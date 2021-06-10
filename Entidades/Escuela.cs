namespace CoreEscuela.Entidades{

    class Escuala
    {
        //Formas de crear variables y de encapsular
            //forma 1
        string nombre;
        public  string Nombre{
            get{return "Copia" + nombre;}
            set{nombre = value;}
        }
            //forma 2
        public int anoCreacion{get;set;}
        public int Pais{get;set;}

        //prop atajo para crear una propiedad
        public int Ciudad{get;set;}

        public int MyVar { get; set; }

    }
}