using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class CalculatorVisitor : CalculatorBaseVisitor<double>
    {
        public override double VisitDouble(CalculatorParser.DoubleContext context)
        {
            return double.Parse(context.DOUBLE().GetText());
        }

        public override double VisitAddSub(CalculatorParser.AddSubContext context)
        {
            double left = Visit(context.expr(0));
            double right = Visit(context.expr(1));
            if (context.op.Type == CalculatorParser.ADD)
            {
                return left + right;
            }
            else
            {
                return left - right;
            }
        }

        public override double VisitMulDiv(CalculatorParser.MulDivContext context)
        {
            double left = Visit(context.expr(0));
            double right = Visit(context.expr(1));
            if (context.op.Type == CalculatorParser.MUL)
            {
                return left * right;
            }
            else
            {
                return left / right;
            }
        }

        public override double VisitParens(CalculatorParser.ParensContext context)
        {
            return Visit(context.expr());
        }
    }
}
