using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIC_Sim
{
    public partial class FormMapa : Form
    {
        string[,] mapa;
        int progSize, loadAdress;
        private string regObj;
        private int instr;
        private int contadorPrograma;

        public FormMapa()
        {
            InitializeComponent();
        }

        public FormMapa(string fileName) {
            InitializeComponent();
            if (fileName != string.Empty)
            {
                openRegDialog.FileName = fileName;
                openRegDialog_FileOk(this, null);
            }
        }

        private void FormMapa_Load(object sender, EventArgs e)
        {
    
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openRegDialog.ShowDialog();
        }

        private void carga() {
           
            mapaDeMemoria.Rows.Add((progSize / 16) + 1);
            for (int i = 0; i < (progSize / 16) + 1; i++)
                mapaDeMemoria.Rows[i].HeaderCell.Value = (loadAdress + (i * 16)).ToString("X");

            int gridRows = (progSize / 16) + ((progSize % 16) != 0 ? 1 : 0);
            for (int i = 0; i < gridRows; i++)
            {
                for (int j = 0; (j < 16) && ((i * 16) + j < progSize); j++)
                {
                    if (mapa[i, j] == null)
                        mapaDeMemoria[j, i].Value = "FF";
                    else
                        mapaDeMemoria[j, i].Value = mapa[i, j];
                    
                }
            }
            textCP.Text = loadAdress.ToString("X");
            textA.Text = "FFFF";
            textX.Text = "FFFF";
            textL.Text = "FFFF";
            textSW.Text = "FFFF";
            btnEjecutar.Enabled = true;
            contadorPrograma = loadAdress;
        }

        private bool leeArchivo()
        {
            int k;
            bool success;
            string[] lines = Regex.Split(regObj, "\r\n");

            if (lines.Length > 2 && Regex.IsMatch(lines[0], "^H") && Regex.IsMatch(lines[lines.Length - 1], "^E"))
            {
                loadAdress = int.Parse(lines[0].Substring(7, 6), System.Globalization.NumberStyles.HexNumber);
                progSize = int.Parse(lines[0].Substring(13, 6), System.Globalization.NumberStyles.HexNumber);
                mapa = new string[(progSize / 16) + ((progSize % 16) != 0 ? 1 : 0), 16];
                for (int c = 0; c < regObj.Length; c++)
                {
                    k = 0;
                    if (regObj[c] == 'T')
                    {
                        int dir1 = (int.Parse(regObj.Substring(c + 1, 6), System.Globalization.NumberStyles.HexNumber) - loadAdress) / 16;
                        int dir2 = (int.Parse(regObj.Substring(c + 1, 6), System.Globalization.NumberStyles.HexNumber) - loadAdress) % 16;
                        int bytes = int.Parse(regObj.Substring(c + 7, 2), System.Globalization.NumberStyles.HexNumber);
                        c += 9;
                        for (int i = dir1; i < progSize / 16 && k < bytes; i++)
                        {
                            for (int j = dir2 % 16; j < 16 && k < bytes; j++, k += 2)
                            {
                                mapa[i, j] = regObj.Substring(c, 2);
                                c += 2;
                            }
                            dir2 = 0;
                        }
                    }
                }
                success = true;
            }
            else
                success = false;
            return success;
        }

        private void openRegDialog_FileOk(object sender, CancelEventArgs e)
        {
            regObj = String.Join("\r\n", File.ReadAllLines(openRegDialog.FileName));
            if (leeArchivo())
            {
                carga();
                lbDirCarga.Text += loadAdress.ToString("X");
                lbTamProg.Text += progSize.ToString("X");
            }
            else
                MessageBox.Show("Error al leer archivo", "Lectura de archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (btnEjecutar.Text == "Ejecutar")
            {
                btnEjecutar.Text = "Detener";
                if (!int.TryParse(textInstr.Text, out instr))
                    instr = 1;
                timer.Start();
            }
            else
            {
                btnEjecutar.Text = "Ejecutar";
                timer.Stop();
                clk.BackColor = Color.LightGray;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (clk.BackColor == Color.LightGray)
            {
                if (contadorPrograma >= (progSize + loadAdress))
                {
                    btnEjecutar.Text = "Ejecutar";
                    textCP.Text = loadAdress.ToString("X");
                    timer.Stop();
                }
                else
                {
                    clk.BackColor = Color.MediumSeaGreen;
                    MuestraInstruccion();
                }
            }
            else
            {
                clk.BackColor = Color.LightGray;
                if ((--instr) < 1)
                {
                    btnEjecutar.Text = "Ejecutar";
                    timer.Stop();
                }
            }
        }

        private void MuestraInstruccion()
        {

            string info = string.Empty;
            int avance, valorByte;

            contadorPrograma = int.Parse(textCP.Text, System.Globalization.NumberStyles.HexNumber);
            avance = contadorPrograma - loadAdress;
            info = "CP = " + textCP.Text + "\r\n";
            info += "Instrucción: " + 
                mapaDeMemoria[avance % 16, avance / 16].Value +
                mapaDeMemoria[(avance + 1) % 16, (avance + 1) / 16].Value +
                mapaDeMemoria[(avance + 2) % 16, (avance + 2) / 16].Value + "\r\n";
            // Deteccion de modo
            valorByte = int.Parse(mapaDeMemoria[(avance + 1) % 16, (avance + 1) / 16].Value.ToString(), System.Globalization.NumberStyles.HexNumber);
            info += "CodOP = " + mapaDeMemoria[avance % 16, avance / 16].Value + "; ";
            info += "Modo = " + (valorByte >= 128 ? "Indexado" : "Directo") + "; ";
            info += "m = " + (valorByte >= 128 ? (valorByte - 128).ToString("X") : valorByte.ToString("X")) + 
                mapaDeMemoria[(avance + 2) % 16, (avance + 2) / 16].Value.ToString() + "\r\n";
            info += "Efecto: " + ObtenEfecto(mapaDeMemoria[avance % 16, avance / 16].Value.ToString(), true, "");
            // Incremento del CP
            textCP.Text = (contadorPrograma += 3).ToString("X");
            textInfo.Text += info;
            textInfo.SelectionStart = textInfo.TextLength;
            textInfo.ScrollToCaret();
        }

        private string ObtenEfecto(string codOp, bool isX, string m)
        {
            string efecto = string.Empty;

            switch (codOp)
            {
                case "18":
                    return "ADD m \r\n" + "\tA <- (A) + (m...m+2)\r\n";
                    break;
                case "00":
                    return "LDA m \r\n" + "\tA <- (m...m+2)\r\n";
                    break;
                case "04":
                    return "LDX m \r\n" + "\tX <- (m...m+2)\r\n";
                    break;
            }
            return efecto;
        }
    }
}
