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
        public Menu_Principal()
        {
            InitializeComponent();
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

        }
    }
}
