namespace BarsGroup_Developer_Task2
{
    using System;
    using System.Threading;

    internal class AsyncCaller
    {
        private readonly EventHandler _handler;
        public AsyncCaller(EventHandler handler) => _handler = handler;
        public bool Invoke(int millisecondsTimeout, object sender, EventArgs eventArgs)
        {
            Thread thread = new Thread(new ThreadStart(() => _handler.Invoke(sender, eventArgs)));
            thread.Start();
            if (thread.Join(millisecondsTimeout))
            {
                return true;
            }
            else
            {
                thread.Abort();
                return false;
            }
        }

    }
}
