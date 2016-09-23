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
        StdAssemblerVisitor visitor;
        private string FileName;
        bool saved;
        private Point formPosition;
        private bool mouseAction;

        public Form1()
        {
            InitializeComponent();
            saveFile.Filter = "SIC|*.s";
            saved = false;
            windowTitle.Location = new Point((Width / 2) - 25, 10);
        }

        private void AnalizarGramatica(object sender, EventArgs e)
        {
            int codeLine = 1;
            StdToken token;
            bool hasErrors = false;
            String cad = "";

            if(!saved)
                saveFile.ShowDialog();

            if (saved)
            {
                // Inicializa la clase Visitor, la cual realiza la traducción
                visitor = new StdAssemblerVisitor();
                tabSimMenuItem.Enabled = false;
                outputTextBox.Text = "Análisis Léxico / Sintáctico comenzado...\r\n";
                foreach (string line in inputTextBox.Text.Split('\n'))
                {
                    AntlrInputStream input = new AntlrInputStream(line + '\n');
                    StdAssemblerLexer lexer = new StdAssemblerLexer(input);
                    CommonTokenStream tokens = new CommonTokenStream(lexer);
                    StdAssemblerParser parser = new StdAssemblerParser(tokens);
                    IParseTree tree = parser.linea();
                    token = visitor.Visit(tree) as StdToken;
                    if (token.StepOneError != null && token.StepOneError != string.Empty)
                    {
                        hasErrors = true;
                        outputTextBox.Text += token.StepOneError + "(Línea: " + codeLine.ToString() + ")\r\n";
                    }
                    codeLine++;
                }
                tabSimMenuItem.Enabled = hasErrors ? false : true;
                outputTextBox.Text += "Análisis Léxico / Sintáctico finalizado " + (hasErrors ? "con errores..." : "exitosamente...") + "\r\n" 
                                   + "Tamaño del programa: "+(visitor.GetTokens().Last().Address - visitor.GetTokens().First().Address).ToString("X") + "H\r\n";
                GeneraArchivoAnalisis(outputTextBox.Text);
                if (!hasErrors) 
                    GeneraTablaSimbolos();

                foreach (StdToken t in visitor.GetTokens())
                {
                    if (!t.IsEmpty)
                        cad += t.Address.ToString("X") + "\r\n";
                    else
                        cad += "\r\n";
                }
                direcciones.Text = cad;
            
                
            }
        }

        private void TabSimClick(object sender, EventArgs e)
        {
            string tabsim = string.Empty;
            foreach (KeyValuePair<string, string> value in visitor.GetTabSim())
            {
                tabsim += value.Key + " : [ " + value.Value + " ]\r\n";
            }
            MessageBox.Show(tabsim, "Tabla de Símbolos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenFileClick(object sender, EventArgs e)
        {
            openFile.Filter = "SIC|*.s";
            openFile.ShowDialog();
        }

        private void NewFileClick(object sender, EventArgs e)
        {
            FileName = null;
            inputTextBox.Text = string.Empty;
            outputTextBox.Text = string.Empty;
            direcciones.Text = string.Empty;
            StdTreeView.Nodes.Clear();
            StdTreeView.Nodes.Add("Nuevo");
            StdTreeView.Nodes[0].Nodes.Add("Nuevo.s");
            inputTextBox.Enabled = true;
            AnalisisMenuItem.Enabled = true;
            tabSimMenuItem.Enabled = false;
            saved = false;
        }

        private void SaveFileClick(object sender, EventArgs e)
        {
            if (FileName != null)
            {
                File.WriteAllText(FileName, inputTextBox.Text);
            }
            else
            {
                saveFile.Filter = "SIC|*.s";
                saveFile.ShowDialog();
            }
        }

        private void SaveFileAsClick(object sender, EventArgs e)
        {
            saveFile.Filter = "SIC|*.s";
            saveFile.ShowDialog();
        }

        private void CreateResultFile() 
        { 

        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {
            FileName = openFile.FileName;
            inputTextBox.Text = String.Join("\r\n", File.ReadAllLines(openFile.FileName));
            outputTextBox.Text = string.Empty;
            direcciones.Text = string.Empty;
            StdTreeView.Nodes.Clear();
            StdTreeView.Nodes.Add(FileName.Split('\\').Last().Replace(".s", ""));
            StdTreeView.Nodes[0].Nodes.Add(FileName.Split('\\').Last());
            inputTextBox.Enabled = true;
            AnalisisMenuItem.Enabled = true;
            saved = true;
        }

        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {
            FileName = saveFile.FileName;
            File.WriteAllText(saveFile.FileName, inputTextBox.Text);
            StdTreeView.Nodes.Clear();
            StdTreeView.Nodes.Add(FileName.Split('\\').Last().Replace(".s", ""));
            StdTreeView.Nodes[0].Nodes.Add(FileName.Split('\\').Last());
            saved = true;
        }

        private void StdTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //MessageBox.Show(e.Node.Text);
        }

        private void GeneraArchivoAnalisis(string analisis)
        {
            string[] path = FileName.Split('\\');
            string name = string.Empty;

            for(int i = 0; i < path.Length - 1; i++)
            {
                name += path.ElementAt(i) + "\\";
            }
            name += path.Last().Replace(".s", "") + ".t";
            File.WriteAllText(name, analisis);
            StdTreeView.Nodes[0].Nodes.Add(path.Last().Replace(".s", "") + ".t");
        }

        private void GeneraTablaSimbolos()
        {
            string tabsim = string.Empty;
            string[] path = FileName.Split('\\');
            string name = string.Empty;

            for (int i = 0; i < path.Length - 1; i++)
            {
                name += path.ElementAt(i) + "\\";
            }
            foreach (KeyValuePair<string, string> value in visitor.GetTabSim())
            {
                tabsim += value.Key + " : [ " + value.Value + " ]\r\n";
            }
            name += path.Last().Replace(".s", "") + ".tsim";
            File.WriteAllText(name, tabsim);
            StdTreeView.Nodes[0].Nodes.Add(path.Last().Replace(".s", "") + ".tsim");

        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeWindow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

            windowTitle.Location = new Point((Width / 2) - 25, 10);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

            windowTitle.Location = new Point((Width / 2) - 25, 10);
        }

        private void direcciones_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
