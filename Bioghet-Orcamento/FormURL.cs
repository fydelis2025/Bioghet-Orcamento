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
    public partial class FormURL : Form
    {
        public FormURL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Url _url = null;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrWhiteSpace(TxNome.Text)&&!String.IsNullOrWhiteSpace(TxDescricao.Text))
                {
                    _url = new Url();
                    _url.Nome = TxNome.Text;
                    _url.Descricao = TxDescricao.Text;


                    Classes.Bioghet_InserirMYSQL.Criar_URL(_url);

                    MessageBox.Show("URL CRIADA COM SUCESSO");

                    TxNome.ResetText();
                    TxDescricao.ResetText();
                    
                   
                }
                else
                {
                    throw new Exception("INFORME OS DADOS CADASTRAIS");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DgConsulta.Rows.Clear();


                Classes.Bioghet_Configuracao.url = Classes.Bioghet_ConsultaMysql.Listar_Url();
                
                string[] param = new string[2];
                for (int i = 0; i < Classes.Bioghet_Configuracao.url.Count; i++)
                {
                    param[0] = Classes.Bioghet_Configuracao.url[i].Nome;
                    param[1] = Classes.Bioghet_Configuracao.url[i].Descricao;

                    DgConsulta.Rows.Add(param);
                }
            }
        }

        private void FormURL_Load(object sender, EventArgs e)
        {

        }

        private void DgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex.Equals(2))
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir o item" + DgConsulta.CurrentRow.Cells[0].Value, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(result == System.Windows.Forms.DialogResult.Yes)
                    {

                        Classes.Bioghet_DeleteSQL.ExcluirURL(DgConsulta.CurrentRow.Cells[0].Value.ToString());
                        
                        MessageBox.Show("Url excluido com sucesso");
                        DgConsulta.Rows.Clear();


                        Classes.Bioghet_Configuracao.url = Classes.Bioghet_ConsultaMysql.Listar_Url();
                        
                        string[] param = new string[2];
                        for (int i = 0; i < Classes.Bioghet_Configuracao.url.Count; i++)
                        {
                            param[0] = Classes.Bioghet_Configuracao.url[i].Nome;
                            param[1] = Classes.Bioghet_Configuracao.url[i].Descricao;

                            DgConsulta.Rows.Add(param);
                        }
                    }
                }

                if(e.ColumnIndex.Equals(3))
                {

                    Classes.Bioghet_Configuracao._Retorno = Classes.Bioghet_ConsultaMysql.IDUrl(DgConsulta.CurrentRow.Cells[0].Value.ToString(), DgConsulta.CurrentRow.Cells[1].Value.ToString());
                    Classes.Bioghet_UpdateSQL.Atualizar_URL(Classes.Bioghet_Configuracao._Retorno, DgConsulta.CurrentRow.Cells[0].Value.ToString(), DgConsulta.CurrentRow.Cells[1].Value.ToString());
                    

                    MessageBox.Show("URL ATUALIZADO COM SUCESSO");
                    DgConsulta.Rows.Clear();


                    Classes.Bioghet_Configuracao.url = Classes.Bioghet_ConsultaMysql.Listar_Url();
                    

                    string[] param = new string[2];
                    for (int i = 0; i < Classes.Bioghet_Configuracao.url.Count; i++)
                    {
                        param[0] = Classes.Bioghet_Configuracao.url[i].Nome;
                        param[1] = Classes.Bioghet_Configuracao.url[i].Descricao;

                        DgConsulta.Rows.Add(param);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChTudo_Click(object sender, EventArgs e)
        {
            try
            {
                if(ChTudo.Checked.Equals(true))
                {
                    DgConsulta.Rows.Clear();


                    Classes.Bioghet_Configuracao.url = Classes.Bioghet_ConsultaMysql.Listar_Url();
                    
                    string[] param = new string[2];
                    for (int i = 0; i < Classes.Bioghet_Configuracao.url.Count; i++)
                    {
                        param[0] = Classes.Bioghet_Configuracao.url[i].Nome;
                        param[1] = Classes.Bioghet_Configuracao.url[i].Descricao;

                        DgConsulta.Rows.Add(param);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DgConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                TxNome.Text = DgConsulta.CurrentRow.Cells[0].Value.ToString();
                TxDescricao.Text = DgConsulta.CurrentRow.Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
