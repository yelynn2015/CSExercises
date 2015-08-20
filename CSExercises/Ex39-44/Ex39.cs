using System;
namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            long n = Convert.ToInt64(Console.ReadLine());
            Console.Write("The factorial of {0} is :", n);
            Console.WriteLine(Factorial(n));
            Console.WriteLine();
        }
        public static long Factorial(long n)
        {
            long f=1;
            
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }
        
    }
}
