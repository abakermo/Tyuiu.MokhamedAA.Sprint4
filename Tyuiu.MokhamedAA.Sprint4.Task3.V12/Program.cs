using Tyuiu.MokhamedAA.Sprint4.Task3.V12.Lib;
namespace Tyuiu.MokhamedAA.Sprint4.Task3.V12
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[5, 5] { { 9, 7, 4, 9, 7 },
                                         { 5, 2, 5, 7, 6 },
                                         { 8, 3, 3, 5, 7 },
                                         { 8, 4, 2, 4, 5 },
                                         { 8, 8, 9, 5, 6 } };
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            DataService ds = new DataService();

           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mas);

            Console.WriteLine("Минимальный элемент в третьем столбце массива = " + res);
            Console.ReadKey();
        }
    }
}
