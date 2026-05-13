using Bioghet_Orcamento.Classes;
using MySql.Data.MySqlClient;
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
    public partial class FormExtorno : Form
    {
        public FormExtorno()
        {
            InitializeComponent();
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrWhiteSpace(TxCupom.Text))
                {
                    List<Classes.Bioghet_RelatorioVendas> Listar_venda = Classes.Bioghet_ConsultaMysql.Listar_RelatorioVendasCupomC(Int32.Parse(TxCupom.Text));

                    String[] Param = new String[5];
                    DgVenda.Rows.Clear();

                    for(int i = 0; i < Listar_venda.Count; i++)
                    {
                        Param[0] = Listar_venda[i].ID.ToString();
                        Param[1] = Listar_venda[i].Descricao.ToUpper();
                        Param[2] = Listar_venda[i].Quantidade.ToString();
                        Param[3] = Listar_venda[i].Valor.ToString("#####0.00");
                        Param[4] = Listar_venda[i].Total.ToString("#####0.00");

                        DgVenda.Rows.Add(Param);
                    }

                    Decimal Total = 0;

                    foreach(DataGridViewRow  Coluna in DgVenda.Rows)

                    {
                        Decimal Valor = Convert.ToDecimal(Coluna.Cells[4].Value.ToString());

                        Total = Decimal.Add(Total, Valor);
                    }

                    TxTotal.Text = Total.ToString("#####0.00");

                    String CPF = Classes.Bioghet_ConsultaMysql.Consultar_CPFNota(Int32.Parse(TxCupom.Text));

                    if (!String.IsNullOrWhiteSpace(CPF))
                    {
                        TxCPF.Text = CPF;
                    }
                    else
                    {
                        throw new Exception("CPF NÃO INCLUSO NA NOTA");
                    }
                }
                else
                {
                    throw new Exception("CUPOM NÃO ENCONTRADO");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RdTotal_Click(object sender, EventArgs e)
        {
            DgVenda.Enabled = false;
        }

        private void RdParcial_Click(object sender, EventArgs e)
        {
            DgVenda.Enabled = true;
        }

        private void DgVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(5))
                {

                    TxCredito.Text = DgVenda.CurrentRow.Cells[3].Value.ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtExtornar_Click(object sender, EventArgs e)
        {
            try
            {
                if(RdTotal.Equals(true))
                {

                    DialogResult _pergunta = MessageBox.Show("DESEJA REALMENTE EXTORNAR A VENDA DO CUPOM ==>" + TxCupom.Text, "EXTORNAR VENDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (_pergunta == DialogResult.Yes)
                    {
                        int retorno = Classes.Bioghet_DeleteMYSQL.Extornar_Venda(Int32.Parse(TxCupom.Text), "VC");

                        if (retorno.Equals(1))
                        {
                            Realsoft_POS58.Printer_Pos58e pos = new Realsoft_POS58.Printer_Pos58e();

                            String Parametro = "          BIOGHET TECNOLOGIA" + Environment.NewLine;

                            Classes.Bioghet_Empresa _empresa = Classes.Bioghet_ConsultaMysql.Consultar_DadosFilial(int.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "empresa", "")));

                            Parametro += "LOJA: ".PadLeft(15) + _empresa.RazaoSocial.PadLeft(5, ' ') + Environment.NewLine;
                            Parametro += "CNPJ: ".PadLeft(15, ' ') + _empresa.CNPJ.PadLeft(5, ' ') + Environment.NewLine;
                            Parametro += "TELEFONE: ".PadLeft(15) + _empresa.Telefone.PadLeft(5, ' ') + " / " + _empresa.Celular.PadLeft(5, ' ') + Environment.NewLine;
                            Parametro += "-------------------------------------" + Environment.NewLine;
                            Parametro += "Comprovante de Extorno de produto" + Environment.NewLine;
                            Parametro += "Recibo de Comprovante".PadLeft(25, ' ') + Environment.NewLine;
                            Parametro += "------------------------------------------" + Environment.NewLine;
                            Parametro += "Dados do Cliente".PadLeft(25, ' ') + Environment.NewLine;
                            Parametro += "------------------------------------------" + Environment.NewLine;
                            Parametro += "Nome:     " + TxNome.Text + Environment.NewLine;
                            Parametro += "CPF:       " + TxCPF.Text + Environment.NewLine;
                            Parametro += "RG:       " + TxRG.Text + Environment.NewLine;
                            Parametro += "Telefone: " + TxTelefone.Text + Environment.NewLine;
                            Parametro += "------------------------------------------" + Environment.NewLine;
                            Parametro += "Motivo da devolução".PadLeft(25, ' ') + Environment.NewLine;
                            Parametro += "------------------------------------------" + Environment.NewLine;
                            Parametro += Environment.NewLine;

                            Parametro += TxMotivo.Text + Environment.NewLine;

                            Parametro += Environment.NewLine;
                            Parametro += "Salvador, Ba " + DateTime.Now.ToString("dd-MM-yy");
                            Parametro += Environment.NewLine;
                            Parametro += "Obs. Crédito " + TxCredito.Text + " válido por 30 dias";
                            Parametro += Environment.NewLine;
                            Parametro += "------------------------------------------" + Environment.NewLine;

                            pos.charFontBText("POS-58-Series");
                            pos.printText("POS-58-Series", Parametro);

                            MessageBox.Show("VENDA EXTORNADA COM SUCESSO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("NÃO FOI POSSÍVEL REALIZAR O EXTORNO, FAVOR VERIFIQUE E TENTE NOVAMENTE");
                        }
                    }
                }

                if (RdParcial.Equals(true))
                {

                    int retorno = Classes.Bioghet_DeleteMYSQL.Extornar_VendaParcial(Int32.Parse(TxCupom.Text), "VC",Int32.Parse(DgVenda.CurrentRow.Cells[0].Value.ToString()));

                    if (retorno.Equals(1))
                    {
                        Realsoft_POS58.Printer_Pos58e pos = new Realsoft_POS58.Printer_Pos58e();

                        String Parametro = "          BIOGHET TECNOLOGIA" + Environment.NewLine;

                        Classes.Bioghet_Empresa _empresa = Classes.Bioghet_ConsultaMysql.Consultar_DadosFilial(int.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "empresa", "")));

                        Parametro += "LOJA: ".PadLeft(15) + _empresa.RazaoSocial.PadLeft(5, ' ') + Environment.NewLine;
                        Parametro += "CNPJ: ".PadLeft(15, ' ') + _empresa.CNPJ.PadLeft(5, ' ') + Environment.NewLine;
                        Parametro += "TELEFONE: ".PadLeft(15) + _empresa.Telefone.PadLeft(5, ' ') + " / " + _empresa.Celular.PadLeft(5, ' ') + Environment.NewLine;
                        Parametro += "-------------------------------------" + Environment.NewLine;
                        Parametro += "Comprovante de Extorno de produto" + Environment.NewLine;
                        Parametro += "Recibo de Comprovante".PadLeft(25, ' ') + Environment.NewLine;
                        Parametro += "------------------------------------------" + Environment.NewLine;
                        Parametro += "Dados do Cliente".PadLeft(25, ' ') + Environment.NewLine;
                        Parametro += "------------------------------------------" + Environment.NewLine;
                        Parametro += "Nome:     " + TxNome.Text + Environment.NewLine;
                        Parametro += "CPF:       " + TxCPF.Text + Environment.NewLine;
                        Parametro += "RG:       " + TxRG.Text + Environment.NewLine;
                        Parametro += "Telefone: " + TxTelefone.Text + Environment.NewLine;
                        Parametro += "------------------------------------------" + Environment.NewLine;
                        Parametro += "Motivo da devolução".PadLeft(25, ' ') + Environment.NewLine;
                        Parametro += "------------------------------------------" + Environment.NewLine;
                        Parametro += Environment.NewLine;

                        Parametro += TxMotivo.Text + Environment.NewLine;

                        Parametro += Environment.NewLine;
                        Parametro += "Salvador, Ba " + DateTime.Now.ToString("dd-MM-yy");
                        Parametro += Environment.NewLine;
                        Parametro += "Obs. Crédito " + TxCredito.Text + " válido por 30 dias";
                        Parametro += Environment.NewLine;
                        Parametro += "------------------------------------------" + Environment.NewLine;

                        pos.charFontBText("POS-58-Series");
                        pos.printText("POS-58-Series", Parametro);

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

        private void TxCupom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void TxCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }
    }
}
