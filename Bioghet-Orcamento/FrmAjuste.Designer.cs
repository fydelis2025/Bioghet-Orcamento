namespace Bioghet_Orcamento
{
    partial class FrmAjuste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjuste));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxCadModelo = new System.Windows.Forms.ComboBox();
            this.TxCadMarca = new System.Windows.Forms.ComboBox();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxNovo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxAparelho = new System.Windows.Forms.TextBox();
            this.TxMargem = new System.Windows.Forms.TextBox();
            this.DtFabricacao = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ChDeletar = new System.Windows.Forms.CheckBox();
            this.ChMOMenos = new System.Windows.Forms.CheckBox();
            this.ChMOMais = new System.Windows.Forms.CheckBox();
            this.ChMargemMenos = new System.Windows.Forms.CheckBox();
            this.ChMargemMais = new System.Windows.Forms.CheckBox();
            this.TxReajusteMargem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxReajusteMO = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(127, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modelo";
            // 
            // TxCadModelo
            // 
            this.TxCadModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxCadModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TxCadModelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxCadModelo.FormattingEnabled = true;
            this.TxCadModelo.Location = new System.Drawing.Point(17, 123);
            this.TxCadModelo.Name = "TxCadModelo";
            this.TxCadModelo.Size = new System.Drawing.Size(227, 21);
            this.TxCadModelo.TabIndex = 170;
            this.TxCadModelo.TextChanged += new System.EventHandler(this.TxCadModelo_TextChanged);
            this.TxCadModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxCadModelo_KeyPress);
            this.TxCadModelo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxCadModelo_KeyUp);
            // 
            // TxCadMarca
            // 
            this.TxCadMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxCadMarca.FormattingEnabled = true;
            this.TxCadMarca.Location = new System.Drawing.Point(127, 80);
            this.TxCadMarca.Name = "TxCadMarca";
            this.TxCadMarca.Size = new System.Drawing.Size(117, 21);
            this.TxCadMarca.TabIndex = 168;
            this.TxCadMarca.SelectedValueChanged += new System.EventHandler(this.TxCadMarca_SelectedValueChanged);
            // 
            // CbTipo
            // 
            this.CbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbTipo.FormattingEnabled = true;
            this.CbTipo.Location = new System.Drawing.Point(15, 80);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(106, 21);
            this.CbTipo.TabIndex = 167;
            this.CbTipo.SelectedValueChanged += new System.EventHandler(this.CbTipo_SelectedValueChanged);
            this.CbTipo.Click += new System.EventHandler(this.CbTipo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(141, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 176;
            this.label5.Text = "R$ Usado";
            // 
            // TxNovo
            // 
            this.TxNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxNovo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxNovo.Enabled = false;
            this.TxNovo.Location = new System.Drawing.Point(32, 36);
            this.TxNovo.MaxLength = 8;
            this.TxNovo.Name = "TxNovo";
            this.TxNovo.Size = new System.Drawing.Size(52, 20);
            this.TxNovo.TabIndex = 171;
            this.TxNovo.Text = "0";
            this.TxNovo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 175;
            this.label7.Text = "R$ Novo";
            // 
            // TxAparelho
            // 
            this.TxAparelho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxAparelho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxAparelho.Enabled = false;
            this.TxAparelho.Location = new System.Drawing.Point(140, 36);
            this.TxAparelho.MaxLength = 8;
            this.TxAparelho.Name = "TxAparelho";
            this.TxAparelho.Size = new System.Drawing.Size(52, 20);
            this.TxAparelho.TabIndex = 173;
            this.TxAparelho.Text = "0";
            this.TxAparelho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxMargem
            // 
            this.TxMargem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxMargem.Enabled = false;
            this.TxMargem.Location = new System.Drawing.Point(86, 36);
            this.TxMargem.MaxLength = 4;
            this.TxMargem.Name = "TxMargem";
            this.TxMargem.Size = new System.Drawing.Size(52, 20);
            this.TxMargem.TabIndex = 172;
            this.TxMargem.Text = "0";
            this.TxMargem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DtFabricacao
            // 
            this.DtFabricacao.AutoSize = true;
            this.DtFabricacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFabricacao.ForeColor = System.Drawing.Color.Orange;
            this.DtFabricacao.Location = new System.Drawing.Point(85, 20);
            this.DtFabricacao.Name = "DtFabricacao";
            this.DtFabricacao.Size = new System.Drawing.Size(32, 13);
            this.DtFabricacao.TabIndex = 174;
            this.DtFabricacao.Text = "(%) -";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.TxNovo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxMargem);
            this.groupBox3.Controls.Add(this.TxAparelho);
            this.groupBox3.Controls.Add(this.DtFabricacao);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(15, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 66);
            this.groupBox3.TabIndex = 182;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valores Novos/Usados";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ChDeletar);
            this.groupBox1.Controls.Add(this.ChMOMenos);
            this.groupBox1.Controls.Add(this.ChMOMais);
            this.groupBox1.Controls.Add(this.ChMargemMenos);
            this.groupBox1.Controls.Add(this.ChMargemMais);
            this.groupBox1.Controls.Add(this.TxReajusteMargem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxReajusteMO);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 74);
            this.groupBox1.TabIndex = 183;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reajustar Orçamento";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(151, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 25);
            this.button1.TabIndex = 184;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChDeletar
            // 
            this.ChDeletar.AutoSize = true;
            this.ChDeletar.Location = new System.Drawing.Point(156, 16);
            this.ChDeletar.Name = "ChDeletar";
            this.ChDeletar.Size = new System.Drawing.Size(60, 17);
            this.ChDeletar.TabIndex = 188;
            this.ChDeletar.Text = "Deletar";
            this.ChDeletar.UseVisualStyleBackColor = true;
            // 
            // ChMOMenos
            // 
            this.ChMOMenos.AutoSize = true;
            this.ChMOMenos.Location = new System.Drawing.Point(112, 16);
            this.ChMOMenos.Name = "ChMOMenos";
            this.ChMOMenos.Size = new System.Drawing.Size(29, 17);
            this.ChMOMenos.TabIndex = 187;
            this.ChMOMenos.Text = "-";
            this.ChMOMenos.UseVisualStyleBackColor = true;
            // 
            // ChMOMais
            // 
            this.ChMOMais.AutoSize = true;
            this.ChMOMais.Location = new System.Drawing.Point(79, 16);
            this.ChMOMais.Name = "ChMOMais";
            this.ChMOMais.Size = new System.Drawing.Size(32, 17);
            this.ChMOMais.TabIndex = 186;
            this.ChMOMais.Text = "+";
            this.ChMOMais.UseVisualStyleBackColor = true;
            // 
            // ChMargemMenos
            // 
            this.ChMargemMenos.AutoSize = true;
            this.ChMargemMenos.Location = new System.Drawing.Point(44, 19);
            this.ChMargemMenos.Name = "ChMargemMenos";
            this.ChMargemMenos.Size = new System.Drawing.Size(29, 17);
            this.ChMargemMenos.TabIndex = 185;
            this.ChMargemMenos.Text = "-";
            this.ChMargemMenos.UseVisualStyleBackColor = true;
            // 
            // ChMargemMais
            // 
            this.ChMargemMais.AutoSize = true;
            this.ChMargemMais.Location = new System.Drawing.Point(6, 19);
            this.ChMargemMais.Name = "ChMargemMais";
            this.ChMargemMais.Size = new System.Drawing.Size(32, 17);
            this.ChMargemMais.TabIndex = 184;
            this.ChMargemMais.Text = "+";
            this.ChMargemMais.UseVisualStyleBackColor = true;
            // 
            // TxReajusteMargem
            // 
            this.TxReajusteMargem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxReajusteMargem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxReajusteMargem.Location = new System.Drawing.Point(6, 36);
            this.TxReajusteMargem.MaxLength = 8;
            this.TxReajusteMargem.Name = "TxReajusteMargem";
            this.TxReajusteMargem.Size = new System.Drawing.Size(63, 20);
            this.TxReajusteMargem.TabIndex = 171;
            this.TxReajusteMargem.Text = "0";
            this.TxReajusteMargem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 175;
            this.label6.Text = "Margem ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(85, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 176;
            this.label8.Text = "M.O";
            // 
            // TxReajusteMO
            // 
            this.TxReajusteMO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxReajusteMO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxReajusteMO.Location = new System.Drawing.Point(75, 35);
            this.TxReajusteMO.MaxLength = 8;
            this.TxReajusteMO.Name = "TxReajusteMO";
            this.TxReajusteMO.Size = new System.Drawing.Size(67, 20);
            this.TxReajusteMO.TabIndex = 173;
            this.TxReajusteMO.Text = "0";
            this.TxReajusteMO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Bioghet_Orcamento.Properties.Resources.shutdown;
            this.pictureBox4.Location = new System.Drawing.Point(213, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 237;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // FrmAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::Bioghet_Orcamento.Properties.Resources.ajuste_fw;
            this.ClientSize = new System.Drawing.Size(254, 294);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TxCadModelo);
            this.Controls.Add(this.TxCadMarca);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAjuste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste";
            this.Load += new System.EventHandler(this.FrmAjuste_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAjuste_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmAjuste_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmAjuste_MouseUp);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DtFabricacao;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox TxCadModelo;
        public System.Windows.Forms.ComboBox TxCadMarca;
        public System.Windows.Forms.ComboBox CbTipo;
        public System.Windows.Forms.TextBox TxNovo;
        public System.Windows.Forms.TextBox TxAparelho;
        public System.Windows.Forms.TextBox TxMargem;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox TxReajusteMargem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TxReajusteMO;
        private System.Windows.Forms.CheckBox ChMOMenos;
        private System.Windows.Forms.CheckBox ChMOMais;
        private System.Windows.Forms.CheckBox ChMargemMenos;
        private System.Windows.Forms.CheckBox ChMargemMais;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ChDeletar;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}