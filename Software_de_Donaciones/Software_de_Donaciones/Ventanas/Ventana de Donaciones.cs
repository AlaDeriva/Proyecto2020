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
    public partial class Ventana_de_Donaciones : Form
    {
       
        public Ventana_de_Donaciones()
        {
            InitializeComponent();
        }

        private void boton_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_donar_Click(object sender, EventArgs e)
        {
            if (!(Categoriadonacion_despliegue.SelectedItem is null))
            {
                if (nombreproducto_texto.Text.Length > 0)
                {
                    if (cantidad_texto.Text.Length > 0)
                    {
                        if (empresa_texto.Text.Length > 0)
                        {
                            if (ciusuario_texto.Text.Length > 0)
                            {
                                if (ciusuario_texto.Text.Length > 8)
                                {
                                    if (direccion_texto.Text.Length > 0)
                                    {
                                        if (cideldestinatario_texto.Text.Length > 0)
                                        {
                                            if (cideldestinatario_texto.Text.Length > 8)
                                            {
                                                if (telefonodeldest_texto.Text.Length > 0)
                                                {
                                                    if (esfragil_texto.Text.Length > 0)
                                                    {
                                                       







                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("¿Es fragil?");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Introduzca el teléfono del destinatario");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("La C.I del destinatario debe tener al menos 8 digitos");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Introduzca la C.I del destinatario");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Introduzca su direccion");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La C.I debe tener al menos 8 digitos");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Introduzca la C.I del usuario");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Introduzca el nombre de la empresa");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Introduzca la cantidad");
                    }
                }
                else
                {
                    MessageBox.Show("Introduzca el nombre del producto");
                }
            }
            else
            {
                MessageBox.Show("Elija la categoria de la donacion");
            }
        }

        private void Ventana_de_Donaciones_Load(object sender, EventArgs e)
        {
            
        }
       

    }
}
