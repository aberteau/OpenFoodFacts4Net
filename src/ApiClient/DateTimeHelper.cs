using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFoodFacts4Net.ApiClient
{
    public class DateTimeHelper
    {
        public static DateTime UnixTimestampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp);
            return dtDateTime;
        }
    }
}
