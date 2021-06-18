using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace CursoBasicoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
                pais: "Colombia", ciudad: "Bogota"
            );

            escuela.Cursos = new List<Curso> {
                new Curso(){Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "301", Jornada = TiposJornada.Mañana}
            };

            escuela.Cursos.Add(new Curso { Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso { Nombre = "202", Jornada = TiposJornada.Tarde });

            var otraCollecion = new List<Curso> {
                new Curso(){Nombre = "401", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "501", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "501", Jornada = TiposJornada.Tarde}
            };
            otraCollecion.REM ();
            escuela.Cursos.AddRange(otraCollecion);


           /*  escuela.Cursos = new Curso[] {
                new Curso(){Nombre = "101"},
                new Curso(){Nombre = "201"},
                new Curso(){Nombre = "301"}
            }; */

            WriteLine(escuela);
            WriteLine("==============");

            WriteLine("==============");
            ImprimirCursosEscuelaForEach(escuela.Cursos);


        }

        private static void ImprimirCursosEscuelaForEach(List<Curso> arregloCursos)
        {
            foreach (var item in arregloCursos)
            {
                Console.WriteLine($"Nombre{item.Nombre}, Id {item.UniqueId}");
            }
        }
    }
}

