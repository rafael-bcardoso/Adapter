using System;

namespace Adapter.Interfaces
{
    public interface ILoggerCustom
    {
        void Send(string message, string className, DateTime date);
    }
}
