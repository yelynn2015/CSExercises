using System;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string s = Console.ReadLine();
            char[] s1=new char[s.Length];
            int j = 0;
            s = s.ToLower();//全部转换为小写字母

            int i;

            for (i=0;i<s.Length;i++)
            {
               if((s[i]>=97&&s[i]<=122)||(s[i]>=48&&s[i]<=58))
                {
                    s1[j++] = s[i];
                    //Console.WriteLine(j - 1 + "enter s1" + s1[j - 1]);
                }
            }

           
            for (i=0;i<j;i++)
            {
                if (s1[i] != s1[j - i - 1])
                {
                    Console.WriteLine("the string is not a palindrome");
                    break;
                }
            }
            if (i >= j)
                Console.WriteLine("the string is a palindrome");
        }
    }
}
