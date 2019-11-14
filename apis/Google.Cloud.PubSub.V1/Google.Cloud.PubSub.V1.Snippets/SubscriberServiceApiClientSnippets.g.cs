// Copyright 2019 Google LLC
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

namespace Google.Cloud.PubSub.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using apis = Google.Cloud.PubSub.V1;
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

    /// <summary>Generated snippets</summary>
    public class GeneratedSubscriberServiceApiClientSnippets
    {
        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionAsync()
        {
            // Snippet: CreateSubscriptionAsync(SubscriptionName,TopicName,PushConfig,int?,CallSettings)
            // Additional: CreateSubscriptionAsync(SubscriptionName,TopicName,PushConfig,int?,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName name = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 0;
            // Make the request
            Subscription response = await subscriberServiceApiClient.CreateSubscriptionAsync(name, topic, pushConfig, ackDeadlineSeconds);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscription()
        {
            // Snippet: CreateSubscription(SubscriptionName,TopicName,PushConfig,int?,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName name = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 0;
            // Make the request
            Subscription response = subscriberServiceApiClient.CreateSubscription(name, topic, pushConfig, ackDeadlineSeconds);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionAsync_RequestObject()
        {
            // Snippet: CreateSubscriptionAsync(Subscription,CallSettings)
            // Additional: CreateSubscriptionAsync(Subscription,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            Subscription request = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
            };
            // Make the request
            Subscription response = await subscriberServiceApiClient.CreateSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscription_RequestObject()
        {
            // Snippet: CreateSubscription(Subscription,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            Subscription request = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
            };
            // Make the request
            Subscription response = subscriberServiceApiClient.CreateSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for GetSubscriptionAsync</summary>
        public async Task GetSubscriptionAsync()
        {
            // Snippet: GetSubscriptionAsync(SubscriptionName,CallSettings)
            // Additional: GetSubscriptionAsync(SubscriptionName,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Subscription response = await subscriberServiceApiClient.GetSubscriptionAsync(subscription);
            // End snippet
        }

        /// <summary>Snippet for GetSubscription</summary>
        public void GetSubscription()
        {
            // Snippet: GetSubscription(SubscriptionName,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Subscription response = subscriberServiceApiClient.GetSubscription(subscription);
            // End snippet
        }

        /// <summary>Snippet for GetSubscriptionAsync</summary>
        public async Task GetSubscriptionAsync_RequestObject()
        {
            // Snippet: GetSubscriptionAsync(GetSubscriptionRequest,CallSettings)
            // Additional: GetSubscriptionAsync(GetSubscriptionRequest,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            Subscription response = await subscriberServiceApiClient.GetSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSubscription</summary>
        public void GetSubscription_RequestObject()
        {
            // Snippet: GetSubscription(GetSubscriptionRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            Subscription response = subscriberServiceApiClient.GetSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriptionAsync</summary>
        public async Task UpdateSubscriptionAsync_RequestObject()
        {
            // Snippet: UpdateSubscriptionAsync(UpdateSubscriptionRequest,CallSettings)
            // Additional: UpdateSubscriptionAsync(UpdateSubscriptionRequest,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription
                {
                    AckDeadlineSeconds = 42,
                },
                UpdateMask = new FieldMask
                {
                    Paths = {
                                "ack_deadline_seconds",
                            },
                },
            };
            // Make the request
            Subscription response = await subscriberServiceApiClient.UpdateSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscription</summary>
        public void UpdateSubscription_RequestObject()
        {
            // Snippet: UpdateSubscription(UpdateSubscriptionRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription
                {
                    AckDeadlineSeconds = 42,
                },
                UpdateMask = new FieldMask
                {
                    Paths = {
                                "ack_deadline_seconds",
                            },
                },
            };
            // Make the request
            Subscription response = subscriberServiceApiClient.UpdateSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptionsAsync</summary>
        public async Task ListSubscriptionsAsync()
        {
            // Snippet: ListSubscriptionsAsync(ProjectName,string,int?,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName project = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response =
                subscriberServiceApiClient.ListSubscriptionsAsync(project);

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

        /// <summary>Snippet for ListSubscriptions</summary>
        public void ListSubscriptions()
        {
            // Snippet: ListSubscriptions(ProjectName,string,int?,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            ProjectName project = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response =
                subscriberServiceApiClient.ListSubscriptions(project);

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

        /// <summary>Snippet for ListSubscriptionsAsync</summary>
        public async Task ListSubscriptionsAsync_RequestObject()
        {
            // Snippet: ListSubscriptionsAsync(ListSubscriptionsRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                ProjectAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response =
                subscriberServiceApiClient.ListSubscriptionsAsync(request);

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

        /// <summary>Snippet for ListSubscriptions</summary>
        public void ListSubscriptions_RequestObject()
        {
            // Snippet: ListSubscriptions(ListSubscriptionsRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                ProjectAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response =
                subscriberServiceApiClient.ListSubscriptions(request);

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

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionAsync()
        {
            // Snippet: DeleteSubscriptionAsync(SubscriptionName,CallSettings)
            // Additional: DeleteSubscriptionAsync(SubscriptionName,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            await subscriberServiceApiClient.DeleteSubscriptionAsync(subscription);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscription()
        {
            // Snippet: DeleteSubscription(SubscriptionName,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            subscriberServiceApiClient.DeleteSubscription(subscription);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionAsync_RequestObject()
        {
            // Snippet: DeleteSubscriptionAsync(DeleteSubscriptionRequest,CallSettings)
            // Additional: DeleteSubscriptionAsync(DeleteSubscriptionRequest,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            await subscriberServiceApiClient.DeleteSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscription_RequestObject()
        {
            // Snippet: DeleteSubscription(DeleteSubscriptionRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            subscriberServiceApiClient.DeleteSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyAckDeadlineAsync</summary>
        public async Task ModifyAckDeadlineAsync()
        {
            // Snippet: ModifyAckDeadlineAsync(SubscriptionName,IEnumerable<string>,int,CallSettings)
            // Additional: ModifyAckDeadlineAsync(SubscriptionName,IEnumerable<string>,int,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            int ackDeadlineSeconds = 0;
            // Make the request
            await subscriberServiceApiClient.ModifyAckDeadlineAsync(subscription, ackIds, ackDeadlineSeconds);
            // End snippet
        }

        /// <summary>Snippet for ModifyAckDeadline</summary>
        public void ModifyAckDeadline()
        {
            // Snippet: ModifyAckDeadline(SubscriptionName,IEnumerable<string>,int,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            int ackDeadlineSeconds = 0;
            // Make the request
            subscriberServiceApiClient.ModifyAckDeadline(subscription, ackIds, ackDeadlineSeconds);
            // End snippet
        }

        /// <summary>Snippet for ModifyAckDeadlineAsync</summary>
        public async Task ModifyAckDeadlineAsync_RequestObject()
        {
            // Snippet: ModifyAckDeadlineAsync(ModifyAckDeadlineRequest,CallSettings)
            // Additional: ModifyAckDeadlineAsync(ModifyAckDeadlineRequest,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
                AckDeadlineSeconds = 0,
            };
            // Make the request
            await subscriberServiceApiClient.ModifyAckDeadlineAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyAckDeadline</summary>
        public void ModifyAckDeadline_RequestObject()
        {
            // Snippet: ModifyAckDeadline(ModifyAckDeadlineRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
                AckDeadlineSeconds = 0,
            };
            // Make the request
            subscriberServiceApiClient.ModifyAckDeadline(request);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeAsync</summary>
        public async Task AcknowledgeAsync()
        {
            // Snippet: AcknowledgeAsync(SubscriptionName,IEnumerable<string>,CallSettings)
            // Additional: AcknowledgeAsync(SubscriptionName,IEnumerable<string>,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            // Make the request
            await subscriberServiceApiClient.AcknowledgeAsync(subscription, ackIds);
            // End snippet
        }

        /// <summary>Snippet for Acknowledge</summary>
        public void Acknowledge()
        {
            // Snippet: Acknowledge(SubscriptionName,IEnumerable<string>,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new List<string>();
            // Make the request
            subscriberServiceApiClient.Acknowledge(subscription, ackIds);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeAsync</summary>
        public async Task AcknowledgeAsync_RequestObject()
        {
            // Snippet: AcknowledgeAsync(AcknowledgeRequest,CallSettings)
            // Additional: AcknowledgeAsync(AcknowledgeRequest,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
            };
            // Make the request
            await subscriberServiceApiClient.AcknowledgeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Acknowledge</summary>
        public void Acknowledge_RequestObject()
        {
            // Snippet: Acknowledge(AcknowledgeRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { },
            };
            // Make the request
            subscriberServiceApiClient.Acknowledge(request);
            // End snippet
        }

        /// <summary>Snippet for PullAsync</summary>
        public async Task PullAsync()
        {
            // Snippet: PullAsync(SubscriptionName,bool?,int,CallSettings)
            // Additional: PullAsync(SubscriptionName,bool?,int,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            bool returnImmediately = false;
            int maxMessages = 0;
            // Make the request
            PullResponse response = await subscriberServiceApiClient.PullAsync(subscription, returnImmediately, maxMessages);
            // End snippet
        }

        /// <summary>Snippet for Pull</summary>
        public void Pull()
        {
            // Snippet: Pull(SubscriptionName,bool?,int,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            bool returnImmediately = false;
            int maxMessages = 0;
            // Make the request
            PullResponse response = subscriberServiceApiClient.Pull(subscription, returnImmediately, maxMessages);
            // End snippet
        }

        /// <summary>Snippet for PullAsync</summary>
        public async Task PullAsync_RequestObject()
        {
            // Snippet: PullAsync(PullRequest,CallSettings)
            // Additional: PullAsync(PullRequest,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                MaxMessages = 0,
            };
            // Make the request
            PullResponse response = await subscriberServiceApiClient.PullAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Pull</summary>
        public void Pull_RequestObject()
        {
            // Snippet: Pull(PullRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                MaxMessages = 0,
            };
            // Make the request
            PullResponse response = subscriberServiceApiClient.Pull(request);
            // End snippet
        }

        /// <summary>Snippet for StreamingPull</summary>
        public async Task StreamingPull()
        {
            // Snippet: StreamingPull(CallSettings,BidirectionalStreamingSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize streaming call, retrieving the stream object
            SubscriberServiceApiClient.StreamingPullStream duplexStream = subscriberServiceApiClient.StreamingPull();

            // Sending requests and retrieving responses can be arbitrarily interleaved.
            // Exact sequence will depend on client/server behavior.

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                AsyncResponseStream<StreamingPullResponse> responseStream = duplexStream.GetResponseStream();
                while (await responseStream.MoveNextAsync())
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

        /// <summary>Snippet for ModifyPushConfigAsync</summary>
        public async Task ModifyPushConfigAsync()
        {
            // Snippet: ModifyPushConfigAsync(SubscriptionName,PushConfig,CallSettings)
            // Additional: ModifyPushConfigAsync(SubscriptionName,PushConfig,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            PushConfig pushConfig = new PushConfig();
            // Make the request
            await subscriberServiceApiClient.ModifyPushConfigAsync(subscription, pushConfig);
            // End snippet
        }

        /// <summary>Snippet for ModifyPushConfig</summary>
        public void ModifyPushConfig()
        {
            // Snippet: ModifyPushConfig(SubscriptionName,PushConfig,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            PushConfig pushConfig = new PushConfig();
            // Make the request
            subscriberServiceApiClient.ModifyPushConfig(subscription, pushConfig);
            // End snippet
        }

        /// <summary>Snippet for ModifyPushConfigAsync</summary>
        public async Task ModifyPushConfigAsync_RequestObject()
        {
            // Snippet: ModifyPushConfigAsync(ModifyPushConfigRequest,CallSettings)
            // Additional: ModifyPushConfigAsync(ModifyPushConfigRequest,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            // Make the request
            await subscriberServiceApiClient.ModifyPushConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyPushConfig</summary>
        public void ModifyPushConfig_RequestObject()
        {
            // Snippet: ModifyPushConfig(ModifyPushConfigRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            // Make the request
            subscriberServiceApiClient.ModifyPushConfig(request);
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotsAsync</summary>
        public async Task ListSnapshotsAsync()
        {
            // Snippet: ListSnapshotsAsync(ProjectName,string,int?,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName project = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response =
                subscriberServiceApiClient.ListSnapshotsAsync(project);

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

        /// <summary>Snippet for ListSnapshots</summary>
        public void ListSnapshots()
        {
            // Snippet: ListSnapshots(ProjectName,string,int?,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            ProjectName project = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response =
                subscriberServiceApiClient.ListSnapshots(project);

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

        /// <summary>Snippet for ListSnapshotsAsync</summary>
        public async Task ListSnapshotsAsync_RequestObject()
        {
            // Snippet: ListSnapshotsAsync(ListSnapshotsRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ProjectAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response =
                subscriberServiceApiClient.ListSnapshotsAsync(request);

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

        /// <summary>Snippet for ListSnapshots</summary>
        public void ListSnapshots_RequestObject()
        {
            // Snippet: ListSnapshots(ListSnapshotsRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ProjectAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response =
                subscriberServiceApiClient.ListSnapshots(request);

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

        /// <summary>Snippet for CreateSnapshotAsync</summary>
        public async Task CreateSnapshotAsync()
        {
            // Snippet: CreateSnapshotAsync(SnapshotName,SubscriptionName,CallSettings)
            // Additional: CreateSnapshotAsync(SnapshotName,SubscriptionName,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotName name = new SnapshotName("[PROJECT]", "[SNAPSHOT]");
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Snapshot response = await subscriberServiceApiClient.CreateSnapshotAsync(name, subscription);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshot</summary>
        public void CreateSnapshot()
        {
            // Snippet: CreateSnapshot(SnapshotName,SubscriptionName,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SnapshotName name = new SnapshotName("[PROJECT]", "[SNAPSHOT]");
            SubscriptionName subscription = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Snapshot response = subscriberServiceApiClient.CreateSnapshot(name, subscription);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotAsync</summary>
        public async Task CreateSnapshotAsync_RequestObject()
        {
            // Snippet: CreateSnapshotAsync(CreateSnapshotRequest,CallSettings)
            // Additional: CreateSnapshotAsync(CreateSnapshotRequest,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            Snapshot response = await subscriberServiceApiClient.CreateSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshot</summary>
        public void CreateSnapshot_RequestObject()
        {
            // Snippet: CreateSnapshot(CreateSnapshotRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            Snapshot response = subscriberServiceApiClient.CreateSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSnapshotAsync</summary>
        public async Task UpdateSnapshotAsync_RequestObject()
        {
            // Snippet: UpdateSnapshotAsync(UpdateSnapshotRequest,CallSettings)
            // Additional: UpdateSnapshotAsync(UpdateSnapshotRequest,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSnapshotRequest request = new UpdateSnapshotRequest
            {
                Snapshot = new Snapshot
                {
                    ExpireTime = new Timestamp
                                 {
                                     Seconds = 123456L,
                                 },
                },
                UpdateMask = new FieldMask
                {
                    Paths = {
                                "expire_time",
                            },
                },
            };
            // Make the request
            Snapshot response = await subscriberServiceApiClient.UpdateSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSnapshot</summary>
        public void UpdateSnapshot_RequestObject()
        {
            // Snippet: UpdateSnapshot(UpdateSnapshotRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            UpdateSnapshotRequest request = new UpdateSnapshotRequest
            {
                Snapshot = new Snapshot
                {
                    ExpireTime = new Timestamp
                                 {
                                     Seconds = 123456L,
                                 },
                },
                UpdateMask = new FieldMask
                {
                    Paths = {
                                "expire_time",
                            },
                },
            };
            // Make the request
            Snapshot response = subscriberServiceApiClient.UpdateSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotAsync</summary>
        public async Task DeleteSnapshotAsync()
        {
            // Snippet: DeleteSnapshotAsync(SnapshotName,CallSettings)
            // Additional: DeleteSnapshotAsync(SnapshotName,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotName snapshot = new SnapshotName("[PROJECT]", "[SNAPSHOT]");
            // Make the request
            await subscriberServiceApiClient.DeleteSnapshotAsync(snapshot);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshot</summary>
        public void DeleteSnapshot()
        {
            // Snippet: DeleteSnapshot(SnapshotName,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SnapshotName snapshot = new SnapshotName("[PROJECT]", "[SNAPSHOT]");
            // Make the request
            subscriberServiceApiClient.DeleteSnapshot(snapshot);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotAsync</summary>
        public async Task DeleteSnapshotAsync_RequestObject()
        {
            // Snippet: DeleteSnapshotAsync(DeleteSnapshotRequest,CallSettings)
            // Additional: DeleteSnapshotAsync(DeleteSnapshotRequest,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
            };
            // Make the request
            await subscriberServiceApiClient.DeleteSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshot</summary>
        public void DeleteSnapshot_RequestObject()
        {
            // Snippet: DeleteSnapshot(DeleteSnapshotRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = new SnapshotName("[PROJECT]", "[SNAPSHOT]"),
            };
            // Make the request
            subscriberServiceApiClient.DeleteSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for SeekAsync</summary>
        public async Task SeekAsync_RequestObject()
        {
            // Snippet: SeekAsync(SeekRequest,CallSettings)
            // Additional: SeekAsync(SeekRequest,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SeekRequest request = new SeekRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            SeekResponse response = await subscriberServiceApiClient.SeekAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Seek</summary>
        public void Seek_RequestObject()
        {
            // Snippet: Seek(SeekRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SeekRequest request = new SeekRequest
            {
                SubscriptionAsSubscriptionName = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            SeekResponse response = subscriberServiceApiClient.Seek(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string,Policy,CallSettings)
            // Additional: SetIamPolicyAsync(string,Policy,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = await subscriberServiceApiClient.SetIamPolicyAsync(formattedResource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string,Policy,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = subscriberServiceApiClient.SetIamPolicy(formattedResource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest,CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await subscriberServiceApiClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = subscriberServiceApiClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string,CallSettings)
            // Additional: GetIamPolicyAsync(string,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            // Make the request
            Policy response = await subscriberServiceApiClient.GetIamPolicyAsync(formattedResource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            // Make the request
            Policy response = subscriberServiceApiClient.GetIamPolicy(formattedResource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest,CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString(),
            };
            // Make the request
            Policy response = await subscriberServiceApiClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString(),
            };
            // Make the request
            Policy response = subscriberServiceApiClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string,IEnumerable<string>,CallSettings)
            // Additional: TestIamPermissionsAsync(string,IEnumerable<string>,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = await subscriberServiceApiClient.TestIamPermissionsAsync(formattedResource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string,IEnumerable<string>,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string formattedResource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = subscriberServiceApiClient.TestIamPermissions(formattedResource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest,CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest,CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = await subscriberServiceApiClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest,CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new SubscriptionName("[PROJECT]", "[SUBSCRIPTION]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = subscriberServiceApiClient.TestIamPermissions(request);
            // End snippet
        }

    }
}
