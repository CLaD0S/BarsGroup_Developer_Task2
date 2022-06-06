namespace BarsGroup_Developer_Task2
{
    using System;
    internal static class Program
    {
        private delegate void MyEventHandler(object sender, EventArgs eventArgs);
        private static void Main()
        {
            Console.WriteLine("Выполнение AsyncCaller'а ограничено в 5000 миллисекунд");
            
            TestMethod(Control.TestMethodTimeOut);
            TestMethod(Control.TestMethodDone);

            Console.ReadKey();
        }

        private static void TestMethod(MyEventHandler myEventHandler)
        {
            DateTime dateTime = DateTime.Now;

            EventHandler handler = new EventHandler(myEventHandler);
            AsyncCaller asyncCaller = new AsyncCaller(handler);
            bool completedOK = asyncCaller.Invoke(5000, null, EventArgs.Empty);

            Console.WriteLine("Экземпляр AsyncCaller вернул :" + completedOK);
            Console.WriteLine("    Прошло:" + (DateTime.Now - dateTime).TotalMilliseconds + " миллисекунд.");
        }
    }
}