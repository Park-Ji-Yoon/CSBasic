using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output = new List<int>();

            output = (from item in input where item % 2 == 0 orderby item descending select item).ToList();
            /*foreach(var item in input)
            {
                if(item % 2 == 0)
                {
                    output.Add(item);
                }
            }*/
            foreach(var item in output)
            {
                Console.WriteLine(item);
            }

            var output2 = from item in input
                          where item % 2 == 0
                          select new
                          {
                              A = item * 2,
                              B = item * item,
                              C = 100
                          };
            foreach (var item in output2)
            {
                Console.WriteLine(item.A + " / " + item.B + " / " + item.C);
            }
        }
    }
}
