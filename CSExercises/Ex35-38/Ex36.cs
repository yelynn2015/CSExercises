using System;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string s = Console.ReadLine();
            Console.WriteLine("the length is"+s.Length);
           /* for(int i=0;i<s.Length/2;i++)
            {
                if (s[i] != s[s.Length - i])
                    Console.WriteLine("the string is not a palindrome");
                    break;
            }*/
        }
    }
}
