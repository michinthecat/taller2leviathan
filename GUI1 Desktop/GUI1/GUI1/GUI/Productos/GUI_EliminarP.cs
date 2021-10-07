using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI1.GUI.Productos
{
    public partial class GUI_EliminarP : Form
    {
        public GUI_EliminarP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();

            Double pIdProducto = Convert.ToDouble(textBoxID.Text);

            Sw_Pro.producto productoObtenido = servicio.obtenerProducto(Convert.ToInt32(pIdProducto));

            textBoxNombre.Text = productoObtenido.nombre;           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();
            

            if (servicio.eliminarProductoPorId(Convert.ToInt32(textBoxIDPro2.Text)) == true)
            {
                MessageBox.Show("Se ha eliminado exitosamente el Producto", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al eliminar el producto, verifica la integridad de la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
