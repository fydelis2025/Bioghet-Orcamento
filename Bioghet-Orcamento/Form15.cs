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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void BtLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DgBuscar.Rows.Clear();
                List<bioghet_produto> _produto = Classes.Bioghet_ConsultaMysql.Listar_ProdutoLojaDigito(TxDescricao.Text, int.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "EMPRESA", "")));
                String[] Param = new String[2];

                for (int i = 0; i < _produto.Count; i++)
                {
                    //Param[0] = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(_produto[i].Filial);
                    Param[0] = _produto[i].CodigoInterno;
                    Param[1] = _produto[i].Descricao;

                    DgBuscar.Rows.Add(Param);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DgBuscar.Rows.Clear();
                    List<bioghet_produto> _produto = Classes.Bioghet_ConsultaMysql.Listar_ProdutoLojaDigito(TxDescricao.Text, int.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "EMPRESA", "")));
                    String[] Param = new String[2];

                    for (int i = 0; i < _produto.Count; i++)
                    {
                        //Param[0] = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(_produto[i].Filial);
                        Param[0] = _produto[i].CodigoInterno;
                        Param[1] = _produto[i].Descricao;

                        DgBuscar.Rows.Add(Param);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex.Equals(2))
                {
                    Classes.Bioghet_Configuracao.CodigoProduto = DgBuscar.CurrentRow.Cells[0].Value.ToString();
                    Classes.Bioghet_Configuracao.DescricaoProduto = DgBuscar.CurrentRow.Cells[1].Value.ToString();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
