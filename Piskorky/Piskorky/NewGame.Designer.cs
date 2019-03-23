namespace Piskorky
{
    partial class NewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
			this.lbl_WinCondition = new System.Windows.Forms.Label();
			this.txt_WinCondition = new System.Windows.Forms.TextBox();
			this.lbl_Lenght = new System.Windows.Forms.Label();
			this.txt_Size = new System.Windows.Forms.TextBox();
			this.btn_Play = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.txt_Player1Name = new System.Windows.Forms.TextBox();
			this.txt_Player2Name = new System.Windows.Forms.TextBox();
			this.txt_Player3Name = new System.Windows.Forms.TextBox();
			this.txt_Player4Name = new System.Windows.Forms.TextBox();
			this.txt_Player1Mark = new System.Windows.Forms.TextBox();
			this.txt_Player2Mark = new System.Windows.Forms.TextBox();
			this.txt_Player3Mark = new System.Windows.Forms.TextBox();
			this.txt_Player4Mark = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.chck_Player1 = new System.Windows.Forms.CheckBox();
			this.chck_Player2 = new System.Windows.Forms.CheckBox();
			this.chck_Player3 = new System.Windows.Forms.CheckBox();
			this.chck_Player4 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// lbl_WinCondition
			// 
			this.lbl_WinCondition.AutoSize = true;
			this.lbl_WinCondition.BackColor = System.Drawing.Color.Transparent;
			this.lbl_WinCondition.Location = new System.Drawing.Point(260, 5);
			this.lbl_WinCondition.Name = "lbl_WinCondition";
			this.lbl_WinCondition.Size = new System.Drawing.Size(72, 13);
			this.lbl_WinCondition.TabIndex = 0;
			this.lbl_WinCondition.Text = "Win condition";
			// 
			// txt_WinCondition
			// 
			this.txt_WinCondition.Location = new System.Drawing.Point(260, 21);
			this.txt_WinCondition.Name = "txt_WinCondition";
			this.txt_WinCondition.Size = new System.Drawing.Size(72, 20);
			this.txt_WinCondition.TabIndex = 1;
			this.txt_WinCondition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_WinCondition_KeyPress);
			// 
			// lbl_Lenght
			// 
			this.lbl_Lenght.AutoSize = true;
			this.lbl_Lenght.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Lenght.Location = new System.Drawing.Point(351, 5);
			this.lbl_Lenght.Name = "lbl_Lenght";
			this.lbl_Lenght.Size = new System.Drawing.Size(27, 13);
			this.lbl_Lenght.TabIndex = 4;
			this.lbl_Lenght.Text = "Size";
			// 
			// txt_Size
			// 
			this.txt_Size.Location = new System.Drawing.Point(338, 21);
			this.txt_Size.Name = "txt_Size";
			this.txt_Size.Size = new System.Drawing.Size(72, 20);
			this.txt_Size.TabIndex = 5;
			this.txt_Size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Size_KeyPress);
			// 
			// btn_Play
			// 
			this.btn_Play.Location = new System.Drawing.Point(330, 198);
			this.btn_Play.Name = "btn_Play";
			this.btn_Play.Size = new System.Drawing.Size(75, 23);
			this.btn_Play.TabIndex = 6;
			this.btn_Play.Text = "Play";
			this.btn_Play.UseVisualStyleBackColor = true;
			this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(12, 198);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 7;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// txt_Player1Name
			// 
			this.txt_Player1Name.Location = new System.Drawing.Point(45, 21);
			this.txt_Player1Name.Name = "txt_Player1Name";
			this.txt_Player1Name.Size = new System.Drawing.Size(100, 20);
			this.txt_Player1Name.TabIndex = 8;
			this.txt_Player1Name.Text = "Player1Name";
			// 
			// txt_Player2Name
			// 
			this.txt_Player2Name.Location = new System.Drawing.Point(45, 47);
			this.txt_Player2Name.Name = "txt_Player2Name";
			this.txt_Player2Name.Size = new System.Drawing.Size(100, 20);
			this.txt_Player2Name.TabIndex = 9;
			this.txt_Player2Name.Text = "Player2Name";
			// 
			// txt_Player3Name
			// 
			this.txt_Player3Name.Location = new System.Drawing.Point(45, 73);
			this.txt_Player3Name.Name = "txt_Player3Name";
			this.txt_Player3Name.Size = new System.Drawing.Size(100, 20);
			this.txt_Player3Name.TabIndex = 10;
			this.txt_Player3Name.Text = "Player3Name";
			// 
			// txt_Player4Name
			// 
			this.txt_Player4Name.Location = new System.Drawing.Point(45, 100);
			this.txt_Player4Name.Name = "txt_Player4Name";
			this.txt_Player4Name.Size = new System.Drawing.Size(100, 20);
			this.txt_Player4Name.TabIndex = 11;
			this.txt_Player4Name.Text = "Player4Name";
			// 
			// txt_Player1Mark
			// 
			this.txt_Player1Mark.Location = new System.Drawing.Point(151, 21);
			this.txt_Player1Mark.Name = "txt_Player1Mark";
			this.txt_Player1Mark.Size = new System.Drawing.Size(100, 20);
			this.txt_Player1Mark.TabIndex = 12;
			this.txt_Player1Mark.Text = "X";
			// 
			// txt_Player2Mark
			// 
			this.txt_Player2Mark.Location = new System.Drawing.Point(151, 47);
			this.txt_Player2Mark.Name = "txt_Player2Mark";
			this.txt_Player2Mark.Size = new System.Drawing.Size(100, 20);
			this.txt_Player2Mark.TabIndex = 13;
			this.txt_Player2Mark.Text = "O";
			// 
			// txt_Player3Mark
			// 
			this.txt_Player3Mark.Location = new System.Drawing.Point(151, 73);
			this.txt_Player3Mark.Name = "txt_Player3Mark";
			this.txt_Player3Mark.Size = new System.Drawing.Size(100, 20);
			this.txt_Player3Mark.TabIndex = 14;
			this.txt_Player3Mark.Text = "T";
			// 
			// txt_Player4Mark
			// 
			this.txt_Player4Mark.Location = new System.Drawing.Point(151, 100);
			this.txt_Player4Mark.Name = "txt_Player4Mark";
			this.txt_Player4Mark.Size = new System.Drawing.Size(100, 20);
			this.txt_Player4Mark.TabIndex = 15;
			this.txt_Player4Mark.Text = "S";
			// 
			// chck_Player1
			// 
			this.chck_Player1.AutoSize = true;
			this.chck_Player1.Checked = true;
			this.chck_Player1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chck_Player1.Location = new System.Drawing.Point(13, 23);
			this.chck_Player1.Name = "chck_Player1";
			this.chck_Player1.Size = new System.Drawing.Size(15, 14);
			this.chck_Player1.TabIndex = 16;
			this.chck_Player1.UseVisualStyleBackColor = true;
			this.chck_Player1.CheckedChanged += new System.EventHandler(this.chck_Player1_CheckedChanged);
			// 
			// chck_Player2
			// 
			this.chck_Player2.AutoSize = true;
			this.chck_Player2.Checked = true;
			this.chck_Player2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chck_Player2.Location = new System.Drawing.Point(13, 49);
			this.chck_Player2.Name = "chck_Player2";
			this.chck_Player2.Size = new System.Drawing.Size(15, 14);
			this.chck_Player2.TabIndex = 17;
			this.chck_Player2.UseVisualStyleBackColor = true;
			this.chck_Player2.CheckedChanged += new System.EventHandler(this.chck_Player2_CheckedChanged);
			// 
			// chck_Player3
			// 
			this.chck_Player3.AutoSize = true;
			this.chck_Player3.Checked = true;
			this.chck_Player3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chck_Player3.Location = new System.Drawing.Point(13, 75);
			this.chck_Player3.Name = "chck_Player3";
			this.chck_Player3.Size = new System.Drawing.Size(15, 14);
			this.chck_Player3.TabIndex = 18;
			this.chck_Player3.UseVisualStyleBackColor = true;
			this.chck_Player3.CheckedChanged += new System.EventHandler(this.chck_Player3_CheckedChanged);
			// 
			// chck_Player4
			// 
			this.chck_Player4.AutoSize = true;
			this.chck_Player4.Checked = true;
			this.chck_Player4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chck_Player4.Location = new System.Drawing.Point(12, 102);
			this.chck_Player4.Name = "chck_Player4";
			this.chck_Player4.Size = new System.Drawing.Size(15, 14);
			this.chck_Player4.TabIndex = 19;
			this.chck_Player4.UseVisualStyleBackColor = true;
			this.chck_Player4.CheckedChanged += new System.EventHandler(this.chck_Player4_CheckedChanged);
			// 
			// NewGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(417, 223);
			this.Controls.Add(this.chck_Player4);
			this.Controls.Add(this.chck_Player3);
			this.Controls.Add(this.chck_Player2);
			this.Controls.Add(this.chck_Player1);
			this.Controls.Add(this.txt_Player4Mark);
			this.Controls.Add(this.txt_Player3Mark);
			this.Controls.Add(this.txt_Player2Mark);
			this.Controls.Add(this.txt_Player1Mark);
			this.Controls.Add(this.txt_Player4Name);
			this.Controls.Add(this.txt_Player3Name);
			this.Controls.Add(this.txt_Player2Name);
			this.Controls.Add(this.txt_Player1Name);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Play);
			this.Controls.Add(this.txt_Size);
			this.Controls.Add(this.lbl_Lenght);
			this.Controls.Add(this.txt_WinCondition);
			this.Controls.Add(this.lbl_WinCondition);
			this.Name = "NewGame";
			this.Text = "NewGame";
			this.Enter += new System.EventHandler(this.NewGame_Enter);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WinCondition;
        private System.Windows.Forms.TextBox txt_WinCondition;
        private System.Windows.Forms.Label lbl_Lenght;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.TextBox txt_Player1Name;
		private System.Windows.Forms.TextBox txt_Player2Name;
		private System.Windows.Forms.TextBox txt_Player3Name;
		private System.Windows.Forms.TextBox txt_Player4Name;
		private System.Windows.Forms.TextBox txt_Player1Mark;
		private System.Windows.Forms.TextBox txt_Player2Mark;
		private System.Windows.Forms.TextBox txt_Player3Mark;
		private System.Windows.Forms.TextBox txt_Player4Mark;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.CheckBox chck_Player1;
		private System.Windows.Forms.CheckBox chck_Player2;
		private System.Windows.Forms.CheckBox chck_Player3;
		private System.Windows.Forms.CheckBox chck_Player4;
	}
}