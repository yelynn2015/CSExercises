using System;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] count = new int[11];
            int[] number = new int[50];
            for (int i = 0; i < 50; i++)
            {
                Random r = new Random();
                number[i] = r.Next(-5, 6);
               // while (i > 6 && ((number[i] == number[i - 1]) || (number[i] == number[i - 2]) || (number[i] == number[i - 3]) || (number[i] == number[i - 4]) || (number[i] == number[i - 5]) || (number[i] == number[i - 6]) || (number[i] == number[i - 7])))
                //{
                   // number[i] = r.Next(-5, 6); //Console.WriteLine(number[i]);
                //}
                Console.WriteLine(number[i] + "");
            }
            for (int i = 0; i < 50; i++)
            {
                count[number[i] + 5]++;

            }
            Console.WriteLine("Number\tCount");
            for (int i = 0; i < 11; i++)
            {
                int k = i - 5;
                Console.WriteLine(k + "\t" + count[i]);
            }
            Console.WriteLine("Number");
            for (int i = 0; i < 11; i++)
            {
                Console.Write(i - 5 + "\t");
                for (int j = 0; j < count[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}
