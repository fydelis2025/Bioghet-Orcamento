using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Xml;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using System.Collections;
using System.Text.RegularExpressions;

namespace Bioghet_Orcamento
{
    public partial class FormMercadoPago : Form
    {
        public FormMercadoPago()
        {
            InitializeComponent();

        }

        internal String ID = Classes.BioCriptografia.Descripto(Ini.GetIniString(Ini.nomeArquivoINI(), "mercadopago", "id", ""));
        internal String Token = Classes.BioCriptografia.Descripto(Ini.GetIniString(Ini.nomeArquivoINI(), "mercadopago", "token", ""));
        internal String ClienteID = Classes.BioCriptografia.Descripto(Ini.GetIniString(Ini.nomeArquivoINI(), "mercadopago", "clientid", ""));
        private async void FormMercadoPago_Shown(object sender, EventArgs e)
        {
            try
            {
                String Formato = await MercadoLivre.PerfilUsuario(Token);

                if(String.IsNullOrEmpty(Formato))
                {
                    throw new Exception("ERRO AO CARREGAR O PERFIL DO USUARIO");
                }

                int NikName, Email, Perfil, Photo, Fone, DataRegistro, Identificacao, MLB, Verificado, IDMerc;

                IDMerc = Formato.IndexOf("id");

               
                NikName = Formato.IndexOf("nickname");
                DataRegistro = Formato.IndexOf("registration_date");

                Email = Formato.IndexOf("email");
                Identificacao = Formato.IndexOf("identification");

                Perfil = Formato.IndexOf("permalink");
                MLB  = Formato.IndexOf("shipping_modes");

                Photo = Formato.IndexOf("picture_url");

                Fone = Formato.IndexOf("extension");
                Verificado = Formato.IndexOf("number");

                String Url = Formato.Substring(Photo + 11).Replace("\"", "").Replace(":", "").Replace(",", "").Insert(5, ":");

                if (IDMerc != -1)
                {
                    if (String.IsNullOrEmpty(ID))
                    {
                        String _ID_ = Formato.Substring(IDMerc + 2, NikName - 2).Replace("\"", "").Replace(":", "").Replace(",", "").Replace("n", "");
                        Ini.gravaarquivoini("mercadopago", "id", Classes.BioCriptografia.Encripta(_ID_));
                    }
                }

                if (NikName != -1)
                {
                    LbNome.Text = Formato.Substring(NikName + 8, DataRegistro - 24).Replace("\"", "").Replace(":", "").Replace(",", "");
                }
                if (Email != -1)
                {
                    String EmailPerfil = Formato.Substring(Email + 5, Identificacao - 14).Replace("\"", "").Replace(":", "").Replace(",", "");
                    int PerfEmail = EmailPerfil.IndexOf("identification");
                    LbEmail.Text = EmailPerfil.Remove(PerfEmail);
                }
                if (Perfil != -1)
                {
                    String FormatoPerfil = Formato.Substring(Perfil + 9, MLB - 14).Replace("\"", "").Replace(":", "").Replace(",", "").Insert(4, ":");
                    int fperfil = FormatoPerfil.IndexOf("hipping_modes");
                    LbPerfil.Text = FormatoPerfil.Remove(fperfil -1);
                }
                if (Photo != -1)
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(AllwaysGoodCertificate);

                    PMercadoPago.ImageLocation = Url;

                }
                if (Fone != -1)
                {
                    String TelefonePerfil = Formato.Substring(Fone + 21, Verificado - 8).Replace("\"", "").Replace(":", "").Replace(",", "");
                    int perfTelefone = TelefonePerfil.IndexOf("verified");

                    LbTelefone.Text = TelefonePerfil.Remove(perfTelefone);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
            }
        }

        private bool AllwaysGoodCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        private void FormMercadoPago_Load(object sender, EventArgs e)
        {

        }

        private void TViwer_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Name.Equals("CORREIOS"))
            {
                Controle.SelectedIndex = 3;
            }
            if(e.Node.Name.Equals("PRODUTOS"))
            {
                Controle.SelectedIndex = 1;
            }
        }

        private async void BtRastrear_Click(object sender, EventArgs e)
        {
            try
            {
                String Retorno = await MercadoLivre.RastreioObjeto(ID, Token);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void CbCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                CbCategoria.Items.Clear();

                String _Categoria = await MercadoLivre.ListarCategoriasMercadoLivre();
               
                String Retorno = CorigeString(_Categoria.Replace("[", "{").Replace("]", "}").Replace(",", "-").Replace("name", "").Replace("id", "").Replace("\"", "").Replace(":", ""));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string CorigeString(string str)
        {
            string[] acentos = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };
            string[] semAcento = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

            for (int i = 0; i < acentos.Length; i++)
            {
                str = str.Replace(acentos[i], semAcento[i]);
            }
            string[] caracteresEspeciais = { "¹", "²", "³", "£", "¢", "¬", "º", "¨", "\"", "'", ".", ",", "-", ":", "(", ")", "ª", "|", "\\\\", "°", "_", "@", "#", "!", "$", "%", "&", "*", ";", "/", "<", ">", "?", "[", "]", "{", "}", "=", "+", "§", "´", "`", "^", "~" };

            for (int i = 0; i < caracteresEspeciais.Length; i++)
            {
                str = str.Replace(caracteresEspeciais[i], "");
            }

            str = Regex.Replace(str, @"[^\w\.@-]", " ",
                                RegexOptions.None, TimeSpan.FromSeconds(1.5));

            return str.Trim();
        }
    }
}
