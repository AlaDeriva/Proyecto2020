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

        public Usuario()
        {
        }

        public Usuario(string nUsuario,string contraseña)
        {
            NUsuario = nUsuario;

        }

        public string NUsuario { get => nUsuario; set => nUsuario = value; }
        public string Hash { get => hash; set => hash = value; }
        public string Sal { get => sal; set => sal = value; }
    }
}
