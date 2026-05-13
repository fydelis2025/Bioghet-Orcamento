namespace Bioghet_Orcamento
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.TxMarca = new System.Windows.Forms.ComboBox();
            this.TxImei = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TxModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxRG = new System.Windows.Forms.TextBox();
            this.TxTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxCPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxMarca
            // 
            this.TxMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxMarca.FormattingEnabled = true;
            this.TxMarca.Location = new System.Drawing.Point(161, 83);
            this.TxMarca.MaxDropDownItems = 10;
            this.TxMarca.Name = "TxMarca";
            this.TxMarca.Size = new System.Drawing.Size(88, 21);
            this.TxMarca.TabIndex = 2;
            this.TxMarca.SelectedIndexChanged += new System.EventHandler(this.TxMarca_SelectedIndexChanged);
            // 
            // TxImei
            // 
            this.TxImei.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxImei.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxImei.Location = new System.Drawing.Point(253, 84);
            this.TxImei.MaxLength = 20;
            this.TxImei.Name = "TxImei";
            this.TxImei.Size = new System.Drawing.Size(104, 20);
            this.TxImei.TabIndex = 1;
            this.TxImei.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxImei_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(250, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 113;
            this.label17.Text = "Imei / Serial";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(158, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 112;
            this.label13.Text = "Marca";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(57, 154);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 107);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // TxModelo
            // 
            this.TxModelo.Location = new System.Drawing.Point(57, 131);
            this.TxModelo.Name = "TxModelo";
            this.TxModelo.Size = new System.Drawing.Size(300, 20);
            this.TxModelo.TabIndex = 3;
            this.TxModelo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxModelo_KeyDown);
            this.TxModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxModelo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 148;
            this.label5.Text = "Modelo do aparelho";
            // 
            // TxValor
            // 
            this.TxValor.Location = new System.Drawing.Point(59, 363);
            this.TxValor.Name = "TxValor";
            this.TxValor.Size = new System.Drawing.Size(59, 20);
            this.TxValor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 151;
            this.label1.Text = "Valor";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(157, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 23);
            this.button4.TabIndex = 157;
            this.button4.Text = "Novo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(277, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 156;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(220, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 155;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxNome
            // 
            this.TxNome.Location = new System.Drawing.Point(59, 281);
            this.TxNome.Name = "TxNome";
            this.TxNome.Size = new System.Drawing.Size(174, 20);
            this.TxNome.TabIndex = 158;
            this.TxNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxNome_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 159;
            this.label2.Text = "Nome";
            // 
            // TxRG
            // 
            this.TxRG.Location = new System.Drawing.Point(59, 320);
            this.TxRG.Name = "TxRG";
            this.TxRG.Size = new System.Drawing.Size(174, 20);
            this.TxRG.TabIndex = 160;
            this.TxRG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxRG_KeyDown);
            this.TxRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxRG_KeyPress);
            // 
            // TxTelefone
            // 
            this.TxTelefone.Location = new System.Drawing.Point(239, 320);
            this.TxTelefone.Name = "TxTelefone";
            this.TxTelefone.Size = new System.Drawing.Size(118, 20);
            this.TxTelefone.TabIndex = 161;
            this.TxTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTelefone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 162;
            this.label3.Text = "RG";
            // 
            // TxCPF
            // 
            this.TxCPF.Location = new System.Drawing.Point(239, 281);
            this.TxCPF.Name = "TxCPF";
            this.TxCPF.Size = new System.Drawing.Size(118, 20);
            this.TxCPF.TabIndex = 163;
            this.TxCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxCPF_KeyDown);
            this.TxCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxCPF_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(236, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 164;
            this.label4.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(236, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 165;
            this.label6.Text = "Telefone";
            // 
            // CbTipo
            // 
            this.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbTipo.FormattingEnabled = true;
            this.CbTipo.Location = new System.Drawing.Point(57, 83);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(98, 21);
            this.CbTipo.TabIndex = 166;
            this.CbTipo.SelectedIndexChanged += new System.EventHandler(this.CbTipo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(56, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 167;
            this.label7.Text = "Tipo";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(400, 446);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxTelefone);
            this.Controls.Add(this.TxRG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxNome);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxValor);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TxModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxMarca);
            this.Controls.Add(this.TxImei);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprestimo";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TxMarca;
        private System.Windows.Forms.TextBox TxImei;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox TxModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxRG;
        private System.Windows.Forms.TextBox TxTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbTipo;
        private System.Windows.Forms.Label label7;
    }
}