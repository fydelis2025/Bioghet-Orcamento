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
    public partial class RptLaudo : Form
    {
        public RptLaudo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RptLaudo_Load(object sender, EventArgs e)
        {

            this.RptLaudoTecnico.RefreshReport();
            this.RptLaudoTecnico.LocalReport.EnableExternalImages = true;


            Classes.Bioghet_Configuracao._laudo = Classes.Bioghet_ConsultaMysql.Listar_LaudoTecnico(Classes.Bioghet_Configuracao.campo);
            

            RptLaudoTecnico.ProcessingMode = ProcessingMode.Local;
            RptLaudoTecnico.LocalReport.DataSources.Clear();
            RptLaudoTecnico.LocalReport.ReportPath = Environment.CurrentDirectory + "\\Report5.rdlc";
            ReportDataSource _relatorioextratocartao = new ReportDataSource("DataSet1", Classes.Bioghet_Configuracao._laudo);
            _relatorioextratocartao.Value = Classes.Bioghet_Configuracao._laudo;
            RptLaudoTecnico.LocalReport.DataSources.Add(_relatorioextratocartao);
            RptLaudoTecnico.LocalReport.Refresh();
            RptLaudoTecnico.ShowPrintButton = true;
            RptLaudoTecnico.Visible = true;
            this.RptLaudoTecnico.RefreshReport();
        }
    }
}
