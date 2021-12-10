namespace Solid{
    public class Cuadrado:IFigura{
        public double Width { get; set; }
        public Cuadrado(double width)
        {
            this.Width = width;
        }

        public double Area()
        {
            return Width * Width;
        }
    }
}