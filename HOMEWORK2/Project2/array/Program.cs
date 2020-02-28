using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] array = new int[] { 4,5,78,9,45,78,78 };
                         Console.WriteLine("Min:{0}", array.Min());
                         Console.WriteLine("Max:{0}", array.Max());
             Console.WriteLine("Average:{0}", array.Average());
             Console.ReadKey();
         }*/
            int[] array = new int[] { 1, 2, 4, 3, 0, -1, 34, 545, 2, 34 };
            double all;double ave1;
            int min = Program.Min(array);
            int max = Program.Max(array);
            Console.WriteLine("数组最小值：{0}", min);
            Console.WriteLine("数组最小值：{0}", max);
            aver Ave = new aver();
            Ave.Average(array, out all, out ave1);
            Console.WriteLine("元素和：{0}\n数组平均值：{1}", all, ave1);   
            //Console.ReadKey();
        }
        public static int Min(int[] array)
        {
            if (array == null)
                throw new Exception("数组空异常");
            int min1 = array[0];
            foreach (int x in array)
            {
                if (x < min1)
                    min1 = x;
            }
            return min1;
        }
        public static int Max (int[] array)
        {
            if (array == null)
                throw new Exception("数组空异常");
            int max1 = array[0];
            foreach (int x in array)
            {
                if (x > max1)
                {
                    max1 = x;
                }
            }
            return max1;
        }
        class aver
        {
            public void  Average(int[] array, out double all, out double ave1)
            {
                all = 0;
                int i = 0;
                foreach (int x in array)
                {
                    all += x;
                    i++;
                }
                ave1 = all / i;

            }
        }

    }
}

            
