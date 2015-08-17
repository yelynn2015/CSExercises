using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input the distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The fare is " + Math.Round(distance));
            double fare;
            fare = 2.4 + distance * 0.4;
            fare = Math.Ceiling(fare);
            Console.WriteLine("The fare is {0:#.00}", fare);
        }
    }
}
