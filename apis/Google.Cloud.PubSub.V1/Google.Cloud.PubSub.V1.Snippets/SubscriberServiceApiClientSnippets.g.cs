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
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.PubSub.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSubscriberServiceApiClientSnippets
    {
        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscriptionRequestObject()
        {
            // Snippet: CreateSubscription(Subscription, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            Subscription request = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = 0,
                RetainAckedMessages = false,
                MessageRetentionDuration = new Duration(),
                Labels = { { "", "" }, },
                EnableMessageOrdering = false,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new Duration(),
                BigqueryConfig = new BigQueryConfig(),
                State = Subscription.Types.State.Unspecified,
                CloudStorageConfig = new CloudStorageConfig(),
                AnalyticsHubSubscriptionInfo = new Subscription.Types.AnalyticsHubSubscriptionInfo(),
            };
            // Make the request
            Subscription response = subscriberServiceApiClient.CreateSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionRequestObjectAsync()
        {
            // Snippet: CreateSubscriptionAsync(Subscription, CallSettings)
            // Additional: CreateSubscriptionAsync(Subscription, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            Subscription request = new Subscription
            {
                SubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                PushConfig = new PushConfig(),
                AckDeadlineSeconds = 0,
                RetainAckedMessages = false,
                MessageRetentionDuration = new Duration(),
                Labels = { { "", "" }, },
                EnableMessageOrdering = false,
                ExpirationPolicy = new ExpirationPolicy(),
                Filter = "",
                DeadLetterPolicy = new DeadLetterPolicy(),
                RetryPolicy = new RetryPolicy(),
                Detached = false,
                EnableExactlyOnceDelivery = false,
                TopicMessageRetentionDuration = new Duration(),
                BigqueryConfig = new BigQueryConfig(),
                State = Subscription.Types.State.Unspecified,
                CloudStorageConfig = new CloudStorageConfig(),
                AnalyticsHubSubscriptionInfo = new Subscription.Types.AnalyticsHubSubscriptionInfo(),
            };
            // Make the request
            Subscription response = await subscriberServiceApiClient.CreateSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscription()
        {
            // Snippet: CreateSubscription(string, string, PushConfig, int, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            string topic = "projects/[PROJECT]/topics/[TOPIC]";
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 0;
            // Make the request
            Subscription response = subscriberServiceApiClient.CreateSubscription(name, topic, pushConfig, ackDeadlineSeconds);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionAsync()
        {
            // Snippet: CreateSubscriptionAsync(string, string, PushConfig, int, CallSettings)
            // Additional: CreateSubscriptionAsync(string, string, PushConfig, int, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            string topic = "projects/[PROJECT]/topics/[TOPIC]";
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 0;
            // Make the request
            Subscription response = await subscriberServiceApiClient.CreateSubscriptionAsync(name, topic, pushConfig, ackDeadlineSeconds);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscriptionResourceNames()
        {
            // Snippet: CreateSubscription(SubscriptionName, TopicName, PushConfig, int, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            TopicName topic = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 0;
            // Make the request
            Subscription response = subscriberServiceApiClient.CreateSubscription(name, topic, pushConfig, ackDeadlineSeconds);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionResourceNamesAsync()
        {
            // Snippet: CreateSubscriptionAsync(SubscriptionName, TopicName, PushConfig, int, CallSettings)
            // Additional: CreateSubscriptionAsync(SubscriptionName, TopicName, PushConfig, int, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            TopicName topic = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]");
            PushConfig pushConfig = new PushConfig();
            int ackDeadlineSeconds = 0;
            // Make the request
            Subscription response = await subscriberServiceApiClient.CreateSubscriptionAsync(name, topic, pushConfig, ackDeadlineSeconds);
            // End snippet
        }

        /// <summary>Snippet for GetSubscription</summary>
        public void GetSubscriptionRequestObject()
        {
            // Snippet: GetSubscription(GetSubscriptionRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            Subscription response = subscriberServiceApiClient.GetSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for GetSubscriptionAsync</summary>
        public async Task GetSubscriptionRequestObjectAsync()
        {
            // Snippet: GetSubscriptionAsync(GetSubscriptionRequest, CallSettings)
            // Additional: GetSubscriptionAsync(GetSubscriptionRequest, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            Subscription response = await subscriberServiceApiClient.GetSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSubscription</summary>
        public void GetSubscription()
        {
            // Snippet: GetSubscription(string, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            // Make the request
            Subscription response = subscriberServiceApiClient.GetSubscription(subscription);
            // End snippet
        }

        /// <summary>Snippet for GetSubscriptionAsync</summary>
        public async Task GetSubscriptionAsync()
        {
            // Snippet: GetSubscriptionAsync(string, CallSettings)
            // Additional: GetSubscriptionAsync(string, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            // Make the request
            Subscription response = await subscriberServiceApiClient.GetSubscriptionAsync(subscription);
            // End snippet
        }

        /// <summary>Snippet for GetSubscription</summary>
        public void GetSubscriptionResourceNames()
        {
            // Snippet: GetSubscription(SubscriptionName, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Subscription response = subscriberServiceApiClient.GetSubscription(subscription);
            // End snippet
        }

        /// <summary>Snippet for GetSubscriptionAsync</summary>
        public async Task GetSubscriptionResourceNamesAsync()
        {
            // Snippet: GetSubscriptionAsync(SubscriptionName, CallSettings)
            // Additional: GetSubscriptionAsync(SubscriptionName, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Subscription response = await subscriberServiceApiClient.GetSubscriptionAsync(subscription);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscription</summary>
        public void UpdateSubscriptionRequestObject()
        {
            // Snippet: UpdateSubscription(UpdateSubscriptionRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Subscription response = subscriberServiceApiClient.UpdateSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriptionAsync</summary>
        public async Task UpdateSubscriptionRequestObjectAsync()
        {
            // Snippet: UpdateSubscriptionAsync(UpdateSubscriptionRequest, CallSettings)
            // Additional: UpdateSubscriptionAsync(UpdateSubscriptionRequest, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Subscription response = await subscriberServiceApiClient.UpdateSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscription</summary>
        public void UpdateSubscription()
        {
            // Snippet: UpdateSubscription(Subscription, FieldMask, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            Subscription subscription = new Subscription();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Subscription response = subscriberServiceApiClient.UpdateSubscription(subscription, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriptionAsync</summary>
        public async Task UpdateSubscriptionAsync()
        {
            // Snippet: UpdateSubscriptionAsync(Subscription, FieldMask, CallSettings)
            // Additional: UpdateSubscriptionAsync(Subscription, FieldMask, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            Subscription subscription = new Subscription();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Subscription response = await subscriberServiceApiClient.UpdateSubscriptionAsync(subscription, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptions</summary>
        public void ListSubscriptionsRequestObject()
        {
            // Snippet: ListSubscriptions(ListSubscriptionsRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response = subscriberServiceApiClient.ListSubscriptions(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptionsAsync</summary>
        public async Task ListSubscriptionsRequestObjectAsync()
        {
            // Snippet: ListSubscriptionsAsync(ListSubscriptionsRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response = subscriberServiceApiClient.ListSubscriptionsAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptions</summary>
        public void ListSubscriptions()
        {
            // Snippet: ListSubscriptions(string, string, int?, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string project = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response = subscriberServiceApiClient.ListSubscriptions(project);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptionsAsync</summary>
        public async Task ListSubscriptionsAsync()
        {
            // Snippet: ListSubscriptionsAsync(string, string, int?, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string project = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response = subscriberServiceApiClient.ListSubscriptionsAsync(project);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptions</summary>
        public void ListSubscriptionsResourceNames()
        {
            // Snippet: ListSubscriptions(ProjectName, string, int?, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response = subscriberServiceApiClient.ListSubscriptions(project);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptionsAsync</summary>
        public async Task ListSubscriptionsResourceNamesAsync()
        {
            // Snippet: ListSubscriptionsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response = subscriberServiceApiClient.ListSubscriptionsAsync(project);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscriptionRequestObject()
        {
            // Snippet: DeleteSubscription(DeleteSubscriptionRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            subscriberServiceApiClient.DeleteSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionRequestObjectAsync()
        {
            // Snippet: DeleteSubscriptionAsync(DeleteSubscriptionRequest, CallSettings)
            // Additional: DeleteSubscriptionAsync(DeleteSubscriptionRequest, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            await subscriberServiceApiClient.DeleteSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscription()
        {
            // Snippet: DeleteSubscription(string, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            // Make the request
            subscriberServiceApiClient.DeleteSubscription(subscription);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionAsync()
        {
            // Snippet: DeleteSubscriptionAsync(string, CallSettings)
            // Additional: DeleteSubscriptionAsync(string, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            // Make the request
            await subscriberServiceApiClient.DeleteSubscriptionAsync(subscription);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscriptionResourceNames()
        {
            // Snippet: DeleteSubscription(SubscriptionName, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            subscriberServiceApiClient.DeleteSubscription(subscription);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionResourceNamesAsync()
        {
            // Snippet: DeleteSubscriptionAsync(SubscriptionName, CallSettings)
            // Additional: DeleteSubscriptionAsync(SubscriptionName, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            await subscriberServiceApiClient.DeleteSubscriptionAsync(subscription);
            // End snippet
        }

        /// <summary>Snippet for ModifyAckDeadline</summary>
        public void ModifyAckDeadlineRequestObject()
        {
            // Snippet: ModifyAckDeadline(ModifyAckDeadlineRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckDeadlineSeconds = 0,
                AckIds = { "", },
            };
            // Make the request
            subscriberServiceApiClient.ModifyAckDeadline(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyAckDeadlineAsync</summary>
        public async Task ModifyAckDeadlineRequestObjectAsync()
        {
            // Snippet: ModifyAckDeadlineAsync(ModifyAckDeadlineRequest, CallSettings)
            // Additional: ModifyAckDeadlineAsync(ModifyAckDeadlineRequest, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckDeadlineSeconds = 0,
                AckIds = { "", },
            };
            // Make the request
            await subscriberServiceApiClient.ModifyAckDeadlineAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyAckDeadline</summary>
        public void ModifyAckDeadline()
        {
            // Snippet: ModifyAckDeadline(string, IEnumerable<string>, int, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            IEnumerable<string> ackIds = new string[] { "", };
            int ackDeadlineSeconds = 0;
            // Make the request
            subscriberServiceApiClient.ModifyAckDeadline(subscription, ackIds, ackDeadlineSeconds);
            // End snippet
        }

        /// <summary>Snippet for ModifyAckDeadlineAsync</summary>
        public async Task ModifyAckDeadlineAsync()
        {
            // Snippet: ModifyAckDeadlineAsync(string, IEnumerable<string>, int, CallSettings)
            // Additional: ModifyAckDeadlineAsync(string, IEnumerable<string>, int, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            IEnumerable<string> ackIds = new string[] { "", };
            int ackDeadlineSeconds = 0;
            // Make the request
            await subscriberServiceApiClient.ModifyAckDeadlineAsync(subscription, ackIds, ackDeadlineSeconds);
            // End snippet
        }

        /// <summary>Snippet for ModifyAckDeadline</summary>
        public void ModifyAckDeadlineResourceNames()
        {
            // Snippet: ModifyAckDeadline(SubscriptionName, IEnumerable<string>, int, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new string[] { "", };
            int ackDeadlineSeconds = 0;
            // Make the request
            subscriberServiceApiClient.ModifyAckDeadline(subscription, ackIds, ackDeadlineSeconds);
            // End snippet
        }

        /// <summary>Snippet for ModifyAckDeadlineAsync</summary>
        public async Task ModifyAckDeadlineResourceNamesAsync()
        {
            // Snippet: ModifyAckDeadlineAsync(SubscriptionName, IEnumerable<string>, int, CallSettings)
            // Additional: ModifyAckDeadlineAsync(SubscriptionName, IEnumerable<string>, int, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new string[] { "", };
            int ackDeadlineSeconds = 0;
            // Make the request
            await subscriberServiceApiClient.ModifyAckDeadlineAsync(subscription, ackIds, ackDeadlineSeconds);
            // End snippet
        }

        /// <summary>Snippet for Acknowledge</summary>
        public void AcknowledgeRequestObject()
        {
            // Snippet: Acknowledge(AcknowledgeRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { "", },
            };
            // Make the request
            subscriberServiceApiClient.Acknowledge(request);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeAsync</summary>
        public async Task AcknowledgeRequestObjectAsync()
        {
            // Snippet: AcknowledgeAsync(AcknowledgeRequest, CallSettings)
            // Additional: AcknowledgeAsync(AcknowledgeRequest, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                AckIds = { "", },
            };
            // Make the request
            await subscriberServiceApiClient.AcknowledgeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Acknowledge</summary>
        public void Acknowledge()
        {
            // Snippet: Acknowledge(string, IEnumerable<string>, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            IEnumerable<string> ackIds = new string[] { "", };
            // Make the request
            subscriberServiceApiClient.Acknowledge(subscription, ackIds);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeAsync</summary>
        public async Task AcknowledgeAsync()
        {
            // Snippet: AcknowledgeAsync(string, IEnumerable<string>, CallSettings)
            // Additional: AcknowledgeAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            IEnumerable<string> ackIds = new string[] { "", };
            // Make the request
            await subscriberServiceApiClient.AcknowledgeAsync(subscription, ackIds);
            // End snippet
        }

        /// <summary>Snippet for Acknowledge</summary>
        public void AcknowledgeResourceNames()
        {
            // Snippet: Acknowledge(SubscriptionName, IEnumerable<string>, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new string[] { "", };
            // Make the request
            subscriberServiceApiClient.Acknowledge(subscription, ackIds);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeAsync</summary>
        public async Task AcknowledgeResourceNamesAsync()
        {
            // Snippet: AcknowledgeAsync(SubscriptionName, IEnumerable<string>, CallSettings)
            // Additional: AcknowledgeAsync(SubscriptionName, IEnumerable<string>, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            IEnumerable<string> ackIds = new string[] { "", };
            // Make the request
            await subscriberServiceApiClient.AcknowledgeAsync(subscription, ackIds);
            // End snippet
        }

        /// <summary>Snippet for Pull</summary>
        public void PullRequestObject()
        {
            // Snippet: Pull(PullRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                MaxMessages = 0,
            };
            // Make the request
            PullResponse response = subscriberServiceApiClient.Pull(request);
            // End snippet
        }

        /// <summary>Snippet for PullAsync</summary>
        public async Task PullRequestObjectAsync()
        {
            // Snippet: PullAsync(PullRequest, CallSettings)
            // Additional: PullAsync(PullRequest, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            PullRequest request = new PullRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                MaxMessages = 0,
            };
            // Make the request
            PullResponse response = await subscriberServiceApiClient.PullAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Pull</summary>
        public void Pull1()
        {
            // Snippet: Pull(string, bool, int, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            bool returnImmediately = false;
            int maxMessages = 0;
            // Make the request
#pragma warning disable CS0612
            PullResponse response = subscriberServiceApiClient.Pull(subscription, returnImmediately, maxMessages);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for PullAsync</summary>
        public async Task Pull1Async()
        {
            // Snippet: PullAsync(string, bool, int, CallSettings)
            // Additional: PullAsync(string, bool, int, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            bool returnImmediately = false;
            int maxMessages = 0;
            // Make the request
#pragma warning disable CS0612
            PullResponse response = await subscriberServiceApiClient.PullAsync(subscription, returnImmediately, maxMessages);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for Pull</summary>
        public void Pull1ResourceNames()
        {
            // Snippet: Pull(SubscriptionName, bool, int, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            bool returnImmediately = false;
            int maxMessages = 0;
            // Make the request
#pragma warning disable CS0612
            PullResponse response = subscriberServiceApiClient.Pull(subscription, returnImmediately, maxMessages);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for PullAsync</summary>
        public async Task Pull1ResourceNamesAsync()
        {
            // Snippet: PullAsync(SubscriptionName, bool, int, CallSettings)
            // Additional: PullAsync(SubscriptionName, bool, int, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            bool returnImmediately = false;
            int maxMessages = 0;
            // Make the request
#pragma warning disable CS0612
            PullResponse response = await subscriberServiceApiClient.PullAsync(subscription, returnImmediately, maxMessages);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for Pull</summary>
        public void Pull2()
        {
            // Snippet: Pull(string, int, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            int maxMessages = 0;
            // Make the request
            PullResponse response = subscriberServiceApiClient.Pull(subscription, maxMessages);
            // End snippet
        }

        /// <summary>Snippet for PullAsync</summary>
        public async Task Pull2Async()
        {
            // Snippet: PullAsync(string, int, CallSettings)
            // Additional: PullAsync(string, int, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            int maxMessages = 0;
            // Make the request
            PullResponse response = await subscriberServiceApiClient.PullAsync(subscription, maxMessages);
            // End snippet
        }

        /// <summary>Snippet for Pull</summary>
        public void Pull2ResourceNames()
        {
            // Snippet: Pull(SubscriptionName, int, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            int maxMessages = 0;
            // Make the request
            PullResponse response = subscriberServiceApiClient.Pull(subscription, maxMessages);
            // End snippet
        }

        /// <summary>Snippet for PullAsync</summary>
        public async Task Pull2ResourceNamesAsync()
        {
            // Snippet: PullAsync(SubscriptionName, int, CallSettings)
            // Additional: PullAsync(SubscriptionName, int, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            int maxMessages = 0;
            // Make the request
            PullResponse response = await subscriberServiceApiClient.PullAsync(subscription, maxMessages);
            // End snippet
        }

        /// <summary>Snippet for StreamingPull</summary>
        public async Task StreamingPull()
        {
            // Snippet: StreamingPull(CallSettings, BidirectionalStreamingSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize streaming call, retrieving the stream object
            using SubscriberServiceApiClient.StreamingPullStream response = subscriberServiceApiClient.StreamingPull();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<StreamingPullResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    StreamingPullResponse responseItem = responseStream.Current;
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
                    SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                    AckIds = { "", },
                    ModifyDeadlineSeconds = { 0, },
                    ModifyDeadlineAckIds = { "", },
                    StreamAckDeadlineSeconds = 0,
                    ClientId = "",
                    MaxOutstandingMessages = 0L,
                    MaxOutstandingBytes = 0L,
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for ModifyPushConfig</summary>
        public void ModifyPushConfigRequestObject()
        {
            // Snippet: ModifyPushConfig(ModifyPushConfigRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            // Make the request
            subscriberServiceApiClient.ModifyPushConfig(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyPushConfigAsync</summary>
        public async Task ModifyPushConfigRequestObjectAsync()
        {
            // Snippet: ModifyPushConfigAsync(ModifyPushConfigRequest, CallSettings)
            // Additional: ModifyPushConfigAsync(ModifyPushConfigRequest, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                PushConfig = new PushConfig(),
            };
            // Make the request
            await subscriberServiceApiClient.ModifyPushConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyPushConfig</summary>
        public void ModifyPushConfig()
        {
            // Snippet: ModifyPushConfig(string, PushConfig, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            PushConfig pushConfig = new PushConfig();
            // Make the request
            subscriberServiceApiClient.ModifyPushConfig(subscription, pushConfig);
            // End snippet
        }

        /// <summary>Snippet for ModifyPushConfigAsync</summary>
        public async Task ModifyPushConfigAsync()
        {
            // Snippet: ModifyPushConfigAsync(string, PushConfig, CallSettings)
            // Additional: ModifyPushConfigAsync(string, PushConfig, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            PushConfig pushConfig = new PushConfig();
            // Make the request
            await subscriberServiceApiClient.ModifyPushConfigAsync(subscription, pushConfig);
            // End snippet
        }

        /// <summary>Snippet for ModifyPushConfig</summary>
        public void ModifyPushConfigResourceNames()
        {
            // Snippet: ModifyPushConfig(SubscriptionName, PushConfig, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            PushConfig pushConfig = new PushConfig();
            // Make the request
            subscriberServiceApiClient.ModifyPushConfig(subscription, pushConfig);
            // End snippet
        }

        /// <summary>Snippet for ModifyPushConfigAsync</summary>
        public async Task ModifyPushConfigResourceNamesAsync()
        {
            // Snippet: ModifyPushConfigAsync(SubscriptionName, PushConfig, CallSettings)
            // Additional: ModifyPushConfigAsync(SubscriptionName, PushConfig, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            PushConfig pushConfig = new PushConfig();
            // Make the request
            await subscriberServiceApiClient.ModifyPushConfigAsync(subscription, pushConfig);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshot</summary>
        public void GetSnapshotRequestObject()
        {
            // Snippet: GetSnapshot(GetSnapshotRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            // Make the request
            Snapshot response = subscriberServiceApiClient.GetSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotAsync</summary>
        public async Task GetSnapshotRequestObjectAsync()
        {
            // Snippet: GetSnapshotAsync(GetSnapshotRequest, CallSettings)
            // Additional: GetSnapshotAsync(GetSnapshotRequest, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            // Make the request
            Snapshot response = await subscriberServiceApiClient.GetSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshot</summary>
        public void GetSnapshot()
        {
            // Snippet: GetSnapshot(string, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string snapshot = "projects/[PROJECT]/snapshots/[SNAPSHOT]";
            // Make the request
            Snapshot response = subscriberServiceApiClient.GetSnapshot(snapshot);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotAsync</summary>
        public async Task GetSnapshotAsync()
        {
            // Snippet: GetSnapshotAsync(string, CallSettings)
            // Additional: GetSnapshotAsync(string, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string snapshot = "projects/[PROJECT]/snapshots/[SNAPSHOT]";
            // Make the request
            Snapshot response = await subscriberServiceApiClient.GetSnapshotAsync(snapshot);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshot</summary>
        public void GetSnapshotResourceNames()
        {
            // Snippet: GetSnapshot(SnapshotName, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SnapshotName snapshot = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]");
            // Make the request
            Snapshot response = subscriberServiceApiClient.GetSnapshot(snapshot);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotAsync</summary>
        public async Task GetSnapshotResourceNamesAsync()
        {
            // Snippet: GetSnapshotAsync(SnapshotName, CallSettings)
            // Additional: GetSnapshotAsync(SnapshotName, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotName snapshot = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]");
            // Make the request
            Snapshot response = await subscriberServiceApiClient.GetSnapshotAsync(snapshot);
            // End snippet
        }

        /// <summary>Snippet for ListSnapshots</summary>
        public void ListSnapshotsRequestObject()
        {
            // Snippet: ListSnapshots(ListSnapshotsRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response = subscriberServiceApiClient.ListSnapshots(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotsAsync</summary>
        public async Task ListSnapshotsRequestObjectAsync()
        {
            // Snippet: ListSnapshotsAsync(ListSnapshotsRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response = subscriberServiceApiClient.ListSnapshotsAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshots</summary>
        public void ListSnapshots()
        {
            // Snippet: ListSnapshots(string, string, int?, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string project = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response = subscriberServiceApiClient.ListSnapshots(project);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotsAsync</summary>
        public async Task ListSnapshotsAsync()
        {
            // Snippet: ListSnapshotsAsync(string, string, int?, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string project = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response = subscriberServiceApiClient.ListSnapshotsAsync(project);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshots</summary>
        public void ListSnapshotsResourceNames()
        {
            // Snippet: ListSnapshots(ProjectName, string, int?, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response = subscriberServiceApiClient.ListSnapshots(project);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotsAsync</summary>
        public async Task ListSnapshotsResourceNamesAsync()
        {
            // Snippet: ListSnapshotsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response = subscriberServiceApiClient.ListSnapshotsAsync(project);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshot</summary>
        public void CreateSnapshotRequestObject()
        {
            // Snippet: CreateSnapshot(CreateSnapshotRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                Labels = { { "", "" }, },
            };
            // Make the request
            Snapshot response = subscriberServiceApiClient.CreateSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotAsync</summary>
        public async Task CreateSnapshotRequestObjectAsync()
        {
            // Snippet: CreateSnapshotAsync(CreateSnapshotRequest, CallSettings)
            // Additional: CreateSnapshotAsync(CreateSnapshotRequest, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                Labels = { { "", "" }, },
            };
            // Make the request
            Snapshot response = await subscriberServiceApiClient.CreateSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshot</summary>
        public void CreateSnapshot()
        {
            // Snippet: CreateSnapshot(string, string, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/snapshots/[SNAPSHOT]";
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            // Make the request
            Snapshot response = subscriberServiceApiClient.CreateSnapshot(name, subscription);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotAsync</summary>
        public async Task CreateSnapshotAsync()
        {
            // Snippet: CreateSnapshotAsync(string, string, CallSettings)
            // Additional: CreateSnapshotAsync(string, string, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/snapshots/[SNAPSHOT]";
            string subscription = "projects/[PROJECT]/subscriptions/[SUBSCRIPTION]";
            // Make the request
            Snapshot response = await subscriberServiceApiClient.CreateSnapshotAsync(name, subscription);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshot</summary>
        public void CreateSnapshotResourceNames()
        {
            // Snippet: CreateSnapshot(SnapshotName, SubscriptionName, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SnapshotName name = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]");
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Snapshot response = subscriberServiceApiClient.CreateSnapshot(name, subscription);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotAsync</summary>
        public async Task CreateSnapshotResourceNamesAsync()
        {
            // Snippet: CreateSnapshotAsync(SnapshotName, SubscriptionName, CallSettings)
            // Additional: CreateSnapshotAsync(SnapshotName, SubscriptionName, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotName name = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]");
            SubscriptionName subscription = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]");
            // Make the request
            Snapshot response = await subscriberServiceApiClient.CreateSnapshotAsync(name, subscription);
            // End snippet
        }

        /// <summary>Snippet for UpdateSnapshot</summary>
        public void UpdateSnapshotRequestObject()
        {
            // Snippet: UpdateSnapshot(UpdateSnapshotRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            UpdateSnapshotRequest request = new UpdateSnapshotRequest
            {
                Snapshot = new Snapshot(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Snapshot response = subscriberServiceApiClient.UpdateSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSnapshotAsync</summary>
        public async Task UpdateSnapshotRequestObjectAsync()
        {
            // Snippet: UpdateSnapshotAsync(UpdateSnapshotRequest, CallSettings)
            // Additional: UpdateSnapshotAsync(UpdateSnapshotRequest, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSnapshotRequest request = new UpdateSnapshotRequest
            {
                Snapshot = new Snapshot(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Snapshot response = await subscriberServiceApiClient.UpdateSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSnapshot</summary>
        public void UpdateSnapshot()
        {
            // Snippet: UpdateSnapshot(Snapshot, FieldMask, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            Snapshot snapshot = new Snapshot();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Snapshot response = subscriberServiceApiClient.UpdateSnapshot(snapshot, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSnapshotAsync</summary>
        public async Task UpdateSnapshotAsync()
        {
            // Snippet: UpdateSnapshotAsync(Snapshot, FieldMask, CallSettings)
            // Additional: UpdateSnapshotAsync(Snapshot, FieldMask, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            Snapshot snapshot = new Snapshot();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Snapshot response = await subscriberServiceApiClient.UpdateSnapshotAsync(snapshot, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshot</summary>
        public void DeleteSnapshotRequestObject()
        {
            // Snippet: DeleteSnapshot(DeleteSnapshotRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            // Make the request
            subscriberServiceApiClient.DeleteSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotAsync</summary>
        public async Task DeleteSnapshotRequestObjectAsync()
        {
            // Snippet: DeleteSnapshotAsync(DeleteSnapshotRequest, CallSettings)
            // Additional: DeleteSnapshotAsync(DeleteSnapshotRequest, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotAsSnapshotName = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]"),
            };
            // Make the request
            await subscriberServiceApiClient.DeleteSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshot</summary>
        public void DeleteSnapshot()
        {
            // Snippet: DeleteSnapshot(string, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            string snapshot = "projects/[PROJECT]/snapshots/[SNAPSHOT]";
            // Make the request
            subscriberServiceApiClient.DeleteSnapshot(snapshot);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotAsync</summary>
        public async Task DeleteSnapshotAsync()
        {
            // Snippet: DeleteSnapshotAsync(string, CallSettings)
            // Additional: DeleteSnapshotAsync(string, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string snapshot = "projects/[PROJECT]/snapshots/[SNAPSHOT]";
            // Make the request
            await subscriberServiceApiClient.DeleteSnapshotAsync(snapshot);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshot</summary>
        public void DeleteSnapshotResourceNames()
        {
            // Snippet: DeleteSnapshot(SnapshotName, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SnapshotName snapshot = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]");
            // Make the request
            subscriberServiceApiClient.DeleteSnapshot(snapshot);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotAsync</summary>
        public async Task DeleteSnapshotResourceNamesAsync()
        {
            // Snippet: DeleteSnapshotAsync(SnapshotName, CallSettings)
            // Additional: DeleteSnapshotAsync(SnapshotName, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotName snapshot = SnapshotName.FromProjectSnapshot("[PROJECT]", "[SNAPSHOT]");
            // Make the request
            await subscriberServiceApiClient.DeleteSnapshotAsync(snapshot);
            // End snippet
        }

        /// <summary>Snippet for Seek</summary>
        public void SeekRequestObject()
        {
            // Snippet: Seek(SeekRequest, CallSettings)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = SubscriberServiceApiClient.Create();
            // Initialize request argument(s)
            SeekRequest request = new SeekRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                Time = new Timestamp(),
            };
            // Make the request
            SeekResponse response = subscriberServiceApiClient.Seek(request);
            // End snippet
        }

        /// <summary>Snippet for SeekAsync</summary>
        public async Task SeekRequestObjectAsync()
        {
            // Snippet: SeekAsync(SeekRequest, CallSettings)
            // Additional: SeekAsync(SeekRequest, CancellationToken)
            // Create client
            SubscriberServiceApiClient subscriberServiceApiClient = await SubscriberServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SeekRequest request = new SeekRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                Time = new Timestamp(),
            };
            // Make the request
            SeekResponse response = await subscriberServiceApiClient.SeekAsync(request);
            // End snippet
        }
    }
}
