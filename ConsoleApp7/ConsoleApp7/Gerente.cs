using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Gerente : Funcionario
    {
        protected int extensao;

        public string Espe { get; set; }

        public int Exten
        {
            get { return extensao; }
            set
            {
                if (value > 0)
                    extensao = value;
            }
        }

       public Gerente():base() { extensao = 0;Espe = ""; }
       public Gerente(int ex,string es, int Id, double vh, string n, string e, DateTime d) : base(Id, vh, n, e, d) { extensao = ex;Espe = es; }
       public Gerente(Gerente g) : base(g) { extensao = g.extensao;Espe = g.Espe; }


        public override string ToString()
        {
            return "Extensão:" + extensao
                + "Especialidade:" + Espe
                + "Id:" + id
                + "Valor hora:" + vHora
                + "Nome:" + nome
                + "Email:" + email
                + "Data:" + dataNasc;
        }
    }
}
