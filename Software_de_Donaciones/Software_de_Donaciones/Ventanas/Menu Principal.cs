using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_de_Donaciones.Ventanas;

namespace Software_de_Donaciones
{
    public partial class Menu_Principal : Form
    {
        private Inicio ventanainicio = null;

        public Inicio Ventanainicio { get => ventanainicio; set => ventanainicio = value; }

        public Menu_Principal(Inicio ventana)
        {
            InitializeComponent();
            this.Ventanainicio = ventana;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void boton_accederaldeposito_Click(object sender, EventArgs e)
        {
            Ventana_Deposito nuevaventana = new Ventana_Deposito();
            nuevaventana.ShowDialog();
        }

        private void boton_enviardonacion_Click(object sender, EventArgs e)
        {
            Ventana_de_Donaciones nuevaventana = new Ventana_de_Donaciones();

            nuevaventana.ShowDialog();
        }

        private void boton_cerrarsesion_Click(object sender, EventArgs e)
        {
            Ventanainicio.Show();
            this.Close();
        }

        private void boton_versubordinados_Click(object sender, EventArgs e)
        {
            Lista_de_Subordinados nuevaventana = new Lista_de_Subordinados();
            nuevaventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro_Actual_del_Material_Previo_a_la_Llegada_del_Deposito nuevaventana = new Registro_Actual_del_Material_Previo_a_la_Llegada_del_Deposito();
            nuevaventana.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Detalles_del_Circunstancias_de_Salida nuevaventana = new Detalles_del_Circunstancias_de_Salida();
            nuevaventana.ShowDialog();
        }
    }
}
