using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Empresa : Contacto
    {
        public int actividade;

        public string Resp { get; set; }
        public string Morada { get; set; }

        public Empresa() : base() { actividade = 0;Resp = "";Morada = ""; }
        Empresa(int act,string res,string mor, int Id, int tf, string n, string e) :base(Id,tf,n,e) { actividade = act;Resp = res;Morada = mor; }
        Empresa(Empresa e):base(e) { actividade = e.actividade;Resp = e.Resp;Morada = e.Morada; }

        public int Act
        {
            get { return actividade; }
            set
            {
                if (value >= 0)
                    actividade = value;
            }
        }

            public override string ToString()
        {
            return "A actividade:" + actividade
                + "\n Responsavel:" + Resp
                + "\n Morada:" + Morada
                + "\n O id:" + id
                + "\n Nome:" + Nome
                + "\n Telefone:" + telef
                + "\n Email:" + Email;
        }
    }
}
