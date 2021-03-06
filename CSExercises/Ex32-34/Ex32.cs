using System;
using System.Collections; //使用Hashtable时，必须引入这个命名空间
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            double[] sales = new double[12];
            double whole = 0;
            for (int i = 0; i < 12; i++)
            {
                Console.Write("Enter sales for month " + i + " :");
                sales[i] = Convert.ToDouble(Console.ReadLine());
                whole = whole + sales[i];
            }

            Hashtable ht_max = new Hashtable();//建立哈西表，记录有多个最大值月份的情况
            Hashtable ht_min = new Hashtable();//建立哈西表，记录有多个最小值月份的情况

            int max = 0, min = 0;
            int max_i = 0, min_i = 0;
            for (int i = 1; i < 12; i++)
            {
                if (sales[max] < sales[i]) max = i;
                if (sales[min] > sales[i]) min = i;
            }
            for (int i = 0; i < 12; i++)
            {
                if (sales[max] == sales[i]) { ht_max.Add(max_i, i); max_i++; }
                if (sales[min] == sales[i]) { ht_min.Add(min_i, i); min_i++; }
            }
            double average = whole / 12;
            foreach (int key in ht_max.Keys)
            {
                Console.WriteLine("Maximun Sales: "+ht_max[key]);
            }//遍历整个哈希表，foreach方法
            foreach (int key in ht_min.Keys)
            {
                Console.WriteLine("Minimun Sales: " + ht_min[key]);
            }


            Console.WriteLine("Average Sales:" + Math.Round(average));

        }
    }
}
