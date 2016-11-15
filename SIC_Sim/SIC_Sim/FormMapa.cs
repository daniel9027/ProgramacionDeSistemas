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
            textA.Text = "FFFFFF";
            textX.Text = "FFFFFF";
            textL.Text = "FFFFFF";
            textSW.Text = "FFFFFF";
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
                    contadorPrograma = loadAdress;
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
            string cod, modo, etiq;

            contadorPrograma = int.Parse(textCP.Text, System.Globalization.NumberStyles.HexNumber);
            avance = contadorPrograma - loadAdress;
            // Deteccion de elementos (Cod.Operacion, Modo, Etiqueta)
            valorByte = int.Parse(mapaDeMemoria[(avance + 1) % 16, (avance + 1) / 16].Value.ToString(), System.Globalization.NumberStyles.HexNumber);
            cod = mapaDeMemoria[avance % 16, avance / 16].Value.ToString();
            modo = (valorByte >= 128 ? "Indexado" : "Directo");
            etiq = (valorByte >= 128 ? (valorByte - 128).ToString("X") : valorByte.ToString("X")) + mapaDeMemoria[(avance + 2) % 16, (avance + 2) / 16].Value.ToString();
            // Llenado de text box 
            info = "CP = " + textCP.Text + "\r\n";
            info += "Instrucción: " +
                mapaDeMemoria[avance % 16, avance / 16].Value +
                mapaDeMemoria[(avance + 1) % 16, (avance + 1) / 16].Value +
                mapaDeMemoria[(avance + 2) % 16, (avance + 2) / 16].Value + "\r\n";
            info += "CodOP = " + cod + "; ";
            info += "Modo = " + modo + "; ";
            info += "m = " + etiq + "\r\n";
            info += "Efecto: " + ObtenEfecto(cod, modo, etiq) + "\r\n";
            textInfo.Text += info;
            textInfo.SelectionStart = textInfo.TextLength;
            textInfo.ScrollToCaret();
            // Incremento del CP
            textCP.Text = (contadorPrograma += 3).ToString("X");
        }

        private string ObtenEfecto(string codOp, string modo, string etiq)
        {
            string efecto = string.Empty;

            switch (codOp)
            {
                case "18":
                    if(modo == "Directo")
                        efecto = "ADD m \r\n" + "\tA <- (A) + (m...m+2)\r\n";
                    else
                        efecto = "ADD m,X \r\n" + "\tA <- (A) + ((m + (X))...(m + (X)+2))\r\n";
                    ADD(modo != "Directo", etiq);
                    break;
                case "40":
                    if (modo == "Directo")
                        efecto = "AND m \r\n" + "\tA ← (A) & (m..m+2)\r\n";
                    else
                        efecto = "AND m,X \r\n" + "\tA ← (A) & ((m + (X))...(m + (X)+2))\r\n";
                    break;
                case "28":
                    if (modo == "Directo")
                        efecto = "COMP m \r\n" + "\t(A) : (m..m+2)\r\n";
                    else
                        efecto = "COMP m,X \r\n" + "\t(A) : ((m + (X))...(m + (X)+2))\r\n";
                    break;
                case "24":
                    if (modo == "Directo")
                        efecto = "DIV m \r\n" + "\tA ← (A) / (m..m+2)\r\n";
                    else
                        efecto = "DIV m,X \r\n" + "\tA ← (A) / ((m + (X))...(m + (X)+2))\r\n";
                    break;
                case "3C":
                    if (modo == "Directo")
                        efecto = "J m \r\n" + "\tCP ← m\r\n";
                    else
                        efecto = "J m,X \r\n" + "\tCP ← m + (X)\r\n";
                    break;
                case "30":
                    if (modo == "Directo")
                        efecto = "JEQ m \r\n" + "\tCP ← m si CC está en =\r\n";
                    else
                        efecto = "JEQ m,X \r\n" + "\tCP ← m + (X) si CC está en =\r\n";
                    break;
                case "34":
                    if (modo == "Directo")
                        efecto = "JGT m \r\n" + "\tCP ← m si CC está en >\r\n";
                    else
                        efecto = "JGT m,X \r\n" + "\tCP ← m + (X) si CC está en >\r\n";
                    break;
                case "38":
                    if (modo == "Directo")
                        efecto = "JLT m \r\n" + "\tCP ← m si CC está en <\r\n";
                    else
                        efecto = "JLT m,X \r\n" + "\tCP ← m + (X) si CC está en <\r\n";
                    break;
                case "48":
                    if (modo == "Directo")
                        efecto = "JSUB m \r\n" + "\tL ← (CP); CP ← m\r\n";
                    else
                        efecto = "JSUB m,X \r\n" + "\tL ← (CP); CP ← m + (X)\r\n";
                    break;
                case "00":
                    if (modo == "Directo")
                        efecto = "LDA m \r\n" + "\tA ← (m..m+2)\r\n";
                    else
                        efecto = "LDA m,X \r\n" + "\tA ← ((m + (X))...(m + (X)+2))\r\n";
                    LDA(modo != "Directo", etiq);
                    break;
                case "50":
                    if (modo == "Directo")
                        efecto = "LDCH m \r\n" + "\tA [el byte de más a la derecha]  ← (m)\r\n";
                    else
                        efecto = "LDCH m,X \r\n" + "\tA [el byte de más a la derecha]  ← (m + (X))\r\n";
                    break;
                case "08":
                    if (modo == "Directo")
                        efecto = "LDL m \r\n" + "\tL ← (m..m+2)\r\n";
                    else
                        efecto = "LDL m,X \r\n" + "\tL ← ((m + (X))...(m + (X)+2))\r\n";
                    break;
                case "04":
                    if (modo == "Directo")
                        efecto = "LDX m \r\n" + "\tX ← (m..m+2)\r\n";
                    else
                        efecto = "LDX m,X \r\n" + "\tX ← ((m + (X))...(m + (X)+2))\r\n";
                    LDX(modo != "Directo", etiq);
                    break;
                case "20":
                    if (modo == "Directo")
                        efecto = "MUL m \r\n" + "\tA ← (A) * (m..m+2)\r\n";
                    else
                        efecto = "MUL m,X \r\n" + "\tA ← (A) * ((m + (X))...(m + (X)+2))\r\n";
                    break;
                case "44":
                    if (modo == "Directo")
                        efecto = "OR m \r\n" + "\tA ← (A) | (m..m+2)\r\n";
                    else
                        efecto = "OR m,X \r\n" + "\tA ← (A) | ((m + (X))...(m + (X)+2))\r\n";
                    break;
                case "D8":
                    if (modo == "Directo")
                        efecto = "RD m \r\n" + "\tA [el byte de más a la derecha] ← datos del dispositivo especificado por (m)\r\n";
                    else
                        efecto = "RD m,X \r\n" + "\tA [el byte de más a la derecha] ← datos del dispositivo especificado por (m + (X))\r\n";
                    break;
                case "4C":
                        efecto = "RSUB \r\n" + "\tPC  ← (L)\r\n";
                    break;
                case "0C":
                    if (modo == "Directo")
                        efecto = "STA m \r\n" + "\tm...m+2 ← (A)\r\n";
                    else
                        efecto = "STA m,X \r\n" + "\tm+(X)...m+(X)+2 ← (A)\r\n";
                    break;
                case "54":
                    if (modo == "Directo")
                        efecto = "STCH m \r\n" + "\tm ← (A) [el byte de más a la derecha]\r\n";
                    else
                        efecto = "STCH m,X \r\n" + "\tm+(X) ← (A) [el byte de más a la derecha]\r\n";
                    break;
                case "14":
                    if (modo == "Directo")
                        efecto = "STL m \r\n" + "\tm...m+2 ← (L)\r\n";
                    else
                        efecto = "STL m,X \r\n" + "\tm+(X)...m+(X)+2 ← (L)\r\n";
                    break;
                case "E8":
                    if (modo == "Directo")
                        efecto = "STSW m \r\n" + "\tm...m+2 ← (SW)\r\n";
                    else
                        efecto = "STSW m,X \r\n" + "\tm+(X)...m+(X)+2 ← (SW)\r\n";
                    break;
                case "10":
                    if (modo == "Directo")
                        efecto = "STX m \r\n" + "\tm...m+2 ← (X)\r\n";
                    else
                        efecto = "STX m,X \r\n" + "\tm+(X)...m+(X)+2 ← (A)\r\n";
                    break;
                case "1C":
                    if (modo == "Directo")
                        efecto = "SUB m \r\n" + "\tA <- (A) - (m...m+2)\r\n";
                    else
                        efecto = "SUB m,X \r\n" + "\tA <- (A) - ((m + (X))...(m + (X)+2))\r\n";
                    break;
                case "E0":
                    if (modo == "Directo")
                        efecto = "SUB m \r\n" + "\tPrueba el dispositivo especificado por (m)\r\n";
                    else
                        efecto = "SUB m,X \r\n" + "\tPrueba el dispositivo especificado por (m + (X))\r\n";
                    break;
                case "2C":
                    if (modo == "Directo")
                        efecto = "TIX m \r\n" + "\tX ← (X) + 1; (X) : (m...m+2)\r\n";
                    else
                        efecto = "TIX m,X \r\n" + "\tX ← (X) + 1; (X) : ((m + (X))...(m + (X)+2))\r\n";
                    TIX(modo != "Directo", etiq);
                    break;
                case "DC":
                    if (modo == "Directo")
                        efecto = "WD m \r\n" + "\tDispositivo especificado por (m)  ← (A) [el byte de más a la derecha]\r\n";
                    else
                        efecto = "WD m,X \r\n" + "\tDispositivo especificado por (m+(X)) ← (A) [el byte de más a la derecha]\r\n";
                    break;
                default:
                        efecto = "INSTRUCCIÓN NO VÁLIDA\r\n";
                    break;
            }
            return efecto;
        }

        private void LDX(bool isIndexed, string label)
        {
            int targetAddress;
            int avance;

            targetAddress = int.Parse(label, System.Globalization.NumberStyles.HexNumber);
            if(isIndexed)
                targetAddress += int.Parse(textX.Text, System.Globalization.NumberStyles.HexNumber);
            avance = targetAddress - loadAdress;
            textX.Text = mapaDeMemoria[avance % 16, avance / 16].Value.ToString() +
                mapaDeMemoria[(avance + 1) % 16, (avance + 1) / 16].Value.ToString() +
                mapaDeMemoria[(avance + 2) % 16, (avance + 2) / 16].Value.ToString();

        }

        private void LDA(bool isIndexed, string label)
        {
            int targetAddress;
            int avance;

            targetAddress = int.Parse(label, System.Globalization.NumberStyles.HexNumber);
            if (isIndexed)
                targetAddress += int.Parse(textX.Text, System.Globalization.NumberStyles.HexNumber);
            avance = targetAddress - loadAdress;
            textA.Text = mapaDeMemoria[avance % 16, avance / 16].Value.ToString() +
                mapaDeMemoria[(avance + 1) % 16, (avance + 1) / 16].Value.ToString() +
                mapaDeMemoria[(avance + 2) % 16, (avance + 2) / 16].Value.ToString();
        }

        private void ADD(bool isIndexed, string label)
        {
            int targetAddress;
            int avance;
            string value;

            targetAddress = int.Parse(label, System.Globalization.NumberStyles.HexNumber);
            if (isIndexed)
                targetAddress += int.Parse(textX.Text, System.Globalization.NumberStyles.HexNumber);
            avance = targetAddress - loadAdress;
            value = mapaDeMemoria[avance % 16, avance / 16].Value.ToString() +
                mapaDeMemoria[(avance + 1) % 16, (avance + 1) / 16].Value.ToString() +
                mapaDeMemoria[(avance + 2) % 16, (avance + 2) / 16].Value.ToString();

            textA.Text = (int.Parse(textA.Text, System.Globalization.NumberStyles.HexNumber) + int.Parse(value, System.Globalization.NumberStyles.HexNumber)).ToString("X").PadLeft(6, '0'); ;
        }

        private void TIX(bool isIndexed, string label)
        {
            int targetAddress, avance, valueM, valueX, CC, valueSW, mask;
            string m;

            targetAddress = int.Parse(label, System.Globalization.NumberStyles.HexNumber);
            if (isIndexed)
                targetAddress += int.Parse(textX.Text, System.Globalization.NumberStyles.HexNumber);
            avance = targetAddress - loadAdress;
            m = mapaDeMemoria[avance % 16, avance / 16].Value.ToString() +
                mapaDeMemoria[(avance + 1) % 16, (avance + 1) / 16].Value.ToString() +
                mapaDeMemoria[(avance + 2) % 16, (avance + 2) / 16].Value.ToString();
            valueM = int.Parse(m, System.Globalization.NumberStyles.HexNumber);
            valueX = int.Parse(textX.Text, System.Globalization.NumberStyles.HexNumber) + 1;
            valueSW = int.Parse(textSW.Text, System.Globalization.NumberStyles.HexNumber);
            mask = int.Parse("FFFFFC", System.Globalization.NumberStyles.HexNumber);
            CC = valueX < valueM ? 0 :
                valueX == valueM ? 1 :
                valueX > valueM ?  2 :
                3; // Algo anda mal
            textX.Text = valueX.ToString("X").PadLeft(6, '0');
            textSW.Text = ((mask | CC) & valueSW).ToString("X").PadLeft(6, '0'); ;
        }
    }
}
