using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your distance(km)");
            double distance = Convert.ToDouble(Console.ReadLine());
            double charge = 0;
            if (distance <= 0.5)
                charge = 2.4;
            else if (distance > 0.5 && distance <= 9)
                charge = 2.4 + (distance - 0.5) * 10 * 0.04;
            else
            {
                distance = Math.Ceiling(distance * 10);
                Console.WriteLine("distance" + distance);
                charge = 2.4 + 85 * 0.04 + (distance - 90) * 0.05;
            }
            Console.WriteLine("The charge is {0:#.00}", charge);
            
        }
    }
}