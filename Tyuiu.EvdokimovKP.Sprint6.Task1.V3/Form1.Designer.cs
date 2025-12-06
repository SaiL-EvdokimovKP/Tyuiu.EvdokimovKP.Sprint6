namespace Tyuiu.EvdokimovKP.Sprint6.Task1.V3
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
            groupBoxInfo_EKP = new GroupBox();
            buttonClick_EKP = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxResult_EKP = new GroupBox();
            textBoxResult_EKP = new TextBox();
            groupBoxInfo_EKP.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxResult_EKP.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInfo_EKP
            // 
            groupBoxInfo_EKP.Controls.Add(buttonClick_EKP);
            groupBoxInfo_EKP.Controls.Add(textBox1);
            groupBoxInfo_EKP.Controls.Add(groupBox1);
            groupBoxInfo_EKP.Location = new Point(12, 12);
            groupBoxInfo_EKP.Name = "groupBoxInfo_EKP";
            groupBoxInfo_EKP.Size = new Size(479, 376);
            groupBoxInfo_EKP.TabIndex = 0;
            groupBoxInfo_EKP.TabStop = false;
            groupBoxInfo_EKP.Text = "Условия";
            // 
            // buttonClick_EKP
            // 
            buttonClick_EKP.Location = new Point(336, 331);
            buttonClick_EKP.Name = "buttonClick_EKP";
            buttonClick_EKP.Size = new Size(136, 39);
            buttonClick_EKP.TabIndex = 3;
            buttonClick_EKP.Text = "Выполнить";
            buttonClick_EKP.UseVisualStyleBackColor = true;
            buttonClick_EKP.Click += buttonClick_EKP_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(466, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Произвести табулирование функции с шагом 1 на отрезке [-5 , 5]";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(6, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 80);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Функция:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 46);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBoxResult_EKP
            // 
            groupBoxResult_EKP.Controls.Add(textBoxResult_EKP);
            groupBoxResult_EKP.Location = new Point(497, 12);
            groupBoxResult_EKP.Name = "groupBoxResult_EKP";
            groupBoxResult_EKP.Size = new Size(291, 377);
            groupBoxResult_EKP.TabIndex = 1;
            groupBoxResult_EKP.TabStop = false;
            groupBoxResult_EKP.Text = "Результат";
            // 
            // textBoxResult_EKP
            // 
            textBoxResult_EKP.Location = new Point(6, 26);
            textBoxResult_EKP.Multiline = true;
            textBoxResult_EKP.Name = "textBoxResult_EKP";
            textBoxResult_EKP.Size = new Size(279, 345);
            textBoxResult_EKP.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(groupBoxResult_EKP);
            Controls.Add(groupBoxInfo_EKP);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxInfo_EKP.ResumeLayout(false);
            groupBoxInfo_EKP.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxResult_EKP.ResumeLayout(false);
            groupBoxResult_EKP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInfo_EKP;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBoxResult_EKP;
        private Button buttonClick_EKP;
        private TextBox textBox1;
        private TextBox textBoxResult_EKP;
    }
}
