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
    public partial class Telecentro_Orcamento : Form
    {
        public Telecentro_Orcamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Telecentro_Orcamento_Load(object sender, EventArgs e)
        {

            this.RptOrcamento.RefreshReport();
            this.RptOrcamento.LocalReport.EnableExternalImages = true;


            Classes.Bioghet_Configuracao._Relatorio_Telecentro = Classes.Bioghet_Consultas.Relatorio_Bioghet_Telecentro(Classes.Bioghet_Configuracao.campo);
            

            RptOrcamento.ProcessingMode = ProcessingMode.Local;
            RptOrcamento.LocalReport.DataSources.Clear();
            RptOrcamento.LocalReport.ReportPath = Environment.CurrentDirectory + "\\Report1.rdlc";
            ReportDataSource _relatorioextratocartao = new ReportDataSource("DataSet1", Classes.Bioghet_Configuracao._Relatorio_Telecentro);
            _relatorioextratocartao.Value = Classes.Bioghet_Configuracao._Relatorio_Telecentro;
            RptOrcamento.LocalReport.DataSources.Add(_relatorioextratocartao);
            RptOrcamento.LocalReport.Refresh();
            RptOrcamento.ShowPrintButton = true;
            RptOrcamento.Visible = true;
            this.RptOrcamento.RefreshReport();
            this.RptOrcamento.RefreshReport();
        }
    }
}
