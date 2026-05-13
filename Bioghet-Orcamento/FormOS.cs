using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bioghet_Orcamento
{
    public partial class FormOS : Form
    {
        public FormOS()
        {
            InitializeComponent();
        }

        private Bioghet_OS _bioghetos = null;
        List<String> Lista = new List<String>();
        Random numero = new Random();
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOS_Load(object sender, EventArgs e)
        {
            try
            {
                //_bioghetos = null;

                //int codigo =  Mysql.Consulta.Consultar_ProximoID();
                TxOS.Text = numero.Next(9999).ToString();

                CbFilial.Text = Classes.Bioghet_ConsultaMysql.Consultar_RazaoSocial(Int32.Parse(Ini.GetIniString(Ini.nomeArquivoINI(), "geral", "empresa", "")));

               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            try
            {
                //_bioghetos = null;
                BtSalvar.Enabled = true;
                //int codigo = Mysql.Consulta.Consultar_ProximoID();
                TxOS.Text = TxOS.Text = numero.Next(9999).ToString();
                TxCliente.ResetText();
                TxCpf.ResetText();
                TxTelefone.ResetText();
                TxTipo.ResetText();
                TxMarca.ResetText();
                TxModelo.ResetText();
                TxDefeito.ResetText();
                TxObs.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (_bioghetos == null)
                {
                    _bioghetos = new Bioghet_OS();

                    _bioghetos.OS = int.Parse(TxOS.Text);
                    _bioghetos.Nome = TxCliente.Text;
                    _bioghetos.Cpf = TxCpf.Text;
                    _bioghetos.Telefone = TxTelefone.Text;
                    _bioghetos.Tipo = TxTipo.Text;
                    _bioghetos.Marca = TxMarca.Text;
                    _bioghetos.Modelo = TxModelo.Text;
                    _bioghetos.OBS = TxObs.Text;
                    _bioghetos.Defeito = TxDefeito.Text;
                    _bioghetos.Imei = TxImei.Text;

                    if (CbFilial.Text.Equals("TELECENTRO JAPONES"))
                    {
                        _bioghetos.Filial = 1;
                    }
                    else if (CbFilial.Text.Equals("BIOGHET PITUBA"))
                    {
                        _bioghetos.Filial = 2;
                    }
                    else
                    {
                        _bioghetos.Filial = 3;
                    }

                    Classes.Bioghet_InserirMYSQL.Criar_OrdemdeServico(_bioghetos);
                    MessageBox.Show("Ordem de serviço criado com sucesso");


                    BtSalvar.Enabled = false;
                }
                else
                {
                    _bioghetos.OS = int.Parse(TxOS.Text);
                    _bioghetos.Nome = TxCliente.Text;
                    _bioghetos.Cpf = TxCpf.Text;
                    _bioghetos.Telefone = TxTelefone.Text;
                    _bioghetos.Tipo = TxTipo.Text;
                    _bioghetos.Marca = TxMarca.Text;
                    _bioghetos.Modelo = TxModelo.Text;
                    _bioghetos.OBS = TxObs.Text;
                    _bioghetos.Defeito = TxDefeito.Text;
                    _bioghetos.Imei = TxImei.Text;

                    if (CbFilial.Text.Equals("TELECENTRO JAPONES"))
                    {
                        _bioghetos.Filial = 1;
                    }
                    else if (CbFilial.Text.Equals("BIOGHET PITUBA"))
                    {
                        _bioghetos.Filial = 2;
                    }
                    else
                    {
                        _bioghetos.Filial = 3;
                    }

                    if (Classes.Bioghet_Configuracao.StatusConexao.Equals(Classes.Bioghet_Configuracao.StatusInternet.OFFILINE.ToString()))
                    {
                        //Inserir.Criar_Orcamento(_bioghetos);
                    }
                    else
                    {
                        //ONLINE.Inserir.Criar_Orcamento(_bioghetos);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao._marca = Classes.Bioghet_ConsultaMysql.Listar_Marca(TxTipo.Text);

                TxMarca.Items.Clear();
                for (int m = 0; m < Classes.Bioghet_Configuracao._marca.Count; m++)
                {
                    TxMarca.Items.Add(Classes.Bioghet_Configuracao._marca[m].Descricao.ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Classes.Bioghet_Configuracao.CodigoMarca = Classes.Bioghet_ConsultaMysql.Consultar_IdMarca(TxMarca.Text, TxTipo.Text);
                Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_Modelo(Classes.Bioghet_Configuracao.CodigoMarca);
                

                TxModelo.ResetText();

                TxModelo.Items.Clear();

                for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                {
                    TxModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                }

                TxModelo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxModelo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TxModelo.Items.Clear();


                String _modelo = TxModelo.Text;
                Classes.Bioghet_Configuracao._modelo = Classes.Bioghet_ConsultaMysql.Listar_ModeloDigitado(_modelo.ToUpper());

                for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                {
                    TxModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                }

                TxModelo.DroppedDown = true;
            }
        }

        private void TxModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);

                    //TxModelo.Items.Clear();

                    //if (LbStatusInternet.Text.Equals(Classes.Bioghet_Configuracao.StatusInternet.OFFILINE.ToString()))
                    //{
                    //    String _modelo = e.KeyChar.ToString();
                    //    Classes.Bioghet_Configuracao._modelo = Listar.Listar_ModeloDigitado(_modelo.ToUpper());
                    //}
                    //else
                    //{
                    //    String _modelo = e.KeyChar.ToString();
                    //    Classes.Bioghet_Configuracao._modelo = ONLINE.Listar.Listar_ModeloDigitado(_modelo.ToUpper());
                    //}

                    //for (int i = 0; i < Classes.Bioghet_Configuracao._modelo.Count; i++)
                    //{
                    //    TxModelo.Items.Add(Classes.Bioghet_Configuracao._modelo[i].Descricao.ToUpper());
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxModelo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TxDefeito.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxDefeito_Click(object sender, EventArgs e)
        {
            try
            {
                TxDefeito.Items.Clear();

                Classes.Bioghet_Configuracao._Listardef = Classes.Bioghet_ConsultaMysql.Listar_Defeito(TxTipo.Text);

                for (int r = 0; r < Classes.Bioghet_Configuracao._Listardef.Count; r++)
                {
                    TxDefeito.Items.Add(Classes.Bioghet_Configuracao._Listardef[r].Descricao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void impressão1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao.campo = TxOS.Text;
                Classes.Bioghet_Configuracao.ImpOS = true;
                if (Classes.Bioghet_Configuracao.campo.Equals(String.Empty))
                {
                    throw new Exception("NÃO FOI POSSIVEL CARREGAR O RELATÓRIO FAVOR VERIFIQUE SE O ORÇAMENTO FOI GERADO");
                }
                else
                {

                    LbStatus.Text = Classes.Bioghet_Configuracao.Status.IMPRESSO.ToString();


                    Classes.Bioghet_Update.Atualizar_Status(LbStatus.Text, TxOS.Text);
                    

                    FormOrdemServico frm = new FormOrdemServico();

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void impressão2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Bioghet_Configuracao.campo = TxOS.Text;
                Classes.Bioghet_Configuracao.ImpOS = false;

                if (Classes.Bioghet_Configuracao.campo.Equals(String.Empty))
                {
                    throw new Exception("NÃO FOI POSSIVEL CARREGAR O RELATÓRIO FAVOR VERIFIQUE SE O ORÇAMENTO FOI GERADO");
                }
                else
                {

                    LbStatus.Text = Classes.Bioghet_Configuracao.Status.IMPRESSO.ToString();
                    Classes.Bioghet_Configuracao.ImpOS = false;


                    Classes.Bioghet_Update.Atualizar_Status(LbStatus.Text, TxOS.Text);
                   

                    FormOrdemServico frm = new FormOrdemServico();

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxCpf_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!String.IsNullOrWhiteSpace(TxTelefone.Text))
                    {
                        if (TxCpf.Text.Trim().Length == 11)
                        {
                            Boolean retorno = ValidarCampos.IsCpf(TxCpf.Text);

                            if (retorno.Equals(false))
                            {
                                throw new Exception("CPF INVALIDO");
                            }
                            else
                            {
                                TxTelefone.Focus();
                            }
                        }

                        if (TxCpf.Text.Trim().Length == 14)
                        {
                            Boolean retorno = ValidarCampos.IsCnpj(TxCpf.Text);

                            if (retorno.Equals(false))
                            {
                                throw new Exception("CNPJ INVALIDO");
                            }
                            else
                            {
                                TxTelefone.Focus();
                            }
                        }
                    }
                    else
                    {
                        TxTelefone.Focus();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChGerarImei_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChGerarImei.Checked.Equals(true))
                {
                    Random gerarimei = new Random();
                    TxImei.Text = gerarimei.Next(999999999).ToString();
                    String texto = "OBSERVAÇÃO: NÃO TIVEMOS ACESSO AO IMEI DO APARELHO," + Environment.NewLine;
                    texto += "EM RAZÃO DISSO GERAMOS O IMEI FICTÍCIO PARA CADASTRAR O APARELHO." + Environment.NewLine;
                    texto += "INFORMAMOS QUE A DIFICULDADE DE ACESSO AO IMEI É DE RESPONSÁBILIDADE DO CLIENTE" + Environment.NewLine;

                    //PWebcam.SizeMode = PictureBoxSizeMode.Normal;

                    //PWebcam.Image = ConverterTexto.CriarImagemBitMap(texto, "Arial", 10);
                }
                else
                {
                    TxImei.ResetText();
                    //PWebcam.SizeMode = PictureBoxSizeMode.StretchImage;

                    //PWebcam.Image = Image.FromFile(Environment.CurrentDirectory + "\\Fotos\\Nenhuma.jpg");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxTipo_Click(object sender, EventArgs e)
        {
            try
            {
                TxTipo.Items.Clear();
                Classes.Bioghet_Configuracao._servico = Classes.Bioghet_ConsultaMysql.Listar_TipoServico();
                for (int servico = 0; servico < Classes.Bioghet_Configuracao._servico.Count; servico++)
                {
                    TxTipo.Items.Add(Classes.Bioghet_Configuracao._servico[servico].Descricao.ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CbFilial_Click(object sender, EventArgs e)
        {
            try
            {
                List<Filial> Lista = Classes.Bioghet_ConsultaMysql.Listar_Filial();

                CbFilial.Items.Clear();
                for (int i = 0; i < Lista.Count; i++)
                {
                    CbFilial.Items.Add(Lista[i].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://web.whatsapp.com/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.consultaserialaparelho.com.br/public-web/homeSiga");
        }
    }
}
