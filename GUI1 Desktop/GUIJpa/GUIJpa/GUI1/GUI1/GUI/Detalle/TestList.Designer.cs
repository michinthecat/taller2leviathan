
namespace GUI1.GUI.Detalle
{
    partial class TestList
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
            this.dataGridViewTest = new System.Windows.Forms.DataGridView();
            this.listar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTest
            // 
            this.dataGridViewTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTest.Location = new System.Drawing.Point(102, 46);
            this.dataGridViewTest.Name = "dataGridViewTest";
            this.dataGridViewTest.Size = new System.Drawing.Size(576, 267);
            this.dataGridViewTest.TabIndex = 0;
            // 
            // listar
            // 
            this.listar.Location = new System.Drawing.Point(102, 366);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(75, 23);
            this.listar.TabIndex = 1;
            this.listar.Text = "listar";
            this.listar.UseVisualStyleBackColor = true;
            this.listar.Click += new System.EventHandler(this.listar_Click);
            // 
            // TestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.dataGridViewTest);
            this.Name = "TestList";
            this.Text = "TestList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTest;
        private System.Windows.Forms.Button listar;
    }
}