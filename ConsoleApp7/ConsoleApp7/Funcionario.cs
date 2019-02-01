using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Funcionario
    {
        protected int id;
        protected double vHora;

        public string nome { get; set; }
        public string email { get; set; }
        public DateTime dataNasc { get; set; }

        public int ID
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }

        public double ValorH
        {
            get { return vHora; }
            set
            {
                if (value > 0)
                    vHora = value;
            }
        }

        Funcionario() { id = 0; vHora = 0; nome = "Sem nome"; email = ""; dataNasc = new DateTime(); }
        Funcionario(int Id, double vh, string n, string e, DateTime d) { id = Id; vHora = vh; nome = n; email = e; dataNasc = new DateTime(); }
        Funcionario(Funcionario f) { id = f.id; vHora = f.vHora; nome = f.nome; email = f.email; dataNasc = f.dataNasc; }

        public int calcularIdade()
        {
            return 2019 - dataNasc.Year;
        }

        public double calcSal(double he)
        {
            if (he > 0)
            {
                return he * vHora;
            }
            return vHora;

        }
    }
}
