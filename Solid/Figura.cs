namespace Solid{

public class Figura {
    public string Nombre { get; set; }
    public string Color { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area(){
        return Width * Height;
    }
}
}