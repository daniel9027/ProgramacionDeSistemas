using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.IO;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora (Ctrl+Z para salir):");
            StreamReader inputStream = new StreamReader(Console.OpenStandardInput());
            while (!inputStream.EndOfStream)
            {
                AntlrInputStream input = new AntlrInputStream(inputStream.ReadLine());
                CalculatorLexer lexer = new CalculatorLexer(input);
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                CalculatorParser parser = new CalculatorParser(tokens);
                IParseTree tree = parser.prog();
                //Console.WriteLine(tree.ToStringTree(parser));
                CalculatorVisitor visitor = new CalculatorVisitor();
                Console.WriteLine(visitor.Visit(tree));
            }
        }
    }
}
