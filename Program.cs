using System;
using CoreEscuela.Entidades;

namespace CursoBasicoDotNet
{
    class Programs
    {
        static void Main(string[] args)
        {   
            var escuela = new Escuela("Platzi Academy",2012);
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogotá";

            Console.WriteLine(escuela.AnoCreacion);
        }
    }
}
