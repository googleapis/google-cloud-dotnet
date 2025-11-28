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
using Google.Apis.Http;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Grpc.Core;
using Grpc.Auth;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public partial class SpannerConnectionTests
    {
        [Fact]
        public void OpenWithNoDatabase_InvalidCredentials()
        {
            var builder = new SpannerConnectionStringBuilder
            {
                DataSource = "projects/project_id/instances/instance_id",
                CredentialFile = "this_will_not_exist.json"
            };
            using (var connection = new SpannerConnection(builder))
            {
                Assert.Throws<FileNotFoundException>(() => connection.Open());
            }
        }

        [Fact]
        public void ConnectionString_SetterMaintainsChannelCredentialsAndSessionPoolManager()
        {
            var channelCredentials = new FakeCredential().ToChannelCredentials();
            var sessionPoolManager = new SessionPoolManager(new SessionPoolOptions(), SpannerSettings.GetDefault(), Logger.DefaultLogger, (o, s) => throw new InvalidOperationException());

            var builder = new SpannerConnectionStringBuilder("Data Source=projects/project_id/instances/instance_id; ClrToSpannerTypeDefaultMappings=DecimalToNumeric", channelCredentials)
            {
                SessionPoolManager = sessionPoolManager
            };
            using var connection = new SpannerConnection(builder);
            connection.ConnectionString = "Data Source=projects/project_id2/instances/instance_id2; ClrToSpannerTypeDefaultMappings=DecimalToPgNumeric";

            // Original builder hasn't changed
            Assert.Equal("projects/project_id/instances/instance_id", builder.DataSource);
            Assert.Equal(SpannerDbType.Numeric, builder.ConversionOptions.DecimalToConfiguredSpannerType);

            // Connection observes new values
            Assert.Equal("projects/project_id2/instances/instance_id2", connection.DataSource);
            Assert.Equal(SpannerDbType.PgNumeric, connection.Builder.ConversionOptions.DecimalToConfiguredSpannerType);

            Assert.Same(channelCredentials, connection.Builder.CredentialOverride);
            Assert.Same(sessionPoolManager, connection.Builder.SessionPoolManager);
        }

        [Fact]
        public void Constructor_GoogleCredential()
        {
            var credential = GoogleCredential.FromAccessToken("token", accessMethod: null);
            var connection = new SpannerConnection("Data Source=projects/project_id/instances/instance_id", credential);
            Assert.Same(credential, connection.Builder.GoogleCredential);
        }

        private class FakeCredential : ITokenAccess
        {
            public Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default) =>
                throw new NotImplementedException();
        }
    }
}
