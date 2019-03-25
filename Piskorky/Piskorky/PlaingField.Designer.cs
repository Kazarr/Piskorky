namespace Piskorky
{
    partial class PlaingField
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
            this.dtgw_PlaingField = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_PlaingField)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgw_PlaingField
            // 
            this.dtgw_PlaingField.AllowUserToAddRows = false;
            this.dtgw_PlaingField.AllowUserToDeleteRows = false;
            this.dtgw_PlaingField.AllowUserToResizeColumns = false;
            this.dtgw_PlaingField.AllowUserToResizeRows = false;
            this.dtgw_PlaingField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgw_PlaingField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgw_PlaingField.ColumnHeadersVisible = false;
            this.dtgw_PlaingField.Location = new System.Drawing.Point(13, 13);
            this.dtgw_PlaingField.Name = "dtgw_PlaingField";
            this.dtgw_PlaingField.RowHeadersVisible = false;
            this.dtgw_PlaingField.ShowEditingIcon = false;
            this.dtgw_PlaingField.Size = new System.Drawing.Size(775, 425);
            this.dtgw_PlaingField.TabIndex = 0;
            this.dtgw_PlaingField.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgw_PlaingField_CellClick);
            this.dtgw_PlaingField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgw_PlaingField_KeyPress);
            // 
            // PlaingField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dtgw_PlaingField);
            this.Name = "PlaingField";
            this.Text = "PlaingField";
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_PlaingField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgw_PlaingField;
    }
}