using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date();
            Contacto c1 = new Contacto();

            Console.WriteLine("Qual é o ano ?");
            c1.D.A= int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o mês ?");
            c1.D.M= int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o dia ?");
            c1.D.D = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o id ?");
            c1.ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o telefone ?");
            c1.TF = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o nome ?");
            c1.N = Console.ReadLine();

            Console.WriteLine("Qual é o email ?");
            c1.EM = Console.ReadLine();


            Console.WriteLine(c1.ToString());

            Console.WriteLine(c1.calcularIdade());

            Console.ReadKey();
        }
    }
}
