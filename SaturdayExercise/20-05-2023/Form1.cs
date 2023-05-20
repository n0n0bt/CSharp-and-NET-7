using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20_05_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            MessageBox.Show(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string address = textBox1.Text;
            string name = textBox2.Text;
            MessageBox.Show(address + " " + name);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}