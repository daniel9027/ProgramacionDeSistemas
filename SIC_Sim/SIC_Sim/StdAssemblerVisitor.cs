using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;

namespace SIC_Sim
{
    class StdAssemblerVisitor : StdAssemblerBaseVisitor<object>
    {
        public List<string> errors;

        public StdAssemblerVisitor()
        {
            errors = new List<string>();
        }
        public override object VisitInicio([NotNull] StdAssemblerParser.InicioContext context)
        {
            string etiqueta, start, dir, h;

            if(context.etiqueta() != null)
                etiqueta = Visit(context.etiqueta()) as String;
            start = context.START().GetText();
            dir = context.DIR().GetText();
            h = context.H().GetText();
            return string.Empty;
        }

        public override object VisitFin([NotNull] StdAssemblerParser.FinContext context)
        {
            return string.Empty;
        }

        public override object VisitProposiciones([NotNull] StdAssemblerParser.ProposicionesContext context)
        {
            if (context.proposiciones() != null)
                Visit(context.proposiciones());
            if (context.proposicion() != null)
                Visit(context.proposicion());

            return string.Empty;
        }

        public override object VisitInstruccion([NotNull] StdAssemblerParser.InstruccionContext context)
        {
            return string.Empty;
        }

        public override object VisitDirectiva([NotNull] StdAssemblerParser.DirectivaContext context)
        {
            return string.Empty;
        }

        public override object VisitPropInstr([NotNull] StdAssemblerParser.PropInstrContext context)
        {
            string etiqueta;
            bool index;

            if (context.etiqueta() != null)
                etiqueta = Visit(context.etiqueta()) as String;
            index = (bool) (Visit(context.instruccion()));

            return string.Empty;
        }

        public override object VisitPropDir([NotNull] StdAssemblerParser.PropDirContext context)
        {
            string etiqueta, count;

            if (context.etiqueta() != null)
                etiqueta = Visit(context.etiqueta()) as String;
            count = Visit(context.directiva()) as String;

            return string.Empty;
        }

        public override object VisitCodOp([NotNull] StdAssemblerParser.CodOpContext context)
        {
            string codOp, etiqueta;
            Boolean index = false;

            codOp = context.CODOP().GetText();
            etiqueta = context.etiqueta().GetText();
            if (context.COMA() != null && context.HEX() != null)
                index = true;

            return index;
        }

        public override object VisitRSub([NotNull] StdAssemblerParser.RSubContext context)
        {
            string codOp;

            codOp = context.RSUB().GetText();
            return "0003";
        }

        public override object VisitDirByteChar([NotNull] StdAssemblerParser.DirByteCharContext context)
        {
            return string.Empty;
        }

        public override object VisitDirByteHex([NotNull] StdAssemblerParser.DirByteHexContext context)
        {
            return string.Empty;
        }

        public override object VisitDirWordHex([NotNull] StdAssemblerParser.DirWordHexContext context)
        {
            return string.Empty;
        }

        public override object VisitDirWordInt([NotNull] StdAssemblerParser.DirWordIntContext context)
        {
            return string.Empty;
        }

        public override object VisitDirResbHex([NotNull] StdAssemblerParser.DirResbHexContext context)
        {
            return string.Empty;
        }

        public override object VisitDirResbInt([NotNull] StdAssemblerParser.DirResbIntContext context)
        {
            return string.Empty;
        }

        public override object VisitDirReswHex([NotNull] StdAssemblerParser.DirReswHexContext context)
        {
            return string.Empty;
        }

        public override object VisitDirReswInt([NotNull] StdAssemblerParser.DirReswIntContext context)
        {
            return string.Empty;
        }

        public override object VisitEtiqueta([NotNull] StdAssemblerParser.EtiquetaContext context)
        {
            return context.ASCIIVAL().GetText();
        }
    }
}
