using System;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a integer to find its factorial");
            int N=Convert.ToInt16(Console.ReadLine());
            int[] F=new int[N];
            int j = 0;
            //for(int i=1;i<=Math.Sqrt(N);i++)
            //{
            //    if (N % i == 0&&N/i!=N)
            //    {
            //        F[j++] = i;
            //        if(i!=N/i)
            //        {
            //            F[j++] = N / i;
            //        }
                    
            //    }
            //}
           
            for(int i=Convert.ToInt16(Math.Sqrt(N));i>0;i--)
            {
                if (N % i == 0 && N / i != N)
                {
                    F[j++] = i;
                    if (i != N / i)
                    {
                        F[j++] = N / i;
                    }
                }
            }

            for (int i=0;i<j;i++)//i只是存活在所命名的小范围中
            {
                Console.WriteLine("The No {0} factorial is {1} ",i+1,F[i]);
            }
            if (j == 0) Console.WriteLine("{0} do not have factorial",N);
        }
    }
}
