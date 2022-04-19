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

using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using Google.Cloud.Iam.V1;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.PubSub.V1.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(PubsubSnippetFixture))]
    public class PublisherServiceApiClientSnippets
    {
        private readonly PubsubSnippetFixture _fixture;

        public PublisherServiceApiClientSnippets(PubsubSnippetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void ListTopics()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListTopics(ProjectName,*,*,*)
            PublisherServiceApiClient client = PublisherServiceApiClient.Create();

            ProjectName projectName = new ProjectName(projectId);
            foreach (Topic topic in client.ListTopics(projectName))
            {
                Console.WriteLine(topic.Name);
            }
            // End snippet
        }

        [Fact]
        public async Task ListTopicsAsync()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListTopicsAsync(ProjectName,*,*,*)
            PublisherServiceApiClient client = PublisherServiceApiClient.Create();

            ProjectName projectName = new ProjectName(projectId);
            IAsyncEnumerable<Topic> topics = client.ListTopicsAsync(projectName);
            await topics.ForEachAsync(topic =>
            {
                Console.WriteLine(topic.Name);
            });
            // End snippet
        }

        [Fact]
        public void CreateTopic()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();

            // Snippet: CreateTopic(TopicName,*)
            PublisherServiceApiClient client = PublisherServiceApiClient.Create();

            TopicName topicName = new TopicName(projectId, topicId);
            Topic topic = client.CreateTopic(topicName);
            Console.WriteLine($"Created {topic.Name}");
            // End snippet
        }

        [Fact]
        public async Task CreateTopicAsync()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();

            // Snippet: CreateTopicAsync(TopicName,CallSettings)
            // Additional: CreateTopicAsync(TopicName,CancellationToken)
            PublisherServiceApiClient client = PublisherServiceApiClient.Create();

            TopicName topicName = new TopicName(projectId, topicId);
            Topic topic = await client.CreateTopicAsync(topicName);
            Console.WriteLine($"Created {topic.Name}");
            // End snippet
        }

        [Fact]
        public void Publish()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();

            // Snippet: Publish(TopicName,*,*)
            PublisherServiceApiClient client = PublisherServiceApiClient.Create();
            // Make sure we have a topic to publish to
            TopicName topicName = new TopicName(projectId, topicId);
            client.CreateTopic(topicName);

            PubsubMessage message = new PubsubMessage
            {
                // The data is any arbitrary ByteString. Here, we're using text.
                Data = ByteString.CopyFromUtf8("Hello, Pubsub"),
                // The attributes provide metadata in a string-to-string dictionary.
                Attributes =
                {
                    { "description", "Simple text message" }
                }
            };
            client.Publish(topicName, new[] { message });
            // End snippet
        }


        [Fact]
        public async Task PublishAsync()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();

            // Snippet: PublishAsync(TopicName,*,CallSettings)
            // Additional: PublishAsync(TopicName,*,CancellationToken)
            PublisherServiceApiClient client = PublisherServiceApiClient.Create();
            // Make sure we have a topic to publish to
            TopicName topicName = new TopicName(projectId, topicId);
            await client.CreateTopicAsync(topicName);

            PubsubMessage message = new PubsubMessage
            {
                // The data is any arbitrary ByteString. Here, we're using text.
                Data = ByteString.CopyFromUtf8("Hello, Pubsub"),
                // The attributes provide metadata in a string-to-string dictionary.
                Attributes =
                {
                    { "description", "Simple text message" }
                }
            };
            await client.PublishAsync(topicName, new[] { message });
            // End snippet
        }

        [Fact]
        public void DeleteTopic()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();

            PublisherServiceApiClient.Create().CreateTopic(new TopicName(projectId, topicId));

            // Snippet: DeleteTopic(TopicName,*)
            PublisherServiceApiClient client = PublisherServiceApiClient.Create();

            TopicName topicName = new TopicName(projectId, topicId);
            client.DeleteTopic(topicName);
            Console.WriteLine($"Deleted {topicName}");
            // End snippet
        }

        [Fact]
        public async Task DeleteTopicAsync()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();

            await PublisherServiceApiClient.Create().CreateTopicAsync(new TopicName(projectId, topicId));

            // Snippet: DeleteTopicAsync(TopicName,CallSettings)
            // Additional: DeleteTopicAsync(TopicName,CancellationToken)
            PublisherServiceApiClient client = PublisherServiceApiClient.Create();

            TopicName topicName = new TopicName(projectId, topicId);
            await client.DeleteTopicAsync(topicName);
            Console.WriteLine($"Deleted {topicName}");
            // End snippet
        }
    }
}
