using Adapter.Adapters;
using Adapter.Interfaces;
using Adapter.Services;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger log = new Logger();
            log.Send();


            ILogger logCustom = new LogAdapter();
            logCustom.Send();
        }
    }
}
