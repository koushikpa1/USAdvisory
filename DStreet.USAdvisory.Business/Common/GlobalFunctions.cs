using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DStreet.USAdvisory.Business.Common
{
    public static class GlobalFunctions
    {

        public static DateTime GetCurrentTimeInEST()
        {
            DateTime MyTime = new DateTime(DateTime.Now.Ticks, DateTimeKind.Local);
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(MyTime, "Eastern Standard Time");

        }
    }
}
