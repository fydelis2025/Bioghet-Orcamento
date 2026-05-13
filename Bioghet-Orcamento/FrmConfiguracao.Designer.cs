namespace Bioghet_Orcamento
{
    partial class FrmConfiguracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracao));
            this.PropertyConfig = new System.Windows.Forms.PropertyGrid();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // PropertyConfig
            // 
            this.PropertyConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PropertyConfig.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PropertyConfig.CommandsActiveLinkColor = System.Drawing.Color.White;
            this.PropertyConfig.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.PropertyConfig.CommandsForeColor = System.Drawing.Color.White;
            this.PropertyConfig.HelpBackColor = System.Drawing.Color.White;
            this.PropertyConfig.Location = new System.Drawing.Point(12, 75);
            this.PropertyConfig.Name = "PropertyConfig";
            this.PropertyConfig.Size = new System.Drawing.Size(663, 568);
            this.PropertyConfig.TabIndex = 1;
            this.PropertyConfig.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropertyConfig_PropertyValueChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Bioghet_Orcamento.Properties.Resources.shutdown;
            this.pictureBox4.Location = new System.Drawing.Point(642, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 236;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // FrmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::Bioghet_Orcamento.Properties.Resources.CONFIGURACAO1;
            this.ClientSize = new System.Drawing.Size(687, 668);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.PropertyConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração do Sistema";
            this.Activated += new System.EventHandler(this.FrmConfiguracao_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConfiguracao_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConfiguracao_FormClosed);
            this.Load += new System.EventHandler(this.FrmConfiguracao_Load);
            this.Shown += new System.EventHandler(this.FrmConfiguracao_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmConfiguracao_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmConfiguracao_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmConfiguracao_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid PropertyConfig;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}