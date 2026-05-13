using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class FormTelecentro : Form
    {
        private Bioghet_Telecentro_ _orcamento = null;
        private Bioghet_Items _items = null;

        WebCam _mywebcam = new WebCam();

        public const int WM_USER = 1024;

        public const int WM_CAP_CONNECT = 1034;
        public const int WM_CAP_DISCONNECT = 1035;
        public const int WM_CAP_GT_FRAME = 1084;
        public const int WM_CAP_COPY = 1054;

        public const int WM_CAP_START = WM_USER;

        public const int WM_CAP_DLG_VIDEOFORMAT = WM_CAP_START + 41;
        public const int WM_CAP_DLG_VIDEOSOURCE = WM_CAP_START + 42;
        public const int WM_CAP_DLG_VIDEODISPLAY = WM_CAP_START + 43;
        public const int WM_CAP_GET_VIDEOFORMAT = WM_CAP_START + 44;
        public const int WM_CAP_SET_VIDEOFORMAT = WM_CAP_START + 45;
        public const int WM_CAP_DLG_VIDEOCOMPRESSION = WM_CAP_START + 46;
        public const int WM_CAP_SET_PREVIEW = WM_CAP_START + 50;
        public FormTelecentro()
        {
            InitializeComponent();
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            try
            {
                _orcamento = null;
                LimparCampos();
                DgLista.Rows.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!String.IsNullOrWhiteSpace(TxMarca.Text) && (!String.IsNullOrWhiteSpace(TxModelo.Text) && (!String.IsNullOrWhiteSpace(TxTipo.Text)) && (!String.IsNullOrWhiteSpace(TxImei.Text)))))
                {
                    if (_orcamento == null)
                    {
                        _orcamento = new Bioghet_Telecentro_();
                        _orcamento.Nome = TxCliente.Text;
                        _orcamento.CPF = TxCpf.Text;
                        _orcamento.Telefone = TxTelefone.Text;
                        _orcamento.Tipo = TxTipo.Text;
                        _orcamento.Marca = TxMarca.Text;
                        _orcamento.Modelo = TxModelo.Text;
                        _orcamento.Imei = TxImei.Text;
                        _orcamento.Defeito = TxDefeito.Text;
                        _orcamento.OBS = TxObs.Text;
                        _orcamento.Foto = Classes.Bioghet_Configuracao.Foto1;
                        _orcamento.Foto1 = Classes.Bioghet_Configuracao.Foto2;
                        _orcamento.Foto2 = Classes.Bioghet_Configuracao.Foto3;
                        _orcamento.Funcionario = TxFuncionario.Text;
                        _orcamento.Total = decimal.Parse(LbTotal.Text);
                        _orcamento.MO = decimal.Parse(TxMO.Text);

                        Classes.Bioghet_Inserir.bioghet_telecentro(_orcamento);

                        MessageBox.Show("ORÇAMENTO GERADO COM SUCESSO", "ORÇAMENTO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        BtSalvar.Enabled = false;
                    }
                    else
                    {
                        _orcamento = new Bioghet_Telecentro_();
                        _orcamento.Nome = TxCliente.Text;
                        _orcamento.CPF = TxCpf.Text;
                        _orcamento.Telefone = TxTelefone.Text;
                        _orcamento.Tipo = TxTipo.Text;
                        _orcamento.Marca = TxMarca.Text;
                        _orcamento.Modelo = TxModelo.Text;
                        _orcamento.Imei = TxImei.Text;
                        _orcamento.Defeito = TxDefeito.Text;
                        _orcamento.OBS = TxObs.Text;
                        _orcamento.Foto = Classes.Bioghet_Configuracao.Foto1;
                        _orcamento.Foto1 = Classes.Bioghet_Configuracao.Foto2;
                        _orcamento.Foto2 = Classes.Bioghet_Configuracao.Foto3;
                        _orcamento.Funcionario = TxFuncionario.Text;
                        _orcamento.Total = decimal.Parse(LbTotal.Text);
                        _orcamento.MO = decimal.Parse(TxMO.Text);

                        Classes.Bioghet_Update.Atualizar_Bioghet_Telecentro(_orcamento);
                        

                        MessageBox.Show("ORÇAMENTO ATUALIZADO COM SUCESSO", "ORÇAMENTO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    throw new Exception("EXISTEM CAMPOS NULOS FAVOR VERIFICAR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImageSize()
        {
            _mywebcam.m_Width = PImage.Size.Width;
            _mywebcam.m_Height = PImage.Size.Height;
        }

        public void Stop()
        {
            try
            {
                WebCam.bStopped = true;
                tmrRefrashFrame.Stop();


                Application.DoEvents();

                WebCam.SendMessage(_mywebcam.m_CapHwnd, WM_CAP_DISCONNECT, 0, 0);

                WebCam.CloseClipboard();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Start()
        {
            try
            {
                ImageSize();

                this.Stop();

                _mywebcam.m_CapHwnd = WebCam.capCreateCaptureWindowA("RealsoftWebCam", 0, 0, 0, _mywebcam.m_Width, _mywebcam.m_Height, this.Handle.ToInt32(), 0);

                Application.DoEvents();

                WebCam.SendMessage(_mywebcam.m_CapHwnd, WM_CAP_CONNECT, 0, 0);

                this.tmrRefrashFrame.Interval = 1;

                WebCam.bStopped = false;
                this.tmrRefrashFrame.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Stop();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Stop();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            try
            {
                TxCliente.ResetText();
                TxCpf.ResetText();
                TxTelefone.ResetText();
                TxMarca.ResetText();
                TxModelo.ResetText();
                TxDefeito.ResetText();
                TxTipo.ResetText();
                TxImei.ResetText();
                TxObs.ResetText();
                TxFuncionario.ResetText();
                Classes.Bioghet_Configuracao.Foto1 = string.Empty;
                Classes.Bioghet_Configuracao.Foto2 = string.Empty;
                Classes.Bioghet_Configuracao.Foto3 = string.Empty;
                BtSalvar.Enabled = true;
                TxMO.Text = "0,00";
                LbTotal.Text = "0,00";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int contador = 1;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Stop();

                if (contador.Equals(1))
                {
                    Classes.Bioghet_Configuracao.Foto1 = Environment.CurrentDirectory + "\\Fotos\\" + TxImei.Text + "_" + contador.ToString() + ".jpg";
                    PImage.Image.Save(Classes.Bioghet_Configuracao.Foto1, ImageFormat.Jpeg);
                    MessageBox.Show("Imagem salva com sucesso");

                    contador = contador + 1;
                }
                else if (contador.Equals(2))
                {
                    Classes.Bioghet_Configuracao.Foto2 = Environment.CurrentDirectory + "\\Fotos\\" + TxImei.Text + "_" + contador.ToString() + ".jpg";
                    PImage.Image.Save(Classes.Bioghet_Configuracao.Foto2, ImageFormat.Jpeg);
                    MessageBox.Show("Imagem salva com sucesso");
                    contador = contador + 1;
                }
                else if (contador.Equals(3))
                {
                    Classes.Bioghet_Configuracao.Foto3 = Environment.CurrentDirectory + "\\Fotos\\" + TxImei.Text + "_" + contador.ToString() + ".jpg";
                    PImage.Image.Save(Classes.Bioghet_Configuracao.Foto3, ImageFormat.Jpeg);
                    MessageBox.Show("Imagem salva com sucesso");
                    contador = contador + 1;
                }
                else
                {
                    throw new Exception("QUANTIDADE DE IMAGEM EXCEDIDO");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void tmrRefrashFrame_Tick(object sender, EventArgs e)
        {
            try
            {
                this.tmrRefrashFrame.Stop();

                ImageSize();

                WebCam.SendMessage(this._mywebcam.m_CapHwnd, WM_CAP_GT_FRAME, 0, 0);

                WebCam.SendMessage(this._mywebcam.m_CapHwnd, WM_CAP_COPY, 0, 0);

                WebCam.OpenClipboard(this._mywebcam.m_CapHwnd);

                IntPtr img = WebCam.GetClipboardData(2);

                WebCam.CloseClipboard();

                IDataObject tempObj = Clipboard.GetDataObject();
                Image tempImg = (System.Drawing.Bitmap)tempObj.GetData(DataFormats.Bitmap);

                PImage.Image = tempImg;

                PImage.Refresh();

                Application.DoEvents();

                if (!WebCam.bStopped)
                {
                    this.tmrRefrashFrame.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormTelecentro_Load(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao._servico = Classes.Bioghet_Consultas.Listar_TipoServico();
                Classes.Bioghet_Configuracao.func = Classes.Bioghet_Consultas.Listar_Funcionario();
                

                for (int servico = 0; servico < Classes.Bioghet_Configuracao._servico.Count; servico++)
                {
                    TxTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao.ToUpper());
                }

                for (int i = 0; i < Classes.Bioghet_Configuracao.func.Count; i++)
                {
                    TxFuncionario.Items.Add(Classes.Bioghet_Configuracao.func[i].Nome);
                }

                TxTipo.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void TxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao._marca = Classes.Bioghet_Consultas.Listar_Marca(TxTipo.Text);

                TxMarca.Items.Clear();
                for (int m = 0; m < Classes.Bioghet_Configuracao._marca.Count; m++)
                {
                    TxMarca.Items.Add(Classes.Bioghet_Configuracao._marca[m].Descricao.ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_Consultas.Consultar_IdMarca(TxMarca.Text, TxTipo.Text);
                Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_Consultas.Listar_Modelo(Classes.Bioghet_Configuracao.CodigoMarca);

                TxModelo.ResetText();

                TxModelo.Items.Clear();

                for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                {
                    TxModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                }

                TxModelo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxMarca_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    String retorno = string.Empty;

                    retorno = Classes.Bioghet_Consultas.Consultar_Marca(TxMarca.Text);

                    if (!retorno.Equals(string.Empty))
                    {
                        TxModelo.Focus();
                    }
                    else
                    {
                        throw new Exception("MARCA NÃO ENCONTRADA, FAVOR VERIFIQUE");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxModelo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TxModelo.Items.Clear();


                String _modelo = TxModelo.Text;
                Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_Consultas.Listar_ModeloDigitado(_modelo.ToUpper());

                for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                {
                    TxModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                }

                TxModelo.DroppedDown = true;
            }
        }

        private void TxModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);

                    TxModelo.Items.Clear();

                    String _modelo = e.KeyChar.ToString();
                    Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_Consultas.Listar_ModeloDigitado(_modelo.ToUpper());

                    for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                    {
                        TxModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxModelo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TxDefeito.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int item = 0;
        private void TxDefeito_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _items = new Bioghet_Items();


                Classes.Bioghet_Configuracao.obra = Classes.Bioghet_Consultas.Listar_MaoObraOrcamento(TxDefeito.Text, TxTipo.Text, TxMarca.Text, TxModelo.Text);
                

                if (Classes.Bioghet_Configuracao.obra != null)
                {
                    String[] param = new String[6];
                    for (int i = 0; i < Classes.Bioghet_Configuracao.obra.Count; i++)
                    {
                        if (Classes.Bioghet_Configuracao.obra[i].TipoPecas.Equals(1))
                        {
                            item = item + 1;

                            param[0] = item.ToString();
                            param[1] = Classes.Bioghet_Configuracao.obra[i].Peca;
                            param[2] = "1";
                            param[3] = Classes.Bioghet_Configuracao.obra[i].Valor.ToString("#####0.00");
                            param[4] = "0,00";
                            param[5] = Decimal.Subtract(Classes.Bioghet_Configuracao.obra[i].Total, Classes.Bioghet_Configuracao.obra[i].ValorMO).ToString("#####0.00");

                            DgLista.Rows.Add(param);

                            _items.Item = item;
                            _items.Descricao = Classes.Bioghet_Configuracao.obra[i].Peca;
                            _items.Quantidade = int.Parse("1");
                            _items.Valor = Classes.Bioghet_Configuracao.obra[i].Valor;
                            _items.SubTotal = decimal.Parse(param[5]);
                            _items.Serial = TxImei.Text;


                            Classes.Bioghet_Inserir.bioghet_telecentro_Items(_items);
                            
                        }

                    }

                    Decimal Total = 0;

                    foreach (DataGridViewRow coluna in DgLista.Rows)
                    {
                        Decimal Valor = Decimal.Parse(coluna.Cells[5].Value.ToString());

                        Total = Decimal.Add(Total, Valor);
                    }

                    LbTotal.Text = Total.ToString("#####0.00");

                    TxImei.Focus();
                }
                else
                {
                    throw new Exception("ORÇAMENTO NÃO ENCONTRADO");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxDefeito_Click(object sender, EventArgs e)
        {
            try
            {
                TxDefeito.Items.Clear();

                //if (Parametro.StatusConexao.Equals(Parametro.StatusInternet.OFFILINE.ToString()))
                //{
                //    Parametro._Listardef = Listar.Listar_Defeito(TxTipo.Text);
                //}
                //else
                //{
                //    Parametro._Listardef = ONLINE.Listar.Listar_Defeito(TxTipo.Text);
                //}

                //for (int r = 0; r < Parametro._Listardef.Count; r++)
                //{
                //    TxDefeito.Items.Add(Parametro._Listardef[r].Descricao);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxMO_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    Decimal SubTotal = Decimal.Parse(LbTotal.Text);
                    Decimal Total = Decimal.Add(Decimal.Parse(TxMO.Text), SubTotal);

                    LbTotal.Text = Total.ToString("#####0.00");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChGerarImei_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChGerarImei.Checked.Equals(true))
                {
                    Random gerarimei = new Random();
                    TxImei.Text = gerarimei.Next(999999999).ToString();
                   
                }
                else
                {
                    TxImei.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void orçamentoTelecentroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Parametro.campo = TxImei.Text;

                //if (Parametro.campo.Equals(String.Empty))
                //{
                //    throw new Exception("NÃO FOI POSSIVEL CARREGAR O RELATÓRIO FAVOR VERIFIQUE SE O ORÇAMENTO FOI GERADO");
                //}
                //else
                //{

                //    LbStatus.Text = Parametro.Status.IMPRESSO.ToString();

                //    if (Parametro.StatusConexao.Equals(Parametro.StatusInternet.OFFILINE.ToString()))
                //    {
                //        Inserir.Atualizar_Status(LbStatus.Text, TxImei.Text);
                //    }
                //    else
                //    {
                //        ONLINE.Inserir.Atualizar_Status(LbStatus.Text, TxImei.Text);
                //    }

                //    Telecentro_Orcamento frm = new Telecentro_Orcamento();

                //    frm.ShowDialog();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
