using System;

namespace 插值查找
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seqList = { 2, 8, 10, 13, 21, 36, 51, 57, 62, 69 };

            Console.WriteLine("-------------基本插值查找-------------");
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
                // 和二分查找唯一的区别：mid的获取方式，用了一个公式来计算key距离low比较近还是距离high比较近，可有效提高查找效率
                // 公式：mid=低位+（中数-底数 / 高数-中数）*（高位-低位）
                mid = low + ((key - seqList[low]) / (seqList[high] - seqList[low])) * (high - low);
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
