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

using Google.Apis.Auth.OAuth2;
using Google.Cloud.ClientTesting;
using Grpc.Auth;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerClientCreationOptionsTest
    {
        [Fact]
        public void Equality_CustomHostAndPort()
        {
            string dataSource = "projects/p1/instances/i1/databases/d1";
            var builder = new SpannerConnectionStringBuilder { DataSource = dataSource, Host = "h1", Port = 500  };
            // The data source doesn't matter
            var equalBuilder = new SpannerConnectionStringBuilder($"Data Source=projects/p2/instances/i2/databases/d2;Host = h1; Port = 500");

            var unequalBuilders = new[]
            {
                new SpannerConnectionStringBuilder { DataSource = dataSource, Host = "h1", Port = 600 },
                new SpannerConnectionStringBuilder { DataSource = dataSource, Host = "h2", Port = 500 },
                new SpannerConnectionStringBuilder { DataSource = dataSource, Host = "h1", Port = 500, MaximumGrpcChannels = 5 },
                new SpannerConnectionStringBuilder { DataSource = dataSource, Host = "h1", Port = 500, MaxConcurrentStreamsLowWatermark = 25 },
                new SpannerConnectionStringBuilder { DataSource = dataSource, Host = "h1", Port = 500, CredentialFile = "creds.json" },
                new SpannerConnectionStringBuilder($"Data Source={dataSource}; Host = h1; Port = 500", new ComputeCredential().ToChannelCredentials())
            };

            var options = new SpannerClientCreationOptions(builder);
            var equalOptions = new SpannerClientCreationOptions(equalBuilder);
            var unequalOptions = unequalBuilders.Select(b => new SpannerClientCreationOptions(b)).ToArray();

            EqualityTester.AssertEqual(options, new[] { equalOptions }, unequalOptions);
        }

        [Fact]
        public void Equality_DefaultHostAndPort()
        {
            string dataSource = "projects/p1/instances/i1/databases/d1";
            var builder = new SpannerConnectionStringBuilder { DataSource = dataSource };
            // Timeout doesn't matter
            var equalBuilder = new SpannerConnectionStringBuilder($"Data Source={dataSource}; Timeout=100");

            var unequalBuilders = new[]
            {
                new SpannerConnectionStringBuilder { DataSource = dataSource, CredentialFile = "creds.json" },
                new SpannerConnectionStringBuilder($"Data Source={dataSource}", new ComputeCredential().ToChannelCredentials())
            };

            var options = new SpannerClientCreationOptions(builder);
            var equalOptions = new SpannerClientCreationOptions(equalBuilder);
            var unequalOptions = unequalBuilders.Select(b => new SpannerClientCreationOptions(b)).ToArray();

            EqualityTester.AssertEqual(options, new[] { equalOptions }, unequalOptions);
        }

        [Fact]
        public void Equality_GoogleCredential()
        {
            var credential = GoogleCredential.FromAccessToken("token", accessMethod: null);
            string dataSource = "projects/p1/instances/i1/databases/d1";
            var builder = new SpannerConnectionStringBuilder("", credential) { DataSource = dataSource };
            var equalBuilder = new SpannerConnectionStringBuilder($"Data Source = {dataSource}", credential);

            var unequalBuilders = new[]
            {
                new SpannerConnectionStringBuilder { DataSource = dataSource, CredentialFile = "creds.json" },
                new SpannerConnectionStringBuilder { DataSource = dataSource },
                new SpannerConnectionStringBuilder($"Data Source={dataSource}", GoogleCredential.FromComputeCredential(new ComputeCredential()))
            };

            var options = new SpannerClientCreationOptions(builder);
            var equalOptions = new SpannerClientCreationOptions(equalBuilder);
            var unequalOptions = unequalBuilders.Select(b => new SpannerClientCreationOptions(b)).ToArray();

            EqualityTester.AssertEqual(options, new[] { equalOptions }, unequalOptions);
        }

        // Credential tests moved from the previous SpannerConnectionStringBuilder tests
        [Fact]
        public async Task CredentialFile()
        {
            string appFolder = AppDomain.CurrentDomain.BaseDirectory;
            string jsonFile = Path.Combine(appFolder, "SpannerEF-8dfc036f6000.json");
            Assert.True(File.Exists(jsonFile));
            var builder = new SpannerConnectionStringBuilder($"CredentialFile={jsonFile}");
            var options = new SpannerClientCreationOptions(builder);
            Assert.NotNull(await options.CreateSpannerClientAsync(new Spanner.V1.SpannerSettings()));
        }

        [Fact]
        public async Task CredentialFileRelative()
        {
            var builder = new SpannerConnectionStringBuilder("CredentialFile=SpannerEF-8dfc036f6000.json");
            var options = new SpannerClientCreationOptions(builder);
            Assert.NotNull(await options.CreateSpannerClientAsync(new Spanner.V1.SpannerSettings()));
        }

        [Fact]
        public async Task CredentialFileP12Error()
        {
            var builder = new SpannerConnectionStringBuilder("CredentialFile=SpannerEF-8dfc036f6000.p12");
            var options = new SpannerClientCreationOptions(builder);
            await Assert.ThrowsAsync<FileNotFoundException>(() => options.CreateSpannerClientAsync(new Spanner.V1.SpannerSettings()));
        }

        [Fact]
        public async Task CredentialFileNotFound()
        {
            var builder = new SpannerConnectionStringBuilder("CredentialFile=..\\BadFilePath.json");
            var options = new SpannerClientCreationOptions(builder);
            await Assert.ThrowsAsync<FileNotFoundException>(() => options.CreateSpannerClientAsync(new Spanner.V1.SpannerSettings()));
        }

        [Fact]
        public async Task GetCredentialsAsync_GoogleCredential()
        {
            var credential = GoogleCredential.FromAccessToken("token", accessMethod: null);
            var builder = new SpannerConnectionStringBuilder("", credential);
            var options = new SpannerClientCreationOptions(builder);
            Assert.NotNull(await options.CreateSpannerClientAsync(new Spanner.V1.SpannerSettings()));
        }
    }
}
