// Copyright 2020 Google LLC
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

using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.Data.IntegrationTests;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.Spanner.V1.IntegrationTests
{
    [Collection(nameof(SpannerDatabaseFixture))]
    public class CredentialsTests
    {
        private const string NoSpannerAccessCredPathEnvVar = "GOOGLE_NO_SPANNER";

        private readonly SpannerDatabaseFixture _fixture;
        private readonly GoogleCredential _withSpannerAccess;
        private readonly GoogleCredential _withoutSpannerAccess;

        public CredentialsTests(SpannerDatabaseFixture fixture)
        {
            _fixture = fixture;
            _withSpannerAccess = GoogleCredential.GetApplicationDefault();
            _withoutSpannerAccess = GoogleCredential.FromFile(Environment.GetEnvironmentVariable(NoSpannerAccessCredPathEnvVar));
        }

        #region Sanity check tests, just to make sure that the credentials are as described.

        [Fact]
        public void WithSpannerAccess()
        {
            var builder = new SpannerClientBuilder
            {
                ChannelCredentials = _withSpannerAccess.ToChannelCredentials()
            };
            var client = builder.Build();

            var sessions = client.ListSessions(new ListSessionsRequest { DatabaseAsDatabaseName = _fixture.DatabaseName });

            // We really don't care whether we get sessions or not.
            // Just ensure that the call gets to the server.
            Assert.True(sessions.Count() >= 0);
        }

        [Fact]
        public void WithouSpannerAccess()
        {
            var builder = new SpannerClientBuilder
            {
                ChannelCredentials = _withoutSpannerAccess.ToChannelCredentials()
            };
            var client = builder.Build();

            var sessions = client.ListSessions(new ListSessionsRequest { DatabaseAsDatabaseName = _fixture.DatabaseName });

            // We really don't care whether we get sessions or not.
            // Just ensure that the call gets to the server.
            var exception = Assert.Throws<RpcException>(() => sessions.Count());
            Assert.Equal(StatusCode.PermissionDenied, exception.StatusCode);
        }

        #endregion

        #region Tests that test for credential clashing

        [Fact]
        public void GoodChannelCred_BadCallCred_ListOperation()
        {
            var builder = new SpannerClientBuilder
            {
                ChannelCredentials = _withSpannerAccess.ToChannelCredentials()
            };
            var client = builder.Build();

            var sessions = client.ListSessions(
                new ListSessionsRequest { DatabaseAsDatabaseName = _fixture.DatabaseName },
                CallSettings.FromCallCredentials(_withoutSpannerAccess.ToCallCredentials()));

            // This should pass since the call credentials should take precedence over
            // the channel credentials.
            // But the test fails because this doesn't throw, which means the channel
            // credential is being used.
            var exception = Assert.Throws<RpcException>(() => sessions.Count());
            Assert.Equal(StatusCode.PermissionDenied, exception.StatusCode);
        }

        [Fact]
        public void BadChannelCred_GoodCallCred_ListOperation()
        {
            var builder = new SpannerClientBuilder
            {
                ChannelCredentials = _withoutSpannerAccess.ToChannelCredentials()
            };
            var client = builder.Build();

            var sessions = client.ListSessions(
                new ListSessionsRequest { DatabaseAsDatabaseName = _fixture.DatabaseName },
                CallSettings.FromCallCredentials(_withSpannerAccess.ToCallCredentials()));

            // This should pass since the call credentials should take precedence over
            // the channel credentials.
            // But the test fails throwing a PermissionDenied RpcException, which means the
            // channel credentials are being used.
            Assert.True(sessions.Count() >= 0);
        }

        [Fact]
        public void GoodChannelCred_BadCallCred_CreateOperation()
        {
            var builder = new SpannerClientBuilder
            {
                ChannelCredentials = _withSpannerAccess.ToChannelCredentials()
            };
            var client = builder.Build();

            // This should pass since the call credentials should take precedence over
            // the channel credentials.
            // But the test fails because this doesn't throw, which means the channel
            // credential is being used.
            var exception = Assert.Throws<RpcException>(() => client.CreateSession(
                new CreateSessionRequest
                { 
                    DatabaseAsDatabaseName = _fixture.DatabaseName,
                    Session = new Session { }
                },
                CallSettings.FromCallCredentials(_withoutSpannerAccess.ToCallCredentials())));
            Assert.Equal(StatusCode.PermissionDenied, exception.StatusCode);
        }

        [Fact]
        public void BadChannelCred_GoodCallCred_CreateOperation()
        {
            var builder = new SpannerClientBuilder
            {
                ChannelCredentials = _withoutSpannerAccess.ToChannelCredentials()
            };
            var client = builder.Build();

            var session = client.CreateSession(
                new CreateSessionRequest
                {
                    DatabaseAsDatabaseName = _fixture.DatabaseName,
                    Session = new Session { }
                },
                CallSettings.FromCallCredentials(_withSpannerAccess.ToCallCredentials()));

            // This should pass since the call credentials should take precedence over
            // the channel credentials.
            // But the test fails throwing a PermissionDenied RpcException, which means the
            // channel credentials are being used.
            Assert.NotNull(session);

            // Just deleting the created session.
            client.DeleteSession(
                new DeleteSessionRequest { SessionName = session.SessionName },
                CallSettings.FromCallCredentials(_withSpannerAccess.ToCallCredentials()));
        }

        #endregion
    }
}
