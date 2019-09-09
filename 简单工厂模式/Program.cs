using System;

namespace 简单工厂模式
{
    class Program
    {
        // 图标接口
        public interface IChartable
        {
            void Display();
        }

        // 创建柱状图
        public class HistogramChart : IChartable
        {
            public HistogramChart()
            {
                Console.WriteLine("创建柱状图...");
            }

            public void Display()
            {
                Console.WriteLine("显示柱状图...");
            }
        }

        // 创建折线图
        public class LineChart : IChartable
        {
            public LineChart()
            {
                Console.WriteLine("创建折线图...");
            }

            public void Display()
            {
                Console.WriteLine("显示折线图...");
            }
        }

        // 创建饼状图
        public class PieChart : IChartable
        {
            public PieChart()
            {
                Console.WriteLine("创建饼状图...");
            }

            public void Display()
            {
                Console.WriteLine("显示饼状图...");
            }
        }

        // 图表的生产工厂，但仅仅是调用以上的生产方法，实际不包含生产方法
        public class ChartFactory
        {
            public static IChartable GetChart(string type)
            {
                IChartable chart = null;

                if (type.Equals("histogram", StringComparison.OrdinalIgnoreCase))
                {
                    chart = new HistogramChart();
                    Console.WriteLine("初始化设置柱状图...");
                }
                else if (type.Equals("pie", StringComparison.OrdinalIgnoreCase))
                {
                    chart = new PieChart();
                    Console.WriteLine("初始化设置饼状图...");
                }
                else if (type.Equals("line", StringComparison.OrdinalIgnoreCase))
                {
                    chart = new PieChart();
                    Console.WriteLine("初始化设置折线图...");
                }

                return chart;
            }
        }

        // 主函数，我想干啥直接搞接口就行了
        static void Main(string[] args)
        {
            IChartable chart = ChartFactory.GetChart("histogram");
            if (chart != null)
            {
                chart.Display();
            }

            chart = ChartFactory.GetChart("pie");
            if (chart != null)
            {
                chart.Display();
            }
        }
    }
}
