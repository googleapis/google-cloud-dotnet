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

using Google.Api.Gax;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using System;
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
            var bits = SpannerClient.DefaultEndpoint.Split(':');
            Assert.Equal(bits[0], builder.Host);
            Assert.Equal(int.Parse(bits[1]), builder.Port);
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
            Assert.Throws<ArgumentOutOfRangeException>(() => connectionStringBuilder.Port = 0);
        }

        [Fact]
        public void AllowImmediateTimeouts()
        {
            var connectionStringBuilder = new SpannerConnectionStringBuilder("AllowImmediateTimeouts=true");
            Assert.True(connectionStringBuilder.AllowImmediateTimeouts);
            connectionStringBuilder.AllowImmediateTimeouts = false;
            Assert.False(connectionStringBuilder.AllowImmediateTimeouts);
            // DbConnectionStringBuilder lower-cases keywords, annoyingly.
            Assert.Equal("allowimmediatetimeouts=False", connectionStringBuilder.ToString());
        }

        [Fact]
        public void MaximumGrpcChannels()
        {
            var connectionStringBuilder = new SpannerConnectionStringBuilder("MaximumGrpcChannels=5");
            Assert.Equal(5, connectionStringBuilder.MaximumGrpcChannels);
            connectionStringBuilder.MaximumGrpcChannels = 10;
            Assert.Equal(10, connectionStringBuilder.MaximumGrpcChannels);
            // DbConnectionStringBuilder lower-cases keywords, annoyingly.
            Assert.Equal("maximumgrpcchannels=10", connectionStringBuilder.ToString());
            Assert.Throws<ArgumentOutOfRangeException>(() => connectionStringBuilder.MaximumGrpcChannels = 0);
        }

        [Fact]
        public void MaxConcurrentStreamsLowWatermark()
        {
            var connectionStringBuilder = new SpannerConnectionStringBuilder("MaxConcurrentStreamsLowWatermark=100");
            Assert.Equal(100, connectionStringBuilder.MaxConcurrentStreamsLowWatermark);
            connectionStringBuilder.MaxConcurrentStreamsLowWatermark = 10;
            Assert.Equal(10, connectionStringBuilder.MaxConcurrentStreamsLowWatermark);
            // DbConnectionStringBuilder lower-cases keywords, annoyingly.
            Assert.Equal("maxconcurrentstreamslowwatermark=10", connectionStringBuilder.ToString());
            Assert.Throws<ArgumentOutOfRangeException>(() => connectionStringBuilder.MaxConcurrentStreamsLowWatermark = 0);
        }

        [Fact]
        public void Timeout()
        {
            var connectionStringBuilder = new SpannerConnectionStringBuilder("timeout=100");
            Assert.Equal(100, connectionStringBuilder.Timeout);
            connectionStringBuilder.Timeout = 10;
            Assert.Equal(10, connectionStringBuilder.Timeout);
            // DbConnectionStringBuilder lower-cases keywords, annoyingly.
            Assert.Equal("timeout=10", connectionStringBuilder.ToString());
            Assert.Throws<ArgumentOutOfRangeException>(() => connectionStringBuilder.Timeout = -1);
        }

        [Fact]
        public void LogCommitStats()
        {
            var connectionStringBuilder = new SpannerConnectionStringBuilder("LogCommitStats=true");
            Assert.True(connectionStringBuilder.LogCommitStats);
            connectionStringBuilder.LogCommitStats = false;
            Assert.False(connectionStringBuilder.LogCommitStats);
            // DbConnectionStringBuilder lower-cases keywords, annoyingly.
            Assert.Equal("logcommitstats=False", connectionStringBuilder.ToString());
            connectionStringBuilder = new SpannerConnectionStringBuilder("");
            Assert.False(connectionStringBuilder.LogCommitStats);
        }

        [Fact]
        public void UseSpannerNumericForDecimal()
        {
            var connectionStringBuilder = new SpannerConnectionStringBuilder("UseSpannerNumericForDecimal=true");
            Assert.True(connectionStringBuilder.UseSpannerNumericForDecimal);
            connectionStringBuilder.UseSpannerNumericForDecimal = false;
            Assert.False(connectionStringBuilder.UseSpannerNumericForDecimal);
            // DbConnectionStringBuilder lower-cases keywords, annoyingly.
            Assert.Equal("usespannernumericfordecimal=False", connectionStringBuilder.ToString());
            connectionStringBuilder = new SpannerConnectionStringBuilder("");
            Assert.False(connectionStringBuilder.UseSpannerNumericForDecimal);
        }

        [Fact]
        public void UsePgNumericForDecimal()
        {
            var connectionStringBuilder = new SpannerConnectionStringBuilder("UsePgNumericForDecimal=true");
            Assert.True(connectionStringBuilder.UsePgNumericForDecimal);
            connectionStringBuilder.UsePgNumericForDecimal = false;
            Assert.False(connectionStringBuilder.UsePgNumericForDecimal);
            // DbConnectionStringBuilder lower-cases keywords, annoyingly.
            Assert.Equal("usepgnumericfordecimal=False", connectionStringBuilder.ToString());
            connectionStringBuilder = new SpannerConnectionStringBuilder("");
            Assert.False(connectionStringBuilder.UsePgNumericForDecimal);
        }

        [Fact]
        public void EmulatorDetectionProperty()
        {
            var connectionStringBuilder = new SpannerConnectionStringBuilder("EmulatorDetection=EmulatorOnly");
            Assert.Equal(EmulatorDetection.EmulatorOnly, connectionStringBuilder.EmulatorDetection);
            connectionStringBuilder.EmulatorDetection = EmulatorDetection.ProductionOnly;
            Assert.Equal(EmulatorDetection.ProductionOnly, connectionStringBuilder.EmulatorDetection);
            // DbConnectionStringBuilder lower-cases keywords, annoyingly.
            Assert.Equal("emulatordetection=ProductionOnly", connectionStringBuilder.ToString());
            // Ignores invalid values set in the connection string.
            var invalidConnectionStringBuilder = new SpannerConnectionStringBuilder("EmulatorDetection=Prod");
            Assert.Equal(EmulatorDetection.None, invalidConnectionStringBuilder.EmulatorDetection);
            Assert.Throws<ArgumentException>(() => connectionStringBuilder.EmulatorDetection = (EmulatorDetection)(-1));
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
