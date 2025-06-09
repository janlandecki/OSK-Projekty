using System;
using System.Collections.Generic;
using System.Threading;

namespace witam
{
    class Cpu
    {
        public ushort AX { get; set; }
        public ushort BX { get; set; }
        public ushort CX { get; set; }
        public ushort DX { get; set; }

        public byte AH
        {
            get => (byte)(AX >> 8);
            set => AX = (ushort)((AX & 0x00FF) | (value << 8));
        }
        public byte AL
        {
            get => (byte)(AX & 0x00FF);
            set => AX = (ushort)((AX & 0xFF00) | value);
        }

        public byte BH { get => (byte)(BX >> 8); set => BX = (ushort)((BX & 0x00FF) | (value << 8)); }
        public byte BL { get => (byte)(BX & 0x00FF); set => BX = (ushort)((BX & 0xFF00) | value); }
        public byte CH { get => (byte)(CX >> 8); set => CX = (ushort)((CX & 0x00FF) | (value << 8)); }
        public byte CL { get => (byte)(CX & 0x00FF); set => CX = (ushort)((CX & 0xFF00) | value); }
        public byte DH { get => (byte)(DX >> 8); set => DX = (ushort)((DX & 0x00FF) | (value << 8)); }
        public byte DL { get => (byte)(DX & 0x00FF); set => DX = (ushort)((DX & 0xFF00) | value); }

        // Stos
        private const int StackSize = 1024;
        private short[] STOS = new short[StackSize];
        private int SP = StackSize - 1;

        // Program
        private List<Instruction> program = new List<Instruction>();
        public int IP { get; private set; } = 0;

        public void LoadProgram(List<Instruction> prog)
        {
            program = prog;
            IP = 0;
        }

        public void Reset()
        {
            AX = BX = CX = DX = 0;
            SP = StackSize - 1;
            IP = 0;
        }

        public void Push(ushort val)
        {
            if (SP < 0) throw new StackOverflowException();
            STOS[SP--] = (short)val;
        }

        public ushort Pop()
        {
            if (SP >= StackSize - 1) throw new InvalidOperationException("Stos pusty");
            return (ushort)STOS[++SP];
        }

        public bool Step()
        {
            if (IP >= program.Count) return false;
            var instr = program[IP++];
            Execute(instr);
            return true;
        }

        public void Run()
        {
            while (IP < program.Count)
                Step();
        }

        private void Execute(Instruction instr)
        {
            ushort value;
            switch (instr.OpCode)
            {
                case OpCode.MOV:
                    value = instr.IsImmediate ? instr.Immediate : GetRegister(instr.Source);
                    SetRegister(instr.Destination, value);
                    break;
                case OpCode.ADD:
                    value = GetRegister(instr.Destination);
                    value = (ushort)(value + (instr.IsImmediate ? instr.Immediate : GetRegister(instr.Source)));
                    SetRegister(instr.Destination, value);
                    break;
                case OpCode.SUB:
                    value = GetRegister(instr.Destination);
                    value = (ushort)(value - (instr.IsImmediate ? instr.Immediate : GetRegister(instr.Source)));
                    SetRegister(instr.Destination, value);
                    break;
                case OpCode.INT:
                    Push(AX); Push(BX); Push(CX); Push(DX);
                    HandleInterrupt(instr.InterruptNumber);
                    DX = Pop(); CX = Pop(); BX = Pop(); AX = Pop();
                    break;
                default:
                    throw new InvalidOperationException("Nieznana instrukcja");
            }
        }

        private void HandleInterrupt(byte num)
        {
            switch (num)
            {
                case 0x10: // Video
                    if (AH == 0x0E) VideoTeletypeOutput();
                    break;
                case 0x11: // Equipment list
                    if (AH == 0x00) GetEquipmentList();
                    break;
                case 0x12: // Memory size
                    if (AH == 0x00) GetMemorySize();
                    break;
                case 0x13: // Disk
                    if (AH == 0x02) DiskReadSectors();
                    break;
                case 0x15: // System
                    if (AH == 0x86) WaitMilliSeconds();
                    break;
                case 0x16: // Keyboard
                    if (AH == 0x10) ReadKeyboard();
                    break;
                case 0x17: // Printer
                    if (AH == 0x00) PrinterPrintChar();
                    break;
                case 0x19: // Bootstrap
                    if (AH == 0x00) BootstrapLoader();
                    break;
                case 0x1A: // RTC
                    if (AH == 0x02) GetRTCTime();
                    else if (AH == 0x03) SetRTCTime();
                    break;
                case 0x21: // DOS
                    if (AH == 0x09) DosDisplayString();
                    break;
                default:
                    throw new InvalidOperationException($"Nieobsługiwane przerwanie INT{num:X2}");
            }
        }

        // Symulacje przerwań

        private void VideoTeletypeOutput()
        {
            char c = (char)AL;
            Console.WriteLine($"[INT10h] VideoTeletypeOutput – znak: '{c}'");
        }

        private void GetEquipmentList()
        {
            AX = 0x002F;
            Console.WriteLine($"[INT11h] GetEquipmentList – equipment flags = 0x{AX:X4}");
        }

        private void GetMemorySize()
        {
            AX = 640;
            Console.WriteLine($"[INT12h] GetMemorySize – conventional memory = {AX} KB");
        }

        private void DiskReadSectors()
        {
            AH = 0x00;
            Console.WriteLine(
                $"[INT13h] DiskReadSectors – sectors={AL}, cylinder={CH}, sector={CL}, head={DH}, drive={DL} -> AH(success)=0x{AH:X2}");
        }

