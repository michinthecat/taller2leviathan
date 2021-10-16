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
    public partial class GUI_ConsultarP : Form
    {
        public GUI_ConsultarP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();

            // Double pIdProducto = Convert.ToDouble(textBoxID.Text);

            // Sw_Pro.producto productoObtenido = servicio.obtenerProducto(Convert.ToInt32 (pIdProducto));

            //textBoxNombre.Text = productoObtenido.nombre;
            //textBoxUPC.Text = Convert.ToString(productoObtenido.upc);
            //textBoxPrecio.Text = Convert.ToString(productoObtenido.precioVenta);

            Sw_Pro.SWControladorClient client = new Sw_Pro.SWControladorClient();

            Sw_Pro.producto producto = client.obtenerProducto(Convert.ToInt64(textBoxID.Text));

            if (producto == null)
            {
                MessageBox.Show("No se encontro el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxNombre.Text = producto.nombre;
                textBoxUPC.Text = producto.upc;
                textBoxPrecio.Text = producto.precioVenta.ToString();
            }

        }

        private void GUI_ConsultarP_Load(object sender, EventArgs e)
        {

        }
    }
}
