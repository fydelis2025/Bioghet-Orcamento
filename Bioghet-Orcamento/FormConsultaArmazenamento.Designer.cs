namespace Bioghet_Orcamento
{
    partial class FormConsultaArmazenamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaArmazenamento));
            this.DgArmazenamento = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRATELEIRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GANCHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAIXA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgArmazenamento)).BeginInit();
            this.SuspendLayout();
            // 
            // DgArmazenamento
            // 
            this.DgArmazenamento.AllowUserToAddRows = false;
            this.DgArmazenamento.AllowUserToDeleteRows = false;
            this.DgArmazenamento.AllowUserToResizeColumns = false;
            this.DgArmazenamento.AllowUserToResizeRows = false;
            this.DgArmazenamento.BackgroundColor = System.Drawing.Color.White;
            this.DgArmazenamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgArmazenamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgArmazenamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgArmazenamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgArmazenamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.PRODUTO,
            this.QTDE,
            this.LADO,
            this.PRATELEIRA,
            this.GANCHO,
            this.CAIXA,
            this.IDPRODUTO,
            this.Excluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgArmazenamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgArmazenamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgArmazenamento.Location = new System.Drawing.Point(0, 0);
            this.DgArmazenamento.Name = "DgArmazenamento";
            this.DgArmazenamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgArmazenamento.RowHeadersVisible = false;
            this.DgArmazenamento.Size = new System.Drawing.Size(911, 487);
            this.DgArmazenamento.TabIndex = 0;
            this.DgArmazenamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgArmazenamento_CellClick);
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // PRODUTO
            // 
            this.PRODUTO.FillWeight = 250F;
            this.PRODUTO.HeaderText = "PRODUTO";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.Width = 250;
            // 
            // QTDE
            // 
            this.QTDE.HeaderText = "QTDE";
            this.QTDE.Name = "QTDE";
            // 
            // LADO
            // 
            this.LADO.FillWeight = 80F;
            this.LADO.HeaderText = "LADO";
            this.LADO.Name = "LADO";
            this.LADO.Width = 80;
            // 
            // PRATELEIRA
            // 
            this.PRATELEIRA.FillWeight = 80F;
            this.PRATELEIRA.HeaderText = "PRATELEIRA";
            this.PRATELEIRA.Name = "PRATELEIRA";
            this.PRATELEIRA.Width = 80;
            // 
            // GANCHO
            // 
            this.GANCHO.FillWeight = 80F;
            this.GANCHO.HeaderText = "GANCHO";
            this.GANCHO.Name = "GANCHO";
            this.GANCHO.Width = 80;
            // 
            // CAIXA
            // 
            this.CAIXA.FillWeight = 80F;
            this.CAIXA.HeaderText = "CAIXA";
            this.CAIXA.Name = "CAIXA";
            this.CAIXA.Width = 80;
            // 
            // IDPRODUTO
            // 
            this.IDPRODUTO.HeaderText = "ID";
            this.IDPRODUTO.Name = "IDPRODUTO";
            this.IDPRODUTO.Visible = false;
            // 
            // Excluir
            // 
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.Text = "Excluir";
            this.Excluir.ToolTipText = "Excluir";
            // 
            // FormConsultaArmazenamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(911, 487);
            this.Controls.Add(this.DgArmazenamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaArmazenamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Armazenamento";
            this.Load += new System.EventHandler(this.FormConsultaArmazenamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgArmazenamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView DgArmazenamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRATELEIRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GANCHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAIXA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUTO;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}