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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedInterconnectsClientSnippets
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
            lro::Operation<Operation, Operation> response = interconnectsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectsClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
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
            lro::Operation<Operation, Operation> response = await interconnectsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
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
            lro::Operation<Operation, Operation> response = interconnectsClient.Delete(project, interconnect);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectsClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
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
            lro::Operation<Operation, Operation> response = await interconnectsClient.DeleteAsync(project, interconnect);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
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

        /// <summary>Snippet for GetMacsecConfig</summary>
        public void GetMacsecConfigRequestObject()
        {
            // Snippet: GetMacsecConfig(GetMacsecConfigInterconnectRequest, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            GetMacsecConfigInterconnectRequest request = new GetMacsecConfigInterconnectRequest
            {
                Interconnect = "",
                Project = "",
            };
            // Make the request
            InterconnectsGetMacsecConfigResponse response = interconnectsClient.GetMacsecConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetMacsecConfigAsync</summary>
        public async Task GetMacsecConfigRequestObjectAsync()
        {
            // Snippet: GetMacsecConfigAsync(GetMacsecConfigInterconnectRequest, CallSettings)
            // Additional: GetMacsecConfigAsync(GetMacsecConfigInterconnectRequest, CancellationToken)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            GetMacsecConfigInterconnectRequest request = new GetMacsecConfigInterconnectRequest
            {
                Interconnect = "",
                Project = "",
            };
            // Make the request
            InterconnectsGetMacsecConfigResponse response = await interconnectsClient.GetMacsecConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMacsecConfig</summary>
        public void GetMacsecConfig()
        {
            // Snippet: GetMacsecConfig(string, string, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnect = "";
            // Make the request
            InterconnectsGetMacsecConfigResponse response = interconnectsClient.GetMacsecConfig(project, interconnect);
            // End snippet
        }

        /// <summary>Snippet for GetMacsecConfigAsync</summary>
        public async Task GetMacsecConfigAsync()
        {
            // Snippet: GetMacsecConfigAsync(string, string, CallSettings)
            // Additional: GetMacsecConfigAsync(string, string, CancellationToken)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnect = "";
            // Make the request
            InterconnectsGetMacsecConfigResponse response = await interconnectsClient.GetMacsecConfigAsync(project, interconnect);
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
            lro::Operation<Operation, Operation> response = interconnectsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectsClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
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
            lro::Operation<Operation, Operation> response = await interconnectsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectsClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
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
            lro::Operation<Operation, Operation> response = interconnectsClient.Insert(project, interconnectResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectsClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
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
            lro::Operation<Operation, Operation> response = await interconnectsClient.InsertAsync(project, interconnectResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectsClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
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
            lro::Operation<Operation, Operation> response = interconnectsClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectsClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
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
            lro::Operation<Operation, Operation> response = await interconnectsClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectsClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
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
            lro::Operation<Operation, Operation> response = interconnectsClient.Patch(project, interconnect, interconnectResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectsClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
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
            lro::Operation<Operation, Operation> response = await interconnectsClient.PatchAsync(project, interconnect, interconnectResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectsClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsInterconnectRequest, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            SetLabelsInterconnectRequest request = new SetLabelsInterconnectRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectsClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectsClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsInterconnectRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsInterconnectRequest, CancellationToken)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsInterconnectRequest request = new SetLabelsInterconnectRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectsClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectsClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, GlobalSetLabelsRequest, CallSettings)
            // Create client
            InterconnectsClient interconnectsClient = InterconnectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectsClient.SetLabels(project, resource, globalSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectsClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CancellationToken)
            // Create client
            InterconnectsClient interconnectsClient = await InterconnectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectsClient.SetLabelsAsync(project, resource, globalSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectsClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
