using Tyuiu.EvdokimovKP.Sprint6.Task7.V30.Lib;
using System.IO;

namespace Tyuiu.EvdokimovKP.Sprint6.Task7.V30
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();

        string filePath;
        int[,] matrixOut;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void buttonOpenFile_EKP_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    string[] lines = File.ReadAllLines(filePath);
                    int rows = lines.Length;

                    int column = lines[0].Split(';').Length;

                    int[,] matrix = new int[rows, column];

                    for (int i = 0; i < rows; i++)
                    {
                        string[] values = lines[i].Split(";");
                        for (int j = 0; j < column; j++)
                        {
                            matrix[i, j] = int.Parse(values[j]);
                        }
                    }

                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                    int rowCount = matrix.GetLength(0);
                    int columnCount = matrix.GetLength(1);

                    for (int j = 0; j < columnCount; j++)
                    {
                        dataGridView1.Columns.Add($"{j + 1}", $"{j + 1}");
                    }

                    for (int i = 0; i < rowCount; i++)
                    {
                        var row = new DataGridViewRow();
                        for (int j = 0; j < columnCount; j++)
                        {
                            row.Cells.Add(new DataGridViewTextBoxCell() { Value = matrix[i, j] });
                        }
                        dataGridView1.Rows.Add(row);
                    }

                    for (int i = 0; i < columnCount; i++) dataGridView1.Columns[i].Width = 35;
                }
            }
        }

        private void buttonRes_EKP_Click(object sender, EventArgs e)
        {
            matrixOut = ds.GetMatrix(filePath);

            dataGridViewRes_EKP.Rows.Clear();
            dataGridViewRes_EKP.Columns.Clear();

            int rowCount = matrixOut.GetLength(0);
            int columnCount = matrixOut.GetLength(1);

            for (int j = 0; j < columnCount; j++)
            {
                dataGridViewRes_EKP.Columns.Add($"{j + 1}", $"{j + 1}");
            }

            for (int i = 0; i < rowCount; i++)
            {
                var row = new DataGridViewRow();
                for (int j = 0; j < columnCount; j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = matrixOut[i, j] });
                }
                dataGridViewRes_EKP.Rows.Add(row);
            }

            for (int i = 0; i < columnCount; i++) dataGridViewRes_EKP.Columns[i].Width = 35;
        }

        private void buttonSave_EKP_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                int rowCount = matrixOut.GetLength(0);
                int columnCount = matrixOut.GetLength(1);

                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        writer.Write(matrixOut[i, j]);

                        if (j < columnCount - 1)
                        {
                            writer.Write(";");
                        }
                    }
                    writer.WriteLine(); 
                }
            }
        }
    }
}
