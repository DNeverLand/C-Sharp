using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Data
    {
        private int _dia, _mes, _ano;
        private string _ds;

        public Data() { _dia = 01; _mes = 01; _ano = 2000; }
        public Data(int d, int m, int a) { _dia = d; _mes = m; _ano = a; }
        public Data(Data y) { _dia = y._dia; _mes = y._mes; _ano = y._ano; }

        public int D
        {
            get { return _dia; }
            set
            {
                if (_ano % 4 == 0 && _ano % 100 != 0 && _ano % 400 == 0)
                {
                    if (_mes == 1)
                    {
                        if (value > 0 && value < 32)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 2)
                    {
                        if (value > 0 && value < 30)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 3)
                    {
                        if (value > 0 && value < 32)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 4)
                    {
                        if (value > 0 && value < 31)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 5)
                    {
                        if (value > 0 && value < 32)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 6)
                    {
                        if (value > 0 && value < 31)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 7)
                    {
                        if (value > 0 && value < 32)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 8)
                    {
                        if (value > 0 && value < 32)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 9)
                    {
                        if (value > 0 && value < 31)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 10)
                    {
                        if (value > 0 && value < 32)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 11)
                    {
                        if (value > 0 && value < 31)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 12)
                    {
                        if (value > 0 && value < 32)
                        {
                            _dia = value;
                        }
                    }
                }
                else
                {
                    if (_mes == 1)
                    {
                        if (value > 0 && value < 32)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 2)
                    {
                        if (value > 0 && value < 29)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 3)
                    {
                        if (value > 0 && value < 32)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 4)
                    {
                        if (value > 0 && value < 31)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 5)
                    {
                        if (value > 0 && value < 32)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 6)
                    {
                        if (value > 0 && value < 31)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 7)
                    {
                        if (value > 0 && value < 32)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 8)
                    {
                        if (value > 0 && value < 32)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 9)
                    {
                        if (value > 0 && value < 31)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 10)
                    {
                        if (value > 0 && value < 32)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 11)
                    {
                        if (value > 0 && value < 31)
                        {
                            _dia = value;
                        }
                    }
                    else if (_mes == 12)
                    {
                        if (value > 0 && value < 32)
                        {
                            _dia = value;
                        }
                    }
                }
            }
        }

        public int M
        {
            get { return _mes; }
            set
            {
                if (value > 0 && value < 13)
                    _mes = value;
            }
        }

        public int A
        {
            get { return _ano; }
            set
            {
                if (value > 1900 && value < 2020)
                    _ano = value;
            }
        }

        public override string ToString()
        {
            return "Ano: " + _ano + "\n Mes: " + _mes + "\n Dia: " + _dia;
        }
    }
}
