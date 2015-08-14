using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a number to get the square");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Math.Sqrt(a);
            Console.WriteLine("the square is "+b);

        }
    }
}
