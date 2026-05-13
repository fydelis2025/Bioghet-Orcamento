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
    public partial class FormLaudoTecnico : Form
    {
        public FormLaudoTecnico()
        {
            InitializeComponent();
        }

        private LaudoTecnico _laudo;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLaudoTecnico_Load(object sender, EventArgs e)
        {
            try
            {
                _laudo = null;


                Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();
                

                for (int servico = 0; servico < Classes.Bioghet_Configuracao._servico.Count; servico++)
                {
                    CbTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao.ToUpper());
                }


                Classes.Bioghet_Configuracao.func = Classes.Bioghet_ConsultaMysql.Listar_Funcionario();
                
                for (int i = 0; i < Classes.Bioghet_Configuracao.func.Count; i++)
                {
                    TxFuncionario.Items.Add(Classes.Bioghet_Configuracao.func[i].Nome);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao._marca = Classes.Bioghet_ConsultaMysql.Listar_Marca(CbTipo.Text);

                TxMarca.Items.Clear();
                for (int m = 0; m < Classes.Bioghet_Configuracao._marca.Count; m++)
                {
                    TxMarca.Items.Add(Classes.Bioghet_Configuracao._marca[m].Descricao.ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(TxMarca.Text, CbTipo.Text);
                Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_Modelo(Classes.Bioghet_Configuracao.CodigoMarca);
                

                TxModelo.ResetText();

                TxModelo.Items.Clear();

                for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                {
                    TxModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                }

                TxModelo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxMarca_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    String retorno = string.Empty;


                    retorno = Classes.Bioghet_ConsultaMysql.Consultar_Marca(TxMarca.Text);

                    if (!retorno.Equals(string.Empty))
                    {
                        TxModelo.Focus();
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

        private void TxModelo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TxDefeito.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);

                    //TxModelo.Items.Clear();

                    //if (LbStatusInternet.Text.Equals(Classes.Bioghet_Configuracao.StatusInternet.OFFILINE.ToString()))
                    //{
                    //    String _modelo = e.KeyChar.ToString();
                    //    Classes.Bioghet_Configuracao._modelo = Listar.Listar_ModeloDigitado(_modelo.ToUpper());
                    //}
                    //else
                    //{
                    //    String _modelo = e.KeyChar.ToString();
                    //    Classes.Bioghet_Configuracao._modelo = ONLINE.Listar.Listar_ModeloDigitado(_modelo.ToUpper());
                    //}

                    //for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                    //{
                    //    TxModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxModelo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TxModelo.Items.Clear();

             
                    String _modelo = TxModelo.Text;
                Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_ModeloDigitado(_modelo.ToUpper());
                

                for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                {
                    TxModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                }

                TxModelo.DroppedDown = true;
            }
        }

        private void TxDefeito_Click(object sender, EventArgs e)
        {
            try
            {
                TxDefeito.Items.Clear();


                Classes.Bioghet_Configuracao._Listardef = Classes.Bioghet_ConsultaMysql.Listar_Defeito(CbTipo.Text);
                

                for (int r = 0; r < Classes.Bioghet_Configuracao._Listardef.Count; r++)
                {
                    TxDefeito.Items.Add(Classes.Bioghet_Configuracao._Listardef[r].Descricao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxDefeito_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxImei.Focus();
        }

        private void TxDefeito_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxImei.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(TxImei.Text))
                {
                    Classes.Bioghet_Configuracao.campo = TxImei.Text;
                    RptLaudo laudo = new RptLaudo();
                    laudo.ShowDialog();
                }
                else
                {
                    throw new Exception("LAUDO NÃO ENCONTRADO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                _laudo = null;
                CbTipo.SelectedIndex = 0;
                TxMarca.ResetText();
                TxModelo.ResetText();
                TxDefeito.ResetText();
                TxImei.ResetText();
                TxCliente.ResetText();
                TxCpf.ResetText();
                TxFuncionario.ResetText();
                TxDefeito.ResetText();
                TxLaudo.ResetText();
                TxDescricao.ResetText();
                TxLaudo.ResetText();
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
                if(_laudo == null)
                {
                    if (!String.IsNullOrWhiteSpace(TxImei.Text) && (!String.IsNullOrWhiteSpace(TxDescricao.Text) && (!String.IsNullOrWhiteSpace(TxLaudo.Text))))
                    {
                        _laudo = new LaudoTecnico();
                        _laudo.Tipo = CbTipo.Text;
                        _laudo.Marca = TxMarca.Text;
                        _laudo.Modelo = TxModelo.Text;
                        _laudo.Defeito = TxDefeito.Text;
                        _laudo.Imei = TxImei.Text;
                        _laudo.Nome = TxCliente.Text;
                        _laudo.CPF = TxCpf.Text;
                        _laudo.Funcionario = TxFuncionario.Text;
                        _laudo.Reclamado = TxDescricao.Text;
                        _laudo.Laudo = TxLaudo.Text;


                        Classes.Bioghet_InserirMYSQL.Criar_Laudo(_laudo);
                        

                        MessageBox.Show("LAUDO CRIADO COM SUCESSO", "LAUDO TÉCNICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("IMPOSSÍVEL PROSSEGUIR COM CAMPOS OBRIGATÓRIOS NULOS");
                    }
                }
                else
                {
                    _laudo.Tipo = CbTipo.Text;
                    _laudo.Marca = TxMarca.Text;
                    _laudo.Modelo = TxModelo.Text;
                    _laudo.Defeito = TxDefeito.Text;
                    _laudo.Imei = TxImei.Text;
                    _laudo.Nome = TxCliente.Text;
                    _laudo.CPF = TxCpf.Text;
                    _laudo.Funcionario = TxFuncionario.Text;
                    _laudo.Reclamado = TxDescricao.Text;
                    _laudo.Laudo = TxLaudo.Text;

                    if (Classes.Bioghet_Configuracao.StatusConexao.Equals(Classes.Bioghet_Configuracao.StatusInternet.OFFILINE.ToString()))
                    {

                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int count = 0;
                foreach (char c in TxDescricao.Text)
                {
                    count++;
                    LbCaractereDefeito.Text = count.ToString();

                    if (count.Equals(200))
                    {
                        throw new Exception("LIMITE DE CARACTERE EXCEDIDO");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxLaudo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int count = 0;
                foreach (char c in TxLaudo.Text)
                {
                    count++;
                    LbCaractereLaudo.Text = count.ToString();

                    if (count.Equals(200))
                    {
                        throw new Exception("LIMITE DE CARACTERE EXCEDIDO");
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
