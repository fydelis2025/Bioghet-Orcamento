namespace Bioghet_Orcamento.Fiscal
{
    partial class LMFS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LMFS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_Arquivo = new System.Windows.Forms.RadioButton();
            this.RB_Impressa = new System.Windows.Forms.RadioButton();
            this.TB_Parametro_Final = new System.Windows.Forms.TextBox();
            this.TB_Parametro_Inicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Fechar = new System.Windows.Forms.Button();
            this.BT_Enviar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Arquivo);
            this.groupBox1.Controls.Add(this.RB_Impressa);
            this.groupBox1.Controls.Add(this.TB_Parametro_Final);
            this.groupBox1.Controls.Add(this.TB_Parametro_Inicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 95);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leitura da Memoria Fiscal Completa";
            // 
            // RB_Arquivo
            // 
            this.RB_Arquivo.AutoSize = true;
            this.RB_Arquivo.Location = new System.Drawing.Point(300, 56);
            this.RB_Arquivo.Name = "RB_Arquivo";
            this.RB_Arquivo.Size = new System.Drawing.Size(61, 17);
            this.RB_Arquivo.TabIndex = 89;
            this.RB_Arquivo.Text = "Arquivo";
            this.RB_Arquivo.UseVisualStyleBackColor = true;
            // 
            // RB_Impressa
            // 
            this.RB_Impressa.AutoSize = true;
            this.RB_Impressa.Checked = true;
            this.RB_Impressa.Location = new System.Drawing.Point(300, 26);
            this.RB_Impressa.Name = "RB_Impressa";
            this.RB_Impressa.Size = new System.Drawing.Size(67, 17);
            this.RB_Impressa.TabIndex = 88;
            this.RB_Impressa.TabStop = true;
            this.RB_Impressa.Text = "Impressa";
            this.RB_Impressa.UseVisualStyleBackColor = true;
            // 
            // TB_Parametro_Final
            // 
            this.TB_Parametro_Final.Location = new System.Drawing.Point(116, 56);
            this.TB_Parametro_Final.Name = "TB_Parametro_Final";
            this.TB_Parametro_Final.Size = new System.Drawing.Size(143, 20);
            this.TB_Parametro_Final.TabIndex = 87;
            this.TB_Parametro_Final.Text = "31/01/2010";
            // 
            // TB_Parametro_Inicial
            // 
            this.TB_Parametro_Inicial.Location = new System.Drawing.Point(116, 24);
            this.TB_Parametro_Inicial.Name = "TB_Parametro_Inicial";
            this.TB_Parametro_Inicial.Size = new System.Drawing.Size(143, 20);
            this.TB_Parametro_Inicial.TabIndex = 86;
            this.TB_Parametro_Inicial.Text = "01/01/2010";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Parâmetro Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Parâmetro Inicial:";
            // 
            // BT_Fechar
            // 
            this.BT_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Fechar.ForeColor = System.Drawing.Color.White;
            this.BT_Fechar.Location = new System.Drawing.Point(310, 113);
            this.BT_Fechar.Name = "BT_Fechar";
            this.BT_Fechar.Size = new System.Drawing.Size(77, 23);
            this.BT_Fechar.TabIndex = 89;
            this.BT_Fechar.Text = "Fechar";
            this.BT_Fechar.UseVisualStyleBackColor = true;
            // 
            // BT_Enviar
            // 
            this.BT_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Enviar.ForeColor = System.Drawing.Color.White;
            this.BT_Enviar.Location = new System.Drawing.Point(229, 113);
            this.BT_Enviar.Name = "BT_Enviar";
            this.BT_Enviar.Size = new System.Drawing.Size(77, 23);
            this.BT_Enviar.TabIndex = 88;
            this.BT_Enviar.Text = "Enviar";
            this.BT_Enviar.UseVisualStyleBackColor = true;
            this.BT_Enviar.Click += new System.EventHandler(this.BT_Enviar_Click);
            // 
            // LMFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(400, 145);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BT_Fechar);
            this.Controls.Add(this.BT_Enviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LMFS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LMFS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_Arquivo;
        private System.Windows.Forms.RadioButton RB_Impressa;
        private System.Windows.Forms.TextBox TB_Parametro_Final;
        private System.Windows.Forms.TextBox TB_Parametro_Inicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Fechar;
        private System.Windows.Forms.Button BT_Enviar;
    }
}