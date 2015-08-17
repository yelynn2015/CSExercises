using System;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input your name and gender(M or F)");
            String name=Convert.ToString(System.Console.ReadLine());
            String gender = Convert.ToString(System.Console.ReadLine());
            if(gender=="M")
            {
                gender = "Mr.";

            }
            else if(gender=="F")
            {
                gender = "Ms.";
            }
            else
            {
                Console.WriteLine("Wrong gender input");
            }

            Console.WriteLine("Good Moring "+gender+name);
            
        }
    }
}