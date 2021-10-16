using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI1.GUI.Detalle
{
    public partial class GUI_AdicionarD : Form
    {
        public GUI_AdicionarD()
        {
            InitializeComponent();
        }

        private void GUI_AdicionarD_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            //Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();

            //Sw_Pro.orden pOrden= new Sw_Pro.orden();

            //Sw_Pro.producto pProducto = new Sw_Pro.producto();

            //pOrden.pedidoId = Convert.ToInt32(textBoxIDPedido.Text);
            //pOrden.pedidoIdSpecified = true;
            //pProducto.idProducto = Convert.ToInt32(textBoxIDPro.Text);
            //pProducto.idProductoSpecified = true;
            //pOrden.producto = pProducto;
            //pOrden.precio = Convert.ToInt64(textBoxPrecio.Text);
            //pOrden.precioSpecified = true;
            //pOrden.cantidad = Convert.ToInt32(textBoxCantidad.Text);
            //pOrden.cantidadSpecified = true;



            //if (servicio.guardarOrden(pOrden) == true)
            //{
            //    MessageBox.Show("Se ha agregado exitosamente la Orden", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Hubo un error al agrega el Orden, verifica la integridad de la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            Sw_Pro.SWControladorClient servicio = new Sw_Pro.SWControladorClient();
            
            Sw_Pro.productosPedidos pOrden = new Sw_Pro.productosPedidos();


            Sw_Pro.productosPedidosPK productosPedidosPK = new Sw_Pro.productosPedidosPK();
            
            productosPedidosPK.pedidosidPedido = textBoxIDPedido.Text;
            productosPedidosPK.productoidProducto = Convert.ToInt64(textBoxIDPro.Text);

            pOrden.productosPedidosPK = productosPedidosPK;
            pOrden.cantidad = Convert.ToByte(textBoxCantidad.Text);
            pOrden.precio = textBoxPrecio.Text;

            if (servicio.guardarProductoPedido(pOrden) == true)
            {
                MessageBox.Show("Se ha agregado exitosamente la Orden", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al agrega el Orden, verifica la integridad de la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();

            //Double pIdProducto = Convert.ToDouble(textBoxIDPro.Text);

            //Sw_Pro.producto productoObtenido = servicio.obtenerProducto(Convert.ToInt32(pIdProducto));

            //textBoxNombre.Text = productoObtenido.nombre;
            //textBoxUPC.Text = Convert.ToString(productoObtenido.upc);

            Sw_Pro.SWControladorClient servicio = new Sw_Pro.SWControladorClient();
            Sw_Pro.producto producto = servicio.obtenerProducto(Convert.ToInt64(textBoxIDPro.Text));
            if (producto == null)
            {
                MessageBox.Show("No se encontro el producto", ":C", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxNombre.Text = producto.nombre;
            textBoxUPC.Text = producto.upc;

            textBoxIDPro.ReadOnly = true;
            textBoxCantidad.ReadOnly = false;
            textBoxIDPedido.ReadOnly = false;
            textBoxPrecio.ReadOnly = false;
            buttonAdicionar.Enabled = true;
            buttonConsultar.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonConsultar.Enabled = true;
            textBoxIDPro.ReadOnly = false;
            textBoxCantidad.Text = "";
            textBoxIDPedido.Text = "";
            textBoxPrecio.Text = "";
            textBoxCantidad.ReadOnly = true;
            textBoxIDPedido.ReadOnly = true;
            textBoxPrecio.ReadOnly = true;
            buttonAdicionar.Enabled = false;

            textBoxIDPro.Text = "";
            textBoxNombre.Text = "";
            textBoxUPC.Text = "";
              

        }
    }
}
