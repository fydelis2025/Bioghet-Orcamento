using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NITGEN.SDK.NBioBSP;

namespace Bioghet_Orcamento
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private Login _logon;

        private void limparcampos()
        {
            TxNome.ResetText();
            TxUsuario.ResetText();
            TxSenha.ResetText();

            _logon = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(_logon == null)
                {
                    _logon = new Login();
                    _logon.Nome = TxNome.Text;
                    _logon.Usuario = TxUsuario.Text;
                    _logon.Senha = Criptografia.Encripta(TxSenha.Text);
                    _logon.Adm = ChAdm.Checked;
                    _logon.Ativo = true;
                    _logon.Bloqueado = ChBloqueado.Checked;
                    _logon.Tentativa = 0;
                    _logon.Filial = int.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "EMPRESA", ""));
                    Classes.Bioghet_Configuracao.Foto = ConverterImage(PImage.Image);

                    Classes.Bioghet_Configuracao._Retorno = Classes.Bioghet_InserirMYSQL.Criar_Usuario(_logon);
                    

                    if (Classes.Bioghet_Configuracao._Retorno.Equals(1))
                    {
                        MessageBox.Show("USUARIO CRIADO COM SUCESSO", "ACESSO RESTRITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("FALHA AO CRIAR O USUÁRIO");
                    }
                }
                else
                {
                    _logon.Nome = TxNome.Text;
                    _logon.Usuario = TxUsuario.Text;
                    _logon.Senha = Criptografia.Encripta(TxSenha.Text);
                    _logon.Adm = ChAdm.Checked;
                    _logon.ID = Classes.Bioghet_Consultas.Consultar_IDUsuario(TxUsuario.Text);
                    _logon.Bloqueado = ChBloqueado.Checked;
                    _logon.Tentativa = 0;
                    _logon.Filial = int.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "EMPRESA", ""));
                    Classes.Bioghet_Configuracao.Foto = ConverterImage(PImage.Image);

                    Classes.Bioghet_Configuracao._Retorno = Classes.Bioghet_UpdateMYSQL.Atualizar_Usuario(_logon);

                    if (Classes.Bioghet_Configuracao._Retorno.Equals(1))
                    {
                        MessageBox.Show("USUARIO ATUALIZADO COM SUCESSO", "ACESSO RESTRITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("FALHA AO ATUALIZAR O USUÁRIO");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public byte[] ConverterImage(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); //aqui voce troca o formato de arquivo a salvar
                return ms.ToArray();
            }
        }

        private List<Login> _login;
        private void ChUser_Click(object sender, EventArgs e)
        {
            try
            {
                if(ChUser.Checked.Equals(true))
                {
                    DgConsulta.Rows.Clear();


                    _login = Classes.Bioghet_ConsultaMysql.Listar_Login();
                    

                    String[] param = new String[3];

                    for(int i = 0; i <_login.Count; i++)
                    {
                        param[0] = _login[i].Nome;
                        param[1] = _login[i].Usuario;
                        param[2] = _login[i].Senha;

                        DgConsulta.Rows.Add(param);
                    }

                }
                else
                {
                    DgConsulta.Rows.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void DgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex.Equals(3))
                {
                    TxNome.Text = DgConsulta.CurrentRow.Cells[0].Value.ToString();
                    TxUsuario.Text = DgConsulta.CurrentRow.Cells[1].Value.ToString();
                    TxSenha.Text = Criptografia.Descripto(DgConsulta.CurrentRow.Cells[2].Value.ToString());

                    _logon = new Login();
                    _logon.Nome = TxNome.Text;
                    _logon.Usuario = TxUsuario.Text;
                    _logon.Senha = TxSenha.Text;

                    byte[] retorno = Classes.Bioghet_ConsultaMysql.Consultar_FotoBiometriaUsuario(TxUsuario.Text);
                    PImage.Image = ConvertByteToImage(retorno);

                }

                if (e.ColumnIndex.Equals(4))
                {
                    DialogResult resultado;

                    resultado = MessageBox.Show("DESEJA REALMENTE EXCLUIR O USUARIO " + DgConsulta.CurrentRow.Cells[0].Value.ToString(), "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if(resultado == System.Windows.Forms.DialogResult.Yes)
                    {

                        int codigo = Classes.Bioghet_ConsultaMysql.Consultar_IDUsuario(DgConsulta.CurrentRow.Cells[0].Value.ToString());
                        Classes.Bioghet_Delete.ExcluirLogin(codigo);
                        

                        MessageBox.Show("USUARIO EXCLUIDO COM SUCESSO");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChMostrar_Click(object sender, EventArgs e)
        {
            if(ChMostrar.Checked.Equals(true))
            {
                TxSenha.UseSystemPasswordChar = false;
                //Criptografia.Descripto(TxSenha.Text);
            }
            else
            {
                TxSenha.UseSystemPasswordChar = true;

            }
        }

        List<String> Lista = new List<String>();
        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {

                Lista = Classes.Bioghet_ConsultaSQL.Visualizar_Filiais();

                CbFilial.Items.Clear();
                for (int i = 0; i < Lista.Count; i++)
                {
                    CbFilial.Items.Add(Lista[i].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool mouseClicked;
        Point clickedAt;

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void FormLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                _logon = null;
                TxNome.ResetText();
                TxUsuario.ResetText();
                TxSenha.ResetText();
                ChAdm.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgConsulta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void DgConsulta_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private NBioAPI _scan;
        private Boolean result = true;
        private uint _ret;
        //private NBioAPI.Type.HFIR HFIR;
        private NBioAPI.Type.WINDOW_OPTION _Opcao;
        private String _ForeRGB, _BkRGB;
        private void PImage_Click(object sender, EventArgs e)
        {
            try
            {
                _Opcao = new NBioAPI.Type.WINDOW_OPTION();
                _scan = new NBioAPI();
                _Opcao.Option2 = new NBioAPI.Type.WINDOW_OPTION_2();

                _ForeRGB = "000000";
                _BkRGB = "FFFFFF";

                _Opcao.WindowStyle = NBioAPI.Type.WINDOW_STYLE.INVISIBLE;
                _Opcao.Option2.FPForeColor[0] = Convert.ToByte(_ForeRGB.Substring(0, 2), 16);
                _Opcao.Option2.FPForeColor[1] = Convert.ToByte(_ForeRGB.Substring(2, 2), 16);
                _Opcao.Option2.FPForeColor[2] = Convert.ToByte(_ForeRGB.Substring(4, 2), 16);

                _Opcao.Option2.FPBackColor[0] = Convert.ToByte(_BkRGB.Substring(0, 2), 16);
                _Opcao.Option2.FPBackColor[1] = Convert.ToByte(_BkRGB.Substring(2, 2), 16);
                _Opcao.Option2.FPBackColor[2] = Convert.ToByte(_BkRGB.Substring(4, 2), 16);

                if (result == true)
                {
                    _Opcao.FingerWnd = PImage.Handle;
                }
                else
                {
                    _Opcao.FingerWnd = IntPtr.Zero;
                }

                _Opcao.WindowStyle |= (result) ? (uint)NBioAPI.Type.WINDOW_STYLE.NO_FPIMG : 0;
                _Opcao.WindowStyle |= (result) ? (uint)NBioAPI.Type.WINDOW_STYLE.NO_TOPMOST : 0;
                _Opcao.WindowStyle |= (result) ? (uint)NBioAPI.Type.WINDOW_STYLE.NO_WELCOME : 0;

                _Opcao.CaptureCallBackInfo = new NBioAPI.Type.CALLBACK_INFO_0();
                _Opcao.CaptureCallBackInfo.CallBackFunction = new NBioAPI.Type.WINDOW_CALLBACK_0(__CaptureCallback);
                _Opcao.FinishCallBackInfo = new NBioAPI.Type.CALLBACK_INFO_1();
                _Opcao.FinishCallBackInfo.CallBackFunction = new NBioAPI.Type.WINDOW_CALLBACK_1(__FinalizaCallback);

                NBioAPI.Type.HFIR hCapturedFIR;

                _scan.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);
                _scan.Capture(out hCapturedFIR, NBioAPI.Type.TIMEOUT.DEFAULT, _Opcao);
                _scan.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public uint __CaptureCallback(ref NBioAPI.Type.WINDOW_CALLBACK_PARAM_0 cbParam0, IntPtr userParam)
        {
            NBioAPI.Type.WINDOW_CALLBACK_PARAM_EX ParamEx = (NBioAPI.Type.WINDOW_CALLBACK_PARAM_EX)System.Runtime.InteropServices.Marshal.PtrToStructure(cbParam0.ParamEx, typeof(NBioAPI.Type.WINDOW_CALLBACK_PARAM_EX));
            string szQuality = cbParam0.Quality.ToString();

            if (labelImgQuality.InvokeRequired)
            {
                labelImgQuality.Invoke(new MethodInvoker(delegate ()
                {
                    labelImgQuality.Text = szQuality;
                }
                   ));
            }
            else
                labelImgQuality.Text = szQuality;

            return 0;
        }

        public uint __FinalizaCallback(ref NBioAPI.Type.WINDOW_CALLBACK_PARAM_1 cbParam1, IntPtr userParam)
        {
            //labelResult.Text = cbParam1.Result.ToString();
            string szResult = cbParam1.Result.ToString();

            if (labelResult.InvokeRequired)
            {
                labelResult.Invoke(new MethodInvoker(delegate ()
                {
                    labelResult.Text = szResult;
                }
                   ));
            }
            else
                labelResult.Text = szResult;

            return 0;
        }
    }
}
