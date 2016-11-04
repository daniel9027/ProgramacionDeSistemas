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
        List<GridItem> rowsList;
        string[,] memoryMap;
        int progSize;
        public Form1()
        {
            InitializeComponent();
            saveFile.Filter = "SIC|*.s";
            saved = false;
            windowTitle.Location = new Point((Width / 2) - 25, 10);
            rowsList = new List<GridItem>();
        }

        private void AnalizarGramatica(object sender, EventArgs e)
        {
            int codeLine = 1;
            StdToken token;
            bool hasErrors = false;
            String cad = string.Empty, cadCodigoObj = string.Empty;

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
                    token.Text = line;
                    codeLine++;
                }
                tabSimMenuItem.Enabled = hasErrors ? false : true;
                outputTextBox.Text += "Análisis Léxico / Sintáctico finalizado " + (hasErrors ? "con errores..." : "exitosamente...") + "\r\n" 
                                   + "Tamaño del programa: "+(visitor.GetTokens().Last().Address - visitor.GetTokens().First().Address).ToString("X") + "H\r\n";
                GeneraArchivoAnalisis(outputTextBox.Text);
                GeneraTablaSimbolos();
                GeneraCodigoObj();
                outputTextBox.Text += creaArchivoRegistrosObj();
                foreach (StdToken t in visitor.GetTokens())
                {
                    string dir, obj;

                    if (!t.IsEmpty)
                        dir= t.Address.ToString("X") + ((t.OperationCode == "END") ? "" : "\r\n");
                    else
                        dir= "\r\n";
                    obj = t.GetOperationCodeValue(visitor.TabSim) + ((t.OperationCode == "END") ? "" : "\r\n");
                    rowsList.Add(new GridItem() 
                    { 
                        Address = dir,
                        ObjectCode = obj,
                        Text = t.Text
                    });
                    cad += dir;
                    cadCodigoObj += obj;
                }
                direcciones.Text = cad;
                CodObjTextBox.Text = cadCodigoObj;
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

        private void GeneraCodigoObj()
        {
            string opcode = string.Empty;
            string[] path = FileName.Split('\\');
            string name = string.Empty;

            for (int i = 0; i < path.Length - 1; i++)
            {
                name += path.ElementAt(i) + "\\";
            }
            name += path.Last().Replace(".s", "") + ".o";
            foreach (StdToken t in visitor.GetTokens())
            {
                opcode += t.Address.ToString("X") + "H\t" + t.GetOperationCodeValue(visitor.TabSim) + "\r\n";
            }
            File.WriteAllText(name, opcode);
            StdTreeView.Nodes[0].Nodes.Add(path.Last().Replace(".s", "") + ".o");

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string creaArchivoRegistrosObj() {
            string opcodeAux = string.Empty;
            string[] path = FileName.Split('\\');
            string name = string.Empty;
            string regObj = string.Empty;
            string tReg = string.Empty;
            int count = 0;
            int add = -1, loadAdress,k;

            loadAdress = visitor.GetTokens().First().Address;
            foreach (StdToken t in visitor.GetTokens())
            {
                opcodeAux = t.GetOperationCodeValue(visitor.TabSim);
                if (!t.IsEmpty && (!t.IsDirective || (t.OperationCode == "BYTE" || t.OperationCode == "WORD")))
                {
                    if (!t.IsDirective && add == -1)
                        add = t.Address;
                    if (tReg.Length + t.OperationCode.Length > 69)
                    {
                        regObj += tReg.Replace("  ", count.ToString("X")) + "\r\n";
                        tReg = string.Empty;
                        count = 0;
                        tReg = "T" + t.Address.ToString("X").PadLeft(6, '0') + "  ";
                    }
                    else if (tReg.Length == 0)
                    {
                        tReg = "T" + t.Address.ToString("X").PadLeft(6, '0') + "  ";
                    }
                    tReg += opcodeAux;
                    count += opcodeAux.Length;
                }
                else
                {
                    switch (t.OperationCode)
                    {
                        case "START":
                            regObj += "H";
                            if (t.Label.Length > 6)
                                regObj += t.Label.Substring(0, 6);
                            else
                                regObj += t.Label.PadRight(6, ' ');
                            regObj += t.Address.ToString("X").PadLeft(6, '0') + (visitor.GetTokens().Last().Address - visitor.GetTokens().First().Address).ToString("X").PadLeft(6, '0') + "\r\n";
                            break;
                        case "END":
                            if (tReg != string.Empty)
                                regObj += tReg.Replace("  ", count.ToString("X")) + "\r\n";
                            tReg = string.Empty;
                            if (t.Value.Length > 0)
                                tReg += "E" + t.getSimbolAddress(visitor.TabSim, t.Symbol).ToString("X").PadLeft(6, '0');
                            else
                                tReg += "E" + add.ToString("X").PadLeft(6, '0');
                            regObj += tReg;
                            break;
                        default:
                            if (tReg != string.Empty)
                            {
                                regObj += tReg.Replace("  ", count.ToString("X").PadLeft(2,'0')) + "\r\n";
                                tReg = string.Empty;
                                count = 0;
                            }
                            break;
                    }
                }
            }

            for (int i = 0; i < path.Length - 1; i++)
            {
                name += path.ElementAt(i) + "\\";
            }
            name += path.Last().Replace(".s", "") + ".sobj";
            File.WriteAllText(name, regObj);
            StdTreeView.Nodes[0].Nodes.Add(path.Last().Replace(".s", "") + ".sobj");
            progSize = (visitor.GetTokens().Last().Address - visitor.GetTokens().First().Address);
            memoryMap = new string[progSize/16, 16];
            for (int c = 0; c < regObj.Length; c++)
            {
                k = 0;
                if( regObj[c] == 'T')
                {
                    int dir1 = (int.Parse(regObj.Substring(c + 1, 6), System.Globalization.NumberStyles.HexNumber) - loadAdress) / 16;
                    int dir2 = (int.Parse(regObj.Substring(c + 1, 6), System.Globalization.NumberStyles.HexNumber) - loadAdress) % 16;
                    int bytes = int.Parse(regObj.Substring(c + 7, 2), System.Globalization.NumberStyles.HexNumber);
                    c += 9;
                    for (int i = dir1; i < progSize / 16 && k < bytes; i++)
                    {
                        for (int j = dir2%16; j < 16 && k < bytes; j++, k+=2)
                        {
                                memoryMap[i, j] = regObj.Substring(c,2);
                                c+=2;
                        }
                        dir2 = 0;
                    }
                }
            }

                return regObj;
        }

        private void resultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultForm result = new ResultForm(rowsList);
            result.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mapaDeMemoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMapa fm = new FormMapa(memoryMap,progSize);
            fm.Show();
        }
    }
}
