using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

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
        // analogicznie BH, BL, CH, CL, DH, DL
        public byte BH { get => (byte)(BX >> 8); set => BX = (ushort)((BX & 0x00FF) | (value << 8)); }
        public byte BL { get => (byte)(BX & 0x00FF); set => BX = (ushort)((BX & 0xFF00) | value); }
        public byte CH { get => (byte)(CX >> 8); set => CX = (ushort)((CX & 0x00FF) | (value << 8)); }
        public byte CL { get => (byte)(CX & 0x00FF); set => CX = (ushort)((CX & 0xFF00) | value); }
        public byte DH { get => (byte)(DX >> 8); set => DX = (ushort)((DX & 0x00FF) | (value << 8)); }
        public byte DL { get => (byte)(DX & 0x00FF); set => DX = (ushort)((DX & 0xFF00) | value); }

        private List<Instruction> program = new List<Instruction>();
        public int InstructionPointer { get; private set; } = 0;

        public void LoadProgram(List<Instruction> prog)
        {
            program = prog;
            InstructionPointer = 0;
        }

        public void Reset()
        {
            AX = BX = CX = DX = 0;
            InstructionPointer = 0;
        }

        public bool Step()
        {
            if (InstructionPointer < 0 || InstructionPointer >= program.Count)
                return false;
            var instr = program[InstructionPointer++];
            Execute(instr);
            return true;
        }

        public void Run()
        {
            while (Step()) { }
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
                default:
                    throw new InvalidOperationException("Nieznana instrukcja");
            }
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
    }
}
