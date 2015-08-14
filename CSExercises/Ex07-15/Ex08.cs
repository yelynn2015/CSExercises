using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input temperature in Centigrate");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = a * 1.8+32;
            Console.WriteLine("the temperature in Fahrenheit is {0:#.00}", b);
        }
    }
}
