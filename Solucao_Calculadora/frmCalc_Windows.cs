using System;
using System.Windows.Forms;

namespace Solucao_Calculadora
{
    public partial class frmCalc_Windows : Form
    {
        public frmCalc_Windows()
        {
            InitializeComponent();
            ControlBox = false; // Desabilita os Botoes Minimizar, Maximizar e Fechar.
        }
        decimal numAnt;
        string operacao;
        bool ehPraLimpar = false;

        private void button17_Click(object sender, EventArgs e) // Botão Fechar
        {
            Close();
            FrmMenu_Exercicios.limitador = 0; //Esta linha especifica busca a variavel "limitador" declarada no Menu_Exercicio;
                                          // Ao fechar reseta o conteudo da Variavel para 0,
                                          // assim habilitando para abrir novamente a Calculadora.
        }
        public void f_Numero(object sender, EventArgs e) //Função criada para os botoes que estão na esquerda
        {
            string vNumero = ((Button)sender).Text; //a variavel irá receber o texto do Botão clicado.

            if (ehPraLimpar) //destrava o botao de limpar "C".
            {
                lblVisor.Text = "";
                ehPraLimpar = false;
            }
            if (lblVisor.Text == "0") { lblVisor.Text = ""; }

            if ((vNumero == "," && !lblVisor.Text.Contains(",")) || vNumero != ",") // tratar a virgula
            {
                lblVisor.Text += vNumero; // concatena o numero ao visor.
            }
             //   if (lblVisor.Text == "0") //Se for zero ele limpa
             //   {
             //       lblVisor.Text = ""; //limpa aqui
             //}
             //  lblVisor.Text += (sender as Button).Text; //Aqui ele só trata como botão

            //   if (lblVisor.Text == "0") lblVisor.Text = "";

            //   if (lblVisor.Text == "," && !lblVisor.Text.Contains == ",")
            //  {

            //   }
        }
        private void BtnIgual_Click(object sender, EventArgs e) //Botão igual.
        {
            decimal numAtual = decimal.Parse(lblVisor.Text);
            switch(operacao)
            {
                case "+":
                    {
                        lblVisor.Text = (numAnt + numAtual).ToString();
                        break;
                    }
                case "-":
                    {
                        lblVisor.Text = (numAnt - numAtual).ToString();
                        break;
                    }
                case "x":
                    {
                        lblVisor.Text = (numAnt * numAtual).ToString();
                        break;
                    }
                case ":":
                    {
                        lblVisor.Text = (numAnt / numAtual).ToString();
                        break;
                    }
            }
            lblVisor.Focus();
        }

        private void Calc_Windows_KeyDown(object sender, KeyEventArgs e) //Função criada para poder usar os botões do Teclado fisico.
        {
            Button bot = new Button(); //criando botão via codigo

            if (e.Control == true) // se CTRL for pressionado
            {

            }
            if (e.Shift == true) // se o SHIFT for pressionado
            {

            }
            if (e.Alt == true) // se o ALT for pressionado
            {

            }

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            {
                bot.Text = e.KeyCode.ToString().Substring(1);
                f_Numero(bot, e);
            }
            //if((e.KeyCode < Keys.NumPad0  e.KeyCode > Keys.NumPad9))
            //{
            //    bot.Text = e.KeyCode.ToString().Substring(7);
            //    f_Numero(bot, e);
            //}
            switch (e.KeyCode.ToString())
            {
                case "Add": //caso adição ( + )
                    {
                        bot.Text = "+";
                        f_Operacao(bot, e);
                        return;
                    }
                case "Substract": //caso Subtração ( - )
                    {
                        bot.Text = "-";
                        f_Operacao(bot, e);
                        return;
                    }
                case "Multiply": //caso Multiplicação ( x usar *)
                    {
                        bot.Text = "x";
                        f_Operacao(bot, e);
                        return;
                    }
                case "Divide": //caso Divisão ( : usar / )
                    {
                        bot.Text = ":";
                        f_Operacao(bot, e);
                        return;
                    }
            }

            if(e.KeyCode == Keys.Enter)
            {
                BtnIgual_Click(bot, e);
            }
        }

        private void f_Operacao(object sender, EventArgs e) //Função criada para os botões das operações aritmeticas.
        {
            operacao = ((Button)sender).Text;
            numAnt = decimal.Parse(lblVisor.Text);
            lblHistorico.Text += $"{numAnt}{operacao}";
            ehPraLimpar = true;
            lblVisor.Focus();
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            if(lblVisor.Text == "")
            {
                lblVisor.Text = "0";
            }
        }

        private void btnInverteSinal_Click(object sender, EventArgs e)
        {
            lblVisor.Text = (decimal.Parse(lblVisor.Text) * -1).ToString();
        }

        private void lblHistorico_Click(object sender, EventArgs e)
        {
            //Historico = f_Numero as sender ;
        }

        private void btnLimpar_Click(object sender, EventArgs e) //Botão C (Clear)
        {
            lblVisor.Text = "0";
            //lblHistorico.Text = "";
        }

        private void btnLimparTudo_Click(object sender, EventArgs e) //Botão CE ( Clear Everything)
        {
            lblVisor.Text = "0";
            lblHistorico.Text = "";
            ehPraLimpar = false;
        }

        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
    }
}
