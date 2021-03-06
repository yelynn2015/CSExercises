using System;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the amount:(please between 0.05~3.50) ");
            double cents = Convert.ToDouble(Console.ReadLine());
            if (cents * 100 % 5 != 0 || cents < 0.05 || cents > 3.50)
            {
                Console.WriteLine("Wrong Amount Input...");
            }
            else
            {
                int[] number = new int[5];
                number = FindMinCent(cents);
                for(int i=0;i<number[0];i++)
                {
                    Console.WriteLine("100c");
                }
                for (int i = 0; i < number[1]; i++)
                {
                    Console.WriteLine("50c");
                }
                for (int i = 0; i < number[2]; i++)
                {
                    Console.WriteLine("20c");
                }
                for (int i = 0; i < number[3]; i++)
                {
                    Console.WriteLine("10c");
                }
                for (int i = 0; i < number[4]; i++)
                {
                    Console.WriteLine("5c");
                }
            }
        }
        public static int[] FindMinCent(double cents)
        {
            int[] number = new int[5];//number[0] match the number of 100 cents,number[1] match the number of 50 cents...
            cents = (int)(cents * 100);
            number[0] = (int)cents / 100;
            number[1] = ((int)cents - number[0]*100)/50;
            number[2] = ((int)cents - number[0] * 100 - number[1] * 50) / 20;
            number[3] = ((int)cents - number[0] * 100 - number[1] * 50 - number[2] * 20) / 10;
            number[4] = ((int)cents - number[0] * 100 - number[1] * 50 - number[2] * 20 - number[3] * 10) / 5;
            
            return number;
        }
    }
}
