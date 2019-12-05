using System;

namespace DesignPatterns.SOLID.DependencyInversionPrinciple
{
    public class ExceptionLogger
    {
        private readonly ILogger _logger;
        public ExceptionLogger(ILogger aLogger)
        {
            this._logger = aLogger;
        }
        public void LogException(Exception aException)
        {
            string strMessage = GetUserReadableMessage(aException);
            this._logger.LogMessage(strMessage);
        }
        private string GetUserReadableMessage(Exception aException)
        {
            string strMessage = string.Empty;
            //code to convert Exception's stack trace and message to user readable format.  
           return strMessage;
        }
    }
}
