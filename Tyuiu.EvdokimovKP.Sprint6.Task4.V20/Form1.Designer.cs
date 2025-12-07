namespace Tyuiu.EvdokimovKP.Sprint6.Task4.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonGo_EKP = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            textBoxResult_EKP = new TextBox();
            groupBox3 = new GroupBox();
            chartResult_EKP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonSave_EKP = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_EKP).BeginInit();
            SuspendLayout();
            // 
            // buttonGo_EKP
            // 
            buttonGo_EKP.Location = new Point(306, 362);
            buttonGo_EKP.Name = "buttonGo_EKP";
            buttonGo_EKP.Size = new Size(104, 29);
            buttonGo_EKP.TabIndex = 0;
            buttonGo_EKP.Text = "Выполнить";
            buttonGo_EKP.UseVisualStyleBackColor = true;
            buttonGo_EKP.Click += buttonGo_EKP_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(buttonGo_EKP);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 397);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 78);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 88);
            textBox1.TabIndex = 2;
            textBox1.Text = "Произвести табулирование функции с шагом 1, на интервале [ -5 , 5 ].\r\nОкруглить до двух знаков после запятой.\r\nПостроить график функции и сохранить в файл.\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(404, 42);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxResult_EKP);
            groupBox2.Location = new Point(438, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(190, 397);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ответ";
            // 
            // textBoxResult_EKP
            // 
            textBoxResult_EKP.Location = new Point(6, 26);
            textBoxResult_EKP.Multiline = true;
            textBoxResult_EKP.Name = "textBoxResult_EKP";
            textBoxResult_EKP.Size = new Size(178, 365);
            textBoxResult_EKP.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonSave_EKP);
            groupBox3.Controls.Add(chartResult_EKP);
            groupBox3.Location = new Point(634, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(464, 397);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "График";
            // 
            // chartResult_EKP
            // 
            chartArea2.Name = "ChartArea1";
            chartResult_EKP.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartResult_EKP.Legends.Add(legend2);
            chartResult_EKP.Location = new Point(6, 34);
            chartResult_EKP.Name = "chartResult_EKP";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartResult_EKP.Series.Add(series2);
            chartResult_EKP.Size = new Size(455, 326);
            chartResult_EKP.TabIndex = 0;
            chartResult_EKP.Text = "chart1";
            // 
            // buttonSave_EKP
            // 
            buttonSave_EKP.Location = new Point(193, 362);
            buttonSave_EKP.Name = "buttonSave_EKP";
            buttonSave_EKP.Size = new Size(94, 29);
            buttonSave_EKP.TabIndex = 1;
            buttonSave_EKP.Text = "Сохранить";
            buttonSave_EKP.UseVisualStyleBackColor = true;
            buttonSave_EKP.Click += buttonSave_EKP_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 421);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult_EKP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGo_EKP;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_EKP;
        private TextBox textBoxResult_EKP;
        private Button buttonSave_EKP;
    }
}
