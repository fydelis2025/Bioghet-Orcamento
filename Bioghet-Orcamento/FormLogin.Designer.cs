namespace Bioghet_Orcamento
{
    partial class FormLogin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.TxNome = new System.Windows.Forms.TextBox();
            this.TxUsuario = new System.Windows.Forms.TextBox();
            this.TxSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChAdm = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DgConsulta = new System.Windows.Forms.DataGridView();
            this.ChUser = new System.Windows.Forms.CheckBox();
            this.ChMostrar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbFilial = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ChBloqueado = new System.Windows.Forms.CheckBox();
            this.PImage = new System.Windows.Forms.PictureBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelImgQuality = new System.Windows.Forms.Label();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TxNome
            // 
            this.TxNome.Location = new System.Drawing.Point(17, 84);
            this.TxNome.Name = "TxNome";
            this.TxNome.Size = new System.Drawing.Size(119, 20);
            this.TxNome.TabIndex = 185;
            // 
            // TxUsuario
            // 
            this.TxUsuario.Location = new System.Drawing.Point(142, 84);
            this.TxUsuario.Name = "TxUsuario";
            this.TxUsuario.Size = new System.Drawing.Size(116, 20);
            this.TxUsuario.TabIndex = 186;
            // 
            // TxSenha
            // 
            this.TxSenha.Location = new System.Drawing.Point(264, 84);
            this.TxSenha.Name = "TxSenha";
            this.TxSenha.Size = new System.Drawing.Size(131, 20);
            this.TxSenha.TabIndex = 187;
            this.TxSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 188;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 189;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(266, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 190;
            this.label3.Text = "Senha";
            // 
            // ChAdm
            // 
            this.ChAdm.AutoSize = true;
            this.ChAdm.BackColor = System.Drawing.Color.Transparent;
            this.ChAdm.ForeColor = System.Drawing.Color.White;
            this.ChAdm.Location = new System.Drawing.Point(17, 154);
            this.ChAdm.Name = "ChAdm";
            this.ChAdm.Size = new System.Drawing.Size(89, 17);
            this.ChAdm.TabIndex = 191;
            this.ChAdm.Text = "Administrador";
            this.ChAdm.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Bioghet_Orcamento.Properties.Resources._7;
            this.button2.Location = new System.Drawing.Point(237, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 74);
            this.button2.TabIndex = 193;
            this.button2.Text = "Salvar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DgConsulta
            // 
            this.DgConsulta.AllowUserToAddRows = false;
            this.DgConsulta.AllowUserToDeleteRows = false;
            this.DgConsulta.AllowUserToResizeColumns = false;
            this.DgConsulta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgConsulta.BackgroundColor = System.Drawing.Color.White;
            this.DgConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Senha,
            this.Column10,
            this.Column9});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgConsulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgConsulta.GridColor = System.Drawing.Color.Silver;
            this.DgConsulta.Location = new System.Drawing.Point(8, 202);
            this.DgConsulta.Name = "DgConsulta";
            this.DgConsulta.RowHeadersVisible = false;
            this.DgConsulta.Size = new System.Drawing.Size(387, 201);
            this.DgConsulta.TabIndex = 194;
            this.DgConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgConsulta_CellClick);
            // 
            // ChUser
            // 
            this.ChUser.AutoSize = true;
            this.ChUser.BackColor = System.Drawing.Color.Transparent;
            this.ChUser.ForeColor = System.Drawing.Color.White;
            this.ChUser.Location = new System.Drawing.Point(91, 175);
            this.ChUser.Name = "ChUser";
            this.ChUser.Size = new System.Drawing.Size(79, 17);
            this.ChUser.TabIndex = 195;
            this.ChUser.Text = "Listar Tudo";
            this.ChUser.UseVisualStyleBackColor = false;
            this.ChUser.Click += new System.EventHandler(this.ChUser_Click);
            // 
            // ChMostrar
            // 
            this.ChMostrar.AutoSize = true;
            this.ChMostrar.BackColor = System.Drawing.Color.Transparent;
            this.ChMostrar.ForeColor = System.Drawing.Color.White;
            this.ChMostrar.Location = new System.Drawing.Point(334, 67);
            this.ChMostrar.Name = "ChMostrar";
            this.ChMostrar.Size = new System.Drawing.Size(61, 17);
            this.ChMostrar.TabIndex = 196;
            this.ChMostrar.Text = "Mostrar";
            this.ChMostrar.UseVisualStyleBackColor = false;
            this.ChMostrar.Click += new System.EventHandler(this.ChMostrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 198;
            this.label4.Text = "Filial";
            // 
            // CbFilial
            // 
            this.CbFilial.FormattingEnabled = true;
            this.CbFilial.Location = new System.Drawing.Point(17, 127);
            this.CbFilial.Name = "CbFilial";
            this.CbFilial.Size = new System.Drawing.Size(157, 21);
            this.CbFilial.TabIndex = 197;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Bioghet_Orcamento.Properties.Resources.minimize_thewindow_theapplication_2872;
            this.pictureBox1.Location = new System.Drawing.Point(326, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 237;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Bioghet_Orcamento.Properties.Resources.shutdown;
            this.pictureBox4.Location = new System.Drawing.Point(361, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 236;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Bioghet_Orcamento.Properties.Resources._8;
            this.button3.Location = new System.Drawing.Point(180, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 74);
            this.button3.TabIndex = 238;
            this.button3.Text = "Novo";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ChBloqueado
            // 
            this.ChBloqueado.AutoSize = true;
            this.ChBloqueado.BackColor = System.Drawing.Color.Transparent;
            this.ChBloqueado.ForeColor = System.Drawing.Color.White;
            this.ChBloqueado.Location = new System.Drawing.Point(17, 175);
            this.ChBloqueado.Name = "ChBloqueado";
            this.ChBloqueado.Size = new System.Drawing.Size(68, 17);
            this.ChBloqueado.TabIndex = 239;
            this.ChBloqueado.Text = "Bloquear";
            this.ChBloqueado.UseVisualStyleBackColor = false;
            // 
            // PImage
            // 
            this.PImage.BackColor = System.Drawing.Color.White;
            this.PImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PImage.Location = new System.Drawing.Point(294, 110);
            this.PImage.Name = "PImage";
            this.PImage.Size = new System.Drawing.Size(99, 82);
            this.PImage.TabIndex = 240;
            this.PImage.TabStop = false;
            this.PImage.Click += new System.EventHandler(this.PImage_Click);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.Transparent;
            this.labelResult.Location = new System.Drawing.Point(319, 48);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(38, 16);
            this.labelResult.TabIndex = 242;
            this.labelResult.Visible = false;
            // 
            // labelImgQuality
            // 
            this.labelImgQuality.BackColor = System.Drawing.Color.Transparent;
            this.labelImgQuality.Location = new System.Drawing.Point(360, 48);
            this.labelImgQuality.Name = "labelImgQuality";
            this.labelImgQuality.Size = new System.Drawing.Size(35, 16);
            this.labelImgQuality.TabIndex = 241;
            this.labelImgQuality.Visible = false;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 150F;
            this.Column6.HeaderText = "Nome";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Usuario";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Senha
            // 
            this.Senha.FillWeight = 70F;
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.Visible = false;
            this.Senha.Width = 70;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 50F;
            this.Column10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column10.HeaderText = "Editar";
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column10.Text = "Editar";
            this.Column10.UseColumnTextForButtonValue = true;
            this.Column10.Width = 50;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 50F;
            this.Column9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column9.HeaderText = "Excluir";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column9.Text = "Excluir";
            this.Column9.UseColumnTextForButtonValue = true;
            this.Column9.Width = 50;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::Bioghet_Orcamento.Properties.Resources.LOGIN1;
            this.ClientSize = new System.Drawing.Size(407, 421);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelImgQuality);
            this.Controls.Add(this.PImage);
            this.Controls.Add(this.ChBloqueado);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbFilial);
            this.Controls.Add(this.ChMostrar);
            this.Controls.Add(this.ChUser);
            this.Controls.Add(this.DgConsulta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ChAdm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxSenha);
            this.Controls.Add(this.TxUsuario);
            this.Controls.Add(this.TxNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxNome;
        private System.Windows.Forms.TextBox TxUsuario;
        private System.Windows.Forms.TextBox TxSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChAdm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DgConsulta;
        private System.Windows.Forms.CheckBox ChUser;
        private System.Windows.Forms.CheckBox ChMostrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbFilial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox ChBloqueado;
        private System.Windows.Forms.PictureBox PImage;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelImgQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
    }
}