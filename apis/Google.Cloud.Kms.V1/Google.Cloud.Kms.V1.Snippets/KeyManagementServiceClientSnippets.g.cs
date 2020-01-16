// Copyright 2020 Google LLC
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

namespace Google.Cloud.Kms.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Iam.V1;
    using apis = Google.Cloud.Kms.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedKeyManagementServiceClientSnippets
    {
        /// <summary>Snippet for ListKeyRingsAsync</summary>
        public async Task ListKeyRingsAsync()
        {
            // Snippet: ListKeyRingsAsync(LocationName,string,int?,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListKeyRingsResponse, KeyRing> response =
                keyManagementServiceClient.ListKeyRingsAsync(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyRings</summary>
        public void ListKeyRings()
        {
            // Snippet: ListKeyRings(LocationName,string,int?,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListKeyRingsResponse, KeyRing> response =
                keyManagementServiceClient.ListKeyRings(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyRingsAsync</summary>
        public async Task ListKeyRingsAsync_RequestObject()
        {
            // Snippet: ListKeyRingsAsync(ListKeyRingsRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListKeyRingsRequest request = new ListKeyRingsRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListKeyRingsResponse, KeyRing> response =
                keyManagementServiceClient.ListKeyRingsAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyRings</summary>
        public void ListKeyRings_RequestObject()
        {
            // Snippet: ListKeyRings(ListKeyRingsRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ListKeyRingsRequest request = new ListKeyRingsRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListKeyRingsResponse, KeyRing> response =
                keyManagementServiceClient.ListKeyRings(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobsAsync</summary>
        public async Task ListImportJobsAsync()
        {
            // Snippet: ListImportJobsAsync(KeyRingName,string,int?,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName parent = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> response =
                keyManagementServiceClient.ListImportJobsAsync(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobs</summary>
        public void ListImportJobs()
        {
            // Snippet: ListImportJobs(KeyRingName,string,int?,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName parent = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            PagedEnumerable<ListImportJobsResponse, ImportJob> response =
                keyManagementServiceClient.ListImportJobs(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobsAsync</summary>
        public async Task ListImportJobsAsync_RequestObject()
        {
            // Snippet: ListImportJobsAsync(ListImportJobsRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListImportJobsRequest request = new ListImportJobsRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> response =
                keyManagementServiceClient.ListImportJobsAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobs</summary>
        public void ListImportJobs_RequestObject()
        {
            // Snippet: ListImportJobs(ListImportJobsRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ListImportJobsRequest request = new ListImportJobsRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            // Make the request
            PagedEnumerable<ListImportJobsResponse, ImportJob> response =
                keyManagementServiceClient.ListImportJobs(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeysAsync</summary>
        public async Task ListCryptoKeysAsync()
        {
            // Snippet: ListCryptoKeysAsync(KeyRingName,string,int?,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName parent = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeysResponse, CryptoKey> response =
                keyManagementServiceClient.ListCryptoKeysAsync(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeys</summary>
        public void ListCryptoKeys()
        {
            // Snippet: ListCryptoKeys(KeyRingName,string,int?,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName parent = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            PagedEnumerable<ListCryptoKeysResponse, CryptoKey> response =
                keyManagementServiceClient.ListCryptoKeys(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeysAsync</summary>
        public async Task ListCryptoKeysAsync_RequestObject()
        {
            // Snippet: ListCryptoKeysAsync(ListCryptoKeysRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCryptoKeysRequest request = new ListCryptoKeysRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeysResponse, CryptoKey> response =
                keyManagementServiceClient.ListCryptoKeysAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeys</summary>
        public void ListCryptoKeys_RequestObject()
        {
            // Snippet: ListCryptoKeys(ListCryptoKeysRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ListCryptoKeysRequest request = new ListCryptoKeysRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            // Make the request
            PagedEnumerable<ListCryptoKeysResponse, CryptoKey> response =
                keyManagementServiceClient.ListCryptoKeys(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersionsAsync</summary>
        public async Task ListCryptoKeyVersionsAsync()
        {
            // Snippet: ListCryptoKeyVersionsAsync(CryptoKeyName,string,int?,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyName parent = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response =
                keyManagementServiceClient.ListCryptoKeyVersionsAsync(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersions</summary>
        public void ListCryptoKeyVersions()
        {
            // Snippet: ListCryptoKeyVersions(CryptoKeyName,string,int?,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyName parent = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            // Make the request
            PagedEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response =
                keyManagementServiceClient.ListCryptoKeyVersions(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersionsAsync</summary>
        public async Task ListCryptoKeyVersionsAsync_RequestObject()
        {
            // Snippet: ListCryptoKeyVersionsAsync(ListCryptoKeyVersionsRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCryptoKeyVersionsRequest request = new ListCryptoKeyVersionsRequest
            {
                ParentAsCryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response =
                keyManagementServiceClient.ListCryptoKeyVersionsAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersions</summary>
        public void ListCryptoKeyVersions_RequestObject()
        {
            // Snippet: ListCryptoKeyVersions(ListCryptoKeyVersionsRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ListCryptoKeyVersionsRequest request = new ListCryptoKeyVersionsRequest
            {
                ParentAsCryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            PagedEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response =
                keyManagementServiceClient.ListCryptoKeyVersions(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetKeyRingAsync</summary>
        public async Task GetKeyRingAsync()
        {
            // Snippet: GetKeyRingAsync(KeyRingName,CallSettings)
            // Additional: GetKeyRingAsync(KeyRingName,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName name = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            KeyRing response = await keyManagementServiceClient.GetKeyRingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyRing</summary>
        public void GetKeyRing()
        {
            // Snippet: GetKeyRing(KeyRingName,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName name = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            KeyRing response = keyManagementServiceClient.GetKeyRing(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyRingAsync</summary>
        public async Task GetKeyRingAsync_RequestObject()
        {
            // Snippet: GetKeyRingAsync(GetKeyRingRequest,CallSettings)
            // Additional: GetKeyRingAsync(GetKeyRingRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetKeyRingRequest request = new GetKeyRingRequest
            {
                KeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            // Make the request
            KeyRing response = await keyManagementServiceClient.GetKeyRingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeyRing</summary>
        public void GetKeyRing_RequestObject()
        {
            // Snippet: GetKeyRing(GetKeyRingRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetKeyRingRequest request = new GetKeyRingRequest
            {
                KeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            // Make the request
            KeyRing response = keyManagementServiceClient.GetKeyRing(request);
            // End snippet
        }

        /// <summary>Snippet for GetImportJobAsync</summary>
        public async Task GetImportJobAsync()
        {
            // Snippet: GetImportJobAsync(ImportJobName,CallSettings)
            // Additional: GetImportJobAsync(ImportJobName,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportJobName name = new ImportJobName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]");
            // Make the request
            ImportJob response = await keyManagementServiceClient.GetImportJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetImportJob</summary>
        public void GetImportJob()
        {
            // Snippet: GetImportJob(ImportJobName,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ImportJobName name = new ImportJobName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]");
            // Make the request
            ImportJob response = keyManagementServiceClient.GetImportJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetImportJobAsync</summary>
        public async Task GetImportJobAsync_RequestObject()
        {
            // Snippet: GetImportJobAsync(GetImportJobRequest,CallSettings)
            // Additional: GetImportJobAsync(GetImportJobRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = new ImportJobName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            // Make the request
            ImportJob response = await keyManagementServiceClient.GetImportJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetImportJob</summary>
        public void GetImportJob_RequestObject()
        {
            // Snippet: GetImportJob(GetImportJobRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = new ImportJobName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            // Make the request
            ImportJob response = keyManagementServiceClient.GetImportJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyAsync</summary>
        public async Task GetCryptoKeyAsync()
        {
            // Snippet: GetCryptoKeyAsync(CryptoKeyName,CallSettings)
            // Additional: GetCryptoKeyAsync(CryptoKeyName,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyName name = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            // Make the request
            CryptoKey response = await keyManagementServiceClient.GetCryptoKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKey</summary>
        public void GetCryptoKey()
        {
            // Snippet: GetCryptoKey(CryptoKeyName,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyName name = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            // Make the request
            CryptoKey response = keyManagementServiceClient.GetCryptoKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyAsync</summary>
        public async Task GetCryptoKeyAsync_RequestObject()
        {
            // Snippet: GetCryptoKeyAsync(GetCryptoKeyRequest,CallSettings)
            // Additional: GetCryptoKeyAsync(GetCryptoKeyRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCryptoKeyRequest request = new GetCryptoKeyRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            CryptoKey response = await keyManagementServiceClient.GetCryptoKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKey</summary>
        public void GetCryptoKey_RequestObject()
        {
            // Snippet: GetCryptoKey(GetCryptoKeyRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetCryptoKeyRequest request = new GetCryptoKeyRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            CryptoKey response = keyManagementServiceClient.GetCryptoKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyVersionAsync</summary>
        public async Task GetCryptoKeyVersionAsync()
        {
            // Snippet: GetCryptoKeyVersionAsync(CryptoKeyVersionName,CallSettings)
            // Additional: GetCryptoKeyVersionAsync(CryptoKeyVersionName,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.GetCryptoKeyVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyVersion</summary>
        public void GetCryptoKeyVersion()
        {
            // Snippet: GetCryptoKeyVersion(CryptoKeyVersionName,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.GetCryptoKeyVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyVersionAsync</summary>
        public async Task GetCryptoKeyVersionAsync_RequestObject()
        {
            // Snippet: GetCryptoKeyVersionAsync(GetCryptoKeyVersionRequest,CallSettings)
            // Additional: GetCryptoKeyVersionAsync(GetCryptoKeyVersionRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCryptoKeyVersionRequest request = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.GetCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyVersion</summary>
        public void GetCryptoKeyVersion_RequestObject()
        {
            // Snippet: GetCryptoKeyVersion(GetCryptoKeyVersionRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetCryptoKeyVersionRequest request = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.GetCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRingAsync</summary>
        public async Task CreateKeyRingAsync()
        {
            // Snippet: CreateKeyRingAsync(LocationName,string,KeyRing,CallSettings)
            // Additional: CreateKeyRingAsync(LocationName,string,KeyRing,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            string keyRingId = "";
            KeyRing keyRing = new KeyRing();
            // Make the request
            KeyRing response = await keyManagementServiceClient.CreateKeyRingAsync(parent, keyRingId, keyRing);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRing</summary>
        public void CreateKeyRing()
        {
            // Snippet: CreateKeyRing(LocationName,string,KeyRing,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            string keyRingId = "";
            KeyRing keyRing = new KeyRing();
            // Make the request
            KeyRing response = keyManagementServiceClient.CreateKeyRing(parent, keyRingId, keyRing);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRingAsync</summary>
        public async Task CreateKeyRingAsync_RequestObject()
        {
            // Snippet: CreateKeyRingAsync(CreateKeyRingRequest,CallSettings)
            // Additional: CreateKeyRingAsync(CreateKeyRingRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateKeyRingRequest request = new CreateKeyRingRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                KeyRingId = "",
                KeyRing = new KeyRing(),
            };
            // Make the request
            KeyRing response = await keyManagementServiceClient.CreateKeyRingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRing</summary>
        public void CreateKeyRing_RequestObject()
        {
            // Snippet: CreateKeyRing(CreateKeyRingRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CreateKeyRingRequest request = new CreateKeyRingRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                KeyRingId = "",
                KeyRing = new KeyRing(),
            };
            // Make the request
            KeyRing response = keyManagementServiceClient.CreateKeyRing(request);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJobAsync</summary>
        public async Task CreateImportJobAsync()
        {
            // Snippet: CreateImportJobAsync(KeyRingName,string,ImportJob,CallSettings)
            // Additional: CreateImportJobAsync(KeyRingName,string,ImportJob,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName parent = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string importJobId = "my-import-job";
            ImportJob importJob = new ImportJob
            {
                ImportMethod = ImportJob.Types.ImportMethod.RsaOaep3072Sha1Aes256,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            // Make the request
            ImportJob response = await keyManagementServiceClient.CreateImportJobAsync(parent, importJobId, importJob);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJob</summary>
        public void CreateImportJob()
        {
            // Snippet: CreateImportJob(KeyRingName,string,ImportJob,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName parent = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string importJobId = "my-import-job";
            ImportJob importJob = new ImportJob
            {
                ImportMethod = ImportJob.Types.ImportMethod.RsaOaep3072Sha1Aes256,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            // Make the request
            ImportJob response = keyManagementServiceClient.CreateImportJob(parent, importJobId, importJob);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJobAsync</summary>
        public async Task CreateImportJobAsync_RequestObject()
        {
            // Snippet: CreateImportJobAsync(CreateImportJobRequest,CallSettings)
            // Additional: CreateImportJobAsync(CreateImportJobRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "my-import-job",
                ImportJob = new ImportJob
                {
                    ImportMethod = ImportJob.Types.ImportMethod.RsaOaep3072Sha1Aes256,
                    ProtectionLevel = ProtectionLevel.Hsm,
                },
            };
            // Make the request
            ImportJob response = await keyManagementServiceClient.CreateImportJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJob</summary>
        public void CreateImportJob_RequestObject()
        {
            // Snippet: CreateImportJob(CreateImportJobRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "my-import-job",
                ImportJob = new ImportJob
                {
                    ImportMethod = ImportJob.Types.ImportMethod.RsaOaep3072Sha1Aes256,
                    ProtectionLevel = ProtectionLevel.Hsm,
                },
            };
            // Make the request
            ImportJob response = keyManagementServiceClient.CreateImportJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyAsync</summary>
        public async Task CreateCryptoKeyAsync()
        {
            // Snippet: CreateCryptoKeyAsync(KeyRingName,string,CryptoKey,CallSettings)
            // Additional: CreateCryptoKeyAsync(KeyRingName,string,CryptoKey,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName parent = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string cryptoKeyId = "my-app-key";
            CryptoKey cryptoKey = new CryptoKey
            {
                Purpose = CryptoKey.Types.CryptoKeyPurpose.EncryptDecrypt,
                NextRotationTime = new Timestamp
                {
                    Seconds = 2147483647L,
                },
                RotationPeriod = new Duration
                {
                    Seconds = 604800L,
                },
            };
            // Make the request
            CryptoKey response = await keyManagementServiceClient.CreateCryptoKeyAsync(parent, cryptoKeyId, cryptoKey);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKey</summary>
        public void CreateCryptoKey()
        {
            // Snippet: CreateCryptoKey(KeyRingName,string,CryptoKey,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName parent = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string cryptoKeyId = "my-app-key";
            CryptoKey cryptoKey = new CryptoKey
            {
                Purpose = CryptoKey.Types.CryptoKeyPurpose.EncryptDecrypt,
                NextRotationTime = new Timestamp
                {
                    Seconds = 2147483647L,
                },
                RotationPeriod = new Duration
                {
                    Seconds = 604800L,
                },
            };
            // Make the request
            CryptoKey response = keyManagementServiceClient.CreateCryptoKey(parent, cryptoKeyId, cryptoKey);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyAsync</summary>
        public async Task CreateCryptoKeyAsync_RequestObject()
        {
            // Snippet: CreateCryptoKeyAsync(CreateCryptoKeyRequest,CallSettings)
            // Additional: CreateCryptoKeyAsync(CreateCryptoKeyRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCryptoKeyRequest request = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "my-app-key",
                CryptoKey = new CryptoKey
                {
                    Purpose = CryptoKey.Types.CryptoKeyPurpose.EncryptDecrypt,
                    NextRotationTime = new Timestamp
                                       {
                                           Seconds = 2147483647L,
                                       },
                    RotationPeriod = new Duration
                                     {
                                         Seconds = 604800L,
                                     },
                },
            };
            // Make the request
            CryptoKey response = await keyManagementServiceClient.CreateCryptoKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKey</summary>
        public void CreateCryptoKey_RequestObject()
        {
            // Snippet: CreateCryptoKey(CreateCryptoKeyRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CreateCryptoKeyRequest request = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "my-app-key",
                CryptoKey = new CryptoKey
                {
                    Purpose = CryptoKey.Types.CryptoKeyPurpose.EncryptDecrypt,
                    NextRotationTime = new Timestamp
                                       {
                                           Seconds = 2147483647L,
                                       },
                    RotationPeriod = new Duration
                                     {
                                         Seconds = 604800L,
                                     },
                },
            };
            // Make the request
            CryptoKey response = keyManagementServiceClient.CreateCryptoKey(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersionAsync</summary>
        public async Task CreateCryptoKeyVersionAsync()
        {
            // Snippet: CreateCryptoKeyVersionAsync(CryptoKeyName,CryptoKeyVersion,CallSettings)
            // Additional: CreateCryptoKeyVersionAsync(CryptoKeyName,CryptoKeyVersion,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyName parent = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.CreateCryptoKeyVersionAsync(parent, cryptoKeyVersion);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersion</summary>
        public void CreateCryptoKeyVersion()
        {
            // Snippet: CreateCryptoKeyVersion(CryptoKeyName,CryptoKeyVersion,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyName parent = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.CreateCryptoKeyVersion(parent, cryptoKeyVersion);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersionAsync</summary>
        public async Task CreateCryptoKeyVersionAsync_RequestObject()
        {
            // Snippet: CreateCryptoKeyVersionAsync(CreateCryptoKeyVersionRequest,CallSettings)
            // Additional: CreateCryptoKeyVersionAsync(CreateCryptoKeyVersionRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.CreateCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersion</summary>
        public void CreateCryptoKeyVersion_RequestObject()
        {
            // Snippet: CreateCryptoKeyVersion(CreateCryptoKeyVersionRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.CreateCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for ImportCryptoKeyVersionAsync</summary>
        public async Task ImportCryptoKeyVersionAsync_RequestObject()
        {
            // Snippet: ImportCryptoKeyVersionAsync(ImportCryptoKeyVersionRequest,CallSettings)
            // Additional: ImportCryptoKeyVersionAsync(ImportCryptoKeyVersionRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportCryptoKeyVersionRequest request = new ImportCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.Unspecified,
                ImportJob = "",
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.ImportCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportCryptoKeyVersion</summary>
        public void ImportCryptoKeyVersion_RequestObject()
        {
            // Snippet: ImportCryptoKeyVersion(ImportCryptoKeyVersionRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ImportCryptoKeyVersionRequest request = new ImportCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.Unspecified,
                ImportJob = "",
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.ImportCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyAsync</summary>
        public async Task UpdateCryptoKeyAsync()
        {
            // Snippet: UpdateCryptoKeyAsync(CryptoKey,FieldMask,CallSettings)
            // Additional: UpdateCryptoKeyAsync(CryptoKey,FieldMask,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKey cryptoKey = new CryptoKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CryptoKey response = await keyManagementServiceClient.UpdateCryptoKeyAsync(cryptoKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKey</summary>
        public void UpdateCryptoKey()
        {
            // Snippet: UpdateCryptoKey(CryptoKey,FieldMask,CallSettings)
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
        public async Task UpdateCryptoKeyAsync_RequestObject()
        {
            // Snippet: UpdateCryptoKeyAsync(UpdateCryptoKeyRequest,CallSettings)
            // Additional: UpdateCryptoKeyAsync(UpdateCryptoKeyRequest,CancellationToken)
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
        public void UpdateCryptoKey_RequestObject()
        {
            // Snippet: UpdateCryptoKey(UpdateCryptoKeyRequest,CallSettings)
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

        /// <summary>Snippet for UpdateCryptoKeyVersionAsync</summary>
        public async Task UpdateCryptoKeyVersionAsync()
        {
            // Snippet: UpdateCryptoKeyVersionAsync(CryptoKeyVersion,FieldMask,CallSettings)
            // Additional: UpdateCryptoKeyVersionAsync(CryptoKeyVersion,FieldMask,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.UpdateCryptoKeyVersionAsync(cryptoKeyVersion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyVersion</summary>
        public void UpdateCryptoKeyVersion()
        {
            // Snippet: UpdateCryptoKeyVersion(CryptoKeyVersion,FieldMask,CallSettings)
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
        public async Task UpdateCryptoKeyVersionAsync_RequestObject()
        {
            // Snippet: UpdateCryptoKeyVersionAsync(UpdateCryptoKeyVersionRequest,CallSettings)
            // Additional: UpdateCryptoKeyVersionAsync(UpdateCryptoKeyVersionRequest,CancellationToken)
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
        public void UpdateCryptoKeyVersion_RequestObject()
        {
            // Snippet: UpdateCryptoKeyVersion(UpdateCryptoKeyVersionRequest,CallSettings)
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

        /// <summary>Snippet for EncryptAsync</summary>
        public async Task EncryptAsync()
        {
            // Snippet: EncryptAsync(CryptoKeyPathName,ByteString,CallSettings)
            // Additional: EncryptAsync(CryptoKeyPathName,ByteString,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyPathName name = new CryptoKeyPathName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY_PATH]");
            ByteString plaintext = ByteString.Empty;
            // Make the request
            EncryptResponse response = await keyManagementServiceClient.EncryptAsync(name, plaintext);
            // End snippet
        }

        /// <summary>Snippet for Encrypt</summary>
        public void Encrypt()
        {
            // Snippet: Encrypt(CryptoKeyPathName,ByteString,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyPathName name = new CryptoKeyPathName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY_PATH]");
            ByteString plaintext = ByteString.Empty;
            // Make the request
            EncryptResponse response = keyManagementServiceClient.Encrypt(name, plaintext);
            // End snippet
        }

        /// <summary>Snippet for EncryptAsync</summary>
        public async Task EncryptAsync_RequestObject()
        {
            // Snippet: EncryptAsync(EncryptRequest,CallSettings)
            // Additional: EncryptAsync(EncryptRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            EncryptRequest request = new EncryptRequest
            {
                CryptoKeyPathName = new CryptoKeyPathName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY_PATH]"),
                Plaintext = ByteString.Empty,
            };
            // Make the request
            EncryptResponse response = await keyManagementServiceClient.EncryptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Encrypt</summary>
        public void Encrypt_RequestObject()
        {
            // Snippet: Encrypt(EncryptRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            EncryptRequest request = new EncryptRequest
            {
                CryptoKeyPathName = new CryptoKeyPathName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY_PATH]"),
                Plaintext = ByteString.Empty,
            };
            // Make the request
            EncryptResponse response = keyManagementServiceClient.Encrypt(request);
            // End snippet
        }

        /// <summary>Snippet for DecryptAsync</summary>
        public async Task DecryptAsync()
        {
            // Snippet: DecryptAsync(CryptoKeyName,ByteString,CallSettings)
            // Additional: DecryptAsync(CryptoKeyName,ByteString,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyName name = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            DecryptResponse response = await keyManagementServiceClient.DecryptAsync(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for Decrypt</summary>
        public void Decrypt()
        {
            // Snippet: Decrypt(CryptoKeyName,ByteString,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyName name = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            DecryptResponse response = keyManagementServiceClient.Decrypt(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for DecryptAsync</summary>
        public async Task DecryptAsync_RequestObject()
        {
            // Snippet: DecryptAsync(DecryptRequest,CallSettings)
            // Additional: DecryptAsync(DecryptRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            DecryptRequest request = new DecryptRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = ByteString.Empty,
            };
            // Make the request
            DecryptResponse response = await keyManagementServiceClient.DecryptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Decrypt</summary>
        public void Decrypt_RequestObject()
        {
            // Snippet: Decrypt(DecryptRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            DecryptRequest request = new DecryptRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = ByteString.Empty,
            };
            // Make the request
            DecryptResponse response = keyManagementServiceClient.Decrypt(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersionAsync</summary>
        public async Task UpdateCryptoKeyPrimaryVersionAsync()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersionAsync(CryptoKeyName,string,CallSettings)
            // Additional: UpdateCryptoKeyPrimaryVersionAsync(CryptoKeyName,string,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyName name = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            string cryptoKeyVersionId = "";
            // Make the request
            CryptoKey response = await keyManagementServiceClient.UpdateCryptoKeyPrimaryVersionAsync(name, cryptoKeyVersionId);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersion</summary>
        public void UpdateCryptoKeyPrimaryVersion()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersion(CryptoKeyName,string,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyName name = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            string cryptoKeyVersionId = "";
            // Make the request
            CryptoKey response = keyManagementServiceClient.UpdateCryptoKeyPrimaryVersion(name, cryptoKeyVersionId);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersionAsync</summary>
        public async Task UpdateCryptoKeyPrimaryVersionAsync_RequestObject()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersionAsync(UpdateCryptoKeyPrimaryVersionRequest,CallSettings)
            // Additional: UpdateCryptoKeyPrimaryVersionAsync(UpdateCryptoKeyPrimaryVersionRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCryptoKeyPrimaryVersionRequest request = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "",
            };
            // Make the request
            CryptoKey response = await keyManagementServiceClient.UpdateCryptoKeyPrimaryVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersion</summary>
        public void UpdateCryptoKeyPrimaryVersion_RequestObject()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersion(UpdateCryptoKeyPrimaryVersionRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            UpdateCryptoKeyPrimaryVersionRequest request = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "",
            };
            // Make the request
            CryptoKey response = keyManagementServiceClient.UpdateCryptoKeyPrimaryVersion(request);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersionAsync</summary>
        public async Task DestroyCryptoKeyVersionAsync()
        {
            // Snippet: DestroyCryptoKeyVersionAsync(CryptoKeyVersionName,CallSettings)
            // Additional: DestroyCryptoKeyVersionAsync(CryptoKeyVersionName,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.DestroyCryptoKeyVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersion</summary>
        public void DestroyCryptoKeyVersion()
        {
            // Snippet: DestroyCryptoKeyVersion(CryptoKeyVersionName,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.DestroyCryptoKeyVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersionAsync</summary>
        public async Task DestroyCryptoKeyVersionAsync_RequestObject()
        {
            // Snippet: DestroyCryptoKeyVersionAsync(DestroyCryptoKeyVersionRequest,CallSettings)
            // Additional: DestroyCryptoKeyVersionAsync(DestroyCryptoKeyVersionRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            DestroyCryptoKeyVersionRequest request = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.DestroyCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersion</summary>
        public void DestroyCryptoKeyVersion_RequestObject()
        {
            // Snippet: DestroyCryptoKeyVersion(DestroyCryptoKeyVersionRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            DestroyCryptoKeyVersionRequest request = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.DestroyCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersionAsync</summary>
        public async Task RestoreCryptoKeyVersionAsync()
        {
            // Snippet: RestoreCryptoKeyVersionAsync(CryptoKeyVersionName,CallSettings)
            // Additional: RestoreCryptoKeyVersionAsync(CryptoKeyVersionName,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.RestoreCryptoKeyVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersion</summary>
        public void RestoreCryptoKeyVersion()
        {
            // Snippet: RestoreCryptoKeyVersion(CryptoKeyVersionName,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.RestoreCryptoKeyVersion(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersionAsync</summary>
        public async Task RestoreCryptoKeyVersionAsync_RequestObject()
        {
            // Snippet: RestoreCryptoKeyVersionAsync(RestoreCryptoKeyVersionRequest,CallSettings)
            // Additional: RestoreCryptoKeyVersionAsync(RestoreCryptoKeyVersionRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            RestoreCryptoKeyVersionRequest request = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.RestoreCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersion</summary>
        public void RestoreCryptoKeyVersion_RequestObject()
        {
            // Snippet: RestoreCryptoKeyVersion(RestoreCryptoKeyVersionRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            RestoreCryptoKeyVersionRequest request = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.RestoreCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublicKeyAsync</summary>
        public async Task GetPublicKeyAsync()
        {
            // Snippet: GetPublicKeyAsync(CryptoKeyVersionName,CallSettings)
            // Additional: GetPublicKeyAsync(CryptoKeyVersionName,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            PublicKey response = await keyManagementServiceClient.GetPublicKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublicKey</summary>
        public void GetPublicKey()
        {
            // Snippet: GetPublicKey(CryptoKeyVersionName,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            PublicKey response = keyManagementServiceClient.GetPublicKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublicKeyAsync</summary>
        public async Task GetPublicKeyAsync_RequestObject()
        {
            // Snippet: GetPublicKeyAsync(GetPublicKeyRequest,CallSettings)
            // Additional: GetPublicKeyAsync(GetPublicKeyRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPublicKeyRequest request = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            PublicKey response = await keyManagementServiceClient.GetPublicKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublicKey</summary>
        public void GetPublicKey_RequestObject()
        {
            // Snippet: GetPublicKey(GetPublicKeyRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetPublicKeyRequest request = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            PublicKey response = keyManagementServiceClient.GetPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecryptAsync</summary>
        public async Task AsymmetricDecryptAsync()
        {
            // Snippet: AsymmetricDecryptAsync(CryptoKeyVersionName,ByteString,CallSettings)
            // Additional: AsymmetricDecryptAsync(CryptoKeyVersionName,ByteString,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            AsymmetricDecryptResponse response = await keyManagementServiceClient.AsymmetricDecryptAsync(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecrypt</summary>
        public void AsymmetricDecrypt()
        {
            // Snippet: AsymmetricDecrypt(CryptoKeyVersionName,ByteString,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            AsymmetricDecryptResponse response = keyManagementServiceClient.AsymmetricDecrypt(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecryptAsync</summary>
        public async Task AsymmetricDecryptAsync_RequestObject()
        {
            // Snippet: AsymmetricDecryptAsync(AsymmetricDecryptRequest,CallSettings)
            // Additional: AsymmetricDecryptAsync(AsymmetricDecryptRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            AsymmetricDecryptRequest request = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = ByteString.Empty,
            };
            // Make the request
            AsymmetricDecryptResponse response = await keyManagementServiceClient.AsymmetricDecryptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecrypt</summary>
        public void AsymmetricDecrypt_RequestObject()
        {
            // Snippet: AsymmetricDecrypt(AsymmetricDecryptRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            AsymmetricDecryptRequest request = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = ByteString.Empty,
            };
            // Make the request
            AsymmetricDecryptResponse response = keyManagementServiceClient.AsymmetricDecrypt(request);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSignAsync</summary>
        public async Task AsymmetricSignAsync()
        {
            // Snippet: AsymmetricSignAsync(CryptoKeyVersionName,Digest,CallSettings)
            // Additional: AsymmetricSignAsync(CryptoKeyVersionName,Digest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            Digest digest = new Digest();
            // Make the request
            AsymmetricSignResponse response = await keyManagementServiceClient.AsymmetricSignAsync(name, digest);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSign</summary>
        public void AsymmetricSign()
        {
            // Snippet: AsymmetricSign(CryptoKeyVersionName,Digest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            Digest digest = new Digest();
            // Make the request
            AsymmetricSignResponse response = keyManagementServiceClient.AsymmetricSign(name, digest);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSignAsync</summary>
        public async Task AsymmetricSignAsync_RequestObject()
        {
            // Snippet: AsymmetricSignAsync(AsymmetricSignRequest,CallSettings)
            // Additional: AsymmetricSignAsync(AsymmetricSignRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
            };
            // Make the request
            AsymmetricSignResponse response = await keyManagementServiceClient.AsymmetricSignAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSign</summary>
        public void AsymmetricSign_RequestObject()
        {
            // Snippet: AsymmetricSign(AsymmetricSignRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
            };
            // Make the request
            AsymmetricSignResponse response = keyManagementServiceClient.AsymmetricSign(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(KeyNameOneof,Policy,CallSettings)
            // Additional: SetIamPolicyAsync(KeyNameOneof,Policy,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyNameOneof resource = KeyNameOneof.From(new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"));
            Policy policy = new Policy();
            // Make the request
            Policy response = await keyManagementServiceClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(KeyNameOneof,Policy,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyNameOneof resource = KeyNameOneof.From(new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"));
            Policy policy = new Policy();
            // Make the request
            Policy response = keyManagementServiceClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest,CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = KeyNameOneof.From(new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]")),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await keyManagementServiceClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = KeyNameOneof.From(new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]")),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = keyManagementServiceClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(KeyNameOneof,CallSettings)
            // Additional: GetIamPolicyAsync(KeyNameOneof,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyNameOneof resource = KeyNameOneof.From(new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"));
            // Make the request
            Policy response = await keyManagementServiceClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(KeyNameOneof,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyNameOneof resource = KeyNameOneof.From(new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"));
            // Make the request
            Policy response = keyManagementServiceClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest,CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = KeyNameOneof.From(new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]")),
            };
            // Make the request
            Policy response = await keyManagementServiceClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = KeyNameOneof.From(new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]")),
            };
            // Make the request
            Policy response = keyManagementServiceClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(KeyNameOneof,IEnumerable<string>,CallSettings)
            // Additional: TestIamPermissionsAsync(KeyNameOneof,IEnumerable<string>,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyNameOneof resource = KeyNameOneof.From(new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"));
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = await keyManagementServiceClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(KeyNameOneof,IEnumerable<string>,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyNameOneof resource = KeyNameOneof.From(new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"));
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = keyManagementServiceClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest,CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest,CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = KeyNameOneof.From(new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]")),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = await keyManagementServiceClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest,CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = KeyNameOneof.From(new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]")),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = keyManagementServiceClient.TestIamPermissions(request);
            // End snippet
        }

    }
}
