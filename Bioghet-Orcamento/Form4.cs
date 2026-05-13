using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }

        private void CbParaguai_SelectedIndexChanged(object sender, EventArgs e)
        {

            String retorno = Classes.Bioghet_ConsultaSQL.Consultar_URL(CbParaguai.Text);
            PY.Navigate(retorno);
            PY.Show();
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbMercadoLivre_SelectedIndexChanged(object sender, EventArgs e)
        {

            String retorno = Classes.Bioghet_ConsultaSQL.Consultar_URL(CbMercadoLivre.Text);
            ML.Navigate(retorno);
            ML.Show();
            
        }

        private void CbParaguai_Click(object sender, EventArgs e)
        {
            try
            {
                CbParaguai.Items.Clear();

                Classes.Bioghet_Configuracao.url = Classes.Bioghet_ConsultaSQL.Listar_Url();
                
                string[] param = new string[2];
                for (int i = 0; i < Classes.Bioghet_Configuracao.url.Count; i++)
                {

                    CbParaguai.Items.Add(Classes.Bioghet_Configuracao.url[i].Nome);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbMercadoLivre_Click(object sender, EventArgs e)
        {
            try
            {

                CbMercadoLivre.Items.Clear();


                Classes.Bioghet_Configuracao.url = Classes.Bioghet_ConsultaSQL.Listar_Url();
                
                
                string[] param = new string[2];
                for (int i = 0; i < Classes.Bioghet_Configuracao.url.Count; i++)
                {

                    CbMercadoLivre.Items.Add(Classes.Bioghet_Configuracao.url[i].Nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormURL url = new FormURL();
            url.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                //VersaoNavegador _versao;

                //_versao = (VersaoNavegador)PY.Version.Major;
                //_versao = (VersaoNavegador)ML.Version.Major;

                //if (PY.Version.Major.Equals(11) && ML.Version.Major.Equals(11))
                //{

                //    if (Realsoft_VersaoWebBrouser.GetBrowserEmulationVersion() != _versao)
                //    {
                //        Realsoft_VersaoWebBrouser.SetBrowserEmulationVersion(_versao);
                //    }
                //}
                //else
                //{
                //    Process.Start("https://www.microsoft.com/pt-br/download/internet-explorer-11-for-windows-7-details.aspx");
                //    MessageBox.Show("SUA APLICAÇÃO ESTÁ COM O NAVEGADOR IEXPLORER DESATUALIZADO FAVOR ATUALIZE PARA A VERSÃO MAIS RECENTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                //    Application.Exit();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
