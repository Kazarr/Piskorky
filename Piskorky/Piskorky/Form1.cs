﻿using System;
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
    public partial class Form1 : Form
    {
        public NewGame NewGame { get; set; }
        public PlaingField PlaingField { get; set; }
		public Logic Logic { get; set; }

		public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            using (NewGame)
            {
                NewGame = new NewGame();
                var dialogResultNewGame = NewGame.ShowDialog();
                var isDialogResultOK = dialogResultNewGame == DialogResult.OK;
				Logic = NewGame.Logic;
				if (isDialogResultOK)
                {
                    PlaingField = new PlaingField(Logic);
                    using (PlaingField)
                    {
						var dialogResultPlayinField = PlaingField.ShowDialog();
                        
                    }
                }

            }
        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CreatePlayingField()
        {

        }

        private void btn_LoadGame_Click(object sender, EventArgs e, DataGridView dtgw_PlaingField)
        {
            PlaingField PlaingField = new PlaingField(Datalayer.Load("C:\\Users\\kardos\\source\\repos\\Piskorky2\\Piskorky\\Piskorky\\bin\\Debug\\Piskorky.txt"));
            using (PlaingField)
            {
                var dialogResultPlayinField = PlaingField.ShowDialog();

            }
        }
    }
}
