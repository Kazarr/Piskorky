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
        public NewGame NewGame { get; set; } = new NewGame();
        public PlaingField PlaingField { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            using (NewGame)
            {
                var dialogResultNewGame = NewGame.ShowDialog();
                var isDialogResultOK = dialogResultNewGame == DialogResult.OK;
                if (isDialogResultOK)
                {
                    using(PlaingField)
                    {
                        PlaingField table = new PlaingField(NewGame.PlayLenght, NewGame.PlayWidth);

                        var dialogResultPlaingField = table.ShowDialog();
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
    }
}
