using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
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
    public partial class FrmConsultaProduto : Form
    {
        public FrmConsultaProduto()
        {
            InitializeComponent();
        }

        private void BtProduto_Click(object sender, EventArgs e)
        {
            if (Classes.Bioghet_Configuracao.Funcao.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
            {
                Form11 _produto = new Form11();
                _produto.ChOpcao.Items.Clear();
                _produto._produto = null;

                List<Bioghet_Orcamento.Classes.Bioghet_Opcao> Lista = Classes.Bioghet_ConsultaMysql.Listar_Opcao();
                for (int i = 0; i < Lista.Count; i++)
                {
                    _produto.ChOpcao.Items.Add(Lista[i].Descricao);
                }

                _produto.ChOpcao.SetItemChecked(1, true);
                _produto.ChOpcao.SetItemChecked(2, true);
                _produto.ChOpcao.SetItemChecked(7, true);

                _produto.Show();
            }
            else
            {
                throw new Exception("OPERADOR NÃO HABILITADO A UTILIZAR ESTE RECURSO");
            }
        }

        internal FrmVenda _venda = new FrmVenda();
        internal NotifyIcon _Icon = new NotifyIcon();
        internal int codigofilial = Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "EMPRESA", ""));
        private void FrmConsultaProduto_Load(object sender, EventArgs e)
        {
            try
            {
                //DgConsulta.Rows.Clear();
                //List<bioghet_produto> _produto = Classes.Bioghet_ConsultaMysql.Listar_ProdutoLoja();
                //String[] Param = new String[25];

                //for(int i = 0; i < _produto.Count; i++)
                //{

                //    Param[0] = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(_produto[i].Filial);
                //    Param[1] = _produto[i].Descricao;
                //    Param[2] = _produto[i].CodigoInterno;
                //    Param[3] = _produto[i].CodigoBarra;
                //    Param[4] = _produto[i].Serial;
                //    Param[5] = _produto[i].Lote;
                //    Param[6] = _produto[i].TipoPeca.ToString();
                //    Param[7] = _produto[i].Quantidade.ToString();
                //    Param[8] = _produto[i].PrecoCusto.ToString("#####0.00");
                //    Param[9] = _produto[i].PrecoVarejo.ToString("#####0.00");
                //    Param[10] = _produto[i].PrecoAtacado.ToString("#####0.00");
                //    Param[11] = _produto[i].DataCompra.ToString("dd-MM-yyyy");
                //    Param[12] = _produto[i].Garantia.ToString();
                //    Param[13] = _produto[i].FimGarantia.ToString("dd-MM-yyyy");
                //    Param[14] = _produto[i].PVarejo.ToString();
                //    Param[15] = _produto[i].PAtacado.ToString();
                //    Param[16] = _produto[i].Aparelho.ToString();
                //    Param[17] = _produto[i].Peca.ToString();
                //    Param[18] = _produto[i].Novo.ToString();
                //    Param[19] = _produto[i].Usado.ToString();
                //    Param[20] = _produto[i].NTestada.ToString();
                //    Param[21] = _produto[i].Defeito.ToString();
                //    Param[22] = _produto[i].RetAparelho.ToString();
                //    Param[23] = _produto[i].Testado.ToString();
                //    Param[24] = _produto[i].Filial.ToString();

                //    DgConsulta.Rows.Add(Param);
                //}

                codigofilial = Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "EMPRESA", ""));

                String RazaoSocial = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(codigofilial);

                LbCambio.Text = Decimal.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "cambiododia", "")).ToString("#####0.00");

                List<Classes.Bioghet_Empresa> Lista = Classes.Bioghet_ConsultaMysql.Listar_Empresa();
                CbFilial.Items.Clear();
                for (int i = 0; i < Lista.Count; i++)
                {
                    CbFilial.Items.Add(Lista[i].ID + " - " + Lista[i].RazaoSocial);
                }

                int codigoRetornoFilial = CbFilial.FindString(codigofilial.ToString() + " - " + RazaoSocial);
                CbFilial.SelectedIndex = codigoRetornoFilial;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                for(int i = 0; i < DgConsulta.Rows.Count; i++)
                {
                    if (DgConsulta.Rows[i].Cells[7].Value.Equals("0"))
                    {
                        DgConsulta.Rows[i].Cells[7].Style.BackColor = Color.FromArgb(255, 192, 192);
                        //_Icon.Icon = new Icon(Environment.CurrentDirectory + "\\LGOTJ.ico");
                        //_Icon.Visible = true;
                        //_Icon.BalloonTipTitle = "BIOGHET - ATENÇÃO";
                        //_Icon.Text = "NOTIFICAÇÃO DE ALERTA";
                        //_Icon.BalloonTipText = "EXISTEM PRODUTOS COM ESTOQUE ZERADO, FAVOR VERIFIQUE";
                        //_Icon.ShowBalloonTip(1000);    
                    }
                    //else
                    //{
                    //    DgConsulta.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 185);
                    //}
                    if (DgConsulta.Rows[i].Cells[6].Value.Equals("1"))
                    {
                        DgConsulta.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(0, 192, 0);
                    }
                    else if (DgConsulta.Rows[i].Cells[6].Value.Equals("2"))
                    {
                        DgConsulta.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(192, 192, 0);
                    }
                    else if (DgConsulta.Rows[i].Cells[6].Value.Equals("3"))
                    {
                        DgConsulta.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(0, 192, 192);
                    }
                    else if (DgConsulta.Rows[i].Cells[6].Value.Equals("4"))
                    {
                        DgConsulta.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(255, 128, 128);
                    }

                }
            }

        }

        private void TxDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (RdDescricao.Checked)
                {
                    DgConsulta.Rows.Clear();
                    List<bioghet_produto> _produto = Classes.Bioghet_ConsultaMysql.Listar_ProdutoLojaDigito(TxDescricao.Text, Int32.Parse(CbFilial.Text.Remove(2)));
                    String[] Param = new String[30];

                    for (int i = 0; i < _produto.Count; i++)
                    {
                        //Param[0] = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(_produto[i].Filial);
                        Param[0] = _produto[i].RazaoSocial;
                        Param[1] = _produto[i].Descricao;
                        Param[2] = _produto[i].CodigoInterno;
                        Param[3] = _produto[i].CodigoBarra;
                        Param[4] = _produto[i].Serial;
                        Param[5] = _produto[i].Lote;
                        Param[6] = _produto[i].TipoPeca.ToString();
                        Param[7] = _produto[i].Quantidade.ToString();
                        Param[8] = _produto[i].PrecoCusto.ToString("#####0.00");
                        Param[9] = _produto[i].PrecoVarejo.ToString("#####0.00");
                        Param[10] = _produto[i].PrecoAtacado.ToString("#####0.00");
                        Param[11] = _produto[i].DataCompra.ToString("dd-MM-yyyy");
                        Param[12] = _produto[i].Garantia.ToString();
                        Param[13] = _produto[i].FimGarantia.ToString("dd-MM-yyyy");
                        Param[14] = _produto[i].PVarejo.ToString();
                        Param[15] = _produto[i].PAtacado.ToString();
                        Param[16] = _produto[i].Aparelho.ToString();
                        Param[17] = _produto[i].Peca.ToString();
                        Param[18] = _produto[i].Novo.ToString();
                        Param[19] = _produto[i].Usado.ToString();
                        Param[20] = _produto[i].NTestada.ToString();
                        Param[21] = _produto[i].Defeito.ToString();
                        Param[22] = _produto[i].RetAparelho.ToString();
                        Param[23] = _produto[i].Testado.ToString();
                        Param[24] = _produto[i].Filial.ToString();
                        Param[25] = _produto[i].ID.ToString();
                        Param[26] = _produto[i].DolaVarejo.ToString("#####0.00");
                        Param[27] = _produto[i].DolaAtacado.ToString("#####0.00");
                        Param[28] = _produto[i].DolaCompra.ToString("#####0.00");
                        Param[29] = _produto[i].CambioDia.ToString("#####0.00");

                        DgConsulta.Rows.Add(Param);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                for (int i = 0; i < DgConsulta.Rows.Count; i++)
                {
                    if (DgConsulta.Rows[i].Cells[7].Value.Equals("0"))
                    {
                        DgConsulta.Rows[i].Cells[7].Style.BackColor = Color.FromArgb(255, 192, 192);
                        //_Icon.Icon = new Icon(Environment.CurrentDirectory + "\\LGOTJ.ico");
                        //_Icon.Visible = true;
                        //_Icon.BalloonTipTitle = "BIOGHET - ATENÇÃO";
                        //_Icon.Text = "NOTIFICAÇÃO DE ALERTA";
                        //_Icon.BalloonTipText = "EXISTEM PRODUTOS COM ESTOQUE ZERADO, FAVOR VERIFIQUE";
                        //_Icon.ShowBalloonTip(1000);
                    }
                }
            }
        }

        internal Int32 Retorno;
        private int filiallogado = Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "EMPRESA", ""));
        private void DgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 30)
                {//25

                    int filial = Int32.Parse(CbFilial.Text.Remove(2));

                    if (filiallogado != filial)
                        throw new Exception("NÃO FOI POSSIVEL REALIZAR ALTERAÇÕES NA EMPRESA SELECIONADA, FAVOR EFETUE O LOGOFF E LOGUE NA FILIAL QUE DESEJA REALIZAR ALTERAÇÃO");

                    Form11 _produto = new Form11();

                    _produto._produto = new bioghet_produto();
                    _produto._fornecedor = new Classes.Bioghet_Fornecedor();
                    _produto._armazenamento = new Classes.Bioghet_Armazenamento();

                    _produto.ChOpcao.Items.Clear();

                    List<Bioghet_Orcamento.Classes.Bioghet_Opcao> Lista = Classes.Bioghet_ConsultaMysql.Listar_Opcao();
                    for (int i = 0; i < Lista.Count; i++)
                    {
                        _produto.ChOpcao.Items.Add(Lista[i].Descricao);
                    }

                    List<Classes.Bioghet_Empresa> ListafILIAL = Classes.Bioghet_ConsultaMysql.Listar_Empresa();
                    _produto.CbFilial.Items.Clear();
                    for (int i = 0; i < ListafILIAL.Count; i++)
                    {
                        _produto.CbFilial.Items.Add(ListafILIAL[i].ID + " - " + ListafILIAL[i].RazaoSocial);
                    }

                    _produto.TxDescricao.Text = DgConsulta.CurrentRow.Cells[1].Value.ToString();
                    _produto._produto.Descricao = DgConsulta.CurrentRow.Cells[1].Value.ToString();

                    _produto.TxCodigo.Text = DgConsulta.CurrentRow.Cells[2].Value.ToString();
                    _produto._produto.CodigoInterno = DgConsulta.CurrentRow.Cells[2].Value.ToString();

                    _produto.TxBarra.Text = DgConsulta.CurrentRow.Cells[3].Value.ToString();
                    _produto._produto.CodigoBarra = DgConsulta.CurrentRow.Cells[3].Value.ToString();

                    _produto.TxSerie.Text = DgConsulta.CurrentRow.Cells[4].Value.ToString();
                    _produto._produto.Serial = DgConsulta.CurrentRow.Cells[4].Value.ToString();

                    _produto.TxLote.Text = DgConsulta.CurrentRow.Cells[5].Value.ToString();
                    _produto._produto.Lote = DgConsulta.CurrentRow.Cells[5].Value.ToString();
                    _produto.TxDolaVarejo.Text = DgConsulta.CurrentRow.Cells[26].Value.ToString();
                    _produto.TxDolaAtacado.Text = DgConsulta.CurrentRow.Cells[27].Value.ToString();
                    _produto.TxDolaCompra.Text = DgConsulta.CurrentRow.Cells[28].Value.ToString();

                    if (DgConsulta.CurrentRow.Cells[6].Value.ToString().Equals("1"))
                    {
                        _produto.CbTipoPecas.SelectedIndex = 0;
                    }
                    else if (DgConsulta.CurrentRow.Cells[6].Value.ToString().Equals("2"))
                    {
                        _produto.CbTipoPecas.SelectedIndex = 1;
                    }
                    else if (DgConsulta.CurrentRow.Cells[6].Value.ToString().Equals("3"))
                    {
                        _produto.CbTipoPecas.SelectedIndex = 2;

                    }
                    else if (DgConsulta.CurrentRow.Cells[6].Value.ToString().Equals("4"))
                    {
                        _produto.CbTipoPecas.SelectedIndex = 3;
                    }
                    else
                    {
                        _produto.CbTipoPecas.Text = "99 SEM CLASSIFICAÇÃO";
                    }
                    _produto.TxQuantidade.Text = DgConsulta.CurrentRow.Cells[7].Value.ToString();
                    _produto._produto.Quantidade = Int32.Parse(DgConsulta.CurrentRow.Cells[7].Value.ToString());

                    _produto.TxPrecoCusto.Text = DgConsulta.CurrentRow.Cells[8].Value.ToString();
                    _produto._produto.PrecoCusto = Decimal.Parse(DgConsulta.CurrentRow.Cells[8].Value.ToString());

                    _produto.TxVendaVarejo.Text = DgConsulta.CurrentRow.Cells[9].Value.ToString();
                    _produto._produto.PrecoVarejo = Decimal.Parse(DgConsulta.CurrentRow.Cells[9].Value.ToString());

                    _produto.TxPrecoAtacado.Text = DgConsulta.CurrentRow.Cells[10].Value.ToString();
                    _produto._produto.PrecoAtacado = Decimal.Parse(DgConsulta.CurrentRow.Cells[10].Value.ToString());

                    _produto.DtCompra.Text = DgConsulta.CurrentRow.Cells[11].Value.ToString();
                    _produto._produto.DataCompra = DateTime.Parse(DgConsulta.CurrentRow.Cells[11].Value.ToString());

                    _produto.TxGarantia.Text = DgConsulta.CurrentRow.Cells[12].Value.ToString();
                    _produto._produto.Garantia = Int32.Parse(DgConsulta.CurrentRow.Cells[12].Value.ToString());

                    _produto.DtGarantia.Text = DgConsulta.CurrentRow.Cells[13].Value.ToString();
                    _produto._produto.DataCompra = DateTime.Parse(DgConsulta.CurrentRow.Cells[13].Value.ToString());

                    _produto.TxPorcVarejo.Text = DgConsulta.CurrentRow.Cells[14].Value.ToString();
                    _produto._produto.PVarejo = Decimal.Parse(DgConsulta.CurrentRow.Cells[14].Value.ToString());

                    _produto.TxPorcAtacado.Text = DgConsulta.CurrentRow.Cells[15].Value.ToString();
                    _produto._produto.PAtacado = Decimal.Parse(DgConsulta.CurrentRow.Cells[15].Value.ToString());

                    _produto.ChOpcao.SetItemChecked(0, Boolean.Parse(DgConsulta.CurrentRow.Cells[16].Value.ToString()));
                    _produto.ChOpcao.SetItemChecked(1, Boolean.Parse(DgConsulta.CurrentRow.Cells[17].Value.ToString()));
                    _produto.ChOpcao.SetItemChecked(2, Boolean.Parse(DgConsulta.CurrentRow.Cells[18].Value.ToString()));
                    _produto.ChOpcao.SetItemChecked(3, Boolean.Parse(DgConsulta.CurrentRow.Cells[19].Value.ToString()));
                    _produto.ChOpcao.SetItemChecked(4, Boolean.Parse(DgConsulta.CurrentRow.Cells[20].Value.ToString()));
                    _produto.ChOpcao.SetItemChecked(5, Boolean.Parse(DgConsulta.CurrentRow.Cells[21].Value.ToString()));
                    _produto.ChOpcao.SetItemChecked(6, Boolean.Parse(DgConsulta.CurrentRow.Cells[22].Value.ToString()));
                    _produto.ChOpcao.SetItemChecked(7, Boolean.Parse(DgConsulta.CurrentRow.Cells[23].Value.ToString()));

                    _produto.LbCodigoProduto.Text = DgConsulta.CurrentRow.Cells[25].Value.ToString();

                    Bioghet_Orcamento.Classes.Bioghet_Fornecedor _fornecedor = Bioghet_Orcamento.Classes.Bioghet_ConsultaMysql.Consultar_FornecedorProduto(DgConsulta.CurrentRow.Cells[2].Value.ToString(), int.Parse(DgConsulta.CurrentRow.Cells[25].Value.ToString()));

                    if (_fornecedor != null)
                    {
                        _produto.TxFornecedor.Text = _fornecedor.RazaoSocial;
                        _produto._fornecedor.RazaoSocial = _fornecedor.RazaoSocial;

                        _produto.TxCNPJ.Text = _fornecedor.CNPJCPF;
                        _produto._fornecedor.CNPJCPF = _fornecedor.CNPJCPF;

                        _produto.TxTelefone.Text = _fornecedor.Telefone;
                        _produto._fornecedor.Telefone = _fornecedor.Telefone;

                        _produto.TxContato.Text = _fornecedor.Contato;
                        _produto._fornecedor.Contato = _fornecedor.Contato;
                    }


                    Classes.Bioghet_Armazenamento _armazenamento = Classes.Bioghet_ConsultaMysql.Consultar_ArmazenamentoProduto(DgConsulta.CurrentRow.Cells[2].Value.ToString(), int.Parse(DgConsulta.CurrentRow.Cells[25].Value.ToString()));

                    if (_armazenamento != null)
                    {
                        _produto.TxPrateleira.Text = _armazenamento.Prateleira;
                        _produto._armazenamento.Prateleira = _armazenamento.Prateleira;

                        _produto.TxCompartimento.Text = _armazenamento.Compartimento;
                        _produto._armazenamento.Compartimento = _armazenamento.Compartimento;

                        _produto.TxGaveta.Text = _armazenamento.Gaveta;
                        _produto._armazenamento.Gaveta = _armazenamento.Gaveta;

                        _produto.TxCaixa.Text = _armazenamento.Caixa;
                        _produto._armazenamento.Caixa = _armazenamento.Caixa;

                        _produto.TxEstGeral.Text = _armazenamento.EstoqueGeral.ToString();
                        _produto._armazenamento.EstoqueGeral = _armazenamento.EstoqueGeral;

                        _produto.TxLado.Text = _armazenamento.Lado;
                        _produto._armazenamento.Lado = _armazenamento.Lado;

                        _produto.TxPrateleira_.Text = _armazenamento.LadoPrateleira;
                        _produto._armazenamento.LadoPrateleira = _armazenamento.LadoPrateleira;

                        _produto.TxCaixa_.Text = _armazenamento.LadoCaixa;
                        _produto._armazenamento.LadoCaixa = _armazenamento.LadoCaixa;

                        _produto.TxGancho.Text = _armazenamento.LadoGancho;
                        _produto._armazenamento.LadoGancho = _armazenamento.LadoGancho;

                        _produto.TxQtde.Text = _armazenamento.Qtde.ToString();
                        _produto._armazenamento.Qtde = _armazenamento.Qtde;
                    }



                    if (DgConsulta.CurrentRow.Cells[24].Value.ToString().Equals("1"))
                    {
                        int retornofilial = _produto.CbFilial.FindString("1 - UNIVERSO PITUBA");
                        _produto.CbFilial.SelectedIndex = retornofilial;
                    }
                    else if (DgConsulta.CurrentRow.Cells[24].Value.ToString().Equals("2"))
                    {
                        int retornofilial = _produto.CbFilial.FindString("2 - TELECENTRO TJ");
                        _produto.CbFilial.SelectedIndex = retornofilial;
                    }
                    else if (DgConsulta.CurrentRow.Cells[24].Value.ToString().Equals("3"))
                    {
                        int retornofilial = _produto.CbFilial.FindString("3 - UNIVERSO DO CELULAR");
                        _produto.CbFilial.SelectedIndex = retornofilial;
                    }
                    else if (DgConsulta.CurrentRow.Cells[24].Value.ToString().Equals("4"))
                    {
                        int retornofilial = _produto.CbFilial.FindString("4 - UNIVERSO DO IPHONE");
                        _produto.CbFilial.SelectedIndex = retornofilial;
                    }
                    else if (DgConsulta.CurrentRow.Cells[24].Value.ToString().Equals("5"))
                    {
                        int retornofilial = _produto.CbFilial.FindString("5 - LOJA VIRTUAL2");
                        _produto.CbFilial.SelectedIndex = retornofilial;
                    }
                    else if (DgConsulta.CurrentRow.Cells[24].Value.ToString().Equals("6"))
                    {
                        int retornofilial = _produto.CbFilial.FindString("6 - SPTECH SP");
                        _produto.CbFilial.SelectedIndex = retornofilial;
                    }
                    else
                    {
                        _produto.CbFilial.Text = "FILIAL NÃO ENCONTRADO";
                    }

                    _produto.Show();
                }

                if(e.ColumnIndex.Equals(31))
                {//26

                    int filial = Int32.Parse(CbFilial.Text.Remove(2));

                    if (filiallogado != filial)
                        throw new Exception("NÃO FOI POSSIVEL REALIZAR ALTERAÇÕES NA EMPRESA SELECIONADA, FAVOR EFETUE O LOGOFF E LOGUE NA FILIAL QUE DESEJA REALIZAR ALTERAÇÃO");


                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE EXCLUIR O PRODUTO" + DgConsulta.CurrentRow.Cells[1].Value.ToString(), "EXCLUIR PRODUTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(_pergunta == System.Windows.Forms.DialogResult.Yes)
                    {
                        Retorno = Classes.Bioghet_ExcluirMYSQL.Excluir_Produto(DgConsulta.CurrentRow.Cells[2].Value.ToString(), int.Parse(DgConsulta.CurrentRow.Cells[6].Value.ToString()), int.Parse(DgConsulta.CurrentRow.Cells[24].Value.ToString()));
                        if(Retorno.Equals(1))
                        {
                            Retorno = Classes.Bioghet_ExcluirMYSQL.Excluir_Fornecedor(DgConsulta.CurrentRow.Cells[2].Value.ToString(), Int32.Parse(DgConsulta.CurrentRow.Cells[24].Value.ToString()));

                            if(Retorno.Equals(1))
                            {
                                Retorno = Classes.Bioghet_ExcluirMYSQL.Excluir_Armazenamento(DgConsulta.CurrentRow.Cells[2].Value.ToString(), int.Parse(DgConsulta.CurrentRow.Cells[24].Value.ToString()), int.Parse(DgConsulta.CurrentRow.Cells[25].Value.ToString()));
                                if(Retorno.Equals(1))
                                {
                                    MessageBox.Show("PRODUTO EXCLUIDO COM SUCESSO", "EXCLUIR PRODUTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    throw new Exception("ERRO AO EXCLUIR O ARMAZENAMENTO DO PRODUTO " + DgConsulta.CurrentRow.Cells[1].Value.ToString());
                                }
                            }
                            else
                            {
                                throw new Exception("ERRO AO EXCLUIR O FORNECEDOR DO PRODUTO " + DgConsulta.CurrentRow.Cells[1].Value.ToString());
                            }
                        }
                        else
                        {
                            throw new Exception("ERRO AO EXCLUIR O PRODUTO " + DgConsulta.CurrentRow.Cells[1].Value.ToString());
                        }
                    }
                }

                if(e.ColumnIndex.Equals(32))
                {//27

                    int filial = Int32.Parse(CbFilial.Text.Remove(2));

                    if (filiallogado != filial)
                        throw new Exception("NÃO FOI POSSIVEL REALIZAR ALTERAÇÕES NA EMPRESA SELECIONADA, FAVOR EFETUE O LOGOFF E LOGUE NA FILIAL QUE DESEJA REALIZAR ALTERAÇÃO");


                    Classes.Bioghet_Configuracao.venda = true;

                    FrmAviso _aviso = new FrmAviso();
                    _aviso.LbAviso.Text = "DIGITE A QUANTIDADE DO PRODUTO";
                    _aviso.ShowDialog();

                    int QuantidadeEstoque = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(int.Parse(DgConsulta.CurrentRow.Cells[6].Value.ToString()), DgConsulta.CurrentRow.Cells[2].Value.ToString(), int.Parse(DgConsulta.CurrentRow.Cells[24].Value.ToString()));

                    if(QuantidadeEstoque <= 0)
                    {
                        throw new Exception("VENDA INVÁLIDA ESTOQUE ZERADO, FAVOR VERIFIQUE");
                    }
                    else if (Classes.Bioghet_Configuracao.Quantidade > QuantidadeEstoque)
                    {
                        throw new Exception("VENDA INVÁLIDA QUANTIDADE EXCEDIDA, FAVOR VERIFIQUE");
                    }
                    else
                    {
                        DialogResult _pergunta = MessageBox.Show("DESEJA ADICIONAR O ITEM " + DgConsulta.CurrentRow.Cells[1].Value.ToString() + " AO CARRINHO DE COMPRA", "CARRINHO DE COMPRA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (_pergunta == System.Windows.Forms.DialogResult.Yes)
                        {

                            Classes.Bioghet_Configuracao.TotalItems = Classes.Bioghet_Configuracao.TotalItems + 1;

                            //LbTotalItems.Text = Classes.Bioghet_Configuracao.TotalItems.ToString();

                            _venda.DgConsulta.Rows.Add(Classes.Bioghet_Configuracao.TotalItems.ToString(), DgConsulta.CurrentRow.Cells[1].Value.ToString(), DgConsulta.CurrentRow.Cells[2].Value.ToString(), DgConsulta.CurrentRow.Cells[6].Value.ToString(), Classes.Bioghet_Configuracao.Quantidade, DgConsulta.CurrentRow.Cells[9].Value.ToString(), Decimal.Multiply(decimal.Parse(Classes.Bioghet_Configuracao.Quantidade.ToString()), decimal.Parse(DgConsulta.CurrentRow.Cells[9].Value.ToString())), DgConsulta.CurrentRow.Cells[24].Value.ToString(), DgConsulta.CurrentRow.Cells[25].Value.ToString());

                            Decimal QtdeAtual = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoque(Int32.Parse(DgConsulta.CurrentRow.Cells[6].Value.ToString()), DgConsulta.CurrentRow.Cells[2].Value.ToString(), Int32.Parse(DgConsulta.CurrentRow.Cells[24].Value.ToString()));

                            Decimal Total = Decimal.Subtract(QtdeAtual, Decimal.Parse(Classes.Bioghet_Configuracao.Quantidade.ToString()));

                            int IDProduto = Classes.Bioghet_ConsultaMysql.Consultar_IDProduto(DgConsulta.CurrentRow.Cells[2].Value.ToString(), int.Parse(DgConsulta.CurrentRow.Cells[6].Value.ToString()), int.Parse(DgConsulta.CurrentRow.Cells[24].Value.ToString()));

                            //int retornoestoque = Classes.Bioghet_UpdateMYSQL.Update_QuantidadeArmazenamento(Int32.Parse(Total.ToString()), DgConsulta.CurrentRow.Cells[2].Value.ToString(),int.Parse(DgConsulta.CurrentRow.Cells[24].Value.ToString()),IDProduto);
                            int retornoestoqueproduto = Classes.Bioghet_UpdateMYSQL.Update_QuantidadeProduto(Int32.Parse(Total.ToString()), DgConsulta.CurrentRow.Cells[2].Value.ToString(), int.Parse(DgConsulta.CurrentRow.Cells[24].Value.ToString()), IDProduto);

                            Decimal quantidadearmazenamento = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeArmazenamentoLoja(DgConsulta.CurrentRow.Cells[2].Value.ToString(), IDProduto, int.Parse(DgConsulta.CurrentRow.Cells[24].Value.ToString()));

                            Decimal QtdeArmazenamento = Decimal.Subtract(quantidadearmazenamento, Decimal.Parse(Classes.Bioghet_Configuracao.Quantidade.ToString()));

                            int retornoarmazenamento = Classes.Bioghet_UpdateMYSQL.Update_ProdutoArmazenadoLoja(Int32.Parse(QtdeArmazenamento.ToString()), DgConsulta.CurrentRow.Cells[2].Value.ToString(), int.Parse(DgConsulta.CurrentRow.Cells[24].Value.ToString()), IDProduto);
                        }
                    }
                }

                if(e.ColumnIndex.Equals(33))
                {//28
                    int filial = Int32.Parse(CbFilial.Text.Remove(2));

                    if (filiallogado != filial)
                        throw new Exception("NÃO FOI POSSIVEL REALIZAR ALTERAÇÕES NA EMPRESA SELECIONADA, FAVOR EFETUE O LOGOFF E LOGUE NA FILIAL QUE DESEJA REALIZAR ALTERAÇÃO");


                    FrmLocalGuarda _Local = new FrmLocalGuarda();
                    _Local.Codigo = DgConsulta.CurrentRow.Cells[2].Value.ToString();
                    _Local.tipopecas = int.Parse(DgConsulta.CurrentRow.Cells[6].Value.ToString());
                    _Local.filial = int.Parse(DgConsulta.CurrentRow.Cells[24].Value.ToString());
                    _Local.IDProduto = int.Parse(DgConsulta.CurrentRow.Cells[25].Value.ToString());
                    _Local.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (String.IsNullOrWhiteSpace(TxDescricao.Text))
                    {
                        throw new Exception("FAVOR SELECIONAR UMA OPÇÃO PARA CONSULTA");
                    }
                    else
                    {
                        if (RdCodInterno.Checked)
                        {
                            Consultar(false, false, false, true, false);
                        }
                        else if (RdCodBarra.Checked)
                        {
                            Consultar(false, false, false, false, true);
                        }
                        else if (RdFilial.Checked)
                        {
                            Consultar(false, true, false, false, false);
                        }
                        else if (RdDescricao.Checked)
                        {
                            Consultar(true, false, false, false, false);
                        }
                        else
                        {
                            Consultar(false, false, true, false, false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void Consultar(Boolean Descricao, Boolean __Filial, Boolean Geral, Boolean CodigoInterno, Boolean CodigoBarra)
        {
            try
            {
                if (Descricao.Equals(true))
                {
                    DgConsulta.Rows.Clear();
                    List<bioghet_produto> _produto = Classes.Bioghet_ConsultaMysql.Listar_ProdutoLojaDigito(TxDescricao.Text, int.Parse(CbFilial.Text.Remove(2)));
                    String[] Param = new String[30];

                    for (int i = 0; i < _produto.Count; i++)
                    {
                        //Param[0] = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(_produto[i].Filial);
                        Param[0] = _produto[i].RazaoSocial;
                        Param[1] = _produto[i].Descricao;
                        Param[2] = _produto[i].CodigoInterno;
                        Param[3] = _produto[i].CodigoBarra;
                        Param[4] = _produto[i].Serial;
                        Param[5] = _produto[i].Lote;
                        Param[6] = _produto[i].TipoPeca.ToString();
                        Param[7] = _produto[i].Quantidade.ToString();
                        Param[8] = _produto[i].PrecoCusto.ToString("#####0.00");
                        Param[9] = _produto[i].PrecoVarejo.ToString("#####0.00");
                        Param[10] = _produto[i].PrecoAtacado.ToString("#####0.00");
                        Param[11] = _produto[i].DataCompra.ToString("dd-MM-yyyy");
                        Param[12] = _produto[i].Garantia.ToString();
                        Param[13] = _produto[i].FimGarantia.ToString("dd-MM-yyyy");
                        Param[14] = _produto[i].PVarejo.ToString();
                        Param[15] = _produto[i].PAtacado.ToString();
                        Param[16] = _produto[i].Aparelho.ToString();
                        Param[17] = _produto[i].Peca.ToString();
                        Param[18] = _produto[i].Novo.ToString();
                        Param[19] = _produto[i].Usado.ToString();
                        Param[20] = _produto[i].NTestada.ToString();
                        Param[21] = _produto[i].Defeito.ToString();
                        Param[22] = _produto[i].RetAparelho.ToString();
                        Param[23] = _produto[i].Testado.ToString();
                        Param[24] = _produto[i].Filial.ToString();
                        Param[25] = _produto[i].ID.ToString();
                        Param[26] = _produto[i].DolaVarejo.ToString("#####0.00");
                        Param[27] = _produto[i].DolaAtacado.ToString("#####0.00");
                        Param[28] = _produto[i].DolaCompra.ToString("#####0.00");
                        Param[29] = _produto[i].CambioDia.ToString("#####0.00");

                        DgConsulta.Rows.Add(Param);
                    }
                }

                if(__Filial.Equals(true))
                {
                    DgConsulta.Rows.Clear();
                    List<bioghet_produto> _produto = Classes.Bioghet_ConsultaMysql.Listar_ProdutoLojaFilial(int.Parse(CbFilial.Text.Remove(2)));
                    String[] Param = new String[30];

                    for (int i = 0; i < _produto.Count; i++)
                    {
                        Param[0] = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(_produto[i].Filial);
                        Param[1] = _produto[i].Descricao;
                        Param[2] = _produto[i].CodigoInterno;
                        Param[3] = _produto[i].CodigoBarra;
                        Param[4] = _produto[i].Serial;
                        Param[5] = _produto[i].Lote;
                        Param[6] = _produto[i].TipoPeca.ToString();
                        Param[7] = _produto[i].Quantidade.ToString();
                        Param[8] = _produto[i].PrecoCusto.ToString("#####0.00");
                        Param[9] = _produto[i].PrecoVarejo.ToString("#####0.00");
                        Param[10] = _produto[i].PrecoAtacado.ToString("#####0.00");
                        Param[11] = _produto[i].DataCompra.ToString("dd-MM-yyyy");
                        Param[12] = _produto[i].Garantia.ToString();
                        Param[13] = _produto[i].FimGarantia.ToString("dd-MM-yyyy");
                        Param[14] = _produto[i].PVarejo.ToString();
                        Param[15] = _produto[i].PAtacado.ToString();
                        Param[16] = _produto[i].Aparelho.ToString();
                        Param[17] = _produto[i].Peca.ToString();
                        Param[18] = _produto[i].Novo.ToString();
                        Param[19] = _produto[i].Usado.ToString();
                        Param[20] = _produto[i].NTestada.ToString();
                        Param[21] = _produto[i].Defeito.ToString();
                        Param[22] = _produto[i].RetAparelho.ToString();
                        Param[23] = _produto[i].Testado.ToString();
                        Param[24] = _produto[i].Filial.ToString();
                        Param[25] = _produto[i].ID.ToString();
                        Param[26] = _produto[i].DolaVarejo.ToString("#####0.00");
                        Param[27] = _produto[i].DolaAtacado.ToString("#####0.00");
                        Param[28] = _produto[i].DolaCompra.ToString("#####0.00");
                        Param[29] = _produto[i].CambioDia.ToString("#####0.00");

                        DgConsulta.Rows.Add(Param);
                    }
                }

                if (Geral.Equals(true))
                {
                    DgConsulta.Rows.Clear();
                    List<bioghet_produto> _produto = Classes.Bioghet_ConsultaMysql.Listar_ProdutoLoja();
                    String[] Param = new String[28];

                    for (int i = 0; i < _produto.Count; i++)
                    {
                        Param[0] = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(_produto[i].Filial);
                        Param[1] = _produto[i].Descricao;
                        Param[2] = _produto[i].CodigoInterno;
                        Param[3] = _produto[i].CodigoBarra;
                        Param[4] = _produto[i].Serial;
                        Param[5] = _produto[i].Lote;
                        Param[6] = _produto[i].TipoPeca.ToString();
                        Param[7] = _produto[i].Quantidade.ToString();
                        Param[8] = _produto[i].PrecoCusto.ToString("#####0.00");
                        Param[9] = _produto[i].PrecoVarejo.ToString("#####0.00");
                        Param[10] = _produto[i].PrecoAtacado.ToString("#####0.00");
                        Param[11] = _produto[i].DataCompra.ToString("dd-MM-yyyy");
                        Param[12] = _produto[i].Garantia.ToString();
                        Param[13] = _produto[i].FimGarantia.ToString("dd-MM-yyyy");
                        Param[14] = _produto[i].PVarejo.ToString();
                        Param[15] = _produto[i].PAtacado.ToString();
                        Param[16] = _produto[i].Aparelho.ToString();
                        Param[17] = _produto[i].Peca.ToString();
                        Param[18] = _produto[i].Novo.ToString();
                        Param[19] = _produto[i].Usado.ToString();
                        Param[20] = _produto[i].NTestada.ToString();
                        Param[21] = _produto[i].Defeito.ToString();
                        Param[22] = _produto[i].RetAparelho.ToString();
                        Param[23] = _produto[i].Testado.ToString();
                        Param[24] = _produto[i].Filial.ToString();
                        Param[25] = _produto[i].ID.ToString();
                        Param[26] = _produto[i].DolaVarejo.ToString("#####0.00");
                        Param[27] = _produto[i].DolaAtacado.ToString("#####0.00");

                        DgConsulta.Rows.Add(Param);
                    }
                }

                if(CodigoInterno.Equals(true))
                {
                    DgConsulta.Rows.Clear();
                    List<bioghet_produto> _produto = Classes.Bioghet_ConsultaMysql.Listar_ProdutoLojaCodigo(TxDescricao.Text, int.Parse(CbFilial.Text.Remove(2)));
                    String[] Param = new String[30];

                    for (int i = 0; i < _produto.Count; i++)
                    {
                        Param[0] = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(_produto[i].Filial);
                        Param[1] = _produto[i].Descricao;
                        Param[2] = _produto[i].CodigoInterno;
                        Param[3] = _produto[i].CodigoBarra;
                        Param[4] = _produto[i].Serial;
                        Param[5] = _produto[i].Lote;
                        Param[6] = _produto[i].TipoPeca.ToString();
                        Param[7] = _produto[i].Quantidade.ToString();
                        Param[8] = _produto[i].PrecoCusto.ToString("#####0.00");
                        Param[9] = _produto[i].PrecoVarejo.ToString("#####0.00");
                        Param[10] = _produto[i].PrecoAtacado.ToString("#####0.00");
                        Param[11] = _produto[i].DataCompra.ToString("dd-MM-yyyy");
                        Param[12] = _produto[i].Garantia.ToString();
                        Param[13] = _produto[i].FimGarantia.ToString("dd-MM-yyyy");
                        Param[14] = _produto[i].PVarejo.ToString();
                        Param[15] = _produto[i].PAtacado.ToString();
                        Param[16] = _produto[i].Aparelho.ToString();
                        Param[17] = _produto[i].Peca.ToString();
                        Param[18] = _produto[i].Novo.ToString();
                        Param[19] = _produto[i].Usado.ToString();
                        Param[20] = _produto[i].NTestada.ToString();
                        Param[21] = _produto[i].Defeito.ToString();
                        Param[22] = _produto[i].RetAparelho.ToString();
                        Param[23] = _produto[i].Testado.ToString();
                        Param[24] = _produto[i].Filial.ToString();
                        Param[25] = _produto[i].ID.ToString();
                        Param[26] = _produto[i].DolaVarejo.ToString("#####0.00");
                        Param[27] = _produto[i].DolaAtacado.ToString("#####0.00");
                        Param[28] = _produto[i].DolaCompra.ToString("#####0.00");
                        Param[29] = _produto[i].CambioDia.ToString("#####0.00");

                        DgConsulta.Rows.Add(Param);
                    }
                }

                if (CodigoBarra.Equals(true))
                {
                    DgConsulta.Rows.Clear();
                    List<bioghet_produto> _produto = Classes.Bioghet_ConsultaMysql.Listar_ProdutoCodigoBarra(TxDescricao.Text, int.Parse(CbFilial.Text.Remove(2)));
                    String[] Param = new String[30];

                    for (int i = 0; i < _produto.Count; i++)
                    {
                        Param[0] = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(_produto[i].Filial);
                        Param[1] = _produto[i].Descricao;
                        Param[2] = _produto[i].CodigoInterno;
                        Param[3] = _produto[i].CodigoBarra;
                        Param[4] = _produto[i].Serial;
                        Param[5] = _produto[i].Lote;
                        Param[6] = _produto[i].TipoPeca.ToString();
                        Param[7] = _produto[i].Quantidade.ToString();
                        Param[8] = _produto[i].PrecoCusto.ToString("#####0.00");
                        Param[9] = _produto[i].PrecoVarejo.ToString("#####0.00");
                        Param[10] = _produto[i].PrecoAtacado.ToString("#####0.00");
                        Param[11] = _produto[i].DataCompra.ToString("dd-MM-yyyy");
                        Param[12] = _produto[i].Garantia.ToString();
                        Param[13] = _produto[i].FimGarantia.ToString("dd-MM-yyyy");
                        Param[14] = _produto[i].PVarejo.ToString();
                        Param[15] = _produto[i].PAtacado.ToString();
                        Param[16] = _produto[i].Aparelho.ToString();
                        Param[17] = _produto[i].Peca.ToString();
                        Param[18] = _produto[i].Novo.ToString();
                        Param[19] = _produto[i].Usado.ToString();
                        Param[20] = _produto[i].NTestada.ToString();
                        Param[21] = _produto[i].Defeito.ToString();
                        Param[22] = _produto[i].RetAparelho.ToString();
                        Param[23] = _produto[i].Testado.ToString();
                        Param[24] = _produto[i].Filial.ToString();
                        Param[25] = _produto[i].ID.ToString();
                        Param[26] = _produto[i].DolaVarejo.ToString("#####0.00");
                        Param[27] = _produto[i].DolaAtacado.ToString("#####0.00");
                        Param[28] = _produto[i].DolaCompra.ToString("#####0.00");
                        Param[29] = _produto[i].CambioDia.ToString("#####0.00");

                        DgConsulta.Rows.Add(Param);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                for (int i = 0; i < DgConsulta.Rows.Count; i++)
                {
                    if (DgConsulta.Rows[i].Cells[7].Value.Equals("0"))
                    {
                        DgConsulta.Rows[i].Cells[7].Style.BackColor = Color.FromArgb(255, 192, 192);
                        //_Icon.Icon = new Icon(Environment.CurrentDirectory + "\\LGOTJ.ico");
                        //_Icon.Visible = true;
                        //_Icon.BalloonTipTitle = "BIOGHET - ATENÇÃO";
                        //_Icon.Text = "NOTIFICAÇÃO DE ALERTA";
                        //_Icon.BalloonTipText = "EXISTEM PRODUTOS COM ESTOQUE ZERADO, FAVOR VERIFIQUE";
                        //_Icon.ShowBalloonTip(0);
                    }
                    //else
                    //{
                    //    DgConsulta.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 185);
                    //}

                    if (DgConsulta.Rows[i].Cells[6].Value.Equals("1"))
                    {
                        DgConsulta.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(0, 192, 0);
                    }
                    else if (DgConsulta.Rows[i].Cells[6].Value.Equals("2"))
                    {
                        DgConsulta.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(192, 192, 0);
                    }
                    else if (DgConsulta.Rows[i].Cells[6].Value.Equals("3"))
                    {
                        DgConsulta.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(0, 192, 192);
                    }
                    else if (DgConsulta.Rows[i].Cells[6].Value.Equals("4"))
                    {
                        DgConsulta.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(255, 128, 128);
                    }


                }
            }
        }
        private void BtLocalizar_Click(object sender, EventArgs e)
        {
            try
            {

                if (RdCodInterno.Checked)
                {
                    Consultar(false, false, false, true, false);
                }
                else if (RdCodBarra.Checked)
                {
                    Consultar(false, false, false, false, true);
                }
                else if (RdFilial.Checked)
                {
                    Consultar(false, true, false, false, false);
                }
                else if (RdDescricao.Checked)
                {
                    Consultar(true, false, false, false, false);
                }
                else if (RdFilial.Checked)
                {
                    Consultar(false, true, false, false, false);
                }
                else
                {
                    throw new Exception("SELECIONE UMA OPÇÃO");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RdFilial_Click(object sender, EventArgs e)
        {
            CbFilial.Focus();
        }

        private void RdDescricao_Click(object sender, EventArgs e)
        {
            TxDescricao.Focus();
        }

        private void RdCodInterno_Click(object sender, EventArgs e)
        {
            TxDescricao.Focus();
        }

        private void RdCodBarra_Click(object sender, EventArgs e)
        {
           TxDescricao.Focus();
        }

        private void RdSerie_Click(object sender, EventArgs e)
        {
            TxDescricao.Focus();
        }

        private void RdLote_Click(object sender, EventArgs e)
        {
          

            TxDescricao.Focus();
        }

        private void RdTudo_Click(object sender, EventArgs e)
        {
            Consultar(false, false, true, false, false);

            TxDescricao.Focus();
        }

        private void CbFilial_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Consultar(false, true,false, false, false);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtFechar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (_venda.DgConsulta.Rows.Count != 0)
                {
                    Random _CupomVenda = new Random();
                    _venda.LbVenda.Text = _CupomVenda.Next(9999).ToString();
                    
                    
                    Decimal Total = 0;

                    foreach (DataGridViewRow col in _venda.DgConsulta.Rows)
                    {

                        Decimal Valor = Decimal.Parse(col.Cells[6].Value.ToString());
                        Total = Decimal.Add(Total, Valor);

                    }

                    Classes.Bioghet_Configuracao.venda = true;

                    _venda.LbTotalVenda.Text = Total.ToString("#####0.00");

                    _venda.ShowDialog();
                }
                else
                {
                    throw new Exception("NENHUM ITEM ADICIONADO AO CARRINHO DE COMPRA, FAVOR VERIFIQUE");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmConsultaProduto_Activated(object sender, EventArgs e)
        {
            try
            {
                LbCambio.Text = Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "cambiododia", "");

                if (Classes.Bioghet_Configuracao.FinalizarVenda == true)
                {
                    Classes.Bioghet_Configuracao.FinalizarVenda = false;
                    Classes.Bioghet_Configuracao.TotalItems = 0;
                    

                    DgConsulta.Rows.Clear();
                    List<bioghet_produto> _produto = Classes.Bioghet_ConsultaMysql.Listar_ProdutoLoja();
                    String[] Param = new String[26];

                    for (int i = 0; i < _produto.Count; i++)
                    {
                        Param[0] = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(_produto[i].Filial);
                        Param[1] = _produto[i].Descricao;
                        Param[2] = _produto[i].CodigoInterno;
                        Param[3] = _produto[i].CodigoBarra;
                        Param[4] = _produto[i].Serial;
                        Param[5] = _produto[i].Lote;
                        Param[6] = _produto[i].TipoPeca.ToString();
                        Param[7] = _produto[i].Quantidade.ToString();
                        Param[8] = _produto[i].PrecoCusto.ToString("#####0.00");
                        Param[9] = _produto[i].PrecoVarejo.ToString("#####0.00");
                        Param[10] = _produto[i].PrecoAtacado.ToString("#####0.00");
                        Param[11] = _produto[i].DataCompra.ToString("dd-MM-yyyy");
                        Param[12] = _produto[i].Garantia.ToString();
                        Param[13] = _produto[i].FimGarantia.ToString("dd-MM-yyyy");
                        Param[14] = _produto[i].PVarejo.ToString();
                        Param[15] = _produto[i].PAtacado.ToString();
                        Param[16] = _produto[i].Aparelho.ToString();
                        Param[17] = _produto[i].Peca.ToString();
                        Param[18] = _produto[i].Novo.ToString();
                        Param[19] = _produto[i].Usado.ToString();
                        Param[20] = _produto[i].NTestada.ToString();
                        Param[21] = _produto[i].Defeito.ToString();
                        Param[22] = _produto[i].RetAparelho.ToString();
                        Param[23] = _produto[i].Testado.ToString();
                        Param[24] = _produto[i].Filial.ToString();
                        Param[25] = _produto[i].ID.ToString();

                        DgConsulta.Rows.Add(Param);
                    }

                    List<Classes.Bioghet_Empresa> Lista = Classes.Bioghet_ConsultaMysql.Listar_Empresa();
                    CbFilial.Items.Clear();
                    for (int i = 0; i < Lista.Count; i++)
                    {
                        CbFilial.Items.Add(Lista[i].ID + " - " + Lista[i].RazaoSocial);
                    }

                    CbFilial.SelectedIndex = 0;
                }
                if (Classes.Bioghet_Configuracao.VendaExtornado == true)
                {
                    Classes.Bioghet_Configuracao.VendaExtornado = false;

                    Classes.Bioghet_Configuracao.TotalItems = 0;

                    DgConsulta.Rows.Clear();
                    List<bioghet_produto> _produto = Classes.Bioghet_ConsultaMysql.Listar_ProdutoLoja();
                    String[] Param = new String[26];

                    for (int i = 0; i < _produto.Count; i++)
                    {
                        Param[0] = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(_produto[i].Filial);
                        Param[1] = _produto[i].Descricao;
                        Param[2] = _produto[i].CodigoInterno;
                        Param[3] = _produto[i].CodigoBarra;
                        Param[4] = _produto[i].Serial;
                        Param[5] = _produto[i].Lote;
                        Param[6] = _produto[i].TipoPeca.ToString();
                        Param[7] = _produto[i].Quantidade.ToString();
                        Param[8] = _produto[i].PrecoCusto.ToString("#####0.00");
                        Param[9] = _produto[i].PrecoVarejo.ToString("#####0.00");
                        Param[10] = _produto[i].PrecoAtacado.ToString("#####0.00");
                        Param[11] = _produto[i].DataCompra.ToString("dd-MM-yyyy");
                        Param[12] = _produto[i].Garantia.ToString();
                        Param[13] = _produto[i].FimGarantia.ToString("dd-MM-yyyy");
                        Param[14] = _produto[i].PVarejo.ToString();
                        Param[15] = _produto[i].PAtacado.ToString();
                        Param[16] = _produto[i].Aparelho.ToString();
                        Param[17] = _produto[i].Peca.ToString();
                        Param[18] = _produto[i].Novo.ToString();
                        Param[19] = _produto[i].Usado.ToString();
                        Param[20] = _produto[i].NTestada.ToString();
                        Param[21] = _produto[i].Defeito.ToString();
                        Param[22] = _produto[i].RetAparelho.ToString();
                        Param[23] = _produto[i].Testado.ToString();
                        Param[24] = _produto[i].Filial.ToString();
                        Param[25] = _produto[i].ID.ToString();

                        DgConsulta.Rows.Add(Param);
                    }

                    List<Classes.Bioghet_Empresa> Lista = Classes.Bioghet_ConsultaMysql.Listar_Empresa();
                    CbFilial.Items.Clear();
                    for (int i = 0; i < Lista.Count; i++)
                    {
                        CbFilial.Items.Add(Lista[i].ID + " - " + Lista[i].RazaoSocial);
                    }

                    CbFilial.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                for (int i = 0; i < DgConsulta.Rows.Count; i++)
                {

                    if (DgConsulta.Rows[i].Cells[6].Value.Equals("1"))
                    {
                        DgConsulta.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(0, 192, 0);
                    }
                    else if (DgConsulta.Rows[i].Cells[6].Value.Equals("2"))
                    {
                        DgConsulta.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(192, 192, 0);
                    }
                    else if (DgConsulta.Rows[i].Cells[6].Value.Equals("3"))
                    {
                        DgConsulta.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(0, 192, 192);
                    }
                    else if (DgConsulta.Rows[i].Cells[6].Value.Equals("4"))
                    {
                        DgConsulta.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(255, 128, 128);
                    }
                }
            }
        }

        private void FrmConsultaProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //if (!LbTotalItems.Text.Equals("0"))
                //{
                //    this.Close();
                //}
                //else
                //{
                //    throw new Exception("EXISTEM VENDAS EM ABERTO FAVOR VERIFIQUE");
                //}

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtExtornar_Click(object sender, EventArgs e)
        {
            try
            {
                //Classes.Bioghet_Configuracao.Cupom = int.Parse(Interaction.InputBox("INFORME O NÚMERO DO CUPOM", "EXTORNAR VENDA", "1", 200, 200));

                //DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE EXTORNAR A VENDA DO CUPOM ==>" + Classes.Bioghet_Configuracao.Cupom.ToString() , "EXTORNAR VENDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //if (_pergunta == DialogResult.Yes)
                //{
                //    int retorno = Classes.Bioghet_DeleteMYSQL.Extornar_Venda(Classes.Bioghet_Configuracao.Cupom,"VC");

                //    if(retorno.Equals(1))
                //    {
                //        LbTotalItems.Text = "0";
                //        MessageBox.Show("VENDA EXTORNADA COM SUCESSO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //    else
                //    {
                //        throw new Exception("NÃO FOI POSSÍVEL REALIZAR O EXTORNO, FAVOR VERIFIQUE E TENTE NOVAMENTE");
                //    }
                //}
                FormExtorno extorno = new FormExtorno();
                extorno.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtRelatorios_Click(object sender, EventArgs e)
        {
            try
            {
                Button __Sender = (Button)sender;
                Point __PowerClique = new Point(0, __Sender.Height);
                __PowerClique = __Sender.PointToScreen(__PowerClique);
                MnuRelatorio.Show(__PowerClique);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool mouseClicked;
        Point clickedAt;
        private void FrmConsultaProduto_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void FrmConsultaProduto_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void FrmConsultaProduto_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FrmVendaRapida _venda = new FrmVendaRapida();
            _venda.Show();
        }

        private void DgConsulta_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    DialogResult _resultado = MessageBox.Show("DESEJA ALTERAR O PREÇO DO PRODUTO", "ALTERAÇÃO DE PREÇO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(_resultado == DialogResult.Yes)
                    {

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgConsulta_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if (e.KeyCode == Keys.Enter)
                //{
                //    DialogResult _resultado = MessageBox.Show("DESEJA ALTERAR O PREÇO DO PRODUTO", "ALTERAÇÃO DE PREÇO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //    if (_resultado == DialogResult.Yes)
                //    {

                //    }

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgConsulta_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int filial = Int32.Parse(CbFilial.Text.Remove(2));

                if (filiallogado != filial)
                    throw new Exception("NÃO FOI POSSIVEL REALIZAR ALTERAÇÕES NA EMPRESA SELECIONADA, FAVOR EFETUE O LOGOFF E LOGUE NA FILIAL QUE DESEJA REALIZAR ALTERAÇÃO");


                String Dolar = Microsoft.VisualBasic.Interaction.InputBox("POR FAVOR, INFORME O CAMBIO DO DIA E CLIQUE EM OK PARA PROSSEGUIR COM OS AJUSTES, PARA CANCELAR CLIQUE EM CANCELAR ", "ATENÇÃO", Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "cambiododia", ""), 200, 200);

                if (!String.IsNullOrWhiteSpace(Dolar))
                {
                    DialogResult perguntaAlt = MessageBox.Show("POR FAVOR CLIQUE EM SIM PARA AUMENTO DO DOLA OU EM NÃO SE O DOLA DIMINUIU?? ", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (perguntaAlt == DialogResult.Yes)
                    {
                        perguntaAlt = MessageBox.Show("DESEJA REALMENTE CONFIRMAR AS ALTERAÇÕES NO DÓLARR? ", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (perguntaAlt == DialogResult.Yes)
                        {
                            Ini.gravaarquivoini("geral", "cambiododia", Dolar);

                            LbCambio.Text = Dolar;

                            FrmProgresso _progress = new FrmProgresso();
                            _progress.setModo(1);
                            _progress.ShowDialog();
                        }
                     
                    }
                    //else
                    //{
                    //    perguntaAlt = MessageBox.Show("DESEJA REALMENTE CONFIRMAR AS ALTERAÇÕES NO DÓLARR? ", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //    if (perguntaAlt == DialogResult.Yes)
                    //    {
                    //        Ini.gravaarquivoini("geral", "cambiododia", Dolar);

                    //        LbCambio.Text = Dolar;

                    //        FrmProgresso _progress = new FrmProgresso();
                    //        _progress.setModo(2);
                    //        _progress.ShowDialog();
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRptVendas _relatoriodevendas = new FrmRptVendas();
            _relatoriodevendas.ShowDialog();
        }

        private void consultarOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioProduto frmRelatorio = new FrmRelatorioProduto();
            frmRelatorio.ShowDialog();
        }

        private void BtURL_Click(object sender, EventArgs e)
        {
            Form12 _frm = new Form12();
            _frm.Show();
        }

        private void FrmConsultaProduto_Shown(object sender, EventArgs e)
        {
            try
            {
                if (Classes.Bioghet_Configuracao.Funcao.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
                {
                    BtURL.Enabled = true;
                }
                else
                {
                    BtURL.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
