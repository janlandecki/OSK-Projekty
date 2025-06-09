using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace witam
{
    public static class ProgramIO
    {
        public static List<Instruction> Load(string path)
        {
            var lines = System.IO.File.ReadAllLines(path);
            var list = new List<Instruction>();
            foreach (var (text, idx) in lines.Select((t, i) => (t, i + 1)))
            {
                var trimmed = text.Trim();
                if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith(";"))
                    continue; // komentarz lub pusta

                var parts = trimmed.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                Instruction instr = new Instruction { LineNumber = idx };
                // INTxx
                if (parts[0].StartsWith("INT", StringComparison.OrdinalIgnoreCase))
                {
                    instr.OpCode = OpCode.INT;
                    // np. "INT16" lub "INT16H"
                    var numText = parts[0].Substring(3).TrimEnd('H');
                    instr.InterruptNumber = byte.Parse(numText, NumberStyles.HexNumber);
                }
                else
                {
                    instr.OpCode = (OpCode)Enum.Parse(typeof(OpCode), parts[0], true);
                    instr.Destination = (RegisterRef)Enum.Parse(typeof(RegisterRef), parts[1], true);
                    // czy immediate?
                    if (ushort.TryParse(parts[2], out ushort imm) ||
                        (parts[2].EndsWith("H", StringComparison.OrdinalIgnoreCase)
                         && ushort.TryParse(parts[2].TrimEnd('H'), NumberStyles.HexNumber, null, out imm)))
                    {
                        instr.IsImmediate = true;
                        instr.Immediate = imm;
                    }
                    else
                    {
                        instr.IsImmediate = false;
                        instr.Source = (RegisterRef)Enum.Parse(typeof(RegisterRef), parts[2], true);
                    }
                }
                list.Add(instr);
            }
            return list;
        }

        public static List<Instruction> Parse(string[] lines)
        {
            var list = new List<Instruction>();

            foreach (var line in lines.Select((t, i) => (t, i)))
            {
                var parts = line.t.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length < 3) continue;

                var instr = new Instruction { LineNumber = line.i + 1 };

                instr.OpCode = (OpCode)Enum.Parse(typeof(OpCode), parts[0], true);
                instr.Destination = (RegisterRef)Enum.Parse(typeof(RegisterRef), parts[1], true);

                if (ushort.TryParse(parts[2], out ushort imm))
                {
                    instr.IsImmediate = true;
                    instr.Immediate = imm;
                }
                else
                {
                    instr.IsImmediate = false;
                    instr.Source = (RegisterRef)Enum.Parse(typeof(RegisterRef), parts[2], true);
                }

                list.Add(instr);
            }
            return list;
        }

        public static void Save(string path, IEnumerable<Instruction> program)
        {
            File.WriteAllLines(path, program.Select(i => i.ToString()));
        }
    }
}
