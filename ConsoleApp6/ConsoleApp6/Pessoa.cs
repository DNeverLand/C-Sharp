using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Pessoa : Contacto
    {
        Data dataNasc;


        Pessoa() { dataNasc = new Data(); }
        Pessoa(Data d) { dataNasc = d; }
        Pessoa(Pessoa p) { dataNasc = p.dataNasc; }


        public int calcularIdade()
        {
            return 2019 - dataNasc.A;
        }

    }
}
