using System;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a integer to find its factorial");
            int N=Convert.ToInt16(Console.ReadLine());
            int F=N;
            for(int i=N-1;i>0;i--)
            {
                F = F * i;    
            }
            Console.WriteLine("The factorial of {0} is {1}",N,F);
            F = 1;
            for(int i=1;i<=N;i++)
            {
                F = F * i;
            }
            Console.WriteLine("The factorial of {0} is {1}", N, F);
        }
    }
}
