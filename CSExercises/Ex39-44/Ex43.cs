using System;
namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] a)
        {
            Console.WriteLine("From 1 to 100, their hexadecimal is as follow:");
            for (int i = 1; i < 10000; i++)
            {
                Console.WriteLine("The hexadecimal of {0} is {1} ", i, Hex(i));
            }

        }
        public static string Hex(int i)
        {
            int[] H = new int[10];
            string H16 = "";
            int j = 0;
            if (i / 16 <= 0)
            {
                if (i < 10) return i + "";
                else if (i == 10) return "A";
                else if (i == 11) return "B";
                else if (i == 12) return "C";
                else if (i == 13) return "D";
                else if (i == 14) return "E";
                else if (i == 15) return "F";
            }
            while (i / 16 > 0)
            {
                H[j++] = i % 16; 
                i = i / 16;
            }
            H[j] = i;
            for (int k = j; k >= 0; k--)
            {
                if (H[k] < 10)  H16 = H16 + H[k]; 
                else if (H[k] == 10) H16 = H16 + "A";
                else if (H[k] == 11) H16 = H16 + "B";
                else if (H[k] == 12) H16 = H16 + "C";
                else if (H[k] == 13) H16 = H16 + "D";
                else if (H[k] == 14) H16 = H16 + "E";
                else if (H[k] == 15) H16 = H16 + "F";

            }
            return H16;
        }
    }
}
