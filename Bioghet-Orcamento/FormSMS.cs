using Bioghet_Orcamento.SMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class FormSMS : Form
    {
        public FormSMS()
        {
            InitializeComponent();
        }


        #region Private Variables
        SerialPort port = new SerialPort();
        Bioghet_SMS objclsSMS = new Bioghet_SMS();
        ShortMessageCollection objShortMessageCollection = new ShortMessageCollection();
        #endregion

        private void WriteStatusBar(string status)
        {
            try
            {
                statusStrip1.Text = "Mensagem: " + status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSMS_Load(object sender, EventArgs e)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();

                foreach (string port in ports)
                {
                    this.CbPorta.Items.Add(port);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtConectar_Click(object sender, EventArgs e)
        {
            try
            {
                this.port = objclsSMS.OpenPort(this.CbPorta.Text, Convert.ToInt32(9600), Convert.ToInt32(8), Convert.ToInt32(300), Convert.ToInt32(300));

                if (this.port != null)
                {
                    this.statusStrip1.Text = "Modem is connected na PORTA " + this.CbPorta.Text;

                    this.statusStrip1.Text = "Connected at " + this.CbPorta.Text;

                    this.BtDesconectar.Enabled = true;
                    BtConectar.Enabled = false;
                    BtEnviar.Enabled = true;
                }

                else
                {
                    this.statusStrip1.Text = "Invalid port settings";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (objclsSMS.sendMsg(this.port, this.TxTelefone.Text, this.TxNotificacao.Text))
                {
                    this.statusStrip1.Text = "Notificação enviada com sucesso";
                }
                else
                {
                    this.statusStrip1.Text = "Erro ao enviar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                objclsSMS.ClosePort(this.port);

                this.statusStrip1.Text = "Não Connectado";
                this.BtDesconectar.Enabled = false;
                BtConectar.Enabled = true;
                BtEnviar.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
