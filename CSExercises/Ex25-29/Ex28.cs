using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a integer");
            int N = Convert.ToInt16(Console.ReadLine());
            
            int signal = 0;//信号，变成1时说明不是质数
            for(int i=1;i<=Math.Sqrt(N);i++)
            {
                if (N % i == 0&&N/i!=N)
                {
                    signal = 1;
                }
            }
            if (signal == 1) Console.WriteLine("Not Prime");
            else Console.WriteLine("Prime");
        }
    }
}
