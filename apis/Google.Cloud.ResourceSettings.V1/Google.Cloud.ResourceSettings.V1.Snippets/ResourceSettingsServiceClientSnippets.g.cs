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
    using Google.Cloud.ResourceSettings.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    [ObsoleteAttribute]
    public sealed class AllGeneratedResourceSettingsServiceClientSnippets
    {
        /// <summary>Snippet for ListSettings</summary>
        public void ListSettingsRequestObject()
        {
            // Snippet: ListSettings(ListSettingsRequest, CallSettings)
            // Create client
            ResourceSettingsServiceClient resourceSettingsServiceClient = ResourceSettingsServiceClient.Create();
            // Initialize request argument(s)
            ListSettingsRequest request = new ListSettingsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                View = SettingView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListSettingsResponse, Setting> response = resourceSettingsServiceClient.ListSettings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Setting item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSettingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Setting item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Setting> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Setting item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSettingsAsync</summary>
        public async Task ListSettingsRequestObjectAsync()
        {
            // Snippet: ListSettingsAsync(ListSettingsRequest, CallSettings)
            // Create client
            ResourceSettingsServiceClient resourceSettingsServiceClient = await ResourceSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSettingsRequest request = new ListSettingsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                View = SettingView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListSettingsResponse, Setting> response = resourceSettingsServiceClient.ListSettingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Setting item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSettingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Setting item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Setting> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Setting item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSettings</summary>
        public void ListSettings()
        {
            // Snippet: ListSettings(string, string, int?, CallSettings)
            // Create client
            ResourceSettingsServiceClient resourceSettingsServiceClient = ResourceSettingsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            PagedEnumerable<ListSettingsResponse, Setting> response = resourceSettingsServiceClient.ListSettings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Setting item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSettingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Setting item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Setting> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Setting item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSettingsAsync</summary>
        public async Task ListSettingsAsync()
        {
            // Snippet: ListSettingsAsync(string, string, int?, CallSettings)
            // Create client
            ResourceSettingsServiceClient resourceSettingsServiceClient = await ResourceSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            PagedAsyncEnumerable<ListSettingsResponse, Setting> response = resourceSettingsServiceClient.ListSettingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Setting item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSettingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Setting item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Setting> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Setting item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSettings</summary>
        public void ListSettingsResourceNames()
        {
            // Snippet: ListSettings(IResourceName, string, int?, CallSettings)
            // Create client
            ResourceSettingsServiceClient resourceSettingsServiceClient = ResourceSettingsServiceClient.Create();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListSettingsResponse, Setting> response = resourceSettingsServiceClient.ListSettings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Setting item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSettingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Setting item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Setting> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Setting item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSettingsAsync</summary>
        public async Task ListSettingsResourceNamesAsync()
        {
            // Snippet: ListSettingsAsync(IResourceName, string, int?, CallSettings)
            // Create client
            ResourceSettingsServiceClient resourceSettingsServiceClient = await ResourceSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListSettingsResponse, Setting> response = resourceSettingsServiceClient.ListSettingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Setting item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSettingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Setting item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Setting> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Setting item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSetting</summary>
        public void GetSettingRequestObject()
        {
            // Snippet: GetSetting(GetSettingRequest, CallSettings)
            // Create client
            ResourceSettingsServiceClient resourceSettingsServiceClient = ResourceSettingsServiceClient.Create();
            // Initialize request argument(s)
            GetSettingRequest request = new GetSettingRequest
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
                View = SettingView.Unspecified,
            };
            // Make the request
            Setting response = resourceSettingsServiceClient.GetSetting(request);
            // End snippet
        }

        /// <summary>Snippet for GetSettingAsync</summary>
        public async Task GetSettingRequestObjectAsync()
        {
            // Snippet: GetSettingAsync(GetSettingRequest, CallSettings)
            // Additional: GetSettingAsync(GetSettingRequest, CancellationToken)
            // Create client
            ResourceSettingsServiceClient resourceSettingsServiceClient = await ResourceSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSettingRequest request = new GetSettingRequest
            {
                SettingName = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]"),
                View = SettingView.Unspecified,
            };
            // Make the request
            Setting response = await resourceSettingsServiceClient.GetSettingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSetting</summary>
        public void GetSetting()
        {
            // Snippet: GetSetting(string, CallSettings)
            // Create client
            ResourceSettingsServiceClient resourceSettingsServiceClient = ResourceSettingsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/settings/[SETTING_NAME]";
            // Make the request
            Setting response = resourceSettingsServiceClient.GetSetting(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettingAsync</summary>
        public async Task GetSettingAsync()
        {
            // Snippet: GetSettingAsync(string, CallSettings)
            // Additional: GetSettingAsync(string, CancellationToken)
            // Create client
            ResourceSettingsServiceClient resourceSettingsServiceClient = await ResourceSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/settings/[SETTING_NAME]";
            // Make the request
            Setting response = await resourceSettingsServiceClient.GetSettingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSetting</summary>
        public void GetSettingResourceNames()
        {
            // Snippet: GetSetting(SettingName, CallSettings)
            // Create client
            ResourceSettingsServiceClient resourceSettingsServiceClient = ResourceSettingsServiceClient.Create();
            // Initialize request argument(s)
            SettingName name = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]");
            // Make the request
            Setting response = resourceSettingsServiceClient.GetSetting(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettingAsync</summary>
        public async Task GetSettingResourceNamesAsync()
        {
            // Snippet: GetSettingAsync(SettingName, CallSettings)
            // Additional: GetSettingAsync(SettingName, CancellationToken)
            // Create client
            ResourceSettingsServiceClient resourceSettingsServiceClient = await ResourceSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SettingName name = SettingName.FromProjectNumberSettingName("[PROJECT_NUMBER]", "[SETTING_NAME]");
            // Make the request
            Setting response = await resourceSettingsServiceClient.GetSettingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSetting</summary>
        public void UpdateSettingRequestObject()
        {
            // Snippet: UpdateSetting(UpdateSettingRequest, CallSettings)
            // Create client
            ResourceSettingsServiceClient resourceSettingsServiceClient = ResourceSettingsServiceClient.Create();
            // Initialize request argument(s)
            UpdateSettingRequest request = new UpdateSettingRequest
            {
                Setting = new Setting(),
            };
            // Make the request
            Setting response = resourceSettingsServiceClient.UpdateSetting(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettingAsync</summary>
        public async Task UpdateSettingRequestObjectAsync()
        {
            // Snippet: UpdateSettingAsync(UpdateSettingRequest, CallSettings)
            // Additional: UpdateSettingAsync(UpdateSettingRequest, CancellationToken)
            // Create client
            ResourceSettingsServiceClient resourceSettingsServiceClient = await ResourceSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSettingRequest request = new UpdateSettingRequest
            {
                Setting = new Setting(),
            };
            // Make the request
            Setting response = await resourceSettingsServiceClient.UpdateSettingAsync(request);
            // End snippet
        }
    }
}
