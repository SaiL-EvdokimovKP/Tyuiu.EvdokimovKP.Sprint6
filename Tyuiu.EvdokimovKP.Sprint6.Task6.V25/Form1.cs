using Tyuiu.EvdokimovKP.Sprint6.Task6.V25.Lib;

namespace Tyuiu.EvdokimovKP.Sprint6.Task6.V25
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        string openFilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_EKP_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            textBox2.Text = File.ReadAllText(openFilePath);
            textBox2.Text = textBox2.Text + " " + openFileDialog1.FileName;
            buttonOpenFile_EKP.Enabled = false;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonOpenFile_EKP.Enabled = true;
            button1.Enabled = false;
            textBoxResult_EKP.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
