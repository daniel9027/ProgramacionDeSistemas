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
    public partial class AgregaDispositivo : Form
    {
        public AgregaDispositivo()
        {
            InitializeComponent();
        }

        private void AgregaDispositivo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int dispositivoDisponible(string dir) {
            int band = 2;
            string id = string.Empty;

            foreach(Control c in Controls) {
                if (c is TextBox && c.AccessibleDescription == "Direccion" && ((TextBox)c).Text != string.Empty && ((TextBox)c).Text.PadLeft(2, '0') == dir)
                {
                    id = ((TextBox)c).AccessibleName;
                } else if (c is CheckBox && ((CheckBox)c).AccessibleName == id)
                {
                    band = ((CheckBox)c).Checked ? 0:1;
                    break;
                }
            }

            return band;
        }

        public string leerDispositivo(string dir) {
            string val = string.Empty, id = string.Empty;
            bool band = false;

            foreach(Control c in Controls) {
                if (c is TextBox && c.AccessibleDescription == "Direccion" && ((TextBox)c).Text != string.Empty && ((TextBox)c).Text.PadLeft(2, '0') == dir)
                {
                    id = ((TextBox)c).AccessibleName;
                }
                else if (c is TextBox && ((TextBox)c).Text != string.Empty && ((TextBox)c).AccessibleName == id)
                {
                    val = ((TextBox)c).Text;
                }
                else if (c is CheckBox && ((CheckBox)c).AccessibleName == id)
                {
                    band = ((CheckBox)c).Checked ? true : false;
                    break;
                }
            }

            return band ? val : "FF";
        }

        public void escribeDispositivo(string dir, string val) {
            string id = string.Empty;
            bool band = false;
            TextBox valueTextBox = null;

            foreach (Control c in Controls)
            {
                if (c is TextBox && c.AccessibleDescription == "Direccion" && ((TextBox)c).Text != string.Empty && ((TextBox)c).Text.PadLeft(2, '0') == dir)
                {
                    id = ((TextBox)c).AccessibleName;
                }
                else if (c is TextBox && ((TextBox)c).Text != string.Empty && ((TextBox)c).AccessibleName == id)
                {
                    valueTextBox = (TextBox)c;
                }
                else if (c is CheckBox && ((CheckBox)c).AccessibleName == id)
                {
                    band = ((CheckBox)c).Checked ? true : false;
                    break;
                }
            }
            if (band)
                valueTextBox.Text = val;
        }

        private void AgregaDispositivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }

        private void textBox_textChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse( ((TextBox)sender).Text, System.Globalization.NumberStyles.HexNumber );
            }
            catch(Exception)
            {
                 ((TextBox)sender).Text = string.Empty;
            }
        }
    }
}
