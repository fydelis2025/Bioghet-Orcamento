using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioghet_Orcamento.Fiscal
{
    public partial class LMFS : Form
    {
        public LMFS()
        {
            InitializeComponent();
        }

        private void BT_Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                Declaracoes.regAlterarValor_Daruma(@"ECF\LMFCompleta", "0");
                string Str_Parametro_Inicial, Str_Parametro_Final;
                if (RB_Arquivo.Checked.Equals(true))
                {
                    Str_Parametro_Inicial = TB_Parametro_Inicial.Text.Trim().Replace("/", "");
                    Str_Parametro_Final = TB_Parametro_Final.Text.Trim().Replace("/", "");

                    Declaracoes.iRetorno = Declaracoes.iMFLerSerial_ECF_Daruma(Str_Parametro_Inicial, Str_Parametro_Final);
                    Declaracoes.TrataRetorno(Declaracoes.iRetorno);

                }
                else
                {
                    Str_Parametro_Inicial = TB_Parametro_Inicial.Text.Trim().Replace("/", "");
                    Str_Parametro_Final = TB_Parametro_Final.Text.Trim().Replace("/", "");

                    Declaracoes.iRetorno = Declaracoes.iMFLer_ECF_Daruma(Str_Parametro_Inicial, Str_Parametro_Final);
                    Declaracoes.TrataRetorno(Declaracoes.iRetorno);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
