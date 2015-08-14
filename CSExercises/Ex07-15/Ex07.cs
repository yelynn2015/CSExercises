using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your initial salary");
            double a=Convert.ToDouble(Console.ReadLine());
            a = a * (1 + 0.1 + 0.03);
            Console.WriteLine("The whole salary you can get is {0:#.000}",a);
        }
    }
}
