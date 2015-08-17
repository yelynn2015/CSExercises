
using System;
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a number with 3 digit");
            double number = Convert.ToDouble(Console.ReadLine());
            int a = (int)number / 100;
            int b = ((int)(number-a*100)) / 10;
            int c = ((int)(number - a * 100 - b * 10));
            if (number == Math.Pow(a,3)+ Math.Pow(b, 3) + Math.Pow(c, 3))
                Console.WriteLine(number+"is a Armstrong Number");
            else
                Console.WriteLine(number + "is not a Armstrong Number");



        }
    }
}