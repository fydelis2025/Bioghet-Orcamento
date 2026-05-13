using Bioghet_Orcamento.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class FrmContas : Form
    {
        public FrmContas()
        {
            InitializeComponent();
        }

        private void CbCredor_Click(object sender, EventArgs e)
        {
            try
            {
                CbCredor.Items.Clear();
                List<Classes.Bioghet_Credores> _Credor = Classes.Bioghet_ConsultaMysql.Listar_Credores();
                for(int i = 0; i < _Credor.Count; i++)
                {
                    CbCredor.Items.Add(_Credor[i].ID + " - " + _Credor[i].Descricao);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbTipoConta_Click(object sender, EventArgs e)
        {
            try
            {
                CbTipoConta.Items.Clear();

                List<Classes.Bioghet_TipoPagamento> ListarTipoPagamento = Classes.Bioghet_ConsultaMysql.Listar_TipoPagamento();
                for(int i  = 0; i < ListarTipoPagamento.Count; i++)
                {
                    CbTipoConta.Items.Add(ListarTipoPagamento[i].ID + " - " + ListarTipoPagamento[i].Descricao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbContas_Click(object sender, EventArgs e)
        {
            try
            {
                CbContas.Items.Clear();

                List<Classes.Bioghet_Bancos> ListarBancos = Classes.Bioghet_ConsultaMysql.Listar_Bancos();
                for(int i = 0; i < ListarBancos.Count; i++)
                {
                    CbContas.Items.Add(ListarBancos[i].CodigoAgencia + " - " + ListarBancos[i].Descricao);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxNumeoDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxNotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxValorDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxValorPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxJuros_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ChGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if(ChGerar.Checked.Equals(true))
                {
                    Random _numeroDocumento = new Random();
                    TxNumeoDocumento.Text = _numeroDocumento.Next(999999999).ToString();
                }
                else
                {
                    TxNumeoDocumento.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtPasta_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog File = new OpenFileDialog();
                File.Filter = "Arquivos (*.pdf)|*.pdf";
                if (File.ShowDialog() == DialogResult.OK)
                {
                    TxCaminho.Text = File.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal Classes.Bioghet_ContasPagar _contaspagar;
        private void BtIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                _contaspagar = null;
                TxNumeoDocumento.Text = "0";
                TxNotaFiscal.Text = "0";
                TxValorDocumento.Text = "0,00";
                TxValorPagar.Text = "0,00";
                TxJuros.Text = "0,00";
                TxDesconto.Text = "0,00";
                CbParcelas.ResetText();
                CbPagamento.ResetText();
                TxSacado.ResetText();
                TxCaminho.ResetText();
                CbTipo.ResetText();
                CbCredor.ResetText();
                CbTipoConta.ResetText();
                CbContas.ResetText();

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
                if(String.IsNullOrWhiteSpace(TxNumeoDocumento.Text))
                {
                    throw new Exception("FAVOR INFORMAR O NUMERO DO DOCUMENTO, CAMPO OBRIGATORIO");
                }

                if(_contaspagar == null)
                {
                    _contaspagar = new Classes.Bioghet_ContasPagar();
                    _contaspagar.Tipo = CbTipo.Text;
                    _contaspagar.Documento = TxNumeoDocumento.Text;
                    _contaspagar.DataLancamento = DateTime.Parse(DtLancamento.Text);
                    _contaspagar.DataVencimento = DateTime.Parse(DtVencimento.Text);
                    _contaspagar.NotaFiscal = TxNotaFiscal.Text;
                    _contaspagar.Credor = Int32.Parse(CbCredor.Text.Remove(2));
                    _contaspagar.TipoPagamento = Int32.Parse(CbTipoConta.Text.Remove(2));
                    _contaspagar.CodigoBanco = CbContas.Text.Remove(3);
                    _contaspagar.ValoraPagar = Decimal.Parse(TxValorDocumento.Text);
                    _contaspagar.ValorPago = Decimal.Parse(TxValorPagar.Text);
                    _contaspagar.Juros = Decimal.Parse(TxJuros.Text);
                    _contaspagar.Desconto = Decimal.Parse(TxDesconto.Text);
                    _contaspagar.Parcelas = Int32.Parse(CbParcelas.Text);
                    _contaspagar.DataPagamento = DateTime.Parse(DtPagamento.Text);
                    _contaspagar.FormaPagamento = CbPagamento.Text;
                    _contaspagar.Sacado = TxSacado.Text;
                    _contaspagar.CaminhoArquivo = TxCaminho.Text;
                    _contaspagar.Finalizado = ChFinalizado.Checked;
                    _contaspagar.DataCriacao = DateTime.Now;
                    _contaspagar.Usuario = Classes.Bioghet_Configuracao.Usuario;

                    Classes.Bioghet_InserirMYSQL.Criar_PlanoContas(_contaspagar);

                    MessageBox.Show("CADASTRO CRIADO COM SUCESSO","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else
                {
                    _contaspagar.Tipo = CbTipo.Text;
                    _contaspagar.Documento = TxNumeoDocumento.Text;
                    _contaspagar.DataLancamento = DateTime.Parse(DtLancamento.Text);
                    _contaspagar.DataVencimento = DateTime.Parse(DtVencimento.Text);
                    _contaspagar.NotaFiscal = TxNotaFiscal.Text;
                    _contaspagar.Credor = Int32.Parse(CbCredor.Text.Remove(2));
                    _contaspagar.TipoPagamento = Int32.Parse(CbTipoConta.Text.Remove(2));
                    _contaspagar.CodigoBanco = CbContas.Text.Remove(3);
                    _contaspagar.ValoraPagar = Decimal.Parse(TxValorDocumento.Text);
                    _contaspagar.ValorPago = Decimal.Parse(TxValorPagar.Text);
                    _contaspagar.Juros = Decimal.Parse(TxJuros.Text);
                    _contaspagar.Desconto = Decimal.Parse(TxDesconto.Text);
                    _contaspagar.Parcelas = Int32.Parse(CbParcelas.Text);
                    _contaspagar.DataPagamento = DateTime.Parse(DtPagamento.Text);
                    _contaspagar.FormaPagamento = CbPagamento.Text;
                    _contaspagar.Sacado = TxSacado.Text;
                    _contaspagar.CaminhoArquivo = TxCaminho.Text;
                    _contaspagar.Finalizado = ChFinalizado.Checked;
                    _contaspagar.DataCriacao = DateTime.Now;
                    _contaspagar.Usuario = Classes.Bioghet_Configuracao.Usuario;

                    int retorno = Classes.Bioghet_UpdateMYSQL.Aplicar_PlanodeContas(_contaspagar);

                    if(retorno.Equals(1))
                    {
                        MessageBox.Show("CADASTRO ATUALIZADO COM SUCESSO");
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

        private void BtParcelas_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_ParcelasPlanoContas _planocontas = new Classes.Bioghet_ParcelasPlanoContas();

                var parcela = Convert.ToInt32(CbParcelas.Text);
                var juros = Decimal.Parse(TxJuros.Text);
                var valorTotal = Convert.ToDecimal(TxValorDocumento.Text);
                var vencimento = Convert.ToDateTime(DtVencimento.Text);
                var Valorjuros = valorTotal * juros / 100;
                var Soma = valorTotal + Valorjuros;
                var resultado = Soma / parcela;

                parcela = Convert.ToInt32(CbParcelas.Text);

                for (var i = 0; i < parcela; i++)
                {
                    DgParcelas.Rows.Add(new object[] {i +1, CbCredor.Text.Remove(2), vencimento.AddMonths(i + 1).ToString("dd/MM/yy"), resultado.ToString("#####0.00") });

                    _planocontas.Parcelas = i + 1;
                    _planocontas.Descricao = CbCredor.Text;
                    _planocontas.Vencimento = vencimento;
                    _planocontas.Valor = resultado;

                    Classes.Bioghet_InserirMYSQL.Criar_ParcelaPlanoContas(_planocontas);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DgContas.Rows.Clear();
                String[] Param = new String[21];

                if (CbVwTipo.Text == "CONTA A PAGAR")
                {
                    if (!String.IsNullOrWhiteSpace(TxBuscar.Text))
                    {
                        if (ChContasVencidas.Checked.Equals(true))
                        {
                            List<Classes.Bioghet_ContasPagar> _ContasPagars = Classes.Bioghet_ConsultaMysql.Listar_ContasVencidas(CbVwTipo.Text, TxBuscar.Text);

                            for(int i = 0; i < _ContasPagars.Count;i++)
                            {
                                Param[0] = _ContasPagars[i].ID.ToString();
                                Param[1] = _ContasPagars[i].Tipo;
                                Param[2] = _ContasPagars[i].Documento;
                                Param[3] = _ContasPagars[i].DataLancamento.ToString("dd-MM-yyyy");
                                Param[4] = _ContasPagars[i].DataVencimento.ToString("dd-MM-yyyy");
                                Param[5] = _ContasPagars[i].Desconto.ToString();
                                Param[6] = _ContasPagars[i].Juros.ToString();
                                Param[7] = _ContasPagars[i].NotaFiscal;
                                Param[8] = _ContasPagars[i].Sacado;
                                Param[9] = _ContasPagars[i].ValoraPagar.ToString("#####0.00");
                                Param[10] = _ContasPagars[i].ValorPago.ToString("#####0.00");
                                Param[11] = _ContasPagars[i].DataPagamento.ToString("dd-MM-yyyy");
                                Param[12] = _ContasPagars[i].FormaPagamento.ToString();
                                Param[13] = _ContasPagars[i].TipoPagamento.ToString();
                                Param[14] = _ContasPagars[i].Parcelas.ToString();
                                Param[15] = _ContasPagars[i].Finalizado.ToString();
                                Param[16] = _ContasPagars[i].DataCriacao.ToString("dd-MM-yyyy");
                                Param[17] = _ContasPagars[i].Usuario.ToString();
                                Param[18] = _ContasPagars[i].CaminhoArquivo;
                                Param[19] = _ContasPagars[i].Favorecido.ToString();
                                Param[20] = _ContasPagars[i].Credor.ToString();

                                DgContas.Rows.Add(Param);
                            }
                        }

                        if(ChContasaVencer.Checked.Equals(true))
                        {
                            List<Classes.Bioghet_ContasPagar> _ContasPagars = Classes.Bioghet_ConsultaMysql.Listar_ContasaVencer(CbVwTipo.Text, TxBuscar.Text);
                            for (int i = 0; i < _ContasPagars.Count; i++)
                            {
                                Param[0] = _ContasPagars[i].ID.ToString();
                                Param[1] = _ContasPagars[i].Tipo;
                                Param[2] = _ContasPagars[i].Documento;
                                Param[3] = _ContasPagars[i].DataLancamento.ToString("dd-MM-yyyy");
                                Param[4] = _ContasPagars[i].DataVencimento.ToString("dd-MM-yyyy");
                                Param[5] = _ContasPagars[i].Desconto.ToString();
                                Param[6] = _ContasPagars[i].Juros.ToString();
                                Param[7] = _ContasPagars[i].NotaFiscal;
                                Param[8] = _ContasPagars[i].Sacado;
                                Param[9] = _ContasPagars[i].ValoraPagar.ToString("#####0.00");
                                Param[10] = _ContasPagars[i].ValorPago.ToString("#####0.00");
                                Param[11] = _ContasPagars[i].DataPagamento.ToString("dd-MM-yyyy");
                                Param[12] = _ContasPagars[i].FormaPagamento.ToString();
                                Param[13] = _ContasPagars[i].TipoPagamento.ToString();
                                Param[14] = _ContasPagars[i].Parcelas.ToString();
                                Param[15] = _ContasPagars[i].Finalizado.ToString();
                                Param[16] = _ContasPagars[i].DataCriacao.ToString("dd-MM-yyyy");
                                Param[17] = _ContasPagars[i].Usuario.ToString();
                                Param[18] = _ContasPagars[i].CaminhoArquivo;
                                Param[19] = _ContasPagars[i].Favorecido.ToString();
                                Param[20] = _ContasPagars[i].Credor.ToString();

                                DgContas.Rows.Add(Param);
                            }
                        }
                        
                    }
                    else
                    {
                        if (ChContasVencidas.Checked.Equals(true))
                        {
                            List<Classes.Bioghet_ContasPagar> _ContasPagars = Classes.Bioghet_ConsultaMysql.Listar_ContasVencidas(CbVwTipo.Text, "");
                            for (int i = 0; i < _ContasPagars.Count; i++)
                            {
                                Param[0] = _ContasPagars[i].ID.ToString();
                                Param[1] = _ContasPagars[i].Tipo;
                                Param[2] = _ContasPagars[i].Documento;
                                Param[3] = _ContasPagars[i].DataLancamento.ToString("dd-MM-yyyy");
                                Param[4] = _ContasPagars[i].DataVencimento.ToString("dd-MM-yyyy");
                                Param[5] = _ContasPagars[i].Desconto.ToString();
                                Param[6] = _ContasPagars[i].Juros.ToString();
                                Param[7] = _ContasPagars[i].NotaFiscal;
                                Param[8] = _ContasPagars[i].Sacado;
                                Param[9] = _ContasPagars[i].ValoraPagar.ToString("#####0.00");
                                Param[10] = _ContasPagars[i].ValorPago.ToString("#####0.00");
                                Param[11] = _ContasPagars[i].DataPagamento.ToString("dd-MM-yyyy");
                                Param[12] = _ContasPagars[i].FormaPagamento.ToString();
                                Param[13] = _ContasPagars[i].TipoPagamento.ToString();
                                Param[14] = _ContasPagars[i].Parcelas.ToString();
                                Param[15] = _ContasPagars[i].Finalizado.ToString();
                                Param[16] = _ContasPagars[i].DataCriacao.ToString("dd-MM-yyyy");
                                Param[17] = _ContasPagars[i].Usuario.ToString();
                                Param[18] = _ContasPagars[i].CaminhoArquivo;
                                Param[19] = _ContasPagars[i].Favorecido.ToString();
                                Param[20] = _ContasPagars[i].Credor.ToString();

                                DgContas.Rows.Add(Param);
                            }
                        }

                        if (ChContasaVencer.Checked.Equals(true))
                        {
                            List<Classes.Bioghet_ContasPagar> _ContasPagars = Classes.Bioghet_ConsultaMysql.Listar_ContasaVencer(CbVwTipo.Text, "");
                            for (int i = 0; i < _ContasPagars.Count; i++)
                            {
                                Param[0] = _ContasPagars[i].ID.ToString();
                                Param[1] = _ContasPagars[i].Tipo;
                                Param[2] = _ContasPagars[i].Documento;
                                Param[3] = _ContasPagars[i].DataLancamento.ToString("dd-MM-yyyy");
                                Param[4] = _ContasPagars[i].DataVencimento.ToString("dd-MM-yyyy");
                                Param[5] = _ContasPagars[i].Desconto.ToString();
                                Param[6] = _ContasPagars[i].Juros.ToString();
                                Param[7] = _ContasPagars[i].NotaFiscal;
                                Param[8] = _ContasPagars[i].Sacado;
                                Param[9] = _ContasPagars[i].ValoraPagar.ToString("#####0.00");
                                Param[10] = _ContasPagars[i].ValorPago.ToString("#####0.00");
                                Param[11] = _ContasPagars[i].DataPagamento.ToString("dd-MM-yyyy");
                                Param[12] = _ContasPagars[i].FormaPagamento.ToString();
                                Param[13] = _ContasPagars[i].TipoPagamento.ToString();
                                Param[14] = _ContasPagars[i].Parcelas.ToString();
                                Param[15] = _ContasPagars[i].Finalizado.ToString();
                                Param[16] = _ContasPagars[i].DataCriacao.ToString("dd-MM-yyyy");
                                Param[17] = _ContasPagars[i].Usuario.ToString();
                                Param[18] = _ContasPagars[i].CaminhoArquivo;
                                Param[19] = _ContasPagars[i].Favorecido.ToString();
                                Param[20] = _ContasPagars[i].Credor.ToString();

                                DgContas.Rows.Add(Param);
                            }
                        }
                    }
                }
                else if (CbVwTipo.Text == "CONTA A RECEBER")
                {
                    if (!String.IsNullOrWhiteSpace(TxBuscar.Text))
                    {
                        if (ChContasVencidas.Checked.Equals(true))
                        {
                            List<Classes.Bioghet_ContasPagar> _ContasPagars = Classes.Bioghet_ConsultaMysql.Listar_ContasVencidas(CbVwTipo.Text, TxBuscar.Text);

                            for (int i = 0; i < _ContasPagars.Count; i++)
                            {
                                Param[0] = _ContasPagars[i].ID.ToString();
                                Param[1] = _ContasPagars[i].Tipo;
                                Param[2] = _ContasPagars[i].Documento;
                                Param[3] = _ContasPagars[i].DataLancamento.ToString("dd-MM-yyyy");
                                Param[4] = _ContasPagars[i].DataVencimento.ToString("dd-MM-yyyy");
                                Param[5] = _ContasPagars[i].Desconto.ToString();
                                Param[6] = _ContasPagars[i].Juros.ToString();
                                Param[7] = _ContasPagars[i].NotaFiscal;
                                Param[8] = _ContasPagars[i].Sacado;
                                Param[9] = _ContasPagars[i].ValoraPagar.ToString("#####0.00");
                                Param[10] = _ContasPagars[i].ValorPago.ToString("#####0.00");
                                Param[11] = _ContasPagars[i].DataPagamento.ToString("dd-MM-yyyy");
                                Param[12] = _ContasPagars[i].FormaPagamento.ToString();
                                Param[13] = _ContasPagars[i].TipoPagamento.ToString();
                                Param[14] = _ContasPagars[i].Parcelas.ToString();
                                Param[15] = _ContasPagars[i].Finalizado.ToString();
                                Param[16] = _ContasPagars[i].DataCriacao.ToString("dd-MM-yyyy");
                                Param[17] = _ContasPagars[i].Usuario.ToString();
                                Param[18] = _ContasPagars[i].CaminhoArquivo;
                                Param[19] = _ContasPagars[i].Favorecido.ToString();
                                Param[20] = _ContasPagars[i].Credor.ToString();

                                DgContas.Rows.Add(Param);
                            }
                        }

                        if (ChContasaVencer.Checked.Equals(true))
                        {
                            List<Classes.Bioghet_ContasPagar> _ContasPagars = Classes.Bioghet_ConsultaMysql.Listar_ContasaVencer(CbVwTipo.Text, TxBuscar.Text);
                            for (int i = 0; i < _ContasPagars.Count; i++)
                            {
                                Param[0] = _ContasPagars[i].ID.ToString();
                                Param[1] = _ContasPagars[i].Tipo;
                                Param[2] = _ContasPagars[i].Documento;
                                Param[3] = _ContasPagars[i].DataLancamento.ToString("dd-MM-yyyy");
                                Param[4] = _ContasPagars[i].DataVencimento.ToString("dd-MM-yyyy");
                                Param[5] = _ContasPagars[i].Desconto.ToString();
                                Param[6] = _ContasPagars[i].Juros.ToString();
                                Param[7] = _ContasPagars[i].NotaFiscal;
                                Param[8] = _ContasPagars[i].Sacado;
                                Param[9] = _ContasPagars[i].ValoraPagar.ToString("#####0.00");
                                Param[10] = _ContasPagars[i].ValorPago.ToString("#####0.00");
                                Param[11] = _ContasPagars[i].DataPagamento.ToString("dd-MM-yyyy");
                                Param[12] = _ContasPagars[i].FormaPagamento.ToString();
                                Param[13] = _ContasPagars[i].TipoPagamento.ToString();
                                Param[14] = _ContasPagars[i].Parcelas.ToString();
                                Param[15] = _ContasPagars[i].Finalizado.ToString();
                                Param[16] = _ContasPagars[i].DataCriacao.ToString("dd-MM-yyyy");
                                Param[17] = _ContasPagars[i].Usuario.ToString();
                                Param[18] = _ContasPagars[i].CaminhoArquivo;
                                Param[19] = _ContasPagars[i].Favorecido.ToString();
                                Param[20] = _ContasPagars[i].Credor.ToString();

                                DgContas.Rows.Add(Param);
                            }
                        }

                    }
                    else
                    {
                        if (ChContasVencidas.Checked.Equals(true))
                        {
                            List<Classes.Bioghet_ContasPagar> _ContasPagars = Classes.Bioghet_ConsultaMysql.Listar_ContasVencidas(CbVwTipo.Text, "");
                            for (int i = 0; i < _ContasPagars.Count; i++)
                            {
                                Param[0] = _ContasPagars[i].ID.ToString();
                                Param[1] = _ContasPagars[i].Tipo;
                                Param[2] = _ContasPagars[i].Documento;
                                Param[3] = _ContasPagars[i].DataLancamento.ToString("dd-MM-yyyy");
                                Param[4] = _ContasPagars[i].DataVencimento.ToString("dd-MM-yyyy");
                                Param[5] = _ContasPagars[i].Desconto.ToString();
                                Param[6] = _ContasPagars[i].Juros.ToString();
                                Param[7] = _ContasPagars[i].NotaFiscal;
                                Param[8] = _ContasPagars[i].Sacado;
                                Param[9] = _ContasPagars[i].ValoraPagar.ToString("#####0.00");
                                Param[10] = _ContasPagars[i].ValorPago.ToString("#####0.00");
                                Param[11] = _ContasPagars[i].DataPagamento.ToString("dd-MM-yyyy");
                                Param[12] = _ContasPagars[i].FormaPagamento.ToString();
                                Param[13] = _ContasPagars[i].TipoPagamento.ToString();
                                Param[14] = _ContasPagars[i].Parcelas.ToString();
                                Param[15] = _ContasPagars[i].Finalizado.ToString();
                                Param[16] = _ContasPagars[i].DataCriacao.ToString("dd-MM-yyyy");
                                Param[17] = _ContasPagars[i].Usuario.ToString();
                                Param[18] = _ContasPagars[i].CaminhoArquivo;
                                Param[19] = _ContasPagars[i].Favorecido.ToString();
                                Param[20] = _ContasPagars[i].Credor.ToString();

                                DgContas.Rows.Add(Param);
                            }
                        }

                        if (ChContasaVencer.Checked.Equals(true))
                        {
                            List<Classes.Bioghet_ContasPagar> _ContasPagars = Classes.Bioghet_ConsultaMysql.Listar_ContasaVencer(CbVwTipo.Text, "");
                            for (int i = 0; i < _ContasPagars.Count; i++)
                            {
                                Param[0] = _ContasPagars[i].ID.ToString();
                                Param[1] = _ContasPagars[i].Tipo;
                                Param[2] = _ContasPagars[i].Documento;
                                Param[3] = _ContasPagars[i].DataLancamento.ToString("dd-MM-yyyy");
                                Param[4] = _ContasPagars[i].DataVencimento.ToString("dd-MM-yyyy");
                                Param[5] = _ContasPagars[i].Desconto.ToString();
                                Param[6] = _ContasPagars[i].Juros.ToString();
                                Param[7] = _ContasPagars[i].NotaFiscal;
                                Param[8] = _ContasPagars[i].Sacado;
                                Param[9] = _ContasPagars[i].ValoraPagar.ToString("#####0.00");
                                Param[10] = _ContasPagars[i].ValorPago.ToString("#####0.00");
                                Param[11] = _ContasPagars[i].DataPagamento.ToString("dd-MM-yyyy");
                                Param[12] = _ContasPagars[i].FormaPagamento.ToString();
                                Param[13] = _ContasPagars[i].TipoPagamento.ToString();
                                Param[14] = _ContasPagars[i].Parcelas.ToString();
                                Param[15] = _ContasPagars[i].Finalizado.ToString();
                                Param[16] = _ContasPagars[i].DataCriacao.ToString("dd-MM-yyyy");
                                Param[17] = _ContasPagars[i].Usuario.ToString();
                                Param[18] = _ContasPagars[i].CaminhoArquivo;
                                Param[19] = _ContasPagars[i].Favorecido.ToString();
                                Param[20] = _ContasPagars[i].Credor.ToString();

                                DgContas.Rows.Add(Param);
                            }
                        }
                    }
                }
                else
                {
                    throw new Exception("FAVOR INFORME UM PLANO DE CONTAS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void DgContas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex.Equals(21))
                {
                    CbTipo.Text = DgContas.CurrentRow.Cells[2].Value.ToString();

                    tabControl1.SelectedIndex = 0;
                }
                if (e.ColumnIndex.Equals(22))
                {
                    DialogResult pergunta = MessageBox.Show("DESEJA EXCLUIR O PLANO DE CONTAS?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(pergunta == DialogResult.Yes)
                    {
                        int ret = Classes.Bioghet_DeleteMYSQL.Deletar_PlanodeContas(DgContas.CurrentRow.Cells[2].Value.ToString());

                        if (ret.Equals(1))
                        {
                            int retorno = Classes.Bioghet_DeleteMYSQL.Deletar_ParcelaPlanodeContas(DgContas.CurrentRow.Cells[2].Value.ToString());

                            MessageBox.Show("PLANO REMOVIDO COM SUCESSO");
                        }
                        else
                        {
                            throw new Exception("ERRO AO REMOVER");
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
}
