namespace Bioghet_Orcamento
{
    partial class Telecentro_Orcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telecentro_Orcamento));
            this.OrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RptOrcamento = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.OrcamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrcamentoBindingSource
            // 
            this.OrcamentoBindingSource.DataSource = typeof(Bioghet_Orcamento.Orcamento);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(10, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(596, 33);
            this.label6.TabIndex = 178;
            this.label6.Text = "IMPRESSÃO DO ORÇAMENTO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(612, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 177;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RptOrcamento
            // 
            this.RptOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrcamentoBindingSource;
            this.RptOrcamento.LocalReport.DataSources.Add(reportDataSource1);
            this.RptOrcamento.LocalReport.DisplayName = "ORÇAMENTO";
            this.RptOrcamento.LocalReport.EnableExternalImages = true;
            this.RptOrcamento.LocalReport.EnableHyperlinks = true;
            this.RptOrcamento.LocalReport.ReportEmbeddedResource = "Bioghet_Orcamento.Report1.rdlc";
            this.RptOrcamento.Location = new System.Drawing.Point(10, 66);
            this.RptOrcamento.Name = "RptOrcamento";
            this.RptOrcamento.Size = new System.Drawing.Size(677, 655);
            this.RptOrcamento.TabIndex = 176;
            // 
            // Telecentro_Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(697, 750);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RptOrcamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Telecentro_Orcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telecentro_Orcamento";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Telecentro_Orcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrcamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource OrcamentoBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer RptOrcamento;
    }
}