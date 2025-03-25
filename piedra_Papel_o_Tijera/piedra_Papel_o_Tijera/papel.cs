using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piedra_Papel_o_Tijera
{
    internal class papel:maquina
    {
        private string pa;

        public string Pa { get => pa; set => pa = value; }

        public void tirar()
        {
            pa = "papel";
        }
    }
}
