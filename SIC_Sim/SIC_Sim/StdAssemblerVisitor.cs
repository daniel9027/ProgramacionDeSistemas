using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
using System.Text.RegularExpressions;

namespace SIC_Sim
{
    class StdAssemblerVisitor : StdAssemblerBaseVisitor<object>
    {
        public List<string> errors;
        private int count;
        public Dictionary<string, string> TabSim;
        private List<StdToken> TokenList;
        
        public StdAssemblerVisitor()
        {
            errors = new List<string>();
            count = 0;
            TabSim = new Dictionary<string, string>();
            TokenList = new List<StdToken>();
        }

        public override object VisitLinea(StdAssemblerParser.LineaContext context)
        {
            StdToken token;

            try
            {
                if(context.exception != null)
                    throw new Exception("Error de sintáxis: Instrucción no válida");
                if (context.inicio() != null)
                    return Visit(context.inicio());
                else if (context.proposiciones() != null)
                    return Visit(context.proposiciones());
                else if (context.fin() != null)
                    return Visit(context.fin());
                else if (context.NL() != null)
                {
                    token = new StdToken()
                    {
                        IsEmpty = true
                    };
                    TokenList.Add(token);
                    return token;
                }
                else
                {
                    token = new StdToken()
                    {
                        Address = count,
                        StepOneError = "Error de sintáxis: Instrucción no válida"
                    };
                    TokenList.Add(token);
                    return token;
                }
            }
            catch (NullReferenceException)
            {
                token = new StdToken()
                {
                    Address = count,
                    StepOneError = "Error de sintáxis: Instrucción no válida",
                };
                TokenList.Add(token);
                return token;
            }
            catch (Exception ex)
            {
                token = new StdToken()
                {
                    Address = count,
                    StepOneError = ex.Message
                };
                TokenList.Add(token);
                return token;
            }
        }

        public override object VisitInicio([NotNull] StdAssemblerParser.InicioContext context)
        {
            string etiqueta, start, dir;
            StdToken token;

            etiqueta = string.Empty;
            if (context.etiqueta() != null)
            {
                if (context.children.Count > 4)
                    throw new Exception("Error de sintáxis: Instrucción no válida");
                else
                {
                    etiqueta = Visit(context.etiqueta()) as String;
                    start = context.START().GetText();
                    dir = context.VAL().GetText();
                    if (!Regex.IsMatch(dir, @"^[0-9A-F]{4}(H|h)$"))
                        throw new Exception("Error de sintáxis: ingrese una dirección hexadecimal");
                    if (start.Contains("missing") || dir.Contains("missing"))
                        throw new Exception("Error de sintáxis: Instrucción no válida");
                    count = int.Parse(Regex.Replace(dir, "(H|h)", ""), System.Globalization.NumberStyles.HexNumber);
                }
            }
            else
            {
                if (context.children.Count > 3)
                    throw new Exception("Error de sintáxis: Instrucción no válida");
                else
                {
                    start = context.START().GetText();
                    dir = context.VAL().GetText();
                    if (!Regex.IsMatch(dir, @"^[0-9A-F]{4}(H|h)$"))
                        throw new Exception("Error de sintáxis: ingrese una dirección hexadecimal");
                    if (start.Contains("missing") || dir.Contains("missing"))
                        throw new Exception("Error de sintáxis: Instrucción no válida");
                    count = int.Parse(Regex.Replace(dir, @"(H|h)", ""), System.Globalization.NumberStyles.HexNumber);
                }
            }
            token = new StdToken()
            {
                Address = count,
                IsDirective = true,
                IsHex = true,
                Label = etiqueta,
                Mode = false,
                OperationCode = "START",
                Value = dir
            };
            TokenList.Add(token);
            return token;
        }

        public override object VisitFin([NotNull] StdAssemblerParser.FinContext context)
        {
            string end, inicio, dir;
            StdToken token;
            
            if (context.children.Count > 3)
                throw new Exception("Error de sintáxis: Instrucción no válida");
            else
            {
                end = context.END().GetText();
                dir = context.etiquetaFin().GetText();
                inicio = Visit(context.etiquetaFin()) as String;
                if (end.Contains("missing") || inicio.Contains("missing"))
                    throw new Exception("Error de sintáxis: Instrucción no válida");
            }
            token = new StdToken()
            {
                Address = count,
                IsDirective = true,
                IsHex = false,
                Mode = false,
                OperationCode = "END",
                Value = dir
            };
            TokenList.Add(token);
            return token;
        }

        public override object VisitProposiciones([NotNull] StdAssemblerParser.ProposicionesContext context)
        {
            if (context.proposiciones() != null)
                return Visit(context.proposiciones());
            if (context.proposicion() != null)
                return Visit(context.proposicion());

            throw new Exception("Error de sintáxis: Instrucción no válida");
        }

