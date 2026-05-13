using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        public static Classes.Bioghet_Bazar _bazar;
        public static Classes.Bioghet_BarraLed _barraled;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                _bazar = null;
                TxValor.Text = "0,00";
                TxPartNumber.ResetText();
                TxSerie.ResetText();
                TxPrateleira.Text = "0";
                TxCaixa.Text = "0";
                TxCompartimento.Text = "0";
                TxQuantidade.Text = "0";
                TxDescricao.ResetText();
                CbTipo.DroppedDown = true;
                DgSerie.Rows.Clear();
                TxCodPeca.Text = "0";
                TxPavimento.ResetText();
                TxSala.ResetText();
                TxPrateleira.ResetText();
                TxCaixa.ResetText();
                TxCompartimento.ResetText();
                
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
                if (_bazar == null)
                {
                    if (DgSerie.Rows.Count.Equals(0))
                        throw new Exception("NENUM ITEM ADICIONADO A LISTA");

                    _bazar = new Classes.Bioghet_Bazar();
                    _bazar.Tipo = CbTipo.Text;
                    _bazar.Marca = TxCadMarca.Text;
                    _bazar.Modelo = TxCadModelo.Text;
                    _bazar.PartNumber = TxPartNumber.Text;
                    _bazar.Serie = TxSerie.Text;
                    _bazar.Status = CbStatus.Text;
                    _bazar.Valor = Decimal.Parse(TxValor.Text);
                    _bazar.Prateleira = TxPrateleira.Text;
                    _bazar.Caixa = TxCaixa.Text;
                    _bazar.Compartimento = TxCompartimento.Text;
                    _bazar.Quantidade = int.Parse(TxQuantidade.Text);
                    _bazar.OBS = TxObs.Text;
                    _bazar.DataCriacao = DateTime.Now;
                    _bazar.Descricao = TxDescricao.Text;
                    _bazar.Situacao = CbSituacao.Text;
                    _bazar.Modelo = TxCadModelo.Text;
                    _bazar.Pavimento = TxPavimento.Text;
                    _bazar.Sala = TxSala.Text;
                    _bazar.CodigoPeca = TxCodPeca.Text;
                    _bazar.Data = DateTime.Parse(TxDataPeca.Text);
                    _bazar.TV = ChTV.Checked;
                    /*_bazar.Tensao = TxTensao.Text;
                    _bazar.QtdeLede = int.Parse(TxQtdeLed.Text);
                    _bazar.VLed = TxVled.Text;
                    _bazar.WLed = TxWled.Text;
                    _bazar.QtdeBarra = int.Parse(TxQtdeBarra.Text);
                    _bazar.TBarra = TxTBarra.Text;
                    _bazar.QtdeBLed = int.Parse(TxQtdeLedBarra.Text);
                    _bazar.TotalLed = int.Parse(TxTotalLed.Text);
                    _bazar.ValorBarra = Decimal.Parse(TxValorBarra.Text);
                    _bazar.ValorLed = Decimal.Parse(TxValorLed.Text);*/

                    if (!String.IsNullOrWhiteSpace(TxSerie.Text))
                    {
                        int retorno = Classes.Bioghet_InserirMYSQL.Criar_Bazar(_bazar);

                        if (retorno.Equals(1))
                        {
                            MessageBox.Show("BAZAR CRIADO COM SUCESSO", "BAZAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("ERRO NO CADASTRO DO BAZAR");
                        }
                    }
                    else
                    {
                        _bazar = null;
                        throw new Exception("NÚMERO DE SÉRIE OBRIGATORIO");
                    }


                }
                else
                {

                    _bazar.Tipo = CbTipo.Text;
                    _bazar.Marca = TxCadMarca.Text;
                    _bazar.Modelo = TxCadModelo.Text;
                    _bazar.PartNumber = TxPartNumber.Text;
                    _bazar.Serie = TxSerie.Text;
                    _bazar.Status = CbStatus.Text;
                    _bazar.Valor = Decimal.Parse(TxValor.Text);
                    _bazar.Prateleira = TxPrateleira.Text;
                    _bazar.Caixa = TxCaixa.Text;
                    _bazar.Compartimento = TxCompartimento.Text;
                    _bazar.Quantidade = int.Parse(TxQuantidade.Text);
                    _bazar.OBS = TxObs.Text;
                    _bazar.DataCriacao = DateTime.Now;
                    _bazar.Descricao = TxDescricao.Text;
                    _bazar.Situacao = CbSituacao.Text;
                    _bazar.Modelo = TxCadModelo.Text;
                    _bazar.Pavimento = TxPavimento.Text;
                    _bazar.Sala = TxSala.Text;
                    _bazar.CodigoPeca = TxCodPeca.Text;
                    _bazar.Data = DateTime.Parse(TxDataPeca.Text);
                    _bazar.TV = ChTV.Checked;
                   

                    int retorno = Classes.Bioghet_UpdateMYSQL.Update_Bazar(_bazar);

                    if (retorno.Equals(1))
                    {
                        MessageBox.Show("BAZAR ATUALIZADO COM SUCESSO", "ATUALIZAR BAZAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        throw new Exception("ERRO AO ATUALIZAR O BAZAR");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            try
            {
                String[] Param = new String[2];
                List<Classes.Bioghet_BazarEmbal> _lista_bazarEmbal = Classes.Bioghet_ConsultaMysql.Listar_BazarEmbal(CbTipo.Text,TxCadMarca.Text, TxCadModelo.Text);
                for (int i = 0; i < _lista_bazarEmbal.Count; i++)
                {
                    Param[0] = _lista_bazarEmbal[i].ID.ToString();
                    Param[1] = _lista_bazarEmbal[i].Serie;

                    DgSerie.Rows.Add(Param);
                }

                _barraled = null;
                TxQtdeLed.Text = "0";
                TxVled.ResetText();
                TxWled.ResetText();
                TxQtdeBarra.Text = "0";
                TxValorBarra.Text = "0";
                TxValorLed.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao._marca = Classes.Bioghet_ConsultaMysql.Listar_Marca(CbTipo.Text);

                TxCadMarca.Items.Clear();
                for (int i = 0; i < Classes.Bioghet_Configuracao._marca.Count; i++)
                {
                    TxCadMarca.Items.Add(Classes.Bioghet_Configuracao._marca[i].Descricao.ToUpper());
                }

                if(CbTipo.Text == "BARRA DE LED")
                {
                    TxQtdeLed.Enabled = true;
                    TxVled.Enabled = true;
                    TxWled.Enabled = true;
                    TxQtdeBarra.Enabled = true;
                    TxValorBarra.Enabled = true;
                    TxValorLed.Enabled = true;
                }
                else
                {
                    TxQtdeLed.Enabled = false;
                    TxVled.Enabled = false;
                    TxWled.Enabled = false;
                    TxQtdeBarra.Enabled = false;
                    TxValorBarra.Enabled = false;
                    TxValorLed.Enabled = false;
                }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCadModelo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxCadModelo_SelectedValueChanged(object sender, EventArgs e)
        {
            TxDescricao.Focus();
        }

        private void TxPartNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            //{
            //    e.Handled = true;
            //}
        }

        private void TxSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            //{
            //    e.Handled = true;
            //}
        }

        private void TxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxPrateleira_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxCompartimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxPartNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxSerie.Focus();
            }
        }

        private void TxSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CbStatus.Focus();
            }
        }

        private void CbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            TxValor.Focus();
        }

        private void TxValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxPavimento.Focus();
            }
        }

        private void TxPrateleira_KeyDown(object sender, KeyEventArgs e)
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
                TxCompartimento.Focus();
            }
        }

        private void TxCompartimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxQuantidade.Focus();
            }
        }

        private void TxDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxPartNumber.Focus();
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
                    CbTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChGerar.Checked.Equals(true))
                {
                    Random codigo = new Random();
                    String Valor = "ABCDEFGHIJKLMNOPQRSTUVYWXZ0123456789";
                    String Chave = String.Empty;

                    for (int i = 0; i < 3; i++)
                    {
                        Chave += Valor.Substring(codigo.Next(36), 1) + Valor.Substring(codigo.Next(36), 1);
                    }

                    TxSerie.Text = codigo.Next(999999999).ToString();
                    CbStatus.Focus();
                }
                else
                {
                    TxSerie.ResetText();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormModelo modelo = new FormModelo();
            modelo.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMarca marca = new FormMarca();
            marca.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmRBS rbs = new FrmRBS();
            rbs.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int contador = DgSerie.Rows.Count;

                if (!String.IsNullOrWhiteSpace(TxSerie.Text))
                {
                    Classes.Bioghet_BazarEmbal _BazarEmbal = new Classes.Bioghet_BazarEmbal();

                    _BazarEmbal.Tipo = CbTipo.Text;
                    _BazarEmbal.Marca = TxCadMarca.Text;
                    _BazarEmbal.Modelo = TxCadModelo.Text;
                    _BazarEmbal.Serie = TxSerie.Text;

                    int retorno = Classes.Bioghet_InserirMYSQL.Criar_BazarEMBAL(_BazarEmbal);

                    if (retorno.Equals(1))
                    {
                        DgSerie.Rows.Add("", TxSerie.Text);

                        contador = contador + 1;

                        TxQuantidade.Text = contador.ToString();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    throw new Exception("ATENÇÃO, FAVOR INFORME O NÚMERO DE SÉRIE");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChPartNumber_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChPartNumber.Checked.Equals(true))
                {
                    Random codigo = new Random();
                    String Valor = "ABCDEFGHIJKLMNOPQRSTUVYWXZ0123456789";
                    String Chave = String.Empty;

                    for (int i = 0; i < 3; i++)
                    {
                        Chave += Valor.Substring(codigo.Next(36), 1) + Valor.Substring(codigo.Next(36), 1);
                    }

                    TxPartNumber.Text = codigo.Next(999999999).ToString();
                    TxSerie.Focus();
                }
                else
                {
                    TxSerie.ResetText();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChLimpar.Checked.Equals(true))
                {
                    DgSerie.Rows.Clear();
                    Classes.Bioghet_ExcluirMYSQL.Excluir_BazarEmbalGeal(CbTipo.Text, TxCadMarca.Text, TxCadModelo.Text);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgModelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgModelos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
               if(e.KeyCode == Keys.Delete)
                {
                    DialogResult result = MessageBox.Show("VOCÊ ESTA PRESTE A REMOVER UM INTEM DA LISTA, DESEJA PROSSEGUIR COM A REMOÇÃO?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Int32 retorno = Classes.Bioghet_ExcluirMYSQL.Excluir_BazarEmbal(DgSerie.CurrentRow.Cells[1].Value.ToString(), Int32.Parse(DgSerie.CurrentRow.Cells[0].Value.ToString()));

                        if (retorno.Equals(1))
                        {
                            DgSerie.Rows.RemoveAt(DgSerie.CurrentRow.Index);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgModelos_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChCodPeca_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChCodPeca.Checked.Equals(true))
                {
                    Random codigo = new Random();
                    String Valor = "ABCDEFGHIJKLMNOPQRSTUVYWXZ0123456789";
                    String Chave = String.Empty;

                    for (int i = 0; i < 3; i++)
                    {
                        Chave += Valor.Substring(codigo.Next(36), 1) + Valor.Substring(codigo.Next(36), 1);
                    }

                    TxCodPeca.Text = codigo.Next(999999999).ToString();
                    TxSerie.Focus();
                }
                else
                {
                    TxSerie.ResetText();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxPavimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxSala.Focus();
            }
        }

        private void TxSala_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxPrateleira.Focus();
            }
        }

        private void DgSerie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex.Equals(0))
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {

                _barraled = null;
                TxQtdeLed.Text = "0";
                TxVled.Text = "0";
                TxWled.Text = "0";
                TxVTela.Text = "0";
                TxWTela.Text = "0";
                TxQtdeBarra.Text = "0";
                TxValorBarra.Text = "0";
                TxValorLed.Text = "0";
                TxMemo.ResetText();

                TxQtdeLed.Enabled = false;
                TxVled.Enabled = false;
                TxWled.Enabled = false;
                TxQtdeBarra.Enabled = false;
                TxValorBarra.Enabled = false;
                TxValorLed.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(TxCodigo.Text))
                    throw new Exception("CAMPO CODIGO É OBRIGATORIO");

                if (_barraled == null)
                {
                    _barraled = new Classes.Bioghet_BarraLed();
                    _barraled.Tipo = "BARRA DE LED";
                    _barraled.Marca = CbMarca.Text; 
                    _barraled.Modelo = CbModelo.Text;   
                    _barraled.CodigoBLED = TxCodigo.Text;
                    _barraled.QtdeLede = int.Parse(TxQtdeLed.Text); 
                    _barraled.QtdeBarra = int.Parse(TxQtdeBarra.Text);
                    _barraled.VTela = TxVTela.Text;
                    _barraled.WTela = TxWTela.Text;
                    _barraled.VLed = TxVled.Text;
                    _barraled.WLed = TxWled.Text;
                    _barraled.ValorBarra = Decimal.Parse(TxValorBarra.Text);
                    _barraled.ValorLed = Decimal.Parse(TxValorLed.Text);
                    _barraled.Obs = TxMemo.Text;

                    int retorno = Classes.Bioghet_InserirMYSQL.Criar_BarraLed(_barraled);

                    if (retorno.Equals(1))
                    {
                        MessageBox.Show("BAZAR CRIADO COM SUCESSO", "BAZAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TxQtdeLed.Enabled = false;
                        TxVled.Enabled = false;
                        TxWled.Enabled = false;
                        TxQtdeBarra.Enabled = false;
                        TxValorBarra.Enabled = false;
                        TxValorLed.Enabled = false;
                    }
                    else
                    {
                        throw new Exception("ERRO NO CADASTRO DO BAZAR");
                    }
                   
                }
                else
                {
                    _barraled.Tipo = "BARRA DE LED";
                    _barraled.Marca = CbMarca.Text;
                    _barraled.Modelo = CbModelo.Text;
                    _barraled.CodigoBLED = TxCodigo.Text;
                    _barraled.QtdeLede = Int32.Parse(TxQtdeLed.Text);
                    _barraled.QtdeBarra = Int32.Parse(TxQtdeBarra.Text);
                    _barraled.VTela = TxVTela.Text;
                    _barraled.WTela = TxWTela.Text;
                    _barraled.VLed = TxVled.Text;
                    _barraled.WLed = TxWled.Text;
                    _barraled.ValorBarra = Decimal.Parse(TxValorBarra.Text);
                    _barraled.ValorLed = Decimal.Parse(TxValorLed.Text);
                    _barraled.Obs = TxMemo.Text;

                    int retorno = Classes.Bioghet_UpdateMYSQL.Update_BarraLed(_barraled);

                    if (retorno.Equals(1))
                    {
                        MessageBox.Show("BAZAR ATUALIZADO COM SUCESSO", "ATUALIZAR BAZAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxQtdeLed.Enabled = false;
                        TxVled.Enabled = false;
                        TxWled.Enabled = false;
                        TxQtdeBarra.Enabled = false;
                        TxValorBarra.Enabled = false;
                        TxValorLed.Enabled = false;
                    }
                    else
                    {
                        throw new Exception("ERRO AO ATUALIZAR O BAZAR");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbTipoBarra_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    CbTipoBarra.Items.Clear();
                    Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();

                    for (int servico = 0; servico < Classes.Bioghet_Configuracao._servico.Count; servico++)
                    {
                        if (Classes.Bioghet_Configuracao._servico[servico].Descricao == "BARRA DE LED")
                            CbTipoBarra.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao);
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

        private void CbTipoBarra_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao._marca = Classes.Bioghet_ConsultaMysql.Listar_Marca("TELEVISOR");

                //Classes.Bioghet_Configuracao._marca = Classes.Bioghet_ConsultaMysql.Listar_Marca(CbTipoBarra.Text);

                CbMarca.Items.Clear();
                for (int i = 0; i < Classes.Bioghet_Configuracao._marca.Count; i++)
                {
                    CbMarca.Items.Add(Classes.Bioghet_Configuracao._marca[i].Descricao.ToUpper());
                }

                if (CbTipoBarra.Text == "BARRA DE LED")
                {
                    TxQtdeLed.Enabled = true;
                    TxVled.Enabled = true;
                    TxWled.Enabled = true;
                    TxQtdeBarra.Enabled = true;
                    TxValorBarra.Enabled = true;
                    TxValorLed.Enabled = true;
                    TxCodigo.Enabled = true;
                    TxVTela.Enabled = true;
                    TxWTela.Enabled = true;
                }
                else
                {
                    TxQtdeLed.Enabled = false;
                    TxVled.Enabled = false;
                    TxWled.Enabled = false;
                    TxQtdeBarra.Enabled = false;
                    TxValorBarra.Enabled = false;
                    TxValorLed.Enabled = false;
                    TxCodigo.Enabled = false;
                    TxVTela.Enabled = false;
                    TxWTela.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbMarca_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(CbMarca.Text, CbTipoBarra.Text);

                CbModelo.Items.Clear();


                Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_Modelo(Classes.Bioghet_Configuracao.CodigoMarca);


                for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                {
                    CbModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbMarca_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(CbMarca.Text, CbTipoBarra.Text);
                    Classes.Bioghet_Configuracao.Retorno = Classes.Bioghet_ConsultaMysql.Consultar_Marca(CbMarca.Text);

                    if (!Classes.Bioghet_Configuracao.Retorno.Equals(string.Empty))
                    {
                        CbModelo.Focus();
                    }
                    else
                    {
                        throw new Exception("MARCA NÃO ENCONTRADA, FAVOR VERIFIQUE");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbModelo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                CbModelo.Items.Clear();


                String _modelo = CbModelo.Text;
                Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_ModeloDigitado(_modelo.ToUpper());


                for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                {
                    CbModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                }

                CbModelo.DroppedDown = true;
            }
        }

        private void CbModelo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CbModelo_SelectedValueChanged(object sender, EventArgs e)
        {
            TxQtdeLed.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                DgBarraLed.Rows.Clear();

                List<Classes.Bioghet_BarraLed> barras = Classes.Bioghet_ConsultaMysql.Listar_Bazar_BarraLed(CbMarca.Text, CbModelo.Text);
                String[] Param = new string[12];

                for(int i = 0; i < barras.Count; i ++)
                {
                    Param[0] = barras[i].Marca;
                    Param[1] = barras[i].Modelo;
                    Param[2] = barras[i].CodigoBLED;
                    Param[3] = barras[i].QtdeLede.ToString();
                    Param[4] = barras[i].QtdeBarra.ToString();
                    Param[5] = barras[i].VTela.ToString();
                    Param[6] = barras[i].WTela.ToString();
                    Param[7] = barras[i].VLed.ToString();
                    Param[8] = barras[i].WLed.ToString();
                    Param[9] = barras[i].ValorBarra.ToString("#####0.00");
                    Param[10] = barras[i].ValorLed.ToString("#####0.00");
                    Param[11] = barras[i].Obs;

                    DgBarraLed.Rows.Add(Param);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgBarraLed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex.Equals(12))
                {
                    _barraled = new Classes.Bioghet_BarraLed();

                    CbMarca.Text = DgBarraLed.CurrentRow.Cells[0].Value.ToString();
                    CbModelo.Text = DgBarraLed.CurrentRow.Cells[1].Value.ToString();
                    TxCodigo.Text = DgBarraLed.CurrentRow.Cells[2].Value.ToString();
                    TxQtdeLed.Text = DgBarraLed.CurrentRow.Cells[3].Value.ToString();
                    TxQtdeBarra.Text = DgBarraLed.CurrentRow.Cells[4].Value.ToString();
                    TxVTela.Text = DgBarraLed.CurrentRow.Cells[5].Value.ToString();
                    TxWTela.Text = DgBarraLed.CurrentRow.Cells[6].Value.ToString();
                    TxVled.Text = DgBarraLed.CurrentRow.Cells[7].Value.ToString(); 
                    TxWled.Text = DgBarraLed.CurrentRow.Cells[8].Value.ToString();
                    TxValorBarra.Text = DgBarraLed.CurrentRow.Cells[9].Value.ToString();
                    TxValorLed.Text = DgBarraLed.CurrentRow.Cells[10].Value.ToString();
                    TxMemo.Text = DgBarraLed.CurrentRow.Cells[11].Value.ToString();

                    _barraled.Tipo = CbTipoBarra.Text;
                    _barraled.Marca = CbMarca.Text;
                    _barraled.Modelo = CbModelo.Text;
                    _barraled.QtdeLede = int.Parse(TxQtdeLed.Text);
                    _barraled.VTela = TxVTela.Text;
                    _barraled.WTela = TxWTela.Text;
                    _barraled.VLed = TxVled.Text;
                    _barraled.WLed = TxWled.Text;
                    _barraled.QtdeBarra = int.Parse(TxQtdeBarra.Text);
                    _barraled.ValorBarra = decimal.Parse(TxValorBarra.Text);
                    _barraled.ValorLed = decimal.Parse(TxValorLed.Text);
                    _barraled.Obs = TxMemo.Text;
                }

                if (e.ColumnIndex.Equals(13))
                {
                    DialogResult pergunta = MessageBox.Show("DESEJA REALMENTE EXCLUIR A BARRA DE LED " + DgBarraLed.CurrentRow.Cells[2].Value.ToString(), " EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (pergunta == DialogResult.Yes)
                    {
                        int retorno = Classes.Bioghet_ExcluirMYSQL.Excluir_BarraLed(DgBarraLed.CurrentRow.Cells[2].Value.ToString());
                        if (retorno.Equals(1))
                        {
                            MessageBox.Show("ITEM EXCLUIDO COM SUCESSO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DgBarraLed.Rows.Clear();
                        }
                        else
                        {
                            throw new Exception("ERRO AO EXCLUIR O ITEM DO BAZAR");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxValorBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxValorLed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxQtdeLed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxQtdeBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxQtdeLedBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxTotalLed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxVTela.Focus();
            }
        }

        private void TxVTela_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxWTela.Focus();
            }
        }

        private void TxWTela_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if (!String.IsNullOrWhiteSpace(TxVTela.Text) && !String.IsNullOrWhiteSpace(TxWTela.Text))
                //{
                //    Decimal SomaVTela = Decimal.Divide(Decimal.Parse(TxVTela.Text), Decimal.Parse(TxWTela.Text));
                //    TxVled.Text = SomaVTela.ToString("#####0.00");

                //    Decimal SomaVTotalLed = Decimal.Divide(Decimal.Parse(TxVTela.Text), Decimal.Parse(TxVled.Text));
                //    TxQtdeLed.Text = SomaVTotalLed.ToString("#####0.00");

                //    //Decimal SomaWTotalLed = Decimal.Divide(Decimal.Parse(TxWTela.Text), Decimal.Parse(TxQtdeLed.Text));
                //    //TxWled.Text = SomaWTotalLed.ToString("#####0.00");
                //}

                TxVled.Focus();
            }
        }

        private void TxQtdeLed_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TxWled.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void TxQtdeBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxValorBarra.Focus();
            }
        }

        private void TxVled_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxQtdeLed.Focus();
            }
        }

        private void TxWled_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxQtdeBarra.Focus();
            }
        }

        private void TxTBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxValorBarra.Focus();
            }
        }

        private void TxValorBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxValorLed.Focus();
            }
        }

        private void TxValorLed_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TxVTela_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            //{
            //    e.Handled = true;

            //}
        }

        private void TxWTela_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            //{
            //    e.Handled = true;

            //}
        }

        private void TxVled_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            //{
            //    e.Handled = true;

            //}
        }

        private void TxWled_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            //{
            //    e.Handled = true;

            //}
        }

        private void TxTBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private String CriarRelatorioBarraLed()
        {
            DataGridView DgURL = new DataGridView();
            DgURL.Columns.Add("TIPO", "TIPO");
            DgURL.Columns.Add("MARCA", "MARCA");
            DgURL.Columns.Add("MODELO", "MODELO");
            DgURL.Columns.Add("CODIGO", "CODIGO");
            DgURL.Columns.Add("QTDELED", "QTDELED");
            DgURL.Columns.Add("QTDEBARRA", "QTDEBARRA");
            DgURL.Columns.Add("VTELA", "VTELA");
            DgURL.Columns.Add("WTELA", "WTELA");
            DgURL.Columns.Add("VLED", "VLED");
            DgURL.Columns.Add("WLED", "WLED");
            DgURL.Columns.Add("VALORBARRA", "VALORBARRA");
            DgURL.Columns.Add("VALORLED", "VALORLED");

            List<Classes.Bioghet_BarraLed> bioghet_Apps = Classes.Bioghet_ConsultaMysql.Listar_Bazar_BarraLed(CbMarca.Text, CbModelo.Text);
            String[] Param = new String[13];

            for (int i = 0; i < bioghet_Apps.Count; i++)
            {
                Param[0] = bioghet_Apps[i].Tipo;
                Param[1] = bioghet_Apps[i].Marca;
                Param[2] = bioghet_Apps[i].Modelo;
                Param[3] = bioghet_Apps[i].CodigoBLED;
                Param[4] = bioghet_Apps[i].QtdeLede.ToString();
                Param[5] = bioghet_Apps[i].QtdeBarra.ToString();
                Param[6] = bioghet_Apps[i].VTela.ToString();
                Param[7] = bioghet_Apps[i].WTela.ToString();
                Param[8] = bioghet_Apps[i].VLed.ToString();
                Param[9] = bioghet_Apps[i].WLed.ToString();
                Param[10] = bioghet_Apps[i].ValorBarra.ToString("#####0.00");
                Param[11] = bioghet_Apps[i].ValorLed.ToString("#####0.00");

                DgURL.Rows.Add(Param);
            }

            String formatohtml = String.Empty;

            Font fonte = DgURL.ColumnHeadersDefaultCellStyle.Font;

            int tabSize = 0;
            foreach (DataGridViewColumn col in DgURL.Columns)
                if (col.Visible) tabSize += col.Width;

            string[] conteudo = new string[DgURL.Columns.Count];

            formatohtml = ("<html><head>");
            formatohtml += ("<meta http-equiv='Content-Type' "
                + "content='text/html; charset=utf-8' />");
            formatohtml += ("<title>" + "RELAÇÃO DE BARRA DE LEDS" + "</title>");
            formatohtml += ("</head><body>");
            //formatohtml += ("<center><p><image src='" + Environment.CurrentDirectory + "\\logotelecentro.png" + "' align='middle'><image src='" + Environment.CurrentDirectory + "\\logobioghet.png"+ "' align='middle'></p></center>");
            formatohtml += ("<div style='text-align:center; font-weight:bold; font-size:20px'>RELATÓRIO DE BARRA DE LEDS</div> ");
            formatohtml += ("<br>");
            formatohtml += ("<div style='position:static'>");
            formatohtml += ("<table align=center style='border-collapse: collapse; width:"
                + tabSize.ToString() + "px'>");
            formatohtml += ("<tr>");

            foreach (DataGridViewColumn coluna in DgURL.Columns)
            {
                if (coluna.Visible)
                {
                    formatohtml += ("<td style='padding: 2px 2px 2px 2px; "
                        + "font-weight:bold; font-size:"
                        + Convert.ToInt32(fonte.Size + 3).ToString()
                        + "px; border-collapse: collapse; ' align='"
                        + coluna.InheritedStyle.Alignment.ToString().Substring(6,
                            coluna.InheritedStyle.Alignment.ToString().Length - 6)
                        + "' width='" + coluna.Width + "'>");
                    formatohtml += ("<font face='" + fonte.Name + "'>");
                    formatohtml += (coluna.HeaderText.ToString());
                    formatohtml += ("</font>");
                    formatohtml += ("</td>");
                }
            }
            formatohtml += ("</tr>");
            if (DgURL.Rows.Count > 0)
            {
                foreach (DataGridViewRow linha in DgURL.Rows)
                {
                    formatohtml += ("<tr>");
                    foreach (DataGridViewCell celula in linha.Cells)
                    {
                        if (celula.Visible)
                        {
                            formatohtml += ("<td style='padding: 2px 2px 2px 2px; font-size:"
                                + Convert.ToInt32(fonte.Size + 3).ToString()
                                + "; border-collapse: collapse; ' align='"
                                + celula.InheritedStyle.Alignment.ToString().Substring(6,
                                    celula.InheritedStyle.Alignment.ToString().Length - 6)
                                + "' width='" + celula.Size.Width + "'>");
                            formatohtml += ("<font face='" + fonte.Name + "'>"
                                + celula.FormattedValue.ToString() + "</font>");
                            formatohtml += ("</td>");
                        }
                    }
                    formatohtml += ("</tr>");
                }
            }
            formatohtml += ("</table></div></body></html>");

            formatohtml += ("<br>");
            formatohtml += ("<br>");
            formatohtml += ("<hr />");
            formatohtml += ("<br>");
            formatohtml += ("<br>");

            return formatohtml;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter(Environment.CurrentDirectory + "\\Relatorio\\BaraLed.html");
                arquivo.WriteLine(CriarRelatorioBarraLed());
                arquivo.Flush();
                arquivo.Close();

                DialogResult Pergunta = MessageBox.Show("ARQUIVO GERADO COM SUCESSO, DESEJA VISUALIZAR O ARQUIVO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (Pergunta == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\Relatorio\\BaraLed.html");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                Random codigo = new Random();
                String Valor = "ABCDEFGHIJKLMNOPQRSTUVYWXZ0123456789";
                String Chave = String.Empty;

                for (int i = 0; i < 3; i++)
                {
                    Chave += Valor.Substring(codigo.Next(36), 1) + Valor.Substring(codigo.Next(36), 1);
                }

                TxCodigo.Text = Chave;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
