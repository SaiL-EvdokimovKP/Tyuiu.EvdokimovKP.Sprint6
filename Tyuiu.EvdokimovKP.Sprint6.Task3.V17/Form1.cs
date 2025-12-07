using Tyuiu.EvdokimovKP.Sprint6.Task3.V17.Lib;

namespace Tyuiu.EvdokimovKP.Sprint6.Task3.V17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClick_EKP_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] m = new int[5, 5] { {22, 32, -16, 24, 27 },
                                   { 3, -20, 24, -20, 25 },
                                   { 21, 17, -8, -19, 17 },
                                   { 8, 22, 28, 27, 19 },
                                   { 11, 20, 12, 27, 29 } };
            int[,] res = ds.Calculate(m);
            dataGridRes_EKP.ColumnCount = res.GetLength(1);
            dataGridRes_EKP.RowCount = res.GetLength(0);

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    dataGridRes_EKP.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
    }
}
