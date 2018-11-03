using System;
using System.Collections.Generic;

namespace Common
{
    public static class LoggingService
    {
        public static string WriteToFile(List<ILoggable> changedItems)
        {
            var logs = string.Empty;

            foreach (var item in changedItems)
            {
                logs += $"{item.Log()}{Environment.NewLine}";
            }

            logs = logs.Trim();

            return logs;
        }
    }
}
