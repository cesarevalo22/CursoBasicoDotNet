using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.inicializar();
            Printer.writeTitle("Bienvenidos a la Escuela");
            Printer.Beep(10000, 500, 10);
            ImprimirCursosEscuela(engine.Escuela);

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.writeTitle("Cursos de la Escuela");

            if (escuela?.Cursos != null)
            {
                foreach (var item in escuela.Cursos)
                {
                    Console.WriteLine($"Nombre{item.Nombre}, Id {item.UniqueId}, jornada {item.Jornada}");
                }
            }
        }
    }
}

