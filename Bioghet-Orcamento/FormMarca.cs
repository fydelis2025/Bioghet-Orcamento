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
    public partial class FormMarca : Form
    {
        public FormMarca()
        {
            InitializeComponent();
        }

        private Marca _marca;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void limpar_campos()
        {
            TxDescricao.ResetText();

            _marca = null;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao.retorno = Classes.Bioghet_ConsultaMysql.get_MARCA_Dpl(TxDescricao.Text, TxTipo.Text);

                if (_marca == null)
                {
                    _marca = new Marca();

                    _marca.Descricao = TxDescricao.Text;
                    _marca.Tipo = TxTipo.Text;

                    if (Classes.Bioghet_Configuracao.retorno.Equals(false))
                    {

                        Classes.Bioghet_InserirMYSQL.Criar_Marca(_marca);

                        MessageBox.Show("MODELO CRIADO COM SUCESSO");
                    }
                    else
                    {
                        throw new Exception("MODELO JA CADASTRADO");
                    }
                }
                else
                {

                    Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(DgConsulta.CurrentRow.Cells[0].Value.ToString(), TxTipo.Text);
                    
                    _marca.Descricao = TxDescricao.Text;

                    Classes.Bioghet_UpdateMYSQL.Atualizar_Marca(_marca);
                  
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpar_campos();
        }

        private void DgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 1)
                {
                    DialogResult result = MessageBox.Show("Deseja excluir a marca " + DgConsulta.CurrentRow.Cells[0].Value, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(result == System.Windows.Forms.DialogResult.Yes)
                    {

                        Classes.Bioghet_DeleteMYSQL.ExcluirMarca(DgConsulta.CurrentRow.Cells[0].Value.ToString());

                        MessageBox.Show("MARCA " + DgConsulta.CurrentRow.Cells[0].Value + " EXCLUIDO COM SUCESSO");
                    }
                }

                if (e.ColumnIndex == 2)
                {
                    TxDescricao.Text = DgConsulta.CurrentRow.Cells[0].Value.ToString();

                    _marca = new Marca();
                    _marca.Descricao = DgConsulta.CurrentRow.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChTudo_Click(object sender, EventArgs e)
        {
            try
            {
                DgConsulta.Rows.Clear();

                

                Classes.Bioghet_Configuracao._list = Classes.Bioghet_ConsultaMysql.Listar_Marca(TxTipo.Text);
                

                string[] param = new string[1];
                for (int i = 0; i < Classes.Bioghet_Configuracao._list.Count; i++)
                {
                    param[0] = Classes.Bioghet_Configuracao._list[i].Descricao;

                    DgConsulta.Rows.Add(param);
                }
 

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();

                for (int servico = 0; servico < Classes.Bioghet_Configuracao._servico.Count; servico++)
                {
                    TxTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao.ToUpper());
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
        private void FormMarca_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void FormMarca_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void FormMarca_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }
    }
}
