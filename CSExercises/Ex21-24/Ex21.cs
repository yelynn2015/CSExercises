using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            Console.Write("Guessing the lucky number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            while(number!=88)
            {
                Console.Write("Guessing the lucky number again: ");
                number = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Lucky you...");
        }
    }
}
