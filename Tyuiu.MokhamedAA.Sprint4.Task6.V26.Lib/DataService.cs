using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MokhamedAA.Sprint4.Task6.V26.Lib
{
    public class DataService : ISprint4Task6V26
    {
        public string[] Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, city => city.Length > 5);
            return res;
        }
    }
}
