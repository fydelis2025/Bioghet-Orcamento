using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.ServiceProcess;
using System.Security.Permissions;
using System.Security;
using Microsoft.VisualBasic;

namespace Bioghet_Orcamento
{
    public partial class FrmBKP : Form
    {
        public FrmBKP()
        {
            try
            {
                InitializeComponent();

                int Inicio = Classes.Bioghet_Configuracao.__StrConection.IndexOf("Server");
                Inicio = Inicio + ("Server").Length + 1;

                int FIM = Classes.Bioghet_Configuracao.__StrConection.IndexOf(";", Inicio);
                FIM = FIM - Inicio;

                Classes.Bioghet_Configuracao.__STR__ = Classes.Bioghet_Configuracao.__StrConection.Substring(Inicio, FIM);

                Inicio = Classes.Bioghet_Configuracao.__StrConection.IndexOf("Port");
                Inicio = Inicio + ("Port").Length + 1;
                FIM = Classes.Bioghet_Configuracao.__StrConection.IndexOf(";", Inicio);
                FIM = FIM - Inicio;

                Classes.Bioghet_Configuracao.__Porta = Classes.Bioghet_Configuracao.__StrConection.Substring(Inicio, FIM);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBKP_Load(object sender, EventArgs e)
        {
            try
            {
                if (Classes.Bioghet_Configuracao.__ExecutePath.Length == 0)
                {
                    bool bPostgresService = false;
                    ServiceController[] services = ServiceController.GetServices();
                    
                    foreach (ServiceController service in services)
                    {
                        if (service.ServiceName.Contains("postgre") == true)
                        {
                            bPostgresService = true;
                            break;
                        }
                    }
                    if (bPostgresService == true)
                    {
                        ExecutePostGresql();
                        //objProcess.Kill();
                        if (Classes.Bioghet_Configuracao.__ExecutePath.Length != 0)
                        {
                            //MessageBox.Show("PostgreSql está Instalado");
                            labelLocation.Text = "Local da instalação " + Classes.Bioghet_Configuracao.__LocalIntalacao;
                            labelLocation.Visible = true;
                            //btnCheckPostgres.BackColor = Color.Green;
                            //panel1.Enabled = true;

                            CbBanco.Items.Clear();
                            CbBanco.Text = string.Empty;
                            DataSet __banco = new DataSet();
                            Classes.Bioghet_Configuracao.__Porta = txtPort.Text;

                            __banco = __Get("SELECT datname FROM pg_database WHERE datistemplate IS FALSE AND datallowconn IS TRUE AND datname!='postgres';");
                            if (__banco != null)
                            {
                                if (__banco.Tables[0].Rows.Count > 0)
                                {
                                    for (int i = 0; i < __banco.Tables[0].Rows.Count; i++)
                                    {
                                        CbBanco.Items.Add(__banco.Tables[0].Rows[i][0].ToString());
                                    }
                                    CbBanco.SelectedIndex = 0;

                                    butSelectLoc.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("Nenhum banco de dados");
                                }
                            }
                        }
                    }
                    else
                    {
                        //objProcess.Kill();
                        MessageBox.Show("Banco de dados PostgreSQL Não está instalado no seu sistema operacional, favor instalar");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        internal void ExecutePostGresql()
        {
            try
            {
                if (Classes.Bioghet_Configuracao.__ExecutePath.Length == 0)
                {
                    if (Classes.Bioghet_Configuracao.__CaracterPath == String.Empty)
                    {
                        Classes.Bioghet_Configuracao.__CaracterPath = __LocalizarArquivo("pg_dump.exe");
                        if (Classes.Bioghet_Configuracao.__CaracterPath == String.Empty)
                        {
                            MessageBox.Show("PostgreSql não instalado");
                        }
                    }

                    int a = Classes.Bioghet_Configuracao.__CaracterPath.IndexOf(":\\", 0);
                    a = a + 2;
                    string strSub = Classes.Bioghet_Configuracao.__CaracterPath.Substring(0, (a - 2));
                    Classes.Bioghet_Configuracao.__CaracterPath = Classes.Bioghet_Configuracao.__CaracterPath.Substring(a, (Classes.Bioghet_Configuracao.__CaracterPath.Length - a));

                    StringBuilder __B1__ = new StringBuilder(Classes.Bioghet_Configuracao.__CaracterPath);
                    __B1__.Replace("\\", "\r\n\r\ncd ");

                    StringBuilder __B2__ = new StringBuilder("cd /D ");
                    __B2__.Append(strSub);
                    __B2__.Append(":\\");

                    __B1__ = __B2__.Append(__B1__);
                    __B1__ = __B2__.Remove((__B1__.Length - 3), 3);
                    Classes.Bioghet_Configuracao.__ExecutePath = __B1__;
                    Classes.Bioghet_Configuracao.__CaracterPath = __B1__.ToString();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        internal String __LocalizarArquivo(String __NomeArquivo)
        {
            String __StrPath = String.Empty;
            try
            {
                DriveInfo[] __drives__ = DriveInfo.GetDrives();

                foreach (DriveInfo drive in __drives__)
                {
                    __StrPath = __LocalizarTarefa__(drive.Name, __NomeArquivo);
                    if (__StrPath.Length != 0)
                        break;
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            return __StrPath;
        }

        private string __LocalizarTarefa__(String __Diretorio, String NomeArquivo__)
        {
            try
            {
                if (Classes.Bioghet_Configuracao.__CaracterPath.Length == 0)
                {
                    try
                    {
                        foreach (String Diretorio in Directory.GetDirectories(__Diretorio))
                        {
                            FileIOPermission __LerPermissao__ = new FileIOPermission(FileIOPermissionAccess.Write, Diretorio);
                            if (SecurityManager.IsGranted(__LerPermissao__))
                            {
                                try
                                {
                                    foreach (string __Arquivo in Directory.GetFiles(Diretorio, NomeArquivo__))
                                    {
                                        Classes.Bioghet_Configuracao.__CaracterPath = Diretorio + "\\";
                                        if (Classes.Bioghet_Configuracao.__CaracterPath.Length > 0)
                                        {
                                            Classes.Bioghet_Configuracao.__LocalIntalacao = Classes.Bioghet_Configuracao.__CaracterPath;
                                            break;
                                        }
                                    }
                                    if (Classes.Bioghet_Configuracao.__CaracterPath.Length == 0)
                                        __LocalizarTarefa__(Diretorio, NomeArquivo__);
                                }
                                catch (Exception ex)
                                {  }
                            }
                            if (Classes.Bioghet_Configuracao.__CaracterPath != String.Empty)
                                break;
                        }
                    }
                    catch (Exception ex)
                    {  }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return Classes.Bioghet_Configuracao.__CaracterPath;
        }

        public DataSet __Get(String __Consulta)
        {
            DataSet objDataSet = new DataSet();
            try
            {

                Classes.Bioghet_Configuracao.m_NpgsqlConnection = new NpgsqlConnection(Classes.Bioghet_Configuracao.__StrConection);
                

                NpgsqlDataAdapter objSqlAdapter = new NpgsqlDataAdapter(__Consulta, Classes.Bioghet_Configuracao.m_NpgsqlConnection);
                objSqlAdapter.Fill(objDataSet);
                return objDataSet;
            }
            catch (Exception Ex)
            {
                objDataSet = null;
                return objDataSet;
            }
        }
        private void BtListar_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void butSelectLoc_Click(object sender, EventArgs e)
        {
            try
            {
                CbBanco.Text = string.Empty;
                BtInicio.Enabled = false;
                SaveFileDialog SalvarArquivo__ = new SaveFileDialog();
                SalvarArquivo__.Title = "LOCAL DO ARQUIVO BACKUP";
                SalvarArquivo__.Filter = "Backup ARQUIVO|*.backup";
                SalvarArquivo__.FilterIndex = 0;
                SalvarArquivo__.RestoreDirectory = true;
                string NomedoArquivo = Classes.Bioghet_Configuracao.__DatabaseName + "_" + System.DateTime.Now.ToString("ddMMyyyy_HHmm");
                SalvarArquivo__.FileName = NomedoArquivo;

                if (SalvarArquivo__.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = SalvarArquivo__.FileName;
                    BtInicio.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtInicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "-------")
                {
                    MessageBox.Show("Selecione o local do arquivo para salvar");
                    return;
                }
                StreamWriter __Bkp = new StreamWriter("Bioghet_BK.bat");
                StringBuilder __Bkp__ = new StringBuilder(Classes.Bioghet_Configuracao.__CaracterPath);

                if (__Bkp__.Length != 0)
                {
                    __Bkp__.Append("pg_dump.exe --host " + Classes.Bioghet_Configuracao.__STR__ + " --port " + Classes.Bioghet_Configuracao.__Porta + " --username bioghet_carlito --format custom --blobs --verbose --file ");
                    __Bkp__.Append("\"" + textBox1.Text + "\"");
                    __Bkp__.Append(" \"" + Classes.Bioghet_Configuracao.__DatabaseName + "\r\n\r\n");
                    __Bkp.WriteLine(__Bkp__);
                    __Bkp.Dispose();
                    __Bkp.Close();
                    Process processDB = Process.Start("Bioghet_BK.bat");
                    do
                    {
                    }
                    while (!processDB.HasExited);
                    {
                        MessageBox.Show(Classes.Bioghet_Configuracao.__DatabaseName + " Backup gerado com sucesso " + textBox1.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, forneça o local para fazer o backup!");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void butBackupFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                txtBackupFilePath.Text = String.Empty;
                BtRestaurar.Enabled = false;
                OpenFileDialog __AbrirArquivo = new OpenFileDialog();
                __AbrirArquivo.Title = "Selecione o local do Backup";
                __AbrirArquivo.Filter = "backup|*.backup";
                __AbrirArquivo.RestoreDirectory = true;
                if (__AbrirArquivo.ShowDialog() == DialogResult.OK)
                {
                    txtBackupFilePath.Text = __AbrirArquivo.FileName;
                    BtRestaurar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ChecarBanco(String __DataBase)
        {
            try
            {
                string DBlist = "SELECT datname FROM pg_database WHERE datistemplate IS FALSE AND datallowconn IS TRUE AND datname!='postgres';";
                DataSet __DB = new DataSet();
                __DB = __Get(DBlist);
                bool Existe = false;
                for (int i = 0; i < __DB.Tables[0].Rows.Count; i++)
                {
                    if (__DB.Tables[0].Rows[i][0].ToString() == __DataBase)
                    {
                        Existe = true;
                        break;
                    }
                }
                if (Existe)
                {
                    string str = "select pg_terminate_backend(procpid) from pg_stat_activity where datname='" + __DataBase + "'";
                    ExecuteQuery(str);
                    string str1 = "drop database \"" + __DataBase + "\" ";
                    ExecuteQuery(str1);

                    string str2 = "create database \"" + __DataBase + "\" ";
                    ExecuteQuery(str2);

                    return true;
                }
                else
                {
                    string str = "create database \"" + __DataBase + "\" ";
                    ExecuteQuery(str);
                    Thread.Sleep(1000);
                    return true;
                }

                //return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal bool ExecuteQuery(String __Consulta)
        {
            bool bstatus = false;
            try
            {
                NpgsqlConnection m_NpgsqlConnection = new NpgsqlConnection(Classes.Bioghet_Configuracao.__StrConection);
                int __ReturnValue = 0;

                try
                {
                    if (m_NpgsqlConnection.State != ConnectionState.Open)
                        m_NpgsqlConnection.Open();
                    if (m_NpgsqlConnection.State == ConnectionState.Open)
                    {
                        NpgsqlCommand objSqlCommand = new NpgsqlCommand(__Consulta, m_NpgsqlConnection);

                        __ReturnValue = objSqlCommand.ExecuteNonQuery();
                        if (__ReturnValue == -1)
                            bstatus = false;
                        else
                            bstatus = true;
                    }
                    if (m_NpgsqlConnection.State == ConnectionState.Open)
                        m_NpgsqlConnection.Close();

                    if (m_NpgsqlConnection != null)
                        m_NpgsqlConnection.Dispose();
                }
                catch (Exception ex)
                {
                    bstatus = false;

                    if (m_NpgsqlConnection.State == ConnectionState.Open)
                        m_NpgsqlConnection.Close();

                    if (m_NpgsqlConnection != null)
                        m_NpgsqlConnection.Dispose();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return bstatus;

        }

        private void BtRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBackupFilePath.Text == string.Empty)
                {
                    MessageBox.Show("Select backup file");
                    return;
                }
                
                if (Classes.Bioghet_Configuracao.__DatabaseName != "")
                {
                    if (txtBackupFilePath.Text != "")
                    {
                        StreamWriter __DB = new StreamWriter("DBRestore.bat");
                        
                        StringBuilder DB__ = new StringBuilder(Classes.Bioghet_Configuracao.__CaracterPath);
                        if (DB__.Length != 0)
                        {
                            ChecarBanco(Classes.Bioghet_Configuracao.__DatabaseName);
                            DB__.Append("pg_restore.exe --host " + Classes.Bioghet_Configuracao.__STR__ + " --port " + Classes.Bioghet_Configuracao.__Porta + " --username bioghet_carlito --dbname");
                            DB__.Append(" \"" + Classes.Bioghet_Configuracao.__DatabaseName + "\"");
                            DB__.Append(" --verbose ");
                            DB__.Append("\"" + txtBackupFilePath.Text + "\"");
                            __DB.WriteLine(DB__);
                            __DB.Dispose();
                            __DB.Close();
                            Process processDB = Process.Start("Bioghet_Restaurar.bat");
                            do
                            {//dont perform anything
                            }
                            while (!processDB.HasExited);
                            {
                                MessageBox.Show("Arquivo restaurado com sucesso " + Classes.Bioghet_Configuracao.__DatabaseName + " Database from " + txtBackupFilePath.Text);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, digite o caminho para salvar o backup!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, digite o nome do banco de dados para restaurar!");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCheckPostgres_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CbBanco_SelectedValueChanged(object sender, EventArgs e)
        {
            Classes.Bioghet_Configuracao.__DatabaseName = CbBanco.Text;
        }

        private void FrmBKP_Shown(object sender, EventArgs e)
        {
            try
            {
                //String Senha = Interaction.InputBox("DIGITE A PALAVRA CHAVE PARA ACESSAR AS CONFIGURAÇÕES DO SISTEMA", "ACESSO RESTRITO", "*", 200, 200);

                //if (!String.IsNullOrWhiteSpace(Senha))
                //{
                //    if (Senha != Classes.BioCriptografia.Descripto(Ini.GetIniString(Ini.nomeArquivoINI(), "hash", "hash", "")))
                //    {
                //        this.Close();
                //    }
                //    else
                //    {
                //        panel1.Visible = true;
                //    }
                //}
                //else
                //{
                //    this.Close();
                //}
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
        private void FrmBKP_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void FrmBKP_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void FrmBKP_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }
    }
}
