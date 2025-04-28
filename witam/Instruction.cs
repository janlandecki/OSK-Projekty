using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace witam
{

    public enum OpCode { MOV, ADD, SUB }
    public enum RegisterRef { AX, BX, CX, DX, AH, AL, BH, BL, CH, CL, DH, DL }

    public class Instruction
    {
        public OpCode OpCode { get; set; }
        public RegisterRef Destination { get; set; }
        public RegisterRef Source { get; set; }
        public bool IsImmediate { get; set; }
        public ushort Immediate { get; set; }
        public int LineNumber { get; set; }

        public override string ToString() =>
            $"{LineNumber:000}: {OpCode} {Destination}, {(IsImmediate ? Immediate.ToString() : Source.ToString())}";
    }

}
