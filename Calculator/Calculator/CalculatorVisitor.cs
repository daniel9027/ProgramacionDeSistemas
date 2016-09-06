using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class CalculatorVisitor : CalculatorBaseVisitor<double>
    {
        Dictionary<string, double> memory;

        public CalculatorVisitor()
        {
            memory = new Dictionary<string, double>();
        }
        /*public override double VisitDouble(CalculatorParser.DoubleContext context)
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
        }*/

        #region atom
        public override double VisitBraces(CalculatorParser.BracesContext context)
        {
            return Visit(context.plusOrMinus());
        }

        public override double VisitVariable(CalculatorParser.VariableContext context)
        {
            string id = context.ID().GetText();
            double val = 0;

            if (memory.FirstOrDefault(m => m.Key == id).Key == null)
            {
                memory.Add(id, val);
            }
            else
            {
                val = memory[id];
            }
            return val;
        }

        public override double VisitInt(CalculatorParser.IntContext context)
        {
            return double.Parse(context.INT().GetText());
        }

        public override double VisitDouble(CalculatorParser.DoubleContext context)
        {
            return double.Parse(context.DOUBLE().GetText());
        }

        public override double VisitConstantE(CalculatorParser.ConstantEContext context)
        {
            return Math.E;
        }

        public override double VisitConstantPI(CalculatorParser.ConstantPIContext context)
        {
            return Math.PI;
        }
        #endregion

        #region unaryMinus
        public override double VisitToAtom(CalculatorParser.ToAtomContext context)
        {
            return Visit(context.atom());
        }

        public override double VisitChangeSign(CalculatorParser.ChangeSignContext context)
        {
            return ( -1.0d * Visit(context.unaryMinus()) );
        }
        #endregion

        #region pow
        public override double VisitPower(CalculatorParser.PowerContext context)
        {
            return context.ChildCount == 1 ? 
                Visit(context.unaryMinus()): 
                Math.Pow( Visit(context.unaryMinus()), Visit(context.pow()) );
        }
        #endregion

        #region multOrDiv
        public override double VisitMultiplication(CalculatorParser.MultiplicationContext context)
        {
            return (Visit(context.multOrDiv()) * Visit(context.pow()));
        }

        public override double VisitDivision(CalculatorParser.DivisionContext context)
        {
            return (Visit(context.multOrDiv()) / Visit(context.pow()));
        }

        public override double VisitToPow(CalculatorParser.ToPowContext context)
        {
            return Visit(context.pow());
        }
        #endregion

        #region plusOrMinus
        public override double VisitPlus(CalculatorParser.PlusContext context)
        {
            return (Visit(context.plusOrMinus()) + Visit(context.multOrDiv()));
        }

        public override double VisitMinus(CalculatorParser.MinusContext context)
        {
            return (Visit(context.plusOrMinus()) - Visit(context.multOrDiv()));
        }

        public override double VisitToMultOrDiv(CalculatorParser.ToMultOrDivContext context)
        {
            return Visit(context.multOrDiv());
        }
        #endregion

        #region setVar
        public override double VisitSetVariable(CalculatorParser.SetVariableContext context)
        {
            string id = context.ID().GetText();
            double val = Visit(context.plusOrMinus());

            if (memory.FirstOrDefault(m => m.Key == id).Key == null)
            {
                memory.Add(id, val);
            }
            else
            {
                memory[id] = val;
            }
            return val;
        }
        #endregion

        #region input
        public override double VisitToSetVar(CalculatorParser.ToSetVarContext context)
        {
            return Visit(context.setVar());
        }

        public override double VisitCalculate(CalculatorParser.CalculateContext context)
        {
            return Visit(context.plusOrMinus());
        }
        #endregion
    }
}
