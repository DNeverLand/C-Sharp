using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario f1 = new Funcionario(5, 40, "José", "mikas@mikas.mikas",new DateTime(1997,8,26));
            Gerente g1 = new Gerente(2, "Admin de Sistemas", 6, 30, "Tone", "neves@neves.neves", new DateTime(1945, 4, 12));
            Operario o1 = new Operario("Limpeza", 2, 70, "Maria", "boss@boss.boss", new DateTime(2012, 12, 1));

            Console.WriteLine("Quantas horas extra trabalhou?");
            double he = double.Parse(Console.ReadLine());

            //Console.WriteLine(f1.ToString());

            Console.WriteLine("O seu salário:" + f1.calcSal(he));

           void inserirGer()
            {
                Gerente ger = new Gerente();

                Console.WriteLine("Qual é a extensão?");
                ger.Exten= int.Parse(Console.ReadLine());
                Console.WriteLine("Qual é a especialidade?");
                ger.Espe = Console.ReadLine();
                Console.WriteLine("Qual é o id?");
                ger.ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual é o valor hora?");
                ger.ValorH = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual é o nome?");
                ger.nome = Console.ReadLine();
                Console.WriteLine("Qual é o email?");
                ger.email = Console.ReadLine();
                Console.WriteLine("Qual é a data?");
                ger.dataNasc = DateTime.Parse(Console.ReadLine());
            }

            void inserirOpe()
            {
                Operario ope = new Operario();

                Console.WriteLine("Qual é o departamento");
                ope.Depar = Console.ReadLine();
                Console.WriteLine("Qual é o id?");
                ope.ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual é o valor hora?");
                ope.ValorH = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual é o nome?");
                ope.nome = Console.ReadLine();
                Console.WriteLine("Qual é o email?");
                ope.email = Console.ReadLine();
                Console.WriteLine("Qual é a data?");
                ope.dataNasc = DateTime.Parse(Console.ReadLine());
            }

            void visGerentes()
            {
                Gerente ger1 = new Gerente(001,"Vendas",01,7.00,"Andre","andre@mail.pt",new DateTime(1980,01,01));
                Gerente ger2 = new Gerente(002,"Caixas",02,10.00,"Maria","maria@mail.pt",new DateTime(1980,01,01));




                Console.WriteLine("Pretende alterar os gerente ? 1/2 ou 0 para voltar");
            }

            ArrayList list = new ArrayList();

            //list.Add(f1);
            //list.Add(g1);
            //list.Add(o1);

            StreamReader rd = new StreamReader(@"kappa.txt");

                if (File.Exists("kappa.txt"))
                {
                    while (!rd.EndOfStream)
                    {
                        string[] valors = rd.ReadLine().Split(';');
                        list.Add(new Funcionario(int.Parse(valors[0]),double.Parse(valors[1]),valors[2],valors[3],DateTime.Parse(valors[4])));
                    }
                }

                foreach(Funcionario fun in list)
                {   
                    Console.WriteLine(fun.ToString());
                }

            StreamWriter wr = new StreamWriter(@"ola.txt",true);

            foreach(Object xpto in list)
            {
                if (File.Exists("ola.txt"))
                {
                    wr.WriteLine(xpto.ToString());

                }
            }

            wr.Close();

            Console.Clear();

            int menu;
            bool flag=true;
            Console.WriteLine("Insert the number of the option you want");
            menu = int.Parse(Console.ReadLine());

            do {
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Inserir Gerente:");
                        inserirGer();
                        break;
                    case 2:
                        Console.WriteLine("Inserir Operário:");
                        inserirOpe();
                        break;
                    case 3:
                        Console.WriteLine("Visualizar Gerentes:");

                        break;
                    case 4:
                        Console.WriteLine("Visualizar Operários:");
                        break;
                    case 5:
                        Console.WriteLine("Visulaizar Funcionários:");
                        break;
                    case 6:
                        Console.WriteLine("Sair");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        flag = false;
                        continue;
                }
            } while (flag == false);

            Console.ReadKey();
        }
    }
}
