using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class FrmAjuda : Form
    {
        public FrmAjuda()
        {
            InitializeComponent();
        }

        private void FrmAjuda_Load(object sender, EventArgs e)
        {
            try
            {

                FileInfo info = new FileInfo(Environment.CurrentDirectory + "\\" + "Bioghet-Orcamento.exe");
                DateTime dt = info.LastWriteTime;

                LbAtualizacao.Text = dt.ToString();
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
        private void FrmAjuda_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void FrmAjuda_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void FrmAjuda_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void BtAtualizar_Click(object sender, EventArgs e)
        {
            try
            {

                String Arquivo = Classes.Bioghet_ChecaAtualizacao.ListarArquivosDownload();

                if (!String.IsNullOrWhiteSpace(Arquivo))
                {
                    DirectorySecurity _DcSecurity = new DirectorySecurity();

                    string UserName = Environment.UserName;

                    _DcSecurity.AddAccessRule(new FileSystemAccessRule(UserName, FileSystemRights.Modify, AccessControlType.Allow));

                    String Caminho = Environment.CurrentDirectory + "\\Atualizacao";

                    //if (!Directory.Exists(Caminho));
                    //{
                    //    Directory.CreateDirectory(Environment.CurrentDirectory + "\\Atualizacao", _DcSecurity);
                    //}

                    Classes.Bioghet_ChecaAtualizacao.DownloadArquivo();

                    Classes.Bioghet_ChecaAtualizacao.DeletarArquivosDownload();

                }
                //if (System.IO.File.Exists(Environment.CurrentDirectory + "\\Atualizacao\\Bioghet-Orcamento.rar"))
                //{
                //    File.Copy(Environment.CurrentDirectory + "\\Atualizacao\\Bioghet-Orcamento.rar", Environment.CurrentDirectory + "\\Bioghet-OrcamentoNew.rar");
                //    //System.IO.File.Delete(Environment.CurrentDirectory + "\\Atualizacao\\Bioghet-Orcamento.exe");

                //    MessageBox.Show("ATUALIZAÇÃO REALIZADA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                //}

                //if (File.Exists(Environment.CurrentDirectory + "\\Bioghet-OrcamentoNew.rar"))
                //{
                //    throw new Exception("Existe uma atualização do software, favor verifique");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
