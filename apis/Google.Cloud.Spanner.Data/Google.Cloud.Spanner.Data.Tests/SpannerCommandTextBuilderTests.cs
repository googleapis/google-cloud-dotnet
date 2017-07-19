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
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerCommandTextBuilderTests
    {
        [Theory]
        [InlineData("DROP DATABASE FOO")]
        [InlineData("DROP DATABASE FOO;")]
        [InlineData("DROP DATABASE  FOO")]
        [InlineData("DROP DATABASE      FOO")]
        [InlineData("DROP DATABASE  FOO     ;")]
        [InlineData("DROP DATABASE      FOO;;")]
        public void DropDatabasePositive(string ddlString)
        {
            SpannerCommandTextBuilder builder = new SpannerCommandTextBuilder(ddlString);
            Assert.True(builder.IsDropDatabaseCommand);
            Assert.Equal("FOO", builder.DatabaseToDrop);

            //via spannerconnection as well...
            using (var connection = new SpannerConnection("Data Source=projects/p/instances/i"))
            {
                var command = connection.CreateDdlCommand(ddlString);
                Assert.True(command.SpannerCommandTextBuilder.IsDropDatabaseCommand);
                Assert.Equal("FOO", command.SpannerCommandTextBuilder.DatabaseToDrop);
            }
        }

        [Theory]
        [InlineData("DROPDATABASE FOO;")]
        [InlineData("DROP DATABASE FOO BAR")]
        public void DropDatabaseNegative(string ddlString)
        {
            Assert.Throws<InvalidOperationException>(
                () =>
                {
                    var builder = new SpannerCommandTextBuilder(ddlString);
                    // ReSharper disable once UnusedVariable
                    string ignored = builder.DatabaseToDrop;
                });
        }

        [Theory]
        [InlineData("DROP DATABASEFOO")]
        [InlineData("DROP  DATABASE  FOO")]
        public void DropDatabaseUnrecognized(string ddlString)
        {
            var builder = new SpannerCommandTextBuilder(ddlString);
            Assert.False(builder.IsDropDatabaseCommand);
        }
    }
}
