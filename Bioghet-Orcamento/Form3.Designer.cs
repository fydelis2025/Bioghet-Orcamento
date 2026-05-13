namespace Bioghet_Orcamento
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.DgOrcamento = new System.Windows.Forms.DataGridView();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RdCliente = new System.Windows.Forms.RadioButton();
            this.RdCpf = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.RdImei = new System.Windows.Forms.RadioButton();
            this.BtFechar = new System.Windows.Forms.PictureBox();
            this.BtPesquisar = new System.Windows.Forms.PictureBox();
            this.PFoto2 = new System.Windows.Forms.PictureBox();
            this.PFoto1 = new System.Windows.Forms.PictureBox();
            this.PFoto = new System.Windows.Forms.PictureBox();
            this.RdTudo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgOrcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // DgOrcamento
            // 
            this.DgOrcamento.AllowUserToAddRows = false;
            this.DgOrcamento.AllowUserToDeleteRows = false;
            this.DgOrcamento.AllowUserToResizeColumns = false;
            this.DgOrcamento.AllowUserToResizeRows = false;
            this.DgOrcamento.BackgroundColor = System.Drawing.Color.White;
            this.DgOrcamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgOrcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLIENTE,
            this.CPF,
            this.TELEFONE,
            this.MARCA,
            this.MODELO,
            this.IMEI});
            this.DgOrcamento.Location = new System.Drawing.Point(11, 108);
            this.DgOrcamento.Name = "DgOrcamento";
            this.DgOrcamento.RowHeadersVisible = false;
            this.DgOrcamento.Size = new System.Drawing.Size(868, 557);
            this.DgOrcamento.TabIndex = 0;
            this.DgOrcamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOrcamento_CellClick);
            // 
            // CLIENTE
            // 
            this.CLIENTE.FillWeight = 250F;
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Width = 250;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CNPJ/CPF";
            this.CPF.Name = "CPF";
            // 
            // TELEFONE
            // 
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.Name = "TELEFONE";
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            // 
            // MODELO
            // 
            this.MODELO.HeaderText = "MODELO";
            this.MODELO.Name = "MODELO";
            // 
            // IMEI
            // 
            this.IMEI.HeaderText = "IMEI";
            this.IMEI.Name = "IMEI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(882, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Foto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(885, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Foto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(885, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Foto";
            // 
            // TxBuscar
            // 
            this.TxBuscar.Location = new System.Drawing.Point(11, 64);
            this.TxBuscar.Name = "TxBuscar";
            this.TxBuscar.Size = new System.Drawing.Size(330, 20);
            this.TxBuscar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Informe aqui dados para pesquisa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RdCliente
            // 
            this.RdCliente.AutoSize = true;
            this.RdCliente.BackColor = System.Drawing.Color.Transparent;
            this.RdCliente.ForeColor = System.Drawing.Color.White;
            this.RdCliente.Location = new System.Drawing.Point(401, 44);
            this.RdCliente.Name = "RdCliente";
            this.RdCliente.Size = new System.Drawing.Size(57, 17);
            this.RdCliente.TabIndex = 10;
            this.RdCliente.Text = "Cliente";
            this.RdCliente.UseVisualStyleBackColor = false;
            // 
            // RdCpf
            // 
            this.RdCpf.AutoSize = true;
            this.RdCpf.BackColor = System.Drawing.Color.Transparent;
            this.RdCpf.ForeColor = System.Drawing.Color.White;
            this.RdCpf.Location = new System.Drawing.Point(401, 67);
            this.RdCpf.Name = "RdCpf";
            this.RdCpf.Size = new System.Drawing.Size(77, 17);
            this.RdCpf.TabIndex = 11;
            this.RdCpf.Text = "CNPJ/CPF";
            this.RdCpf.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(826, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fechar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RdImei
            // 
            this.RdImei.AutoSize = true;
            this.RdImei.BackColor = System.Drawing.Color.Transparent;
            this.RdImei.ForeColor = System.Drawing.Color.White;
            this.RdImei.Location = new System.Drawing.Point(495, 46);
            this.RdImei.Name = "RdImei";
            this.RdImei.Size = new System.Drawing.Size(85, 17);
            this.RdImei.TabIndex = 14;
            this.RdImei.Text = "Imei/Serviço";
            this.RdImei.UseVisualStyleBackColor = false;
            // 
            // BtFechar
            // 
            this.BtFechar.BackColor = System.Drawing.Color.Transparent;
            this.BtFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtFechar.Image = ((System.Drawing.Image)(resources.GetObject("BtFechar.Image")));
            this.BtFechar.Location = new System.Drawing.Point(829, 48);
            this.BtFechar.Name = "BtFechar";
            this.BtFechar.Size = new System.Drawing.Size(32, 32);
            this.BtFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtFechar.TabIndex = 12;
            this.BtFechar.TabStop = false;
            this.BtFechar.Click += new System.EventHandler(this.BtFechar_Click);
            // 
            // BtPesquisar
            // 
            this.BtPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.BtPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BtPesquisar.Image")));
            this.BtPesquisar.Location = new System.Drawing.Point(347, 52);
            this.BtPesquisar.Name = "BtPesquisar";
            this.BtPesquisar.Size = new System.Drawing.Size(32, 32);
            this.BtPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtPesquisar.TabIndex = 9;
            this.BtPesquisar.TabStop = false;
            this.BtPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // PFoto2
            // 
            this.PFoto2.BackColor = System.Drawing.Color.Transparent;
            this.PFoto2.Image = global::Bioghet_Orcamento.Properties.Resources.Nenhuma;
            this.PFoto2.Location = new System.Drawing.Point(885, 473);
            this.PFoto2.Name = "PFoto2";
            this.PFoto2.Size = new System.Drawing.Size(189, 189);
            this.PFoto2.TabIndex = 5;
            this.PFoto2.TabStop = false;
            // 
            // PFoto1
            // 
            this.PFoto1.BackColor = System.Drawing.Color.Transparent;
            this.PFoto1.Image = global::Bioghet_Orcamento.Properties.Resources.Nenhuma;
            this.PFoto1.Location = new System.Drawing.Point(885, 254);
            this.PFoto1.Name = "PFoto1";
            this.PFoto1.Size = new System.Drawing.Size(189, 189);
            this.PFoto1.TabIndex = 3;
            this.PFoto1.TabStop = false;
            // 
            // PFoto
            // 
            this.PFoto.BackColor = System.Drawing.Color.Transparent;
            this.PFoto.Image = ((System.Drawing.Image)(resources.GetObject("PFoto.Image")));
            this.PFoto.Location = new System.Drawing.Point(885, 33);
            this.PFoto.Name = "PFoto";
            this.PFoto.Size = new System.Drawing.Size(189, 189);
            this.PFoto.TabIndex = 2;
            this.PFoto.TabStop = false;
            // 
            // RdTudo
            // 
            this.RdTudo.AutoSize = true;
            this.RdTudo.BackColor = System.Drawing.Color.Transparent;
            this.RdTudo.Checked = true;
            this.RdTudo.ForeColor = System.Drawing.Color.White;
            this.RdTudo.Location = new System.Drawing.Point(495, 69);
            this.RdTudo.Name = "RdTudo";
            this.RdTudo.Size = new System.Drawing.Size(50, 17);
            this.RdTudo.TabIndex = 15;
            this.RdTudo.TabStop = true;
            this.RdTudo.Text = "Tudo";
            this.RdTudo.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1099, 750);
            this.Controls.Add(this.RdTudo);
            this.Controls.Add(this.RdImei);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtFechar);
            this.Controls.Add(this.RdCpf);
            this.Controls.Add(this.RdCliente);
            this.Controls.Add(this.BtPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PFoto2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PFoto1);
            this.Controls.Add(this.PFoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgOrcamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgOrcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgOrcamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PFoto;
        private System.Windows.Forms.PictureBox PFoto1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PFoto2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox BtPesquisar;
        private System.Windows.Forms.RadioButton RdCliente;
        private System.Windows.Forms.RadioButton RdCpf;
        private System.Windows.Forms.PictureBox BtFechar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RdImei;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMEI;
        private System.Windows.Forms.RadioButton RdTudo;
    }
}