namespace Bioghet_Orcamento
{
    partial class FrmConsultaProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaProduto));
            this.DgConsulta = new System.Windows.Forms.DataGridView();
            this.FILIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODBARRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOPECA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECOCUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVAREJO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATACADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GARANTIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRVAREJO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRATACADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APARELHO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PECA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NOVO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.USADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NTESTADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DEFEITO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RETAPARELHO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TESTADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codfilial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolavarejo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolaAtacado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DolaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VER = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.venda = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Local = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxDescricao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbFilial = new System.Windows.Forms.ComboBox();
            this.RdTudo = new System.Windows.Forms.RadioButton();
            this.RdFilial = new System.Windows.Forms.RadioButton();
            this.BtLocalizar = new System.Windows.Forms.PictureBox();
            this.RdDescricao = new System.Windows.Forms.RadioButton();
            this.RdCodBarra = new System.Windows.Forms.RadioButton();
            this.RdCodInterno = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtNovo = new System.Windows.Forms.Button();
            this.BtFinalizar = new System.Windows.Forms.Button();
            this.BtExtornar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtURL = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LbCambio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MnuRelatorio = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarOrçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsulta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtLocalizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.MnuRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgConsulta
            // 
            this.DgConsulta.AllowUserToAddRows = false;
            this.DgConsulta.AllowUserToDeleteRows = false;
            this.DgConsulta.AllowUserToResizeColumns = false;
            this.DgConsulta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
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
            this.FILIAL,
            this.DESCRICAO,
            this.CODIGO,
            this.CODBARRA,
            this.SERIAL,
            this.lote,
            this.TIPOPECA,
            this.QUANTIDADE,
            this.PRECOCUSTO,
            this.PVAREJO,
            this.PATACADO,
            this.COMPRA,
            this.GARANTIA,
            this.FIM,
            this.PRVAREJO,
            this.PRATACADO,
            this.APARELHO,
            this.PECA,
            this.NOVO,
            this.USADO,
            this.NTESTADO,
            this.DEFEITO,
            this.RETAPARELHO,
            this.TESTADO,
            this.codfilial,
            this.ID,
            this.dolavarejo,
            this.DolaAtacado,
            this.DolaCompra,
            this.Cambio,
            this.VER,
            this.Excluir,
            this.venda,
            this.Local});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgConsulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgConsulta.GridColor = System.Drawing.Color.Silver;
            this.DgConsulta.Location = new System.Drawing.Point(12, 153);
            this.DgConsulta.Name = "DgConsulta";
            this.DgConsulta.RowHeadersVisible = false;
            this.DgConsulta.Size = new System.Drawing.Size(1248, 586);
            this.DgConsulta.TabIndex = 166;
            this.DgConsulta.CellBorderStyleChanged += new System.EventHandler(this.DgConsulta_CellBorderStyleChanged);
            this.DgConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgConsulta_CellClick);
            this.DgConsulta.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgConsulta_RowEnter);
            this.DgConsulta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgConsulta_KeyDown);
            // 
            // FILIAL
            // 
            this.FILIAL.FillWeight = 120F;
            this.FILIAL.HeaderText = "Filial";
            this.FILIAL.Name = "FILIAL";
            this.FILIAL.Width = 120;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.FillWeight = 290F;
            this.DESCRICAO.HeaderText = "Descrição";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.Width = 290;
            // 
            // CODIGO
            // 
            this.CODIGO.FillWeight = 80F;
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Width = 80;
            // 
            // CODBARRA
            // 
            this.CODBARRA.FillWeight = 70F;
            this.CODBARRA.HeaderText = "Barra";
            this.CODBARRA.Name = "CODBARRA";
            this.CODBARRA.Width = 70;
            // 
            // SERIAL
            // 
            this.SERIAL.FillWeight = 70F;
            this.SERIAL.HeaderText = "Serial";
            this.SERIAL.Name = "SERIAL";
            this.SERIAL.Width = 70;
            // 
            // lote
            // 
            this.lote.FillWeight = 65F;
            this.lote.HeaderText = "Lote";
            this.lote.Name = "lote";
            this.lote.Width = 65;
            // 
            // TIPOPECA
            // 
            this.TIPOPECA.FillWeight = 55F;
            this.TIPOPECA.HeaderText = "Classific";
            this.TIPOPECA.Name = "TIPOPECA";
            this.TIPOPECA.Width = 55;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.FillWeight = 50F;
            this.QUANTIDADE.HeaderText = "Qtde";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.Width = 50;
            // 
            // PRECOCUSTO
            // 
            this.PRECOCUSTO.FillWeight = 67F;
            this.PRECOCUSTO.HeaderText = "$Custo";
            this.PRECOCUSTO.Name = "PRECOCUSTO";
            this.PRECOCUSTO.Width = 70;
            // 
            // PVAREJO
            // 
            this.PVAREJO.FillWeight = 67F;
            this.PVAREJO.HeaderText = "$Varejo";
            this.PVAREJO.Name = "PVAREJO";
            this.PVAREJO.Width = 70;
            // 
            // PATACADO
            // 
            this.PATACADO.FillWeight = 67F;
            this.PATACADO.HeaderText = "$Atacado";
            this.PATACADO.Name = "PATACADO";
            this.PATACADO.Width = 70;
            // 
            // COMPRA
            // 
            this.COMPRA.FillWeight = 70F;
            this.COMPRA.HeaderText = "Compra";
            this.COMPRA.Name = "COMPRA";
            this.COMPRA.Visible = false;
            this.COMPRA.Width = 70;
            // 
            // GARANTIA
            // 
            this.GARANTIA.FillWeight = 70F;
            this.GARANTIA.HeaderText = "Garantia";
            this.GARANTIA.Name = "GARANTIA";
            this.GARANTIA.Visible = false;
            this.GARANTIA.Width = 70;
            // 
            // FIM
            // 
            this.FIM.FillWeight = 65F;
            this.FIM.HeaderText = "Fim";
            this.FIM.Name = "FIM";
            this.FIM.ToolTipText = "FIM GARANTIA";
            this.FIM.Visible = false;
            this.FIM.Width = 65;
            // 
            // PRVAREJO
            // 
            this.PRVAREJO.HeaderText = "PVAREJO";
            this.PRVAREJO.Name = "PRVAREJO";
            this.PRVAREJO.Visible = false;
            // 
            // PRATACADO
            // 
            this.PRATACADO.HeaderText = "PATACADO";
            this.PRATACADO.Name = "PRATACADO";
            this.PRATACADO.Visible = false;
            // 
            // APARELHO
            // 
            this.APARELHO.HeaderText = "APARELHO";
            this.APARELHO.Name = "APARELHO";
            this.APARELHO.Visible = false;
            // 
            // PECA
            // 
            this.PECA.HeaderText = "PECA";
            this.PECA.Name = "PECA";
            this.PECA.Visible = false;
            // 
            // NOVO
            // 
            this.NOVO.HeaderText = "NOVO";
            this.NOVO.Name = "NOVO";
            this.NOVO.Visible = false;
            // 
            // USADO
            // 
            this.USADO.HeaderText = "USADO";
            this.USADO.Name = "USADO";
            this.USADO.Visible = false;
            // 
            // NTESTADO
            // 
            this.NTESTADO.HeaderText = "NTESTADO";
            this.NTESTADO.Name = "NTESTADO";
            this.NTESTADO.Visible = false;
            // 
            // DEFEITO
            // 
            this.DEFEITO.HeaderText = "DEFEITO";
            this.DEFEITO.Name = "DEFEITO";
            this.DEFEITO.Visible = false;
            // 
            // RETAPARELHO
            // 
            this.RETAPARELHO.HeaderText = "RETAPARELHO";
            this.RETAPARELHO.Name = "RETAPARELHO";
            this.RETAPARELHO.Visible = false;
            // 
            // TESTADO
            // 
            this.TESTADO.HeaderText = "TESTADO";
            this.TESTADO.Name = "TESTADO";
            this.TESTADO.Visible = false;
            // 
            // codfilial
            // 
            this.codfilial.HeaderText = "codfilial";
            this.codfilial.Name = "codfilial";
            this.codfilial.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // dolavarejo
            // 
            this.dolavarejo.HeaderText = "DolaVarejo";
            this.dolavarejo.Name = "dolavarejo";
            this.dolavarejo.Visible = false;
            // 
            // DolaAtacado
            // 
            this.DolaAtacado.HeaderText = "DolaAtacado";
            this.DolaAtacado.Name = "DolaAtacado";
            this.DolaAtacado.Visible = false;
            // 
            // DolaCompra
            // 
            this.DolaCompra.HeaderText = "DolaCompra";
            this.DolaCompra.Name = "DolaCompra";
            this.DolaCompra.Visible = false;
            // 
            // Cambio
            // 
            this.Cambio.HeaderText = "Cambio";
            this.Cambio.Name = "Cambio";
            this.Cambio.Visible = false;
            // 
            // VER
            // 
            this.VER.FillWeight = 55F;
            this.VER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VER.HeaderText = "";
            this.VER.Name = "VER";
            this.VER.Text = "Alterar";
            this.VER.ToolTipText = "Alterar";
            this.VER.UseColumnTextForButtonValue = true;
            this.VER.Width = 60;
            // 
            // Excluir
            // 
            this.Excluir.FillWeight = 55F;
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            this.Excluir.Text = "Excluir";
            this.Excluir.ToolTipText = "Excluir";
            this.Excluir.UseColumnTextForButtonValue = true;
            this.Excluir.Width = 60;
            // 
            // venda
            // 
            this.venda.FillWeight = 55F;
            this.venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.venda.HeaderText = "";
            this.venda.Name = "venda";
            this.venda.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.venda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.venda.Text = "Venda";
            this.venda.ToolTipText = "Venda";
            this.venda.UseColumnTextForButtonValue = true;
            this.venda.Width = 60;
            // 
            // Local
            // 
            this.Local.FillWeight = 50F;
            this.Local.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Local.HeaderText = "";
            this.Local.Name = "Local";
            this.Local.Text = "...";
            this.Local.ToolTipText = "Local de Guarda";
            this.Local.UseColumnTextForButtonValue = true;
            this.Local.Width = 50;
            // 
            // TxDescricao
            // 
            this.TxDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxDescricao.Location = new System.Drawing.Point(15, 44);
            this.TxDescricao.Name = "TxDescricao";
            this.TxDescricao.Size = new System.Drawing.Size(296, 20);
            this.TxDescricao.TabIndex = 244;
            this.TxDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxDescricao_KeyDown);
            this.TxDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxDescricao_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CbFilial);
            this.groupBox1.Controls.Add(this.RdTudo);
            this.groupBox1.Controls.Add(this.RdFilial);
            this.groupBox1.Controls.Add(this.BtLocalizar);
            this.groupBox1.Controls.Add(this.TxDescricao);
            this.groupBox1.Controls.Add(this.RdDescricao);
            this.groupBox1.Controls.Add(this.RdCodBarra);
            this.groupBox1.Controls.Add(this.RdCodInterno);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 77);
            this.groupBox1.TabIndex = 247;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opção de busca";
            // 
            // CbFilial
            // 
            this.CbFilial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbFilial.FormattingEnabled = true;
            this.CbFilial.Location = new System.Drawing.Point(317, 44);
            this.CbFilial.Name = "CbFilial";
            this.CbFilial.Size = new System.Drawing.Size(220, 21);
            this.CbFilial.TabIndex = 342;
            this.CbFilial.SelectedValueChanged += new System.EventHandler(this.CbFilial_SelectedValueChanged);
            // 
            // RdTudo
            // 
            this.RdTudo.AutoSize = true;
            this.RdTudo.Location = new System.Drawing.Point(329, 19);
            this.RdTudo.Name = "RdTudo";
            this.RdTudo.Size = new System.Drawing.Size(78, 17);
            this.RdTudo.TabIndex = 248;
            this.RdTudo.TabStop = true;
            this.RdTudo.Text = "Listar Tudo";
            this.RdTudo.UseVisualStyleBackColor = true;
            this.RdTudo.Visible = false;
            this.RdTudo.Click += new System.EventHandler(this.RdTudo_Click);
            // 
            // RdFilial
            // 
            this.RdFilial.AutoSize = true;
            this.RdFilial.Location = new System.Drawing.Point(281, 19);
            this.RdFilial.Name = "RdFilial";
            this.RdFilial.Size = new System.Drawing.Size(45, 17);
            this.RdFilial.TabIndex = 247;
            this.RdFilial.TabStop = true;
            this.RdFilial.Text = "Filial";
            this.RdFilial.UseVisualStyleBackColor = true;
            this.RdFilial.Click += new System.EventHandler(this.RdFilial_Click);
            // 
            // BtLocalizar
            // 
            this.BtLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtLocalizar.Image = global::Bioghet_Orcamento.Properties.Resources._10;
            this.BtLocalizar.Location = new System.Drawing.Point(543, 33);
            this.BtLocalizar.Name = "BtLocalizar";
            this.BtLocalizar.Size = new System.Drawing.Size(32, 32);
            this.BtLocalizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtLocalizar.TabIndex = 246;
            this.BtLocalizar.TabStop = false;
            this.BtLocalizar.Click += new System.EventHandler(this.BtLocalizar_Click);
            // 
            // RdDescricao
            // 
            this.RdDescricao.AutoSize = true;
            this.RdDescricao.Location = new System.Drawing.Point(15, 19);
            this.RdDescricao.Name = "RdDescricao";
            this.RdDescricao.Size = new System.Drawing.Size(73, 17);
            this.RdDescricao.TabIndex = 3;
            this.RdDescricao.TabStop = true;
            this.RdDescricao.Text = "Descrição";
            this.RdDescricao.UseVisualStyleBackColor = true;
            this.RdDescricao.Click += new System.EventHandler(this.RdDescricao_Click);
            // 
            // RdCodBarra
            // 
            this.RdCodBarra.AutoSize = true;
            this.RdCodBarra.Location = new System.Drawing.Point(194, 19);
            this.RdCodBarra.Name = "RdCodBarra";
            this.RdCodBarra.Size = new System.Drawing.Size(86, 17);
            this.RdCodBarra.TabIndex = 1;
            this.RdCodBarra.TabStop = true;
            this.RdCodBarra.Text = "Código Barra";
            this.RdCodBarra.UseVisualStyleBackColor = true;
            this.RdCodBarra.Click += new System.EventHandler(this.RdCodBarra_Click);
            // 
            // RdCodInterno
            // 
            this.RdCodInterno.AutoSize = true;
            this.RdCodInterno.Location = new System.Drawing.Point(94, 19);
            this.RdCodInterno.Name = "RdCodInterno";
            this.RdCodInterno.Size = new System.Drawing.Size(94, 17);
            this.RdCodInterno.TabIndex = 0;
            this.RdCodInterno.TabStop = true;
            this.RdCodInterno.Text = "Código Interno";
            this.RdCodInterno.UseVisualStyleBackColor = true;
            this.RdCodInterno.Click += new System.EventHandler(this.RdCodInterno_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Bioghet";
            // 
            // BtNovo
            // 
            this.BtNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtNovo.ForeColor = System.Drawing.Color.White;
            this.BtNovo.Image = global::Bioghet_Orcamento.Properties.Resources._8;
            this.BtNovo.Location = new System.Drawing.Point(610, 68);
            this.BtNovo.Name = "BtNovo";
            this.BtNovo.Size = new System.Drawing.Size(65, 72);
            this.BtNovo.TabIndex = 261;
            this.BtNovo.Text = "Novo";
            this.BtNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtNovo, "Criar novo modelo de aparelho");
            this.BtNovo.UseVisualStyleBackColor = false;
            this.BtNovo.Click += new System.EventHandler(this.BtProduto_Click);
            // 
            // BtFinalizar
            // 
            this.BtFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtFinalizar.ForeColor = System.Drawing.Color.White;
            this.BtFinalizar.Image = global::Bioghet_Orcamento.Properties.Resources._1f6d248x48_fw;
            this.BtFinalizar.Location = new System.Drawing.Point(678, 68);
            this.BtFinalizar.Name = "BtFinalizar";
            this.BtFinalizar.Size = new System.Drawing.Size(65, 72);
            this.BtFinalizar.TabIndex = 262;
            this.BtFinalizar.Text = "Finalizar";
            this.BtFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtFinalizar, "Clique aqui para finalizar a venda");
            this.BtFinalizar.UseVisualStyleBackColor = false;
            this.BtFinalizar.Click += new System.EventHandler(this.BtVenda_Click);
            // 
            // BtExtornar
            // 
            this.BtExtornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtExtornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtExtornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExtornar.ForeColor = System.Drawing.Color.White;
            this.BtExtornar.Image = global::Bioghet_Orcamento.Properties.Resources.cancelar48x48_fw;
            this.BtExtornar.Location = new System.Drawing.Point(746, 68);
            this.BtExtornar.Name = "BtExtornar";
            this.BtExtornar.Size = new System.Drawing.Size(65, 72);
            this.BtExtornar.TabIndex = 263;
            this.BtExtornar.Text = "Extornar";
            this.BtExtornar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtExtornar, "Clique aqui para extornar uma venda");
            this.BtExtornar.UseVisualStyleBackColor = false;
            this.BtExtornar.Click += new System.EventHandler(this.BtExtornar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Bioghet_Orcamento.Properties.Resources.Printer_icon48x48_fw;
            this.button1.Location = new System.Drawing.Point(814, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 72);
            this.button1.TabIndex = 264;
            this.button1.Text = "Relatórios";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button1, "Clique aqui para ver o relatório das vendas");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtRelatorios_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Bioghet_Orcamento.Properties.Resources._1f6d248x48_fw;
            this.button2.Location = new System.Drawing.Point(883, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 72);
            this.button2.TabIndex = 265;
            this.button2.Text = "Venda";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button2, "VENDA RÁPIDA");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Bioghet_Orcamento.Properties.Resources.orcamentoicon_fw;
            this.button3.Location = new System.Drawing.Point(968, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 72);
            this.button3.TabIndex = 266;
            this.button3.Text = "Ajuste";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button3, "Clique aqui para ver o relatório das vendas");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtURL
            // 
            this.BtURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtURL.ForeColor = System.Drawing.Color.White;
            this.BtURL.Image = global::Bioghet_Orcamento.Properties.Resources.Sem_título_1_fw;
            this.BtURL.Location = new System.Drawing.Point(1043, 68);
            this.BtURL.Name = "BtURL";
            this.BtURL.Size = new System.Drawing.Size(70, 72);
            this.BtURL.TabIndex = 270;
            this.BtURL.Text = "URL";
            this.BtURL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtURL, "CADASTRO DE URL");
            this.BtURL.UseVisualStyleBackColor = false;
            this.BtURL.Click += new System.EventHandler(this.BtURL_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Bioghet_Orcamento.Properties.Resources.minimize_thewindow_theapplication_2872;
            this.pictureBox2.Location = new System.Drawing.Point(1188, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 260;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Bioghet_Orcamento.Properties.Resources.shutdown;
            this.pictureBox4.Location = new System.Drawing.Point(1223, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 259;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.LbCambio);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(1165, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 84);
            this.groupBox3.TabIndex = 256;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cambio do dia";
            // 
            // LbCambio
            // 
            this.LbCambio.BackColor = System.Drawing.Color.Transparent;
            this.LbCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCambio.ForeColor = System.Drawing.Color.White;
            this.LbCambio.Location = new System.Drawing.Point(6, 16);
            this.LbCambio.Name = "LbCambio";
            this.LbCambio.Size = new System.Drawing.Size(85, 61);
            this.LbCambio.TabIndex = 268;
            this.LbCambio.Text = "0,00";
            this.LbCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(509, 36);
            this.label2.TabIndex = 269;
            this.label2.Text = "CONSULTA DE PRODUTO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MnuRelatorio
            // 
            this.MnuRelatorio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.consultarOrçamentoToolStripMenuItem});
            this.MnuRelatorio.Name = "MnuPrinter";
            this.MnuRelatorio.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MnuRelatorio.Size = new System.Drawing.Size(123, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem1.Text = "Vendas";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // consultarOrçamentoToolStripMenuItem
            // 
            this.consultarOrçamentoToolStripMenuItem.Name = "consultarOrçamentoToolStripMenuItem";
            this.consultarOrçamentoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.consultarOrçamentoToolStripMenuItem.Text = "Produtos";
            this.consultarOrçamentoToolStripMenuItem.Click += new System.EventHandler(this.consultarOrçamentoToolStripMenuItem_Click);
            // 
            // FrmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::Bioghet_Orcamento.Properties.Resources.venda1;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.BtURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtExtornar);
            this.Controls.Add(this.BtFinalizar);
            this.Controls.Add(this.BtNovo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Produto";
            this.Activated += new System.EventHandler(this.FrmConsultaProduto_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConsultaProduto_FormClosing);
            this.Load += new System.EventHandler(this.FrmConsultaProduto_Load);
            this.Shown += new System.EventHandler(this.FrmConsultaProduto_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmConsultaProduto_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmConsultaProduto_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmConsultaProduto_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsulta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtLocalizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.MnuRelatorio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsulta;
        private System.Windows.Forms.TextBox TxDescricao;
        private System.Windows.Forms.PictureBox BtLocalizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdCodBarra;
        private System.Windows.Forms.RadioButton RdCodInterno;
        private System.Windows.Forms.RadioButton RdDescricao;
        private System.Windows.Forms.RadioButton RdFilial;
        private System.Windows.Forms.RadioButton RdTudo;
        public System.Windows.Forms.ComboBox CbFilial;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BtNovo;
        private System.Windows.Forms.Button BtFinalizar;
        private System.Windows.Forms.Button BtExtornar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LbCambio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip MnuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarOrçamentoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FILIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODBARRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOPECA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECOCUSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVAREJO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATACADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GARANTIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRVAREJO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRATACADO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn APARELHO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PECA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NOVO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn USADO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NTESTADO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DEFEITO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RETAPARELHO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn codfilial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolavarejo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolaAtacado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DolaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cambio;
        private System.Windows.Forms.DataGridViewButtonColumn VER;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.DataGridViewButtonColumn venda;
        private System.Windows.Forms.DataGridViewButtonColumn Local;
        private System.Windows.Forms.Button BtURL;
    }
}