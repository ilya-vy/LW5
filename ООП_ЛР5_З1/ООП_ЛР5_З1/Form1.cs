using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ООП_ЛР5_З1
{
    // У проекті реалізовано лише можливість рухати квадрат за допомогою клавіш
    public partial class Form1 : Form
    {
        public int x;
        public int y;
        public int Width1;
        public int Height1;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Keyboard);
        }
        public virtual void Keyboard(object sender, KeyEventArgs e)
        {
            int x1 = pictureBox1.Location.X;
            int y1 = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right) x1 += 15;
            else if (e.KeyCode == Keys.Left) x1 -= 15;
            else if (e.KeyCode == Keys.Up) y1 -=15;
            else if (e.KeyCode == Keys.Down) y1 += 15;

            pictureBox1.Location = new Point(x1, y1);
        }
        public Bitmap Draw(int width, int height)
        {
            var bitmap = new Bitmap(width, height);
            var graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(new SolidBrush(Color.DarkCyan), x, y, Width1, Height1);

            return bitmap;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            Width1 = int.Parse(textBox3.Text);
            Height1 = int.Parse(textBox4.Text);
            pictureBox1.Image = Draw(pictureBox1.Width, pictureBox1.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(Handle, 161, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}

