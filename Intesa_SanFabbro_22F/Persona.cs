using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intesa_SanFabbro_22F
{
    internal class Persona
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                if (_nome.Length <= 2)
                {
                    _nome = "Sconosciuto";
                }
            }
        }
    }
}
