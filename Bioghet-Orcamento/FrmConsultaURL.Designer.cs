namespace Bioghet_Orcamento
{
    partial class FrmConsultaURL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaURL));
            this.CbReferencia = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.DgConsulta = new System.Windows.Forms.DataGridView();
            this.URL = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsulta)).BeginInit();
            this.SuspendLayout();
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
            this.CbReferencia.Location = new System.Drawing.Point(12, 32);
            this.CbReferencia.Name = "CbReferencia";
            this.CbReferencia.Size = new System.Drawing.Size(451, 21);
            this.CbReferencia.TabIndex = 4;
            this.CbReferencia.SelectedValueChanged += new System.EventHandler(this.CbReferencia_SelectedValueChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(9, 16);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 13);
            this.label32.TabIndex = 169;
            this.label32.Text = "Referencia";
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.URL});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgConsulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgConsulta.GridColor = System.Drawing.Color.Silver;
            this.DgConsulta.Location = new System.Drawing.Point(12, 69);
            this.DgConsulta.Name = "DgConsulta";
            this.DgConsulta.RowHeadersVisible = false;
            this.DgConsulta.Size = new System.Drawing.Size(471, 369);
            this.DgConsulta.TabIndex = 196;
            this.DgConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgConsulta_CellClick);
            // 
            // URL
            // 
            this.URL.FillWeight = 450F;
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.URL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.URL.Width = 450;
            // 
            // FrmConsultaURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.DgConsulta);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.CbReferencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaURL";
            this.Text = "Consultar URL";
            ((System.ComponentModel.ISupportInitialize)(this.DgConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CbReferencia;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView DgConsulta;
        private System.Windows.Forms.DataGridViewLinkColumn URL;
    }
}