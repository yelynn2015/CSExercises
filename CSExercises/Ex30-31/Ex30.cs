using System;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int singal = 0;//变为1说明不是质数
            for (double N = 5; N <= 10000; N++)
            {
                singal = 0;
                for (int i = 1; i <= Math.Sqrt(N); i++)
                {
                    if (N % i == 0 && N / i != N)
                    {
                        singal = 1;
                        break;
                    }
                }
                if (singal == 0)
                {
                    Console.Write(N+"\t");
                }
            }
        }
    }
}
