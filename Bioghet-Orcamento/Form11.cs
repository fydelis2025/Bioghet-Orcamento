using Bioghet_Orcamento.Classes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Bioghet_Orcamento
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        public bioghet_produto _produto;
        public  Bioghet_Orcamento.Classes.Bioghet_Fornecedor _fornecedor;
        public  Bioghet_Orcamento.Classes.Bioghet_Armazenamento _armazenamento;
        public  Bioghet_Orcamento.Classes.Bioghet_Estoque _estoque;
        private int retorno;
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            try
            {
                //if (_produto != null)
                //{
                //    _produto = new bioghet_produto();

                //    _produto.CodigoInterno = TxCodigo.Text;
                //    _produto.CodigoBarra = TxBarra.Text;
                //    _produto.Serial = TxSerie.Text;
                //    _produto.PrecoCusto = Decimal.Parse(TxPrecoCusto.Text);
                //    _produto.PVarejo = Decimal.Parse(TxPorcVarejo.Text);
                //    _produto.PrecoVarejo = Decimal.Parse(TxVendaVarejo.Text);
                //    _produto.PAtacado = Decimal.Parse(TxPorcAtacado.Text);
                //    _produto.PrecoAtacado = Decimal.Parse(TxPrecoAtacado.Text);
                //    _produto.Desconto = Decimal.Parse(TxDesconto.Text);
                //    _produto.DataCompra = DateTime.Parse(DtCompra.Text);
                //    _produto.Garantia = Int32.Parse(TxGarantia.Text);
                //    _produto.FimGarantia = DateTime.Parse(DtGarantia.Text);
                //    _produto.Aparelho = ChOpcao.GetItemChecked(0);
                //    _produto.Peca = ChOpcao.GetItemChecked(1);
                //    _produto.Novo = ChOpcao.GetItemChecked(2);
                //    _produto.Usado = ChOpcao.GetItemChecked(3);
                //    _produto.NTestada = ChOpcao.GetItemChecked(4);
                //    _produto.Defeito = ChOpcao.GetItemChecked(5);
                //    _produto.RetAparelho = ChOpcao.GetItemChecked(6);
                //    _produto.Testado = ChOpcao.GetItemChecked(7);
                //    _produto.Descricao = TxDescricao.Text;
                //    _produto.TipoPeca = int.Parse(CbTipoPecas.Text.Remove(2));
                //    _produto.Quantidade = int.Parse(TxQuantidade.Text);
                //    _produto.Lote = TxLote.Text;
                //    _produto.Filial = int.Parse(CbFilial.Text.Remove(2).Replace(" ", ""));
                //    ChOpcao.Items.Clear();
                //    List<Bioghet_Orcamento.Classes.Bioghet_Opcao> Lista = Classes.Bioghet_ConsultaMysql.Listar_Opcao();
                //    for (int i = 0; i < Lista.Count; i++)
                //    {
                //        ChOpcao.Items.Add(Lista[i].Descricao);
                //    }
                //}
                //else
                //{
                //    _produto = null;
                //}

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtEstoqueGeral_Click(object sender, EventArgs e)
        {
            FrmEstoque _estoque = new FrmEstoque();
            _estoque.Show();
        }

        private void BtIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                _produto = null;
                _fornecedor = null;
                _armazenamento = null;
                _estoque = null;

                ChOpcao.SetItemChecked(1, true);
                ChOpcao.SetItemChecked(2, true);
                ChOpcao.SetItemChecked(7, true);

                TxDescricao.ResetText();
                TxCodigo.ResetText();
                TxBarra.ResetText();
                TxSerie.ResetText();
                CbTipoPecas.ResetText();
                TxFornecedor.ResetText();
                TxCNPJ.ResetText();
                TxTelefone.ResetText();
                TxContato.ResetText();
                TxGarantia.Text = "0";
                TxDolaCompra.Text = "0";
                TxDolaVarejo.Text = "0";
                TxDolaAtacado.Text = "0";
                TxDesconto.Text = "5";
                TxPorcVarejo.Text = "40";
                TxPorcAtacado.Text = "25";

                DateTime Data = DtCompra.Value.AddDays(double.Parse(TxGarantia.Text));

                DtGarantia.Text = Data.ToString();

                //-----------------------------------

                //TxPrateleira.Text = "0";
                //TxCompartimento.Text = "0";
                //TxGaveta.Text = "0";
                //TxCaixa.Text = "0";
                TxEstGeral.Text = "0";
                //TxLado.Text = "0";
                //TxPrateleira_.Text = "0";
                //TxCaixa_.Text = "0";
                //TxGancho.Text = "0";
                TxQtde.Text = "0";

                //------------------------------------

                TxPrateleira.Text = "P-";
                TxCompartimento.Text = "C-";
                TxGaveta.Text = "G-";
                TxCaixa.Text = "CX-";
                TxEstGeral.Text = "0";
                TxLado.Text = "L-";
                TxPrateleira_.Text = "P-";
                TxCaixa_.Text = "CX-";
                TxGancho.Text = "GA-";
                TxQtde.Text = "0";
                TxQuantidade.Text = "0";

                TxDescricao.Focus();


                this.CarregaValores();

                _cambio = Decimal.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "cambiododia", ""));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxGarantia_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DateTime Data = DtCompra.Value.AddDays(double.Parse(TxGarantia.Text));

                    DtGarantia.Text = Data.ToString();

                    DtGarantia.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtGerarCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                Random codigo = new Random();
                //String Valor = "ABCDEFGHIJKLMNOPQRSTUVYWXZ0123456789";
                //String Chave = String.Empty;

                //for (int i = 0; i < 3; i++)
                //{
                //    Chave += Valor.Substring(codigo.Next(36), 1) + Valor.Substring(codigo.Next(36), 1);
                //}

                TxCodigo.Text = codigo.Next(999999).ToString();
                TxBarra.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxPorcVarejo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxVendaVarejo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxPorcAtacado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxPrecoAtacado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(TxCodigo.Text))
                {
                    throw new Exception("CAMPO CODIGO INTERNO É OBRIGATÓRIO");
                }
                else if (String.IsNullOrWhiteSpace(CbFilial.Text))
                {
                    throw new Exception("FILIAL É OBRIGATÓRIO");
                }
                else
                {
                    if (_produto == null)
                    {

                        if (!String.IsNullOrEmpty(TxBarra.Text))
                        {
                            _produto = Classes.Bioghet_ConsultaMysql.Consultar_ProdutoLojaCodigoBarra(TxBarra.Text, int.Parse(CbFilial.Text.Remove(2)));

                            if (_produto != null)
                            {
                                _produto = null;
                                throw new Exception("CODIGO DE BARRA JA CADASTRADO, FAVOR VERIFIQUE");
                            }
                        }

                        if (!String.IsNullOrEmpty(TxCodigo.Text))
                        {
                            _produto = Classes.Bioghet_ConsultaMysql.Consultar_ProdutoLojaCodigo(TxCodigo.Text, Int32.Parse(CbFilial.Text.Remove(2)));

                            if (_produto != null)
                            {
                                _produto = null;
                                throw new Exception("CODIGO DE BARRA JA CADASTRADO, FAVOR VERIFIQUE");
                            }
                        }

                        int retornocadprod = Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)), int.Parse(CbFilial.Text.Remove(2)));

                        if (retornocadprod.Equals(0))
                        {
                            DialogResult Aviso = MessageBox.Show("DESEJA APLICAR EM TODAS AS FILIAIS", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (Aviso == DialogResult.Yes)
                            {
                                List<Bioghet_Empresa> _listafilial = Bioghet_ConsultaMysql.Listar_Empresa();

                                for(int i = 0; i <_listafilial.Count; i++)
                                {
                                    _produto = new bioghet_produto();

                                    _produto.CodigoInterno = TxCodigo.Text;
                                    _produto.CodigoBarra = TxBarra.Text;
                                    _produto.Serial = TxSerie.Text;
                                    _produto.PrecoCusto = Decimal.Parse(TxPrecoCusto.Text);
                                    _produto.PVarejo = Decimal.Parse(TxPorcVarejo.Text);
                                    _produto.PrecoVarejo = Decimal.Parse(TxVendaVarejo.Text);
                                    _produto.PAtacado = Decimal.Parse(TxPorcAtacado.Text);
                                    _produto.PrecoAtacado = Decimal.Parse(TxPrecoAtacado.Text);
                                    _produto.Desconto = Decimal.Parse(TxDesconto.Text);
                                    _produto.DataCompra = DateTime.Parse(DtCompra.Text);
                                    _produto.Garantia = Int32.Parse(TxGarantia.Text);
                                    _produto.FimGarantia = DateTime.Parse(DtGarantia.Text);
                                    _produto.Aparelho = ChOpcao.GetItemChecked(0);
                                    _produto.Peca = ChOpcao.GetItemChecked(1);
                                    _produto.Novo = ChOpcao.GetItemChecked(2);
                                    _produto.Usado = ChOpcao.GetItemChecked(3);
                                    _produto.NTestada = ChOpcao.GetItemChecked(4);
                                    _produto.Defeito = ChOpcao.GetItemChecked(5);
                                    _produto.RetAparelho = ChOpcao.GetItemChecked(6);
                                    _produto.Testado = ChOpcao.GetItemChecked(7);
                                    _produto.Descricao = TxDescricao.Text;
                                    _produto.TipoPeca = int.Parse(CbTipoPecas.Text.Remove(2));
                                    _produto.Quantidade = int.Parse(TxQuantidade.Text);
                                    _produto.Lote = TxLote.Text;
                                    if (_listafilial[i].Equals(0))
                                    {
                                        _produto.Filial = int.Parse(CbFilial.Text.Remove(2));
                                    }
                                    else
                                    {
                                        _produto.Filial = _listafilial[i].ID;
                                    }
                                    _produto.DolaVarejo = Decimal.Parse(TxDolaVarejo.Text);
                                    _produto.DolaAtacado = Decimal.Parse(TxDolaAtacado.Text);
                                    _produto.DolaCompra = Decimal.Parse(TxDolaCompra.Text);
                                    _produto.Usuario = Classes.Bioghet_Configuracao.Usuario;
                                    _produto.DataCriacao = DateTime.Now;
                                    
                                   Bioghet_Orcamento.Classes.Bioghet_InserirMYSQL.Criar_Produto(_produto);

                                    _fornecedor = new Bioghet_Fornecedor();

                                    _fornecedor = new Classes.Bioghet_Fornecedor();
                                    _fornecedor.CodigoProduto = TxCodigo.Text;
                                    _fornecedor.CNPJCPF = TxCNPJ.Text;
                                    _fornecedor.RazaoSocial = TxFornecedor.Text;
                                    _fornecedor.Telefone = TxTelefone.Text;
                                    _fornecedor.Contato = TxContato.Text;
                                    _fornecedor.IDProduto = Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)), _listafilial[i].ID); ;
                                    _fornecedor.Filail = _listafilial[i].ID;

                                    int retorno = Bioghet_Orcamento.Classes.Bioghet_InserirMYSQL.Criar_Fornecedor(_fornecedor);

                                    if (retorno.Equals(0))
                                    {
                                        // MessageBox.Show("Fornecedor criado com sucesso", "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        //MessageBox.Show("Error no cadastro do produto, favor verifique", "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    
                                }

                                MessageBox.Show("Produto criado com sucesso", "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                _produto = new bioghet_produto();

                                _produto.CodigoInterno = TxCodigo.Text;
                                _produto.CodigoBarra = TxBarra.Text;
                                _produto.Serial = TxSerie.Text;
                                _produto.PrecoCusto = Decimal.Parse(TxPrecoCusto.Text);
                                _produto.PVarejo = Decimal.Parse(TxPorcVarejo.Text);
                                _produto.PrecoVarejo = Decimal.Parse(TxVendaVarejo.Text);
                                _produto.PAtacado = Decimal.Parse(TxPorcAtacado.Text);
                                _produto.PrecoAtacado = Decimal.Parse(TxPrecoAtacado.Text);
                                _produto.Desconto = Decimal.Parse(TxDesconto.Text);
                                _produto.DataCompra = DateTime.Parse(DtCompra.Text);
                                _produto.Garantia = Int32.Parse(TxGarantia.Text);
                                _produto.FimGarantia = DateTime.Parse(DtGarantia.Text);
                                _produto.Aparelho = ChOpcao.GetItemChecked(0);
                                _produto.Peca = ChOpcao.GetItemChecked(1);
                                _produto.Novo = ChOpcao.GetItemChecked(2);
                                _produto.Usado = ChOpcao.GetItemChecked(3);
                                _produto.NTestada = ChOpcao.GetItemChecked(4);
                                _produto.Defeito = ChOpcao.GetItemChecked(5);
                                _produto.RetAparelho = ChOpcao.GetItemChecked(6);
                                _produto.Testado = ChOpcao.GetItemChecked(7);
                                _produto.Descricao = TxDescricao.Text;
                                _produto.TipoPeca = int.Parse(CbTipoPecas.Text.Remove(2));
                                _produto.Quantidade = int.Parse(TxQuantidade.Text);
                                _produto.Lote = TxLote.Text;
                                _produto.Filial = int.Parse(CbFilial.Text.Remove(2));
                                _produto.DolaVarejo = Decimal.Parse(TxDolaVarejo.Text);
                                _produto.DolaAtacado = Decimal.Parse(TxDolaAtacado.Text);
                                _produto.DolaCompra = Decimal.Parse(TxDolaCompra.Text);
                                _produto.Usuario = Classes.Bioghet_Configuracao.Usuario;
                                _produto.DataCriacao = DateTime.Now;

                                int retorno = Bioghet_Orcamento.Classes.Bioghet_InserirMYSQL.Criar_Produto(_produto);

                                if (retorno.Equals(1))
                                {
                                    MessageBox.Show("Produto criado com sucesso", "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error no cadastro do produto, favor verifique", "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                          
                        }
                        else
                        {
                            throw new Exception("PRODUTO JA CADASTRADO");
                        }
                    }
                    else
                    {
                        int retornocadprod = Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)), int.Parse(CbFilial.Text.Remove(2)));

                        _produto.CodigoInterno = TxCodigo.Text;
                        _produto.CodigoBarra = TxBarra.Text;
                        _produto.Serial = TxSerie.Text;
                        _produto.PrecoCusto = Decimal.Parse(TxPrecoCusto.Text);
                        _produto.PVarejo = Decimal.Parse(TxPorcVarejo.Text);
                        _produto.PrecoVarejo = Decimal.Parse(TxVendaVarejo.Text);
                        _produto.PAtacado = Decimal.Parse(TxPorcAtacado.Text);
                        _produto.PrecoAtacado = Decimal.Parse(TxPrecoAtacado.Text);
                        _produto.Desconto = Decimal.Parse(TxDesconto.Text);
                        _produto.DataCompra = DateTime.Parse(DtCompra.Text);
                        _produto.Garantia = Int32.Parse(TxGarantia.Text);
                        _produto.FimGarantia = DateTime.Parse(DtGarantia.Text);
                        _produto.Aparelho = ChOpcao.GetItemChecked(0);
                        _produto.Peca = ChOpcao.GetItemChecked(1);
                        _produto.Novo = ChOpcao.GetItemChecked(2);
                        _produto.Usado = ChOpcao.GetItemChecked(3);
                        _produto.NTestada = ChOpcao.GetItemChecked(4);
                        _produto.Defeito = ChOpcao.GetItemChecked(5);
                        _produto.RetAparelho = ChOpcao.GetItemChecked(6);
                        _produto.Testado = ChOpcao.GetItemChecked(7);
                        _produto.Descricao = TxDescricao.Text;
                        _produto.TipoPeca = int.Parse(CbTipoPecas.Text.Remove(2));
                        _produto.Quantidade = int.Parse(TxQuantidade.Text);
                        _produto.Lote = TxLote.Text;
                        _produto.Filial = int.Parse(CbFilial.Text.Remove(2));
                        _produto.ID = retornocadprod;
                        _produto.DolaVarejo = Decimal.Parse(TxDolaVarejo.Text);
                        _produto.DolaAtacado = Decimal.Parse(TxDolaAtacado.Text);
                        _produto.DolaCompra = Decimal.Parse(TxDolaCompra.Text);

                        int retorno = Bioghet_Orcamento.Classes.Bioghet_UpdateMYSQL.Update_Produto(_produto);

                        MessageBox.Show("Produto atualizado com sucesso", "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //if (retorno.Equals(1))
                        //{
                        //    MessageBox.Show("Produto atualizado com sucesso", "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Error na atualização do produto, favor verifique", "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                    }

                    _fornecedor = Bioghet_Orcamento.Classes.Bioghet_ConsultaMysql.Consultar_FornecedorProduto(TxCodigo.Text, Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)), int.Parse(CbFilial.Text.Remove(2))));

                    if (_fornecedor == null)
                    {
                        _fornecedor = new Classes.Bioghet_Fornecedor();
                        _fornecedor.CodigoProduto = TxCodigo.Text;
                        _fornecedor.CNPJCPF = TxCNPJ.Text;
                        _fornecedor.RazaoSocial = TxFornecedor.Text;
                        _fornecedor.Telefone = TxTelefone.Text;
                        _fornecedor.Contato = TxContato.Text;
                        _fornecedor.IDProduto = Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, _produto.TipoPeca, int.Parse(CbFilial.Text.Remove(2)));
                        

                        int retorno = Bioghet_Orcamento.Classes.Bioghet_InserirMYSQL.Criar_Fornecedor(_fornecedor);

                        if (retorno.Equals(0))
                        {
                           // MessageBox.Show("Fornecedor criado com sucesso", "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //MessageBox.Show("Error no cadastro do produto, favor verifique", "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        _fornecedor.CodigoProduto = TxCodigo.Text;
                        _fornecedor.CNPJCPF = TxCNPJ.Text;
                        _fornecedor.RazaoSocial = TxFornecedor.Text;
                        _fornecedor.Telefone = TxTelefone.Text;
                        _fornecedor.Contato = TxContato.Text;
                        _fornecedor.IDProduto = Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)), int.Parse(CbFilial.Text.Remove(2)));

                        int retorno = Bioghet_Orcamento.Classes.Bioghet_UpdateMYSQL.Update_Fornecedor(_fornecedor);

                        if (retorno.Equals(0))
                        {
                            ///MessageBox.Show("Fornecedor atualizado com sucesso", "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //MessageBox.Show("Error na atualização do fornecedor, favor verifique", "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void BtEstoqueGeral_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DgArmazenamento.Rows.Clear();
               
        //        List<Classes.Bioghet_TotalEstoque> Listar = Classes.Bioghet_ConsultaMysql.Consultar_EstoqueProdutoLojas(Classes.Bioghet_Configuracao.CodigoProduto);
        //        String[] ParamEstoque = new String[10];
        //        for (int i = 0; i < Listar.Count; i++)
        //        {
        //            ParamEstoque[0] = Listar[i].RazaoSocial;
        //            ParamEstoque[1] = Listar[i].Original.ToString();
        //            ParamEstoque[2] = Listar[i].PrimeiraLinha.ToString();
        //            ParamEstoque[3] = Listar[i].SegundaLinha.ToString();
        //            ParamEstoque[4] = Listar[i].Generico.ToString();
        //            ParamEstoque[5] = "0";
        //            ParamEstoque[6] = Listar[i].Total.ToString();
        //            ParamEstoque[7] = "0";
        //            ParamEstoque[8] = "0";
        //            ParamEstoque[9] = "0";

        //            DgArmazenamento.Rows.Add(ParamEstoque);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void TxEstGeral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxPrateleira_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxCompartimento.Focus();
            }
        }

        private void TxCompartimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxGaveta.Focus();
            }
        }

        private void TxGaveta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxCaixa.Focus();
            }
        }

        private void TxCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxEstGeral.Focus();
            }
        }

        private void TxEstGeral_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxLado.Focus();
            }
        }

        private void TxLado_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int limitelado = Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "ladoloja", "limitelado", ""));

                    int quantidadelado = int.Parse(TxLado.Text.Replace("L-", ""));

                    if (quantidadelado >= limitelado)

                        throw new Exception("LIMITE EXCEDIDO");

                    TxPrateleira_.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxPrateleira__KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int limiteprateleira = Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "ladoloja", "limiteprateleira", ""));
                    int quantidadeprateleira = int.Parse(TxPrateleira_.Text.Replace("P-", ""));

                    if (quantidadeprateleira > limiteprateleira)
                        throw new Exception("LIMITE EXCEDIDO");

                    TxCaixa_.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCaixa__KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                try
                {

                    if (e.KeyCode == Keys.Enter)
                    {
                        int limitecaixa = Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "ladoloja", "ladocaixa", ""));
                        int quantidadecaixa = int.Parse(TxCaixa_.Text.Replace("CX-", ""));

                        if (quantidadecaixa > limitecaixa)
                            throw new Exception("LIMITE EXCEDIDO");

                        TxGancho.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxGancho_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int limiteqtdegancho = Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "ladoloja", "limiteqtdegancho", ""));
                    int quantidadeqtdegancho = int.Parse(TxGancho.Text.Replace("GA-", ""));

                    if (quantidadeqtdegancho > limiteqtdegancho)
                        throw new Exception("LIMITE EXCEDIDO");

                    TxQtde.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxQtde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxQuantidade.Focus();
            }
        }

        private void TxQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxOriginal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxPrimeiraLinha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxSegundaLinha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxGenerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void BtSalvarEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                int limitelado = Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "ladoloja", "limitelado", ""));

                //String _QtdeLado = TxLado.Text.Replace("L-", "");

                //int Quantidadelado = int.Parse(TxLado.Text.Replace("L-",""));

                //if (Convert.ToInt32(_QtdeLado) >= limitelado)
                  //  throw new Exception("LADO EXCEDIDO");

                int limiteprateleira = Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "ladoloja", "limiteprateleira", ""));

                //int quantidadeprateleira = int.Parse(TxPrateleira_.Text.Replace("P-",""));

                //if (quantidadeprateleira >= limiteprateleira)
                //    throw new Exception("LADO PRATELEIRA EXCEDIDO");

                int limitecaixa = Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "ladoloja", "ladocaixa", ""));
                //int quantidadecaixa = int.Parse(TxCaixa_.Text.Replace("CX-", ""));

                //if (quantidadecaixa >= limitecaixa)
                //    throw new Exception("LADO CAIXA EXCEDIDO");

                int limiteqtdegancho = Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "ladoloja", "limiteqtdegancho", ""));
                //int quantidadeqtdegancho = int.Parse(TxGancho.Text.Replace("GA-",""));

                //if (quantidadeqtdegancho >= limiteqtdegancho)
                //    throw new Exception("LADO GANCHO EXCEDIDO");

                if (String.IsNullOrWhiteSpace(TxCodigo.Text))
                {
                    throw new Exception("CAMPO CODIGO INTERNO É OBRIGATÓRIO");
                }
                else
                {
                    _armazenamento =  Classes.Bioghet_ConsultaMysql.Consultar_ArmazenamentoProduto(TxCodigo.Text, Classes.Bioghet_ConsultaMysql.Consultar_ID_Produto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)), int.Parse(CbFilial.Text.Remove(2))));

                    if (_armazenamento == null)
                    {
                        _armazenamento = new Classes.Bioghet_Armazenamento();
                        _armazenamento.ID = Classes.Bioghet_ConsultaMysql.Consultar_ID_Produto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)), int.Parse(CbFilial.Text.Remove(2)));
                        _armazenamento.CodigoProduto = TxCodigo.Text;
                        _armazenamento.Filial = int.Parse(CbFilial.Text.Remove(2).Replace(" ", ""));
                        _armazenamento.Prateleira = TxPrateleira.Text;
                        _armazenamento.Gaveta = TxGaveta.Text;
                        _armazenamento.Caixa = TxCaixa.Text;
                        _armazenamento.Compartimento = TxCompartimento.Text;
                        _armazenamento.EstoqueGeral = Int32.Parse(TxEstGeral.Text);
                        _armazenamento.Lado = TxLado.Text;
                        _armazenamento.LadoPrateleira = TxPrateleira_.Text;
                        _armazenamento.LadoGancho = TxGancho.Text;
                        _armazenamento.LadoCaixa = TxCaixa_.Text;
                        _armazenamento.Qtde = Int32.Parse(TxQtde.Text);
                        _armazenamento.TipoPeca = Int32.Parse(CbTipoPecas.Text.Remove(2));
                        _armazenamento.QtdePeca = Int32.Parse(TxQuantidade.Text);

                        

                        int totalpermitido = Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "limitegancho", ""));

                        Int32 maximoqtdetotalloja = Classes.Bioghet_ConsultaMysql.Consultar_LadoLojaTotal(TxLado.Text, TxPrateleira_.Text, TxGancho.Text, TxCaixa_.Text, Int32.Parse(CbFilial.Text.Remove(2)));

                        if (maximoqtdetotalloja >= totalpermitido)
                            throw new Exception("LIMITE EXCEDIDO");

                        Int32 TotalDigitado = Int32.Parse(TxQtde.Text);

                        if (TotalDigitado >= totalpermitido)
                        {

                            throw new Exception("LIMITE MÁXIMO PERMITIDO JA ESTÁ SENDO UTILIZADO NA LOJA " + CbFilial.Text);
                        }
                        else
                        {

                            //Int32 _retornopeca = Classes.Bioghet_ConsultaMysql.Consultar_QTDEPeca(TxCodigo.Text, int.Parse(CbFilial.Text.Remove(2)));

                            //if (_retornopeca.Equals(0))
                            //{
                            retorno = Bioghet_Orcamento.Classes.Bioghet_InserirMYSQL.Criar_Armazenamento(_armazenamento);

                            if (retorno.Equals(1))
                            {
                                MessageBox.Show("Armazenamento criado com sucesso", "Informações do Armazenamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                _armazenamento = null;
                            }
                            else
                            {
                                MessageBox.Show("Error no armazenamento do produto, favor verifique", "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        //}
                    }
                    else
                    {
                        _armazenamento.ID = int.Parse(LbCodigoProduto.Text);
                        _armazenamento.CodigoProduto = TxCodigo.Text;
                        _armazenamento.Filial = int.Parse(CbFilial.Text.Remove(2).Replace(" ", "")); ;
                        _armazenamento.Prateleira = TxPrateleira.Text;
                        _armazenamento.Gaveta = TxGaveta.Text;
                        _armazenamento.Caixa = TxCaixa.Text;
                        _armazenamento.Compartimento = TxCompartimento.Text;
                        _armazenamento.EstoqueGeral = Int32.Parse(TxEstGeral.Text);
                        _armazenamento.Lado = TxLado.Text;
                        _armazenamento.LadoPrateleira = TxPrateleira_.Text;
                        _armazenamento.LadoGancho = TxGancho.Text;
                        _armazenamento.LadoCaixa = TxCaixa_.Text;
                        _armazenamento.Qtde = Int32.Parse(TxQtde.Text);
                        _armazenamento.TipoPeca = Int32.Parse(CbTipoPecas.Text.Remove(2));
                        _armazenamento.QtdePeca = Int32.Parse(TxQuantidade.Text);

                        int totalpermitido = Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "limitegancho", ""));

                        Int32 maximoqtdetotalloja = Classes.Bioghet_ConsultaMysql.Consultar_LadoLojaTotal(TxLado.Text, TxPrateleira_.Text, TxGancho.Text, TxCaixa_.Text, Int32.Parse(CbFilial.Text.Remove(2)));

                        if (maximoqtdetotalloja >= totalpermitido)
                            throw new Exception("LIMITE EXCEDIDO");

                        Int32 TotalDigitado = Int32.Parse(TxQtde.Text);

                        if (TotalDigitado >= totalpermitido)
                        {

                            throw new Exception("LIMITE MÁXIMO PERMITIDO JA ESTÁ SENDO UTILIZADO NA LOJA " + CbFilial.Text);
                        }
                        else
                        {
                            retorno = Bioghet_Orcamento.Classes.Bioghet_UpdateMYSQL.Update_Armazenamento(_armazenamento);

                            if (retorno.Equals(1))
                            {
                                MessageBox.Show("Armazenamento atualizado com sucesso", "Informações do Armazenamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                _armazenamento = null;
                            }
                            else
                            {
                                // MessageBox.Show("Error ao atualizar o  armazenamento do produto, favor verifique", "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void TxDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxCodigo.Focus();
            }
        }

        private void TxCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxBarra.Focus();
            }
        }

        private void TxBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _produto = Classes.Bioghet_ConsultaMysql.Consultar_ProdutoLojaCodigoBarra(TxBarra.Text, int.Parse(CbFilial.Text.Remove(2)));

                if(_produto != null)
                {
                    throw new Exception("CODIGO DE BARRA JA CADASTRADO, FAVOR VERIFIQUE");
                }

                TxSerie.Focus();
            }
        }

        private void TxSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxLote.Focus();
            }
        }


        private void TxPrecoCusto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Decimal Custo = Decimal.Parse(TxPrecoCusto.Text);
                Decimal Soma = Decimal.Divide(Custo, _cambio);

                TxDolaCompra.Text = Soma.ToString("#####0.00");

                TxPorcVarejo.Focus();
            }
        }

        
        
        private void TxPorcVarejo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Decimal Custo = Decimal.Parse(TxPrecoCusto.Text);
                    Decimal MargemVarejo = Decimal.Parse(TxPorcVarejo.Text);

                    Decimal Soma = Decimal.Multiply(Custo, MargemVarejo) / 100;
                    Decimal ValorVarejo = Decimal.Add(Soma, Custo);
                    Decimal SomaDola = Decimal.Divide(ValorVarejo, _cambio);
                    TxDolaVarejo.Text = SomaDola.ToString("#####0.00");

                    TxVendaVarejo.Text = ValorVarejo.ToString("#####0.00");

                    

                    TxPorcAtacado.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxVendaVarejo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxPorcAtacado.Focus();
            }
        }

        private void TxPorcAtacado_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Decimal Custo = Decimal.Parse(TxPrecoCusto.Text);
                    Decimal MargemAtacado = Decimal.Parse(TxPorcAtacado.Text);

                    Decimal Soma = Decimal.Multiply(Custo, MargemAtacado) / 100;
                    Decimal SomaAtacado = Decimal.Add(Soma, Custo);

                    TxPrecoAtacado.Text = SomaAtacado.ToString("#####0.00");

                    TxDolaAtacado.Text = Decimal.Divide(SomaAtacado, _cambio).ToString("#####0.00");

                    TxDesconto.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxPrecoAtacado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxDesconto.Focus();
            }
        }

        private void TxOriginal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxPrecoCusto.Focus();
            }
        }

        private void TxDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxFornecedor.Focus();
            }
        }

        private void TxFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxCNPJ.Focus();
            }
        }

        private void TxCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxTelefone.Focus();
            }
        }

        private void TxTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxContato.Focus();
            }
        }

        private void TxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void BtLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                TxEstTotalPituba.Text = "0";
                TxTotalTJ.Text = "0";
                TxTotalBrio.Text = "0";
                TxTotalSP.Text = "0";
                TxTotalVT.Text = "0";
                TxTotalVT1.Text = "0";

                //--------------------PITUBA------------------------------//
                //_estoque = Classes.Bioghet_ConsultaMysql.Consultar_Estoque_Loja(TxCodigo.Text, Classes.Bioghet_ConsultaMysql.Consultar_CodigoFilial(LbLoja1.Text));
                _estoque = Classes.Bioghet_ConsultaMysql.Consultar_Estoque_Loja(TxCodigo.Text, int.Parse(LbLoja1.Text.Remove(2)));

                if (_estoque != null)
                {
                    TxPratPituba.Text = _estoque.Prateleira;
                    TxCompPituba.Text = _estoque.Compartimento;
                    TxGavetaPituba.Text = _estoque.Gaveta;
                    TxCaixaPituba.Text = _estoque.Caixa;
                    TxESTPituba.Text = _estoque.EstoqueGeral.ToString();

                    TxOrigPituba.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(1, TxCodigo.Text, int.Parse(LbLoja1.Text.Remove(2))).ToString();

                    Tx1Pituba.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(2, TxCodigo.Text, int.Parse(LbLoja1.Text.Remove(2))).ToString();

                    Tx2Pituba.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(3, TxCodigo.Text, int.Parse(LbLoja1.Text.Remove(2))).ToString();

                    TxGePituba.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(4, TxCodigo.Text, int.Parse(LbLoja1.Text.Remove(2))).ToString();

                    TxFrentQtde1.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeFrenteLoja(TxCodigo.Text, int.Parse(LbLoja1.Text.Remove(2))).ToString();

                    TxEstTotalPituba.Text = Convert.ToString(int.Parse(TxOrigPituba.Text) + int.Parse(Tx1Pituba.Text) + int.Parse(Tx2Pituba.Text) + int.Parse(TxGePituba.Text));

                    TxTotalSaida1.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoqueSaida(Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)),4), 4).ToString();
                }
                //----------------------------------------------------------//

                ////--------------------TELECENTRO------------------------------//
                //_estoque = Classes.Bioghet_ConsultaMysql.Consultar_Estoque_Loja(TxCodigo.Text, Classes.Bioghet_ConsultaMysql.Consultar_CodigoFilial(LbLoja2.Text));
                _estoque = Classes.Bioghet_ConsultaMysql.Consultar_Estoque_Loja(TxCodigo.Text, int.Parse(LbLoja2.Text.Remove(2)));

                if (_estoque != null)
                {
                    TxPratTJ.Text = _estoque.Prateleira;
                    TxCompTJ.Text = _estoque.Compartimento;
                    TxGavetaTJ.Text = _estoque.Gaveta;
                    TxCaixaTJ.Text = _estoque.Caixa;
                    TxEstTJ.Text = _estoque.EstoqueGeral.ToString();

                    TxOrigTJ.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(1, TxCodigo.Text, Classes.Bioghet_ConsultaMysql.Consultar_CodigoFilial(LbLoja2.Text)).ToString();

                    Tx1TJ.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(2, TxCodigo.Text, Classes.Bioghet_ConsultaMysql.Consultar_CodigoFilial(LbLoja2.Text)).ToString();

                    Tx2TJ.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(3, TxCodigo.Text, Classes.Bioghet_ConsultaMysql.Consultar_CodigoFilial(LbLoja2.Text)).ToString();

                    TxGeTJ.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(4, TxCodigo.Text, Classes.Bioghet_ConsultaMysql.Consultar_CodigoFilial(LbLoja2.Text)).ToString();

                    TxFrentQtde2.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeFrenteLoja(TxCodigo.Text, Classes.Bioghet_ConsultaMysql.Consultar_CodigoFilial(LbLoja2.Text)).ToString();

                    TxTotalTJ.Text = Convert.ToString(int.Parse(TxOrigTJ.Text) + int.Parse(Tx1TJ.Text) + int.Parse(Tx2TJ.Text) + int.Parse(TxGeTJ.Text));

                    TxTotalSaida2.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoqueSaida(Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)),5), 5).ToString();
                }
                ////--------------------------------------------------------------//


                //--------------------BOCA DO RIO------------------------------//
                //_estoque = Classes.Bioghet_ConsultaMysql.Consultar_Estoque_Loja(TxCodigo.Text, Classes.Bioghet_ConsultaMysql.Consultar_CodigoFilial(LbLoja3.Text));
                _estoque = Classes.Bioghet_ConsultaMysql.Consultar_Estoque_Loja(TxCodigo.Text, int.Parse(LbLoja3.Text.Remove(2)));

                if (_estoque != null)
                {
                    TxPratBrio.Text = _estoque.Prateleira;
                    TxCompBrio.Text = _estoque.Compartimento;
                    TxGavetaBrio.Text = _estoque.Gaveta;
                    TxCaixaBrio.Text = _estoque.Caixa;
                    TxEstBrio.Text = _estoque.EstoqueGeral.ToString();

                    TxOrigBrio.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(1, TxCodigo.Text, int.Parse(LbLoja3.Text.Remove(2))).ToString();

                    Tx1Brio.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(2, TxCodigo.Text, int.Parse(LbLoja3.Text.Remove(2))).ToString();

                    Tx2Brio.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(3, TxCodigo.Text, int.Parse(LbLoja3.Text.Remove(2))).ToString();

                    TxGeBrio.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(4, TxCodigo.Text, int.Parse(LbLoja3.Text.Remove(2))).ToString();

                    TxFrentQtde3.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeFrenteLoja(TxCodigo.Text, int.Parse(LbLoja3.Text.Remove(2))).ToString();

                    TxTotalBrio.Text = Convert.ToString(int.Parse(TxOrigBrio.Text) + int.Parse(Tx1Brio.Text)+int.Parse(Tx2Brio.Text) + int.Parse(TxGeBrio.Text));

                    TxTotalSaida3.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoqueSaida(Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)),11), 11).ToString();
                }
                //----------------------------------------------------------//

                ////-------------------SPTECH SP-----------------------------//
                //_estoque = Classes.Bioghet_ConsultaMysql.Consultar_Estoque_Loja(TxCodigo.Text, Classes.Bioghet_ConsultaMysql.Consultar_CodigoFilial(LbLoja4.Text));
                _estoque = Classes.Bioghet_ConsultaMysql.Consultar_Estoque_Loja(TxCodigo.Text, int.Parse(LbLoja4.Text.Remove(2)));
                if (_estoque != null)
                {
                    TxPratSP.Text = _estoque.Prateleira;
                    TxCompSP.Text = _estoque.Compartimento;
                    TxGavetaSP.Text = _estoque.Gaveta;
                    TxCaixaSP.Text = _estoque.Caixa;
                    TxEstSP.Text = _estoque.EstoqueGeral.ToString();

                    TxOrigSP.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(1, TxCodigo.Text, int.Parse(LbLoja4.Text.Remove(2))).ToString();

                    Tx1SP.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(2, TxCodigo.Text, int.Parse(LbLoja4.Text.Remove(2))).ToString();

                    Tx2SP.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(3, TxCodigo.Text, int.Parse(LbLoja4.Text.Remove(2))).ToString();

                    TxGeSP.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(4, TxCodigo.Text, int.Parse(LbLoja4.Text.Remove(2))).ToString();

                    TxFrentQtde4.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeFrenteLoja(TxCodigo.Text, int.Parse(LbLoja4.Text.Remove(2))).ToString();

                    TxTotalSP.Text = Convert.ToString(int.Parse(TxOrigSP.Text) + int.Parse(Tx1SP.Text) + int.Parse(Tx2SP.Text) + int.Parse(TxGeSP.Text));

                    TxTotalSaida4.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoqueSaida(Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)),12), 12).ToString();
                }
                ////----------------------------------------------------------//

                ////-------------------VIRUTAL1------------------------------//
                //_estoque = Classes.Bioghet_ConsultaMysql.Consultar_Estoque_Loja(TxCodigo.Text, Classes.Bioghet_ConsultaMysql.Consultar_CodigoFilial(LbLoja5.Text));
                _estoque = Classes.Bioghet_ConsultaMysql.Consultar_Estoque_Loja(TxCodigo.Text, int.Parse(LbLoja5.Text.Remove(2)));
                if (_estoque != null)
                {
                    TxPratVT.Text = _estoque.Prateleira;
                    TxCompVT.Text = _estoque.Compartimento;
                    TxGavetaVT.Text = _estoque.Gaveta;
                    TxCaixaVT.Text = _estoque.Caixa;
                    TxEstVT.Text = _estoque.EstoqueGeral.ToString();

                    TxOrigVT.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(1, TxCodigo.Text, int.Parse(LbLoja5.Text.Remove(2))).ToString();

                    Tx1VT.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(2, TxCodigo.Text, int.Parse(LbLoja5.Text.Remove(2))).ToString();

                    Tx2VT.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(3, TxCodigo.Text, int.Parse(LbLoja5.Text.Remove(2))).ToString();

                    TxGeVT.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(4, TxCodigo.Text, int.Parse(LbLoja5.Text.Remove(2))).ToString();

                    TxFrentQtde5.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeFrenteLoja(TxCodigo.Text, int.Parse(LbLoja5.Text.Remove(2))).ToString();

                    TxTotalVT.Text = Convert.ToString(int.Parse(TxOrigVT.Text) + int.Parse(Tx1VT.Text) + int.Parse(Tx2VT.Text) + int.Parse(TxGeVT.Text));

                    TxTotalSaida5.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoqueSaida(Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)),8), 8).ToString();
                }
                ////----------------------------------------------------------//

                ////-------------------VIRUTAL2------------------------------//
                _estoque = Classes.Bioghet_ConsultaMysql.Consultar_Estoque_Loja(TxCodigo.Text, int.Parse(LbLoja6.Text.Remove(2)));
                //_estoque = Classes.Bioghet_ConsultaMysql.Consultar_Estoque_Loja(TxCodigo.Text, Classes.Bioghet_ConsultaMysql.Consultar_CodigoFilial(LbLoja6.Text));
                if (_estoque != null)
                {
                    TxPratVT1.Text = _estoque.Prateleira;
                    TxCompVT1.Text = _estoque.Compartimento;
                    TxGavetaVT1.Text = _estoque.Gaveta;
                    TxCaixaVT1.Text = _estoque.Caixa;
                    TxEstVT1.Text = _estoque.EstoqueGeral.ToString();

                    TxOrigVT1.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(1, TxCodigo.Text, int.Parse(LbLoja6.Text.Remove(2))).ToString();

                    Tx1VT1.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(2, TxCodigo.Text, int.Parse(LbLoja6.Text.Remove(2))).ToString();

                    Tx2VT1.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(3, TxCodigo.Text, int.Parse(LbLoja6.Text.Remove(2))).ToString();

                    TxGeVT1.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(4, TxCodigo.Text, int.Parse(LbLoja6.Text.Remove(2))).ToString();

                    TxFrentQtde6.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeFrenteLoja(TxCodigo.Text, int.Parse(LbLoja6.Text.Remove(2))).ToString();

                    TxTotalVT1.Text = Convert.ToString(int.Parse(TxOrigVT1.Text) + int.Parse(Tx1VT1.Text) + int.Parse(Tx2VT1.Text) + int.Parse(TxGeVT1.Text));

                    TxTotalSaida6.Text = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoqueSaida(Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)),9), 9).ToString();
                }
                ////----------------------------------------------------------//

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Decimal Soma = 0;
                Decimal QtdeSaida; 

                Soma = Decimal.Parse(TxEstTotalPituba.Text) + Decimal.Parse(TxTotalTJ.Text) + Decimal.Parse(TxTotalBrio.Text) + Decimal.Parse(TxTotalSP.Text) + Decimal.Parse(TxTotalVT.Text) + Decimal.Parse(TxTotalVT1.Text);

                LbGeral.Text = Soma.ToString();

                QtdeSaida = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoqueSaida(Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)),int.Parse(CbTipoPecas.Text.Remove(2))), int.Parse(CbFilial.Text.Remove(2)));

                //QtdeAtual = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(Int32.Parse(CbTipoPecas.Text.Remove(2)), TxCodigo.Text, Int32.Parse(CbFilial.Text.Remove(2)));

                LbSaida.Text = QtdeSaida.ToString();

                //Decimal TotalAtual = Decimal.Subtract(QtdeAtual, QtdeSaida);

            }
        }

        private void TxCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void BtNovoArmazenamento_Click(object sender, EventArgs e)
        {
            try
            {
                _armazenamento = null;

                TxPrateleira.Text = "P-";
                TxCompartimento.Text = "C-";
                TxGaveta.Text = "G-";
                TxCaixa.Text = "CX-";
                TxEstGeral.Text = "0";
                TxLado.Text = "L-";
                TxPrateleira_.Text = "P-";
                TxCaixa_.Text = "CX-";
                TxGancho.Text = "GA-";
                TxQtde.Text = "0";

                CbFilial.Focus();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxLote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxQuantidade.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Classes.Bioghet_Empresa> ListafILIAL = Classes.Bioghet_ConsultaMysql.Listar_Empresa();
                CbFilial.Items.Clear();
                for (int i = 0; i < ListafILIAL.Count; i++)
                {
                    CbFilial.Items.Add(ListafILIAL[i].ID + " - " + ListafILIAL[i].RazaoSocial);
                }

                Classes.Bioghet_Configuracao.campo = Interaction.InputBox("INFORME O CÓDIGO DO PRODUTO PARA A REALIZAÇÃO DA CONSULTA", "CONSULTAR PRODUTO", "", 200, 200);

                List<bioghet_produto> _Listproduto = Classes.Bioghet_ConsultaMysql.Listar_ProdutoLojaCodigo(Classes.Bioghet_Configuracao.campo, Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "empresa", "")));

                for(int i = 0; i < _Listproduto.Count; i ++)
                {
                    _produto = new bioghet_produto();
                    TxDescricao.Text = _Listproduto[i].Descricao;
                    _produto.Descricao = _Listproduto[i].Descricao;
                    TxCodigo.Text = _Listproduto[i].CodigoInterno;
                    _produto.CodigoInterno = _Listproduto[i].CodigoInterno;
                    TxBarra.Text = _Listproduto[i].CodigoBarra;
                    _produto.CodigoBarra = _Listproduto[i].CodigoBarra;
                    TxSerie.Text = _Listproduto[i].Serial;
                    _produto.Serial = _Listproduto[i].Serial;
                    TxLote.Text = _Listproduto[i].Lote;
                    _produto.Lote = _Listproduto[i].Lote;
                    if (_Listproduto[i].TipoPeca.Equals(1))
                    {
                        CbTipoPecas.SelectedIndex = 0;
                    }
                    else if (_Listproduto[i].TipoPeca.Equals(2))
                    {
                        CbTipoPecas.SelectedIndex = 2;
                    }
                    else if (_Listproduto[i].TipoPeca.Equals(3))
                    {
                        CbTipoPecas.SelectedIndex = 3;
                    }
                    else if (_Listproduto[i].TipoPeca.Equals(4))
                    {
                        CbTipoPecas.SelectedIndex = 4;
                    }
                    else
                    {
                        CbTipoPecas.Text = "99 SEM CLASSIFICAÇÃO";
                    }
                    TxQuantidade.Text = _Listproduto[i].Quantidade.ToString();
                    TxPrecoCusto.Text = _Listproduto[i].PrecoCusto.ToString("#####0.00");
                    TxPorcVarejo.Text = _Listproduto[i].PVarejo.ToString();
                    TxVendaVarejo.Text = _Listproduto[i].PrecoVarejo.ToString("#####0.00");
                    TxPorcAtacado.Text = _Listproduto[i].PAtacado.ToString();
                    TxPrecoAtacado.Text = _Listproduto[i].PrecoAtacado.ToString("#####0.00");
                    TxDesconto.Text = _Listproduto[i].Desconto.ToString();
                    TxDolaCompra.Text = _Listproduto[i].DolaCompra.ToString("#####0.00");
                    TxDolaVarejo.Text = _Listproduto[i].DolaVarejo.ToString("#####0.00");
                    TxDolaAtacado.Text = _Listproduto[i].DolaAtacado.ToString("#####0.00");

                    String RazaoSocial = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(_Listproduto[i].Filial);

                    if (_Listproduto[i].Filial.ToString().Equals("1"))
                    {
                        int retornofilial = CbFilial.FindString(_Listproduto[i].Filial + " - " + "UNIVERSO PITUBA");
                        CbFilial.SelectedIndex = retornofilial;
                    }
                    else if (_Listproduto[i].Filial.ToString().Equals("2"))
                    {
                        int retornofilial = CbFilial.FindString(_Listproduto[i].Filial + " - " + "TELECENTRO TJ");
                        CbFilial.SelectedIndex = retornofilial;
                    }
                    else if (_Listproduto[i].Filial.ToString().Equals("3"))
                    {
                        int retornofilial = CbFilial.FindString(_Listproduto[i].Filial + " - " + "UNIVERSO DO CELULAR");
                        CbFilial.SelectedIndex = retornofilial;
                    }
                    else if (_Listproduto[i].Filial.ToString().Equals("4"))
                    {
                        int retornofilial = CbFilial.FindString(_Listproduto[i].Filial + " - " + "UNIVERSO DO IPHONE");
                        CbFilial.SelectedIndex = retornofilial;
                    }
                    else if (_Listproduto[i].Filial.ToString().Equals("5"))
                    {
                        int retornofilial = CbFilial.FindString(_Listproduto[i].Filial + " - " + "LOJA VIRTUAL2");
                        CbFilial.SelectedIndex = retornofilial;
                    }
                    else if (_Listproduto[i].Filial.ToString().Equals("6"))
                    {
                        int retornofilial = CbFilial.FindString(_Listproduto[i].Filial + " - " + "SPTECH SP");
                        CbFilial.SelectedIndex = retornofilial;
                    }
                    else
                    {
                        CbFilial.Text = "FILIAL NÃO ENCONTRADO";
                    }
                }

                _fornecedor = Bioghet_Orcamento.Classes.Bioghet_ConsultaMysql.Consultar_FornecedorProduto(Classes.Bioghet_Configuracao.campo, Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)), Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "empresa", ""))));

                if (_fornecedor != null)
                {
                    TxFornecedor.Text = _fornecedor.RazaoSocial;
                    TxCNPJ.Text = _fornecedor.CNPJCPF;
                    TxTelefone.Text = _fornecedor.Telefone;
                    TxContato.Text = _fornecedor.Contato;
                }

                _armazenamento = Classes.Bioghet_ConsultaMysql.Consultar_ArmazenamentoProduto(Classes.Bioghet_Configuracao.campo, Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(TxCodigo.Text, int.Parse(CbTipoPecas.Text.Remove(2)), Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "empresa", ""))));

                if (_armazenamento != null)
                {
                    TxPrateleira.Text = _armazenamento.Prateleira;
                    TxCompartimento.Text = _armazenamento.Compartimento;
                    TxGaveta.Text = _armazenamento.Gaveta;
                    TxCaixa.Text = _armazenamento.Caixa;
                    TxEstGeral.Text = _armazenamento.EstoqueGeral.ToString();
                    TxLado.Text = _armazenamento.Lado;
                    TxPrateleira_.Text = _armazenamento.LadoPrateleira;
                    TxCaixa_.Text = _armazenamento.LadoCaixa;
                    TxGancho.Text = _armazenamento.LadoGancho;
                    TxQtde.Text = _armazenamento.Qtde.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtCodigoBarra_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrWhiteSpace(TxBarra.Text))
                {
                    _produto = Classes.Bioghet_ConsultaMysql.Consultar_ProdutoLojaCodigoBarra(TxBarra.Text, int.Parse(CbFilial.Text.Remove(2)));

                    if (_produto != null)
                    {
                        TxDescricao.Text = _produto.Descricao;
                        TxCodigo.Text = _produto.CodigoInterno;
                        TxBarra.Text = _produto.CodigoBarra;
                        TxSerie.Text = _produto.Serial;
                        TxLote.Text = _produto.Lote;
                        if (_produto.TipoPeca.Equals(1))
                        {
                            CbTipoPecas.SelectedIndex = 0;
                        }
                        else if (_produto.TipoPeca.Equals(2))
                        {
                            CbTipoPecas.SelectedIndex = 1;
                        }
                        else if (_produto.TipoPeca.Equals(3))
                        {
                            CbTipoPecas.SelectedIndex = 2;
                        }
                        else if (_produto.TipoPeca.Equals(4))
                        {
                            CbTipoPecas.SelectedIndex = 3;
                        }
                        else
                        {
                            CbTipoPecas.Text = "99 SEM CLASSIFICAÇÃO";
                        }

                        TxQuantidade.Text = _produto.Quantidade.ToString();
                        TxPrecoCusto.Text = _produto.PrecoCusto.ToString("#####0.00");
                        TxPorcVarejo.Text = _produto.PVarejo.ToString();
                        TxVendaVarejo.Text = _produto.PrecoVarejo.ToString("#####0.00");
                        TxPorcAtacado.Text = _produto.PAtacado.ToString();
                        TxPrecoAtacado.Text = _produto.PrecoAtacado.ToString("#####0.00");
                        TxDesconto.Text = _produto.Desconto.ToString();
                        TxDolaCompra.Text = _produto.DolaCompra.ToString("#####0.00");
                        TxDolaVarejo.Text = _produto.DolaVarejo.ToString("#####0.00");
                        TxDolaAtacado.Text = _produto.DolaAtacado.ToString("#####0.00");

                        _fornecedor = Bioghet_Orcamento.Classes.Bioghet_ConsultaMysql.Consultar_FornecedorProduto(Classes.Bioghet_Configuracao.campo, int.Parse(LbCodigoProduto.Text));
                        TxFornecedor.Text = _fornecedor.RazaoSocial;
                        TxCNPJ.Text = _fornecedor.CNPJCPF;
                        TxTelefone.Text = _fornecedor.Telefone;
                        TxContato.Text = _fornecedor.Contato;

                        _armazenamento = Classes.Bioghet_ConsultaMysql.Consultar_ArmazenamentoProduto(Classes.Bioghet_Configuracao.campo, Int32.Parse(LbCodigoProduto.Text));
                        TxPrateleira.Text = _armazenamento.Prateleira;
                        TxCompartimento.Text = _armazenamento.Compartimento;
                        TxGaveta.Text = _armazenamento.Gaveta;
                        TxCaixa.Text = _armazenamento.Caixa;
                        TxEstGeral.Text = _armazenamento.EstoqueGeral.ToString();
                        TxLado.Text = _armazenamento.Lado;
                        TxPrateleira_.Text = _armazenamento.LadoPrateleira;
                        TxCaixa_.Text = _armazenamento.LadoCaixa;
                        TxGancho.Text = _armazenamento.LadoGancho;
                        TxQtde.Text = _armazenamento.Qtde.ToString();

                        if (_armazenamento.Filial.Equals(4))
                        {
                            CbFilial.SelectedIndex = 0;
                        }
                        else if (_armazenamento.Filial.Equals(5))
                        {
                            CbFilial.SelectedIndex = 1;
                        }
                        else if (_armazenamento.Filial.Equals(8))
                        {
                            CbFilial.SelectedIndex = 2;
                        }
                        else if (_armazenamento.Filial.Equals(9))
                        {
                            CbFilial.SelectedIndex = 3;
                        }
                        else if (_armazenamento.Filial.Equals(11))
                        {
                            CbFilial.SelectedIndex = 4;
                        }
                        else if (_armazenamento.Filial.Equals(12))
                        {
                            CbFilial.SelectedIndex = 5;
                        }
                        else
                        {
                            CbFilial.Text = "FILIAL NÃO ENCONTRADO";
                        }
                    }
                    else
                    {
                        throw new Exception("PRODUTO NÃO ENCONTRADO");
                    }
                }
                else
                {
                    throw new Exception("FAVOR INFORME O CÓDIGO DE BARRA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtSerie_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(TxSerie.Text))
                {
                    _produto = Classes.Bioghet_ConsultaMysql.Consultar_ProdutoLojaCodigoSerie(TxSerie.Text, Int32.Parse(CbFilial.Text.Remove(2)));

                    if (_produto != null)
                    {
                        TxDescricao.Text = _produto.Descricao;
                        TxCodigo.Text = _produto.CodigoInterno;
                        TxBarra.Text = _produto.CodigoBarra;
                        TxSerie.Text = _produto.Serial;
                        TxLote.Text = _produto.Lote;
                        if (_produto.TipoPeca.Equals(1))
                        {
                            CbTipoPecas.SelectedIndex = 0;
                        }
                        else if (_produto.TipoPeca.Equals(2))
                        {
                            CbTipoPecas.SelectedIndex = 1;
                        }
                        else if (_produto.TipoPeca.Equals(3))
                        {
                            CbTipoPecas.SelectedIndex = 2;
                        }
                        else if (_produto.TipoPeca.Equals(4))
                        {
                            CbTipoPecas.SelectedIndex = 3;
                        }
                        else
                        {
                            CbTipoPecas.Text = "99 SEM CLASSIFICAÇÃO";
                        }

                        TxQuantidade.Text = _produto.Quantidade.ToString();
                        TxPrecoCusto.Text = _produto.PrecoCusto.ToString("#####0.00");
                        TxPorcVarejo.Text = _produto.PVarejo.ToString();
                        TxVendaVarejo.Text = _produto.PrecoVarejo.ToString("#####0.00");
                        TxPorcAtacado.Text = _produto.PAtacado.ToString();
                        TxPrecoAtacado.Text = _produto.PrecoAtacado.ToString("#####0.00");
                        TxDesconto.Text = _produto.Desconto.ToString();
                        TxDolaCompra.Text = _produto.DolaCompra.ToString("#####0.00");
                        TxDolaVarejo.Text = _produto.DolaVarejo.ToString("#####0.00");
                        TxDolaAtacado.Text = _produto.DolaAtacado.ToString("#####0.00");

                        _fornecedor = Bioghet_Orcamento.Classes.Bioghet_ConsultaMysql.Consultar_FornecedorProduto(Classes.Bioghet_Configuracao.campo, int.Parse(LbCodigoProduto.Text));
                        TxFornecedor.Text = _fornecedor.RazaoSocial;
                        TxCNPJ.Text = _fornecedor.CNPJCPF;
                        TxTelefone.Text = _fornecedor.Telefone;
                        TxContato.Text = _fornecedor.Contato;

                        _armazenamento = Classes.Bioghet_ConsultaMysql.Consultar_ArmazenamentoProduto(Classes.Bioghet_Configuracao.campo, Int32.Parse(LbCodigoProduto.Text));
                        TxPrateleira.Text = _armazenamento.Prateleira;
                        TxCompartimento.Text = _armazenamento.Compartimento;
                        TxGaveta.Text = _armazenamento.Gaveta;
                        TxCaixa.Text = _armazenamento.Caixa;
                        TxEstGeral.Text = _armazenamento.EstoqueGeral.ToString();
                        TxLado.Text = _armazenamento.Lado;
                        TxPrateleira_.Text = _armazenamento.LadoPrateleira;
                        TxCaixa_.Text = _armazenamento.LadoCaixa;
                        TxGancho.Text = _armazenamento.LadoGancho;
                        TxQtde.Text = _armazenamento.Qtde.ToString();

                        if (_armazenamento.Filial.Equals(4))
                        {
                            CbFilial.SelectedIndex = 0;
                        }
                        else if (_armazenamento.Filial.Equals(5))
                        {
                            CbFilial.SelectedIndex = 1;
                        }
                        else if (_armazenamento.Filial.Equals(8))
                        {
                            CbFilial.SelectedIndex = 2;
                        }
                        else if (_armazenamento.Filial.Equals(9))
                        {
                            CbFilial.SelectedIndex = 3;
                        }
                        else if (_armazenamento.Filial.Equals(11))
                        {
                            CbFilial.SelectedIndex = 4;
                        }
                        else if (_armazenamento.Filial.Equals(12))
                        {
                            CbFilial.SelectedIndex = 5;
                        }
                        else
                        {
                            CbFilial.Text = "FILIAL NÃO ENCONTRADO";
                        }
                    }
                    else
                    {
                        throw new Exception("PRODUTO NÃO ENCONTRADO");
                    }
                }
                else
                {
                    throw new Exception("FAVOR INFORME O NÚMERO DE SÉRIE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtLote_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(TxLote.Text))
                {
                    _produto = Classes.Bioghet_ConsultaMysql.Consultar_ProdutoLojaCodigoLote(TxLote.Text);

                    if (_produto != null)
                    {
                        TxDescricao.Text = _produto.Descricao;
                        TxCodigo.Text = _produto.CodigoInterno;
                        TxBarra.Text = _produto.CodigoBarra;
                        TxSerie.Text = _produto.Serial;
                        TxLote.Text = _produto.Lote;
                        if (_produto.TipoPeca.Equals(1))
                        {
                            CbTipoPecas.SelectedIndex = 0;
                        }
                        else if (_produto.TipoPeca.Equals(2))
                        {
                            CbTipoPecas.SelectedIndex = 1;
                        }
                        else if (_produto.TipoPeca.Equals(3))
                        {
                            CbTipoPecas.SelectedIndex = 2;
                        }
                        else if (_produto.TipoPeca.Equals(4))
                        {
                            CbTipoPecas.SelectedIndex = 3;
                        }
                        else
                        {
                            CbTipoPecas.Text = "99 SEM CLASSIFICAÇÃO";
                        }
                        TxQuantidade.Text = _produto.Quantidade.ToString();
                        TxPrecoCusto.Text = _produto.PrecoCusto.ToString("#####0.00");
                        TxPorcVarejo.Text = _produto.PVarejo.ToString();
                        TxVendaVarejo.Text = _produto.PrecoVarejo.ToString("#####0.00");
                        TxPorcAtacado.Text = _produto.PAtacado.ToString();
                        TxPrecoAtacado.Text = _produto.PrecoAtacado.ToString("#####0.00");
                        TxDesconto.Text = _produto.Desconto.ToString();

                        _fornecedor = Bioghet_Orcamento.Classes.Bioghet_ConsultaMysql.Consultar_FornecedorProduto(Classes.Bioghet_Configuracao.campo, int.Parse(LbCodigoProduto.Text));
                        TxFornecedor.Text = _fornecedor.RazaoSocial;
                        TxCNPJ.Text = _fornecedor.CNPJCPF;
                        TxTelefone.Text = _fornecedor.Telefone;
                        TxContato.Text = _fornecedor.Contato;

                        _armazenamento = Classes.Bioghet_ConsultaMysql.Consultar_ArmazenamentoProduto(Classes.Bioghet_Configuracao.campo, Int32.Parse(LbCodigoProduto.Text));
                        TxPrateleira.Text = _armazenamento.Prateleira;
                        TxCompartimento.Text = _armazenamento.Compartimento;
                        TxGaveta.Text = _armazenamento.Gaveta;
                        TxCaixa.Text = _armazenamento.Caixa;
                        TxEstGeral.Text = _armazenamento.EstoqueGeral.ToString();
                        TxLado.Text = _armazenamento.Lado;
                        TxPrateleira_.Text = _armazenamento.LadoPrateleira;
                        TxCaixa_.Text = _armazenamento.LadoCaixa;
                        TxGancho.Text = _armazenamento.LadoGancho;
                        TxQtde.Text = _armazenamento.Qtde.ToString();

                        if (_armazenamento.Filial.Equals(4))
                        {
                            CbFilial.SelectedIndex = 0;
                        }
                        else if (_armazenamento.Filial.Equals(5))
                        {
                            CbFilial.SelectedIndex = 1;
                        }
                        else if (_armazenamento.Filial.Equals(8))
                        {
                            CbFilial.SelectedIndex = 2;
                        }
                        else if (_armazenamento.Filial.Equals(9))
                        {
                            CbFilial.SelectedIndex = 3;
                        }
                        else if (_armazenamento.Filial.Equals(11))
                        {
                            CbFilial.SelectedIndex = 4;
                        }
                        else if (_armazenamento.Filial.Equals(12))
                        {
                            CbFilial.SelectedIndex = 5;
                        }
                        else
                        {
                            CbFilial.Text = "FILIAL NÃO ENCONTRADO";
                        }
                    }
                    else
                    {
                        throw new Exception("PRODUTO NÃO ENCONTRADO");
                    }
                }
                else
                {
                    throw new Exception("FAVOR INFORME O NÚMERO DE SÉRIE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbFilial_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                
                //_produto = null;
                //_fornecedor = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxEstTotalPituba_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxTotalTJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxFrentQtde6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxFrentQtde1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxFrentQtde2_TextChanged(object sender, EventArgs e)
        {

        }

        private Decimal _cambio;
        private void Form11_Activated(object sender, EventArgs e)
        {
            try
            {
                _cambio = Decimal.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "cambiododia", ""));

                //if (_produto == null)
                //{
                //    _produto = null;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbFilial_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                //_produto = null;
                //_fornecedor = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(TxFornecedor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbFilial_Click(object sender, EventArgs e)
        {
            try
            {
                List<Classes.Bioghet_Empresa> Lista = Classes.Bioghet_ConsultaMysql.Listar_Empresa();
                CbFilial.Items.Clear();
                for (int i = 0; i < Lista.Count; i++)
                {
                    CbFilial.Items.Add(Lista[i].ID + " - " + Lista[i].RazaoSocial);
                }

                //CbFilial.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                List<Classes.Bioghet_Armazenamento> Listar = Classes.Bioghet_ConsultaMysql.Listar_ProdutosArmazenadosLoja(TxLado.Text, TxPrateleira_.Text, TxGancho.Text, TxCaixa_.Text, int.Parse(CbFilial.Text.Remove(2)));

                String[] Param = new String[8];

                FormConsultaArmazenamento armazenamento = new FormConsultaArmazenamento();

                armazenamento.DgArmazenamento.Rows.Clear();

                for (int i = 0; i < Listar.Count; i++)
                {
                    Param[0] = Listar[i].CodigoProduto;
                    Param[1] = Listar[i].DescricaoProduto;
                    Param[2] = Listar[i].Qtde.ToString();
                    Param[3] = Listar[i].Lado;
                    Param[4] = Listar[i].LadoPrateleira;
                    Param[5] = Listar[i].LadoGancho;
                    Param[6] = Listar[i].LadoCaixa;
                    Param[7] = Listar[i].ID.ToString();

                    armazenamento.DgArmazenamento.Rows.Add(Param);

                }
                
                Int32 maximoqtdetotalloja = Classes.Bioghet_ConsultaMysql.Consultar_LadoLojaTotal(TxLado.Text, TxPrateleira_.Text, TxGancho.Text, TxCaixa_.Text, Int32.Parse(CbFilial.Text.Remove(2)));

                armazenamento.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtDolar_Click(object sender, EventArgs e)
        {
            try
            {
                String Dolar = Microsoft.VisualBasic.Interaction.InputBox(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "cambiododia", ""), " - CAMBIO DO DIA", "", 200, 200);

                if(!String.IsNullOrWhiteSpace(Dolar))
                {
                    DialogResult pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR O CAMBIO DO DIA? ", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("geral", "cambiododia", Dolar);
                        Ini.gravaarquivoini("geral", "cambioant", Dolar);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void CarregaValores()
        {
            try
            {
                if (_produto == null)
                {
                    TxPrecoCusto.Text = "0,05";
                    Decimal Custo = Decimal.Parse(TxPrecoCusto.Text);
                    Decimal Soma = Decimal.Divide(Custo, _cambio);

                    TxDolaCompra.Text = Soma.ToString("#####0.00");

                    Decimal MargemVarejo = Decimal.Parse("75");

                    Soma = Decimal.Multiply(Custo, MargemVarejo) / 100;
                    Decimal ValorVarejo = Decimal.Add(Soma, Custo);
                    Decimal SomaDola = Decimal.Divide(ValorVarejo, _cambio);
                    TxDolaVarejo.Text = SomaDola.ToString("#####0.00");

                    TxVendaVarejo.Text = ValorVarejo.ToString("#####0.00");

                    Decimal MargemAtacado = Decimal.Parse("55");

                    Soma = Decimal.Multiply(Custo, MargemAtacado) / 100;
                    Decimal SomaAtacado = Decimal.Add(Soma, Custo);

                    TxPrecoAtacado.Text = SomaAtacado.ToString("#####0.00");

                    TxDolaAtacado.Text = Decimal.Divide(SomaAtacado, _cambio).ToString("#####0.00");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form11_Shown(object sender, EventArgs e)
        {
            try
            {
                CarregaValores();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
