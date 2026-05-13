namespace Bioghet_Orcamento
{
    partial class FormMercadoPago
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("ITENS");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("CORREIOS");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("HOME", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("PRODUTOS");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("VENDAS");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMercadoPago));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LbPerfil = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbTelefone = new System.Windows.Forms.Label();
            this.LbNome = new System.Windows.Forms.Label();
            this.TViwer = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Controle = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.PMercadoPago = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.BtRastrear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Controle.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PMercadoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbPerfil);
            this.groupBox1.Controls.Add(this.LbEmail);
            this.groupBox1.Controls.Add(this.LbTelefone);
            this.groupBox1.Controls.Add(this.LbNome);
            this.groupBox1.Controls.Add(this.PMercadoPago);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da conta";
            // 
            // LbPerfil
            // 
            this.LbPerfil.Location = new System.Drawing.Point(12, 207);
            this.LbPerfil.Name = "LbPerfil";
            this.LbPerfil.Size = new System.Drawing.Size(221, 23);
            this.LbPerfil.TabIndex = 4;
            this.LbPerfil.Text = "PERFIL";
            this.LbPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbEmail
            // 
            this.LbEmail.Location = new System.Drawing.Point(9, 184);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(224, 23);
            this.LbEmail.TabIndex = 3;
            this.LbEmail.Text = "EMAIL";
            this.LbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbTelefone
            // 
            this.LbTelefone.Location = new System.Drawing.Point(6, 161);
            this.LbTelefone.Name = "LbTelefone";
            this.LbTelefone.Size = new System.Drawing.Size(227, 23);
            this.LbTelefone.TabIndex = 2;
            this.LbTelefone.Text = "FONE";
            this.LbTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbNome
            // 
            this.LbNome.Location = new System.Drawing.Point(6, 140);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(227, 23);
            this.LbNome.TabIndex = 1;
            this.LbNome.Text = "NIKENAME";
            this.LbNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TViwer
            // 
            this.TViwer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TViwer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TViwer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TViwer.ImageIndex = 0;
            this.TViwer.ImageList = this.imageList1;
            this.TViwer.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TViwer.Location = new System.Drawing.Point(12, 276);
            this.TViwer.Name = "TViwer";
            treeNode6.Name = "ITENS";
            treeNode6.Text = "ITENS";
            treeNode7.Name = "CORREIOS";
            treeNode7.Text = "CORREIOS";
            treeNode8.Name = "HOME";
            treeNode8.Text = "HOME";
            treeNode9.Name = "PRODUTOS";
            treeNode9.Text = "PRODUTOS";
            treeNode10.Name = "VENDAS";
            treeNode10.Text = "VENDAS";
            this.TViwer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            this.TViwer.SelectedImageIndex = 0;
            this.TViwer.Size = new System.Drawing.Size(239, 292);
            this.TViwer.TabIndex = 2;
            this.TViwer.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TViwer_BeforeSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "store_icon-icons.com_54371.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Controle);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(257, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 460);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // Controle
            // 
            this.Controle.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Controle.Controls.Add(this.tabPage1);
            this.Controle.Controls.Add(this.tabPage2);
            this.Controle.Controls.Add(this.tabPage3);
            this.Controle.Controls.Add(this.tabPage4);
            this.Controle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controle.ImageList = this.imageList1;
            this.Controle.Location = new System.Drawing.Point(3, 16);
            this.Controle.Name = "Controle";
            this.Controle.SelectedIndex = 0;
            this.Controle.Size = new System.Drawing.Size(555, 441);
            this.Controle.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(547, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.CbCategoria);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(547, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Produtos";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(547, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vendas";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.BtRastrear);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(547, 411);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rastreio";
            // 
            // PMercadoPago
            // 
            this.PMercadoPago.Location = new System.Drawing.Point(53, 23);
            this.PMercadoPago.Name = "PMercadoPago";
            this.PMercadoPago.Size = new System.Drawing.Size(117, 112);
            this.PMercadoPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PMercadoPago.TabIndex = 0;
            this.PMercadoPago.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = global::Bioghet_Orcamento.Properties.Resources.Printer_icon48x48_fw;
            this.button5.Location = new System.Drawing.Point(16, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 72);
            this.button5.TabIndex = 268;
            this.button5.Text = "Etiqueta";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // BtRastrear
            // 
            this.BtRastrear.BackColor = System.Drawing.Color.White;
            this.BtRastrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRastrear.ForeColor = System.Drawing.Color.Black;
            this.BtRastrear.Image = global::Bioghet_Orcamento.Properties.Resources.mail_22591;
            this.BtRastrear.Location = new System.Drawing.Point(87, 13);
            this.BtRastrear.Name = "BtRastrear";
            this.BtRastrear.Size = new System.Drawing.Size(65, 72);
            this.BtRastrear.TabIndex = 269;
            this.BtRastrear.Text = "Rastrear";
            this.BtRastrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtRastrear.UseVisualStyleBackColor = false;
            this.BtRastrear.Click += new System.EventHandler(this.BtRastrear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bioghet_Orcamento.Properties.Resources.correios_logo_1_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(409, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 270;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bioghet_Orcamento.Properties.Resources.como_vender_no_mercado_livre_758x421;
            this.pictureBox3.Location = new System.Drawing.Point(257, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(561, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // CbCategoria
            // 
            this.CbCategoria.FormattingEnabled = true;
            this.CbCategoria.Location = new System.Drawing.Point(9, 28);
            this.CbCategoria.Name = "CbCategoria";
            this.CbCategoria.Size = new System.Drawing.Size(230, 21);
            this.CbCategoria.TabIndex = 1;
            this.CbCategoria.Click += new System.EventHandler(this.CbCategoria_Click);
            // 
            // FormMercadoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(830, 580);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TViwer);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMercadoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integração com o mercado pago";
            this.Load += new System.EventHandler(this.FormMercadoPago_Load);
            this.Shown += new System.EventHandler(this.FormMercadoPago_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.Controle.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PMercadoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PMercadoPago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbTelefone;
        private System.Windows.Forms.Label LbPerfil;
        private System.Windows.Forms.TreeView TViwer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl Controle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button BtRastrear;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbCategoria;
    }
}