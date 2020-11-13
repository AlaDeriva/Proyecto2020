using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_de_Donaciones.Ventanas
{
    public partial class Lista_de_Subordinados : Form
    {
        int i = 1;
        int posocion;
        public Lista_de_Subordinados()
        {
            InitializeComponent();
        }

        private void Lista_de_Subordinados_Load(object sender, EventArgs e)
        {
            boton_despedir.Enabled = false;
            boton_modificar.Enabled = false;
            boton_seleccionarf.Enabled = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void boton_iralmenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            if (nombre_texto.Text.Length > 0)
            {
                if (apellido_texto.Text.Length > 0)
                {
                    if (ci_texto.Text.Length > 0)
                    {
                        if (ci_texto.Text.Length > 7)
                        {
                            if (cargo_texto.Text.Length > 0)
                            {
                                if (telefono_texto.Text.Length > 0)
                                {


                                    string nombre, apellido, ci, cargo, telefono;

                                    nombre = nombre_texto.Text;
                                    apellido = apellido_texto.Text;
                                    ci = ci_texto.Text;
                                    cargo = cargo_texto.Text;
                                    telefono = telefono_texto.Text;
                                    dgv_subordinados.Rows.Add(i + "", nombre, apellido, ci, cargo, telefono);
                                    i = i + 1;
                                    limpiar();
                                    nombre_texto.Focus();




                                    void limpiar()
                                    {
                                        
                                        nombre_texto.Text = "";
                                        apellido_texto.Text = "";
                                        ci_texto.Text = "";
                                        cargo_texto.Text = "";
                                        telefono_texto.Text = "";

                                    }
                                    


                                }
                                else
                                {
                                    MessageBox.Show("Escriba el teléfono");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Escriba el cargo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("la C.I debe tener almenos 8 digitos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Escriba la C.I");
                    }
                }
                else
                {
                    MessageBox.Show("Escriba el apellido");
                }
            }
            else
            {
                MessageBox.Show("Escriba el nombre");
            }






        }

        private void boton_despedir_Click(object sender, EventArgs e)
        {
           
                dgv_subordinados.Rows.Remove(dgv_subordinados.CurrentRow);
         
            

            boton_despedir.Enabled = false;
            boton_modificar.Enabled = false;
            boton_seleccionarf.Enabled = false;
            boton_agregar.Enabled = true;
        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_subordinados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            boton_despedir.Enabled = true;
            boton_modificar.Enabled = true;
            boton_seleccionarf.Enabled = true;
           





        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                string nombre, apellido, ci, cargo, telefono;
                nombre = nombre_texto.Text;
                apellido = apellido_texto.Text;
                ci = ci_texto.Text;
                cargo = cargo_texto.Text;
                telefono = telefono_texto.Text;
                dgv_subordinados[1, posocion].Value = nombre_texto.Text;
                dgv_subordinados[2, posocion].Value = apellido_texto.Text;
                dgv_subordinados[3, posocion].Value = ci_texto.Text;
                dgv_subordinados[4, posocion].Value = cargo_texto.Text;
                dgv_subordinados[5, posocion].Value = telefono_texto.Text;
                limpiar();
                nombre_texto.Focus();

                void limpiar()
                {

                    nombre_texto.Text = "";
                    apellido_texto.Text = "";
                    ci_texto.Text = "";
                    cargo_texto.Text = "";
                    telefono_texto.Text = "";

                }
            


           

            boton_despedir.Enabled = false;
            boton_modificar.Enabled = false;
            boton_seleccionarf.Enabled = false;
            boton_agregar.Enabled = true;







        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            posocion = dgv_subordinados.CurrentRow.Index;
            nombre_texto.Text = dgv_subordinados[1, posocion].Value.ToString();
            apellido_texto.Text = dgv_subordinados[2, posocion].Value.ToString();
            ci_texto.Text = dgv_subordinados[3, posocion].Value.ToString();
            cargo_texto.Text = dgv_subordinados[4, posocion].Value.ToString();
            telefono_texto.Text = dgv_subordinados[5, posocion].Value.ToString();
            nombre_texto.Focus();

            boton_agregar.Enabled = false;

        }
    }
}
