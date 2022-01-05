// Copyright 2022 Google LLC
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

namespace Google.Cloud.AccessApproval.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAccessApprovalServiceClientSnippets
    {
        /// <summary>Snippet for ListApprovalRequests</summary>
        public void ListApprovalRequestsRequestObject()
        {
            // Snippet: ListApprovalRequests(ListApprovalRequestsMessage, CallSettings)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = AccessApprovalServiceClient.Create();
            // Initialize request argument(s)
            ListApprovalRequestsMessage request = new ListApprovalRequestsMessage
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListApprovalRequestsResponse, ApprovalRequest> response = accessApprovalServiceClient.ListApprovalRequests(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApprovalRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApprovalRequestsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApprovalRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApprovalRequestsAsync</summary>
        public async Task ListApprovalRequestsRequestObjectAsync()
        {
            // Snippet: ListApprovalRequestsAsync(ListApprovalRequestsMessage, CallSettings)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = await AccessApprovalServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListApprovalRequestsMessage request = new ListApprovalRequestsMessage
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListApprovalRequestsResponse, ApprovalRequest> response = accessApprovalServiceClient.ListApprovalRequestsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApprovalRequest item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApprovalRequestsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApprovalRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApprovalRequests</summary>
        public void ListApprovalRequests()
        {
            // Snippet: ListApprovalRequests(string, string, int?, CallSettings)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = AccessApprovalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListApprovalRequestsResponse, ApprovalRequest> response = accessApprovalServiceClient.ListApprovalRequests(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApprovalRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApprovalRequestsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApprovalRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApprovalRequestsAsync</summary>
        public async Task ListApprovalRequestsAsync()
        {
            // Snippet: ListApprovalRequestsAsync(string, string, int?, CallSettings)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = await AccessApprovalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListApprovalRequestsResponse, ApprovalRequest> response = accessApprovalServiceClient.ListApprovalRequestsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApprovalRequest item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApprovalRequestsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApprovalRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetApprovalRequest</summary>
        public void GetApprovalRequestRequestObject()
        {
            // Snippet: GetApprovalRequest(GetApprovalRequestMessage, CallSettings)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = AccessApprovalServiceClient.Create();
            // Initialize request argument(s)
            GetApprovalRequestMessage request = new GetApprovalRequestMessage { Name = "", };
            // Make the request
            ApprovalRequest response = accessApprovalServiceClient.GetApprovalRequest(request);
            // End snippet
        }

        /// <summary>Snippet for GetApprovalRequestAsync</summary>
        public async Task GetApprovalRequestRequestObjectAsync()
        {
            // Snippet: GetApprovalRequestAsync(GetApprovalRequestMessage, CallSettings)
            // Additional: GetApprovalRequestAsync(GetApprovalRequestMessage, CancellationToken)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = await AccessApprovalServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetApprovalRequestMessage request = new GetApprovalRequestMessage { Name = "", };
            // Make the request
            ApprovalRequest response = await accessApprovalServiceClient.GetApprovalRequestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApprovalRequest</summary>
        public void GetApprovalRequest()
        {
            // Snippet: GetApprovalRequest(string, CallSettings)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = AccessApprovalServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            ApprovalRequest response = accessApprovalServiceClient.GetApprovalRequest(name);
            // End snippet
        }

        /// <summary>Snippet for GetApprovalRequestAsync</summary>
        public async Task GetApprovalRequestAsync()
        {
            // Snippet: GetApprovalRequestAsync(string, CallSettings)
            // Additional: GetApprovalRequestAsync(string, CancellationToken)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = await AccessApprovalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            ApprovalRequest response = await accessApprovalServiceClient.GetApprovalRequestAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ApproveApprovalRequest</summary>
        public void ApproveApprovalRequestRequestObject()
        {
            // Snippet: ApproveApprovalRequest(ApproveApprovalRequestMessage, CallSettings)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = AccessApprovalServiceClient.Create();
            // Initialize request argument(s)
            ApproveApprovalRequestMessage request = new ApproveApprovalRequestMessage
            {
                Name = "",
                ExpireTime = new Timestamp(),
            };
            // Make the request
            ApprovalRequest response = accessApprovalServiceClient.ApproveApprovalRequest(request);
            // End snippet
        }

        /// <summary>Snippet for ApproveApprovalRequestAsync</summary>
        public async Task ApproveApprovalRequestRequestObjectAsync()
        {
            // Snippet: ApproveApprovalRequestAsync(ApproveApprovalRequestMessage, CallSettings)
            // Additional: ApproveApprovalRequestAsync(ApproveApprovalRequestMessage, CancellationToken)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = await AccessApprovalServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApproveApprovalRequestMessage request = new ApproveApprovalRequestMessage
            {
                Name = "",
                ExpireTime = new Timestamp(),
            };
            // Make the request
            ApprovalRequest response = await accessApprovalServiceClient.ApproveApprovalRequestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DismissApprovalRequest</summary>
        public void DismissApprovalRequestRequestObject()
        {
            // Snippet: DismissApprovalRequest(DismissApprovalRequestMessage, CallSettings)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = AccessApprovalServiceClient.Create();
            // Initialize request argument(s)
            DismissApprovalRequestMessage request = new DismissApprovalRequestMessage { Name = "", };
            // Make the request
            ApprovalRequest response = accessApprovalServiceClient.DismissApprovalRequest(request);
            // End snippet
        }

        /// <summary>Snippet for DismissApprovalRequestAsync</summary>
        public async Task DismissApprovalRequestRequestObjectAsync()
        {
            // Snippet: DismissApprovalRequestAsync(DismissApprovalRequestMessage, CallSettings)
            // Additional: DismissApprovalRequestAsync(DismissApprovalRequestMessage, CancellationToken)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = await AccessApprovalServiceClient.CreateAsync();
            // Initialize request argument(s)
            DismissApprovalRequestMessage request = new DismissApprovalRequestMessage { Name = "", };
            // Make the request
            ApprovalRequest response = await accessApprovalServiceClient.DismissApprovalRequestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessApprovalSettings</summary>
        public void GetAccessApprovalSettingsRequestObject()
        {
            // Snippet: GetAccessApprovalSettings(GetAccessApprovalSettingsMessage, CallSettings)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = AccessApprovalServiceClient.Create();
            // Initialize request argument(s)
            GetAccessApprovalSettingsMessage request = new GetAccessApprovalSettingsMessage { Name = "", };
            // Make the request
            AccessApprovalSettings response = accessApprovalServiceClient.GetAccessApprovalSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessApprovalSettingsAsync</summary>
        public async Task GetAccessApprovalSettingsRequestObjectAsync()
        {
            // Snippet: GetAccessApprovalSettingsAsync(GetAccessApprovalSettingsMessage, CallSettings)
            // Additional: GetAccessApprovalSettingsAsync(GetAccessApprovalSettingsMessage, CancellationToken)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = await AccessApprovalServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAccessApprovalSettingsMessage request = new GetAccessApprovalSettingsMessage { Name = "", };
            // Make the request
            AccessApprovalSettings response = await accessApprovalServiceClient.GetAccessApprovalSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessApprovalSettings</summary>
        public void GetAccessApprovalSettings()
        {
            // Snippet: GetAccessApprovalSettings(string, CallSettings)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = AccessApprovalServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            AccessApprovalSettings response = accessApprovalServiceClient.GetAccessApprovalSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessApprovalSettingsAsync</summary>
        public async Task GetAccessApprovalSettingsAsync()
        {
            // Snippet: GetAccessApprovalSettingsAsync(string, CallSettings)
            // Additional: GetAccessApprovalSettingsAsync(string, CancellationToken)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = await AccessApprovalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            AccessApprovalSettings response = await accessApprovalServiceClient.GetAccessApprovalSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessApprovalSettings</summary>
        public void UpdateAccessApprovalSettingsRequestObject()
        {
            // Snippet: UpdateAccessApprovalSettings(UpdateAccessApprovalSettingsMessage, CallSettings)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = AccessApprovalServiceClient.Create();
            // Initialize request argument(s)
            UpdateAccessApprovalSettingsMessage request = new UpdateAccessApprovalSettingsMessage
            {
                Settings = new AccessApprovalSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AccessApprovalSettings response = accessApprovalServiceClient.UpdateAccessApprovalSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessApprovalSettingsAsync</summary>
        public async Task UpdateAccessApprovalSettingsRequestObjectAsync()
        {
            // Snippet: UpdateAccessApprovalSettingsAsync(UpdateAccessApprovalSettingsMessage, CallSettings)
            // Additional: UpdateAccessApprovalSettingsAsync(UpdateAccessApprovalSettingsMessage, CancellationToken)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = await AccessApprovalServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAccessApprovalSettingsMessage request = new UpdateAccessApprovalSettingsMessage
            {
                Settings = new AccessApprovalSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AccessApprovalSettings response = await accessApprovalServiceClient.UpdateAccessApprovalSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessApprovalSettings</summary>
        public void UpdateAccessApprovalSettings()
        {
            // Snippet: UpdateAccessApprovalSettings(AccessApprovalSettings, FieldMask, CallSettings)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = AccessApprovalServiceClient.Create();
            // Initialize request argument(s)
            AccessApprovalSettings settings = new AccessApprovalSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AccessApprovalSettings response = accessApprovalServiceClient.UpdateAccessApprovalSettings(settings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessApprovalSettingsAsync</summary>
        public async Task UpdateAccessApprovalSettingsAsync()
        {
            // Snippet: UpdateAccessApprovalSettingsAsync(AccessApprovalSettings, FieldMask, CallSettings)
            // Additional: UpdateAccessApprovalSettingsAsync(AccessApprovalSettings, FieldMask, CancellationToken)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = await AccessApprovalServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccessApprovalSettings settings = new AccessApprovalSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AccessApprovalSettings response = await accessApprovalServiceClient.UpdateAccessApprovalSettingsAsync(settings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessApprovalSettings</summary>
        public void DeleteAccessApprovalSettingsRequestObject()
        {
            // Snippet: DeleteAccessApprovalSettings(DeleteAccessApprovalSettingsMessage, CallSettings)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = AccessApprovalServiceClient.Create();
            // Initialize request argument(s)
            DeleteAccessApprovalSettingsMessage request = new DeleteAccessApprovalSettingsMessage { Name = "", };
            // Make the request
            accessApprovalServiceClient.DeleteAccessApprovalSettings(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessApprovalSettingsAsync</summary>
        public async Task DeleteAccessApprovalSettingsRequestObjectAsync()
        {
            // Snippet: DeleteAccessApprovalSettingsAsync(DeleteAccessApprovalSettingsMessage, CallSettings)
            // Additional: DeleteAccessApprovalSettingsAsync(DeleteAccessApprovalSettingsMessage, CancellationToken)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = await AccessApprovalServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAccessApprovalSettingsMessage request = new DeleteAccessApprovalSettingsMessage { Name = "", };
            // Make the request
            await accessApprovalServiceClient.DeleteAccessApprovalSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessApprovalSettings</summary>
        public void DeleteAccessApprovalSettings()
        {
            // Snippet: DeleteAccessApprovalSettings(string, CallSettings)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = AccessApprovalServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            accessApprovalServiceClient.DeleteAccessApprovalSettings(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessApprovalSettingsAsync</summary>
        public async Task DeleteAccessApprovalSettingsAsync()
        {
            // Snippet: DeleteAccessApprovalSettingsAsync(string, CallSettings)
            // Additional: DeleteAccessApprovalSettingsAsync(string, CancellationToken)
            // Create client
            AccessApprovalServiceClient accessApprovalServiceClient = await AccessApprovalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            await accessApprovalServiceClient.DeleteAccessApprovalSettingsAsync(name);
            // End snippet
        }
    }
}
