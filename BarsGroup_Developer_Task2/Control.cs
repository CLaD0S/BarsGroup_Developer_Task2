namespace BarsGroup_Developer_Task2
{
    using System;
    using System.Threading;
    internal static class Control
    {
        public static void TestMethodDone(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("TestMethodDone начат!");
            Thread.Sleep(2500);
            Console.WriteLine("TestMethodDone выполнен!");
        }
        public static void TestMethodTimeOut(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("TestMethodTimeOut начат!");
            Thread.Sleep(7500);
            Console.WriteLine("TestMethodTimeOut выполнен!");
        }
    }
}