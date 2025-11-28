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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAdBreakServiceClientSnippets
    {
        /// <summary>Snippet for GetAdBreak</summary>
        public void GetAdBreakRequestObject()
        {
            // Snippet: GetAdBreak(GetAdBreakRequest, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = AdBreakServiceClient.Create();
            // Initialize request argument(s)
            GetAdBreakRequest request = new GetAdBreakRequest
            {
                AdBreakName = AdBreakName.FromNetworkCodeAssetKeyAdBreak("[NETWORK_CODE]", "[ASSET_KEY]", "[AD_BREAK]"),
            };
            // Make the request
            AdBreak response = adBreakServiceClient.GetAdBreak(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdBreakAsync</summary>
        public async Task GetAdBreakRequestObjectAsync()
        {
            // Snippet: GetAdBreakAsync(GetAdBreakRequest, CallSettings)
            // Additional: GetAdBreakAsync(GetAdBreakRequest, CancellationToken)
            // Create client
            AdBreakServiceClient adBreakServiceClient = await AdBreakServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdBreakRequest request = new GetAdBreakRequest
            {
                AdBreakName = AdBreakName.FromNetworkCodeAssetKeyAdBreak("[NETWORK_CODE]", "[ASSET_KEY]", "[AD_BREAK]"),
            };
            // Make the request
            AdBreak response = await adBreakServiceClient.GetAdBreakAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdBreak</summary>
        public void GetAdBreak()
        {
            // Snippet: GetAdBreak(string, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = AdBreakServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/liveStreamEventsByAssetKey/[ASSET_KEY]/adBreaks/[AD_BREAK]";
            // Make the request
            AdBreak response = adBreakServiceClient.GetAdBreak(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdBreakAsync</summary>
        public async Task GetAdBreakAsync()
        {
            // Snippet: GetAdBreakAsync(string, CallSettings)
            // Additional: GetAdBreakAsync(string, CancellationToken)
            // Create client
            AdBreakServiceClient adBreakServiceClient = await AdBreakServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/liveStreamEventsByAssetKey/[ASSET_KEY]/adBreaks/[AD_BREAK]";
            // Make the request
            AdBreak response = await adBreakServiceClient.GetAdBreakAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdBreak</summary>
        public void GetAdBreakResourceNames()
        {
            // Snippet: GetAdBreak(AdBreakName, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = AdBreakServiceClient.Create();
            // Initialize request argument(s)
            AdBreakName name = AdBreakName.FromNetworkCodeAssetKeyAdBreak("[NETWORK_CODE]", "[ASSET_KEY]", "[AD_BREAK]");
            // Make the request
            AdBreak response = adBreakServiceClient.GetAdBreak(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdBreakAsync</summary>
        public async Task GetAdBreakResourceNamesAsync()
        {
            // Snippet: GetAdBreakAsync(AdBreakName, CallSettings)
            // Additional: GetAdBreakAsync(AdBreakName, CancellationToken)
            // Create client
            AdBreakServiceClient adBreakServiceClient = await AdBreakServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdBreakName name = AdBreakName.FromNetworkCodeAssetKeyAdBreak("[NETWORK_CODE]", "[ASSET_KEY]", "[AD_BREAK]");
            // Make the request
            AdBreak response = await adBreakServiceClient.GetAdBreakAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAdBreaks</summary>
        public void ListAdBreaksRequestObject()
        {
            // Snippet: ListAdBreaks(ListAdBreaksRequest, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = AdBreakServiceClient.Create();
            // Initialize request argument(s)
            ListAdBreaksRequest request = new ListAdBreaksRequest
            {
                ParentAsLiveStreamEventName = LiveStreamEventName.FromNetworkCodeLiveStreamEvent("[NETWORK_CODE]", "[LIVE_STREAM_EVENT]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListAdBreaksResponse, AdBreak> response = adBreakServiceClient.ListAdBreaks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdBreak item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdBreaksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdBreak item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdBreak> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdBreak item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdBreaksAsync</summary>
        public async Task ListAdBreaksRequestObjectAsync()
        {
            // Snippet: ListAdBreaksAsync(ListAdBreaksRequest, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = await AdBreakServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAdBreaksRequest request = new ListAdBreaksRequest
            {
                ParentAsLiveStreamEventName = LiveStreamEventName.FromNetworkCodeLiveStreamEvent("[NETWORK_CODE]", "[LIVE_STREAM_EVENT]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListAdBreaksResponse, AdBreak> response = adBreakServiceClient.ListAdBreaksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdBreak item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdBreaksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdBreak item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdBreak> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdBreak item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdBreaks</summary>
        public void ListAdBreaks()
        {
            // Snippet: ListAdBreaks(string, string, int?, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = AdBreakServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/liveStreamEvents/[LIVE_STREAM_EVENT]";
            // Make the request
            PagedEnumerable<ListAdBreaksResponse, AdBreak> response = adBreakServiceClient.ListAdBreaks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdBreak item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdBreaksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdBreak item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdBreak> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdBreak item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdBreaksAsync</summary>
        public async Task ListAdBreaksAsync()
        {
            // Snippet: ListAdBreaksAsync(string, string, int?, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = await AdBreakServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/liveStreamEvents/[LIVE_STREAM_EVENT]";
            // Make the request
            PagedAsyncEnumerable<ListAdBreaksResponse, AdBreak> response = adBreakServiceClient.ListAdBreaksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdBreak item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdBreaksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdBreak item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdBreak> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdBreak item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdBreaks</summary>
        public void ListAdBreaksResourceNames()
        {
            // Snippet: ListAdBreaks(LiveStreamEventName, string, int?, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = AdBreakServiceClient.Create();
            // Initialize request argument(s)
            LiveStreamEventName parent = LiveStreamEventName.FromNetworkCodeLiveStreamEvent("[NETWORK_CODE]", "[LIVE_STREAM_EVENT]");
            // Make the request
            PagedEnumerable<ListAdBreaksResponse, AdBreak> response = adBreakServiceClient.ListAdBreaks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdBreak item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdBreaksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdBreak item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdBreak> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdBreak item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdBreaksAsync</summary>
        public async Task ListAdBreaksResourceNamesAsync()
        {
            // Snippet: ListAdBreaksAsync(LiveStreamEventName, string, int?, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = await AdBreakServiceClient.CreateAsync();
            // Initialize request argument(s)
            LiveStreamEventName parent = LiveStreamEventName.FromNetworkCodeLiveStreamEvent("[NETWORK_CODE]", "[LIVE_STREAM_EVENT]");
            // Make the request
            PagedAsyncEnumerable<ListAdBreaksResponse, AdBreak> response = adBreakServiceClient.ListAdBreaksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdBreak item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdBreaksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdBreak item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdBreak> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdBreak item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateAdBreak</summary>
        public void CreateAdBreakRequestObject()
        {
            // Snippet: CreateAdBreak(CreateAdBreakRequest, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = AdBreakServiceClient.Create();
            // Initialize request argument(s)
            CreateAdBreakRequest request = new CreateAdBreakRequest
            {
                ParentAsLiveStreamEventName = LiveStreamEventName.FromNetworkCodeLiveStreamEvent("[NETWORK_CODE]", "[LIVE_STREAM_EVENT]"),
                AdBreak = new AdBreak(),
            };
            // Make the request
            AdBreak response = adBreakServiceClient.CreateAdBreak(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdBreakAsync</summary>
        public async Task CreateAdBreakRequestObjectAsync()
        {
            // Snippet: CreateAdBreakAsync(CreateAdBreakRequest, CallSettings)
            // Additional: CreateAdBreakAsync(CreateAdBreakRequest, CancellationToken)
            // Create client
            AdBreakServiceClient adBreakServiceClient = await AdBreakServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAdBreakRequest request = new CreateAdBreakRequest
            {
                ParentAsLiveStreamEventName = LiveStreamEventName.FromNetworkCodeLiveStreamEvent("[NETWORK_CODE]", "[LIVE_STREAM_EVENT]"),
                AdBreak = new AdBreak(),
            };
            // Make the request
            AdBreak response = await adBreakServiceClient.CreateAdBreakAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdBreak</summary>
        public void CreateAdBreak()
        {
            // Snippet: CreateAdBreak(string, AdBreak, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = AdBreakServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/liveStreamEvents/[LIVE_STREAM_EVENT]";
            AdBreak adBreak = new AdBreak();
            // Make the request
            AdBreak response = adBreakServiceClient.CreateAdBreak(parent, adBreak);
            // End snippet
        }

        /// <summary>Snippet for CreateAdBreakAsync</summary>
        public async Task CreateAdBreakAsync()
        {
            // Snippet: CreateAdBreakAsync(string, AdBreak, CallSettings)
            // Additional: CreateAdBreakAsync(string, AdBreak, CancellationToken)
            // Create client
            AdBreakServiceClient adBreakServiceClient = await AdBreakServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/liveStreamEvents/[LIVE_STREAM_EVENT]";
            AdBreak adBreak = new AdBreak();
            // Make the request
            AdBreak response = await adBreakServiceClient.CreateAdBreakAsync(parent, adBreak);
            // End snippet
        }

        /// <summary>Snippet for CreateAdBreak</summary>
        public void CreateAdBreakResourceNames()
        {
            // Snippet: CreateAdBreak(LiveStreamEventName, AdBreak, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = AdBreakServiceClient.Create();
            // Initialize request argument(s)
            LiveStreamEventName parent = LiveStreamEventName.FromNetworkCodeLiveStreamEvent("[NETWORK_CODE]", "[LIVE_STREAM_EVENT]");
            AdBreak adBreak = new AdBreak();
            // Make the request
            AdBreak response = adBreakServiceClient.CreateAdBreak(parent, adBreak);
            // End snippet
        }

        /// <summary>Snippet for CreateAdBreakAsync</summary>
        public async Task CreateAdBreakResourceNamesAsync()
        {
            // Snippet: CreateAdBreakAsync(LiveStreamEventName, AdBreak, CallSettings)
            // Additional: CreateAdBreakAsync(LiveStreamEventName, AdBreak, CancellationToken)
            // Create client
            AdBreakServiceClient adBreakServiceClient = await AdBreakServiceClient.CreateAsync();
            // Initialize request argument(s)
            LiveStreamEventName parent = LiveStreamEventName.FromNetworkCodeLiveStreamEvent("[NETWORK_CODE]", "[LIVE_STREAM_EVENT]");
            AdBreak adBreak = new AdBreak();
            // Make the request
            AdBreak response = await adBreakServiceClient.CreateAdBreakAsync(parent, adBreak);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdBreak</summary>
        public void UpdateAdBreakRequestObject()
        {
            // Snippet: UpdateAdBreak(UpdateAdBreakRequest, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = AdBreakServiceClient.Create();
            // Initialize request argument(s)
            UpdateAdBreakRequest request = new UpdateAdBreakRequest
            {
                AdBreak = new AdBreak(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AdBreak response = adBreakServiceClient.UpdateAdBreak(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdBreakAsync</summary>
        public async Task UpdateAdBreakRequestObjectAsync()
        {
            // Snippet: UpdateAdBreakAsync(UpdateAdBreakRequest, CallSettings)
            // Additional: UpdateAdBreakAsync(UpdateAdBreakRequest, CancellationToken)
            // Create client
            AdBreakServiceClient adBreakServiceClient = await AdBreakServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAdBreakRequest request = new UpdateAdBreakRequest
            {
                AdBreak = new AdBreak(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AdBreak response = await adBreakServiceClient.UpdateAdBreakAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdBreak</summary>
        public void UpdateAdBreak()
        {
            // Snippet: UpdateAdBreak(AdBreak, FieldMask, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = AdBreakServiceClient.Create();
            // Initialize request argument(s)
            AdBreak adBreak = new AdBreak();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AdBreak response = adBreakServiceClient.UpdateAdBreak(adBreak, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdBreakAsync</summary>
        public async Task UpdateAdBreakAsync()
        {
            // Snippet: UpdateAdBreakAsync(AdBreak, FieldMask, CallSettings)
            // Additional: UpdateAdBreakAsync(AdBreak, FieldMask, CancellationToken)
            // Create client
            AdBreakServiceClient adBreakServiceClient = await AdBreakServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdBreak adBreak = new AdBreak();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AdBreak response = await adBreakServiceClient.UpdateAdBreakAsync(adBreak, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdBreak</summary>
        public void DeleteAdBreakRequestObject()
        {
            // Snippet: DeleteAdBreak(DeleteAdBreakRequest, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = AdBreakServiceClient.Create();
            // Initialize request argument(s)
            DeleteAdBreakRequest request = new DeleteAdBreakRequest
            {
                AdBreakName = AdBreakName.FromNetworkCodeAssetKeyAdBreak("[NETWORK_CODE]", "[ASSET_KEY]", "[AD_BREAK]"),
            };
            // Make the request
            adBreakServiceClient.DeleteAdBreak(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdBreakAsync</summary>
        public async Task DeleteAdBreakRequestObjectAsync()
        {
            // Snippet: DeleteAdBreakAsync(DeleteAdBreakRequest, CallSettings)
            // Additional: DeleteAdBreakAsync(DeleteAdBreakRequest, CancellationToken)
            // Create client
            AdBreakServiceClient adBreakServiceClient = await AdBreakServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAdBreakRequest request = new DeleteAdBreakRequest
            {
                AdBreakName = AdBreakName.FromNetworkCodeAssetKeyAdBreak("[NETWORK_CODE]", "[ASSET_KEY]", "[AD_BREAK]"),
            };
            // Make the request
            await adBreakServiceClient.DeleteAdBreakAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdBreak</summary>
        public void DeleteAdBreak()
        {
            // Snippet: DeleteAdBreak(string, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = AdBreakServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/liveStreamEventsByAssetKey/[ASSET_KEY]/adBreaks/[AD_BREAK]";
            // Make the request
            adBreakServiceClient.DeleteAdBreak(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdBreakAsync</summary>
        public async Task DeleteAdBreakAsync()
        {
            // Snippet: DeleteAdBreakAsync(string, CallSettings)
            // Additional: DeleteAdBreakAsync(string, CancellationToken)
            // Create client
            AdBreakServiceClient adBreakServiceClient = await AdBreakServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/liveStreamEventsByAssetKey/[ASSET_KEY]/adBreaks/[AD_BREAK]";
            // Make the request
            await adBreakServiceClient.DeleteAdBreakAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdBreak</summary>
        public void DeleteAdBreakResourceNames()
        {
            // Snippet: DeleteAdBreak(AdBreakName, CallSettings)
            // Create client
            AdBreakServiceClient adBreakServiceClient = AdBreakServiceClient.Create();
            // Initialize request argument(s)
            AdBreakName name = AdBreakName.FromNetworkCodeAssetKeyAdBreak("[NETWORK_CODE]", "[ASSET_KEY]", "[AD_BREAK]");
            // Make the request
            adBreakServiceClient.DeleteAdBreak(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdBreakAsync</summary>
        public async Task DeleteAdBreakResourceNamesAsync()
        {
            // Snippet: DeleteAdBreakAsync(AdBreakName, CallSettings)
            // Additional: DeleteAdBreakAsync(AdBreakName, CancellationToken)
            // Create client
            AdBreakServiceClient adBreakServiceClient = await AdBreakServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdBreakName name = AdBreakName.FromNetworkCodeAssetKeyAdBreak("[NETWORK_CODE]", "[ASSET_KEY]", "[AD_BREAK]");
            // Make the request
            await adBreakServiceClient.DeleteAdBreakAsync(name);
            // End snippet
        }
    }
}
