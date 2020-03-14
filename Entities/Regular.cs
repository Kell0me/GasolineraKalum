namespace GasolineraKalum.Entities
{
    public class Regular : Bomba
    {
        
        public Regular() //constructor nullo
        {
            
        }

        public Regular(double precio, int capacidad, string medida) 
        : base(precio, capacidad, medida)
        {
        }
    }
}