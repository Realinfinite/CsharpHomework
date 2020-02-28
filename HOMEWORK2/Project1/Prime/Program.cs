using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String numresults = " ";
                int num = Int32.Parse(Console.ReadLine());
                for (int j = 2; j < num; j++)
                {
                    while (num % j == 0 && num != j)
                    {
                        num /= j;
                        numresults += j + ",";
                    }
                }
                numresults += num;
                Console.Write(numresults);
            }
            catch(Exception x)
            {
                Console.WriteLine("Put an int");
            }
            Console.ReadKey();

        }
       

    }
}
