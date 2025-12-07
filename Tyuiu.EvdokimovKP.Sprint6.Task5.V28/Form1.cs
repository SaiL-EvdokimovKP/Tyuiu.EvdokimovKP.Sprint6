using Tyuiu.EvdokimovKP.Sprint6.Task5.V28.Lib;

namespace Tyuiu.EvdokimovKP.Sprint6.Task5.V28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\evdok\Desktop\Sprint 6\InPutDataFileTask5V28.txt";
        private void buttonGo_EKP_Click(object sender, EventArgs e)
        {
            dataGridViewRes_EKP.ColumnCount = 2;
            dataGridViewRes_EKP.Columns[0].Width = 50;
            dataGridViewRes_EKP.Columns[1].Width = 80;

            this.chartRes_EKP.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartRes_EKP.ChartAreas[0].AxisY.Title = "Ось Y";

            chartRes_EKP.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewRes_EKP.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartRes_EKP.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
    }
}
