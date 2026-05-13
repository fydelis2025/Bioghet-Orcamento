using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class FrmAviso : Form
    {
        public FrmAviso()
        {
            InitializeComponent();
        }

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool mouseClicked;
        Point clickedAt;

        private void FrmAviso_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void FrmAviso_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void FrmAviso_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrWhiteSpace(TxDigita.Text))
                {
                    if (Classes.Bioghet_Configuracao.bioghet.Equals(true))
                    {
                        Classes.Bioghet_Configuracao.campo = TxDigita.Text;

                        Classes.Bioghet_Update.Atualizar_Status(Classes.Bioghet_Configuracao.Status.IMPRESSO.ToString(), Classes.Bioghet_Configuracao.campo);

                        this.Hide();

                        Form2 frm = new Form2();

                        frm.ShowDialog();
                    }
                    else if (Classes.Bioghet_Configuracao.telecentro.Equals(true))
                    {
                        Classes.Bioghet_Configuracao.campo = TxDigita.Text;

                        Classes.Bioghet_Update.Atualizar_Status(Classes.Bioghet_Configuracao.Status.IMPRESSO.ToString(), Classes.Bioghet_Configuracao.campo);

                        this.Hide();

                        Telecentro_Orcamento frm = new Telecentro_Orcamento();

                        frm.ShowDialog();

                    }
                    else if (Classes.Bioghet_Configuracao.senhaconfiguracao.Equals(true))
                    {
                        if (!String.IsNullOrWhiteSpace(TxDigita.Text))
                        {
                            if (TxDigita.Text != Classes.BioCriptografia.Descripto(Ini.GetIniString(Ini.nomeArquivoINI(), "hash", "hash", "")))
                            {
                                throw new Exception("SENHA INVÁLIDA");
                            }
                            else
                            {
                                Classes.Bioghet_Configuracao.LiberarConfiguracao = true;

                                this.Close();
                            }
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else if (Classes.Bioghet_Configuracao.venda.Equals(true))
                    {
                        Classes.Bioghet_Configuracao.Quantidade = int.Parse(TxDigita.Text);
                        this.Close();
                    }
                    else if (Classes.Bioghet_Configuracao.vendaBazar.Equals(true))
                    {
                        Classes.Bioghet_Configuracao.Quantidade = int.Parse(TxDigita.Text);
                        this.Close();
                    }
                    else
                    {

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
