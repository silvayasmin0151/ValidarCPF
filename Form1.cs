using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidarCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bt_checarCPF_Click(object sender, EventArgs e)
        {
            string cpf = textBox_CPF.Text, cpf2, msg;
            int i, j= 0, num, soma = 0, mult, res, res2, digito1, digito2;
            mult = 10;
            bool valido = true;
           
            if(cpf.Length != 11)
            {
                resultado.ForeColor = Color.Black;
                resultado.Visible = true;
                msg = "Informe o CPF\ncorretamente!";
                resultado.Text = msg.ToString();
            }
            else
            {
                for(i = 0; i <= 8; i++)
                {
                    if (textBox_CPF.Text == "" || !char.IsDigit(cpf, i))
                    {
                        valido = false;
                        break;
                    }
                }
                if (valido)
                {
                    for (i = 0; i <= 8; i++)
                    {
                        num = Convert.ToInt16(cpf.Substring(i, 1));
                        soma += num * mult;
                        mult -= 1;

                    }
                    //calcular o resto
                    res = soma % 11;
                    //calcular o primeiro digito verificador
                    digito1 = 11 - res;

                    if (digito1 >= 10)
                    {
                        digito1 = 0;
                    }
                    soma = 0;
                    cpf2 = cpf + digito1.ToString();//incluir o digito 1 no cpf
                    mult = 11;
                    for (i = 0; i <= 9; i++)
                    {
                        num = Convert.ToInt16(cpf2.Substring(i, 1));
                        soma += num * mult;
                        mult -= 1;
                    }
                    //calcular o resto
                    res2 = soma % 11;
                    //calcular o digito verificador 2
                    digito2 = 11 - res2;
                    if (digito2 >= 10)
                    {
                        digito2 = 0;
                    }
                    //comparar o resultado do digito 1 e digito 2 com os digitos do cpf
                    char d1, d2;
                    d1 = cpf.ToString()[9];
                    d2 = cpf.ToString()[10];

                    if (d1.ToString() == digito1.ToString() & d2.ToString() == digito2.ToString())
                    {
                        resultado.Visible = true;
                        resultado.ForeColor = Color.Green;
                        msg = $"O CPF {cpf}\né valido!";
                        resultado.Text = msg.ToString();
                    }
                    else
                    {
                        resultado.Visible = true;
                        resultado.ForeColor = Color.Red;
                        msg = $"o CPF {cpf}\né invalido";
                        resultado.Text = msg.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Digite apenas números!");
                }
            }

        }

    }
}
