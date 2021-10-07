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
    public partial class GUI_ConsultarD : Form
    {
        public GUI_ConsultarD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sw_Pro.ControllerClient servicio = new Sw_Pro.ControllerClient();

            int pIdProducto = Convert.ToInt32(textBoxIDPro.Text);
            int pIdPedido = Convert.ToInt32(textBoxIDPedido.Text);

            Sw_Pro.orden ordenObtenido = servicio.obtenerOrden(pIdProducto, pIdPedido);

            textBoxCantidad.Text = Convert.ToString(ordenObtenido.cantidad);
            textBoxPrecio.Text = Convert.ToString(ordenObtenido.precio);
        }
    }
}
