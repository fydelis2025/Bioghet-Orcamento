using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO;
using System.ServiceModel;
using System.Windows.Forms.Design.Behavior;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.Xml.Serialization;

namespace Bioghet_Orcamento
{
    public partial class FormCorreios : Form
    {
        public FormCorreios()
        {
            InitializeComponent();
        }

        StringBuilder Caminho = new StringBuilder();
        XmlDocument XmlDoc = new XmlDocument();
        String strServico = String.Empty;
        Int32 intFormato = 0;
        private void BtCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Caminho = new StringBuilder();
                XmlDoc = new XmlDocument();

                Caminho.Append("http://ws.correios.com.br/calculador/CalcPrecoPrazo.aspx?");
                Caminho.Append("nCdEmpresa=");
                Caminho.Append("&sDsSenha=");
                strServico = CbTipoEnvio.Text.Remove(5);
                Caminho.Append("&nCdServico=" + strServico);
                Caminho.Append("&sCepOrigem=" + TxCepOrigem.Text);
                Caminho.Append("&sCepDestino=" + TxCepDestino.Text);
                Caminho.Append("&nVlPeso=" + TxPeso.Text);
                intFormato = Int32.Parse(CbTipoDespacho.Text.Remove(2));
                Caminho.Append("&nCdFormato=" + intFormato);
                Caminho.Append("&nVlComprimento=" + Convert.ToDecimal(TxComprimento.Text));
                Caminho.Append("&nVlAltura=" + Convert.ToDecimal(TxAltura.Text));
                Caminho.Append("&nVlLargura=" + Convert.ToDecimal(TxLargura.Text));
                Caminho.Append("&nVlLargura=" + Convert.ToDecimal(TxDiametro.Text));
                if (ChEntrega.Checked.Equals(true))
                {
                    Caminho.Append("&sCdMaoPropria=s");
                }
                else
                {
                    Caminho.Append("&sCdMaoPropria=n");
                }
                Caminho.Append("&nVlValorDeclarado=" + Convert.ToDecimal(TxValor.Text));
                if(ChAviso.Checked.Equals(true))
                {
                    Caminho.Append("&sCdAvisoRecebimento=s");
                }
                else
                {
                    Caminho.Append("&sCdAvisoRecebimento=n");
                }
                Caminho.Append("&StrRetorno=xml");
                Caminho.Append("&nIndicaCalculo=3");

                XmlDoc.Load(Caminho.ToString());

                String Aviso = XmlDoc.InnerText;

                int retorno = Aviso.IndexOf(" ERP-008");
                int retorno1 = Aviso.IndexOf(" ERP-036");

                if (retorno1 != -1)
                {
                    String RetornoAviso = Aviso.Substring(30, retorno1);

                    throw new Exception(RetornoAviso);
                }

                if (retorno != -1)
                {
                    String RetornoAviso = Aviso.Substring(30, retorno);

                    throw new Exception(RetornoAviso);
                }

                XmlNodeList Frete = XmlDoc.GetElementsByTagName("Valor");
                XmlNodeList PrazoEntrega = XmlDoc.GetElementsByTagName("PrazoEntrega");

                lblPrazo.Text = "Prazo: " + PrazoEntrega.Item(0).InnerText;
                lblValor.Text = "Valor: " + Frete.Item(0).InnerText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCepOrigem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //var ws = new WSCorreios.AtendeClienteClient();
                    //var resposta = ws.consultaCEP(TxCepOrigem.Text);

                    //TxEnderecoOrigem.Text = resposta.end;
                    //TxComplementoOrigem.Text = resposta.complemento2;
                    //TxUFOigem.Text = resposta.uf;
                    //TxCidadeOrigem.Text = resposta.cidade;
                    //TxBairroOrigem.Text = resposta.bairro;
                    //WSCorreios.unidadePostagemERP[] postagem = resposta.unidadesPostagem;
                }
                                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCepDestino_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //var ws = new WSCorreios.AtendeClienteClient();
                    //var resposta = ws.consultaCEP(TxCepDestino.Text);

