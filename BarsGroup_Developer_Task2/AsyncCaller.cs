namespace BarsGroup_Developer_Task2
{
    using System;
    internal class AsyncCaller
    {
        private EventHandler _handler;
        public AsyncCaller(EventHandler handler) => _handler = handler;
        public bool Invoke(int millisecondsTimeout, object sender, EventArgs eventArgs)
        {
            IAsyncResult asyncResult = _handler.BeginInvoke(sender, eventArgs, null, null);
            asyncResult.AsyncWaitHandle.WaitOne(millisecondsTimeout);
            return asyncResult.IsCompleted == true ? true : false;
        }
    }
}