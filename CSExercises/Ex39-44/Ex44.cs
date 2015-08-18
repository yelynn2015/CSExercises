using System;
namespace CSExercises
{
    public class Ex44
    {
        public  static void Main(string[] a)
        {
            Console.WriteLine("Please input a string , two character");
            string s = Console.ReadLine();
            char c1 = Convert.ToChar(Console.ReadLine());
            char c2 = Convert.ToChar(Console.ReadLine());
            if (Substitute(s, c1, c2) != null)
            {
                Console.WriteLine("The result of combination is   " + Substitute(s, c1, c2));
            }
            else
                Console.WriteLine("can not find the {0} in {1}",c1,s);
        }
        public static string Substitute(string s, char c1, char c2)
        {
            int[] address = new int[s.Length];//用于存放s中有c1这个字符的下标
            int j = 0;//address数组的下标
            int singal = 0;//用户判断s有没有c1这个字符，如果没有则singal一直为0
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c1)
                {
                    address[j++] = i;
                    singal = 1;
                }
            }
           
            if (singal == 0)
            {
                return null;
            }

            else
            {
                for (int i = 0; i < j; i++)
                {
                    s=s.Insert(address[i]+1+i,c2+"");

                }
                return s;
            }
        }
    }
}
