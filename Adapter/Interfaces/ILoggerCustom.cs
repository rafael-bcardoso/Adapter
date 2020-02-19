using System;

namespace Adapter.Interfaces
{
    public interface ILoggerCustom
    {
        void Forward(string message, string className, DateTime date);
    }
}
