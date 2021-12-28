using MySql.Data.MySqlClient;
using System;
using System.Text;

public class ADOMySQL: IADO{
    public void SaveDB(double resultado){
    
    string texto = $"El resultado de la operación es {resultado}";
    string _connectionString = @"datasource=localhost;port=3306;username=root;password=;database=test;SslMode=none";

        using(MySqlConnection  connection = new MySqlConnection(_connectionString))
        {
            String query = "INSERT INTO `figura` (`Id`, `Resultado`) VALUES (NULL, '"+texto+"');";
            using(MySqlCommand command = new MySqlCommand(query, connection))
            {               
                connection.Open();
               // int result = command.ExecuteNonQuery();
                MySqlDataReader myReader = command.ExecuteReader();
                // Check Error
                Console.WriteLine("Se guardo en Base de datos correctamente");

            }
        }

    }
}