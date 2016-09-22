﻿using System;
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
        private Dictionary<string, string> TabSim;
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
                if (context.inicio() != null)
                    return Visit(context.inicio());
                else if (context.proposiciones() != null)
                    return Visit(context.proposiciones());
                else if (context.fin() != null)
                    return Visit(context.fin());
                else
                {
                    token = new StdToken()
                    {
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
                    StepOneError = "Error de sintáxis: Instrucción no válida"
                };
                TokenList.Add(token);
                return token;
            }
            catch (Exception ex)
            {
                token = new StdToken()
                {
                    StepOneError = ex.Message
                };
                TokenList.Add(token);
                return token;
            }
        }

        public override object VisitInicio([NotNull] StdAssemblerParser.InicioContext context)
        {
            string etiqueta, start, dir, h;
            StdToken token;

            etiqueta = string.Empty;
            if (context.etiqueta() != null)
            {
                if (context.children.Count > 5)
                    throw new Exception("Error de sintáxis: Instrucción no válida");
                else
                {
                    etiqueta = Visit(context.etiqueta()) as String;
                    start = context.START().GetText();
                    dir = context.HEXVAL().GetText();
                    h = context.H().GetText();
                    if (start.Contains("missing") || dir.Contains("missing") || h.Contains("missing"))
                        throw new Exception("Error de sintáxis: Instrucción no válida");

                    count = int.Parse(dir, System.Globalization.NumberStyles.HexNumber);
                }
            }
            else
            {
                if (context.children.Count > 4)
                    throw new Exception("Error de sintáxis: Instrucción no válida");
                else
                {
                    start = context.START().GetText();
                    dir = context.HEXVAL().GetText();
                    h = context.H().GetText();
                    if (start.Contains("missing") || dir.Contains("missing") || h.Contains("missing"))
                        throw new Exception("Error de sintáxis: Instrucción no válida");

                    count = int.Parse(dir, System.Globalization.NumberStyles.HexNumber);
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
            string end, inicio;
            StdToken token;
            
            if (context.children.Count > 3)
                throw new Exception("Error de sintáxis: Instrucción no válida");
            else
            {
                end = context.END().GetText();
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
                OperationCode = "END"
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

            if(context.children.Count != 5)
                throw new Exception("Error de sintáxis: Instrucción no válida");
            else 
            {
                ascii = context.ASCIIVAL().GetText();
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
                value = context.HEXVAL().GetText();
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

            if (context.children.Count != 3)
                throw new Exception("Error de sintáxis: Instrucción no válida");
            else
            {
                value = context.HEXVAL().GetText();
                if (context.H().ToString().Contains("missing"))
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
                else
                {
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
            }
        }

        public override object VisitDirResb([NotNull] StdAssemblerParser.DirResbContext context)
        {
            string value;
            StdToken token;

            if (context.children.Count != 3)
                throw new Exception("Error de sintáxis: Instrucción no válida");
            else
            {
                value = context.HEXVAL().GetText();
                if (context.H().ToString().Contains("missing"))
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
                else
                {
                    token = new StdToken()
                    {
                        Address = count,
                        IsDirective = true,
                        IsHex = true,
                        Mode = false,
                        OperationCode = "RESB",
                        Value = value
                    };
                    count += int.Parse(value, System.Globalization.NumberStyles.HexNumber);
                    return token;
                }
            }
        }

        public override object VisitDirResw([NotNull] StdAssemblerParser.DirReswContext context)
        {
            string value;
            StdToken token;

            if (context.children.Count != 3)
                throw new Exception("Error de sintáxis: Instrucción no válida");
            else
            {
                value = context.HEXVAL().GetText();
                if (context.H().ToString().Contains("missing"))
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
                else
                {
                    token = new StdToken()
                    {
                        Address = count,
                        IsDirective = true,
                        IsHex = true,
                        Mode = false,
                        OperationCode = "RESW",
                        Value = value
                    };
                    count += int.Parse(value, System.Globalization.NumberStyles.HexNumber) * 3;
                    return token;
                }
            }
        }

        public override object VisitEtiqueta([NotNull] StdAssemblerParser.EtiquetaContext context)
        {
            if (context.children.FirstOrDefault(c => Regex.IsMatch(c.GetText(), @"^(ADD|AND|COMP|DIV|J|JEQ|JGT|JLT|JSUB|LDA|LDCH|LDL|LDX|MUL|OR|RD|STA|STCH|STL|STSW|STX|SUB|TD|TIX|WD|START|END|RSUB|BYTE|WORD|RESB|RESW)$")) != null)
                throw new Exception("Error de sintáxis: Etiqueta no válida");
            else
                return context.ASCIIVAL().GetText();
        }

        public override object VisitEtiquetaFin(StdAssemblerParser.EtiquetaFinContext context)
        {
            if (context.children.FirstOrDefault(c => Regex.IsMatch(c.GetText(), @"^(ADD|AND|COMP|DIV|J|JEQ|JGT|JLT|JSUB|LDA|LDCH|LDL|LDX|MUL|OR|RD|STA|STCH|STL|STSW|STX|SUB|TD|TIX|WD|START|END|RSUB|BYTE|WORD|RESB|RESW)$")) != null)
                throw new Exception("Error de sintáxis: Etiqueta no válida");
            else
                return context.ASCIIVAL().GetText();
        }

        public string GetCountValue()
        {
            return count.ToString("X");
        }

        public List<KeyValuePair<string, string>> GetTabSim()
        {
            return TabSim.ToList();
        }
    }
}