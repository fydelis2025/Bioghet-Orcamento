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
    public partial class FrmDefeito : Form
    {
        public FrmDefeito()
        {
            InitializeComponent();
        }

        bool mouseClicked;
        Point clickedAt;
        private void FrmDefeito_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void FrmDefeito_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void FrmDefeito_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Defeito _defeito;
        private void FrmDefeito_Load(object sender, EventArgs e)
        {
            try
            {
                CbTipo.Items.Clear();

                Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();

                if (Classes.Bioghet_Configuracao._servico != null)
                {
                    for (int servico = 0; servico < Classes.Bioghet_Configuracao._servico.Count; servico++)
                    {
                        CbTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao.ToUpper());
                    }

                    CbTipo.SelectedIndex = 0;

                    _defeito = null;
                }
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
                _defeito = null;
                TxDescricao.ResetText();
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
                if(_defeito == null)
                {
                    if (!String.IsNullOrWhiteSpace(TxDescricao.Text))
                    {
                        _defeito = new Defeito();
                        _defeito.Descricao = TxDescricao.Text;
                        _defeito.Tipo = CbTipo.Text;

                        int retorno = Classes.Bioghet_InserirMYSQL.Criar_Defeito(_defeito);

                        if(retorno.Equals(1))
                        {
                            MessageBox.Show("DEFEITO CRIADO COM SUCESSO","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("ERRO AO CADASTRAR DEFEITO");
                        }
                    }
                }
                else
                {
                    _defeito.Descricao = TxDescricao.Text;
                    _defeito.Tipo = CbTipo.Text;

                    int retorno = Classes.Bioghet_UpdateMYSQL.Atualizar_Defeito(_defeito);
                    if (retorno.Equals(1))
                    {
                        MessageBox.Show("DEFEITO ATUALIZADO COM SUCESSO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("ERRO AO ATUALIZAR DEFEITO");
                    }

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
                if(e.ColumnIndex.Equals(2))
                {
                    CbTipo.Text = DgDefeito.CurrentRow.Cells[0].Value.ToString();
                    TxDescricao.Text = DgDefeito.CurrentRow.Cells[1].Value.ToString();

                    _defeito.Tipo = CbTipo.Text;
                    _defeito.Descricao = TxDescricao.Text;
                }

                if (e.ColumnIndex.Equals(3))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE EXCLUIR O DEFEITO","AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(_pergunta == System.Windows.Forms.DialogResult.Yes)
                    {
                        int retorno = Classes.Bioghet_ExcluirMYSQL.ExcluirDefeito(DgDefeito.CurrentRow.Cells[0].Value.ToString(), DgDefeito.CurrentRow.Cells[1].Value.ToString());

                        if(retorno.Equals(1))
                        {
                            MessageBox.Show("DEFEITO REMOVIDO COM SUCESSO","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);

                            DgDefeito.Rows.Clear();
                        }
                        else
                        {
                            throw new Exception("ERRO AO EXCLUIR O DEFEITO");
                        }
                    }
                }
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
                DgDefeito.Rows.Clear();
                List<Defeito> _LstDefeito = Classes.Bioghet_ConsultaMysql.Listar_Defeito(CbTipo.Text);
                String[] param = new String[2];
                for(int i = 0; i < _LstDefeito.Count; i++)
                {
                    param[0] = _LstDefeito[i].Tipo;
                    param[1] = _LstDefeito[i].Descricao;

                    DgDefeito.Rows.Add(param);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
