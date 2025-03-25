using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piedra_Papel_o_Tijera
{
    internal class maquina
    {
        private string piedra;
        private string papel;
        private string tijeras;

        public string Piedra { get => piedra; set => piedra = value; }
        public string Papel { get => papel; set => papel = value; }
        public string Tijeras { get => tijeras; set => tijeras = value; }

        public void tirar()
        {
            piedra = "piedra";
            papel = "papel";
            tijeras = "tijera";
        }
    }
}