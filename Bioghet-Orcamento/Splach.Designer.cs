namespace Bioghet_Orcamento
{
    partial class Splach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splach));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BkProgress = new System.ComponentModel.BackgroundWorker();
            this.label38 = new System.Windows.Forms.Label();
            this.PLoad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(19, 381);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(621, 41);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // BkProgress
            // 
            this.BkProgress.WorkerReportsProgress = true;
            this.BkProgress.WorkerSupportsCancellation = true;
            this.BkProgress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BkProgress_DoWork);
            this.BkProgress.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BkProgress_ProgressChanged);
            this.BkProgress.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BkProgress_RunWorkerCompleted);
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label38.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label38.Location = new System.Drawing.Point(13, 21);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(627, 33);
            this.label38.TabIndex = 184;
            this.label38.Text = "ORÇAMENTO RÁPIDO PARA O CLIENTE";
            this.label38.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PLoad
            // 
            this.PLoad.BackColor = System.Drawing.Color.Transparent;
            this.PLoad.Image = global::Bioghet_Orcamento.Properties.Resources._27332460_484949021941737_5394615602741053096_n;
            this.PLoad.Location = new System.Drawing.Point(19, 73);
            this.PLoad.Name = "PLoad";
            this.PLoad.Size = new System.Drawing.Size(632, 293);
            this.PLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PLoad.TabIndex = 188;
            this.PLoad.TabStop = false;
            // 
            // Splach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::Bioghet_Orcamento.Properties.Resources.splash_fw;
            this.ClientSize = new System.Drawing.Size(659, 436);
            this.Controls.Add(this.PLoad);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splach";
            this.Load += new System.EventHandler(this.Splach_Load);
            this.Shown += new System.EventHandler(this.Splach_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Splach_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker BkProgress;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.PictureBox PLoad;
    }
}