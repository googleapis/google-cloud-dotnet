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
    using Google.Cloud.ApiHub.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRuntimeProjectAttachmentServiceClientSnippets
    {
        /// <summary>Snippet for CreateRuntimeProjectAttachment</summary>
        public void CreateRuntimeProjectAttachmentRequestObject()
        {
            // Snippet: CreateRuntimeProjectAttachment(CreateRuntimeProjectAttachmentRequest, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            CreateRuntimeProjectAttachmentRequest request = new CreateRuntimeProjectAttachmentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                RuntimeProjectAttachmentId = "",
                RuntimeProjectAttachment = new RuntimeProjectAttachment(),
            };
            // Make the request
            RuntimeProjectAttachment response = runtimeProjectAttachmentServiceClient.CreateRuntimeProjectAttachment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRuntimeProjectAttachmentAsync</summary>
        public async Task CreateRuntimeProjectAttachmentRequestObjectAsync()
        {
            // Snippet: CreateRuntimeProjectAttachmentAsync(CreateRuntimeProjectAttachmentRequest, CallSettings)
            // Additional: CreateRuntimeProjectAttachmentAsync(CreateRuntimeProjectAttachmentRequest, CancellationToken)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateRuntimeProjectAttachmentRequest request = new CreateRuntimeProjectAttachmentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                RuntimeProjectAttachmentId = "",
                RuntimeProjectAttachment = new RuntimeProjectAttachment(),
            };
            // Make the request
            RuntimeProjectAttachment response = await runtimeProjectAttachmentServiceClient.CreateRuntimeProjectAttachmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRuntimeProjectAttachment</summary>
        public void CreateRuntimeProjectAttachment()
        {
            // Snippet: CreateRuntimeProjectAttachment(string, RuntimeProjectAttachment, string, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RuntimeProjectAttachment runtimeProjectAttachment = new RuntimeProjectAttachment();
            string runtimeProjectAttachmentId = "";
            // Make the request
            RuntimeProjectAttachment response = runtimeProjectAttachmentServiceClient.CreateRuntimeProjectAttachment(parent, runtimeProjectAttachment, runtimeProjectAttachmentId);
            // End snippet
        }

        /// <summary>Snippet for CreateRuntimeProjectAttachmentAsync</summary>
        public async Task CreateRuntimeProjectAttachmentAsync()
        {
            // Snippet: CreateRuntimeProjectAttachmentAsync(string, RuntimeProjectAttachment, string, CallSettings)
            // Additional: CreateRuntimeProjectAttachmentAsync(string, RuntimeProjectAttachment, string, CancellationToken)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RuntimeProjectAttachment runtimeProjectAttachment = new RuntimeProjectAttachment();
            string runtimeProjectAttachmentId = "";
            // Make the request
            RuntimeProjectAttachment response = await runtimeProjectAttachmentServiceClient.CreateRuntimeProjectAttachmentAsync(parent, runtimeProjectAttachment, runtimeProjectAttachmentId);
            // End snippet
        }

        /// <summary>Snippet for CreateRuntimeProjectAttachment</summary>
        public void CreateRuntimeProjectAttachmentResourceNames()
        {
            // Snippet: CreateRuntimeProjectAttachment(LocationName, RuntimeProjectAttachment, string, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RuntimeProjectAttachment runtimeProjectAttachment = new RuntimeProjectAttachment();
            string runtimeProjectAttachmentId = "";
            // Make the request
            RuntimeProjectAttachment response = runtimeProjectAttachmentServiceClient.CreateRuntimeProjectAttachment(parent, runtimeProjectAttachment, runtimeProjectAttachmentId);
            // End snippet
        }

        /// <summary>Snippet for CreateRuntimeProjectAttachmentAsync</summary>
        public async Task CreateRuntimeProjectAttachmentResourceNamesAsync()
        {
            // Snippet: CreateRuntimeProjectAttachmentAsync(LocationName, RuntimeProjectAttachment, string, CallSettings)
            // Additional: CreateRuntimeProjectAttachmentAsync(LocationName, RuntimeProjectAttachment, string, CancellationToken)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RuntimeProjectAttachment runtimeProjectAttachment = new RuntimeProjectAttachment();
            string runtimeProjectAttachmentId = "";
            // Make the request
            RuntimeProjectAttachment response = await runtimeProjectAttachmentServiceClient.CreateRuntimeProjectAttachmentAsync(parent, runtimeProjectAttachment, runtimeProjectAttachmentId);
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeProjectAttachment</summary>
        public void GetRuntimeProjectAttachmentRequestObject()
        {
            // Snippet: GetRuntimeProjectAttachment(GetRuntimeProjectAttachmentRequest, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            GetRuntimeProjectAttachmentRequest request = new GetRuntimeProjectAttachmentRequest
            {
                RuntimeProjectAttachmentName = RuntimeProjectAttachmentName.FromProjectLocationRuntimeProjectAttachment("[PROJECT]", "[LOCATION]", "[RUNTIME_PROJECT_ATTACHMENT]"),
            };
            // Make the request
            RuntimeProjectAttachment response = runtimeProjectAttachmentServiceClient.GetRuntimeProjectAttachment(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeProjectAttachmentAsync</summary>
        public async Task GetRuntimeProjectAttachmentRequestObjectAsync()
        {
            // Snippet: GetRuntimeProjectAttachmentAsync(GetRuntimeProjectAttachmentRequest, CallSettings)
            // Additional: GetRuntimeProjectAttachmentAsync(GetRuntimeProjectAttachmentRequest, CancellationToken)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRuntimeProjectAttachmentRequest request = new GetRuntimeProjectAttachmentRequest
            {
                RuntimeProjectAttachmentName = RuntimeProjectAttachmentName.FromProjectLocationRuntimeProjectAttachment("[PROJECT]", "[LOCATION]", "[RUNTIME_PROJECT_ATTACHMENT]"),
            };
            // Make the request
            RuntimeProjectAttachment response = await runtimeProjectAttachmentServiceClient.GetRuntimeProjectAttachmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeProjectAttachment</summary>
        public void GetRuntimeProjectAttachment()
        {
            // Snippet: GetRuntimeProjectAttachment(string, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimeProjectAttachments/[RUNTIME_PROJECT_ATTACHMENT]";
            // Make the request
            RuntimeProjectAttachment response = runtimeProjectAttachmentServiceClient.GetRuntimeProjectAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeProjectAttachmentAsync</summary>
        public async Task GetRuntimeProjectAttachmentAsync()
        {
            // Snippet: GetRuntimeProjectAttachmentAsync(string, CallSettings)
            // Additional: GetRuntimeProjectAttachmentAsync(string, CancellationToken)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimeProjectAttachments/[RUNTIME_PROJECT_ATTACHMENT]";
            // Make the request
            RuntimeProjectAttachment response = await runtimeProjectAttachmentServiceClient.GetRuntimeProjectAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeProjectAttachment</summary>
        public void GetRuntimeProjectAttachmentResourceNames()
        {
            // Snippet: GetRuntimeProjectAttachment(RuntimeProjectAttachmentName, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            RuntimeProjectAttachmentName name = RuntimeProjectAttachmentName.FromProjectLocationRuntimeProjectAttachment("[PROJECT]", "[LOCATION]", "[RUNTIME_PROJECT_ATTACHMENT]");
            // Make the request
            RuntimeProjectAttachment response = runtimeProjectAttachmentServiceClient.GetRuntimeProjectAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeProjectAttachmentAsync</summary>
        public async Task GetRuntimeProjectAttachmentResourceNamesAsync()
        {
            // Snippet: GetRuntimeProjectAttachmentAsync(RuntimeProjectAttachmentName, CallSettings)
            // Additional: GetRuntimeProjectAttachmentAsync(RuntimeProjectAttachmentName, CancellationToken)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuntimeProjectAttachmentName name = RuntimeProjectAttachmentName.FromProjectLocationRuntimeProjectAttachment("[PROJECT]", "[LOCATION]", "[RUNTIME_PROJECT_ATTACHMENT]");
            // Make the request
            RuntimeProjectAttachment response = await runtimeProjectAttachmentServiceClient.GetRuntimeProjectAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeProjectAttachments</summary>
        public void ListRuntimeProjectAttachmentsRequestObject()
        {
            // Snippet: ListRuntimeProjectAttachments(ListRuntimeProjectAttachmentsRequest, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            ListRuntimeProjectAttachmentsRequest request = new ListRuntimeProjectAttachmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment> response = runtimeProjectAttachmentServiceClient.ListRuntimeProjectAttachments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuntimeProjectAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuntimeProjectAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeProjectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeProjectAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeProjectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeProjectAttachmentsAsync</summary>
        public async Task ListRuntimeProjectAttachmentsRequestObjectAsync()
        {
            // Snippet: ListRuntimeProjectAttachmentsAsync(ListRuntimeProjectAttachmentsRequest, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRuntimeProjectAttachmentsRequest request = new ListRuntimeProjectAttachmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment> response = runtimeProjectAttachmentServiceClient.ListRuntimeProjectAttachmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RuntimeProjectAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuntimeProjectAttachmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeProjectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeProjectAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeProjectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeProjectAttachments</summary>
        public void ListRuntimeProjectAttachments()
        {
            // Snippet: ListRuntimeProjectAttachments(string, string, int?, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment> response = runtimeProjectAttachmentServiceClient.ListRuntimeProjectAttachments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuntimeProjectAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuntimeProjectAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeProjectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeProjectAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeProjectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeProjectAttachmentsAsync</summary>
        public async Task ListRuntimeProjectAttachmentsAsync()
        {
            // Snippet: ListRuntimeProjectAttachmentsAsync(string, string, int?, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment> response = runtimeProjectAttachmentServiceClient.ListRuntimeProjectAttachmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RuntimeProjectAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuntimeProjectAttachmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeProjectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeProjectAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeProjectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeProjectAttachments</summary>
        public void ListRuntimeProjectAttachmentsResourceNames()
        {
            // Snippet: ListRuntimeProjectAttachments(LocationName, string, int?, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment> response = runtimeProjectAttachmentServiceClient.ListRuntimeProjectAttachments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuntimeProjectAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuntimeProjectAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeProjectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeProjectAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeProjectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeProjectAttachmentsAsync</summary>
        public async Task ListRuntimeProjectAttachmentsResourceNamesAsync()
        {
            // Snippet: ListRuntimeProjectAttachmentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment> response = runtimeProjectAttachmentServiceClient.ListRuntimeProjectAttachmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RuntimeProjectAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuntimeProjectAttachmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeProjectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeProjectAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeProjectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteRuntimeProjectAttachment</summary>
        public void DeleteRuntimeProjectAttachmentRequestObject()
        {
            // Snippet: DeleteRuntimeProjectAttachment(DeleteRuntimeProjectAttachmentRequest, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            DeleteRuntimeProjectAttachmentRequest request = new DeleteRuntimeProjectAttachmentRequest
            {
                RuntimeProjectAttachmentName = RuntimeProjectAttachmentName.FromProjectLocationRuntimeProjectAttachment("[PROJECT]", "[LOCATION]", "[RUNTIME_PROJECT_ATTACHMENT]"),
            };
            // Make the request
            runtimeProjectAttachmentServiceClient.DeleteRuntimeProjectAttachment(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRuntimeProjectAttachmentAsync</summary>
        public async Task DeleteRuntimeProjectAttachmentRequestObjectAsync()
        {
            // Snippet: DeleteRuntimeProjectAttachmentAsync(DeleteRuntimeProjectAttachmentRequest, CallSettings)
            // Additional: DeleteRuntimeProjectAttachmentAsync(DeleteRuntimeProjectAttachmentRequest, CancellationToken)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRuntimeProjectAttachmentRequest request = new DeleteRuntimeProjectAttachmentRequest
            {
                RuntimeProjectAttachmentName = RuntimeProjectAttachmentName.FromProjectLocationRuntimeProjectAttachment("[PROJECT]", "[LOCATION]", "[RUNTIME_PROJECT_ATTACHMENT]"),
            };
            // Make the request
            await runtimeProjectAttachmentServiceClient.DeleteRuntimeProjectAttachmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRuntimeProjectAttachment</summary>
        public void DeleteRuntimeProjectAttachment()
        {
            // Snippet: DeleteRuntimeProjectAttachment(string, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimeProjectAttachments/[RUNTIME_PROJECT_ATTACHMENT]";
            // Make the request
            runtimeProjectAttachmentServiceClient.DeleteRuntimeProjectAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRuntimeProjectAttachmentAsync</summary>
        public async Task DeleteRuntimeProjectAttachmentAsync()
        {
            // Snippet: DeleteRuntimeProjectAttachmentAsync(string, CallSettings)
            // Additional: DeleteRuntimeProjectAttachmentAsync(string, CancellationToken)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimeProjectAttachments/[RUNTIME_PROJECT_ATTACHMENT]";
            // Make the request
            await runtimeProjectAttachmentServiceClient.DeleteRuntimeProjectAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRuntimeProjectAttachment</summary>
        public void DeleteRuntimeProjectAttachmentResourceNames()
        {
            // Snippet: DeleteRuntimeProjectAttachment(RuntimeProjectAttachmentName, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            RuntimeProjectAttachmentName name = RuntimeProjectAttachmentName.FromProjectLocationRuntimeProjectAttachment("[PROJECT]", "[LOCATION]", "[RUNTIME_PROJECT_ATTACHMENT]");
            // Make the request
            runtimeProjectAttachmentServiceClient.DeleteRuntimeProjectAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRuntimeProjectAttachmentAsync</summary>
        public async Task DeleteRuntimeProjectAttachmentResourceNamesAsync()
        {
            // Snippet: DeleteRuntimeProjectAttachmentAsync(RuntimeProjectAttachmentName, CallSettings)
            // Additional: DeleteRuntimeProjectAttachmentAsync(RuntimeProjectAttachmentName, CancellationToken)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuntimeProjectAttachmentName name = RuntimeProjectAttachmentName.FromProjectLocationRuntimeProjectAttachment("[PROJECT]", "[LOCATION]", "[RUNTIME_PROJECT_ATTACHMENT]");
            // Make the request
            await runtimeProjectAttachmentServiceClient.DeleteRuntimeProjectAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LookupRuntimeProjectAttachment</summary>
        public void LookupRuntimeProjectAttachmentRequestObject()
        {
            // Snippet: LookupRuntimeProjectAttachment(LookupRuntimeProjectAttachmentRequest, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            LookupRuntimeProjectAttachmentRequest request = new LookupRuntimeProjectAttachmentRequest
            {
                LocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            LookupRuntimeProjectAttachmentResponse response = runtimeProjectAttachmentServiceClient.LookupRuntimeProjectAttachment(request);
            // End snippet
        }

        /// <summary>Snippet for LookupRuntimeProjectAttachmentAsync</summary>
        public async Task LookupRuntimeProjectAttachmentRequestObjectAsync()
        {
            // Snippet: LookupRuntimeProjectAttachmentAsync(LookupRuntimeProjectAttachmentRequest, CallSettings)
            // Additional: LookupRuntimeProjectAttachmentAsync(LookupRuntimeProjectAttachmentRequest, CancellationToken)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            LookupRuntimeProjectAttachmentRequest request = new LookupRuntimeProjectAttachmentRequest
            {
                LocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            LookupRuntimeProjectAttachmentResponse response = await runtimeProjectAttachmentServiceClient.LookupRuntimeProjectAttachmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LookupRuntimeProjectAttachment</summary>
        public void LookupRuntimeProjectAttachment()
        {
            // Snippet: LookupRuntimeProjectAttachment(string, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            LookupRuntimeProjectAttachmentResponse response = runtimeProjectAttachmentServiceClient.LookupRuntimeProjectAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for LookupRuntimeProjectAttachmentAsync</summary>
        public async Task LookupRuntimeProjectAttachmentAsync()
        {
            // Snippet: LookupRuntimeProjectAttachmentAsync(string, CallSettings)
            // Additional: LookupRuntimeProjectAttachmentAsync(string, CancellationToken)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            LookupRuntimeProjectAttachmentResponse response = await runtimeProjectAttachmentServiceClient.LookupRuntimeProjectAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LookupRuntimeProjectAttachment</summary>
        public void LookupRuntimeProjectAttachmentResourceNames()
        {
            // Snippet: LookupRuntimeProjectAttachment(LocationName, CallSettings)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = RuntimeProjectAttachmentServiceClient.Create();
            // Initialize request argument(s)
            LocationName name = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            LookupRuntimeProjectAttachmentResponse response = runtimeProjectAttachmentServiceClient.LookupRuntimeProjectAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for LookupRuntimeProjectAttachmentAsync</summary>
        public async Task LookupRuntimeProjectAttachmentResourceNamesAsync()
        {
            // Snippet: LookupRuntimeProjectAttachmentAsync(LocationName, CallSettings)
            // Additional: LookupRuntimeProjectAttachmentAsync(LocationName, CancellationToken)
            // Create client
            RuntimeProjectAttachmentServiceClient runtimeProjectAttachmentServiceClient = await RuntimeProjectAttachmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName name = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            LookupRuntimeProjectAttachmentResponse response = await runtimeProjectAttachmentServiceClient.LookupRuntimeProjectAttachmentAsync(name);
            // End snippet
        }
    }
}
