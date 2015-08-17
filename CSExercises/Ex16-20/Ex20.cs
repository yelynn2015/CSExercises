using System;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter quantity for TV: ");
            int tv=Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine();
            Console.Write("Enter quantity for DVD: ");
            int dvd = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine();
            Console.Write("Enter quantity for Mp3: ");
            int mp3 = Convert.ToInt16(Console.ReadLine());
            if (tv < 0 || dvd < 0 || mp3 < 0) Console.WriteLine("wrong input");
            else
            {
                double charge_first = 900 * tv + 500 * dvd+700*mp3;
                if (charge_first > 5000 && charge_first <= 10000)
                    charge_first =(charge_first - 700 * mp3)*0.9; 
                else if (charge_first > 10000)
                    charge_first =(charge_first-700*mp3)*0.85;
                double charge_whole = charge_first + mp3*700 ;
                Console.WriteLine("Total price for this order is $"+charge_whole);
            }

        }
    }
}