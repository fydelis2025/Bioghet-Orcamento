using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IpPublicKnowledge;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Collections;
using HtmlAgilityPack;
using System.IO;
using System.Net;
using MySql.Data.MySqlClient;
using System.Management;
using System.Security.AccessControl;
using System.Security.Principal;
using System.IO.Compression;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Bioghet_Orcamento
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private int ProximaImagem = 0;
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                var ip = IPK.GetMyPublicIp();
                var _ip = IPK.GetIpInfo(ip);

                //timer1.Enabled = true;

                //Classes.Bioghet_Configuracao._log = Classes.Bioghet_Consultas.Listar_Acessos();

                Classes.Bioghet_Configuracao.Funcao = LbFuncao.Text;

                if (LbFuncao.Text.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
                {
                    Classes.Bioghet_Configuracao.Grupo = true;
                    BtProtecao.Enabled = true;
                    BtDesprotege.Enabled = true;
                    BtCorreios.Enabled = true;
                    BtPendrive.Enabled = true;
                    BtVNC.Enabled = true;
                    BtCamera.Enabled = true;
                    BtRemoto.Enabled = true;
                    BtMercadoPago.Enabled = true;

                }
                else
                {
                    Classes.Bioghet_Configuracao.Grupo = false;
                    BtProtecao.Enabled = false;
                    BtDesprotege.Enabled = false;
                    BtCorreios.Enabled = false;
                    BtPendrive.Enabled = false;
                    BtVNC.Enabled = false;
                    BtCamera.Enabled = false;
                    BtRemoto.Enabled = false;
                    BtMercadoPago.Enabled = false;
                }



                LbData.Text = DateTime.Now.ToString("dd-MM-yyyy");

                FileInfo info = new FileInfo(Environment.CurrentDirectory + "\\" + "Bioghet-Orcamento.exe");
                DateTime dt = info.LastWriteTime;

                LbUltimaAtualizacao.Text = dt.ToString();

                Classes.Bioghet_Configuracao.Usuario = Classes.Bioghet_ConsultaMysql.Consultar_IDUsuario(LbUser.Text);


                foreach(DriveInfo hd in DriveInfo.GetDrives())
                {
                    if (hd.IsReady && hd.Name.Equals("C:\\"))
                    {
                        GraficoHD.Legends["Legenda"].Title = "Volume " + hd.Name;
                        GraficoHD.Legends["Legenda"].TitleAlignment = StringAlignment.Center;
                        GraficoHD.Series["hd"].Points.AddXY("Usado", hd.TotalSize);
                        GraficoHD.Series["hd"].Points.AddXY("Livre", hd.TotalFreeSpace);
                        GraficoHD.Series["hd"].Points.AddXY("Avalidado", hd.AvailableFreeSpace);
                        
                    }
                }
                
                //bioAcessos.Items.Clear();
                //String[] Param = new String[2];
                //for (int a = 0; a < Classes.Bioghet_Configuracao._log.Count; a++)
                //{
                //    Param[0] = Classes.Bioghet_Configuracao._log[a].IPLocal;
                //    if (Classes.Bioghet_Configuracao._log[a].Ativo.Equals(true))
                //    {
                //        Param[1] = "Conectado";
                //    }
                //    else
                //    {
                //        Param[1] = "Desconectado";
                //    }

                //    this.bioAcessos.ShowItemToolTips = true;
                //    this.bioAcessos.Items.Add(new ListViewItem(new[] { Param[0], Param[1]}));
                //}

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void serviçoBioghetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://servico.bioghet.com.br/");
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/bioghet1");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com");
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/bioghet/");
        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/bioghet/");
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Environment.CurrentDirectory + "\\Bioghet_Paraguai.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bematechMp2500ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imprimirOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LbFuncao.Text.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
            {
                Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
                FormRptCompras compra = new FormRptCompras();
                compra.ShowDialog();
            }
            else
            {
                throw new Exception("OPERADOR NÃO HABILITADO A UTILIZAR ESTE RECURSO");
            }
        }

        private void aberturaDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LbFuncao.Text.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
            {
                Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
                FormAbertura compra = new FormAbertura();
                compra.ShowDialog();
            }
            else
            {
                throw new Exception("OPERADOR NÃO HABILITADO A UTILIZAR ESTE RECURSO");
            }
        }

        private void novaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LbFuncao.Text.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
            {
                Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
                FormCompra compra = new FormCompra();
                compra.ShowDialog();
            }
            else
            {
                throw new Exception("OPERADOR NÃO HABILITADO A UTILIZAR ESTE RECURSO");
            }
        }

        private void declaraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
            if (LbFuncao.Text.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
            {
                FormDeclaracao declaracao = new FormDeclaracao();
                declaracao.ShowDialog();
            }
            else
            {
                throw new Exception("OPERADOR NÃO HABILITADO A UTILIZAR ESTE RECURSO");
            }
        }

        private void emprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;

            if (LbFuncao.Text.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
            {
                Form7 frm = new Form7();
                frm.ShowDialog();
            }
            else
            {
                throw new Exception("OPERADOR NÃO HABILITADO A UTILIZAR ESTE RECURSO");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastrarOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void paraOClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
            //Youtube _tube = new Youtube();
            //_tube.ShowDialog();
        }

        private void laudoTécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
            FormLaudoTecnico _laudo = new FormLaudoTecnico();
            _laudo.ShowDialog();
        }

        private void valoresDeAparelhosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LbFuncao.Text.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
                {
                    Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
                    RptValoresAp _aparelhos = new RptValoresAp();
                    _aparelhos.ShowDialog();
                }
                else
                {
                    throw new Exception("OPERADOR NÃO HABILITADO A UTILIZAR ESTE RECURSO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(TxDscrParagaui.Text))
                {
                    ComprasParaguai.AcessarML(TxDscrParagaui.Text);

                    DgPY.Rows.Clear();
                    if (ComprasParaguai.tabela != null)
                    {
                        String[] param = new String[2];
                        for (int i = 0; i < ComprasParaguai.tabela.Rows.Count; i++)
                        {
                            String Dcr = ComprasParaguai.tabela.Rows[i].ItemArray[0].ToString();
                            String Valor = ComprasParaguai.tabela.Rows[i].ItemArray[1].ToString();

                            param[0] = Dcr.ToUpper();
                            param[1] = Valor;

                            DgPY.Rows.Add(param);
                            //this.bioList1.Items.Add(new ListViewItem(new[] { ComprasParaguai.tabela.Rows[i].ItemArray[0].ToString(), ComprasParaguai.tabela.Rows[i].ItemArray[1].ToString() }));
                        }
                    }
                    //else
                    //{
                    //    throw new Exception("NÃO ENCONTRADO PARA OS PARAMETROS SELECIONADOS AAA, ORIG, ORGINAL, GDE");
                    //}
                    //if (LbStatusInternet.Text.Equals(Classes.Bioghet_Configuracao.StatusInternet.OFFILINE.ToString()))
                    //{

                    //}
                    //else
                    //{
                    //    Classes.Bioghet_Configuracao._comparativo = ONLINE.Listar.Listar_ComparativoParaguai(CbTipoPY.Text, CbMarcaParaguai.Text, TxDscrParagaui.Text);
                    //}

                    //bioList1.Items.Clear();
                    //String[] Param = new String[3];

                    //for (int i = 0; i < Classes.Bioghet_Configuracao._comparativo.Count; i++)
                    //{
                    //    Param[0] = Classes.Bioghet_Configuracao._comparativo[i].Descricao;
                    //    Param[1] = Classes.Bioghet_Configuracao._comparativo[i].Valor.ToString("#####0.00");
                    //    Param[2] = Classes.Bioghet_Configuracao._comparativo[i].TipoPeca;

                    //    this.bioList1.Items.Add(new ListViewItem(new[] { Param[0], Param[1], Param[2] }));
                    //}
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(TxDscrParagaui.Text))
                {
                    //bioList1.Items.Clear();

                    for (int i = 0; i < DgPY.Rows.Count; i++)
                    {
                        Decimal Percentual = Decimal.Parse(TxPercentual.Text);

                        Decimal SubTotal = Decimal.Multiply(Decimal.Parse(DgPY.Rows[i].Cells[1].Value.ToString().Replace("R$","")), Percentual) / 100;

                        Decimal Soma = Decimal.Add(Decimal.Parse(DgPY.Rows[i].Cells[1].Value.ToString().Replace("R$", "")), SubTotal);

                        DgPY.Rows[i].Cells[1].Value = Soma.ToString("#####0.00");
                    }

                }
                else
                {
                    throw new Exception("INFORME A MARCA E A DESCRIÇÃO DO APARELHO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bioAcessos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception ex)
            {

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(TxDescricaoML.Text))
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(AllwaysGoodCertificate);

                    Classes.Bioghet_InfoCellRio.AcessarURL(TxDescricaoML.Text);

                    //MercadoLivre.AcessarML(TxDescricaoML.Text);

                    DgML.Rows.Clear();

                    if (Classes.Bioghet_InfoCellRio.tabela != null)
                    {
                        String[] param = new String[2];
                        for (int i = 0; i < Classes.Bioghet_InfoCellRio.tabela.Rows.Count; i++)
                        {
                            String Dcr = Classes.Bioghet_InfoCellRio.tabela.Rows[i].ItemArray[0].ToString();
                            String Valor = Classes.Bioghet_InfoCellRio.tabela.Rows[i].ItemArray[1].ToString();

                            param[0] = Dcr.ToUpper();
                            param[1] = Valor;

                            DgML.Rows.Add(param);
                            //this.bioML.Items.Add(new ListViewItem(new[] { MercadoLivre.tabela.Rows[i].ItemArray[0].ToString(), MercadoLivre.tabela.Rows[i].ItemArray[1].ToString() }));
                        }
                    }
                    else
                    {
                        throw new Exception("NÃO ENCONTRADO");
                    }

                    //if (MercadoLivre.tabela != null)
                    //{
                    //    String[] param = new String[2];
                    //    for (int i = 0; i < MercadoLivre.tabela.Rows.Count; i++)
                    //    {
                    //        String Dcr = MercadoLivre.tabela.Rows[i].ItemArray[0].ToString();
                    //        String Valor = MercadoLivre.tabela.Rows[i].ItemArray[1].ToString();

                    //        param[0] = Dcr.ToUpper();
                    //        param[1] = Valor;

                    //        DgML.Rows.Add(param);
                    //        //this.bioML.Items.Add(new ListViewItem(new[] { MercadoLivre.tabela.Rows[i].ItemArray[0].ToString(), MercadoLivre.tabela.Rows[i].ItemArray[1].ToString() }));
                    //    }
                    //}
                    //else
                    //{
                    //    throw new Exception("NÃO ENCONTRADO");
                    //}

                    //    if (LbStatusInternet.Text.Equals(Classes.Bioghet_Configuracao.StatusInternet.OFFILINE.ToString()))
                    //    {

                    //    }
                    //    else
                    //    {
                    //        Classes.Bioghet_Configuracao._comparativo1 = ONLINE.Listar.Listar_ComparativoML(CbTipoML.Text, CbML.Text, TxDescricaoML.Text);
                    //    }

                    //    bioML.Items.Clear();
                    //    String[] Param = new String[3];

                    //    for (int i = 0; i < Classes.Bioghet_Configuracao._comparativo1.Count; i++)
                    //    {
                    //        Param[0] = Classes.Bioghet_Configuracao._comparativo1[i].Descricao;
                    //        Param[1] = Classes.Bioghet_Configuracao._comparativo1[i].Valor.ToString("#####0.00");
                    //        Param[2] = Classes.Bioghet_Configuracao._comparativo1[i].TipoPeca;

                    //        this.bioML.Items.Add(new ListViewItem(new[] { Param[0], Param[1], Param[2] }));
                    //    }
                }
                else
                {
                    throw new Exception("INFORME A MARCA E A DESCRIÇÃO DO APARELHO");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
               

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                //WebPage.IsWebBrowserContextMenuEnabled = true;

                //WebPage.ShowPrintPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbTipoPY_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TxDscrParagaui.Text = CbTipoPY.Text;
        }

        private void CbMarcaParaguai_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TxDscrParagaui.Text = CbTipoPY.Text + " " + CbMarcaParaguai.Text;
        }

        private void bioTjOrcamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(textBox1.Text))
                {
                    //bioList1.Items.Clear();

                    for (int i = 0; i < DgML.Rows.Count; i++)
                    {
                        Decimal Percentual = Decimal.Parse(textBox1.Text);

                        Decimal SubTotal = Decimal.Multiply(Decimal.Parse(DgML.Rows[i].Cells[1].Value.ToString().Replace("R$", "")), Percentual) / 100;

                        Decimal Soma = Decimal.Add(Decimal.Parse(DgML.Rows[i].Cells[1].Value.ToString().Replace("R$", "")), SubTotal);

                        DgML.Rows[i].Cells[1].Value = Soma.ToString("#####0.00");
                    }

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void geradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LbFuncao.Text.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
            {
                Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
                FormRptOS os = new FormRptOS();
                os.ShowDialog();
            }
        }

        private void analiseEletrônicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\ORCAMENTO TELECENTRO-22333.doc"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\ORCAMENTO TELECENTRO-22333.doc");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tJEmpresaAssistToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void emprestimoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void uRLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
            FormURL url = new FormURL();
            url.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void Pstatus_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;

                result = MessageBox.Show("DESEJA MUDAR STATUS?","AVISO",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

                if(result == System.Windows.Forms.DialogResult.Yes)
                {
                    Ini.gravaarquivoini("geral", "internet", "true");
                    Application.Restart();
                }
                else if(result == System.Windows.Forms.DialogResult.No)
                {
                    Ini.gravaarquivoini("geral", "internet", "false");
                    Application.Restart();
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void tipoServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mãoDeObraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
           
        }

        private void compraDePeçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void orçamentoTelecentroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pagamentosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void eletronicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao.campo = Interaction.InputBox("DIGITE AQUI O IMEI OU O NÚMERO DE SÉRIE PARA GERAR A IMPRESSÃO", "IMEI / SÉRIE", "", 200, 200);

                Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;

                if (Classes.Bioghet_Configuracao.campo.Equals(String.Empty))
                {
                    throw new Exception("NÃO FOI POSSIVEL CARREGAR O RELATÓRIO FAVOR VERIFIQUE SE O ORÇAMENTO FOI GERADO");
                }
                else
                {

                    Classes.Bioghet_Update.Atualizar_Status(Classes.Bioghet_Configuracao.Status.IMPRESSO.ToString(), Classes.Bioghet_Configuracao.campo);
                    

                    FormOrdemServico frm = new FormOrdemServico();

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
         
        }

        private void aparelhosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void peçasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
            if (LbFuncao.Text.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
            {
                FrmConsultaProduto _produto = new FrmConsultaProduto();
                _produto.Show();
            }
            else
            {
                throw new Exception("OPERADOR NÃO HABILITADO A UTILIZAR ESTE RECURSO");
            }
        }

        private void acessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
            Form4 acesso = new Form4();
            acesso.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void configuraçãoDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void remotoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vNCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVNC _vnc = new FrmVNC();
            _vnc.Show();
        }

        private void terminalServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTerminalServices _services = new FrmTerminalServices();
            _services.Show();
        }

        private void bioghetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://servico.bioghet.com.br/");
        }

        private void transmitirBaseDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransmitir _dados = new FrmTransmitir();
            _dados.Show();
        }

        private void uRLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void baixarVideoDoYoutubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void reciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dECLARAÇÃODEVENDADECOMPUTADORToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dECLARAÇÃODEVENDADETELEVISAOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void oRCAMENTOTELECENTROJAPONES1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bIOGHETORDEMSERVICOToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void oRCAMENTOANALISEELETRONICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void oRCAMENTOTJEMPRESAToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void salárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void leituraXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Declaracoes.iRetorno = Declaracoes.iLeituraX_ECF_Daruma();
                Declaracoes.TrataRetorno(Declaracoes.iRetorno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reduçãoZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Pergunta = MessageBox.Show("ESTA OPÇÃO IRÁ ENCERRAR O MOVIMENTO DO DIA, DESEJA CONTINUAR?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Pergunta == DialogResult.Yes)
                {
                    Declaracoes.iRetorno = Declaracoes.iReducaoZ_ECF_Daruma("", "");
                    Declaracoes.TrataRetorno(Declaracoes.iRetorno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lMFCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fiscal.LMFC _lmfc = new Fiscal.LMFC();
            _lmfc.ShowDialog();
        }

        private void lMFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fiscal.LMFS _lmfs = new Fiscal.LMFS();
            _lmfs.ShowDialog();
        }

        private void downloadMFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fiscal.DownloadMF _MF = new Fiscal.DownloadMF();
            _MF.ShowDialog();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        bool mouseClicked;
        Point clickedAt;

        private bool AllwaysGoodCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            try
            {
                FileInfo info = new FileInfo(Environment.CurrentDirectory + "\\" + "Bioghet-Orcamento.exe");
                DateTime dt = info.LastWriteTime;

                //Boolean versao = Classes.Bioghet_Consultas.Checar_VersaoAtual(dt.ToString());

                //if (!versao.Equals(true))
                //{
                //    //MessageBox.Show("A VERSÃO DO APLICATIVO ESTÁ OBSOLETA, FAVOR ATUALIZAR O APLICATIVO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                PProgresso.Image = ImgProgresso.Images[ProximaImagem];
                ProximaImagem++;
                if ((ProximaImagem == ImgProgresso.Images.Count))
                {
                    ProximaImagem = 0;
                }
            }
            catch (Exception ex)
            {
                timer1.Enabled = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PProgresso_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled.Equals(true))
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void defeitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            try
            {
               
                
                
                //Boolean desconectado = Classes.Bioghet_Consultas.Consultar_UsuarioDesconectado(Classes.Bioghet_Consultas.Consultar_IDUsuario(LbUser.Text), DateTime.Now);
                //if(desconectado.Equals(true))
                //{
                //    MessageBox.Show("ESTE USUARIO FOI DESCONECTADO, FAVOR LOGUE NOVAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                //    Application.Restart();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void ConpraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AberturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AUTORIZADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void RevendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rBSPHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void vENDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lAUDOTÉCNICOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cAMERACFTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void BtRptVendas_Click(object sender, EventArgs e)
        {
            FrmRelatorioVendas _vendas = new FrmRelatorioVendas();
            _vendas.ShowDialog();
        }

        private void BtRptRBS_Click(object sender, EventArgs e)
        {
            FrmRBS rbs = new FrmRBS();
            rbs.ShowDialog();
        }

        private void BtRptSalario_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\COMPRA DE PECA\\PAGAMENTOS.xlsx"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\COMPRA DE PECA\\PAGAMENTOS.xlsx");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtRptPagamentos_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\COMPRA DE PECA\\PAGAMENTOS.xlsx"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\COMPRA DE PECA\\PAGAMENTOS.xlsx");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtRptCompras_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\COMPRA DE PECA\\COMPRA DE PECA.xlsx"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\COMPRA DE PECA\\COMPRA DE PECA.xlsx");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton16_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\AUTORIZADAS.xlsx"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\AUTORIZADAS.xlsx");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtRptRecibo_Click(object sender, EventArgs e)
        {
            FrmRecibo _recibo = new FrmRecibo();
            _recibo.ShowDialog();
        }

        private void ribbonButton15_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\BIOGHET ORDEM-SERVICO.doc"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\BIOGHET ORDEM-SERVICO.doc");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton14_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\DECLARACAO DE VENDA DE TELEVISAO.docx"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\DECLARACAO DE VENDA DE TELEVISAO.docx");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton13_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\DECLARACAO DE VENDA DE COMPUTADOR.docx"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\DECLARACAO DE VENDA DE COMPUTADOR.docx");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton12_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\DECLARACAO DE VENDA DE AP-ELETRONICO.docx"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\DECLARACAO DE VENDA DE AP-ELETRONICO.docx");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton11_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\DECLARACAO DE VENDA DE APARELHO Notebook.docx"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\DECLARACAO DE VENDA DE APARELHO Notebook.docx");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton10_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\DECLARACAO DE VENDA DE APARELHO celular.docx"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\DECLARACAO DE VENDA DE APARELHO celular.docx");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtRptOrcamentoBioghet_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao.bioghet = true;

                FrmAviso _aviso = new FrmAviso();
                _aviso.LbAviso.Text = "DIGITE AQUI O IMEI OU O NÚMERO DE SÉRIE PARA GERAR A IMPRESSÃO";
                _aviso.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtRptOrcamentoTelecentro_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao.telecentro = true;

                FrmAviso _aviso = new FrmAviso();
                _aviso.LbAviso.Text = "DIGITE AQUI O IMEI OU O NÚMERO DE SÉRIE PARA GERAR A IMPRESSÃO";
                _aviso.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\ORCAMENTO TELECENTRO-2233.doc"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\ORCAMENTO TELECENTRO-2233.doc");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\ORCAMENTO TELECENTRO-JAPONES.doc"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\ORCAMENTO TELECENTRO-JAPONES.doc");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\ORCAMENTO TELECENTRO-JAPONES1.doc"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\ORCAMENTO TELECENTRO-JAPONES1.doc");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\ORCAMENTO-ANALISE-ELETRONICA.docx"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\ORCAMENTO-ANALISE-ELETRONICA.docx");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\ORCAMENTO-TJ-EMPRESA.docx"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\ORCAMENTO-TJ-EMPRESA.docx");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtVenda_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;

            FrmConsultaProduto _produto = new FrmConsultaProduto();
            _produto.ShowDialog();
        }

        private void BtOrdemServico_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
            FormOS _os = new FormOS();
            _os.ShowDialog();
        }

        private void BtCamera_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\camera.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "EXPORTAR BANCO DE DADOS";
                saveFile.Filter = "BIOGHET|*.bioghet";
                saveFile.FileName = "BACKUP_" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
                DialogResult result = saveFile.ShowDialog();

                if(result == DialogResult.OK)
                {
                    if(!String.IsNullOrWhiteSpace(saveFile.FileName))
                    {
                        Classes.Bioghet_Conexao.FazerBackupdoBanco(saveFile.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("BACKUP FINALIZADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtAjuda_Click(object sender, EventArgs e)
        {
            FrmAjuda ajuda = new FrmAjuda();
            ajuda.ShowDialog();
        }

        private void BtURL_Click(object sender, EventArgs e)
        {
            
        }

        private void BtAbertura_Click(object sender, EventArgs e)
        {
            FormAbertura _abertura = new FormAbertura();
            _abertura.ShowDialog();
        }

        private void BtBazar_Click(object sender, EventArgs e)
        {
            Form14 _bazar = new Form14();
            _bazar.Show();
        }

        private void BtCompra_Click(object sender, EventArgs e)
        {
            FormCompra _compra = new FormCompra();
            _compra.ShowDialog();
        }

        private void BtDefeito_Click(object sender, EventArgs e)
        {
            FrmDefeito _defeito = new FrmDefeito();
            _defeito.ShowDialog();
        }

        private void BtFuncionario_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
            if (LbFuncao.Text.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
            {
                Form6 frm = new Form6();
                frm.ShowDialog();
            }
            else
            {
                throw new Exception("OPERADOR NÃO HABILITADO A UTILIZAR ESTE RECURSO");
            }
        }

        private void BtLaudo_Click(object sender, EventArgs e)
        {
            FormLaudoTecnico laudo = new FormLaudoTecnico();
            laudo.ShowDialog();
        }

        private void BtMarca_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;

            if (LbFuncao.Text.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
            {
                FormModelo manutencao = new FormModelo();
                manutencao.Show();
            }
            else
            {
                throw new Exception("OPERADOR NÃO HABILITADO A UTILIZAR ESTE RECURSO");
            }
        }

        private void BtServico_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
            FormTipoServico tipo = new FormTipoServico();
            tipo.Show();
        }

        private void BtUsuario_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
            FormLogin _usuario = new FormLogin();
            _usuario.ShowDialog();
        }

        private void BtRevenda_Click(object sender, EventArgs e)
        {
            FrmRevenda _revenda = new FrmRevenda();
            _revenda.Show();
        }

        private void BtOrcCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;

                FrmOrcamento frm = new FrmOrcamento();
                frm.GrupoMargem.Enabled = Classes.Bioghet_Configuracao.Grupo;
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtCadOrca_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
                if (LbFuncao.Text.Equals(Classes.Bioghet_Configuracao.Login.Administrador.ToString()))
                {
                    Form5 cadmaoobra = new Form5();
                    cadmaoobra.Show();
                }
                else
                {
                    throw new Exception("OPERADOR NÃO HABILITADO A OPERAR COM ESSA OPÇÃO");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtTelecentro_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.StatusConexao = LbStatusInternet.Text;
            FormTelecentro _telecentro = new FormTelecentro();
            _telecentro.Show();
        }

        private void BtCadURL_Click(object sender, EventArgs e)
        {
            Form12 _frm = new Form12();
            _frm.Show();
        }

        private void BtConfig_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.senhaconfiguracao = true;

            FrmConfiguracao _config = new FrmConfiguracao();
            _config.ShowDialog();
        }

        private void BtRemoto_Click(object sender, EventArgs e)
        {
            FrmTerminalServices frmTerminal = new FrmTerminalServices();
            frmTerminal.Show();
        }

        private void BtVNC_Click(object sender, EventArgs e)
        {
            FrmVNC frmVNC = new FrmVNC();
            frmVNC.Show();
        }

        private void BtPendrive_Click(object sender, EventArgs e)
        {
            try
            {
                String Password = Microsoft.VisualBasic.Interaction.InputBox("DIGITE A SENHA MASTER PARA FAZER BACKUP DO SISTEMA ", "BACKUP - PARA O USB", "*", 200, 200);

                if (!String.IsNullOrWhiteSpace(Password))
                {

                    if (Password == "@@Bioghet1986$$")
                    {
                        var drives = DriveInfo.GetDrives().Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable).ToArray();

                        for (int i = 0; i < drives.Length; i++)
                        {
                            DialogResult dialog = MessageBox.Show("EXISTE UM " +
                             "DISPOSITIVO USB CONECTADO AO COMPUTADOR " + "Dispositivo: " + drives[i].DriveType + " " + drives[i].Name + "\n"
                             + "Espaço Livre: " + drives[i].TotalFreeSpace.ToString() + "\n" + " Formato " + drives[i].DriveFormat + " DESEJA FAZER BACKUP DO SISTEMA PARA ESTA UNIDADE?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dialog == DialogResult.Yes)
                            {
                                String CaminhoRemovivel = drives[i].RootDirectory.FullName; //"Bioghet_Sistema_"+DateTime.Now.ToString("ddMMyyHHmmss");

                                DirectoryInfo directory = new DirectoryInfo(CaminhoRemovivel);
                                DirectorySecurity security = directory.GetAccessControl();

                                var user = WindowsIdentity.GetCurrent();

                                security.AddAccessRule(new FileSystemAccessRule(user.User, FileSystemRights.Write, AccessControlType.Allow));
                                security.AddAccessRule(new FileSystemAccessRule(user.User, FileSystemRights.ReadAndExecute, AccessControlType.Allow));
                                security.AddAccessRule(new FileSystemAccessRule(user.User, FileSystemRights.CreateDirectories, AccessControlType.Allow));
                                security.AddAccessRule(new FileSystemAccessRule(user.User, FileSystemRights.CreateFiles, AccessControlType.Allow));
                                directory.SetAccessControl(security);

                                drives[i].RootDirectory.Create(security);

                                String ArquivoSistema = CaminhoRemovivel + "Bioghet_Sistema_" + DateTime.Now.ToString("ddMMyyHHmmss") + ".zip";
                                //Directory.CreateDirectory(ArquivoSistema);

                                ZipFile.CreateFromDirectory(Environment.CurrentDirectory, ArquivoSistema);

                                MessageBox.Show("BACKUP REALIZADO COM SUCESSO", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                    else
                    {
                        throw new Exception("SENHA INCORRETA");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtProtecao_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog __Diretorio = new FolderBrowserDialog();
                if (__Diretorio.ShowDialog() == DialogResult.OK)
                {
                    Classes.Bioghet_BloqueaPasta pasta = new Classes.Bioghet_BloqueaPasta();
                    Boolean retorno = pasta.BloqueaPasta(__Diretorio.SelectedPath);
                    if (retorno.Equals(true))
                        MessageBox.Show("Pasta bloqueada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtDesprotege_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog __Diretorio = new FolderBrowserDialog();
                if (__Diretorio.ShowDialog() == DialogResult.OK)
                {
                    Classes.Bioghet_BloqueaPasta pasta = new Classes.Bioghet_BloqueaPasta();
                    Boolean retorno = pasta.DesbloqueaPasta(__Diretorio.SelectedPath);
                    if (retorno.Equals(true))
                        MessageBox.Show("Pasta Desbloqueada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtWats_Click(object sender, EventArgs e)
        {
            Process.Start("https://web.whatsapp.com/");

        }

        private void BtSMS_Click(object sender, EventArgs e)
        {
            FormSMS sms = new FormSMS();
            sms.Show();
        }

        private void ribbonOrbRecentItem2_Click(object sender, EventArgs e)
        {
            Process.Start("http://bioghet.com.br/servico/");
        }

        private void ribbonOrbRecentItem1_Click(object sender, EventArgs e)
        {
            Process.Start("http://bioghet.com.br/bioghetorcamento/");
            
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\COMPRA DE PECA.xlsx"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\COMPRA DE PECA.xlsx");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\PAGAMENTOS.xlsx"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\PAGAMENTOS.xlsx");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\EMPRESTIMO DE CELULAR.rtf"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\EMPRESTIMO DE CELULAR.rtf");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ribbonButton9_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\OS BIOGHET.doc"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\OS BIOGHET.doc");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton17_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Relatorio\\OS TELECENTRO.doc"))
                {
                    Process.Start(Environment.CurrentDirectory + "\\Relatorio\\OS TELECENTRO.doc");
                }
                else
                {
                    throw new Exception("ARQUIVO NÃO ENCONTRADO, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtCorreios_Click(object sender, EventArgs e)
        {
            FormCorreios correios = new FormCorreios();
            correios.Show();
        }

        private void BtContas_Click(object sender, EventArgs e)
        {
            FrmContas frmconta = new FrmContas();
            frmconta.ShowDialog();
        }

        private void BtMercadoPago_Click(object sender, EventArgs e)
        {
            FormMercadoPago mercadopago = new FormMercadoPago();
            mercadopago.ShowDialog();
        }

        private String CriarRelatorioProduto()
        {
            DataGridView DgURL = new DataGridView();
            DgURL.Columns.Add("NOMEPC", "NOMEPC");
            DgURL.Columns.Add("USUARIOPC", "USUARIOPC");
            DgURL.Columns.Add("MACPC", "MACPC");
            DgURL.Columns.Add("TIPOAPP", "TIPOAPP");
            DgURL.Columns.Add("DATAINSTALACAO", "DATAINSTALACAO");
            DgURL.Columns.Add("SO", "SO");
            DgURL.Columns.Add("PROCESSADOR", "PROCESSADOR");

            List<Classes.Bioghet_AppInstalado> bioghet_Apps = Classes.Bioghet_ConsultaMysql.Listar_AppInstalado();
            String[] Param = new String[7];

            for(int i = 0; i < bioghet_Apps.Count; i++)
            {
                Param[0] = bioghet_Apps[i].NomePC;
                Param[1] = bioghet_Apps[i].UsuarioPC;
                Param[2] = bioghet_Apps[i].MACPC;
                Param[3] = bioghet_Apps[i].TipoAPP;
                Param[4] = bioghet_Apps[i].DataInstalacao.ToString();
                Param[5] = bioghet_Apps[i].SO;
                Param[6] = bioghet_Apps[i].Arquitetura;

                DgURL.Rows.Add(Param);
            }

            String formatohtml = String.Empty;

            Font fonte = DgURL.ColumnHeadersDefaultCellStyle.Font;

            int tabSize = 0;
            foreach (DataGridViewColumn col in DgURL.Columns)
                if (col.Visible) tabSize += col.Width;

            string[] conteudo = new string[DgURL.Columns.Count];

            formatohtml = ("<html><head>");
            formatohtml += ("<meta http-equiv='Content-Type' "
                + "content='text/html; charset=utf-8' />");
            formatohtml += ("<title>" + "RELAÇÃO DOS COMPUTADORES INSTALADO" + "</title>");
            formatohtml += ("</head><body>");
            //formatohtml += ("<center><p><image src='" + Environment.CurrentDirectory + "\\logotelecentro.png" + "' align='middle'><image src='" + Environment.CurrentDirectory + "\\logobioghet.png"+ "' align='middle'></p></center>");
            formatohtml += ("<div style='text-align:center; font-weight:bold; font-size:20px'>RELATÓRIO DE INSTALAÇÃO DO APLICATIVO</div> ");
            formatohtml += ("<br>");
            formatohtml += ("<div style='position:static'>");
            formatohtml += ("<table align=center style='border-collapse: collapse; width:"
                + tabSize.ToString() + "px'>");
            formatohtml += ("<tr>");

            foreach (DataGridViewColumn coluna in DgURL.Columns)
            {
                if (coluna.Visible)
                {
                    formatohtml += ("<td style='padding: 2px 2px 2px 2px; "
                        + "font-weight:bold; font-size:"
                        + Convert.ToInt32(fonte.Size + 3).ToString()
                        + "px; border-collapse: collapse; ' align='"
                        + coluna.InheritedStyle.Alignment.ToString().Substring(6,
                            coluna.InheritedStyle.Alignment.ToString().Length - 6)
                        + "' width='" + coluna.Width + "'>");
                    formatohtml += ("<font face='" + fonte.Name + "'>");
                    formatohtml += (coluna.HeaderText.ToString());
                    formatohtml += ("</font>");
                    formatohtml += ("</td>");
                }
            }
            formatohtml += ("</tr>");
            if (DgURL.Rows.Count > 0)
            {
                foreach (DataGridViewRow linha in DgURL.Rows)
                {
                    formatohtml += ("<tr>");
                    foreach (DataGridViewCell celula in linha.Cells)
                    {
                        if (celula.Visible)
                        {
                            formatohtml += ("<td style='padding: 2px 2px 2px 2px; font-size:"
                                + Convert.ToInt32(fonte.Size + 3).ToString()
                                + "; border-collapse: collapse; ' align='"
                                + celula.InheritedStyle.Alignment.ToString().Substring(6,
                                    celula.InheritedStyle.Alignment.ToString().Length - 6)
                                + "' width='" + celula.Size.Width + "'>");
                            formatohtml += ("<font face='" + fonte.Name + "'>"
                                + celula.FormattedValue.ToString() + "</font>");
                            formatohtml += ("</td>");
                        }
                    }
                    formatohtml += ("</tr>");
                }
            }
            formatohtml += ("</table></div></body></html>");

            formatohtml += ("<br>");
            formatohtml += ("<br>");
            formatohtml += ("<hr />");
            formatohtml += ("<br>");
            formatohtml += ("<br>");

            return formatohtml;
        }
        private void BtAplicativos_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter(Environment.CurrentDirectory + "\\Relatorio\\Aplicativos.html");
                arquivo.WriteLine(CriarRelatorioProduto());
                arquivo.Flush();
                arquivo.Close();

                DialogResult Pergunta = MessageBox.Show("ARQUIVO GERADO COM SUCESSO, DESEJA VISUALIZAR O ARQUIVO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (Pergunta == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\Relatorio\\Aplicativos.html");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
