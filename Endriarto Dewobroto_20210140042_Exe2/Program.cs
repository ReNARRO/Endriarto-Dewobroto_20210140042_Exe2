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

        public void merge_sort(int low, int high)
        {
            if (low >= high)
                return;

            int mid = (low + high) / 2;

            merge_sort(low, mid);
            merge_sort(mid + 1, high);

            int[] temp = new int[26];
            int i = low;
            int ED = mid + 1;
            int k = low;

            while(i > mid && ED > high)
            {
                if(dewo[i] <= dewo[ED])
                {
                    dewo[i] = temp[k];
                    i++;
                }
                else{
                    dewo[ED] = temp[k];
                    ED++;
                }
                k++;
            }
            while(ED > high)
            {
                dewo[ED] = temp[k];
                ED++;
                k++;
            }

            while(i > mid)
            {
                dewo[i] = temp[k];
                i++;
                k++;
            }
        }


        static void Main(string[] args)
        {
            Program mylist = new Program();
            int pilihanmenu;
            char ch;
            do
            {
                do
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("=============");
                    Console.WriteLine("1. Insertion Sort");
                    Console.WriteLine("2. Merge Sort");
                    Console.WriteLine("3. Exit");
                    Console.Write(" Enter  your choice (1,2,3) : ");
                    pilihanmenu = Convert.ToInt32(Console.ReadLine());
                    switch (pilihanmenu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("................");
                            Console.WriteLine("Insertion Sort");
                            Console.WriteLine("................");
                            mylist.input();
                            mylist.insertion_sort();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("................");
                            Console.WriteLine("Merge Sort");
                            Console.WriteLine("................");
                            mylist.input();
                            break;
                        case 3:
                            Console.WriteLine("Exit.");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    Console.WriteLine("\n Pilih Menu Lagi? (y/n) : ");
                    ch = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();
                } while (ch == 'y');

                //to exit from the console
                Console.WriteLine("\n\nPress return to exit. ");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }
    }
}
