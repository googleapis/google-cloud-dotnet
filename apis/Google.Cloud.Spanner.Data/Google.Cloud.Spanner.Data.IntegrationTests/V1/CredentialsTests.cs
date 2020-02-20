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
using System.Threading.Tasks;
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
        public void GoodChannel_NoCall()
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
        public void BadChannel_NoCall()
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

        [Fact]
        public void NoChannel_GoodCall()
        {
            var builder = new SpannerClientBuilder
            {
                // Don't add a call credential to the channel credential,
                // just the credential needed to establish the TSL connection.
                ChannelCredentials = new SslCredentials()
            };
            var client = builder.Build();

            // Per call, a call credential is needed.
            var sessions = client.ListSessions(
                new ListSessionsRequest { DatabaseAsDatabaseName = _fixture.DatabaseName },
                CallSettings.FromCallCredentials(_withSpannerAccess.ToCallCredentials()));

            // We really don't care whether we get sessions or not.
            // Just ensure that the call gets to the server.
            Assert.True(sessions.Count() >= 0);
        }

        [Fact]
        public void NoChannel_BadCall()
        {
            var builder = new SpannerClientBuilder
            {
                // Don't add a call credential to the channel credential,
                // just the credential needed to establish the TSL connection.
                ChannelCredentials = new SslCredentials()
            };
            var client = builder.Build();

            // Per call, a call credential is needed.
            var sessions = client.ListSessions(
                new ListSessionsRequest { DatabaseAsDatabaseName = _fixture.DatabaseName },
                CallSettings.FromCallCredentials(_withoutSpannerAccess.ToCallCredentials()));

            // We really don't care whether we get sessions or not.
            // Just ensure that the call gets to the server.
            var exception = Assert.Throws<RpcException>(() => sessions.Count());
            Assert.Equal(StatusCode.PermissionDenied, exception.StatusCode);
        }

        [Fact]
        public void NoChannel_NoCall()
        {
            var builder = new SpannerClientBuilder
            {
                // Don't add a call credential to the channel credential,
                // just the credential needed to establish the TSL connection.
                ChannelCredentials = new SslCredentials()
            };
            var client = builder.Build();

            // Don't add a credential to the call either.
            var sessions = client.ListSessions(
                new ListSessionsRequest { DatabaseAsDatabaseName = _fixture.DatabaseName });

            // We really don't care whether we get sessions or not.
            // Just ensure that the call gets to the server.
            var exception = Assert.Throws<RpcException>(() => sessions.Count());
            Assert.Equal(StatusCode.Unauthenticated, exception.StatusCode);
        }

        #endregion

        #region Tests that test for credential clashing

        [Fact]
        public void GoodChannel_BadCall_ListOperation()
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
        public void BadChannel_GoodCall_ListOperation()
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
        public void GoodChannel_BadCall_CreateOperation()
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
        public void BadChannel_GoodCall_CreateOperation()
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

        #region Possible workarounds (exploration)

        [Fact]
        public void BadChannel_GoodCall_TweakedInterceptors()
        {
            // We don't know in what order the credential interceptors are executed.
            // If the order is call -> channel, we want the channel credential to only
            // add itself if there's no call credential.
            // If the order is channel -> call, we want the call credential to remove
            // any existing credential, if any.

            // Let's tweak the channel credential interceptor so that it only adds itself
            // if there's no other credential (call credential) set.
            var channelCredentialsInterceptor = GoogleAuthInterceptors.FromCredential(_withoutSpannerAccess);
            var tweakedChannelCredentials = CallCredentials.FromInterceptor(new AsyncAuthInterceptor((context, metadata) =>
            {
                var existingCredential = metadata.FirstOrDefault(entrie => entrie.Key.Equals("authorization", StringComparison.OrdinalIgnoreCase));
                // The problem is that the metadata received is always empty.
                // I suppose that the changes made here will be merged with the "real" metadata.
                if (existingCredential != null)
                {
                    return Task.FromResult(true);
                }
                return channelCredentialsInterceptor(context, metadata);
            }));
            var builder = new SpannerClientBuilder
            {
                ChannelCredentials = ChannelCredentials.Create(new SslCredentials(), tweakedChannelCredentials)
            };
            var client = builder.Build();

            // Let's tweak the call credential interceptor so that it removes any other credential befor adding itself.
            var callCredentialsInterceptor = GoogleAuthInterceptors.FromCredential(_withSpannerAccess);
            var tweakedCallCredentials = CallCredentials.FromInterceptor(new AsyncAuthInterceptor((context, metadata) =>
            {
                var existingCredential = metadata.FirstOrDefault(entrie => entrie.Key.Equals("authorization", StringComparison.OrdinalIgnoreCase));
                // The problem is that the metadata received is always empty.
                // I suppose that the changes made here will be merged with the "real" metadata.
                if (existingCredential != null)
                {
                    metadata.Remove(existingCredential);
                }
                return callCredentialsInterceptor(context, metadata);
            }));

            var sessions = client.ListSessions(
                new ListSessionsRequest { DatabaseAsDatabaseName = _fixture.DatabaseName },
                CallSettings.FromCallCredentials(tweakedCallCredentials));

            // This should pass after the tweaking, because we "quarantee" that the
            // call credential is the only one set... except tweaking does not work
            // because we don't have access to the "real" metadata.
            // So the test fails throwing a PermissionDenied RpcException.
            Assert.True(sessions.Count() >= 0);
        }

        #endregion
    }
}
