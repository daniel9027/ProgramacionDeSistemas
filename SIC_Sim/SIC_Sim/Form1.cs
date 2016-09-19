using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace SIC_Sim
{
    public partial class Form1 : Form
    {
        private StdAssemblerVisitor visitor;
        public Form1()
        {
            InitializeComponent();
            // Inicializa la clase Visitor, la cual realiza la traducción
            visitor = new StdAssemblerVisitor();
        }

        private void AnalizarGramatica(object sender, EventArgs e)
        {
            string result = string.Empty;
            foreach(string line in inputTextBox.Text.Split('\n'))
            {
                AntlrInputStream input = new AntlrInputStream(line + '\n');
                StdAssemblerLexer lexer = new StdAssemblerLexer(input);
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                StdAssemblerParser parser = new StdAssemblerParser(tokens);
                IParseTree tree = parser.linea();
                try
                {
                    result = visitor.Visit(tree).ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la gramática", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
