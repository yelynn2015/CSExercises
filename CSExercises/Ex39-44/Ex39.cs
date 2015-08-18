using System;
namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            long n = Convert.ToInt64(Console.ReadLine());
            Factorial(n);
            Console.WriteLine();
        }
        public static long Factorial(long n)
        {
            Console.Write("The factorial of {0} is :",n);
            for (int i = Convert.ToInt16(Math.Sqrt(n)); i > 0; i--)
            {
                if (n % i == 0 && n / i != n)
                {
                    Console.Write(i+"\t");
                    
                    if (i != n / i)
                    {
                        Console.Write(n/i + "\t");
                    }
                }
            }
            Console.Write("1"+"\t"+n);
            return 0;
        }
        
    }
}
