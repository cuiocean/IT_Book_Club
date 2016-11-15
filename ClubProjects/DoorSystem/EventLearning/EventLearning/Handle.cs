using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLearning
{
    public class Handle
    {
        public event EventHandler<HandleOpenTimeEventArg> HandleOpened;

        public void Open()
        {
            DateTime dateTime = DateTime.Now;
            OnHandleOpened(dateTime);
        }

        protected virtual void OnHandleOpened(DateTime dateTime)
        {
            HandleOpened?.Invoke(this, new HandleOpenTimeEventArg(dateTime));
        }
    }

    public class HandleOpenTimeEventArg : EventArgs
    {
        public HandleOpenTimeEventArg(DateTime dateTime) : base()
        {
            OpenTime = dateTime;
        }
        public DateTime OpenTime { get; }
    }
}
