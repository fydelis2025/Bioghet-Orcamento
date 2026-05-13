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
    public partial class FormConsultaArmazenamento : Form
    {
        public FormConsultaArmazenamento()
        {
            InitializeComponent();
        }

        private void FormConsultaArmazenamento_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgArmazenamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex.Equals(8))
                {
                    DialogResult pergunta = MessageBox.Show("DESEJA REALMENTE EXCLUIR O ARMAZENAMENTO " + DgArmazenamento.CurrentRow.Cells[0].Value.ToString(), "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(pergunta == DialogResult.Yes)
                    {
                       int retorno = Classes.Bioghet_ExcluirMYSQL.Excluir_Armazenamento(DgArmazenamento.CurrentRow.Cells[0].Value.ToString(), Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "empresa", "")),int.Parse(DgArmazenamento.CurrentRow.Cells[7].Value.ToString()));

                        if (retorno.Equals(1))
                        {
                            DgArmazenamento.Rows.Remove(DgArmazenamento.Rows[e.RowIndex]);

                            throw new Exception("PRODUTO EXTORNADO COM SUCESSO");
                        }
                        else
                        {
                            throw new Exception("ERRO AO EXTORNAR O PRODUTO");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
