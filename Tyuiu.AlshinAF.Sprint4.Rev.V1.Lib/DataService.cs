namespace Tyuiu.AlshinAF.Sprint4.Rev.V1.Lib
{
    public class DataService
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            int r = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        r ++;
                    }
                }
            }
            return r;
        }
    }
}
