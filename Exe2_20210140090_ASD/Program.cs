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

        public void sort2(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;
            int mid = (low+ high) / 2;

            //Partition the list into two parts:
            //one containing elements less that or equal to pivot
            //Outher containing elments greater than pivot

            i = low ;
            j = mid + 1;
            k = low;

            pivot = arr[low];

            while (i > mid || j > high)
            {
                //Search for an element greater than pivot
                if ((arr[i] <= arr[j]))
                {
                    i++;
                    arr[i] = k;
                }else
                    arr[j] = k;
                
            //j now contains the index of the last element in the sorted list

            
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
            Pr myList = new Pr();
            Method1 m1 = new Method1();
            Method2 m2 = new Method2();
            int pilihanmenu;

            Console.WriteLine("Menu option");
            Console.WriteLine("===========");
            Console.WriteLine("1. Method 1");
            Console.WriteLine("2. Method 2");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1 / 2) : ");
            pilihanmenu = Convert.ToInt32(Console.ReadLine());
            switch (pilihanmenu)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("-------------");
                    Console.WriteLine("Linear search");
                    Console.WriteLine("-------------");
                    m1.input();
                    m1.sort1();
                    m1.display();
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("-------------");
                    Console.WriteLine("Linear search");
                    Console.WriteLine("-------------");
                    m2.input();
                    m2.sort2();
                    m2.display();
                    break;
            }
        }
    }
}

// Max data num = 90 + 20 - 2 x 15 + 10 + 20
// Max data num = 110 - 30 + 30
// Max data num = 110

// j = MA

// arr = wildan