using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class FormCompra : Form
    {
        public FormCompra()
        {
            InitializeComponent();
        }

        private Compra _compra;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private Abertura _abertura;
        private void FormCompra_Load(object sender, EventArgs e)
        {
            try
            {
                TxQuantidade.Text = "1";
                TxValorProduto.Text = "0,00";
                TxTotalPago.Text = "0,00";
                TxFrete.Text = "0,00";
                _compra = null;


                _abertura = Classes.Bioghet_ConsultaMysql.Consultar_Saldododia();
                

                if(_abertura.Saldo == 0)
                {
                    LbSaldo.Text = _abertura.Suprimento.ToString("#####0.00");
                }
                else
                {
                    LbSaldo.Text = _abertura.Saldo.ToString("#####0.00");
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                _compra = null;

                TxPedido.ResetText();
                TxCodigoBarra.ResetText();
                TxProduto.ResetText();
                TxDataCompra.ResetText();
                TxQuantidade.Text = "1";
                TxValorProduto.Text = "0,00";
                TxTotalPago.Text = "0,00";
                TxFrete.Text = "0,00";
                TxTransportadora.ResetText();
                TxDataEntrega.ResetText();
                TxURL.ResetText();
                TxSedex.ResetText();
                TxCnpj.ResetText();
                TxRazaoSocial.ResetText();
                TxTelefone.ResetText();
                TxZap.ResetText();
                TxIe.ResetText();
                TxPaginaFornecedor.ResetText();
                TxContato.ResetText();
                ChClienteVenda.Checked = false;
                TxDataVenda.ResetText();
                ChProdutoDevolvido.Checked = false;
                TxDataDevolucao.ResetText();
                ChNotaFiscal.Checked = false;
                TxNumeroNF.ResetText();
                ChClienteServico.Checked = false;
                TxServico.ResetText();
                ChDefeito.Checked = false;
                TxDefeito.ResetText();
                ChUsoEmpresa.Checked = false;
                ChTestada.Checked = false;
                ChPecaNova.Checked = false;


                _abertura = Classes.Bioghet_ConsultaMysql.Consultar_Saldododia();
                

                Decimal Saldo = Decimal.Subtract(_abertura.Suprimento, _abertura.Sangria) - _abertura.Saldo;

                LbSaldo.Text = Saldo.ToString("#####0.00");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal Total = Decimal.Subtract(Decimal.Parse(LbSaldo.Text), Decimal.Parse(TxTotalPago.Text));

                if (Total > 0)
                {
                    if (_compra == null)
                    {
                        _compra = new Compra();

                        _compra.Pedido = TxPedido.Text;
                        _compra.CodigoBarra = TxCodigoBarra.Text;
                        _compra.DescricaoProduto = TxProduto.Text;
                        _compra.DataCompra = DateTime.Parse(TxDataCompra.Text);
                        _compra.Quantidade = int.Parse(TxQuantidade.Text);
                        _compra.ValorProduto = decimal.Parse(TxValorProduto.Text);
                        _compra.ValorPago = decimal.Parse(TxTotalPago.Text);
                        _compra.ValorFrete = decimal.Parse(TxFrete.Text);
                        _compra.Transportadora = TxTransportadora.Text;
                        _compra.DataEntrega = DateTime.Parse(TxDataEntrega.Text);
                        _compra.Url = TxURL.Text;
                        _compra.Sedex = TxSedex.Text;
                        _compra.Cnpj = TxCnpj.Text;
                        _compra.RazaoSocial = TxRazaoSocial.Text;
                        _compra.IE = TxIe.Text;
                        _compra.Telefone = TxTelefone.Text;
                        _compra.Zap = TxZap.Text;
                        _compra.Pagina = TxPaginaFornecedor.Text;
                        _compra.Contato = TxContato.Text;
                        _compra.ClienteVenda = ChClienteVenda.Checked;
                        _compra.ClienteServico = ChClienteServico.Checked;
                        _compra.ProdutoDevolvido = ChProdutoDevolvido.Checked;
                        _compra.Defeito = ChDefeito.Checked;
                        _compra.UsoEmpresa = ChUsoEmpresa.Checked;
                        _compra.PecaNova = ChPecaNova.Checked;
                        _compra.Testada = ChTestada.Checked;
                        _compra.NotaFiscal = ChNotaFiscal.Checked;
                        _compra.NumeroNotaFiscal = TxNumeroNF.Text;
                        _compra.DataVenda = DateTime.Parse(TxDataVenda.Text);
                        _compra.DataDevolucao = DateTime.Parse(TxDataDevolucao.Text);
                        _compra.Servico = TxServico.Text;
                        _compra.DescricaoDefeito = TxDefeito.Text;
                        _compra.Garantia = DateTime.Parse(TxGarantia.Text);


                        Classes.Bioghet_InserirMYSQL.Criar_Compras(_compra);
                        Classes.Bioghet_UpdateMYSQL.Atualizar_Saldo(Decimal.Parse(LbSaldo.Text));
                        MessageBox.Show("COMPRAS GERADA COM SUCESSO");
                        
                    }
                    else
                    {

                        _compra.Pedido = TxPedido.Text;
                        _compra.CodigoBarra = TxCodigoBarra.Text;
                        _compra.DescricaoProduto = TxProduto.Text;
                        _compra.DataCompra = DateTime.Parse(TxDataCompra.Text);
                        _compra.Quantidade = int.Parse(TxQuantidade.Text);
                        _compra.ValorProduto = decimal.Parse(TxValorProduto.Text);
                        _compra.ValorPago = decimal.Parse(TxTotalPago.Text);
                        _compra.ValorFrete = decimal.Parse(TxFrete.Text);
                        _compra.Transportadora = TxTransportadora.Text;
                        _compra.DataEntrega = DateTime.Parse(TxDataEntrega.Text);
                        _compra.Url = TxURL.Text;
                        _compra.Sedex = TxSedex.Text;
                        _compra.Cnpj = TxCnpj.Text;
                        _compra.RazaoSocial = TxRazaoSocial.Text;
                        _compra.IE = TxIe.Text;
                        _compra.Telefone = TxTelefone.Text;
                        _compra.Zap = TxZap.Text;
                        _compra.Pagina = TxPaginaFornecedor.Text;
                        _compra.Contato = TxContato.Text;
                        _compra.ClienteVenda = ChClienteVenda.Checked;
                        _compra.ClienteServico = ChClienteServico.Checked;
                        _compra.ProdutoDevolvido = ChProdutoDevolvido.Checked;
                        _compra.Defeito = ChDefeito.Checked;
                        _compra.UsoEmpresa = ChUsoEmpresa.Checked;
                        _compra.PecaNova = ChPecaNova.Checked;
                        _compra.Testada = ChTestada.Checked;
                        _compra.NotaFiscal = ChNotaFiscal.Checked;
                        _compra.NumeroNotaFiscal = TxNumeroNF.Text;
                        _compra.DataVenda = DateTime.Parse(TxDataVenda.Text);
                        _compra.DataDevolucao = DateTime.Parse(TxDataDevolucao.Text);
                        _compra.Servico = TxServico.Text;
                        _compra.DescricaoDefeito = TxDefeito.Text;
                        _compra.Garantia = DateTime.Parse(TxGarantia.Text);


                        _compra.ID = Classes.Bioghet_ConsultaMysql.Consultar_IDCompras(TxPedido.Text);

                        Classes.Bioghet_UpdateMYSQL.Atualizar_Compras(_compra);

                        MessageBox.Show("COMPRAS ATUALIZADA COM SUCESSO");
                        
                    }
                }
                else
                {
                    button2.Enabled = false;
                    throw new Exception("SEM LIMITE PARA COMPRAS");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxSedex_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    //br.com.correios.webservice.rastro _rastrea = new br.com.correios.webservice.rastro();
                    //_rastrea.buscaEventos("","","","","","");
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!String.IsNullOrWhiteSpace(TxCnpj.Text))
                    {
                        Boolean _cnpj = ValidarCampos.IsCnpj(TxCnpj.Text);

                        if (_cnpj.Equals(true))
                        {
                            String formato = Classes.Bioghet_Configuracao.Iniciar_Consulta(TxCnpj.Text);

                            int _nome = formato.IndexOf("nome");
                            int _telefone = formato.IndexOf("telefone");
                            //int _Situacao = formato.IndexOf("ativo");

                            TxRazaoSocial.Text = formato.Substring(_nome + 8, 40).Replace("\n", "").Replace("\r", "").Replace("u", "").Replace("'\'", "");
                            TxTelefone.Text = formato.Substring(_telefone + 10, 20).Replace("\\", "").Replace("/ (", "");
                            //TxSituacao.Text = formato.Substring(_Situacao, 3);
                        }
                        else
                        {
                            throw new Exception("CNPJ INVÁLIDO FAVOR VERIFIQUE");
                        }
                    }
                    else
                    {
                        throw new Exception("FAVOR INFORMAR UM CNPJ VÁLIDO");
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxCodigoBarra.Focus();
            }
        }

        private void TxValorProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxTotalPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
        }

        private void TxFrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
        }

        private void TxCodigoBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxProduto.Focus();
            }
        }

        private void TxProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxQuantidade.Focus();
            }
        }

        private void TxQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxValorProduto.Focus();
            }
        }
        private void TxValorProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxFrete.Focus();
            }
        }

        private void TxTotalPago_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Decimal Total = Decimal.Subtract(Decimal.Parse(LbSaldo.Text), Decimal.Parse(TxTotalPago.Text));
                    if (Total > 0)
                    {
                        LbSaldo.Text = Total.ToString("#####0.00");

                        TxTransportadora.Focus();
                    }
                    else
                    {
                        button2.Enabled = false;
                        throw new Exception("SALDO INSUFICIENTE");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxFrete_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Decimal SubTotal = Decimal.Multiply(Decimal.Parse(TxQuantidade.Text), Decimal.Parse(TxValorProduto.Text));
                    Decimal Total = Decimal.Add(SubTotal, Decimal.Parse(TxFrete.Text));

                    TxTotalPago.Text = Total.ToString("#####0.00");

                    TxTotalPago.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxTransportadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxURL.Focus();
            }
        }

        private void TxURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxSedex.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRptCompras compras = new FormRptCompras();
            compras.ShowDialog();
        }
    }
}
