namespace Tyuiu.EvdokimovKP.Sprint6.Task5.V28
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            buttonGo_EKP = new Button();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridViewRes_EKP = new DataGridView();
            groupBox3 = new GroupBox();
            chartRes_EKP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Numb = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_EKP).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_EKP).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonGo_EKP);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 417);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // buttonGo_EKP
            // 
            buttonGo_EKP.Location = new Point(139, 382);
            buttonGo_EKP.Name = "buttonGo_EKP";
            buttonGo_EKP.Size = new Size(105, 29);
            buttonGo_EKP.TabIndex = 1;
            buttonGo_EKP.Text = "Выполнить";
            buttonGo_EKP.UseVisualStyleBackColor = true;
            buttonGo_EKP.Click += buttonGo_EKP_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(238, 107);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V28.txt. Вывести в dataGridView. Вывести все числа, меньше 10. Построить диаграмму по этим значениям.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewRes_EKP);
            groupBox2.Location = new Point(268, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(193, 417);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ответ";
            // 
            // dataGridViewRes_EKP
            // 
            dataGridViewRes_EKP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_EKP.Columns.AddRange(new DataGridViewColumn[] { Numb, Column1 });
            dataGridViewRes_EKP.Location = new Point(6, 26);
            dataGridViewRes_EKP.Name = "dataGridViewRes_EKP";
            dataGridViewRes_EKP.RowHeadersVisible = false;
            dataGridViewRes_EKP.RowHeadersWidth = 51;
            dataGridViewRes_EKP.Size = new Size(180, 385);
            dataGridViewRes_EKP.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chartRes_EKP);
            groupBox3.Location = new Point(467, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(569, 417);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "График";
            // 
            // chartRes_EKP
            // 
            chartArea1.Name = "ChartArea1";
            chartRes_EKP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRes_EKP.Legends.Add(legend1);
            chartRes_EKP.Location = new Point(6, 26);
            chartRes_EKP.Name = "chartRes_EKP";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes_EKP.Series.Add(series1);
            chartRes_EKP.Size = new Size(557, 385);
            chartRes_EKP.TabIndex = 0;
            chartRes_EKP.Text = "chart1";
            // 
            // Numb
            // 
            Numb.HeaderText = "№";
            Numb.MinimumWidth = 6;
            Numb.Name = "Numb";
            Numb.ReadOnly = true;
            Numb.Width = 50;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ответ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 441);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_EKP).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartRes_EKP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewRes_EKP;
        private GroupBox groupBox3;
        private Button buttonGo_EKP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_EKP;
        private DataGridViewTextBoxColumn Numb;
        private DataGridViewTextBoxColumn Column1;
    }
}
