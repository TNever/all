﻿using System;

// 工厂方法模式引入了工厂等级结构，解决了在原来简单工厂模式中工厂类职责太重的原则，
// 但是由于工厂方法模式的每个工厂只生产一类产品，可能会导致系统中存在大量的工厂类，从而增加系统开销。
// 那么，我们应该怎么来重构？似乎，我们可以考虑将一些相关的产品组成一个“产品族”，
// 由同一个工厂来统一生产，这就是本次将要学习的抽象工厂模式的基本思想。

namespace 抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


