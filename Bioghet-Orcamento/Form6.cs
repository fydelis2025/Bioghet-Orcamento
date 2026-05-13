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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private Funcionario _func = null;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxNome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxCPF.Focus();
            }
        }

        private void TxCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxTelefone.Focus();
            }
        }

        private void TxTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxEmail.Focus();
            }
        }

        private void BtSalvarImg_Click(object sender, EventArgs e)
        {
            try
            {
                if(_func == null)
                {
                    _func = new Funcionario();

                    _func.Nome = TxNome.Text;
                    _func.Cpf = TxCPF.Text;
                    _func.Telefone = TxTelefone.Text;
                    _func.Email = TxEmail.Text;

                    Classes.Bioghet_InserirMYSQL.Criar_Funcionario(_func);

                    MessageBox.Show("FUNCIONARIO CRIADO COM SUCESSO", "FUNCIONARIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _func.Nome = TxNome.Text;
                    _func.Cpf = TxCPF.Text;
                    _func.Telefone = TxTelefone.Text;
                    _func.Email = TxEmail.Text;


                    Classes.Bioghet_UpdateMYSQL.Atualizar_Funcionario(_func);
                    

                    MessageBox.Show("FUNCIONARIO ATUALIZADO COM SUCESSO", "FUNCIONARIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listar_tabela()
        {
            try
            {
                DgFuncionario.Rows.Clear();


                Classes.Bioghet_Configuracao.func = Classes.Bioghet_ConsultaMysql.Listar_Funcionario();
                

                string[] param = new string[2];
                for (int i = 0; i < Classes.Bioghet_Configuracao.func.Count; i++)
                {
                    param[0] = Classes.Bioghet_Configuracao.func[i].Nome;
                    param[1] = Classes.Bioghet_Configuracao.func[i].Telefone;

                    DgFuncionario.Rows.Add(param);
                }
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
                TxNome.ResetText();
                TxCPF.ResetText();
                TxTelefone.ResetText();
                TxEmail.ResetText();

                _func = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChMostrar_Click(object sender, EventArgs e)
        {
            if(ChMostrar.Checked.Equals(true))
            {
                DgFuncionario.Rows.Clear();

                listar_tabela();
            }
            else
            {
                DgFuncionario.Rows.Clear();
            }
        }

        private void DgFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 2)
                {

                    Classes.Bioghet_Configuracao.codigofuncionario = Classes.Bioghet_ConsultaMysql.Consultar_IdFuncionario(DgFuncionario.CurrentRow.Cells[0].Value.ToString());
                    _func = Classes.Bioghet_ConsultaMysql.Consultar_Funcionario(Classes.Bioghet_Configuracao.codigofuncionario);

                        TxNome.Text = _func.Nome;
                        TxCPF.Text = _func.Cpf;
                        TxTelefone.Text = _func.Telefone;
                        TxEmail.Text = _func.Email;
                    

                    
                }
                if (e.ColumnIndex == 3)
                {
                    DialogResult result = MessageBox.Show("DESEJA REALMENTE EXCLUIR O FUNCIONÁRIO" + DgFuncionario.CurrentRow.Cells[0].Value,"AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);

                    if(result == System.Windows.Forms.DialogResult.Yes)
                    {

                        Classes.Bioghet_DeleteMYSQL.ExcluirFuncionario(DgFuncionario.CurrentRow.Cells[0].Value.ToString());

                        MessageBox.Show("FUNCIONÁRIO " + DgFuncionario.CurrentRow.Cells[0].Value + " EXCLUIDO COM SUCESSO");
                        listar_tabela();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
