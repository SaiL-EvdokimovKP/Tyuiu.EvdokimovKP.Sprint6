using Tyuiu.EvdokimovKP.Sprint6.Task0.V7.Lib;

namespace Tyuiu.EvdokimovKP.Sprint6.Task0.V7
{
    public partial class Form1 : Form
    {
        int x = 3;
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRES_EKP_Click(object sender, EventArgs e)
        {
            textBoxResult_EKP.Text = Convert.ToString(ds.Calculate(x));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
