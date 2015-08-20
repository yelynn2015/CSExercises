using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input the distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The distance is "+distance);
            double fare;
            fare = 2.4 + distance * 0.4;
            Console.WriteLine(fare);
            fare = Math.Round(fare,2);
            
            Console.WriteLine("The fare is {0:#.00}", fare);
        }
    }
}
