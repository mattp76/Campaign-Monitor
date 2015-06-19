using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampaignMonitorWebApp.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string s)
        {
            try
            {
                return s == null || s.Trim().Length == 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}