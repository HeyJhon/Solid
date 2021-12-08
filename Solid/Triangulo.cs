namespace Solid{
    public class Triangulo : IFigura
    {
        public double Height { get; set; }
        public double myBase { get; set; }
        public double Area()
        {
           return (myBase * Height) / 2;
        }
    }
}