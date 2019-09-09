using System;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance();
            Console.ReadKey();
        }

        public sealed class Singleton
        {
            //在Singleton第一次被调用时会执行instance的初始化
            //静态变量实现单例，该例子利用.net的特性来完成单例模式的创建，是线程安全的
            private static readonly Singleton instance = new Singleton();

            private Singleton()
            {
                Console.WriteLine("开启单线程");
            }

            public static Singleton Instance()
            {
                return instance;
            }
        }
    }
}
