namespace Bioghet_Orcamento
{
    partial class FormOrdemServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdemServico));
            this.Bioghet_OSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RptOs = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Bioghet_OSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Bioghet_OSBindingSource
            // 
            this.Bioghet_OSBindingSource.DataSource = typeof(Bioghet_Orcamento.Bioghet_OS);
            // 
            // RptOs
            // 
            this.RptOs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptOs.Location = new System.Drawing.Point(0, 0);
            this.RptOs.Name = "RptOs";
            this.RptOs.Size = new System.Drawing.Size(697, 440);
            this.RptOs.TabIndex = 0;
            // 
            // FormOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 440);
            this.Controls.Add(this.RptOs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormOrdemServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bioghet_OSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource Bioghet_OSBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer RptOs;
    }
}