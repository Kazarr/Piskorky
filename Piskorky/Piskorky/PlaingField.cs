using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piskorky
{
    public partial class PlaingField : Form
    {
        public PlaingField(int lenght, int width)
        {
            InitializeComponent();
            for(int i = 0; i < lenght; i++)
            {
                dtgw_PlaingField.Columns.Add($"{i}", $"{i}");
                dtgw_PlaingField.Rows.Add();
            }
        }

        private void dtgw_PlaingField_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgw_PlaingField[e.ColumnIndex, e.RowIndex].Value = "X";
        }
    }
}
