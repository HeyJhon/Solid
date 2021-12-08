namespace Solid{
    public class Rombo : IFigura
    {

    public double DiagonalMayor { get; set; }   
    public double DiagonalMenor { get; set; }    
    public double Area()
            {
                return DiagonalMayor * DiagonalMenor;
            }
    }
}