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
    public partial class FrmMenu_Exercicios : Form
    {
        
        public FrmMenu_Exercicios()
        {
            InitializeComponent();
        }

        public static int limitador = 0; //Variavel "limitacao" declarada publica, para que assim possamos
                                         //manipula-la em outros Forms;
        private void CalculadoraComBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (limitador == 0) //Validação da variavel para que assim possamos abrir a calculadora normal;
            { 
                limitador++ ; //Ao abrir a Instancia acrescenta 1 unidade no "contador interno" da variavel,
                              //com isso bloqueia a abertura de novas Instancias(Janelas);

                FrmCalc_Botao objCalc = new FrmCalc_Botao();
                objCalc.MdiParent = this;
                objCalc.Show();
            }
            else //Caso o Usuario tente abrir novas janelas, esta mensagem irá aparecer;
            {
                MessageBox.Show("Uma Calculadora ja esta aberta!",
                                "Opa!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void CalculadoraBotãoRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (limitador == 0)
            {
                limitador++;
                FrmCalc_RadioButton frmCalcRadio = new FrmCalc_RadioButton();
            frmCalcRadio.MdiParent = this;
            frmCalcRadio.Show();
            }
            else
            {
                MessageBox.Show("Uma Calculadora ja esta aberta!",
                                "Opa!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void Calc_WindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (limitador == 0)
            {
                limitador++;
                frmCalc_Windows calc_Windows= new frmCalc_Windows();
                calc_Windows.MdiParent = this;
                calc_Windows.Show();
            }
            else
            {
                MessageBox.Show("Uma Calculadora ja esta aberta!",
                                "Opa!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void frmMenuMDINovo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            //telaLogin form = new telaLogin();
            //form.Show();
            //telaLogin.limitador = 0;
            
        }

        private void trocarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTela_Login form = new FrmTela_Login();
            form.Show();
            this.Hide();
        }

        public void UpdateStatusLabel(string newtext) //Mostra qual o nome do usuario logado.
        {
            UsuarioLogado.Text = newtext;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (limitador == 0)
            {
                limitador++;
                FrmCalculadora_OrientadaObjeto calc_orientadaObjeto = new FrmCalculadora_OrientadaObjeto();
                calc_orientadaObjeto.MdiParent = this;
                calc_orientadaObjeto.Show();
            }
            else
            {
                MessageBox.Show("Uma Calculadora ja esta aberta!",
                                "Opa!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}
