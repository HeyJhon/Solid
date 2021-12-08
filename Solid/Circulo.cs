namespace Solid{
    public class Circulo : IFigura
    {
        public double Radio { get; set; }
        private const double PI = 3.1415926535897931;

        public double Area()
        {
            return PI * (Radio * Radio);
        }
    }
}