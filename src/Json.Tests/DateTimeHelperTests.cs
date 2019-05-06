using System;
using Xunit;

namespace OpenFoodFacts4Net.Json.Tests
{
    public class DateTimeHelperTests
    {
        [Theory]
        [InlineData(1556280105, 2019, 4, 26, 12, 1, 45)]
        [InlineData(1338046925, 2012, 5, 26, 15, 42, 5)]
        public void Should_Convert_UnixTimestamp_ToDateTime(Int64 timestamp, Int32 year, Int32 month, Int32 day, Int32 hour, Int32 minute, Int32 second)
        {
            DateTime expectedDateTime = new DateTime(year, month, day, hour, minute, second, DateTimeKind.Utc);
            
            DateTime actualDateTime = DateTimeHelper.UnixTimestampToDateTime(timestamp);
            Assert.Equal(expectedDateTime, actualDateTime);
        }
    }
}
