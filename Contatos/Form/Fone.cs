using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form
{
    class Fone
    {
        private string numero;
        private string tipo;

        public string Numero { get => numero; set => numero = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public Fone(string numero, string tipo)
        {
            this.numero = numero;
            this.tipo = tipo;
        }
    }
}
