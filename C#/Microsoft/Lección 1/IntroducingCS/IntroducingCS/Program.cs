using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingCS
{
    class Program
    {
        static void Main(string[] args)
        {
            ForEachTest();

        }

        private static void ForEachTest()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
