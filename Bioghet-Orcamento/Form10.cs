using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AxBrouser.Navigate(TxUrl.Text);
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {
                //VersaoNavegador _versao;

                //_versao = (VersaoNavegador)AxBrouser.Version.Major;

                //if (AxBrouser.Version.Major.Equals(11))
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
