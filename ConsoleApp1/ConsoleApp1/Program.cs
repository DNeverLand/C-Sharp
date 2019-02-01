using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
                Console.WriteLine("Qual é o seu nome ?");
                nome = Console.ReadLine();
            /*if (nome != "Bartolomeu" || nome != "bartolomeu")
            {
                Console.WriteLine("Olá " + nome);
            }
            else
            {
                Console.WriteLine("Dá cá o meu!");
            }
            string[] separado = nome.Split(' ');

            i = separado.Length-1;

            Console.WriteLine(separado[0]); // 1 posição do separado
            Console.WriteLine(separado[i]); // o i representa  o tamanho de separado -1 que vai ser o ultimo, no caso de serem 4 nomes, vai ser 4-1 que vai dar a pos 3, de 0 a 3.*/

            string[] separar = nome.Split(' ');

           string num = MaiorString(separar);
            Console.WriteLine(num);

            if (MesmoComp(separar))
            {
                Console.WriteLine("São todos iguais !");
            }
            else
            {
                Console.WriteLine("Tem diferentes !");
            }

            int n = TotalString(separar);
            Console.WriteLine(n);

            string Act = Modificar(nome);
            Console.WriteLine(Act);

            Console.ReadKey();
        }

        private static string MaiorString(string[] separar)
        {
            int maior=0;
            for(int i = 1; i < separar.Length; i++)
            {
                if (separar[i].Length > separar[maior].Length)
                {
                    maior = i;
                }
            }
            return separar[maior];
        }

        private static bool MesmoComp(string[] separar)
        {
            int igual = separar[0].Length;

            for(int i = 1; i < separar.Length; i++)
            {
                if (separar[i].Length != igual)
                {
                    return false;
                }
            }
            return true;
        }

        private static int TotalString(string[] separar)
        {
            int total=0;
            for(int i = 0; i < separar.Length; i++)
            {
                total = total + separar[i].Length;
            }
            return total;
        }

        private static string Modificar(string nome)
        {
            nome = nome.ToUpper();
            nome = nome.Replace("V", "B");
            nome = nome.Replace("ÃO", "OM");

            return nome;
        }

        private static bool Algarismos(string nome)
        {
            int[] vec = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for(int i = 0; i < vec.Length; i++)
            {
                if (nome.IndexOf("0") == -1 &&)
                {

                }
            }
            
        }

    }
}
