using System;

namespace 希尔排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 3, 1, 2, 5 };
            ShellSort(arr);
            foreach (var temp in arr)
            {
                Console.Write(temp + " ");
            }
            Console.ReadKey();
        }

        private static void ShellSort(int[] arr)
        {
            for(int gap = arr.Length/2;gap>0;gap=gap/2)
            {
                for (int i = gap; i < arr.Length; i++)
                {
                    for (int j = i - gap; j >= 0 && arr[j] > arr[j + gap]; j-=gap)
                    {
                        int temp = arr[j + gap];
                        arr[j + gap] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}
