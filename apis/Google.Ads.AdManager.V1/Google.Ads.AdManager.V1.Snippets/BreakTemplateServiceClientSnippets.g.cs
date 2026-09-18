// Copyright 2026 Google LLC
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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBreakTemplateServiceClientSnippets
    {
        /// <summary>Snippet for GetBreakTemplate</summary>
        public void GetBreakTemplateRequestObject()
        {
            // Snippet: GetBreakTemplate(GetBreakTemplateRequest, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            GetBreakTemplateRequest request = new GetBreakTemplateRequest
            {
                BreakTemplateName = BreakTemplateName.FromNetworkCodeBreakTemplate("[NETWORK_CODE]", "[BREAK_TEMPLATE]"),
            };
            // Make the request
            BreakTemplate response = breakTemplateServiceClient.GetBreakTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetBreakTemplateAsync</summary>
        public async Task GetBreakTemplateRequestObjectAsync()
        {
            // Snippet: GetBreakTemplateAsync(GetBreakTemplateRequest, CallSettings)
            // Additional: GetBreakTemplateAsync(GetBreakTemplateRequest, CancellationToken)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBreakTemplateRequest request = new GetBreakTemplateRequest
            {
                BreakTemplateName = BreakTemplateName.FromNetworkCodeBreakTemplate("[NETWORK_CODE]", "[BREAK_TEMPLATE]"),
            };
            // Make the request
            BreakTemplate response = await breakTemplateServiceClient.GetBreakTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBreakTemplate</summary>
        public void GetBreakTemplate()
        {
            // Snippet: GetBreakTemplate(string, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/breakTemplates/[BREAK_TEMPLATE]";
            // Make the request
            BreakTemplate response = breakTemplateServiceClient.GetBreakTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetBreakTemplateAsync</summary>
        public async Task GetBreakTemplateAsync()
        {
            // Snippet: GetBreakTemplateAsync(string, CallSettings)
            // Additional: GetBreakTemplateAsync(string, CancellationToken)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/breakTemplates/[BREAK_TEMPLATE]";
            // Make the request
            BreakTemplate response = await breakTemplateServiceClient.GetBreakTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBreakTemplate</summary>
        public void GetBreakTemplateResourceNames()
        {
            // Snippet: GetBreakTemplate(BreakTemplateName, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            BreakTemplateName name = BreakTemplateName.FromNetworkCodeBreakTemplate("[NETWORK_CODE]", "[BREAK_TEMPLATE]");
            // Make the request
            BreakTemplate response = breakTemplateServiceClient.GetBreakTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetBreakTemplateAsync</summary>
        public async Task GetBreakTemplateResourceNamesAsync()
        {
            // Snippet: GetBreakTemplateAsync(BreakTemplateName, CallSettings)
            // Additional: GetBreakTemplateAsync(BreakTemplateName, CancellationToken)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            BreakTemplateName name = BreakTemplateName.FromNetworkCodeBreakTemplate("[NETWORK_CODE]", "[BREAK_TEMPLATE]");
            // Make the request
            BreakTemplate response = await breakTemplateServiceClient.GetBreakTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBreakTemplates</summary>
        public void ListBreakTemplatesRequestObject()
        {
            // Snippet: ListBreakTemplates(ListBreakTemplatesRequest, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            ListBreakTemplatesRequest request = new ListBreakTemplatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListBreakTemplatesResponse, BreakTemplate> response = breakTemplateServiceClient.ListBreakTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BreakTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBreakTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BreakTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BreakTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BreakTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBreakTemplatesAsync</summary>
        public async Task ListBreakTemplatesRequestObjectAsync()
        {
            // Snippet: ListBreakTemplatesAsync(ListBreakTemplatesRequest, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListBreakTemplatesRequest request = new ListBreakTemplatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListBreakTemplatesResponse, BreakTemplate> response = breakTemplateServiceClient.ListBreakTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (BreakTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBreakTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BreakTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BreakTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BreakTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBreakTemplates</summary>
        public void ListBreakTemplates()
        {
            // Snippet: ListBreakTemplates(string, string, int?, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListBreakTemplatesResponse, BreakTemplate> response = breakTemplateServiceClient.ListBreakTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BreakTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBreakTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BreakTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BreakTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BreakTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBreakTemplatesAsync</summary>
        public async Task ListBreakTemplatesAsync()
        {
            // Snippet: ListBreakTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListBreakTemplatesResponse, BreakTemplate> response = breakTemplateServiceClient.ListBreakTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (BreakTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBreakTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BreakTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BreakTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BreakTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBreakTemplates</summary>
        public void ListBreakTemplatesResourceNames()
        {
            // Snippet: ListBreakTemplates(NetworkName, string, int?, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListBreakTemplatesResponse, BreakTemplate> response = breakTemplateServiceClient.ListBreakTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BreakTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBreakTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BreakTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BreakTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BreakTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBreakTemplatesAsync</summary>
        public async Task ListBreakTemplatesResourceNamesAsync()
        {
            // Snippet: ListBreakTemplatesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListBreakTemplatesResponse, BreakTemplate> response = breakTemplateServiceClient.ListBreakTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (BreakTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBreakTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BreakTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BreakTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BreakTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateBreakTemplate</summary>
        public void CreateBreakTemplateRequestObject()
        {
            // Snippet: CreateBreakTemplate(CreateBreakTemplateRequest, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            CreateBreakTemplateRequest request = new CreateBreakTemplateRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                BreakTemplate = new BreakTemplate(),
            };
            // Make the request
            BreakTemplate response = breakTemplateServiceClient.CreateBreakTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBreakTemplateAsync</summary>
        public async Task CreateBreakTemplateRequestObjectAsync()
        {
            // Snippet: CreateBreakTemplateAsync(CreateBreakTemplateRequest, CallSettings)
            // Additional: CreateBreakTemplateAsync(CreateBreakTemplateRequest, CancellationToken)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateBreakTemplateRequest request = new CreateBreakTemplateRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                BreakTemplate = new BreakTemplate(),
            };
            // Make the request
            BreakTemplate response = await breakTemplateServiceClient.CreateBreakTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBreakTemplate</summary>
        public void CreateBreakTemplate()
        {
            // Snippet: CreateBreakTemplate(string, BreakTemplate, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            BreakTemplate breakTemplate = new BreakTemplate();
            // Make the request
            BreakTemplate response = breakTemplateServiceClient.CreateBreakTemplate(parent, breakTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateBreakTemplateAsync</summary>
        public async Task CreateBreakTemplateAsync()
        {
            // Snippet: CreateBreakTemplateAsync(string, BreakTemplate, CallSettings)
            // Additional: CreateBreakTemplateAsync(string, BreakTemplate, CancellationToken)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            BreakTemplate breakTemplate = new BreakTemplate();
            // Make the request
            BreakTemplate response = await breakTemplateServiceClient.CreateBreakTemplateAsync(parent, breakTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateBreakTemplate</summary>
        public void CreateBreakTemplateResourceNames()
        {
            // Snippet: CreateBreakTemplate(NetworkName, BreakTemplate, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            BreakTemplate breakTemplate = new BreakTemplate();
            // Make the request
            BreakTemplate response = breakTemplateServiceClient.CreateBreakTemplate(parent, breakTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateBreakTemplateAsync</summary>
        public async Task CreateBreakTemplateResourceNamesAsync()
        {
            // Snippet: CreateBreakTemplateAsync(NetworkName, BreakTemplate, CallSettings)
            // Additional: CreateBreakTemplateAsync(NetworkName, BreakTemplate, CancellationToken)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            BreakTemplate breakTemplate = new BreakTemplate();
            // Make the request
            BreakTemplate response = await breakTemplateServiceClient.CreateBreakTemplateAsync(parent, breakTemplate);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateBreakTemplates</summary>
        public void BatchCreateBreakTemplatesRequestObject()
        {
            // Snippet: BatchCreateBreakTemplates(BatchCreateBreakTemplatesRequest, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateBreakTemplatesRequest request = new BatchCreateBreakTemplatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateBreakTemplateRequest(),
                },
            };
            // Make the request
            BatchCreateBreakTemplatesResponse response = breakTemplateServiceClient.BatchCreateBreakTemplates(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateBreakTemplatesAsync</summary>
        public async Task BatchCreateBreakTemplatesRequestObjectAsync()
        {
            // Snippet: BatchCreateBreakTemplatesAsync(BatchCreateBreakTemplatesRequest, CallSettings)
            // Additional: BatchCreateBreakTemplatesAsync(BatchCreateBreakTemplatesRequest, CancellationToken)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateBreakTemplatesRequest request = new BatchCreateBreakTemplatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateBreakTemplateRequest(),
                },
            };
            // Make the request
            BatchCreateBreakTemplatesResponse response = await breakTemplateServiceClient.BatchCreateBreakTemplatesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateBreakTemplates</summary>
        public void BatchCreateBreakTemplates()
        {
            // Snippet: BatchCreateBreakTemplates(string, IEnumerable<CreateBreakTemplateRequest>, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateBreakTemplateRequest> requests = new CreateBreakTemplateRequest[]
            {
                new CreateBreakTemplateRequest(),
            };
            // Make the request
            BatchCreateBreakTemplatesResponse response = breakTemplateServiceClient.BatchCreateBreakTemplates(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateBreakTemplatesAsync</summary>
        public async Task BatchCreateBreakTemplatesAsync()
        {
            // Snippet: BatchCreateBreakTemplatesAsync(string, IEnumerable<CreateBreakTemplateRequest>, CallSettings)
            // Additional: BatchCreateBreakTemplatesAsync(string, IEnumerable<CreateBreakTemplateRequest>, CancellationToken)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateBreakTemplateRequest> requests = new CreateBreakTemplateRequest[]
            {
                new CreateBreakTemplateRequest(),
            };
            // Make the request
            BatchCreateBreakTemplatesResponse response = await breakTemplateServiceClient.BatchCreateBreakTemplatesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateBreakTemplates</summary>
        public void BatchCreateBreakTemplatesResourceNames()
        {
            // Snippet: BatchCreateBreakTemplates(NetworkName, IEnumerable<CreateBreakTemplateRequest>, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateBreakTemplateRequest> requests = new CreateBreakTemplateRequest[]
            {
                new CreateBreakTemplateRequest(),
            };
            // Make the request
            BatchCreateBreakTemplatesResponse response = breakTemplateServiceClient.BatchCreateBreakTemplates(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateBreakTemplatesAsync</summary>
        public async Task BatchCreateBreakTemplatesResourceNamesAsync()
        {
            // Snippet: BatchCreateBreakTemplatesAsync(NetworkName, IEnumerable<CreateBreakTemplateRequest>, CallSettings)
            // Additional: BatchCreateBreakTemplatesAsync(NetworkName, IEnumerable<CreateBreakTemplateRequest>, CancellationToken)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateBreakTemplateRequest> requests = new CreateBreakTemplateRequest[]
            {
                new CreateBreakTemplateRequest(),
            };
            // Make the request
            BatchCreateBreakTemplatesResponse response = await breakTemplateServiceClient.BatchCreateBreakTemplatesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateBreakTemplate</summary>
        public void UpdateBreakTemplateRequestObject()
        {
            // Snippet: UpdateBreakTemplate(UpdateBreakTemplateRequest, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            UpdateBreakTemplateRequest request = new UpdateBreakTemplateRequest
            {
                BreakTemplate = new BreakTemplate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BreakTemplate response = breakTemplateServiceClient.UpdateBreakTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBreakTemplateAsync</summary>
        public async Task UpdateBreakTemplateRequestObjectAsync()
        {
            // Snippet: UpdateBreakTemplateAsync(UpdateBreakTemplateRequest, CallSettings)
            // Additional: UpdateBreakTemplateAsync(UpdateBreakTemplateRequest, CancellationToken)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBreakTemplateRequest request = new UpdateBreakTemplateRequest
            {
                BreakTemplate = new BreakTemplate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BreakTemplate response = await breakTemplateServiceClient.UpdateBreakTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBreakTemplate</summary>
        public void UpdateBreakTemplate()
        {
            // Snippet: UpdateBreakTemplate(BreakTemplate, FieldMask, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            BreakTemplate breakTemplate = new BreakTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BreakTemplate response = breakTemplateServiceClient.UpdateBreakTemplate(breakTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateBreakTemplateAsync</summary>
        public async Task UpdateBreakTemplateAsync()
        {
            // Snippet: UpdateBreakTemplateAsync(BreakTemplate, FieldMask, CallSettings)
            // Additional: UpdateBreakTemplateAsync(BreakTemplate, FieldMask, CancellationToken)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            BreakTemplate breakTemplate = new BreakTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BreakTemplate response = await breakTemplateServiceClient.UpdateBreakTemplateAsync(breakTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateBreakTemplates</summary>
        public void BatchUpdateBreakTemplatesRequestObject()
        {
            // Snippet: BatchUpdateBreakTemplates(BatchUpdateBreakTemplatesRequest, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateBreakTemplatesRequest request = new BatchUpdateBreakTemplatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateBreakTemplateRequest(),
                },
            };
            // Make the request
            BatchUpdateBreakTemplatesResponse response = breakTemplateServiceClient.BatchUpdateBreakTemplates(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateBreakTemplatesAsync</summary>
        public async Task BatchUpdateBreakTemplatesRequestObjectAsync()
        {
            // Snippet: BatchUpdateBreakTemplatesAsync(BatchUpdateBreakTemplatesRequest, CallSettings)
            // Additional: BatchUpdateBreakTemplatesAsync(BatchUpdateBreakTemplatesRequest, CancellationToken)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateBreakTemplatesRequest request = new BatchUpdateBreakTemplatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateBreakTemplateRequest(),
                },
            };
            // Make the request
            BatchUpdateBreakTemplatesResponse response = await breakTemplateServiceClient.BatchUpdateBreakTemplatesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateBreakTemplates</summary>
        public void BatchUpdateBreakTemplates()
        {
            // Snippet: BatchUpdateBreakTemplates(string, IEnumerable<UpdateBreakTemplateRequest>, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateBreakTemplateRequest> requests = new UpdateBreakTemplateRequest[]
            {
                new UpdateBreakTemplateRequest(),
            };
            // Make the request
            BatchUpdateBreakTemplatesResponse response = breakTemplateServiceClient.BatchUpdateBreakTemplates(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateBreakTemplatesAsync</summary>
        public async Task BatchUpdateBreakTemplatesAsync()
        {
            // Snippet: BatchUpdateBreakTemplatesAsync(string, IEnumerable<UpdateBreakTemplateRequest>, CallSettings)
            // Additional: BatchUpdateBreakTemplatesAsync(string, IEnumerable<UpdateBreakTemplateRequest>, CancellationToken)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateBreakTemplateRequest> requests = new UpdateBreakTemplateRequest[]
            {
                new UpdateBreakTemplateRequest(),
            };
            // Make the request
            BatchUpdateBreakTemplatesResponse response = await breakTemplateServiceClient.BatchUpdateBreakTemplatesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateBreakTemplates</summary>
        public void BatchUpdateBreakTemplatesResourceNames()
        {
            // Snippet: BatchUpdateBreakTemplates(NetworkName, IEnumerable<UpdateBreakTemplateRequest>, CallSettings)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = BreakTemplateServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateBreakTemplateRequest> requests = new UpdateBreakTemplateRequest[]
            {
                new UpdateBreakTemplateRequest(),
            };
            // Make the request
            BatchUpdateBreakTemplatesResponse response = breakTemplateServiceClient.BatchUpdateBreakTemplates(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateBreakTemplatesAsync</summary>
        public async Task BatchUpdateBreakTemplatesResourceNamesAsync()
        {
            // Snippet: BatchUpdateBreakTemplatesAsync(NetworkName, IEnumerable<UpdateBreakTemplateRequest>, CallSettings)
            // Additional: BatchUpdateBreakTemplatesAsync(NetworkName, IEnumerable<UpdateBreakTemplateRequest>, CancellationToken)
            // Create client
            BreakTemplateServiceClient breakTemplateServiceClient = await BreakTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateBreakTemplateRequest> requests = new UpdateBreakTemplateRequest[]
            {
                new UpdateBreakTemplateRequest(),
            };
            // Make the request
            BatchUpdateBreakTemplatesResponse response = await breakTemplateServiceClient.BatchUpdateBreakTemplatesAsync(parent, requests);
            // End snippet
        }
    }
}
