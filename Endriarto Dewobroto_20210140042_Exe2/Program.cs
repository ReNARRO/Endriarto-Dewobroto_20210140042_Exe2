using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endriarto_Dewobroto_20210140042_Exe2
{
    class Program
    {
        private int[] dewo = new int[26];
        private int n;
        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements \n");
            }
            Console.WriteLine("\n=======================");
            Console.WriteLine("Enter Array Element");
            Console.WriteLine("\n=======================");

            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                dewo[i] = Int32.Parse(s1);
            }
        }
        public void insertion_sort()
        {
            for (int i = 1; i < n; i++)
            {
                int temp = dewo[i];
                int ED = i - 1;
                while (ED >= 0 && dewo[ED] > temp)
                {
                    dewo[ED + 1] = dewo[ED];
                    ED--;
                }
                dewo[ED + 1] = temp;
            }
        }

        public void merge_sort(int high, int low)
        {
            if (low >= high)
                return;

            int mid = (low + high) / 2;

            merge_sort(low, mid);
            merge_sort(mid + 1, high);




        }
        static void Main(string[] args)
        {
        }
    }
}
