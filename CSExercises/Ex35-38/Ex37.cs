using System;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string s = Console.ReadLine();
            
            if(s[0] >= 97 && s[0] <= 122) s=s.Replace(s[0], (char)((int)s[0] - 32));
            
            

            for (int i=1;i<s.Length;i++)
            {
               if(s[i-1]==(char)32&&s[i]>=97&&s[i]<=122)
                {
                    s=s.Replace(s[i],(char)(s[i]-32));
                }
            }
            Console.WriteLine(""+s);
            
        }
    }
}
