using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__week4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;
            Console.Write("Original array: ");
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Reverse(temp);
            Console.Write("Reversed array: ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}
