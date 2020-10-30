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
    public partial class Registro_Actual_del_Material_Previo_a_la_Llegada_del_Deposito : Form
    {
        public Registro_Actual_del_Material_Previo_a_la_Llegada_del_Deposito()
        {
            InitializeComponent();
        }

        private void boton_iralmenuprincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_informaciondeladonacion_Click(object sender, EventArgs e)
        {
            Información_General_de_la_Donación nuevaventana = new Información_General_de_la_Donación();
            nuevaventana.ShowDialog();
        }
    }
}
