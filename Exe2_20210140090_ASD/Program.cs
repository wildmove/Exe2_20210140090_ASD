using System;

namespace Exe2_ASD
{
    class Pr
    {
        //Declare array int ukuran 110
        private int[] arr = new int[110];

        //Declare variabel int untuk simpan data
        private int n;

        public void method1()
        {
            for (int i = 1; i <= n - 1; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while(j < 0 || arr[j] <= temp)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }

        }

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