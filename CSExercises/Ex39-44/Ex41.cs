using System;
namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] a)
        {
            Console.Write("Input the first string: ");
            string s1= Console.ReadLine();
            Console.Write("Input the second string: ");
            string s2 = Console.ReadLine();
            if (InString(s1, s2)) Console.WriteLine("s2 occurs in s1");
            else Console.WriteLine("s2 do not occur in s1");
        }
        public static bool InString(string s1, string s2)
        {
            int signal = 0;
            int[]  capital =new int[s1.Length];//存放s1中字符等于s2首字符的位置信息
            int i = 0;
            int length_s2 = s2.Length;
            int length_s1 = s1.Length;
            for (int j = 0; j < s1.Length; j++)
            {
                if (s2[0] == s1[j])
                {
                    signal = 1;
                    capital[i++] = j;
                }
            }
            if(signal==0)
            {
                return false;
            }
            else
            {
               for(int k=0;k< i;k++)
                {
                    if ((length_s1 - capital[k]) >= length_s2)
                    {
                        string s11 = s1.Substring(capital[k], length_s2);
                        if(s11.Equals(s2))
                        { 
                            return true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return false;
        }
    }
}
