using Tyuiu.EvdokimovKP.Sprint6.Task1.V3.Lib;

namespace Tyuiu.EvdokimovKP.Sprint6.Task1.V3
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
            int startValue = -5;
            int stopValue = 5;

            int len =  ds.GetMassFunction(startValue, stopValue).Length;
            double[] array;
            array = new double[len];
            array = ds.GetMassFunction(startValue, stopValue);
            textBoxResult_EKP.Text = "";
            textBoxResult_EKP.AppendText("+---------+--------+" + Environment.NewLine);
            textBoxResult_EKP.AppendText("|    X    |  f(x)  |" + Environment.NewLine);
            textBoxResult_EKP.AppendText("+---------+--------+" + Environment.NewLine);

            for (int i = 0; i <= len - 1; i++)
            { 
                string Line = String.Format("|{0,5:d}    |{1, 8:f2}   |", startValue, array[i]);
                textBoxResult_EKP.AppendText(Line + Environment.NewLine);
                startValue++;
            }
            textBoxResult_EKP.AppendText("+---------+--------+" + Environment.NewLine);
        }
    }
}
