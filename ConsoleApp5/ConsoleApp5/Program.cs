using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double valo;
            string ver;

            Conta c1 = new Conta();

            Console.WriteLine("Qual é o nome do titular?");
            c1.Titular = Console.ReadLine();

            Console.WriteLine("Qual é o numero da conta?");
            c1.NR = int.Parse(Console.ReadLine());

            Console.WriteLine("Quer mudar o estado da conta? y/n");
            ver = Console.ReadLine();

            Console.WriteLine("Quanto quer depositar?\n");
            c1.Depositar(double.Parse(Console.ReadLine()));

            Console.WriteLine("Quanto quer levantar?\n");
            c1.Levantar(double.Parse(Console.ReadLine()));

            if (ver == "y")
            {
                c1.alterarEstado();
            }

            Console.WriteLine(c1.ToString());

            Console.ReadKey();

        }
    }
}
