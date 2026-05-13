namespace Bioghet_Orcamento
{
    partial class Form9
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.TxSenha = new System.Windows.Forms.TextBox();
            this.TxLogin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CbFilial = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LbHost = new System.Windows.Forms.Label();
            this.labelImgQuality = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.Bioghet = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TxSenha
            // 
            this.TxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxSenha.Location = new System.Drawing.Point(206, 254);
            this.TxSenha.Name = "TxSenha";
            this.TxSenha.Size = new System.Drawing.Size(238, 22);
            this.TxSenha.TabIndex = 1;
            this.TxSenha.UseSystemPasswordChar = true;
            this.TxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxSenha_KeyDown);
            // 
            // TxLogin
            // 
            this.TxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxLogin.Location = new System.Drawing.Point(206, 183);
            this.TxLogin.Name = "TxLogin";
            this.TxLogin.Size = new System.Drawing.Size(238, 22);
            this.TxLogin.TabIndex = 0;
            this.TxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxLogin_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(14, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Image = global::Bioghet_Orcamento.Properties.Resources.fechar_fw;
            this.button2.Location = new System.Drawing.Point(95, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 72);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sair";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Bioghet_Orcamento.Properties.Resources.download2;
            this.pictureBox2.Location = new System.Drawing.Point(27, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.Bioghet.SetToolTip(this.pictureBox2, "CLIQUE AQUI PARA INICIALIZAR A LEITURA");
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // CbFilial
            // 
            this.CbFilial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFilial.FormattingEnabled = true;
            this.CbFilial.Location = new System.Drawing.Point(206, 113);
            this.CbFilial.Name = "CbFilial";
            this.CbFilial.Size = new System.Drawing.Size(238, 24);
            this.CbFilial.TabIndex = 9;
            this.CbFilial.Click += new System.EventHandler(this.CbFilial_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Bioghet_Orcamento.Properties.Resources.servidor_web_png_;
            this.pictureBox3.Location = new System.Drawing.Point(31, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // LbHost
            // 
            this.LbHost.AutoSize = true;
            this.LbHost.BackColor = System.Drawing.Color.Transparent;
            this.LbHost.ForeColor = System.Drawing.Color.White;
            this.LbHost.Location = new System.Drawing.Point(28, 66);
            this.LbHost.Name = "LbHost";
            this.LbHost.Size = new System.Drawing.Size(0, 13);
            this.LbHost.TabIndex = 13;
            // 
            // labelImgQuality
            // 
            this.labelImgQuality.BackColor = System.Drawing.Color.Transparent;
            this.labelImgQuality.Location = new System.Drawing.Point(92, 240);
            this.labelImgQuality.Name = "labelImgQuality";
            this.labelImgQuality.Size = new System.Drawing.Size(35, 16);
            this.labelImgQuality.TabIndex = 14;
            this.labelImgQuality.Text = "0";
            this.labelImgQuality.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.Transparent;
            this.labelResult.Location = new System.Drawing.Point(51, 240);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(38, 16);
            this.labelResult.TabIndex = 15;
            this.labelResult.Visible = false;
            // 
            // Bioghet
            // 
            this.Bioghet.BackColor = System.Drawing.Color.SteelBlue;
            this.Bioghet.ForeColor = System.Drawing.Color.White;
            this.Bioghet.IsBalloon = true;
            this.Bioghet.ShowAlways = true;
            this.Bioghet.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Bioghet.ToolTipTitle = "Bioghet - Aviso";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(473, 352);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelImgQuality);
            this.Controls.Add(this.LbHost);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.CbFilial);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxLogin);
            this.Controls.Add(this.TxSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso restrito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form9_FormClosing);
            this.Load += new System.EventHandler(this.Form9_Load);
            this.Shown += new System.EventHandler(this.Form9_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxSenha;
        private System.Windows.Forms.TextBox TxLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox CbFilial;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LbHost;
        private System.Windows.Forms.Label labelImgQuality;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ToolTip Bioghet;
    }
}