using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioghet_Orcamento.Fiscal
{
    public partial class DownloadMF : Form
    {
        public DownloadMF()
        {
            InitializeComponent();
        }

        private void CBO_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CBO_Tipo.SelectedItem.Equals("DATAM"))
                {
                    DTP_DataInicial.Visible = true;
                    DTP_DataFinal.Visible = true;
                    TB_Inicial.Visible = false;
                    TB_Final.Visible = false;
                    TB_Final.Visible = false;
                    DateTime sHoje = DateTime.Today;
                    DTP_DataInicial.Value = DTP_DataFinal.Value = sHoje;
                }
                else if (CBO_Tipo.SelectedItem.Equals("COO"))
                {
                    DTP_DataInicial.Visible = false;
                    DTP_DataFinal.Visible = false;
                    TB_Inicial.Visible = true;
                    TB_Final.Visible = true;
                }
                else if (CBO_Tipo.SelectedItem.Equals("CRZ"))
                {
                    DTP_DataInicial.Visible = false;
                    DTP_DataFinal.Visible = false;
                    TB_Inicial.Visible = true;
                    TB_Final.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_GerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                string Str_Tipo, Str_Inicial, Str_Final, Str_LocalArquivo, Str_NomeArquivo = "Daruma.mfd";
                Str_Tipo = string.Empty;
                Str_Inicial = string.Empty;
                Str_Final = string.Empty;

                Str_LocalArquivo = TB_LocalArquivo.Text;
                if (Str_LocalArquivo != "")
                {
                    Declaracoes.iRetorno = Declaracoes.regAlterarValor_Daruma(@"START\LocalArquivosRelatorios", Str_LocalArquivo);
                }


                if (CBO_Tipo.SelectedItem.Equals("COO"))
                {

                    Str_Tipo = "COO";
                    Str_Inicial = TB_Inicial.Text.Trim();
                    Str_Final = TB_Final.Text.Trim();

                }
                else if (CBO_Tipo.SelectedItem.Equals("DATAM"))
                {

                    Str_Tipo = "DATAM";
                    DateTime Aux_Inicial1 = Convert.ToDateTime(DTP_DataInicial.Text);
                    //Conversão de formato de data
                    Str_Inicial = Aux_Inicial1.ToString("ddMMyyyy");
                    DateTime Aux_Final1 = Convert.ToDateTime(DTP_DataFinal.Text);
                    //Conversão de formato de data
                    Str_Final = Aux_Final1.ToString("ddMMyyyy");

                }
                else if (CBO_Tipo.SelectedItem.Equals("CRZ"))
                {

                    Str_Tipo = "CRZ";
                    Str_Inicial = TB_Inicial.Text.Trim();
                    Str_Final = TB_Final.Text.Trim();

                }
                Str_LocalArquivo = Str_LocalArquivo + Str_NomeArquivo;

                Declaracoes.iRetorno = Declaracoes.rEfetuarDownloadMFD_ECF_Daruma(Str_Tipo, Str_Inicial, Str_Final, Str_LocalArquivo);
                Declaracoes.TrataRetorno(Declaracoes.iRetorno);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_MF_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            TB_LocalArquivo.Text = folderBrowserDialog1.SelectedPath.ToString() + @"\";
        }
    }
}
