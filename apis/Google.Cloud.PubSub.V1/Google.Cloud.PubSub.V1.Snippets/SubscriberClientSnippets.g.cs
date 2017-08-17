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
    public class GeneratedSubscriberClientSnippets
    {
        public async Task CreateSubscriptionAsync()
        {
            // Snippet: CreateSubscriptionAsync(SubscriptionName,TopicName,PushConfig,int?,CallSettings)
            // Additional: CreateSubscriptionAsync(SubscriptionName,TopicName,PushConfig,int?,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName name = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 0;
            // Make the request
            Subscription response = await subscriberClient.CreateSubscriptionAsync(name, topic, pushConfig, ackDeadlineSeconds);
            // End snippet
        }

        public void CreateSubscription()
        {
            // Snippet: CreateSubscription(SubscriptionName,TopicName,PushConfig,int?,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName name = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 0;
            // Make the request
            Subscription response = subscriberClient.CreateSubscription(name, topic, pushConfig, ackDeadlineSeconds);
            // End snippet
        }

        public async Task CreateSubscriptionAsync_RequestObject()
        {
            // Snippet: CreateSubscriptionAsync(Subscription,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            Subscription request = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
            };
            // Make the request
            Subscription response = await subscriberClient.CreateSubscriptionAsync(request);
            // End snippet
        }

        public void CreateSubscription_RequestObject()
        {
            // Snippet: CreateSubscription(Subscription,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            Subscription request = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
            };
            // Make the request
            Subscription response = subscriberClient.CreateSubscription(request);
            // End snippet
        }

        public async Task GetSubscriptionAsync()
        {
            // Snippet: GetSubscriptionAsync(SubscriptionName,CallSettings)
            // Additional: GetSubscriptionAsync(SubscriptionName,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Subscription response = await subscriberClient.GetSubscriptionAsync(subscription);
            // End snippet
        }

        public void GetSubscription()
        {
            // Snippet: GetSubscription(SubscriptionName,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Subscription response = subscriberClient.GetSubscription(subscription);
            // End snippet
        }

        public async Task GetSubscriptionAsync_RequestObject()
        {
            // Snippet: GetSubscriptionAsync(GetSubscriptionRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            Subscription response = await subscriberClient.GetSubscriptionAsync(request);
            // End snippet
        }

        public void GetSubscription_RequestObject()
        {
            // Snippet: GetSubscription(GetSubscriptionRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            Subscription response = subscriberClient.GetSubscription(request);
            // End snippet
        }

        public async Task UpdateSubscriptionAsync_RequestObject()
        {
            // Snippet: UpdateSubscriptionAsync(UpdateSubscriptionRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Subscription response = await subscriberClient.UpdateSubscriptionAsync(request);
            // End snippet
        }

        public void UpdateSubscription_RequestObject()
        {
            // Snippet: UpdateSubscription(UpdateSubscriptionRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Subscription response = subscriberClient.UpdateSubscription(request);
            // End snippet
        }

        public async Task ListSubscriptionsAsync()
        {
            // Snippet: ListSubscriptionsAsync(ProjectName,string,int?,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName project = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response =
                subscriberClient.ListSubscriptionsAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subscription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListSubscriptions()
        {
            // Snippet: ListSubscriptions(ProjectName,string,int?,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            ProjectName project = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response =
                subscriberClient.ListSubscriptions(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListSubscriptionsAsync_RequestObject()
        {
            // Snippet: ListSubscriptionsAsync(ListSubscriptionsRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                ProjectAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response =
                subscriberClient.ListSubscriptionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subscription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListSubscriptions_RequestObject()
        {
            // Snippet: ListSubscriptions(ListSubscriptionsRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                ProjectAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response =
                subscriberClient.ListSubscriptions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task DeleteSubscriptionAsync()
        {
            // Snippet: DeleteSubscriptionAsync(SubscriptionName,CallSettings)
            // Additional: DeleteSubscriptionAsync(SubscriptionName,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            await subscriberClient.DeleteSubscriptionAsync(subscription);
            // End snippet
        }

        public void DeleteSubscription()
        {
            // Snippet: DeleteSubscription(SubscriptionName,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            subscriberClient.DeleteSubscription(subscription);
            // End snippet
        }

        public async Task DeleteSubscriptionAsync_RequestObject()
        {
            // Snippet: DeleteSubscriptionAsync(DeleteSubscriptionRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            await subscriberClient.DeleteSubscriptionAsync(request);
            // End snippet
        }

        public void DeleteSubscription_RequestObject()
        {
            // Snippet: DeleteSubscription(DeleteSubscriptionRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            subscriberClient.DeleteSubscription(request);
            // End snippet
        }

        public async Task ModifyAckDeadlineAsync()
        {
            // Snippet: ModifyAckDeadlineAsync(SubscriptionName,IEnumerable<string>,int,CallSettings)
            // Additional: ModifyAckDeadlineAsync(SubscriptionName,IEnumerable<string>,int,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            int ackDeadlineSeconds = 0;
            // Make the request
            await subscriberClient.ModifyAckDeadlineAsync(subscription, ackIds, ackDeadlineSeconds);
            // End snippet
        }

        public void ModifyAckDeadline()
        {
            // Snippet: ModifyAckDeadline(SubscriptionName,IEnumerable<string>,int,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            int ackDeadlineSeconds = 0;
            // Make the request
            subscriberClient.ModifyAckDeadline(subscription, ackIds, ackDeadlineSeconds);
            // End snippet
        }

        public async Task ModifyAckDeadlineAsync_RequestObject()
        {
            // Snippet: ModifyAckDeadlineAsync(ModifyAckDeadlineRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
                AckDeadlineSeconds = 0,
            };
            // Make the request
            await subscriberClient.ModifyAckDeadlineAsync(request);
            // End snippet
        }

        public void ModifyAckDeadline_RequestObject()
        {
            // Snippet: ModifyAckDeadline(ModifyAckDeadlineRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
                AckDeadlineSeconds = 0,
            };
            // Make the request
            subscriberClient.ModifyAckDeadline(request);
            // End snippet
        }

        public async Task AcknowledgeAsync()
        {
            // Snippet: AcknowledgeAsync(SubscriptionName,IEnumerable<string>,CallSettings)
            // Additional: AcknowledgeAsync(SubscriptionName,IEnumerable<string>,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            // Make the request
            await subscriberClient.AcknowledgeAsync(subscription, ackIds);
            // End snippet
        }

        public void Acknowledge()
        {
            // Snippet: Acknowledge(SubscriptionName,IEnumerable<string>,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            // Make the request
            subscriberClient.Acknowledge(subscription, ackIds);
            // End snippet
        }

        public async Task AcknowledgeAsync_RequestObject()
        {
            // Snippet: AcknowledgeAsync(AcknowledgeRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
            };
            // Make the request
            await subscriberClient.AcknowledgeAsync(request);
            // End snippet
        }

        public void Acknowledge_RequestObject()
        {
            // Snippet: Acknowledge(AcknowledgeRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
            };
            // Make the request
            subscriberClient.Acknowledge(request);
            // End snippet
        }

        public async Task PullAsync()
        {
            // Snippet: PullAsync(SubscriptionName,bool?,int,CallSettings)
            // Additional: PullAsync(SubscriptionName,bool?,int,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            bool returnImmediately = false;
            int maxMessages = 0;
            // Make the request
            PullResponse response = await subscriberClient.PullAsync(subscription, returnImmediately, maxMessages);
            // End snippet
        }

        public void Pull()
        {
            // Snippet: Pull(SubscriptionName,bool?,int,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            bool returnImmediately = false;
            int maxMessages = 0;
            // Make the request
            PullResponse response = subscriberClient.Pull(subscription, returnImmediately, maxMessages);
            // End snippet
        }

        public async Task PullAsync_RequestObject()
        {
            // Snippet: PullAsync(PullRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                MaxMessages = 0,
            };
            // Make the request
            PullResponse response = await subscriberClient.PullAsync(request);
            // End snippet
        }

        public void Pull_RequestObject()
        {
            // Snippet: Pull(PullRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                MaxMessages = 0,
            };
            // Make the request
            PullResponse response = subscriberClient.Pull(request);
            // End snippet
        }

        public async Task StreamingPull()
        {
            // Snippet: StreamingPull(CallSettings,BidirectionalStreamingSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize streaming call, retrieving the stream object
            SubscriberClient.StreamingPullStream duplexStream = subscriberClient.StreamingPull();

            // Sending requests and retrieving responses can be arbitrarily interleaved.
            // Exact sequence will depend on client/server behavior.

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                IAsyncEnumerator<StreamingPullResponse> responseStream = duplexStream.ResponseStream;
                while (await responseStream.MoveNext())
                {
                    StreamingPullResponse response = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                StreamingPullRequest request = new StreamingPullRequest
                {
                    SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                    StreamAckDeadlineSeconds = 0,
                };
                // Stream a request to the server
                await duplexStream.WriteAsync(request);

                // Set "done" to true when sending requests is complete
            }
            // Complete writing requests to the stream
            await duplexStream.WriteCompleteAsync();
            // Await the response handler.
            // This will complete once all server responses have been processed.
            await responseHandlerTask;
            // End snippet
        }

        public async Task ModifyPushConfigAsync()
        {
            // Snippet: ModifyPushConfigAsync(SubscriptionName,PushConfig,CallSettings)
            // Additional: ModifyPushConfigAsync(SubscriptionName,PushConfig,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            PushConfig pushConfig = new PushConfig();
            // Make the request
            await subscriberClient.ModifyPushConfigAsync(subscription, pushConfig);
            // End snippet
        }

        public void ModifyPushConfig()
        {
            // Snippet: ModifyPushConfig(SubscriptionName,PushConfig,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            PushConfig pushConfig = new PushConfig();
            // Make the request
            subscriberClient.ModifyPushConfig(subscription, pushConfig);
            // End snippet
        }

        public async Task ModifyPushConfigAsync_RequestObject()
        {
            // Snippet: ModifyPushConfigAsync(ModifyPushConfigRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            // Make the request
            await subscriberClient.ModifyPushConfigAsync(request);
            // End snippet
        }

        public void ModifyPushConfig_RequestObject()
        {
            // Snippet: ModifyPushConfig(ModifyPushConfigRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            // Make the request
            subscriberClient.ModifyPushConfig(request);
            // End snippet
        }

        public async Task ListSnapshotsAsync()
        {
            // Snippet: ListSnapshotsAsync(ProjectName,string,int?,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName project = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response =
                subscriberClient.ListSnapshotsAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Snapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListSnapshots()
        {
            // Snippet: ListSnapshots(ProjectName,string,int?,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            ProjectName project = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response =
                subscriberClient.ListSnapshots(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Snapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListSnapshotsAsync_RequestObject()
        {
            // Snippet: ListSnapshotsAsync(ListSnapshotsRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ProjectAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response =
                subscriberClient.ListSnapshotsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Snapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListSnapshots_RequestObject()
        {
            // Snippet: ListSnapshots(ListSnapshotsRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ProjectAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response =
                subscriberClient.ListSnapshots(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Snapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task CreateSnapshotAsync()
        {
            // Snippet: CreateSnapshotAsync(SnapshotName,SubscriptionName,CallSettings)
            // Additional: CreateSnapshotAsync(SnapshotName,SubscriptionName,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotName name = new SnapshotName("[PROJECT]", "[SNAPSHOT]");
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Snapshot response = await subscriberClient.CreateSnapshotAsync(name, subscription);
            // End snippet
        }

        public void CreateSnapshot()
        {
            // Snippet: CreateSnapshot(SnapshotName,SubscriptionName,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SnapshotName name = new SnapshotName("[PROJECT]", "[SNAPSHOT]");
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Snapshot response = subscriberClient.CreateSnapshot(name, subscription);
            // End snippet
        }

        public async Task CreateSnapshotAsync_RequestObject()
        {
            // Snippet: CreateSnapshotAsync(CreateSnapshotRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            Snapshot response = await subscriberClient.CreateSnapshotAsync(request);
            // End snippet
        }

        public void CreateSnapshot_RequestObject()
        {
            // Snippet: CreateSnapshot(CreateSnapshotRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            Snapshot response = subscriberClient.CreateSnapshot(request);
            // End snippet
        }

        public async Task UpdateSnapshotAsync_RequestObject()
        {
            // Snippet: UpdateSnapshotAsync(UpdateSnapshotRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSnapshotRequest request = new UpdateSnapshotRequest
            {
                Snapshot = new Snapshot(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Snapshot response = await subscriberClient.UpdateSnapshotAsync(request);
            // End snippet
        }

        public void UpdateSnapshot_RequestObject()
        {
            // Snippet: UpdateSnapshot(UpdateSnapshotRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            UpdateSnapshotRequest request = new UpdateSnapshotRequest
            {
                Snapshot = new Snapshot(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Snapshot response = subscriberClient.UpdateSnapshot(request);
            // End snippet
        }

        public async Task DeleteSnapshotAsync()
        {
            // Snippet: DeleteSnapshotAsync(SnapshotName,CallSettings)
            // Additional: DeleteSnapshotAsync(SnapshotName,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotName snapshot = new SnapshotName("[PROJECT]", "[SNAPSHOT]");
            // Make the request
            await subscriberClient.DeleteSnapshotAsync(snapshot);
            // End snippet
        }

        public void DeleteSnapshot()
        {
            // Snippet: DeleteSnapshot(SnapshotName,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SnapshotName snapshot = new SnapshotName("[PROJECT]", "[SNAPSHOT]");
            // Make the request
            subscriberClient.DeleteSnapshot(snapshot);
            // End snippet
        }

        public async Task DeleteSnapshotAsync_RequestObject()
        {
            // Snippet: DeleteSnapshotAsync(DeleteSnapshotRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
            };
            // Make the request
            await subscriberClient.DeleteSnapshotAsync(request);
            // End snippet
        }

        public void DeleteSnapshot_RequestObject()
        {
            // Snippet: DeleteSnapshot(DeleteSnapshotRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
            };
            // Make the request
            subscriberClient.DeleteSnapshot(request);
            // End snippet
        }

        public async Task SeekAsync_RequestObject()
        {
            // Snippet: SeekAsync(SeekRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            SeekRequest request = new SeekRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            SeekResponse response = await subscriberClient.SeekAsync(request);
            // End snippet
        }

        public void Seek_RequestObject()
        {
            // Snippet: Seek(SeekRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SeekRequest request = new SeekRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            SeekResponse response = subscriberClient.Seek(request);
            // End snippet
        }

        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string,Policy,CallSettings)
            // Additional: SetIamPolicyAsync(string,Policy,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = await subscriberClient.SetIamPolicyAsync(formattedResource, policy);
            // End snippet
        }

        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string,Policy,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = subscriberClient.SetIamPolicy(formattedResource, policy);
            // End snippet
        }

        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await subscriberClient.SetIamPolicyAsync(request);
            // End snippet
        }

        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = subscriberClient.SetIamPolicy(request);
            // End snippet
        }

        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string,CallSettings)
            // Additional: GetIamPolicyAsync(string,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            // Make the request
            Policy response = await subscriberClient.GetIamPolicyAsync(formattedResource);
            // End snippet
        }

        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            // Make the request
            Policy response = subscriberClient.GetIamPolicy(formattedResource);
            // End snippet
        }

        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString(),
            };
            // Make the request
            Policy response = await subscriberClient.GetIamPolicyAsync(request);
            // End snippet
        }

        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString(),
            };
            // Make the request
            Policy response = subscriberClient.GetIamPolicy(request);
            // End snippet
        }

        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string,IEnumerable<string>,CallSettings)
            // Additional: TestIamPermissionsAsync(string,IEnumerable<string>,CancellationToken)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = await subscriberClient.TestIamPermissionsAsync(formattedResource, permissions);
            // End snippet
        }

        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string,IEnumerable<string>,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = subscriberClient.TestIamPermissions(formattedResource, permissions);
            // End snippet
        }

        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = await SubscriberClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = await subscriberClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest,CallSettings)
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = subscriberClient.TestIamPermissions(request);
            // End snippet
        }

    }
}
