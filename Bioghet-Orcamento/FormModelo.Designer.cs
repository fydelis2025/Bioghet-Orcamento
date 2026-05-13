namespace Bioghet_Orcamento
{
    partial class FormModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModelo));
            this.TxCadMarca = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.DgURL = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxBR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxURL = new System.Windows.Forms.TextBox();
            this.TxAno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxNovo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxAparelho = new System.Windows.Forms.TextBox();
            this.TxMargem = new System.Windows.Forms.TextBox();
            this.DtFabricacao = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PImage = new System.Windows.Forms.PictureBox();
            this.PBuscar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PImagePeca = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.TxURLLocal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.TxMesAno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgURL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PImagePeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // TxCadMarca
            // 
            this.TxCadMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxCadMarca.FormattingEnabled = true;
            this.TxCadMarca.Location = new System.Drawing.Point(176, 106);
            this.TxCadMarca.Name = "TxCadMarca";
            this.TxCadMarca.Size = new System.Drawing.Size(174, 21);
            this.TxCadMarca.TabIndex = 1;
            this.TxCadMarca.SelectedIndexChanged += new System.EventHandler(this.TxCadMarca_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(173, 90);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 13);
            this.label32.TabIndex = 122;
            this.label32.Text = "Marca";
            // 
            // DgURL
            // 
            this.DgURL.AllowUserToAddRows = false;
            this.DgURL.AllowUserToDeleteRows = false;
            this.DgURL.AllowUserToResizeColumns = false;
            this.DgURL.AllowUserToResizeRows = false;
            this.DgURL.BackgroundColor = System.Drawing.Color.White;
            this.DgURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgURL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgURL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgURL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgURL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column4,
            this.mes,
            this.Column5,
            this.Column6});
            this.DgURL.Location = new System.Drawing.Point(10, 259);
            this.DgURL.Name = "DgURL";
            this.DgURL.RowHeadersVisible = false;
            this.DgURL.Size = new System.Drawing.Size(873, 256);
            this.DgURL.TabIndex = 123;
            this.DgURL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgURL_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 180F;
            this.Column1.HeaderText = "Modelo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "Pais";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 220F;
            this.Column3.HeaderText = "URL";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 220;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 70F;
            this.Column7.HeaderText = "Novo";
            this.Column7.Name = "Column7";
            this.Column7.Width = 70;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 50F;
            this.Column8.HeaderText = "Margem";
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 70F;
            this.Column9.HeaderText = "Usado";
            this.Column9.Name = "Column9";
            this.Column9.Width = 70;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 70F;
            this.Column4.HeaderText = "Ano";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // mes
            // 
            this.mes.HeaderText = "mes";
            this.mes.Name = "mes";
            this.mes.Visible = false;
            // 
            // Column5
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.FillWeight = 60F;
            this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column5.HeaderText = "Editar";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Text = "Editar";
            this.Column5.UseColumnTextForButtonValue = true;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.FillWeight = 60F;
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column6.HeaderText = "Excluir";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Text = "Excluir";
            this.Column6.UseColumnTextForButtonValue = true;
            this.Column6.Width = 60;
            // 
            // TxTipo
            // 
            this.TxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxTipo.FormattingEnabled = true;
            this.TxTipo.Location = new System.Drawing.Point(25, 106);
            this.TxTipo.MaxDropDownItems = 10;
            this.TxTipo.Name = "TxTipo";
            this.TxTipo.Size = new System.Drawing.Size(127, 21);
            this.TxTipo.TabIndex = 0;
            this.TxTipo.SelectedIndexChanged += new System.EventHandler(this.TxTipo_SelectedIndexChanged);
            this.TxTipo.Click += new System.EventHandler(this.TxTipo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 161;
            this.label3.Text = "Tipo do aparelho";
            // 
            // TxDescricao
            // 
            this.TxDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxDescricao.Location = new System.Drawing.Point(380, 106);
            this.TxDescricao.Name = "TxDescricao";
            this.TxDescricao.Size = new System.Drawing.Size(336, 20);
            this.TxDescricao.TabIndex = 2;
            this.TxDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxDescricao_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(377, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 163;
            this.label1.Text = "Modelo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Bioghet_Orcamento.Properties.Resources._7;
            this.button1.Location = new System.Drawing.Point(398, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 72);
            this.button1.TabIndex = 164;
            this.button1.Text = "Salvar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button1, "salvar / atualizar os aparelhos cadastrados");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxBR
            // 
            this.TxBR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxBR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBR.Location = new System.Drawing.Point(25, 147);
            this.TxBR.MaxLength = 2;
            this.TxBR.Name = "TxBR";
            this.TxBR.Size = new System.Drawing.Size(43, 20);
            this.TxBR.TabIndex = 3;
            this.TxBR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxBR_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 166;
            this.label2.Text = "BR";
            // 
            // TxURL
            // 
            this.TxURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxURL.Location = new System.Drawing.Point(74, 147);
            this.TxURL.Name = "TxURL";
            this.TxURL.Size = new System.Drawing.Size(318, 20);
            this.TxURL.TabIndex = 4;
            this.TxURL.TextChanged += new System.EventHandler(this.TxURL_TextChanged);
            this.TxURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxURL_KeyDown);
            // 
            // TxAno
            // 
            this.TxAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxAno.Location = new System.Drawing.Point(216, 186);
            this.TxAno.MaxLength = 4;
            this.TxAno.Name = "TxAno";
            this.TxAno.Size = new System.Drawing.Size(53, 20);
            this.TxAno.TabIndex = 10;
            this.TxAno.Text = "2017";
            this.TxAno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxAno_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 169;
            this.label4.Text = "URL Aparelho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(213, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 170;
            this.label5.Text = "Ano do ap";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Bioghet_Orcamento.Properties.Resources._8;
            this.button3.Location = new System.Drawing.Point(317, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 72);
            this.button3.TabIndex = 172;
            this.button3.Text = "Novo";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button3, "Criar novo modelo de aparelho");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(125, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 180;
            this.label7.Text = "R$ Usado";
            // 
            // TxNovo
            // 
            this.TxNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxNovo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxNovo.Location = new System.Drawing.Point(25, 187);
            this.TxNovo.MaxLength = 8;
            this.TxNovo.Name = "TxNovo";
            this.TxNovo.Size = new System.Drawing.Size(52, 20);
            this.TxNovo.TabIndex = 6;
            this.TxNovo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxNovo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxNovo_KeyDown);
            this.TxNovo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxNovo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 179;
            this.label8.Text = "R$ Novo";
            // 
            // TxAparelho
            // 
            this.TxAparelho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxAparelho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxAparelho.Location = new System.Drawing.Point(128, 187);
            this.TxAparelho.MaxLength = 8;
            this.TxAparelho.Name = "TxAparelho";
            this.TxAparelho.Size = new System.Drawing.Size(52, 20);
            this.TxAparelho.TabIndex = 8;
            this.TxAparelho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxAparelho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxAparelho_KeyDown);
            this.TxAparelho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxAparelho_KeyPress);
            // 
            // TxMargem
            // 
            this.TxMargem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxMargem.Location = new System.Drawing.Point(83, 187);
            this.TxMargem.MaxLength = 4;
            this.TxMargem.Name = "TxMargem";
            this.TxMargem.Size = new System.Drawing.Size(39, 20);
            this.TxMargem.TabIndex = 7;
            this.TxMargem.Text = "5";
            this.TxMargem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxMargem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxMargem_KeyDown);
            this.TxMargem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxMargem_KeyPress);
            // 
            // DtFabricacao
            // 
            this.DtFabricacao.AutoSize = true;
            this.DtFabricacao.BackColor = System.Drawing.Color.Transparent;
            this.DtFabricacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFabricacao.ForeColor = System.Drawing.Color.Orange;
            this.DtFabricacao.Location = new System.Drawing.Point(86, 172);
            this.DtFabricacao.Name = "DtFabricacao";
            this.DtFabricacao.Size = new System.Drawing.Size(32, 13);
            this.DtFabricacao.TabIndex = 178;
            this.DtFabricacao.Text = "(%) -";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Bioghet_Orcamento.Properties.Resources.download1;
            this.button4.Location = new System.Drawing.Point(479, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 72);
            this.button4.TabIndex = 182;
            this.button4.Text = "Importar";
            this.toolTip1.SetToolTip(this.button4, "Importar Imagem");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Bioghet";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Bioghet_Orcamento.Properties.Resources.add;
            this.pictureBox3.Location = new System.Drawing.Point(155, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 187;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Tipo Serviço");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Bioghet_Orcamento.Properties.Resources._8;
            this.pictureBox2.Location = new System.Drawing.Point(718, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 183;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Baixar Imagem");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PImage
            // 
            this.PImage.BackColor = System.Drawing.Color.Transparent;
            this.PImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PImage.Location = new System.Drawing.Point(751, 78);
            this.PImage.Name = "PImage";
            this.PImage.Size = new System.Drawing.Size(141, 167);
            this.PImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PImage.TabIndex = 181;
            this.PImage.TabStop = false;
            this.toolTip1.SetToolTip(this.PImage, "Imagem do aparelho");
            this.PImage.Click += new System.EventHandler(this.PImage_Click);
            // 
            // PBuscar
            // 
            this.PBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBuscar.Image = global::Bioghet_Orcamento.Properties.Resources._10;
            this.PBuscar.Location = new System.Drawing.Point(718, 105);
            this.PBuscar.Name = "PBuscar";
            this.PBuscar.Size = new System.Drawing.Size(19, 21);
            this.PBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBuscar.TabIndex = 173;
            this.PBuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.PBuscar, "Acessar Internet");
            this.PBuscar.Click += new System.EventHandler(this.PBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Bioghet_Orcamento.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(356, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 171;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Cadastrar Marcas");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PImagePeca
            // 
            this.PImagePeca.BackColor = System.Drawing.Color.Transparent;
            this.PImagePeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PImagePeca.Location = new System.Drawing.Point(876, 79);
            this.PImagePeca.Name = "PImagePeca";
            this.PImagePeca.Size = new System.Drawing.Size(11, 10);
            this.PImagePeca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PImagePeca.TabIndex = 239;
            this.PImagePeca.TabStop = false;
            this.toolTip1.SetToolTip(this.PImagePeca, "Imagem do aparelho");
            this.PImagePeca.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Bioghet_Orcamento.Properties.Resources.ie9_logo;
            this.pictureBox6.Location = new System.Drawing.Point(400, 147);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(19, 21);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 244;
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, "Baixar Imagem");
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Bioghet_Orcamento.Properties.Resources.orcamentoicon_fw;
            this.button5.Location = new System.Drawing.Point(560, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 73);
            this.button5.TabIndex = 238;
            this.button5.Text = "Orçamento";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TxURLLocal
            // 
            this.TxURLLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxURLLocal.Location = new System.Drawing.Point(425, 147);
            this.TxURLLocal.Name = "TxURLLocal";
            this.TxURLLocal.Size = new System.Drawing.Size(291, 20);
            this.TxURLLocal.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(422, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 185;
            this.label9.Text = "URL Peça";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Bioghet_Orcamento.Properties.Resources.minimize_thewindow_theapplication_2872;
            this.pictureBox4.Location = new System.Drawing.Point(816, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 237;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Bioghet_Orcamento.Properties.Resources.shutdown;
            this.pictureBox5.Location = new System.Drawing.Point(851, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 236;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // TxMesAno
            // 
            this.TxMesAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxMesAno.Location = new System.Drawing.Point(186, 187);
            this.TxMesAno.MaxLength = 4;
            this.TxMesAno.Name = "TxMesAno";
            this.TxMesAno.Size = new System.Drawing.Size(24, 20);
            this.TxMesAno.TabIndex = 9;
            this.TxMesAno.Text = "1";
            this.TxMesAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxMesAno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxMesAno_KeyDown);
            this.TxMesAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxMesAno_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(183, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 242;
            this.label6.Text = "Mês";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Bioghet_Orcamento.Properties.Resources.Sem_título_1_fw;
            this.button2.Location = new System.Drawing.Point(641, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 73);
            this.button2.TabIndex = 243;
            this.button2.Text = "URL";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // FormModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::Bioghet_Orcamento.Properties.Resources.MODELO_fw;
            this.ClientSize = new System.Drawing.Size(895, 527);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxMesAno);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxURLLocal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxNovo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxAparelho);
            this.Controls.Add(this.TxMargem);
            this.Controls.Add(this.DtFabricacao);
            this.Controls.Add(this.PBuscar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxAno);
            this.Controls.Add(this.TxURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxBR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxDescricao);
            this.Controls.Add(this.TxTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgURL);
            this.Controls.Add(this.TxCadMarca);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.PImagePeca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutencao";
            this.Load += new System.EventHandler(this.FormManutencao_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormModelo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormModelo_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormModelo_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.DgURL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PImagePeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TxCadMarca;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView DgURL;
        private System.Windows.Forms.ComboBox TxTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxBR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxURL;
        private System.Windows.Forms.TextBox TxAno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox PBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxNovo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxAparelho;
        private System.Windows.Forms.TextBox TxMargem;
        private System.Windows.Forms.Label DtFabricacao;
        private System.Windows.Forms.PictureBox PImage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxURLLocal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox PImagePeca;
        private System.Windows.Forms.TextBox TxMesAno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}