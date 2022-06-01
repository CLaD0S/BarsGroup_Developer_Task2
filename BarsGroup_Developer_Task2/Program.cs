namespace BarsGroup_Developer_Task2
{
    using System;
    internal static class Program
    {
        private delegate void MyEventHandler(object sender, EventArgs e);
        private static void Main()
        {
            EventHandler handler = new EventHandler(Control.TestMethodTimeOut);
            TestMethod(Control.TestMethodTimeOut);
            TestMethod(Control.TestMethodDone);

            Console.ReadKey();
        }

        private static void TestMethod(MyEventHandler myEventHandler)
        {
            EventHandler handler = new EventHandler(myEventHandler);
            DateTime dateTime = DateTime.Now;
            AsyncCaller asyncCaller = new AsyncCaller(handler);
            bool completedOK = asyncCaller.Invoke(5000, null, EventArgs.Empty);
            Console.WriteLine("Экземпляр AsyncCaller вернул :" + completedOK);
            Console.WriteLine("    Прошло:" + (DateTime.Now - dateTime).TotalMilliseconds + " миллисекунд.");
        }

    }
}