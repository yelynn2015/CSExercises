using System;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int factor = 1;
            Console.WriteLine("The perfect number from 1 to 1000 is ");
            for (int N = 1; N <= 1000; N++)
            {
                for (int i = Convert.ToInt16(Math.Sqrt(N)); i > 0; i--)
                {
                    if (N % i == 0 && N / i != N)
                    {
                        factor = factor + i;
                        if (i != N / i)
                        {
                            factor = factor + N / i;
                        }
                    }
                }
                if (factor == N) Console.Write(N + "\t");
                factor = 1;
            }
        }
    }
}
