using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace trabalho_final
{
    internal class Program
    {
        public static double[] motores = new double [14];
        public static string lancarGasto(double[]motor)
        {
            Console.WriteLine("informe o motor [1-15]");
            int indice = int.Parse(Console.ReadLine());
            if (indice > motor.Length || indice < 0)
            {
                Console.WriteLine("Motor não constado!");
            }
            else
            {
                Console.WriteLine("informe o valor gasto:");
                double valor = double.Parse(Console.ReadLine());
                motor[indice] = valor;
            }
            return "";  
        }
        public static double mostrarGastos(double[] motor, double total)
        {
            for(int ii = 0; ii < motor.Length; ii++)
            {
                total += motor[ii];
            }
            Console.WriteLine("O total é: R$" + total);
            return total;
        }
        public static string maiorGasto(double[] motor, double maiorvalor)
        {
            int maior = 0;
            for (int ii = 0; ii < (motor.Length); ii++)
            {
                if (motor[maior] < motor[ii])
                {
                    maior = ii;
                    maiorvalor = motor[maior];
                }
            }
            Console.WriteLine("O motor " + maior + " gastou mais: R$" + maiorvalor);
            return "";
        }



        static void Main(string[] args)

        {
            int seletor = 1;
            double total = 0;
            double maiorvalor = 0;
            Console.WriteLine("Escolha uma opção:\n 0 - sair\n 1 - lançar\n 2 - total\n 3 - maior gasto");
            while (seletor != 0)
            {
                Console.WriteLine("Escolha uma opção:");
                seletor = int.Parse(Console.ReadLine());
                if (seletor == 1)
                {
                    Console.WriteLine("Sua opção: " + seletor);
                    lancarGasto(motores);
                }
                else if (seletor == 2)
                {
                    Console.WriteLine("Sua opção: " + seletor);
                    mostrarGastos(motores, total);
                }
                else if (seletor == 3)
                {
                    Console.WriteLine("Sua opção: " + seletor);
                    maiorGasto(motores, maiorvalor);
                }
                else if(seletor == 0)
                {
                    Console.WriteLine("Sua opção: " + seletor);
                    Console.WriteLine("************************~FIM~************************");
                }
                else
                    Console.WriteLine("opção inválida");
            }
            

        }
    }
}
