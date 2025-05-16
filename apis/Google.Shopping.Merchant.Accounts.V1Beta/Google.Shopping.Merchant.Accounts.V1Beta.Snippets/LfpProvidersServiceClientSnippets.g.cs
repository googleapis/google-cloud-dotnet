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
    using Google.Shopping.Merchant.Accounts.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLfpProvidersServiceClientSnippets
    {
        /// <summary>Snippet for FindLfpProviders</summary>
        public void FindLfpProvidersRequestObject()
        {
            // Snippet: FindLfpProviders(FindLfpProvidersRequest, CallSettings)
            // Create client
            LfpProvidersServiceClient lfpProvidersServiceClient = LfpProvidersServiceClient.Create();
            // Initialize request argument(s)
            FindLfpProvidersRequest request = new FindLfpProvidersRequest
            {
                ParentAsOmnichannelSettingName = OmnichannelSettingName.FromAccountOmnichannelSetting("[ACCOUNT]", "[OMNICHANNEL_SETTING]"),
            };
            // Make the request
            PagedEnumerable<FindLfpProvidersResponse, LfpProvider> response = lfpProvidersServiceClient.FindLfpProviders(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LfpProvider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FindLfpProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LfpProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LfpProvider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LfpProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FindLfpProvidersAsync</summary>
        public async Task FindLfpProvidersRequestObjectAsync()
        {
            // Snippet: FindLfpProvidersAsync(FindLfpProvidersRequest, CallSettings)
            // Create client
            LfpProvidersServiceClient lfpProvidersServiceClient = await LfpProvidersServiceClient.CreateAsync();
            // Initialize request argument(s)
            FindLfpProvidersRequest request = new FindLfpProvidersRequest
            {
                ParentAsOmnichannelSettingName = OmnichannelSettingName.FromAccountOmnichannelSetting("[ACCOUNT]", "[OMNICHANNEL_SETTING]"),
            };
            // Make the request
            PagedAsyncEnumerable<FindLfpProvidersResponse, LfpProvider> response = lfpProvidersServiceClient.FindLfpProvidersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LfpProvider item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FindLfpProvidersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LfpProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LfpProvider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LfpProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FindLfpProviders</summary>
        public void FindLfpProviders()
        {
            // Snippet: FindLfpProviders(string, string, int?, CallSettings)
            // Create client
            LfpProvidersServiceClient lfpProvidersServiceClient = LfpProvidersServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]/omnichannelSettings/[OMNICHANNEL_SETTING]";
            // Make the request
            PagedEnumerable<FindLfpProvidersResponse, LfpProvider> response = lfpProvidersServiceClient.FindLfpProviders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LfpProvider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FindLfpProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LfpProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LfpProvider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LfpProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FindLfpProvidersAsync</summary>
        public async Task FindLfpProvidersAsync()
        {
            // Snippet: FindLfpProvidersAsync(string, string, int?, CallSettings)
            // Create client
            LfpProvidersServiceClient lfpProvidersServiceClient = await LfpProvidersServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]/omnichannelSettings/[OMNICHANNEL_SETTING]";
            // Make the request
            PagedAsyncEnumerable<FindLfpProvidersResponse, LfpProvider> response = lfpProvidersServiceClient.FindLfpProvidersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LfpProvider item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FindLfpProvidersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LfpProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LfpProvider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LfpProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FindLfpProviders</summary>
        public void FindLfpProvidersResourceNames()
        {
            // Snippet: FindLfpProviders(OmnichannelSettingName, string, int?, CallSettings)
            // Create client
            LfpProvidersServiceClient lfpProvidersServiceClient = LfpProvidersServiceClient.Create();
            // Initialize request argument(s)
            OmnichannelSettingName parent = OmnichannelSettingName.FromAccountOmnichannelSetting("[ACCOUNT]", "[OMNICHANNEL_SETTING]");
            // Make the request
            PagedEnumerable<FindLfpProvidersResponse, LfpProvider> response = lfpProvidersServiceClient.FindLfpProviders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LfpProvider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FindLfpProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LfpProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LfpProvider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LfpProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FindLfpProvidersAsync</summary>
        public async Task FindLfpProvidersResourceNamesAsync()
        {
            // Snippet: FindLfpProvidersAsync(OmnichannelSettingName, string, int?, CallSettings)
            // Create client
            LfpProvidersServiceClient lfpProvidersServiceClient = await LfpProvidersServiceClient.CreateAsync();
            // Initialize request argument(s)
            OmnichannelSettingName parent = OmnichannelSettingName.FromAccountOmnichannelSetting("[ACCOUNT]", "[OMNICHANNEL_SETTING]");
            // Make the request
            PagedAsyncEnumerable<FindLfpProvidersResponse, LfpProvider> response = lfpProvidersServiceClient.FindLfpProvidersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LfpProvider item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FindLfpProvidersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LfpProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LfpProvider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LfpProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LinkLfpProvider</summary>
        public void LinkLfpProviderRequestObject()
        {
            // Snippet: LinkLfpProvider(LinkLfpProviderRequest, CallSettings)
            // Create client
            LfpProvidersServiceClient lfpProvidersServiceClient = LfpProvidersServiceClient.Create();
            // Initialize request argument(s)
            LinkLfpProviderRequest request = new LinkLfpProviderRequest
            {
                LfpProviderName = LfpProviderName.FromAccountOmnichannelSettingLfpProvider("[ACCOUNT]", "[OMNICHANNEL_SETTING]", "[LFP_PROVIDER]"),
                ExternalAccountId = "",
            };
            // Make the request
            LinkLfpProviderResponse response = lfpProvidersServiceClient.LinkLfpProvider(request);
            // End snippet
        }

        /// <summary>Snippet for LinkLfpProviderAsync</summary>
        public async Task LinkLfpProviderRequestObjectAsync()
        {
            // Snippet: LinkLfpProviderAsync(LinkLfpProviderRequest, CallSettings)
            // Additional: LinkLfpProviderAsync(LinkLfpProviderRequest, CancellationToken)
            // Create client
            LfpProvidersServiceClient lfpProvidersServiceClient = await LfpProvidersServiceClient.CreateAsync();
            // Initialize request argument(s)
            LinkLfpProviderRequest request = new LinkLfpProviderRequest
            {
                LfpProviderName = LfpProviderName.FromAccountOmnichannelSettingLfpProvider("[ACCOUNT]", "[OMNICHANNEL_SETTING]", "[LFP_PROVIDER]"),
                ExternalAccountId = "",
            };
            // Make the request
            LinkLfpProviderResponse response = await lfpProvidersServiceClient.LinkLfpProviderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LinkLfpProvider</summary>
        public void LinkLfpProvider()
        {
            // Snippet: LinkLfpProvider(string, CallSettings)
            // Create client
            LfpProvidersServiceClient lfpProvidersServiceClient = LfpProvidersServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/omnichannelSettings/[OMNICHANNEL_SETTING]/lfpProviders/[LFP_PROVIDER]";
            // Make the request
            LinkLfpProviderResponse response = lfpProvidersServiceClient.LinkLfpProvider(name);
            // End snippet
        }

        /// <summary>Snippet for LinkLfpProviderAsync</summary>
        public async Task LinkLfpProviderAsync()
        {
            // Snippet: LinkLfpProviderAsync(string, CallSettings)
            // Additional: LinkLfpProviderAsync(string, CancellationToken)
            // Create client
            LfpProvidersServiceClient lfpProvidersServiceClient = await LfpProvidersServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/omnichannelSettings/[OMNICHANNEL_SETTING]/lfpProviders/[LFP_PROVIDER]";
            // Make the request
            LinkLfpProviderResponse response = await lfpProvidersServiceClient.LinkLfpProviderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LinkLfpProvider</summary>
        public void LinkLfpProviderResourceNames()
        {
            // Snippet: LinkLfpProvider(LfpProviderName, CallSettings)
            // Create client
            LfpProvidersServiceClient lfpProvidersServiceClient = LfpProvidersServiceClient.Create();
            // Initialize request argument(s)
            LfpProviderName name = LfpProviderName.FromAccountOmnichannelSettingLfpProvider("[ACCOUNT]", "[OMNICHANNEL_SETTING]", "[LFP_PROVIDER]");
            // Make the request
            LinkLfpProviderResponse response = lfpProvidersServiceClient.LinkLfpProvider(name);
            // End snippet
        }

        /// <summary>Snippet for LinkLfpProviderAsync</summary>
        public async Task LinkLfpProviderResourceNamesAsync()
        {
            // Snippet: LinkLfpProviderAsync(LfpProviderName, CallSettings)
            // Additional: LinkLfpProviderAsync(LfpProviderName, CancellationToken)
            // Create client
            LfpProvidersServiceClient lfpProvidersServiceClient = await LfpProvidersServiceClient.CreateAsync();
            // Initialize request argument(s)
            LfpProviderName name = LfpProviderName.FromAccountOmnichannelSettingLfpProvider("[ACCOUNT]", "[OMNICHANNEL_SETTING]", "[LFP_PROVIDER]");
            // Make the request
            LinkLfpProviderResponse response = await lfpProvidersServiceClient.LinkLfpProviderAsync(name);
            // End snippet
        }
    }
}
