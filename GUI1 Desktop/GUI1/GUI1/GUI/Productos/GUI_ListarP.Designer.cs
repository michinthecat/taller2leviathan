
namespace GUI1.GUI.Productos
{
    partial class GUI_ListarP
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
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.listarProductosPorNombreResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreP = new System.Windows.Forms.TextBox();
            this.ButtonMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarProductosPorNombreResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Location = new System.Drawing.Point(27, 22);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.Size = new System.Drawing.Size(746, 286);
            this.dataGridProductos.TabIndex = 0;
            this.dataGridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listarProductosPorNombreResponseBindingSource
            // 
            this.listarProductosPorNombreResponseBindingSource.DataSource = typeof(GUI1.Sw_Pro.listarProductosPorNombreResponse);
            this.listarProductosPorNombreResponseBindingSource.CurrentChanged += new System.EventHandler(this.listarProductosPorNombreResponseBindingSource_CurrentChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Producto:";
            // 
            // textBoxNombreP
            // 
            this.textBoxNombreP.Location = new System.Drawing.Point(308, 344);
            this.textBoxNombreP.Name = "textBoxNombreP";
            this.textBoxNombreP.Size = new System.Drawing.Size(172, 20);
            this.textBoxNombreP.TabIndex = 2;
            // 
            // ButtonMostrar
            // 
            this.ButtonMostrar.Location = new System.Drawing.Point(499, 342);
            this.ButtonMostrar.Name = "ButtonMostrar";
            this.ButtonMostrar.Size = new System.Drawing.Size(75, 23);
            this.ButtonMostrar.TabIndex = 3;
            this.ButtonMostrar.Text = "Mostrar";
            this.ButtonMostrar.UseVisualStyleBackColor = true;
            this.ButtonMostrar.Click += new System.EventHandler(this.ButtonMostrar_Click);
            // 
            // GUI_ListarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.ButtonMostrar);
            this.Controls.Add(this.textBoxNombreP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProductos);
            this.Name = "GUI_ListarP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarProductosPorNombreResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.BindingSource listarProductosPorNombreResponseBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreP;
        private System.Windows.Forms.Button ButtonMostrar;
    }
}