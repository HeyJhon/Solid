namespace Solid{
    public class Rectangulo : IFigura
    {
        public double Width { get; set; }
        public double Height {get; set; }

        public Rectangulo()
        {
            
        }
        public Rectangulo(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Area()
        {
            return Width * Height;
        }
    }
}