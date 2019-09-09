using System;

namespace 快速排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 3, 1, 2, 5 };
            QuickSort(arr,0,arr.Length-1);
            foreach (var temp in arr)
            {
                Console.Write(temp + " ");
            }
            Console.ReadKey();
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left > right)
            {
                return;
            }
            int i, j, temp;
            i = left;
            j = right;
            temp = arr[left];
            while (i != j)
            {
                while (arr[j] >= temp && i < j)
                {
                    j--;
                }
                while (arr[i] <= temp && i < j)
                {
                    i++;
                }
                if (i < j)
                {
                    int t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;
                }
            }
            arr[left] = arr[i];
            arr[i] = temp;
            QuickSort(arr, left, i - 1);
            QuickSort(arr, i + 1, right);
        }
    }
}
