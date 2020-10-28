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
            Agregar_Nombre_de_la_Categoría nuevaventana = new Agregar_Nombre_de_la_Categoría();
            nuevaventana.Show();
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
    }
}
