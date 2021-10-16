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
    public partial class GUI_ActualizarP : Form
    {
        public GUI_ActualizarP()
        {
            InitializeComponent();
        }

        private void GUI_ActualizarP_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();

            //Double pIdProducto = Convert.ToDouble(textBoxID.Text);

            //Sw_Pro.producto productoObtenido = servicio.obtenerProducto(Convert.ToInt32(pIdProducto));

            //textBoxNombre.Text = productoObtenido.nombre;
            //textBoxUPC.Text = Convert.ToString(productoObtenido.upc);
            //textBoxPrecio.Text = Convert.ToString(productoObtenido.precioVenta);

            Sw_Pro.SWControladorClient servicio = new Sw_Pro.SWControladorClient();

            Sw_Pro.producto productoObtenido = servicio.obtenerProducto(Convert.ToInt64(textBoxID.Text));

            if (productoObtenido == null)
            {
                MessageBox.Show("No se encontro el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBoxNombre.Text = productoObtenido.nombre;
            textBoxUPC.Text = Convert.ToString(productoObtenido.upc);
            textBoxPrecio.Text = Convert.ToString(productoObtenido.precioVenta);

            textBoxID.ReadOnly = true;
            labelEdit.Text = "Indica El Nuevo Precio";
            textBoxPrecioNew.ReadOnly = false;
            buttonActualizar.Enabled = true;
            buttonConsultar.Enabled = false;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            textBoxID.ReadOnly = false;
            textBoxPrecioNew.ReadOnly = true;
            textBoxID.Text = "";
            textBoxNombre.Text = "";
            textBoxPrecio.Text = "";
            textBoxUPC.Text = "";
            textBoxPrecioNew.Text = "";
            buttonActualizar.Enabled = false;
            labelEdit.Text = "";
            buttonConsultar.Enabled = true;


        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Sw_Pro.SWControladorClient servicio = new Sw_Pro.SWControladorClient();

            Sw_Pro.producto pProducto = new Sw_Pro.producto();

            pProducto.idProducto = Convert.ToInt32(textBoxID.Text);
            pProducto.nombre = textBoxNombre.Text;
            pProducto.idProductoSpecified = true;            
            pProducto.precioVenta = Convert.ToInt64(textBoxPrecioNew.Text);
            pProducto.upc = textBoxUPC.Text;


            if (servicio.actualizarPrecioVentaProducto(pProducto))
            {
                MessageBox.Show("Se ha modificado exitosamente el Producto " + textBoxID.Text + "", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonRestart_Click(sender, e);

            }
            else
            {
                MessageBox.Show("No se ha podido modificar el producto " + textBoxID.Text + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





        }
    }
}
