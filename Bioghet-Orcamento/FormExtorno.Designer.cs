namespace Bioghet_Orcamento
{
    partial class FormExtorno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExtorno));
            this.TxCupom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxCredito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxMotivo = new System.Windows.Forms.TextBox();
            this.BtExtornar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxRG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxNome = new System.Windows.Forms.TextBox();
            this.RdTotal = new System.Windows.Forms.RadioButton();
            this.RdParcial = new System.Windows.Forms.RadioButton();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.DgVenda = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxCPF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxOperador = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // TxCupom
            // 
            this.TxCupom.Location = new System.Drawing.Point(8, 51);
            this.TxCupom.Name = "TxCupom";
            this.TxCupom.Size = new System.Drawing.Size(75, 20);
            this.TxCupom.TabIndex = 0;
            this.TxCupom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxCupom_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cupom";
            // 
            // TxTotal
            // 
            this.TxTotal.Location = new System.Drawing.Point(533, 51);
            this.TxTotal.Name = "TxTotal";
            this.TxTotal.Size = new System.Drawing.Size(75, 20);
            this.TxTotal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(530, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total da venda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.TxCredito);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxMotivo);
            this.groupBox2.Controls.Add(this.BtExtornar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxTelefone);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxRG);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxNome);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 175);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do cliente";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(472, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Credito";
            // 
            // TxCredito
            // 
            this.TxCredito.Location = new System.Drawing.Point(472, 38);
            this.TxCredito.MaxLength = 12;
            this.TxCredito.Name = "TxCredito";
            this.TxCredito.Size = new System.Drawing.Size(75, 20);
            this.TxCredito.TabIndex = 11;
            this.TxCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxCredito_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Motivo";
            // 
            // TxMotivo
            // 
            this.TxMotivo.Location = new System.Drawing.Point(6, 87);
            this.TxMotivo.MaxLength = 400;
            this.TxMotivo.Multiline = true;
            this.TxMotivo.Name = "TxMotivo";
            this.TxMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxMotivo.Size = new System.Drawing.Size(600, 82);
            this.TxMotivo.TabIndex = 9;
            // 
            // BtExtornar
            // 
            this.BtExtornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExtornar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtExtornar.Image = global::Bioghet_Orcamento.Properties.Resources.select;
            this.BtExtornar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtExtornar.Location = new System.Drawing.Point(567, 31);
            this.BtExtornar.Name = "BtExtornar";
            this.BtExtornar.Size = new System.Drawing.Size(39, 32);
            this.BtExtornar.TabIndex = 7;
            this.BtExtornar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtExtornar.UseVisualStyleBackColor = true;
            this.BtExtornar.Click += new System.EventHandler(this.BtExtornar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(388, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone";
            // 
            // TxTelefone
            // 
            this.TxTelefone.Location = new System.Drawing.Point(391, 38);
            this.TxTelefone.MaxLength = 12;
            this.TxTelefone.Name = "TxTelefone";
            this.TxTelefone.Size = new System.Drawing.Size(75, 20);
            this.TxTelefone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(307, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "RG";
            // 
            // TxRG
            // 
            this.TxRG.Location = new System.Drawing.Point(310, 38);
            this.TxRG.MaxLength = 10;
            this.TxRG.Name = "TxRG";
            this.TxRG.Size = new System.Drawing.Size(75, 20);
            this.TxRG.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome";
            // 
            // TxNome
            // 
            this.TxNome.Location = new System.Drawing.Point(6, 38);
            this.TxNome.MaxLength = 100;
            this.TxNome.Name = "TxNome";
            this.TxNome.Size = new System.Drawing.Size(298, 20);
            this.TxNome.TabIndex = 3;
            // 
            // RdTotal
            // 
            this.RdTotal.AutoSize = true;
            this.RdTotal.Checked = true;
            this.RdTotal.ForeColor = System.Drawing.Color.White;
            this.RdTotal.Location = new System.Drawing.Point(418, 35);
            this.RdTotal.Name = "RdTotal";
            this.RdTotal.Size = new System.Drawing.Size(88, 17);
            this.RdTotal.TabIndex = 8;
            this.RdTotal.TabStop = true;
            this.RdTotal.Text = "Extorno Total";
            this.RdTotal.UseVisualStyleBackColor = true;
            this.RdTotal.Click += new System.EventHandler(this.RdTotal_Click);
            // 
            // RdParcial
            // 
            this.RdParcial.AutoSize = true;
            this.RdParcial.ForeColor = System.Drawing.Color.White;
            this.RdParcial.Location = new System.Drawing.Point(418, 58);
            this.RdParcial.Name = "RdParcial";
            this.RdParcial.Size = new System.Drawing.Size(96, 17);
            this.RdParcial.TabIndex = 9;
            this.RdParcial.Text = "Estorno Parcial";
            this.RdParcial.UseVisualStyleBackColor = true;
            this.RdParcial.Click += new System.EventHandler(this.RdParcial_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtBuscar.Image = global::Bioghet_Orcamento.Properties.Resources.CONSULTA;
            this.BtBuscar.Location = new System.Drawing.Point(89, 43);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(29, 35);
            this.BtBuscar.TabIndex = 1;
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // DgVenda
            // 
            this.DgVenda.AllowUserToAddRows = false;
            this.DgVenda.AllowUserToDeleteRows = false;
            this.DgVenda.AllowUserToResizeColumns = false;
            this.DgVenda.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgVenda.BackgroundColor = System.Drawing.Color.White;
            this.DgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DESCRICAO,
            this.QTDE,
            this.PRECO,
            this.TOTAL,
            this.Alterar});
            this.DgVenda.Enabled = false;
            this.DgVenda.Location = new System.Drawing.Point(8, 84);
            this.DgVenda.Name = "DgVenda";
            this.DgVenda.RowHeadersVisible = false;
            this.DgVenda.Size = new System.Drawing.Size(612, 150);
            this.DgVenda.TabIndex = 10;
            this.DgVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgVenda_CellClick);
            // 
            // CODIGO
            // 
            this.CODIGO.FillWeight = 70F;
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Width = 70;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.FillWeight = 220F;
            this.DESCRICAO.HeaderText = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.Width = 220;
            // 
            // QTDE
            // 
            this.QTDE.FillWeight = 50F;
            this.QTDE.HeaderText = "QTDE";
            this.QTDE.Name = "QTDE";
            this.QTDE.Width = 50;
            // 
            // PRECO
            // 
            this.PRECO.FillWeight = 70F;
            this.PRECO.HeaderText = "PRECO";
            this.PRECO.Name = "PRECO";
            this.PRECO.Width = 70;
            // 
            // TOTAL
            // 
            this.TOTAL.FillWeight = 70F;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Width = 70;
            // 
            // Alterar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Alterar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alterar.HeaderText = "Alterar";
            this.Alterar.Name = "Alterar";
            this.Alterar.Text = "Alterar";
            // 
            // TxCPF
            // 
            this.TxCPF.Location = new System.Drawing.Point(124, 51);
            this.TxCPF.Name = "TxCPF";
            this.TxCPF.Size = new System.Drawing.Size(114, 20);
            this.TxCPF.TabIndex = 19;
            this.TxCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxCPF_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(124, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "CPF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(244, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "OPERADOR";
            // 
            // TxOperador
            // 
            this.TxOperador.Location = new System.Drawing.Point(244, 51);
            this.TxOperador.Name = "TxOperador";
            this.TxOperador.Size = new System.Drawing.Size(151, 20);
            this.TxOperador.TabIndex = 21;
            // 
            // FormExtorno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(632, 436);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxOperador);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxCPF);
            this.Controls.Add(this.DgVenda);
            this.Controls.Add(this.RdParcial);
            this.Controls.Add(this.RdTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.TxCupom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExtorno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extornar venda";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxCupom;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtExtornar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxRG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxMotivo;
        private System.Windows.Forms.RadioButton RdTotal;
        private System.Windows.Forms.RadioButton RdParcial;
        private System.Windows.Forms.DataGridView DgVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
        private System.Windows.Forms.TextBox TxCPF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxOperador;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxCredito;
    }
}