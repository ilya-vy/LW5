using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ЛР5_З3
{
    class UpperTriangleMatrix : Matrix
    {
        private int N;
        private int M;

        public UpperTriangleMatrix(int n, int m) : base(n, m)
        {
            N = n;
            M = m;
        }

        public  int[,] ReturnUTArray()
        {
            Random rnd = new Random();
            int[,] arr = new int[M, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (i > j)
                    {
                        arr[i, j] = 0;
                    }
                    else
                    {
                        arr[i, j] = rnd.Next(0, 9);
                    }

                }
            }

            return arr;
        }
    }
}
