using Tyuiu.MokhamedAA.Sprint4.Task6.V26.Lib;
namespace Tyuiu.MokhamedAA.Sprint4.Task6.V26
{ 
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            var array = new string[] { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.Calculate(array);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
