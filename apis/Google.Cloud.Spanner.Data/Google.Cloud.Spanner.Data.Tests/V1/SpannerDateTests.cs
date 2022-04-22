// Copyright 2022 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class SpannerDateTests
    {
        public static IEnumerable<object[]> FromDateTimeData()
        {
            // Input: DateTime values.
            yield return new object[] { new DateTime(2022, 4, 18, 0, 0, 0, DateTimeKind.Utc) };
            yield return new object[] { new DateTime(2022, 4, 18, 1, 0, 0, DateTimeKind.Utc) };
            yield return new object[] { new DateTime(2022, 4, 18, 0, 0, 0, DateTimeKind.Local) };
            yield return new object[] { new DateTime(2022, 4, 18, 1, 0, 0, DateTimeKind.Local) };
            yield return new object[] { new DateTime(2022, 4, 18, 23, 59, 59, DateTimeKind.Utc) };
            yield return new object[] { new DateTime(2022, 4, 18, 23, 59, 59, DateTimeKind.Local) };
            yield return new object[] { new DateTime(2022, 4, 18, 23, 59, 59, DateTimeKind.Unspecified) };
            yield return new object[] { new DateTime(0001, 01, 01, 0, 0, 0, DateTimeKind.Utc) };
            yield return new object[] { new DateTime(9999, 12, 31, 23, 59, 59, DateTimeKind.Utc) };
            yield return new object[] { new DateTime(2000, 12, 31, 23, 59, 59, DateTimeKind.Unspecified) };
        }

        [Theory]
        [InlineData("0001-01-01")]
        [InlineData("9999-12-31")]
        [InlineData("2022-04-18")]
        [InlineData("2020-02-29")]
        public void ParseToStringRoundTrip(string input)
        {
            SpannerDate date = SpannerDate.Parse(input);
            Assert.Equal(input, date.ToString());

            // Check that TryParse works too.
            Assert.True(SpannerDate.TryParse(input, out var date2));
            Assert.Equal(date, date2);
        }

        [Theory]
        [InlineData("")]
        [InlineData("       ")]
        [InlineData("ABCDEFGH")]
        [InlineData("pp/qq/rrss")]
        [InlineData("12-34-5678")]
        [InlineData("0000-01-01")]
        [InlineData("9999-12-32")]
        [InlineData("0000/01/01")]
        [InlineData("9999/12/32")]
        [InlineData("2020-00-01")]
        [InlineData("2020-13-13")]
        [InlineData("2020-01-00")]
        [InlineData("2020-01-32")]
        [InlineData("2020-02-30")]
        [InlineData("12/31/9999")]
        [InlineData("0001/01/01")]
        [InlineData("2022/04/20")]
        [InlineData("31/12/9999")]
        public void Parse_Invalid(string input)
        {
            Assert.Throws<FormatException>(() => SpannerDate.Parse(input));
            bool success = SpannerDate.TryParse(input, out SpannerDate date2);
            Assert.Equal(default(SpannerDate), date2);
            Assert.False(success);
        }

        [Theory]
        [InlineData("0001-01-01","0001-01-02")]
        [InlineData("9999-12-30", "9999-12-31")]
        [InlineData("0001-01-01", "2022-04-18")]
        [InlineData("2022-04-18", "9999-12-31")]
        public void Inequality(string input1, string input2)
        {
            var date1 = SpannerDate.Parse(input1);
            var date2 = SpannerDate.Parse(input2);
            // Value of input1 is always less than input2.
            // So, we assert that input1 is not equal to input2 and
            // input1 is less than input2 and input2 is greater than input1.
            // In addition to inequality, we assert that first date
            // is less than second date using Assert.True.
            Assert.NotEqual(date1, date2);
            Assert.False(date1 == date2);
            Assert.NotEqual(date1.GetHashCode(), date2.GetHashCode());
            Assert.False(date1.GetHashCode() == date2.GetHashCode());
            Assert.True(date1 != date2);
            Assert.True(!date1.Equals(date2));
            Assert.True(!date2.Equals(date1));
            Assert.True(date1 < date2);
            Assert.True(date1 <= date2);
            Assert.True(date1.CompareTo(date2) < 0);
            Assert.True(date2 > date1);
            Assert.True(date2 >= date1);
            Assert.True(date2.CompareTo(date1) > 0);
        }

        [Theory]
        [InlineData("0001-01-01")]
        [InlineData("9999-12-31")]
        [InlineData("2022-04-18")]
        [InlineData("2000-02-28")]
        public void Equality(string input1)
        {
            var date1 = SpannerDate.Parse(input1);
            var date2 = SpannerDate.Parse(input1);
            var hashCode1 = date1.GetHashCode();
            var hashCode2 = date2.GetHashCode();
            Assert.True(date1.Equals(date2));
            Assert.True(date2.Equals(date1));
            Assert.Equal(0, date1.CompareTo(date2));
            Assert.Equal(0, date2.CompareTo(date1));
            Assert.Equal(hashCode1, hashCode2);
        }

        [Theory]
        [MemberData(nameof(FromDateTimeData))]
        public void FromDateTime(DateTime input)
        {
            SpannerDate spannerDate = SpannerDate.FromDateTime(input);
            Assert.Equal(input.Date.Year, spannerDate.Year);
            Assert.Equal(input.Date.Month, spannerDate.Month);
            Assert.Equal(input.Date.Day, spannerDate.Day);
        }

        [Theory]
        [InlineData("9999-12-31")]
        [InlineData("0001-01-01")]
        [InlineData("2022-04-18")]
        [InlineData("2000-12-31")]
        public void ToDateTime(string input)
        {
            SpannerDate spannerDate = SpannerDate.Parse(input);
            var expectedDateTime = DateTime.Parse(input, CultureInfo.InvariantCulture);
            var result = spannerDate.ToDateTime();
            Assert.Equal(expectedDateTime, result);
            Assert.Equal(DateTimeKind.Unspecified, result.Kind);
        }

        [Fact]
        public void Constants()
        {
            Assert.Equal(SpannerDate.FromDateTime(DateTime.MaxValue), SpannerDate.MaxDate);
            Assert.Equal(SpannerDate.FromDateTime(DateTime.MinValue), SpannerDate.MinDate);
            Assert.Equal(default(SpannerDate), SpannerDate.Parse("0001-01-01"));
        }
    }
}
