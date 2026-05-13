namespace Bioghet_Orcamento
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.OrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RptOrcamento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // OrcamentoBindingSource
            // 
            this.OrcamentoBindingSource.DataSource = typeof(Bioghet_Orcamento.Orcamento);
            // 
            // RptOrcamento
            // 
            this.RptOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RptOrcamento.LocalReport.ReportEmbeddedResource = "Bioghet_Orcamento.Report2.rdlc";
            this.RptOrcamento.Location = new System.Drawing.Point(12, 109);
            this.RptOrcamento.Name = "RptOrcamento";
            this.RptOrcamento.ServerReport.DisplayName = "Bioghet Orçamento";
            this.RptOrcamento.Size = new System.Drawing.Size(681, 641);
            this.RptOrcamento.TabIndex = 176;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Bioghet_Orcamento.Properties.Resources.shutdown;
            this.pictureBox4.Location = new System.Drawing.Point(653, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 235;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::Bioghet_Orcamento.Properties.Resources.TELA_IMPRESSAO_fw;
            this.ClientSize = new System.Drawing.Size(705, 773);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.RptOrcamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.OrcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Microsoft.Reporting.WinForms.ReportViewer RptOrcamento;
        private System.Windows.Forms.BindingSource OrcamentoBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer RptOrcamento;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}