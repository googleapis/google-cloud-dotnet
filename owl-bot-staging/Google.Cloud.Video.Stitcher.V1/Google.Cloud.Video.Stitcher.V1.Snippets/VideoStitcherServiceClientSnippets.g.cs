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

namespace Google.Cloud.Video.Stitcher.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedVideoStitcherServiceClientSnippets
    {
        /// <summary>Snippet for CreateCdnKey</summary>
        public void CreateCdnKeyRequestObject()
        {
            // Snippet: CreateCdnKey(CreateCdnKeyRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            CreateCdnKeyRequest request = new CreateCdnKeyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CdnKey = new CdnKey(),
                CdnKeyId = "",
            };
            // Make the request
            CdnKey response = videoStitcherServiceClient.CreateCdnKey(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCdnKeyAsync</summary>
        public async Task CreateCdnKeyRequestObjectAsync()
        {
            // Snippet: CreateCdnKeyAsync(CreateCdnKeyRequest, CallSettings)
            // Additional: CreateCdnKeyAsync(CreateCdnKeyRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCdnKeyRequest request = new CreateCdnKeyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CdnKey = new CdnKey(),
                CdnKeyId = "",
            };
            // Make the request
            CdnKey response = await videoStitcherServiceClient.CreateCdnKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCdnKey</summary>
        public void CreateCdnKey()
        {
            // Snippet: CreateCdnKey(string, CdnKey, string, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CdnKey cdnKey = new CdnKey();
            string cdnKeyId = "";
            // Make the request
            CdnKey response = videoStitcherServiceClient.CreateCdnKey(parent, cdnKey, cdnKeyId);
            // End snippet
        }

        /// <summary>Snippet for CreateCdnKeyAsync</summary>
        public async Task CreateCdnKeyAsync()
        {
            // Snippet: CreateCdnKeyAsync(string, CdnKey, string, CallSettings)
            // Additional: CreateCdnKeyAsync(string, CdnKey, string, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CdnKey cdnKey = new CdnKey();
            string cdnKeyId = "";
            // Make the request
            CdnKey response = await videoStitcherServiceClient.CreateCdnKeyAsync(parent, cdnKey, cdnKeyId);
            // End snippet
        }

        /// <summary>Snippet for CreateCdnKey</summary>
        public void CreateCdnKeyResourceNames()
        {
            // Snippet: CreateCdnKey(LocationName, CdnKey, string, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CdnKey cdnKey = new CdnKey();
            string cdnKeyId = "";
            // Make the request
            CdnKey response = videoStitcherServiceClient.CreateCdnKey(parent, cdnKey, cdnKeyId);
            // End snippet
        }

        /// <summary>Snippet for CreateCdnKeyAsync</summary>
        public async Task CreateCdnKeyResourceNamesAsync()
        {
            // Snippet: CreateCdnKeyAsync(LocationName, CdnKey, string, CallSettings)
            // Additional: CreateCdnKeyAsync(LocationName, CdnKey, string, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CdnKey cdnKey = new CdnKey();
            string cdnKeyId = "";
            // Make the request
            CdnKey response = await videoStitcherServiceClient.CreateCdnKeyAsync(parent, cdnKey, cdnKeyId);
            // End snippet
        }

        /// <summary>Snippet for ListCdnKeys</summary>
        public void ListCdnKeysRequestObject()
        {
            // Snippet: ListCdnKeys(ListCdnKeysRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            ListCdnKeysRequest request = new ListCdnKeysRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCdnKeysResponse, CdnKey> response = videoStitcherServiceClient.ListCdnKeys(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CdnKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCdnKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CdnKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CdnKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CdnKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCdnKeysAsync</summary>
        public async Task ListCdnKeysRequestObjectAsync()
        {
            // Snippet: ListCdnKeysAsync(ListCdnKeysRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCdnKeysRequest request = new ListCdnKeysRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCdnKeysResponse, CdnKey> response = videoStitcherServiceClient.ListCdnKeysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CdnKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCdnKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CdnKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CdnKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CdnKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCdnKeys</summary>
        public void ListCdnKeys()
        {
            // Snippet: ListCdnKeys(string, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCdnKeysResponse, CdnKey> response = videoStitcherServiceClient.ListCdnKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CdnKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCdnKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CdnKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CdnKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CdnKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCdnKeysAsync</summary>
        public async Task ListCdnKeysAsync()
        {
            // Snippet: ListCdnKeysAsync(string, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCdnKeysResponse, CdnKey> response = videoStitcherServiceClient.ListCdnKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CdnKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCdnKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CdnKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CdnKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CdnKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCdnKeys</summary>
        public void ListCdnKeysResourceNames()
        {
            // Snippet: ListCdnKeys(LocationName, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCdnKeysResponse, CdnKey> response = videoStitcherServiceClient.ListCdnKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CdnKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCdnKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CdnKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CdnKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CdnKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCdnKeysAsync</summary>
        public async Task ListCdnKeysResourceNamesAsync()
        {
            // Snippet: ListCdnKeysAsync(LocationName, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCdnKeysResponse, CdnKey> response = videoStitcherServiceClient.ListCdnKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CdnKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCdnKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CdnKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CdnKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CdnKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCdnKey</summary>
        public void GetCdnKeyRequestObject()
        {
            // Snippet: GetCdnKey(GetCdnKeyRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            GetCdnKeyRequest request = new GetCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            // Make the request
            CdnKey response = videoStitcherServiceClient.GetCdnKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetCdnKeyAsync</summary>
        public async Task GetCdnKeyRequestObjectAsync()
        {
            // Snippet: GetCdnKeyAsync(GetCdnKeyRequest, CallSettings)
            // Additional: GetCdnKeyAsync(GetCdnKeyRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCdnKeyRequest request = new GetCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            // Make the request
            CdnKey response = await videoStitcherServiceClient.GetCdnKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCdnKey</summary>
        public void GetCdnKey()
        {
            // Snippet: GetCdnKey(string, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cdnKeys/[CDN_KEY]";
            // Make the request
            CdnKey response = videoStitcherServiceClient.GetCdnKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetCdnKeyAsync</summary>
        public async Task GetCdnKeyAsync()
        {
            // Snippet: GetCdnKeyAsync(string, CallSettings)
            // Additional: GetCdnKeyAsync(string, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cdnKeys/[CDN_KEY]";
            // Make the request
            CdnKey response = await videoStitcherServiceClient.GetCdnKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCdnKey</summary>
        public void GetCdnKeyResourceNames()
        {
            // Snippet: GetCdnKey(CdnKeyName, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            CdnKeyName name = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]");
            // Make the request
            CdnKey response = videoStitcherServiceClient.GetCdnKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetCdnKeyAsync</summary>
        public async Task GetCdnKeyResourceNamesAsync()
        {
            // Snippet: GetCdnKeyAsync(CdnKeyName, CallSettings)
            // Additional: GetCdnKeyAsync(CdnKeyName, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            CdnKeyName name = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]");
            // Make the request
            CdnKey response = await videoStitcherServiceClient.GetCdnKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCdnKey</summary>
        public void DeleteCdnKeyRequestObject()
        {
            // Snippet: DeleteCdnKey(DeleteCdnKeyRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            DeleteCdnKeyRequest request = new DeleteCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            // Make the request
            videoStitcherServiceClient.DeleteCdnKey(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCdnKeyAsync</summary>
        public async Task DeleteCdnKeyRequestObjectAsync()
        {
            // Snippet: DeleteCdnKeyAsync(DeleteCdnKeyRequest, CallSettings)
            // Additional: DeleteCdnKeyAsync(DeleteCdnKeyRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCdnKeyRequest request = new DeleteCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            // Make the request
            await videoStitcherServiceClient.DeleteCdnKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCdnKey</summary>
        public void DeleteCdnKey()
        {
            // Snippet: DeleteCdnKey(string, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cdnKeys/[CDN_KEY]";
            // Make the request
            videoStitcherServiceClient.DeleteCdnKey(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCdnKeyAsync</summary>
        public async Task DeleteCdnKeyAsync()
        {
            // Snippet: DeleteCdnKeyAsync(string, CallSettings)
            // Additional: DeleteCdnKeyAsync(string, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cdnKeys/[CDN_KEY]";
            // Make the request
            await videoStitcherServiceClient.DeleteCdnKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCdnKey</summary>
        public void DeleteCdnKeyResourceNames()
        {
            // Snippet: DeleteCdnKey(CdnKeyName, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            CdnKeyName name = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]");
            // Make the request
            videoStitcherServiceClient.DeleteCdnKey(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCdnKeyAsync</summary>
        public async Task DeleteCdnKeyResourceNamesAsync()
        {
            // Snippet: DeleteCdnKeyAsync(CdnKeyName, CallSettings)
            // Additional: DeleteCdnKeyAsync(CdnKeyName, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            CdnKeyName name = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]");
            // Make the request
            await videoStitcherServiceClient.DeleteCdnKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateCdnKey</summary>
        public void UpdateCdnKeyRequestObject()
        {
            // Snippet: UpdateCdnKey(UpdateCdnKeyRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            UpdateCdnKeyRequest request = new UpdateCdnKeyRequest
            {
                CdnKey = new CdnKey(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CdnKey response = videoStitcherServiceClient.UpdateCdnKey(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCdnKeyAsync</summary>
        public async Task UpdateCdnKeyRequestObjectAsync()
        {
            // Snippet: UpdateCdnKeyAsync(UpdateCdnKeyRequest, CallSettings)
            // Additional: UpdateCdnKeyAsync(UpdateCdnKeyRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCdnKeyRequest request = new UpdateCdnKeyRequest
            {
                CdnKey = new CdnKey(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CdnKey response = await videoStitcherServiceClient.UpdateCdnKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCdnKey</summary>
        public void UpdateCdnKey()
        {
            // Snippet: UpdateCdnKey(CdnKey, FieldMask, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            CdnKey cdnKey = new CdnKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CdnKey response = videoStitcherServiceClient.UpdateCdnKey(cdnKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCdnKeyAsync</summary>
        public async Task UpdateCdnKeyAsync()
        {
            // Snippet: UpdateCdnKeyAsync(CdnKey, FieldMask, CallSettings)
            // Additional: UpdateCdnKeyAsync(CdnKey, FieldMask, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            CdnKey cdnKey = new CdnKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CdnKey response = await videoStitcherServiceClient.UpdateCdnKeyAsync(cdnKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for CreateVodSession</summary>
        public void CreateVodSessionRequestObject()
        {
            // Snippet: CreateVodSession(CreateVodSessionRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            CreateVodSessionRequest request = new CreateVodSessionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VodSession = new VodSession(),
            };
            // Make the request
            VodSession response = videoStitcherServiceClient.CreateVodSession(request);
            // End snippet
        }

        /// <summary>Snippet for CreateVodSessionAsync</summary>
        public async Task CreateVodSessionRequestObjectAsync()
        {
            // Snippet: CreateVodSessionAsync(CreateVodSessionRequest, CallSettings)
            // Additional: CreateVodSessionAsync(CreateVodSessionRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateVodSessionRequest request = new CreateVodSessionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VodSession = new VodSession(),
            };
            // Make the request
            VodSession response = await videoStitcherServiceClient.CreateVodSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateVodSession</summary>
        public void CreateVodSession()
        {
            // Snippet: CreateVodSession(string, VodSession, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            VodSession vodSession = new VodSession();
            // Make the request
            VodSession response = videoStitcherServiceClient.CreateVodSession(parent, vodSession);
            // End snippet
        }

        /// <summary>Snippet for CreateVodSessionAsync</summary>
        public async Task CreateVodSessionAsync()
        {
            // Snippet: CreateVodSessionAsync(string, VodSession, CallSettings)
            // Additional: CreateVodSessionAsync(string, VodSession, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            VodSession vodSession = new VodSession();
            // Make the request
            VodSession response = await videoStitcherServiceClient.CreateVodSessionAsync(parent, vodSession);
            // End snippet
        }

        /// <summary>Snippet for CreateVodSession</summary>
        public void CreateVodSessionResourceNames()
        {
            // Snippet: CreateVodSession(LocationName, VodSession, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            VodSession vodSession = new VodSession();
            // Make the request
            VodSession response = videoStitcherServiceClient.CreateVodSession(parent, vodSession);
            // End snippet
        }

        /// <summary>Snippet for CreateVodSessionAsync</summary>
        public async Task CreateVodSessionResourceNamesAsync()
        {
            // Snippet: CreateVodSessionAsync(LocationName, VodSession, CallSettings)
            // Additional: CreateVodSessionAsync(LocationName, VodSession, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            VodSession vodSession = new VodSession();
            // Make the request
            VodSession response = await videoStitcherServiceClient.CreateVodSessionAsync(parent, vodSession);
            // End snippet
        }

        /// <summary>Snippet for GetVodSession</summary>
        public void GetVodSessionRequestObject()
        {
            // Snippet: GetVodSession(GetVodSessionRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            GetVodSessionRequest request = new GetVodSessionRequest
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
            };
            // Make the request
            VodSession response = videoStitcherServiceClient.GetVodSession(request);
            // End snippet
        }

        /// <summary>Snippet for GetVodSessionAsync</summary>
        public async Task GetVodSessionRequestObjectAsync()
        {
            // Snippet: GetVodSessionAsync(GetVodSessionRequest, CallSettings)
            // Additional: GetVodSessionAsync(GetVodSessionRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetVodSessionRequest request = new GetVodSessionRequest
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
            };
            // Make the request
            VodSession response = await videoStitcherServiceClient.GetVodSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVodSession</summary>
        public void GetVodSession()
        {
            // Snippet: GetVodSession(string, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vodSessions/[VOD_SESSION]";
            // Make the request
            VodSession response = videoStitcherServiceClient.GetVodSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetVodSessionAsync</summary>
        public async Task GetVodSessionAsync()
        {
            // Snippet: GetVodSessionAsync(string, CallSettings)
            // Additional: GetVodSessionAsync(string, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vodSessions/[VOD_SESSION]";
            // Make the request
            VodSession response = await videoStitcherServiceClient.GetVodSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVodSession</summary>
        public void GetVodSessionResourceNames()
        {
            // Snippet: GetVodSession(VodSessionName, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            VodSessionName name = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]");
            // Make the request
            VodSession response = videoStitcherServiceClient.GetVodSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetVodSessionAsync</summary>
        public async Task GetVodSessionResourceNamesAsync()
        {
            // Snippet: GetVodSessionAsync(VodSessionName, CallSettings)
            // Additional: GetVodSessionAsync(VodSessionName, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            VodSessionName name = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]");
            // Make the request
            VodSession response = await videoStitcherServiceClient.GetVodSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListVodStitchDetails</summary>
        public void ListVodStitchDetailsRequestObject()
        {
            // Snippet: ListVodStitchDetails(ListVodStitchDetailsRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            ListVodStitchDetailsRequest request = new ListVodStitchDetailsRequest
            {
                ParentAsVodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
            };
            // Make the request
            PagedEnumerable<ListVodStitchDetailsResponse, VodStitchDetail> response = videoStitcherServiceClient.ListVodStitchDetails(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VodStitchDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVodStitchDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VodStitchDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VodStitchDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VodStitchDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVodStitchDetailsAsync</summary>
        public async Task ListVodStitchDetailsRequestObjectAsync()
        {
            // Snippet: ListVodStitchDetailsAsync(ListVodStitchDetailsRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListVodStitchDetailsRequest request = new ListVodStitchDetailsRequest
            {
                ParentAsVodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListVodStitchDetailsResponse, VodStitchDetail> response = videoStitcherServiceClient.ListVodStitchDetailsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VodStitchDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVodStitchDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VodStitchDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VodStitchDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VodStitchDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVodStitchDetails</summary>
        public void ListVodStitchDetails()
        {
            // Snippet: ListVodStitchDetails(string, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/vodSessions/[VOD_SESSION]";
            // Make the request
            PagedEnumerable<ListVodStitchDetailsResponse, VodStitchDetail> response = videoStitcherServiceClient.ListVodStitchDetails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VodStitchDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVodStitchDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VodStitchDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VodStitchDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VodStitchDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVodStitchDetailsAsync</summary>
        public async Task ListVodStitchDetailsAsync()
        {
            // Snippet: ListVodStitchDetailsAsync(string, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/vodSessions/[VOD_SESSION]";
            // Make the request
            PagedAsyncEnumerable<ListVodStitchDetailsResponse, VodStitchDetail> response = videoStitcherServiceClient.ListVodStitchDetailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VodStitchDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVodStitchDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VodStitchDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VodStitchDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VodStitchDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVodStitchDetails</summary>
        public void ListVodStitchDetailsResourceNames()
        {
            // Snippet: ListVodStitchDetails(VodSessionName, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            VodSessionName parent = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]");
            // Make the request
            PagedEnumerable<ListVodStitchDetailsResponse, VodStitchDetail> response = videoStitcherServiceClient.ListVodStitchDetails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VodStitchDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVodStitchDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VodStitchDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VodStitchDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VodStitchDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVodStitchDetailsAsync</summary>
        public async Task ListVodStitchDetailsResourceNamesAsync()
        {
            // Snippet: ListVodStitchDetailsAsync(VodSessionName, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            VodSessionName parent = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]");
            // Make the request
            PagedAsyncEnumerable<ListVodStitchDetailsResponse, VodStitchDetail> response = videoStitcherServiceClient.ListVodStitchDetailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VodStitchDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVodStitchDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VodStitchDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VodStitchDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VodStitchDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetVodStitchDetail</summary>
        public void GetVodStitchDetailRequestObject()
        {
            // Snippet: GetVodStitchDetail(GetVodStitchDetailRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            GetVodStitchDetailRequest request = new GetVodStitchDetailRequest
            {
                VodStitchDetailName = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]"),
            };
            // Make the request
            VodStitchDetail response = videoStitcherServiceClient.GetVodStitchDetail(request);
            // End snippet
        }

        /// <summary>Snippet for GetVodStitchDetailAsync</summary>
        public async Task GetVodStitchDetailRequestObjectAsync()
        {
            // Snippet: GetVodStitchDetailAsync(GetVodStitchDetailRequest, CallSettings)
            // Additional: GetVodStitchDetailAsync(GetVodStitchDetailRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetVodStitchDetailRequest request = new GetVodStitchDetailRequest
            {
                VodStitchDetailName = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]"),
            };
            // Make the request
            VodStitchDetail response = await videoStitcherServiceClient.GetVodStitchDetailAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVodStitchDetail</summary>
        public void GetVodStitchDetail()
        {
            // Snippet: GetVodStitchDetail(string, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vodSessions/[VOD_SESSION]/vodStitchDetails/[VOD_STITCH_DETAIL]";
            // Make the request
            VodStitchDetail response = videoStitcherServiceClient.GetVodStitchDetail(name);
            // End snippet
        }

        /// <summary>Snippet for GetVodStitchDetailAsync</summary>
        public async Task GetVodStitchDetailAsync()
        {
            // Snippet: GetVodStitchDetailAsync(string, CallSettings)
            // Additional: GetVodStitchDetailAsync(string, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vodSessions/[VOD_SESSION]/vodStitchDetails/[VOD_STITCH_DETAIL]";
            // Make the request
            VodStitchDetail response = await videoStitcherServiceClient.GetVodStitchDetailAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVodStitchDetail</summary>
        public void GetVodStitchDetailResourceNames()
        {
            // Snippet: GetVodStitchDetail(VodStitchDetailName, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            VodStitchDetailName name = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]");
            // Make the request
            VodStitchDetail response = videoStitcherServiceClient.GetVodStitchDetail(name);
            // End snippet
        }

        /// <summary>Snippet for GetVodStitchDetailAsync</summary>
        public async Task GetVodStitchDetailResourceNamesAsync()
        {
            // Snippet: GetVodStitchDetailAsync(VodStitchDetailName, CallSettings)
            // Additional: GetVodStitchDetailAsync(VodStitchDetailName, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            VodStitchDetailName name = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]");
            // Make the request
            VodStitchDetail response = await videoStitcherServiceClient.GetVodStitchDetailAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListVodAdTagDetails</summary>
        public void ListVodAdTagDetailsRequestObject()
        {
            // Snippet: ListVodAdTagDetails(ListVodAdTagDetailsRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            ListVodAdTagDetailsRequest request = new ListVodAdTagDetailsRequest
            {
                ParentAsVodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
            };
            // Make the request
            PagedEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> response = videoStitcherServiceClient.ListVodAdTagDetails(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VodAdTagDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVodAdTagDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VodAdTagDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VodAdTagDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VodAdTagDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVodAdTagDetailsAsync</summary>
        public async Task ListVodAdTagDetailsRequestObjectAsync()
        {
            // Snippet: ListVodAdTagDetailsAsync(ListVodAdTagDetailsRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListVodAdTagDetailsRequest request = new ListVodAdTagDetailsRequest
            {
                ParentAsVodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> response = videoStitcherServiceClient.ListVodAdTagDetailsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VodAdTagDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVodAdTagDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VodAdTagDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VodAdTagDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VodAdTagDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVodAdTagDetails</summary>
        public void ListVodAdTagDetails()
        {
            // Snippet: ListVodAdTagDetails(string, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/vodSessions/[VOD_SESSION]";
            // Make the request
            PagedEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> response = videoStitcherServiceClient.ListVodAdTagDetails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VodAdTagDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVodAdTagDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VodAdTagDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VodAdTagDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VodAdTagDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVodAdTagDetailsAsync</summary>
        public async Task ListVodAdTagDetailsAsync()
        {
            // Snippet: ListVodAdTagDetailsAsync(string, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/vodSessions/[VOD_SESSION]";
            // Make the request
            PagedAsyncEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> response = videoStitcherServiceClient.ListVodAdTagDetailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VodAdTagDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVodAdTagDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VodAdTagDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VodAdTagDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VodAdTagDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVodAdTagDetails</summary>
        public void ListVodAdTagDetailsResourceNames()
        {
            // Snippet: ListVodAdTagDetails(VodSessionName, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            VodSessionName parent = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]");
            // Make the request
            PagedEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> response = videoStitcherServiceClient.ListVodAdTagDetails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VodAdTagDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVodAdTagDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VodAdTagDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VodAdTagDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VodAdTagDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVodAdTagDetailsAsync</summary>
        public async Task ListVodAdTagDetailsResourceNamesAsync()
        {
            // Snippet: ListVodAdTagDetailsAsync(VodSessionName, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            VodSessionName parent = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]");
            // Make the request
            PagedAsyncEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> response = videoStitcherServiceClient.ListVodAdTagDetailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VodAdTagDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVodAdTagDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VodAdTagDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VodAdTagDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VodAdTagDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetVodAdTagDetail</summary>
        public void GetVodAdTagDetailRequestObject()
        {
            // Snippet: GetVodAdTagDetail(GetVodAdTagDetailRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            GetVodAdTagDetailRequest request = new GetVodAdTagDetailRequest
            {
                VodAdTagDetailName = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]"),
            };
            // Make the request
            VodAdTagDetail response = videoStitcherServiceClient.GetVodAdTagDetail(request);
            // End snippet
        }

        /// <summary>Snippet for GetVodAdTagDetailAsync</summary>
        public async Task GetVodAdTagDetailRequestObjectAsync()
        {
            // Snippet: GetVodAdTagDetailAsync(GetVodAdTagDetailRequest, CallSettings)
            // Additional: GetVodAdTagDetailAsync(GetVodAdTagDetailRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetVodAdTagDetailRequest request = new GetVodAdTagDetailRequest
            {
                VodAdTagDetailName = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]"),
            };
            // Make the request
            VodAdTagDetail response = await videoStitcherServiceClient.GetVodAdTagDetailAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVodAdTagDetail</summary>
        public void GetVodAdTagDetail()
        {
            // Snippet: GetVodAdTagDetail(string, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vodSessions/[VOD_SESSION]/vodAdTagDetails/[VOD_AD_TAG_DETAIL]";
            // Make the request
            VodAdTagDetail response = videoStitcherServiceClient.GetVodAdTagDetail(name);
            // End snippet
        }

        /// <summary>Snippet for GetVodAdTagDetailAsync</summary>
        public async Task GetVodAdTagDetailAsync()
        {
            // Snippet: GetVodAdTagDetailAsync(string, CallSettings)
            // Additional: GetVodAdTagDetailAsync(string, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vodSessions/[VOD_SESSION]/vodAdTagDetails/[VOD_AD_TAG_DETAIL]";
            // Make the request
            VodAdTagDetail response = await videoStitcherServiceClient.GetVodAdTagDetailAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVodAdTagDetail</summary>
        public void GetVodAdTagDetailResourceNames()
        {
            // Snippet: GetVodAdTagDetail(VodAdTagDetailName, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            VodAdTagDetailName name = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]");
            // Make the request
            VodAdTagDetail response = videoStitcherServiceClient.GetVodAdTagDetail(name);
            // End snippet
        }

        /// <summary>Snippet for GetVodAdTagDetailAsync</summary>
        public async Task GetVodAdTagDetailResourceNamesAsync()
        {
            // Snippet: GetVodAdTagDetailAsync(VodAdTagDetailName, CallSettings)
            // Additional: GetVodAdTagDetailAsync(VodAdTagDetailName, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            VodAdTagDetailName name = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]");
            // Make the request
            VodAdTagDetail response = await videoStitcherServiceClient.GetVodAdTagDetailAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLiveAdTagDetails</summary>
        public void ListLiveAdTagDetailsRequestObject()
        {
            // Snippet: ListLiveAdTagDetails(ListLiveAdTagDetailsRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            ListLiveAdTagDetailsRequest request = new ListLiveAdTagDetailsRequest
            {
                ParentAsLiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
            };
            // Make the request
            PagedEnumerable<ListLiveAdTagDetailsResponse, LiveAdTagDetail> response = videoStitcherServiceClient.ListLiveAdTagDetails(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LiveAdTagDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLiveAdTagDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LiveAdTagDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LiveAdTagDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LiveAdTagDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLiveAdTagDetailsAsync</summary>
        public async Task ListLiveAdTagDetailsRequestObjectAsync()
        {
            // Snippet: ListLiveAdTagDetailsAsync(ListLiveAdTagDetailsRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLiveAdTagDetailsRequest request = new ListLiveAdTagDetailsRequest
            {
                ParentAsLiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListLiveAdTagDetailsResponse, LiveAdTagDetail> response = videoStitcherServiceClient.ListLiveAdTagDetailsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LiveAdTagDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLiveAdTagDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LiveAdTagDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LiveAdTagDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LiveAdTagDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLiveAdTagDetails</summary>
        public void ListLiveAdTagDetails()
        {
            // Snippet: ListLiveAdTagDetails(string, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/liveSessions/[LIVE_SESSION]";
            // Make the request
            PagedEnumerable<ListLiveAdTagDetailsResponse, LiveAdTagDetail> response = videoStitcherServiceClient.ListLiveAdTagDetails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LiveAdTagDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLiveAdTagDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LiveAdTagDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LiveAdTagDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LiveAdTagDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLiveAdTagDetailsAsync</summary>
        public async Task ListLiveAdTagDetailsAsync()
        {
            // Snippet: ListLiveAdTagDetailsAsync(string, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/liveSessions/[LIVE_SESSION]";
            // Make the request
            PagedAsyncEnumerable<ListLiveAdTagDetailsResponse, LiveAdTagDetail> response = videoStitcherServiceClient.ListLiveAdTagDetailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LiveAdTagDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLiveAdTagDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LiveAdTagDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LiveAdTagDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LiveAdTagDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLiveAdTagDetails</summary>
        public void ListLiveAdTagDetailsResourceNames()
        {
            // Snippet: ListLiveAdTagDetails(LiveSessionName, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            LiveSessionName parent = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]");
            // Make the request
            PagedEnumerable<ListLiveAdTagDetailsResponse, LiveAdTagDetail> response = videoStitcherServiceClient.ListLiveAdTagDetails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LiveAdTagDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLiveAdTagDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LiveAdTagDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LiveAdTagDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LiveAdTagDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLiveAdTagDetailsAsync</summary>
        public async Task ListLiveAdTagDetailsResourceNamesAsync()
        {
            // Snippet: ListLiveAdTagDetailsAsync(LiveSessionName, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            LiveSessionName parent = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]");
            // Make the request
            PagedAsyncEnumerable<ListLiveAdTagDetailsResponse, LiveAdTagDetail> response = videoStitcherServiceClient.ListLiveAdTagDetailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LiveAdTagDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLiveAdTagDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LiveAdTagDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LiveAdTagDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LiveAdTagDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetLiveAdTagDetail</summary>
        public void GetLiveAdTagDetailRequestObject()
        {
            // Snippet: GetLiveAdTagDetail(GetLiveAdTagDetailRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            GetLiveAdTagDetailRequest request = new GetLiveAdTagDetailRequest
            {
                LiveAdTagDetailName = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]"),
            };
            // Make the request
            LiveAdTagDetail response = videoStitcherServiceClient.GetLiveAdTagDetail(request);
            // End snippet
        }

        /// <summary>Snippet for GetLiveAdTagDetailAsync</summary>
        public async Task GetLiveAdTagDetailRequestObjectAsync()
        {
            // Snippet: GetLiveAdTagDetailAsync(GetLiveAdTagDetailRequest, CallSettings)
            // Additional: GetLiveAdTagDetailAsync(GetLiveAdTagDetailRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLiveAdTagDetailRequest request = new GetLiveAdTagDetailRequest
            {
                LiveAdTagDetailName = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]"),
            };
            // Make the request
            LiveAdTagDetail response = await videoStitcherServiceClient.GetLiveAdTagDetailAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLiveAdTagDetail</summary>
        public void GetLiveAdTagDetail()
        {
            // Snippet: GetLiveAdTagDetail(string, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/liveSessions/[LIVE_SESSION]/liveAdTagDetails/[LIVE_AD_TAG_DETAIL]";
            // Make the request
            LiveAdTagDetail response = videoStitcherServiceClient.GetLiveAdTagDetail(name);
            // End snippet
        }

        /// <summary>Snippet for GetLiveAdTagDetailAsync</summary>
        public async Task GetLiveAdTagDetailAsync()
        {
            // Snippet: GetLiveAdTagDetailAsync(string, CallSettings)
            // Additional: GetLiveAdTagDetailAsync(string, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/liveSessions/[LIVE_SESSION]/liveAdTagDetails/[LIVE_AD_TAG_DETAIL]";
            // Make the request
            LiveAdTagDetail response = await videoStitcherServiceClient.GetLiveAdTagDetailAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLiveAdTagDetail</summary>
        public void GetLiveAdTagDetailResourceNames()
        {
            // Snippet: GetLiveAdTagDetail(LiveAdTagDetailName, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            LiveAdTagDetailName name = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]");
            // Make the request
            LiveAdTagDetail response = videoStitcherServiceClient.GetLiveAdTagDetail(name);
            // End snippet
        }

        /// <summary>Snippet for GetLiveAdTagDetailAsync</summary>
        public async Task GetLiveAdTagDetailResourceNamesAsync()
        {
            // Snippet: GetLiveAdTagDetailAsync(LiveAdTagDetailName, CallSettings)
            // Additional: GetLiveAdTagDetailAsync(LiveAdTagDetailName, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            LiveAdTagDetailName name = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]");
            // Make the request
            LiveAdTagDetail response = await videoStitcherServiceClient.GetLiveAdTagDetailAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSlate</summary>
        public void CreateSlateRequestObject()
        {
            // Snippet: CreateSlate(CreateSlateRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            CreateSlateRequest request = new CreateSlateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SlateId = "",
                Slate = new Slate(),
            };
            // Make the request
            Slate response = videoStitcherServiceClient.CreateSlate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSlateAsync</summary>
        public async Task CreateSlateRequestObjectAsync()
        {
            // Snippet: CreateSlateAsync(CreateSlateRequest, CallSettings)
            // Additional: CreateSlateAsync(CreateSlateRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSlateRequest request = new CreateSlateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SlateId = "",
                Slate = new Slate(),
            };
            // Make the request
            Slate response = await videoStitcherServiceClient.CreateSlateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSlate</summary>
        public void CreateSlate()
        {
            // Snippet: CreateSlate(string, Slate, string, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Slate slate = new Slate();
            string slateId = "";
            // Make the request
            Slate response = videoStitcherServiceClient.CreateSlate(parent, slate, slateId);
            // End snippet
        }

        /// <summary>Snippet for CreateSlateAsync</summary>
        public async Task CreateSlateAsync()
        {
            // Snippet: CreateSlateAsync(string, Slate, string, CallSettings)
            // Additional: CreateSlateAsync(string, Slate, string, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Slate slate = new Slate();
            string slateId = "";
            // Make the request
            Slate response = await videoStitcherServiceClient.CreateSlateAsync(parent, slate, slateId);
            // End snippet
        }

        /// <summary>Snippet for CreateSlate</summary>
        public void CreateSlateResourceNames()
        {
            // Snippet: CreateSlate(LocationName, Slate, string, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Slate slate = new Slate();
            string slateId = "";
            // Make the request
            Slate response = videoStitcherServiceClient.CreateSlate(parent, slate, slateId);
            // End snippet
        }

        /// <summary>Snippet for CreateSlateAsync</summary>
        public async Task CreateSlateResourceNamesAsync()
        {
            // Snippet: CreateSlateAsync(LocationName, Slate, string, CallSettings)
            // Additional: CreateSlateAsync(LocationName, Slate, string, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Slate slate = new Slate();
            string slateId = "";
            // Make the request
            Slate response = await videoStitcherServiceClient.CreateSlateAsync(parent, slate, slateId);
            // End snippet
        }

        /// <summary>Snippet for ListSlates</summary>
        public void ListSlatesRequestObject()
        {
            // Snippet: ListSlates(ListSlatesRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            ListSlatesRequest request = new ListSlatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSlatesResponse, Slate> response = videoStitcherServiceClient.ListSlates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Slate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSlatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Slate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Slate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Slate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSlatesAsync</summary>
        public async Task ListSlatesRequestObjectAsync()
        {
            // Snippet: ListSlatesAsync(ListSlatesRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSlatesRequest request = new ListSlatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSlatesResponse, Slate> response = videoStitcherServiceClient.ListSlatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Slate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSlatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Slate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Slate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Slate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSlates</summary>
        public void ListSlates()
        {
            // Snippet: ListSlates(string, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSlatesResponse, Slate> response = videoStitcherServiceClient.ListSlates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Slate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSlatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Slate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Slate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Slate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSlatesAsync</summary>
        public async Task ListSlatesAsync()
        {
            // Snippet: ListSlatesAsync(string, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSlatesResponse, Slate> response = videoStitcherServiceClient.ListSlatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Slate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSlatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Slate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Slate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Slate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSlates</summary>
        public void ListSlatesResourceNames()
        {
            // Snippet: ListSlates(LocationName, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSlatesResponse, Slate> response = videoStitcherServiceClient.ListSlates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Slate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSlatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Slate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Slate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Slate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSlatesAsync</summary>
        public async Task ListSlatesResourceNamesAsync()
        {
            // Snippet: ListSlatesAsync(LocationName, string, int?, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSlatesResponse, Slate> response = videoStitcherServiceClient.ListSlatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Slate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSlatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Slate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Slate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Slate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSlate</summary>
        public void GetSlateRequestObject()
        {
            // Snippet: GetSlate(GetSlateRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            GetSlateRequest request = new GetSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            // Make the request
            Slate response = videoStitcherServiceClient.GetSlate(request);
            // End snippet
        }

        /// <summary>Snippet for GetSlateAsync</summary>
        public async Task GetSlateRequestObjectAsync()
        {
            // Snippet: GetSlateAsync(GetSlateRequest, CallSettings)
            // Additional: GetSlateAsync(GetSlateRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSlateRequest request = new GetSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            // Make the request
            Slate response = await videoStitcherServiceClient.GetSlateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSlate</summary>
        public void GetSlate()
        {
            // Snippet: GetSlate(string, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/slates/[SLATE]";
            // Make the request
            Slate response = videoStitcherServiceClient.GetSlate(name);
            // End snippet
        }

        /// <summary>Snippet for GetSlateAsync</summary>
        public async Task GetSlateAsync()
        {
            // Snippet: GetSlateAsync(string, CallSettings)
            // Additional: GetSlateAsync(string, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/slates/[SLATE]";
            // Make the request
            Slate response = await videoStitcherServiceClient.GetSlateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSlate</summary>
        public void GetSlateResourceNames()
        {
            // Snippet: GetSlate(SlateName, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            SlateName name = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]");
            // Make the request
            Slate response = videoStitcherServiceClient.GetSlate(name);
            // End snippet
        }

        /// <summary>Snippet for GetSlateAsync</summary>
        public async Task GetSlateResourceNamesAsync()
        {
            // Snippet: GetSlateAsync(SlateName, CallSettings)
            // Additional: GetSlateAsync(SlateName, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            SlateName name = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]");
            // Make the request
            Slate response = await videoStitcherServiceClient.GetSlateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSlate</summary>
        public void UpdateSlateRequestObject()
        {
            // Snippet: UpdateSlate(UpdateSlateRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            UpdateSlateRequest request = new UpdateSlateRequest
            {
                Slate = new Slate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Slate response = videoStitcherServiceClient.UpdateSlate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSlateAsync</summary>
        public async Task UpdateSlateRequestObjectAsync()
        {
            // Snippet: UpdateSlateAsync(UpdateSlateRequest, CallSettings)
            // Additional: UpdateSlateAsync(UpdateSlateRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSlateRequest request = new UpdateSlateRequest
            {
                Slate = new Slate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Slate response = await videoStitcherServiceClient.UpdateSlateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSlate</summary>
        public void UpdateSlate()
        {
            // Snippet: UpdateSlate(Slate, FieldMask, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            Slate slate = new Slate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Slate response = videoStitcherServiceClient.UpdateSlate(slate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSlateAsync</summary>
        public async Task UpdateSlateAsync()
        {
            // Snippet: UpdateSlateAsync(Slate, FieldMask, CallSettings)
            // Additional: UpdateSlateAsync(Slate, FieldMask, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            Slate slate = new Slate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Slate response = await videoStitcherServiceClient.UpdateSlateAsync(slate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSlate</summary>
        public void DeleteSlateRequestObject()
        {
            // Snippet: DeleteSlate(DeleteSlateRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            DeleteSlateRequest request = new DeleteSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            // Make the request
            videoStitcherServiceClient.DeleteSlate(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSlateAsync</summary>
        public async Task DeleteSlateRequestObjectAsync()
        {
            // Snippet: DeleteSlateAsync(DeleteSlateRequest, CallSettings)
            // Additional: DeleteSlateAsync(DeleteSlateRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSlateRequest request = new DeleteSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            // Make the request
            await videoStitcherServiceClient.DeleteSlateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSlate</summary>
        public void DeleteSlate()
        {
            // Snippet: DeleteSlate(string, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/slates/[SLATE]";
            // Make the request
            videoStitcherServiceClient.DeleteSlate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSlateAsync</summary>
        public async Task DeleteSlateAsync()
        {
            // Snippet: DeleteSlateAsync(string, CallSettings)
            // Additional: DeleteSlateAsync(string, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/slates/[SLATE]";
            // Make the request
            await videoStitcherServiceClient.DeleteSlateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSlate</summary>
        public void DeleteSlateResourceNames()
        {
            // Snippet: DeleteSlate(SlateName, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            SlateName name = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]");
            // Make the request
            videoStitcherServiceClient.DeleteSlate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSlateAsync</summary>
        public async Task DeleteSlateResourceNamesAsync()
        {
            // Snippet: DeleteSlateAsync(SlateName, CallSettings)
            // Additional: DeleteSlateAsync(SlateName, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            SlateName name = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]");
            // Make the request
            await videoStitcherServiceClient.DeleteSlateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateLiveSession</summary>
        public void CreateLiveSessionRequestObject()
        {
            // Snippet: CreateLiveSession(CreateLiveSessionRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            CreateLiveSessionRequest request = new CreateLiveSessionRequest
            {
                ParentAsLiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                LiveSession = new LiveSession(),
            };
            // Make the request
            LiveSession response = videoStitcherServiceClient.CreateLiveSession(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLiveSessionAsync</summary>
        public async Task CreateLiveSessionRequestObjectAsync()
        {
            // Snippet: CreateLiveSessionAsync(CreateLiveSessionRequest, CallSettings)
            // Additional: CreateLiveSessionAsync(CreateLiveSessionRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateLiveSessionRequest request = new CreateLiveSessionRequest
            {
                ParentAsLiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                LiveSession = new LiveSession(),
            };
            // Make the request
            LiveSession response = await videoStitcherServiceClient.CreateLiveSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLiveSession</summary>
        public void CreateLiveSession()
        {
            // Snippet: CreateLiveSession(string, LiveSession, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/liveSessions/[LIVE_SESSION]";
            LiveSession liveSession = new LiveSession();
            // Make the request
            LiveSession response = videoStitcherServiceClient.CreateLiveSession(parent, liveSession);
            // End snippet
        }

        /// <summary>Snippet for CreateLiveSessionAsync</summary>
        public async Task CreateLiveSessionAsync()
        {
            // Snippet: CreateLiveSessionAsync(string, LiveSession, CallSettings)
            // Additional: CreateLiveSessionAsync(string, LiveSession, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/liveSessions/[LIVE_SESSION]";
            LiveSession liveSession = new LiveSession();
            // Make the request
            LiveSession response = await videoStitcherServiceClient.CreateLiveSessionAsync(parent, liveSession);
            // End snippet
        }

        /// <summary>Snippet for CreateLiveSession</summary>
        public void CreateLiveSessionResourceNames()
        {
            // Snippet: CreateLiveSession(LiveSessionName, LiveSession, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            LiveSessionName parent = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]");
            LiveSession liveSession = new LiveSession();
            // Make the request
            LiveSession response = videoStitcherServiceClient.CreateLiveSession(parent, liveSession);
            // End snippet
        }

        /// <summary>Snippet for CreateLiveSessionAsync</summary>
        public async Task CreateLiveSessionResourceNamesAsync()
        {
            // Snippet: CreateLiveSessionAsync(LiveSessionName, LiveSession, CallSettings)
            // Additional: CreateLiveSessionAsync(LiveSessionName, LiveSession, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            LiveSessionName parent = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]");
            LiveSession liveSession = new LiveSession();
            // Make the request
            LiveSession response = await videoStitcherServiceClient.CreateLiveSessionAsync(parent, liveSession);
            // End snippet
        }

        /// <summary>Snippet for GetLiveSession</summary>
        public void GetLiveSessionRequestObject()
        {
            // Snippet: GetLiveSession(GetLiveSessionRequest, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            GetLiveSessionRequest request = new GetLiveSessionRequest
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
            };
            // Make the request
            LiveSession response = videoStitcherServiceClient.GetLiveSession(request);
            // End snippet
        }

        /// <summary>Snippet for GetLiveSessionAsync</summary>
        public async Task GetLiveSessionRequestObjectAsync()
        {
            // Snippet: GetLiveSessionAsync(GetLiveSessionRequest, CallSettings)
            // Additional: GetLiveSessionAsync(GetLiveSessionRequest, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLiveSessionRequest request = new GetLiveSessionRequest
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
            };
            // Make the request
            LiveSession response = await videoStitcherServiceClient.GetLiveSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLiveSession</summary>
        public void GetLiveSession()
        {
            // Snippet: GetLiveSession(string, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/liveSessions/[LIVE_SESSION]";
            // Make the request
            LiveSession response = videoStitcherServiceClient.GetLiveSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetLiveSessionAsync</summary>
        public async Task GetLiveSessionAsync()
        {
            // Snippet: GetLiveSessionAsync(string, CallSettings)
            // Additional: GetLiveSessionAsync(string, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/liveSessions/[LIVE_SESSION]";
            // Make the request
            LiveSession response = await videoStitcherServiceClient.GetLiveSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLiveSession</summary>
        public void GetLiveSessionResourceNames()
        {
            // Snippet: GetLiveSession(LiveSessionName, CallSettings)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            LiveSessionName name = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]");
            // Make the request
            LiveSession response = videoStitcherServiceClient.GetLiveSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetLiveSessionAsync</summary>
        public async Task GetLiveSessionResourceNamesAsync()
        {
            // Snippet: GetLiveSessionAsync(LiveSessionName, CallSettings)
            // Additional: GetLiveSessionAsync(LiveSessionName, CancellationToken)
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = await VideoStitcherServiceClient.CreateAsync();
            // Initialize request argument(s)
            LiveSessionName name = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]");
            // Make the request
            LiveSession response = await videoStitcherServiceClient.GetLiveSessionAsync(name);
            // End snippet
        }
    }
}
