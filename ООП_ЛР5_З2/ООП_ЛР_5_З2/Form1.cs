using System;
using System.Windows.Forms;

namespace ООП_ЛР_5_З2
{
    public partial class Form1 : Form
    {
        public double PI = 3.14159;
        public double H;
        public double R;
        public double V;
        public double S;
        public Form1()
        {
            InitializeComponent();
        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {

        }

        public void label4_Click(object sender, EventArgs e)
        {

        }

        public virtual void button1_Click(object sender, EventArgs e)
        {

            H = Convert.ToInt32(textBox1.Text);
            R = Convert.ToInt32(textBox2.Text);
            V = (PI * Math.Pow(R, 2)) / 3;
            S = PI * Math.Pow(R, 2);

            textBox3.Text = Convert.ToString(V);
            textBox4.Text= Convert.ToString(S);
        }
    }
}
