using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using profesorAlumno;

class Program
{
    static void Main()
    {
        profesor p=new profesor();
        alumno al = new alumno();
        Dictionary <string,string> informacion = new Dictionary<string,string>();

        Console.WriteLine("HOLAA ESCRIIBE TU NOMBRE ");
        p.NombreProfesor=Console.ReadLine();
        Console.WriteLine("\n\n\nINGRESA EL NL: ");
        al.NumeroDeLista=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("INGRESA NOMBRE DEL ALUMNO: ");
        al.Nombre=Console.ReadLine();

        int i;
        for (i = 0; i <5; i++)
        {
            Console.WriteLine("AGREGA UNA MATERIA:");
            al.Materias.Add(Convert.ToString(Console.ReadLine()));
        }

        int x;
        for (x = 0; x < 1; x++)
        {
            foreach (var mats in al.Materias)
            {
                Console.WriteLine("AGREGA LA CALIFICACION DE "+ mats);
                al.Calificaciones.Add(Convert.ToString(Console.ReadLine()));    
            }
    
        }

        if (al.Materias.Count == al.Calificaciones.Count)
        {
            for (int y = 0; y < al.Materias.Count; y++)
            {
                informacion[al.Materias[y].ToString()]=al.Calificaciones[y].ToString();
            }
        }
        Console.WriteLine("\n\n\n\n::::::::::FICHA INFORMATIVA::::::::::");
        Console.WriteLine("PROFESOR >>>>>  "+p.NombreProfesor);
        Console.WriteLine("\n=====DATOS DEL ALUMNO=====");
        Console.WriteLine("ALUMNO >>>>> " + al.Nombre);
        Console.WriteLine("NUMERO DE LISTA >>>>> "+al.NumeroDeLista);
        Console.WriteLine("\n=====MATERIAS=====");
        foreach(var elementos in informacion)
        {
            Console.WriteLine(elementos);
        }
     
    }
}