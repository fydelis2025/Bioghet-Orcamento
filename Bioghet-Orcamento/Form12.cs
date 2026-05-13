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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private Bioghet_Orcamento.Classes.Bioghet_URL _url = null;

        private void Form12_Load(object sender, EventArgs e)
        {
            try
            {
                _url = null;

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _url = null;
                TxURL.ResetText();

             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Consultar_URL()
        {
            try
            {
                List<Classes.Bioghet_URL> _listar = Classes.Bioghet_ConsultaMysql.Listar_BioghetURLtipo(CbReferencia.Text, CbTipo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               if(_url == null)
               {
                    _url = new Classes.Bioghet_URL();
                    _url.Referencia = CbReferencia.Text;
                    _url.Tipo = CbTipo.Text;
                    _url.Marca = TxMarca.Text;
                    _url.Status = CbStatus.Text;
                    if(CbTestado.Text.Equals("SIM"))
                    {
                        _url.Testado = true;
                    }
                    else
                    {
                        _url.Testado = false;
                    }
                    _url.URL = TxURL.Text;

                    int retorno = Classes.Bioghet_InserirMYSQL.Criar_BioghetURL(_url);
                    if(retorno.Equals(1))
                    {
                        MessageBox.Show("URL CADASTRADO COM SUCESSO");
                    }
                    else
                    {
                        MessageBox.Show("ERRO AO CADASTRAR A URL");
                    }
               }
               else
               {
                    _url.Referencia = CbReferencia.Text;
                    _url.Tipo = CbTipo.Text;
                    _url.Marca = TxMarca.Text;
                    _url.Status = CbStatus.Text;
                    if (CbTestado.Text.Equals("SIM"))
                    {
                        _url.Testado = true;
                    }
                    else
                    {
                        _url.Testado = false;
                    }

                    _url.URL = TxURL.Text;

                    int retorno = Classes.Bioghet_UpdateMYSQL.Update_BioghetURL(_url);
                    if (retorno.Equals(1))
                    {
                        MessageBox.Show("URL CADASTRADO COM SUCESSO");
                    }
                    else
                    {
                        MessageBox.Show("ERRO AO CADASTRAR A URL");
                    }
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
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void DgConsulta_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(0))
                {
                    System.Diagnostics.Process.Start(DgConsulta.CurrentRow.Cells[0].Value.ToString());
                }

                if (e.ColumnIndex.Equals(6))
                {
                    CbReferencia.Text = DgConsulta.CurrentRow.Cells[1].Value.ToString();
                    CbTipo.Text = DgConsulta.CurrentRow.Cells[2].Value.ToString();
                    TxMarca.Text = DgConsulta.CurrentRow.Cells[3].Value.ToString();
                    CbStatus.Text = DgConsulta.CurrentRow.Cells[4].Value.ToString();
                    if(DgConsulta.CurrentRow.Cells[5].Value.Equals(true))
                    {
                        CbTestado.Text = "SIM";
                    }
                    else
                    {
                        CbTestado.Text = "NAO";
                    }

                    TxURL.Text = DgConsulta.CurrentRow.Cells[0].Value.ToString();

                    TxURL.Focus();
                }

                if (e.ColumnIndex.Equals(7))
                {
                    DialogResult pergunta;
                    pergunta = MessageBox.Show("DESEJA REALMENTE EXCLUIR A URL " + DgConsulta.CurrentRow.Cells[0].Value.ToString(), "EXCLUIR URL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(pergunta == DialogResult.Yes)
                    {
                        int retorno = Classes.Bioghet_DeleteMYSQL.Excluir_URL(DgConsulta.CurrentRow.Cells[1].Value.ToString(), DgConsulta.CurrentRow.Cells[3].Value.ToString(), DgConsulta.CurrentRow.Cells[0].Value.ToString());

                        if(retorno.Equals(1))
                        {
                            MessageBox.Show("URL EXCLUIDO COM SUCESSO");
                        }
                        else
                        {
                            throw new Exception("ERRO AO EXCLUIR A URL");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbReferencia_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                /*DgConsulta.Rows.Clear();
                List<Classes.Bioghet_URL> _listar = Classes.Bioghet_ConsultaMysql.Listar_BioghetURL(CbReferencia.Text);

                string[] param = new string[6];

                for(int i = 0; i < _listar.Count; i++)
                {
                    param[0] = _listar[i].URL;
                    param[1] = _listar[i].Referencia;
                    param[2] = _listar[i].Tipo;
                    param[3] = _listar[i].Marca;
                    param[4] = _listar[i].Status;
                    param[5] = _listar[i].Testado.ToString();

                    DgConsulta.Rows.Add(param);
                }*/
            }
            catch (Exception ex)
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
                for (int i = 0; i < Classes.Bioghet_Configuracao._marca.Count; i++)
                {
                    TxMarca.Items.Add(Classes.Bioghet_Configuracao._marca[i].Descricao.ToUpper());
                }

                DgConsulta.Rows.Clear();
                List<Classes.Bioghet_URL> _listar = Classes.Bioghet_ConsultaMysql.Listar_BioghetURLtipo(CbReferencia.Text, CbTipo.Text);
                string[] param = new string[6];
                for (int i = 0; i < _listar.Count; i++)
                {
                    param[0] = _listar[i].URL;
                    param[1] = _listar[i].Referencia;
                    param[2] = _listar[i].Tipo;
                    param[3] = _listar[i].Marca;
                    param[4] = _listar[i].Status;
                    param[5] = _listar[i].Testado.ToString();

                    DgConsulta.Rows.Add(param);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
