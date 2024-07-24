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
    using Google.Protobuf.WellKnownTypes;
    using Google.Shopping.Merchant.Notifications.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNotificationsApiServiceClientSnippets
    {
        /// <summary>Snippet for GetNotificationSubscription</summary>
        public void GetNotificationSubscriptionRequestObject()
        {
            // Snippet: GetNotificationSubscription(GetNotificationSubscriptionRequest, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = NotificationsApiServiceClient.Create();
            // Initialize request argument(s)
            GetNotificationSubscriptionRequest request = new GetNotificationSubscriptionRequest
            {
                NotificationSubscriptionName = NotificationSubscriptionName.FromAccountNotificationSubscription("[ACCOUNT]", "[NOTIFICATION_SUBSCRIPTION]"),
            };
            // Make the request
            NotificationSubscription response = notificationsApiServiceClient.GetNotificationSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationSubscriptionAsync</summary>
        public async Task GetNotificationSubscriptionRequestObjectAsync()
        {
            // Snippet: GetNotificationSubscriptionAsync(GetNotificationSubscriptionRequest, CallSettings)
            // Additional: GetNotificationSubscriptionAsync(GetNotificationSubscriptionRequest, CancellationToken)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = await NotificationsApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNotificationSubscriptionRequest request = new GetNotificationSubscriptionRequest
            {
                NotificationSubscriptionName = NotificationSubscriptionName.FromAccountNotificationSubscription("[ACCOUNT]", "[NOTIFICATION_SUBSCRIPTION]"),
            };
            // Make the request
            NotificationSubscription response = await notificationsApiServiceClient.GetNotificationSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationSubscription</summary>
        public void GetNotificationSubscription()
        {
            // Snippet: GetNotificationSubscription(string, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = NotificationsApiServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/notificationsubscriptions/[NOTIFICATION_SUBSCRIPTION]";
            // Make the request
            NotificationSubscription response = notificationsApiServiceClient.GetNotificationSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationSubscriptionAsync</summary>
        public async Task GetNotificationSubscriptionAsync()
        {
            // Snippet: GetNotificationSubscriptionAsync(string, CallSettings)
            // Additional: GetNotificationSubscriptionAsync(string, CancellationToken)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = await NotificationsApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/notificationsubscriptions/[NOTIFICATION_SUBSCRIPTION]";
            // Make the request
            NotificationSubscription response = await notificationsApiServiceClient.GetNotificationSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationSubscription</summary>
        public void GetNotificationSubscriptionResourceNames()
        {
            // Snippet: GetNotificationSubscription(NotificationSubscriptionName, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = NotificationsApiServiceClient.Create();
            // Initialize request argument(s)
            NotificationSubscriptionName name = NotificationSubscriptionName.FromAccountNotificationSubscription("[ACCOUNT]", "[NOTIFICATION_SUBSCRIPTION]");
            // Make the request
            NotificationSubscription response = notificationsApiServiceClient.GetNotificationSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationSubscriptionAsync</summary>
        public async Task GetNotificationSubscriptionResourceNamesAsync()
        {
            // Snippet: GetNotificationSubscriptionAsync(NotificationSubscriptionName, CallSettings)
            // Additional: GetNotificationSubscriptionAsync(NotificationSubscriptionName, CancellationToken)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = await NotificationsApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationSubscriptionName name = NotificationSubscriptionName.FromAccountNotificationSubscription("[ACCOUNT]", "[NOTIFICATION_SUBSCRIPTION]");
            // Make the request
            NotificationSubscription response = await notificationsApiServiceClient.GetNotificationSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationSubscription</summary>
        public void CreateNotificationSubscriptionRequestObject()
        {
            // Snippet: CreateNotificationSubscription(CreateNotificationSubscriptionRequest, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = NotificationsApiServiceClient.Create();
            // Initialize request argument(s)
            CreateNotificationSubscriptionRequest request = new CreateNotificationSubscriptionRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                NotificationSubscription = new NotificationSubscription(),
            };
            // Make the request
            NotificationSubscription response = notificationsApiServiceClient.CreateNotificationSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationSubscriptionAsync</summary>
        public async Task CreateNotificationSubscriptionRequestObjectAsync()
        {
            // Snippet: CreateNotificationSubscriptionAsync(CreateNotificationSubscriptionRequest, CallSettings)
            // Additional: CreateNotificationSubscriptionAsync(CreateNotificationSubscriptionRequest, CancellationToken)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = await NotificationsApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateNotificationSubscriptionRequest request = new CreateNotificationSubscriptionRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                NotificationSubscription = new NotificationSubscription(),
            };
            // Make the request
            NotificationSubscription response = await notificationsApiServiceClient.CreateNotificationSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationSubscription</summary>
        public void CreateNotificationSubscription()
        {
            // Snippet: CreateNotificationSubscription(string, NotificationSubscription, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = NotificationsApiServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            NotificationSubscription notificationSubscription = new NotificationSubscription();
            // Make the request
            NotificationSubscription response = notificationsApiServiceClient.CreateNotificationSubscription(parent, notificationSubscription);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationSubscriptionAsync</summary>
        public async Task CreateNotificationSubscriptionAsync()
        {
            // Snippet: CreateNotificationSubscriptionAsync(string, NotificationSubscription, CallSettings)
            // Additional: CreateNotificationSubscriptionAsync(string, NotificationSubscription, CancellationToken)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = await NotificationsApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            NotificationSubscription notificationSubscription = new NotificationSubscription();
            // Make the request
            NotificationSubscription response = await notificationsApiServiceClient.CreateNotificationSubscriptionAsync(parent, notificationSubscription);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationSubscription</summary>
        public void CreateNotificationSubscriptionResourceNames()
        {
            // Snippet: CreateNotificationSubscription(AccountName, NotificationSubscription, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = NotificationsApiServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            NotificationSubscription notificationSubscription = new NotificationSubscription();
            // Make the request
            NotificationSubscription response = notificationsApiServiceClient.CreateNotificationSubscription(parent, notificationSubscription);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationSubscriptionAsync</summary>
        public async Task CreateNotificationSubscriptionResourceNamesAsync()
        {
            // Snippet: CreateNotificationSubscriptionAsync(AccountName, NotificationSubscription, CallSettings)
            // Additional: CreateNotificationSubscriptionAsync(AccountName, NotificationSubscription, CancellationToken)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = await NotificationsApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            NotificationSubscription notificationSubscription = new NotificationSubscription();
            // Make the request
            NotificationSubscription response = await notificationsApiServiceClient.CreateNotificationSubscriptionAsync(parent, notificationSubscription);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationSubscription</summary>
        public void UpdateNotificationSubscriptionRequestObject()
        {
            // Snippet: UpdateNotificationSubscription(UpdateNotificationSubscriptionRequest, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = NotificationsApiServiceClient.Create();
            // Initialize request argument(s)
            UpdateNotificationSubscriptionRequest request = new UpdateNotificationSubscriptionRequest
            {
                NotificationSubscription = new NotificationSubscription(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            NotificationSubscription response = notificationsApiServiceClient.UpdateNotificationSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationSubscriptionAsync</summary>
        public async Task UpdateNotificationSubscriptionRequestObjectAsync()
        {
            // Snippet: UpdateNotificationSubscriptionAsync(UpdateNotificationSubscriptionRequest, CallSettings)
            // Additional: UpdateNotificationSubscriptionAsync(UpdateNotificationSubscriptionRequest, CancellationToken)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = await NotificationsApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNotificationSubscriptionRequest request = new UpdateNotificationSubscriptionRequest
            {
                NotificationSubscription = new NotificationSubscription(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            NotificationSubscription response = await notificationsApiServiceClient.UpdateNotificationSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationSubscription</summary>
        public void UpdateNotificationSubscription()
        {
            // Snippet: UpdateNotificationSubscription(NotificationSubscription, FieldMask, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = NotificationsApiServiceClient.Create();
            // Initialize request argument(s)
            NotificationSubscription notificationSubscription = new NotificationSubscription();
            FieldMask updateMask = new FieldMask();
            // Make the request
            NotificationSubscription response = notificationsApiServiceClient.UpdateNotificationSubscription(notificationSubscription, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationSubscriptionAsync</summary>
        public async Task UpdateNotificationSubscriptionAsync()
        {
            // Snippet: UpdateNotificationSubscriptionAsync(NotificationSubscription, FieldMask, CallSettings)
            // Additional: UpdateNotificationSubscriptionAsync(NotificationSubscription, FieldMask, CancellationToken)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = await NotificationsApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationSubscription notificationSubscription = new NotificationSubscription();
            FieldMask updateMask = new FieldMask();
            // Make the request
            NotificationSubscription response = await notificationsApiServiceClient.UpdateNotificationSubscriptionAsync(notificationSubscription, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationSubscription</summary>
        public void DeleteNotificationSubscriptionRequestObject()
        {
            // Snippet: DeleteNotificationSubscription(DeleteNotificationSubscriptionRequest, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = NotificationsApiServiceClient.Create();
            // Initialize request argument(s)
            DeleteNotificationSubscriptionRequest request = new DeleteNotificationSubscriptionRequest
            {
                NotificationSubscriptionName = NotificationSubscriptionName.FromAccountNotificationSubscription("[ACCOUNT]", "[NOTIFICATION_SUBSCRIPTION]"),
            };
            // Make the request
            notificationsApiServiceClient.DeleteNotificationSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationSubscriptionAsync</summary>
        public async Task DeleteNotificationSubscriptionRequestObjectAsync()
        {
            // Snippet: DeleteNotificationSubscriptionAsync(DeleteNotificationSubscriptionRequest, CallSettings)
            // Additional: DeleteNotificationSubscriptionAsync(DeleteNotificationSubscriptionRequest, CancellationToken)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = await NotificationsApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNotificationSubscriptionRequest request = new DeleteNotificationSubscriptionRequest
            {
                NotificationSubscriptionName = NotificationSubscriptionName.FromAccountNotificationSubscription("[ACCOUNT]", "[NOTIFICATION_SUBSCRIPTION]"),
            };
            // Make the request
            await notificationsApiServiceClient.DeleteNotificationSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationSubscription</summary>
        public void DeleteNotificationSubscription()
        {
            // Snippet: DeleteNotificationSubscription(string, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = NotificationsApiServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/notificationsubscriptions/[NOTIFICATION_SUBSCRIPTION]";
            // Make the request
            notificationsApiServiceClient.DeleteNotificationSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationSubscriptionAsync</summary>
        public async Task DeleteNotificationSubscriptionAsync()
        {
            // Snippet: DeleteNotificationSubscriptionAsync(string, CallSettings)
            // Additional: DeleteNotificationSubscriptionAsync(string, CancellationToken)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = await NotificationsApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/notificationsubscriptions/[NOTIFICATION_SUBSCRIPTION]";
            // Make the request
            await notificationsApiServiceClient.DeleteNotificationSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationSubscription</summary>
        public void DeleteNotificationSubscriptionResourceNames()
        {
            // Snippet: DeleteNotificationSubscription(NotificationSubscriptionName, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = NotificationsApiServiceClient.Create();
            // Initialize request argument(s)
            NotificationSubscriptionName name = NotificationSubscriptionName.FromAccountNotificationSubscription("[ACCOUNT]", "[NOTIFICATION_SUBSCRIPTION]");
            // Make the request
            notificationsApiServiceClient.DeleteNotificationSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationSubscriptionAsync</summary>
        public async Task DeleteNotificationSubscriptionResourceNamesAsync()
        {
            // Snippet: DeleteNotificationSubscriptionAsync(NotificationSubscriptionName, CallSettings)
            // Additional: DeleteNotificationSubscriptionAsync(NotificationSubscriptionName, CancellationToken)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = await NotificationsApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationSubscriptionName name = NotificationSubscriptionName.FromAccountNotificationSubscription("[ACCOUNT]", "[NOTIFICATION_SUBSCRIPTION]");
            // Make the request
            await notificationsApiServiceClient.DeleteNotificationSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNotificationSubscriptions</summary>
        public void ListNotificationSubscriptionsRequestObject()
        {
            // Snippet: ListNotificationSubscriptions(ListNotificationSubscriptionsRequest, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = NotificationsApiServiceClient.Create();
            // Initialize request argument(s)
            ListNotificationSubscriptionsRequest request = new ListNotificationSubscriptionsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListNotificationSubscriptionsResponse, NotificationSubscription> response = notificationsApiServiceClient.ListNotificationSubscriptions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationSubscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationSubscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationSubscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationSubscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationSubscriptionsAsync</summary>
        public async Task ListNotificationSubscriptionsRequestObjectAsync()
        {
            // Snippet: ListNotificationSubscriptionsAsync(ListNotificationSubscriptionsRequest, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = await NotificationsApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNotificationSubscriptionsRequest request = new ListNotificationSubscriptionsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNotificationSubscriptionsResponse, NotificationSubscription> response = notificationsApiServiceClient.ListNotificationSubscriptionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationSubscription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationSubscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationSubscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationSubscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationSubscriptions</summary>
        public void ListNotificationSubscriptions()
        {
            // Snippet: ListNotificationSubscriptions(string, string, int?, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = NotificationsApiServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListNotificationSubscriptionsResponse, NotificationSubscription> response = notificationsApiServiceClient.ListNotificationSubscriptions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationSubscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationSubscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationSubscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationSubscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationSubscriptionsAsync</summary>
        public async Task ListNotificationSubscriptionsAsync()
        {
            // Snippet: ListNotificationSubscriptionsAsync(string, string, int?, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = await NotificationsApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListNotificationSubscriptionsResponse, NotificationSubscription> response = notificationsApiServiceClient.ListNotificationSubscriptionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationSubscription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationSubscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationSubscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationSubscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationSubscriptions</summary>
        public void ListNotificationSubscriptionsResourceNames()
        {
            // Snippet: ListNotificationSubscriptions(AccountName, string, int?, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = NotificationsApiServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListNotificationSubscriptionsResponse, NotificationSubscription> response = notificationsApiServiceClient.ListNotificationSubscriptions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationSubscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationSubscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationSubscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationSubscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationSubscriptionsAsync</summary>
        public async Task ListNotificationSubscriptionsResourceNamesAsync()
        {
            // Snippet: ListNotificationSubscriptionsAsync(AccountName, string, int?, CallSettings)
            // Create client
            NotificationsApiServiceClient notificationsApiServiceClient = await NotificationsApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListNotificationSubscriptionsResponse, NotificationSubscription> response = notificationsApiServiceClient.ListNotificationSubscriptionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationSubscription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationSubscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationSubscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationSubscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
