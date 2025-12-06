using Tyuiu.EvdokimovKP.Sprint6.Task2.V4.Lib;   

namespace Tyuiu.EvdokimovKP.Sprint6.Task2.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonGoRes_EKP_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] array;
            array = new double[len];
            array = ds.GetMassFunction(startValue, stopValue);

            this.chartSin_EKP.Titles.Add("График функции sin(x)");

            this.chartSin_EKP.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartSin_EKP.ChartAreas[0].AxisY.Title = "Ось Y";

            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridViewResult_EKP.Rows.Add(startValue.ToString(), Convert.ToString(array[i]));

                this.chartSin_EKP.Series[0].Points.AddXY(startValue, array[i]);
                startValue++;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
