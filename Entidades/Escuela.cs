using System.Collections.Generic;

namespace CoreEscuela.Entidades{

    public class Escuela
    {
        //Formas de crear variables y de encapsular
            //forma 1
        string nombre;  
        public  string Nombre{
            get{return "Copia " + nombre;}
            set{nombre = value.ToUpper();}
        }
            //forma 2
        public int AnoCreacion{get; set;}
        public string Pais{get; set;}

        //prop atajo para crear una propiedad
        public string Ciudad{get;set;}

        public List<Curso> Cursos { get; set; }
        
        public TiposEscuela TipoEscuela { get; set; }

        //forma 1 de escribir constructores
        public Escuela (string nombre, int ano){
            this.Nombre = nombre;
            this.AnoCreacion = ano;
        }

        //forma 2 de escribir constructores
        public Escuela(string nombre, int ano, string pais) => (Nombre, AnoCreacion, Pais) = (nombre, ano, pais);
        public Escuela(string nombre, int ano,
                         TiposEscuela tipo, 
                         string pais = "",string ciudad = "" ) 
                         {
                            (Nombre, AnoCreacion, Pais) = (nombre, ano, pais); 
                            Pais = pais;
                            Ciudad = ciudad;
                         }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad: {Ciudad}"; 
        }

    }
}