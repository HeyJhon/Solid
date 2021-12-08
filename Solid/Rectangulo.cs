namespace Solid{
    public class Rectangulo : IFigura
    {
        public double Width { get; set; }
        public double Height {get; set; }
        public double Area()
        {
            return Width * Height;
        }
    }
}