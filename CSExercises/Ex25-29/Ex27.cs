using System;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            double y = 0;
            Console.WriteLine("x\ty");
            Console.WriteLine("---------------------------");
            for(int x=-5;x<6;x++)
            {
                y= 2 * x * x - 4 * x + 3;
                Console.WriteLine("{0:0.0}\t{1:0.0}",x,y);
            }
            for(int x=1;x<21;x++)
            {
                y = 2 * x * x - 4 * x + 3;
                Console.Write("{0:0.0}", x);
                for(int i=0;i<y;i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
