using System;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a pharse");
            string pharse = Console.ReadLine();
            int a = 0, e = 0, i = 0, o = 0, u = 0;
            for(int j=0;j<pharse.Length;j++)
            {
                if (pharse[j] == 'a') a++;
                if (pharse[j] == 'e') e++;
                if (pharse[j] == 'i') i++;
                if (pharse[j] == 'o') o++;
                if (pharse[j] == 'u') u++;
            }
            int count = a + e + i + o + u;
            Console.WriteLine("The total number of vowels is"+count);
            Console.WriteLine("The number of a is" + a);
            Console.WriteLine("The number of e is" + e);
            Console.WriteLine("The number of i is" + i);
            Console.WriteLine("The number of o is" + o);
            Console.WriteLine("The number of u is" + u);
        }
    }
}
