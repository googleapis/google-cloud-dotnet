// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.TestModels.Northwind;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class QuerySpannerTest : QueryTestBase<NorthwindQuerySpannerFixture>
    {
        public QuerySpannerTest(NorthwindQuerySpannerFixture fixture)
            : base(fixture)
        {
            Fixture.TestSqlLoggerFactory.Clear();
        }

        [Fact]
        public override void String_Contains_Literal()
        {
            var test = CreateContext().Set<Customer>().ToArray();

            base.String_Contains_Literal();
            AssertContainsInSql("WHERE STRPOS(\"c\".\"ContactName\", 'M') > 0");
        }

        [Fact]
        public override void String_StartsWith_Literal()
        {
            base.String_StartsWith_Literal();
            AssertContainsInSql("WHERE \"c\".\"ContactName\" LIKE 'M%'");
        }

        [Fact]
        public override void String_StartsWith_Column()
        {
            AssertQuery<Customer>(cs => cs.Where(c => c.ContactName.StartsWith(c.City)));
            AssertContainsInSql(
                @"WHERE ""c"".""ContactName"" LIKE (""c"".""City"" || '%') AND (LEFT(""c"".""ContactName"", LENGTH(""c"".""City"")) = ""c"".""City"")");
        }

        [Fact]
        public override void String_EndsWith_Literal()
        {
            base.String_EndsWith_Literal();
            AssertContainsInSql("WHERE RIGHT(\"c\".\"ContactName\", LENGTH('b')) = 'b'");
        }

        [Fact]
        public override void Trim_without_argument_in_predicate()
        {
            base.Trim_without_argument_in_predicate();
            AssertContainsInSql(@"WHERE REGEXP_REPLACE(""c"".""ContactTitle"", '^\s*(.*?)\s*$', '\1') = 'Owner'");
        }

        [Fact]
        public override void Trim_with_char_argument_in_predicate()
        {
            base.Trim_with_char_argument_in_predicate();
            AssertContainsInSql("WHERE BTRIM(\"c\".\"ContactTitle\", 'O')");
        }

        [Fact]
        public override void Trim_with_char_array_argument_in_predicate()
        {
            base.Trim_with_char_array_argument_in_predicate();
            AssertContainsInSql("WHERE BTRIM(\"c\".\"ContactTitle\", 'Or')");
        }

        [Fact]
        public override void TrimStart_without_arguments_in_predicate()
        {
            base.TrimStart_without_arguments_in_predicate();
            AssertContainsInSql("WHERE REGEXP_REPLACE(\"c\".\"ContactTitle\", '^\\s*', '') = 'Owner'");
        }

        [Fact]
        public override void TrimStart_with_char_argument_in_predicate()
        {
            base.TrimStart_with_char_argument_in_predicate();
            AssertContainsInSql("WHERE LTRIM(\"c\".\"ContactTitle\", 'O')");
        }

        [Fact]
        public override void TrimStart_with_char_array_argument_in_predicate()
        {
            base.TrimStart_with_char_array_argument_in_predicate();
            AssertContainsInSql("WHERE LTRIM(\"c\".\"ContactTitle\", 'Ow')");
        }

        [Fact]
        public override void TrimEnd_without_arguments_in_predicate()
        {
            base.TrimEnd_without_arguments_in_predicate();
            AssertContainsInSql("WHERE REGEXP_REPLACE(\"c\".\"ContactTitle\", '\\s*$', '') = 'Owner'");
        }

        [Fact]
        public override void TrimEnd_with_char_argument_in_predicate()
        {
            base.TrimEnd_with_char_argument_in_predicate();
            AssertContainsInSql("WHERE RTRIM(\"c\".\"ContactTitle\", 'r')");
        }

        [Fact]
        public override void TrimEnd_with_char_array_argument_in_predicate()
        {
            base.TrimEnd_with_char_array_argument_in_predicate();
            AssertContainsInSql("WHERE RTRIM(\"c\".\"ContactTitle\", 'er')");
        }

        [Fact]
        public override void IsNullOrWhiteSpace_in_predicate()
        {
            base.IsNullOrWhiteSpace_in_predicate();
            AssertContainsInSql("WHERE \"c\".\"Region\" IS NULL OR (\"c\".\"Region\" ~ '^\\s*$' = TRUE)");
        }

        [Fact]
        public override void Query_expression_with_to_string_and_contains()
        {
            base.Query_expression_with_to_string_and_contains();
            AssertContainsInSql("STRPOS(CAST(\"o\".\"EmployeeID\" AS text), '10') > 0");
        }

        [Fact]
        public override void Where_datetime_now()
        {
            base.Where_datetime_now();
            AssertContainsInSql("WHERE NOW() <>");
        }

        [Fact]
        public override void Where_datetime_utcnow()
        {
            base.Where_datetime_utcnow();
            AssertContainsInSql("WHERE NOW() AT TIME ZONE 'UTC' <>");
        }

        [Fact]
        public override void Where_datetime_date_component()
        {
            base.Where_datetime_date_component();
            AssertContainsInSql("WHERE DATE_TRUNC('day', \"o\".\"OrderDate\")");
        }

        [Fact]
        public override void Where_datetime_year_component()
        {
            base.Where_datetime_year_component();
            AssertContainsInSql("DATE_PART('year', \"o\".\"OrderDate\")");
        }

        [Fact]
        public override void Where_datetime_month_component()
        {
            base.Where_datetime_month_component();
            AssertContainsInSql("DATE_PART('month', \"o\".\"OrderDate\")");
        }

        [Fact]
        public override void Where_datetime_dayOfYear_component()
        {
            base.Where_datetime_dayOfYear_component();
            AssertContainsInSql("DATE_PART('doy', \"o\".\"OrderDate\")");
        }

        [Fact]
        public override void Where_datetime_day_component()
        {
            base.Where_datetime_day_component();
            AssertContainsInSql("DATE_PART('day', \"o\".\"OrderDate\")");
        }

        [Fact]
        public override void Where_datetime_hour_component()
        {
            base.Where_datetime_hour_component();
            AssertContainsInSql("DATE_PART('hour', \"o\".\"OrderDate\")");
        }

        [Fact]
        public override void Where_datetime_minute_component()
        {
            base.Where_datetime_minute_component();
            AssertContainsInSql("DATE_PART('minute', \"o\".\"OrderDate\")");
        }

        [Fact]
        public override void Where_datetime_second_component()
        {
            base.Where_datetime_second_component();
            AssertContainsInSql("DATE_PART('second', \"o\".\"OrderDate\")");
        }

        // ReSharper disable once RedundantOverriddenMember
        [Fact]
        public override void Where_datetime_millisecond_component()
        {
            // SQL translation not implemented, too annoying
            base.Where_datetime_millisecond_component();
        }

        private void AssertContainsInSql(string expected)
            => Assert.Contains(expected, Fixture.TestSqlLoggerFactory.Sql);

        protected override void ClearLog()
            => Fixture.TestSqlLoggerFactory.Clear();

        [Fact]
        public void IsNullOrWhiteSpace_in_predicate_with_newline()
        {
            using (var context = CreateContext())
            {
                var query = context.Set<Customer>()
                    .FirstOrDefault(c => string.IsNullOrWhiteSpace("\n"));
                Assert.NotNull(query);
            }
        }

        [Fact(Skip = "https://github.com/aspnet/EntityFramework/issues/8606")]
        public override void OrderBy_coalesce_skip_take_distinct_take()
        {
        }

        [Fact]
        public void Regex_IsMatch()
        {
            AssertQuery<Customer>(
                cs => cs.Where(c => Regex.IsMatch(c.CompanyName, "^A")),
                entryCount: 4);
            AssertContainsInSql("WHERE \"c\".\"CompanyName\" ~ ('(?p)' || '^A')");
        }

        [Fact]
        public void Regex_IsMatchOptionsIgnoreCase()
        {
            AssertQuery<Customer>(
                cs => cs.Where(c => Regex.IsMatch(c.CompanyName, "^a", RegexOptions.IgnoreCase)),
                entryCount: 4);
            AssertContainsInSql("WHERE \"c\".\"CompanyName\" ~ ('(?ip)' || '^a')");
        }

        [Fact]
        public void Regex_IsMatchOptionsIgnorePatternWhitespace()
        {
            AssertQuery<Customer>(
                cs => cs.Where(c => Regex.IsMatch(c.CompanyName, "^ A", RegexOptions.IgnorePatternWhitespace)),
                entryCount: 4);
            AssertContainsInSql("WHERE \"c\".\"CompanyName\" ~ ('(?px)' || '^ A')");
        }

        [Fact]
        public void Regex_IsMatchOptionsMultiline()
        {
            AssertQuery<Customer>(
                cs => cs.Where(c => Regex.IsMatch(c.CompanyName, "^A", RegexOptions.Multiline)),
                entryCount: 4);
            AssertContainsInSql("WHERE \"c\".\"CompanyName\" ~ ('(?n)' || '^A')");
        }

        [Fact]
        public void Regex_IsMatchOptionsNone()
        {
            AssertQuery<Customer>(
                cs => cs.Where(c => Regex.IsMatch(c.CompanyName, "^A", RegexOptions.None)),
                entryCount: 4);
            AssertContainsInSql("WHERE \"c\".\"CompanyName\" ~ ('(?p)' || '^A')");
        }

        [Fact]
        public void Regex_IsMatchOptionsSingleline()
        {
            AssertQuery<Customer>(
                cs => cs.Where(c => Regex.IsMatch(c.CompanyName, "^A", RegexOptions.Singleline)),
                entryCount: 4);
            AssertContainsInSql("WHERE \"c\".\"CompanyName\" ~ '^A'");
        }

        [Fact]
        public void Regex_IsMatchOptionsUnsupported()
        {
            AssertQuery<Customer>(
                cs => cs.Where(c => Regex.IsMatch(c.CompanyName, "^A", RegexOptions.RightToLeft)),
                entryCount: 4);
            Assert.DoesNotContain("WHERE \"c\".\"CompanyName\" ~ ", Fixture.TestSqlLoggerFactory.Sql);
        }

        [Fact]
        public void String_IndexOf_Char()
        {
            AssertQuery<Customer>(
                cs => cs.Where(c => c.CompanyName.IndexOf('A') > 5),
                entryCount: 9);
            AssertContainsInSql("WHERE (STRPOS(\"c\".\"CompanyName\", 'A') - 1) > 5");
        }

        [Fact]
        public void String_IndexOf_not_found()
        {
            AssertQuery<Customer>(
                cs => cs.Where(c => c.CompanyName.IndexOf("[") == -1),
                entryCount: 91);
            AssertContainsInSql("WHERE (STRPOS(\"c\".\"CompanyName\", '[') - 1) = -1");
        }

        [Fact]
        public void String_IndexOf_String()
        {
            AssertQuery<Customer>(
                cs => cs.Where(c => c.CompanyName.IndexOf("ar") > 5),
                entryCount: 13);
            AssertContainsInSql("WHERE (STRPOS(\"c\".\"CompanyName\", 'ar') - 1) > 5");
        }

        [Fact]
        public void String_StartsWith_Literal_with_escaping()
        {
            AssertQuery<Customer>(cs => cs.Where(c => c.ContactName.StartsWith(@"_a%b\c")));
            AssertContainsInSql(@"WHERE ""c"".""ContactName"" LIKE '\_a\%b\\c%'");
        }

        [Fact]
        public void Where_datetime_dayOfWeek_component()
        {
            AssertQuery<Order>(
                oc => oc.Where(o =>
                    o.OrderDate.Value.DayOfWeek == DayOfWeek.Tuesday),
                entryCount: 168);
            AssertContainsInSql("WHERE CAST(FLOOR(DATE_PART('dow', \"o\".\"OrderDate\")) AS int4)");
        }

    }
}