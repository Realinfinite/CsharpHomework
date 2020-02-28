using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[99];
            for(int i= 0;i<99;i++)
            {
                n[i] = i + 2;
            }
            List<int> arr_list = n.OfType<int>().ToList();
            for (int j = 2; j <= 100; j++)
            {
                for (int num = 2; num <= 100; num++)
                {
                    if (num % j == 0 && num != j)
                    {
                        arr_list.Remove(item: num);

                    }
                }
            } 
            foreach (var item in arr_list)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();         
        }
    }
}
