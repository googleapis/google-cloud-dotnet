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
using Google.Apis.Auth.OAuth2;
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
        public void LeaderRoutingEnabledByDefault() =>
            Assert.True(new SpannerConnectionStringBuilder().EnableLeaderRouting);

        [Fact]
        public void EnableLeaderRouting()
        {
            var connectionStringBuilder = new SpannerConnectionStringBuilder("EnableLeaderRouting=false");
            Assert.False(connectionStringBuilder.EnableLeaderRouting);
            connectionStringBuilder.EnableLeaderRouting = true;
            Assert.True(connectionStringBuilder.EnableLeaderRouting);
            // DbConnectionStringBuilder lower-cases keywords, annoyingly.
            Assert.Equal("enableleaderrouting=True", connectionStringBuilder.ToString());
        }

        [Fact]
        public void DirectedReadOptionsNullByDefault() =>
            Assert.Null(new SpannerConnectionStringBuilder().DirectedReadOptions);

        [Fact]
        public void Clone_WithDirectedReadOptions()
        {
            var connectionStringBuilder = new SpannerConnectionStringBuilder();
            connectionStringBuilder.DirectedReadOptions = DirectedReadTests.IncludeDirectedReadOptions;

            var cloned = connectionStringBuilder.Clone();
            Assert.NotSame(connectionStringBuilder.DirectedReadOptions, cloned.DirectedReadOptions);
            Assert.Equal(connectionStringBuilder.DirectedReadOptions, cloned.DirectedReadOptions);
            Assert.Equal(DirectedReadTests.IncludeDirectedReadOptions, cloned.DirectedReadOptions);
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

        [Fact]
        public void ClrToSpannerTypeDefaultMappings()
        {
            // Defaults - When property is not set.
            var builder = new SpannerConnectionStringBuilder();
            Assert.True(string.IsNullOrEmpty(builder.ClrToSpannerTypeDefaultMappings));

            // Explicitly set valid type mapping.
            builder = new SpannerConnectionStringBuilder("ClrToSpannerTypeDefaultMappings=DecimalToNumeric,DateTimeToDate");
            // DbConnectionStringBuilder lower-cases keywords, annoyingly.
            Assert.Equal("clrtospannertypedefaultmappings=DecimalToNumeric,DateTimeToDate", builder.ToString());

            // Explicitly set valid type mappings. Latest should be reflected.
            // Also check that strings  are case insensitive.
            builder.ClrToSpannerTypeDefaultMappings = "decimalTofloat64,dateTimetotimestamp";
            // DbConnectionStringBuilder lower-cases keywords, annoyingly.
            Assert.Equal("clrtospannertypedefaultmappings=decimalTofloat64,dateTimetotimestamp", builder.ToString());
        }

        [Fact]
        public void SpannerToClrTypeDefaultMappings()
        {
            // Defaults - When property is not set.
            var builder = new SpannerConnectionStringBuilder();
            Assert.True(string.IsNullOrEmpty(builder.SpannerToClrTypeDefaultMappings));

            // Explicitly set valid type mappings.
            builder = new SpannerConnectionStringBuilder("SpannerToClrTypeDefaultMappings=DateToDateTime");
            // DbConnectionStringBuilder lower-cases keywords, annoyingly.
            Assert.Equal("spannertoclrtypedefaultmappings=DateToDateTime", builder.ToString());

            // Explicitly set valid type mappings. Latest should be reflected.
            // Also check that strings  are case insensitive.
            builder.SpannerToClrTypeDefaultMappings = "dateTospannerDate";
            // DbConnectionStringBuilder lower-cases keywords, annoyingly.
            Assert.Equal("spannertoclrtypedefaultmappings=dateTospannerDate", builder.ToString());
        }

        [Theory]
        [InlineData("DecimalToFloat64,DecimalToNumeric,DateTimeToDate")] // Multiple mappings for a type.
        [InlineData("DecimalToFloat64,DecimalToPgNumeric,DateTimeToDate,DateTimeToTimestamp")] // Multiple mappings for a type.
        [InlineData("DecimalToFloat64   ,DecimalToNumeric,DateTimeToDate")] // Multiple mappings and whitespace.
        [InlineData("DecimalToFloat64   ,  DateTimeToDate")] // Valid mapping with whitespace.
        [InlineData("UseFloat64ForDecimal,DecimalToNumeric,DateTimeToDate")] // Invalid values.
        public void BadClrToSpannerTypeDefaultMappingsThrows(string clrToSpannerTypeMappings)
        {
            Assert.Throws<ArgumentException>(() => new SpannerConnectionStringBuilder($"ClrToSpannerTypeDefaultMappings={clrToSpannerTypeMappings}"));
            Assert.Throws<ArgumentException>(() => new SpannerConnectionStringBuilder { ClrToSpannerTypeDefaultMappings = clrToSpannerTypeMappings });
        }

        [Theory]
        [InlineData("DateToDateTime,DateToSpannerDate")] // Multiple mappings for a type.
        [InlineData("  DateToDateTime  ,")] // Whitespace.
        [InlineData("UseDateToSpannerDate")] // Invalid value.
        public void BadSpannerToClrTypeDefaultMappingsThrows(string spannerToClrTypeMappings)
        {
            Assert.Throws<ArgumentException>(() => new SpannerConnectionStringBuilder($"SpannerToClrTypeDefaultMappings={spannerToClrTypeMappings}"));
            Assert.Throws<ArgumentException>(() => new SpannerConnectionStringBuilder { SpannerToClrTypeDefaultMappings = spannerToClrTypeMappings });
        }

        [Fact]
        public void CloneWithConversionOptions()
        {
            var builder = new SpannerConnectionStringBuilder("SpannerToClrTypeDefaultMappings=DateToSpannerDate;ClrToSpannerTypeDefaultMappings=DecimalToNumeric");
            var clone = builder.Clone();
            // We effectively want to assert that builder.ConversionOptions is equal to clone.ConversionOptions, but
            // we don't have an equality comparison available... just test a couple of properties.
            Assert.Equal(builder.ConversionOptions.DecimalToConfiguredSpannerType, clone.ConversionOptions.DecimalToConfiguredSpannerType);
            Assert.Equal(builder.ConversionOptions.DateToConfiguredClrType, clone.ConversionOptions.DateToConfiguredClrType);
        }

        [Fact]
        public void SettingConnectionStringResetsConversionOptions()
        {
            var builder = new SpannerConnectionStringBuilder();
            builder.ConnectionString = "SpannerToClrTypeDefaultMappings=DateToSpannerDate";
            builder.ConnectionString = "";
            Assert.Equal(SpannerConversionOptions.Default.DateToConfiguredClrType, builder.ConversionOptions.DateToConfiguredClrType);
        }

        [Fact]
        public void Clone_MaintainsGoogleCredential()
        {
            var credential = GoogleCredential.FromAccessToken("token", accessMethod: null);
            var builder = new SpannerConnectionStringBuilder("", credential);
            var clone = builder.Clone();
            Assert.Same(credential, clone.GoogleCredential);
        }

        [Fact]
        public void UniverseDomainTest()
        {
            string universeDomain = "test-domain.test.goog";
            var builder = new SpannerConnectionStringBuilder($"UniverseDomain={universeDomain}");

            Assert.Equal(universeDomain, builder.UniverseDomain);
            Assert.Equal(SpannerConnectionStringBuilder.DefaultHost, builder.Host);
            Assert.Equal($"{SpannerConnectionStringBuilder.DefaultHost}:{SpannerConnectionStringBuilder.DefaultPort}",builder.EndPoint);

            string host = "h1";
            string port = "567";
            builder = new SpannerConnectionStringBuilder($"Host={host};Port={port};UniverseDomain={universeDomain}");

            Assert.Equal(host,builder.Host);
            Assert.Equal($"{host}:{port}",builder.EndPoint);
        }
    }
}
