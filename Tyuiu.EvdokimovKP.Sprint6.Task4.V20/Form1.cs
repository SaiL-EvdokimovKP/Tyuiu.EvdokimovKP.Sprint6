using Tyuiu.EvdokimovKP.Sprint6.Task4.V20.Lib;

namespace Tyuiu.EvdokimovKP.Sprint6.Task4.V20
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGo_EKP_Click(object sender, EventArgs e)
        {
            int startValue = -5;
            int stopValue = 5;
            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            this.chartResult_EKP.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartResult_EKP.ChartAreas[0].AxisY.Title = "Ось Y";

            textBoxResult_EKP.Text = "";
            chartResult_EKP.Series[0].Points.Clear();

            for (int i = 0; i < len - 1; i++)
            {
                this.chartResult_EKP.Series[0].Points.AddXY(startValue, valueArray[i]);
                textBoxResult_EKP.AppendText(valueArray[i] + Environment.NewLine);
                startValue++;
            }
        }

        private void buttonSave_EKP_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\PutPutFileTask4V20.txt";
            File.WriteAllText(path, textBoxResult_EKP.Text);

            DialogResult dialogres = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogres == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }
    }
}
