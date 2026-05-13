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
    public partial class FormOrdemServico : Form
    {
        public FormOrdemServico()
        {
            InitializeComponent();
        }

        private int _filial;
        
        private void FormOrdemServico_Load(object sender, EventArgs e)
        {
            try
            {

                this.RptOs.RefreshReport();
                this.RptOs.LocalReport.EnableExternalImages = true;
                

                Classes.Bioghet_Configuracao.OrdemdeServico = Classes.Bioghet_ConsultaMysql.Listar_OrcamentoRapido(int.Parse(Classes.Bioghet_Configuracao.campo));
                
                for (int i = 0; i < Classes.Bioghet_Configuracao.OrdemdeServico.Count; i++ )
                {
                    _filial = Classes.Bioghet_Configuracao.OrdemdeServico[i].Filial;

                    //this.RptOs.Name = Classes.Bioghet_Configuracao.OrdemdeServico[i].Imei.ToString();
                }

                if (_filial == 1)
                {
                    RptOs.ProcessingMode = ProcessingMode.Local;
                    RptOs.LocalReport.DataSources.Clear();
                    

                    if (Classes.Bioghet_Configuracao.ImpOS.Equals(true))
                    {
                        RptOs.LocalReport.ReportPath = Environment.CurrentDirectory + "\\Report7.rdlc";
                    }
                    else
                    {
                        RptOs.LocalReport.ReportPath = Environment.CurrentDirectory + "\\Report9.rdlc";
                    }
                    ReportDataSource _relatorioextratocartao = new ReportDataSource("DataSet1", Classes.Bioghet_Configuracao.OrdemdeServico);
                    _relatorioextratocartao.Value = Classes.Bioghet_Configuracao.OrdemdeServico;
                    RptOs.LocalReport.DataSources.Add(_relatorioextratocartao);
                    RptOs.LocalReport.Refresh();
                    RptOs.ShowPrintButton = true;
                    RptOs.Visible = true;
                    this.RptOs.RefreshReport();
                }
                else
                {
                    RptOs.ProcessingMode = ProcessingMode.Local;
                    RptOs.LocalReport.DataSources.Clear();
                    if (Classes.Bioghet_Configuracao.ImpOS.Equals(true))
                    {
                        RptOs.LocalReport.ReportPath = Environment.CurrentDirectory + "\\Report8.rdlc";
                    }
                    else
                    {
                        RptOs.LocalReport.ReportPath = Environment.CurrentDirectory + "\\Report9.rdlc";
                    }
                    ReportDataSource _relatorioextratocartao = new ReportDataSource("DataSet1", Classes.Bioghet_Configuracao.OrdemdeServico);
                    _relatorioextratocartao.Value = Classes.Bioghet_Configuracao.OrdemdeServico;
                    RptOs.LocalReport.DataSources.Add(_relatorioextratocartao);
                    RptOs.LocalReport.Refresh();
                    RptOs.ShowPrintButton = true;
                    RptOs.Visible = true;
                    this.RptOs.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.RptOs.RefreshReport();
        }
    }
}
