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
        private Logic _logic;
        public PlaingField(Logic logic)
        {
            InitializeComponent();
			_logic = logic;
			_logic.CreatePlaingFiled(_logic.Settings.Size, dtgw_PlaingField);
		}


        private void dtgw_PlaingField_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _logic.Mark(dtgw_PlaingField, e);
            if (_logic.IsWin(dtgw_PlaingField, e))
			{
                MessageBox.Show("");
                Close();
            }
		}

		private void dtgw_PlaingField_KeyPress(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
                using (EscMenu EscMenu = new EscMenu(_logic, dtgw_PlaingField))
                {
                    var dialogResultEscMenu = EscMenu.ShowDialog();
                    if (dialogResultEscMenu == DialogResult.OK)
                    {
                        EscMenu.Close();
                    }
                    else if (dialogResultEscMenu == DialogResult.Abort)
                    {
                        EscMenu.Close();
                        Close();
                    }
                }
                
			}
		}
	}
}
