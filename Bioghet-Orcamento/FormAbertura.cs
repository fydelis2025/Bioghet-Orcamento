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
    public partial class FormAbertura : Form
    {
        public FormAbertura()
        {
            InitializeComponent();
        }

        private void FormAbertura_Load(object sender, EventArgs e)
        {
            try
            {
                TxValor.Text = "0,00";

                _abertura = null;


                Classes.Bioghet_Configuracao._listarAbertura = Classes.Bioghet_ConsultaMysql.Listar_Abertura();
                

                DgAbertura.Rows.Clear();
                String[] Param = new String[3];
                for(int i = 0; i < Classes.Bioghet_Configuracao._listarAbertura.Count; i++)
                {
                    Param[0] = Classes.Bioghet_Configuracao._listarAbertura[i].Suprimento.ToString("#####0.00");
                    Param[1] = Classes.Bioghet_Configuracao._listarAbertura[i].Sangria.ToString("#####0.00");
                    Param[2] = Classes.Bioghet_Configuracao._listarAbertura[i].Data.ToString("dd-MM-yyyy");

                    DgAbertura.Rows.Add(Param);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Abertura _abertura;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TxValor.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(RdSuprimento.Checked.Equals(true))
                {
                    if(_abertura == null)
                    {
                        _abertura = new Abertura();

                        _abertura.Suprimento = Decimal.Parse(TxValor.Text);


                        Classes.Bioghet_InserirMYSQL.Criar_Suprimento(_abertura);
                        MessageBox.Show("SUPRIMENTO CRIADO COM SUCESSO");
                        
                    }
                    else
                    {
                        _abertura.Suprimento = Decimal.Parse(TxValor.Text);


                        Classes.Bioghet_UpdateMYSQL.Atualizar_Suprimento(_abertura);
                        MessageBox.Show("SUPRIMENTO ATUALIZADO COM SUCESSO");
                        
                    }
                }

                if(RdSangria.Checked.Equals(true))
                {
                    if (_abertura == null)
                    {
                        _abertura = new Abertura();

                        _abertura.Sangria = Decimal.Parse(TxValor.Text);


                        Classes.Bioghet_InserirSQL.Criar_Sangria(_abertura);
                        MessageBox.Show("SANGRIA CRIADO COM SUCESSO");
                        
                    }
                    else
                    {
                        _abertura.Sangria = Decimal.Parse(TxValor.Text);

                        Classes.Bioghet_UpdateMYSQL.Atualizar_Sangria(_abertura);
                        MessageBox.Show("SANGRIA ATUALIZADO COM SUCESSO");
                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgAbertura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex.Equals(3))
                {
                    if(RdSangria.Checked.Equals(true))
                    {
                        _abertura = new Abertura();

                        TxValor.Text = DgAbertura.CurrentRow.Cells[1].Value.ToString();
                        _abertura.Sangria = decimal.Parse(TxValor.Text);
                    }

                    if(RdSuprimento.Checked.Equals(true))
                    {
                        _abertura = new Abertura();
                        TxValor.Text = DgAbertura.CurrentRow.Cells[0].Value.ToString();
                        _abertura.Suprimento = decimal.Parse(TxValor.Text);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
