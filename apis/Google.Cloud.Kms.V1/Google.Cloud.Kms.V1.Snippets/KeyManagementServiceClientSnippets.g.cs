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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Kms.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedKeyManagementServiceClientSnippets
    {
        /// <summary>Snippet for ListKeyRings</summary>
        public void ListKeyRingsRequestObject()
        {
            // Snippet: ListKeyRings(ListKeyRingsRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ListKeyRingsRequest request = new ListKeyRingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListKeyRingsResponse, KeyRing> response = keyManagementServiceClient.ListKeyRings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyRing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeyRingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyRing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyRing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyRing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyRingsAsync</summary>
        public async Task ListKeyRingsRequestObjectAsync()
        {
            // Snippet: ListKeyRingsAsync(ListKeyRingsRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListKeyRingsRequest request = new ListKeyRingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListKeyRingsResponse, KeyRing> response = keyManagementServiceClient.ListKeyRingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyRing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeyRingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyRing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyRing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyRing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyRings</summary>
        public void ListKeyRings()
        {
            // Snippet: ListKeyRings(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListKeyRingsResponse, KeyRing> response = keyManagementServiceClient.ListKeyRings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyRing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeyRingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyRing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyRing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyRing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyRingsAsync</summary>
        public async Task ListKeyRingsAsync()
        {
            // Snippet: ListKeyRingsAsync(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListKeyRingsResponse, KeyRing> response = keyManagementServiceClient.ListKeyRingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyRing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeyRingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyRing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyRing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyRing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyRings</summary>
        public void ListKeyRingsResourceNames()
        {
            // Snippet: ListKeyRings(LocationName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListKeyRingsResponse, KeyRing> response = keyManagementServiceClient.ListKeyRings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyRing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeyRingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyRing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyRing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyRing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyRingsAsync</summary>
        public async Task ListKeyRingsResourceNamesAsync()
        {
            // Snippet: ListKeyRingsAsync(LocationName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListKeyRingsResponse, KeyRing> response = keyManagementServiceClient.ListKeyRingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyRing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeyRingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyRing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyRing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyRing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeys</summary>
        public void ListCryptoKeysRequestObject()
        {
            // Snippet: ListCryptoKeys(ListCryptoKeysRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ListCryptoKeysRequest request = new ListCryptoKeysRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                VersionView = CryptoKeyVersion.Types.CryptoKeyVersionView.Unspecified,
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCryptoKeysResponse, CryptoKey> response = keyManagementServiceClient.ListCryptoKeys(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CryptoKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeysAsync</summary>
        public async Task ListCryptoKeysRequestObjectAsync()
        {
            // Snippet: ListCryptoKeysAsync(ListCryptoKeysRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCryptoKeysRequest request = new ListCryptoKeysRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                VersionView = CryptoKeyVersion.Types.CryptoKeyVersionView.Unspecified,
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeysResponse, CryptoKey> response = keyManagementServiceClient.ListCryptoKeysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CryptoKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeys</summary>
        public void ListCryptoKeys()
        {
            // Snippet: ListCryptoKeys(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            // Make the request
            PagedEnumerable<ListCryptoKeysResponse, CryptoKey> response = keyManagementServiceClient.ListCryptoKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CryptoKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeysAsync</summary>
        public async Task ListCryptoKeysAsync()
        {
            // Snippet: ListCryptoKeysAsync(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeysResponse, CryptoKey> response = keyManagementServiceClient.ListCryptoKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CryptoKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeys</summary>
        public void ListCryptoKeysResourceNames()
        {
            // Snippet: ListCryptoKeys(KeyRingName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            PagedEnumerable<ListCryptoKeysResponse, CryptoKey> response = keyManagementServiceClient.ListCryptoKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CryptoKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeysAsync</summary>
        public async Task ListCryptoKeysResourceNamesAsync()
        {
            // Snippet: ListCryptoKeysAsync(KeyRingName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeysResponse, CryptoKey> response = keyManagementServiceClient.ListCryptoKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CryptoKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersions</summary>
        public void ListCryptoKeyVersionsRequestObject()
        {
            // Snippet: ListCryptoKeyVersions(ListCryptoKeyVersionsRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ListCryptoKeyVersionsRequest request = new ListCryptoKeyVersionsRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                View = CryptoKeyVersion.Types.CryptoKeyVersionView.Unspecified,
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response = keyManagementServiceClient.ListCryptoKeyVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CryptoKeyVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeyVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKeyVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKeyVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKeyVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersionsAsync</summary>
        public async Task ListCryptoKeyVersionsRequestObjectAsync()
        {
            // Snippet: ListCryptoKeyVersionsAsync(ListCryptoKeyVersionsRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCryptoKeyVersionsRequest request = new ListCryptoKeyVersionsRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                View = CryptoKeyVersion.Types.CryptoKeyVersionView.Unspecified,
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response = keyManagementServiceClient.ListCryptoKeyVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CryptoKeyVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeyVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKeyVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKeyVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKeyVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersions</summary>
        public void ListCryptoKeyVersions()
        {
            // Snippet: ListCryptoKeyVersions(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            // Make the request
            PagedEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response = keyManagementServiceClient.ListCryptoKeyVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CryptoKeyVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeyVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKeyVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKeyVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKeyVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersionsAsync</summary>
        public async Task ListCryptoKeyVersionsAsync()
        {
            // Snippet: ListCryptoKeyVersionsAsync(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response = keyManagementServiceClient.ListCryptoKeyVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CryptoKeyVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeyVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKeyVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKeyVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKeyVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersions</summary>
        public void ListCryptoKeyVersionsResourceNames()
        {
            // Snippet: ListCryptoKeyVersions(CryptoKeyName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyName parent = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            // Make the request
            PagedEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response = keyManagementServiceClient.ListCryptoKeyVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CryptoKeyVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeyVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKeyVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKeyVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKeyVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersionsAsync</summary>
        public async Task ListCryptoKeyVersionsResourceNamesAsync()
        {
            // Snippet: ListCryptoKeyVersionsAsync(CryptoKeyName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyName parent = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response = keyManagementServiceClient.ListCryptoKeyVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CryptoKeyVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeyVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKeyVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKeyVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKeyVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobs</summary>
        public void ListImportJobsRequestObject()
        {
            // Snippet: ListImportJobs(ListImportJobsRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ListImportJobsRequest request = new ListImportJobsRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListImportJobsResponse, ImportJob> response = keyManagementServiceClient.ListImportJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ImportJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListImportJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobsAsync</summary>
        public async Task ListImportJobsRequestObjectAsync()
        {
            // Snippet: ListImportJobsAsync(ListImportJobsRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListImportJobsRequest request = new ListImportJobsRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> response = keyManagementServiceClient.ListImportJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ImportJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListImportJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobs</summary>
        public void ListImportJobs()
        {
            // Snippet: ListImportJobs(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            // Make the request
            PagedEnumerable<ListImportJobsResponse, ImportJob> response = keyManagementServiceClient.ListImportJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ImportJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListImportJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobsAsync</summary>
        public async Task ListImportJobsAsync()
        {
            // Snippet: ListImportJobsAsync(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            // Make the request
            PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> response = keyManagementServiceClient.ListImportJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ImportJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListImportJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobs</summary>
        public void ListImportJobsResourceNames()
        {
            // Snippet: ListImportJobs(KeyRingName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            PagedEnumerable<ListImportJobsResponse, ImportJob> response = keyManagementServiceClient.ListImportJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ImportJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListImportJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobsAsync</summary>
        public async Task ListImportJobsResourceNamesAsync()
        {
            // Snippet: ListImportJobsAsync(KeyRingName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> response = keyManagementServiceClient.ListImportJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ImportJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListImportJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetKeyRing</summary>
        public void GetKeyRingRequestObject()
        {
            // Snippet: GetKeyRing(GetKeyRingRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetKeyRingRequest request = new GetKeyRingRequest
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            // Make the request
            KeyRing response = keyManagementServiceClient.GetKeyRing(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeyRingAsync</summary>
        public async Task GetKeyRingRequestObjectAsync()
        {
            // Snippet: GetKeyRingAsync(GetKeyRingRequest, CallSettings)
            // Additional: GetKeyRingAsync(GetKeyRingRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetKeyRingRequest request = new GetKeyRingRequest
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            // Make the request
            KeyRing response = await keyManagementServiceClient.GetKeyRingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeyRing</summary>
        public void GetKeyRing()
        {
            // Snippet: GetKeyRing(string, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            // Make the request
            KeyRing response = keyManagementServiceClient.GetKeyRing(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyRingAsync</summary>
        public async Task GetKeyRingAsync()
        {
            // Snippet: GetKeyRingAsync(string, CallSettings)
            // Additional: GetKeyRingAsync(string, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            // Make the request
            KeyRing response = await keyManagementServiceClient.GetKeyRingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyRing</summary>
        public void GetKeyRingResourceNames()
        {
            // Snippet: GetKeyRing(KeyRingName, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName name = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            KeyRing response = keyManagementServiceClient.GetKeyRing(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyRingAsync</summary>
        public async Task GetKeyRingResourceNamesAsync()
        {
            // Snippet: GetKeyRingAsync(KeyRingName, CallSettings)
            // Additional: GetKeyRingAsync(KeyRingName, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName name = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            KeyRing response = await keyManagementServiceClient.GetKeyRingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKey</summary>
        public void GetCryptoKeyRequestObject()
        {
            // Snippet: GetCryptoKey(GetCryptoKeyRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetCryptoKeyRequest request = new GetCryptoKeyRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            CryptoKey response = keyManagementServiceClient.GetCryptoKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyAsync</summary>
        public async Task GetCryptoKeyRequestObjectAsync()
        {
            // Snippet: GetCryptoKeyAsync(GetCryptoKeyRequest, CallSettings)
            // Additional: GetCryptoKeyAsync(GetCryptoKeyRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCryptoKeyRequest request = new GetCryptoKeyRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            CryptoKey response = await keyManagementServiceClient.GetCryptoKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKey</summary>
        public void GetCryptoKey()
        {
            // Snippet: GetCryptoKey(string, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            // Make the request
            CryptoKey response = keyManagementServiceClient.GetCryptoKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyAsync</summary>
        public async Task GetCryptoKeyAsync()
        {
            // Snippet: GetCryptoKeyAsync(string, CallSettings)
            // Additional: GetCryptoKeyAsync(string, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            // Make the request
            CryptoKey response = await keyManagementServiceClient.GetCryptoKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKey</summary>
        public void GetCryptoKeyResourceNames()
        {
            // Snippet: GetCryptoKey(CryptoKeyName, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyName name = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            // Make the request
            CryptoKey response = keyManagementServiceClient.GetCryptoKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyAsync</summary>
        public async Task GetCryptoKeyResourceNamesAsync()
        {
            // Snippet: GetCryptoKeyAsync(CryptoKeyName, CallSettings)
            // Additional: GetCryptoKeyAsync(CryptoKeyName, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyName name = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            // Make the request
            CryptoKey response = await keyManagementServiceClient.GetCryptoKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyVersion</summary>
        public void GetCryptoKeyVersionRequestObject()
        {
            // Snippet: GetCryptoKeyVersion(GetCryptoKeyVersionRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetCryptoKeyVersionRequest request = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.GetCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyVersionAsync</summary>
        public async Task GetCryptoKeyVersionRequestObjectAsync()
        {
            // Snippet: GetCryptoKeyVersionAsync(GetCryptoKeyVersionRequest, CallSettings)
            // Additional: GetCryptoKeyVersionAsync(GetCryptoKeyVersionRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCryptoKeyVersionRequest request = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.GetCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyVersion</summary>
        public void GetCryptoKeyVersion()
        {
            // Snippet: GetCryptoKeyVersion(string, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.GetCryptoKeyVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyVersionAsync</summary>
        public async Task GetCryptoKeyVersionAsync()
        {
            // Snippet: GetCryptoKeyVersionAsync(string, CallSettings)
            // Additional: GetCryptoKeyVersionAsync(string, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.GetCryptoKeyVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyVersion</summary>
        public void GetCryptoKeyVersionResourceNames()
        {
            // Snippet: GetCryptoKeyVersion(CryptoKeyVersionName, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.GetCryptoKeyVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyVersionAsync</summary>
        public async Task GetCryptoKeyVersionResourceNamesAsync()
        {
            // Snippet: GetCryptoKeyVersionAsync(CryptoKeyVersionName, CallSettings)
            // Additional: GetCryptoKeyVersionAsync(CryptoKeyVersionName, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.GetCryptoKeyVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublicKey</summary>
        public void GetPublicKeyRequestObject()
        {
            // Snippet: GetPublicKey(GetPublicKeyRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetPublicKeyRequest request = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            PublicKey response = keyManagementServiceClient.GetPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublicKeyAsync</summary>
        public async Task GetPublicKeyRequestObjectAsync()
        {
            // Snippet: GetPublicKeyAsync(GetPublicKeyRequest, CallSettings)
            // Additional: GetPublicKeyAsync(GetPublicKeyRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPublicKeyRequest request = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            PublicKey response = await keyManagementServiceClient.GetPublicKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublicKey</summary>
        public void GetPublicKey()
        {
            // Snippet: GetPublicKey(string, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            // Make the request
            PublicKey response = keyManagementServiceClient.GetPublicKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublicKeyAsync</summary>
        public async Task GetPublicKeyAsync()
        {
            // Snippet: GetPublicKeyAsync(string, CallSettings)
            // Additional: GetPublicKeyAsync(string, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            // Make the request
            PublicKey response = await keyManagementServiceClient.GetPublicKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublicKey</summary>
        public void GetPublicKeyResourceNames()
        {
            // Snippet: GetPublicKey(CryptoKeyVersionName, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            PublicKey response = keyManagementServiceClient.GetPublicKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublicKeyAsync</summary>
        public async Task GetPublicKeyResourceNamesAsync()
        {
            // Snippet: GetPublicKeyAsync(CryptoKeyVersionName, CallSettings)
            // Additional: GetPublicKeyAsync(CryptoKeyVersionName, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            PublicKey response = await keyManagementServiceClient.GetPublicKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetImportJob</summary>
        public void GetImportJobRequestObject()
        {
            // Snippet: GetImportJob(GetImportJobRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            // Make the request
            ImportJob response = keyManagementServiceClient.GetImportJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetImportJobAsync</summary>
        public async Task GetImportJobRequestObjectAsync()
        {
            // Snippet: GetImportJobAsync(GetImportJobRequest, CallSettings)
            // Additional: GetImportJobAsync(GetImportJobRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            // Make the request
            ImportJob response = await keyManagementServiceClient.GetImportJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetImportJob</summary>
        public void GetImportJob()
        {
            // Snippet: GetImportJob(string, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/importJobs/[IMPORT_JOB]";
            // Make the request
            ImportJob response = keyManagementServiceClient.GetImportJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetImportJobAsync</summary>
        public async Task GetImportJobAsync()
        {
            // Snippet: GetImportJobAsync(string, CallSettings)
            // Additional: GetImportJobAsync(string, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/importJobs/[IMPORT_JOB]";
            // Make the request
            ImportJob response = await keyManagementServiceClient.GetImportJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetImportJob</summary>
        public void GetImportJobResourceNames()
        {
            // Snippet: GetImportJob(ImportJobName, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ImportJobName name = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]");
            // Make the request
            ImportJob response = keyManagementServiceClient.GetImportJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetImportJobAsync</summary>
        public async Task GetImportJobResourceNamesAsync()
        {
            // Snippet: GetImportJobAsync(ImportJobName, CallSettings)
            // Additional: GetImportJobAsync(ImportJobName, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportJobName name = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]");
            // Make the request
            ImportJob response = await keyManagementServiceClient.GetImportJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRing</summary>
        public void CreateKeyRingRequestObject()
        {
            // Snippet: CreateKeyRing(CreateKeyRingRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CreateKeyRingRequest request = new CreateKeyRingRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KeyRingId = "",
                KeyRing = new KeyRing(),
            };
            // Make the request
            KeyRing response = keyManagementServiceClient.CreateKeyRing(request);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRingAsync</summary>
        public async Task CreateKeyRingRequestObjectAsync()
        {
            // Snippet: CreateKeyRingAsync(CreateKeyRingRequest, CallSettings)
            // Additional: CreateKeyRingAsync(CreateKeyRingRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateKeyRingRequest request = new CreateKeyRingRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KeyRingId = "",
                KeyRing = new KeyRing(),
            };
            // Make the request
            KeyRing response = await keyManagementServiceClient.CreateKeyRingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRing</summary>
        public void CreateKeyRing()
        {
            // Snippet: CreateKeyRing(string, string, KeyRing, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string keyRingId = "";
            KeyRing keyRing = new KeyRing();
            // Make the request
            KeyRing response = keyManagementServiceClient.CreateKeyRing(parent, keyRingId, keyRing);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRingAsync</summary>
        public async Task CreateKeyRingAsync()
        {
            // Snippet: CreateKeyRingAsync(string, string, KeyRing, CallSettings)
            // Additional: CreateKeyRingAsync(string, string, KeyRing, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string keyRingId = "";
            KeyRing keyRing = new KeyRing();
            // Make the request
            KeyRing response = await keyManagementServiceClient.CreateKeyRingAsync(parent, keyRingId, keyRing);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRing</summary>
        public void CreateKeyRingResourceNames()
        {
            // Snippet: CreateKeyRing(LocationName, string, KeyRing, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string keyRingId = "";
            KeyRing keyRing = new KeyRing();
            // Make the request
            KeyRing response = keyManagementServiceClient.CreateKeyRing(parent, keyRingId, keyRing);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRingAsync</summary>
        public async Task CreateKeyRingResourceNamesAsync()
        {
            // Snippet: CreateKeyRingAsync(LocationName, string, KeyRing, CallSettings)
            // Additional: CreateKeyRingAsync(LocationName, string, KeyRing, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string keyRingId = "";
            KeyRing keyRing = new KeyRing();
            // Make the request
            KeyRing response = await keyManagementServiceClient.CreateKeyRingAsync(parent, keyRingId, keyRing);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKey</summary>
        public void CreateCryptoKeyRequestObject()
        {
            // Snippet: CreateCryptoKey(CreateCryptoKeyRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CreateCryptoKeyRequest request = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "",
                CryptoKey = new CryptoKey(),
                SkipInitialVersionCreation = false,
            };
            // Make the request
            CryptoKey response = keyManagementServiceClient.CreateCryptoKey(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyAsync</summary>
        public async Task CreateCryptoKeyRequestObjectAsync()
        {
            // Snippet: CreateCryptoKeyAsync(CreateCryptoKeyRequest, CallSettings)
            // Additional: CreateCryptoKeyAsync(CreateCryptoKeyRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCryptoKeyRequest request = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "",
                CryptoKey = new CryptoKey(),
                SkipInitialVersionCreation = false,
            };
            // Make the request
            CryptoKey response = await keyManagementServiceClient.CreateCryptoKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKey</summary>
        public void CreateCryptoKey()
        {
            // Snippet: CreateCryptoKey(string, string, CryptoKey, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            string cryptoKeyId = "";
            CryptoKey cryptoKey = new CryptoKey();
            // Make the request
            CryptoKey response = keyManagementServiceClient.CreateCryptoKey(parent, cryptoKeyId, cryptoKey);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyAsync</summary>
        public async Task CreateCryptoKeyAsync()
        {
            // Snippet: CreateCryptoKeyAsync(string, string, CryptoKey, CallSettings)
            // Additional: CreateCryptoKeyAsync(string, string, CryptoKey, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            string cryptoKeyId = "";
            CryptoKey cryptoKey = new CryptoKey();
            // Make the request
            CryptoKey response = await keyManagementServiceClient.CreateCryptoKeyAsync(parent, cryptoKeyId, cryptoKey);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKey</summary>
        public void CreateCryptoKeyResourceNames()
        {
            // Snippet: CreateCryptoKey(KeyRingName, string, CryptoKey, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string cryptoKeyId = "";
            CryptoKey cryptoKey = new CryptoKey();
            // Make the request
            CryptoKey response = keyManagementServiceClient.CreateCryptoKey(parent, cryptoKeyId, cryptoKey);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyAsync</summary>
        public async Task CreateCryptoKeyResourceNamesAsync()
        {
            // Snippet: CreateCryptoKeyAsync(KeyRingName, string, CryptoKey, CallSettings)
            // Additional: CreateCryptoKeyAsync(KeyRingName, string, CryptoKey, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string cryptoKeyId = "";
            CryptoKey cryptoKey = new CryptoKey();
            // Make the request
            CryptoKey response = await keyManagementServiceClient.CreateCryptoKeyAsync(parent, cryptoKeyId, cryptoKey);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersion</summary>
        public void CreateCryptoKeyVersionRequestObject()
        {
            // Snippet: CreateCryptoKeyVersion(CreateCryptoKeyVersionRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.CreateCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersionAsync</summary>
        public async Task CreateCryptoKeyVersionRequestObjectAsync()
        {
            // Snippet: CreateCryptoKeyVersionAsync(CreateCryptoKeyVersionRequest, CallSettings)
            // Additional: CreateCryptoKeyVersionAsync(CreateCryptoKeyVersionRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.CreateCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersion</summary>
        public void CreateCryptoKeyVersion()
        {
            // Snippet: CreateCryptoKeyVersion(string, CryptoKeyVersion, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.CreateCryptoKeyVersion(parent, cryptoKeyVersion);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersionAsync</summary>
        public async Task CreateCryptoKeyVersionAsync()
        {
            // Snippet: CreateCryptoKeyVersionAsync(string, CryptoKeyVersion, CallSettings)
            // Additional: CreateCryptoKeyVersionAsync(string, CryptoKeyVersion, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.CreateCryptoKeyVersionAsync(parent, cryptoKeyVersion);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersion</summary>
        public void CreateCryptoKeyVersionResourceNames()
        {
            // Snippet: CreateCryptoKeyVersion(CryptoKeyName, CryptoKeyVersion, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyName parent = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.CreateCryptoKeyVersion(parent, cryptoKeyVersion);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersionAsync</summary>
        public async Task CreateCryptoKeyVersionResourceNamesAsync()
        {
            // Snippet: CreateCryptoKeyVersionAsync(CryptoKeyName, CryptoKeyVersion, CallSettings)
            // Additional: CreateCryptoKeyVersionAsync(CryptoKeyName, CryptoKeyVersion, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyName parent = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.CreateCryptoKeyVersionAsync(parent, cryptoKeyVersion);
            // End snippet
        }

        /// <summary>Snippet for ImportCryptoKeyVersion</summary>
        public void ImportCryptoKeyVersionRequestObject()
        {
            // Snippet: ImportCryptoKeyVersion(ImportCryptoKeyVersionRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ImportCryptoKeyVersionRequest request = new ImportCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.Unspecified,
                ImportJob = "",
                RsaAesWrappedKey = ByteString.Empty,
                CryptoKeyVersionAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                WrappedKey = ByteString.Empty,
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.ImportCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for ImportCryptoKeyVersionAsync</summary>
        public async Task ImportCryptoKeyVersionRequestObjectAsync()
        {
            // Snippet: ImportCryptoKeyVersionAsync(ImportCryptoKeyVersionRequest, CallSettings)
            // Additional: ImportCryptoKeyVersionAsync(ImportCryptoKeyVersionRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportCryptoKeyVersionRequest request = new ImportCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.Unspecified,
                ImportJob = "",
                RsaAesWrappedKey = ByteString.Empty,
                CryptoKeyVersionAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                WrappedKey = ByteString.Empty,
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.ImportCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJob</summary>
        public void CreateImportJobRequestObject()
        {
            // Snippet: CreateImportJob(CreateImportJobRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "",
                ImportJob = new ImportJob(),
            };
            // Make the request
            ImportJob response = keyManagementServiceClient.CreateImportJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJobAsync</summary>
        public async Task CreateImportJobRequestObjectAsync()
        {
            // Snippet: CreateImportJobAsync(CreateImportJobRequest, CallSettings)
            // Additional: CreateImportJobAsync(CreateImportJobRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "",
                ImportJob = new ImportJob(),
            };
            // Make the request
            ImportJob response = await keyManagementServiceClient.CreateImportJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJob</summary>
        public void CreateImportJob()
        {
            // Snippet: CreateImportJob(string, string, ImportJob, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            string importJobId = "";
            ImportJob importJob = new ImportJob();
            // Make the request
            ImportJob response = keyManagementServiceClient.CreateImportJob(parent, importJobId, importJob);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJobAsync</summary>
        public async Task CreateImportJobAsync()
        {
            // Snippet: CreateImportJobAsync(string, string, ImportJob, CallSettings)
            // Additional: CreateImportJobAsync(string, string, ImportJob, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            string importJobId = "";
            ImportJob importJob = new ImportJob();
            // Make the request
            ImportJob response = await keyManagementServiceClient.CreateImportJobAsync(parent, importJobId, importJob);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJob</summary>
        public void CreateImportJobResourceNames()
        {
            // Snippet: CreateImportJob(KeyRingName, string, ImportJob, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string importJobId = "";
            ImportJob importJob = new ImportJob();
            // Make the request
            ImportJob response = keyManagementServiceClient.CreateImportJob(parent, importJobId, importJob);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJobAsync</summary>
        public async Task CreateImportJobResourceNamesAsync()
        {
            // Snippet: CreateImportJobAsync(KeyRingName, string, ImportJob, CallSettings)
            // Additional: CreateImportJobAsync(KeyRingName, string, ImportJob, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string importJobId = "";
            ImportJob importJob = new ImportJob();
            // Make the request
            ImportJob response = await keyManagementServiceClient.CreateImportJobAsync(parent, importJobId, importJob);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKey</summary>
        public void UpdateCryptoKeyRequestObject()
        {
            // Snippet: UpdateCryptoKey(UpdateCryptoKeyRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            UpdateCryptoKeyRequest request = new UpdateCryptoKeyRequest
            {
                CryptoKey = new CryptoKey(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CryptoKey response = keyManagementServiceClient.UpdateCryptoKey(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyAsync</summary>
        public async Task UpdateCryptoKeyRequestObjectAsync()
        {
            // Snippet: UpdateCryptoKeyAsync(UpdateCryptoKeyRequest, CallSettings)
            // Additional: UpdateCryptoKeyAsync(UpdateCryptoKeyRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCryptoKeyRequest request = new UpdateCryptoKeyRequest
            {
                CryptoKey = new CryptoKey(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CryptoKey response = await keyManagementServiceClient.UpdateCryptoKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKey</summary>
        public void UpdateCryptoKey()
        {
            // Snippet: UpdateCryptoKey(CryptoKey, FieldMask, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKey cryptoKey = new CryptoKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CryptoKey response = keyManagementServiceClient.UpdateCryptoKey(cryptoKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyAsync</summary>
        public async Task UpdateCryptoKeyAsync()
        {
            // Snippet: UpdateCryptoKeyAsync(CryptoKey, FieldMask, CallSettings)
            // Additional: UpdateCryptoKeyAsync(CryptoKey, FieldMask, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKey cryptoKey = new CryptoKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CryptoKey response = await keyManagementServiceClient.UpdateCryptoKeyAsync(cryptoKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyVersion</summary>
        public void UpdateCryptoKeyVersionRequestObject()
        {
            // Snippet: UpdateCryptoKeyVersion(UpdateCryptoKeyVersionRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            UpdateCryptoKeyVersionRequest request = new UpdateCryptoKeyVersionRequest
            {
                CryptoKeyVersion = new CryptoKeyVersion(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.UpdateCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyVersionAsync</summary>
        public async Task UpdateCryptoKeyVersionRequestObjectAsync()
        {
            // Snippet: UpdateCryptoKeyVersionAsync(UpdateCryptoKeyVersionRequest, CallSettings)
            // Additional: UpdateCryptoKeyVersionAsync(UpdateCryptoKeyVersionRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCryptoKeyVersionRequest request = new UpdateCryptoKeyVersionRequest
            {
                CryptoKeyVersion = new CryptoKeyVersion(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.UpdateCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyVersion</summary>
        public void UpdateCryptoKeyVersion()
        {
            // Snippet: UpdateCryptoKeyVersion(CryptoKeyVersion, FieldMask, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.UpdateCryptoKeyVersion(cryptoKeyVersion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyVersionAsync</summary>
        public async Task UpdateCryptoKeyVersionAsync()
        {
            // Snippet: UpdateCryptoKeyVersionAsync(CryptoKeyVersion, FieldMask, CallSettings)
            // Additional: UpdateCryptoKeyVersionAsync(CryptoKeyVersion, FieldMask, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.UpdateCryptoKeyVersionAsync(cryptoKeyVersion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersion</summary>
        public void UpdateCryptoKeyPrimaryVersionRequestObject()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersion(UpdateCryptoKeyPrimaryVersionRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            UpdateCryptoKeyPrimaryVersionRequest request = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "",
            };
            // Make the request
            CryptoKey response = keyManagementServiceClient.UpdateCryptoKeyPrimaryVersion(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersionAsync</summary>
        public async Task UpdateCryptoKeyPrimaryVersionRequestObjectAsync()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersionAsync(UpdateCryptoKeyPrimaryVersionRequest, CallSettings)
            // Additional: UpdateCryptoKeyPrimaryVersionAsync(UpdateCryptoKeyPrimaryVersionRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCryptoKeyPrimaryVersionRequest request = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "",
            };
            // Make the request
            CryptoKey response = await keyManagementServiceClient.UpdateCryptoKeyPrimaryVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersion</summary>
        public void UpdateCryptoKeyPrimaryVersion()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersion(string, string, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            string cryptoKeyVersionId = "";
            // Make the request
            CryptoKey response = keyManagementServiceClient.UpdateCryptoKeyPrimaryVersion(name, cryptoKeyVersionId);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersionAsync</summary>
        public async Task UpdateCryptoKeyPrimaryVersionAsync()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersionAsync(string, string, CallSettings)
            // Additional: UpdateCryptoKeyPrimaryVersionAsync(string, string, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            string cryptoKeyVersionId = "";
            // Make the request
            CryptoKey response = await keyManagementServiceClient.UpdateCryptoKeyPrimaryVersionAsync(name, cryptoKeyVersionId);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersion</summary>
        public void UpdateCryptoKeyPrimaryVersionResourceNames()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersion(CryptoKeyName, string, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyName name = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            string cryptoKeyVersionId = "";
            // Make the request
            CryptoKey response = keyManagementServiceClient.UpdateCryptoKeyPrimaryVersion(name, cryptoKeyVersionId);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersionAsync</summary>
        public async Task UpdateCryptoKeyPrimaryVersionResourceNamesAsync()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersionAsync(CryptoKeyName, string, CallSettings)
            // Additional: UpdateCryptoKeyPrimaryVersionAsync(CryptoKeyName, string, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyName name = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            string cryptoKeyVersionId = "";
            // Make the request
            CryptoKey response = await keyManagementServiceClient.UpdateCryptoKeyPrimaryVersionAsync(name, cryptoKeyVersionId);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersion</summary>
        public void DestroyCryptoKeyVersionRequestObject()
        {
            // Snippet: DestroyCryptoKeyVersion(DestroyCryptoKeyVersionRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            DestroyCryptoKeyVersionRequest request = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.DestroyCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersionAsync</summary>
        public async Task DestroyCryptoKeyVersionRequestObjectAsync()
        {
            // Snippet: DestroyCryptoKeyVersionAsync(DestroyCryptoKeyVersionRequest, CallSettings)
            // Additional: DestroyCryptoKeyVersionAsync(DestroyCryptoKeyVersionRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            DestroyCryptoKeyVersionRequest request = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.DestroyCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersion</summary>
        public void DestroyCryptoKeyVersion()
        {
            // Snippet: DestroyCryptoKeyVersion(string, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.DestroyCryptoKeyVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersionAsync</summary>
        public async Task DestroyCryptoKeyVersionAsync()
        {
            // Snippet: DestroyCryptoKeyVersionAsync(string, CallSettings)
            // Additional: DestroyCryptoKeyVersionAsync(string, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.DestroyCryptoKeyVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersion</summary>
        public void DestroyCryptoKeyVersionResourceNames()
        {
            // Snippet: DestroyCryptoKeyVersion(CryptoKeyVersionName, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.DestroyCryptoKeyVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersionAsync</summary>
        public async Task DestroyCryptoKeyVersionResourceNamesAsync()
        {
            // Snippet: DestroyCryptoKeyVersionAsync(CryptoKeyVersionName, CallSettings)
            // Additional: DestroyCryptoKeyVersionAsync(CryptoKeyVersionName, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.DestroyCryptoKeyVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersion</summary>
        public void RestoreCryptoKeyVersionRequestObject()
        {
            // Snippet: RestoreCryptoKeyVersion(RestoreCryptoKeyVersionRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            RestoreCryptoKeyVersionRequest request = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.RestoreCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersionAsync</summary>
        public async Task RestoreCryptoKeyVersionRequestObjectAsync()
        {
            // Snippet: RestoreCryptoKeyVersionAsync(RestoreCryptoKeyVersionRequest, CallSettings)
            // Additional: RestoreCryptoKeyVersionAsync(RestoreCryptoKeyVersionRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            RestoreCryptoKeyVersionRequest request = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.RestoreCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersion</summary>
        public void RestoreCryptoKeyVersion()
        {
            // Snippet: RestoreCryptoKeyVersion(string, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.RestoreCryptoKeyVersion(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersionAsync</summary>
        public async Task RestoreCryptoKeyVersionAsync()
        {
            // Snippet: RestoreCryptoKeyVersionAsync(string, CallSettings)
            // Additional: RestoreCryptoKeyVersionAsync(string, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.RestoreCryptoKeyVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersion</summary>
        public void RestoreCryptoKeyVersionResourceNames()
        {
            // Snippet: RestoreCryptoKeyVersion(CryptoKeyVersionName, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.RestoreCryptoKeyVersion(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersionAsync</summary>
        public async Task RestoreCryptoKeyVersionResourceNamesAsync()
        {
            // Snippet: RestoreCryptoKeyVersionAsync(CryptoKeyVersionName, CallSettings)
            // Additional: RestoreCryptoKeyVersionAsync(CryptoKeyVersionName, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.RestoreCryptoKeyVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for Encrypt</summary>
        public void EncryptRequestObject()
        {
            // Snippet: Encrypt(EncryptRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            EncryptRequest request = new EncryptRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Plaintext = ByteString.Empty,
                AdditionalAuthenticatedData = ByteString.Empty,
                PlaintextCrc32C = 0L,
                AdditionalAuthenticatedDataCrc32C = 0L,
            };
            // Make the request
            EncryptResponse response = keyManagementServiceClient.Encrypt(request);
            // End snippet
        }

        /// <summary>Snippet for EncryptAsync</summary>
        public async Task EncryptRequestObjectAsync()
        {
            // Snippet: EncryptAsync(EncryptRequest, CallSettings)
            // Additional: EncryptAsync(EncryptRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            EncryptRequest request = new EncryptRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Plaintext = ByteString.Empty,
                AdditionalAuthenticatedData = ByteString.Empty,
                PlaintextCrc32C = 0L,
                AdditionalAuthenticatedDataCrc32C = 0L,
            };
            // Make the request
            EncryptResponse response = await keyManagementServiceClient.EncryptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Encrypt</summary>
        public void Encrypt()
        {
            // Snippet: Encrypt(string, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "a/wildcard/resource";
            ByteString plaintext = ByteString.Empty;
            // Make the request
            EncryptResponse response = keyManagementServiceClient.Encrypt(name, plaintext);
            // End snippet
        }

        /// <summary>Snippet for EncryptAsync</summary>
        public async Task EncryptAsync()
        {
            // Snippet: EncryptAsync(string, ByteString, CallSettings)
            // Additional: EncryptAsync(string, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "a/wildcard/resource";
            ByteString plaintext = ByteString.Empty;
            // Make the request
            EncryptResponse response = await keyManagementServiceClient.EncryptAsync(name, plaintext);
            // End snippet
        }

        /// <summary>Snippet for Encrypt</summary>
        public void EncryptResourceNames()
        {
            // Snippet: Encrypt(IResourceName, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            ByteString plaintext = ByteString.Empty;
            // Make the request
            EncryptResponse response = keyManagementServiceClient.Encrypt(name, plaintext);
            // End snippet
        }

        /// <summary>Snippet for EncryptAsync</summary>
        public async Task EncryptResourceNamesAsync()
        {
            // Snippet: EncryptAsync(IResourceName, ByteString, CallSettings)
            // Additional: EncryptAsync(IResourceName, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            ByteString plaintext = ByteString.Empty;
            // Make the request
            EncryptResponse response = await keyManagementServiceClient.EncryptAsync(name, plaintext);
            // End snippet
        }

        /// <summary>Snippet for Decrypt</summary>
        public void DecryptRequestObject()
        {
            // Snippet: Decrypt(DecryptRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            DecryptRequest request = new DecryptRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = ByteString.Empty,
                AdditionalAuthenticatedData = ByteString.Empty,
                CiphertextCrc32C = 0L,
                AdditionalAuthenticatedDataCrc32C = 0L,
            };
            // Make the request
            DecryptResponse response = keyManagementServiceClient.Decrypt(request);
            // End snippet
        }

        /// <summary>Snippet for DecryptAsync</summary>
        public async Task DecryptRequestObjectAsync()
        {
            // Snippet: DecryptAsync(DecryptRequest, CallSettings)
            // Additional: DecryptAsync(DecryptRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            DecryptRequest request = new DecryptRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = ByteString.Empty,
                AdditionalAuthenticatedData = ByteString.Empty,
                CiphertextCrc32C = 0L,
                AdditionalAuthenticatedDataCrc32C = 0L,
            };
            // Make the request
            DecryptResponse response = await keyManagementServiceClient.DecryptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Decrypt</summary>
        public void Decrypt()
        {
            // Snippet: Decrypt(string, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            DecryptResponse response = keyManagementServiceClient.Decrypt(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for DecryptAsync</summary>
        public async Task DecryptAsync()
        {
            // Snippet: DecryptAsync(string, ByteString, CallSettings)
            // Additional: DecryptAsync(string, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            DecryptResponse response = await keyManagementServiceClient.DecryptAsync(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for Decrypt</summary>
        public void DecryptResourceNames()
        {
            // Snippet: Decrypt(CryptoKeyName, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyName name = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            DecryptResponse response = keyManagementServiceClient.Decrypt(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for DecryptAsync</summary>
        public async Task DecryptResourceNamesAsync()
        {
            // Snippet: DecryptAsync(CryptoKeyName, ByteString, CallSettings)
            // Additional: DecryptAsync(CryptoKeyName, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyName name = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            DecryptResponse response = await keyManagementServiceClient.DecryptAsync(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for RawEncrypt</summary>
        public void RawEncryptRequestObject()
        {
            // Snippet: RawEncrypt(RawEncryptRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            RawEncryptRequest request = new RawEncryptRequest
            {
                Name = "",
                Plaintext = ByteString.Empty,
                AdditionalAuthenticatedData = ByteString.Empty,
                PlaintextCrc32C = 0L,
                AdditionalAuthenticatedDataCrc32C = 0L,
                InitializationVector = ByteString.Empty,
                InitializationVectorCrc32C = 0L,
            };
            // Make the request
            RawEncryptResponse response = keyManagementServiceClient.RawEncrypt(request);
            // End snippet
        }

        /// <summary>Snippet for RawEncryptAsync</summary>
        public async Task RawEncryptRequestObjectAsync()
        {
            // Snippet: RawEncryptAsync(RawEncryptRequest, CallSettings)
            // Additional: RawEncryptAsync(RawEncryptRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            RawEncryptRequest request = new RawEncryptRequest
            {
                Name = "",
                Plaintext = ByteString.Empty,
                AdditionalAuthenticatedData = ByteString.Empty,
                PlaintextCrc32C = 0L,
                AdditionalAuthenticatedDataCrc32C = 0L,
                InitializationVector = ByteString.Empty,
                InitializationVectorCrc32C = 0L,
            };
            // Make the request
            RawEncryptResponse response = await keyManagementServiceClient.RawEncryptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RawDecrypt</summary>
        public void RawDecryptRequestObject()
        {
            // Snippet: RawDecrypt(RawDecryptRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            RawDecryptRequest request = new RawDecryptRequest
            {
                Name = "",
                Ciphertext = ByteString.Empty,
                AdditionalAuthenticatedData = ByteString.Empty,
                InitializationVector = ByteString.Empty,
                TagLength = 0,
                CiphertextCrc32C = 0L,
                AdditionalAuthenticatedDataCrc32C = 0L,
                InitializationVectorCrc32C = 0L,
            };
            // Make the request
            RawDecryptResponse response = keyManagementServiceClient.RawDecrypt(request);
            // End snippet
        }

        /// <summary>Snippet for RawDecryptAsync</summary>
        public async Task RawDecryptRequestObjectAsync()
        {
            // Snippet: RawDecryptAsync(RawDecryptRequest, CallSettings)
            // Additional: RawDecryptAsync(RawDecryptRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            RawDecryptRequest request = new RawDecryptRequest
            {
                Name = "",
                Ciphertext = ByteString.Empty,
                AdditionalAuthenticatedData = ByteString.Empty,
                InitializationVector = ByteString.Empty,
                TagLength = 0,
                CiphertextCrc32C = 0L,
                AdditionalAuthenticatedDataCrc32C = 0L,
                InitializationVectorCrc32C = 0L,
            };
            // Make the request
            RawDecryptResponse response = await keyManagementServiceClient.RawDecryptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSign</summary>
        public void AsymmetricSignRequestObject()
        {
            // Snippet: AsymmetricSign(AsymmetricSignRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
                DigestCrc32C = 0L,
                Data = ByteString.Empty,
                DataCrc32C = 0L,
            };
            // Make the request
            AsymmetricSignResponse response = keyManagementServiceClient.AsymmetricSign(request);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSignAsync</summary>
        public async Task AsymmetricSignRequestObjectAsync()
        {
            // Snippet: AsymmetricSignAsync(AsymmetricSignRequest, CallSettings)
            // Additional: AsymmetricSignAsync(AsymmetricSignRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
                DigestCrc32C = 0L,
                Data = ByteString.Empty,
                DataCrc32C = 0L,
            };
            // Make the request
            AsymmetricSignResponse response = await keyManagementServiceClient.AsymmetricSignAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSign</summary>
        public void AsymmetricSign()
        {
            // Snippet: AsymmetricSign(string, Digest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            Digest digest = new Digest();
            // Make the request
            AsymmetricSignResponse response = keyManagementServiceClient.AsymmetricSign(name, digest);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSignAsync</summary>
        public async Task AsymmetricSignAsync()
        {
            // Snippet: AsymmetricSignAsync(string, Digest, CallSettings)
            // Additional: AsymmetricSignAsync(string, Digest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            Digest digest = new Digest();
            // Make the request
            AsymmetricSignResponse response = await keyManagementServiceClient.AsymmetricSignAsync(name, digest);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSign</summary>
        public void AsymmetricSignResourceNames()
        {
            // Snippet: AsymmetricSign(CryptoKeyVersionName, Digest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            Digest digest = new Digest();
            // Make the request
            AsymmetricSignResponse response = keyManagementServiceClient.AsymmetricSign(name, digest);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSignAsync</summary>
        public async Task AsymmetricSignResourceNamesAsync()
        {
            // Snippet: AsymmetricSignAsync(CryptoKeyVersionName, Digest, CallSettings)
            // Additional: AsymmetricSignAsync(CryptoKeyVersionName, Digest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            Digest digest = new Digest();
            // Make the request
            AsymmetricSignResponse response = await keyManagementServiceClient.AsymmetricSignAsync(name, digest);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecrypt</summary>
        public void AsymmetricDecryptRequestObject()
        {
            // Snippet: AsymmetricDecrypt(AsymmetricDecryptRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            AsymmetricDecryptRequest request = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = ByteString.Empty,
                CiphertextCrc32C = 0L,
            };
            // Make the request
            AsymmetricDecryptResponse response = keyManagementServiceClient.AsymmetricDecrypt(request);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecryptAsync</summary>
        public async Task AsymmetricDecryptRequestObjectAsync()
        {
            // Snippet: AsymmetricDecryptAsync(AsymmetricDecryptRequest, CallSettings)
            // Additional: AsymmetricDecryptAsync(AsymmetricDecryptRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            AsymmetricDecryptRequest request = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = ByteString.Empty,
                CiphertextCrc32C = 0L,
            };
            // Make the request
            AsymmetricDecryptResponse response = await keyManagementServiceClient.AsymmetricDecryptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecrypt</summary>
        public void AsymmetricDecrypt()
        {
            // Snippet: AsymmetricDecrypt(string, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            AsymmetricDecryptResponse response = keyManagementServiceClient.AsymmetricDecrypt(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecryptAsync</summary>
        public async Task AsymmetricDecryptAsync()
        {
            // Snippet: AsymmetricDecryptAsync(string, ByteString, CallSettings)
            // Additional: AsymmetricDecryptAsync(string, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            AsymmetricDecryptResponse response = await keyManagementServiceClient.AsymmetricDecryptAsync(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecrypt</summary>
        public void AsymmetricDecryptResourceNames()
        {
            // Snippet: AsymmetricDecrypt(CryptoKeyVersionName, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            AsymmetricDecryptResponse response = keyManagementServiceClient.AsymmetricDecrypt(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecryptAsync</summary>
        public async Task AsymmetricDecryptResourceNamesAsync()
        {
            // Snippet: AsymmetricDecryptAsync(CryptoKeyVersionName, ByteString, CallSettings)
            // Additional: AsymmetricDecryptAsync(CryptoKeyVersionName, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            AsymmetricDecryptResponse response = await keyManagementServiceClient.AsymmetricDecryptAsync(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for MacSign</summary>
        public void MacSignRequestObject()
        {
            // Snippet: MacSign(MacSignRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            MacSignRequest request = new MacSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = ByteString.Empty,
                DataCrc32C = 0L,
            };
            // Make the request
            MacSignResponse response = keyManagementServiceClient.MacSign(request);
            // End snippet
        }

        /// <summary>Snippet for MacSignAsync</summary>
        public async Task MacSignRequestObjectAsync()
        {
            // Snippet: MacSignAsync(MacSignRequest, CallSettings)
            // Additional: MacSignAsync(MacSignRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            MacSignRequest request = new MacSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = ByteString.Empty,
                DataCrc32C = 0L,
            };
            // Make the request
            MacSignResponse response = await keyManagementServiceClient.MacSignAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MacSign</summary>
        public void MacSign()
        {
            // Snippet: MacSign(string, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            ByteString data = ByteString.Empty;
            // Make the request
            MacSignResponse response = keyManagementServiceClient.MacSign(name, data);
            // End snippet
        }

        /// <summary>Snippet for MacSignAsync</summary>
        public async Task MacSignAsync()
        {
            // Snippet: MacSignAsync(string, ByteString, CallSettings)
            // Additional: MacSignAsync(string, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            ByteString data = ByteString.Empty;
            // Make the request
            MacSignResponse response = await keyManagementServiceClient.MacSignAsync(name, data);
            // End snippet
        }

        /// <summary>Snippet for MacSign</summary>
        public void MacSignResourceNames()
        {
            // Snippet: MacSign(CryptoKeyVersionName, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            ByteString data = ByteString.Empty;
            // Make the request
            MacSignResponse response = keyManagementServiceClient.MacSign(name, data);
            // End snippet
        }

        /// <summary>Snippet for MacSignAsync</summary>
        public async Task MacSignResourceNamesAsync()
        {
            // Snippet: MacSignAsync(CryptoKeyVersionName, ByteString, CallSettings)
            // Additional: MacSignAsync(CryptoKeyVersionName, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            ByteString data = ByteString.Empty;
            // Make the request
            MacSignResponse response = await keyManagementServiceClient.MacSignAsync(name, data);
            // End snippet
        }

        /// <summary>Snippet for MacVerify</summary>
        public void MacVerifyRequestObject()
        {
            // Snippet: MacVerify(MacVerifyRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            MacVerifyRequest request = new MacVerifyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = ByteString.Empty,
                DataCrc32C = 0L,
                Mac = ByteString.Empty,
                MacCrc32C = 0L,
            };
            // Make the request
            MacVerifyResponse response = keyManagementServiceClient.MacVerify(request);
            // End snippet
        }

        /// <summary>Snippet for MacVerifyAsync</summary>
        public async Task MacVerifyRequestObjectAsync()
        {
            // Snippet: MacVerifyAsync(MacVerifyRequest, CallSettings)
            // Additional: MacVerifyAsync(MacVerifyRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            MacVerifyRequest request = new MacVerifyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = ByteString.Empty,
                DataCrc32C = 0L,
                Mac = ByteString.Empty,
                MacCrc32C = 0L,
            };
            // Make the request
            MacVerifyResponse response = await keyManagementServiceClient.MacVerifyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MacVerify</summary>
        public void MacVerify()
        {
            // Snippet: MacVerify(string, ByteString, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            ByteString data = ByteString.Empty;
            ByteString mac = ByteString.Empty;
            // Make the request
            MacVerifyResponse response = keyManagementServiceClient.MacVerify(name, data, mac);
            // End snippet
        }

        /// <summary>Snippet for MacVerifyAsync</summary>
        public async Task MacVerifyAsync()
        {
            // Snippet: MacVerifyAsync(string, ByteString, ByteString, CallSettings)
            // Additional: MacVerifyAsync(string, ByteString, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            ByteString data = ByteString.Empty;
            ByteString mac = ByteString.Empty;
            // Make the request
            MacVerifyResponse response = await keyManagementServiceClient.MacVerifyAsync(name, data, mac);
            // End snippet
        }

        /// <summary>Snippet for MacVerify</summary>
        public void MacVerifyResourceNames()
        {
            // Snippet: MacVerify(CryptoKeyVersionName, ByteString, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            ByteString data = ByteString.Empty;
            ByteString mac = ByteString.Empty;
            // Make the request
            MacVerifyResponse response = keyManagementServiceClient.MacVerify(name, data, mac);
            // End snippet
        }

        /// <summary>Snippet for MacVerifyAsync</summary>
        public async Task MacVerifyResourceNamesAsync()
        {
            // Snippet: MacVerifyAsync(CryptoKeyVersionName, ByteString, ByteString, CallSettings)
            // Additional: MacVerifyAsync(CryptoKeyVersionName, ByteString, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            ByteString data = ByteString.Empty;
            ByteString mac = ByteString.Empty;
            // Make the request
            MacVerifyResponse response = await keyManagementServiceClient.MacVerifyAsync(name, data, mac);
            // End snippet
        }

        /// <summary>Snippet for GenerateRandomBytes</summary>
        public void GenerateRandomBytesRequestObject()
        {
            // Snippet: GenerateRandomBytes(GenerateRandomBytesRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GenerateRandomBytesRequest request = new GenerateRandomBytesRequest
            {
                Location = "",
                LengthBytes = 0,
                ProtectionLevel = ProtectionLevel.Unspecified,
            };
            // Make the request
            GenerateRandomBytesResponse response = keyManagementServiceClient.GenerateRandomBytes(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateRandomBytesAsync</summary>
        public async Task GenerateRandomBytesRequestObjectAsync()
        {
            // Snippet: GenerateRandomBytesAsync(GenerateRandomBytesRequest, CallSettings)
            // Additional: GenerateRandomBytesAsync(GenerateRandomBytesRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateRandomBytesRequest request = new GenerateRandomBytesRequest
            {
                Location = "",
                LengthBytes = 0,
                ProtectionLevel = ProtectionLevel.Unspecified,
            };
            // Make the request
            GenerateRandomBytesResponse response = await keyManagementServiceClient.GenerateRandomBytesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateRandomBytes</summary>
        public void GenerateRandomBytes()
        {
            // Snippet: GenerateRandomBytes(string, int, ProtectionLevel, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string location = "";
            int lengthBytes = 0;
            ProtectionLevel protectionLevel = ProtectionLevel.Unspecified;
            // Make the request
            GenerateRandomBytesResponse response = keyManagementServiceClient.GenerateRandomBytes(location, lengthBytes, protectionLevel);
            // End snippet
        }

        /// <summary>Snippet for GenerateRandomBytesAsync</summary>
        public async Task GenerateRandomBytesAsync()
        {
            // Snippet: GenerateRandomBytesAsync(string, int, ProtectionLevel, CallSettings)
            // Additional: GenerateRandomBytesAsync(string, int, ProtectionLevel, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string location = "";
            int lengthBytes = 0;
            ProtectionLevel protectionLevel = ProtectionLevel.Unspecified;
            // Make the request
            GenerateRandomBytesResponse response = await keyManagementServiceClient.GenerateRandomBytesAsync(location, lengthBytes, protectionLevel);
            // End snippet
        }
    }
}
