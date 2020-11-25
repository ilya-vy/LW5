using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ЛР5_З3
{
    class UnitaryMatrix : Matrix
    {
        private int N;
        private int M;
        public UnitaryMatrix(int n, int m) : base(n, m)
        {
            N = n;
            M = m;
        }
        public override int[,] ReturnArray()
        {
            int[,] arr = new int[M, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (i == j)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }

                }
            }
            return arr;
        }
    }
}
