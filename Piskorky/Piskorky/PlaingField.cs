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
		public Logic Logic { get; }
		public int Turn { get; set; }
        public PlaingField(Logic logic)
        {
            InitializeComponent();
			Logic = logic;
			Logic.CreatePlaingFiled(Logic.Settings.Size, dtgw_PlaingField);
			//for(int i = 0; i < logic.Settings.Size; i++)
			//{
			//    dtgw_PlaingField.Columns.Add($"{i}", $"{i}");
			//    dtgw_PlaingField.Rows.Add();
			//}
		}


        private void dtgw_PlaingField_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			
			Logic.Mark(dtgw_PlaingField, e, Turn);
			Turn++;
		}

		private void dtgw_PlaingField_KeyPress(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

	}
}
