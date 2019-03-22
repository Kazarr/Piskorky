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
            this.lbl_Width = new System.Windows.Forms.Label();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.lbl_Lenght = new System.Windows.Forms.Label();
            this.txt_Lenght = new System.Windows.Forms.TextBox();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_WinCondition
            // 
            this.lbl_WinCondition.AutoSize = true;
            this.lbl_WinCondition.BackColor = System.Drawing.Color.Transparent;
            this.lbl_WinCondition.Location = new System.Drawing.Point(172, 140);
            this.lbl_WinCondition.Name = "lbl_WinCondition";
            this.lbl_WinCondition.Size = new System.Drawing.Size(72, 13);
            this.lbl_WinCondition.TabIndex = 0;
            this.lbl_WinCondition.Text = "Win condition";
            // 
            // txt_WinCondition
            // 
            this.txt_WinCondition.Location = new System.Drawing.Point(172, 156);
            this.txt_WinCondition.Name = "txt_WinCondition";
            this.txt_WinCondition.Size = new System.Drawing.Size(72, 20);
            this.txt_WinCondition.TabIndex = 1;
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Width.Location = new System.Drawing.Point(301, 140);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(35, 13);
            this.lbl_Width.TabIndex = 2;
            this.lbl_Width.Text = "Width";
            // 
            // txt_Width
            // 
            this.txt_Width.Location = new System.Drawing.Point(281, 156);
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(72, 20);
            this.txt_Width.TabIndex = 3;
            // 
            // lbl_Lenght
            // 
            this.lbl_Lenght.AutoSize = true;
            this.lbl_Lenght.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Lenght.Location = new System.Drawing.Point(407, 140);
            this.lbl_Lenght.Name = "lbl_Lenght";
            this.lbl_Lenght.Size = new System.Drawing.Size(40, 13);
            this.lbl_Lenght.TabIndex = 4;
            this.lbl_Lenght.Text = "Lenght";
            // 
            // txt_Lenght
            // 
            this.txt_Lenght.Location = new System.Drawing.Point(389, 156);
            this.txt_Lenght.Name = "txt_Lenght";
            this.txt_Lenght.Size = new System.Drawing.Size(72, 20);
            this.txt_Lenght.TabIndex = 5;
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(537, 246);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(75, 23);
            this.btn_Play.TabIndex = 6;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(12, 246);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 281);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.txt_Lenght);
            this.Controls.Add(this.lbl_Lenght);
            this.Controls.Add(this.txt_Width);
            this.Controls.Add(this.lbl_Width);
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
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.Label lbl_Lenght;
        private System.Windows.Forms.TextBox txt_Lenght;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Cancel;
    }
}