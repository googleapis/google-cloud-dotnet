// Copyright 2017, Google Inc. All rights reserved.
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
using Google.Cloud.Iam.V1;
using Google.Cloud.PubSub.V1;
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

namespace Google.Cloud.PubSub.V1.Snippets
{
    public class GeneratedPublisherClientSnippets
    {
        public async Task CreateTopicAsync()
        {
            // Snippet: CreateTopicAsync(TopicName,CallSettings)
            // Additional: CreateTopicAsync(TopicName,CancellationToken)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            TopicName name = new TopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            Topic response = await publisherClient.CreateTopicAsync(name);
            // End snippet
        }

        public void CreateTopic()
        {
            // Snippet: CreateTopic(TopicName,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            TopicName name = new TopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            Topic response = publisherClient.CreateTopic(name);
            // End snippet
        }

        public async Task CreateTopicAsync_RequestObject()
        {
            // Snippet: CreateTopicAsync(Topic,CallSettings)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            Topic request = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            Topic response = await publisherClient.CreateTopicAsync(request);
            // End snippet
        }

        public void CreateTopic_RequestObject()
        {
            // Snippet: CreateTopic(Topic,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            Topic request = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            Topic response = publisherClient.CreateTopic(request);
            // End snippet
        }

        public async Task UpdateTopicAsync_RequestObject()
        {
            // Snippet: UpdateTopicAsync(UpdateTopicRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Topic response = await publisherClient.UpdateTopicAsync(request);
            // End snippet
        }

        public void UpdateTopic_RequestObject()
        {
            // Snippet: UpdateTopic(UpdateTopicRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Topic response = publisherClient.UpdateTopic(request);
            // End snippet
        }

        public async Task PublishAsync()
        {
            // Snippet: PublishAsync(TopicName,IEnumerable<PubsubMessage>,CallSettings)
            // Additional: PublishAsync(TopicName,IEnumerable<PubsubMessage>,CancellationToken)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            IEnumerable<PubsubMessage> messages = new[]
            {
                new PubsubMessage
                {
                    Data = ByteString.CopyFromUtf8(""),
                },
            };
            // Make the request
            PublishResponse response = await publisherClient.PublishAsync(topic, messages);
            // End snippet
        }

        public void Publish()
        {
            // Snippet: Publish(TopicName,IEnumerable<PubsubMessage>,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            IEnumerable<PubsubMessage> messages = new[]
            {
                new PubsubMessage
                {
                    Data = ByteString.CopyFromUtf8(""),
                },
            };
            // Make the request
            PublishResponse response = publisherClient.Publish(topic, messages);
            // End snippet
        }

