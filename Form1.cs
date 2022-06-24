using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operacao = "";
        string total;
        Nullable<double> number1 = null, number2 = null;
        //nullable = tipo de valor que pode ser anulado (não é 0, é nulo)
        //válido para as variaveis double number1 e number2 | Coloquei pq com 0 estava dando erro

        private void numeros(string numeros) //função criada para os botões de número para salvar/guardar a primeira variavel e esperar (ou nao) a segunda
        {
            if (number1 != null && number2 == null)
            {
                txtResultado.Text = "";
            }

            txtResultado.Text += numeros;

            if (number1 != null && operacao != "")
            {
                number2 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            }
        }
        
        private void calcular() //COM AS OPERAÇÕES QUE ACONTECERÃO NO BOTÃO "="
        {
            if (number1 != null && number2 != null)
            {
                //CONDIÇÕES PARA FUNCIONAR IGUAL A CALCULADORA
                //usada para que possa ter ou não o segundo número
                if (operacao == "SOMA")
                {
                    txtResultado.Text = Convert.ToString(number1 + number2);
                }
                else if (operacao == "SUB")
                {
                    txtResultado.Text = Convert.ToString(number1 - number2);
                }
                else if (operacao == "MULT")
                {
                    txtResultado.Text = Convert.ToString(number1 * number2);
                }
                else if (operacao == "DIV")
                {
                    txtResultado.Text = Convert.ToString(number1 / number2);
                }
                else if (operacao == "PORC")
                {

                }
            }

            if (operacao == "PORC" && number2 == null)
            {
                if (operacao == "PORC")
                {
                    txtResultado.Text = Convert.ToString(number1 * 0.01);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //txtResultado.Text = "2";
            numeros("2");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //txtResultado.Text = "3";
            numeros("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //txtResultado.Text = "4";
            numeros("4");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //txtResultado.Text = "5";
            numeros("5");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //txtResultado.Text = "6";
            numeros("6");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtResultado.Text = "7";
            numeros("7");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //txtResultado.Text = "8";
            numeros("8");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //txtResultado.Text = "9";
            numeros("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            //txtResultado.Text = "";
            operacao = "MULT";
            lblOperacao.Text = "*";
            calcular(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            //txtResultado.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";
            calcular();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            //txtResultado.Text = "";
            operacao = "SUB";
            lblOperacao.Text = "-";
            calcular();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            //txtResultado.Text = "";
            operacao = "DIV";
            lblOperacao.Text = "/";
            calcular();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            //txtResultado.Text = "";
            operacao = "PORC";
            lblOperacao.Text = "%";
            calcular();
        }

        private void button19_Click(object sender, EventArgs e) //=
        {
            calcular(); //APENAS CHAMA A FUNÇÃO COM A ORDEM DOS ACONTECIMENTOS IGUAL DA CALCULADORA
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //txtResultado.Text = "1"; 
            numeros("0");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text = ".";
        }

        private void button16_Click(object sender, EventArgs e) //BOTAO CE
        {
            txtResultado.Text = "";
            number1 = null;
            number2 = null;
            lblOperacao.Text = "";
        }

        private void button17_Click(object sender, EventArgs e) //BOTAO C
        {
            txtResultado.Text = "";
            number2 = null;
            lblOperacao.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //txtResultado.Text += "1";
            numeros("1");
        }
    }
}
