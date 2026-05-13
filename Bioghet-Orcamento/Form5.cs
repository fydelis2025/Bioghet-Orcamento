using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

          
        }

        private MaoObra obra;

        private void limparcampo()
        {
            TxCadMarca.ResetText();
            TxCadModelo.ResetText();
            TxCadDefeito.ResetText();
            TxCadValor.Text = "0,00";
            TxValorMO.Text = "0";
            TxTotal.Text = "0";
            TxAparelho.Text = "0,00";
            //TxMemo.ResetText();
            CbTipoPecas.ResetText();
            TxPeca.ResetText();
            TxMargem.Text = "0,00";
            TxMargemPeca.Text = "0";
            TxMargemMO.Text = "0";
            TxNovo.Text = "0";
            obra = null;
        }

        internal void Criar_Orcamento()
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(TxCadMarca.Text) && (!String.IsNullOrWhiteSpace(TxCadModelo.Text)))
                {
                    if (obra == null)
                    {
                        obra = new MaoObra();

                        obra.Tipo = CbTipo.Text;
                        obra.Marca = TxCadMarca.Text;
                        obra.Modelo = TxCadModelo.Text;
                        obra.Defeito = TxCadDefeito.Text;
                        obra.Peca = TxPeca.Text;
                        obra.Valor = decimal.Parse(TxCadValor.Text);
                        //obra.AnoFabricacao = int.Parse(TxMargem.Text);
                        obra.ValorMO = decimal.Parse(TxValorMO.Text);
                        obra.Total = decimal.Parse(TxTotal.Text);
                        obra.TipoPecas = int.Parse(CbTipoPecas.Text.Substring(0, 2));
                        obra.ValorAparelho = decimal.Parse(TxAparelho.Text);
                        obra.Memo = String.Empty;
                        obra.PrecoNovo = decimal.Parse(TxNovo.Text);
                        obra.MargemPrecoNovo = decimal.Parse(TxMargem.Text);
                        obra.MargemPreco = decimal.Parse(TxMargemPeca.Text);
                        obra.MargemMo = decimal.Parse(TxMargemMO.Text);
                        obra.Opcao = ChOpcao.Checked;

                        //if (RdSim.Checked.Equals(true))
                        //{
                        //    obra.PGANTECIPAGO = RdSim.Checked;
                        //}

                        //if (RdNao.Checked.Equals(true))
                        //{
                        //    obra.PGANTECIPAGO = false;
                        //}

                        Classes.Bioghet_Configuracao.retorno = Classes.Bioghet_ConsultaMysql.Consultar_Orcamento(obra.Tipo, obra.Marca, obra.Modelo, obra.Defeito, obra.TipoPecas);

                        if (Classes.Bioghet_Configuracao.retorno.Equals(false))
                        {

                            int retorno = Classes.Bioghet_InserirMYSQL.Criar_MaoObra(obra);
                            if (retorno.Equals(1))
                            {
                                MessageBox.Show("ORÇAMENTO CRIADA COM SUCESSO","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                            else
                            {
                                throw new Exception("ERRO AO CRIAR O ORÇAMENTO");
                            }
                        }
                        else
                        {
                            obra = null;
                            throw new Exception("ORÇAMENTO PARA O MODELO " + TxCadModelo.Text + " COM DEFEITO " + TxCadDefeito.Text + " JA ESTÁ CADASTRADO");
                        }

                        obra = null;

                        //Listar_Tabela();

                    }
                    else
                    {
                        obra.Tipo = CbTipo.Text;
                        obra.Marca = TxCadMarca.Text;
                        obra.Modelo = TxCadModelo.Text;
                        obra.Defeito = TxCadDefeito.Text;
                        obra.Peca = TxPeca.Text;
                        obra.Valor = decimal.Parse(TxCadValor.Text);
                        //obra.AnoFabricacao = int.Parse(TxMargem.Text);
                        obra.ValorMO = decimal.Parse(TxValorMO.Text);
                        obra.Total = decimal.Parse(TxTotal.Text);
                        obra.TipoPecas = int.Parse(CbTipoPecas.Text.Substring(0, 1));
                        obra.ValorAparelho = decimal.Parse(TxAparelho.Text);
                        obra.Memo = String.Empty;
                        obra.PrecoNovo = decimal.Parse(TxNovo.Text);
                        obra.MargemPrecoNovo = decimal.Parse(TxMargem.Text);
                        obra.MargemPreco = decimal.Parse(TxMargemPeca.Text);
                        obra.MargemMo = decimal.Parse(TxMargemMO.Text);
                        obra.Opcao = ChOpcao.Checked;

                        //if (RdSim.Checked.Equals(true))
                        //{
                        //    obra.PGANTECIPAGO = RdSim.Checked;
                        //}

                        //if (RdNao.Checked.Equals(true))
                        //{
                        //    obra.PGANTECIPAGO = false;
                        //}

                        int retorno = Classes.Bioghet_UpdateMYSQL.Atualizar_MaoObraOrcamento(obra);

                        if (retorno.Equals(1))
                        {
                            MessageBox.Show("ORÇAMENTO ATUALIZADA COM SUCESSO","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("ERRO AO ATUALIZAR O ORÇAMENTO");
                        }

                       // Listar_Tabela();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Criar_Orcamento();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                TxCadValor.Text = "0,00";
                TxValorMO.Text = "0,00";
                TxTotal.Text = "0,00";
                TxMargem.Text = "0,00";
                TxAparelho.Text = "0,00";
                TxNovo.Text = "0,00";
                TxMargemPeca.Text = "0";
                TxMargemMO.Text = "0";
                //obra = null;

                DgConsulta.Rows.Clear();

                Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();

                if (Classes.Bioghet_Configuracao._servico != null)
                {
                    for (int servico = 0; servico < Classes.Bioghet_Configuracao._servico.Count; servico++)
                    {
                        CbTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao.ToUpper());
                    }

                    //CbTipo.SelectedIndex = 0;

                    CbTipoPecas.Items.Clear();

                    Classes.Bioghet_Configuracao._TipoPecas = Classes.Bioghet_ConsultaMysql.Listar_TipoPeca(CbTipo.Text);

                    for (int TipoPecas = 0; TipoPecas < Classes.Bioghet_Configuracao._TipoPecas.Count; TipoPecas++)
                    {
                        CbTipoPecas.Items.Add(Classes.Bioghet_Configuracao._TipoPecas[TipoPecas].ID.ToString() + " - " + Classes.Bioghet_Configuracao._TipoPecas[TipoPecas].Descricao.ToUpper());
                    }
                }
                else
                {
                    throw new Exception("TIPO SERVIÇO NÃO ENCONTRADO");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //
                //TxCadMarca.SelectedIndex = 7;
                //TxCadModelo.Focus();
            }
        }

        private void TxCadMarca_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(TxCadMarca.Text, CbTipo.Text);
                    Classes.Bioghet_Configuracao.Retorno = Classes.Bioghet_ConsultaMysql.Consultar_Marca(TxCadMarca.Text);
                    


                    if (!Classes.Bioghet_Configuracao.Retorno.Equals(string.Empty))
                    {
                        TxCadModelo.Focus();
                    }
                    else
                    {
                        throw new Exception("MARCA NÃO ENCONTRADA, FAVOR VERIFIQUE");
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCadModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxCadDefeito.Focus();
            }
        }

        private void TxRam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxCadDefeito.Focus();
            }
        }

        private void TxCadDefeito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(TxCadDefeito.Text))
                {
                    try
                    {
                        TxPeca.Text = TxCadDefeito.Text + " " + TxCadMarca.Text + " " + TxCadModelo.Text;

                        CbTipoPecas.DroppedDown = true;
                        CbTipoPecas.SelectedIndex = 0;
                        CbTipoPecas.Focus();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void TxPeca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxMargemPeca.Focus();
            }
        }

        private void TxCadValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxMargemMO.Focus();
            }
        }

        private void TxValorPeca_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    Decimal ValorAparelho = Decimal.Parse(TxCadValor.Text);
            //    Decimal ValorPeca = Decimal.Parse(TxValorMO.Text);

            //    Decimal Soma = Decimal.Add(ValorAparelho, ValorPeca);

            //    TxTotal.Text = Soma.ToString("#####0.00");

                //Tx.Focus();
            //}
        }

        private void TxTela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }

        }

        private void TxRam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
        }

        private void TxCadValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;
               
            }
            
        }

        private void TxValorPeca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormTipoServico tipo = new FormTipoServico();
            tipo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result;

                result = MessageBox.Show("DESEJA DELETAR TODOS OS ORÇAMENTOS GERADOS PARA O MODELO " + TxCadModelo.Text, "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    int excluir = Classes.Bioghet_DeleteMYSQL.Excluir_MaodeObra(CbTipo.Text, TxCadMarca.Text, TxCadModelo.Text);

                    if (excluir.Equals(1))
                    {
                        throw new Exception("ERRO AO EXCLUIR TODOS OS REGISTROS");
                    }
                    else
                    {
                        MessageBox.Show("TODOS OS REGISTROS DO ORÇAMENTO FORAM EXCLUIDOS COM SUCESSO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbTipo_Click(object sender, EventArgs e)
        {
            try
            {
                CbTipo.Items.Clear();


                Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();

                for (int servico = 0; servico < Classes.Bioghet_Configuracao._servico.Count; servico++)
                {
                    CbTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao.ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void TxAnoFabricacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void CbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CbTipoPecas.Items.Clear();
                Classes.Bioghet_Configuracao._TipoPecas = Classes.Bioghet_ConsultaMysql.Listar_TipoPeca(CbTipo.Text);

                for (int TipoPecas = 0; TipoPecas < Classes.Bioghet_Configuracao._TipoPecas.Count; TipoPecas++)
                {
                    CbTipoPecas.Items.Add(Classes.Bioghet_Configuracao._TipoPecas[TipoPecas].ID.ToString() + " - " + Classes.Bioghet_Configuracao._TipoPecas[TipoPecas].Descricao.ToUpper());
                }

                Classes.Bioghet_Configuracao._marca = Classes.Bioghet_ConsultaMysql.Listar_Marca(CbTipo.Text);

                TxCadMarca.Items.Clear();

                for (int i = 0; i < Classes.Bioghet_Configuracao._marca.Count; i++)
                {
                    TxCadMarca.Items.Add(Classes.Bioghet_Configuracao._marca[i].Descricao.ToUpper());
                }

                TxCadDefeito.Items.Clear();
                Classes.Bioghet_Configuracao._Listardef = Classes.Bioghet_ConsultaMysql.Listar_Defeito(CbTipo.Text);
                if (Classes.Bioghet_Configuracao._Listardef.Count != 0)
                {
                    for (int r = 0; r < Classes.Bioghet_Configuracao._Listardef.Count; r++)
                    {
                        TxCadDefeito.Items.Add(Classes.Bioghet_Configuracao._Listardef[r].Descricao);
                    }
                }
                else
                {
                    throw new Exception("DEFEITO NÃO CADASTRADO PARA ESTE TIPO DE APARELHO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCadMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{

            //    Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(TxCadMarca.Text, CbTipo.Text);

            //    TxCadModelo.Items.Clear();


            //    Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_Modelo(Classes.Bioghet_Configuracao.CodigoMarca);


            //    for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
            //    {
            //        TxCadModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }

        private void TxAparelho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
            
        }

        private void TxCadModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TxCadModelo.DroppedDown = true;
        }

        private void TxCadDefeito_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Classes.Bioghet_Configuracao.Defeito = TxCadDefeito.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limparcampo();
        }

        private void TxNovo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TxMargem.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxNovo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxMargem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    decimal novo = decimal.Parse(TxNovo.Text);
                    decimal velho = decimal.Parse(TxAparelho.Text);

                    decimal soma = decimal.Multiply(novo, decimal.Parse(TxMargem.Text)) / 100;

                    decimal subtract = decimal.Subtract(novo, soma);

                    TxAparelho.Text = subtract.ToString("#####0.00");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TxCadModelo.Items.Clear();


                Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_ModeloDigitado(TxCadModelo.Text);
                

                for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                {
                    TxCadModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_Shown(object sender, EventArgs e)
        {
            try
            {
                if (Classes.Bioghet_Configuracao.Funcao.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
                {
                    button3.Enabled = true;
                    BtValores.Enabled = true;
                    button1.Enabled = true;
                }
                else
                {
                    button3.Enabled = false;
                    BtValores.Enabled = false;
                    button1.Enabled = false;
                }
                
                //RdApUsado.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxMargemPeca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxMargemMO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxMargemPeca_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    if (RdApNovo.Checked.Equals(true))
                    {
                        decimal novo = decimal.Parse(TxNovo.Text);
                        decimal velho = decimal.Parse(TxCadValor.Text);

                        decimal soma = decimal.Multiply(novo, decimal.Parse(TxMargemPeca.Text)) / 100;

                        TxCadValor.Text = soma.ToString("#####0.00");

                        TxCadValor.Focus();
                    }
                    
                    if(RdApUsado.Checked.Equals(true))
                    {
                        decimal novo = decimal.Parse(TxAparelho.Text);
                        decimal velho = decimal.Parse(TxCadValor.Text);

                        decimal soma = decimal.Multiply(novo, decimal.Parse(TxMargemPeca.Text)) / 100;

                        TxCadValor.Text = soma.ToString("#####0.00");

                        TxCadValor.Focus();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxMargemMO_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (RdApNovo.Checked.Equals(true))
                    {
                        decimal novo = decimal.Parse(TxNovo.Text);
                        decimal velho = decimal.Parse(TxValorMO.Text);

                        decimal soma = decimal.Multiply(novo, decimal.Parse(TxMargemMO.Text)) / 100;

                        //decimal subtract = decimal.Subtract(novo, soma);

                        TxValorMO.Text = soma.ToString("#####0.00");

                        decimal valorpeca = decimal.Parse(TxCadValor.Text);
                        decimal somatotal = decimal.Add(valorpeca, soma);

                        TxTotal.Text = somatotal.ToString("#####0.00");

                        TxMargemMO.Focus();
                    }
                    
                    if(RdApUsado.Checked.Equals(true))
                    {
                        decimal novo = decimal.Parse(TxAparelho.Text);
                        decimal velho = decimal.Parse(TxValorMO.Text);

                        decimal soma = decimal.Multiply(novo, decimal.Parse(TxMargemMO.Text)) / 100;

                        //decimal subtract = decimal.Subtract(novo, soma);

                        TxValorMO.Text = soma.ToString("#####0.00");

                        decimal valorpeca = decimal.Parse(TxCadValor.Text);
                        decimal somatotal = decimal.Add(valorpeca, soma);

                        TxTotal.Text = somatotal.ToString("#####0.00");

                        TxMargemMO.Focus();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxAparelho_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxCadDefeito.Focus();
            }
        }

         private void TxCadDefeito_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TxPeca.Text = TxCadDefeito.Text + " " + TxCadMarca.Text + " " + TxCadModelo.Text;

                CbTipoPecas.DroppedDown = true;
                //CbTipoPecas.SelectedIndex = 0;
                CbTipoPecas.Focus();
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCadDefeito_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao._Listardef = Classes.Bioghet_ConsultaMysql.Listar_Defeito(CbTipo.Text);

                TxCadDefeito.Items.Clear();
                for (int r = 0; r < Classes.Bioghet_Configuracao._Listardef.Count; r++)
                {
                    TxCadDefeito.Items.Add(Classes.Bioghet_Configuracao._Listardef[r].Descricao);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.PY.Navigate("http://www.comprasparaguai.com.br/busca/?q=" + TxCadDefeito.Text);
            frm.ML.Navigate("https://lista.mercadolivre.com.br/" + TxCadDefeito.Text);
            frm.Show();
        }

        private void PBuscar_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.PY.Navigate("http://www.comprasparaguai.com.br/busca/?q=" + TxCadDefeito.Text);
            frm.ML.Navigate("https://lista.mercadolivre.com.br/" + TxCadDefeito.Text);
            frm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        internal Classes.Bioghet_TipoPecas _tipopecas = null;
        private void CbTipoPecas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (CbTipo.Text.Equals("CELULAR") && CbTipoPecas.Text.Equals("1 - ORIGINAL"))
                {
                    ChOpcao.Checked = true;
                }
                else if (CbTipo.Text.Equals("CELULAR") && CbTipoPecas.Text.Equals("3 - SEGUNDA LINHA"))
                {
                    ChOpcao.Checked = true;
                }
                else if (CbTipo.Text.Equals("TELEVISOR") && CbTipoPecas.Text.Equals("5 - NOVO"))
                {
                    ChOpcao.Checked = true;
                }
                else
                {
                    ChOpcao.Checked = false;
                }

                this._tipopecas = Classes.Bioghet_ConsultaMysql.Consultar_ValoresPecas(CbTipo.Text, TxCadDefeito.Text, Int32.Parse(CbTipoPecas.Text.Remove(2)));

                if (_tipopecas != null)
                {
                    TxMargemPeca.Text = _tipopecas.MargemPeca.ToString();
                    TxMargemMO.Text = _tipopecas.MargemMo.ToString();

                    if (RdApNovo.Checked.Equals(true))
                    {
                        decimal novo = decimal.Parse(TxNovo.Text);
                        decimal velho = decimal.Parse(TxCadValor.Text);

                        decimal soma = decimal.Multiply(novo, decimal.Parse(TxMargemPeca.Text)) / 100;

                        TxCadValor.Text = soma.ToString("#####0.00");

                        TxTotal.Focus();
                    }

                    if (RdApUsado.Checked.Equals(true))
                    {
                        decimal novo = decimal.Parse(TxAparelho.Text);
                        decimal velho = decimal.Parse(TxCadValor.Text);

                        decimal soma = decimal.Multiply(novo, decimal.Parse(TxMargemPeca.Text)) / 100;

                        TxCadValor.Text = soma.ToString("#####0.00");

                        TxTotal.Focus();
                    }

                    if (RdApNovo.Checked.Equals(true))
                    {
                        decimal novo = decimal.Parse(TxNovo.Text);
                        decimal velho = decimal.Parse(TxValorMO.Text);

                        decimal soma = decimal.Multiply(novo, decimal.Parse(TxMargemMO.Text)) / 100;

                        //decimal subtract = decimal.Subtract(novo, soma);

                        TxValorMO.Text = soma.ToString("#####0.00");

                        decimal valorpeca = decimal.Parse(TxCadValor.Text);
                        decimal somatotal = decimal.Add(valorpeca, soma);

                        TxTotal.Text = somatotal.ToString("#####0.00");

                        TxTotal.Focus();
                    }

                    if (RdApUsado.Checked.Equals(true))
                    {
                        decimal novo = decimal.Parse(TxAparelho.Text);
                        decimal velho = decimal.Parse(TxValorMO.Text);

                        decimal soma = decimal.Multiply(novo, decimal.Parse(TxMargemMO.Text)) / 100;

                        //decimal subtract = decimal.Subtract(novo, soma);

                        TxValorMO.Text = soma.ToString("#####0.00");

                        decimal valorpeca = decimal.Parse(TxCadValor.Text);
                        decimal somatotal = decimal.Add(valorpeca, soma);

                        TxTotal.Text = somatotal.ToString("#####0.00");

                        TxTotal.Focus();
                    }
                }
                else
                {
                    throw new Exception("MARGEM NAO CADASTRADA PARA ESTE TIPO DE APARELHO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCadModelo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCadModelo_KeyDown_2(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TxCadDefeito.Focus();
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCadModelo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao._mod = Classes.Bioghet_ConsultaMysql.Consultar_ModeloVALORES(TxCadModelo.Text);
                Classes.Bioghet_Configuracao._Listardef = Classes.Bioghet_ConsultaMysql.Listar_Defeito(CbTipo.Text);

                if (Classes.Bioghet_Configuracao._mod != null)
                {
                    TxNovo.Text = Classes.Bioghet_Configuracao._mod.Novo.ToString("#####0.00");
                    TxMargem.Text = Classes.Bioghet_Configuracao._mod.Margem.ToString("#####0.00");
                    TxAparelho.Text = Classes.Bioghet_Configuracao._mod.Usado.ToString("#####0.00");
                }

                TxCadDefeito.Items.Clear();
                for (int r = 0; r < Classes.Bioghet_Configuracao._Listardef.Count; r++)
                {
                    TxCadDefeito.Items.Add(Classes.Bioghet_Configuracao._Listardef[r].Descricao);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCadModelo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TxCadModelo.Items.Clear();

                String _modelo = TxCadModelo.Text;
                Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_ModeloDigitado(_modelo.ToUpper());
                

                for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                {
                    TxCadModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                }

                TxCadModelo.DroppedDown = true;
            }
        }

        private void CbTipoPecas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbTipo.Text.Equals("CELULAR") && CbTipoPecas.Text.Equals("1 - ORIGINAL"))
                {
                    ChOpcao.Checked = true;
                }
                else if (CbTipo.Text.Equals("CELULAR") && CbTipoPecas.Text.Equals("3 - SEGUNDA LINHA"))
                {
                    ChOpcao.Checked = true;
                }
                else if (CbTipo.Text.Equals("TELEVISOR") && CbTipoPecas.Text.Equals("5 - NOVO"))
                {
                    ChOpcao.Checked = true;
                }
                else
                {
                    ChOpcao.Checked = false;
                }

                this._tipopecas = Classes.Bioghet_ConsultaMysql.Consultar_ValoresPecas(CbTipo.Text, TxCadDefeito.Text, Int32.Parse(CbTipoPecas.Text.Remove(2)));

                if (_tipopecas != null)
                {
                    TxMargemPeca.Text = _tipopecas.MargemPeca.ToString();
                    TxMargemMO.Text = _tipopecas.MargemMo.ToString();

                    if (RdApNovo.Checked.Equals(true))
                    {
                        decimal novo = decimal.Parse(TxNovo.Text);
                        decimal velho = decimal.Parse(TxCadValor.Text);

                        decimal soma = decimal.Multiply(novo, decimal.Parse(TxMargemPeca.Text)) / 100;

                        TxCadValor.Text = soma.ToString("#####0.00");

                        TxTotal.Focus();
                    }

                    if (RdApUsado.Checked.Equals(true))
                    {
                        decimal novo = decimal.Parse(TxAparelho.Text);
                        decimal velho = decimal.Parse(TxCadValor.Text);

                        decimal soma = decimal.Multiply(novo, decimal.Parse(TxMargemPeca.Text)) / 100;

                        TxCadValor.Text = soma.ToString("#####0.00");

                        TxTotal.Focus();
                    }

                    if (RdApNovo.Checked.Equals(true))
                    {
                        decimal novo = decimal.Parse(TxNovo.Text);
                        decimal velho = decimal.Parse(TxValorMO.Text);

                        decimal soma = decimal.Multiply(novo, decimal.Parse(TxMargemMO.Text)) / 100;

                        //decimal subtract = decimal.Subtract(novo, soma);

                        TxValorMO.Text = soma.ToString("#####0.00");

                        decimal valorpeca = decimal.Parse(TxCadValor.Text);
                        decimal somatotal = decimal.Add(valorpeca, soma);

                        TxTotal.Text = somatotal.ToString("#####0.00");

                        TxTotal.Focus();
                    }

                    if (RdApUsado.Checked.Equals(true))
                    {
                        decimal novo = decimal.Parse(TxAparelho.Text);
                        decimal velho = decimal.Parse(TxValorMO.Text);

                        decimal soma = decimal.Multiply(novo, decimal.Parse(TxMargemMO.Text)) / 100;

                        //decimal subtract = decimal.Subtract(novo, soma);

                        TxValorMO.Text = soma.ToString("#####0.00");

                        decimal valorpeca = decimal.Parse(TxCadValor.Text);
                        decimal somatotal = decimal.Add(valorpeca, soma);

                        TxTotal.Text = somatotal.ToString("#####0.00");

                        TxTotal.Focus();
                    }
                }
                else
                {
                    throw new Exception("MARGEM NAO CADASTRADA PARA ESTE TIPO DE APARELHO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Criar_Orcamento();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamWriter _GerarAqruivo = new System.IO.StreamWriter(Environment.CurrentDirectory + "\\Arquivos\\" + TxCadMarca.Text + "_" + DateTime.Now.ToString("dd_MM_yy") + ".Bioghet");
                for (int i = 0; i < TxCadModelo.Items.Count; i++)
                {
                    _GerarAqruivo.WriteLine(TxCadModelo.Items[i].ToString());
                }
                _GerarAqruivo.Close();

                DialogResult Aviso;
                Aviso = MessageBox.Show("ARQUIVO GERADO COM SUCESSO, DESEJA VISUALIZAR O ARQUIVO GERADO", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (Aviso == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\Arquivos\\" + TxCadMarca.Text + "_" + DateTime.Now.ToString("dd_MM_yy") + ".Bioghet");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Tabela()
        {
            try
            {
                DgConsulta.Rows.Clear();

              
                Classes.Bioghet_Configuracao.obra = Classes.Bioghet_ConsultaMysql.Listar_MaoObraT(CbTipo.Text, TxCadMarca.Text, TxCadModelo.Text);
                

                String[] param = new String[10];

                for (int i = 0; i < Classes.Bioghet_Configuracao.obra.Count; i++)
                {
                    if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(1))
                    {
                        param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                    }
                    if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(2))
                    {
                        param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                    }
                    if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(3))
                    {
                        param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                    }
                    if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(4))
                    {
                        param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                    }

                    param[1] = Classes.Bioghet_Configuracao.obra[i].Marca;
                    param[2] = Classes.Bioghet_Configuracao.obra[i].Modelo;
                    param[3] = Classes.Bioghet_Configuracao.obra[i].Defeito;
                    param[4] = Classes.Bioghet_Configuracao.obra[i].Valor.ToString("#####0.00");
                    param[5] = Classes.Bioghet_Configuracao.obra[i].ValorMO.ToString("#####0.00");
                    param[6] = Classes.Bioghet_Configuracao.obra[i].Total.ToString("#####0.00");
                    param[7] = Classes.Bioghet_Configuracao.obra[i].PrecoNovo.ToString("#####0.00");
                    param[8] = Classes.Bioghet_Configuracao.obra[i].ValorAparelho.ToString("#####0.00");

                    DgConsulta.Rows.Add(param);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(TxConsultas.Text))
                {
                    DgConsulta.Rows.Clear();

                    
                    Classes.Bioghet_Configuracao.obra = Classes.Bioghet_ConsultaMysql.Listar_MaoObraDigitado(CbTipo.Text, TxCadMarca.Text, TxConsultas.Text);
                    
                    String[] param = new String[10];

                    for (int i = 0; i < Classes.Bioghet_Configuracao.obra.Count; i++)
                    {
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(1))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(2))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(3))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(4))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(5))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(7))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(8))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(10))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(11))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(12))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(13))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(14))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(15))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(16))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(17))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(18))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(19))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(20))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(21))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(22))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(23))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(24))
                        {
                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                        }

                        param[1] = Classes.Bioghet_Configuracao.obra[i].Marca;
                        param[2] = Classes.Bioghet_Configuracao.obra[i].Modelo;
                        param[3] = Classes.Bioghet_Configuracao.obra[i].Defeito;
                        param[4] = Classes.Bioghet_Configuracao.obra[i].Valor.ToString("#####0.00");
                        param[5] = Classes.Bioghet_Configuracao.obra[i].ValorMO.ToString("#####0.00");
                        param[6] = Classes.Bioghet_Configuracao.obra[i].Total.ToString("#####0.00");
                        param[7] = Classes.Bioghet_Configuracao.obra[i].PrecoNovo.ToString("#####0.00");
                        param[8] = Classes.Bioghet_Configuracao.obra[i].ValorAparelho.ToString("#####0.00");
                        param[9] = Classes.Bioghet_Configuracao.obra[i].Opcao.ToString();

                        DgConsulta.Rows.Add(param);

                        for (int linha = 0; linha < DgConsulta.Rows.Count; linha++)
                        {
                            Boolean _opcao = Boolean.Parse(DgConsulta.Rows[i].Cells[9].Value.ToString());

                            if (DgConsulta.Rows[i].Cells[3].Value.Equals("TELA FRONTAL") &&  DgConsulta.Rows[i].Cells[0].Value.Equals("ORIGINAL") || DgConsulta.Rows[i].Cells[0].Value.Equals("SEGUNDA LINHA") && _opcao.Equals(true))
                            {
                                DgConsulta.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
                                DgConsulta.Rows[i].DefaultCellStyle.ForeColor = Color.Black;

                                DgConsulta.Rows[i].Cells[6].ToolTipText = "VALOR A SER OFERECIDO AO CONSUMIDOR FINAL";
                                
                            }
                        }
                    }
                }
                else
                {
                    throw new Exception("FAVOR INFORMAR DADOS PARA CONSULTAS, NO CAMPO CONSULTAS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(11))
                {
                    DialogResult pergunta = MessageBox.Show("Deseja realmente excluir o item", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (pergunta == System.Windows.Forms.DialogResult.Yes)
                    {

                        Classes.Bioghet_ExcluirMYSQL.ExcluirMaoObra(DgConsulta.CurrentRow.Cells[1].Value.ToString(), DgConsulta.CurrentRow.Cells[2].Value.ToString(), (DgConsulta.CurrentRow.Cells[3].Value.ToString()), Classes.Bioghet_ConsultaMysql.Consultar_IDPeca(DgConsulta.CurrentRow.Cells[0].Value.ToString()));
                        

                        MessageBox.Show("Registro excluido com sucesso");
                        Listar_Tabela();
                    }
                }

                if (e.ColumnIndex.Equals(10))
                {

                    obra = Classes.Bioghet_ConsultaMysql.Consultar_AlterarMaoObra(DgConsulta.CurrentRow.Cells[1].Value.ToString(), DgConsulta.CurrentRow.Cells[2].Value.ToString(), DgConsulta.CurrentRow.Cells[3].Value.ToString(), Classes.Bioghet_ConsultaMysql.Consultar_IDPeca(DgConsulta.CurrentRow.Cells[0].Value.ToString()));
                   
                    if (obra != null)
                    {

                        Classes.Bioghet_Configuracao.codigomaoobra = Classes.Bioghet_ConsultaMysql.IDMaoObra(DgConsulta.CurrentRow.Cells[1].Value.ToString(), DgConsulta.CurrentRow.Cells[2].Value.ToString(), DgConsulta.CurrentRow.Cells[3].Value.ToString(), Classes.Bioghet_ConsultaMysql.Consultar_IDPeca(DgConsulta.CurrentRow.Cells[0].Value.ToString()));

                        //Classes.Bioghet_Configuracao.codigomaoobra = Classes.Bioghet_Configuracao.codigomaoobra;

                        CbTipo.Text = obra.Tipo;
                        TxCadMarca.Text = obra.Marca;
                        TxCadModelo.Text = obra.Modelo;
                        TxMargem.Text = obra.AnoFabricacao.ToString();
                        TxCadDefeito.Text = obra.Defeito;
                        TxPeca.Text = obra.Peca;
                        TxCadValor.Text = obra.Valor.ToString();
                        TxValorMO.Text = obra.ValorMO.ToString();
                        TxTotal.Text = obra.Total.ToString();
                        TxNovo.Text = obra.PrecoNovo.ToString();
                        TxAparelho.Text = obra.ValorAparelho.ToString();
                        TxMargem.Text = obra.MargemPrecoNovo.ToString();
                        TxMargemPeca.Text = obra.MargemPreco.ToString();
                        TxMargemMO.Text = obra.MargemMo.ToString();

                        if (obra.TipoPecas.Equals(1))
                        {
                            CbTipoPecas.SelectedIndex = 0;
                        }
                        else if (obra.TipoPecas.Equals(2))
                        {
                            CbTipoPecas.SelectedIndex = 1;
                        }
                        else if (obra.TipoPecas.Equals(3))
                        {
                            CbTipoPecas.SelectedIndex = 2;
                        }
                        else if (obra.TipoPecas.Equals(4))
                        {
                            CbTipoPecas.SelectedIndex = 3;
                        }
                        else
                        {
                            CbTipoPecas.SelectedIndex = 0;
                        }

                        ChOpcao.Checked = obra.Opcao;
                    }
                    else
                    {
                        throw new Exception("Mão de Obra não encontrado");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxConsultas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DgConsulta.Rows.Clear();


                    Classes.Bioghet_Configuracao.obra = Classes.Bioghet_ConsultaMysql.Listar_MaoObraDigitado(CbTipo.Text, TxCadMarca.Text, TxConsultas.Text);
                   

                    String[] param = new String[10];

                    for (int i = 0; i < Classes.Bioghet_Configuracao.obra.Count; i++)
                    {
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(1))
                        {

                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                            
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(2))
                        {

                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                            
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(3))
                        {

                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                            
                        }
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(4))
                        {

                            param[0] = Classes.Bioghet_ConsultaMysql.Consultar_Peca(Classes.Bioghet_Configuracao.obra[i].TipoPecas);
                            
                        }

                        param[1] = Classes.Bioghet_Configuracao.obra[i].Marca;
                        param[2] = Classes.Bioghet_Configuracao.obra[i].Modelo;
                        param[3] = Classes.Bioghet_Configuracao.obra[i].Defeito;
                        param[4] = Classes.Bioghet_Configuracao.obra[i].Valor.ToString("#####0.00");
                        param[5] = Classes.Bioghet_Configuracao.obra[i].ValorMO.ToString("#####0.00");
                        param[6] = Classes.Bioghet_Configuracao.obra[i].Total.ToString("#####0.00");
                        param[7] = Classes.Bioghet_Configuracao.obra[i].PrecoNovo.ToString("#####0.00");
                        param[8] = Classes.Bioghet_Configuracao.obra[i].ValorAparelho.ToString("#####0.00");

                        DgConsulta.Rows.Add(param);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxCadModelo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                TxConsultas.Text = TxCadModelo.Text;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCadModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtValores_Click(object sender, EventArgs e)
        {
            FrmMargens _margens = new FrmMargens();
            _margens.ShowDialog();
        }

        int Sucess;
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("DESEJA REALMENTE ATUALIZAR O ORÇAMENTO PARA O MODELO " + TxCadModelo.Text, "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                String Passwd;
                String Padrao = Classes.BioCriptografia.Descripto(Ini.GetIniString(Ini.nomeArquivoINI(), "hash", "hash", ""));

                if (result == DialogResult.Yes)
                {
                    Passwd = Interaction.InputBox("DIGITE A PALAVRA CHAVE PARA ACESSAR AS CONFIGURAÇÕES", "ACESSO RESTRITO", "", 200, 200);

                    if (!String.IsNullOrWhiteSpace(Passwd))
                    {

                        if (Passwd == Padrao)
                        {
                            List<Classes.Bioghet_AplicarOrcamento> _aplOrcamento = Classes.Bioghet_ConsultaMysql.Listar_ValoresOrcamento(CbTipo.Text, TxCadMarca.Text, TxCadModelo.Text);

                            for (int retval = 0; retval < _aplOrcamento.Count; retval++)
                            {
                                Decimal CalculaValor = Decimal.Multiply(_aplOrcamento[retval].ValorUsado, _aplOrcamento[retval].MargemPeca) / 100;
                                //Decimal Soma = Decimal.Add(_aplOrcamento[retval].Valor, CalculaValor);

                                Decimal CalculaMO = Decimal.Multiply(_aplOrcamento[retval].ValorUsado, _aplOrcamento[retval].MargemMO) / 100;
                                //Decimal SomaMO = Decimal.Add(_aplOrcamento[retval].ValorMO, CalculaMO);

                                Decimal SomaTotal = Decimal.Add(CalculaValor, CalculaMO);

                                Sucess = Classes.Bioghet_UpdateMYSQL.Aplicar_ValoresOrcamento(CalculaValor, CalculaMO, SomaTotal, _aplOrcamento[retval].ID);
                            }

                            throw new Exception("TODOS OS VALORES FORAM ATUALIZADOS");
                        }
                        
                    }
                }
                else
                {
                    throw new Exception("NENHUMA OPERAÇÃO A SER EXECUTADA");
                }
                //FrmAjuste _ajuste = new FrmAjuste();

                //Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();

                //for (int servico = 0; servico < Classes.Bioghet_Configuracao._servico.Count; servico++)
                //{
                //    _ajuste.CbTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao);
                //}

                //Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(TxCadMarca.Text, CbTipo.Text);

                //Classes.Bioghet_Configuracao._marca = Classes.Bioghet_ConsultaMysql.Listar_Marca(CbTipo.Text);

                //TxCadMarca.Items.Clear();
                //for (int i = 0; i < Classes.Bioghet_Configuracao._marca.Count; i++)
                //{
                //    _ajuste.TxCadMarca.Items.Add(Classes.Bioghet_Configuracao._marca[i].Descricao.ToUpper());
                //}

                //TxCadModelo.Items.Clear();

                //Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_Modelo(Classes.Bioghet_Configuracao.CodigoMarca);


                //for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                //{
                //    _ajuste.TxCadModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                //}

                //int _tipo = _ajuste.CbTipo.FindString(CbTipo.Text);
                //_ajuste.CbTipo.SelectedIndex = _tipo;

                //int _marca = _ajuste.TxCadMarca.FindString(TxCadMarca.Text);
                //_ajuste.TxCadMarca.SelectedIndex = _marca;

                //int _modelo = _ajuste.TxCadModelo.FindString(TxCadModelo.Text);
                //_ajuste.TxCadModelo.SelectedIndex = _modelo;

                ////List<MaoObra> _listar = Classes.Bioghet_ConsultaMysql.Listar_MargemOrcamento(CbTipo.Text, TxCadMarca.Text, TxCadModelo.Text);
                //Modelo _modeloValores = Classes.Bioghet_ConsultaMysql.Consultar_ValoresModelo(TxCadModelo.Text);
                ////for (int i = 0; i < _listar.Count; i++)
                ////{
                //if (_modeloValores != null)
                //{
                //    _ajuste.TxNovo.Text = _modeloValores.Novo.ToString("#####0.00");
                //    _ajuste.TxMargem.Text = _modeloValores.Margem.ToString();
                //    _ajuste.TxAparelho.Text = _modeloValores.Usado.ToString("#####0.00");
                //}
                ////}

                //_ajuste.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCadMarca_Click(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao._marca = Classes.Bioghet_ConsultaMysql.Listar_Marca(CbTipo.Text);
                
                TxCadMarca.Items.Clear();
                for (int i = 0; i < Classes.Bioghet_Configuracao._marca.Count; i++)
                {
                    TxCadMarca.Items.Add(Classes.Bioghet_Configuracao._marca[i].Descricao.ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCadModelo_Click(object sender, EventArgs e)
        {
            try
            {
                //TxCadModelo.Items.Clear();

                //Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(TxCadMarca.Text, CbTipo.Text);

                //Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_Modelo(Classes.Bioghet_Configuracao.CodigoMarca);


                //for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                //{
                //    TxCadModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCadMarca_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(TxCadMarca.Text, CbTipo.Text);

                TxCadModelo.Items.Clear();


                Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_Modelo(Classes.Bioghet_Configuracao.CodigoMarca);


                for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                {
                    TxCadModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.Defeito = TxCadDefeito.Text;
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool mouseClicked;
        Point clickedAt;
        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void Form5_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            FormModelo _modelo = new FormModelo();
            _modelo.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmTipoPeca tipo = new FrmTipoPeca();
            tipo.ShowDialog();
        }
    }
}
