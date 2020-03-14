namespace GasolineraKalum.Entities
{
    public class Super : Bomba
    {

        public Super() : base() //constructor null 1
        {

        }
        public Super(int aditivo, double precio, int capacidad, string medida) 
        : base(precio, capacidad, medida)
        {
        this.Aditivo = aditivo;

        }

        public int Aditivo { get; set; }

    }


}