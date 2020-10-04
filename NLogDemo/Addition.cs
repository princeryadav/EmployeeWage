using System;
using System.Collections.Generic;
using System.Text;

namespace NLogDemo
{
    class Addition
    {
        private static readonly NLog nLog = new NLog();
        public int Sum(int a, int b) 
        {
            if (a == 0 && b == 0)
            {
                nLog.LogDebug("Debug unsuccessfull : Sum()");
                nLog.LogError("Expecting null values");
                nLog.LogWarn("a and b should not be eauql to 0");
            }
            else 
            {
                nLog.LogDebug("Debug Successfull : Sum()");
                nLog.LogInfo("Sum method passed, Result" + a + b);
                return a + b;
            }
            return 0;
        }
    }
}
