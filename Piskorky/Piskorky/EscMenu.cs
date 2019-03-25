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
    public partial class EscMenu : Form
    {
        private Logic Logic;
        private DataGridView Dtgw_plaingField;
        public EscMenu(Logic logic, DataGridView dtgw_plaingField)
        {
            InitializeComponent();
            Logic = logic;
            Dtgw_plaingField = dtgw_plaingField;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Datalayer.Save(Logic, Dtgw_plaingField))
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show("Sucessfully saved");
            }
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void btn_Resume_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
