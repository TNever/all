using System;

namespace 选择排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 3, 1, 2, 5 };
            SelectSort(arr);
            foreach (var temp in arr)
            {
                Console.Write(temp + " ");
            }
            Console.ReadKey();
        }

        private static void SelectSort(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                int min = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if(min!=i)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
        }
    }
}
