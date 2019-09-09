using System;

// 简单工厂模式虽然简单，但是存在一个很严重的问题：
// 当系统中需要引入新产品时，由于静态工厂方法通过所传入参数的不同来创建不同的产品，这必定要修改工厂类的源代码，将违背开闭原则。
// 如何实现新增新产品而不影响已有代码？工厂方法模式为此应运而生。
namespace 工厂方法模式
{
    class Program
    {
        // 抽象产品：ILogger接口
        public interface ILogger
        {
            void WriteLog();
        }
        // 抽象工厂：ILoggerFactory接口
        public interface ILoggerFactory
        {
            ILogger CreateLogger();
        }

        // 列举两个具体产品
        public class FileLogger : ILogger
        {
            public void WriteLog()
            {
                Console.WriteLine("文件日志记录...");
            }
        }
        public class DatabaseLogger : ILogger
        {
            public void WriteLog()
            {
                Console.WriteLine("数据库日志记录...");
            }
        }

        // 列举具体工厂：FileLoggerFactory和DatabaseLoggerFactory类
        public class FileLoggerFactory : ILoggerFactory
        {
            public ILogger CreateLogger()
            {
                ILogger logger = new FileLogger();
                return logger;
            }
        }

        public class DatabaseLoggerFactory : ILoggerFactory
        {
            public ILogger CreateLogger()
            {
                ILogger logger = new DatabaseLogger();
                return logger;
            }
        }

        static void Main(string[] args)
        {
            ILoggerFactory factory = new FileLoggerFactory(); // 可通过引入配置文件实现
            if (factory == null)
            {
                return;
            }

            ILogger logger = factory.CreateLogger();
            logger.WriteLog();

            ILoggerFactory factory2 = new DatabaseLoggerFactory(); 
            if (factory2 == null)
            {
                return;
            }

            ILogger logger2 = factory2.CreateLogger();
            logger2.WriteLog();
        }
    }
}
