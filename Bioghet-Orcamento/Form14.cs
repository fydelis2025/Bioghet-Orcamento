using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Form13 _bazar = new Form13();
            _bazar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao.RptRBS = false;

                if (RdTudo.Checked.Equals(true))
                {
                    DgConsulta.Rows.Clear();
                    List<Classes.Bioghet_Bazar> Listar = Classes.Bioghet_ConsultaMysql.Listar_Bazar();

                    String[] Param = new String[18];

                    for(int i = 0; i < Listar.Count; i++)
                    {
                        Param[0] = Listar[i].Tipo;
                        Param[1] = Listar[i].Marca;
                        Param[2] = Listar[i].Modelo;
                        Param[3] = Listar[i].Descricao;
                        Param[4] = Listar[i].PartNumber;
                        Param[5] = Listar[i].Serie;
                        Param[6] = Listar[i].Status;
                        Param[7] = Listar[i].Valor.ToString("#####0.00");
                        Param[8] = Listar[i].Prateleira.ToString();
                        Param[9] = Listar[i].Caixa.ToString();
                        Param[10] = Listar[i].Compartimento.ToString();
                        Param[11] = Listar[i].Quantidade.ToString();
                        Param[12] = Listar[i].Pavimento;
                        Param[13] = Listar[i].Sala;
                        Param[14] = Listar[i].OBS;
                        Param[15] = Listar[i].CodigoPeca;
                        Param[16] = Listar[i].Data.ToString("dd-MM-yyyy");
                        Param[17] = Listar[i].TV.ToString();
                        /*Param[18] = Listar[i].Tensao;
                        Param[19] = Listar[i].QtdeLede.ToString();
                        Param[20] = Listar[i].VLed;
                        Param[21] = Listar[i].WLed;
                        Param[22] = Listar[i].QtdeBarra.ToString();
                        Param[23] = Listar[i].TBarra;
                        Param[24] = Listar[i].QtdeBLed.ToString();
                        Param[25] = Listar[i].TotalLed.ToString();
                        Param[26] = Listar[i].ValorBarra.ToString();
                        Param[27] = Listar[i].ValorLed.ToString();*/

                        DgConsulta.Rows.Add(Param);
                    }
                }
                else
                {
                    if(String.IsNullOrWhiteSpace(TxBuscar.Text))
                    {
                        throw new Exception("FAVOR DIGITE O QUE DESEJA BUSCAR NA BASE DE DADOS AQUI");
                    }
                    else
                    {
                        if(RdMarca.Checked.Equals(true))
                        {
                            DgConsulta.Rows.Clear();
                            List<Classes.Bioghet_Bazar> Listar = Classes.Bioghet_ConsultaMysql.Listar_Bazar_Marca(TxBuscar.Text);

                            String[] Param = new String[18];

                            for (int i = 0; i < Listar.Count; i++)
                            {
                                Param[0] = Listar[i].Tipo;
                                Param[1] = Listar[i].Marca;
                                Param[2] = Listar[i].Modelo;
                                Param[3] = Listar[i].Descricao;
                                Param[4] = Listar[i].PartNumber;
                                Param[5] = Listar[i].Serie;
                                Param[6] = Listar[i].Status;
                                Param[7] = Listar[i].Valor.ToString("#####0.00");
                                Param[8] = Listar[i].Prateleira.ToString();
                                Param[9] = Listar[i].Caixa.ToString();
                                Param[10] = Listar[i].Compartimento.ToString();
                                Param[11] = Listar[i].Quantidade.ToString();
                                Param[12] = Listar[i].Pavimento;
                                Param[13] = Listar[i].Sala;
                                Param[14] = Listar[i].OBS;
                                Param[15] = Listar[i].CodigoPeca;
                                Param[16] = Listar[i].Data.ToString("dd-MM-yyyy");
                                Param[17] = Listar[i].TV.ToString();
                                /*Param[18] = Listar[i].Tensao;
                                Param[19] = Listar[i].QtdeLede.ToString();
                                Param[20] = Listar[i].VLed;
                                Param[21] = Listar[i].WLed;
                                Param[22] = Listar[i].QtdeBarra.ToString();
                                Param[23] = Listar[i].TBarra;
                                Param[24] = Listar[i].QtdeBLed.ToString();
                                Param[25] = Listar[i].TotalLed.ToString();
                                Param[26] = Listar[i].ValorBarra.ToString();
                                Param[27] = Listar[i].ValorLed.ToString();*/

                                DgConsulta.Rows.Add(Param);
                            }
                        }
                        else if (RdModelo.Checked.Equals(true))
                        {
                            DgConsulta.Rows.Clear();
                            List<Classes.Bioghet_Bazar> Listar = Classes.Bioghet_ConsultaMysql.Listar_Bazar_Modelo(TxBuscar.Text);

                            String[] Param = new String[18];

                            for (int i = 0; i < Listar.Count; i++)
                            {
                                Param[0] = Listar[i].Tipo;
                                Param[1] = Listar[i].Marca;
                                Param[2] = Listar[i].Modelo;
                                Param[3] = Listar[i].Descricao;
                                Param[4] = Listar[i].PartNumber;
                                Param[5] = Listar[i].Serie;
                                Param[6] = Listar[i].Status;
                                Param[7] = Listar[i].Valor.ToString("#####0.00");
                                Param[8] = Listar[i].Prateleira.ToString();
                                Param[9] = Listar[i].Caixa.ToString();
                                Param[10] = Listar[i].Compartimento.ToString();
                                Param[11] = Listar[i].Quantidade.ToString();
                                Param[12] = Listar[i].Pavimento;
                                Param[13] = Listar[i].Sala;
                                Param[14] = Listar[i].OBS;
                                Param[15] = Listar[i].CodigoPeca;
                                Param[16] = Listar[i].Data.ToString("dd-MM-yyyy");
                                Param[17] = Listar[i].TV.ToString();
                                /*Param[18] = Listar[i].Tensao;
                                Param[19] = Listar[i].QtdeLede.ToString();
                                Param[20] = Listar[i].VLed;
                                Param[21] = Listar[i].WLed;
                                Param[22] = Listar[i].QtdeBarra.ToString();
                                Param[23] = Listar[i].TBarra;
                                Param[24] = Listar[i].QtdeBLed.ToString();
                                Param[25] = Listar[i].TotalLed.ToString();
                                Param[26] = Listar[i].ValorBarra.ToString();
                                Param[27] = Listar[i].ValorLed.ToString();*/

                                DgConsulta.Rows.Add(Param);
                            }
                        }
                        else if (RdCodigo.Checked.Equals(true))
                        {
                            DgConsulta.Rows.Clear();
                            List<Classes.Bioghet_Bazar> Listar = Classes.Bioghet_ConsultaMysql.Listar_Bazar_CodigoPeca(TxBuscar.Text);

                            String[] Param = new String[18];

                            for (int i = 0; i < Listar.Count; i++)
                            {
                                Param[0] = Listar[i].Tipo;
                                Param[1] = Listar[i].Marca;
                                Param[2] = Listar[i].Modelo;
                                Param[3] = Listar[i].Descricao;
                                Param[4] = Listar[i].PartNumber;
                                Param[5] = Listar[i].Serie;
                                Param[6] = Listar[i].Status;
                                Param[7] = Listar[i].Valor.ToString("#####0.00");
                                Param[8] = Listar[i].Prateleira.ToString();
                                Param[9] = Listar[i].Caixa.ToString();
                                Param[10] = Listar[i].Compartimento.ToString();
                                Param[11] = Listar[i].Quantidade.ToString();
                                Param[12] = Listar[i].Pavimento;
                                Param[13] = Listar[i].Sala;
                                Param[14] = Listar[i].OBS;
                                Param[15] = Listar[i].CodigoPeca;
                                Param[16] = Listar[i].Data.ToString("dd-MM-yyyy");
                                Param[17] = Listar[i].TV.ToString();
                                /*Param[18] = Listar[i].Tensao;
                                Param[19] = Listar[i].QtdeLede.ToString();
                                Param[20] = Listar[i].VLed;
                                Param[21] = Listar[i].WLed;
                                Param[22] = Listar[i].QtdeBarra.ToString();
                                Param[23] = Listar[i].TBarra;
                                Param[24] = Listar[i].QtdeBLed.ToString();
                                Param[25] = Listar[i].TotalLed.ToString();
                                Param[26] = Listar[i].ValorBarra.ToString();
                                Param[27] = Listar[i].ValorLed.ToString();*/

                                DgConsulta.Rows.Add(Param);
                            }
                        }
                        else if (RdPartNumber.Checked.Equals(true))
                        {
                            DgConsulta.Rows.Clear();
                            List<Classes.Bioghet_Bazar> ListarPartNumber = Classes.Bioghet_ConsultaMysql.Listar_Bazar_PartNumber(TxBuscar.Text);

                            String[] Param = new String[18];

                            for (int i = 0; i < ListarPartNumber.Count; i++)
                            {
                                Param[0] = ListarPartNumber[i].Tipo;
                                Param[1] = ListarPartNumber[i].Marca;
                                Param[2] = ListarPartNumber[i].Modelo;
                                Param[3] = ListarPartNumber[i].Descricao;
                                Param[4] = ListarPartNumber[i].PartNumber;
                                Param[5] = ListarPartNumber[i].Serie;
                                Param[6] = ListarPartNumber[i].Status;
                                Param[7] = ListarPartNumber[i].Valor.ToString("#####0.00");
                                Param[8] = ListarPartNumber[i].Prateleira.ToString();
                                Param[9] = ListarPartNumber[i].Caixa.ToString();
                                Param[10] = ListarPartNumber[i].Compartimento.ToString();
                                Param[11] = ListarPartNumber[i].Quantidade.ToString();
                                Param[12] = ListarPartNumber[i].Pavimento;
                                Param[13] = ListarPartNumber[i].Sala;
                                Param[14] = ListarPartNumber[i].OBS;
                                Param[15] = ListarPartNumber[i].CodigoPeca;
                                Param[16] = ListarPartNumber[i].Data.ToString("dd-MM-yyyy");
                                Param[17] = ListarPartNumber[i].TV.ToString();
                                /*Param[18] = ListarPartNumber[i].Tensao;
                                Param[19] = ListarPartNumber[i].QtdeLede.ToString();
                                Param[20] = ListarPartNumber[i].VLed;
                                Param[21] = ListarPartNumber[i].WLed;
                                Param[22] = ListarPartNumber[i].QtdeBarra.ToString();
                                Param[23] = ListarPartNumber[i].TBarra;
                                Param[24] = ListarPartNumber[i].QtdeBLed.ToString();
                                Param[25] = ListarPartNumber[i].TotalLed.ToString();
                                Param[26] = ListarPartNumber[i].ValorBarra.ToString();
                                Param[27] = ListarPartNumber[i].ValorLed.ToString();*/

                                DgConsulta.Rows.Add(Param);
                            }
                        }
                        else if (RdSerie.Checked.Equals(true))
                        {
                            DgConsulta.Rows.Clear();
                            List<Classes.Bioghet_Bazar> Listar = Classes.Bioghet_ConsultaMysql.Listar_Bazar_Serie(TxBuscar.Text);

                            String[] Param = new String[18];

                            for (int i = 0; i < Listar.Count; i++)
                            {
                                Param[0] = Listar[i].Tipo;
                                Param[1] = Listar[i].Marca;
                                Param[2] = Listar[i].Modelo;
                                Param[3] = Listar[i].Descricao;
                                Param[4] = Listar[i].PartNumber;
                                Param[5] = Listar[i].Serie;
                                Param[6] = Listar[i].Status;
                                Param[7] = Listar[i].Valor.ToString("#####0.00");
                                Param[8] = Listar[i].Prateleira.ToString();
                                Param[9] = Listar[i].Caixa.ToString();
                                Param[10] = Listar[i].Compartimento.ToString();
                                Param[11] = Listar[i].Quantidade.ToString();
                                Param[12] = Listar[i].Pavimento;
                                Param[13] = Listar[i].Sala;
                                Param[14] = Listar[i].OBS;
                                Param[15] = Listar[i].CodigoPeca;
                                Param[16] = Listar[i].Data.ToString("dd-MM-yyyy");
                                Param[17] = Listar[i].TV.ToString();
                                /*Param[18] = Listar[i].Tensao;
                                Param[19] = Listar[i].QtdeLede.ToString();
                                Param[20] = Listar[i].VLed;
                                Param[21] = Listar[i].WLed;
                                Param[22] = Listar[i].QtdeBarra.ToString();
                                Param[23] = Listar[i].TBarra;
                                Param[24] = Listar[i].QtdeBLed.ToString();
                                Param[25] = Listar[i].TotalLed.ToString();
                                Param[26] = Listar[i].ValorBarra.ToString();
                                Param[27] = Listar[i].ValorLed.ToString();*/

                                DgConsulta.Rows.Add(Param);
                            }
                        }
                        else if (RdStatus.Checked.Equals(true))
                        {
                            DgConsulta.Rows.Clear();
                            List<Classes.Bioghet_Bazar> Listar = Classes.Bioghet_ConsultaMysql.Listar_Bazar_Status(TxBuscar.Text);

                            String[] Param = new String[18];

                            for (int i = 0; i < Listar.Count; i++)
                            {
                                Param[0] = Listar[i].Tipo;
                                Param[1] = Listar[i].Marca;
                                Param[2] = Listar[i].Modelo;
                                Param[3] = Listar[i].Descricao;
                                Param[4] = Listar[i].PartNumber;
                                Param[5] = Listar[i].Serie;
                                Param[6] = Listar[i].Status;
                                Param[7] = Listar[i].Valor.ToString("#####0.00");
                                Param[8] = Listar[i].Prateleira.ToString();
                                Param[9] = Listar[i].Caixa.ToString();
                                Param[10] = Listar[i].Compartimento.ToString();
                                Param[11] = Listar[i].Quantidade.ToString();
                                Param[12] = Listar[i].Pavimento;
                                Param[13] = Listar[i].Sala;
                                Param[14] = Listar[i].OBS;
                                Param[15] = Listar[i].CodigoPeca;
                                Param[16] = Listar[i].Data.ToString("dd-MM-yyyy");
                                Param[17] = Listar[i].TV.ToString();
                                /*Param[18] = Listar[i].Tensao;
                                Param[19] = Listar[i].QtdeLede.ToString();
                                Param[20] = Listar[i].VLed;
                                Param[21] = Listar[i].WLed;
                                Param[22] = Listar[i].QtdeBarra.ToString();
                                Param[23] = Listar[i].TBarra;
                                Param[24] = Listar[i].QtdeBLed.ToString();
                                Param[25] = Listar[i].TotalLed.ToString();
                                Param[26] = Listar[i].ValorBarra.ToString();
                                Param[27] = Listar[i].ValorLed.ToString();*/

                                DgConsulta.Rows.Add(Param);
                            }
                        }
                        else if (RdDescricao.Checked.Equals(true))
                        {
                            DgConsulta.Rows.Clear();
                            List<Classes.Bioghet_Bazar> Listar = Classes.Bioghet_ConsultaMysql.Listar_Bazar_Descricao(TxBuscar.Text);

                            String[] Param = new String[18];

                            for (int i = 0; i < Listar.Count; i++)
                            {
                                Param[0] = Listar[i].Tipo;
                                Param[1] = Listar[i].Marca;
                                Param[2] = Listar[i].Modelo;
                                Param[3] = Listar[i].Descricao;
                                Param[4] = Listar[i].PartNumber;
                                Param[5] = Listar[i].Serie;
                                Param[6] = Listar[i].Status;
                                Param[7] = Listar[i].Valor.ToString("#####0.00");
                                Param[8] = Listar[i].Prateleira.ToString();
                                Param[9] = Listar[i].Caixa.ToString();
                                Param[10] = Listar[i].Compartimento.ToString();
                                Param[11] = Listar[i].Quantidade.ToString();
                                Param[12] = Listar[i].Pavimento;
                                Param[13] = Listar[i].Sala;
                                Param[14] = Listar[i].OBS;
                                Param[15] = Listar[i].CodigoPeca;
                                Param[16] = Listar[i].Data.ToString("dd-MM-yyyy");
                                Param[17] = Listar[i].TV.ToString();
                                /*Param[18] = Listar[i].Tensao;
                                Param[19] = Listar[i].QtdeLede.ToString();
                                Param[20] = Listar[i].VLed;
                                Param[21] = Listar[i].WLed;
                                Param[22] = Listar[i].QtdeBarra.ToString();
                                Param[23] = Listar[i].TBarra;
                                Param[24] = Listar[i].QtdeBLed.ToString();
                                Param[25] = Listar[i].TotalLed.ToString();
                                Param[26] = Listar[i].ValorBarra.ToString();
                                Param[27] = Listar[i].ValorLed.ToString();*/

                                DgConsulta.Rows.Add(Param);
                            }
                        }
                        else
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal FrmVenda _venda = new FrmVenda();
        private void DgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(18))
                {
                    Classes.Bioghet_Configuracao.vendaBazar = true;

                    FrmAviso _aviso = new FrmAviso();
                    _aviso.LbAviso.Text = "DIGITE A QUANTIDADE DO PRODUTO";
                    _aviso.ShowDialog();

                    int QuantidadeEstoque = 0;

                    if (!String.IsNullOrWhiteSpace(DgConsulta.CurrentRow.Cells[4].Value.ToString()))
                    {
                        QuantidadeEstoque = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoqueBazarPartnumber(DgConsulta.CurrentRow.Cells[4].Value.ToString());
                    }
                    else
                    {
                        QuantidadeEstoque = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeEstoqueBazarSerie(DgConsulta.CurrentRow.Cells[5].Value.ToString());
                    }

                    if (QuantidadeEstoque <= 0)
                    {
                        throw new Exception("VENDA INVÁLIDA ESTOQUE ZERADO, FAVOR VERIFIQUE");
                    }
                    else if (Classes.Bioghet_Configuracao.Quantidade > QuantidadeEstoque)
                    {
                        throw new Exception("VENDA INVÁLIDA QUANTIDADE EXCEDIDA, FAVOR VERIFIQUE");
                    }
                    else
                    {
                        DialogResult _pergunta = MessageBox.Show("DESEJA ADICIONAR O ITEM " + DgConsulta.CurrentRow.Cells[1].Value.ToString() + " AO CARRINHO DE COMPRA", "CARRINHO DE COMPRA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (_pergunta == System.Windows.Forms.DialogResult.Yes)
                        {

                            Classes.Bioghet_Configuracao.TotalItems = Classes.Bioghet_Configuracao.TotalItems + 1;

                            LbTotalItems.Text = Classes.Bioghet_Configuracao.TotalItems.ToString();

                            if (!String.IsNullOrWhiteSpace(DgConsulta.CurrentRow.Cells[4].Value.ToString()))
                            {
                                _venda.DgConsulta.Rows.Add(LbTotalItems.Text, DgConsulta.CurrentRow.Cells[3].Value.ToString(), Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeCodigoBazarPartnumber(DgConsulta.CurrentRow.Cells[4].Value.ToString()), String.Empty, Classes.Bioghet_Configuracao.Quantidade, DgConsulta.CurrentRow.Cells[7].Value.ToString(), Decimal.Multiply(decimal.Parse(Classes.Bioghet_Configuracao.Quantidade.ToString()), decimal.Parse(DgConsulta.CurrentRow.Cells[7].Value.ToString())), Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeCodigoBazarPartnumber(DgConsulta.CurrentRow.Cells[4].Value.ToString()), Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeCodigoBazarPartnumber(DgConsulta.CurrentRow.Cells[4].Value.ToString()));
                            }
                            else
                            {
                                _venda.DgConsulta.Rows.Add(LbTotalItems.Text, DgConsulta.CurrentRow.Cells[3].Value.ToString(), Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeCodigoBazarPartnumber(DgConsulta.CurrentRow.Cells[4].Value.ToString()), String.Empty, Classes.Bioghet_Configuracao.Quantidade, DgConsulta.CurrentRow.Cells[7].Value.ToString(), Decimal.Multiply(decimal.Parse(Classes.Bioghet_Configuracao.Quantidade.ToString()), decimal.Parse(DgConsulta.CurrentRow.Cells[7].Value.ToString())), Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeCodigoBazarPartnumber(DgConsulta.CurrentRow.Cells[4].Value.ToString()), Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeCodigoBazarSerie(DgConsulta.CurrentRow.Cells[5].Value.ToString()));
                            }

                            Decimal Total = Decimal.Subtract(QuantidadeEstoque, Decimal.Parse(Classes.Bioghet_Configuracao.Quantidade.ToString()));

                            int IDProduto = 0;

                            if (!String.IsNullOrWhiteSpace(DgConsulta.CurrentRow.Cells[4].Value.ToString()))
                            {
                                IDProduto = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeCodigoBazarPartnumber(DgConsulta.CurrentRow.Cells[4].Value.ToString());
                            }
                            else
                            {
                                IDProduto = Classes.Bioghet_ConsultaMysql.Consultar_QuantidadeCodigoBazarSerie(DgConsulta.CurrentRow.Cells[5].Value.ToString());
                            }

                            int retornoestoqueproduto = Classes.Bioghet_UpdateMYSQL.Update_QuantidadeBazar(Int32.Parse(Total.ToString()), IDProduto);
                        }
                    }
                }
                
                if(e.ColumnIndex.Equals(19))
                {
                    Form13 _bazar = new Form13();

                    Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();
                    _bazar.CbTipo.Items.Clear();

                    for (int servico = 0; servico < Classes.Bioghet_Configuracao._servico.Count; servico++)
                    {
                        _bazar.CbTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao);
                    }

                    int index =_bazar.CbTipo.FindString(DgConsulta.CurrentRow.Cells[0].Value.ToString());
                    _bazar.CbTipo.SelectedIndex = index;
                    _bazar.TxCadMarca.Text = DgConsulta.CurrentRow.Cells[1].Value.ToString();
                    _bazar.TxCadModelo.Text = DgConsulta.CurrentRow.Cells[2].Value.ToString();
                    if (!String.IsNullOrWhiteSpace(DgConsulta.CurrentRow.Cells[3].Value.ToString()))
                        _bazar.TxDescricao.Text = DgConsulta.CurrentRow.Cells[3].Value.ToString();
                    _bazar.TxPartNumber.Text = DgConsulta.CurrentRow.Cells[4].Value.ToString();
                    _bazar.TxSerie.Text = DgConsulta.CurrentRow.Cells[5].Value.ToString();
                    _bazar.CbStatus.Text = DgConsulta.CurrentRow.Cells[6].Value.ToString();
                    _bazar.TxValor.Text = DgConsulta.CurrentRow.Cells[7].Value.ToString();
                    _bazar.TxPrateleira.Text = DgConsulta.CurrentRow.Cells[8].Value.ToString();
                    _bazar.TxCaixa.Text = DgConsulta.CurrentRow.Cells[9].Value.ToString();
                    _bazar.TxCompartimento.Text = DgConsulta.CurrentRow.Cells[10].Value.ToString();
                    _bazar.TxQuantidade.Text = DgConsulta.CurrentRow.Cells[11].Value.ToString();
                    _bazar.TxPavimento.Text = DgConsulta.CurrentRow.Cells[12].Value.ToString();
                    _bazar.TxSala.Text = DgConsulta.CurrentRow.Cells[13].Value.ToString();
                    _bazar.TxObs.Text = DgConsulta.CurrentRow.Cells[14].Value.ToString();
                    _bazar.TxCodPeca.Text = DgConsulta.CurrentRow.Cells[15].Value.ToString();
                    _bazar.TxDataPeca.Text = DgConsulta.CurrentRow.Cells[16].Value.ToString();
                    /*_bazar.TxTensao.Text = DgConsulta.CurrentRow.Cells[18].Value.ToString();
                    _bazar.TxQtdeLed.Text = DgConsulta.CurrentRow.Cells[19].Value.ToString();
                    _bazar.TxVled.Text = DgConsulta.CurrentRow.Cells[20].Value.ToString();
                    _bazar.TxWled.Text = DgConsulta.CurrentRow.Cells[21].Value.ToString();
                    _bazar.TxQtdeBarra.Text = DgConsulta.CurrentRow.Cells[22].Value.ToString();
                    _bazar.TxTBarra.Text = DgConsulta.CurrentRow.Cells[23].Value.ToString();
                    _bazar.TxQtdeLedBarra.Text = DgConsulta.CurrentRow.Cells[24].Value.ToString();
                    _bazar.TxTotalLed.Text = DgConsulta.CurrentRow.Cells[25].Value.ToString();
                    _bazar.TxValorBarra.Text = DgConsulta.CurrentRow.Cells[26].Value.ToString();
                    _bazar.TxValorLed.Text = DgConsulta.CurrentRow.Cells[27].Value.ToString();*/
                   
                    if(_bazar.CbTipo.Text == "BARRA DE LED")
                    {
                        _bazar.TxQtdeLed.Enabled = true;
                        _bazar.TxVled.Enabled = true;
                        _bazar.TxWled.Enabled = true;
                        _bazar.TxQtdeBarra.Enabled = true;
                        //_bazar.TxTBarra.Enabled = true;
                        _bazar.TxValorBarra.Enabled = true;
                        _bazar.TxValorLed.Enabled = true;
                        _bazar.TxCodigo.Enabled = true;
                        _bazar.TxVTela.Enabled = true;
                        _bazar.TxWTela.Enabled = true;
                    }
                    else
                    {
                        _bazar.TxQtdeLed.Enabled = false;
                        _bazar.TxVled.Enabled = false;
                        _bazar.TxWled.Enabled = false;
                        _bazar.TxQtdeBarra.Enabled = false;
                        //_bazar.TxTBarra.Enabled = false;
                        _bazar.TxValorBarra.Enabled = false;
                        _bazar.TxValorLed.Enabled = false;
                        _bazar.TxCodigo.Enabled = true;
                        _bazar.TxVTela.Enabled = true;
                        _bazar.TxWTela.Enabled = true;
                    }
                    //_bazar.DgSerie.Rows.Clear();



                    //List<Classes.Bioghet_Bazar> _lista_bazarModelos = Classes.Bioghet_ConsultaMysql.Listar_Bazar_Modelos(DgConsulta.CurrentRow.Cells[2].Value.ToString());
                    //for(int i = 0; i < 1; i++)
                    //{
                    //    if (i == 0)
                    //        if (!String.IsNullOrWhiteSpace(_lista_bazarModelos[i].Modelo))
                    //            _bazar.DgModelos.Rows.Add(_lista_bazarModelos[i].Modelo);
                    //        if (!String.IsNullOrWhiteSpace(_lista_bazarModelos[i].Modelo1))
                    //            _bazar.DgModelos.Rows.Add(_lista_bazarModelos[i].Modelo1);
                    //        if (!String.IsNullOrWhiteSpace(_lista_bazarModelos[i].Modelo2))
                    //            _bazar.DgModelos.Rows.Add(_lista_bazarModelos[i].Modelo2);
                    //        if (!String.IsNullOrWhiteSpace(_lista_bazarModelos[i].Modelo3))
                    //            _bazar.DgModelos.Rows.Add(_lista_bazarModelos[i].Modelo3);
                    //        if (!String.IsNullOrWhiteSpace(_lista_bazarModelos[i].Modelo4))
                    //            _bazar.DgModelos.Rows.Add(_lista_bazarModelos[i].Modelo4);

                    //}

                    Form13._bazar = new Classes.Bioghet_Bazar();

                    Form13._bazar.Tipo = DgConsulta.CurrentRow.Cells[0].Value.ToString();
                    Form13._bazar.Marca = DgConsulta.CurrentRow.Cells[1].Value.ToString();
                    Form13._bazar.Modelo = DgConsulta.CurrentRow.Cells[2].Value.ToString();
                    Form13._bazar.PartNumber = DgConsulta.CurrentRow.Cells[4].Value.ToString();
                    Form13._bazar.Serie = DgConsulta.CurrentRow.Cells[5].Value.ToString();
                    Form13._bazar.Status = DgConsulta.CurrentRow.Cells[6].Value.ToString();
                    Form13._bazar.Valor = Decimal.Parse(DgConsulta.CurrentRow.Cells[7].Value.ToString());
                    Form13._bazar.Prateleira = DgConsulta.CurrentRow.Cells[8].Value.ToString();
                    Form13._bazar.Caixa = DgConsulta.CurrentRow.Cells[9].Value.ToString();
                    Form13._bazar.Compartimento = DgConsulta.CurrentRow.Cells[10].Value.ToString();
                    Form13._bazar.Quantidade = int.Parse(DgConsulta.CurrentRow.Cells[11].Value.ToString());
                    if (!String.IsNullOrWhiteSpace(DgConsulta.CurrentRow.Cells[4].Value.ToString()))
                    {                      
                        Form13._bazar.Situacao = Classes.Bioghet_ConsultaMysql.Consultar_SituacaoPartNumber(DgConsulta.CurrentRow.Cells[4].Value.ToString());
                        _bazar.CbSituacao.Text = Form13._bazar.Situacao;
                    }
                    else
                    {
                        Form13._bazar.Situacao = Classes.Bioghet_ConsultaMysql.Consultar_SituacaoSerie(DgConsulta.CurrentRow.Cells[5].Value.ToString());
                        _bazar.CbSituacao.Text = Form13._bazar.Situacao;
                    }

                    _bazar.ShowDialog();
                }

                if (e.ColumnIndex.Equals(20))
                {
                    DialogResult pergunta = MessageBox.Show("DESEJA REALMENTE EXCLUIR O ITEM " + DgConsulta.CurrentRow.Cells[2].Value.ToString(), " EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(pergunta == DialogResult.Yes)
                    {
                        int retorno = Classes.Bioghet_ExcluirMYSQL.Excluir_Bazar(DgConsulta.CurrentRow.Cells[5].Value.ToString());
                        if (retorno.Equals(1))
                        {
                            Classes.Bioghet_ExcluirMYSQL.Excluir_BazarEmbalGeal(DgConsulta.CurrentRow.Cells[0].Value.ToString(), DgConsulta.CurrentRow.Cells[1].Value.ToString(), DgConsulta.CurrentRow.Cells[2].Value.ToString());
                            MessageBox.Show("ITEM EXCLUIDO COM SUCESSO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("ERRO AO EXCLUIR O ITEM DO BAZAR");
                        }
                    }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool mouseClicked;
        Point clickedAt;

        private void Form14_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void Form14_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void Form14_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void TxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Button __Sender = (Button)sender;
                Point __PowerClique = new Point(0, __Sender.Height);
                __PowerClique = __Sender.PointToScreen(__PowerClique);
                MnuPrinter.Show(__PowerClique);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao.Cupom = int.Parse(Interaction.InputBox("INFORME O NÚMERO DO CUPOM", "EXTORNAR VENDA", "1", 200, 200));

                DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE EXTORNAR A VENDA DO CUPOM ==>" + Classes.Bioghet_Configuracao.Cupom.ToString(), "EXTORNAR VENDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (_pergunta == DialogResult.Yes)
                {
                    int retorno = Classes.Bioghet_DeleteMYSQL.Extornar_Venda(Classes.Bioghet_Configuracao.Cupom, "VB");

                    if (retorno.Equals(1))
                    {
                        LbTotalItems.Text = "0";
                        MessageBox.Show("VENDA EXTORNADA COM SUCESSO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("NÃO FOI POSSÍVEL REALIZAR O EXTORNO, FAVOR VERIFIQUE E TENTE NOVAMENTE");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (RdDescricao.Checked.Equals(true))
                    {
                        DgConsulta.Rows.Clear();
                        List<Classes.Bioghet_Bazar> Listar = Classes.Bioghet_ConsultaMysql.Listar_Bazar_Descricao(TxBuscar.Text);

                        String[] Param = new String[12];

                        for (int i = 0; i < Listar.Count; i++)
                        {
                            Param[0] = Listar[i].Tipo;
                            Param[1] = Listar[i].Marca;
                            Param[2] = Listar[i].Modelo;
                            Param[3] = Listar[i].Descricao;
                            Param[4] = Listar[i].PartNumber;
                            Param[5] = Listar[i].Serie;
                            Param[6] = Listar[i].Status;
                            Param[7] = Listar[i].Valor.ToString("#####0.00");
                            Param[8] = Listar[i].Prateleira.ToString();
                            Param[9] = Listar[i].Caixa.ToString();
                            Param[10] = Listar[i].Compartimento.ToString();
                            Param[11] = Listar[i].Quantidade.ToString();

                            DgConsulta.Rows.Add(Param);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imprimirVazioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_venda.DgConsulta.Rows.Count != 0)
                {
                    Random _CupomVenda = new Random();
                    _venda.LbVenda.Text = _CupomVenda.Next(9999).ToString();

                    Decimal Total = 0;

                    foreach (DataGridViewRow col in _venda.DgConsulta.Rows)
                    {

                        Decimal Valor = Decimal.Parse(col.Cells[6].Value.ToString());
                        Total = Decimal.Add(Total, Valor);

                    }

                    Classes.Bioghet_Configuracao.vendaBazar = true;

                    _venda.LbTotalVenda.Text = Total.ToString("#####0.00");

                    _venda.ShowDialog();
                }
                else
                {
                    throw new Exception("NENHUM ITEM ADICIONADO AO CARRINHO DE COMPRA, FAVOR VERIFIQUE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String CriarRelatorioProduto()
        {
            String formatohtml = String.Empty;

            Font fonte = DgConsulta.ColumnHeadersDefaultCellStyle.Font;

            int tabSize = 0;
            foreach (DataGridViewColumn col in DgConsulta.Columns)
                if (col.Visible) tabSize += col.Width;

            string[] conteudo = new string[DgConsulta.Columns.Count];

            formatohtml = ("<html><head>");
            formatohtml += ("<meta http-equiv='Content-Type' "
                + "content='text/html; charset=utf-8' />");
            formatohtml += ("<title>" + "LISTA DE BAZAR CADASTRADOS" + "</title>");
            formatohtml += ("</head><body>");
            //formatohtml += ("<center><p><image src='" + Environment.CurrentDirectory + "\\logotelecentro.png" + "' align='middle'><image src='" + Environment.CurrentDirectory + "\\logobioghet.png"+ "' align='middle'></p></center>");
            formatohtml += ("<div style='text-align:center; font-weight:bold; font-size:20px'>LISTA DE BAZAR CADASTRADOS</div> ");
            formatohtml += ("<br>");
            formatohtml += ("<div style='position:static'>");
            formatohtml += ("<table align=center style='border-collapse: collapse; width:"
                + tabSize.ToString() + "px'>");
            formatohtml += ("<tr>");

            foreach (DataGridViewColumn coluna in DgConsulta.Columns)
            {
                if (coluna.Visible)
                {
                    formatohtml += ("<td style='padding: 2px 2px 2px 2px; "
                        + "font-weight:bold; font-size:"
                        + Convert.ToInt32(fonte.Size + 3).ToString()
                        + "px; border-collapse: collapse; ' align='"
                        + coluna.InheritedStyle.Alignment.ToString().Substring(6,
                            coluna.InheritedStyle.Alignment.ToString().Length - 6)
                        + "' width='" + coluna.Width + "'>");
                    formatohtml += ("<font face='" + fonte.Name + "'>");
                    formatohtml += (coluna.HeaderText.ToString());
                    formatohtml += ("</font>");
                    formatohtml += ("</td>");
                }
            }
            formatohtml += ("</tr>");
            if (DgConsulta.Rows.Count > 0)
            {
                foreach (DataGridViewRow linha in DgConsulta.Rows)
                {
                    formatohtml += ("<tr>");
                    foreach (DataGridViewCell celula in linha.Cells)
                    {
                        if (celula.Visible)
                        {
                            formatohtml += ("<td style='padding: 2px 2px 2px 2px; font-size:"
                                + Convert.ToInt32(fonte.Size + 3).ToString()
                                + "; border-collapse: collapse; ' align='"
                                + celula.InheritedStyle.Alignment.ToString().Substring(6,
                                    celula.InheritedStyle.Alignment.ToString().Length - 6)
                                + "' width='" + celula.Size.Width + "'>");
                            formatohtml += ("<font face='" + fonte.Name + "'>"
                                + celula.FormattedValue.ToString() + "</font>");
                            formatohtml += ("</td>");
                        }
                    }
                    formatohtml += ("</tr>");
                }
            }
            formatohtml += ("</table></div></body></html>");

            formatohtml += ("<br>");
            formatohtml += ("<br>");
            formatohtml += ("<hr />");
            formatohtml += ("<br>");
            formatohtml += ("<br>");

            return formatohtml;
        }
        private void relatorioBazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter(Environment.CurrentDirectory + "\\Relatorio\\Bazar.html");
                arquivo.WriteLine(CriarRelatorioProduto());
                arquivo.Flush();
                arquivo.Close();

                DialogResult Pergunta = MessageBox.Show("ARQUIVO GERADO COM SUCESSO, DESEJA VISUALIZAR O ARQUIVO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (Pergunta == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\Relatorio\\Bazar.html");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRelatorioBazar bazar = new FrmRelatorioBazar();
                bazar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String CriarRelatorioBarraLed()
        {
            DataGridView DgURL = new DataGridView();
            DgURL.Columns.Add("TIPO", "TIPO");
            DgURL.Columns.Add("MARCA", "MARCA");
            DgURL.Columns.Add("MODELO", "MODELO");
            DgURL.Columns.Add("CODIGO", "CODIGO");
            DgURL.Columns.Add("QTDELED", "QTDELED");
            DgURL.Columns.Add("QTDEBARRA", "QTDEBARRA");
            DgURL.Columns.Add("VTELA", "VTELA");
            DgURL.Columns.Add("WTELA", "WTELA");
            DgURL.Columns.Add("VLED", "VLED");
            DgURL.Columns.Add("WLED", "WLED");
            DgURL.Columns.Add("VALORBARRA", "VALORBARRA");
            DgURL.Columns.Add("VALORLED", "VALORLED");

            List<Classes.Bioghet_BarraLed> bioghet_Apps = Classes.Bioghet_ConsultaMysql.Listar_Bazar_BarraLeds();
            String[] Param = new String[13];

            for (int i = 0; i < bioghet_Apps.Count; i++)
            {
                Param[0] = bioghet_Apps[i].Tipo;
                Param[1] = bioghet_Apps[i].Marca;
                Param[2] = bioghet_Apps[i].Modelo;
                Param[3] = bioghet_Apps[i].CodigoBLED;
                Param[4] = bioghet_Apps[i].QtdeLede.ToString();
                Param[5] = bioghet_Apps[i].QtdeBarra.ToString();
                Param[6] = bioghet_Apps[i].VTela.ToString();
                Param[7] = bioghet_Apps[i].WTela.ToString();
                Param[8] = bioghet_Apps[i].VLed.ToString();
                Param[9] = bioghet_Apps[i].WLed.ToString();
                Param[10] = bioghet_Apps[i].ValorBarra.ToString("#####0.00");
                Param[11] = bioghet_Apps[i].ValorLed.ToString("#####0.00");

                DgURL.Rows.Add(Param);
            }

            String formatohtml = String.Empty;

            Font fonte = DgURL.ColumnHeadersDefaultCellStyle.Font;

            int tabSize = 0;
            foreach (DataGridViewColumn col in DgURL.Columns)
                if (col.Visible) tabSize += col.Width;

            string[] conteudo = new string[DgURL.Columns.Count];

            formatohtml = ("<html><head>");
            formatohtml += ("<meta http-equiv='Content-Type' "
                + "content='text/html; charset=utf-8' />");
            formatohtml += ("<title>" + "RELAÇÃO DE BARRA DE LEDS" + "</title>");
            formatohtml += ("</head><body>");
            //formatohtml += ("<center><p><image src='" + Environment.CurrentDirectory + "\\logotelecentro.png" + "' align='middle'><image src='" + Environment.CurrentDirectory + "\\logobioghet.png"+ "' align='middle'></p></center>");
            formatohtml += ("<div style='text-align:center; font-weight:bold; font-size:20px'>RELATÓRIO DE BARRA DE LEDS</div> ");
            formatohtml += ("<br>");
            formatohtml += ("<div style='position:static'>");
            formatohtml += ("<table align=center style='border-collapse: collapse; width:"
                + tabSize.ToString() + "px'>");
            formatohtml += ("<tr>");

            foreach (DataGridViewColumn coluna in DgURL.Columns)
            {
                if (coluna.Visible)
                {
                    formatohtml += ("<td style='padding: 2px 2px 2px 2px; "
                        + "font-weight:bold; font-size:"
                        + Convert.ToInt32(fonte.Size + 3).ToString()
                        + "px; border-collapse: collapse; ' align='"
                        + coluna.InheritedStyle.Alignment.ToString().Substring(6,
                            coluna.InheritedStyle.Alignment.ToString().Length - 6)
                        + "' width='" + coluna.Width + "'>");
                    formatohtml += ("<font face='" + fonte.Name + "'>");
                    formatohtml += (coluna.HeaderText.ToString());
                    formatohtml += ("</font>");
                    formatohtml += ("</td>");
                }
            }
            formatohtml += ("</tr>");
            if (DgURL.Rows.Count > 0)
            {
                foreach (DataGridViewRow linha in DgURL.Rows)
                {
                    formatohtml += ("<tr>");
                    foreach (DataGridViewCell celula in linha.Cells)
                    {
                        if (celula.Visible)
                        {
                            formatohtml += ("<td style='padding: 2px 2px 2px 2px; font-size:"
                                + Convert.ToInt32(fonte.Size + 3).ToString()
                                + "; border-collapse: collapse; ' align='"
                                + celula.InheritedStyle.Alignment.ToString().Substring(6,
                                    celula.InheritedStyle.Alignment.ToString().Length - 6)
                                + "' width='" + celula.Size.Width + "'>");
                            formatohtml += ("<font face='" + fonte.Name + "'>"
                                + celula.FormattedValue.ToString() + "</font>");
                            formatohtml += ("</td>");
                        }
                    }
                    formatohtml += ("</tr>");
                }
            }
            formatohtml += ("</table></div></body></html>");

            formatohtml += ("<br>");
            formatohtml += ("<br>");
            formatohtml += ("<hr />");
            formatohtml += ("<br>");
            formatohtml += ("<br>");

            return formatohtml;
        }
        private void barraDeLedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter(Environment.CurrentDirectory + "\\Relatorio\\BaraLed.html");
                arquivo.WriteLine(CriarRelatorioBarraLed());
                arquivo.Flush();
                arquivo.Close();

                DialogResult Pergunta = MessageBox.Show("ARQUIVO GERADO COM SUCESSO, DESEJA VISUALIZAR O ARQUIVO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (Pergunta == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\Relatorio\\BaraLed.html");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
