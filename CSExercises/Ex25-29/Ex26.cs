using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double[,] M = new double[10,4];
            
            for(int i=1;i<=10;i++)
            {
                M[i - 1,0] = i;
                M[i - 1, 1] = 1 / (double)i;
                M[i - 1, 2] = Math.Sqrt(i);
                M[i - 1, 3] = i * i;
            }
            Console.WriteLine("NO\t\tINVERSE\t\tSQUARE ROOT\tSQUARE");
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine("{0:0.0}\t\t{1:0.0##}\t\t{2:0.0##}\t\t{3:0.0}",M[i-1,0],M[i-1,1],M[i-1,2],M[i-1,3]);
            }
        }
    }
}
