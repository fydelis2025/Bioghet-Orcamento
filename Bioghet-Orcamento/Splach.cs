using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Bioghet_Orcamento
{
    public partial class Splach : Form
    {
        public Splach()
        {
            InitializeComponent();

        }

        private void BkProgress_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for(int i =0; i<=100; i++)
                {
                    System.Threading.Thread.Sleep(80);
                    BkProgress.ReportProgress(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Splach_Load(object sender, EventArgs e)
        {
            try
            {
                String NomePc = Environment.MachineName;
                String UsuarioPC = Environment.UserName;
                String MACPC = Classes.Bioghet_Configuracao.GetEnderecoMAC();
                String UserDominio = Environment.UserDomainName;
                String Procesador = String.Empty;
                Int32 VersaoSO = Environment.OSVersion.Version.Major;
                String ServicePack = Environment.OSVersion.ServicePack;
                String Plataforma = Environment.OSVersion.Platform.ToString();
                String SO = String.Empty;

                if (Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE") == "AMD64" || Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432") == "AMD64")
                {
                    Procesador = "64 Bits";
                }
                else if (Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE") == "x86")
                {
                    Procesador = "32 Bits";
                }

                string SistemaOperacional =String.Empty;
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
                {
                    ManagementObjectCollection information = searcher.Get();
                    if (information != null)
                    {
                        foreach (ManagementObject obj in information)
                        {
                            SistemaOperacional = obj["Caption"].ToString() + " - " + obj["OSArchitecture"].ToString();
                        }
                    }

                    SO = SistemaOperacional;
                }

                Classes.Bioghet_AppInstalado bioghet_App = Classes.Bioghet_ConsultaMysql.Consultar_APP(NomePc, UsuarioPC, MACPC);

                if(bioghet_App == null)
                {
                    bioghet_App = new Classes.Bioghet_AppInstalado();
                    bioghet_App.NomePC = NomePc;
                    bioghet_App.UsuarioPC = UsuarioPC;
                    bioghet_App.MACPC = MACPC;
                    bioghet_App.TipoAPP = "DESKTOP";
                    bioghet_App.DataInstalacao = DateTime.Now;
                    bioghet_App.Ativo = true;
                    bioghet_App.SO = SO;
                    bioghet_App.Plataforma = Plataforma;
                    bioghet_App.Arquitetura = Procesador;
                    bioghet_App.UsuarioDominio = UserDominio;
                    bioghet_App.VersaoSO = VersaoSO;

                    Classes.Bioghet_InserirMYSQL.Criar_InstalacaoAPP(bioghet_App);
                }
                else
                {
                    if (bioghet_App.Ativo.Equals(false))
                    {
                        MessageBox.Show("ESTE COMPUTADOR ESTA BLOQUEADO PARA A EXECUÇÃO DO SISTEMA, ENTRE EM CONTATO COM O SUPORTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        Application.Exit();
                    }
                }

                AssemblyName assemblyName = typeof(String).Assembly.GetName();
                FileInfo info = new FileInfo(Environment.CurrentDirectory + "\\" + "Bioghet-Orcamento.exe");
                DateTime dt = info.LastWriteTime;

                Boolean checaversao = Classes.Bioghet_ConsultaMysql.Checar_VersaoaAtualizada(assemblyName.Version.Major,dt);

                if (checaversao.Equals(false))
                {
                    DialogResult result = MessageBox.Show("ESTA VERSÃO ESTA DESCONTINUADA DESEJA CONTINUAR ASSIM MESMO?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                    if(result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }


                BkProgress.RunWorkerAsync();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void BkProgress_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Value = e.ProgressPercentage;

                if(e.ProgressPercentage.Equals(50))
                {
                    PLoad.Image = Bioghet_Orcamento.Properties.Resources._27332002_485796121857027_8243401172391071570_n;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BkProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.Hide();

                Boolean __Configuracao__ = Boolean.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "configuracao", ""));

                if (__Configuracao__ == false)
                {
                    Form9 frm = new Form9();
                    frm.Show();
                }
                else
                {
                    FrmConfiguracao config = new FrmConfiguracao();
                    config.Show();
                    //Process.Start(Environment.CurrentDirectory + "\\Bioghet_Configurador.exe");
                    //Application.Exit();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Splach_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                Classes.Bioghet_Configuracao.senhaconfiguracao = true;
                Ini.gravaarquivoini("geral", "configuracao", "true");
            }
        }

        public static DataTable tabela = null;
        private void Splach_Shown(object sender, EventArgs e)
        {
            try
            {
                //tabela = new DataTable();
                //tabela.Columns.Add("descricao");
                //tabela.Columns.Add("valor");
                //WebClient webClient = new WebClient();
                //String html = webClient.DownloadString("https://www.maxcelltelecom.com.br/loja/busca.php?loja=375576&palavra_busca=FRONTAL%20SAMSUNG");

                //HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                //htmlDocument.LoadHtml(html);

                //HtmlNode elementbyId = htmlDocument.GetElementbyId("container");
                //HtmlNode htmlNode = elementbyId.SelectSingleNode("//span[contains(@class,'product-item')]");
                ////HtmlNode _htm = htmlNode.SelectSingleNode("//ul[contains(@class,'products columns-3')]");

                String Retorno = ComprasParaguai.CotacaodoDola();

                if (!String.IsNullOrEmpty(Retorno))
                {
                    Ini.gravaarquivoini("geral", "cambiododia", Retorno);
                }
                else
                {
                    Ini.gravaarquivoini("geral", "cambiododia", "0,00");
                }

                if (!File.Exists(Environment.CurrentDirectory + "\\Licenca.bioghet"))
                {
                    //Classes.Bioghet_Regedit reg = new Classes.Bioghet_Regedit();
                    //reg.CriarRegistroSoftware();

                    StreamWriter escrita = new StreamWriter("Licenca.bioghet");
                    String Mac = Classes.Bioghet_Configuracao.GetEnderecoMAC();

                    String Cripto = Classes.BioCriptografia.Encripta(Mac);
                    escrita.WriteLine(Cripto);
                    escrita.Close();
                    Classes.Bioghet_Extencao extencao = new Classes.Bioghet_Extencao();
                    extencao.AbrirArquivoLicenca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
