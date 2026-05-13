using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class FormModelo : Form
    {
        public FormModelo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private Modelo _modelo = null;
        private void FormManutencao_Load(object sender, EventArgs e)
        {
            try
            {
                TxNovo.Text = "0,00";
                TxAparelho.Text = "0,00";
                TxMargem.Text = "0";
                TxBR.Text = "BR";
                
                Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();

                for (int servico = 0; servico < Classes.Bioghet_Configuracao._servico.Count; servico++)
                {
                    TxTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao.ToUpper());
                }

                TxAno.Text = DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TxTipo.SelectedIndex = 0;
                //TxCadMarca.SelectedIndex = 7;
                //TxDescricao.Focus();
            }
        }

        private void Listar_Tabela(String Campo)
        {
            try
            {

                if (Campo == String.Empty)
                {
                    Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(TxCadMarca.Text, TxTipo.Text);
                    Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_ModeloURLs(Classes.Bioghet_Configuracao.CodigoMarca);

                    DgURL.Rows.Clear();

                    String[] param = new String[7];
                    for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                    {
                        param[0] = Classes.Bioghet_Configuracao._modelo[i].Descricao;
                        param[1] = Classes.Bioghet_Configuracao._modelo[i].Pais;
                        param[2] = Classes.Bioghet_Configuracao._modelo[i].URL;
                        param[3] = Classes.Bioghet_Configuracao._modelo[i].Novo.ToString("#####0.00");
                        param[4] = Classes.Bioghet_Configuracao._modelo[i].Margem.ToString();
                        param[5] = Classes.Bioghet_Configuracao._modelo[i].Usado.ToString("#####0.00");
                        param[6] = Classes.Bioghet_Configuracao._modelo[i].Ano.ToString();

                        DgURL.Rows.Add(param);
                    }
                }
                else
                {

                    Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(TxCadMarca.Text, TxTipo.Text);
                    Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_ModeloURLsDescricao(Classes.Bioghet_Configuracao.CodigoMarca, Campo);
                    

                    DgURL.Rows.Clear();

                    String[] param = new String[7];
                    for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                    {
                        param[0] = Classes.Bioghet_Configuracao._modelo[i].Descricao;
                        param[1] = Classes.Bioghet_Configuracao._modelo[i].Pais;
                        param[2] = Classes.Bioghet_Configuracao._modelo[i].URL;
                        param[3] = Classes.Bioghet_Configuracao._modelo[i].Novo.ToString("#####0.00");
                        param[4] = Classes.Bioghet_Configuracao._modelo[i].Margem.ToString();
                        param[5] = Classes.Bioghet_Configuracao._modelo[i].Usado.ToString("#####0.00");
                        param[6] = Classes.Bioghet_Configuracao._modelo[i].Ano.ToString();

                        DgURL.Rows.Add(param);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TxCadMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(TxCadMarca.Text, TxTipo.Text);
                Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_ModeloURLs(Classes.Bioghet_Configuracao.CodigoMarca);
                
                DgURL.Rows.Clear();
                
                String[] param = new String[8];
                for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                {
                    param[0] = Classes.Bioghet_Configuracao._modelo[i].Descricao;
                    param[1] = Classes.Bioghet_Configuracao._modelo[i].Pais;
                    param[2] = Classes.Bioghet_Configuracao._modelo[i].URL;
                    param[3] = Classes.Bioghet_Configuracao._modelo[i].Novo.ToString("#####0.00");
                    param[4] = Classes.Bioghet_Configuracao._modelo[i].Margem.ToString();
                    param[5] = Classes.Bioghet_Configuracao._modelo[i].Usado.ToString("#####0.00");
                    param[6] = Classes.Bioghet_Configuracao._modelo[i].Ano.ToString();
                    param[7] = Classes.Bioghet_Configuracao._modelo[i].Mes.ToString();

                    DgURL.Rows.Add(param);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao._marca = Classes.Bioghet_ConsultaMysql.Listar_Marca(TxTipo.Text);

                TxCadMarca.Items.Clear();
                for (int m = 0; m < Classes.Bioghet_Configuracao._marca.Count; m++)
                {
                    TxCadMarca.Items.Add(Classes.Bioghet_Configuracao._marca[m].Descricao.ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpar_campos()
        {
            TxTipo.ResetText();
            TxCadMarca.ResetText();
            TxDescricao.ResetText();
            TxBR.Text = "BR";
            TxURL.ResetText();
            TxAno.Text = DateTime.Now.Year.ToString();
            TxNovo.Text = "0,00";
            TxAparelho.Text = "0,00";
            TxMargem.Text = "10";
            DgURL.Rows.Clear();
            TxURLLocal.ResetText();

            PImage.Image = null;
        }

        internal void Criar_Modelo()
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(AllwaysGoodCertificate);

                Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(TxCadMarca.Text, TxTipo.Text);
                Classes.Bioghet_Configuracao.retorno = Classes.Bioghet_ConsultaMysql.get_modelo_Dpl(TxDescricao.Text);

                if (_modelo == null)
                {
                    _modelo = new Modelo();

                    _modelo.Marca = Classes.Bioghet_Configuracao.CodigoMarca;
                    _modelo.Descricao = TxDescricao.Text;
                    _modelo.URL = TxURL.Text;
                    _modelo.Pais = TxBR.Text;
                    _modelo.Ano = int.Parse(TxAno.Text);
                    _modelo.Novo = decimal.Parse(TxNovo.Text);
                    _modelo.Usado = decimal.Parse(TxAparelho.Text);
                    _modelo.Margem = decimal.Parse(TxMargem.Text);
                    _modelo.URl1 = TxURLLocal.Text;
                    _modelo.Mes = int.Parse(TxMesAno.Text);

                    if (!String.IsNullOrWhiteSpace(TxURL.Text))
                    {
                        var request = WebRequest.Create(TxURL.Text);

                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            MemoryStream img = new MemoryStream();

                            PImage.Image = Bitmap.FromStream(stream);

                            PImage.Image.Save(img, ImageFormat.Jpeg);

                            byte[] foto = img.ToArray();

                            Classes.Bioghet_Configuracao.Foto = foto;
                        }
                    }
                    else
                    {
                        Classes.Bioghet_Configuracao.Foto = null;
                    }

                    //if (!String.IsNullOrWhiteSpace(TxURLLocal.Text))
                    //{
                    //    var request = WebRequest.Create(TxURLLocal.Text);

                    //    using (var response = request.GetResponse())
                    //    using (var stream = response.GetResponseStream())
                    //    {
                    //        MemoryStream imgpeca = new MemoryStream();

                    //        PImagePeca.Image = Bitmap.FromStream(stream);

                    //        PImagePeca.Image.Save(imgpeca, ImageFormat.Jpeg);

                    //        byte[] fotopeca = imgpeca.ToArray();

                    //        Classes.Bioghet_Configuracao.FotoPeca = fotopeca;
                    //    }
                    //}
                    //else
                    //{
                    //    Classes.Bioghet_Configuracao.FotoPeca = null;
                    //}
                    //Classes.Bioghet_Configuracao.retorno = Classes.Bioghet_ConsultaMysql.Consultar_DescricaoMarcas(Classes.Bioghet_Configuracao.CodigoMarca);

                    if (Classes.Bioghet_Configuracao.retorno.Equals(false))
                    {

                        Classes.Bioghet_InserirMYSQL.Criar_Modelo(_modelo);

                        MessageBox.Show("MODELO CRIADO COM SUCESSO");
                    }
                    else
                    {
                        throw new Exception("MODELO JA CADASTRADO");
                    }
                }
                else
                {

                    Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(TxCadMarca.Text, TxTipo.Text);
                    _modelo.ID = Classes.Bioghet_ConsultaMysql.Consultar_IdModelo(DgURL.CurrentRow.Cells[0].Value.ToString());
                    
                    _modelo.Marca = Classes.Bioghet_Configuracao.CodigoMarca;
                    _modelo.Descricao = TxDescricao.Text;
                    _modelo.URL = TxURL.Text;
                    _modelo.Pais = TxBR.Text;
                    _modelo.Ano = int.Parse(TxAno.Text);
                    _modelo.Novo = decimal.Parse(TxNovo.Text);
                    _modelo.Usado = decimal.Parse(TxAparelho.Text);
                    _modelo.Margem = decimal.Parse(TxMargem.Text);
                    _modelo.URl1 = TxURLLocal.Text;
                    _modelo.Mes = int.Parse(TxMesAno.Text);

                    if (!String.IsNullOrWhiteSpace(TxURL.Text))
                    {
                        var request = WebRequest.Create(TxURL.Text);
                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            MemoryStream img = new MemoryStream();

                            PImage.Image = Bitmap.FromStream(stream);

                            PImage.Image.Save(img, ImageFormat.Jpeg);

                            byte[] foto = img.ToArray();

                            Classes.Bioghet_Configuracao.Foto = foto;
                        }
                    }
                    else
                    {
                        byte[] retorno = Classes.Bioghet_ConsultaMysql.Consultar_FotoURLModelo(TxDescricao.Text);
                        PImage.Image = ConvertByteToImage(retorno);

                        Classes.Bioghet_Configuracao.Foto = null;
                    }

                    //if (!String.IsNullOrWhiteSpace(TxURLLocal.Text))
                    //{
                    //    var request = WebRequest.Create(TxURLLocal.Text);

                    //    using (var response = request.GetResponse())
                    //    using (var stream = response.GetResponseStream())
                    //    {
                    //        MemoryStream imgpeca = new MemoryStream();

                    //        PImagePeca.Image = Bitmap.FromStream(stream);

                    //        PImagePeca.Image.Save(imgpeca, ImageFormat.Jpeg);

                    //        byte[] fotopeca = imgpeca.ToArray();

                    //        Classes.Bioghet_Configuracao.FotoPeca = fotopeca;
                    //    }
                    //}
                    //else
                    //{
                    //   byte[] retorno = Classes.Bioghet_ConsultaMysql.Consultar_FotoURLLocalModelo(TxURLLocal.Text);
                    //   PImagePeca.Image = ConvertByteToImage(retorno);

                    //    Classes.Bioghet_Configuracao.FotoPeca = null;
                    //}

                    Classes.Bioghet_Configuracao.FotoPeca = null;
                    Classes.Bioghet_Configuracao._Retorno = Classes.Bioghet_UpdateMYSQL.UpdateModelo(_modelo);

                    if (Classes.Bioghet_Configuracao._Retorno.Equals(1))
                    {
                        MessageBox.Show("MODELO ATUALIZADO COM SUCESSO");
                    }
                    else
                    {
                        throw new Exception("Erro ao tentar atualizar a tabela");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AllwaysGoodCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        private Image ConvertByteToImage(byte[] __bp)
        {
            if (__bp != null)
            {
                try
                {
                    MemoryStream Stream = new MemoryStream();
                    Stream.Write(__bp, 0, __bp.Length);
                    Stream.Position = 0;
                    __bp = System.Text.UnicodeEncoding.Convert(Encoding.Unicode, Encoding.Default, __bp);
                    Image img = Image.FromStream(Stream);
                    return img;
                }
                catch
                {
                    return null;
                }

            }
            else return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(TxTipo.Text) && (!String.IsNullOrWhiteSpace(TxCadMarca.Text) && (!String.IsNullOrWhiteSpace(TxDescricao.Text))))
                {

                    Criar_Modelo();
                    
                }
                else
                {
                    throw new Exception("EXISTEM CAMPOS OBRIGATÓRIOS SEM SER PREENXIDOS FAVOR VERIFIQUE");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMarca _FRM = new FormMarca();
            _FRM.ShowDialog();
        }

        private void TxDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Boolean retorno = Classes.Bioghet_ConsultaMysql.get_modelo_Dpl(TxDescricao.Text);

                    if (retorno.Equals(true))
                    {
                        Listar_Tabela(TxDescricao.Text);

                        byte[] retornofoto = Classes.Bioghet_ConsultaMysql.Consultar_FotoURLModelo(TxDescricao.Text);
                        PImage.Image = ConvertByteToImage(retornofoto);

                        throw new Exception("MODELO JA CADASTRADO");
                    }
                    else
                    {
                        Listar_Tabela(TxDescricao.Text);
                        TxBR.Focus();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxBR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxURL.Focus();
            }
        }

        private void TxURL_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (TxURL.TextLength <= 55)
                    {
                        throw new Exception("IMAGEM EM BAIXA RESOLUÇÃO");
                    }
                    else
                    {
                        TxNovo.Focus();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpar_campos();
            _modelo = null;
        }

        private void DgURL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex.Equals(2))
                {
                    object _imag = DgURL.CurrentRow.Cells[2].Value.ToString();

                    if (_imag != null)
                    {
                        PImage.Load(_imag.ToString());
                    }
                }

                if(e.ColumnIndex.Equals(8))
                {
                    object BR = DgURL.CurrentRow.Cells[1].Value;
                    object url = DgURL.CurrentRow.Cells[2].Value;
                    object ano = DgURL.CurrentRow.Cells[6].Value;
                    object mes = DgURL.CurrentRow.Cells[7].Value;
                    object novo = DgURL.CurrentRow.Cells[3].Value;
                    object margem = DgURL.CurrentRow.Cells[4].Value;
                    object usado = DgURL.CurrentRow.Cells[5].Value;

                    //cabeça não boa vou bagacar essa parte para concluir
                    TxDescricao.Text = DgURL.CurrentRow.Cells[0].Value.ToString();
                    
                    TxCadMarca.Text = Classes.Bioghet_ConsultaMysql.Consultar_DescricaoMarca(Classes.Bioghet_ConsultaMysql.Consultar_IdModeloMarca(TxDescricao.Text));

                    if(BR != null)
                    {
                        TxBR.Text = BR.ToString();
                    }

                    if(url != null)
                    {
                        TxURL.Text = url.ToString();
                    }

                    if(ano != null)
                    {
                        TxAno.Text = ano.ToString();
                    }

                    if (mes != null)
                    {
                        TxMesAno.Text = mes.ToString();
                    }


                    TxNovo.Text = novo.ToString();
                    TxMargem.Text = margem.ToString();
                    TxAparelho.Text = usado.ToString();

                    _modelo = new Modelo();
                    _modelo.Descricao = TxDescricao.Text;
                    _modelo.URL = TxURL.Text;
                    _modelo.Pais = TxBR.Text;
                    _modelo.Ano = int.Parse(TxAno.Text);
                    _modelo.Novo = decimal.Parse(novo.ToString());
                    _modelo.Margem = decimal.Parse(margem.ToString());
                    _modelo.Usado = decimal.Parse(usado.ToString());
                    _modelo.Mes = int.Parse(TxMesAno.Text);

                    byte[] retorno = Classes.Bioghet_ConsultaMysql.Consultar_FotoURLModelo(TxDescricao.Text);
                    PImage.Image = ConvertByteToImage(retorno);

                    byte[] retornopeca = Classes.Bioghet_ConsultaMysql.Consultar_FotoURLLocalModelo(TxDescricao.Text);
                    PImagePeca.Image = ConvertByteToImage(retornopeca);
                }

                if(e.ColumnIndex.Equals(9))
                {
                    DialogResult pergunta;

                    pergunta = MessageBox.Show("DESEJA REALMENTE EXCLUIR O MODELO" + TxDescricao.Text, "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(pergunta == System.Windows.Forms.DialogResult.Yes)
                    {

                        int codigomodelo = Classes.Bioghet_ConsultaMysql.Consultar_IdModelo(DgURL.CurrentRow.Cells[0].Value.ToString());

                        Classes.Bioghet_DeleteMYSQL.ExcluirModelo(codigomodelo);

                        MessageBox.Show("MODELO EXCLUIDO COM SUCESSO");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PBuscar_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.PY.Navigate("http://www.comprasparaguai.com.br/busca/?q=" + TxDescricao.Text);
            frm.ML.Navigate("https://lista.mercadolivre.com.br/" + TxDescricao.Text);
            frm.Show();
        }

        private void TxNovo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
        }

        private void TxNovo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TxMargem.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxMargem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxMargem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    decimal novo = decimal.Parse(TxNovo.Text);
                    decimal velho = decimal.Parse(TxAparelho.Text);

                    decimal soma = decimal.Multiply(novo, decimal.Parse(TxMargem.Text)) / 100;

                    decimal subtract = decimal.Subtract(novo, soma);

                    TxAparelho.Text = subtract.ToString("#####0.00");

                    TxMesAno.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxAparelho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
        }

        private String caminhoImage;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string arquivo = Environment.CurrentDirectory + "\\MODELO.xlsx";
                string strConexao = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=0\"", arquivo);
                OleDbConnection conn = new OleDbConnection(strConexao);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                cmd.Connection = conn;
                conn.Open();

                DataTable dtSchema;
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string nomePlanilha = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();
                conn.Open();

                cmd.CommandText = "SELECT * From [" + nomePlanilha + "]";
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                conn.Close();

                Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(TxCadMarca.Text, TxTipo.Text);
                Classes.Bioghet_Configuracao.retorno = Classes.Bioghet_ConsultaMysql.get_modelo_Dpl(TxDescricao.Text);

                FrmViewImport frmView = new FrmViewImport();
                frmView.DgImportado.DataSource = dt;
                frmView.LbTipo.Text = TxTipo.Text;
                frmView.LbMarca.Text = Classes.Bioghet_Configuracao.CodigoMarca.ToString();
                frmView.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxAno_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    Criar_Modelo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private String Ip;
        private Classes.Bioghet_FotoModeloAparelho _fotoAparelho;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(TxURLLocal.Text))
                {
                    _fotoAparelho = new Classes.Bioghet_FotoModeloAparelho();
                    _fotoAparelho.Tipo = TxTipo.Text;
                    _fotoAparelho.Marca = TxCadMarca.Text;
                    _fotoAparelho.Descricao = TxDescricao.Text;

                    if (!String.IsNullOrWhiteSpace(TxURLLocal.Text))
                    {
                        var request = WebRequest.Create(TxURLLocal.Text);

                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            MemoryStream imgpeca = new MemoryStream();

                            PImagePeca.Image = Bitmap.FromStream(stream);

                            PImagePeca.Image.Save(imgpeca, ImageFormat.Jpeg);

                            byte[] fotopeca = imgpeca.ToArray();

                            Classes.Bioghet_Configuracao.FotoPeca = fotopeca;
                        }
                    }
                    else
                    {
                        Classes.Bioghet_Configuracao.FotoPeca = null;
                    }

                    int retorno = Classes.Bioghet_Inserir.Criar_FotoModeloAparelho(_fotoAparelho);

                    if (retorno.Equals(1))
                    {
                        MessageBox.Show("FOTO INSERIRDA COM SUCESSO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("ERRO AO INSERIR A IMAGEM");
                    }
                }
                else
                {
                    throw new Exception("CAMPO URL PEÇA ESTÁ VAZIO, FAVOR VERIFIQUE");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Classes.Bioghet_Configuracao.StatusConexao = Classes.Bioghet_Configuracao.StatusInternet.ONLINE.ToString();
            Form5 _frm = new Form5();
            _frm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.StatusConexao = Classes.Bioghet_Configuracao.StatusInternet.ONLINE.ToString();
            FormTipoServico _tipo = new FormTipoServico();
            _tipo.ShowDialog();
        }

        private void TxTipo_Click(object sender, EventArgs e)
        {
            try
            {
                TxTipo.Items.Clear();

                Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();

                for (int servico = 0; servico < Classes.Bioghet_Configuracao._servico.Count; servico++)
                {
                    TxTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao.ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool mouseClicked;
        Point clickedAt;

        private void FormModelo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void FormModelo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void FormModelo_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void PImage_Click(object sender, EventArgs e)
        {
            try
            {
                FrmExibirFoto _Exibirfoto = new FrmExibirFoto();

                byte[] retorno = Classes.Bioghet_ConsultaMysql.Consultar_FotoURLModelo(TxDescricao.Text);
                _Exibirfoto.PImagem.Image = ConvertByteToImage(retorno);
                _Exibirfoto.Descricao = TxDescricao.Text;
                _Exibirfoto.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxURL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int contador = TxURL.Text.Length;
                //TxURL.MaxLength = contador;

                if (contador > 50 && contador < 55)
                {
                    throw new Exception("IMAGEM EM BAIXA RESOLUÇÃO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxAparelho_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxMesAno.Focus();
            }
        }

        private void TxMesAno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxAno.Focus();
            }
        }

        private void TxMesAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            FrmConsultaURL _foto = new FrmConsultaURL();
            _foto.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.br/");
        }
    }
}
