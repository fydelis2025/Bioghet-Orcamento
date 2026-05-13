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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {


            this.RptEmprestimo.RefreshReport();
            this.RptEmprestimo.LocalReport.EnableExternalImages = true;

            List<Emprestimo> _orcamento = Classes.Bioghet_ConsultaMysql.Listar_ImpEmprestimo(Classes.Bioghet_Configuracao.campo);

            RptEmprestimo.ProcessingMode = ProcessingMode.Local;
            RptEmprestimo.LocalReport.DataSources.Clear();
            RptEmprestimo.LocalReport.ReportPath = Environment.CurrentDirectory + "\\Report3.rdlc";
            ReportDataSource _relatorioextratocartao = new ReportDataSource("DataSet1", _orcamento);
            _relatorioextratocartao.Value = _orcamento;
            RptEmprestimo.LocalReport.DataSources.Add(_relatorioextratocartao);
            RptEmprestimo.LocalReport.Refresh();
            RptEmprestimo.ShowPrintButton = true;
            RptEmprestimo.Visible = true;
            this.RptEmprestimo.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
