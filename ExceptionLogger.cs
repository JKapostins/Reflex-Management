using System;

namespace ReflexUtility
{
    public class ExceptionLogger
    {
        public static void LogException(Exception e)
        {
            Console.Error.WriteLine(e.Message);
            if (e.InnerException != null)
            {
                LogException(e.InnerException);
            }
        }
    }
}
