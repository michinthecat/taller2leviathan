
namespace GUI1.GUI
{
    partial class GUI_Graficar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartTortita = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTortita)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTortita
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTortita.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTortita.Legends.Add(legend1);
            this.chartTortita.Location = new System.Drawing.Point(12, 12);
            this.chartTortita.Name = "chartTortita";
            this.chartTortita.Size = new System.Drawing.Size(817, 436);
            this.chartTortita.TabIndex = 0;
            this.chartTortita.Text = "chart1";
            this.chartTortita.Click += new System.EventHandler(this.chartTortita_Click);
            // 
            // GUI_Graficar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 455);
            this.Controls.Add(this.chartTortita);
            this.Name = "GUI_Graficar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafica";
            this.Load += new System.EventHandler(this.GUI_Graficar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTortita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTortita;
    }
}