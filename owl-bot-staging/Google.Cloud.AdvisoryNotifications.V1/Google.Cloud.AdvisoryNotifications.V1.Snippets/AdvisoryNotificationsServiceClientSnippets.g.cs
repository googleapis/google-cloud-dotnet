// Copyright 2025 Google LLC
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
    using Google.Cloud.AdvisoryNotifications.V1;
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

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettingsRequestObject()
        {
            // Snippet: GetSettings(GetSettingsRequest, CallSettings)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = AdvisoryNotificationsServiceClient.Create();
            // Initialize request argument(s)
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            Settings response = advisoryNotificationsServiceClient.GetSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsRequestObjectAsync()
        {
            // Snippet: GetSettingsAsync(GetSettingsRequest, CallSettings)
            // Additional: GetSettingsAsync(GetSettingsRequest, CancellationToken)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = await AdvisoryNotificationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            Settings response = await advisoryNotificationsServiceClient.GetSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettings()
        {
            // Snippet: GetSettings(string, CallSettings)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = AdvisoryNotificationsServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/settings";
            // Make the request
            Settings response = advisoryNotificationsServiceClient.GetSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsAsync()
        {
            // Snippet: GetSettingsAsync(string, CallSettings)
            // Additional: GetSettingsAsync(string, CancellationToken)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = await AdvisoryNotificationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/settings";
            // Make the request
            Settings response = await advisoryNotificationsServiceClient.GetSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettingsResourceNames()
        {
            // Snippet: GetSettings(SettingsName, CallSettings)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = AdvisoryNotificationsServiceClient.Create();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            Settings response = advisoryNotificationsServiceClient.GetSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsResourceNamesAsync()
        {
            // Snippet: GetSettingsAsync(SettingsName, CallSettings)
            // Additional: GetSettingsAsync(SettingsName, CancellationToken)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = await AdvisoryNotificationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            Settings response = await advisoryNotificationsServiceClient.GetSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettings</summary>
        public void UpdateSettingsRequestObject()
        {
            // Snippet: UpdateSettings(UpdateSettingsRequest, CallSettings)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = AdvisoryNotificationsServiceClient.Create();
            // Initialize request argument(s)
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
            };
            // Make the request
            Settings response = advisoryNotificationsServiceClient.UpdateSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettingsAsync</summary>
        public async Task UpdateSettingsRequestObjectAsync()
        {
            // Snippet: UpdateSettingsAsync(UpdateSettingsRequest, CallSettings)
            // Additional: UpdateSettingsAsync(UpdateSettingsRequest, CancellationToken)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = await AdvisoryNotificationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
            };
            // Make the request
            Settings response = await advisoryNotificationsServiceClient.UpdateSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettings</summary>
        public void UpdateSettings()
        {
            // Snippet: UpdateSettings(Settings, CallSettings)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = AdvisoryNotificationsServiceClient.Create();
            // Initialize request argument(s)
            Settings settings = new Settings();
            // Make the request
            Settings response = advisoryNotificationsServiceClient.UpdateSettings(settings);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettingsAsync</summary>
        public async Task UpdateSettingsAsync()
        {
            // Snippet: UpdateSettingsAsync(Settings, CallSettings)
            // Additional: UpdateSettingsAsync(Settings, CancellationToken)
            // Create client
            AdvisoryNotificationsServiceClient advisoryNotificationsServiceClient = await AdvisoryNotificationsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Settings settings = new Settings();
            // Make the request
            Settings response = await advisoryNotificationsServiceClient.UpdateSettingsAsync(settings);
            // End snippet
        }
    }
}
