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
    public partial class Regristro_de_Usuario_de_la_Empresa : Form
    {
        public Regristro_de_Usuario_de_la_Empresa()
        {
            InitializeComponent();
        }

        public void Chequeardatos()
        {
            if (!(despliegue_tipoUsuario.SelectedItem is null))
            {
                if (texto_nombredeusuario.Text.Length > 0)
                {
                    if (texto_email.Text.Length > 0)
                    {
                        if (texto_contraseña.Text.Length > 0)
                        {
                            if (texto_contraseña.Text.Length > 7)
                            {
                                if (texto_confirmecontra.Text.Length > 0)
                                {
                                        if (texto_confirmecontra.Text.Equals(texto_contraseña.Text))
                                        {
                                            if (texto_ci.Text.Length > 0)
                                            {
                                            if (texto_ci.Text.Length > 7)
                                            {
                                                if (texto_teléfono.Text.Length > 0)
                                                {

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Escriba su teléfono");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Su C.I debe tener 8 digitos");
                                            }
                                        }
                                            else
                                            {
                                                MessageBox.Show("Escriba su C.I");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("La contraseña no coincide");
                                        }
                                   
                                }
                                else
                                {
                                    MessageBox.Show("Confirme su contraseña");
                                }
                            }
                            else
                            {
                                MessageBox.Show("contraseña muy corta");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Escriba su contraseña");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Escriba su E-mail");
                    }
                }
                else
                {
                    MessageBox.Show("Escriba su nombre de usuario");
                }
            }
            else
            {
                MessageBox.Show("Elija su tipo de usuario");
            }
        }
        


        private void boton_registrarse_Click(object sender, EventArgs e)
        {

            Chequeardatos();
        }
    }
}
