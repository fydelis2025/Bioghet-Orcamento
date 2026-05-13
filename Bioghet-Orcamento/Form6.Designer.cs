namespace Bioghet_Orcamento
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.TxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxEmail = new System.Windows.Forms.TextBox();
            this.DgFuncionario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtSalvarImg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ChMostrar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // TxNome
            // 
            this.TxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxNome.Location = new System.Drawing.Point(12, 32);
            this.TxNome.Name = "TxNome";
            this.TxNome.Size = new System.Drawing.Size(212, 20);
            this.TxNome.TabIndex = 0;
            this.TxNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxNome_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // TxCPF
            // 
            this.TxCPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxCPF.Location = new System.Drawing.Point(230, 32);
            this.TxCPF.MaxLength = 11;
            this.TxCPF.Name = "TxCPF";
            this.TxCPF.Size = new System.Drawing.Size(142, 20);
            this.TxCPF.TabIndex = 2;
            this.TxCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxCPF_KeyDown);
            this.TxCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxCPF_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(227, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone";
            // 
            // TxTelefone
            // 
            this.TxTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxTelefone.Location = new System.Drawing.Point(12, 75);
            this.TxTelefone.MaxLength = 11;
            this.TxTelefone.Name = "TxTelefone";
            this.TxTelefone.Size = new System.Drawing.Size(142, 20);
            this.TxTelefone.TabIndex = 4;
            this.TxTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxTelefone_KeyDown);
            this.TxTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTelefone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(157, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // TxEmail
            // 
            this.TxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxEmail.Location = new System.Drawing.Point(160, 75);
            this.TxEmail.Name = "TxEmail";
            this.TxEmail.Size = new System.Drawing.Size(212, 20);
            this.TxEmail.TabIndex = 6;
            // 
            // DgFuncionario
            // 
            this.DgFuncionario.AllowUserToAddRows = false;
            this.DgFuncionario.AllowUserToDeleteRows = false;
            this.DgFuncionario.AllowUserToResizeColumns = false;
            this.DgFuncionario.AllowUserToResizeRows = false;
            this.DgFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.DgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.DgFuncionario.Location = new System.Drawing.Point(12, 148);
            this.DgFuncionario.Name = "DgFuncionario";
            this.DgFuncionario.RowHeadersVisible = false;
            this.DgFuncionario.Size = new System.Drawing.Size(360, 166);
            this.DgFuncionario.TabIndex = 8;
            this.DgFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgFuncionario_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Telefone";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.FillWeight = 70F;
            this.Column4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column4.HeaderText = "Editar";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.UseColumnTextForButtonValue = true;
            this.Column4.Width = 70;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.FillWeight = 70F;
            this.Column3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column3.HeaderText = "Excluir";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.UseColumnTextForButtonValue = true;
            this.Column3.Width = 70;
            // 
            // BtSalvarImg
            // 
            this.BtSalvarImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtSalvarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSalvarImg.Location = new System.Drawing.Point(242, 119);
            this.BtSalvarImg.Name = "BtSalvarImg";
            this.BtSalvarImg.Size = new System.Drawing.Size(62, 23);
            this.BtSalvarImg.TabIndex = 110;
            this.BtSalvarImg.Text = "Salvar";
            this.BtSalvarImg.UseVisualStyleBackColor = false;
            this.BtSalvarImg.Click += new System.EventHandler(this.BtSalvarImg_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(310, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 111;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(174, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 112;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChMostrar
            // 
            this.ChMostrar.AutoSize = true;
            this.ChMostrar.BackColor = System.Drawing.Color.Transparent;
            this.ChMostrar.ForeColor = System.Drawing.Color.White;
            this.ChMostrar.Location = new System.Drawing.Point(12, 119);
            this.ChMostrar.Name = "ChMostrar";
            this.ChMostrar.Size = new System.Drawing.Size(121, 17);
            this.ChMostrar.TabIndex = 113;
            this.ChMostrar.Text = "Mostar Funcionários";
            this.ChMostrar.UseVisualStyleBackColor = false;
            this.ChMostrar.Click += new System.EventHandler(this.ChMostrar_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(387, 328);
            this.Controls.Add(this.ChMostrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtSalvarImg);
            this.Controls.Add(this.DgFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.DgFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxEmail;
        private System.Windows.Forms.DataGridView DgFuncionario;
        private System.Windows.Forms.Button BtSalvarImg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ChMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}