namespace CoreEscuela.Entidades{

    class Escuela
    {

        //Formas de crear variables y de encapsular
            //forma 1
        public  string Nombre{
            get{return "Copia" + Nombre;}
            set{Nombre = value;}
        }
            //forma 2
        public int AnoCreacion{get; set;}
        public string Pais{get; set;}

        //prop atajo para crear una propiedad
        public string Ciudad{get;set;}

        //forma 1 de escribir constructores
        public Escuela (string nombre, int ano){
            this.Nombre = nombre;
            this.AnoCreacion = ano;
        }

        //forma 2 de escribir constructores
        public Escuela(string nombre, int ano, string pais) => (Nombre, AnoCreacion, Pais) = (nombre, ano, pais);


    }
}