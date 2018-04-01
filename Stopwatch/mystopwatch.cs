using System;
using System.Runtime.Remoting.Messaging;

namespace StopWatch
{
    public class mystopwatch
    {
        private DateTime _now1;
        private DateTime _now2;
        private TimeSpan Calc;

        public void Start()
        {
            _now1 = DateTime.Now;
        }

        public void Stop()
        {
            _now2 = DateTime.Now;

        }

        public void Continue()
        {

        }

        public TimeSpan Calculate()
        {
            return _now2 - _now1;
        }
    }
}