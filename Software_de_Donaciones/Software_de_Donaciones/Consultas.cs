using System;
using MySql.Data.MySqlClient;
namespace Software_de_Donaciones
{
    public class Consultas
    {
        private BaseDeDatos bdd = new BaseDeDatos();

        public Consultas()
        {
            this.iPservidor = utilesXML.LeerConfig(archivoConfig, "IPServidor");
            this.bddAUsar = utilesXML.LeerConfig(archivoConfig, "BDD");
            this.usuarioBD = utilesXML.LeerConfig(archivoConfig, "UsuarioBD");
            this.contraseniaBD = utilesXML.LeerConfig(archivoConfig, "ContraseniaBD");
            //Leemos los datos de configuración para acceder a la base de datos

        }

        private UtilesXML utilesXML = new UtilesXML();
        //Objeto para leer los datos de configuración

        private readonly string archivoConfig = "configuracion.xml";
        //Archivo con los datos de configuración

        private string iPservidor = "";
        private string bddAUsar = "";
        private string usuarioBD = "";
        private string contraseniaBD = "";
        //Variables para almacenar los datos de conexión con la base de datos


        public bool UsuarioExiste(Usuario usuario)
        {
            bool Resultado = false;
            MySqlConnection conexion = bdd.CrearConexion(iPservidor,bddAUsar,usuarioBD,contraseniaBD);

            string Consulta =
            "SELECT count(*) FROM Usuario WHERE NombreUsuario = @NUsuario";
            try
            {
                conexion.Open();

                MySqlCommand comando = new MySqlCommand(Consulta, conexion);
                //Creamos un comando con la consulta y la conexión.
                // Este objeto es el que EJECUTA la consulta

                comando.Parameters.AddWithValue("@NUsuario", usuario.NUsuario);
                //Agregamos el dato al parámetro de la consulta

                MySqlDataReader lector = comando.ExecuteReader();
                //Creamos un objeto lector, para recibir los datos de la consulta

                if (lector.HasRows)
                //Chequeamos que el lector contenga algún registro
                {
                    while (lector.Read())
                    //Recorremos los registros del lector con un bucle WHILE y el método '.Read()'
                    //NOTA: En este caso, si el usuario existe, sólo deberíamos obtener UN REGISTRO
                    {
                        int Cantidad = lector.GetInt32(0);
                        if (Cantidad == 1)
                        {
                            Resultado = true;
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error buscando Usuario: "+ex.Message);

            }

            return Resultado;
        }

        public string TokensDeUsuario(Usuario usuario)
        {
            string ResultadoDeToken;

             
        }

    }
}