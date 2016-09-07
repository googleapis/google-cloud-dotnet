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
using Google.Pubsub.V1;
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
            // Format topicName from the projectId and topicId.
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);
            // Create a CallSettings with a custom header.
            CallSettings callSettings = new CallSettings
            {
                Headers = new Metadata
                {
                    { "ClientVersion", "1.0.0" }
                }
            };
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
                CallSettings = new CallSettings
                {
                    Headers = new Metadata
                    {
                        { "ClientVersion", "1.0.0" }
                    },
                }
            };
            PublisherClient client = PublisherClient.Create(settings: publisherSettings);
            // Format topicName from the projectId and topicId.
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);
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
            publisherSettings.CreateTopicSettings.Headers = new Metadata
            {
                { "ClientVersion", "1.0.0" }
            };
            PublisherClient client = PublisherClient.Create(settings: publisherSettings);
            // Format topicName from the projectId and topicId.
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);
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
            publisherSettings.CreateTopicSettings.Headers = new Metadata
            {
                { "ClientVersion", "1.0.0" }
            };
            publisherSettings.CreateTopicSettings.Timing = CallTiming.FromTimeout(TimeSpan.FromSeconds(5));
            publisherSettings.CreateTopicSettings.CancellationToken = CancellationToken.None;

            // Override the above Timing and CancellationToken in the client-wide CallSettings;
            // the Headers are not overridden.
            publisherSettings.CallSettings = new CallSettings
            {
                Timing = CallTiming.FromDeadline(deadline),
                CancellationToken = CancellationToken.None,
            };

            // Create the client with the configured publisherSettings
            PublisherClient client = PublisherClient.Create(settings: publisherSettings);

            // Format topicName from the projectId and topicId.
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);

            // Call CreateTopic(). Override only the CancellationToken, using a per-RPC-method CallSettings.
            // The CallSettings used during this RPC invocation is:
            // * A custom "ClientVersion" header.
            // * A Timing deadline of 'deadline' (*not* the overridden 5-second timeout).
            // * The CancellationToken 'cancellationToken' (*not* CancellationToken.None).
            Topic topic = client.CreateTopic(topicName, new CallSettings
            {
                CancellationToken = cancellationToken
            });
            // End sample
        }
    }
}
