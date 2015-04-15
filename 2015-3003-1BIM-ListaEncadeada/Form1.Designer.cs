namespace _2015_3003_1BIM_ListaEncadeada
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.Organizarbublle = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.TextBox();
            this.NElementos = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // BubbleSort
            // 
            this.BubbleSort.Location = new System.Drawing.Point(195, 6);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(130, 26);
            this.BubbleSort.TabIndex = 6;
            this.BubbleSort.Text = "BubbleSort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // Organizarbublle
            // 
            this.Organizarbublle.Location = new System.Drawing.Point(195, 38);
            this.Organizarbublle.Name = "Organizarbublle";
            this.Organizarbublle.Size = new System.Drawing.Size(130, 29);
            this.Organizarbublle.TabIndex = 7;
            this.Organizarbublle.Text = "Organizar";
            this.Organizarbublle.UseVisualStyleBackColor = true;
            this.Organizarbublle.Click += new System.EventHandler(this.Organizarbublle_Click);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(12, 12);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(125, 20);
            this.num.TabIndex = 9;
            // 
            // NElementos
            // 
            this.NElementos.Location = new System.Drawing.Point(12, 38);
            this.NElementos.Name = "NElementos";
            this.NElementos.Size = new System.Drawing.Size(125, 29);
            this.NElementos.TabIndex = 10;
            this.NElementos.Text = "Adicionar N elementos";
            this.NElementos.UseVisualStyleBackColor = true;
            this.NElementos.Click += new System.EventHandler(this.NElementos_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 127);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Gráfico";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(572, 300);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Número de elementos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.NElementos);
            this.Controls.Add(this.num);
            this.Controls.Add(this.Organizarbublle);
            this.Controls.Add(this.BubbleSort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Lista Encadeada";
            this.Load += new System.EventHandler(this.CarregarPrograma);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.Button Organizarbublle;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Button NElementos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

