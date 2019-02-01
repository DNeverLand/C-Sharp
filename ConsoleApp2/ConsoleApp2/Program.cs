using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto();
            Ponto p2 = new Ponto();
            Recta r1 = new Recta();

            p1.X = 4;
            p1.Y = 2;
            p2.X = 1;
            p2.Y = 3;

            p1.distancia2P(p2);

            double dis = p1.distancia2P(p2);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            Console.WriteLine("A distancia entre os 2 pontos é : " + dis);

            Console.WriteLine(r1.ToString());

            Console.ReadKey();
        }
    }
}
