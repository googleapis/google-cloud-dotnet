// Copyright 2021 Google LLC
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

namespace Google.Cloud.Compute.V1.Snippets
{
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedInterconnectsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteInterconnectRequest, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            DeleteInterconnectRequest request = new DeleteInterconnectRequest
            {
                RequestId = "",
                Interconnect = "",
                Project = "",
            };
            // Make the request
            Operation response = interconnectsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteInterconnectRequest, CallSettings)
            // Additional: DeleteAsync(DeleteInterconnectRequest, CancellationToken)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInterconnectRequest request = new DeleteInterconnectRequest
            {
                RequestId = "",
                Interconnect = "",
                Project = "",
            };
            // Make the request
            Operation response = await interconnectsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnect = "";
            // Make the request
            Operation response = interconnectsClient.Delete(project, interconnect);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnect = "";
            // Make the request
            Operation response = await interconnectsClient.DeleteAsync(project, interconnect);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetInterconnectRequest, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            GetInterconnectRequest request = new GetInterconnectRequest
            {
                Interconnect = "",
                Project = "",
            };
            // Make the request
            Interconnect response = interconnectsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInterconnectRequest, CallSettings)
            // Additional: GetAsync(GetInterconnectRequest, CancellationToken)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            GetInterconnectRequest request = new GetInterconnectRequest
            {
                Interconnect = "",
                Project = "",
            };
            // Make the request
            Interconnect response = await interconnectsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnect = "";
            // Make the request
            Interconnect response = interconnectsClient.Get(project, interconnect);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnect = "";
            // Make the request
            Interconnect response = await interconnectsClient.GetAsync(project, interconnect);
            // End snippet
        }

        /// <summary>Snippet for GetDiagnostics</summary>
        public void GetDiagnosticsRequestObject()
        {
            // Snippet: GetDiagnostics(GetDiagnosticsInterconnectRequest, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            GetDiagnosticsInterconnectRequest request = new GetDiagnosticsInterconnectRequest
            {
                Interconnect = "",
                Project = "",
            };
            // Make the request
            InterconnectsGetDiagnosticsResponse response = interconnectsClient.GetDiagnostics(request);
            // End snippet
        }

        /// <summary>Snippet for GetDiagnosticsAsync</summary>
        public async Task GetDiagnosticsRequestObjectAsync()
        {
            // Snippet: GetDiagnosticsAsync(GetDiagnosticsInterconnectRequest, CallSettings)
            // Additional: GetDiagnosticsAsync(GetDiagnosticsInterconnectRequest, CancellationToken)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            GetDiagnosticsInterconnectRequest request = new GetDiagnosticsInterconnectRequest
            {
                Interconnect = "",
                Project = "",
            };
            // Make the request
            InterconnectsGetDiagnosticsResponse response = await interconnectsClient.GetDiagnosticsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDiagnostics</summary>
        public void GetDiagnostics()
        {
            // Snippet: GetDiagnostics(string, string, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnect = "";
            // Make the request
            InterconnectsGetDiagnosticsResponse response = interconnectsClient.GetDiagnostics(project, interconnect);
            // End snippet
        }

        /// <summary>Snippet for GetDiagnosticsAsync</summary>
        public async Task GetDiagnosticsAsync()
        {
            // Snippet: GetDiagnosticsAsync(string, string, CallSettings)
            // Additional: GetDiagnosticsAsync(string, string, CancellationToken)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnect = "";
            // Make the request
            InterconnectsGetDiagnosticsResponse response = await interconnectsClient.GetDiagnosticsAsync(project, interconnect);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertInterconnectRequest, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            InsertInterconnectRequest request = new InsertInterconnectRequest
            {
                RequestId = "",
                Project = "",
                InterconnectResource = new Interconnect(),
            };
            // Make the request
            Operation response = interconnectsClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertInterconnectRequest, CallSettings)
            // Additional: InsertAsync(InsertInterconnectRequest, CancellationToken)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            InsertInterconnectRequest request = new InsertInterconnectRequest
            {
                RequestId = "",
                Project = "",
                InterconnectResource = new Interconnect(),
            };
            // Make the request
            Operation response = await interconnectsClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, Interconnect, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            Interconnect interconnectResource = new Interconnect();
            // Make the request
            Operation response = interconnectsClient.Insert(project, interconnectResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, Interconnect, CallSettings)
            // Additional: InsertAsync(string, Interconnect, CancellationToken)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            Interconnect interconnectResource = new Interconnect();
            // Make the request
            Operation response = await interconnectsClient.InsertAsync(project, interconnectResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListInterconnectsRequest, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            ListInterconnectsRequest request = new ListInterconnectsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InterconnectList, Interconnect> response = interconnectsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Interconnect item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InterconnectList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Interconnect item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Interconnect> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Interconnect item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListInterconnectsRequest, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            ListInterconnectsRequest request = new ListInterconnectsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InterconnectList, Interconnect> response = interconnectsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Interconnect item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InterconnectList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Interconnect item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Interconnect> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Interconnect item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, int?, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<InterconnectList, Interconnect> response = interconnectsClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Interconnect item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InterconnectList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Interconnect item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Interconnect> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Interconnect item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, int?, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<InterconnectList, Interconnect> response = interconnectsClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Interconnect item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InterconnectList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Interconnect item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Interconnect> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Interconnect item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchInterconnectRequest, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            PatchInterconnectRequest request = new PatchInterconnectRequest
            {
                RequestId = "",
                Interconnect = "",
                Project = "",
                InterconnectResource = new Interconnect(),
            };
            // Make the request
            Operation response = interconnectsClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchInterconnectRequest, CallSettings)
            // Additional: PatchAsync(PatchInterconnectRequest, CancellationToken)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            PatchInterconnectRequest request = new PatchInterconnectRequest
            {
                RequestId = "",
                Interconnect = "",
                Project = "",
                InterconnectResource = new Interconnect(),
            };
            // Make the request
            Operation response = await interconnectsClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, Interconnect, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnect = "";
            Interconnect interconnectResource = new Interconnect();
            // Make the request
            Operation response = interconnectsClient.Patch(project, interconnect, interconnectResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, Interconnect, CallSettings)
            // Additional: PatchAsync(string, string, Interconnect, CancellationToken)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnect = "";
            Interconnect interconnectResource = new Interconnect();
            // Make the request
            Operation response = await interconnectsClient.PatchAsync(project, interconnect, interconnectResource);
            // End snippet
        }
    }
}
