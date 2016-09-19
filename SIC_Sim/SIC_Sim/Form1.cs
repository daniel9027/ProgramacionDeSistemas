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
using System.IO;
namespace SIC_Sim
{
    public partial class Form1 : Form
    {
        private StdAssemblerVisitor visitor;
        private String file;
        public Form1()
        {
            InitializeComponent();
            file = null;
            // Inicializa la clase Visitor, la cual realiza la traducción
            visitor = new StdAssemblerVisitor();
        }

        private void AnalizarGramatica(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
           
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "SIC|*.s";
            if(fd.ShowDialog() == DialogResult.OK){
                file = fd.FileName;
                code.Text = String.Join("\n",File.ReadAllLines(fd.FileName));
            }
            fd.Dispose();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file != null) {
                char[] sep = { '\n' };
                File.WriteAllLines(file, code.Text.Split(sep));
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "SIC|*.s";
            if(fd.ShowDialog() == DialogResult.OK){
                char[] sep = { '\n' };
                File.WriteAllLines(fd.FileName, code.Text.Split(sep));
            }
        }

        private void analiza_Click(object sender, EventArgs e)
        {
            String s = code.Text.Replace('\n', ' ');
            s = s.Replace('\t', ' ');
            AntlrInputStream input = new AntlrInputStream(s);
            StdAssemblerLexer lexer = new StdAssemblerLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            StdAssemblerParser parser = new StdAssemblerParser(tokens);
            IParseTree tree = parser.programa();
            resultado.Text = visitor.Visit(tree).ToString();
>>>>>>> origin/master
        }
    }
}
