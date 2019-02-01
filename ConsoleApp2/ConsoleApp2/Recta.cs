using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Recta
    {
        private Ponto _p1,_p2;

        public Recta() { _p1 = new Ponto(); _p2 = new Ponto(); }
        public Recta(Ponto pA, Ponto pB) { _p1 = pA; _p2 = pB; }
        public Recta(Recta r) { _p1 = r._p1; _p2 = r._p2; }

        public Ponto P1 { get; set; }
       
        public Ponto P2 { get; set; }
        

        public override string ToString()
        {
            return "Recta: " + _p1.ToString() + _p2.ToString();
        }
    }
}
