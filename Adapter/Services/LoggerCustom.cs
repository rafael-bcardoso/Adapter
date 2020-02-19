using Adapter.Interfaces;
using System;

namespace Adapter.Services
{
    public class LoggerCustom : ILoggerCustom
    {
        public void Send(string message, string className, DateTime date)
        {
            Console.WriteLine($"A messagem é : {message} e foi envida pela classe {className} e foi emitida na data {date}");
        }
    }
}
