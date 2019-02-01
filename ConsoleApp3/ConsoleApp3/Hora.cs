using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Hora
    {
        private int _hora, _min, _seg;

        public Hora() { _hora = 00; _min = 00; _seg = 00; }
        public Hora(int h, int m, int s) { _hora = h; _min = m; _seg = s; }
        public Hora(Hora x) { _hora = x._hora; _min = x._min; _seg = x._seg; }


        public int H
        {
            get { return _hora; }
            set
            {
                if (value < 24 && value >= 0)
                    _hora = value;
            }
        }

        public int M
        {
            get { return _min; }
            set
            {
                if (value < 60 && value > 0)
                    _min = value;
            }
        }

        public int S
        {
            get { return _seg; }
            set
            {
                if (value < 60 && value > 0)
                    _seg = value;
            }
        }

        public string dif2horas(Hora h)
        {
            return (_hora - h._hora) + ":" + (_min - h._min) + ":" + (_seg-h._seg);
        }

        public override string ToString()
        {
            return _hora + ":" + _min + ":" + _seg;
        }
    }
}
