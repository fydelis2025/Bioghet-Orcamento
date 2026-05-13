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
    public partial class FormTipoServico : Form
    {
        public FormTipoServico()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        TipoServico servico = null;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(servico == null)
                {
                    if (!String.IsNullOrWhiteSpace(TxDescricao.Text))
                    {
                        servico = new TipoServico();
                        servico.Descricao = TxDescricao.Text;

                        Classes.Bioghet_InserirMYSQL.Criar_TipoServico(servico);

                        TxDescricao.ResetText();
                        servico = null;

                        DgTipoServico.Rows.Clear();


                        Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();
                        

                        string[] param = new string[1];
                        for (int i = 0; i < Classes.Bioghet_Configuracao._servico.Count; i++)
                        {
                            param[0] = Classes.Bioghet_Configuracao._servico[i].Descricao;

                            DgTipoServico.Rows.Add(param);
                        }
                    }
                    else
                    {
                        throw new Exception("NÃO FOI POSSÍVEL SALVAR O TIPO DO APARELHO");
                    }
                }
                else
                {
                    servico = new TipoServico();
                    servico.Descricao = TxDescricao.Text;
                    TxDescricao.ResetText();
                    servico = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Servico()
        {
            try
            {
                DgTipoServico.Rows.Clear();


                Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();
                

                string[] param = new string[1];
                for (int i = 0; i < Classes.Bioghet_Configuracao._servico.Count; i++)
                {
                    param[0] = Classes.Bioghet_Configuracao._servico[i].Descricao;

                    DgTipoServico.Rows.Add(param);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormTipoServico_Load(object sender, EventArgs e)
        {
            try
            {
                servico = null;
                DgTipoServico.Rows.Clear();


                Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();
                

                string[] param = new string[1];
                for (int i = 0; i < Classes.Bioghet_Configuracao._servico.Count; i++)
                {
                    param[0] = Classes.Bioghet_Configuracao._servico[i].Descricao;

                    DgTipoServico.Rows.Add(param);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void DgTipoServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex.Equals(1))
                {

                    Classes.Bioghet_Configuracao.codigo = Classes.Bioghet_ConsultaMysql.Consultar_IDTipoServico(DgTipoServico.CurrentRow.Cells[0].Value.ToString());
                    

                    if (!Classes.Bioghet_Configuracao.codigo.Equals(0))
                    {

                        Classes.Bioghet_DeleteMYSQL.ExcluirTipoServico(Classes.Bioghet_Configuracao.codigo);
                        MessageBox.Show("TIPO DO SERVIÇO FOI EXCLUIDO COM SUCESSO");

                            Listar_Servico();
                        
                    }
                    else
                    {
                        throw new Exception("ERRO AO PROCESSAR A EXCLUSÃO DO TIPO DO SERVIÇO");
                    }
                }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool mouseClicked;
        Point clickedAt;
        private void FormTipoServico_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void FormTipoServico_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void FormTipoServico_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }
    }
}
