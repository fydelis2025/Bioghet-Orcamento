using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class FrmConfiguracao : Form
    {
        public FrmConfiguracao()
        {
            InitializeComponent();
        }

        private void FrmConfiguracao_Load(object sender, EventArgs e)
        {
            try
            {
                //Classes.Bioghet_Configuracao.senhaconfiguracao = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PropertyConfig_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            try
            {
                if (e.ChangedItem.Label.Equals("INTERNET"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("GERAL", "INTERNET", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("ACESSO"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("GERAL", "ACESSO", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("VIDEO"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("GERAL", "caminhovideo", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("FOTO"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("GERAL", "caminhofoto", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("FILIAL"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("GERAL", "EMPRESA", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("DBONLINE"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("bancodedados", "bancodedadosonline", Classes.BioCriptografia.Encripta(e.ChangedItem.Value.ToString()));
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("CONEXAO ON"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("bancodedados", "conexaoonline", Classes.BioCriptografia.Encripta(e.ChangedItem.Value.ToString()));
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("DBLOCAL"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("bancodedados", "bancodedadoslocal", Classes.BioCriptografia.Encripta(e.ChangedItem.Value.ToString()));
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("Conexao LOCAL"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("bancodedados", "conexaolocal", Classes.BioCriptografia.Encripta(e.ChangedItem.Value.ToString()));
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("MYSQL"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("bancodedados", "conexaomysql", Classes.BioCriptografia.Encripta(e.ChangedItem.Value.ToString()));
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("BANCO"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("bancodedados", "conexao", Classes.BioCriptografia.Encripta(e.ChangedItem.Value.ToString()));
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("MARCA"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("print", "marca", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("MODELO"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("print", "modelo", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("TIPO"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("print", "tipo", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("NAS1"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("share", "nas1", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("PORTA"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("share", "portacomunicacao1", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("ATIVO"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("share", "nas1ativo", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("NAS2"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("share", "nas2", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("PORTA2"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("share", "portacomunicacao2", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("ATIVO2"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("share", "nas2ativo", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("IPSERVIDOR"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("share", "servidor", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("SOMENTE LEITURA"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("share", "somenteleitura", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("CAMINHO IMPRESSORA"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("share", "caminhoimpressora", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }

                if (e.ChangedItem.Label.Equals("CORES"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("padraosistema", "backgroundcolor", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }

                if (e.ChangedItem.Label.Equals("FONTE"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("padraosystem", "fonte", e.ChangedItem.Value.ToString());
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }

                if (e.ChangedItem.Label.Equals("ID"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("mercadopago", "ID", Classes.BioCriptografia.Encripta(e.ChangedItem.Value.ToString()));
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("ClientID"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("mercadopago", "ClientID", Classes.BioCriptografia.Encripta(e.ChangedItem.Value.ToString()));
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("TOKEN"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("mercadopago", "TOKEN", Classes.BioCriptografia.Encripta(e.ChangedItem.Value.ToString()));
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
                if (e.ChangedItem.Label.Equals("CLIENTSECRET"))
                {
                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE ALTERAR A CONFIGURAÇÃO " + e.ChangedItem.Value.ToString(), "ALTERAR CONFIGURAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_pergunta == DialogResult.Yes)
                    {
                        Ini.gravaarquivoini("mercadopago", "CLIENTSECRET", Classes.BioCriptografia.Encripta(e.ChangedItem.Value.ToString()));
                        MessageBox.Show("CONFIGURAÇÃO ATUALIZADA COM SUCESSO");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmConfiguracao_Shown(object sender, EventArgs e)
        {
            try
            {
                FrmAviso _aviso = new FrmAviso();
                _aviso.LbAviso.Text = "DIGITE A PALAVRA CHAVE PARA ACESSAR AS CONFIGURAÇÕES DO SISTEMA";
                _aviso.TxDigita.UseSystemPasswordChar = true;

                _aviso.ShowDialog();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmConfiguracao_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FrmConfiguracao_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Boolean __Configuracao__ = Boolean.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "configuracao", ""));

                if (__Configuracao__ == true)
                {
                    Ini.gravaarquivoini("geral", "configuracao", "false");

                    Application.Restart();
                }
                else
                {
                    Ini.gravaarquivoini("geral", "configuracao", "false");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool mouseClicked;
        Point clickedAt;
        private void FrmConfiguracao_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void FrmConfiguracao_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void FrmConfiguracao_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void FrmConfiguracao_Activated(object sender, EventArgs e)
        {
            try
            {
                if (Classes.Bioghet_Configuracao.LiberarConfiguracao.Equals(true))
                {

                    Classes.Bioghet_PropertGrid _propert = new Classes.Bioghet_PropertGrid();

                    PropertyConfig.SelectedObject = _propert;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
