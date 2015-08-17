using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input the distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            
            double fare;
            fare = 2.4 + distance * 0.4;
            Console.WriteLine("The fare is {0}",fare);
        }
    }
}
