// Copyright 2018 Google LLC
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

using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using System;
using System.IO;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerConnectionStringBuilderTests
    {
        [Fact]
        public void EmptyInstance_EmptyConnectionString()
        {
            var builder = new SpannerConnectionStringBuilder();
            Assert.Equal("", builder.ConnectionString);
        }

        [Fact]
        public void EmptyInstance_CanBeCloned()
        {
            var builder = new SpannerConnectionStringBuilder();
            var clone = builder.Clone();
            Assert.Equal("", clone.ConnectionString);
        }

        [Theory]
        [InlineData(null, null, null, null)]
        [InlineData("", null, null, null)]
        [InlineData("projects/x/instances/y", "x", "y", null)]
        [InlineData("projects/x/instances/y/databases/z", "x", "y", "z")]
        public void DataSourceParts_WithDataSource(string dataSource, string expectedProject, string expectedInstance, string expectedDatabase)
        {
            var builder = new SpannerConnectionStringBuilder { DataSource = dataSource };
            Assert.Equal(expectedProject, builder.Project);
            Assert.Equal(expectedInstance, builder.SpannerInstance);
            Assert.Equal(expectedDatabase, builder.SpannerDatabase);
        }

        [Fact]
        public void DataSourceParts_NoDataSource()
        {
            var builder = new SpannerConnectionStringBuilder();
            Assert.Null(builder.Project);
            Assert.Null(builder.SpannerInstance);
            Assert.Null(builder.SpannerDatabase);
        }

        [Fact]
        public void DatabaseName()
        {
            var builder = new SpannerConnectionStringBuilder();
            Assert.Null(builder.DatabaseName);
            builder.DataSource = "projects/x/instances/y/databases/z";
            Assert.Equal(new DatabaseName("x", "y", "z"), builder.DatabaseName);
            builder.DatabaseName = new DatabaseName("a", "b", "c");
            Assert.Equal("projects/a/instances/b/databases/c", builder.DataSource);

            builder.DatabaseName = null;
            Assert.Null(builder.DatabaseName);
            Assert.Equal("", builder.DataSource);
        }

        [Theory]
        [InlineData("Data Source=badjuju/project1/instances/instance1/databases/database1")]
        [InlineData("Data Source=projects/project1/badjuju/instance1/databases/database1")]
        [InlineData("Data Source=projects/project1/instances/instance1/badjuju/database1")]
        public void BadConnectionStringThrows(string connectionString)
        {
            Assert.Throws<ArgumentException>(() => new SpannerConnectionStringBuilder(connectionString));
            Assert.Throws<ArgumentException>(() => new SpannerConnectionStringBuilder { ConnectionString = connectionString });
        }

        [Theory]
        [InlineData("badjuju/project1/instances/instance1/databases/database1")]
        [InlineData("projects/project1/badjuju/instance1/databases/database1")]
        [InlineData("projects/project1/instances/instance1/badjuju/database1")]
        [InlineData("Data Source=projects/project1/instances/instance1/databases/database1")] // Valid for a connection string, but not for a data source
        public void BadDataSourceThrows(string dataSource)
        {
            Assert.Throws<ArgumentException>(() => new SpannerConnectionStringBuilder { DataSource = dataSource });
        }        

        [Fact]
        public void DefaultEndpointIfNotSpecified()
        {
            var builder = new SpannerConnectionStringBuilder();
            Assert.Equal(SpannerClient.DefaultEndpoint.Host, builder.Host);
            Assert.Equal(SpannerClient.DefaultEndpoint.Port, builder.Port);
        }

        [Fact]
        public void EndpointParsing()
        {
            string connectionString = "Data Source=projects/project1/instances/instance1/databases/database1;Host=foo;Port=1234";
            var builder = new SpannerConnectionStringBuilder(connectionString);

            Assert.Equal("foo", builder.Host);
            Assert.Equal(1234, builder.Port);
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
        public void CredentialFile()
        {
            string appFolder;
#if NETCOREAPP1_0
            appFolder = AppContext.BaseDirectory;
#else
            appFolder = AppDomain.CurrentDomain.BaseDirectory;
#endif
            string jsonFile = $"{appFolder}{Path.DirectorySeparatorChar}SpannerEF-8dfc036f6000.json";
            Assert.True(File.Exists(jsonFile));
            using (var connection = new SpannerConnection($"CredentialFile={jsonFile}"))
            {
                Assert.NotNull(connection.GetCredentials());
            }
        }

        [Fact]
        public void CredentialFileRelative()
        {
            using (var connection = new SpannerConnection("CredentialFile=SpannerEF-8dfc036f6000.json"))
            {
                Assert.NotNull(connection.GetCredentials());
            }
        }

        [Fact]
        public void CredentialFileP12Error()
        {
            using (var connection = new SpannerConnection("CredentialFile=SpannerEF-8dfc036f6000.p12"))
            {
                Assert.Throws<InvalidOperationException>(() => connection.GetCredentials());
            }
        }

        [Fact]
        public void CredentialFileNotFound()
        {
            using (var connection = new SpannerConnection("CredentialFile=..\\BadFilePath.json"))
            {
                Assert.Throws<FileNotFoundException>(() => connection.GetCredentials());
            }
        }        

        [Fact]
        public void WithDatabase()
        {
            var builder = new SpannerConnectionStringBuilder("Data Source=projects/project1/instances/instance1");
            Assert.Null(builder.SpannerDatabase);
            builder = builder.WithDatabase("db1");
            Assert.Equal("project1", builder.Project);
            Assert.Equal("instance1", builder.SpannerInstance);
            Assert.Equal("db1", builder.SpannerDatabase);
            builder = builder.WithDatabase("db2");
            Assert.Equal("db2", builder.SpannerDatabase);
            builder = builder.WithDatabase(null);
            Assert.Null(builder.SpannerDatabase);
        }
    }
}
