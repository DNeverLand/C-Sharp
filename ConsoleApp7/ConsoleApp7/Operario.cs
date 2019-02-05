using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Operario : Funcionario
    {
        public string Depar { get; set; }

       public Operario() : base() { Depar = ""; }
       public Operario(string de, int Id, double vh, string n, string e, DateTime d) : base(Id, vh, n, e, d) { Depar = de; }
       public Operario(Operario o) : base(o) { Depar = o.Depar; }


    }
}
