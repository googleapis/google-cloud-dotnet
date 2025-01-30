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
    using Google.Shopping.Merchant.Conversions.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConversionSourcesServiceClientSnippets
    {
        /// <summary>Snippet for CreateConversionSource</summary>
        public void CreateConversionSourceRequestObject()
        {
            // Snippet: CreateConversionSource(CreateConversionSourceRequest, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            CreateConversionSourceRequest request = new CreateConversionSourceRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                ConversionSource = new ConversionSource(),
            };
            // Make the request
            ConversionSource response = conversionSourcesServiceClient.CreateConversionSource(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConversionSourceAsync</summary>
        public async Task CreateConversionSourceRequestObjectAsync()
        {
            // Snippet: CreateConversionSourceAsync(CreateConversionSourceRequest, CallSettings)
            // Additional: CreateConversionSourceAsync(CreateConversionSourceRequest, CancellationToken)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateConversionSourceRequest request = new CreateConversionSourceRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                ConversionSource = new ConversionSource(),
            };
            // Make the request
            ConversionSource response = await conversionSourcesServiceClient.CreateConversionSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConversionSource</summary>
        public void CreateConversionSource()
        {
            // Snippet: CreateConversionSource(string, ConversionSource, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            ConversionSource conversionSource = new ConversionSource();
            // Make the request
            ConversionSource response = conversionSourcesServiceClient.CreateConversionSource(parent, conversionSource);
            // End snippet
        }

        /// <summary>Snippet for CreateConversionSourceAsync</summary>
        public async Task CreateConversionSourceAsync()
        {
            // Snippet: CreateConversionSourceAsync(string, ConversionSource, CallSettings)
            // Additional: CreateConversionSourceAsync(string, ConversionSource, CancellationToken)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            ConversionSource conversionSource = new ConversionSource();
            // Make the request
            ConversionSource response = await conversionSourcesServiceClient.CreateConversionSourceAsync(parent, conversionSource);
            // End snippet
        }

        /// <summary>Snippet for CreateConversionSource</summary>
        public void CreateConversionSourceResourceNames()
        {
            // Snippet: CreateConversionSource(AccountName, ConversionSource, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            ConversionSource conversionSource = new ConversionSource();
            // Make the request
            ConversionSource response = conversionSourcesServiceClient.CreateConversionSource(parent, conversionSource);
            // End snippet
        }

        /// <summary>Snippet for CreateConversionSourceAsync</summary>
        public async Task CreateConversionSourceResourceNamesAsync()
        {
            // Snippet: CreateConversionSourceAsync(AccountName, ConversionSource, CallSettings)
            // Additional: CreateConversionSourceAsync(AccountName, ConversionSource, CancellationToken)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            ConversionSource conversionSource = new ConversionSource();
            // Make the request
            ConversionSource response = await conversionSourcesServiceClient.CreateConversionSourceAsync(parent, conversionSource);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversionSource</summary>
        public void UpdateConversionSourceRequestObject()
        {
            // Snippet: UpdateConversionSource(UpdateConversionSourceRequest, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            UpdateConversionSourceRequest request = new UpdateConversionSourceRequest
            {
                ConversionSource = new ConversionSource(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ConversionSource response = conversionSourcesServiceClient.UpdateConversionSource(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversionSourceAsync</summary>
        public async Task UpdateConversionSourceRequestObjectAsync()
        {
            // Snippet: UpdateConversionSourceAsync(UpdateConversionSourceRequest, CallSettings)
            // Additional: UpdateConversionSourceAsync(UpdateConversionSourceRequest, CancellationToken)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConversionSourceRequest request = new UpdateConversionSourceRequest
            {
                ConversionSource = new ConversionSource(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ConversionSource response = await conversionSourcesServiceClient.UpdateConversionSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversionSource</summary>
        public void UpdateConversionSource()
        {
            // Snippet: UpdateConversionSource(ConversionSource, FieldMask, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            ConversionSource conversionSource = new ConversionSource();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ConversionSource response = conversionSourcesServiceClient.UpdateConversionSource(conversionSource, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversionSourceAsync</summary>
        public async Task UpdateConversionSourceAsync()
        {
            // Snippet: UpdateConversionSourceAsync(ConversionSource, FieldMask, CallSettings)
            // Additional: UpdateConversionSourceAsync(ConversionSource, FieldMask, CancellationToken)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionSource conversionSource = new ConversionSource();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ConversionSource response = await conversionSourcesServiceClient.UpdateConversionSourceAsync(conversionSource, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionSource</summary>
        public void DeleteConversionSourceRequestObject()
        {
            // Snippet: DeleteConversionSource(DeleteConversionSourceRequest, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            DeleteConversionSourceRequest request = new DeleteConversionSourceRequest
            {
                ConversionSourceName = ConversionSourceName.FromAccountConversionSource("[ACCOUNT]", "[CONVERSION_SOURCE]"),
            };
            // Make the request
            conversionSourcesServiceClient.DeleteConversionSource(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionSourceAsync</summary>
        public async Task DeleteConversionSourceRequestObjectAsync()
        {
            // Snippet: DeleteConversionSourceAsync(DeleteConversionSourceRequest, CallSettings)
            // Additional: DeleteConversionSourceAsync(DeleteConversionSourceRequest, CancellationToken)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConversionSourceRequest request = new DeleteConversionSourceRequest
            {
                ConversionSourceName = ConversionSourceName.FromAccountConversionSource("[ACCOUNT]", "[CONVERSION_SOURCE]"),
            };
            // Make the request
            await conversionSourcesServiceClient.DeleteConversionSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionSource</summary>
        public void DeleteConversionSource()
        {
            // Snippet: DeleteConversionSource(string, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/conversionSources/[CONVERSION_SOURCE]";
            // Make the request
            conversionSourcesServiceClient.DeleteConversionSource(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionSourceAsync</summary>
        public async Task DeleteConversionSourceAsync()
        {
            // Snippet: DeleteConversionSourceAsync(string, CallSettings)
            // Additional: DeleteConversionSourceAsync(string, CancellationToken)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/conversionSources/[CONVERSION_SOURCE]";
            // Make the request
            await conversionSourcesServiceClient.DeleteConversionSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionSource</summary>
        public void DeleteConversionSourceResourceNames()
        {
            // Snippet: DeleteConversionSource(ConversionSourceName, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            ConversionSourceName name = ConversionSourceName.FromAccountConversionSource("[ACCOUNT]", "[CONVERSION_SOURCE]");
            // Make the request
            conversionSourcesServiceClient.DeleteConversionSource(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionSourceAsync</summary>
        public async Task DeleteConversionSourceResourceNamesAsync()
        {
            // Snippet: DeleteConversionSourceAsync(ConversionSourceName, CallSettings)
            // Additional: DeleteConversionSourceAsync(ConversionSourceName, CancellationToken)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionSourceName name = ConversionSourceName.FromAccountConversionSource("[ACCOUNT]", "[CONVERSION_SOURCE]");
            // Make the request
            await conversionSourcesServiceClient.DeleteConversionSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UndeleteConversionSource</summary>
        public void UndeleteConversionSourceRequestObject()
        {
            // Snippet: UndeleteConversionSource(UndeleteConversionSourceRequest, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            UndeleteConversionSourceRequest request = new UndeleteConversionSourceRequest
            {
                ConversionSourceName = ConversionSourceName.FromAccountConversionSource("[ACCOUNT]", "[CONVERSION_SOURCE]"),
            };
            // Make the request
            ConversionSource response = conversionSourcesServiceClient.UndeleteConversionSource(request);
            // End snippet
        }

        /// <summary>Snippet for UndeleteConversionSourceAsync</summary>
        public async Task UndeleteConversionSourceRequestObjectAsync()
        {
            // Snippet: UndeleteConversionSourceAsync(UndeleteConversionSourceRequest, CallSettings)
            // Additional: UndeleteConversionSourceAsync(UndeleteConversionSourceRequest, CancellationToken)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteConversionSourceRequest request = new UndeleteConversionSourceRequest
            {
                ConversionSourceName = ConversionSourceName.FromAccountConversionSource("[ACCOUNT]", "[CONVERSION_SOURCE]"),
            };
            // Make the request
            ConversionSource response = await conversionSourcesServiceClient.UndeleteConversionSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversionSource</summary>
        public void GetConversionSourceRequestObject()
        {
            // Snippet: GetConversionSource(GetConversionSourceRequest, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            GetConversionSourceRequest request = new GetConversionSourceRequest
            {
                ConversionSourceName = ConversionSourceName.FromAccountConversionSource("[ACCOUNT]", "[CONVERSION_SOURCE]"),
            };
            // Make the request
            ConversionSource response = conversionSourcesServiceClient.GetConversionSource(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversionSourceAsync</summary>
        public async Task GetConversionSourceRequestObjectAsync()
        {
            // Snippet: GetConversionSourceAsync(GetConversionSourceRequest, CallSettings)
            // Additional: GetConversionSourceAsync(GetConversionSourceRequest, CancellationToken)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConversionSourceRequest request = new GetConversionSourceRequest
            {
                ConversionSourceName = ConversionSourceName.FromAccountConversionSource("[ACCOUNT]", "[CONVERSION_SOURCE]"),
            };
            // Make the request
            ConversionSource response = await conversionSourcesServiceClient.GetConversionSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversionSource</summary>
        public void GetConversionSource()
        {
            // Snippet: GetConversionSource(string, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/conversionSources/[CONVERSION_SOURCE]";
            // Make the request
            ConversionSource response = conversionSourcesServiceClient.GetConversionSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversionSourceAsync</summary>
        public async Task GetConversionSourceAsync()
        {
            // Snippet: GetConversionSourceAsync(string, CallSettings)
            // Additional: GetConversionSourceAsync(string, CancellationToken)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/conversionSources/[CONVERSION_SOURCE]";
            // Make the request
            ConversionSource response = await conversionSourcesServiceClient.GetConversionSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversionSource</summary>
        public void GetConversionSourceResourceNames()
        {
            // Snippet: GetConversionSource(ConversionSourceName, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            ConversionSourceName name = ConversionSourceName.FromAccountConversionSource("[ACCOUNT]", "[CONVERSION_SOURCE]");
            // Make the request
            ConversionSource response = conversionSourcesServiceClient.GetConversionSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversionSourceAsync</summary>
        public async Task GetConversionSourceResourceNamesAsync()
        {
            // Snippet: GetConversionSourceAsync(ConversionSourceName, CallSettings)
            // Additional: GetConversionSourceAsync(ConversionSourceName, CancellationToken)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionSourceName name = ConversionSourceName.FromAccountConversionSource("[ACCOUNT]", "[CONVERSION_SOURCE]");
            // Make the request
            ConversionSource response = await conversionSourcesServiceClient.GetConversionSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConversionSources</summary>
        public void ListConversionSourcesRequestObject()
        {
            // Snippet: ListConversionSources(ListConversionSourcesRequest, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            ListConversionSourcesRequest request = new ListConversionSourcesRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListConversionSourcesResponse, ConversionSource> response = conversionSourcesServiceClient.ListConversionSources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversionSource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversionSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionSource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionSourcesAsync</summary>
        public async Task ListConversionSourcesRequestObjectAsync()
        {
            // Snippet: ListConversionSourcesAsync(ListConversionSourcesRequest, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListConversionSourcesRequest request = new ListConversionSourcesRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListConversionSourcesResponse, ConversionSource> response = conversionSourcesServiceClient.ListConversionSourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversionSource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversionSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionSource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionSources</summary>
        public void ListConversionSources()
        {
            // Snippet: ListConversionSources(string, string, int?, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListConversionSourcesResponse, ConversionSource> response = conversionSourcesServiceClient.ListConversionSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversionSource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversionSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionSource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionSourcesAsync</summary>
        public async Task ListConversionSourcesAsync()
        {
            // Snippet: ListConversionSourcesAsync(string, string, int?, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListConversionSourcesResponse, ConversionSource> response = conversionSourcesServiceClient.ListConversionSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversionSource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversionSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionSource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionSources</summary>
        public void ListConversionSourcesResourceNames()
        {
            // Snippet: ListConversionSources(AccountName, string, int?, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = ConversionSourcesServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListConversionSourcesResponse, ConversionSource> response = conversionSourcesServiceClient.ListConversionSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversionSource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversionSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionSource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionSourcesAsync</summary>
        public async Task ListConversionSourcesResourceNamesAsync()
        {
            // Snippet: ListConversionSourcesAsync(AccountName, string, int?, CallSettings)
            // Create client
            ConversionSourcesServiceClient conversionSourcesServiceClient = await ConversionSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListConversionSourcesResponse, ConversionSource> response = conversionSourcesServiceClient.ListConversionSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversionSource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversionSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionSource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
