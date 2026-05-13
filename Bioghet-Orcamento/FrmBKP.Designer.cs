namespace Bioghet_Orcamento
{
    partial class FrmBKP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBKP));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butSelectLoc = new System.Windows.Forms.Button();
            this.BtInicio = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GBRestore = new System.Windows.Forms.GroupBox();
            this.BtRestaurar = new System.Windows.Forms.Button();
            this.txtBackupFilePath = new System.Windows.Forms.TextBox();
            this.butBackupFilePath = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.CbBanco = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GBRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.butSelectLoc);
            this.groupBox1.Controls.Add(this.BtInicio);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(22, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 180);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // butSelectLoc
            // 
            this.butSelectLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.butSelectLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSelectLoc.ForeColor = System.Drawing.Color.Black;
            this.butSelectLoc.Location = new System.Drawing.Point(7, 19);
            this.butSelectLoc.Name = "butSelectLoc";
            this.butSelectLoc.Size = new System.Drawing.Size(347, 37);
            this.butSelectLoc.TabIndex = 2;
            this.butSelectLoc.Text = "Local Backup";
            this.butSelectLoc.UseVisualStyleBackColor = false;
            // 
            // BtInicio
            // 
            this.BtInicio.BackColor = System.Drawing.Color.Cyan;
            this.BtInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtInicio.ForeColor = System.Drawing.Color.Black;
            this.BtInicio.Location = new System.Drawing.Point(127, 139);
            this.BtInicio.Name = "BtInicio";
            this.BtInicio.Size = new System.Drawing.Size(129, 29);
            this.BtInicio.TabIndex = 4;
            this.BtInicio.Text = "Inciar Backup";
            this.BtInicio.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(7, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 61);
            this.textBox1.TabIndex = 3;
            // 
            // GBRestore
            // 
            this.GBRestore.BackColor = System.Drawing.Color.Transparent;
            this.GBRestore.Controls.Add(this.BtRestaurar);
            this.GBRestore.Controls.Add(this.txtBackupFilePath);
            this.GBRestore.Controls.Add(this.butBackupFilePath);
            this.GBRestore.ForeColor = System.Drawing.Color.Black;
            this.GBRestore.Location = new System.Drawing.Point(417, 98);
            this.GBRestore.Name = "GBRestore";
            this.GBRestore.Size = new System.Drawing.Size(360, 180);
            this.GBRestore.TabIndex = 13;
            this.GBRestore.TabStop = false;
            this.GBRestore.Text = "Restore";
            // 
            // BtRestaurar
            // 
            this.BtRestaurar.BackColor = System.Drawing.Color.Red;
            this.BtRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRestaurar.Location = new System.Drawing.Point(115, 139);
            this.BtRestaurar.Name = "BtRestaurar";
            this.BtRestaurar.Size = new System.Drawing.Size(129, 29);
            this.BtRestaurar.TabIndex = 2;
            this.BtRestaurar.Text = "Restaurar Backup";
            this.BtRestaurar.UseVisualStyleBackColor = false;
            // 
            // txtBackupFilePath
            // 
            this.txtBackupFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBackupFilePath.Location = new System.Drawing.Point(6, 62);
            this.txtBackupFilePath.Multiline = true;
            this.txtBackupFilePath.Name = "txtBackupFilePath";
            this.txtBackupFilePath.Size = new System.Drawing.Size(342, 61);
            this.txtBackupFilePath.TabIndex = 1;
            // 
            // butBackupFilePath
            // 
            this.butBackupFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butBackupFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBackupFilePath.ForeColor = System.Drawing.Color.Black;
            this.butBackupFilePath.Location = new System.Drawing.Point(6, 19);
            this.butBackupFilePath.Name = "butBackupFilePath";
            this.butBackupFilePath.Size = new System.Drawing.Size(342, 37);
            this.butBackupFilePath.TabIndex = 0;
            this.butBackupFilePath.Text = "Selecionar Arquivo Backup";
            this.butBackupFilePath.UseVisualStyleBackColor = false;
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Location = new System.Drawing.Point(57, 66);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(42, 20);
            this.txtPort.TabIndex = 15;
            this.txtPort.Text = "5432";
            // 
            // CbBanco
            // 
            this.CbBanco.FormattingEnabled = true;
            this.CbBanco.Location = new System.Drawing.Point(149, 65);
            this.CbBanco.Name = "CbBanco";
            this.CbBanco.Size = new System.Drawing.Size(243, 21);
            this.CbBanco.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Bioghet_Orcamento.Properties.Resources.shutdown;
            this.pictureBox4.Location = new System.Drawing.Point(769, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 236;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 237;
            this.label1.Text = "Porta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 238;
            this.label2.Text = "Banco";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.Transparent;
            this.labelLocation.ForeColor = System.Drawing.Color.White;
            this.labelLocation.Location = new System.Drawing.Point(414, 68);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(0, 13);
            this.labelLocation.TabIndex = 239;
            // 
            // FrmBKP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::Bioghet_Orcamento.Properties.Resources.BACKUP1;
            this.ClientSize = new System.Drawing.Size(815, 306);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.CbBanco);
            this.Controls.Add(this.GBRestore);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBKP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.FrmBKP_Load);
            this.Shown += new System.EventHandler(this.FrmBKP_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmBKP_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmBKP_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmBKP_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBRestore.ResumeLayout(false);
            this.GBRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butSelectLoc;
        private System.Windows.Forms.Button BtInicio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox GBRestore;
        private System.Windows.Forms.Button BtRestaurar;
        private System.Windows.Forms.TextBox txtBackupFilePath;
        private System.Windows.Forms.Button butBackupFilePath;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.ComboBox CbBanco;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLocation;
    }
}