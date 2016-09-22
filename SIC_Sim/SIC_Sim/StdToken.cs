using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIC_Sim
{
    class StdToken
    {
        public int Address { get; set; }
        public string Label { get; set; }
        public string OperationCode { get; set; }
        public string Symbol { get; set; }
        public bool Mode { get; set; }
        public string Value { get; set; }
        public bool IsHex { get; set; }
        public bool IsDirective { get; set; }
        public string StepOneError { get; set; }
        public string StepTwoError { get; set; }

        public char[] GetObjectCode()
        {
            string instruction = string.Empty;

            return instruction.ToCharArray();
        }

        private string GetOperationCodeValue()
        {
            string opCode = string.Empty;

            switch(OperationCode)
            {
                case "ADD":
                    opCode = "00011000";
                    break;
                case "AND":
                    opCode = "01000000";
                    break;
                case "COMP":
                    opCode = "00101000";
                    break;
                case "DIV":
                    opCode = "00100100";
                    break;
                case "J":
                    opCode = "00111100";
                    break;
                case "JEQ":
                    opCode = "00110000";
                    break;
                case "JGT":
                    opCode = "00110100";
                    break;
                case "JLT":
                    opCode = "00111000";
                    break;
                case "JSUB":
                    opCode = "01001000";
                    break;
                case "LDA":
                    opCode = "00000000";
                    break;
                case "LDCH":
                    opCode = "01010000";
                    break;
                case "LDL":
                    opCode = "00001000";
                    break;
                case "LDX":
                    opCode = "00000100";
                    break;
                case "MUL":
                    opCode = "00100000";
                    break;
                case "OR":
                    opCode = "01000100";
                    break;
                case "RD":
                    opCode = "11011000";
                    break;
                case "RSUB":
                    opCode = "01001100";
                    break;
                case "STA":
                    opCode = "00001100";
                    break;
                case "STCH":
                    opCode = "01010100";
                    break;
                case "STL":
                    opCode = "00010100";
                    break;
                case "STSW":
                    opCode = "11101000";
                    break;
                case "STX":
                    opCode = "00010000";
                    break;
                case "SUB":
                    opCode = "00011100";
                    break;
                case "TD":
                    opCode = "11100000";
                    break;
                case "TIX":
                    opCode = "00101100";
                    break;
                case "WD":
                    opCode = "11011100";
                    break;
                case "BYTE":
                    opCode = IsHex ? 
                                (Value.Length % 2 == 0 ? Value : "0" + Value) :
                                GetAscii();
                    break;
                case "WORD":
                    opCode = IsHex ?
                                String.Format("{0:D24}", Value) :
                                String.Format("{0:D24}", int.Parse(Value).ToString("X"));
                    break;
                case "START":
                case "END":
                case "RESB":
                case "RESW":
                    opCode = string.Empty;
                    break;
            }
            return opCode;
        }

        private string GetAscii()
        {
            string ascii = string.Empty;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(Value);

            foreach(byte asciiByte in asciiBytes)
            {
                ascii += String.Format("{0:D2}", asciiByte.ToString("X"));
            }
            return ascii;
        }
    }
}
