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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Xunit;
using Xunit.Abstractions;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class DbFunctionsSpannerTest : DbFunctionsTestBase<NorthwindQuerySpannerFixture>
    {
        public DbFunctionsSpannerTest(NorthwindQuerySpannerFixture fixture, ITestOutputHelper testOutputHelper)
            : base(fixture)
        {
            fixture.TestSqlLoggerFactory.Clear();
        }

        private const string FileLineEnding = @"
";

        private string Sql => Fixture.TestSqlLoggerFactory.Sql.Replace(Environment.NewLine, FileLineEnding);

        [Fact]
        public override void String_Like_Identity()
        {
            base.String_Like_Identity();

            Assert.Contains("WHERE c.ContactName", Sql);
        }

        [Fact]
        public override void String_Like_Literal()
        {
            // Spanner like is case-sensitive
            using (var context = CreateContext())
            {
                var count = context.Customers.Count(c => EF.Functions.Like(c.ContactName, "%M%"));

                Assert.Equal(19, count);
            }

            Assert.Contains("WHERE c.ContactName", Sql);
        }


        [Fact(Skip = "ESCAPE keyword not supported in spanner")]
        public void String_Like_Literal_With_Backslash()
        {
            using (var context = CreateContext())
            {
                var count = context.Customers.Count(c => EF.Functions.Like(c.ContactName, "\\"));

                Assert.Equal(0, count);
            }

            Assert.Contains("WHERE c.ContactName", Sql);
        }

        [Fact(Skip = "ESCAPE keyword not supported in spanner")]
        public override void String_Like_Literal_With_Escape()
        {
            base.String_Like_Literal_With_Escape();

            Assert.Contains("WHERE c.ContactName", Sql);
        }
    }
}