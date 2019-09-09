using System;

namespace 插入排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 3, 1, 2, 5 };
            InsertionSort(arr);
            foreach (var temp in arr)
            {
                Console.Write(temp + " ");
            }
            Console.ReadKey();
        }

        private static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i-1; j >= 0 && arr[j] > arr[j+1]; j--)
                {
                    int temp = arr[j+1];
                    arr[j+1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
}
