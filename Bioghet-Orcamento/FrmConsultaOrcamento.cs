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
    public partial class FrmConsultaOrcamento : Form
    {
        public FrmConsultaOrcamento()
        {
            InitializeComponent();
        }

        private List<Orcamento> _orcamento;
        private void BtLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if(RdImei.Checked.Equals(true))
                {
                    if (!String.IsNullOrWhiteSpace(TxDescricao.Text))
                    {
                        DgConsulta.Rows.Clear();

                        _orcamento = Classes.Bioghet_ConsultaMysql.Listar_Orcamento_Imei(TxDescricao.Text);

                        String[] Param = new String[9];
                        for(int _imei = 0; _imei < _orcamento.Count;_imei++)
                        {
                            Param[0] = _orcamento[_imei].Tipo;
                            Param[1] = _orcamento[_imei].Marca;
                            Param[2] = _orcamento[_imei].Modelo;
                            Param[3] = _orcamento[_imei].Defeito;
                            Param[4] = _orcamento[_imei].Nome;
                            Param[5] = _orcamento[_imei].CPF;
                            Param[6] = _orcamento[_imei].Telefone;
                            Param[7] = _orcamento[_imei].Imei;
                            Param[8] = _orcamento[_imei].Funcionario;

                            DgConsulta.Rows.Add(Param);
                        }
                    }
                }
                if (RdCPFCNPJ.Checked.Equals(true))
                {
                    if (!String.IsNullOrWhiteSpace(TxDescricao.Text))
                    {
                        DgConsulta.Rows.Clear();

                        _orcamento = Classes.Bioghet_ConsultaMysql.Listar_Orcamento_CPF(TxDescricao.Text);

                        String[] Param = new String[9];
                        for (int _cpf = 0; _cpf < _orcamento.Count; _cpf++)
                        {
                            Param[0] = _orcamento[_cpf].Tipo;
                            Param[1] = _orcamento[_cpf].Marca;
                            Param[2] = _orcamento[_cpf].Modelo;
                            Param[3] = _orcamento[_cpf].Defeito;
                            Param[4] = _orcamento[_cpf].Nome;
                            Param[5] = _orcamento[_cpf].CPF;
                            Param[6] = _orcamento[_cpf].Telefone;
                            Param[7] = _orcamento[_cpf].Imei;
                            Param[8] = _orcamento[_cpf].Funcionario;

                            DgConsulta.Rows.Add(Param);
                        }
                    }
                }

                if (RdTudo.Checked.Equals(true))
                {
                    DgConsulta.Rows.Clear();

                    _orcamento = Classes.Bioghet_ConsultaMysql.Listar_Orcamento_Tudo();

                    String[] Param = new String[9];
                    for (int _tudo = 0; _tudo < _orcamento.Count; _tudo++)
                    {
                        Param[0] = _orcamento[_tudo].Tipo;
                        Param[1] = _orcamento[_tudo].Marca;
                        Param[2] = _orcamento[_tudo].Modelo;
                        Param[3] = _orcamento[_tudo].Defeito;
                        Param[4] = _orcamento[_tudo].Nome;
                        Param[5] = _orcamento[_tudo].CPF;
                        Param[6] = _orcamento[_tudo].Telefone;
                        Param[7] = _orcamento[_tudo].Imei;
                        Param[8] = _orcamento[_tudo].Funcionario;

                        DgConsulta.Rows.Add(Param);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (RdImei.Checked.Equals(true))
                    {
                        if (!String.IsNullOrWhiteSpace(TxDescricao.Text))
                        {
                            DgConsulta.Rows.Clear();

                            _orcamento = Classes.Bioghet_ConsultaMysql.Listar_Orcamento_Imei(TxDescricao.Text);

                            String[] Param = new String[9];
                            for (int _imei = 0; _imei < _orcamento.Count; _imei++)
                            {
                                Param[0] = _orcamento[_imei].Tipo;
                                Param[1] = _orcamento[_imei].Marca;
                                Param[2] = _orcamento[_imei].Modelo;
                                Param[3] = _orcamento[_imei].Defeito;
                                Param[4] = _orcamento[_imei].Nome;
                                Param[5] = _orcamento[_imei].CPF;
                                Param[6] = _orcamento[_imei].Telefone;
                                Param[7] = _orcamento[_imei].Imei;
                                Param[8] = _orcamento[_imei].Funcionario;

                                DgConsulta.Rows.Add(Param);
                            }
                        }
                    }
                    if (RdCPFCNPJ.Checked.Equals(true))
                    {
                        if (!String.IsNullOrWhiteSpace(TxDescricao.Text))
                        {
                            DgConsulta.Rows.Clear();

                            _orcamento = Classes.Bioghet_ConsultaMysql.Listar_Orcamento_CPF(TxDescricao.Text);

                            String[] Param = new String[9];
                            for (int _cpf = 0; _cpf < _orcamento.Count; _cpf++)
                            {
                                Param[0] = _orcamento[_cpf].Tipo;
                                Param[1] = _orcamento[_cpf].Marca;
                                Param[2] = _orcamento[_cpf].Modelo;
                                Param[3] = _orcamento[_cpf].Defeito;
                                Param[4] = _orcamento[_cpf].Nome;
                                Param[5] = _orcamento[_cpf].CPF;
                                Param[6] = _orcamento[_cpf].Telefone;
                                Param[7] = _orcamento[_cpf].Imei;
                                Param[8] = _orcamento[_cpf].Funcionario;

                                DgConsulta.Rows.Add(Param);
                            }
                        }
                    }

                    if (RdTudo.Checked.Equals(true))
                    {
                        DgConsulta.Rows.Clear();

                        _orcamento = Classes.Bioghet_ConsultaMysql.Listar_Orcamento_Tudo();

                        String[] Param = new String[9];
                        for (int _tudo = 0; _tudo < _orcamento.Count; _tudo++)
                        {
                            Param[0] = _orcamento[_tudo].Tipo;
                            Param[1] = _orcamento[_tudo].Marca;
                            Param[2] = _orcamento[_tudo].Modelo;
                            Param[3] = _orcamento[_tudo].Defeito;
                            Param[4] = _orcamento[_tudo].Nome;
                            Param[5] = _orcamento[_tudo].CPF;
                            Param[6] = _orcamento[_tudo].Telefone;
                            Param[7] = _orcamento[_tudo].Imei;
                            Param[8] = _orcamento[_tudo].Funcionario;

                            DgConsulta.Rows.Add(Param);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
