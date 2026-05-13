using Microsoft.Reporting.WinForms;
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
    public partial class RptValoresAp : Form
    {
        public RptValoresAp()
        {
            InitializeComponent();
        }

        private void RptValoresAp_Load(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();

                for (int servico = 0; servico < Classes.Bioghet_Configuracao._servico.Count; servico++)
                {
                    CbTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao);
                }

                CbTipo.SelectedIndex = 0;
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

                if (!String.IsNullOrWhiteSpace(CbTipo.Text) && (!String.IsNullOrWhiteSpace(TxCadMarca.Text)))
                {
                    this.RptValoresAparelhos.RefreshReport();
                    this.RptValoresAparelhos.LocalReport.EnableExternalImages = true;


                    Classes.Bioghet_Configuracao._valoresaparelho = Classes.Bioghet_ConsultaMysql.Valores_Aparelhos(DateTime.Parse(DataInicio.Text), DateTime.Parse(DataFinal.Text), CbTipo.Text, TxCadMarca.Text);

                    RptValoresAparelhos.ProcessingMode = ProcessingMode.Local;
                    RptValoresAparelhos.LocalReport.DataSources.Clear();
                    RptValoresAparelhos.LocalReport.ReportPath = Environment.CurrentDirectory + "\\Report4.rdlc";
                    ReportDataSource _relatorioextratocartao = new ReportDataSource("DataSet1", Classes.Bioghet_Configuracao._valoresaparelho);
                    _relatorioextratocartao.Value = Classes.Bioghet_Configuracao._valoresaparelho;
                    RptValoresAparelhos.LocalReport.DataSources.Add(_relatorioextratocartao);
                    RptValoresAparelhos.LocalReport.Refresh();
                    RptValoresAparelhos.ShowPrintButton = true;
                    RptValoresAparelhos.Visible = true;
                    this.RptValoresAparelhos.RefreshReport();
                }
                else
                {
                    throw new Exception("FAVOR INFORME O TIPO E A MARCA DO APARELHO");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Classes.Bioghet_Configuracao.StatusConexao.Equals(Classes.Bioghet_Configuracao.StatusInternet.OFFILINE.ToString()))
                {
                    Classes.Bioghet_Configuracao._marca = Classes.Bioghet_ConsultaMysql.Listar_Marca(CbTipo.Text);
                }
                else
                {
                    Classes.Bioghet_Configuracao._marca = Classes.Bioghet_ConsultaMysql.Listar_Marca(CbTipo.Text);
                }

                TxCadMarca.Items.Clear();
                for (int i = 0; i < Classes.Bioghet_Configuracao._marca.Count; i++)
                {
                    TxCadMarca.Items.Add(Classes.Bioghet_Configuracao._marca[i].Descricao.ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
