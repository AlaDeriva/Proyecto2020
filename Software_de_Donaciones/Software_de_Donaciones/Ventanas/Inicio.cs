using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_de_Donaciones
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        public bool Chequeardatos()
        {
            bool resultado = false;
            if (texto_usuario.Text.Length>0)
            {
                if (texto_contraseña.Text.Length > 0)
                {
                    resultado = true;
                }
                else
                {
                    MessageBox.Show("Escriba su contraseña");
                }
            }
            else
            {
                MessageBox.Show("Escriba su nombre de usuario");
            }
            return resultado;
        }

        private void boton_iniciarsesion_Click(object sender, EventArgs e)
        {
            if ( Chequeardatos() )
            {
                Menu_Principal nuevaventana = new Menu_Principal();
                nuevaventana.Show();
                this.Close();
            }
        }

        private void boton_registrarse_Click(object sender, EventArgs e)
        {
            Regristro_de_Usuario_de_la_Empresa nuevaventana = new Regristro_de_Usuario_de_la_Empresa();
            nuevaventana.ShowDialog();
        }
    }

    
}
