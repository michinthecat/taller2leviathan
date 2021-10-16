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
    public partial class GUI_EliminarD : Form
    {
        public GUI_EliminarD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();

            //int pIdProducto = Convert.ToInt32(textBoxIDPro.Text);
            //int pIdPedido = Convert.ToInt32(textBoxIDPedido.Text);

            //Sw_Pro.orden ordenObtenido = servicio.obtenerOrden(pIdProducto, pIdPedido);

            //textBoxCantidad.Text = Convert.ToString(ordenObtenido.cantidad);
            //textBoxPrecio.Text = Convert.ToString(ordenObtenido.precio);

            Sw_Pro.SWControladorClient servicio = new Sw_Pro.SWControladorClient();
            Sw_Pro.productosPedidos ordenObtenida = servicio.buscarProductoPedido(Convert.ToInt64(textBoxIDPedido.Text),Convert.ToInt64(textBoxIDPro.Text));
            if (ordenObtenida == null)
            {
                MessageBox.Show("No se encontro la orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxCantidad.Text = ordenObtenida.cantidad.ToString();
                textBoxPrecio.Text = ordenObtenida.precio;
                textBoxFecha.Text = ordenObtenida.fecha.ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();         

            //if (servicio.eliminarOrdenPorId(Convert.ToInt32(textBoxIDProDelete.Text), Convert.ToInt32(textBoxPedidoDelete.Text)) == true)
            //{
            //    MessageBox.Show("Se ha eliminado exitosamente el detalle", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Hubo un error al eliminar el detalle, verifica la integridad de la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            Sw_Pro.SWControladorClient servicio = new Sw_Pro.SWControladorClient();
            if (servicio.eliminarOrdenPorId(Convert.ToInt32(textBoxIDPedido.Text), Convert.ToInt32(textBoxIDPro.Text)))
            {
                MessageBox.Show("Se ha eliminado exitosamente el detalle", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al eliminar el detalle, verifica la integridad de la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }
    }
    }

