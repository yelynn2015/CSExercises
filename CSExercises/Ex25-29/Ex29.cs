using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a integer");
            int N = Convert.ToInt16(Console.ReadLine());
            int factor=1;
            
            for (int i = Convert.ToInt16(Math.Sqrt(N)); i > 0; i--)
            {
                if (N % i == 0 && N / i != N)
                {
                    factor = factor + i;
                    if (i != N / i)
                    {
                        factor=factor+N/i;
                    }
                }
            }
            
            if(factor==N)
                Console.WriteLine("Perfect Number");
            else
                Console.WriteLine("Not Perfect Number");





        }
    }
}
