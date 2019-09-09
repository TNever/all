using System;

namespace 二分查找
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seqList = { 2, 8, 10, 13, 21, 36, 51, 57, 62, 69 };

            Console.WriteLine("-------------基本二分查找-------------");
            Console.WriteLine("查找51：{0}", SeqSearch(seqList, 51));
            Console.WriteLine("查找8：{0}", SeqSearch(seqList, 8));
            Console.WriteLine("查找15：{0}", SeqSearch(seqList, 15));
        }

        static int SeqSearch(int[] seqList, int key)
        {
            int low = 0;
            int high = seqList.Length - 1;
            int mid;

            while (low <= high)
            {
                mid = (low + high) / 2;
                if (seqList[mid] == key)
                {
                    return mid;
                }
                else if (seqList[mid] < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}
