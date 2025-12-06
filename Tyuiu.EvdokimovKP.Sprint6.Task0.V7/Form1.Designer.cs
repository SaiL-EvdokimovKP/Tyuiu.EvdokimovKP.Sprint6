namespace Tyuiu.EvdokimovKP.Sprint6.Task0.V7
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
            buttonRES_EKP = new Button();
            groupBoxInfo_EKP = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            textBoxResult_EKP = new TextBox();
            groupBoxInfo_EKP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRES_EKP
            // 
            buttonRES_EKP.Location = new Point(332, 141);
            buttonRES_EKP.Name = "buttonRES_EKP";
            buttonRES_EKP.Size = new Size(106, 29);
            buttonRES_EKP.TabIndex = 0;
            buttonRES_EKP.Text = "Выполнить";
            buttonRES_EKP.UseVisualStyleBackColor = true;
            buttonRES_EKP.Click += buttonRES_EKP_Click;
            // 
            // groupBoxInfo_EKP
            // 
            groupBoxInfo_EKP.Controls.Add(textBox1);
            groupBoxInfo_EKP.Controls.Add(buttonRES_EKP);
            groupBoxInfo_EKP.Controls.Add(pictureBox1);
            groupBoxInfo_EKP.Location = new Point(12, 12);
            groupBoxInfo_EKP.Name = "groupBoxInfo_EKP";
            groupBoxInfo_EKP.Size = new Size(776, 176);
            groupBoxInfo_EKP.TabIndex = 1;
            groupBoxInfo_EKP.TabStop = false;
            groupBoxInfo_EKP.Text = "Условия";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(606, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 76);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "Вычислить значение выражение, при x = 3";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxResult_EKP);
            groupBox1.Location = new Point(15, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(773, 116);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Значение выражения";
            // 
            // textBoxResult_EKP
            // 
            textBoxResult_EKP.Location = new Point(20, 51);
            textBoxResult_EKP.Name = "textBoxResult_EKP";
            textBoxResult_EKP.Size = new Size(738, 27);
            textBoxResult_EKP.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 322);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxInfo_EKP);
            Name = "Form1";
            Text = "Form1";
            groupBoxInfo_EKP.ResumeLayout(false);
            groupBoxInfo_EKP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRES_EKP;
        private GroupBox groupBoxInfo_EKP;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox textBoxResult_EKP;
    }
}
