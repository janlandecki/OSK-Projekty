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
            var lines = File.ReadAllLines(path);
            var list = new List<Instruction>();

            char[] hexSuffix = { 'H', 'h' };

            foreach (var (text, idx) in lines.Select((t, i) => (t, i + 1)))
            {
                var trimmed = text.Trim();
                if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith(";"))
                    continue;

                var parts = trimmed.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                var instr = new Instruction { LineNumber = idx };

 
                if (parts[0].StartsWith("INT", StringComparison.OrdinalIgnoreCase))
                {
                    instr.OpCode = OpCode.INT;
                    string numText;
                    if (parts.Length >= 2)
                        numText = parts[1].TrimEnd(hexSuffix);
                    else
                        numText = parts[0].Substring(3).TrimEnd(hexSuffix);
                    instr.InterruptNumber = byte.Parse(numText, NumberStyles.HexNumber, CultureInfo.InvariantCulture);

                    list.Add(instr);
                    continue;
                }

                instr.OpCode = (OpCode)Enum.Parse(typeof(OpCode), parts[0], true);
                instr.Destination = (RegisterRef)Enum.Parse(typeof(RegisterRef), parts[1], true);

                ushort value;
                string operand = parts[2];

                if (operand.Length >= 2 && operand.StartsWith("'") && operand.EndsWith("'"))
                {
                    instr.IsImmediate = true;
                    instr.Immediate = (byte)operand.Trim('\'')[0];
                }

                else if (ushort.TryParse(operand, out value) ||
                         (operand.EndsWith("H", StringComparison.OrdinalIgnoreCase)
                          && ushort.TryParse(operand.TrimEnd(hexSuffix),
                                             NumberStyles.HexNumber,
                                             CultureInfo.InvariantCulture,
                                             out value)))
                {
                    instr.IsImmediate = true;
                    instr.Immediate = value;
                }
                else
                {
                    instr.IsImmediate = false;
                    instr.Source = (RegisterRef)Enum.Parse(typeof(RegisterRef), operand, true);
                }

                list.Add(instr);
            }

            return list;
        }

        public static List<Instruction> Parse(string[] lines)
        {
            var list = new List<Instruction>();
            char[] hexSuffix = { 'H', 'h' };

            foreach (var (text, idx) in lines.Select((t, i) => (t, i + 1)))
            {
                var trimmed = text.Trim();
                if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith(";"))
                    continue;

                var parts = trimmed.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length < 3)
                    continue;

                var instr = new Instruction { LineNumber = idx };
                instr.OpCode = (OpCode)Enum.Parse(typeof(OpCode), parts[0], true);
                instr.Destination = (RegisterRef)Enum.Parse(typeof(RegisterRef), parts[1], true);

                ushort value;
                string operand = parts[2];

                if (operand.Length >= 2 && operand.StartsWith("'") && operand.EndsWith("'"))
                {
                    instr.IsImmediate = true;
                    instr.Immediate = (byte)operand.Trim('\'')[0];
                }
                else if (ushort.TryParse(operand, out value) ||
                         (operand.EndsWith("H", StringComparison.OrdinalIgnoreCase)
                          && ushort.TryParse(operand.TrimEnd(hexSuffix),
                                             NumberStyles.HexNumber,
                                             CultureInfo.InvariantCulture,
                                             out value)))
                {
                    instr.IsImmediate = true;
                    instr.Immediate = value;
                }
                else
                {
                    instr.IsImmediate = false;
                    instr.Source = (RegisterRef)Enum.Parse(typeof(RegisterRef), operand, true);
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
