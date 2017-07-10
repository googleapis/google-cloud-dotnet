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
using Google.Cloud.Spanner.V1;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class ConnectionStringBuilderTests
    {
        //look for "badjuju" for the error in each unit test case.
        [Theory]
        [InlineData("Data Source=badjuju/project1/instances/instance1/databases/database1")]
        [InlineData("Data Source=projects/project1/badjuju/instance1/databases/database1")]
        [InlineData("Data Source=projects/project1/instances/instance1/badjuju/database1")]
        public void BadConnectionStringThrows(string connectionString)
        {
            Assert.Throws<ArgumentException>(
                () =>
                    new SpannerConnectionStringBuilder(connectionString));

            Assert.Throws<ArgumentException>(
                () =>
                    new SpannerConnectionStringBuilder {ConnectionString = connectionString});
        }

        [Theory]
        [InlineData("badjuju/project1/instances/instance1/databases/database1")]
        [InlineData("projects/project1/badjuju/instance1/databases/database1")]
        [InlineData("projects/project1/instances/instance1/badjuju/database1")]
        [InlineData(
            "Data Source=projects/project1/instances/instance1/databases/database1")] //valid *for a connection string*
        public void BadDataSourceThrows(string dataSource)
        {
            Assert.Throws<ArgumentException>(
                () =>
                    new SpannerConnectionStringBuilder
                    {
                        DataSource = dataSource
                    }
            );
        }

        [Fact]
        public void DataSourceParsing()
        {
            var connectionStringBuilder =
                new SpannerConnectionStringBuilder(
                    "Data Source=projects/project1/instances/instance1/databases/database1");
            Assert.Equal("project1", connectionStringBuilder.Project);
            Assert.Equal("instance1", connectionStringBuilder.SpannerInstance);
            Assert.Equal("database1", connectionStringBuilder.SpannerDatabase);
        }

        [Fact]
        public void DataSourceSettableViaProperty()
        {
            var connectionStringBuilder =
                new SpannerConnectionStringBuilder
                {
                    DataSource = "projects/project1/instances/instance1/databases/database1"
                };
            Assert.Equal("project1", connectionStringBuilder.Project);
            Assert.Equal("instance1", connectionStringBuilder.SpannerInstance);
            Assert.Equal("database1", connectionStringBuilder.SpannerDatabase);
        }

        [Fact]
        public void DefaultEndpointIfNotSpecified()
        {
            var connectionStringBuilder = new SpannerConnectionStringBuilder();
            Assert.Equal(SpannerClient.DefaultEndpoint.Host, connectionStringBuilder.Host);
            Assert.Equal(SpannerClient.DefaultEndpoint.Port, connectionStringBuilder.Port);
        }

        [Fact]
        public void EndpointParsing()
        {
            var connectionStringBuilder =
                new SpannerConnectionStringBuilder(
                    "Data Source=projects/project1/instances/instance1/databases/database1;Host=foo;Port=1234");

            Assert.Equal("foo", connectionStringBuilder.Host);
            Assert.Equal(1234, connectionStringBuilder.Port);
        }

        [Fact]
        public void EndPointSettableViaProperty()
        {
            var connectionStringBuilder = new SpannerConnectionStringBuilder
            {
                Host = "foo",
                Port = 1234
            };
            Assert.Equal("foo", connectionStringBuilder.Host);
            Assert.Equal(1234, connectionStringBuilder.Port);
        }

        [Fact]
        public void InstanceOnlyDataSource()
        {
            var connectionStringBuilder =
                new SpannerConnectionStringBuilder("Data Source=projects/project1/instances/instance1");
            Assert.Equal("project1", connectionStringBuilder.Project);
            Assert.Equal("instance1", connectionStringBuilder.SpannerInstance);
            Assert.Null(connectionStringBuilder.SpannerDatabase);
        }
    }
}
