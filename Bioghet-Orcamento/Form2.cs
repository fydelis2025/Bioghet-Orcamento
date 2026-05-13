using Microsoft.Reporting.WinForms;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Boolean RptVazio = false;
        private void Form2_Load(object sender, EventArgs e)
        {

            this.RptOrcamento.RefreshReport();
            this.RptOrcamento.LocalReport.EnableExternalImages = true;


            Classes.Bioghet_Configuracao._orcamento = Classes.Bioghet_ConsultaMysql.Relatorio_Orcamento(Classes.Bioghet_Configuracao.campo);
            
           
            RptOrcamento.ProcessingMode = ProcessingMode.Local;
            RptOrcamento.LocalReport.DataSources.Clear();

            if (Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "empresa", "").Equals("2"))
            {
                if (this.RptVazio.Equals(false))
                {
                    RptOrcamento.LocalReport.ReportPath = Environment.CurrentDirectory + "\\Report12.rdlc";
                }
                else
                {
                    RptOrcamento.LocalReport.ReportPath = Environment.CurrentDirectory + "\\OrcVazio.rdlc";
                    RptVazio = false;
                }
            }
            else if (Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "empresa", "").Equals("3"))
            {
                RptOrcamento.LocalReport.ReportPath = Environment.CurrentDirectory + "\\Report2.rdlc";
            }
            else if (Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "empresa", "").Equals("1"))
            {
                RptOrcamento.LocalReport.ReportPath = Environment.CurrentDirectory + "\\Report11.rdlc";
            }
            else
            {
                throw new Exception("Opção inválida para filial logada");
            }
            ReportDataSource _relatorioextratocartao = new ReportDataSource("DataSet1", Classes.Bioghet_Configuracao._orcamento);
            _relatorioextratocartao.Value = Classes.Bioghet_Configuracao._orcamento;
            RptOrcamento.LocalReport.DataSources.Add(_relatorioextratocartao);
            RptOrcamento.LocalReport.Refresh();
            RptOrcamento.ShowPrintButton = true;
            RptOrcamento.Visible = true;
            this.RptOrcamento.RefreshReport();
            this.RptOrcamento.RefreshReport();
            this.RptOrcamento.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool mouseClicked;
        Point clickedAt;

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }
    }
}
