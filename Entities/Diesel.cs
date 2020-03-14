namespace GasolineraKalum.Entities
{
    public class Diesel : Bomba
    {
        public string Formula { get; set; }

        public Diesel()
        : base()
        {
            
        }
        public Diesel(string formula, double precio, int capacidad, string medida) : base(precio, capacidad, medida)
        {
            this.Formula = formula;
        }
    }
}