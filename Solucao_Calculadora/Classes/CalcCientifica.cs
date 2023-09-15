using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_CalculadoraOrientada_a_Objetos.Classes
{
    public class CalcCientifica:CalculadoraBásica
    {
        public string Comparar(decimal a, decimal b)
        {
            //lógica de comparação
            if (a > b)
            {
                string texto = $"{a} é maior que {b}";
                return texto;
            }
            else if (a < b)
            {
                string texto = $"{a} é menor que {b}";
                return texto;
            }
            else
            {
                string texto = $"Os Numeros são iguais";
                return texto;
            }
        }
        public string Par_Impar()
        {
            ////string texto = "";
            //////Lógica de análise de impar e par;
            //return texto;

            //decimal vResp = Num1 % 2;
            //decimal vResp2 = Num2 % 2;
            decimal vResp = Num1 % 2;
            decimal vResp2 = Num2 % 2;
            string texto = "";
            if (vResp == 0 && vResp2 == 0)
            {
                string resposta = $"Os dois numeros são Pares";
                return resposta;
            }
            else if (vResp != 0 && vResp2 != 0)
            {
                string resposta = $"Os dois numeros são Impares";
                return resposta;
            }
            else if (vResp == 0 && vResp2 != 0)
            {
                string resposta = $"{Num1} é Par e {Num2} é Impar";
                return resposta;
            }
            else if (vResp != 0 && vResp2 == 0)
            {
                string resposta = $"{Num1} é Impar e {Num2} é Par";
                return resposta;
            }
            return texto;

        }
        public string Potenciacao()
        {
            // Lógica de fazer potenciação
            return Math.Pow(Convert.ToDouble(Num1), Convert.ToDouble(Num2)).ToString();

        }

        public string Potenciacao(decimal a, decimal b)
        {
            // Lógica de fazer potenciação
            return Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b)).ToString();

        }
    }
}
