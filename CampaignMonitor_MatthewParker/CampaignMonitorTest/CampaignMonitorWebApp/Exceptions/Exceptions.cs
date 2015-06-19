using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampaignMonitorWebApp.Exceptions
{
    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException() { }
        public InvalidTriangleException(string message) : base(message) { }
        public InvalidTriangleException(string message, Exception inner) : base(message, inner) { }
    }
}