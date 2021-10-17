using GUI1.GUI;
using GUI1.GUI.Detalle;
using GUI1.GUI.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI1
{
    public partial class GUI_Main : Form
    {
        public GUI_Main()
        {
            InitializeComponent();
        }

        private void GUI_Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

           



        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {


            MessageBox.Show("LYJStore Taller 2 fue creado por: \n \n 2220181001 Jhon Bravo \n 2220181028 Valfuryx Paramo \n 2220181010 Jeisson Cortes", "Acerca de UwU", MessageBoxButtons.OK,  MessageBoxIcon.Information);
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ListarP listarP = new GUI_ListarP();
            listarP.Show();
        }

        private void actualizarProductoIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ActualizarP actualizarP = new GUI_ActualizarP();
            actualizarP.Show();
        }

        private void buscarProductoIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ConsultarP consultarP = new GUI_ConsultarP();
            consultarP.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ListarD gUI_ListarD = new GUI_ListarD();
            gUI_ListarD.Show();
        }

        private void consultarDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ConsultarD consultarD = new GUI_ConsultarD();
            consultarD.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_AdicionarP adicionar = new GUI_AdicionarP();
            adicionar.Show();
        }

        private void eliminarPorIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_EliminarP eliminarP = new GUI_EliminarP();
            eliminarP.Show();
        }

        private void graficarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Graficar graficar = new GUI_Graficar();
            graficar.Show();


        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_AdicionarD gUI_AdicionarD = new GUI_AdicionarD();
            gUI_AdicionarD.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_EliminarD gUI_EliminarD = new GUI_EliminarD();
            gUI_EliminarD.Show();
        }

        private void actualizarDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ActualizarD gUI_ActualizarD = new GUI_ActualizarD();
            gUI_ActualizarD.Show();
        }

        
    }
}
