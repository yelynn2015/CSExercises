using System;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter A:");
            int A = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter B:");
            int B = Convert.ToInt16(Console.ReadLine());

            int X=0,Y=0,HCF=0,LCM=0;
            X = A;
            Y = B;
            do
            {
                if (X > Y)
                {
                    X = X - Y;
                }
                else if (X < Y)
                {
                    Y= Y - X;
                }
            }
            while (X != Y);
            HCF = X;
            LCM = (A * B) / HCF;
            Console.WriteLine("HCF: " + HCF);
            Console.WriteLine("LCM: " + LCM);


        }
    }
}
