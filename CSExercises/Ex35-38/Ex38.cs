using System;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = new int[5] {63,29,75,82,55 };
           
            int exchange;
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (mark[i] < mark[j])
                    {
                        exchange = mark[i];
                        mark[i] = mark[j];
                        mark[j] = exchange;
                    }
                }
                Console.Write(mark[i] + "\t");
            }
            Console.WriteLine();
            string exchanges;
            for(int i=0;i<5;i++)
            {
                string a = name[i];
                char a1 = a[0];
                for (int j = i + 1; j < 5; j++)
                {
                    string b = name[j];
                    char b1 = b[0];
                    if(a1>b1)
                    {
                        exchanges = name[i];
                        name[i] = name[j];
                        name[j] = exchanges;
                    }

                }
                Console.Write(name[i] + "\t");
            }

           
        }
    }
}
