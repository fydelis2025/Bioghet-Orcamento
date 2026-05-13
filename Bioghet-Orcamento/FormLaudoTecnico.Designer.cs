namespace Bioghet_Orcamento
{
    partial class FormLaudoTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaudoTecnico));
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxModelo = new System.Windows.Forms.ComboBox();
            this.TxDefeito = new System.Windows.Forms.ComboBox();
            this.TxMarca = new System.Windows.Forms.ComboBox();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.TxImei = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxCpf = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LbCaractereDefeito = new System.Windows.Forms.Label();
            this.TxDescricao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LbCaractereLaudo = new System.Windows.Forms.Label();
            this.TxLaudo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.TxFuncionario = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(10, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(596, 33);
            this.label6.TabIndex = 177;
            this.label6.Text = "LAUDO TÉCNICO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(615, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 176;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxModelo
            // 
            this.TxModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TxModelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxModelo.FormattingEnabled = true;
            this.TxModelo.Location = new System.Drawing.Point(272, 149);
            this.TxModelo.Name = "TxModelo";
            this.TxModelo.Size = new System.Drawing.Size(250, 21);
            this.TxModelo.TabIndex = 2;
            this.TxModelo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxModelo_KeyDown);
            this.TxModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxModelo_KeyPress);
            this.TxModelo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxModelo_KeyUp);
            // 
            // TxDefeito
            // 
            this.TxDefeito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxDefeito.FormattingEnabled = true;
            this.TxDefeito.Location = new System.Drawing.Point(528, 149);
            this.TxDefeito.Name = "TxDefeito";
            this.TxDefeito.Size = new System.Drawing.Size(162, 21);
            this.TxDefeito.TabIndex = 3;
            this.TxDefeito.SelectedIndexChanged += new System.EventHandler(this.TxDefeito_SelectedIndexChanged);
            this.TxDefeito.Click += new System.EventHandler(this.TxDefeito_Click);
            this.TxDefeito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxDefeito_KeyDown);
            // 
            // TxMarca
            // 
            this.TxMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxMarca.FormattingEnabled = true;
            this.TxMarca.Location = new System.Drawing.Point(149, 149);
            this.TxMarca.Name = "TxMarca";
            this.TxMarca.Size = new System.Drawing.Size(117, 21);
            this.TxMarca.TabIndex = 1;
            this.TxMarca.SelectedIndexChanged += new System.EventHandler(this.TxMarca_SelectedIndexChanged);
            this.TxMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxMarca_KeyDown);
            // 
            // CbTipo
            // 
            this.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbTipo.FormattingEnabled = true;
            this.CbTipo.Location = new System.Drawing.Point(16, 149);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(127, 21);
            this.CbTipo.TabIndex = 0;
            this.CbTipo.SelectedIndexChanged += new System.EventHandler(this.CbTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 183;
            this.label1.Text = "Tipo";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(525, 132);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(41, 13);
            this.label34.TabIndex = 182;
            this.label34.Text = "Defeito";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(275, 132);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(42, 13);
            this.label33.TabIndex = 181;
            this.label33.Text = "Modelo";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(146, 132);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 13);
            this.label32.TabIndex = 180;
            this.label32.Text = "Marca";
            // 
            // TxImei
            // 
            this.TxImei.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxImei.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxImei.Location = new System.Drawing.Point(16, 201);
            this.TxImei.MaxLength = 20;
            this.TxImei.Name = "TxImei";
            this.TxImei.Size = new System.Drawing.Size(127, 20);
            this.TxImei.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(13, 185);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 187;
            this.label17.Text = "Imei / Serial";
            // 
            // TxCliente
            // 
            this.TxCliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxCliente.Location = new System.Drawing.Point(149, 201);
            this.TxCliente.MaxLength = 80;
            this.TxCliente.Name = "TxCliente";
            this.TxCliente.Size = new System.Drawing.Size(317, 20);
            this.TxCliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 188;
            this.label2.Text = "Nome do cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(469, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 190;
            this.label3.Text = "CPF do cliente";
            // 
            // TxCpf
            // 
            this.TxCpf.Location = new System.Drawing.Point(472, 201);
            this.TxCpf.MaxLength = 14;
            this.TxCpf.Name = "TxCpf";
            this.TxCpf.Size = new System.Drawing.Size(105, 20);
            this.TxCpf.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LbCaractereDefeito);
            this.groupBox1.Controls.Add(this.TxDescricao);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 214);
            this.groupBox1.TabIndex = 192;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Defeito Reclamaedo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(212, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 182;
            this.label4.Text = "Total digito";
            // 
            // LbCaractereDefeito
            // 
            this.LbCaractereDefeito.AutoSize = true;
            this.LbCaractereDefeito.BackColor = System.Drawing.Color.Transparent;
            this.LbCaractereDefeito.ForeColor = System.Drawing.Color.White;
            this.LbCaractereDefeito.Location = new System.Drawing.Point(284, 16);
            this.LbCaractereDefeito.Name = "LbCaractereDefeito";
            this.LbCaractereDefeito.Size = new System.Drawing.Size(25, 13);
            this.LbCaractereDefeito.TabIndex = 181;
            this.LbCaractereDefeito.Text = "200";
            // 
            // TxDescricao
            // 
            this.TxDescricao.Location = new System.Drawing.Point(6, 33);
            this.TxDescricao.MaxLength = 200;
            this.TxDescricao.Multiline = true;
            this.TxDescricao.Name = "TxDescricao";
            this.TxDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxDescricao.Size = new System.Drawing.Size(315, 175);
            this.TxDescricao.TabIndex = 7;
            this.TxDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxDescricao_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.LbCaractereLaudo);
            this.groupBox2.Controls.Add(this.TxLaudo);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(349, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 214);
            this.groupBox2.TabIndex = 193;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Laudo Técnico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(231, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 183;
            this.label5.Text = "Total digito";
            // 
            // LbCaractereLaudo
            // 
            this.LbCaractereLaudo.AutoSize = true;
            this.LbCaractereLaudo.BackColor = System.Drawing.Color.Transparent;
            this.LbCaractereLaudo.ForeColor = System.Drawing.Color.White;
            this.LbCaractereLaudo.Location = new System.Drawing.Point(307, 16);
            this.LbCaractereLaudo.Name = "LbCaractereLaudo";
            this.LbCaractereLaudo.Size = new System.Drawing.Size(25, 13);
            this.LbCaractereLaudo.TabIndex = 182;
            this.LbCaractereLaudo.Text = "200";
            // 
            // TxLaudo
            // 
            this.TxLaudo.Location = new System.Drawing.Point(6, 33);
            this.TxLaudo.MaxLength = 200;
            this.TxLaudo.Multiline = true;
            this.TxLaudo.Name = "TxLaudo";
            this.TxLaudo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxLaudo.Size = new System.Drawing.Size(326, 175);
            this.TxLaudo.TabIndex = 8;
            this.TxLaudo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxLaudo_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(615, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 194;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(615, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 195;
            this.button3.Text = "Novo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(580, 185);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(46, 13);
            this.label40.TabIndex = 197;
            this.label40.Text = "Técnico";
            // 
            // TxFuncionario
            // 
            this.TxFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxFuncionario.FormattingEnabled = true;
            this.TxFuncionario.Location = new System.Drawing.Point(583, 200);
            this.TxFuncionario.MaxDropDownItems = 10;
            this.TxFuncionario.Name = "TxFuncionario";
            this.TxFuncionario.Size = new System.Drawing.Size(107, 21);
            this.TxFuncionario.TabIndex = 196;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(615, 457);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 198;
            this.button4.Text = "Imprimir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormLaudoTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(707, 515);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.TxFuncionario);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxCpf);
            this.Controls.Add(this.TxCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxImei);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TxModelo);
            this.Controls.Add(this.TxDefeito);
            this.Controls.Add(this.TxMarca);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLaudoTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laudo Tecnico";
            this.Load += new System.EventHandler(this.FormLaudoTecnico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TxModelo;
        private System.Windows.Forms.ComboBox TxDefeito;
        private System.Windows.Forms.ComboBox TxMarca;
        private System.Windows.Forms.ComboBox CbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox TxImei;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxCpf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxDescricao;
        private System.Windows.Forms.TextBox TxLaudo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox TxFuncionario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label LbCaractereDefeito;
        private System.Windows.Forms.Label LbCaractereLaudo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}