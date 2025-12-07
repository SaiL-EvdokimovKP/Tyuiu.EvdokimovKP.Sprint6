namespace Tyuiu.EvdokimovKP.Sprint6.Task3.V17
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            buttonClick_EKP = new Button();
            Ответ = new GroupBox();
            dataGridRes_EKP = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Ответ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRes_EKP).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonClick_EKP);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 380);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условия";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 187);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 219);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 70);
            textBox1.TabIndex = 1;
            textBox1.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в четвертом столбце.";
            // 
            // buttonClick_EKP
            // 
            buttonClick_EKP.Location = new Point(249, 343);
            buttonClick_EKP.Name = "buttonClick_EKP";
            buttonClick_EKP.Size = new Size(104, 29);
            buttonClick_EKP.TabIndex = 2;
            buttonClick_EKP.Text = "Выполнить";
            buttonClick_EKP.UseVisualStyleBackColor = true;
            buttonClick_EKP.Click += buttonClick_EKP_Click;
            // 
            // Ответ
            // 
            Ответ.Controls.Add(dataGridRes_EKP);
            Ответ.Location = new Point(374, 12);
            Ответ.Name = "Ответ";
            Ответ.Size = new Size(315, 380);
            Ответ.TabIndex = 1;
            Ответ.TabStop = false;
            Ответ.Text = "Ответ";
            // 
            // dataGridRes_EKP
            // 
            dataGridRes_EKP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRes_EKP.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridRes_EKP.Location = new Point(6, 25);
            dataGridRes_EKP.Name = "dataGridRes_EKP";
            dataGridRes_EKP.RowHeadersVisible = false;
            dataGridRes_EKP.RowHeadersWidth = 51;
            dataGridRes_EKP.Size = new Size(304, 347);
            dataGridRes_EKP.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 60;
            // 
            // Column2
            // 
            Column2.HeaderText = "2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 60;
            // 
            // Column3
            // 
            Column3.HeaderText = "3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 60;
            // 
            // Column4
            // 
            Column4.HeaderText = "4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 60;
            // 
            // Column5
            // 
            Column5.HeaderText = "5";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 60;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 404);
            Controls.Add(Ответ);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Ответ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridRes_EKP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button buttonClick_EKP;
        private GroupBox Ответ;
        private DataGridView dataGridRes_EKP;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
