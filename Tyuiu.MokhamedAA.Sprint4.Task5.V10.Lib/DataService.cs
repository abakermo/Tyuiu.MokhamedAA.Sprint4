using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MokhamedAA.Sprint4.Task5.V10.Lib
{
    public class DataService : ISprint4Task5V10
    {
        public int Calculate(int[,] m)

        {
            int rows, columns, s;

            rows = m.GetUpperBound(0) + 1;
            columns = m.Length / rows;
            s = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if (m[i, j] > 0)
                        s += m[i, j];
            return s;



        }
    }
}
