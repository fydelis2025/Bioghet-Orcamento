namespace Bioghet_Orcamento
{
    partial class FormCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompra));
            this.label3 = new System.Windows.Forms.Label();
            this.TxPedido = new System.Windows.Forms.TextBox();
            this.TxProduto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxCodigoBarra = new System.Windows.Forms.TextBox();
            this.TxDataCompra = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxSedex = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxTotalPago = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxFrete = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.TxValorProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxTransportadora = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxQuantidade = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxContato = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxPaginaFornecedor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxZap = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxTelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxIe = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxCnpj = new System.Windows.Forms.TextBox();
            this.TxRazaoSocial = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ChClienteVenda = new System.Windows.Forms.CheckBox();
            this.ChClienteServico = new System.Windows.Forms.CheckBox();
            this.ChUsoEmpresa = new System.Windows.Forms.CheckBox();
            this.TxDataVenda = new System.Windows.Forms.DateTimePicker();
            this.TxServico = new System.Windows.Forms.TextBox();
            this.TxGarantia = new System.Windows.Forms.DateTimePicker();
            this.ChProdutoDevolvido = new System.Windows.Forms.CheckBox();
            this.TxDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.ChDefeito = new System.Windows.Forms.CheckBox();
            this.TxDefeito = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxNumeroNF = new System.Windows.Forms.TextBox();
            this.ChNotaFiscal = new System.Windows.Forms.CheckBox();
            this.ChTestada = new System.Windows.Forms.CheckBox();
            this.ChPecaNova = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.LbSaldo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 185;
            this.label3.Text = "Nº Pedido";
            // 
            // TxPedido
            // 
            this.TxPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxPedido.Location = new System.Drawing.Point(9, 33);
            this.TxPedido.Name = "TxPedido";
            this.TxPedido.Size = new System.Drawing.Size(100, 20);
            this.TxPedido.TabIndex = 0;
            this.TxPedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxPedido_KeyDown);
            // 
            // TxProduto
            // 
            this.TxProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxProduto.Location = new System.Drawing.Point(233, 33);
            this.TxProduto.Name = "TxProduto";
            this.TxProduto.Size = new System.Drawing.Size(366, 20);
            this.TxProduto.TabIndex = 2;
            this.TxProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxProduto_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxCodigoBarra);
            this.groupBox1.Controls.Add(this.TxDataCompra);
            this.groupBox1.Controls.Add(this.TxProduto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxPedido);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 73);
            this.groupBox1.TabIndex = 188;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do pedido";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(112, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 13);
            this.label22.TabIndex = 233;
            this.label22.Text = "Codigo Barra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(601, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 192;
            this.label4.Text = "Data Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 190;
            this.label1.Text = "Descrição do produto";
            // 
            // TxCodigoBarra
            // 
            this.TxCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxCodigoBarra.Location = new System.Drawing.Point(115, 33);
            this.TxCodigoBarra.Name = "TxCodigoBarra";
            this.TxCodigoBarra.Size = new System.Drawing.Size(112, 20);
            this.TxCodigoBarra.TabIndex = 1;
            this.TxCodigoBarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxCodigoBarra_KeyDown);
            // 
            // TxDataCompra
            // 
            this.TxDataCompra.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxDataCompra.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TxDataCompra.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TxDataCompra.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxDataCompra.Location = new System.Drawing.Point(605, 33);
            this.TxDataCompra.Name = "TxDataCompra";
            this.TxDataCompra.Size = new System.Drawing.Size(105, 20);
            this.TxDataCompra.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.TxSedex);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxURL);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxTotalPago);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TxFrete);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxDataEntrega);
            this.groupBox2.Controls.Add(this.TxValorProduto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxTransportadora);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxQuantidade);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 119);
            this.groupBox2.TabIndex = 189;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do pedido";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(560, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 205;
            this.label13.Text = "Cod. Sedex";
            // 
            // TxSedex
            // 
            this.TxSedex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxSedex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxSedex.Location = new System.Drawing.Point(563, 75);
            this.TxSedex.Name = "TxSedex";
            this.TxSedex.Size = new System.Drawing.Size(146, 20);
            this.TxSedex.TabIndex = 11;
            this.TxSedex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxSedex_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 201;
            this.label11.Text = "Url";
            // 
            // TxURL
            // 
            this.TxURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxURL.Location = new System.Drawing.Point(10, 75);
            this.TxURL.Name = "TxURL";
            this.TxURL.Size = new System.Drawing.Size(547, 20);
            this.TxURL.TabIndex = 10;
            this.TxURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxURL_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(203, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 199;
            this.label5.Text = "Total Pago";
            // 
            // TxTotalPago
            // 
            this.TxTotalPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxTotalPago.Location = new System.Drawing.Point(203, 33);
            this.TxTotalPago.Name = "TxTotalPago";
            this.TxTotalPago.Size = new System.Drawing.Size(77, 20);
            this.TxTotalPago.TabIndex = 6;
            this.TxTotalPago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxTotalPago_KeyDown);
            this.TxTotalPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTotalPago_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(140, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 197;
            this.label10.Text = "Valor frete";
            // 
            // TxFrete
            // 
            this.TxFrete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxFrete.Location = new System.Drawing.Point(139, 33);
            this.TxFrete.Name = "TxFrete";
            this.TxFrete.Size = new System.Drawing.Size(58, 20);
            this.TxFrete.TabIndex = 7;
            this.TxFrete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxFrete_KeyDown);
            this.TxFrete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxFrete_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(604, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 195;
            this.label9.Text = "Data Entrega";
            // 
            // TxDataEntrega
            // 
            this.TxDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxDataEntrega.Location = new System.Drawing.Point(604, 33);
            this.TxDataEntrega.Name = "TxDataEntrega";
            this.TxDataEntrega.Size = new System.Drawing.Size(105, 20);
            this.TxDataEntrega.TabIndex = 9;
            // 
            // TxValorProduto
            // 
            this.TxValorProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxValorProduto.Location = new System.Drawing.Point(56, 33);
            this.TxValorProduto.Name = "TxValorProduto";
            this.TxValorProduto.Size = new System.Drawing.Size(77, 20);
            this.TxValorProduto.TabIndex = 5;
            this.TxValorProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxValorProduto_KeyDown);
            this.TxValorProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxValorProduto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(292, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 191;
            this.label6.Text = "Tramsportadora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(56, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 190;
            this.label7.Text = "Valor produto";
            // 
            // TxTransportadora
            // 
            this.TxTransportadora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxTransportadora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxTransportadora.Location = new System.Drawing.Point(286, 33);
            this.TxTransportadora.Name = "TxTransportadora";
            this.TxTransportadora.Size = new System.Drawing.Size(312, 20);
            this.TxTransportadora.TabIndex = 8;
            this.TxTransportadora.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxTransportadora_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 185;
            this.label8.Text = "Quant";
            // 
            // TxQuantidade
            // 
            this.TxQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxQuantidade.Location = new System.Drawing.Point(10, 33);
            this.TxQuantidade.Name = "TxQuantidade";
            this.TxQuantidade.Size = new System.Drawing.Size(40, 20);
            this.TxQuantidade.TabIndex = 4;
            this.TxQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxQuantidade_KeyDown);
            this.TxQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxQuantidade_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.TxContato);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.TxPaginaFornecedor);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.TxZap);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.TxTelefone);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TxIe);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.TxCnpj);
            this.groupBox3.Controls.Add(this.TxRazaoSocial);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(11, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(716, 119);
            this.groupBox3.TabIndex = 206;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações sobre o fornecedor";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(489, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 209;
            this.label18.Text = "Contato";
            // 
            // TxContato
            // 
            this.TxContato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxContato.Location = new System.Drawing.Point(492, 73);
            this.TxContato.Name = "TxContato";
            this.TxContato.Size = new System.Drawing.Size(218, 20);
            this.TxContato.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(230, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 207;
            this.label17.Text = "Pagina";
            // 
            // TxPaginaFornecedor
            // 
            this.TxPaginaFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxPaginaFornecedor.Location = new System.Drawing.Point(233, 73);
            this.TxPaginaFornecedor.Name = "TxPaginaFornecedor";
            this.TxPaginaFornecedor.Size = new System.Drawing.Size(253, 20);
            this.TxPaginaFornecedor.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(118, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 205;
            this.label15.Text = "Zap";
            // 
            // TxZap
            // 
            this.TxZap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxZap.Location = new System.Drawing.Point(121, 73);
            this.TxZap.Name = "TxZap";
            this.TxZap.Size = new System.Drawing.Size(106, 20);
            this.TxZap.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 203;
            this.label14.Text = "Telefone";
            // 
            // TxTelefone
            // 
            this.TxTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxTelefone.Location = new System.Drawing.Point(9, 73);
            this.TxTelefone.Name = "TxTelefone";
            this.TxTelefone.Size = new System.Drawing.Size(106, 20);
            this.TxTelefone.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(604, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 201;
            this.label2.Text = "I.E";
            // 
            // TxIe
            // 
            this.TxIe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxIe.Location = new System.Drawing.Point(603, 33);
            this.TxIe.Name = "TxIe";
            this.TxIe.Size = new System.Drawing.Size(106, 20);
            this.TxIe.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 199;
            this.label16.Text = "Cnpj";
            // 
            // TxCnpj
            // 
            this.TxCnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxCnpj.Location = new System.Drawing.Point(9, 33);
            this.TxCnpj.Name = "TxCnpj";
            this.TxCnpj.Size = new System.Drawing.Size(106, 20);
            this.TxCnpj.TabIndex = 12;
            this.TxCnpj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxCnpj_KeyDown);
            // 
            // TxRazaoSocial
            // 
            this.TxRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxRazaoSocial.Location = new System.Drawing.Point(121, 33);
            this.TxRazaoSocial.Name = "TxRazaoSocial";
            this.TxRazaoSocial.Size = new System.Drawing.Size(478, 20);
            this.TxRazaoSocial.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(118, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 190;
            this.label20.Text = "Razão Social";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label19.Location = new System.Drawing.Point(11, 345);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(502, 33);
            this.label19.TabIndex = 207;
            this.label19.Text = "Destino do Produto";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChClienteVenda
            // 
            this.ChClienteVenda.AutoSize = true;
            this.ChClienteVenda.BackColor = System.Drawing.Color.Transparent;
            this.ChClienteVenda.ForeColor = System.Drawing.Color.White;
            this.ChClienteVenda.Location = new System.Drawing.Point(15, 391);
            this.ChClienteVenda.Name = "ChClienteVenda";
            this.ChClienteVenda.Size = new System.Drawing.Size(92, 17);
            this.ChClienteVenda.TabIndex = 208;
            this.ChClienteVenda.Text = "Cliente Venda";
            this.ChClienteVenda.UseVisualStyleBackColor = false;
            // 
            // ChClienteServico
            // 
            this.ChClienteServico.AutoSize = true;
            this.ChClienteServico.BackColor = System.Drawing.Color.Transparent;
            this.ChClienteServico.ForeColor = System.Drawing.Color.White;
            this.ChClienteServico.Location = new System.Drawing.Point(244, 391);
            this.ChClienteServico.Name = "ChClienteServico";
            this.ChClienteServico.Size = new System.Drawing.Size(97, 17);
            this.ChClienteServico.TabIndex = 209;
            this.ChClienteServico.Text = "Cliente Serviço";
            this.ChClienteServico.UseVisualStyleBackColor = false;
            // 
            // ChUsoEmpresa
            // 
            this.ChUsoEmpresa.AutoSize = true;
            this.ChUsoEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.ChUsoEmpresa.ForeColor = System.Drawing.Color.White;
            this.ChUsoEmpresa.Location = new System.Drawing.Point(464, 388);
            this.ChUsoEmpresa.Name = "ChUsoEmpresa";
            this.ChUsoEmpresa.Size = new System.Drawing.Size(104, 17);
            this.ChUsoEmpresa.TabIndex = 210;
            this.ChUsoEmpresa.Text = "Uso da Empersa";
            this.ChUsoEmpresa.UseVisualStyleBackColor = false;
            // 
            // TxDataVenda
            // 
            this.TxDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxDataVenda.Location = new System.Drawing.Point(133, 388);
            this.TxDataVenda.Name = "TxDataVenda";
            this.TxDataVenda.Size = new System.Drawing.Size(105, 20);
            this.TxDataVenda.TabIndex = 19;
            // 
            // TxServico
            // 
            this.TxServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxServico.Location = new System.Drawing.Point(347, 388);
            this.TxServico.Name = "TxServico";
            this.TxServico.Size = new System.Drawing.Size(106, 20);
            this.TxServico.TabIndex = 22;
            // 
            // TxGarantia
            // 
            this.TxGarantia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxGarantia.Location = new System.Drawing.Point(263, 468);
            this.TxGarantia.Name = "TxGarantia";
            this.TxGarantia.Size = new System.Drawing.Size(105, 20);
            this.TxGarantia.TabIndex = 24;
            // 
            // ChProdutoDevolvido
            // 
            this.ChProdutoDevolvido.AutoSize = true;
            this.ChProdutoDevolvido.BackColor = System.Drawing.Color.Transparent;
            this.ChProdutoDevolvido.ForeColor = System.Drawing.Color.White;
            this.ChProdutoDevolvido.Location = new System.Drawing.Point(15, 423);
            this.ChProdutoDevolvido.Name = "ChProdutoDevolvido";
            this.ChProdutoDevolvido.Size = new System.Drawing.Size(115, 17);
            this.ChProdutoDevolvido.TabIndex = 216;
            this.ChProdutoDevolvido.Text = "Produto devolvido ";
            this.ChProdutoDevolvido.UseVisualStyleBackColor = false;
            // 
            // TxDataDevolucao
            // 
            this.TxDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxDataDevolucao.Location = new System.Drawing.Point(133, 420);
            this.TxDataDevolucao.Name = "TxDataDevolucao";
            this.TxDataDevolucao.Size = new System.Drawing.Size(105, 20);
            this.TxDataDevolucao.TabIndex = 20;
            // 
            // ChDefeito
            // 
            this.ChDefeito.AutoSize = true;
            this.ChDefeito.BackColor = System.Drawing.Color.Transparent;
            this.ChDefeito.ForeColor = System.Drawing.Color.White;
            this.ChDefeito.Location = new System.Drawing.Point(244, 420);
            this.ChDefeito.Name = "ChDefeito";
            this.ChDefeito.Size = new System.Drawing.Size(60, 17);
            this.ChDefeito.TabIndex = 218;
            this.ChDefeito.Text = "Defeito";
            this.ChDefeito.UseVisualStyleBackColor = false;
            // 
            // TxDefeito
            // 
            this.TxDefeito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxDefeito.Location = new System.Drawing.Point(347, 421);
            this.TxDefeito.Name = "TxDefeito";
            this.TxDefeito.Size = new System.Drawing.Size(373, 20);
            this.TxDefeito.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Bioghet_Orcamento.Properties.Resources._8;
            this.button4.Location = new System.Drawing.Point(471, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 83);
            this.button4.TabIndex = 229;
            this.button4.Text = "Novo";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Bioghet_Orcamento.Properties.Resources._7;
            this.button2.Location = new System.Drawing.Point(556, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 83);
            this.button2.TabIndex = 227;
            this.button2.Text = "Salvar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxNumeroNF
            // 
            this.TxNumeroNF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxNumeroNF.Location = new System.Drawing.Point(133, 468);
            this.TxNumeroNF.Name = "TxNumeroNF";
            this.TxNumeroNF.Size = new System.Drawing.Size(124, 20);
            this.TxNumeroNF.TabIndex = 21;
            // 
            // ChNotaFiscal
            // 
            this.ChNotaFiscal.AutoSize = true;
            this.ChNotaFiscal.BackColor = System.Drawing.Color.Transparent;
            this.ChNotaFiscal.ForeColor = System.Drawing.Color.White;
            this.ChNotaFiscal.Location = new System.Drawing.Point(15, 465);
            this.ChNotaFiscal.Name = "ChNotaFiscal";
            this.ChNotaFiscal.Size = new System.Drawing.Size(79, 17);
            this.ChNotaFiscal.TabIndex = 225;
            this.ChNotaFiscal.Text = "Nota Fiscal";
            this.ChNotaFiscal.UseVisualStyleBackColor = false;
            // 
            // ChTestada
            // 
            this.ChTestada.AutoSize = true;
            this.ChTestada.BackColor = System.Drawing.Color.Transparent;
            this.ChTestada.ForeColor = System.Drawing.Color.White;
            this.ChTestada.Location = new System.Drawing.Point(655, 388);
            this.ChTestada.Name = "ChTestada";
            this.ChTestada.Size = new System.Drawing.Size(65, 17);
            this.ChTestada.TabIndex = 224;
            this.ChTestada.Text = "Testada";
            this.ChTestada.UseVisualStyleBackColor = false;
            // 
            // ChPecaNova
            // 
            this.ChPecaNova.AutoSize = true;
            this.ChPecaNova.BackColor = System.Drawing.Color.Transparent;
            this.ChPecaNova.ForeColor = System.Drawing.Color.White;
            this.ChPecaNova.Location = new System.Drawing.Point(574, 388);
            this.ChPecaNova.Name = "ChPecaNova";
            this.ChPecaNova.Size = new System.Drawing.Size(80, 17);
            this.ChPecaNova.TabIndex = 223;
            this.ChPecaNova.Text = "Peça Nova";
            this.ChPecaNova.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(139, 451);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 13);
            this.label21.TabIndex = 230;
            this.label21.Text = "Nº";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(260, 452);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 231;
            this.label12.Text = "Garantia";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Bioghet_Orcamento.Properties.Resources._10;
            this.button3.Location = new System.Drawing.Point(641, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 83);
            this.button3.TabIndex = 232;
            this.button3.Text = "Listar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(519, 360);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 13);
            this.label23.TabIndex = 233;
            this.label23.Text = "Saldo do dia";
            // 
            // LbSaldo
            // 
            this.LbSaldo.AutoSize = true;
            this.LbSaldo.BackColor = System.Drawing.Color.Transparent;
            this.LbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LbSaldo.Location = new System.Drawing.Point(623, 351);
            this.LbSaldo.Name = "LbSaldo";
            this.LbSaldo.Size = new System.Drawing.Size(58, 25);
            this.LbSaldo.TabIndex = 234;
            this.LbSaldo.Text = "0,00";
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(739, 536);
            this.Controls.Add(this.LbSaldo);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxNumeroNF);
            this.Controls.Add(this.ChNotaFiscal);
            this.Controls.Add(this.ChTestada);
            this.Controls.Add(this.ChPecaNova);
            this.Controls.Add(this.TxDefeito);
            this.Controls.Add(this.ChDefeito);
            this.Controls.Add(this.TxDataDevolucao);
            this.Controls.Add(this.ChProdutoDevolvido);
            this.Controls.Add(this.TxGarantia);
            this.Controls.Add(this.TxServico);
            this.Controls.Add(this.TxDataVenda);
            this.Controls.Add(this.ChUsoEmpresa);
            this.Controls.Add(this.ChClienteServico);
            this.Controls.Add(this.ChClienteVenda);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxPedido;
        private System.Windows.Forms.TextBox TxProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker TxDataCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxValorProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxTransportadora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxQuantidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker TxDataEntrega;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxFrete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxTotalPago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxURL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxSedex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxCnpj;
        private System.Windows.Forms.TextBox TxRazaoSocial;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxIe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxTelefone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxZap;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxPaginaFornecedor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxContato;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox ChClienteVenda;
        private System.Windows.Forms.CheckBox ChClienteServico;
        private System.Windows.Forms.CheckBox ChUsoEmpresa;
        private System.Windows.Forms.DateTimePicker TxDataVenda;
        private System.Windows.Forms.TextBox TxServico;
        private System.Windows.Forms.DateTimePicker TxGarantia;
        private System.Windows.Forms.CheckBox ChProdutoDevolvido;
        private System.Windows.Forms.DateTimePicker TxDataDevolucao;
        private System.Windows.Forms.CheckBox ChDefeito;
        private System.Windows.Forms.TextBox TxDefeito;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxNumeroNF;
        private System.Windows.Forms.CheckBox ChNotaFiscal;
        private System.Windows.Forms.CheckBox ChTestada;
        private System.Windows.Forms.CheckBox ChPecaNova;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxCodigoBarra;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label LbSaldo;
    }
}