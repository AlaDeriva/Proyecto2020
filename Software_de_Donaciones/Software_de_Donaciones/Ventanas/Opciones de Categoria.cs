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
    public partial class Opciones_de_Categoria : Form
    {

        
        public Opciones_de_Categoria()
        {
            InitializeComponent();
        }

        private void boton_agregarcategoria_Click(object sender, EventArgs e)
        {

            if (textBox3.Text.Length > 0)
            {
                listBox1.Items.Add(textBox3.Text);
                textBox3.Text = "";
                textBox3.Focus();
            }
            else
            {
                MessageBox.Show("Escriba la categoria");
            }

            
        }

        private void boton_modificarcategoria_Click(object sender, EventArgs e)
        {
            Modificar_Nombre_de_la_Categoría nuevaventana = new Modificar_Nombre_de_la_Categoría();
            nuevaventana.Show();
        }

        private void boton_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_eliminarcategoria_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            boton_eliminarcategoria.Enabled = false;
        }

        private void Opciones_de_Categoria_Load(object sender, EventArgs e)
        {
            boton_eliminarcategoria.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            boton_eliminarcategoria.Enabled = true;
           
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
