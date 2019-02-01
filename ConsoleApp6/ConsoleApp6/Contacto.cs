using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Contacto
    {
        protected int id, telef;

        public string Nome { get; set; }
        public string Email { get; set; }

       public Contacto()
        {
            id = 0;
            telef = 0;
            Nome = "Sem nome";
            Email = "";
        }

       public Contacto(int Id,int tf,string n,string e) { id = Id;telef = tf;Nome = n;Email = e; }

       public Contacto(Contacto c) { id = c.id;telef = c.telef;Nome = c.Nome;Email = c.Email; }

        public int ID
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }

        public int Telef
        {
            get { return telef; }
            set
            {
                if (value > 900000000 && value < 1000000000)
                    telef = value;
            }
        }

        public override string ToString()
        {
            return "O id:" + id
                + "Nome:" + Nome
                + "Telefone" + telef
                + "Email:" + Email;
        }

    }
}
