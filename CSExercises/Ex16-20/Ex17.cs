using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input your name and gender(M or F) and age");
            String name = Convert.ToString(System.Console.ReadLine());
            String gender = Convert.ToString(System.Console.ReadLine());
            int age = Convert.ToInt16(System.Console.ReadLine());
            if (age >= 40)
            {
                if (gender == "M")
                { gender = "Uncle "; }
                else if (gender == "F")
                { gender = "Aunty "; }
                else
                { Console.WriteLine("Wrong gender input"); }
            }
            else
            {
                if (gender == "M") { gender = "Mr."; }
                else if (gender == "F") { gender = "Ms."; }
                else { Console.WriteLine("Wrong gender input"); }
            }
            Console.WriteLine("Good Moring " + gender + name);
        }
    }
}