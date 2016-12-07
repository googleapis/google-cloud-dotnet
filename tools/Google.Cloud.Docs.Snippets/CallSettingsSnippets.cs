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
            // Create a PublisherClient with default settings.
            PublisherClient client = PublisherClient.Create();
            // Create a topic name from the projectId and topicId.
            TopicName topicName = new TopicName(projectId, topicId);
            // Create a CallSettings with a custom header.
            CallSettings callSettings = new CallSettings(null, null, null, metadata => metadata.Add("ClientVersion", "1.0.0"), null, null);
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
            // Create a default PublisherSettings, with a custom header for calls to all RPC methods.
            PublisherSettings publisherSettings = new PublisherSettings
            {
                CallSettings = new CallSettings(null, null, null, metadata => metadata.Add("ClientVersion", "1.0.0"), null, null)
            };
            PublisherClient client = PublisherClient.Create(settings: publisherSettings);
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
            // Create a default PublisherSettings, with a custom header for calls
            // to the CreateTopic RPC method.
            PublisherSettings publisherSettings = new PublisherSettings();
            publisherSettings.CreateTopicSettings = publisherSettings.CreateTopicSettings.WithHeader("ClientVersion", "1.0.0");
            PublisherClient client = PublisherClient.Create(settings: publisherSettings);
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
            // Create a default PublisherSettings, with customizations for CreateTopic RPCs:
            // * A custom "ClientVersion" header.
            // * A custom 5-second timeout Timing.
            // * No cancellation token.
            PublisherSettings publisherSettings = new PublisherSettings();
            publisherSettings.CreateTopicSettings = publisherSettings.CreateTopicSettings
                .WithCancellationToken(CancellationToken.None)
                .WithCallTiming(CallTiming.FromTimeout(TimeSpan.FromSeconds(5)))
                .WithHeader("ClientVersion", "1.0.0");

            // Override the above Timing and CancellationToken in the client-wide CallSettings;
            // the Headers are not overridden.
            publisherSettings.CallSettings = CallSettings
                .FromCallTiming(CallTiming.FromDeadline(deadline))
                .WithCancellationToken(CancellationToken.None);

            // Create the client with the configured publisherSettings
            PublisherClient client = PublisherClient.Create(settings: publisherSettings);

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
            // The overall operation mustn't take more than 30 seconds.
            Expiration totalExpiration = Expiration.FromTimeout(TimeSpan.FromSeconds(30));

            // The delay between one RPC finishing and when we make the next one.
            // Each delay is double the previous one, with a maximum of 5s.
            // The first delay is 1s, then 2s, then 4s, then 5s, then 5s, etc.
            BackoffSettings retryBackoff = new BackoffSettings(
                delay: TimeSpan.FromSeconds(1),
                maxDelay: TimeSpan.FromSeconds(5),
                delayMultiplier: 2.0);

            // How long each individual RPC is allowed to take.
            // Each timeout is 1.5x the previous one, with a maximum of 10s.
            // The first timeout is 4s, then 6s, then 9s, then 10s, then 10s etc.
            BackoffSettings timeoutBackoff = new BackoffSettings(
                delay: TimeSpan.FromSeconds(4),
                maxDelay: TimeSpan.FromSeconds(10),
                delayMultiplier: 1.5);

            RetrySettings settings = new RetrySettings(retryBackoff, timeoutBackoff, totalExpiration);
            // End sample
        }
    }
}
