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
    public partial class NewGame : Form
    {
		public Logic Logic { get; set; }
		public Settings Settings { get; set; }
        public NewGame()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            int size;
            int winCondition;
            bool success = int.TryParse(txt_Size.Text, out size);
            success = int.TryParse(txt_WinCondition.Text, out winCondition);
			Settings = new Settings(size, winCondition);
			if(chck_Player1.Checked) Settings.AddPlayer(new Player(txt_Player1Name.Text, txt_Player1Mark.Text));
			if(chck_Player2.Checked) Settings.AddPlayer(new Player(txt_Player2Name.Text, txt_Player2Mark.Text));
			if (chck_Player3.Checked) Settings.AddPlayer(new Player(txt_Player3Name.Text, txt_Player3Mark.Text));
			if (chck_Player4.Checked) Settings.AddPlayer(new Player(txt_Player4Name.Text, txt_Player4Mark.Text));
			Logic = new Logic(Settings);
            DialogResult = DialogResult.OK;
        }

        private void NewGame_Enter(object sender, EventArgs e)
        {
            btn_Play_Click(sender, e);
        }
		private void chck_Player4_CheckedChanged(object sender, EventArgs e)
		{
			txt_Player4Name.Enabled = chck_Player4.Checked;
			txt_Player4Mark.Enabled = chck_Player4.Checked;
		}
		private void chck_Player3_CheckedChanged(object sender, EventArgs e)
		{
			txt_Player3Name.Enabled = chck_Player3.Checked;
			txt_Player3Mark.Enabled = chck_Player3.Checked;
		}
		private void chck_Player2_CheckedChanged(object sender, EventArgs e)
		{
			txt_Player2Name.Enabled = chck_Player2.Checked;
			txt_Player2Mark.Enabled = chck_Player2.Checked;
		}
		private void chck_Player1_CheckedChanged(object sender, EventArgs e)
		{
			txt_Player1Name.Enabled = chck_Player1.Checked;
			txt_Player1Mark.Enabled = chck_Player1.Checked;
		}
		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
		private void txt_Size_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		private void txt_WinCondition_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
