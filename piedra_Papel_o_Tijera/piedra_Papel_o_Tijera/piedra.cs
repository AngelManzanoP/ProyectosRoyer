using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piedra_Papel_o_Tijera
{
    internal class piedra:maquina
    {
        private string p;

        public string P { get => p; set => p = value; }

        public void tirar()
        {
            p = "piedra";
        }
    }
}
