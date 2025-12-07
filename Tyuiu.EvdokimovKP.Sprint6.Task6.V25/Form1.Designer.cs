namespace Tyuiu.EvdokimovKP.Sprint6.Task6.V25
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            buttonOpenFile_EKP = new Button();
            groupBox3 = new GroupBox();
            groupBox5 = new GroupBox();
            textBoxResult_EKP = new TextBox();
            groupBox4 = new GroupBox();
            textBox2 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(7, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1100, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1088, 81);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(buttonOpenFile_EKP);
            groupBox2.Location = new Point(7, -4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1100, 103);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(94, 16);
            button1.Name = "button1";
            button1.Size = new Size(86, 81);
            button1.TabIndex = 1;
            toolTip1.SetToolTip(button1, "Произвусти поиск");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonOpenFile_EKP
            // 
            buttonOpenFile_EKP.Location = new Point(5, 16);
            buttonOpenFile_EKP.Name = "buttonOpenFile_EKP";
            buttonOpenFile_EKP.Size = new Size(83, 81);
            buttonOpenFile_EKP.TabIndex = 0;
            toolTip1.SetToolTip(buttonOpenFile_EKP, "Открыть файл\r\nВыберите файл");
            buttonOpenFile_EKP.UseVisualStyleBackColor = true;
            buttonOpenFile_EKP.Click += buttonOpenFile_EKP_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(7, 224);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1100, 299);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBoxResult_EKP);
            groupBox5.Location = new Point(552, 17);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(540, 265);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ответ";
            // 
            // textBoxResult_EKP
            // 
            textBoxResult_EKP.Location = new Point(0, 26);
            textBoxResult_EKP.Multiline = true;
            textBoxResult_EKP.Name = "textBoxResult_EKP";
            textBoxResult_EKP.Size = new Size(540, 239);
            textBoxResult_EKP.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Location = new Point(5, 17);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(541, 265);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Содержимое файла";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1, 26);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(540, 239);
            textBox2.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 530);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonOpenFile_EKP;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox5;
        private TextBox textBoxResult_EKP;
        private GroupBox groupBox4;
        private TextBox textBox2;
        private ToolTip toolTip1;
        private Button button1;
    }
}
