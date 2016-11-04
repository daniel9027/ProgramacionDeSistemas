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
    public partial class ResultForm : Form
    {
        public List<GridItem> Rows;

        public ResultForm(List<GridItem> rows)
        {
            InitializeComponent();
            Rows = rows;
            var source = new BindingSource();
            source.DataSource = Rows;
            resultGrid.DataSource = source;
        }
    }
}
