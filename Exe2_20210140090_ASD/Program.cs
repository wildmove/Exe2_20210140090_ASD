using System;

namespace Exe2_ASD
{
    

    class Method1
    {
        //Declare variabel int untuk simpan data
        private int n;
        //Declare array int ukuran 110
        int[] arr = new int[110];

        public void input()
        {
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 110)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        public void sort1()
        {
            for (int i = 1; i <= n - 1; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j < 0 || arr[j] <= temp)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
        }
        public void display()
        {
            //Menampilkan Array yang tersusun
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("");
        }

    }

    class Method2
    {
        //Declare variabel yang dibutuhkan
        private int[] arr = new int[110];
        int pivot, i, j, k;
        //Declare variabel int untuk simpan data
        private int n;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 110)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements");
            }
            Console.WriteLine("\n==================");
            Console.WriteLine("Enter array elements");
            Console.WriteLine("\n================--");

            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        void display()
        {
            Console.WriteLine("\n-------------------");
            Console.WriteLine("Sorted array elements");
            Console.WriteLine("---------------------");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("\nNumber of comparisons: " + cmp_count);
            Console.WriteLine("\nNumber of data movements: " + mov_count);
        }



    }

    

    



    class Pr
    {
        
        static void Main(string[] args)
        {
            

        }
    }
}

// Max data num = 90 + 20 - 2 x 15 + 10 + 20
// Max data num = 110 - 30 + 30
// Max data num = 110

// j = MA

// arr = wildan