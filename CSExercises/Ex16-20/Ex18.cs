using System;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your marks");
            int mark = Convert.ToInt16(Console.ReadLine());
            char grade='0';
            if (mark > 100 || mark < 0) { Console.WriteLine("**Error**"); }
            else
            {
                if (mark >= 80 && mark <= 100)
                    grade = 'A';
                else if (mark >= 60 && mark <= 79)
                    grade = 'B';
                else if (mark >= 40 && mark <= 59)
                    grade = 'C';
                else if (mark >= 0 && mark <= 40)
                    grade = 'F';
                
                Console.WriteLine("Your scored {0} marks which is {1} grade", mark, grade);

            }
        }
    }
}