using System;
using MySql.Data.MySqlClient;
namespace Software_de_Donaciones
{
    public class Usuario
    {
        //llamamos al perfil que el usuario va a tener.
        Perfil perfilDeUsuario = new Perfil();

        private string nUsuario = "";
        private string hash = "";
        private string sal = "";
        private enum cargo { };


        public Usuario(string nUsuario)
        {
            this.NUsuario = nUsuario;
        }


        public Usuario()
        {
        }

        public Usuario(string nUsuario, string contraseña)
        {
            NUsuario = nUsuario;

        }

        /// <summary>
        /// Metodo para iniciar la sesion.
        /// </summary>
        /// <returns>Devuelve el objeto con la sesion iniciada.</returns>
        /// <param name="nUsuario">N usuario.</param>
        /// <param name="hash">Hash.</param>
        public Sesion IniciarSesion(string nUsuario, string hash) 
        {
            Sesion sesion = null;
            return sesion;
        }


        /// <summary>
        /// Cierra la Sesion
        /// </summary>
        /// <returns>El resultado de la operacion</returns>
        /// <param name="sesion">Sesion.</param>
        public string CerrarSesion(Sesion sesion) 
        {

            string Resultado = "";
            return Resultado;
        }


        public Perfil AccederAlPerfil(Sesion sesion)
        {
            Perfil perfil = null;
            return perfil;
        }


        public string NUsuario { get => nUsuario; set => nUsuario = value; }
        public string Hash { get => hash; set => hash = value; }
        public string Sal { get => sal; set => sal = value; }
    }
}
