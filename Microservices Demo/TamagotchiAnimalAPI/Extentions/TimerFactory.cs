using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TamagotchiAnimalAPI.factories
{
    [ExcludeFromCodeCoverage]
    public class TimerFactory
    {
        private readonly Timer _timer;
        private readonly AutoResetEvent _autoResetEvent;
        private readonly Action _action;

        public DateTime TimeStarted { get; set; }

        public TimerFactory(Action action)
        {
            _action = action;
            _timer = new Timer(Execute,_autoResetEvent,1000,5000);
            TimeStarted = DateTime.Now;
        }

        private void Execute(object state)
        {
            _action();

            if ((DateTime.Now - TimeStarted).Seconds > 60)
            {
                _timer.Dispose();
            }

        }
    }
}
