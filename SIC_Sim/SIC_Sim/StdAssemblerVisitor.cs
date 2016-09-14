using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIC_Sim
{
    class StdAssemblerVisitor : StdAssemblerBaseVisitor<double>
    {

        Dictionary<string, double> memory;

        public StdAssemblerVisitor()
        {
            memory = new Dictionary<string, double>();
        }

        #region atom
        /// <summary>
        /// Visita el nodo correspondiente a una expresión agrupada por parentesis
        /// </summary>
        /// <param name="context">Variable de contexto</param>
        /// <returns>Se devuelve el resultado de la llamada al nodo hijo plusOrMinus</returns>
        public override double VisitBraces(StdAssemblerParser.BracesContext context)
        {
            return Visit(context.plusOrMinus());
        }

        /// <summary>
        /// Visita el nodo correspondiente a una variable 
        /// </summary>
        /// <param name="context">Variable de contexto</param>
        /// <returns>Se devuelve el valor de la variable</returns>
        public override double VisitVariable(StdAssemblerParser.VariableContext context)
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

        /// <summary>
        /// Visita el nodo correspondiente a un entero
        /// </summary>
        /// <param name="context">Variable de contexto</param>
        /// <returns>Devuelve el valor del entero</returns>
        public override double VisitInt(StdAssemblerParser.IntContext context)
        {
            return double.Parse(context.INT().GetText());
        }

        /// <summary>
        /// Visita el nodo correspondiente a un double
        /// </summary>
        /// <param name="context">Variable de contexto</param>
        /// <returns>Devuelve el valor del double</returns>
        public override double VisitDouble(StdAssemblerParser.DoubleContext context)
        {
            return double.Parse(context.DOUBLE().GetText());
        }

        /// <summary>
        /// Visita el nodo correspondiente a la constante e
        /// </summary>
        /// <param name="context">Variable de contexto</param>
        /// <returns>Devuelve el valor de la constante</returns>
        public override double VisitConstantE(StdAssemblerParser.ConstantEContext context)
        {
            return Math.E;
        }

        /// <summary>
        /// Visita el nodo correspondiente a la constante PI
        /// </summary>
        /// <param name="context">Variable de contexto</param>
        /// <returns>Devuelve el valor de la constante</returns>
        public override double VisitConstantPI(StdAssemblerParser.ConstantPIContext context)
        {
            return Math.PI;
        }
        #endregion

        #region unaryMinus
        /// <summary>
        /// Visita el nodo Atom, el cual defina los valores primitivos a utilizar
        /// </summary>
        /// <param name="context">Variable de contexto</param>
        /// <returns>Devuelve el resultado de la llamada al nodo hijo atom</returns>
        public override double VisitToAtom(StdAssemblerParser.ToAtomContext context)
        {
            return Visit(context.atom());
        }

        /// <summary>
        /// Visita el nodo correspondiente al menos unario
        /// </summary>
        /// <param name="context">Variable de contexto</param>
        /// <returns>El valor negativo del resultado a la visita de su nodo hijo</returns>
        public override double VisitChangeSign(StdAssemblerParser.ChangeSignContext context)
        {
            return (-1.0d * Visit(context.unaryMinus()));
        }
        #endregion

        #region pow
        /// <summary>
        /// Visita el nodo correspondiente a la potencia de un número o expresión
        /// </summary>
        /// <param name="context">Variable de contexto</param>
        /// <returns>Devuelve el resultado de la expresión interna elevada a la potencia señalada</returns>
        public override double VisitPower(StdAssemblerParser.PowerContext context)
        {
            return context.ChildCount == 1 ?
                Visit(context.unaryMinus()) :
                Math.Pow(Visit(context.unaryMinus()), Visit(context.pow()));
        }
        #endregion

        #region multOrDiv
        public override double VisitMultiplication(StdAssemblerParser.MultiplicationContext context)
        {
            return (Visit(context.multOrDiv()) * Visit(context.pow()));
        }

        public override double VisitDivision(StdAssemblerParser.DivisionContext context)
        {
            return (Visit(context.multOrDiv()) / Visit(context.pow()));
        }

        public override double VisitToPow(StdAssemblerParser.ToPowContext context)
        {
            return Visit(context.pow());
        }
        #endregion

        #region plusOrMinus
        public override double VisitPlus(StdAssemblerParser.PlusContext context)
        {
            return (Visit(context.plusOrMinus()) + Visit(context.multOrDiv()));
        }

        public override double VisitMinus(StdAssemblerParser.MinusContext context)
        {
            return (Visit(context.plusOrMinus()) - Visit(context.multOrDiv()));
        }

        public override double VisitToMultOrDiv(StdAssemblerParser.ToMultOrDivContext context)
        {
            return Visit(context.multOrDiv());
        }
        #endregion

        #region setVar
        /// <summary>
        /// Visita el nodo correspondiente a la asignación de variables
        /// </summary>
        /// <param name="context">Variable de contexto</param>
        /// <returns>Devuelve el valor de la variable tras ser asignada</returns>
        public override double VisitSetVariable(StdAssemblerParser.SetVariableContext context)
        {
            string id = context.ID().GetText();
            double val = Visit(context.setVar());

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

        /// <summary>
        /// Vista el nodo correspondiente a una ecuación
        /// </summary>
        /// <param name="context">Variable de contexto</param>
        /// <returns>Devuelve el resultado de la ecuación tras la visita al nodo hijo</returns>
        public override double VisitCalculate(StdAssemblerParser.CalculateContext context)
        {
            return Visit(context.plusOrMinus());
        }
        #endregion

        #region input
        /// <summary>
        /// Representa cada una de las entradas en la calculadora
        /// </summary>
        /// <param name="context">Variable de contexto</param>
        /// <returns>Devuelve el resultado de la cadena ingresada</returns>
        public override double VisitToSetVar(StdAssemblerParser.ToSetVarContext context)
        {
            return Visit(context.setVar());
        }
        #endregion
    }
}
