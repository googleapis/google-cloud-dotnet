// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.PubSub.V1;
using Grpc.Core;
using System;
using System.Threading;
using Xunit;

namespace Google.Cloud.Tools.Snippets
{
    [Collection(nameof(SnippetFixture))]
    public class CallSettingsSnippets
    {
        private readonly SnippetFixture _fixture;

        public CallSettingsSnippets(SnippetFixture fixture)
        {
            _fixture = fixture;
        }
        
        [Fact]
        public void PerRpc()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();

            // Sample: PerRpc
            // Create a PublisherServiceApiClient with default settings.
            PublisherServiceApiClient client = PublisherServiceApiClient.Create();
            // Create a topic name from the projectId and topicId.
            TopicName topicName = new TopicName(projectId, topicId);
            // Create a CallSettings with a custom header.
            CallSettings callSettings = CallSettings.FromHeader("ClientVersion", "1.0.0");
            // This will cause the custom 'ClientVersion' header to be included in the RPC call.
            Topic topic = client.CreateTopic(topicName, callSettings);
            // End sample
        }

        [Fact]
        public void Client()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();

            // Sample: ClientWide
            // Create a default PublisherServiceApiSettings, with a custom header for calls to all RPC methods.
            PublisherServiceApiSettings publisherSettings = new PublisherServiceApiSettings
            {
                CallSettings = CallSettings.FromHeader("ClientVersion", "1.0.0")
            };
            PublisherServiceApiClient client = new PublisherServiceApiClientBuilder { Settings = publisherSettings }.Build();
            // Create a topic name from the projectId and topicId.
            TopicName topicName = new TopicName(projectId, topicId);
            // The custom 'ClientVersion' header will be included in the RPC call, due to
            // the client being configured with 'publishersettings' above.
            Topic topic = client.CreateTopic(topicName);
            // End sample
        }

        [Fact]
        public void ClientPerMethod()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();

            // Sample: ClientPerMethod
            // Create a default PublisherServiceApiSettings, with a custom header for calls
            // to the CreateTopic RPC method.
            PublisherServiceApiSettings publisherSettings = new PublisherServiceApiSettings();
            publisherSettings.CreateTopicSettings = publisherSettings.CreateTopicSettings.WithHeader("ClientVersion", "1.0.0");
            PublisherServiceApiClient client = new PublisherServiceApiClientBuilder { Settings = publisherSettings }.Build();
            // Create a topic name from the projectId and topicId.
            TopicName topicName = new TopicName(projectId, topicId);
            // The custom 'ClientVersion' header will be included in the RPC call, due to
            // the client being configured with 'publishersettings' above.
            Topic topic = client.CreateTopic(topicName);
            // End sample
        }

        [Fact]
        public void Overrides()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();
            DateTime deadline = DateTime.MaxValue;
            CancellationToken cancellationToken = new CancellationTokenSource().Token;

            // Sample: Overrides
            // Create a default PublisherServiceApiSettings, with customizations for CreateTopic RPCs:
            // * A custom "ClientVersion" header.
            // * A custom 15-second timeout.
            // * No cancellation token.
            PublisherServiceApiSettings publisherSettings = new PublisherServiceApiSettings();
            publisherSettings.CreateTopicSettings = publisherSettings.CreateTopicSettings
                .WithCancellationToken(CancellationToken.None)
                .WithTimeout(TimeSpan.FromSeconds(15))
                .WithHeader("ClientVersion", "1.0.0");

            // Override the above Timing and CancellationToken in the client-wide CallSettings;
            // the Headers are not overridden.
            publisherSettings.CallSettings = CallSettings
                .FromExpiration(Expiration.FromDeadline(deadline))
                .WithCancellationToken(CancellationToken.None);

            // Create the client with the configured publisherSettings
            PublisherServiceApiClient client = new PublisherServiceApiClientBuilder { Settings = publisherSettings }.Build();

            // Create a topic name from the projectId and topicId.
            TopicName topicName = new TopicName(projectId, topicId);

            // Call CreateTopic(). Override only the CancellationToken, using a per-RPC-method CallSettings.
            // The CallSettings used during this RPC invocation is:
            // * A custom "ClientVersion" header.
            // * A Timing deadline of 'deadline' (*not* the overridden 5-second timeout).
            // * The CancellationToken 'cancellationToken' (*not* CancellationToken.None).
            Topic topic = client.CreateTopic(topicName, CallSettings.FromCancellationToken(cancellationToken));
            // End sample
        }

        [Fact]
        public void RetrySettingsTiming()
        {
            // Sample: RetrySettingsTiming
            // Each delay is double the previous one, with a maximum of 5s.
            // The first delay is 1s, then 2s, then 4s, then 5s, then 5s, etc.
            // Only aborted RPCs are retried in this example.
            RetrySettings settings = RetrySettings.FromExponentialBackoff(
                maxAttempts: 10,
                initialBackoff: TimeSpan.FromSeconds(1),
                maxBackoff: TimeSpan.FromSeconds(5),
                backoffMultiplier: 2.0,
                retryFilter: RetrySettings.FilterForStatusCodes(StatusCode.Aborted));
            // End sample
        }
    }
}
