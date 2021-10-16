
namespace GUI1
{
    partial class GUI_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.holaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPorIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductoIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProductoIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holaToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.detalleToolStripMenuItem,
            this.graficarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // holaToolStripMenuItem
            // 
            this.holaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            this.holaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.holaToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarProductoToolStripMenuItem,
            this.eliminarPorIDToolStripMenuItem,
            this.listarProductoToolStripMenuItem,
            this.buscarProductoIDToolStripMenuItem,
            this.actualizarProductoIDToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // adicionarProductoToolStripMenuItem
            // 
            this.adicionarProductoToolStripMenuItem.Name = "adicionarProductoToolStripMenuItem";
            this.adicionarProductoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.adicionarProductoToolStripMenuItem.Text = "Adicionar Producto";
            this.adicionarProductoToolStripMenuItem.Click += new System.EventHandler(this.adicionarProductoToolStripMenuItem_Click);
            // 
            // eliminarPorIDToolStripMenuItem
            // 
            this.eliminarPorIDToolStripMenuItem.Name = "eliminarPorIDToolStripMenuItem";
            this.eliminarPorIDToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.eliminarPorIDToolStripMenuItem.Text = "Eliminar Producto (ID)";
            this.eliminarPorIDToolStripMenuItem.Click += new System.EventHandler(this.eliminarPorIDToolStripMenuItem_Click);
            // 
            // listarProductoToolStripMenuItem
            // 
            this.listarProductoToolStripMenuItem.Name = "listarProductoToolStripMenuItem";
            this.listarProductoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.listarProductoToolStripMenuItem.Text = "Listar Producto (Nombre)";
            this.listarProductoToolStripMenuItem.Click += new System.EventHandler(this.listarProductoToolStripMenuItem_Click);
            // 
            // buscarProductoIDToolStripMenuItem
            // 
            this.buscarProductoIDToolStripMenuItem.Name = "buscarProductoIDToolStripMenuItem";
            this.buscarProductoIDToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.buscarProductoIDToolStripMenuItem.Text = "Consultar Producto (ID)";
            this.buscarProductoIDToolStripMenuItem.Click += new System.EventHandler(this.buscarProductoIDToolStripMenuItem_Click);
            // 
            // actualizarProductoIDToolStripMenuItem
            // 
            this.actualizarProductoIDToolStripMenuItem.Name = "actualizarProductoIDToolStripMenuItem";
            this.actualizarProductoIDToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.actualizarProductoIDToolStripMenuItem.Text = "Actualizar Producto (Precio)";
            this.actualizarProductoIDToolStripMenuItem.Click += new System.EventHandler(this.actualizarProductoIDToolStripMenuItem_Click);
            // 
            // detalleToolStripMenuItem
            // 
            this.detalleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.consultarDetalleToolStripMenuItem,
            this.actualizarDetalleToolStripMenuItem,
            this.testToolStripMenuItem});
            this.detalleToolStripMenuItem.Name = "detalleToolStripMenuItem";
            this.detalleToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.detalleToolStripMenuItem.Text = "Detalle (Productos-Pedidos)";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar Detalle";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar Detalle (ID\'s)";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.listarToolStripMenuItem.Text = "Listar Detalle (ID Producto)";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // consultarDetalleToolStripMenuItem
            // 
            this.consultarDetalleToolStripMenuItem.Name = "consultarDetalleToolStripMenuItem";
            this.consultarDetalleToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.consultarDetalleToolStripMenuItem.Text = "Consultar Detalle (ID\'s)";
            this.consultarDetalleToolStripMenuItem.Click += new System.EventHandler(this.consultarDetalleToolStripMenuItem_Click);
            // 
            // actualizarDetalleToolStripMenuItem
            // 
            this.actualizarDetalleToolStripMenuItem.Name = "actualizarDetalleToolStripMenuItem";
            this.actualizarDetalleToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.actualizarDetalleToolStripMenuItem.Text = "Actualizar Detalle (Cantidad)";
            this.actualizarDetalleToolStripMenuItem.Click += new System.EventHandler(this.actualizarDetalleToolStripMenuItem_Click);
            // 
            // graficarToolStripMenuItem
            // 
            this.graficarToolStripMenuItem.Name = "graficarToolStripMenuItem";
            this.graficarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.graficarToolStripMenuItem.Text = "Graficar";
            this.graficarToolStripMenuItem.Click += new System.EventHandler(this.graficarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "AAA = Productos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "CCC = Tabla Detalle (Productos-Pedidos)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "BBB = Pedidos";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Maroon;
            this.imageList1.Images.SetKeyName(0, "logo-gris.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI1.Properties.Resources.logo_gris;
            this.pictureBox1.Location = new System.Drawing.Point(376, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // GUI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(670, 151);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LYJ Store Ft. Jeisson";
            this.Load += new System.EventHandler(this.GUI_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem holaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPorIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarProductoIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProductoToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem buscarProductoIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficarToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}

