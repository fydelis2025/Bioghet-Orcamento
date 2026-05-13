namespace Bioghet_Orcamento
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.label32 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CbReferencia = new System.Windows.Forms.ComboBox();
            this.TxMarca = new System.Windows.Forms.ComboBox();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbTestado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DgConsulta = new System.Windows.Forms.DataGridView();
            this.URL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.REFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Testado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EDITAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.BtBuscar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(10, 25);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 13);
            this.label32.TabIndex = 168;
            this.label32.Text = "Referencia";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Bioghet_Orcamento.Properties.Resources._7;
            this.button2.Location = new System.Drawing.Point(759, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 49);
            this.button2.TabIndex = 180;
            this.toolTip1.SetToolTip(this.button2, "SALVAR");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Bioghet_Orcamento.Properties.Resources._8;
            this.button1.Location = new System.Drawing.Point(759, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 54);
            this.button1.TabIndex = 181;
            this.toolTip1.SetToolTip(this.button1, "NOVO");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CbReferencia
            // 
            this.CbReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CbReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbReferencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbReferencia.FormattingEnabled = true;
            this.CbReferencia.Items.AddRange(new object[] {
            "APARELHO",
            "PEÇAS",
            "ACESSORIOS",
            "SOFT e FLASH",
            "ROM e BIOS",
            "MANUAIS e ESQUEMAS"});
            this.CbReferencia.Location = new System.Drawing.Point(13, 42);
            this.CbReferencia.Name = "CbReferencia";
            this.CbReferencia.Size = new System.Drawing.Size(201, 21);
            this.CbReferencia.TabIndex = 0;
            this.CbReferencia.SelectedValueChanged += new System.EventHandler(this.CbReferencia_SelectedValueChanged);
            // 
            // TxMarca
            // 
            this.TxMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxMarca.FormattingEnabled = true;
            this.TxMarca.Location = new System.Drawing.Point(332, 42);
            this.TxMarca.Name = "TxMarca";
            this.TxMarca.Size = new System.Drawing.Size(117, 21);
            this.TxMarca.TabIndex = 2;
            // 
            // CbTipo
            // 
            this.CbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbTipo.FormattingEnabled = true;
            this.CbTipo.Location = new System.Drawing.Point(220, 42);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(106, 21);
            this.CbTipo.TabIndex = 1;
            this.CbTipo.SelectedIndexChanged += new System.EventHandler(this.CbTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 187;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(327, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 185;
            this.label2.Text = "Marca";
            // 
            // CbStatus
            // 
            this.CbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbStatus.FormattingEnabled = true;
            this.CbStatus.Items.AddRange(new object[] {
            "NOVO",
            "USADO",
            "AVALIA-VENDA"});
            this.CbStatus.Location = new System.Drawing.Point(455, 41);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(109, 21);
            this.CbStatus.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(452, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 190;
            this.label3.Text = "Status";
            // 
            // TxURL
            // 
            this.TxURL.Location = new System.Drawing.Point(13, 89);
            this.TxURL.Name = "TxURL";
            this.TxURL.Size = new System.Drawing.Size(635, 20);
            this.TxURL.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 192;
            this.label4.Text = "URL";
            // 
            // CbTestado
            // 
            this.CbTestado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CbTestado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbTestado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbTestado.FormattingEnabled = true;
            this.CbTestado.Items.AddRange(new object[] {
            "SIM",
            "NAO"});
            this.CbTestado.Location = new System.Drawing.Point(570, 41);
            this.CbTestado.Name = "CbTestado";
            this.CbTestado.Size = new System.Drawing.Size(78, 21);
            this.CbTestado.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(567, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 194;
            this.label5.Text = "Testado";
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.URL,
            this.REFERENCIA,
            this.Tipo,
            this.Marca,
            this.Status,
            this.Testado,
            this.EDITAR,
            this.DELETE});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgConsulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgConsulta.GridColor = System.Drawing.Color.Silver;
            this.DgConsulta.Location = new System.Drawing.Point(11, 147);
            this.DgConsulta.Name = "DgConsulta";
            this.DgConsulta.RowHeadersVisible = false;
            this.DgConsulta.Size = new System.Drawing.Size(797, 239);
            this.DgConsulta.TabIndex = 195;
            this.DgConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgConsulta_CellClick_1);
            // 
            // URL
            // 
            this.URL.FillWeight = 200F;
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.URL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.URL.Width = 200;
            // 
            // REFERENCIA
            // 
            this.REFERENCIA.FillWeight = 80F;
            this.REFERENCIA.HeaderText = "Referencia";
            this.REFERENCIA.Name = "REFERENCIA";
            this.REFERENCIA.Width = 80;
            // 
            // Tipo
            // 
            this.Tipo.FillWeight = 80F;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 80;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Testado
            // 
            this.Testado.FillWeight = 80F;
            this.Testado.HeaderText = "Testado";
            this.Testado.Name = "Testado";
            this.Testado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Testado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Testado.Width = 80;
            // 
            // EDITAR
            // 
            this.EDITAR.FillWeight = 70F;
            this.EDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EDITAR.HeaderText = "";
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.Text = "EDITAR";
            this.EDITAR.ToolTipText = "EDITAR";
            this.EDITAR.UseColumnTextForButtonValue = true;
            this.EDITAR.Width = 70;
            // 
            // DELETE
            // 
            this.DELETE.FillWeight = 70F;
            this.DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DELETE.HeaderText = "";
            this.DELETE.Name = "DELETE";
            this.DELETE.Text = "DELETE";
            this.DELETE.ToolTipText = "DELETE";
            this.DELETE.UseColumnTextForButtonValue = true;
            this.DELETE.Width = 70;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-2, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(810, 23);
            this.label6.TabIndex = 196;
            this.label6.Text = "URL CADASTRADOS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtBuscar
            // 
            this.BtBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtBuscar.Image = global::Bioghet_Orcamento.Properties.Resources._10;
            this.BtBuscar.Location = new System.Drawing.Point(654, 35);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(28, 28);
            this.BtBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtBuscar.TabIndex = 197;
            this.BtBuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.BtBuscar, "Buscar");
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Bioghet";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(820, 396);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DgConsulta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbTestado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbStatus);
            this.Controls.Add(this.TxMarca);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbReferencia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label32);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE LINKS";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CbReferencia;
        private System.Windows.Forms.ComboBox TxMarca;
        private System.Windows.Forms.ComboBox CbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbTestado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewLinkColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Testado;
        private System.Windows.Forms.DataGridViewButtonColumn EDITAR;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
        private System.Windows.Forms.PictureBox BtBuscar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}