using System;
using Solid;
namespace solid0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Principios SOLID ###");

            Console.WriteLine("Ingresa el valor para el ancho:");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor para el alto:");
            int heigth = int.Parse(Console.ReadLine());

            SingleResponsibility(width, heigth);
            Console.ReadKey();
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
