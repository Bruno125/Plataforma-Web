using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Sem3_Ses1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Permite conectarme a una BD
            SqlConnection sqlCon = new SqlConnection();
            //A qué BD voy a conectar
            sqlCon.ConnectionString = Conexion.URL;
            //Abrir la conexion para ejecutar comandos SQL
            sqlCon.Open();
            Console.WriteLine("Se conectó a la BD " + sqlCon.ConnectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = sqlCon;
            command.CommandText = "INSERT INTO Categories(CategoryName) VALUES ('PRUEBA')";
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            //Cerrar la conexion
            sqlCon.Close();
            Console.WriteLine("Se inserto correctamente la categoria");
            Console.ReadLine();
        }
    }
}
