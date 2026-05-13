namespace Bioghet_Orcamento
{
    partial class Form15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgBuscar = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECIONAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.TxDescricao = new System.Windows.Forms.TextBox();
            this.BtLocalizar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtLocalizar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtLocalizar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxDescricao);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // DgBuscar
            // 
            this.DgBuscar.AllowUserToAddRows = false;
            this.DgBuscar.AllowUserToDeleteRows = false;
            this.DgBuscar.BackgroundColor = System.Drawing.Color.White;
            this.DgBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DESCRICAO,
            this.SELECIONAR});
            this.DgBuscar.Location = new System.Drawing.Point(12, 96);
            this.DgBuscar.Name = "DgBuscar";
            this.DgBuscar.RowHeadersVisible = false;
            this.DgBuscar.Size = new System.Drawing.Size(548, 380);
            this.DgBuscar.TabIndex = 1;
            this.DgBuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgBuscar_CellClick);
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.FillWeight = 300F;
            this.DESCRICAO.HeaderText = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.Width = 300;
            // 
            // SELECIONAR
            // 
            this.SELECIONAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SELECIONAR.HeaderText = "";
            this.SELECIONAR.Name = "SELECIONAR";
            this.SELECIONAR.Text = "SELECIONAR";
            this.SELECIONAR.ToolTipText = "SELECIONAR";
            this.SELECIONAR.UseColumnTextForButtonValue = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Descrição";
            // 
            // TxDescricao
            // 
            this.TxDescricao.Location = new System.Drawing.Point(6, 40);
            this.TxDescricao.Name = "TxDescricao";
            this.TxDescricao.Size = new System.Drawing.Size(498, 20);
            this.TxDescricao.TabIndex = 5;
            this.TxDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxDescricao_KeyDown);
            // 
            // BtLocalizar
            // 
            this.BtLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtLocalizar.Image = global::Bioghet_Orcamento.Properties.Resources._10;
            this.BtLocalizar.Location = new System.Drawing.Point(510, 28);
            this.BtLocalizar.Name = "BtLocalizar";
            this.BtLocalizar.Size = new System.Drawing.Size(32, 32);
            this.BtLocalizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtLocalizar.TabIndex = 247;
            this.BtLocalizar.TabStop = false;
            this.BtLocalizar.Click += new System.EventHandler(this.BtLocalizar_Click);
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(566, 488);
            this.Controls.Add(this.DgBuscar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de produtos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtLocalizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewButtonColumn SELECIONAR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxDescricao;
        private System.Windows.Forms.PictureBox BtLocalizar;
    }
}