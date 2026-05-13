namespace Bioghet_Orcamento
{
    partial class FormSMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSMS));
            this.label1 = new System.Windows.Forms.Label();
            this.TxTelefone = new System.Windows.Forms.TextBox();
            this.TxNotificacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbPorta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.BtDesconectar = new System.Windows.Forms.Button();
            this.BtConectar = new System.Windows.Forms.Button();
            this.BtEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefone";
            // 
            // TxTelefone
            // 
            this.TxTelefone.Location = new System.Drawing.Point(15, 106);
            this.TxTelefone.Name = "TxTelefone";
            this.TxTelefone.Size = new System.Drawing.Size(140, 20);
            this.TxTelefone.TabIndex = 2;
            // 
            // TxNotificacao
            // 
            this.TxNotificacao.Location = new System.Drawing.Point(15, 165);
            this.TxNotificacao.Multiline = true;
            this.TxNotificacao.Name = "TxNotificacao";
            this.TxNotificacao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxNotificacao.Size = new System.Drawing.Size(275, 173);
            this.TxNotificacao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Notificação";
            // 
            // CbPorta
            // 
            this.CbPorta.FormattingEnabled = true;
            this.CbPorta.Location = new System.Drawing.Point(15, 57);
            this.CbPorta.Name = "CbPorta";
            this.CbPorta.Size = new System.Drawing.Size(121, 21);
            this.CbPorta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Porta";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(299, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // BtDesconectar
            // 
            this.BtDesconectar.BackColor = System.Drawing.Color.White;
            this.BtDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtDesconectar.Enabled = false;
            this.BtDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDesconectar.Image = global::Bioghet_Orcamento.Properties.Resources.connect_1217;
            this.BtDesconectar.Location = new System.Drawing.Point(221, 37);
            this.BtDesconectar.Name = "BtDesconectar";
            this.BtDesconectar.Size = new System.Drawing.Size(45, 40);
            this.BtDesconectar.TabIndex = 9;
            this.BtDesconectar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtDesconectar.UseVisualStyleBackColor = false;
            this.BtDesconectar.Click += new System.EventHandler(this.BtDesconectar_Click);
            // 
            // BtConectar
            // 
            this.BtConectar.BackColor = System.Drawing.Color.White;
            this.BtConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtConectar.Image = global::Bioghet_Orcamento.Properties.Resources.connectedset_1218;
            this.BtConectar.Location = new System.Drawing.Point(170, 37);
            this.BtConectar.Name = "BtConectar";
            this.BtConectar.Size = new System.Drawing.Size(45, 40);
            this.BtConectar.TabIndex = 8;
            this.BtConectar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtConectar.UseVisualStyleBackColor = false;
            this.BtConectar.Click += new System.EventHandler(this.BtConectar_Click);
            // 
            // BtEnviar
            // 
            this.BtEnviar.BackColor = System.Drawing.Color.White;
            this.BtEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtEnviar.Enabled = false;
            this.BtEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEnviar.Image = global::Bioghet_Orcamento.Properties.Resources.send_text_message_icon_icons_com_52480;
            this.BtEnviar.Location = new System.Drawing.Point(170, 89);
            this.BtEnviar.Name = "BtEnviar";
            this.BtEnviar.Size = new System.Drawing.Size(45, 41);
            this.BtEnviar.TabIndex = 0;
            this.BtEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEnviar.UseVisualStyleBackColor = false;
            this.BtEnviar.Click += new System.EventHandler(this.BtEnviar_Click);
            // 
            // FormSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(299, 380);
            this.Controls.Add(this.BtDesconectar);
            this.Controls.Add(this.BtConectar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbPorta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxNotificacao);
            this.Controls.Add(this.TxTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtEnviar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS";
            this.Load += new System.EventHandler(this.FormSMS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxTelefone;
        private System.Windows.Forms.TextBox TxNotificacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbPorta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button BtConectar;
        private System.Windows.Forms.Button BtDesconectar;
    }
}