namespace Bioghet_Orcamento
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.DgConsulta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.RdCodigo = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.RdDescricao = new System.Windows.Forms.RadioButton();
            this.RdStatus = new System.Windows.Forms.RadioButton();
            this.RdSerie = new System.Windows.Forms.RadioButton();
            this.RdPartNumber = new System.Windows.Forms.RadioButton();
            this.RdModelo = new System.Windows.Forms.RadioButton();
            this.RdMarca = new System.Windows.Forms.RadioButton();
            this.RdTudo = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LbTotalItems = new System.Windows.Forms.Label();
            this.MnuPrinter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imprimirVazioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioBazarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.barraDeLedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARTNUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRATELEIRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAIXA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPART = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPECA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENDER = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsulta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.MnuPrinter.SuspendLayout();
            this.SuspendLayout();
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
            this.TIPO,
            this.MARCA,
            this.MODELO,
            this.DESCRICAO,
            this.PARTNUMBER,
            this.SERIE,
            this.STATUS,
            this.VALOR,
            this.PRATELEIRA,
            this.CAIXA,
            this.COMPART,
            this.QTDE,
            this.PAV,
            this.SALA,
            this.OBS,
            this.CODIGOPECA,
            this.DATA,
            this.TV,
            this.VENDER,
            this.editar,
            this.excluir});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgConsulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgConsulta.GridColor = System.Drawing.Color.Silver;
            this.DgConsulta.Location = new System.Drawing.Point(8, 149);
            this.DgConsulta.Name = "DgConsulta";
            this.DgConsulta.RowHeadersVisible = false;
            this.DgConsulta.Size = new System.Drawing.Size(1001, 278);
            this.DgConsulta.TabIndex = 196;
            this.toolTip1.SetToolTip(this.DgConsulta, "Informações sobre o armazenamento do bazar");
            this.DgConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgConsulta_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.RdCodigo);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.RdDescricao);
            this.groupBox1.Controls.Add(this.RdStatus);
            this.groupBox1.Controls.Add(this.RdSerie);
            this.groupBox1.Controls.Add(this.RdPartNumber);
            this.groupBox1.Controls.Add(this.RdModelo);
            this.groupBox1.Controls.Add(this.RdMarca);
            this.groupBox1.Controls.Add(this.RdTudo);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxBuscar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 75);
            this.groupBox1.TabIndex = 197;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = global::Bioghet_Orcamento.Properties.Resources.cancelar48x48_fw;
            this.button4.Location = new System.Drawing.Point(759, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 54);
            this.button4.TabIndex = 260;
            this.toolTip1.SetToolTip(this.button4, "EXTORNAR");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RdCodigo
            // 
            this.RdCodigo.AutoSize = true;
            this.RdCodigo.Location = new System.Drawing.Point(289, 21);
            this.RdCodigo.Name = "RdCodigo";
            this.RdCodigo.Size = new System.Drawing.Size(58, 17);
            this.RdCodigo.TabIndex = 259;
            this.RdCodigo.TabStop = true;
            this.RdCodigo.Text = "Codigo";
            this.RdCodigo.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = global::Bioghet_Orcamento.Properties.Resources.Printer_icon48x48_fw;
            this.button3.Location = new System.Drawing.Point(812, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 54);
            this.button3.TabIndex = 11;
            this.toolTip1.SetToolTip(this.button3, "FINALIZAR VENDA E IMPRIMIR");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RdDescricao
            // 
            this.RdDescricao.AutoSize = true;
            this.RdDescricao.Location = new System.Drawing.Point(83, 21);
            this.RdDescricao.Name = "RdDescricao";
            this.RdDescricao.Size = new System.Drawing.Size(73, 17);
            this.RdDescricao.TabIndex = 10;
            this.RdDescricao.TabStop = true;
            this.RdDescricao.Text = "Descrição";
            this.RdDescricao.UseVisualStyleBackColor = true;
            // 
            // RdStatus
            // 
            this.RdStatus.AutoSize = true;
            this.RdStatus.Location = new System.Drawing.Point(509, 21);
            this.RdStatus.Name = "RdStatus";
            this.RdStatus.Size = new System.Drawing.Size(55, 17);
            this.RdStatus.TabIndex = 9;
            this.RdStatus.TabStop = true;
            this.RdStatus.Text = "Status";
            this.RdStatus.UseVisualStyleBackColor = true;
            // 
            // RdSerie
            // 
            this.RdSerie.AutoSize = true;
            this.RdSerie.Location = new System.Drawing.Point(439, 21);
            this.RdSerie.Name = "RdSerie";
            this.RdSerie.Size = new System.Drawing.Size(64, 17);
            this.RdSerie.TabIndex = 8;
            this.RdSerie.TabStop = true;
            this.RdSerie.Text = "Nº Série";
            this.RdSerie.UseVisualStyleBackColor = true;
            // 
            // RdPartNumber
            // 
            this.RdPartNumber.AutoSize = true;
            this.RdPartNumber.Location = new System.Drawing.Point(352, 21);
            this.RdPartNumber.Name = "RdPartNumber";
            this.RdPartNumber.Size = new System.Drawing.Size(81, 17);
            this.RdPartNumber.TabIndex = 7;
            this.RdPartNumber.TabStop = true;
            this.RdPartNumber.Text = "PartNumber";
            this.RdPartNumber.UseVisualStyleBackColor = true;
            // 
            // RdModelo
            // 
            this.RdModelo.AutoSize = true;
            this.RdModelo.Location = new System.Drawing.Point(223, 21);
            this.RdModelo.Name = "RdModelo";
            this.RdModelo.Size = new System.Drawing.Size(60, 17);
            this.RdModelo.TabIndex = 6;
            this.RdModelo.TabStop = true;
            this.RdModelo.Text = "Modelo";
            this.RdModelo.UseVisualStyleBackColor = true;
            // 
            // RdMarca
            // 
            this.RdMarca.AutoSize = true;
            this.RdMarca.Location = new System.Drawing.Point(162, 21);
            this.RdMarca.Name = "RdMarca";
            this.RdMarca.Size = new System.Drawing.Size(55, 17);
            this.RdMarca.TabIndex = 5;
            this.RdMarca.TabStop = true;
            this.RdMarca.Text = "Marca";
            this.RdMarca.UseVisualStyleBackColor = true;
            // 
            // RdTudo
            // 
            this.RdTudo.AutoSize = true;
            this.RdTudo.Location = new System.Drawing.Point(570, 21);
            this.RdTudo.Name = "RdTudo";
            this.RdTudo.Size = new System.Drawing.Size(78, 17);
            this.RdTudo.TabIndex = 4;
            this.RdTudo.TabStop = true;
            this.RdTudo.Text = "Listar Tudo";
            this.RdTudo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::Bioghet_Orcamento.Properties.Resources._8;
            this.button2.Location = new System.Drawing.Point(707, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 54);
            this.button2.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button2, "NOVO");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxBuscar
            // 
            this.TxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBuscar.Location = new System.Drawing.Point(6, 41);
            this.TxBuscar.Name = "TxBuscar";
            this.TxBuscar.Size = new System.Drawing.Size(642, 20);
            this.TxBuscar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.TxBuscar, "Buscar");
            this.TxBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxBuscar_KeyDown);
            this.TxBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxBuscar_KeyPress);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::Bioghet_Orcamento.Properties.Resources._10;
            this.button1.Location = new System.Drawing.Point(651, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 54);
            this.button1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button1, "CONSULTAR");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "BIOGHET";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Bioghet_Orcamento.Properties.Resources.minimize_thewindow_theapplication_2872;
            this.pictureBox1.Location = new System.Drawing.Point(939, 12);
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
            this.pictureBox4.Location = new System.Drawing.Point(974, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 236;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.LbTotalItems);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(894, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 75);
            this.groupBox3.TabIndex = 258;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            // 
            // LbTotalItems
            // 
            this.LbTotalItems.BackColor = System.Drawing.Color.White;
            this.LbTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalItems.ForeColor = System.Drawing.Color.Black;
            this.LbTotalItems.Location = new System.Drawing.Point(7, 17);
            this.LbTotalItems.Name = "LbTotalItems";
            this.LbTotalItems.Size = new System.Drawing.Size(80, 52);
            this.LbTotalItems.TabIndex = 0;
            this.LbTotalItems.Text = "0";
            this.LbTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MnuPrinter
            // 
            this.MnuPrinter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirVazioToolStripMenuItem,
            this.relatorioBazarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.estoqueToolStripMenuItem,
            this.toolStripMenuItem2,
            this.barraDeLedToolStripMenuItem});
            this.MnuPrinter.Name = "MnuPrinter";
            this.MnuPrinter.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MnuPrinter.Size = new System.Drawing.Size(186, 104);
            // 
            // imprimirVazioToolStripMenuItem
            // 
            this.imprimirVazioToolStripMenuItem.Name = "imprimirVazioToolStripMenuItem";
            this.imprimirVazioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirVazioToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.imprimirVazioToolStripMenuItem.Text = "Imprimir Venda";
            this.imprimirVazioToolStripMenuItem.Click += new System.EventHandler(this.imprimirVazioToolStripMenuItem_Click);
            // 
            // relatorioBazarToolStripMenuItem
            // 
            this.relatorioBazarToolStripMenuItem.Name = "relatorioBazarToolStripMenuItem";
            this.relatorioBazarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.relatorioBazarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.relatorioBazarToolStripMenuItem.Text = "Relatorio Bazar";
            this.relatorioBazarToolStripMenuItem.Click += new System.EventHandler(this.relatorioBazarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 6);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(182, 6);
            // 
            // barraDeLedToolStripMenuItem
            // 
            this.barraDeLedToolStripMenuItem.Name = "barraDeLedToolStripMenuItem";
            this.barraDeLedToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.barraDeLedToolStripMenuItem.Text = "Barra de Led";
            this.barraDeLedToolStripMenuItem.Click += new System.EventHandler(this.barraDeLedToolStripMenuItem_Click);
            // 
            // TIPO
            // 
            this.TIPO.FillWeight = 80F;
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.Width = 80;
            // 
            // MARCA
            // 
            this.MARCA.FillWeight = 80F;
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            this.MARCA.Width = 80;
            // 
            // MODELO
            // 
            this.MODELO.FillWeight = 80F;
            this.MODELO.HeaderText = "MODELO";
            this.MODELO.Name = "MODELO";
            this.MODELO.Width = 80;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.HeaderText = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            // 
            // PARTNUMBER
            // 
            this.PARTNUMBER.FillWeight = 70F;
            this.PARTNUMBER.HeaderText = "PARTNUMBER";
            this.PARTNUMBER.Name = "PARTNUMBER";
            this.PARTNUMBER.Width = 70;
            // 
            // SERIE
            // 
            this.SERIE.FillWeight = 70F;
            this.SERIE.HeaderText = "SERIE";
            this.SERIE.Name = "SERIE";
            this.SERIE.Width = 70;
            // 
            // STATUS
            // 
            this.STATUS.FillWeight = 80F;
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.Width = 80;
            // 
            // VALOR
            // 
            this.VALOR.FillWeight = 70F;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.Width = 70;
            // 
            // PRATELEIRA
            // 
            this.PRATELEIRA.FillWeight = 60F;
            this.PRATELEIRA.HeaderText = "PRAT";
            this.PRATELEIRA.Name = "PRATELEIRA";
            this.PRATELEIRA.Width = 60;
            // 
            // CAIXA
            // 
            this.CAIXA.FillWeight = 60F;
            this.CAIXA.HeaderText = "CAIXA";
            this.CAIXA.Name = "CAIXA";
            this.CAIXA.Width = 60;
            // 
            // COMPART
            // 
            this.COMPART.FillWeight = 60F;
            this.COMPART.HeaderText = "COMP";
            this.COMPART.Name = "COMPART";
            this.COMPART.Width = 60;
            // 
            // QTDE
            // 
            this.QTDE.FillWeight = 50F;
            this.QTDE.HeaderText = "QTDE";
            this.QTDE.Name = "QTDE";
            this.QTDE.Width = 50;
            // 
            // PAV
            // 
            this.PAV.FillWeight = 50F;
            this.PAV.HeaderText = "PAV.";
            this.PAV.Name = "PAV";
            this.PAV.Width = 50;
            // 
            // SALA
            // 
            this.SALA.FillWeight = 50F;
            this.SALA.HeaderText = "SALA";
            this.SALA.Name = "SALA";
            this.SALA.Width = 50;
            // 
            // OBS
            // 
            this.OBS.HeaderText = "OBS";
            this.OBS.Name = "OBS";
            this.OBS.Visible = false;
            // 
            // CODIGOPECA
            // 
            this.CODIGOPECA.HeaderText = "CODIGO";
            this.CODIGOPECA.Name = "CODIGOPECA";
            this.CODIGOPECA.Visible = false;
            // 
            // DATA
            // 
            this.DATA.HeaderText = "DATA";
            this.DATA.Name = "DATA";
            this.DATA.Visible = false;
            // 
            // TV
            // 
            this.TV.HeaderText = "TV";
            this.TV.Name = "TV";
            this.TV.Visible = false;
            // 
            // VENDER
            // 
            this.VENDER.FillWeight = 60F;
            this.VENDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VENDER.HeaderText = "";
            this.VENDER.Name = "VENDER";
            this.VENDER.Text = "VENDER";
            this.VENDER.ToolTipText = "VENDER";
            this.VENDER.UseColumnTextForButtonValue = true;
            this.VENDER.Width = 60;
            // 
            // editar
            // 
            this.editar.FillWeight = 60F;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.HeaderText = "";
            this.editar.Name = "editar";
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editar.Text = "editar";
            this.editar.ToolTipText = "editar";
            this.editar.UseColumnTextForButtonValue = true;
            this.editar.Width = 60;
            // 
            // excluir
            // 
            this.excluir.FillWeight = 60F;
            this.excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluir.HeaderText = "";
            this.excluir.Name = "excluir";
            this.excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.excluir.Text = "excluir";
            this.excluir.ToolTipText = "excluir";
            this.excluir.UseColumnTextForButtonValue = true;
            this.excluir.Width = 60;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Bioghet_Orcamento.Properties.Resources.BAZAR_fw;
            this.ClientSize = new System.Drawing.Size(1022, 451);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form14_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form14_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form14_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsulta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.MnuPrinter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton RdModelo;
        private System.Windows.Forms.RadioButton RdMarca;
        private System.Windows.Forms.RadioButton RdTudo;
        private System.Windows.Forms.RadioButton RdStatus;
        private System.Windows.Forms.RadioButton RdSerie;
        private System.Windows.Forms.RadioButton RdPartNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton RdDescricao;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LbTotalItems;
        private System.Windows.Forms.RadioButton RdCodigo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip MnuPrinter;
        private System.Windows.Forms.ToolStripMenuItem imprimirVazioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioBazarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem barraDeLedToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARTNUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRATELEIRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAIXA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPART;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPECA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TV;
        private System.Windows.Forms.DataGridViewButtonColumn VENDER;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.DataGridViewButtonColumn excluir;
    }
}