namespace Bioghet_Orcamento
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.CbParaguai = new System.Windows.Forms.ComboBox();
            this.CbMercadoLivre = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PY = new System.Windows.Forms.WebBrowser();
            this.ML = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbParaguai
            // 
            this.CbParaguai.FormattingEnabled = true;
            this.CbParaguai.Location = new System.Drawing.Point(11, 94);
            this.CbParaguai.Name = "CbParaguai";
            this.CbParaguai.Size = new System.Drawing.Size(508, 21);
            this.CbParaguai.TabIndex = 5;
            this.CbParaguai.SelectedIndexChanged += new System.EventHandler(this.CbParaguai_SelectedIndexChanged);
            this.CbParaguai.Click += new System.EventHandler(this.CbParaguai_Click);
            // 
            // CbMercadoLivre
            // 
            this.CbMercadoLivre.FormattingEnabled = true;
            this.CbMercadoLivre.Location = new System.Drawing.Point(525, 94);
            this.CbMercadoLivre.Name = "CbMercadoLivre";
            this.CbMercadoLivre.Size = new System.Drawing.Size(501, 21);
            this.CbMercadoLivre.TabIndex = 6;
            this.CbMercadoLivre.SelectedIndexChanged += new System.EventHandler(this.CbMercadoLivre_SelectedIndexChanged);
            this.CbMercadoLivre.Click += new System.EventHandler(this.CbMercadoLivre_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1036, 39);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = global::Bioghet_Orcamento.Properties.Resources.add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(117, 36);
            this.toolStripButton1.Text = "Cadastrar URL";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Image = global::Bioghet_Orcamento.Properties.Resources._9;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(78, 36);
            this.toolStripButton2.Text = "Fechar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(525, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Informe a url cadastrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Informe a url cadastrada";
            // 
            // PY
            // 
            this.PY.Location = new System.Drawing.Point(11, 121);
            this.PY.MinimumSize = new System.Drawing.Size(20, 20);
            this.PY.Name = "PY";
            this.PY.ScriptErrorsSuppressed = true;
            this.PY.Size = new System.Drawing.Size(508, 546);
            this.PY.TabIndex = 10;
            // 
            // ML
            // 
            this.ML.Location = new System.Drawing.Point(525, 121);
            this.ML.MinimumSize = new System.Drawing.Size(20, 20);
            this.ML.Name = "ML";
            this.ML.ScriptErrorsSuppressed = true;
            this.ML.Size = new System.Drawing.Size(500, 546);
            this.ML.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1036, 703);
            this.Controls.Add(this.ML);
            this.Controls.Add(this.PY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.CbMercadoLivre);
            this.Controls.Add(this.CbParaguai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diversos";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbParaguai;
        private System.Windows.Forms.ComboBox CbMercadoLivre;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.WebBrowser PY;
        public System.Windows.Forms.WebBrowser ML;

    }
}