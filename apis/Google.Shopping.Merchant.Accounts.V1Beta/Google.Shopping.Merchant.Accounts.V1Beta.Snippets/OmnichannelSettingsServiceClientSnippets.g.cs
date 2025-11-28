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
    using Google.Protobuf.WellKnownTypes;
    using Google.Shopping.Merchant.Accounts.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedOmnichannelSettingsServiceClientSnippets
    {
        /// <summary>Snippet for GetOmnichannelSetting</summary>
        public void GetOmnichannelSettingRequestObject()
        {
            // Snippet: GetOmnichannelSetting(GetOmnichannelSettingRequest, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = OmnichannelSettingsServiceClient.Create();
            // Initialize request argument(s)
            GetOmnichannelSettingRequest request = new GetOmnichannelSettingRequest
            {
                OmnichannelSettingName = OmnichannelSettingName.FromAccountOmnichannelSetting("[ACCOUNT]", "[OMNICHANNEL_SETTING]"),
            };
            // Make the request
            OmnichannelSetting response = omnichannelSettingsServiceClient.GetOmnichannelSetting(request);
            // End snippet
        }

        /// <summary>Snippet for GetOmnichannelSettingAsync</summary>
        public async Task GetOmnichannelSettingRequestObjectAsync()
        {
            // Snippet: GetOmnichannelSettingAsync(GetOmnichannelSettingRequest, CallSettings)
            // Additional: GetOmnichannelSettingAsync(GetOmnichannelSettingRequest, CancellationToken)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = await OmnichannelSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetOmnichannelSettingRequest request = new GetOmnichannelSettingRequest
            {
                OmnichannelSettingName = OmnichannelSettingName.FromAccountOmnichannelSetting("[ACCOUNT]", "[OMNICHANNEL_SETTING]"),
            };
            // Make the request
            OmnichannelSetting response = await omnichannelSettingsServiceClient.GetOmnichannelSettingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOmnichannelSetting</summary>
        public void GetOmnichannelSetting()
        {
            // Snippet: GetOmnichannelSetting(string, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = OmnichannelSettingsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/omnichannelSettings/[OMNICHANNEL_SETTING]";
            // Make the request
            OmnichannelSetting response = omnichannelSettingsServiceClient.GetOmnichannelSetting(name);
            // End snippet
        }

        /// <summary>Snippet for GetOmnichannelSettingAsync</summary>
        public async Task GetOmnichannelSettingAsync()
        {
            // Snippet: GetOmnichannelSettingAsync(string, CallSettings)
            // Additional: GetOmnichannelSettingAsync(string, CancellationToken)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = await OmnichannelSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/omnichannelSettings/[OMNICHANNEL_SETTING]";
            // Make the request
            OmnichannelSetting response = await omnichannelSettingsServiceClient.GetOmnichannelSettingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOmnichannelSetting</summary>
        public void GetOmnichannelSettingResourceNames()
        {
            // Snippet: GetOmnichannelSetting(OmnichannelSettingName, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = OmnichannelSettingsServiceClient.Create();
            // Initialize request argument(s)
            OmnichannelSettingName name = OmnichannelSettingName.FromAccountOmnichannelSetting("[ACCOUNT]", "[OMNICHANNEL_SETTING]");
            // Make the request
            OmnichannelSetting response = omnichannelSettingsServiceClient.GetOmnichannelSetting(name);
            // End snippet
        }

        /// <summary>Snippet for GetOmnichannelSettingAsync</summary>
        public async Task GetOmnichannelSettingResourceNamesAsync()
        {
            // Snippet: GetOmnichannelSettingAsync(OmnichannelSettingName, CallSettings)
            // Additional: GetOmnichannelSettingAsync(OmnichannelSettingName, CancellationToken)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = await OmnichannelSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            OmnichannelSettingName name = OmnichannelSettingName.FromAccountOmnichannelSetting("[ACCOUNT]", "[OMNICHANNEL_SETTING]");
            // Make the request
            OmnichannelSetting response = await omnichannelSettingsServiceClient.GetOmnichannelSettingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListOmnichannelSettings</summary>
        public void ListOmnichannelSettingsRequestObject()
        {
            // Snippet: ListOmnichannelSettings(ListOmnichannelSettingsRequest, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = OmnichannelSettingsServiceClient.Create();
            // Initialize request argument(s)
            ListOmnichannelSettingsRequest request = new ListOmnichannelSettingsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListOmnichannelSettingsResponse, OmnichannelSetting> response = omnichannelSettingsServiceClient.ListOmnichannelSettings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OmnichannelSetting item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOmnichannelSettingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OmnichannelSetting item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OmnichannelSetting> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OmnichannelSetting item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOmnichannelSettingsAsync</summary>
        public async Task ListOmnichannelSettingsRequestObjectAsync()
        {
            // Snippet: ListOmnichannelSettingsAsync(ListOmnichannelSettingsRequest, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = await OmnichannelSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOmnichannelSettingsRequest request = new ListOmnichannelSettingsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListOmnichannelSettingsResponse, OmnichannelSetting> response = omnichannelSettingsServiceClient.ListOmnichannelSettingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OmnichannelSetting item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOmnichannelSettingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OmnichannelSetting item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OmnichannelSetting> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OmnichannelSetting item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOmnichannelSettings</summary>
        public void ListOmnichannelSettings()
        {
            // Snippet: ListOmnichannelSettings(string, string, int?, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = OmnichannelSettingsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListOmnichannelSettingsResponse, OmnichannelSetting> response = omnichannelSettingsServiceClient.ListOmnichannelSettings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OmnichannelSetting item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOmnichannelSettingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OmnichannelSetting item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OmnichannelSetting> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OmnichannelSetting item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOmnichannelSettingsAsync</summary>
        public async Task ListOmnichannelSettingsAsync()
        {
            // Snippet: ListOmnichannelSettingsAsync(string, string, int?, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = await OmnichannelSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListOmnichannelSettingsResponse, OmnichannelSetting> response = omnichannelSettingsServiceClient.ListOmnichannelSettingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OmnichannelSetting item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOmnichannelSettingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OmnichannelSetting item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OmnichannelSetting> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OmnichannelSetting item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOmnichannelSettings</summary>
        public void ListOmnichannelSettingsResourceNames()
        {
            // Snippet: ListOmnichannelSettings(AccountName, string, int?, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = OmnichannelSettingsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListOmnichannelSettingsResponse, OmnichannelSetting> response = omnichannelSettingsServiceClient.ListOmnichannelSettings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OmnichannelSetting item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOmnichannelSettingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OmnichannelSetting item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OmnichannelSetting> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OmnichannelSetting item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOmnichannelSettingsAsync</summary>
        public async Task ListOmnichannelSettingsResourceNamesAsync()
        {
            // Snippet: ListOmnichannelSettingsAsync(AccountName, string, int?, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = await OmnichannelSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListOmnichannelSettingsResponse, OmnichannelSetting> response = omnichannelSettingsServiceClient.ListOmnichannelSettingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OmnichannelSetting item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOmnichannelSettingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OmnichannelSetting item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OmnichannelSetting> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OmnichannelSetting item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateOmnichannelSetting</summary>
        public void CreateOmnichannelSettingRequestObject()
        {
            // Snippet: CreateOmnichannelSetting(CreateOmnichannelSettingRequest, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = OmnichannelSettingsServiceClient.Create();
            // Initialize request argument(s)
            CreateOmnichannelSettingRequest request = new CreateOmnichannelSettingRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                OmnichannelSetting = new OmnichannelSetting(),
            };
            // Make the request
            OmnichannelSetting response = omnichannelSettingsServiceClient.CreateOmnichannelSetting(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOmnichannelSettingAsync</summary>
        public async Task CreateOmnichannelSettingRequestObjectAsync()
        {
            // Snippet: CreateOmnichannelSettingAsync(CreateOmnichannelSettingRequest, CallSettings)
            // Additional: CreateOmnichannelSettingAsync(CreateOmnichannelSettingRequest, CancellationToken)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = await OmnichannelSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateOmnichannelSettingRequest request = new CreateOmnichannelSettingRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                OmnichannelSetting = new OmnichannelSetting(),
            };
            // Make the request
            OmnichannelSetting response = await omnichannelSettingsServiceClient.CreateOmnichannelSettingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOmnichannelSetting</summary>
        public void CreateOmnichannelSetting()
        {
            // Snippet: CreateOmnichannelSetting(string, OmnichannelSetting, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = OmnichannelSettingsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            OmnichannelSetting omnichannelSetting = new OmnichannelSetting();
            // Make the request
            OmnichannelSetting response = omnichannelSettingsServiceClient.CreateOmnichannelSetting(parent, omnichannelSetting);
            // End snippet
        }

        /// <summary>Snippet for CreateOmnichannelSettingAsync</summary>
        public async Task CreateOmnichannelSettingAsync()
        {
            // Snippet: CreateOmnichannelSettingAsync(string, OmnichannelSetting, CallSettings)
            // Additional: CreateOmnichannelSettingAsync(string, OmnichannelSetting, CancellationToken)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = await OmnichannelSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            OmnichannelSetting omnichannelSetting = new OmnichannelSetting();
            // Make the request
            OmnichannelSetting response = await omnichannelSettingsServiceClient.CreateOmnichannelSettingAsync(parent, omnichannelSetting);
            // End snippet
        }

        /// <summary>Snippet for CreateOmnichannelSetting</summary>
        public void CreateOmnichannelSettingResourceNames()
        {
            // Snippet: CreateOmnichannelSetting(AccountName, OmnichannelSetting, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = OmnichannelSettingsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            OmnichannelSetting omnichannelSetting = new OmnichannelSetting();
            // Make the request
            OmnichannelSetting response = omnichannelSettingsServiceClient.CreateOmnichannelSetting(parent, omnichannelSetting);
            // End snippet
        }

        /// <summary>Snippet for CreateOmnichannelSettingAsync</summary>
        public async Task CreateOmnichannelSettingResourceNamesAsync()
        {
            // Snippet: CreateOmnichannelSettingAsync(AccountName, OmnichannelSetting, CallSettings)
            // Additional: CreateOmnichannelSettingAsync(AccountName, OmnichannelSetting, CancellationToken)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = await OmnichannelSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            OmnichannelSetting omnichannelSetting = new OmnichannelSetting();
            // Make the request
            OmnichannelSetting response = await omnichannelSettingsServiceClient.CreateOmnichannelSettingAsync(parent, omnichannelSetting);
            // End snippet
        }

        /// <summary>Snippet for UpdateOmnichannelSetting</summary>
        public void UpdateOmnichannelSettingRequestObject()
        {
            // Snippet: UpdateOmnichannelSetting(UpdateOmnichannelSettingRequest, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = OmnichannelSettingsServiceClient.Create();
            // Initialize request argument(s)
            UpdateOmnichannelSettingRequest request = new UpdateOmnichannelSettingRequest
            {
                OmnichannelSetting = new OmnichannelSetting(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            OmnichannelSetting response = omnichannelSettingsServiceClient.UpdateOmnichannelSetting(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateOmnichannelSettingAsync</summary>
        public async Task UpdateOmnichannelSettingRequestObjectAsync()
        {
            // Snippet: UpdateOmnichannelSettingAsync(UpdateOmnichannelSettingRequest, CallSettings)
            // Additional: UpdateOmnichannelSettingAsync(UpdateOmnichannelSettingRequest, CancellationToken)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = await OmnichannelSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateOmnichannelSettingRequest request = new UpdateOmnichannelSettingRequest
            {
                OmnichannelSetting = new OmnichannelSetting(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            OmnichannelSetting response = await omnichannelSettingsServiceClient.UpdateOmnichannelSettingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateOmnichannelSetting</summary>
        public void UpdateOmnichannelSetting()
        {
            // Snippet: UpdateOmnichannelSetting(OmnichannelSetting, FieldMask, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = OmnichannelSettingsServiceClient.Create();
            // Initialize request argument(s)
            OmnichannelSetting omnichannelSetting = new OmnichannelSetting();
            FieldMask updateMask = new FieldMask();
            // Make the request
            OmnichannelSetting response = omnichannelSettingsServiceClient.UpdateOmnichannelSetting(omnichannelSetting, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateOmnichannelSettingAsync</summary>
        public async Task UpdateOmnichannelSettingAsync()
        {
            // Snippet: UpdateOmnichannelSettingAsync(OmnichannelSetting, FieldMask, CallSettings)
            // Additional: UpdateOmnichannelSettingAsync(OmnichannelSetting, FieldMask, CancellationToken)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = await OmnichannelSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            OmnichannelSetting omnichannelSetting = new OmnichannelSetting();
            FieldMask updateMask = new FieldMask();
            // Make the request
            OmnichannelSetting response = await omnichannelSettingsServiceClient.UpdateOmnichannelSettingAsync(omnichannelSetting, updateMask);
            // End snippet
        }

        /// <summary>Snippet for RequestInventoryVerification</summary>
        public void RequestInventoryVerificationRequestObject()
        {
            // Snippet: RequestInventoryVerification(RequestInventoryVerificationRequest, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = OmnichannelSettingsServiceClient.Create();
            // Initialize request argument(s)
            RequestInventoryVerificationRequest request = new RequestInventoryVerificationRequest
            {
                OmnichannelSettingName = OmnichannelSettingName.FromAccountOmnichannelSetting("[ACCOUNT]", "[OMNICHANNEL_SETTING]"),
            };
            // Make the request
            RequestInventoryVerificationResponse response = omnichannelSettingsServiceClient.RequestInventoryVerification(request);
            // End snippet
        }

        /// <summary>Snippet for RequestInventoryVerificationAsync</summary>
        public async Task RequestInventoryVerificationRequestObjectAsync()
        {
            // Snippet: RequestInventoryVerificationAsync(RequestInventoryVerificationRequest, CallSettings)
            // Additional: RequestInventoryVerificationAsync(RequestInventoryVerificationRequest, CancellationToken)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = await OmnichannelSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            RequestInventoryVerificationRequest request = new RequestInventoryVerificationRequest
            {
                OmnichannelSettingName = OmnichannelSettingName.FromAccountOmnichannelSetting("[ACCOUNT]", "[OMNICHANNEL_SETTING]"),
            };
            // Make the request
            RequestInventoryVerificationResponse response = await omnichannelSettingsServiceClient.RequestInventoryVerificationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RequestInventoryVerification</summary>
        public void RequestInventoryVerification()
        {
            // Snippet: RequestInventoryVerification(string, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = OmnichannelSettingsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/omnichannelSettings/[OMNICHANNEL_SETTING]";
            // Make the request
            RequestInventoryVerificationResponse response = omnichannelSettingsServiceClient.RequestInventoryVerification(name);
            // End snippet
        }

        /// <summary>Snippet for RequestInventoryVerificationAsync</summary>
        public async Task RequestInventoryVerificationAsync()
        {
            // Snippet: RequestInventoryVerificationAsync(string, CallSettings)
            // Additional: RequestInventoryVerificationAsync(string, CancellationToken)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = await OmnichannelSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/omnichannelSettings/[OMNICHANNEL_SETTING]";
            // Make the request
            RequestInventoryVerificationResponse response = await omnichannelSettingsServiceClient.RequestInventoryVerificationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RequestInventoryVerification</summary>
        public void RequestInventoryVerificationResourceNames()
        {
            // Snippet: RequestInventoryVerification(OmnichannelSettingName, CallSettings)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = OmnichannelSettingsServiceClient.Create();
            // Initialize request argument(s)
            OmnichannelSettingName name = OmnichannelSettingName.FromAccountOmnichannelSetting("[ACCOUNT]", "[OMNICHANNEL_SETTING]");
            // Make the request
            RequestInventoryVerificationResponse response = omnichannelSettingsServiceClient.RequestInventoryVerification(name);
            // End snippet
        }

        /// <summary>Snippet for RequestInventoryVerificationAsync</summary>
        public async Task RequestInventoryVerificationResourceNamesAsync()
        {
            // Snippet: RequestInventoryVerificationAsync(OmnichannelSettingName, CallSettings)
            // Additional: RequestInventoryVerificationAsync(OmnichannelSettingName, CancellationToken)
            // Create client
            OmnichannelSettingsServiceClient omnichannelSettingsServiceClient = await OmnichannelSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            OmnichannelSettingName name = OmnichannelSettingName.FromAccountOmnichannelSetting("[ACCOUNT]", "[OMNICHANNEL_SETTING]");
            // Make the request
            RequestInventoryVerificationResponse response = await omnichannelSettingsServiceClient.RequestInventoryVerificationAsync(name);
            // End snippet
        }
    }
}
