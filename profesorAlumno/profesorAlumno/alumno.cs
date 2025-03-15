using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace profesorAlumno
{
    internal class alumno
    {
        private int numeroDeLista;
        private string nombre;
        private ArrayList materias=new ArrayList();
        private ArrayList calificaciones=new ArrayList();

        public int NumeroDeLista { get => numeroDeLista; set => numeroDeLista = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public ArrayList Materias { get => materias; set => materias = value; }
        public ArrayList Calificaciones { get => calificaciones; set => calificaciones = value; }

    }
}
