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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void DgOrcamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Classes.Bioghet_Consultas.Consultar_CaminhoImagem(DgOrcamento.CurrentRow.Cells[5].Value.ToString());

                PFoto.Load(Classes.Bioghet_Configuracao.Foto1);
                PFoto1.Load(Classes.Bioghet_Configuracao.Foto2);
                PFoto2.Load(Classes.Bioghet_Configuracao.Foto3);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (RdTudo.Checked.Equals(true))
                {
                    List<Orcamento> listar_orcamento = Classes.Bioghet_Consultas.Listar_Orcamento();
                    DgOrcamento.Rows.Clear();
                    String[] Param = new String[6];
                    for (int orcamento = 0; orcamento < listar_orcamento.Count; orcamento++)
                    {
                        Param[0] = listar_orcamento[orcamento].Nome;
                        Param[1] = listar_orcamento[orcamento].CPF;
                        Param[2] = listar_orcamento[orcamento].Telefone;
                        Param[3] = listar_orcamento[orcamento].Marca;
                        Param[4] = listar_orcamento[orcamento].Modelo;
                        Param[5] = listar_orcamento[orcamento].Imei;

                        DgOrcamento.Rows.Add(Param);
                    }
                }
                else if (RdImei.Checked.Equals(true))
                {
                    List<Orcamento> listar_orcamento = Classes.Bioghet_Consultas.Listar_OrcamentoImei(TxBuscar.Text);
                    DgOrcamento.Rows.Clear();
                    String[] Param = new String[6];
                    for (int orcamento = 0; orcamento < listar_orcamento.Count; orcamento++)
                    {
                        Param[0] = listar_orcamento[orcamento].Nome;
                        Param[1] = listar_orcamento[orcamento].CPF;
                        Param[2] = listar_orcamento[orcamento].Telefone;
                        Param[3] = listar_orcamento[orcamento].Marca;
                        Param[4] = listar_orcamento[orcamento].Modelo;
                        Param[5] = listar_orcamento[orcamento].Imei;

                        DgOrcamento.Rows.Add(Param);
                    }
                }
                else if (RdCliente.Checked.Equals(true))
                {
                    List<Orcamento> listar_orcamento = Classes.Bioghet_Consultas.Listar_OrcamentoCliente(TxBuscar.Text);
                    DgOrcamento.Rows.Clear();
                    String[] Param = new String[6];
                    for (int orcamento = 0; orcamento < listar_orcamento.Count; orcamento++)
                    {
                        Param[0] = listar_orcamento[orcamento].Nome;
                        Param[1] = listar_orcamento[orcamento].CPF;
                        Param[2] = listar_orcamento[orcamento].Telefone;
                        Param[3] = listar_orcamento[orcamento].Marca;
                        Param[4] = listar_orcamento[orcamento].Modelo;
                        Param[5] = listar_orcamento[orcamento].Imei;

                        DgOrcamento.Rows.Add(Param);
                    }
                }
                else if (RdCpf.Checked.Equals(true))
                {
                    List<Orcamento> listar_orcamento = Classes.Bioghet_Consultas.Listar_OrcamentoCpf(TxBuscar.Text);
                    DgOrcamento.Rows.Clear();
                    String[] Param = new String[6];
                    for (int orcamento = 0; orcamento < listar_orcamento.Count; orcamento++)
                    {
                        Param[0] = listar_orcamento[orcamento].Nome;
                        Param[1] = listar_orcamento[orcamento].CPF;
                        Param[2] = listar_orcamento[orcamento].Telefone;
                        Param[3] = listar_orcamento[orcamento].Marca;
                        Param[4] = listar_orcamento[orcamento].Modelo;
                        Param[5] = listar_orcamento[orcamento].Imei;

                        DgOrcamento.Rows.Add(Param);
                    }
                }
                else
                {
                    throw new Exception("SELECIONE UMA DAS OPÇÕES AO LADO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
