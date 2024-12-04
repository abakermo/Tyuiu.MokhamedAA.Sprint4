using Tyuiu.MokhamedAA.Sprint4.Task2.V11.Lib;
namespace Tyuiu.MokhamedAA.Sprint4.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();


            
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            int len;
            Console.Write("Введите кол-во элементов: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(3, 8);
            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(numsArray[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            int res = ds.Calculate(numsArray);
            Console.WriteLine("Результат сложения чётных чисел: " + ds.Calculate(numsArray));
            Console.ReadKey();
        }
    }
}
