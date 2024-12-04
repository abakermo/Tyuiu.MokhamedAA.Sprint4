using Tyuiu.MokhamedAA.Sprint4.Task4.V14.Lib;
namespace Tyuiu.MokhamedAA.Sprint4.Task4.V14
{
    internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
       
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int rows = 5;
        int columns = 5;
        int[,] matrix = new int[rows, columns];
        Console.WriteLine("Введите значения массива от 1 до 8: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                while (matrix[i, j] > 8 || matrix[i, j] < 1)
                {
                    Console.WriteLine("Неверное значение. Введите число от 1 до 8: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        Console.Write("Массив: ");
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Все нечётные элементы заменены на 0");
        int[,] res = ds.Calculate(matrix);
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < columns; j++)
            {
                Console.Write(res[i, j] + "\t");
            }
        }

    }
}
}
