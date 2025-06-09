using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace witam
{

    public enum OpCode { MOV, ADD, SUB, INT }
    public enum RegisterRef { AX, BX, CX, DX, AH, AL, BH, BL, CH, CL, DH, DL }

    public class Instruction
    {
        public OpCode OpCode { get; set; }
        public RegisterRef Destination { get; set; }
        public RegisterRef Source { get; set; }
        public bool IsImmediate { get; set; }
        public ushort Immediate { get; set; }
        public int LineNumber { get; set; }
        public byte InterruptNumber { get; set; }

        public byte AH { get; set; }
        public byte AL { get; set; }
        public ushort CX { get; set; }
        public ushort DX { get; set; }


        public override string ToString()
        {
            if (OpCode == OpCode.INT)
                return $"{LineNumber:000}: INT{InterruptNumber:X2}h";

            var src = IsImmediate ? Immediate.ToString(CultureInfo.InvariantCulture) : Source.ToString();
            return $"{LineNumber:000}: {OpCode} {Destination}, {src}";
        }
    }

}
