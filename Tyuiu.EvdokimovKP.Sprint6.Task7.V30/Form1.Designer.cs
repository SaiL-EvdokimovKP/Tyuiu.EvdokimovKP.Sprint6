namespace Tyuiu.EvdokimovKP.Sprint6.Task7.V30
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
            groupBox5 = new GroupBox();
            dataGridViewRes_EKP = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            buttonSave_EKP = new Button();
            buttonRes_EKP = new Button();
            buttonOpenFile_EKP = new Button();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            openFileDialog2 = new OpenFileDialog();
            Column1 = new DataGridViewTextBoxColumn();
            Column1M = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_EKP).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 430);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(277, 209);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Location = new Point(443, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(642, 430);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ответ";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewRes_EKP);
            groupBox5.Location = new Point(314, 26);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(322, 398);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Вывод";
            // 
            // dataGridViewRes_EKP
            // 
            dataGridViewRes_EKP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_EKP.Columns.AddRange(new DataGridViewColumn[] { Column1M });
            dataGridViewRes_EKP.Location = new Point(6, 26);
            dataGridViewRes_EKP.Name = "dataGridViewRes_EKP";
            dataGridViewRes_EKP.RowHeadersVisible = false;
            dataGridViewRes_EKP.RowHeadersWidth = 51;
            dataGridViewRes_EKP.Size = new Size(310, 366);
            dataGridViewRes_EKP.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(6, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(302, 398);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Воод";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(290, 366);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonSave_EKP);
            groupBox3.Controls.Add(buttonRes_EKP);
            groupBox3.Controls.Add(buttonOpenFile_EKP);
            groupBox3.Location = new Point(307, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(130, 430);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Действия";
            // 
            // buttonSave_EKP
            // 
            buttonSave_EKP.Location = new Point(6, 262);
            buttonSave_EKP.Name = "buttonSave_EKP";
            buttonSave_EKP.Size = new Size(118, 111);
            buttonSave_EKP.TabIndex = 2;
            buttonSave_EKP.Text = "Сохранить";
            buttonSave_EKP.UseVisualStyleBackColor = true;
            buttonSave_EKP.Click += buttonSave_EKP_Click;
            // 
            // buttonRes_EKP
            // 
            buttonRes_EKP.Location = new Point(6, 144);
            buttonRes_EKP.Name = "buttonRes_EKP";
            buttonRes_EKP.Size = new Size(118, 112);
            buttonRes_EKP.TabIndex = 1;
            buttonRes_EKP.Text = "Выполнить";
            buttonRes_EKP.UseVisualStyleBackColor = true;
            buttonRes_EKP.Click += buttonRes_EKP_Click;
            // 
            // buttonOpenFile_EKP
            // 
            buttonOpenFile_EKP.Location = new Point(6, 26);
            buttonOpenFile_EKP.Name = "buttonOpenFile_EKP";
            buttonOpenFile_EKP.Size = new Size(118, 112);
            buttonOpenFile_EKP.TabIndex = 0;
            buttonOpenFile_EKP.Text = "Выбрать";
            buttonOpenFile_EKP.UseVisualStyleBackColor = true;
            buttonOpenFile_EKP.Click += buttonOpenFile_EKP_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Column1
            // 
            Column1.HeaderText = "1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column1M
            // 
            Column1M.HeaderText = "1";
            Column1M.MinimumWidth = 6;
            Column1M.Name = "Column1M";
            Column1M.ReadOnly = true;
            Column1M.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 445);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_EKP).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonOpenFile_EKP;
        private Button buttonRes_EKP;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private Button buttonSave_EKP;
        private GroupBox groupBox5;
        private DataGridView dataGridViewRes_EKP;
        private GroupBox groupBox4;
        private OpenFileDialog openFileDialog2;
        private DataGridViewTextBoxColumn Column1M;
        private DataGridViewTextBoxColumn Column1;
    }
}
