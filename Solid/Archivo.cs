using System;
using System.IO;

namespace Solid{
    public class Archivo{
    public void SaveFile(double resultado){
        string texto = $"El resultado de la operación es {resultado}";
        try{
            Console.WriteLine("Resultado guardado correctamente en resultado.txt");
            File.WriteAllText("resultado.txt", texto);
        }
        catch{
            Console.WriteLine("Error al guardar");
        }
    }
}
}