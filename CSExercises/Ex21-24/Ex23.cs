using System; 
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random random=new Random();
            int a = random.Next(9);
            
            //double c= random.NextDouble();
            int  count = 1;
            //Random.Next(9);抽象类？？
            Console.WriteLine("start guessing...(from 0~9)");
            int b=Convert.ToInt16(Console.ReadLine());
            while(a!=b)
            {
                Console.WriteLine("Try again");
                b = Convert.ToInt16(Console.ReadLine());
                count++;
            }
            if (count <= 2)
                Console.WriteLine("You are a Wizard!");
            else if (count > 2 && count <= 5)
                Console.WriteLine("You are a good guess.");
            else
                Console.WriteLine("You are lousy!");
            
        }
    }
}
