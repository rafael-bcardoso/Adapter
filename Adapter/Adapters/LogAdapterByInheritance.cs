using Adapter.Interfaces;
using Adapter.Services;
using System;

namespace Adapter.Adapters
{
    class LogAdapterByInheritance : LoggerCustom, ILogger
    {
        public void Send()
        {
            Forward("Logando messagens do sistema através do Adapter e herança", this.GetType().Name, DateTime.Now);
        }
    }
}
