using System;
using System.Windows.Forms;

namespace Solucao_Calculadora
{
    public partial class FrmTela_Login : Form
    {
       
        public FrmTela_Login()
        {
            InitializeComponent();
        }

        //public static int limitador = 0;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //if (limitador == 0)
            //{
                if ((txtUsuario.Text.Equals("admin")&& txtSenha.Text.Equals(""))
                  || txtUsuario.Text.Equals("gabriel") && txtSenha.Text.Equals("123")
                  || txtUsuario.Text.Equals("rodrigo") && txtSenha.Text.Equals("123"))
                {
                    //limitador++;
                    FrmMenu_Exercicios objCalc = new FrmMenu_Exercicios();
                    objCalc.Show();

                    objCalc.UpdateStatusLabel(txtUsuario.Text); //muda o nome do Usuario logado

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario ou senha errado, tente novamente",
                                    "Opa!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
           // }
           // else
            //    MessageBox.Show("Usuario já esta logado!");
        }

        private void telaLogin_FormClosing(object sender, FormClosingEventArgs e) // Botao vermelho de fechar 
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = System.Drawing.Color.LightGreen;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = System.Drawing.Color.White;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = System.Drawing.Color.LightGreen;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = System.Drawing.Color.White;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 8)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras ou numeros",
                                "Calma ae meu nobre!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}


