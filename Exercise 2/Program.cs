using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        //definidikan array dengan ukuran maksimum 40
        private int[] Danila = new int[40];
        //variabel ukuran array
        private int n;
        //fungsi untuk menginputkan ukuran array
        public void read()
        {
            while (true)
            {
                Console.Write("masukkan jumlah element/data array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 40)
                    break;
                else
                    Console.WriteLine("\nArray maksimum 40 element/data.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan element array ");
            Console.WriteLine("-----------------------");

            // user inputs for the array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                Danila[i] = Int32.Parse(s1);
            }
        static void Main(string[] args)
        {
        }
    }
}
