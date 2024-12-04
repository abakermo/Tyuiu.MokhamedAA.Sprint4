using Tyuiu.MokhamedAA.Sprint4.Task7.V19.Lib;
namespace Tyuiu.MokhamedAA.Sprint4.Task7.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[,] matrix = new int[4, 2];
            string str = "90817264";
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int index = 0;
            Console.WriteLine("\nМассив");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++, index++)
                {
                    Console.Write($"{str[index]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество нечётных элементов = " + ds.Calculate(4, 2, str));
            Console.ReadKey();
        }
    }
}
