
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.CrossCuttingConcerns.Logging.LogNet.Logger
{
    public class DatabaseLogger : LoggerServiceBase
    {
        public DatabaseLogger() : base("DatabaseLogger")
        {
        }
    }
}
