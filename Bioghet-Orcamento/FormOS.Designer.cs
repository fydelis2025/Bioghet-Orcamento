namespace Bioghet_Orcamento
{
    partial class FormOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOS));
            this.TxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxCpf = new System.Windows.Forms.TextBox();
            this.TxCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtNovo = new System.Windows.Forms.ToolStripButton();
            this.BtSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtImprimir = new System.Windows.Forms.ToolStripDropDownButton();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressão1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressão2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.TxModelo = new System.Windows.Forms.ComboBox();
            this.TxDefeito = new System.Windows.Forms.ComboBox();
            this.TxMarca = new System.Windows.Forms.ComboBox();
            this.TxTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxObs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxOS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LbStatus = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.TxImei = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CbFilial = new System.Windows.Forms.ComboBox();
            this.ChGerarImei = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxTelefone
            // 
            this.TxTelefone.Location = new System.Drawing.Point(451, 135);
            this.TxTelefone.Mask = "(##)#########";
            this.TxTelefone.Name = "TxTelefone";
            this.TxTelefone.Size = new System.Drawing.Size(100, 20);
            this.TxTelefone.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(448, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 104;
            this.label16.Text = "Telefone / Zap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(337, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "CPF do cliente";
            // 
            // TxCpf
            // 
            this.TxCpf.Location = new System.Drawing.Point(340, 135);
            this.TxCpf.MaxLength = 14;
            this.TxCpf.Name = "TxCpf";
            this.TxCpf.Size = new System.Drawing.Size(105, 20);
            this.TxCpf.TabIndex = 3;
            this.TxCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxCpf_KeyDown);
            this.TxCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxCpf_KeyPress);
            // 
            // TxCliente
            // 
            this.TxCliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxCliente.Location = new System.Drawing.Point(12, 135);
            this.TxCliente.MaxLength = 80;
            this.TxCliente.Name = "TxCliente";
            this.TxCliente.Size = new System.Drawing.Size(322, 20);
            this.TxCliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Nome do cliente";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtNovo,
            this.BtSalvar,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.BtImprimir,
            this.toolStripSeparator3,
            this.toolStripButton2});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(574, 39);
            this.toolStrip1.TabIndex = 105;
            this.toolStrip1.Text = "Menu";
            // 
            // BtNovo
            // 
            this.BtNovo.ForeColor = System.Drawing.Color.White;
            this.BtNovo.Image = ((System.Drawing.Image)(resources.GetObject("BtNovo.Image")));
            this.BtNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtNovo.Name = "BtNovo";
            this.BtNovo.Size = new System.Drawing.Size(72, 36);
            this.BtNovo.Text = "Novo";
            this.BtNovo.ToolTipText = "Novo Orçamento";
            this.BtNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // BtSalvar
            // 
            this.BtSalvar.ForeColor = System.Drawing.Color.White;
            this.BtSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtSalvar.Image")));
            this.BtSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(74, 36);
            this.BtSalvar.Text = "&Salvar";
            this.BtSalvar.ToolTipText = "Salvar Orçamento";
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Bioghet_Orcamento.Properties.Resources.whatsapp_lollipop_logo_B1DF222734_seeklogo1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // BtImprimir
            // 
            this.BtImprimir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatoriosToolStripMenuItem});
            this.BtImprimir.ForeColor = System.Drawing.Color.White;
            this.BtImprimir.Image = ((System.Drawing.Image)(resources.GetObject("BtImprimir.Image")));
            this.BtImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtImprimir.Name = "BtImprimir";
            this.BtImprimir.Size = new System.Drawing.Size(98, 36);
            this.BtImprimir.Text = "Imprimir";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impressão1ToolStripMenuItem,
            this.impressão2ToolStripMenuItem});
            this.relatoriosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.relatoriosToolStripMenuItem.Image = global::Bioghet_Orcamento.Properties.Resources.business_packages_boxes_products_sellingproducts_thereport_2344;
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            this.relatoriosToolStripMenuItem.ToolTipText = "Relatórios";
            this.relatoriosToolStripMenuItem.Click += new System.EventHandler(this.relatoriosToolStripMenuItem_Click);
            // 
            // impressão1ToolStripMenuItem
            // 
            this.impressão1ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.impressão1ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.impressão1ToolStripMenuItem.Name = "impressão1ToolStripMenuItem";
            this.impressão1ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.impressão1ToolStripMenuItem.Text = "Impressão 1";
            this.impressão1ToolStripMenuItem.Click += new System.EventHandler(this.impressão1ToolStripMenuItem_Click);
            // 
            // impressão2ToolStripMenuItem
            // 
            this.impressão2ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.impressão2ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.impressão2ToolStripMenuItem.Name = "impressão2ToolStripMenuItem";
            this.impressão2ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.impressão2ToolStripMenuItem.Text = "Impressão 2";
            this.impressão2ToolStripMenuItem.Click += new System.EventHandler(this.impressão2ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(78, 36);
            this.toolStripButton2.Text = "Fechar";
            this.toolStripButton2.ToolTipText = "Fechar o aplicativo";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // TxModelo
            // 
            this.TxModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TxModelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxModelo.FormattingEnabled = true;
            this.TxModelo.Location = new System.Drawing.Point(282, 194);
            this.TxModelo.Name = "TxModelo";
            this.TxModelo.Size = new System.Drawing.Size(249, 21);
            this.TxModelo.TabIndex = 7;
            this.TxModelo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxModelo_KeyDown);
            this.TxModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxModelo_KeyPress);
            this.TxModelo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxModelo_KeyUp);
            // 
            // TxDefeito
            // 
            this.TxDefeito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxDefeito.FormattingEnabled = true;
            this.TxDefeito.Location = new System.Drawing.Point(12, 242);
            this.TxDefeito.MaxDropDownItems = 10;
            this.TxDefeito.Name = "TxDefeito";
            this.TxDefeito.Size = new System.Drawing.Size(182, 21);
            this.TxDefeito.TabIndex = 8;
            this.TxDefeito.Click += new System.EventHandler(this.TxDefeito_Click);
            // 
            // TxMarca
            // 
            this.TxMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxMarca.FormattingEnabled = true;
            this.TxMarca.Location = new System.Drawing.Point(145, 194);
            this.TxMarca.MaxDropDownItems = 10;
            this.TxMarca.Name = "TxMarca";
            this.TxMarca.Size = new System.Drawing.Size(131, 21);
            this.TxMarca.TabIndex = 6;
            this.TxMarca.SelectedIndexChanged += new System.EventHandler(this.TxMarca_SelectedIndexChanged);
            // 
            // TxTipo
            // 
            this.TxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxTipo.FormattingEnabled = true;
            this.TxTipo.Location = new System.Drawing.Point(12, 194);
            this.TxTipo.MaxDropDownItems = 10;
            this.TxTipo.Name = "TxTipo";
            this.TxTipo.Size = new System.Drawing.Size(127, 21);
            this.TxTipo.TabIndex = 5;
            this.TxTipo.SelectedIndexChanged += new System.EventHandler(this.TxTipo_SelectedIndexChanged);
            this.TxTipo.Click += new System.EventHandler(this.TxTipo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 203;
            this.label3.Text = "Tipo do aparelho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(142, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 200;
            this.label4.Text = "Marca do aparelho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(289, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 201;
            this.label5.Text = "Modelo do aparelho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 202;
            this.label6.Text = "Defeito do aparelho";
            // 
            // TxObs
            // 
            this.TxObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxObs.Location = new System.Drawing.Point(200, 242);
            this.TxObs.MaxLength = 252;
            this.TxObs.Name = "TxObs";
            this.TxObs.Size = new System.Drawing.Size(351, 20);
            this.TxObs.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(197, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 207;
            this.label7.Text = "OBS";
            // 
            // TxOS
            // 
            this.TxOS.Location = new System.Drawing.Point(300, 86);
            this.TxOS.MaxLength = 14;
            this.TxOS.Name = "TxOS";
            this.TxOS.Size = new System.Drawing.Size(105, 20);
            this.TxOS.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(300, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 209;
            this.label8.Text = "Número O.S";
            // 
            // LbStatus
            // 
            this.LbStatus.AutoSize = true;
            this.LbStatus.BackColor = System.Drawing.Color.Transparent;
            this.LbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStatus.ForeColor = System.Drawing.Color.Yellow;
            this.LbStatus.Location = new System.Drawing.Point(479, 275);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(72, 16);
            this.LbStatus.TabIndex = 211;
            this.LbStatus.Text = "DIGITADO";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(425, 275);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(48, 16);
            this.label53.TabIndex = 210;
            this.label53.Text = "Status:";
            // 
            // TxImei
            // 
            this.TxImei.Location = new System.Drawing.Point(411, 86);
            this.TxImei.MaxLength = 14;
            this.TxImei.Name = "TxImei";
            this.TxImei.Size = new System.Drawing.Size(115, 20);
            this.TxImei.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(411, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 213;
            this.label9.Text = "Imei/Número de Série";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 215;
            this.label10.Text = "Filial";
            // 
            // CbFilial
            // 
            this.CbFilial.FormattingEnabled = true;
            this.CbFilial.Location = new System.Drawing.Point(12, 85);
            this.CbFilial.Name = "CbFilial";
            this.CbFilial.Size = new System.Drawing.Size(282, 21);
            this.CbFilial.TabIndex = 214;
            this.CbFilial.Click += new System.EventHandler(this.CbFilial_Click);
            // 
            // ChGerarImei
            // 
            this.ChGerarImei.AutoSize = true;
            this.ChGerarImei.BackColor = System.Drawing.Color.Transparent;
            this.ChGerarImei.ForeColor = System.Drawing.Color.Yellow;
            this.ChGerarImei.Location = new System.Drawing.Point(477, 52);
            this.ChGerarImei.Name = "ChGerarImei";
            this.ChGerarImei.Size = new System.Drawing.Size(74, 17);
            this.ChGerarImei.TabIndex = 216;
            this.ChGerarImei.Text = "Gerar Imei";
            this.ChGerarImei.UseVisualStyleBackColor = false;
            this.ChGerarImei.Click += new System.EventHandler(this.ChGerarImei_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Bioghet_Orcamento.Properties.Resources.download1;
            this.pictureBox3.Location = new System.Drawing.Point(532, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 205;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Bioghet_Orcamento.Properties.Resources.ie9_logo;
            this.pictureBox2.Location = new System.Drawing.Point(532, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 204;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(574, 300);
            this.Controls.Add(this.ChGerarImei);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CbFilial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxImei);
            this.Controls.Add(this.LbStatus);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxOS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxObs);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TxModelo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxDefeito);
            this.Controls.Add(this.TxMarca);
            this.Controls.Add(this.TxTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TxTelefone);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxCpf);
            this.Controls.Add(this.TxCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de servico";
            this.Load += new System.EventHandler(this.FormOS_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtNovo;
        private System.Windows.Forms.ToolStripButton BtSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton BtImprimir;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxOS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LbStatus;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbFilial;
        private System.Windows.Forms.CheckBox ChGerarImei;
        private System.Windows.Forms.ToolStripMenuItem impressão1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressão2ToolStripMenuItem;
        public System.Windows.Forms.MaskedTextBox TxTelefone;
        public System.Windows.Forms.TextBox TxCpf;
        public System.Windows.Forms.TextBox TxCliente;
        public System.Windows.Forms.ComboBox TxModelo;
        public System.Windows.Forms.ComboBox TxDefeito;
        public System.Windows.Forms.ComboBox TxMarca;
        public System.Windows.Forms.ComboBox TxTipo;
        public System.Windows.Forms.TextBox TxImei;
        public System.Windows.Forms.TextBox TxObs;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}