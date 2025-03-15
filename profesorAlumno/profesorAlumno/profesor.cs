using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profesorAlumno
{
    internal class profesor
    {
        private string nombreProfesor;
        alumno al;

        public string NombreProfesor { get => nombreProfesor; set => nombreProfesor = value; }
        internal alumno Al { get => al; set => al = value; }
    }
}
