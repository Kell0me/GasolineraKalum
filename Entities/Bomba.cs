using System;

namespace GasolineraKalum.Entities
{
    public abstract class Bomba : IControlBomba
    {

        public Bomba() //constructor nulo con el comnado ctor sale el automaticamente
        {
            this.Id = GenerarId();
        }

        public Bomba(double precio, int capacidad, string medida) //constructor con sus metodos
        {
            //colocarse adelante del parametro y darle ctrl + . y aparece la propiedad
           this.Id = GenerarId();
           this.Precio = precio;
           this.Capacidad = capacidad;
           this.Medida = medida;
        }


        public string Id { get; set; }

        public double Precio { get; set; }

        public int Capacidad { get; set; }

        public string Medida { get; set; }

        public void Despachar(int cantidad)
        {
            if(this.Capacidad >= cantidad )
            {
            this.Capacidad -= cantidad;                
            }
        }

        public int VerNivelCapacidad()
        {
            return this.Capacidad;
            
        }



        private string GenerarId() //se va a generar dentro de la clase Bomba
        {
            //para generar el id de forma automatica por medio de este constructor
            Guid guid = Guid.NewGuid();  //comando guid //se usa el using System para que no de error se agrega
            return guid.ToString(); //genera el id de forma automatica
            
            
        }


        public override string ToString() 
        {
                //return $" \" \" "; // con diagonal se define que comillas dobles es parte del string
                return $"{{ \" Id \" : {this.Id}\", \" Capacidad \" : {this.Capacidad},\"tipo\" : {this.GetType().ToString().Substring(this.GetType().ToString().LastIndexOf(".")+1)} }}"; //colocando dos llaves { imprime tambien con el string
        }

    }

    public interface IControlBomba
    {
        
    }
}