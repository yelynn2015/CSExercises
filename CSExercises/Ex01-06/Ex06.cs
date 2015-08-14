using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a integer to get the square");
            int a = Convert.ToInt16(Console.ReadLine());
            double b = Math.Sqrt((double)a);
            Console.WriteLine("the square is " + b);
        }
    }
}