                    //TxEnderecoDestino.Text = resposta.end;
                    //TxComplementoDestino.Text = resposta.complemento2;
                    //TxUFDestino.Text = resposta.uf;
                    //TxCidadeDestino.Text = resposta.cidade;
                    //TxBairroDestino.Text = resposta.bairro;
                    //WSCorreios.unidadePostagemERP[] postagem = resposta.unidadesPostagem;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtRastreamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(TxRastreio.Text))
                {
                    WsCorreios.ServiceClient cliente = new WsCorreios.ServiceClient();

                    String[] Lista = { TxRastreio.Text };

                    var clientebehavior = new ClienteBehavior();
                    cliente.Endpoint.EndpointBehaviors.Add(clientebehavior);

                    WsCorreios.buscaEventosResponse resp = await cliente.buscaEventosAsync("ECT", "SRO", "L", "T", "101", TxRastreio.Text);
                    //TextReader leitura = new StringReader(result);

                    //DataSet Dt = new DataSet();
                    //Dt.ReadXml(leitura);

                    //DgRastreamento.DataSource = Dt.Tables[2];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class ClienteBehavior : IEndpointBehavior
        {
            public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
            {
                return;
            }

            public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
            {
                clientRuntime.ClientMessageInspectors.Add(new EndPointInspetor());
                clientRuntime.MessageInspectors.Add(new EndPointInspetor());
            }

            public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
            {
                ChannelDispatcher channelDispatcher = endpointDispatcher.ChannelDispatcher;
                if (channelDispatcher != null)
                {
                    foreach (EndpointDispatcher ed in channelDispatcher.Endpoints)
                    {
                        ed.DispatchRuntime.MessageInspectors.Add(new EndPointDispatchInspetor());
                    }
                }
            }

            public void Validate(ServiceEndpoint endpoint)
            {
                return;
            }

           
        }

        internal Classes.Bioghet_ProcuraDiaria _procuradiaria;
        private void BtNovaProcura_Click(object sender, EventArgs e)
        {
            try
            {
                _procuradiaria = null;

                TxCodigoProcura.ResetText();
                TxDescricaoProcura.ResetText();
                TxClienteProcura.ResetText();
                long numero = 71999999999;

                TxTelProcura.Text = numero.ToString(@"(00) 00000-0000");
                TxObservacao.ResetText();
                TxAtendente.ResetText();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtSalvarProcura_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrWhiteSpace(TxCodigoProcura.Text))
                {
                    throw new Exception("FAVO INFORMAR O CODIGO DO PRODUTO");
                }

                if(_procuradiaria == null)
                {
                    _procuradiaria = new Classes.Bioghet_ProcuraDiaria();
                    _procuradiaria.CodigoInterno = TxCodigoProcura.Text;
                    _procuradiaria.Descricao = TxDescricaoProcura.Text;
                    _procuradiaria.NomeCliente = TxClienteProcura.Text;
                    _procuradiaria.TelefoneCliente = TxTelProcura.Text;
                    _procuradiaria.Atendente = TxAtendente.Text;
                    _procuradiaria.OBS = TxObservacao.Text;
                    _procuradiaria.DataCriacao = DateTime.Parse(DtData.Text);

                    int retorno = Classes.Bioghet_InserirMYSQL.Criar_ProcuraDiaia(_procuradiaria);

                    if(retorno.Equals(1))
                    {
                        MessageBox.Show("SUCESSO", "CADASTRO REALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("ERRO AO REALIZAR O CADASTRO");
                    }
                }
                else
                {
                    _procuradiaria = new Classes.Bioghet_ProcuraDiaria();
                    _procuradiaria.CodigoInterno = TxCodigoProcura.Text;
                    _procuradiaria.Descricao = TxDescricaoProcura.Text;
                    _procuradiaria.NomeCliente = TxClienteProcura.Text;
                    _procuradiaria.TelefoneCliente = TxTelProcura.Text;
                    _procuradiaria.Atendente = TxAtendente.Text;
                    _procuradiaria.OBS = TxObservacao.Text;
                    _procuradiaria.DataCriacao = DateTime.Parse(DtData.Text);

                    int retorno = Classes.Bioghet_UpdateMYSQL.Aplicar_ProcuraDiaria(_procuradiaria);

                    if(retorno.Equals(1))
                    {
                        MessageBox.Show("SUCESSO", "ATUALIZAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("ERRO AO ATUALIZAR O CADASTRO");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgProcura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex.Equals(8))
                {
                    TxCodigoProcura.Text = DgProcura.CurrentRow.Cells[0].Value.ToString();
                    TxDescricaoProcura.Text = DgProcura.CurrentRow.Cells[1].Value.ToString();
                    TxClienteProcura.Text = DgProcura.CurrentRow.Cells[2].Value.ToString();
                    TxTelProcura.Text = DgProcura.CurrentRow.Cells[3].Value.ToString();
                    TxAtendente.Text = DgProcura.CurrentRow.Cells[4].Value.ToString();
                    DtData.Text = DgProcura.CurrentRow.Cells[5].Value.ToString();
                    ChAvisar.Checked = Boolean.Parse(DgProcura.CurrentRow.Cells[6].Value.ToString());
                    TxObservacao.Text = DgProcura.CurrentRow.Cells[7].Value.ToString();
                }

                if(e.ColumnIndex.Equals(9))
                {
                    DialogResult pergunta = MessageBox.Show("DESEJA REALMENTE EXCLUIR O ITEM", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if(pergunta == DialogResult.Yes)
                    {
                        int retorno = Classes.Bioghet_DeleteMYSQL.Deletar_ProcuraDiaria(DgProcura.CurrentRow.Cells[0].Value.ToString());
                        if(retorno.Equals(1))
                        {
                            MessageBox.Show("ITEM DELETADO COM SUCESSO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("ERRO AO DELETAR O ITEM");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal List<Classes.Bioghet_ProcuraDiaria> _ListarProcura;
        internal List<Classes.Bioghet_Encomenda> _ListarEncomenda;
        private void BtBuscarProcura_Click(object sender, EventArgs e)
        {
            try
            {
                DgProcura.Rows.Clear();
                String[] Param = new String[8];

                if (!String.IsNullOrWhiteSpace(TxCodigoProcura.Text))
                {
                    _ListarProcura = Classes.Bioghet_ConsultaMysql.Listar_ProcuraDiariaCodigo(TxCodigoProcura.Text);
                    for (int i = 0; i < _ListarProcura.Count; i++)
                    {
                        Param[0] = _ListarProcura[i].CodigoInterno;
                        Param[1] = _ListarProcura[i].Descricao;
                        Param[2] = _ListarProcura[i].NomeCliente;
                        Param[3] = _ListarProcura[i].TelefoneCliente;
                        Param[4] = _ListarProcura[i].Atendente;
                        Param[5] = _ListarProcura[i].DataCriacao.ToString("dd-MM-yyyy");
                        Param[6] = _ListarProcura[i].Aviso.ToString();
                        Param[7] = _ListarProcura[i].OBS;

                        DgProcura.Rows.Add(Param);
                    }
                }
                else
                {
                    _ListarProcura = Classes.Bioghet_ConsultaMysql.Listar_ProcuraDiariaCodigo("");
                    for (int i = 0; i < _ListarProcura.Count; i++)
                    {
                        Param[0] = _ListarProcura[i].CodigoInterno;
                        Param[1] = _ListarProcura[i].Descricao;
                        Param[2] = _ListarProcura[i].NomeCliente;
                        Param[3] = _ListarProcura[i].TelefoneCliente;
                        Param[4] = _ListarProcura[i].Atendente;
                        Param[5] = _ListarProcura[i].DataCriacao.ToString("dd-MM-yyyy");
                        Param[6] = _ListarProcura[i].Aviso.ToString();
                        Param[7] = _ListarProcura[i].OBS;

                        DgProcura.Rows.Add(Param);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao.ProcuraDiaria = true;

                Form15 frm15 = new Form15();
                frm15.ShowDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void FormCorreios_Activated(object sender, EventArgs e)
        {
            try
            {
                if(Classes.Bioghet_Configuracao.ProcuraDiaria.Equals(true))
                {
                    Classes.Bioghet_Configuracao.ProcuraDiaria = false;
                    TxCodigoProcura.Text = Classes.Bioghet_Configuracao.CodigoProduto;
                    TxDescricaoProcura.Text = Classes.Bioghet_Configuracao.DescricaoProduto;
                    TxClienteProcura.Focus();
                }

                if(Classes.Bioghet_Configuracao.Encomenda.Equals(true))
                {
                    Classes.Bioghet_Configuracao.Encomenda = false;
                    TxCodigoProduto.Text = Classes.Bioghet_Configuracao.CodigoProduto;
                    TxDescricaoProduto.Text = Classes.Bioghet_Configuracao.DescricaoProduto;
                    TxPeca.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao.Encomenda = true;

                Form15 frm15 = new Form15();
                frm15.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCorreios_Load(object sender, EventArgs e)
        {
            try
            {
                long numero = 71999999999;

                TxTelProcura.Text = numero.ToString(@"(00) 00000-0000");
                TxTelefone.Text = numero.ToString(@"(00) 00000-0000");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxTelProcura_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                long numero = 71999999999;

                TxTelProcura.Text = numero.ToString(@"(00) 00000-0000");
            }
        }

        private void TxTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                long numero = 71999999999;

                TxTelefone.Text = numero.ToString(@"(00) 00000-0000");
            }
        }

        private Classes.Bioghet_Encomenda _encomenda;
        private void BtNovaEncomenda_Click(object sender, EventArgs e)
        {
            try
            {
                _encomenda = null;
                TxCodigoProduto.ResetText();
                TxDescricaoProduto.ResetText();
                TxPeca.ResetText();
                TxCaracteristicas.ResetText();
                TxValorEncomenda.Text = "0,00";
                TxVendedor.ResetText();
                TxNomeCliente.ResetText();
                ChPago.Checked = false;
                ChEntrega.Checked = false;
                ChAtrasado.Checked = false;

                long numero = 71999999999;

                TxTelefone.Text = numero.ToString(@"(00) 00000-0000");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtSalvarEncomenda_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrWhiteSpace(TxCodigoProduto.Text))
                {
                    throw new Exception("POR FAVOR INFORME O CODIGO DO PRODUTO");
                }

                if(_encomenda == null)
                {
                    _encomenda = new Classes.Bioghet_Encomenda();
                    _encomenda.CodigoInterno = TxCodigoProduto.Text;
                    _encomenda.Descricao = TxDescricaoProduto.Text;
                    _encomenda.NumeroPeca = TxPeca.Text;
                    _encomenda.Caracteristicas = TxCaracteristicas.Text;
                    _encomenda.Valor = Decimal.Parse(TxValorEncomenda.Text);
                    _encomenda.FormaPagamento = CbFormaPagamento.Text;
                    _encomenda.DataPedido = DateTime.Parse(DtPedido.Text);
                    _encomenda.Prazo = DateTime.Parse(DtPrazo.Text);
                    _encomenda.Vendedor = TxVendedor.Text;
                    _encomenda.Cliente = TxNomeCliente.Text;
                    _encomenda.Telefone = TxTelefone.Text;
                    _encomenda.Pago = ChPago.Checked;
                    _encomenda.Entregue = ChEntrega.Checked;
                    _encomenda.Atrasado = ChAtrasado.Checked;

                    Int32 retorno = Classes.Bioghet_InserirMYSQL.Criar_Encomenda(_encomenda);

                    if (retorno.Equals(1))
                    {
                        MessageBox.Show("SUCESSO", "CADASTRO REALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("ERRO AO REALIZAR O CADASTRO");
                    }
                }
                else
                {
                    _encomenda.CodigoInterno = TxCodigoProduto.Text;
                    _encomenda.Descricao = TxDescricaoProduto.Text;
                    _encomenda.NumeroPeca = TxPeca.Text;
                    _encomenda.Caracteristicas = TxCaracteristicas.Text;
                    _encomenda.Valor = Decimal.Parse(TxValorEncomenda.Text);
                    _encomenda.FormaPagamento = CbFormaPagamento.Text;
                    _encomenda.DataPedido = DateTime.Parse(DtPedido.Text);
                    _encomenda.Prazo = DateTime.Parse(DtPrazo.Text);
                    _encomenda.Vendedor = TxVendedor.Text;
                    _encomenda.Cliente = TxNomeCliente.Text;
                    _encomenda.Telefone = TxTelefone.Text;
                    _encomenda.Pago = ChPago.Checked;
                    _encomenda.Entregue = ChEntrega.Checked;
                    _encomenda.Atrasado = ChAtrasado.Checked;

                    Int32 retorno = Classes.Bioghet_UpdateMYSQL.Aplicar_Encomenda(_encomenda);

                    if (retorno.Equals(1))
                    {
                        MessageBox.Show("SUCESSO", "CADASTRO REALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("ERRO AO REALIZAR O CADASTRO");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal NotifyIcon _Icon = new NotifyIcon();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DgEncomenda.Rows.Clear();
                String[] Param = new String[14];

                if (!String.IsNullOrWhiteSpace(TxCodigoProcura.Text))
                {
                    _ListarEncomenda = Classes.Bioghet_ConsultaMysql.Listar_Encomenda(TxCodigoProduto.Text);

                    for(int i = 0; i < _ListarEncomenda.Count; i++)
                    {
                        Param[0] = _ListarEncomenda[i].CodigoInterno;
                        Param[1] = _ListarEncomenda[i].Descricao;
                        Param[2] = _ListarEncomenda[i].NumeroPeca;
                        Param[3] = _ListarEncomenda[i].Caracteristicas;
                        Param[4] = _ListarEncomenda[i].Valor.ToString("#####0.00");
                        Param[5] = _ListarEncomenda[i].FormaPagamento;
                        Param[6] = _ListarEncomenda[i].DataPedido.ToString();
                        Param[7] = _ListarEncomenda[i].Prazo.ToString();
                        Param[8] = _ListarEncomenda[i].Vendedor;
                        Param[9] = _ListarEncomenda[i].Cliente;
                        Param[10] = _ListarEncomenda[i].Telefone;
                        Param[11] = _ListarEncomenda[i].Pago.ToString();
                        Param[12] = _ListarEncomenda[i].Entregue.ToString();
                        Param[13] = _ListarEncomenda[i].Atrasado.ToString();

                        DgEncomenda.Rows.Add(Param);

                     }
                }
                else
                {
                    _ListarEncomenda = Classes.Bioghet_ConsultaMysql.Listar_Encomenda("");

                    for (int i = 0; i < _ListarEncomenda.Count; i++)
                    {
                        Param[0] = _ListarEncomenda[i].CodigoInterno;
                        Param[1] = _ListarEncomenda[i].Descricao;
                        Param[2] = _ListarEncomenda[i].NumeroPeca;
                        Param[3] = _ListarEncomenda[i].Caracteristicas;
                        Param[4] = _ListarEncomenda[i].Valor.ToString("#####0.00");
                        Param[5] = _ListarEncomenda[i].FormaPagamento;
                        Param[6] = _ListarEncomenda[i].DataPedido.ToString();
                        Param[7] = _ListarEncomenda[i].Prazo.ToString();
                        Param[8] = _ListarEncomenda[i].Vendedor;
                        Param[9] = _ListarEncomenda[i].Cliente;
                        Param[10] = _ListarEncomenda[i].Telefone;
                        Param[11] = _ListarEncomenda[i].Pago.ToString();
                        Param[12] = _ListarEncomenda[i].Entregue.ToString();
                        Param[13] = _ListarEncomenda[i].Atrasado.ToString();

                        DgEncomenda.Rows.Add(Param);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
            }
        }

        private void DgEncomenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex.Equals(14))
                {
                    TxCodigoProduto.Text = DgEncomenda.CurrentRow.Cells[0].Value.ToString();
                    TxDescricaoProduto.Text = DgEncomenda.CurrentRow.Cells[1].Value.ToString();
                    TxPeca.Text = DgEncomenda.CurrentRow.Cells[2].Value.ToString();
                    TxCaracteristicas.Text = DgEncomenda.CurrentRow.Cells[3].Value.ToString();
                    TxValor.Text = DgEncomenda.CurrentRow.Cells[4].Value.ToString();
                    CbFormaPagamento.Text = DgEncomenda.CurrentRow.Cells[5].Value.ToString();
                    DtData.Text = DgEncomenda.CurrentRow.Cells[6].Value.ToString();
                    DtPrazo.Text = DgEncomenda.CurrentRow.Cells[7].Value.ToString();
                    TxVendedor.Text = DgEncomenda.CurrentRow.Cells[8].Value.ToString();
                    TxNomeCliente.Text = DgEncomenda.CurrentRow.Cells[9].Value.ToString();
                    TxTelefone.Text = DgEncomenda.CurrentRow.Cells[10].Value.ToString();
                    ChPago.Checked = Boolean.Parse(DgEncomenda.CurrentRow.Cells[11].Value.ToString());
                    ChEntrega.Checked = Boolean.Parse(DgEncomenda.CurrentRow.Cells[12].Value.ToString());
                    ChAtrasado.Checked = Boolean.Parse(DgEncomenda.CurrentRow.Cells[13].Value.ToString());
                }

                if(e.ColumnIndex.Equals(15))
                {
                    DialogResult pergunta = MessageBox.Show("DESEJA REALMENETE EXCLUIR O ITEM SELECIONADO", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(pergunta == DialogResult.Yes)
                    {
                        int retorno = Classes.Bioghet_DeleteMYSQL.Deletar_Encomenda(DgEncomenda.CurrentRow.Cells[0].Value.ToString());

                        if (retorno.Equals(1))
                        {
                            MessageBox.Show("ITEM DELETADO COM SUCESSO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("ERRO AO DELETAR O ITEM");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    internal class EndPointInspetor : IClientMessageInspector
    {
        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            var Retorno = reply;
            
        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel)
        {

            //XmlSerializer ser = new XmlSerializer(request.GetReaderAtBodyContents.result);

            
            //var retorno = request.WriteBody;
            return request;
        }
    }

    public class EndPointDispatchInspetor : IDispatchMessageInspector
    {
        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            Console.WriteLine("Incoming request: {0}", request);
            return null;
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            //throw new NotImplementedException();
        }
    }
    internal class ClienteBehaviorExtensionElement:BehaviorExtensionElement
    {
        protected override object CreateBehavior()
        {
            return new FormCorreios.ClienteBehavior();
        }

        public override Type BehaviorType
        {
            get
            {
                return typeof(FormCorreios.ClienteBehavior);
            }
        }
    }

}
