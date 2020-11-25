using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_ЛР5_З3
{
    // У проекті реалізовано лише по одному методу створення матриць
    public partial class Form1 : Form
    {
        private int N;
        private int M;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(textBox1.Text);
            M = Convert.ToInt32(textBox2.Text);

            dataGridView1.RowCount = M;
            dataGridView1.ColumnCount = N;

            UpperTriangleMatrix matrix = new UpperTriangleMatrix(N, M);
            int[,] arr = matrix.ReturnUTArray();


            for (int i = 0; i < M; i++)
            for (int j = 0; j < N; j++)
                dataGridView1.Rows[i].Cells[j].Value = arr[i, j];
        }
    }
}
