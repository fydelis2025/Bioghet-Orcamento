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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                TxValor.Text = "0";

                List<TipoServico> _servico = Classes.Bioghet_Consultas.Listar_TipoServico();
                for (int servico = 0; servico < _servico.Count; servico++)
                {
                    CbTipo.Items.Add(_servico[servico].Descricao);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_Consultas.Consultar_IdMarca(TxMarca.Text, CbTipo.Text);

                listView1.Items.Clear();

                List<Modelo> _modelo = Classes.Bioghet_Consultas.Listar_Modelo(Classes.Bioghet_Configuracao.CodigoMarca);
                for (int i = 0; i < _modelo.Count; i++)
                {
                    listView1.Items.Add(_modelo[i].Descricao);
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
                listView1.Items.Clear();

                List<Modelo> Lista = Classes.Bioghet_Consultas.Listar_ModeloDigitado(TxModelo.Text);

                for (int i = 0; i < Lista.Count; i++)
                {
                    listView1.Items.Add(Lista[i].Descricao.ToUpper());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    TxModelo.Text = listView1.SelectedItems[i].Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxImei_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxModelo.Focus();
            }
        }

        private void TxModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxNome.Focus();
            }
        }

        private void TxNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxCPF.Focus();
            }
        }

        private void TxCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxRG.Focus();
            }
        }

        private void TxRG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxTelefone.Focus();
            }
        }

        private Emprestimo _emp = null;

        private void button4_Click(object sender, EventArgs e)
        {
            CbTipo.ResetText();
            TxMarca.ResetText();
            TxModelo.ResetText();
            TxImei.ResetText();
            TxNome.ResetText();
            TxCPF.ResetText();
            TxRG.ResetText();
            TxTelefone.ResetText();
            TxValor.Text = "0";

            _emp = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(_emp == null)
                {
                    _emp = new Emprestimo();
                    _emp.Tipo = CbTipo.Text;
                    _emp.Marca = TxMarca.Text;
                    _emp.Modelo = TxModelo.Text;
                    _emp.Imei = TxImei.Text;
                    _emp.Nome = TxNome.Text;
                    _emp.CPF = TxCPF.Text;
                    _emp.RG = TxRG.Text;
                    _emp.Telefone = TxTelefone.Text;

                    Classes.Bioghet_Inserir.Criar_Emprestimo(_emp);

                    Form8 frm = new Form8();
                    Classes.Bioghet_Configuracao.campo = TxImei.Text;
                    frm.Show();

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
                List<Marca> _marca = Classes.Bioghet_Consultas.Listar_Marca(CbTipo.Text);
                TxMarca.Items.Clear();
                for (int i = 0; i < _marca.Count; i++)
                {
                    TxMarca.Items.Add(_marca[i].Descricao.ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
