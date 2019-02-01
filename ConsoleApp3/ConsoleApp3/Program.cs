using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Hora h1 = new Hora();
            Hora h2 = new Hora();
            Data d1 = new Data();

            Console.WriteLine("Quais são as horas do h1 ?");
            h1.H = int.Parse(Console.ReadLine());

            Console.WriteLine("Quais são os minutos do h1 ?");
            h1.M = int.Parse(Console.ReadLine());

            Console.WriteLine("Quais são os segundos do h1 ?");
            h1.S = int.Parse(Console.ReadLine());

            Console.WriteLine("Quais são as horas do h2 ?");
            h2.H = int.Parse(Console.ReadLine());

            Console.WriteLine("Quais são os minutos do h2 ?");
            h2.M = int.Parse(Console.ReadLine());

            Console.WriteLine("Quais são os segundos do h2 ?");
            h2.S = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o ano ?");
            d1.A = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o mês ?");
            d1.M = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o dia ?");
            d1.D = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o dia da semana ?");
            d1.DS = Console.ReadLine();

            Console.WriteLine(h1.ToString());

            h1.dif2horas(h2);

            string tot= h1.dif2horas(h2);

            Console.WriteLine(tot);

            Console.WriteLine(d1.ToString());

            Console.ReadKey();
        }
    }
}
