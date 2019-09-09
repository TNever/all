using System;

namespace 顺序查找
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seqList = { 2, 8, 10, 13, 21, 36, 51, 57, 62, 69 };

            Console.WriteLine("-------------基本顺序查找-------------");
            Console.WriteLine("查找51：{0}", SequenceSearch(seqList, 51));
            Console.WriteLine("查找8：{0}", SequenceSearch(seqList, 8));
            Console.WriteLine("查找15：{0}", SequenceSearch(seqList, 15));
        }

        static int SequenceSearch(int[] seqList, int key)
        {
            int index = -1;
            for (int i = 0; i < seqList.Length; i++)
            {
                if (seqList[i] == key)
                {
                    index = i;
                    break;
                }
            }
            // 不存在
            return index;
        }
    }
}
