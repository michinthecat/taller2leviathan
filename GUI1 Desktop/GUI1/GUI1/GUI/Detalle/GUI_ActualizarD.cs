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
    public partial class GUI_ActualizarD : Form
    {
        public GUI_ActualizarD()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();

            int pIdProducto = Convert.ToInt32(textBoxIDPro.Text);
            int pIdPedido = Convert.ToInt32(textBoxIDPedido.Text);

            Sw_Pro.orden ordenObtenido = servicio.obtenerOrden(pIdProducto, pIdPedido);

            textBoxCantidad.Text = Convert.ToString(ordenObtenido.cantidad);
            textBoxPrecio.Text = Convert.ToString(ordenObtenido.precio);

            labelEdit.Visible = true;
            buttonActualizar.Enabled = true;
            textBoxNewCantidad.ReadOnly = false;
            textBoxIDPro.ReadOnly = true;
            textBoxIDPedido.ReadOnly = true;
            buttonConsultar.Enabled = false;

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
           Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();

            Sw_Pro.orden pOrden = new Sw_Pro.orden();

            Sw_Pro.producto pProducto = new Sw_Pro.producto();

            pOrden.pedidoId = Convert.ToInt32(textBoxIDPedido.Text);
            pOrden.pedidoIdSpecified = true;
            pProducto.idProducto = Convert.ToInt32(textBoxIDPro.Text);
            pProducto.idProductoSpecified = true;
            pOrden.producto = pProducto;
            pOrden.precio = Convert.ToInt64(textBoxPrecio.Text);
            pOrden.precioSpecified = true;
            pOrden.cantidad = Convert.ToInt32(textBoxNewCantidad.Text);
            pOrden.cantidadSpecified = true;

            servicio.actualizarCatntidadOrden(Convert.ToInt32(textBoxIDPro.Text), Convert.ToInt32(textBoxIDPedido.Text), pOrden);
            MessageBox.Show("Se ha modificado exitosamente el Detalle", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            buttonRestart_Click(sender, e);
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            textBoxIDPro.Text = "";
            textBoxIDPedido.Text = "";           
            buttonActualizar.Enabled = false;
            buttonConsultar.Enabled = true;
            textBoxCantidad.Text = "";
            textBoxPrecio.Text = "";
            textBoxIDPro.ReadOnly = false;
            textBoxIDPedido.ReadOnly = false;
            labelEdit.Visible = false;
            textBoxNewCantidad.Text = "";
            textBoxNewCantidad.ReadOnly = true;

        }
    }
}
