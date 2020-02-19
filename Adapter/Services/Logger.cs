using Adapter.Interfaces;
using System;

namespace Adapter.Services
{
    public class Logger : ILogger
    {
        public void Send()
        {
            Console.WriteLine("Send email pattern");
        }
    }
}
