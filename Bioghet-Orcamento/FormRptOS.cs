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
    public partial class FormRptOS : Form
    {
        public FormRptOS()
        {
            InitializeComponent();
        }

        private void FormRptOS_Load(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao._servico = Classes.Bioghet_Consultas.Listar_TipoServico();
                

                for (int servico = 0; servico < Classes.Bioghet_Configuracao._servico.Count; servico++)
                {
                    CbTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao.ToUpper());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                this.RptOs.RefreshReport();
                this.RptOs.LocalReport.EnableExternalImages = true;

                if (Classes.Bioghet_Configuracao.StatusConexao.Equals(Classes.Bioghet_Configuracao.StatusInternet.OFFILINE.ToString()))
                {
                    //Classes.Bioghet_Configuracao._orcamento = Listar.Listar_Bioghet_OS(DateTime.Parse(DataInicio.Text), DateTime.Parse(DataFinal.Text));
                }
                else
                {
                    Classes.Bioghet_Configuracao._orcamento = Classes.Bioghet_Consultas.Listar_Bioghet_OS(CbTipo.Text, TxCadMarca.Text, DateTime.Parse(DataInicio.Text), DateTime.Parse(DataFinal.Text));
                }

                RptOs.ProcessingMode = ProcessingMode.Local;
                RptOs.LocalReport.DataSources.Clear();
                RptOs.LocalReport.ReportPath = Environment.CurrentDirectory + "\\Report6.rdlc";
                ReportDataSource _relatorioextratocartao = new ReportDataSource("DataSet1", Classes.Bioghet_Configuracao._orcamento);
                _relatorioextratocartao.Value = Classes.Bioghet_Configuracao._orcamento;
                RptOs.LocalReport.DataSources.Add(_relatorioextratocartao);
                RptOs.LocalReport.Refresh();
                RptOs.ShowPrintButton = true;
                RptOs.Visible = true;
                this.RptOs.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao._marca = Classes.Bioghet_Consultas.Listar_Marca(CbTipo.Text);
                

                TxCadMarca.Items.Clear();
                for (int m = 0; m < Classes.Bioghet_Configuracao._marca.Count; m++)
                {
                    TxCadMarca.Items.Add(Classes.Bioghet_Configuracao._marca[m].Descricao.ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
