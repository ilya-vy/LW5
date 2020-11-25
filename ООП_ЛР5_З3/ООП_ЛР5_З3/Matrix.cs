using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ЛР5_З3
{
    class Matrix
    {
        private int N;
        private int M;
        public Matrix(int n, int m)
        {
            N = n;
            M = m;
        }

        public virtual int[,] ReturnArray()
        {
            Random rnd = new Random();
            int[,] arr = new int[M, N];
            for (int i = 0; i < M; i++)
            for (int j = 0; j < N; j++)
                arr[i, j] = rnd.Next(0, 9);
            return arr;
        }
    }
}
