using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Ponto
    {
        private int _x, _y;
        public Ponto() { _x = 0; _y = 0; }
        public Ponto(int a, int b) { _x = a; _y = b; }
        public Ponto(Ponto p) { _x = p.X;_y = p.Y; }
        

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public override string ToString()
        {
            return "Ponto (" + X + "," + Y + ")";
        }

        public double distancia2P(Ponto p)
        {
            return Math.Sqrt(X - p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y);
        }

    }
}
