using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public bool IsEmpty { get; set; }
        public string Text { get; set; }

        public StdToken()
        {
            IsEmpty = false;
        }

        public char[] GetObjectCode()
        {
            string instruction = string.Empty;

            return instruction.ToCharArray();
        }

        public string GetOperationCodeValue(Dictionary<string, string> tabsim)
        {
            string opCode = string.Empty;

            if(((StepOneError == string.Empty) || (StepOneError == null)) && (!IsEmpty))
                switch(OperationCode)
                {
                    case "ADD":
                        opCode = "00011000" + (Mode?"1":"0") + Convert.ToString(getSimbolAddress(tabsim,Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6,'0');
                        break;
                    case "AND":
                        opCode = "01000000" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "COMP":
                        opCode = "00101000" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "DIV":
                        opCode = "00100100" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "J":
                        opCode = "00111100" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "JEQ":
                        opCode = "00110000" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "JGT":
                        opCode = "00110100" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "JLT":
                        opCode = "00111000" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "JSUB":
                        opCode = "01001000" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "LDA":
                        opCode = "00000000" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "LDCH":
                        opCode = "01010000" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "LDL":
                        opCode = "00001000" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "LDX":
                        opCode = "00000100" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "MUL":
                        opCode = "00100000" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "OR":
                        opCode = "01000100" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "RD":
                        opCode = "11011000" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "RSUB":
                        opCode = "010011000000000000000000";
                        opCode = Convert.ToInt32(opCode, 2).ToString("X");
                        break;
                    case "STA":
                        opCode = "00001100" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "STCH":
                        opCode = "01010100" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "STL":
                        opCode = "00010100" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "STSW":
                        opCode = "11101000" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "STX":
                        opCode = "00010000" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "SUB":
                        opCode = "00011100" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "TD":
                        opCode = "11100000" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "TIX":
                        opCode = "00101100" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "WD":
                        opCode = "11011100" + (Mode ? "1" : "0") + Convert.ToString(getSimbolAddress(tabsim, Symbol), 2).PadLeft(15, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6, '0');
                        break;
                    case "BYTE":
                        opCode = IsHex ? 
                                    (Value.Length % 2 == 0 ? Value : "0" + Value) :
                                    GetAscii();
                        break;
                    case "WORD":
                        opCode = Convert.ToString(int.Parse(Regex.Replace(Value, @"(H|h)", ""), System.Globalization.NumberStyles.HexNumber), 2).PadLeft(24, '0');
                        opCode = Convert.ToInt32(opCode, 2).ToString("X").PadLeft(6,'0');
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

        public int getSimbolAddress(Dictionary<string, string> TabSim, string simbolo)
        {
            string sim;

            sim = TabSim.FirstOrDefault(s => s.Key == simbolo).Value;

            if (sim != null)
            {
                return int.Parse(sim, System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                StepTwoError = "Símbolo no encontrado";
                return 32767;
            }
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
