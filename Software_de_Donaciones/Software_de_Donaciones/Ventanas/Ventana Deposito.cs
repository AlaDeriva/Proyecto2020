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
                //Se elimina la donación
            }
        }
    }
}
