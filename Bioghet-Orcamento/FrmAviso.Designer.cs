namespace Bioghet_Orcamento
{
    partial class FrmAviso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAviso));
            this.BtOK = new System.Windows.Forms.Button();
            this.TxDigita = new System.Windows.Forms.TextBox();
            this.LbAviso = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // BtOK
            // 
            this.BtOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtOK.Location = new System.Drawing.Point(351, 96);
            this.BtOK.Name = "BtOK";
            this.BtOK.Size = new System.Drawing.Size(52, 38);
            this.BtOK.TabIndex = 0;
            this.BtOK.Text = "OK";
            this.BtOK.UseVisualStyleBackColor = false;
            this.BtOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // TxDigita
            // 
            this.TxDigita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxDigita.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDigita.Location = new System.Drawing.Point(12, 96);
            this.TxDigita.Name = "TxDigita";
            this.TxDigita.Size = new System.Drawing.Size(333, 38);
            this.TxDigita.TabIndex = 1;
            // 
            // LbAviso
            // 
            this.LbAviso.AutoSize = true;
            this.LbAviso.BackColor = System.Drawing.Color.Transparent;
            this.LbAviso.ForeColor = System.Drawing.Color.White;
            this.LbAviso.Location = new System.Drawing.Point(12, 71);
            this.LbAviso.Name = "LbAviso";
            this.LbAviso.Size = new System.Drawing.Size(0, 13);
            this.LbAviso.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Bioghet_Orcamento.Properties.Resources.shutdown;
            this.pictureBox4.Location = new System.Drawing.Point(371, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 235;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // FrmAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bioghet_Orcamento.Properties.Resources.AVISO_fw;
            this.ClientSize = new System.Drawing.Size(415, 148);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.LbAviso);
            this.Controls.Add(this.TxDigita);
            this.Controls.Add(this.BtOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAviso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAviso";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAviso_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmAviso_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmAviso_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtOK;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label LbAviso;
        public System.Windows.Forms.TextBox TxDigita;
    }
}