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
using IpPublicKnowledge;
using NITGEN.SDK.NBioBSP;
using MySql.Data.MySqlClient;
using System.Reflection.Emit;
using System.Reflection;
using System.Management;

namespace Bioghet_Orcamento
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();

            int Inicio = Classes.Bioghet_Configuracao.__StrConection.IndexOf("Server");
            Inicio = Inicio + ("Server").Length + 1;

            int FIM = Classes.Bioghet_Configuracao.__StrConection.IndexOf(";", Inicio);
            FIM = FIM - Inicio;

            LbHost.Text = Classes.Bioghet_Configuracao.__StrConection.Substring(Inicio, FIM);
        }

        private Login _logon = null;
        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.EX
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        List<String> Lista = new List<String>();

        private void Form9_Load(object sender, EventArgs e)
        {
            try
            {
                ManagementClass management = new ManagementClass("Win32_Battery");
                var ALLBateria = management.GetInstances();

                foreach(var bateria in ALLBateria)
                {
                    Int32 bateriaestimado = Convert.ToInt32(bateria["EstimatedChargeRemaining"]);

                    if(bateriaestimado.Equals(100))
                    {
                        MessageBox.Show("ATENÇÃO -> A BATERIA DESDE COMPUTADOR ESTA ESGOTADO, FAVOR SUBSTITUA O MAIS RAPIDO POSSÍVEL","ATENÇÃO",MessageBoxButtons.RetryCancel,MessageBoxIcon.Stop);
                    }
                    else if (bateriaestimado.Equals(80))
                    {
                        MessageBox.Show("ATENÇÃO -> A BATERIA DESDE COMPUTADOR ESTA ESGOTADO, FAVOR SUBSTITUA O MAIS RAPIDO POSSÍVEL", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (bateriaestimado.Equals(70))
                    {
                        MessageBox.Show("ATENÇÃO -> A BATERIA DESDE COMPUTADOR ESTA ESGOTADO, FAVOR SUBSTITUA O MAIS RAPIDO POSSÍVEL", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                verificaconexao = Classes.Bioghet_Configuracao.ConectadoInternet(Criptografia.Descripto(Ini.GetIniString(Ini.nomeArquivoINI(), "bancodedados", "bancodedadosonline", "")));
                Classes.Bioghet_Configuracao.Banco = Ini.GetIniString(Ini.nomeArquivoINI(), "bancodedados", "conexao", "");

                if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                {
                    CbFilial.Text = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "empresa", "")));
                }
                else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                {

                    CbFilial.Text = Classes.Bioghet_Consultas.Consultar_RazaoSocial(Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "empresa", "")));
                }
                else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                {
                    CbFilial.Text = Classes.Bioghet_ConsultaSQL.Consultar_RazaoSocial(Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "empresa", "")));
                }
                else
                {
                    throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                }

                TxLogin.Focus();
            }
        }

        private void TxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxSenha.Focus();
            }
        }

        private int desc;
        private Boolean verificaconexao;
        private string status;
        private BioLog _log;
        private int contador;
        private Boolean desconectado;
        private Int32 CodigoFilial__ = Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "EMPRESA", ""));
        internal void Acessar_Sistema(String Usuario, String Senha)
        {
            try
            {
                var ip = IPK.GetMyPublicIp();
                var _ip = IPK.GetIpInfo(ip);

                if (!String.IsNullOrWhiteSpace(Usuario) && (!String.IsNullOrWhiteSpace(Senha)))
                {
                    if (verificaconexao.Equals(false))
                    {
                        if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                        {
                            _logon = Classes.Bioghet_ConsultaMysql.Consultar_Login(Usuario, Criptografia.Encripta(Senha));
                            status = Classes.Bioghet_Configuracao.StatusInternet.OFFILINE.ToString();

                        }
                        else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                        {
                            _logon = Classes.Bioghet_Consultas.Consultar_Login(Usuario, Criptografia.Encripta(Senha));
                            status = Classes.Bioghet_Configuracao.StatusInternet.OFFILINE.ToString();
                        }
                        else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                        {
                            _logon = Classes.Bioghet_ConsultaSQL.Consultar_Login(Usuario, Criptografia.Encripta(Senha));
                            status = Classes.Bioghet_Configuracao.StatusInternet.OFFILINE.ToString();
                        }
                        else
                        {
                            throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                        }

                        if (_logon.Adm.Equals(false))
                        {
                            int retorno = _logon.Filial.CompareTo(CodigoFilial__);

                            if (retorno == 1)
                                throw new Exception("ACESSO NÃO PERMITIDO, USUÁRIO SEM PERMISSÃO PARA LOGAR EM OUTRA FILIAL");
                        }

                        if (_logon != null)

                            desconectado = Classes.Bioghet_ConsultaMysql.Consultar_UsuarioDesconectado(_logon.ID, DateTime.Now);

                        Ini.gravaarquivoini("geral", "internet", "false");

                        _log = new BioLog();
                        _log.Usuario = _logon.ID;
                        _log.Descricao = Classes.Bioghet_Configuracao._logs.USUARIO_LOGADO.ToString();
                        _log.DataCriacao = DateTime.Now;
                        _log.IPLocal = Environment.UserName;
                        if (_ip != null)
                        {
                            _log.IP = _ip.IP.ToString();
                            _log.IPLocal = Environment.UserName;
                            _log.Cidade = _ip.city;
                            _log.UF = _ip.region;
                            _log.Pais = _ip.country;
                            _log.ISP = _ip.isp;
                            _log.Latitude = _ip.lat;
                            _log.Longetude = _ip.lon;
                            _log.Zona = _ip.timezone;
                            _log.AS = _ip.AS;
                            _log.Cep = _ip.zip;
                        }

                        if (desconectado.Equals(false))
                        {
                            String Pc = Environment.UserName;
                            String PCLogado = "";

                            if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                            {
                                PCLogado = Classes.Bioghet_ConsultaMysql.Consultar_UsuarioPC(_logon.ID);
                            }
                            else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                            {
                                PCLogado = Classes.Bioghet_Consultas.Consultar_UsuarioPC(_logon.ID);
                            }
                            else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                            {
                                PCLogado = Classes.Bioghet_ConsultaSQL.Consultar_UsuarioPC(_logon.ID);
                            }
                            else
                            {
                                throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                            }


                            if (Pc != PCLogado && PCLogado != String.Empty)
                            {
                                //DialogResult _pergunta = MessageBox.Show("ESTE USUARIO JA ESTA CONECTADO, PARA LOGAR COM ESTE USUÁRIO FAVOR DESCONECTE-O DO OUTRO COMPUTADOR E TENTE NOVAMENTE ----> " + " CONECTADO  --> " + PCLogado.ToUpper() + " --> DESEJA DESCONECTAR ESTE USUARIO <--", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                //if (_pergunta == DialogResult.Yes)
                                //{
                                //    Classes.Bioghet_Update.DesconectarUsuario(_logon.ID, DateTime.Now);
                                //}
                                //else
                                //{
                                //    return;
                                //}
                            }
                            else
                            {
                                int logado = 0;
                                if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                                {
                                    logado  = Classes.Bioghet_ConsultaMysql.Consultar_UsuarioLogado(_logon.ID);
                                }
                                else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                                {
                                    logado = Classes.Bioghet_Consultas.Consultar_UsuarioLogado(_logon.ID);
                                }
                                else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                                {
                                    logado = Classes.Bioghet_ConsultaSQL.Consultar_UsuarioLogado(_logon.ID);
                                }
                                else
                                {
                                    throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                                }

                                if (logado.Equals(0))
                                {
                                    if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                                    {
                                        Classes.Bioghet_InserirMYSQL.Criar_Log(_log);
                                    }
                                    else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                                    {
                                        Classes.Bioghet_Inserir.Criar_Log(_log);
                                    }
                                    else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                                    {
                                        Classes.Bioghet_InserirSQL.Criar_Log(_log);
                                    }
                                    else
                                    {
                                        throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                                    }
                                    
                                }
                            }
                        }
                    }
                    else
                    {
                        if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                        {
                            Classes.Bioghet_Configuracao.Bloqueado = Classes.Bioghet_ConsultaMysql.Consultar_AcessoBloqueado(Usuario, Criptografia.Encripta(Senha));
                        }
                        else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                        {
                            Classes.Bioghet_Configuracao.Bloqueado = Classes.Bioghet_Consultas.Consultar_AcessoBloqueado(Usuario, Criptografia.Encripta(Senha));
                        }
                        else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                        {
                            Classes.Bioghet_Configuracao.Bloqueado = Classes.Bioghet_ConsultaSQL.Consultar_AcessoBloqueado(Usuario, Criptografia.Encripta(Senha));
                        }
                        else
                        {
                            throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                        }
                        

                        if (Classes.Bioghet_Configuracao.Bloqueado.Equals(false))
                        {

                            if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                            {
                                _logon = Classes.Bioghet_ConsultaMysql.Consultar_Login(Usuario, Criptografia.Encripta(Senha));
                            }
                            else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                            {
                                _logon = Classes.Bioghet_Consultas.Consultar_Login(Usuario, Criptografia.Encripta(Senha));
                            }
                            else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                            {
                                _logon = Classes.Bioghet_ConsultaSQL.Consultar_Login(Usuario, Criptografia.Encripta(Senha));
                            }
                            else
                            {
                                throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                            }

                            if (_logon != null)
                            {
                                if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                                {
                                    desconectado = Classes.Bioghet_ConsultaMysql.Consultar_UsuarioDesconectado(_logon.ID, DateTime.Now);
                                }
                                else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                                {
                                    desconectado = Classes.Bioghet_Consultas.Consultar_UsuarioDesconectado(_logon.ID, DateTime.Now);
                                }
                                else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                                {
                                    desconectado = Classes.Bioghet_ConsultaSQL.Consultar_UsuarioDesconectado(_logon.ID, DateTime.Now);
                                }
                                else
                                {
                                    throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                                }
                            }
                                

                            if (_logon != null)
                            {
                                status = Classes.Bioghet_Configuracao.StatusInternet.ONLINE.ToString();

                                Ini.gravaarquivoini("geral", "internet", "true");

                                _log = new BioLog();
                                _log.Usuario = _logon.ID;
                                _log.Descricao = Classes.Bioghet_Configuracao._logs.USUARIO_LOGADO.ToString();
                                _log.DataCriacao = DateTime.Now;
                                if (_ip != null)
                                {
                                    _log.IP = _ip.IP.ToString();
                                    _log.IPLocal = Environment.UserName;
                                    _log.Cidade = _ip.city;
                                    _log.UF = _ip.region;
                                    _log.Pais = _ip.country;
                                    _log.ISP = _ip.isp;
                                    _log.Latitude = _ip.lat;
                                    _log.Longetude = _ip.lon;
                                    _log.Zona = _ip.timezone;
                                    _log.AS = _ip.AS;
                                    _log.Cep = _ip.zip;

                                    if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                                    {
                                        Classes.Bioghet_Configuracao.retorno = Classes.Bioghet_ConsultaMysql.Consultar_AcessoAtivo(Environment.MachineName, _ip.IP.ToString());
                                    }
                                    else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                                    {
                                        Classes.Bioghet_Configuracao.retorno = Classes.Bioghet_Consultas.Consultar_AcessoAtivo(Environment.MachineName, _ip.IP.ToString());
                                    }
                                    else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                                    {
                                        Classes.Bioghet_Configuracao.retorno = Classes.Bioghet_ConsultaSQL.Consultar_AcessoAtivo(Environment.MachineName, _ip.IP.ToString());
                                    }
                                    else
                                    {
                                        throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                                    }
                                    
                                }

                                if (desconectado.Equals(false))
                                {
                                    String Pc = Environment.UserName;
                                    String PCLogado = "";

                                    if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                                    {
                                        PCLogado = Classes.Bioghet_ConsultaMysql.Consultar_UsuarioPC(_logon.ID);
                                    }
                                    else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                                    {
                                        PCLogado = Classes.Bioghet_Consultas.Consultar_UsuarioPC(_logon.ID);
                                    }
                                    else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                                    {
                                        PCLogado = Classes.Bioghet_ConsultaSQL.Consultar_UsuarioPC(_logon.ID);
                                    }
                                    else
                                    {
                                        throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                                    }

                                    if (Pc != PCLogado && PCLogado != String.Empty)
                                    {
                                        //DialogResult _pergunta = MessageBox.Show("ESTE USUARIO JA ESTA CONECTADO, PARA LOGAR COM ESTE USUÁRIO FAVOR DESCONECTE-O DO OUTRO COMPUTADOR E TENTE NOVAMENTE ----> " + " CONECTADO  --> " + PCLogado.ToUpper() + " --> DESEJA DESCONECTAR ESTE USUARIO <--","AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                                        //if(_pergunta == DialogResult.Yes)
                                        //{
                                        //    Classes.Bioghet_Update.DesconectarUsuario(_logon.ID,DateTime.Now);
                                        //}
                                        //else
                                        //{
                                        //    return;
                                        //}
                                    }
                                    else
                                    {
                                        int logado = 0;
                                        if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                                        {
                                            logado = Classes.Bioghet_ConsultaMysql.Consultar_UsuarioLogado(_logon.ID);
                                        }
                                        else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                                        {
                                            logado = Classes.Bioghet_Consultas.Consultar_UsuarioLogado(_logon.ID);
                                        }
                                        else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                                        {
                                            logado = Classes.Bioghet_ConsultaSQL.Consultar_UsuarioLogado(_logon.ID);
                                        }
                                        else
                                        {
                                            throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                                        }

                                        if (logado.Equals(0))
                                        {
                                            if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                                            {
                                                Classes.Bioghet_InserirMYSQL.Criar_Log(_log);
                                            }
                                            else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                                            {
                                                Classes.Bioghet_Inserir.Criar_Log(_log);
                                            }
                                            else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                                            {
                                                Classes.Bioghet_InserirSQL.Criar_Log(_log);
                                            }
                                            else
                                            {
                                                throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                                            }
                                            
                                        }
                                    }
                                }
                            }
                            else
                            {
                                contador = contador + 1;

                                if (contador >= 4)
                                {
                                    if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                                    {
                                        Classes.Bioghet_UpdateMYSQL.Bloquear_Acessos(TxLogin.Text);
                                    }
                                    else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                                    {
                                        Classes.Bioghet_Update.Bloquear_Acessos(TxLogin.Text);
                                    }
                                    else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                                    {
                                        Classes.Bioghet_UpdateSQL.Bloquear_Acessos(TxLogin.Text);
                                    }
                                    else
                                    {
                                        throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                                    }
                                    

                                    throw new Exception("USUARIO BLOQUEADO, FAVOR ENTRAR EM CONTATO COM O SUPORTE");
                                }

                                if (contador <= 3)
                                {
                                    if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                                    {
                                        Classes.Bioghet_UpdateMYSQL.Atualizar_Acessos(TxLogin.Text, contador);
                                    }
                                    else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                                    {
                                        Classes.Bioghet_Update.Atualizar_Acessos(TxLogin.Text, contador);
                                    }
                                    else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                                    {
                                        Classes.Bioghet_UpdateSQL.Atualizar_Acessos(TxLogin.Text, contador);
                                    }
                                    else
                                    {
                                        throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                                    }
                                    

                                    throw new Exception("LOGIN OU SENHA NÃO CONFERE, FAVOR VERIFIQUE TENTATIVA " + contador);
                                }

                                //throw new Exception("LOGIN OU SENHA NÃO CONFERE, FAVOR VERIFIQUE");
                            }
                        }
                        else
                        {
                            throw new Exception("USUÁRIO BLOQUEADO, FAVOR ENTRAR EM CONTATO COM O SUPORTE");
                        }
                    }

                    if (_logon != null)
                    {
                        if (_logon.Adm.Equals(false))
                        {
                            int retorno = _logon.Filial.CompareTo(CodigoFilial__);

                            if (retorno == 1)
                                throw new Exception("ACESSO NÃO PERMITIDO, USUÁRIO SEM PERMISSÃO PARA LOGAR EM OUTRA FILIAL");
                            
                        }

                        this.Hide();
                        FormMain load = new FormMain();
                        load.LbUser.Text = _logon.Usuario;
                        load.LbStatusInternet.Text = status;
                        load.LbFilial.Text = CbFilial.Text;
                        if (verificaconexao.Equals(false))
                        {
                            load.Pstatus.Image = Bioghet_Orcamento.Properties.Resources.Offline_status;
                        }
                        else
                        {
                            load.Pstatus.Image = Bioghet_Orcamento.Properties.Resources.online;
                        }

                        if (_logon.Adm.Equals(true))
                        {
                            load.LbFuncao.Text = Classes.Bioghet_Configuracao.Login.Administrador.ToString();
                        }
                        else
                        {
                            load.LbFuncao.Text = Classes.Bioghet_Configuracao.Login.Usuario.ToString();
                        }

                        if (Classes.Bioghet_Configuracao.Bloqueado.Equals(false))
                        {
                            load.LbServidor.Text = LbHost.Text;
                            load.ShowDialog();
                        }
                        else
                        {
                            throw new Exception("USUÁRIO BLOQUEADO");
                        }
                    }
                    else
                    {
                        if (_logon.Adm.Equals(false))
                        {
                            int retorno = _logon.Filial.CompareTo(CodigoFilial__);
                            if (retorno == 1)
                                throw new Exception("ACESSO NÃO PERMITIDO, USUÁRIO SEM PERMISSÃO PARA LOGAR EM OUTRA FILIAL");
                        }

                        _log = new BioLog();
                        _log.Usuario = _logon.ID;
                        _log.Descricao = Classes.Bioghet_Configuracao._logs.ERROLOGON.ToString();
                        _log.DataCriacao = DateTime.Now;
                        if (_ip != null)
                        {
                            _log.IP = _ip.IP.ToString();
                            _log.IPLocal = Environment.UserName;
                            _log.Cidade = _ip.city;
                            _log.UF = _ip.region;
                            _log.Pais = _ip.country;
                            _log.ISP = _ip.isp;
                            _log.Latitude = _ip.lat;
                            _log.Longetude = _ip.lon;
                            _log.Zona = _ip.timezone;
                            _log.AS = _ip.AS;
                            _log.Cep = _ip.zip;

                            if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                            {
                                Classes.Bioghet_Configuracao.retorno = Classes.Bioghet_ConsultaMysql.Consultar_AcessoAtivo(Environment.MachineName, _ip.IP.ToString());
                            }
                            else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                            {
                                Classes.Bioghet_Configuracao.retorno = Classes.Bioghet_Consultas.Consultar_AcessoAtivo(Environment.MachineName, _ip.IP.ToString());
                            }
                            else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                            {
                                Classes.Bioghet_Configuracao.retorno = Classes.Bioghet_ConsultaSQL.Consultar_AcessoAtivo(Environment.MachineName, _ip.IP.ToString());
                            }
                            else
                            {
                                throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                            }

                            
                        }

                        if (desconectado.Equals(false))
                        {
                            String Pc = Environment.UserName;
                            String PCLogado = "";
                            if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                            {
                                PCLogado = Classes.Bioghet_ConsultaMysql.Consultar_UsuarioPC(_logon.ID);
                            }
                            else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                            {
                                PCLogado = Classes.Bioghet_Consultas.Consultar_UsuarioPC(_logon.ID);
                            }
                            else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                            {
                                PCLogado = Classes.Bioghet_ConsultaSQL.Consultar_UsuarioPC(_logon.ID);
                            }
                            else
                            {
                                throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                            }

                            if (Pc != PCLogado && PCLogado != String.Empty)
                            {
                                //DialogResult _pergunta = MessageBox.Show("ESTE USUARIO JA ESTA CONECTADO, PARA LOGAR COM ESTE USUÁRIO FAVOR DESCONECTE-O DO OUTRO COMPUTADOR E TENTE NOVAMENTE ----> " + " CONECTADO  --> " + PCLogado.ToUpper() + " --> DESEJA DESCONECTAR ESTE USUARIO <--", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                //if (_pergunta == DialogResult.Yes)
                                //{
                                //    Classes.Bioghet_Update.DesconectarUsuario(_logon.ID, DateTime.Now);
                                //}
                                //else
                                //{
                                //    return;
                                //}
                            }
                            else
                            {
                                int logado = 0;
                                if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                                {
                                    logado = Classes.Bioghet_ConsultaMysql.Consultar_UsuarioLogado(_logon.ID);
                                }
                                else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                                {
                                    logado = Classes.Bioghet_Consultas.Consultar_UsuarioLogado(_logon.ID);
                                }
                                else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                                {
                                    logado = Classes.Bioghet_ConsultaSQL.Consultar_UsuarioLogado(_logon.ID);
                                }
                                else
                                {
                                    throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                                }

                                if (logado.Equals(0))
                                {
                                    if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                                    {
                                        Classes.Bioghet_InserirMYSQL.Criar_Log(_log);
                                    }
                                    else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                                    {
                                        Classes.Bioghet_Inserir.Criar_Log(_log);
                                    }
                                    else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                                    {
                                        Classes.Bioghet_InserirSQL.Criar_Log(_log);
                                    }
                                    else
                                    {
                                        throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                                    }
                                    //Classes.Bioghet_Inserir.Criar_Log(_log);
                                }
                            }
                        }

                        throw new Exception("LOGIN OU SENHA NÃO CONFERE, FAVOR VERIFIQUE");
                    }
                }
                else
                {
                    if (_logon.Adm.Equals(false))
                    {
                        int retorno = _logon.Filial.CompareTo(CodigoFilial__);

                        if (retorno == 1)
                            throw new Exception("ACESSO NÃO PERMITIDO, USUÁRIO SEM PERMISSÃO PARA LOGAR EM OUTRA FILIAL");
                    }

                    _log = new BioLog();
                    _log.Usuario = _logon.ID;
                    _log.Descricao = Classes.Bioghet_Configuracao._logs.ERROLOGON.ToString();
                    _log.DataCriacao = DateTime.Now;
                    if (_ip != null)
                    {
                        _log.IP = _ip.IP.ToString();
                        _log.IPLocal = Environment.UserName;
                        _log.Cidade = _ip.city;
                        _log.UF = _ip.region;
                        _log.Pais = _ip.country;
                        _log.ISP = _ip.isp;
                        _log.Latitude = _ip.lat;
                        _log.Longetude = _ip.lon;
                        _log.Zona = _ip.timezone;
                        _log.AS = _ip.AS;
                        _log.Cep = _ip.zip;

                        if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                        {
                            Classes.Bioghet_Configuracao.retorno = Classes.Bioghet_ConsultaMysql.Consultar_AcessoAtivo(Environment.MachineName, _ip.IP.ToString());
                        }
                        else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                        {
                            Classes.Bioghet_Configuracao.retorno = Classes.Bioghet_Consultas.Consultar_AcessoAtivo(Environment.MachineName, _ip.IP.ToString());
                        }
                        else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                        {
                            Classes.Bioghet_Configuracao.retorno = Classes.Bioghet_ConsultaSQL.Consultar_AcessoAtivo(Environment.MachineName, _ip.IP.ToString());
                        }
                        else
                        {
                            throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                        }
                        
                    }

                    if (desconectado.Equals(false))
                    {
                        String Pc = Environment.UserName;
                        String PCLogado = "";

                        if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                        {
                            PCLogado = Classes.Bioghet_ConsultaMysql.Consultar_UsuarioPC(_logon.ID);
                        }
                        else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                        {
                            PCLogado = Classes.Bioghet_Consultas.Consultar_UsuarioPC(_logon.ID);
                        }
                        else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                        {
                            PCLogado = Classes.Bioghet_ConsultaSQL.Consultar_UsuarioPC(_logon.ID);
                        }
                        else
                        {
                            throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                        }

                        if (Pc != PCLogado && PCLogado != String.Empty)
                        {
                            //DialogResult _pergunta = MessageBox.Show("ESTE USUARIO JA ESTA CONECTADO, PARA LOGAR COM ESTE USUÁRIO FAVOR DESCONECTE-O DO OUTRO COMPUTADOR E TENTE NOVAMENTE ----> " + " CONECTADO  --> " + PCLogado.ToUpper() + " --> DESEJA DESCONECTAR ESTE USUARIO <--", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            //if (_pergunta == DialogResult.Yes)
                            //{
                            //    Classes.Bioghet_Update.DesconectarUsuario(_logon.ID, DateTime.Now);
                            //}
                            //else
                            //{
                            //    return;
                            //}
                        }
                        else
                        {
                            int logado = 0;
                            if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                            {
                                //logado = Classes.Bioghet_ConsultaMysql.Consultar_UsuarioLogado(_logon.ID);
                            }
                            else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                            {
                                logado = Classes.Bioghet_Consultas.Consultar_UsuarioLogado(_logon.ID);
                            }
                            else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                            {
                                logado = Classes.Bioghet_ConsultaSQL.Consultar_UsuarioLogado(_logon.ID);
                            }
                            else
                            {
                                throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                            }

                            if (logado.Equals(0))
                            {
                                if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                                {
                                    Classes.Bioghet_InserirMYSQL.Criar_Log(_log);
                                }
                                else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                                {
                                    Classes.Bioghet_Inserir.Criar_Log(_log);
                                }
                                else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                                {
                                    Classes.Bioghet_InserirSQL.Criar_Log(_log);
                                }
                                else
                                {
                                    throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                                }
                                
                            }
                        }
                    }

                    throw new Exception("LOGIN OU SENHA NÃO CONFERE, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(CbFilial.Text))
                {
                    if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                    {
                        Ini.gravaarquivoini("geral", "empresa", Classes.Bioghet_ConsultaMysql.Consultar_CodigoFilial(CbFilial.Text).ToString());
                        Acessar_Sistema(TxLogin.Text, TxSenha.Text);
                    }
                    else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                    {
                        Ini.gravaarquivoini("geral", "empresa", Classes.Bioghet_Consultas.Consultar_CodigoFilial(CbFilial.Text).ToString());
                        Acessar_Sistema(TxLogin.Text, TxSenha.Text);
                    }
                    else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                    {
                        Ini.gravaarquivoini("geral", "empresa", Classes.Bioghet_ConsultaSQL.Consultar_CodigoFilial(CbFilial.Text).ToString());
                        Acessar_Sistema(TxLogin.Text, TxSenha.Text);
                    }
                    else
                    {
                        throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                    }
                    
                }
                else
                {
                    throw new Exception("FAVOR INFORMAR A FILIAL DE ACESSO");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!String.IsNullOrWhiteSpace(CbFilial.Text))
                    {
                        if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                        {
                            Ini.gravaarquivoini("geral", "empresa", Classes.Bioghet_ConsultaMysql.Consultar_CodigoFilial(CbFilial.Text).ToString());
                            Acessar_Sistema(TxLogin.Text, TxSenha.Text);
                        }
                        else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                        {
                            Ini.gravaarquivoini("geral", "empresa", Classes.Bioghet_Consultas.Consultar_CodigoFilial(CbFilial.Text).ToString());
                            Acessar_Sistema(TxLogin.Text, TxSenha.Text);
                        }
                        else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                        {
                            Ini.gravaarquivoini("geral", "empresa", Classes.Bioghet_ConsultaSQL.Consultar_CodigoFilial(CbFilial.Text).ToString());
                            Acessar_Sistema(TxLogin.Text, TxSenha.Text);
                        }
                        else
                        {
                            throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                        }

                    }
                    else
                    {
                        throw new Exception("FAVOR INFORMAR A FILIAL DE ACESSO");
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbFilial_Click(object sender, EventArgs e)
        {
            try
            {
                verificaconexao = Boolean.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "internet", ""));

                if (Classes.Bioghet_Configuracao.Banco.Equals("MYSQL"))
                {
                    Lista = Classes.Bioghet_ConsultaMysql.Visualizar_Filiais();
                }
                else if (Classes.Bioghet_Configuracao.Banco.Equals("POSTEGRESQL"))
                {
                    Lista = Classes.Bioghet_Consultas.Visualizar_Filiais();
                }
                else if (Classes.Bioghet_Configuracao.Banco.Equals("SQLSERVER"))
                {
                    Lista = Classes.Bioghet_ConsultaSQL.Visualizar_Filiais();
                }
                else
                {
                    throw new Exception("BANCO DE DADOS INFORMADO NÃO CADASTRADO");
                }

                

                CbFilial.Items.Clear();
                for (int i = 0; i < Lista.Count; i++)
                {
                    CbFilial.Items.Add(Lista[i].ToString());
                }

                CbFilial.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private NBioAPI _scan;
        private Boolean result = true;
        private uint _ret;
        //private NBioAPI.Type.HFIR HFIR;
        private NBioAPI.Type.WINDOW_OPTION _Opcao;
        private String _ForeRGB, _BkRGB;
        private void PictureBox2_Click(object sender, EventArgs e)
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
                    _Opcao.FingerWnd = pictureBox2.Handle;
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

                byte[] foto = ConverterImage(pictureBox2.Image);

                _logon = Classes.Bioghet_Consultas.Consultar_LoginBiometria(foto);

                if(_logon != null)
                {
                    TxLogin.Text = _logon.Usuario;
                    TxSenha.Text = _logon.Senha;

                    button1.PerformClick();
                }
            }
            catch (Exception ex)
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

        private void Form9_Shown(object sender, EventArgs e)
        {
            try
            {
                AssemblyName assemblyName = typeof(String).Assembly.GetName();

                String Arquivo = Classes.Bioghet_ChecaAtualizacao.ListarArquivosDownload();

                if (!String.IsNullOrWhiteSpace(Arquivo))
                {
                    String NomePc = Environment.MachineName;
                    String UsuarioPC = Environment.UserName;
                    String MACPC = Classes.Bioghet_Configuracao.GetEnderecoMAC();

                    Boolean _arqbaixado = Classes.Bioghet_ConsultaMysql.Checar_ArquivoBaixado(NomePc, UsuarioPC, MACPC);

                    if (_arqbaixado.Equals(false))
                    {
                        DialogResult Pergunta = MessageBox.Show("EXISTE UMA ATUALIZAÇÃO DO SISTEMA DISPONÍVEL", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (Pergunta == DialogResult.Yes)
                        {

                            if (System.IO.File.Exists(Environment.CurrentDirectory + "\\Atualizacao\\Bioghet-Orcamento.rar"))
                                System.IO.File.Delete(Environment.CurrentDirectory + "\\Atualizacao\\Bioghet-Orcamento.rar");

                            Classes.Bioghet_ChecaAtualizacao.DownloadArquivo();

                            int retorno = Classes.Bioghet_UpdateMYSQL.Aplicar_VersaoBaixado(NomePc, UsuarioPC, MACPC);


                            //Classes.Bioghet_Versao _Versao = new Classes.Bioghet_Versao();
                            //_Versao.DataVersao = DateTime.Now;
                            //_Versao.VersaoAPP = assemblyName.Version.Major;
                            //_Versao.Ativo = true;

                            //Classes.Bioghet_InserirMYSQL.Criar_Versao(_Versao);
                        }

                        MessageBox.Show("TODOS OS ARQUIVOS FORAM BAIXADOS COM EXITO, FAVOR VERIFICAR OS ARQUIVOS NA PASTA " + Environment.CurrentDirectory + "\\Atualizacao\\Bioghet-Orcamento.rar", "FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    // String Status = Classes.Bioghet_ChecaAtualizacao.DeletarArquivosDownload();

                }
                
                                        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
