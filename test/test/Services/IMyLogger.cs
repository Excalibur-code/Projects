using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Services
{
    public interface IMyLogger
    {
        void LogMessage();

        void LogMessage(string message);
    }
}