        public override object VisitPropInstr([NotNull] StdAssemblerParser.PropInstrContext context)
        {
            string etiqueta = string.Empty;
            StdToken token;

            if (context.NL().ToString().Contains("missing"))
                throw new Exception("Error de sintáxis: Instrucción no válida");
            else
            {
                if (context.etiqueta() != null)
                {
                    etiqueta = Visit(context.etiqueta()) as String;
                    if (TabSim.FirstOrDefault(s => s.Key == etiqueta).Value == null)
                        TabSim.Add(etiqueta, count.ToString("X"));
                }
                else if (context.children.Count > 2)
                    throw new Exception("Error de sintáxis: Instrucción no válida");

                token = Visit(context.instruccion()) as StdToken;
                token.Label = etiqueta;
                TokenList.Add(token);
                count += 3;
                return token;
            }
        }

        public override object VisitPropDir([NotNull] StdAssemblerParser.PropDirContext context)
        {
            string etiqueta;
            StdToken token;

            etiqueta = string.Empty;
            if(context.exception != null)
                throw new Exception("Error de sintáxis: Instrucción no válida");
            if (context.NL().ToString().Contains("missing"))
                throw new Exception("Error de sintáxis: Instrucción no válida");
            else
            {
                if (context.etiqueta() != null)
                {
                    etiqueta = Visit(context.etiqueta()) as String;
                    if (TabSim.FirstOrDefault(s => s.Key == etiqueta).Value == null)
                        TabSim.Add(etiqueta, count.ToString("X"));
                }
                else if (context.children.Count > 2)
                    throw new Exception("Error de sintáxis: Instrucción no válida");

                token = Visit(context.directiva()) as StdToken;
                token.Label = etiqueta;
                TokenList.Add(token);
                return token;
            }
        }

        public override object VisitCodOp([NotNull] StdAssemblerParser.CodOpContext context)
        {
            string codOp, etiqueta;
            StdToken token;
            Boolean index = false;

            codOp = context.CODOP().GetText();
            etiqueta = Visit(context.etiqueta()) as String;
            if (context.COMA() != null && context.HEX() != null)
                index = true;

            token = new StdToken()
            {
                Address = count,
                IsDirective = false,
                IsHex = false,
                Mode = index,
                OperationCode = codOp,
                Symbol = etiqueta
            };
            return token;
        }

        public override object VisitRSub([NotNull] StdAssemblerParser.RSubContext context)
        {
            StdToken token; 
            string codOp;

            codOp = context.RSUB().GetText();
            token = new StdToken()
            {
                Address = count,
                IsHex = false,
                IsDirective = false,
                Mode = false,
                OperationCode = "RSUB"
            };
            return token;
        }

        public override object VisitDirByteChar([NotNull] StdAssemblerParser.DirByteCharContext context)
        {
            string ascii;
            StdToken token;

            
            {
                ascii = Regex.Match(context.start.InputStream.ToString(), @"\'([\x00-\xFF])+\'").Value.Replace("'", "");
                token = new StdToken()
                {
                    Address = count,
                    IsDirective = true,
                    IsHex = false,
                    Mode = false,
                    OperationCode = "BYTE",
                    Value = ascii
                };
                count += ascii.Length;
                return token;
            }
        }

        public override object VisitDirByteHex([NotNull] StdAssemblerParser.DirByteHexContext context)
        {
            string value;
            StdToken token;

            if (context.children.Count != 5)
                throw new Exception("Error de sintáxis: Instrucción no válida");
            else
            {
                value = context.VAL().GetText();
                    if (!Regex.IsMatch(value, @"^[0-9A-F]+$"))
                        throw new Exception("Error de sintáxis: ingrese un valor hexadecimal");
                token = new StdToken()
                {
                    Address = count,
                    IsDirective = true,
                    IsHex = true,
                    Mode = false,
                    OperationCode = "BYTE",
                    Value = value
                };
                count += int.Parse(Math.Ceiling((double)value.Length / 2).ToString());
                return token;
            }
        }

        public override object VisitDirWord([NotNull] StdAssemblerParser.DirWordContext context)
        {
            string value;
            StdToken token;

            if (context.children.Count != 2)
                throw new Exception("Error de sintáxis: Instrucción no válida");
            else
            {
                value = context.VAL().GetText();
                if (Regex.IsMatch(value, @"(H|h)"))
                {
                    if (!Regex.IsMatch(value, @"^[0-9A-F]+(H|h)$"))
                        throw new Exception("Error de sintáxis: ingrese una dirección hexadecimal");

                    token = new StdToken()
                    {
                        Address = count,
                        IsDirective = true,
                        IsHex = true,
                        Mode = false,
                        OperationCode = "WORD",
                        Value = value
                    };
                    count += 3;
                    return token;
                }
                else
                {
                    if (Regex.IsMatch(value, "^[0-9]+$"))
                    {
                        value = int.Parse(value).ToString("X");
                        token = new StdToken()
                        {
                            Address = count,
                            IsDirective = true,
                            IsHex = false,
                            Mode = false,
                            OperationCode = "WORD",
                            Value = value
                        };
                        count += 3;
                        return token;
                    }
                    else
                        throw new Exception("Error de sintáxis: Instrucción no válida");
                }
            }
        }

