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
        public FormMapa()
        {
            InitializeComponent();
        }

        public FormMapa(string[,] m, int ps) {
            InitializeComponent();
            mapa = m;
            progSize = ps;
        }

        private void FormMapa_Load(object sender, EventArgs e)
        {
    
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openRegDialog.ShowDialog();
        }

        private void carga() {
            for (int j = 0; j < 16; j++)
            {
                mapaDeMemoria.Columns.Add("Columna" + j.ToString(), j.ToString("X").PadLeft(2, '0'));
            }
            mapaDeMemoria.Rows.Add(progSize / 16);

            for (int i = 0; i < progSize / 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (mapa[i, j] == null)
                        mapaDeMemoria[j, i].Value = "FF";
                    else
                        mapaDeMemoria[j, i].Value = mapa[i, j];
                }
            }
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
                mapa = new string[progSize / 16, 16];
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
    }
}
