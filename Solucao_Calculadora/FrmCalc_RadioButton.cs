using System;
using System.Windows.Forms;

namespace Solucao_Calculadora
{
    public partial class FrmCalc_RadioButton : Form
    {
        public FrmCalc_RadioButton()
        {
            InitializeComponent();
            ControlBox = false; // Desabilita os Botoes Minimizar, Maximizar e Fechar.
        }
        private void Button3_Click(object sender, EventArgs e) // Botão Fechar
        {
            Close();
            FrmMenu_Exercicios.limitador = 0; //Esta linha espefica busca a variavel "limitador" declarada no frmMenuMDINovo;
                                          // Ao fechar reseta o conteudo da Variavel para 0,
                                          // assim habilitando para abrir novamente a Calculadora.
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e) // Adição
        {
            lblSinal.Text = "+"; //muda a operação aritmetica usada;
        }
        private void RadioButton2_CheckedChanged(object sender, EventArgs e) // Subtração
        {
            lblSinal.Text = "-"; //muda a operação aritmetica usada;
        }
        private void RadioButton4_CheckedChanged(object sender, EventArgs e) // Multiplicação
        {
            lblSinal.Text = "x"; //muda a operação aritmetica usada;
        }
        private void RadioButton3_CheckedChanged(object sender, EventArgs e) // Divisão
        {
            lblSinal.Text = ":"; //muda a operação aritmetica usada;
        }
        private void RadioButton5_CheckedChanged(object sender, EventArgs e) // Potenciação
        {
            lblSinal.Text = "^"; //muda a operação aritmetica usada;
        }
        private void button1_Click(object sender, EventArgs e) //Botão Calcular.
        {
            double a, b;

            if (radioButton1.Checked)// função Somar
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    lblResultado.Text = (a + b).ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Não foi possivel efetuar sua conta");
                }
            }

            else if (radioButton2.Checked)//função Subtrair
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    lblResultado.Text = (a - b).ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Não foi possivel efetuar sua conta");
                }
            }

            else if (radioButton3.Checked) //função Dividir
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);

                    if (b == 0)//validação do Divisor, caso for 0 inicia este bloco.
                    {   
                                                          // declaração throw ou throw statement:
                        throw new DivideByZeroException();// força o programa iniciar o Bloco catch com
                                                          // a Exceção associada.

                    }

                    lblResultado.Text = (a / b).ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Digite apenas números");
                }

                catch (DivideByZeroException)
                {
                    MessageBox.Show("Impossivel dividir por zero");
                }
            }

            else if (radioButton4.Checked) //função Multiplicar
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    lblResultado.Text = (a * b).ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Não foi possivel efetuar sua conta");
                }

            }

            else if (radioButton5.Checked) //função Potenciação
            {
                try
                {
                    a = double.Parse(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    lblResultado.Text = Math.Pow(a, b).ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Não foi possivel efetuar sua conta");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e) //Botão Limpar
        {
            textBox1.Clear();
            textBox2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "";
            textBox1.Focus(); //depois que apertar ele volta pro N1
        }
    }
}

