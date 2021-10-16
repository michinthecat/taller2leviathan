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
            //Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();

            //Double pIdProducto = Convert.ToDouble(textBoxID.Text);

            //Sw_Pro.producto productoObtenido = servicio.obtenerProducto(Convert.ToInt32(pIdProducto));

            //textBoxNombre.Text = productoObtenido.nombre;

            Sw_Pro.SWControladorClient client = new Sw_Pro.SWControladorClient();

            Sw_Pro.producto producto = client.obtenerProducto(Convert.ToInt64(textBoxID.Text));

            if (producto == null)
            {
                MessageBox.Show("No se encontro el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxNombre.Text = producto.nombre;

            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();


            //if (servicio.eliminarProductoPorId(Convert.ToInt32(textBoxIDPro2.Text)) == true)
            //{
            //    MessageBox.Show("Se ha eliminado exitosamente el Producto", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Hubo un error al eliminar el producto, verifica la integridad de la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            Sw_Pro.SWControladorClient client = new Sw_Pro.SWControladorClient();

            Boolean resultado = client.eliminarProductoPorId(Convert.ToInt64(textBoxIDPro2.Text));
            if (resultado == true)
            {
                MessageBox.Show("Se elimino correctamente el producto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Problema en el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
