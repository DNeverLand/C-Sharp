using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Empresa e1 = new Empresa();

            Console.WriteLine("Qual é a actividade da empresa?");
            e1.actividade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o responsavel?");
            e1.Resp = Console.ReadLine();

            Console.WriteLine("Qual é a morada?");
            e1.Morada = Console.ReadLine();

            Console.WriteLine("Qual é o ID?");
            e1.ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a telefone?");
            e1.Telef = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o nome?");
            e1.Nome = Console.ReadLine();

            Console.WriteLine("Qual é o email?");
            e1.Email = Console.ReadLine();

            Console.WriteLine(e1.ToString());

            Console.ReadKey();
        }
    }
}
