using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class FrmConsultaURL : Form
    {
        public FrmConsultaURL()
        {
            InitializeComponent();
        }

        private void CbReferencia_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DgConsulta.Rows.Clear();
                List<Classes.Bioghet_URL> _listar = Classes.Bioghet_ConsultaMysql.Listar_BioghetURL(CbReferencia.Text);

                string[] param = new string[1];

                for (int i = 0; i < _listar.Count; i++)
                {
                    param[0] = _listar[i].URL;
                    //param[1] = _listar[i].Referencia;
                    //param[2] = _listar[i].Tipo;
                    //param[3] = _listar[i].Marca;
                    //param[4] = _listar[i].Status;
                    //param[5] = _listar[i].Testado.ToString();

                    DgConsulta.Rows.Add(param);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(0))
                {
                    Process.Start(DgConsulta.CurrentRow.Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
