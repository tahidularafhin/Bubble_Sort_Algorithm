using System;

namespace Bubble_Sort_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 89, -1, 0, 4, 2, 3 };
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int flag = 0;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        flag = 1;
                    }

                }

                if (flag == 0)
                {
                    break;
                }


            }



            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
