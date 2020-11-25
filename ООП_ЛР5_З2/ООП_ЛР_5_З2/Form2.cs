using System;

namespace ООП_ЛР_5_З2
{
    public partial class Form2 : Form1
    {
        public Form2()
        {
            InitializeComponent();
        }
        public double R2;
        public override void button1_Click(object sender, EventArgs e)
        {
            H = Convert.ToInt32(textBox1.Text);
            R = Convert.ToInt32(textBox2.Text);
            R2 = Convert.ToInt32(textBox5.Text);

            V = (PI * H * (Math.Pow(R, 2) + (R * R2) + Math.Pow(R2, 2))) / 3;

            textBox3.Text = Convert.ToString(V);
        }
    }
}
