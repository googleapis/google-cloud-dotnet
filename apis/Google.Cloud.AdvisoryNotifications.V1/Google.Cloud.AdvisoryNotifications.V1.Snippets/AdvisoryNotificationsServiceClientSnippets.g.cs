// Copyright 2023 Google LLC
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

namespace Google.Cloud.AdvisoryNotifications.V1.Snippets
{
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAdvisoryNotificationsServiceClientSnippets
    {
        /// <summary>Snippet for ListNotifications</summary>
        public void ListNotificationsRequestObject()
        {
            // Snippet: ListNotifications(ListNotificationsRequest, CallSettings)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = AdvisoryNotificationsServiceClient.Create();
            // Initialize request argument(s)
            ListNotificationsRequest request = new ListNotificationsRequest
            {
                ParentAsLocationName = LocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                View = NotificationView.Unspecified,
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<ListNotificationsResponse, Notification> response = advisoryNotificationsServiceClient.ListNotifications(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Notification item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Notification item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Notification> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Notification item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationsAsync</summary>
        public async Task ListNotificationsRequestObjectAsync()
        {
            // Snippet: ListNotificationsAsync(ListNotificationsRequest, CallSettings)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = await AdvisoryNotificationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNotificationsRequest request = new ListNotificationsRequest
            {
                ParentAsLocationName = LocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                View = NotificationView.Unspecified,
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListNotificationsResponse, Notification> response = advisoryNotificationsServiceClient.ListNotificationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Notification item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Notification item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Notification> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Notification item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotifications</summary>
        public void ListNotifications()
        {
            // Snippet: ListNotifications(string, string, int?, CallSettings)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = AdvisoryNotificationsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListNotificationsResponse, Notification> response = advisoryNotificationsServiceClient.ListNotifications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Notification item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Notification item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Notification> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Notification item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationsAsync</summary>
        public async Task ListNotificationsAsync()
        {
            // Snippet: ListNotificationsAsync(string, string, int?, CallSettings)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = await AdvisoryNotificationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListNotificationsResponse, Notification> response = advisoryNotificationsServiceClient.ListNotificationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Notification item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Notification item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Notification> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Notification item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotifications</summary>
        public void ListNotificationsResourceNames()
        {
            // Snippet: ListNotifications(LocationName, string, int?, CallSettings)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = AdvisoryNotificationsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNotificationsResponse, Notification> response = advisoryNotificationsServiceClient.ListNotifications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Notification item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Notification item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Notification> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Notification item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationsAsync</summary>
        public async Task ListNotificationsResourceNamesAsync()
        {
            // Snippet: ListNotificationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = await AdvisoryNotificationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNotificationsResponse, Notification> response = advisoryNotificationsServiceClient.ListNotificationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Notification item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Notification item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Notification> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Notification item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNotification</summary>
        public void GetNotificationRequestObject()
        {
            // Snippet: GetNotification(GetNotificationRequest, CallSettings)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = AdvisoryNotificationsServiceClient.Create();
            // Initialize request argument(s)
            GetNotificationRequest request = new GetNotificationRequest
            {
                NotificationName = NotificationName.FromOrganizationLocationNotification("[ORGANIZATION]", "[LOCATION]", "[NOTIFICATION]"),
                LanguageCode = "",
            };
            // Make the request
            Notification response = advisoryNotificationsServiceClient.GetNotification(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationAsync</summary>
        public async Task GetNotificationRequestObjectAsync()
        {
            // Snippet: GetNotificationAsync(GetNotificationRequest, CallSettings)
            // Additional: GetNotificationAsync(GetNotificationRequest, CancellationToken)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = await AdvisoryNotificationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNotificationRequest request = new GetNotificationRequest
            {
                NotificationName = NotificationName.FromOrganizationLocationNotification("[ORGANIZATION]", "[LOCATION]", "[NOTIFICATION]"),
                LanguageCode = "",
            };
            // Make the request
            Notification response = await advisoryNotificationsServiceClient.GetNotificationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotification</summary>
        public void GetNotification()
        {
            // Snippet: GetNotification(string, CallSettings)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = AdvisoryNotificationsServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/notifications/[NOTIFICATION]";
            // Make the request
            Notification response = advisoryNotificationsServiceClient.GetNotification(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationAsync</summary>
        public async Task GetNotificationAsync()
        {
            // Snippet: GetNotificationAsync(string, CallSettings)
            // Additional: GetNotificationAsync(string, CancellationToken)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = await AdvisoryNotificationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/notifications/[NOTIFICATION]";
            // Make the request
            Notification response = await advisoryNotificationsServiceClient.GetNotificationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotification</summary>
        public void GetNotificationResourceNames()
        {
            // Snippet: GetNotification(NotificationName, CallSettings)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = AdvisoryNotificationsServiceClient.Create();
            // Initialize request argument(s)
            NotificationName name = NotificationName.FromOrganizationLocationNotification("[ORGANIZATION]", "[LOCATION]", "[NOTIFICATION]");
            // Make the request
            Notification response = advisoryNotificationsServiceClient.GetNotification(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationAsync</summary>
        public async Task GetNotificationResourceNamesAsync()
        {
            // Snippet: GetNotificationAsync(NotificationName, CallSettings)
            // Additional: GetNotificationAsync(NotificationName, CancellationToken)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = await AdvisoryNotificationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationName name = NotificationName.FromOrganizationLocationNotification("[ORGANIZATION]", "[LOCATION]", "[NOTIFICATION]");
            // Make the request
            Notification response = await advisoryNotificationsServiceClient.GetNotificationAsync(name);
            // End snippet
        }
    }
}
