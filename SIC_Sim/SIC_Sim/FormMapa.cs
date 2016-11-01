using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIC_Sim
{
    public partial class FormMapa : Form
    {
        string[,] mapa;
        int progSize;
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
    }
}
