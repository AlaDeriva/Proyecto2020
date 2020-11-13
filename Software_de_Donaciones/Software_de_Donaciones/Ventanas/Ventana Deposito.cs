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
    public partial class Ventana_Deposito : Form
    {
       
        public Ventana_Deposito()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int seleccionada = dgv_datosdeposito.SelectedRows[0].Index;
            DialogResult respuesta = MessageBox.Show(
                "¿Esta seguro que quiere eliminar esta donación?", 
                "Confirmar", 
                MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                dgv_datosdeposito.Rows.Remove(dgv_datosdeposito.CurrentRow);
            }
        }

        private void Ventana_Deposito_Click(object sender, EventArgs e)
        {

        }

        private void boton_opcionesdecategoria_Click(object sender, EventArgs e)
        {
            Opciones_de_Categoria nuevaventana = new Opciones_de_Categoria();
            nuevaventana.ShowDialog();
        }

        private void boton_iralmenuprincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_datosdeposito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           


            boton_eliminardonacion.Enabled = true;
            boton_modificardonacion.Enabled = true;
        }

        private void boton_agregardonacion_Click(object sender, EventArgs e)
        {
            Ventana_de_Donaciones nuevaventana = new Ventana_de_Donaciones();
            nuevaventana.ShowDialog();
        }

        private void dgv_datosdeposito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void boton_modificardonacion_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_datosdeposito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
