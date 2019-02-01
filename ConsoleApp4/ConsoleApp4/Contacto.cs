using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Contacto
    {
        private int _id, _telef;
        private string _nome, _eMail;
        public Date _d1;

        public Contacto() { _id = 0;_telef = 0;_nome = "Sem nome";_eMail = "";_d1 = new Date(); }
        public Contacto(int Id, int tf, string nm, string em,Date d) { _id = Id;_telef = tf;_nome = nm;_eMail = em;_d1 = d; }
        public Contacto(Contacto c) { _id = c._id;_telef = c._telef;_nome = c._nome;_eMail = c._eMail;_d1 = c._d1; }

        public int ID { get { return _id; }
            set { _id = value; }
        }

        public int TF
        {
            get { return _telef; }
            set
            {
                if (value > 900000000 && value < 1000000000)
                    _telef = value;
            }
        }

        public string N { get { return _nome; }
            set { _nome = value; }
        }

        public string EM { get { return _eMail; } set { _eMail = value; } }

        public Date D { get
            {
                return _d1;
            }
            set { _d1 = value; } }
        
        public int calcularIdade()
        {
            return 2019 - _d1.A;
        }

        public override string ToString()
        {
            return "Id: " + _id
                + "\n Telefone: " + _telef
                + "\n Nome: " + _nome
                + "\n Email: " + _eMail
                + "\n Data" + _d1;
        }


    }
}
