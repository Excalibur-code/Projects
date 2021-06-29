using System.Diagnostics;

namespace test.Services
{
    public class MyLogger : IMyLogger
    {
        public void LogMessage()
        {
            Debug.Write(string.Format("Message from Custom Logger !"));
        }

        public void LogMessage(string message)
        {
            Debug.Write(string.Format("Message from Custom Logger ! + : " + message));
        }
    }
}