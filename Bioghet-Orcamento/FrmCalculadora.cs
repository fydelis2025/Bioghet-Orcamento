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
    public partial class FrmCalculadora : Form
    {
        public string no1, constfun;
        public bool inputstatus;

        private void Button31_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            textBox1.Text = (no1.Substring(0, n - 1));
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            
            if (radioButton3.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            //radianos
            if (radioButton3.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Cos(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }

            //graus
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            //radianos
            if (radioButton3.Checked == true)
            {

                textBox1.Text = Convert.ToString(System.Math.Tan(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            //graus
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Asin(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Asin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Acos(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Acos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Atan(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Atan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592654";
        }

        private void Button39_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = "";
            inputstatus = false;
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            inputstatus = true;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Text = "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button1.Text;
            }
            else
            {
                textBox1.Text = button1.Text;
                inputstatus = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button2.Text;
            }
            else
            {
                textBox1.Text = button2.Text;
                inputstatus = true;
            }
        }

        private void funcal()
        {
            switch (constfun)
            {
                case "+":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(no1) + Convert.ToDouble(textBox1.Text));

                    break;
                case "-":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(no1) - Convert.ToDouble(textBox1.Text));

                    break;
                case "*":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(no1) * Convert.ToDouble(textBox1.Text));
                    break;
                case "/":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "infinito";
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(Convert.ToDouble(no1) / Convert.ToDouble(textBox1.Text));
                    }
                    break;
                case "x^y":
                    textBox1.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(no1), Convert.ToDouble(textBox1.Text)));
                    break;
                case "mod":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(no1) % Convert.ToDouble(textBox1.Text));
                    break;
                case "nPr":
                    Double varn, var2, var3;                      //declara variaveis
                    varn = factorial(Convert.ToSingle(no1));    //chama funcão factorial
                    var2 = factorial(Convert.ToSingle(no1) - Convert.ToSingle(textBox1.Text));
                    textBox1.Text = Convert.ToString(varn / var2);
                    break;
                case "nCr":
                    varn = factorial(Convert.ToSingle(no1));
                    var2 = factorial(Convert.ToSingle(no1) - Convert.ToSingle(textBox1.Text));
                    var3 = factorial(Convert.ToSingle(textBox1.Text));
                    textBox1.Text = Convert.ToString(varn / (var3 * var2));
                    break;
            }
        }

        //funcao para calcular o factorial
        private Single factorial(Single x)
        {
            Single i = 1;
            for (Single s = 1; s <= x; s++)
            {
                i = i * s;
            }
            return i;
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            funcal();
            inputstatus = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "+";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "-";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button8.Text;
            }
            else
            {
                textBox1.Text = button8.Text;
                inputstatus = true;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button7.Text;

            }
            else
            {
                textBox1.Text = button7.Text;
                inputstatus = true;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button6.Text;

            }
            else
            {
                textBox1.Text = button6.Text;
                inputstatus = true;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button11.Text;
            }
            else
            {
                textBox1.Text = button11.Text;
                inputstatus = true;
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button12.Text;
            }
            else
            {
                textBox1.Text = button12.Text;
                inputstatus = true;
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button13.Text;

            }
            else
            {
                textBox1.Text = button13.Text;
                inputstatus = true;
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "*";
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "/";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button18.Text;
            }
            else
            {
                textBox1.Text = button18.Text;
                inputstatus = true;
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button17.Text;
            }
            else
            {
                textBox1.Text = button17.Text;
                inputstatus = true;
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button16.Text;
            }
            else
            {
                textBox1.Text = button16.Text;
                inputstatus = true;
            }
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            Single var1 = 1;
            Single valor = Convert.ToSingle(textBox1.Text);
            for (int i = 1; i <= valor; i++)
            {
                var1 = var1 * i;
            }
            textBox1.Text = Convert.ToString(var1);
            inputstatus = false;
        }

        private void Button37_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "nPr";
        }

        private void Button38_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "nCr";
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text));
            inputstatus = false;
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text));
            inputstatus = false;
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "x^y";
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(-Convert.ToInt32(textBox1.Text));
            inputstatus = false;
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "mod";   
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text)));
            inputstatus = false;
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            inputstatus = false;
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Log(Convert.ToDouble(textBox1.Text)));
            inputstatus = false;
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Log10(Convert.ToDouble(textBox1.Text)));
            inputstatus = false;
        }

        public FrmCalculadora()
        {
            InitializeComponent();

            no1 = "";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.Yes;
            radioButton1.Checked = true;
        }
    }
}