        public override object VisitDirResb([NotNull] StdAssemblerParser.DirResbContext context)
        {
            string value;
            StdToken token;

            if (context.children.Count != 2)
                throw new Exception("Error de sintáxis: Instrucción no válida");
            else
            {
                value = context.VAL().GetText();
                if (Regex.IsMatch(value, @"(H|h)"))
                {
                    if (!Regex.IsMatch(value, @"^[0-9A-F]+(H|h)$"))
                        throw new Exception("Error de sintáxis: ingrese una dirección hexadecimal");

                    token = new StdToken()
                    {
                        Address = count,
                        IsDirective = true,
                        IsHex = true,
                        Mode = false,
                        OperationCode = "RESB",
                        Value = value
                    };
                    count += int.Parse(Regex.Replace(value, @"(H|h)", ""), System.Globalization.NumberStyles.HexNumber);
                    return token;
                }
                else
                {
                    if (Regex.IsMatch(value, "^[0-9]+$"))
                    {
                        token = new StdToken()
                        {
                            Address = count,
                            IsDirective = true,
                            IsHex = false,
                            Mode = false,
                            OperationCode = "RESB",
                            Value = value
                        };
                        count += int.Parse(value);
                        return token;
                    }
                    else
                        throw new Exception("Error de sintáxis: Instrucción no válida");
                }
            }
        }

        public override object VisitDirResw([NotNull] StdAssemblerParser.DirReswContext context)
        {
            string value;
            StdToken token;

            if (context.children.Count != 2)
                throw new Exception("Error de sintáxis: Instrucción no válida");
            else
            {
                value = context.VAL().GetText();
                if (Regex.IsMatch(value, @"(H|h)"))
                {
                    if (!Regex.IsMatch(value, @"^[0-9A-F]+(H|h)$"))
                        throw new Exception("Error de sintáxis: ingrese una dirección hexadecimal");

                    token = new StdToken()
                    {
                        Address = count,
                        IsDirective = true,
                        IsHex = true,
                        Mode = false,
                        OperationCode = "RESW",
                        Value = value
                    };
                    count += int.Parse(Regex.Replace(value, @"(H|h)", ""), System.Globalization.NumberStyles.HexNumber) * 3;
                    return token;
                }
                else
                {
                    if (Regex.IsMatch(value, "^[0-9]+$"))
                    {
                        token = new StdToken()
                        {
                            Address = count,
                            IsDirective = true,
                            IsHex = false,
                            Mode = false,
                            OperationCode = "RESW",
                            Value = value
                        };
                        count += int.Parse(value) * 3;
                        return token;
                    }
                    else
                        throw new Exception("Error de sintáxis: Instrucción no válida");
                }
            }
        }

        public override object VisitEtiqueta([NotNull] StdAssemblerParser.EtiquetaContext context)
        {
            if (context.children.FirstOrDefault(c => Regex.IsMatch(c.GetText(), @"^(ADD|AND|COMP|DIV|J|JEQ|JGT|JLT|JSUB|LDA|LDCH|LDL|LDX|MUL|OR|RD|STA|STCH|STL|STSW|STX|SUB|TD|TIX|WD|START|END|RSUB|BYTE|WORD|RESB|RESW)$")) != null)
                throw new Exception("Error de sintáxis: Etiqueta no válida");
            else
                return context.VAL().GetText();
        }

        public override object VisitEtiquetaFin(StdAssemblerParser.EtiquetaFinContext context)
        {
            if (context.children.FirstOrDefault(c => Regex.IsMatch(c.GetText(), @"^(ADD|AND|COMP|DIV|J|JEQ|JGT|JLT|JSUB|LDA|LDCH|LDL|LDX|MUL|OR|RD|STA|STCH|STL|STSW|STX|SUB|TD|TIX|WD|START|END|RSUB|BYTE|WORD|RESB|RESW)$")) != null)
                throw new Exception("Error de sintáxis: Etiqueta no válida");
            else
                return context.VAL().GetText();
        }

        public string GetCountValue()
        {
            return count.ToString("X");
        }

        public List<KeyValuePair<string, string>> GetTabSim()
        {
            return TabSim.ToList();
        }

        public List<StdToken> GetTokens() {
            return TokenList;
        }
    }
}
