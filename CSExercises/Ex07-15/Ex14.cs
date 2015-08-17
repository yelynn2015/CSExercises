
using System;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input the a,b,c");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if (a + b <= c)
            {
                Console.WriteLine("wrong input");
            }
            else
            {
                double s = (a + b + c) / 2;
                double area = Math.Sqrt((s * (s - a) * (s - b) * (s - c)));
                Console.WriteLine("the area is"+area); }
            
        }
    }
}