        public async Task PublishAsync_RequestObject()
        {
            // Snippet: PublishAsync(PublishRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                Messages = {
                               new PubsubMessage
                               {
                                   Data = ByteString.CopyFromUtf8(""),
                               },
                           },
            };
            // Make the request
            PublishResponse response = await publisherClient.PublishAsync(request);
            // End snippet
        }

        public void Publish_RequestObject()
        {
            // Snippet: Publish(PublishRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
                Messages = {
                               new PubsubMessage
                               {
                                   Data = ByteString.CopyFromUtf8(""),
                               },
                           },
            };
            // Make the request
            PublishResponse response = publisherClient.Publish(request);
            // End snippet
        }

        public async Task GetTopicAsync()
        {
            // Snippet: GetTopicAsync(TopicName,CallSettings)
            // Additional: GetTopicAsync(TopicName,CancellationToken)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            Topic response = await publisherClient.GetTopicAsync(topic);
            // End snippet
        }

        public void GetTopic()
        {
            // Snippet: GetTopic(TopicName,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            Topic response = publisherClient.GetTopic(topic);
            // End snippet
        }

        public async Task GetTopicAsync_RequestObject()
        {
            // Snippet: GetTopicAsync(GetTopicRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            GetTopicRequest request = new GetTopicRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            Topic response = await publisherClient.GetTopicAsync(request);
            // End snippet
        }

        public void GetTopic_RequestObject()
        {
            // Snippet: GetTopic(GetTopicRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            GetTopicRequest request = new GetTopicRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            Topic response = publisherClient.GetTopic(request);
            // End snippet
        }

        public async Task ListTopicsAsync()
        {
            // Snippet: ListTopicsAsync(ProjectName,string,int?,CallSettings)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName project = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListTopicsResponse, Topic> response =
                publisherClient.ListTopicsAsync(project);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListTopics()
        {
            // Snippet: ListTopics(ProjectName,string,int?,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            ProjectName project = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListTopicsResponse, Topic> response =
                publisherClient.ListTopics(project);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListTopicsAsync_RequestObject()
        {
            // Snippet: ListTopicsAsync(ListTopicsRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            ListTopicsRequest request = new ListTopicsRequest
            {
                ProjectAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTopicsResponse, Topic> response =
                publisherClient.ListTopicsAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListTopics_RequestObject()
        {
            // Snippet: ListTopics(ListTopicsRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            ListTopicsRequest request = new ListTopicsRequest
            {
                ProjectAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListTopicsResponse, Topic> response =
                publisherClient.ListTopics(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListTopicSubscriptionsAsync()
        {
            // Snippet: ListTopicSubscriptionsAsync(TopicName,string,int?,CallSettings)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            PagedAsyncEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> response =
                publisherClient.ListTopicSubscriptionsAsync(topic);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SubscriptionName item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SubscriptionName item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SubscriptionName> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SubscriptionName item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListTopicSubscriptions()
        {
            // Snippet: ListTopicSubscriptions(TopicName,string,int?,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            PagedEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> response =
                publisherClient.ListTopicSubscriptions(topic);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SubscriptionName item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SubscriptionName item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SubscriptionName> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SubscriptionName item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListTopicSubscriptionsAsync_RequestObject()
        {
            // Snippet: ListTopicSubscriptionsAsync(ListTopicSubscriptionsRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> response =
                publisherClient.ListTopicSubscriptionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SubscriptionName item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SubscriptionName item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SubscriptionName> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SubscriptionName item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListTopicSubscriptions_RequestObject()
        {
            // Snippet: ListTopicSubscriptions(ListTopicSubscriptionsRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            PagedEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> response =
                publisherClient.ListTopicSubscriptions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SubscriptionName item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SubscriptionName item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SubscriptionName> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SubscriptionName item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task DeleteTopicAsync()
        {
            // Snippet: DeleteTopicAsync(TopicName,CallSettings)
            // Additional: DeleteTopicAsync(TopicName,CancellationToken)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            await publisherClient.DeleteTopicAsync(topic);
            // End snippet
        }

        public void DeleteTopic()
        {
            // Snippet: DeleteTopic(TopicName,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            // Make the request
            publisherClient.DeleteTopic(topic);
            // End snippet
        }

        public async Task DeleteTopicAsync_RequestObject()
        {
            // Snippet: DeleteTopicAsync(DeleteTopicRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            await publisherClient.DeleteTopicAsync(request);
            // End snippet
        }

        public void DeleteTopic_RequestObject()
        {
            // Snippet: DeleteTopic(DeleteTopicRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicAsTopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            // Make the request
            publisherClient.DeleteTopic(request);
            // End snippet
        }

        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string,Policy,CallSettings)
            // Additional: SetIamPolicyAsync(string,Policy,CancellationToken)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new TopicName("[PROJECT]", "[TOPIC]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = await publisherClient.SetIamPolicyAsync(formattedResource, policy);
            // End snippet
        }

        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string,Policy,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedResource = new TopicName("[PROJECT]", "[TOPIC]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = publisherClient.SetIamPolicy(formattedResource, policy);
            // End snippet
        }

        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new TopicName("[PROJECT]", "[TOPIC]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await publisherClient.SetIamPolicyAsync(request);
            // End snippet
        }

        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new TopicName("[PROJECT]", "[TOPIC]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = publisherClient.SetIamPolicy(request);
            // End snippet
        }

        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string,CallSettings)
            // Additional: GetIamPolicyAsync(string,CancellationToken)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new TopicName("[PROJECT]", "[TOPIC]").ToString();
            // Make the request
            Policy response = await publisherClient.GetIamPolicyAsync(formattedResource);
            // End snippet
        }

        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedResource = new TopicName("[PROJECT]", "[TOPIC]").ToString();
            // Make the request
            Policy response = publisherClient.GetIamPolicy(formattedResource);
            // End snippet
        }

        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new TopicName("[PROJECT]", "[TOPIC]").ToString(),
            };
            // Make the request
            Policy response = await publisherClient.GetIamPolicyAsync(request);
            // End snippet
        }

        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new TopicName("[PROJECT]", "[TOPIC]").ToString(),
            };
            // Make the request
            Policy response = publisherClient.GetIamPolicy(request);
            // End snippet
        }

        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string,IEnumerable<string>,CallSettings)
            // Additional: TestIamPermissionsAsync(string,IEnumerable<string>,CancellationToken)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new TopicName("[PROJECT]", "[TOPIC]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = await publisherClient.TestIamPermissionsAsync(formattedResource, permissions);
            // End snippet
        }

        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string,IEnumerable<string>,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            string formattedResource = new TopicName("[PROJECT]", "[TOPIC]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = publisherClient.TestIamPermissions(formattedResource, permissions);
            // End snippet
        }

        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new TopicName("[PROJECT]", "[TOPIC]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = await publisherClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest,CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new TopicName("[PROJECT]", "[TOPIC]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = publisherClient.TestIamPermissions(request);
            // End snippet
        }

    }
}
