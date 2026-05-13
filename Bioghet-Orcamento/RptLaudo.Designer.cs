namespace Bioghet_Orcamento
{
    partial class RptLaudo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptLaudo));
            this.LaudoTecnicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RptLaudoTecnico = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.LaudoTecnicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LaudoTecnicoBindingSource
            // 
            this.LaudoTecnicoBindingSource.DataSource = typeof(Bioghet_Orcamento.LaudoTecnico);
            // 
            // RptLaudoTecnico
            // 
            this.RptLaudoTecnico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptLaudoTecnico.DocumentMapWidth = 85;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LaudoTecnicoBindingSource;
            this.RptLaudoTecnico.LocalReport.DataSources.Add(reportDataSource1);
            this.RptLaudoTecnico.LocalReport.DisplayName = "Laudo Técnico";
            this.RptLaudoTecnico.LocalReport.ReportEmbeddedResource = "Bioghet_Orcamento.Report5.rdlc";
            this.RptLaudoTecnico.Location = new System.Drawing.Point(0, 0);
            this.RptLaudoTecnico.Name = "RptLaudoTecnico";
            this.RptLaudoTecnico.ServerReport.DisplayName = "RptLaudo";
            this.RptLaudoTecnico.Size = new System.Drawing.Size(697, 750);
            this.RptLaudoTecnico.TabIndex = 178;
            // 
            // RptLaudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(697, 750);
            this.Controls.Add(this.RptLaudoTecnico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RptLaudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laudo Técnico";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RptLaudo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LaudoTecnicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer RptLaudoTecnico;
        private System.Windows.Forms.BindingSource LaudoTecnicoBindingSource;
    }
}