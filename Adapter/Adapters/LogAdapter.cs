using Adapter.Interfaces;
using Adapter.Services;
using System;

namespace Adapter.Adapters
{
    public class LogAdapter : ILogger
    {
        private readonly ILoggerCustom _logCustom;

        public LogAdapter()
        {
            _logCustom = new LoggerCustom();
        }

        public void Send()
        {
            _logCustom.Forward("Gravando Log por Composição", this.GetType().Name, DateTime.Now);
        }
    }
}
