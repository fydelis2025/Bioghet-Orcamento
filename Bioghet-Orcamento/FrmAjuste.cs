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
    public partial class FrmAjuste : Form
    {
        public FrmAjuste()
        {
            InitializeComponent();
        }

        internal List<MaoObra> _mobra = null;
        private void FrmAjuste_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
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

        private void TxCadModelo_TextChanged(object sender, EventArgs e)
        {
            try
            {


                Classes.Bioghet_Configuracao._mod = Classes.Bioghet_ConsultaMysql.Consultar_ModeloVALORES(TxCadModelo.Text);
                

                if (Classes.Bioghet_Configuracao._mod != null)
                {
                    TxNovo.Text = Classes.Bioghet_Configuracao._mod.Novo.ToString("#####0.00");
                    TxMargem.Text = Classes.Bioghet_Configuracao._mod.Margem.ToString("#####0.00");
                    TxAparelho.Text = Classes.Bioghet_Configuracao._mod.Usado.ToString("#####0.00");
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

       

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void TxMgNovo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxMgUsado_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxMgMO_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    
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
                    CbTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Decimal Valor, Margem, ValorMo, MargemMo, ValorMargem, VMO, VToal, PrecoNovo, PrecoUsado, MPNovo, MPUsado;
        private int Codigo;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(ChDeletar.Checked.Equals(true))
                {
                    int excluir = Classes.Bioghet_DeleteSQL.Excluir_MaodeObra(CbTipo.Text, TxCadMarca.Text, TxCadModelo.Text);

                    if(excluir.Equals(1))
                    {
                        throw new Exception("ERRO AO EXCLUIR TODOS OS REGISTROS");
                    }
                    else
                    {
                        MessageBox.Show("TODOS OS REGISTROS DO ORÇAMENTO FORAM EXCLUIDOS COM SUCESSO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    List<MaoObra> _listar = Classes.Bioghet_ConsultaMysql.Listar_MargemOrcamento(CbTipo.Text, TxCadMarca.Text, TxCadModelo.Text);

                    for (int i = 0; i < _listar.Count; i++)
                    {
                        Codigo = _listar[i].ID;

                        if (ChMargemMais.Checked.Equals(true))
                        {
                            if (!TxReajusteMargem.Text.Equals("0"))
                            {
                                Margem = Decimal.Parse(TxReajusteMargem.Text);
                                Valor = Decimal.Multiply(_listar[i].Valor, Margem) / 100;
                                ValorMargem = Decimal.Add(_listar[i].Valor, Valor);

                                MPNovo = Decimal.Multiply(_listar[i].PrecoNovo, Margem) / 100;
                                PrecoNovo = Decimal.Add(_listar[i].PrecoNovo, MPNovo);

                                MPUsado = Decimal.Multiply(_listar[i].PrecoUsado, Margem) / 100;
                                PrecoUsado = Decimal.Add(_listar[i].PrecoUsado, MPUsado);
                                //_listar[i].Total = _listar[i].Valor + _listar[i].ValorMO;
                            }
                           
                        }
                        else
                        {
                            PrecoNovo = _listar[i].PrecoNovo;
                            PrecoUsado = _listar[i].PrecoUsado;
                            ValorMargem = _listar[i].Valor;
                        }

                        if (ChMargemMenos.Checked.Equals(true))
                        {
                            if (!TxReajusteMargem.Text.Equals("0"))
                            {
                                Margem = Decimal.Parse(TxReajusteMargem.Text);
                                Valor = Decimal.Multiply(_listar[i].Valor, Margem) / 100;
                                ValorMargem = Decimal.Subtract(_listar[i].Valor, Valor);

                                MPNovo = Decimal.Multiply(_listar[i].PrecoNovo, Margem) / 100;
                                PrecoNovo = Decimal.Subtract(_listar[i].PrecoNovo, MPNovo);

                                MPUsado = Decimal.Multiply(_listar[i].PrecoUsado, Margem) / 100;
                                PrecoUsado = Decimal.Subtract(_listar[i].PrecoUsado, MPUsado);
                                //_listar[i].Total = _listar[i].Valor + _listar[i].ValorMO;
                            }
                            
                        }
                        else
                        {
                            PrecoNovo = _listar[i].PrecoNovo;
                            PrecoUsado = _listar[i].PrecoUsado;
                            ValorMargem = _listar[i].Valor;
                        }

                        //-----------------------------------------------
                        if (ChMOMais.Checked.Equals(true))
                        {
                            if (!TxReajusteMO.Text.Equals("0"))
                            {
                                MargemMo = Decimal.Parse(TxReajusteMO.Text);
                                ValorMo = Decimal.Multiply(_listar[i].ValorMO, MargemMo) / 100;
                                VMO = Decimal.Add(_listar[i].ValorMO, ValorMo);

                                MPNovo = Decimal.Multiply(_listar[i].PrecoNovo, Margem) / 100;
                                PrecoNovo = Decimal.Add(_listar[i].PrecoNovo, MPNovo);

                                MPUsado = Decimal.Multiply(_listar[i].PrecoUsado, Margem) / 100;
                                PrecoUsado = Decimal.Add(_listar[i].PrecoUsado, MPUsado);
                            }
                        }
                        else
                        {
                            VMO = _listar[i].ValorMO;
                        }

                        if (ChMOMenos.Checked.Equals(true))
                        {
                            if (!TxReajusteMO.Text.Equals("0"))
                            {
                                MargemMo = Decimal.Parse(TxReajusteMO.Text);
                                ValorMo = Decimal.Multiply(_listar[i].ValorMO, MargemMo) / 100;
                                VMO = Decimal.Subtract(_listar[i].ValorMO, ValorMo);

                                MPNovo = Decimal.Multiply(_listar[i].PrecoNovo, Margem) / 100;
                                PrecoNovo = Decimal.Subtract(_listar[i].PrecoNovo, MPNovo);

                                MPUsado = Decimal.Multiply(_listar[i].PrecoUsado, Margem) / 100;
                                PrecoUsado = Decimal.Subtract(_listar[i].PrecoUsado, MPUsado);
                            }
                        }
                        else
                        {
                            VMO = _listar[i].ValorMO;
                        }

                        VToal = Decimal.Add(ValorMargem, VMO);

                        int retorno = Classes.Bioghet_UpdateMYSQL.Update_ValoresOrcamento(ValorMargem, VMO, VToal, Codigo, PrecoNovo, PrecoUsado);
                        int retorno1 = Classes.Bioghet_UpdateMYSQL.Update_ValoresModelo(PrecoNovo, PrecoUsado, TxCadModelo.Text);

                    }

                    MessageBox.Show("TODOS OS REGISTROS FORAM ATUALIZADOS COM SUCESSO", "ATUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool mouseClicked;
        Point clickedAt;
        private void FrmAjuste_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void FrmAjuste_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void FrmAjuste_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
