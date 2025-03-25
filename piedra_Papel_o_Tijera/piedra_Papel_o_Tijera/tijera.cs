using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piedra_Papel_o_Tijera
{
    internal class tijera:maquina
    {
        private string t;

        public string T { get => t; set => t = value; }
        public void tirar()
        {
            t = "tijera";
        }
    }
}
