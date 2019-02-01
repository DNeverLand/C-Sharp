using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Conta
    {
        private int numero, estado;
        private double saldo;

        public string Titular { get; set; }

        public Conta() { Titular = "Sem nome"; numero = 0;saldo = 0;estado = -1; }
        public Conta(string t,int n, int e) { Titular = t; numero = n;estado = e;saldo = 0; }
        public Conta(Conta c) { Titular = c.Titular; numero = c.numero;estado = c.estado; saldo = 0; }

        public int NR
        {
            get { return numero; }
            set
            {
                if (value > 0)
                    numero = value;
            }
        }

        public double SAL
        {
            get { return saldo; }
        }

        public int Estado
        {
            get { return estado; }
            set
            {
                if (value == 0 && value == -1)
                    estado = value;
            }
        }

        public int Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo = saldo + valor;
                return 0;
            }
            else
                return -1;
        }

        public int Levantar(double valo)
        {
            if (valo <= saldo)
            {
                saldo = saldo - valo;
                return 0;
            }
            else
                return -1;
        }

        public void alterarEstado()
        {
            if (estado == -1)
            {
                estado = 1;
            }
            else
                estado = -1;
        }

        public double Credito()
        {
            if (saldo < 500)
                return 0;
            else if (saldo < 1000)
                return saldo * 0.10;
            else if (saldo < 5000)
                return saldo * 0.30;
            else
                return saldo * 0.50;
        }

        public override string ToString()
        {
            return "Titular da conta: " + Titular
                + "\n Numero da conta: " + numero
                + "\n Saldo da conta: " + saldo
                + "\n Estado da conta: " + (estado==1 ? "Ativado" : "Desativado");
        }

    }
}
