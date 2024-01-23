using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intesa_SanFabbro_22F
{
    internal class Conto : Persona
    {
        private double saldo;
        private bool chiuso = false;

        // saldo sul conto

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        // stato del conto

        public bool Chiuso
        {
            get { return chiuso; }
            set { chiuso = value; }
        }


        public void AprireConto(string nome, double saldo)
        {
            Nome = nome;
            Saldo = saldo;
            chiuso = false;
        }

    }
}
