using System;
using MySql.Data.MySqlClient;
namespace Software_de_Donaciones
{
    public class BaseDeDatos
    { 
        
        public BaseDeDatos()
        {
        }

        public MySqlConnection CrearConexion(string servidor, string bdd, string usuario, string passwd)
        {
            MySqlConnection conexion;
            //Creamos el objeto de conexión

            string datosConexion = "server=" + servidor + ";" +
                                   "database=" + bdd + ";" +
                                   "uid=" + usuario + ";" +
                                   "pwd=" + passwd + ";";
            //Declaro un string con los datos de conexión, agregando los parámetros

            conexion = new MySqlConnection(datosConexion);
            //Inicializo el objeto de conexión con los datos de conexión

            return conexion;
            //Devolvemos el objeto de conexión pronto
        }

    }
}
