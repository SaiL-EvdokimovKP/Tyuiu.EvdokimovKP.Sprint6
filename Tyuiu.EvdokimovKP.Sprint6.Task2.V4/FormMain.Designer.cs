namespace Tyuiu.EvdokimovKP.Sprint6.Task2.V4
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox4 = new GroupBox();
            pictureBox1 = new PictureBox();
            buttonGoRes_EKP = new Button();
            groupBox2 = new GroupBox();
            dataGridViewResult_EKP = new DataGridView();
            groupBox3 = new GroupBox();
            chartSin_EKP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Y = new DataGridViewTextBoxColumn();
            X = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_EKP).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartSin_EKP).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(buttonGoRes_EKP);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 393);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "Табулировать функцию с шагом 1, на инервале [-5 , 5]";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Location = new Point(16, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(357, 125);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Функция";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 48);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonGoRes_EKP
            // 
            buttonGoRes_EKP.Location = new Point(136, 329);
            buttonGoRes_EKP.Name = "buttonGoRes_EKP";
            buttonGoRes_EKP.Size = new Size(137, 40);
            buttonGoRes_EKP.TabIndex = 0;
            buttonGoRes_EKP.Text = "Вычислить";
            buttonGoRes_EKP.UseVisualStyleBackColor = true;
            buttonGoRes_EKP.Click += buttonGoRes_EKP_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewResult_EKP);
            groupBox2.Location = new Point(434, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(202, 393);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Результат";
            // 
            // dataGridViewResult_EKP
            // 
            dataGridViewResult_EKP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_EKP.Columns.AddRange(new DataGridViewColumn[] { Y, X });
            dataGridViewResult_EKP.Location = new Point(6, 26);
            dataGridViewResult_EKP.Name = "dataGridViewResult_EKP";
            dataGridViewResult_EKP.RowHeadersVisible = false;
            dataGridViewResult_EKP.RowHeadersWidth = 51;
            dataGridViewResult_EKP.Size = new Size(190, 361);
            dataGridViewResult_EKP.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chartSin_EKP);
            groupBox3.Location = new Point(642, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(433, 393);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "График";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // chartSin_EKP
            // 
            chartArea1.Name = "ChartArea1";
            chartSin_EKP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartSin_EKP.Legends.Add(legend1);
            chartSin_EKP.Location = new Point(6, 53);
            chartSin_EKP.Name = "chartSin_EKP";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartSin_EKP.Series.Add(series1);
            chartSin_EKP.Size = new Size(448, 284);
            chartSin_EKP.TabIndex = 0;
            chartSin_EKP.Text = "chart1";
            // 
            // Y
            // 
            Y.HeaderText = "F(x)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.ReadOnly = true;
            Y.Width = 85;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 85;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 417);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_EKP).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartSin_EKP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonGoRes_EKP;
        private TextBox textBox1;
        private GroupBox groupBox4;
        private PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSin_EKP;
        private DataGridView dataGridViewResult_EKP;
        private DataGridViewTextBoxColumn Y;
        private DataGridViewTextBoxColumn X;
    }
}
