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
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Pubsub.V1.Snippets
{
    [Collection(nameof(PubsubSnippetFixture))]
    public class PublisherClientSnippets
    {
        private readonly PubsubSnippetFixture _fixture;

        public PublisherClientSnippets(PubsubSnippetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void ListTopics()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListTopics
            PublisherClient client = PublisherClient.Create();

            // Alternative: use a known project resource name:
            // "projects/{PROJECT_ID}"
            string projectName = PublisherClient.FormatProjectName(projectId);
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

            // Snippet: ListTopicsAsync
            PublisherClient client = PublisherClient.Create();

            // Alternative: use a known project resource name:
            // "projects/{PROJECT_ID}"
            string projectName = PublisherClient.FormatProjectName(projectId);
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

            // Snippet: CreateTopic
            PublisherClient client = PublisherClient.Create();

            // Alternative: use a known topic resource name
            // "projects/{PROJECT_ID}/topics/{TOPIC_ID}"
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);
            Topic topic = client.CreateTopic(topicName);
            Console.WriteLine($"Created {topic.Name}");
            // End snippet
        }

        [Fact]
        public async Task CreateTopicAsync()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();

            // Snippet: CreateTopicAsync(string,CallSettings)
            // Additional: CreateTopicAsync(string,CancellationToken)
            PublisherClient client = PublisherClient.Create();

            // Alternative: use a known topic resource name
            // "projects/{PROJECT_ID}/topics/{TOPIC_ID}"
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);
            Topic topic = await client.CreateTopicAsync(topicName);
            Console.WriteLine($"Created {topic.Name}");
            // End snippet
        }

        [Fact]
        public void Publish()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();

            // Snippet: Publish
            PublisherClient client = PublisherClient.Create();
            // Make sure we have a topic to publish to
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);
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

            // Snippet: PublishAsync(*,*,CallSettings)
            // Additional: PublishAsync(*,*,CancellationToken)
            PublisherClient client = PublisherClient.Create();
            // Make sure we have a topic to publish to
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);
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

            PublisherClient.Create().CreateTopic(PublisherClient.FormatTopicName(projectId, topicId));

            // Snippet: DeleteTopic
            PublisherClient client = PublisherClient.Create();

            // Alternative: use a known topic resource name
            // "projects/{PROJECT_ID}/topics/{TOPIC_ID}"
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);
            client.DeleteTopic(topicName);
            Console.WriteLine($"Deleted {topicName}");
            // End snippet
        }

        [Fact]
        public async Task DeleteTopicAsync()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();

            await PublisherClient.Create().CreateTopicAsync(PublisherClient.FormatTopicName(projectId, topicId));

            // Snippet: DeleteTopicAsync(string,CallSettings)
            // Additional: DeleteTopicAsync(string,CancellationToken)
            PublisherClient client = PublisherClient.Create();

            // Alternative: use a known topic resource name
            // "projects/{PROJECT_ID}/topics/{TOPIC_ID}"
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);
            await client.DeleteTopicAsync(topicName);
            Console.WriteLine($"Deleted {topicName}");
            // End snippet
        }

        [Fact]
        public void PageStreamingUseCases_AllResources()
        {
            string projectId = _fixture.ProjectId;
            // Sample: PageStreamingUseCases_AllResources
            PublisherClient client = PublisherClient.Create();
            string projectName = PublisherClient.FormatProjectName(projectId);
            IPagedEnumerable<ListTopicsResponse, Topic> topics = client.ListTopics(projectName, pageSize: 3);
            foreach (Topic topic in topics)
            {
                Console.WriteLine(topic.Name);
            }
            // End sample
        }

        [Fact]
        public void PageStreamingUseCases_Responses()
        {
            string projectId = _fixture.ProjectId;
            // Sample: PageStreamingUseCases_Responses
            PublisherClient client = PublisherClient.Create();
            string projectName = PublisherClient.FormatProjectName(projectId);
            IPagedEnumerable<ListTopicsResponse, Topic> topics = client.ListTopics(projectName, pageSize: 3);
            IResponseEnumerable<ListTopicsResponse, Topic> topicPages = topics.AsPages();
            foreach (ListTopicsResponse page in topicPages)
            {
                Console.WriteLine("Topics in response:");
                foreach (Topic topic in page.Topics)
                {
                    Console.WriteLine($"  {topic.Name}");
                }
                // If you were processing items in batches, you might wish to store this
                // in order to recover from failures. The page token can be passed into the ListTopics method.
                Console.WriteLine($"Next page token: {page.NextPageToken}");
            }
            // End sample
        }

        [Fact]
        public void PageStreamingUseCases_SingleResponse()
        {
            string projectId = _fixture.ProjectId;
            // Sample: PageStreamingUseCases_SingleResponse
            PublisherClient client = PublisherClient.Create();
            string projectName = PublisherClient.FormatProjectName(projectId);
            IPagedEnumerable<ListTopicsResponse, Topic> topics = client.ListTopics(projectName, pageSize: 3);
            IResponseEnumerable<ListTopicsResponse, Topic> topicPages = topics.AsPages();
            // This is just the regular LINQ First() method. The sequence of pages will never be empty,
            // but the page may have no resources.
            ListTopicsResponse firstPage = topicPages.First();
            Console.WriteLine("Topics in response:");
            foreach (Topic topic in firstPage.Topics)
            {
                Console.WriteLine($"  {topic.Name}");
            }
            // If you were processing items in batches, you might wish to store this
            // in order to recover from failures. The page token can be passed into the ListTopics method.
            Console.WriteLine($"Next page token: {firstPage.NextPageToken}");
            // End sample
        }

        [Fact]
        public void PageStreamingUseCases_WithFixedSize()
        {
            string projectId = _fixture.ProjectId;
            string pageTokenFromRequest = "";

            // Sample: PageStreamingUseCases_WithFixedSize
            PublisherClient client = PublisherClient.Create();
            string projectName = PublisherClient.FormatProjectName(projectId);
            IPagedEnumerable<ListTopicsResponse, Topic> topics = client.ListTopics(projectName, pageTokenFromRequest);

            IEnumerable<FixedSizePage<Topic>> fixedSizePages = topics.AsPages().WithFixedSize(3);
            // With fixed size pages, if there are no more resources, there are no more pages.
            FixedSizePage<Topic> nextPage = fixedSizePages.FirstOrDefault();
            if (nextPage != null)
            {
                // In a web application, this would be a matter of including the topics in the web page.
                foreach (Topic topic in nextPage)
                {
                    Console.WriteLine(topic.Name);
                }
                // ... and embedding the next page token into a "next page" link.
                Console.WriteLine($"Next page token: {nextPage.NextPageToken}");
            }
            // End sample
        }
    }
}