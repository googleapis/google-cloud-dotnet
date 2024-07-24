// Copyright 2024 Google LLC
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

// Generated code. DO NOT EDIT!

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.PubSub.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPublisherServiceApiClientSnippets
    {
        /// <summary>Snippet for CreateTopic</summary>
        public void CreateTopicRequestObject()
        {
            // Snippet: CreateTopic(Topic, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            Topic request = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels = { { "", "" }, },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new Duration(),
                State = Topic.Types.State.Unspecified,
                IngestionDataSourceSettings = new IngestionDataSourceSettings(),
            };
            // Make the request
            Topic response = publisherServiceApiClient.CreateTopic(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTopicAsync</summary>
        public async Task CreateTopicRequestObjectAsync()
        {
            // Snippet: CreateTopicAsync(Topic, CallSettings)
            // Additional: CreateTopicAsync(Topic, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            Topic request = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels = { { "", "" }, },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new Duration(),
                State = Topic.Types.State.Unspecified,
                IngestionDataSourceSettings = new IngestionDataSourceSettings(),
            };
            // Make the request
            Topic response = await publisherServiceApiClient.CreateTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTopic</summary>
        public void CreateTopic()
        {
            // Snippet: CreateTopic(string, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/topics/[TOPIC]";
            // Make the request
            Topic response = publisherServiceApiClient.CreateTopic(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTopicAsync</summary>
        public async Task CreateTopicAsync()
        {
            // Snippet: CreateTopicAsync(string, CallSettings)
            // Additional: CreateTopicAsync(string, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/topics/[TOPIC]";
            // Make the request
            Topic response = await publisherServiceApiClient.CreateTopicAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTopic</summary>
        public void CreateTopicResourceNames()
        {
            // Snippet: CreateTopic(TopicName, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            TopicName name = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            // Make the request
            Topic response = publisherServiceApiClient.CreateTopic(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTopicAsync</summary>
        public async Task CreateTopicResourceNamesAsync()
        {
            // Snippet: CreateTopicAsync(TopicName, CallSettings)
            // Additional: CreateTopicAsync(TopicName, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TopicName name = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            // Make the request
            Topic response = await publisherServiceApiClient.CreateTopicAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateTopic</summary>
        public void UpdateTopicRequestObject()
        {
            // Snippet: UpdateTopic(UpdateTopicRequest, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Topic response = publisherServiceApiClient.UpdateTopic(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTopicAsync</summary>
        public async Task UpdateTopicRequestObjectAsync()
        {
            // Snippet: UpdateTopicAsync(UpdateTopicRequest, CallSettings)
            // Additional: UpdateTopicAsync(UpdateTopicRequest, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Topic response = await publisherServiceApiClient.UpdateTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTopic</summary>
        public void UpdateTopic()
        {
            // Snippet: UpdateTopic(Topic, FieldMask, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            Topic topic = new Topic();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Topic response = publisherServiceApiClient.UpdateTopic(topic, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTopicAsync</summary>
        public async Task UpdateTopicAsync()
        {
            // Snippet: UpdateTopicAsync(Topic, FieldMask, CallSettings)
            // Additional: UpdateTopicAsync(Topic, FieldMask, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            Topic topic = new Topic();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Topic response = await publisherServiceApiClient.UpdateTopicAsync(topic, updateMask);
            // End snippet
        }

        /// <summary>Snippet for Publish</summary>
        public void PublishRequestObject()
        {
            // Snippet: Publish(PublishRequest, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Messages =
                {
                    new PubsubMessage(),
                },
            };
            // Make the request
            PublishResponse response = publisherServiceApiClient.Publish(request);
            // End snippet
        }

        /// <summary>Snippet for PublishAsync</summary>
        public async Task PublishRequestObjectAsync()
        {
            // Snippet: PublishAsync(PublishRequest, CallSettings)
            // Additional: PublishAsync(PublishRequest, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Messages =
                {
                    new PubsubMessage(),
                },
            };
            // Make the request
            PublishResponse response = await publisherServiceApiClient.PublishAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Publish</summary>
        public void Publish()
        {
            // Snippet: Publish(string, IEnumerable<PubsubMessage>, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            string topic = "projects/[PROJECT]/topics/[TOPIC]";
            IEnumerable<PubsubMessage> messages = new PubsubMessage[]
            {
                new PubsubMessage(),
            };
            // Make the request
            PublishResponse response = publisherServiceApiClient.Publish(topic, messages);
            // End snippet
        }

        /// <summary>Snippet for PublishAsync</summary>
        public async Task PublishAsync()
        {
            // Snippet: PublishAsync(string, IEnumerable<PubsubMessage>, CallSettings)
            // Additional: PublishAsync(string, IEnumerable<PubsubMessage>, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string topic = "projects/[PROJECT]/topics/[TOPIC]";
            IEnumerable<PubsubMessage> messages = new PubsubMessage[]
            {
                new PubsubMessage(),
            };
            // Make the request
            PublishResponse response = await publisherServiceApiClient.PublishAsync(topic, messages);
            // End snippet
        }

        /// <summary>Snippet for Publish</summary>
        public void PublishResourceNames()
        {
            // Snippet: Publish(TopicName, IEnumerable<PubsubMessage>, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            TopicName topic = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            IEnumerable<PubsubMessage> messages = new PubsubMessage[]
            {
                new PubsubMessage(),
            };
            // Make the request
            PublishResponse response = publisherServiceApiClient.Publish(topic, messages);
            // End snippet
        }

        /// <summary>Snippet for PublishAsync</summary>
        public async Task PublishResourceNamesAsync()
        {
            // Snippet: PublishAsync(TopicName, IEnumerable<PubsubMessage>, CallSettings)
            // Additional: PublishAsync(TopicName, IEnumerable<PubsubMessage>, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TopicName topic = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            IEnumerable<PubsubMessage> messages = new PubsubMessage[]
            {
                new PubsubMessage(),
            };
            // Make the request
            PublishResponse response = await publisherServiceApiClient.PublishAsync(topic, messages);
            // End snippet
        }

        /// <summary>Snippet for GetTopic</summary>
        public void GetTopicRequestObject()
        {
            // Snippet: GetTopic(GetTopicRequest, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            GetTopicRequest request = new GetTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            Topic response = publisherServiceApiClient.GetTopic(request);
            // End snippet
        }

        /// <summary>Snippet for GetTopicAsync</summary>
        public async Task GetTopicRequestObjectAsync()
        {
            // Snippet: GetTopicAsync(GetTopicRequest, CallSettings)
            // Additional: GetTopicAsync(GetTopicRequest, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            GetTopicRequest request = new GetTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            Topic response = await publisherServiceApiClient.GetTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTopic</summary>
        public void GetTopic()
        {
            // Snippet: GetTopic(string, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            string topic = "projects/[PROJECT]/topics/[TOPIC]";
            // Make the request
            Topic response = publisherServiceApiClient.GetTopic(topic);
            // End snippet
        }

        /// <summary>Snippet for GetTopicAsync</summary>
        public async Task GetTopicAsync()
        {
            // Snippet: GetTopicAsync(string, CallSettings)
            // Additional: GetTopicAsync(string, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string topic = "projects/[PROJECT]/topics/[TOPIC]";
            // Make the request
            Topic response = await publisherServiceApiClient.GetTopicAsync(topic);
            // End snippet
        }

        /// <summary>Snippet for GetTopic</summary>
        public void GetTopicResourceNames()
        {
            // Snippet: GetTopic(TopicName, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            TopicName topic = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            // Make the request
            Topic response = publisherServiceApiClient.GetTopic(topic);
            // End snippet
        }

        /// <summary>Snippet for GetTopicAsync</summary>
        public async Task GetTopicResourceNamesAsync()
        {
            // Snippet: GetTopicAsync(TopicName, CallSettings)
            // Additional: GetTopicAsync(TopicName, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TopicName topic = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            // Make the request
            Topic response = await publisherServiceApiClient.GetTopicAsync(topic);
            // End snippet
        }

        /// <summary>Snippet for ListTopics</summary>
        public void ListTopicsRequestObject()
        {
            // Snippet: ListTopics(ListTopicsRequest, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            ListTopicsRequest request = new ListTopicsRequest
            {
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListTopicsResponse, Topic> response = publisherServiceApiClient.ListTopics(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Topic item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicsAsync</summary>
        public async Task ListTopicsRequestObjectAsync()
        {
            // Snippet: ListTopicsAsync(ListTopicsRequest, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ListTopicsRequest request = new ListTopicsRequest
            {
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTopicsResponse, Topic> response = publisherServiceApiClient.ListTopicsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Topic item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopics</summary>
        public void ListTopics()
        {
            // Snippet: ListTopics(string, string, int?, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            string project = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListTopicsResponse, Topic> response = publisherServiceApiClient.ListTopics(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Topic item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicsAsync</summary>
        public async Task ListTopicsAsync()
        {
            // Snippet: ListTopicsAsync(string, string, int?, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string project = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListTopicsResponse, Topic> response = publisherServiceApiClient.ListTopicsAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Topic item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopics</summary>
        public void ListTopicsResourceNames()
        {
            // Snippet: ListTopics(ProjectName, string, int?, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListTopicsResponse, Topic> response = publisherServiceApiClient.ListTopics(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Topic item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicsAsync</summary>
        public async Task ListTopicsResourceNamesAsync()
        {
            // Snippet: ListTopicsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListTopicsResponse, Topic> response = publisherServiceApiClient.ListTopicsAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Topic item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptions</summary>
        public void ListTopicSubscriptionsRequestObject()
        {
            // Snippet: ListTopicSubscriptions(ListTopicSubscriptionsRequest, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            PagedEnumerable<ListTopicSubscriptionsResponse, string> response = publisherServiceApiClient.ListTopicSubscriptions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptionsAsync</summary>
        public async Task ListTopicSubscriptionsRequestObjectAsync()
        {
            // Snippet: ListTopicSubscriptionsAsync(ListTopicSubscriptionsRequest, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> response = publisherServiceApiClient.ListTopicSubscriptionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptions</summary>
        public void ListTopicSubscriptions()
        {
            // Snippet: ListTopicSubscriptions(string, string, int?, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            string topic = "projects/[PROJECT]/topics/[TOPIC]";
            // Make the request
            PagedEnumerable<ListTopicSubscriptionsResponse, string> response = publisherServiceApiClient.ListTopicSubscriptions(topic);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptionsAsync</summary>
        public async Task ListTopicSubscriptionsAsync()
        {
            // Snippet: ListTopicSubscriptionsAsync(string, string, int?, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string topic = "projects/[PROJECT]/topics/[TOPIC]";
            // Make the request
            PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> response = publisherServiceApiClient.ListTopicSubscriptionsAsync(topic);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptions</summary>
        public void ListTopicSubscriptionsResourceNames()
        {
            // Snippet: ListTopicSubscriptions(TopicName, string, int?, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            TopicName topic = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            // Make the request
            PagedEnumerable<ListTopicSubscriptionsResponse, string> response = publisherServiceApiClient.ListTopicSubscriptions(topic);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptionsAsync</summary>
        public async Task ListTopicSubscriptionsResourceNamesAsync()
        {
            // Snippet: ListTopicSubscriptionsAsync(TopicName, string, int?, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TopicName topic = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            // Make the request
            PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> response = publisherServiceApiClient.ListTopicSubscriptionsAsync(topic);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSnapshots</summary>
        public void ListTopicSnapshotsRequestObject()
        {
            // Snippet: ListTopicSnapshots(ListTopicSnapshotsRequest, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            ListTopicSnapshotsRequest request = new ListTopicSnapshotsRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            PagedEnumerable<ListTopicSnapshotsResponse, string> response = publisherServiceApiClient.ListTopicSnapshots(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSnapshotsAsync</summary>
        public async Task ListTopicSnapshotsRequestObjectAsync()
        {
            // Snippet: ListTopicSnapshotsAsync(ListTopicSnapshotsRequest, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ListTopicSnapshotsRequest request = new ListTopicSnapshotsRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTopicSnapshotsResponse, string> response = publisherServiceApiClient.ListTopicSnapshotsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSnapshots</summary>
        public void ListTopicSnapshots()
        {
            // Snippet: ListTopicSnapshots(string, string, int?, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            string topic = "projects/[PROJECT]/topics/[TOPIC]";
            // Make the request
            PagedEnumerable<ListTopicSnapshotsResponse, string> response = publisherServiceApiClient.ListTopicSnapshots(topic);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSnapshotsAsync</summary>
        public async Task ListTopicSnapshotsAsync()
        {
            // Snippet: ListTopicSnapshotsAsync(string, string, int?, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string topic = "projects/[PROJECT]/topics/[TOPIC]";
            // Make the request
            PagedAsyncEnumerable<ListTopicSnapshotsResponse, string> response = publisherServiceApiClient.ListTopicSnapshotsAsync(topic);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSnapshots</summary>
        public void ListTopicSnapshotsResourceNames()
        {
            // Snippet: ListTopicSnapshots(TopicName, string, int?, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            TopicName topic = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            // Make the request
            PagedEnumerable<ListTopicSnapshotsResponse, string> response = publisherServiceApiClient.ListTopicSnapshots(topic);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSnapshotsAsync</summary>
        public async Task ListTopicSnapshotsResourceNamesAsync()
        {
            // Snippet: ListTopicSnapshotsAsync(TopicName, string, int?, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TopicName topic = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            // Make the request
            PagedAsyncEnumerable<ListTopicSnapshotsResponse, string> response = publisherServiceApiClient.ListTopicSnapshotsAsync(topic);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteTopic</summary>
        public void DeleteTopicRequestObject()
        {
            // Snippet: DeleteTopic(DeleteTopicRequest, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            publisherServiceApiClient.DeleteTopic(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopicAsync</summary>
        public async Task DeleteTopicRequestObjectAsync()
        {
            // Snippet: DeleteTopicAsync(DeleteTopicRequest, CallSettings)
            // Additional: DeleteTopicAsync(DeleteTopicRequest, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            await publisherServiceApiClient.DeleteTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopic</summary>
        public void DeleteTopic()
        {
            // Snippet: DeleteTopic(string, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            string topic = "projects/[PROJECT]/topics/[TOPIC]";
            // Make the request
            publisherServiceApiClient.DeleteTopic(topic);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopicAsync</summary>
        public async Task DeleteTopicAsync()
        {
            // Snippet: DeleteTopicAsync(string, CallSettings)
            // Additional: DeleteTopicAsync(string, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string topic = "projects/[PROJECT]/topics/[TOPIC]";
            // Make the request
            await publisherServiceApiClient.DeleteTopicAsync(topic);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopic</summary>
        public void DeleteTopicResourceNames()
        {
            // Snippet: DeleteTopic(TopicName, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            TopicName topic = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            // Make the request
            publisherServiceApiClient.DeleteTopic(topic);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopicAsync</summary>
        public async Task DeleteTopicResourceNamesAsync()
        {
            // Snippet: DeleteTopicAsync(TopicName, CallSettings)
            // Additional: DeleteTopicAsync(TopicName, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TopicName topic = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            // Make the request
            await publisherServiceApiClient.DeleteTopicAsync(topic);
            // End snippet
        }

        /// <summary>Snippet for DetachSubscription</summary>
        public void DetachSubscriptionRequestObject()
        {
            // Snippet: DetachSubscription(DetachSubscriptionRequest, CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            DetachSubscriptionRequest request = new DetachSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            DetachSubscriptionResponse response = publisherServiceApiClient.DetachSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for DetachSubscriptionAsync</summary>
        public async Task DetachSubscriptionRequestObjectAsync()
        {
            // Snippet: DetachSubscriptionAsync(DetachSubscriptionRequest, CallSettings)
            // Additional: DetachSubscriptionAsync(DetachSubscriptionRequest, CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            DetachSubscriptionRequest request = new DetachSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            DetachSubscriptionResponse response = await publisherServiceApiClient.DetachSubscriptionAsync(request);
            // End snippet
        }
    }
}
