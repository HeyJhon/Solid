using System;
using Microsoft.Data.SqlClient;

namespace Solid{
    public class ADO{
    public void SaveDB(double resultado){
        
    string texto = $"El resultado de la operación es {resultado}";
    string _connectionString = @"Server=LAPTOP-1K29SKO8\MSSQLSERVER2020;Database=Demo;User Id=sa;Password=admin2020;";
 
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            String query = "INSERT INTO Figura(Resultado) VALUES(@resultado)";
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@resultado", texto);
                connection.Open();
                int result = command.ExecuteNonQuery();
                // Check Error
                if(result < 0)
                    Console.WriteLine("Error al escribir en la Base de datos!");
                else
                    Console.WriteLine("Se guardo en Base de datos correctamente");

            }
        }
    }
    }
}