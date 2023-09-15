using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucao_Calculadora
{
    public partial class FrmCalc_Botao : Form
    {
        public FrmCalc_Botao() 
        {
            InitializeComponent(); //Inicia a Instância = Abri a Calculadora
            ControlBox = false; // Remove os Botoes Min,Max e Fechar.
        }

        private void Button1_Click(object sender, EventArgs e) // Botão Somar
        {
            double a, b;
            try { 
            lblSinal.Text = "+";

            a = double.Parse(TxtN1.Text);
            b = Convert.ToDouble(TxtN2.Text);
            lblResultado.Text = (a + b).ToString();
            } catch (FormatException)
            {
                lblResultado.Text = ("Não foi possivel efetuar sua conta"); 
            }
        }

        private void Button5_Click(object sender, EventArgs e) //Botão Dividir
        {
            try
            {
                double a, b;

                lblSinal.Text = ":";

                a = double.Parse(TxtN1.Text);
                b = Convert.ToDouble(TxtN2.Text);

                if (b == 0) //validação do Divisor, caso for 0 inicia este bloco.
                {
                    throw new DivideByZeroException(); // declaração throw ou throw statement: força o programa iniciar o Bloco catch com a Exceção associada.
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

        private void Button6_Click(object sender, EventArgs e) //Botão Fechar
        {
            Close();
                                           
            FrmMenu_Exercicios.limitador = 0;  //Esta linha de codigo especifica busca a variavel "limitacao" declarada no frmMenuMDINovo;

                                          // Ao fechar reseta o conteudo da Variavel para 0,
                                          // assim habilitando para abrir novamente a Calculadora.
        }

        private void Button2_Click(object sender, EventArgs e) //Botão Subtrair
        {
            double a, b;

            lblSinal.Text = "-";

            a = double.Parse(TxtN1.Text);
            b = Convert.ToDouble(TxtN2.Text);
            lblResultado.Text = (a - b).ToString();
        }

        private void Button3_Click(object sender, EventArgs e) //Botão Multiplicar
        {
            double a, b;

            lblSinal.Text = "x";

            a = double.Parse(TxtN1.Text);
            b = Convert.ToDouble(TxtN2.Text);
            lblResultado.Text = (a * b).ToString();
        }

        private void Button4_Click(object sender, EventArgs e) // Botão Limpar
        {
            TxtN1.Clear();
            TxtN2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "";
            TxtN1.Focus(); //depois que apertar ele volta pro N1
        }
    }
    }
  

