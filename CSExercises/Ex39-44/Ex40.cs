using System.Data.SqlClient;
using System;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
            
        {
           
            
            for(int i=1;i<26;i++)
            {
                Console.WriteLine("The square of {0} is {1:0.000}",i,SQT(i));
            }
        }

        public static double SQT(int y)
        {
            if(y>0)return Math.Sqrt(y);
            else return 0;
        }
    }
}
