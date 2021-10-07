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
            Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();

            Double pIdProducto = Convert.ToDouble(textBoxID.Text);

            Sw_Pro.producto productoObtenido = servicio.obtenerProducto(Convert.ToInt32 (pIdProducto));

           textBoxNombre.Text = productoObtenido.nombre;
           textBoxUPC.Text = Convert.ToString(productoObtenido.upc);
           textBoxPrecio.Text = Convert.ToString(productoObtenido.precioVenta);


        }

        private void GUI_ConsultarP_Load(object sender, EventArgs e)
        {

        }
    }
}