        private void WaitMilliSeconds()
        {
            int ms = (CX << 16) | DX;
            Console.WriteLine($"[INT15h] WaitMilliSeconds – sleeping for {ms} ms");
            Thread.Sleep(ms);
            Console.WriteLine($"[INT15h] WaitMilliSeconds – wake up");
        }

        private void ReadKeyboard()
        {
            AL = (byte)'A'; AH = 0x1E;
            Console.WriteLine($"[INT16h] ReadKeyboard – char='{(char)AL}', scan code=0x{AH:X2}");
        }

        private void PrinterPrintChar()
        {
            Console.WriteLine($"[INT17h] PrinterPrintChar – port={DX}, char='{(char)AL}'");
            AH = 0x00;
            Console.WriteLine($"[INT17h] PrinterPrintChar – status AH(success)=0x{AH:X2}");
        }

        private void BootstrapLoader()
        {
            Console.WriteLine("[INT19h] BootstrapLoader – bootloader called");
        }

        private void GetRTCTime()
        {
            var now = DateTime.Now;
            CH = (byte)now.Hour;
            CL = (byte)now.Minute;
            DH = (byte)now.Second;
            Console.WriteLine($"[INT1Ah] GetRTCTime – time = {CH:D2}:{CL:D2}:{DH:D2}");
        }

        private void SetRTCTime()
        {
            Console.WriteLine($"[INT1Ah] SetRTCTime – simulated set to {CH:D2}:{CL:D2}:{DH:D2}");
        }

        private void DosDisplayString()
        {
            Console.WriteLine("[INT21h] DosDisplayString – displaying string (simulated)");
        }



        private ushort GetRegister(RegisterRef r)
        {
            switch (r)
            {
                case RegisterRef.AX: return AX;
                case RegisterRef.BX: return BX;
                case RegisterRef.CX: return CX;
                case RegisterRef.DX: return DX;
                case RegisterRef.AH: return AH;
                case RegisterRef.AL: return AL;
                case RegisterRef.BH: return BH;
                case RegisterRef.BL: return BL;
                case RegisterRef.CH: return CH;
                case RegisterRef.CL: return CL;
                case RegisterRef.DH: return DH;
                case RegisterRef.DL: return DL;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        private void SetRegister(RegisterRef r, ushort val)
        {
            switch (r)
            {
                case RegisterRef.AX: AX = val; break;
                case RegisterRef.BX: BX = val; break;
                case RegisterRef.CX: CX = val; break;
                case RegisterRef.DX: DX = val; break;
                case RegisterRef.AH: AH = (byte)val; break;
                case RegisterRef.AL: AL = (byte)val; break;
                case RegisterRef.BH: BH = (byte)val; break;
                case RegisterRef.BL: BL = (byte)val; break;
                case RegisterRef.CH: CH = (byte)val; break;
                case RegisterRef.CL: CL = (byte)val; break;
                case RegisterRef.DH: DH = (byte)val; break;
                case RegisterRef.DL: DL = (byte)val; break;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public void Dydaktyczny()
        {
            Console.WriteLine("[Dydaktyczny] Opis funkcji przerwań:");
            Console.WriteLine("INT 10h (Video): AH=0Eh, AL=znak -> wypisuje znak na ekranie");
            Console.WriteLine("INT 11h (Equipment): AH=00h -> zwraca listę sprzętu w AX");
            Console.WriteLine("INT 12h (Memory): AH=00h -> zwraca ilość pamięci w AX");
            Console.WriteLine("INT 13h (Disk): AH=02h -> czyta sektory z dysku");
            Console.WriteLine("INT 15h (System): AH=86h -> czeka określoną liczbę ms (CX:DX)");
            Console.WriteLine("INT 16h (Keyboard): AH=10h -> odczytuje znak z klawiatury");
            Console.WriteLine("INT 17h (Printer): AH=00h -> drukuje znak (AL)");
            Console.WriteLine("INT 19h (Bootstrap): AH=00h -> uruchamia bootloader");
            Console.WriteLine("INT 1Ah (RTC): AH=02h/03h -> odczyt/ustawienie czasu (CH,CL,DH)");
            Console.WriteLine("INT 21h (DOS): AH=09h -> wyświetla napis (symulacja)");
        }

        public void Demonstracyjny()
        {
            Console.WriteLine("[Demonstracyjny] Uruchamiam demo przerwań...");
            LoadProgram(new List<Instruction> {
                new Instruction { LineNumber = 1, OpCode=OpCode.INT, InterruptNumber=0x10, AH=0x0E, AL=(byte)'X' },
                new Instruction { LineNumber = 2, OpCode=OpCode.INT, InterruptNumber=0x11, AH=0x00 },
                new Instruction { LineNumber = 3, OpCode=OpCode.INT, InterruptNumber=0x12, AH=0x00 },
                new Instruction { LineNumber = 4, OpCode=OpCode.INT, InterruptNumber=0x13, AH=0x02 },
                new Instruction { LineNumber = 5, OpCode=OpCode.INT, InterruptNumber=0x15, AH=0x86, CX=0, DX=100 },
                new Instruction { LineNumber = 6, OpCode=OpCode.INT, InterruptNumber=0x16, AH=0x10 },
                new Instruction { LineNumber = 7, OpCode=OpCode.INT, InterruptNumber=0x17, AH=0x00, AL=(byte)'P' },
                new Instruction { LineNumber = 8, OpCode=OpCode.INT, InterruptNumber=0x19, AH=0x00 },
                new Instruction { LineNumber = 9, OpCode=OpCode.INT, InterruptNumber=0x1A, AH=0x02 },
                new Instruction { LineNumber = 10, OpCode=OpCode.INT, InterruptNumber=0x21, AH=0x09 }
            });
            Run();
            Console.WriteLine("[Demonstracyjny] Demo zakończone.");
        }
    }
}