
namespace GUI1.GUI.Detalle
{
    partial class GUI_EliminarD
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
            this.textBoxIDPedido = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDPro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPedidoDelete = new System.Windows.Forms.TextBox();
            this.textBoxIDProDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxIDPedido
            // 
            this.textBoxIDPedido.Location = new System.Drawing.Point(86, 36);
            this.textBoxIDPedido.Name = "textBoxIDPedido";
            this.textBoxIDPedido.Size = new System.Drawing.Size(39, 20);
            this.textBoxIDPedido.TabIndex = 26;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(60, 127);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.ReadOnly = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(153, 20);
            this.textBoxPrecio.TabIndex = 25;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(60, 90);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.ReadOnly = true;
            this.textBoxCantidad.Size = new System.Drawing.Size(153, 20);
            this.textBoxCantidad.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cantidad:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ID Pedido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Producto:";
            // 
            // textBoxIDPro
            // 
            this.textBoxIDPro.Location = new System.Drawing.Point(86, 9);
            this.textBoxIDPro.Name = "textBoxIDPro";
            this.textBoxIDPro.Size = new System.Drawing.Size(39, 20);
            this.textBoxIDPro.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.textBoxPrecio);
            this.panel1.Controls.Add(this.textBoxIDPedido);
            this.panel1.Controls.Add(this.textBoxIDPro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxCantidad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 160);
            this.panel1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 73);
            this.label5.TabIndex = 28;
            this.label5.Text = "➾";
            // 
            // textBoxPedidoDelete
            // 
            this.textBoxPedidoDelete.Location = new System.Drawing.Point(399, 97);
            this.textBoxPedidoDelete.Name = "textBoxPedidoDelete";
            this.textBoxPedidoDelete.Size = new System.Drawing.Size(39, 20);
            this.textBoxPedidoDelete.TabIndex = 33;
            // 
            // textBoxIDProDelete
            // 
            this.textBoxIDProDelete.Location = new System.Drawing.Point(399, 70);
            this.textBoxIDProDelete.Name = "textBoxIDProDelete";
            this.textBoxIDProDelete.Size = new System.Drawing.Size(39, 20);
            this.textBoxIDProDelete.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "ID Pedido:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(456, 82);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(69, 23);
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // GUI_EliminarD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 183);
            this.Controls.Add(this.textBoxPedidoDelete);
            this.Controls.Add(this.textBoxIDProDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_EliminarD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Detalle (ID\'s)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIDPedido;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDPro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPedidoDelete;
        private System.Windows.Forms.TextBox textBoxIDProDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDelete;
    }
}