using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace witam
{
    public static class ProgramIO
    {
        public static List<Instruction> Load(string path)
        {
            var lines = File.ReadAllLines(path);
            var list = new List<Instruction>();

            foreach (var line in lines.Select((t, i) => (t, i)))
            {
                var parts = line.t.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length < 3) continue;

                var instr = new Instruction { LineNumber = line.i + 1 };

                // Poprawione parsowanie enumów
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
