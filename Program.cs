using System;
using System.Collections.Generic;
using Solid;
namespace solid0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Principios SOLID ###");

            // Console.WriteLine("Ingresa el valor para el ancho:");
            // int width = int.Parse(Console.ReadLine());

            // Console.WriteLine("Ingresa el valor para el alto:");
            // int heigth = int.Parse(Console.ReadLine());

           //SingleResponsibility(width, heigth);
           OpenClose();
            Console.ReadKey();
        }

        public static void OpenClose(){
            List<IFigura> figuras = new List<IFigura>();

            Rectangulo rectangulo = new Rectangulo(){
                Width = 20,
                Height = 10
            };

            Triangulo triangulo = new Triangulo(){
                myBase = 20,
                Height = 30
            };

            Circulo circulo = new Circulo(){
                Radio = 3.5
            };

            Rombo rombo = new Rombo(){
                DiagonalMayor = 20.5,
                DiagonalMenor = 10
            };

            figuras.Add(rectangulo);
            figuras.Add(triangulo);
            figuras.Add(circulo);
            figuras.Add(rombo);
            
            foreach (var figura in figuras)
            {
                Console.WriteLine($"El area de la figura {figura.GetType()} es: {figura.Area()}");
            }
            
        }

        public static void SingleResponsibility(int width, int heigth){

            Figura figura = new Figura(){
                Width = width,
                Height = heigth
            };

            double area = figura.Area();
            Console.WriteLine($"El area de la figura es: {area}");
            //figura.SaveFile(area);
            Archivo archivo = new Archivo();
            archivo.SaveFile(area);

            //figura.SendEmail(area);
            Correo correo = new Correo();
            correo.SendEmail(area);

            //figura.SaveDB(area);
            ADO conexion = new ADO();
            conexion.SaveDB(area);
        }
    }
}
