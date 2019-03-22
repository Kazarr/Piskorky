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
        public int PlayLenght { get; set; }
        public int PlayWidth { get; set; }
        public int WinCondition { get; set; }
        public NewGame()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            int input;
            bool success = int.TryParse(txt_Lenght.Text, out input);
            PlayLenght = input;
            success = int.TryParse(txt_Width.Text, out input);
            PlayWidth = input;
            success = int.TryParse(txt_WinCondition.Text, out input);
            WinCondition = input;
            DialogResult = DialogResult.OK;
        }

        private void NewGame_Enter(object sender, EventArgs e)
        {
            btn_Play_Click(sender, e);
        }
    }
}
