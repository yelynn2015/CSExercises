using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a number to find the sqaure root.");
            int N=Convert.ToInt16(Console.ReadLine());
            Random random = new Random();
            double G = random.Next(N)+random.NextDouble();
            while(G*G!=N&&Math.Round(G*G,5)!=N)
            {
                G = (G + N / G) / 2;
         
            }
            Console.WriteLine("The square root of {0} is {1}",N,G);
        }
    }
}
