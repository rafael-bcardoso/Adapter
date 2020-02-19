using Adapter.Interfaces;
using System;

namespace Adapter.Adapters
{
    public class LogAdapter : ILogger
    {
        private readonly ILoggerCustom _logCustom;
        public void Send()
        {
            _logCustom.Forward("Gravando Log por Composição", this.GetType().Name, DateTime.Now);
        }
    }
}
