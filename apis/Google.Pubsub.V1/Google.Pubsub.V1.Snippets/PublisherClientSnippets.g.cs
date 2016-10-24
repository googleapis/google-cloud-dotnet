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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Pubsub.V1.Snippets
{
    public class PublisherClientSnippets
    {
        public async Task CreateTopicAsync()
        {
            // Snippet: CreateTopicAsync(string,CallSettings)
            // Additional: CreateTopicAsync(string,CancellationToken)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedName = PublisherClient.FormatTopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            Topic response = await publisherClient.CreateTopicAsync(formattedName);
            // End snippet
        }

        public void CreateTopic()
        {
            // Snippet: CreateTopic(string,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedName = PublisherClient.FormatTopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            Topic response = publisherClient.CreateTopic(formattedName);
            // End snippet
        }

        public async Task PublishAsync()
        {
            // Snippet: PublishAsync(string,IEnumerable<PubsubMessage>,CallSettings)
            // Additional: PublishAsync(string,IEnumerable<PubsubMessage>,CancellationToken)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedTopic = PublisherClient.FormatTopicName("[PROJECT]", "[TOPIC]");
            IEnumerable<PubsubMessage> messages = new[]
            {
                new PubsubMessage
                {
                    Data = ByteString.CopyFromUtf8(""),
                },
            };
            // Make the request
            PublishResponse response = await publisherClient.PublishAsync(formattedTopic, messages);
            // End snippet
        }

        public void Publish()
        {
            // Snippet: Publish(string,IEnumerable<PubsubMessage>,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedTopic = PublisherClient.FormatTopicName("[PROJECT]", "[TOPIC]");
            IEnumerable<PubsubMessage> messages = new[]
            {
                new PubsubMessage
                {
                    Data = ByteString.CopyFromUtf8(""),
                },
            };
            // Make the request
            PublishResponse response = publisherClient.Publish(formattedTopic, messages);
            // End snippet
        }

        public async Task GetTopicAsync()
        {
            // Snippet: GetTopicAsync(string,CallSettings)
            // Additional: GetTopicAsync(string,CancellationToken)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedTopic = PublisherClient.FormatTopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            Topic response = await publisherClient.GetTopicAsync(formattedTopic);
            // End snippet
        }

        public void GetTopic()
        {
            // Snippet: GetTopic(string,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedTopic = PublisherClient.FormatTopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            Topic response = publisherClient.GetTopic(formattedTopic);
            // End snippet
        }

        public async Task ListTopicsAsync()
        {
            // Snippet: ListTopicsAsync(string,string,int?,CallSettings)
            // Additional: ListTopicsAsync(string,string,int?,CancellationToken)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedProject = PublisherClient.FormatProjectName("[PROJECT]");
            // Make the request
            IPagedAsyncEnumerable<ListTopicsResponse,Topic> response =
                publisherClient.ListTopicsAsync(formattedProject);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Topic item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            IAsyncEnumerable<FixedSizePage<Topic>> fixedSizePages = response.AsPages().WithFixedSize(pageSize);
            await fixedSizePages.ForEachAsync((FixedSizePage<Topic> page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    Console.WriteLine(item);
                }
            });
            // End snippet
        }

        public void ListTopics()
        {
            // Snippet: ListTopics(string,string,int?,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedProject = PublisherClient.FormatProjectName("[PROJECT]");
            // Make the request
            IPagedEnumerable<ListTopicsResponse,Topic> response =
                publisherClient.ListTopics(formattedProject);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Topic item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            foreach (FixedSizePage<Topic> page in response.AsPages().WithFixedSize(pageSize))
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    Console.WriteLine(item);
                }
            }
            // End snippet
        }

        public async Task ListTopicSubscriptionsAsync()
        {
            // Snippet: ListTopicSubscriptionsAsync(string,string,int?,CallSettings)
            // Additional: ListTopicSubscriptionsAsync(string,string,int?,CancellationToken)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedTopic = PublisherClient.FormatTopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            IPagedAsyncEnumerable<ListTopicSubscriptionsResponse,string> response =
                publisherClient.ListTopicSubscriptionsAsync(formattedTopic);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            IAsyncEnumerable<FixedSizePage<string>> fixedSizePages = response.AsPages().WithFixedSize(pageSize);
            await fixedSizePages.ForEachAsync((FixedSizePage<string> page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    Console.WriteLine(item);
                }
            });
            // End snippet
        }

        public void ListTopicSubscriptions()
        {
            // Snippet: ListTopicSubscriptions(string,string,int?,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedTopic = PublisherClient.FormatTopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            IPagedEnumerable<ListTopicSubscriptionsResponse,string> response =
                publisherClient.ListTopicSubscriptions(formattedTopic);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            foreach (FixedSizePage<string> page in response.AsPages().WithFixedSize(pageSize))
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    Console.WriteLine(item);
                }
            }
            // End snippet
        }

        public async Task DeleteTopicAsync()
        {
            // Snippet: DeleteTopicAsync(string,CallSettings)
            // Additional: DeleteTopicAsync(string,CancellationToken)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedTopic = PublisherClient.FormatTopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            await publisherClient.DeleteTopicAsync(formattedTopic);
            // End snippet
        }

        public void DeleteTopic()
        {
            // Snippet: DeleteTopic(string,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedTopic = PublisherClient.FormatTopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            publisherClient.DeleteTopic(formattedTopic);
            // End snippet
        }

    }
}
