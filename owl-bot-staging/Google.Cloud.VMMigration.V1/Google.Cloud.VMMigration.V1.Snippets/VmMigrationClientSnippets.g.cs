// Copyright 2024 Google LLC
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
    using Google.Cloud.VMMigration.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedVmMigrationClientSnippets
    {
        /// <summary>Snippet for ListSources</summary>
        public void ListSourcesRequestObject()
        {
            // Snippet: ListSources(ListSourcesRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            ListSourcesRequest request = new ListSourcesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSourcesResponse, Source> response = vmMigrationClient.ListSources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Source item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSourcesAsync</summary>
        public async Task ListSourcesRequestObjectAsync()
        {
            // Snippet: ListSourcesAsync(ListSourcesRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            ListSourcesRequest request = new ListSourcesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSourcesResponse, Source> response = vmMigrationClient.ListSourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Source item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public void ListSources()
        {
            // Snippet: ListSources(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSourcesResponse, Source> response = vmMigrationClient.ListSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Source item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSourcesAsync</summary>
        public async Task ListSourcesAsync()
        {
            // Snippet: ListSourcesAsync(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSourcesResponse, Source> response = vmMigrationClient.ListSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Source item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public void ListSourcesResourceNames()
        {
            // Snippet: ListSources(LocationName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSourcesResponse, Source> response = vmMigrationClient.ListSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Source item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSourcesAsync</summary>
        public async Task ListSourcesResourceNamesAsync()
        {
            // Snippet: ListSourcesAsync(LocationName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSourcesResponse, Source> response = vmMigrationClient.ListSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Source item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSource</summary>
        public void GetSourceRequestObject()
        {
            // Snippet: GetSource(GetSourceRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            // Make the request
            Source response = vmMigrationClient.GetSource(request);
            // End snippet
        }

        /// <summary>Snippet for GetSourceAsync</summary>
        public async Task GetSourceRequestObjectAsync()
        {
            // Snippet: GetSourceAsync(GetSourceRequest, CallSettings)
            // Additional: GetSourceAsync(GetSourceRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            // Make the request
            Source response = await vmMigrationClient.GetSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSource</summary>
        public void GetSource()
        {
            // Snippet: GetSource(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            Source response = vmMigrationClient.GetSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetSourceAsync</summary>
        public async Task GetSourceAsync()
        {
            // Snippet: GetSourceAsync(string, CallSettings)
            // Additional: GetSourceAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            Source response = await vmMigrationClient.GetSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSource</summary>
        public void GetSourceResourceNames()
        {
            // Snippet: GetSource(SourceName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            SourceName name = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            Source response = vmMigrationClient.GetSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetSourceAsync</summary>
        public async Task GetSourceResourceNamesAsync()
        {
            // Snippet: GetSourceAsync(SourceName, CallSettings)
            // Additional: GetSourceAsync(SourceName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            SourceName name = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            Source response = await vmMigrationClient.GetSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSource</summary>
        public void CreateSourceRequestObject()
        {
            // Snippet: CreateSource(CreateSourceRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SourceId = "",
                Source = new Source(),
                RequestId = "",
            };
            // Make the request
            Operation<Source, OperationMetadata> response = vmMigrationClient.CreateSource(request);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSourceAsync</summary>
        public async Task CreateSourceRequestObjectAsync()
        {
            // Snippet: CreateSourceAsync(CreateSourceRequest, CallSettings)
            // Additional: CreateSourceAsync(CreateSourceRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SourceId = "",
                Source = new Source(),
                RequestId = "",
            };
            // Make the request
            Operation<Source, OperationMetadata> response = await vmMigrationClient.CreateSourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSource</summary>
        public void CreateSource()
        {
            // Snippet: CreateSource(string, Source, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Source source = new Source();
            string sourceId = "";
            // Make the request
            Operation<Source, OperationMetadata> response = vmMigrationClient.CreateSource(parent, source, sourceId);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSourceAsync</summary>
        public async Task CreateSourceAsync()
        {
            // Snippet: CreateSourceAsync(string, Source, string, CallSettings)
            // Additional: CreateSourceAsync(string, Source, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Source source = new Source();
            string sourceId = "";
            // Make the request
            Operation<Source, OperationMetadata> response = await vmMigrationClient.CreateSourceAsync(parent, source, sourceId);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSource</summary>
        public void CreateSourceResourceNames()
        {
            // Snippet: CreateSource(LocationName, Source, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Source source = new Source();
            string sourceId = "";
            // Make the request
            Operation<Source, OperationMetadata> response = vmMigrationClient.CreateSource(parent, source, sourceId);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSourceAsync</summary>
        public async Task CreateSourceResourceNamesAsync()
        {
            // Snippet: CreateSourceAsync(LocationName, Source, string, CallSettings)
            // Additional: CreateSourceAsync(LocationName, Source, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Source source = new Source();
            string sourceId = "";
            // Make the request
            Operation<Source, OperationMetadata> response = await vmMigrationClient.CreateSourceAsync(parent, source, sourceId);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSource</summary>
        public void UpdateSourceRequestObject()
        {
            // Snippet: UpdateSource(UpdateSourceRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            UpdateSourceRequest request = new UpdateSourceRequest
            {
                UpdateMask = new FieldMask(),
                Source = new Source(),
                RequestId = "",
            };
            // Make the request
            Operation<Source, OperationMetadata> response = vmMigrationClient.UpdateSource(request);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceUpdateSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSourceAsync</summary>
        public async Task UpdateSourceRequestObjectAsync()
        {
            // Snippet: UpdateSourceAsync(UpdateSourceRequest, CallSettings)
            // Additional: UpdateSourceAsync(UpdateSourceRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSourceRequest request = new UpdateSourceRequest
            {
                UpdateMask = new FieldMask(),
                Source = new Source(),
                RequestId = "",
            };
            // Make the request
            Operation<Source, OperationMetadata> response = await vmMigrationClient.UpdateSourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceUpdateSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSource</summary>
        public void UpdateSource()
        {
            // Snippet: UpdateSource(Source, FieldMask, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            Source source = new Source();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Source, OperationMetadata> response = vmMigrationClient.UpdateSource(source, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceUpdateSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSourceAsync</summary>
        public async Task UpdateSourceAsync()
        {
            // Snippet: UpdateSourceAsync(Source, FieldMask, CallSettings)
            // Additional: UpdateSourceAsync(Source, FieldMask, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            Source source = new Source();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Source, OperationMetadata> response = await vmMigrationClient.UpdateSourceAsync(source, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceUpdateSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSource</summary>
        public void DeleteSourceRequestObject()
        {
            // Snippet: DeleteSource(DeleteSourceRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            DeleteSourceRequest request = new DeleteSourceRequest
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteSource(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSourceAsync</summary>
        public async Task DeleteSourceRequestObjectAsync()
        {
            // Snippet: DeleteSourceAsync(DeleteSourceRequest, CallSettings)
            // Additional: DeleteSourceAsync(DeleteSourceRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSourceRequest request = new DeleteSourceRequest
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteSourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSource</summary>
        public void DeleteSource()
        {
            // Snippet: DeleteSource(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteSource(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSourceAsync</summary>
        public async Task DeleteSourceAsync()
        {
            // Snippet: DeleteSourceAsync(string, CallSettings)
            // Additional: DeleteSourceAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteSourceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSource</summary>
        public void DeleteSourceResourceNames()
        {
            // Snippet: DeleteSource(SourceName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            SourceName name = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteSource(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSourceAsync</summary>
        public async Task DeleteSourceResourceNamesAsync()
        {
            // Snippet: DeleteSourceAsync(SourceName, CallSettings)
            // Additional: DeleteSourceAsync(SourceName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            SourceName name = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteSourceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchInventory</summary>
        public void FetchInventoryRequestObject()
        {
            // Snippet: FetchInventory(FetchInventoryRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            FetchInventoryRequest request = new FetchInventoryRequest
            {
                SourceAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                ForceRefresh = false,
            };
            // Make the request
            FetchInventoryResponse response = vmMigrationClient.FetchInventory(request);
            // End snippet
        }

        /// <summary>Snippet for FetchInventoryAsync</summary>
        public async Task FetchInventoryRequestObjectAsync()
        {
            // Snippet: FetchInventoryAsync(FetchInventoryRequest, CallSettings)
            // Additional: FetchInventoryAsync(FetchInventoryRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            FetchInventoryRequest request = new FetchInventoryRequest
            {
                SourceAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                ForceRefresh = false,
            };
            // Make the request
            FetchInventoryResponse response = await vmMigrationClient.FetchInventoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchInventory</summary>
        public void FetchInventory()
        {
            // Snippet: FetchInventory(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string source = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            FetchInventoryResponse response = vmMigrationClient.FetchInventory(source);
            // End snippet
        }

        /// <summary>Snippet for FetchInventoryAsync</summary>
        public async Task FetchInventoryAsync()
        {
            // Snippet: FetchInventoryAsync(string, CallSettings)
            // Additional: FetchInventoryAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string source = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            FetchInventoryResponse response = await vmMigrationClient.FetchInventoryAsync(source);
            // End snippet
        }

        /// <summary>Snippet for FetchInventory</summary>
        public void FetchInventoryResourceNames()
        {
            // Snippet: FetchInventory(SourceName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            SourceName source = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            FetchInventoryResponse response = vmMigrationClient.FetchInventory(source);
            // End snippet
        }

        /// <summary>Snippet for FetchInventoryAsync</summary>
        public async Task FetchInventoryResourceNamesAsync()
        {
            // Snippet: FetchInventoryAsync(SourceName, CallSettings)
            // Additional: FetchInventoryAsync(SourceName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            SourceName source = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            FetchInventoryResponse response = await vmMigrationClient.FetchInventoryAsync(source);
            // End snippet
        }

        /// <summary>Snippet for ListUtilizationReports</summary>
        public void ListUtilizationReportsRequestObject()
        {
            // Snippet: ListUtilizationReports(ListUtilizationReportsRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            ListUtilizationReportsRequest request = new ListUtilizationReportsRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                View = UtilizationReportView.Unspecified,
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListUtilizationReportsResponse, UtilizationReport> response = vmMigrationClient.ListUtilizationReports(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UtilizationReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUtilizationReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UtilizationReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UtilizationReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UtilizationReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUtilizationReportsAsync</summary>
        public async Task ListUtilizationReportsRequestObjectAsync()
        {
            // Snippet: ListUtilizationReportsAsync(ListUtilizationReportsRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            ListUtilizationReportsRequest request = new ListUtilizationReportsRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                View = UtilizationReportView.Unspecified,
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUtilizationReportsResponse, UtilizationReport> response = vmMigrationClient.ListUtilizationReportsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UtilizationReport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUtilizationReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UtilizationReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UtilizationReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UtilizationReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUtilizationReports</summary>
        public void ListUtilizationReports()
        {
            // Snippet: ListUtilizationReports(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            PagedEnumerable<ListUtilizationReportsResponse, UtilizationReport> response = vmMigrationClient.ListUtilizationReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UtilizationReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUtilizationReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UtilizationReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UtilizationReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UtilizationReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUtilizationReportsAsync</summary>
        public async Task ListUtilizationReportsAsync()
        {
            // Snippet: ListUtilizationReportsAsync(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            PagedAsyncEnumerable<ListUtilizationReportsResponse, UtilizationReport> response = vmMigrationClient.ListUtilizationReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UtilizationReport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUtilizationReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UtilizationReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UtilizationReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UtilizationReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUtilizationReports</summary>
        public void ListUtilizationReportsResourceNames()
        {
            // Snippet: ListUtilizationReports(SourceName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            PagedEnumerable<ListUtilizationReportsResponse, UtilizationReport> response = vmMigrationClient.ListUtilizationReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UtilizationReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUtilizationReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UtilizationReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UtilizationReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UtilizationReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUtilizationReportsAsync</summary>
        public async Task ListUtilizationReportsResourceNamesAsync()
        {
            // Snippet: ListUtilizationReportsAsync(SourceName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            PagedAsyncEnumerable<ListUtilizationReportsResponse, UtilizationReport> response = vmMigrationClient.ListUtilizationReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UtilizationReport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUtilizationReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UtilizationReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UtilizationReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UtilizationReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetUtilizationReport</summary>
        public void GetUtilizationReportRequestObject()
        {
            // Snippet: GetUtilizationReport(GetUtilizationReportRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            GetUtilizationReportRequest request = new GetUtilizationReportRequest
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
                View = UtilizationReportView.Unspecified,
            };
            // Make the request
            UtilizationReport response = vmMigrationClient.GetUtilizationReport(request);
            // End snippet
        }

        /// <summary>Snippet for GetUtilizationReportAsync</summary>
        public async Task GetUtilizationReportRequestObjectAsync()
        {
            // Snippet: GetUtilizationReportAsync(GetUtilizationReportRequest, CallSettings)
            // Additional: GetUtilizationReportAsync(GetUtilizationReportRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            GetUtilizationReportRequest request = new GetUtilizationReportRequest
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
                View = UtilizationReportView.Unspecified,
            };
            // Make the request
            UtilizationReport response = await vmMigrationClient.GetUtilizationReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUtilizationReport</summary>
        public void GetUtilizationReport()
        {
            // Snippet: GetUtilizationReport(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/utilizationReports/[UTILIZATION_REPORT]";
            // Make the request
            UtilizationReport response = vmMigrationClient.GetUtilizationReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetUtilizationReportAsync</summary>
        public async Task GetUtilizationReportAsync()
        {
            // Snippet: GetUtilizationReportAsync(string, CallSettings)
            // Additional: GetUtilizationReportAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/utilizationReports/[UTILIZATION_REPORT]";
            // Make the request
            UtilizationReport response = await vmMigrationClient.GetUtilizationReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUtilizationReport</summary>
        public void GetUtilizationReportResourceNames()
        {
            // Snippet: GetUtilizationReport(UtilizationReportName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            UtilizationReportName name = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]");
            // Make the request
            UtilizationReport response = vmMigrationClient.GetUtilizationReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetUtilizationReportAsync</summary>
        public async Task GetUtilizationReportResourceNamesAsync()
        {
            // Snippet: GetUtilizationReportAsync(UtilizationReportName, CallSettings)
            // Additional: GetUtilizationReportAsync(UtilizationReportName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            UtilizationReportName name = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]");
            // Make the request
            UtilizationReport response = await vmMigrationClient.GetUtilizationReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateUtilizationReport</summary>
        public void CreateUtilizationReportRequestObject()
        {
            // Snippet: CreateUtilizationReport(CreateUtilizationReportRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CreateUtilizationReportRequest request = new CreateUtilizationReportRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                UtilizationReport = new UtilizationReport(),
                UtilizationReportId = "",
                RequestId = "",
            };
            // Make the request
            Operation<UtilizationReport, OperationMetadata> response = vmMigrationClient.CreateUtilizationReport(request);

            // Poll until the returned long-running operation is complete
            Operation<UtilizationReport, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UtilizationReport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UtilizationReport, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateUtilizationReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UtilizationReport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUtilizationReportAsync</summary>
        public async Task CreateUtilizationReportRequestObjectAsync()
        {
            // Snippet: CreateUtilizationReportAsync(CreateUtilizationReportRequest, CallSettings)
            // Additional: CreateUtilizationReportAsync(CreateUtilizationReportRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            CreateUtilizationReportRequest request = new CreateUtilizationReportRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                UtilizationReport = new UtilizationReport(),
                UtilizationReportId = "",
                RequestId = "",
            };
            // Make the request
            Operation<UtilizationReport, OperationMetadata> response = await vmMigrationClient.CreateUtilizationReportAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UtilizationReport, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UtilizationReport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UtilizationReport, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateUtilizationReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UtilizationReport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUtilizationReport</summary>
        public void CreateUtilizationReport()
        {
            // Snippet: CreateUtilizationReport(string, UtilizationReport, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            UtilizationReport utilizationReport = new UtilizationReport();
            string utilizationReportId = "";
            // Make the request
            Operation<UtilizationReport, OperationMetadata> response = vmMigrationClient.CreateUtilizationReport(parent, utilizationReport, utilizationReportId);

            // Poll until the returned long-running operation is complete
            Operation<UtilizationReport, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UtilizationReport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UtilizationReport, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateUtilizationReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UtilizationReport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUtilizationReportAsync</summary>
        public async Task CreateUtilizationReportAsync()
        {
            // Snippet: CreateUtilizationReportAsync(string, UtilizationReport, string, CallSettings)
            // Additional: CreateUtilizationReportAsync(string, UtilizationReport, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            UtilizationReport utilizationReport = new UtilizationReport();
            string utilizationReportId = "";
            // Make the request
            Operation<UtilizationReport, OperationMetadata> response = await vmMigrationClient.CreateUtilizationReportAsync(parent, utilizationReport, utilizationReportId);

            // Poll until the returned long-running operation is complete
            Operation<UtilizationReport, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UtilizationReport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UtilizationReport, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateUtilizationReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UtilizationReport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUtilizationReport</summary>
        public void CreateUtilizationReportResourceNames()
        {
            // Snippet: CreateUtilizationReport(SourceName, UtilizationReport, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            UtilizationReport utilizationReport = new UtilizationReport();
            string utilizationReportId = "";
            // Make the request
            Operation<UtilizationReport, OperationMetadata> response = vmMigrationClient.CreateUtilizationReport(parent, utilizationReport, utilizationReportId);

            // Poll until the returned long-running operation is complete
            Operation<UtilizationReport, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UtilizationReport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UtilizationReport, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateUtilizationReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UtilizationReport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUtilizationReportAsync</summary>
        public async Task CreateUtilizationReportResourceNamesAsync()
        {
            // Snippet: CreateUtilizationReportAsync(SourceName, UtilizationReport, string, CallSettings)
            // Additional: CreateUtilizationReportAsync(SourceName, UtilizationReport, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            UtilizationReport utilizationReport = new UtilizationReport();
            string utilizationReportId = "";
            // Make the request
            Operation<UtilizationReport, OperationMetadata> response = await vmMigrationClient.CreateUtilizationReportAsync(parent, utilizationReport, utilizationReportId);

            // Poll until the returned long-running operation is complete
            Operation<UtilizationReport, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UtilizationReport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UtilizationReport, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateUtilizationReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UtilizationReport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUtilizationReport</summary>
        public void DeleteUtilizationReportRequestObject()
        {
            // Snippet: DeleteUtilizationReport(DeleteUtilizationReportRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            DeleteUtilizationReportRequest request = new DeleteUtilizationReportRequest
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteUtilizationReport(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteUtilizationReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUtilizationReportAsync</summary>
        public async Task DeleteUtilizationReportRequestObjectAsync()
        {
            // Snippet: DeleteUtilizationReportAsync(DeleteUtilizationReportRequest, CallSettings)
            // Additional: DeleteUtilizationReportAsync(DeleteUtilizationReportRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUtilizationReportRequest request = new DeleteUtilizationReportRequest
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteUtilizationReportAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteUtilizationReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUtilizationReport</summary>
        public void DeleteUtilizationReport()
        {
            // Snippet: DeleteUtilizationReport(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/utilizationReports/[UTILIZATION_REPORT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteUtilizationReport(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteUtilizationReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUtilizationReportAsync</summary>
        public async Task DeleteUtilizationReportAsync()
        {
            // Snippet: DeleteUtilizationReportAsync(string, CallSettings)
            // Additional: DeleteUtilizationReportAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/utilizationReports/[UTILIZATION_REPORT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteUtilizationReportAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteUtilizationReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUtilizationReport</summary>
        public void DeleteUtilizationReportResourceNames()
        {
            // Snippet: DeleteUtilizationReport(UtilizationReportName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            UtilizationReportName name = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteUtilizationReport(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteUtilizationReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUtilizationReportAsync</summary>
        public async Task DeleteUtilizationReportResourceNamesAsync()
        {
            // Snippet: DeleteUtilizationReportAsync(UtilizationReportName, CallSettings)
            // Additional: DeleteUtilizationReportAsync(UtilizationReportName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            UtilizationReportName name = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteUtilizationReportAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteUtilizationReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDatacenterConnectors</summary>
        public void ListDatacenterConnectorsRequestObject()
        {
            // Snippet: ListDatacenterConnectors(ListDatacenterConnectorsRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            ListDatacenterConnectorsRequest request = new ListDatacenterConnectorsRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDatacenterConnectorsResponse, DatacenterConnector> response = vmMigrationClient.ListDatacenterConnectors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DatacenterConnector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatacenterConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatacenterConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatacenterConnector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatacenterConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatacenterConnectorsAsync</summary>
        public async Task ListDatacenterConnectorsRequestObjectAsync()
        {
            // Snippet: ListDatacenterConnectorsAsync(ListDatacenterConnectorsRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            ListDatacenterConnectorsRequest request = new ListDatacenterConnectorsRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDatacenterConnectorsResponse, DatacenterConnector> response = vmMigrationClient.ListDatacenterConnectorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DatacenterConnector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatacenterConnectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatacenterConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatacenterConnector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatacenterConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatacenterConnectors</summary>
        public void ListDatacenterConnectors()
        {
            // Snippet: ListDatacenterConnectors(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            PagedEnumerable<ListDatacenterConnectorsResponse, DatacenterConnector> response = vmMigrationClient.ListDatacenterConnectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DatacenterConnector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatacenterConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatacenterConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatacenterConnector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatacenterConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatacenterConnectorsAsync</summary>
        public async Task ListDatacenterConnectorsAsync()
        {
            // Snippet: ListDatacenterConnectorsAsync(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            PagedAsyncEnumerable<ListDatacenterConnectorsResponse, DatacenterConnector> response = vmMigrationClient.ListDatacenterConnectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DatacenterConnector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatacenterConnectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatacenterConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatacenterConnector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatacenterConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatacenterConnectors</summary>
        public void ListDatacenterConnectorsResourceNames()
        {
            // Snippet: ListDatacenterConnectors(SourceName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            PagedEnumerable<ListDatacenterConnectorsResponse, DatacenterConnector> response = vmMigrationClient.ListDatacenterConnectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DatacenterConnector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatacenterConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatacenterConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatacenterConnector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatacenterConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatacenterConnectorsAsync</summary>
        public async Task ListDatacenterConnectorsResourceNamesAsync()
        {
            // Snippet: ListDatacenterConnectorsAsync(SourceName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            PagedAsyncEnumerable<ListDatacenterConnectorsResponse, DatacenterConnector> response = vmMigrationClient.ListDatacenterConnectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DatacenterConnector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatacenterConnectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatacenterConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatacenterConnector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatacenterConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDatacenterConnector</summary>
        public void GetDatacenterConnectorRequestObject()
        {
            // Snippet: GetDatacenterConnector(GetDatacenterConnectorRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            GetDatacenterConnectorRequest request = new GetDatacenterConnectorRequest
            {
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
            };
            // Make the request
            DatacenterConnector response = vmMigrationClient.GetDatacenterConnector(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatacenterConnectorAsync</summary>
        public async Task GetDatacenterConnectorRequestObjectAsync()
        {
            // Snippet: GetDatacenterConnectorAsync(GetDatacenterConnectorRequest, CallSettings)
            // Additional: GetDatacenterConnectorAsync(GetDatacenterConnectorRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            GetDatacenterConnectorRequest request = new GetDatacenterConnectorRequest
            {
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
            };
            // Make the request
            DatacenterConnector response = await vmMigrationClient.GetDatacenterConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatacenterConnector</summary>
        public void GetDatacenterConnector()
        {
            // Snippet: GetDatacenterConnector(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/datacenterConnectors/[DATACENTER_CONNECTOR]";
            // Make the request
            DatacenterConnector response = vmMigrationClient.GetDatacenterConnector(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatacenterConnectorAsync</summary>
        public async Task GetDatacenterConnectorAsync()
        {
            // Snippet: GetDatacenterConnectorAsync(string, CallSettings)
            // Additional: GetDatacenterConnectorAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/datacenterConnectors/[DATACENTER_CONNECTOR]";
            // Make the request
            DatacenterConnector response = await vmMigrationClient.GetDatacenterConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatacenterConnector</summary>
        public void GetDatacenterConnectorResourceNames()
        {
            // Snippet: GetDatacenterConnector(DatacenterConnectorName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            DatacenterConnectorName name = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]");
            // Make the request
            DatacenterConnector response = vmMigrationClient.GetDatacenterConnector(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatacenterConnectorAsync</summary>
        public async Task GetDatacenterConnectorResourceNamesAsync()
        {
            // Snippet: GetDatacenterConnectorAsync(DatacenterConnectorName, CallSettings)
            // Additional: GetDatacenterConnectorAsync(DatacenterConnectorName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            DatacenterConnectorName name = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]");
            // Make the request
            DatacenterConnector response = await vmMigrationClient.GetDatacenterConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDatacenterConnector</summary>
        public void CreateDatacenterConnectorRequestObject()
        {
            // Snippet: CreateDatacenterConnector(CreateDatacenterConnectorRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CreateDatacenterConnectorRequest request = new CreateDatacenterConnectorRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                DatacenterConnectorId = "",
                DatacenterConnector = new DatacenterConnector(),
                RequestId = "",
            };
            // Make the request
            Operation<DatacenterConnector, OperationMetadata> response = vmMigrationClient.CreateDatacenterConnector(request);

            // Poll until the returned long-running operation is complete
            Operation<DatacenterConnector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DatacenterConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatacenterConnector, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateDatacenterConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatacenterConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatacenterConnectorAsync</summary>
        public async Task CreateDatacenterConnectorRequestObjectAsync()
        {
            // Snippet: CreateDatacenterConnectorAsync(CreateDatacenterConnectorRequest, CallSettings)
            // Additional: CreateDatacenterConnectorAsync(CreateDatacenterConnectorRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatacenterConnectorRequest request = new CreateDatacenterConnectorRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                DatacenterConnectorId = "",
                DatacenterConnector = new DatacenterConnector(),
                RequestId = "",
            };
            // Make the request
            Operation<DatacenterConnector, OperationMetadata> response = await vmMigrationClient.CreateDatacenterConnectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DatacenterConnector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DatacenterConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatacenterConnector, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateDatacenterConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatacenterConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatacenterConnector</summary>
        public void CreateDatacenterConnector()
        {
            // Snippet: CreateDatacenterConnector(string, DatacenterConnector, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            DatacenterConnector datacenterConnector = new DatacenterConnector();
            string datacenterConnectorId = "";
            // Make the request
            Operation<DatacenterConnector, OperationMetadata> response = vmMigrationClient.CreateDatacenterConnector(parent, datacenterConnector, datacenterConnectorId);

            // Poll until the returned long-running operation is complete
            Operation<DatacenterConnector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DatacenterConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatacenterConnector, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateDatacenterConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatacenterConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatacenterConnectorAsync</summary>
        public async Task CreateDatacenterConnectorAsync()
        {
            // Snippet: CreateDatacenterConnectorAsync(string, DatacenterConnector, string, CallSettings)
            // Additional: CreateDatacenterConnectorAsync(string, DatacenterConnector, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            DatacenterConnector datacenterConnector = new DatacenterConnector();
            string datacenterConnectorId = "";
            // Make the request
            Operation<DatacenterConnector, OperationMetadata> response = await vmMigrationClient.CreateDatacenterConnectorAsync(parent, datacenterConnector, datacenterConnectorId);

            // Poll until the returned long-running operation is complete
            Operation<DatacenterConnector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DatacenterConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatacenterConnector, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateDatacenterConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatacenterConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatacenterConnector</summary>
        public void CreateDatacenterConnectorResourceNames()
        {
            // Snippet: CreateDatacenterConnector(SourceName, DatacenterConnector, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            DatacenterConnector datacenterConnector = new DatacenterConnector();
            string datacenterConnectorId = "";
            // Make the request
            Operation<DatacenterConnector, OperationMetadata> response = vmMigrationClient.CreateDatacenterConnector(parent, datacenterConnector, datacenterConnectorId);

            // Poll until the returned long-running operation is complete
            Operation<DatacenterConnector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DatacenterConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatacenterConnector, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateDatacenterConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatacenterConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatacenterConnectorAsync</summary>
        public async Task CreateDatacenterConnectorResourceNamesAsync()
        {
            // Snippet: CreateDatacenterConnectorAsync(SourceName, DatacenterConnector, string, CallSettings)
            // Additional: CreateDatacenterConnectorAsync(SourceName, DatacenterConnector, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            DatacenterConnector datacenterConnector = new DatacenterConnector();
            string datacenterConnectorId = "";
            // Make the request
            Operation<DatacenterConnector, OperationMetadata> response = await vmMigrationClient.CreateDatacenterConnectorAsync(parent, datacenterConnector, datacenterConnectorId);

            // Poll until the returned long-running operation is complete
            Operation<DatacenterConnector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DatacenterConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatacenterConnector, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateDatacenterConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatacenterConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatacenterConnector</summary>
        public void DeleteDatacenterConnectorRequestObject()
        {
            // Snippet: DeleteDatacenterConnector(DeleteDatacenterConnectorRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            DeleteDatacenterConnectorRequest request = new DeleteDatacenterConnectorRequest
            {
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteDatacenterConnector(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteDatacenterConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatacenterConnectorAsync</summary>
        public async Task DeleteDatacenterConnectorRequestObjectAsync()
        {
            // Snippet: DeleteDatacenterConnectorAsync(DeleteDatacenterConnectorRequest, CallSettings)
            // Additional: DeleteDatacenterConnectorAsync(DeleteDatacenterConnectorRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDatacenterConnectorRequest request = new DeleteDatacenterConnectorRequest
            {
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteDatacenterConnectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteDatacenterConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatacenterConnector</summary>
        public void DeleteDatacenterConnector()
        {
            // Snippet: DeleteDatacenterConnector(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/datacenterConnectors/[DATACENTER_CONNECTOR]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteDatacenterConnector(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteDatacenterConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatacenterConnectorAsync</summary>
        public async Task DeleteDatacenterConnectorAsync()
        {
            // Snippet: DeleteDatacenterConnectorAsync(string, CallSettings)
            // Additional: DeleteDatacenterConnectorAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/datacenterConnectors/[DATACENTER_CONNECTOR]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteDatacenterConnectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteDatacenterConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatacenterConnector</summary>
        public void DeleteDatacenterConnectorResourceNames()
        {
            // Snippet: DeleteDatacenterConnector(DatacenterConnectorName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            DatacenterConnectorName name = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteDatacenterConnector(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteDatacenterConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatacenterConnectorAsync</summary>
        public async Task DeleteDatacenterConnectorResourceNamesAsync()
        {
            // Snippet: DeleteDatacenterConnectorAsync(DatacenterConnectorName, CallSettings)
            // Additional: DeleteDatacenterConnectorAsync(DatacenterConnectorName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            DatacenterConnectorName name = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteDatacenterConnectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteDatacenterConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeAppliance</summary>
        public void UpgradeApplianceRequestObject()
        {
            // Snippet: UpgradeAppliance(UpgradeApplianceRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            UpgradeApplianceRequest request = new UpgradeApplianceRequest
            {
                DatacenterConnectorAsDatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<UpgradeApplianceResponse, OperationMetadata> response = vmMigrationClient.UpgradeAppliance(request);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeApplianceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UpgradeApplianceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeApplianceResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceUpgradeAppliance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeApplianceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeApplianceAsync</summary>
        public async Task UpgradeApplianceRequestObjectAsync()
        {
            // Snippet: UpgradeApplianceAsync(UpgradeApplianceRequest, CallSettings)
            // Additional: UpgradeApplianceAsync(UpgradeApplianceRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            UpgradeApplianceRequest request = new UpgradeApplianceRequest
            {
                DatacenterConnectorAsDatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<UpgradeApplianceResponse, OperationMetadata> response = await vmMigrationClient.UpgradeApplianceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeApplianceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UpgradeApplianceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeApplianceResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceUpgradeApplianceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeApplianceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMigratingVm</summary>
        public void CreateMigratingVmRequestObject()
        {
            // Snippet: CreateMigratingVm(CreateMigratingVmRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CreateMigratingVmRequest request = new CreateMigratingVmRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                MigratingVmId = "",
                MigratingVm = new MigratingVm(),
                RequestId = "",
            };
            // Make the request
            Operation<MigratingVm, OperationMetadata> response = vmMigrationClient.CreateMigratingVm(request);

            // Poll until the returned long-running operation is complete
            Operation<MigratingVm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigratingVm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigratingVm, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateMigratingVm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigratingVm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMigratingVmAsync</summary>
        public async Task CreateMigratingVmRequestObjectAsync()
        {
            // Snippet: CreateMigratingVmAsync(CreateMigratingVmRequest, CallSettings)
            // Additional: CreateMigratingVmAsync(CreateMigratingVmRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            CreateMigratingVmRequest request = new CreateMigratingVmRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                MigratingVmId = "",
                MigratingVm = new MigratingVm(),
                RequestId = "",
            };
            // Make the request
            Operation<MigratingVm, OperationMetadata> response = await vmMigrationClient.CreateMigratingVmAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MigratingVm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigratingVm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigratingVm, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateMigratingVmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigratingVm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMigratingVm</summary>
        public void CreateMigratingVm()
        {
            // Snippet: CreateMigratingVm(string, MigratingVm, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            MigratingVm migratingVm = new MigratingVm();
            string migratingVmId = "";
            // Make the request
            Operation<MigratingVm, OperationMetadata> response = vmMigrationClient.CreateMigratingVm(parent, migratingVm, migratingVmId);

            // Poll until the returned long-running operation is complete
            Operation<MigratingVm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigratingVm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigratingVm, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateMigratingVm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigratingVm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMigratingVmAsync</summary>
        public async Task CreateMigratingVmAsync()
        {
            // Snippet: CreateMigratingVmAsync(string, MigratingVm, string, CallSettings)
            // Additional: CreateMigratingVmAsync(string, MigratingVm, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            MigratingVm migratingVm = new MigratingVm();
            string migratingVmId = "";
            // Make the request
            Operation<MigratingVm, OperationMetadata> response = await vmMigrationClient.CreateMigratingVmAsync(parent, migratingVm, migratingVmId);

            // Poll until the returned long-running operation is complete
            Operation<MigratingVm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigratingVm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigratingVm, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateMigratingVmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigratingVm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMigratingVm</summary>
        public void CreateMigratingVmResourceNames()
        {
            // Snippet: CreateMigratingVm(SourceName, MigratingVm, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            MigratingVm migratingVm = new MigratingVm();
            string migratingVmId = "";
            // Make the request
            Operation<MigratingVm, OperationMetadata> response = vmMigrationClient.CreateMigratingVm(parent, migratingVm, migratingVmId);

            // Poll until the returned long-running operation is complete
            Operation<MigratingVm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigratingVm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigratingVm, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateMigratingVm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigratingVm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMigratingVmAsync</summary>
        public async Task CreateMigratingVmResourceNamesAsync()
        {
            // Snippet: CreateMigratingVmAsync(SourceName, MigratingVm, string, CallSettings)
            // Additional: CreateMigratingVmAsync(SourceName, MigratingVm, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            MigratingVm migratingVm = new MigratingVm();
            string migratingVmId = "";
            // Make the request
            Operation<MigratingVm, OperationMetadata> response = await vmMigrationClient.CreateMigratingVmAsync(parent, migratingVm, migratingVmId);

            // Poll until the returned long-running operation is complete
            Operation<MigratingVm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigratingVm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigratingVm, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateMigratingVmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigratingVm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListMigratingVms</summary>
        public void ListMigratingVmsRequestObject()
        {
            // Snippet: ListMigratingVms(ListMigratingVmsRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            ListMigratingVmsRequest request = new ListMigratingVmsRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                Filter = "",
                OrderBy = "",
                View = MigratingVmView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListMigratingVmsResponse, MigratingVm> response = vmMigrationClient.ListMigratingVms(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigratingVm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMigratingVmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigratingVm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigratingVm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigratingVm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigratingVmsAsync</summary>
        public async Task ListMigratingVmsRequestObjectAsync()
        {
            // Snippet: ListMigratingVmsAsync(ListMigratingVmsRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            ListMigratingVmsRequest request = new ListMigratingVmsRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                Filter = "",
                OrderBy = "",
                View = MigratingVmView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListMigratingVmsResponse, MigratingVm> response = vmMigrationClient.ListMigratingVmsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigratingVm item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMigratingVmsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigratingVm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigratingVm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigratingVm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigratingVms</summary>
        public void ListMigratingVms()
        {
            // Snippet: ListMigratingVms(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            PagedEnumerable<ListMigratingVmsResponse, MigratingVm> response = vmMigrationClient.ListMigratingVms(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigratingVm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMigratingVmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigratingVm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigratingVm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigratingVm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigratingVmsAsync</summary>
        public async Task ListMigratingVmsAsync()
        {
            // Snippet: ListMigratingVmsAsync(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            PagedAsyncEnumerable<ListMigratingVmsResponse, MigratingVm> response = vmMigrationClient.ListMigratingVmsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigratingVm item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMigratingVmsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigratingVm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigratingVm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigratingVm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigratingVms</summary>
        public void ListMigratingVmsResourceNames()
        {
            // Snippet: ListMigratingVms(SourceName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            PagedEnumerable<ListMigratingVmsResponse, MigratingVm> response = vmMigrationClient.ListMigratingVms(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigratingVm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMigratingVmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigratingVm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigratingVm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigratingVm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigratingVmsAsync</summary>
        public async Task ListMigratingVmsResourceNamesAsync()
        {
            // Snippet: ListMigratingVmsAsync(SourceName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            PagedAsyncEnumerable<ListMigratingVmsResponse, MigratingVm> response = vmMigrationClient.ListMigratingVmsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigratingVm item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMigratingVmsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigratingVm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigratingVm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigratingVm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMigratingVm</summary>
        public void GetMigratingVmRequestObject()
        {
            // Snippet: GetMigratingVm(GetMigratingVmRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            GetMigratingVmRequest request = new GetMigratingVmRequest
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                View = MigratingVmView.Unspecified,
            };
            // Make the request
            MigratingVm response = vmMigrationClient.GetMigratingVm(request);
            // End snippet
        }

        /// <summary>Snippet for GetMigratingVmAsync</summary>
        public async Task GetMigratingVmRequestObjectAsync()
        {
            // Snippet: GetMigratingVmAsync(GetMigratingVmRequest, CallSettings)
            // Additional: GetMigratingVmAsync(GetMigratingVmRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            GetMigratingVmRequest request = new GetMigratingVmRequest
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                View = MigratingVmView.Unspecified,
            };
            // Make the request
            MigratingVm response = await vmMigrationClient.GetMigratingVmAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMigratingVm</summary>
        public void GetMigratingVm()
        {
            // Snippet: GetMigratingVm(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            MigratingVm response = vmMigrationClient.GetMigratingVm(name);
            // End snippet
        }

        /// <summary>Snippet for GetMigratingVmAsync</summary>
        public async Task GetMigratingVmAsync()
        {
            // Snippet: GetMigratingVmAsync(string, CallSettings)
            // Additional: GetMigratingVmAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            MigratingVm response = await vmMigrationClient.GetMigratingVmAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMigratingVm</summary>
        public void GetMigratingVmResourceNames()
        {
            // Snippet: GetMigratingVm(MigratingVmName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            MigratingVmName name = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            // Make the request
            MigratingVm response = vmMigrationClient.GetMigratingVm(name);
            // End snippet
        }

        /// <summary>Snippet for GetMigratingVmAsync</summary>
        public async Task GetMigratingVmResourceNamesAsync()
        {
            // Snippet: GetMigratingVmAsync(MigratingVmName, CallSettings)
            // Additional: GetMigratingVmAsync(MigratingVmName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            MigratingVmName name = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            // Make the request
            MigratingVm response = await vmMigrationClient.GetMigratingVmAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateMigratingVm</summary>
        public void UpdateMigratingVmRequestObject()
        {
            // Snippet: UpdateMigratingVm(UpdateMigratingVmRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            UpdateMigratingVmRequest request = new UpdateMigratingVmRequest
            {
                UpdateMask = new FieldMask(),
                MigratingVm = new MigratingVm(),
                RequestId = "",
            };
            // Make the request
            Operation<MigratingVm, OperationMetadata> response = vmMigrationClient.UpdateMigratingVm(request);

            // Poll until the returned long-running operation is complete
            Operation<MigratingVm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigratingVm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigratingVm, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceUpdateMigratingVm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigratingVm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMigratingVmAsync</summary>
        public async Task UpdateMigratingVmRequestObjectAsync()
        {
            // Snippet: UpdateMigratingVmAsync(UpdateMigratingVmRequest, CallSettings)
            // Additional: UpdateMigratingVmAsync(UpdateMigratingVmRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMigratingVmRequest request = new UpdateMigratingVmRequest
            {
                UpdateMask = new FieldMask(),
                MigratingVm = new MigratingVm(),
                RequestId = "",
            };
            // Make the request
            Operation<MigratingVm, OperationMetadata> response = await vmMigrationClient.UpdateMigratingVmAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MigratingVm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigratingVm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigratingVm, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceUpdateMigratingVmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigratingVm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMigratingVm</summary>
        public void UpdateMigratingVm()
        {
            // Snippet: UpdateMigratingVm(MigratingVm, FieldMask, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            MigratingVm migratingVm = new MigratingVm();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MigratingVm, OperationMetadata> response = vmMigrationClient.UpdateMigratingVm(migratingVm, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MigratingVm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigratingVm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigratingVm, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceUpdateMigratingVm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigratingVm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMigratingVmAsync</summary>
        public async Task UpdateMigratingVmAsync()
        {
            // Snippet: UpdateMigratingVmAsync(MigratingVm, FieldMask, CallSettings)
            // Additional: UpdateMigratingVmAsync(MigratingVm, FieldMask, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            MigratingVm migratingVm = new MigratingVm();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MigratingVm, OperationMetadata> response = await vmMigrationClient.UpdateMigratingVmAsync(migratingVm, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MigratingVm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigratingVm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigratingVm, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceUpdateMigratingVmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigratingVm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMigratingVm</summary>
        public void DeleteMigratingVmRequestObject()
        {
            // Snippet: DeleteMigratingVm(DeleteMigratingVmRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            DeleteMigratingVmRequest request = new DeleteMigratingVmRequest
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteMigratingVm(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteMigratingVm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMigratingVmAsync</summary>
        public async Task DeleteMigratingVmRequestObjectAsync()
        {
            // Snippet: DeleteMigratingVmAsync(DeleteMigratingVmRequest, CallSettings)
            // Additional: DeleteMigratingVmAsync(DeleteMigratingVmRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMigratingVmRequest request = new DeleteMigratingVmRequest
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteMigratingVmAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteMigratingVmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMigratingVm</summary>
        public void DeleteMigratingVm()
        {
            // Snippet: DeleteMigratingVm(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteMigratingVm(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteMigratingVm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMigratingVmAsync</summary>
        public async Task DeleteMigratingVmAsync()
        {
            // Snippet: DeleteMigratingVmAsync(string, CallSettings)
            // Additional: DeleteMigratingVmAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteMigratingVmAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteMigratingVmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMigratingVm</summary>
        public void DeleteMigratingVmResourceNames()
        {
            // Snippet: DeleteMigratingVm(MigratingVmName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            MigratingVmName name = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteMigratingVm(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteMigratingVm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMigratingVmAsync</summary>
        public async Task DeleteMigratingVmResourceNamesAsync()
        {
            // Snippet: DeleteMigratingVmAsync(MigratingVmName, CallSettings)
            // Additional: DeleteMigratingVmAsync(MigratingVmName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            MigratingVmName name = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteMigratingVmAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteMigratingVmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartMigration</summary>
        public void StartMigrationRequestObject()
        {
            // Snippet: StartMigration(StartMigrationRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            StartMigrationRequest request = new StartMigrationRequest
            {
                MigratingVmAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            // Make the request
            Operation<StartMigrationResponse, OperationMetadata> response = vmMigrationClient.StartMigration(request);

            // Poll until the returned long-running operation is complete
            Operation<StartMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StartMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceStartMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartMigrationAsync</summary>
        public async Task StartMigrationRequestObjectAsync()
        {
            // Snippet: StartMigrationAsync(StartMigrationRequest, CallSettings)
            // Additional: StartMigrationAsync(StartMigrationRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            StartMigrationRequest request = new StartMigrationRequest
            {
                MigratingVmAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            // Make the request
            Operation<StartMigrationResponse, OperationMetadata> response = await vmMigrationClient.StartMigrationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<StartMigrationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StartMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartMigrationResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceStartMigrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartMigration</summary>
        public void StartMigration()
        {
            // Snippet: StartMigration(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string migratingVm = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            Operation<StartMigrationResponse, OperationMetadata> response = vmMigrationClient.StartMigration(migratingVm);

            // Poll until the returned long-running operation is complete
            Operation<StartMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StartMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceStartMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartMigrationAsync</summary>
        public async Task StartMigrationAsync()
        {
            // Snippet: StartMigrationAsync(string, CallSettings)
            // Additional: StartMigrationAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string migratingVm = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            Operation<StartMigrationResponse, OperationMetadata> response = await vmMigrationClient.StartMigrationAsync(migratingVm);

            // Poll until the returned long-running operation is complete
            Operation<StartMigrationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StartMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartMigrationResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceStartMigrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartMigration</summary>
        public void StartMigrationResourceNames()
        {
            // Snippet: StartMigration(MigratingVmName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            MigratingVmName migratingVm = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            // Make the request
            Operation<StartMigrationResponse, OperationMetadata> response = vmMigrationClient.StartMigration(migratingVm);

            // Poll until the returned long-running operation is complete
            Operation<StartMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StartMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceStartMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartMigrationAsync</summary>
        public async Task StartMigrationResourceNamesAsync()
        {
            // Snippet: StartMigrationAsync(MigratingVmName, CallSettings)
            // Additional: StartMigrationAsync(MigratingVmName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            MigratingVmName migratingVm = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            // Make the request
            Operation<StartMigrationResponse, OperationMetadata> response = await vmMigrationClient.StartMigrationAsync(migratingVm);

            // Poll until the returned long-running operation is complete
            Operation<StartMigrationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StartMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartMigrationResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceStartMigrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeMigration</summary>
        public void ResumeMigrationRequestObject()
        {
            // Snippet: ResumeMigration(ResumeMigrationRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            ResumeMigrationRequest request = new ResumeMigrationRequest
            {
                MigratingVmAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            // Make the request
            Operation<ResumeMigrationResponse, OperationMetadata> response = vmMigrationClient.ResumeMigration(request);

            // Poll until the returned long-running operation is complete
            Operation<ResumeMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResumeMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResumeMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceResumeMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResumeMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeMigrationAsync</summary>
        public async Task ResumeMigrationRequestObjectAsync()
        {
            // Snippet: ResumeMigrationAsync(ResumeMigrationRequest, CallSettings)
            // Additional: ResumeMigrationAsync(ResumeMigrationRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            ResumeMigrationRequest request = new ResumeMigrationRequest
            {
                MigratingVmAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            // Make the request
            Operation<ResumeMigrationResponse, OperationMetadata> response = await vmMigrationClient.ResumeMigrationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ResumeMigrationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResumeMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResumeMigrationResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceResumeMigrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResumeMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PauseMigration</summary>
        public void PauseMigrationRequestObject()
        {
            // Snippet: PauseMigration(PauseMigrationRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            PauseMigrationRequest request = new PauseMigrationRequest
            {
                MigratingVmAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            // Make the request
            Operation<PauseMigrationResponse, OperationMetadata> response = vmMigrationClient.PauseMigration(request);

            // Poll until the returned long-running operation is complete
            Operation<PauseMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PauseMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PauseMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOncePauseMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PauseMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PauseMigrationAsync</summary>
        public async Task PauseMigrationRequestObjectAsync()
        {
            // Snippet: PauseMigrationAsync(PauseMigrationRequest, CallSettings)
            // Additional: PauseMigrationAsync(PauseMigrationRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            PauseMigrationRequest request = new PauseMigrationRequest
            {
                MigratingVmAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            // Make the request
            Operation<PauseMigrationResponse, OperationMetadata> response = await vmMigrationClient.PauseMigrationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PauseMigrationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PauseMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PauseMigrationResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOncePauseMigrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PauseMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FinalizeMigration</summary>
        public void FinalizeMigrationRequestObject()
        {
            // Snippet: FinalizeMigration(FinalizeMigrationRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            FinalizeMigrationRequest request = new FinalizeMigrationRequest
            {
                MigratingVmAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            // Make the request
            Operation<FinalizeMigrationResponse, OperationMetadata> response = vmMigrationClient.FinalizeMigration(request);

            // Poll until the returned long-running operation is complete
            Operation<FinalizeMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FinalizeMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FinalizeMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceFinalizeMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FinalizeMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FinalizeMigrationAsync</summary>
        public async Task FinalizeMigrationRequestObjectAsync()
        {
            // Snippet: FinalizeMigrationAsync(FinalizeMigrationRequest, CallSettings)
            // Additional: FinalizeMigrationAsync(FinalizeMigrationRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            FinalizeMigrationRequest request = new FinalizeMigrationRequest
            {
                MigratingVmAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            // Make the request
            Operation<FinalizeMigrationResponse, OperationMetadata> response = await vmMigrationClient.FinalizeMigrationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FinalizeMigrationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FinalizeMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FinalizeMigrationResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceFinalizeMigrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FinalizeMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FinalizeMigration</summary>
        public void FinalizeMigration()
        {
            // Snippet: FinalizeMigration(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string migratingVm = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            Operation<FinalizeMigrationResponse, OperationMetadata> response = vmMigrationClient.FinalizeMigration(migratingVm);

            // Poll until the returned long-running operation is complete
            Operation<FinalizeMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FinalizeMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FinalizeMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceFinalizeMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FinalizeMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FinalizeMigrationAsync</summary>
        public async Task FinalizeMigrationAsync()
        {
            // Snippet: FinalizeMigrationAsync(string, CallSettings)
            // Additional: FinalizeMigrationAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string migratingVm = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            Operation<FinalizeMigrationResponse, OperationMetadata> response = await vmMigrationClient.FinalizeMigrationAsync(migratingVm);

            // Poll until the returned long-running operation is complete
            Operation<FinalizeMigrationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FinalizeMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FinalizeMigrationResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceFinalizeMigrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FinalizeMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FinalizeMigration</summary>
        public void FinalizeMigrationResourceNames()
        {
            // Snippet: FinalizeMigration(MigratingVmName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            MigratingVmName migratingVm = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            // Make the request
            Operation<FinalizeMigrationResponse, OperationMetadata> response = vmMigrationClient.FinalizeMigration(migratingVm);

            // Poll until the returned long-running operation is complete
            Operation<FinalizeMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FinalizeMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FinalizeMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceFinalizeMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FinalizeMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FinalizeMigrationAsync</summary>
        public async Task FinalizeMigrationResourceNamesAsync()
        {
            // Snippet: FinalizeMigrationAsync(MigratingVmName, CallSettings)
            // Additional: FinalizeMigrationAsync(MigratingVmName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            MigratingVmName migratingVm = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            // Make the request
            Operation<FinalizeMigrationResponse, OperationMetadata> response = await vmMigrationClient.FinalizeMigrationAsync(migratingVm);

            // Poll until the returned long-running operation is complete
            Operation<FinalizeMigrationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FinalizeMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FinalizeMigrationResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceFinalizeMigrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FinalizeMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloneJob</summary>
        public void CreateCloneJobRequestObject()
        {
            // Snippet: CreateCloneJob(CreateCloneJobRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CreateCloneJobRequest request = new CreateCloneJobRequest
            {
                ParentAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                CloneJobId = "",
                CloneJob = new CloneJob(),
                RequestId = "",
            };
            // Make the request
            Operation<CloneJob, OperationMetadata> response = vmMigrationClient.CreateCloneJob(request);

            // Poll until the returned long-running operation is complete
            Operation<CloneJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CloneJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloneJob, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateCloneJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloneJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloneJobAsync</summary>
        public async Task CreateCloneJobRequestObjectAsync()
        {
            // Snippet: CreateCloneJobAsync(CreateCloneJobRequest, CallSettings)
            // Additional: CreateCloneJobAsync(CreateCloneJobRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            CreateCloneJobRequest request = new CreateCloneJobRequest
            {
                ParentAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                CloneJobId = "",
                CloneJob = new CloneJob(),
                RequestId = "",
            };
            // Make the request
            Operation<CloneJob, OperationMetadata> response = await vmMigrationClient.CreateCloneJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CloneJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CloneJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloneJob, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateCloneJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloneJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloneJob</summary>
        public void CreateCloneJob()
        {
            // Snippet: CreateCloneJob(string, CloneJob, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            CloneJob cloneJob = new CloneJob();
            string cloneJobId = "";
            // Make the request
            Operation<CloneJob, OperationMetadata> response = vmMigrationClient.CreateCloneJob(parent, cloneJob, cloneJobId);

            // Poll until the returned long-running operation is complete
            Operation<CloneJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CloneJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloneJob, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateCloneJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloneJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloneJobAsync</summary>
        public async Task CreateCloneJobAsync()
        {
            // Snippet: CreateCloneJobAsync(string, CloneJob, string, CallSettings)
            // Additional: CreateCloneJobAsync(string, CloneJob, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            CloneJob cloneJob = new CloneJob();
            string cloneJobId = "";
            // Make the request
            Operation<CloneJob, OperationMetadata> response = await vmMigrationClient.CreateCloneJobAsync(parent, cloneJob, cloneJobId);

            // Poll until the returned long-running operation is complete
            Operation<CloneJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CloneJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloneJob, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateCloneJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloneJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloneJob</summary>
        public void CreateCloneJobResourceNames()
        {
            // Snippet: CreateCloneJob(MigratingVmName, CloneJob, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            MigratingVmName parent = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            CloneJob cloneJob = new CloneJob();
            string cloneJobId = "";
            // Make the request
            Operation<CloneJob, OperationMetadata> response = vmMigrationClient.CreateCloneJob(parent, cloneJob, cloneJobId);

            // Poll until the returned long-running operation is complete
            Operation<CloneJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CloneJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloneJob, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateCloneJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloneJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloneJobAsync</summary>
        public async Task CreateCloneJobResourceNamesAsync()
        {
            // Snippet: CreateCloneJobAsync(MigratingVmName, CloneJob, string, CallSettings)
            // Additional: CreateCloneJobAsync(MigratingVmName, CloneJob, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            MigratingVmName parent = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            CloneJob cloneJob = new CloneJob();
            string cloneJobId = "";
            // Make the request
            Operation<CloneJob, OperationMetadata> response = await vmMigrationClient.CreateCloneJobAsync(parent, cloneJob, cloneJobId);

            // Poll until the returned long-running operation is complete
            Operation<CloneJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CloneJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloneJob, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateCloneJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloneJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelCloneJob</summary>
        public void CancelCloneJobRequestObject()
        {
            // Snippet: CancelCloneJob(CancelCloneJobRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CancelCloneJobRequest request = new CancelCloneJobRequest
            {
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
            };
            // Make the request
            Operation<CancelCloneJobResponse, OperationMetadata> response = vmMigrationClient.CancelCloneJob(request);

            // Poll until the returned long-running operation is complete
            Operation<CancelCloneJobResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CancelCloneJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CancelCloneJobResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCancelCloneJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CancelCloneJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelCloneJobAsync</summary>
        public async Task CancelCloneJobRequestObjectAsync()
        {
            // Snippet: CancelCloneJobAsync(CancelCloneJobRequest, CallSettings)
            // Additional: CancelCloneJobAsync(CancelCloneJobRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            CancelCloneJobRequest request = new CancelCloneJobRequest
            {
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
            };
            // Make the request
            Operation<CancelCloneJobResponse, OperationMetadata> response = await vmMigrationClient.CancelCloneJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CancelCloneJobResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CancelCloneJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CancelCloneJobResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCancelCloneJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CancelCloneJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelCloneJob</summary>
        public void CancelCloneJob()
        {
            // Snippet: CancelCloneJob(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]/cloneJobs/[CLONE_JOB]";
            // Make the request
            Operation<CancelCloneJobResponse, OperationMetadata> response = vmMigrationClient.CancelCloneJob(name);

            // Poll until the returned long-running operation is complete
            Operation<CancelCloneJobResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CancelCloneJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CancelCloneJobResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCancelCloneJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CancelCloneJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelCloneJobAsync</summary>
        public async Task CancelCloneJobAsync()
        {
            // Snippet: CancelCloneJobAsync(string, CallSettings)
            // Additional: CancelCloneJobAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]/cloneJobs/[CLONE_JOB]";
            // Make the request
            Operation<CancelCloneJobResponse, OperationMetadata> response = await vmMigrationClient.CancelCloneJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CancelCloneJobResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CancelCloneJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CancelCloneJobResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCancelCloneJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CancelCloneJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelCloneJob</summary>
        public void CancelCloneJobResourceNames()
        {
            // Snippet: CancelCloneJob(CloneJobName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CloneJobName name = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]");
            // Make the request
            Operation<CancelCloneJobResponse, OperationMetadata> response = vmMigrationClient.CancelCloneJob(name);

            // Poll until the returned long-running operation is complete
            Operation<CancelCloneJobResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CancelCloneJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CancelCloneJobResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCancelCloneJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CancelCloneJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelCloneJobAsync</summary>
        public async Task CancelCloneJobResourceNamesAsync()
        {
            // Snippet: CancelCloneJobAsync(CloneJobName, CallSettings)
            // Additional: CancelCloneJobAsync(CloneJobName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            CloneJobName name = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]");
            // Make the request
            Operation<CancelCloneJobResponse, OperationMetadata> response = await vmMigrationClient.CancelCloneJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CancelCloneJobResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CancelCloneJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CancelCloneJobResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCancelCloneJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CancelCloneJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListCloneJobs</summary>
        public void ListCloneJobsRequestObject()
        {
            // Snippet: ListCloneJobs(ListCloneJobsRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            ListCloneJobsRequest request = new ListCloneJobsRequest
            {
                ParentAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCloneJobsResponse, CloneJob> response = vmMigrationClient.ListCloneJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloneJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloneJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloneJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloneJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloneJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloneJobsAsync</summary>
        public async Task ListCloneJobsRequestObjectAsync()
        {
            // Snippet: ListCloneJobsAsync(ListCloneJobsRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            ListCloneJobsRequest request = new ListCloneJobsRequest
            {
                ParentAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCloneJobsResponse, CloneJob> response = vmMigrationClient.ListCloneJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloneJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloneJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloneJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloneJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloneJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloneJobs</summary>
        public void ListCloneJobs()
        {
            // Snippet: ListCloneJobs(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            PagedEnumerable<ListCloneJobsResponse, CloneJob> response = vmMigrationClient.ListCloneJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloneJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloneJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloneJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloneJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloneJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloneJobsAsync</summary>
        public async Task ListCloneJobsAsync()
        {
            // Snippet: ListCloneJobsAsync(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            PagedAsyncEnumerable<ListCloneJobsResponse, CloneJob> response = vmMigrationClient.ListCloneJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloneJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloneJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloneJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloneJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloneJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloneJobs</summary>
        public void ListCloneJobsResourceNames()
        {
            // Snippet: ListCloneJobs(MigratingVmName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            MigratingVmName parent = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            // Make the request
            PagedEnumerable<ListCloneJobsResponse, CloneJob> response = vmMigrationClient.ListCloneJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloneJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloneJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloneJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloneJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloneJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloneJobsAsync</summary>
        public async Task ListCloneJobsResourceNamesAsync()
        {
            // Snippet: ListCloneJobsAsync(MigratingVmName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            MigratingVmName parent = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            // Make the request
            PagedAsyncEnumerable<ListCloneJobsResponse, CloneJob> response = vmMigrationClient.ListCloneJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloneJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloneJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloneJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloneJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloneJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCloneJob</summary>
        public void GetCloneJobRequestObject()
        {
            // Snippet: GetCloneJob(GetCloneJobRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            GetCloneJobRequest request = new GetCloneJobRequest
            {
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
            };
            // Make the request
            CloneJob response = vmMigrationClient.GetCloneJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetCloneJobAsync</summary>
        public async Task GetCloneJobRequestObjectAsync()
        {
            // Snippet: GetCloneJobAsync(GetCloneJobRequest, CallSettings)
            // Additional: GetCloneJobAsync(GetCloneJobRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            GetCloneJobRequest request = new GetCloneJobRequest
            {
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
            };
            // Make the request
            CloneJob response = await vmMigrationClient.GetCloneJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCloneJob</summary>
        public void GetCloneJob()
        {
            // Snippet: GetCloneJob(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]/cloneJobs/[CLONE_JOB]";
            // Make the request
            CloneJob response = vmMigrationClient.GetCloneJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloneJobAsync</summary>
        public async Task GetCloneJobAsync()
        {
            // Snippet: GetCloneJobAsync(string, CallSettings)
            // Additional: GetCloneJobAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]/cloneJobs/[CLONE_JOB]";
            // Make the request
            CloneJob response = await vmMigrationClient.GetCloneJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloneJob</summary>
        public void GetCloneJobResourceNames()
        {
            // Snippet: GetCloneJob(CloneJobName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CloneJobName name = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]");
            // Make the request
            CloneJob response = vmMigrationClient.GetCloneJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloneJobAsync</summary>
        public async Task GetCloneJobResourceNamesAsync()
        {
            // Snippet: GetCloneJobAsync(CloneJobName, CallSettings)
            // Additional: GetCloneJobAsync(CloneJobName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            CloneJobName name = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]");
            // Make the request
            CloneJob response = await vmMigrationClient.GetCloneJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCutoverJob</summary>
        public void CreateCutoverJobRequestObject()
        {
            // Snippet: CreateCutoverJob(CreateCutoverJobRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CreateCutoverJobRequest request = new CreateCutoverJobRequest
            {
                ParentAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                CutoverJobId = "",
                CutoverJob = new CutoverJob(),
                RequestId = "",
            };
            // Make the request
            Operation<CutoverJob, OperationMetadata> response = vmMigrationClient.CreateCutoverJob(request);

            // Poll until the returned long-running operation is complete
            Operation<CutoverJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CutoverJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CutoverJob, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateCutoverJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CutoverJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCutoverJobAsync</summary>
        public async Task CreateCutoverJobRequestObjectAsync()
        {
            // Snippet: CreateCutoverJobAsync(CreateCutoverJobRequest, CallSettings)
            // Additional: CreateCutoverJobAsync(CreateCutoverJobRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            CreateCutoverJobRequest request = new CreateCutoverJobRequest
            {
                ParentAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                CutoverJobId = "",
                CutoverJob = new CutoverJob(),
                RequestId = "",
            };
            // Make the request
            Operation<CutoverJob, OperationMetadata> response = await vmMigrationClient.CreateCutoverJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CutoverJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CutoverJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CutoverJob, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateCutoverJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CutoverJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCutoverJob</summary>
        public void CreateCutoverJob()
        {
            // Snippet: CreateCutoverJob(string, CutoverJob, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            CutoverJob cutoverJob = new CutoverJob();
            string cutoverJobId = "";
            // Make the request
            Operation<CutoverJob, OperationMetadata> response = vmMigrationClient.CreateCutoverJob(parent, cutoverJob, cutoverJobId);

            // Poll until the returned long-running operation is complete
            Operation<CutoverJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CutoverJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CutoverJob, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateCutoverJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CutoverJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCutoverJobAsync</summary>
        public async Task CreateCutoverJobAsync()
        {
            // Snippet: CreateCutoverJobAsync(string, CutoverJob, string, CallSettings)
            // Additional: CreateCutoverJobAsync(string, CutoverJob, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            CutoverJob cutoverJob = new CutoverJob();
            string cutoverJobId = "";
            // Make the request
            Operation<CutoverJob, OperationMetadata> response = await vmMigrationClient.CreateCutoverJobAsync(parent, cutoverJob, cutoverJobId);

            // Poll until the returned long-running operation is complete
            Operation<CutoverJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CutoverJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CutoverJob, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateCutoverJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CutoverJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCutoverJob</summary>
        public void CreateCutoverJobResourceNames()
        {
            // Snippet: CreateCutoverJob(MigratingVmName, CutoverJob, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            MigratingVmName parent = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            CutoverJob cutoverJob = new CutoverJob();
            string cutoverJobId = "";
            // Make the request
            Operation<CutoverJob, OperationMetadata> response = vmMigrationClient.CreateCutoverJob(parent, cutoverJob, cutoverJobId);

            // Poll until the returned long-running operation is complete
            Operation<CutoverJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CutoverJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CutoverJob, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateCutoverJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CutoverJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCutoverJobAsync</summary>
        public async Task CreateCutoverJobResourceNamesAsync()
        {
            // Snippet: CreateCutoverJobAsync(MigratingVmName, CutoverJob, string, CallSettings)
            // Additional: CreateCutoverJobAsync(MigratingVmName, CutoverJob, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            MigratingVmName parent = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            CutoverJob cutoverJob = new CutoverJob();
            string cutoverJobId = "";
            // Make the request
            Operation<CutoverJob, OperationMetadata> response = await vmMigrationClient.CreateCutoverJobAsync(parent, cutoverJob, cutoverJobId);

            // Poll until the returned long-running operation is complete
            Operation<CutoverJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CutoverJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CutoverJob, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateCutoverJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CutoverJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelCutoverJob</summary>
        public void CancelCutoverJobRequestObject()
        {
            // Snippet: CancelCutoverJob(CancelCutoverJobRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CancelCutoverJobRequest request = new CancelCutoverJobRequest
            {
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
            };
            // Make the request
            Operation<CancelCutoverJobResponse, OperationMetadata> response = vmMigrationClient.CancelCutoverJob(request);

            // Poll until the returned long-running operation is complete
            Operation<CancelCutoverJobResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CancelCutoverJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CancelCutoverJobResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCancelCutoverJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CancelCutoverJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelCutoverJobAsync</summary>
        public async Task CancelCutoverJobRequestObjectAsync()
        {
            // Snippet: CancelCutoverJobAsync(CancelCutoverJobRequest, CallSettings)
            // Additional: CancelCutoverJobAsync(CancelCutoverJobRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            CancelCutoverJobRequest request = new CancelCutoverJobRequest
            {
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
            };
            // Make the request
            Operation<CancelCutoverJobResponse, OperationMetadata> response = await vmMigrationClient.CancelCutoverJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CancelCutoverJobResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CancelCutoverJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CancelCutoverJobResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCancelCutoverJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CancelCutoverJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelCutoverJob</summary>
        public void CancelCutoverJob()
        {
            // Snippet: CancelCutoverJob(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]/cutoverJobs/[CUTOVER_JOB]";
            // Make the request
            Operation<CancelCutoverJobResponse, OperationMetadata> response = vmMigrationClient.CancelCutoverJob(name);

            // Poll until the returned long-running operation is complete
            Operation<CancelCutoverJobResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CancelCutoverJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CancelCutoverJobResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCancelCutoverJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CancelCutoverJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelCutoverJobAsync</summary>
        public async Task CancelCutoverJobAsync()
        {
            // Snippet: CancelCutoverJobAsync(string, CallSettings)
            // Additional: CancelCutoverJobAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]/cutoverJobs/[CUTOVER_JOB]";
            // Make the request
            Operation<CancelCutoverJobResponse, OperationMetadata> response = await vmMigrationClient.CancelCutoverJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CancelCutoverJobResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CancelCutoverJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CancelCutoverJobResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCancelCutoverJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CancelCutoverJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelCutoverJob</summary>
        public void CancelCutoverJobResourceNames()
        {
            // Snippet: CancelCutoverJob(CutoverJobName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CutoverJobName name = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]");
            // Make the request
            Operation<CancelCutoverJobResponse, OperationMetadata> response = vmMigrationClient.CancelCutoverJob(name);

            // Poll until the returned long-running operation is complete
            Operation<CancelCutoverJobResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CancelCutoverJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CancelCutoverJobResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCancelCutoverJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CancelCutoverJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelCutoverJobAsync</summary>
        public async Task CancelCutoverJobResourceNamesAsync()
        {
            // Snippet: CancelCutoverJobAsync(CutoverJobName, CallSettings)
            // Additional: CancelCutoverJobAsync(CutoverJobName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            CutoverJobName name = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]");
            // Make the request
            Operation<CancelCutoverJobResponse, OperationMetadata> response = await vmMigrationClient.CancelCutoverJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CancelCutoverJobResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CancelCutoverJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CancelCutoverJobResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCancelCutoverJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CancelCutoverJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListCutoverJobs</summary>
        public void ListCutoverJobsRequestObject()
        {
            // Snippet: ListCutoverJobs(ListCutoverJobsRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            ListCutoverJobsRequest request = new ListCutoverJobsRequest
            {
                ParentAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCutoverJobsResponse, CutoverJob> response = vmMigrationClient.ListCutoverJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CutoverJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCutoverJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CutoverJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CutoverJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CutoverJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCutoverJobsAsync</summary>
        public async Task ListCutoverJobsRequestObjectAsync()
        {
            // Snippet: ListCutoverJobsAsync(ListCutoverJobsRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            ListCutoverJobsRequest request = new ListCutoverJobsRequest
            {
                ParentAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCutoverJobsResponse, CutoverJob> response = vmMigrationClient.ListCutoverJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CutoverJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCutoverJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CutoverJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CutoverJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CutoverJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCutoverJobs</summary>
        public void ListCutoverJobs()
        {
            // Snippet: ListCutoverJobs(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            PagedEnumerable<ListCutoverJobsResponse, CutoverJob> response = vmMigrationClient.ListCutoverJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CutoverJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCutoverJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CutoverJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CutoverJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CutoverJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCutoverJobsAsync</summary>
        public async Task ListCutoverJobsAsync()
        {
            // Snippet: ListCutoverJobsAsync(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            PagedAsyncEnumerable<ListCutoverJobsResponse, CutoverJob> response = vmMigrationClient.ListCutoverJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CutoverJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCutoverJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CutoverJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CutoverJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CutoverJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCutoverJobs</summary>
        public void ListCutoverJobsResourceNames()
        {
            // Snippet: ListCutoverJobs(MigratingVmName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            MigratingVmName parent = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            // Make the request
            PagedEnumerable<ListCutoverJobsResponse, CutoverJob> response = vmMigrationClient.ListCutoverJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CutoverJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCutoverJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CutoverJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CutoverJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CutoverJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCutoverJobsAsync</summary>
        public async Task ListCutoverJobsResourceNamesAsync()
        {
            // Snippet: ListCutoverJobsAsync(MigratingVmName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            MigratingVmName parent = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            // Make the request
            PagedAsyncEnumerable<ListCutoverJobsResponse, CutoverJob> response = vmMigrationClient.ListCutoverJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CutoverJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCutoverJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CutoverJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CutoverJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CutoverJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCutoverJob</summary>
        public void GetCutoverJobRequestObject()
        {
            // Snippet: GetCutoverJob(GetCutoverJobRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            GetCutoverJobRequest request = new GetCutoverJobRequest
            {
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
            };
            // Make the request
            CutoverJob response = vmMigrationClient.GetCutoverJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetCutoverJobAsync</summary>
        public async Task GetCutoverJobRequestObjectAsync()
        {
            // Snippet: GetCutoverJobAsync(GetCutoverJobRequest, CallSettings)
            // Additional: GetCutoverJobAsync(GetCutoverJobRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            GetCutoverJobRequest request = new GetCutoverJobRequest
            {
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
            };
            // Make the request
            CutoverJob response = await vmMigrationClient.GetCutoverJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCutoverJob</summary>
        public void GetCutoverJob()
        {
            // Snippet: GetCutoverJob(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]/cutoverJobs/[CUTOVER_JOB]";
            // Make the request
            CutoverJob response = vmMigrationClient.GetCutoverJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetCutoverJobAsync</summary>
        public async Task GetCutoverJobAsync()
        {
            // Snippet: GetCutoverJobAsync(string, CallSettings)
            // Additional: GetCutoverJobAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]/cutoverJobs/[CUTOVER_JOB]";
            // Make the request
            CutoverJob response = await vmMigrationClient.GetCutoverJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCutoverJob</summary>
        public void GetCutoverJobResourceNames()
        {
            // Snippet: GetCutoverJob(CutoverJobName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CutoverJobName name = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]");
            // Make the request
            CutoverJob response = vmMigrationClient.GetCutoverJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetCutoverJobAsync</summary>
        public async Task GetCutoverJobResourceNamesAsync()
        {
            // Snippet: GetCutoverJobAsync(CutoverJobName, CallSettings)
            // Additional: GetCutoverJobAsync(CutoverJobName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            CutoverJobName name = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]");
            // Make the request
            CutoverJob response = await vmMigrationClient.GetCutoverJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGroups</summary>
        public void ListGroupsRequestObject()
        {
            // Snippet: ListGroups(ListGroupsRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            ListGroupsRequest request = new ListGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = vmMigrationClient.ListGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsRequestObjectAsync()
        {
            // Snippet: ListGroupsAsync(ListGroupsRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            ListGroupsRequest request = new ListGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = vmMigrationClient.ListGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroups</summary>
        public void ListGroups()
        {
            // Snippet: ListGroups(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = vmMigrationClient.ListGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsAsync()
        {
            // Snippet: ListGroupsAsync(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = vmMigrationClient.ListGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroups</summary>
        public void ListGroupsResourceNames()
        {
            // Snippet: ListGroups(LocationName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = vmMigrationClient.ListGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsResourceNamesAsync()
        {
            // Snippet: ListGroupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = vmMigrationClient.ListGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroupRequestObject()
        {
            // Snippet: GetGroup(GetGroupRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
            };
            // Make the request
            Group response = vmMigrationClient.GetGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupRequestObjectAsync()
        {
            // Snippet: GetGroupAsync(GetGroupRequest, CallSettings)
            // Additional: GetGroupAsync(GetGroupRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
            };
            // Make the request
            Group response = await vmMigrationClient.GetGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroup()
        {
            // Snippet: GetGroup(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Group response = vmMigrationClient.GetGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupAsync()
        {
            // Snippet: GetGroupAsync(string, CallSettings)
            // Additional: GetGroupAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Group response = await vmMigrationClient.GetGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroupResourceNames()
        {
            // Snippet: GetGroup(GroupName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Group response = vmMigrationClient.GetGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupResourceNamesAsync()
        {
            // Snippet: GetGroupAsync(GroupName, CallSettings)
            // Additional: GetGroupAsync(GroupName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Group response = await vmMigrationClient.GetGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGroup</summary>
        public void CreateGroupRequestObject()
        {
            // Snippet: CreateGroup(CreateGroupRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CreateGroupRequest request = new CreateGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GroupId = "",
                Group = new Group(),
                RequestId = "",
            };
            // Make the request
            Operation<Group, OperationMetadata> response = vmMigrationClient.CreateGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGroupAsync</summary>
        public async Task CreateGroupRequestObjectAsync()
        {
            // Snippet: CreateGroupAsync(CreateGroupRequest, CallSettings)
            // Additional: CreateGroupAsync(CreateGroupRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            CreateGroupRequest request = new CreateGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GroupId = "",
                Group = new Group(),
                RequestId = "",
            };
            // Make the request
            Operation<Group, OperationMetadata> response = await vmMigrationClient.CreateGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGroup</summary>
        public void CreateGroup()
        {
            // Snippet: CreateGroup(string, Group, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Group group = new Group();
            string groupId = "";
            // Make the request
            Operation<Group, OperationMetadata> response = vmMigrationClient.CreateGroup(parent, group, groupId);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGroupAsync</summary>
        public async Task CreateGroupAsync()
        {
            // Snippet: CreateGroupAsync(string, Group, string, CallSettings)
            // Additional: CreateGroupAsync(string, Group, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Group group = new Group();
            string groupId = "";
            // Make the request
            Operation<Group, OperationMetadata> response = await vmMigrationClient.CreateGroupAsync(parent, group, groupId);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGroup</summary>
        public void CreateGroupResourceNames()
        {
            // Snippet: CreateGroup(LocationName, Group, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Group group = new Group();
            string groupId = "";
            // Make the request
            Operation<Group, OperationMetadata> response = vmMigrationClient.CreateGroup(parent, group, groupId);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGroupAsync</summary>
        public async Task CreateGroupResourceNamesAsync()
        {
            // Snippet: CreateGroupAsync(LocationName, Group, string, CallSettings)
            // Additional: CreateGroupAsync(LocationName, Group, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Group group = new Group();
            string groupId = "";
            // Make the request
            Operation<Group, OperationMetadata> response = await vmMigrationClient.CreateGroupAsync(parent, group, groupId);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGroup</summary>
        public void UpdateGroupRequestObject()
        {
            // Snippet: UpdateGroup(UpdateGroupRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                UpdateMask = new FieldMask(),
                Group = new Group(),
                RequestId = "",
            };
            // Make the request
            Operation<Group, OperationMetadata> response = vmMigrationClient.UpdateGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceUpdateGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGroupAsync</summary>
        public async Task UpdateGroupRequestObjectAsync()
        {
            // Snippet: UpdateGroupAsync(UpdateGroupRequest, CallSettings)
            // Additional: UpdateGroupAsync(UpdateGroupRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                UpdateMask = new FieldMask(),
                Group = new Group(),
                RequestId = "",
            };
            // Make the request
            Operation<Group, OperationMetadata> response = await vmMigrationClient.UpdateGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceUpdateGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGroup</summary>
        public void UpdateGroup()
        {
            // Snippet: UpdateGroup(Group, FieldMask, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            Group group = new Group();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Group, OperationMetadata> response = vmMigrationClient.UpdateGroup(group, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceUpdateGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGroupAsync</summary>
        public async Task UpdateGroupAsync()
        {
            // Snippet: UpdateGroupAsync(Group, FieldMask, CallSettings)
            // Additional: UpdateGroupAsync(Group, FieldMask, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            Group group = new Group();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Group, OperationMetadata> response = await vmMigrationClient.UpdateGroupAsync(group, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceUpdateGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGroup</summary>
        public void DeleteGroupRequestObject()
        {
            // Snippet: DeleteGroup(DeleteGroupRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGroupAsync</summary>
        public async Task DeleteGroupRequestObjectAsync()
        {
            // Snippet: DeleteGroupAsync(DeleteGroupRequest, CallSettings)
            // Additional: DeleteGroupAsync(DeleteGroupRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGroup</summary>
        public void DeleteGroup()
        {
            // Snippet: DeleteGroup(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGroupAsync</summary>
        public async Task DeleteGroupAsync()
        {
            // Snippet: DeleteGroupAsync(string, CallSettings)
            // Additional: DeleteGroupAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGroup</summary>
        public void DeleteGroupResourceNames()
        {
            // Snippet: DeleteGroup(GroupName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGroupAsync</summary>
        public async Task DeleteGroupResourceNamesAsync()
        {
            // Snippet: DeleteGroupAsync(GroupName, CallSettings)
            // Additional: DeleteGroupAsync(GroupName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddGroupMigration</summary>
        public void AddGroupMigrationRequestObject()
        {
            // Snippet: AddGroupMigration(AddGroupMigrationRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            AddGroupMigrationRequest request = new AddGroupMigrationRequest
            {
                GroupAsGroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                MigratingVmAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            // Make the request
            Operation<AddGroupMigrationResponse, OperationMetadata> response = vmMigrationClient.AddGroupMigration(request);

            // Poll until the returned long-running operation is complete
            Operation<AddGroupMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddGroupMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddGroupMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceAddGroupMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddGroupMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddGroupMigrationAsync</summary>
        public async Task AddGroupMigrationRequestObjectAsync()
        {
            // Snippet: AddGroupMigrationAsync(AddGroupMigrationRequest, CallSettings)
            // Additional: AddGroupMigrationAsync(AddGroupMigrationRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            AddGroupMigrationRequest request = new AddGroupMigrationRequest
            {
                GroupAsGroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                MigratingVmAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            // Make the request
            Operation<AddGroupMigrationResponse, OperationMetadata> response = await vmMigrationClient.AddGroupMigrationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AddGroupMigrationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddGroupMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddGroupMigrationResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceAddGroupMigrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddGroupMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddGroupMigration</summary>
        public void AddGroupMigration()
        {
            // Snippet: AddGroupMigration(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string group = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Operation<AddGroupMigrationResponse, OperationMetadata> response = vmMigrationClient.AddGroupMigration(group);

            // Poll until the returned long-running operation is complete
            Operation<AddGroupMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddGroupMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddGroupMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceAddGroupMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddGroupMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddGroupMigrationAsync</summary>
        public async Task AddGroupMigrationAsync()
        {
            // Snippet: AddGroupMigrationAsync(string, CallSettings)
            // Additional: AddGroupMigrationAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string group = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Operation<AddGroupMigrationResponse, OperationMetadata> response = await vmMigrationClient.AddGroupMigrationAsync(group);

            // Poll until the returned long-running operation is complete
            Operation<AddGroupMigrationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddGroupMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddGroupMigrationResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceAddGroupMigrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddGroupMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddGroupMigration</summary>
        public void AddGroupMigrationResourceNames()
        {
            // Snippet: AddGroupMigration(GroupName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            GroupName group = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Operation<AddGroupMigrationResponse, OperationMetadata> response = vmMigrationClient.AddGroupMigration(group);

            // Poll until the returned long-running operation is complete
            Operation<AddGroupMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddGroupMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddGroupMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceAddGroupMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddGroupMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddGroupMigrationAsync</summary>
        public async Task AddGroupMigrationResourceNamesAsync()
        {
            // Snippet: AddGroupMigrationAsync(GroupName, CallSettings)
            // Additional: AddGroupMigrationAsync(GroupName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            GroupName group = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Operation<AddGroupMigrationResponse, OperationMetadata> response = await vmMigrationClient.AddGroupMigrationAsync(group);

            // Poll until the returned long-running operation is complete
            Operation<AddGroupMigrationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddGroupMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddGroupMigrationResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceAddGroupMigrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddGroupMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveGroupMigration</summary>
        public void RemoveGroupMigrationRequestObject()
        {
            // Snippet: RemoveGroupMigration(RemoveGroupMigrationRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            RemoveGroupMigrationRequest request = new RemoveGroupMigrationRequest
            {
                GroupAsGroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                MigratingVmAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            // Make the request
            Operation<RemoveGroupMigrationResponse, OperationMetadata> response = vmMigrationClient.RemoveGroupMigration(request);

            // Poll until the returned long-running operation is complete
            Operation<RemoveGroupMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemoveGroupMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveGroupMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceRemoveGroupMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveGroupMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveGroupMigrationAsync</summary>
        public async Task RemoveGroupMigrationRequestObjectAsync()
        {
            // Snippet: RemoveGroupMigrationAsync(RemoveGroupMigrationRequest, CallSettings)
            // Additional: RemoveGroupMigrationAsync(RemoveGroupMigrationRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            RemoveGroupMigrationRequest request = new RemoveGroupMigrationRequest
            {
                GroupAsGroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                MigratingVmAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            // Make the request
            Operation<RemoveGroupMigrationResponse, OperationMetadata> response = await vmMigrationClient.RemoveGroupMigrationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RemoveGroupMigrationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RemoveGroupMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveGroupMigrationResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceRemoveGroupMigrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveGroupMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveGroupMigration</summary>
        public void RemoveGroupMigration()
        {
            // Snippet: RemoveGroupMigration(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string group = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Operation<RemoveGroupMigrationResponse, OperationMetadata> response = vmMigrationClient.RemoveGroupMigration(group);

            // Poll until the returned long-running operation is complete
            Operation<RemoveGroupMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemoveGroupMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveGroupMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceRemoveGroupMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveGroupMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveGroupMigrationAsync</summary>
        public async Task RemoveGroupMigrationAsync()
        {
            // Snippet: RemoveGroupMigrationAsync(string, CallSettings)
            // Additional: RemoveGroupMigrationAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string group = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Operation<RemoveGroupMigrationResponse, OperationMetadata> response = await vmMigrationClient.RemoveGroupMigrationAsync(group);

            // Poll until the returned long-running operation is complete
            Operation<RemoveGroupMigrationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RemoveGroupMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveGroupMigrationResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceRemoveGroupMigrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveGroupMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveGroupMigration</summary>
        public void RemoveGroupMigrationResourceNames()
        {
            // Snippet: RemoveGroupMigration(GroupName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            GroupName group = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Operation<RemoveGroupMigrationResponse, OperationMetadata> response = vmMigrationClient.RemoveGroupMigration(group);

            // Poll until the returned long-running operation is complete
            Operation<RemoveGroupMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemoveGroupMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveGroupMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceRemoveGroupMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveGroupMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveGroupMigrationAsync</summary>
        public async Task RemoveGroupMigrationResourceNamesAsync()
        {
            // Snippet: RemoveGroupMigrationAsync(GroupName, CallSettings)
            // Additional: RemoveGroupMigrationAsync(GroupName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            GroupName group = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Operation<RemoveGroupMigrationResponse, OperationMetadata> response = await vmMigrationClient.RemoveGroupMigrationAsync(group);

            // Poll until the returned long-running operation is complete
            Operation<RemoveGroupMigrationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RemoveGroupMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveGroupMigrationResponse, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceRemoveGroupMigrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveGroupMigrationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListTargetProjects</summary>
        public void ListTargetProjectsRequestObject()
        {
            // Snippet: ListTargetProjects(ListTargetProjectsRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            ListTargetProjectsRequest request = new ListTargetProjectsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListTargetProjectsResponse, TargetProject> response = vmMigrationClient.ListTargetProjects(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetProject item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTargetProjectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetProject item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetProject> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetProject item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetProjectsAsync</summary>
        public async Task ListTargetProjectsRequestObjectAsync()
        {
            // Snippet: ListTargetProjectsAsync(ListTargetProjectsRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetProjectsRequest request = new ListTargetProjectsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTargetProjectsResponse, TargetProject> response = vmMigrationClient.ListTargetProjectsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetProject item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTargetProjectsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetProject item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetProject> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetProject item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetProjects</summary>
        public void ListTargetProjects()
        {
            // Snippet: ListTargetProjects(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTargetProjectsResponse, TargetProject> response = vmMigrationClient.ListTargetProjects(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetProject item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTargetProjectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetProject item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetProject> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetProject item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetProjectsAsync</summary>
        public async Task ListTargetProjectsAsync()
        {
            // Snippet: ListTargetProjectsAsync(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTargetProjectsResponse, TargetProject> response = vmMigrationClient.ListTargetProjectsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetProject item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTargetProjectsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetProject item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetProject> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetProject item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetProjects</summary>
        public void ListTargetProjectsResourceNames()
        {
            // Snippet: ListTargetProjects(LocationName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTargetProjectsResponse, TargetProject> response = vmMigrationClient.ListTargetProjects(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetProject item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTargetProjectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetProject item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetProject> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetProject item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetProjectsAsync</summary>
        public async Task ListTargetProjectsResourceNamesAsync()
        {
            // Snippet: ListTargetProjectsAsync(LocationName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTargetProjectsResponse, TargetProject> response = vmMigrationClient.ListTargetProjectsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetProject item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTargetProjectsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetProject item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetProject> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetProject item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTargetProject</summary>
        public void GetTargetProjectRequestObject()
        {
            // Snippet: GetTargetProject(GetTargetProjectRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            GetTargetProjectRequest request = new GetTargetProjectRequest
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
            };
            // Make the request
            TargetProject response = vmMigrationClient.GetTargetProject(request);
            // End snippet
        }

        /// <summary>Snippet for GetTargetProjectAsync</summary>
        public async Task GetTargetProjectRequestObjectAsync()
        {
            // Snippet: GetTargetProjectAsync(GetTargetProjectRequest, CallSettings)
            // Additional: GetTargetProjectAsync(GetTargetProjectRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            GetTargetProjectRequest request = new GetTargetProjectRequest
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
            };
            // Make the request
            TargetProject response = await vmMigrationClient.GetTargetProjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTargetProject</summary>
        public void GetTargetProject()
        {
            // Snippet: GetTargetProject(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/targetProjects/[TARGET_PROJECT]";
            // Make the request
            TargetProject response = vmMigrationClient.GetTargetProject(name);
            // End snippet
        }

        /// <summary>Snippet for GetTargetProjectAsync</summary>
        public async Task GetTargetProjectAsync()
        {
            // Snippet: GetTargetProjectAsync(string, CallSettings)
            // Additional: GetTargetProjectAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/targetProjects/[TARGET_PROJECT]";
            // Make the request
            TargetProject response = await vmMigrationClient.GetTargetProjectAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTargetProject</summary>
        public void GetTargetProjectResourceNames()
        {
            // Snippet: GetTargetProject(TargetProjectName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            TargetProjectName name = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]");
            // Make the request
            TargetProject response = vmMigrationClient.GetTargetProject(name);
            // End snippet
        }

        /// <summary>Snippet for GetTargetProjectAsync</summary>
        public async Task GetTargetProjectResourceNamesAsync()
        {
            // Snippet: GetTargetProjectAsync(TargetProjectName, CallSettings)
            // Additional: GetTargetProjectAsync(TargetProjectName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            TargetProjectName name = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]");
            // Make the request
            TargetProject response = await vmMigrationClient.GetTargetProjectAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTargetProject</summary>
        public void CreateTargetProjectRequestObject()
        {
            // Snippet: CreateTargetProject(CreateTargetProjectRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CreateTargetProjectRequest request = new CreateTargetProjectRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TargetProjectId = "",
                TargetProject = new TargetProject(),
                RequestId = "",
            };
            // Make the request
            Operation<TargetProject, OperationMetadata> response = vmMigrationClient.CreateTargetProject(request);

            // Poll until the returned long-running operation is complete
            Operation<TargetProject, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TargetProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetProject, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateTargetProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetProject retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTargetProjectAsync</summary>
        public async Task CreateTargetProjectRequestObjectAsync()
        {
            // Snippet: CreateTargetProjectAsync(CreateTargetProjectRequest, CallSettings)
            // Additional: CreateTargetProjectAsync(CreateTargetProjectRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            CreateTargetProjectRequest request = new CreateTargetProjectRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TargetProjectId = "",
                TargetProject = new TargetProject(),
                RequestId = "",
            };
            // Make the request
            Operation<TargetProject, OperationMetadata> response = await vmMigrationClient.CreateTargetProjectAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TargetProject, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TargetProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetProject, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateTargetProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetProject retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTargetProject</summary>
        public void CreateTargetProject()
        {
            // Snippet: CreateTargetProject(string, TargetProject, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TargetProject targetProject = new TargetProject();
            string targetProjectId = "";
            // Make the request
            Operation<TargetProject, OperationMetadata> response = vmMigrationClient.CreateTargetProject(parent, targetProject, targetProjectId);

            // Poll until the returned long-running operation is complete
            Operation<TargetProject, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TargetProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetProject, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateTargetProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetProject retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTargetProjectAsync</summary>
        public async Task CreateTargetProjectAsync()
        {
            // Snippet: CreateTargetProjectAsync(string, TargetProject, string, CallSettings)
            // Additional: CreateTargetProjectAsync(string, TargetProject, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TargetProject targetProject = new TargetProject();
            string targetProjectId = "";
            // Make the request
            Operation<TargetProject, OperationMetadata> response = await vmMigrationClient.CreateTargetProjectAsync(parent, targetProject, targetProjectId);

            // Poll until the returned long-running operation is complete
            Operation<TargetProject, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TargetProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetProject, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateTargetProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetProject retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTargetProject</summary>
        public void CreateTargetProjectResourceNames()
        {
            // Snippet: CreateTargetProject(LocationName, TargetProject, string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TargetProject targetProject = new TargetProject();
            string targetProjectId = "";
            // Make the request
            Operation<TargetProject, OperationMetadata> response = vmMigrationClient.CreateTargetProject(parent, targetProject, targetProjectId);

            // Poll until the returned long-running operation is complete
            Operation<TargetProject, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TargetProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetProject, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateTargetProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetProject retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTargetProjectAsync</summary>
        public async Task CreateTargetProjectResourceNamesAsync()
        {
            // Snippet: CreateTargetProjectAsync(LocationName, TargetProject, string, CallSettings)
            // Additional: CreateTargetProjectAsync(LocationName, TargetProject, string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TargetProject targetProject = new TargetProject();
            string targetProjectId = "";
            // Make the request
            Operation<TargetProject, OperationMetadata> response = await vmMigrationClient.CreateTargetProjectAsync(parent, targetProject, targetProjectId);

            // Poll until the returned long-running operation is complete
            Operation<TargetProject, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TargetProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetProject, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateTargetProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetProject retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTargetProject</summary>
        public void UpdateTargetProjectRequestObject()
        {
            // Snippet: UpdateTargetProject(UpdateTargetProjectRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            UpdateTargetProjectRequest request = new UpdateTargetProjectRequest
            {
                UpdateMask = new FieldMask(),
                TargetProject = new TargetProject(),
                RequestId = "",
            };
            // Make the request
            Operation<TargetProject, OperationMetadata> response = vmMigrationClient.UpdateTargetProject(request);

            // Poll until the returned long-running operation is complete
            Operation<TargetProject, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TargetProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetProject, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceUpdateTargetProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetProject retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTargetProjectAsync</summary>
        public async Task UpdateTargetProjectRequestObjectAsync()
        {
            // Snippet: UpdateTargetProjectAsync(UpdateTargetProjectRequest, CallSettings)
            // Additional: UpdateTargetProjectAsync(UpdateTargetProjectRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTargetProjectRequest request = new UpdateTargetProjectRequest
            {
                UpdateMask = new FieldMask(),
                TargetProject = new TargetProject(),
                RequestId = "",
            };
            // Make the request
            Operation<TargetProject, OperationMetadata> response = await vmMigrationClient.UpdateTargetProjectAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TargetProject, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TargetProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetProject, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceUpdateTargetProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetProject retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTargetProject</summary>
        public void UpdateTargetProject()
        {
            // Snippet: UpdateTargetProject(TargetProject, FieldMask, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            TargetProject targetProject = new TargetProject();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<TargetProject, OperationMetadata> response = vmMigrationClient.UpdateTargetProject(targetProject, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<TargetProject, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TargetProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetProject, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceUpdateTargetProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetProject retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTargetProjectAsync</summary>
        public async Task UpdateTargetProjectAsync()
        {
            // Snippet: UpdateTargetProjectAsync(TargetProject, FieldMask, CallSettings)
            // Additional: UpdateTargetProjectAsync(TargetProject, FieldMask, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            TargetProject targetProject = new TargetProject();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<TargetProject, OperationMetadata> response = await vmMigrationClient.UpdateTargetProjectAsync(targetProject, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<TargetProject, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TargetProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetProject, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceUpdateTargetProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetProject retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetProject</summary>
        public void DeleteTargetProjectRequestObject()
        {
            // Snippet: DeleteTargetProject(DeleteTargetProjectRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            DeleteTargetProjectRequest request = new DeleteTargetProjectRequest
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteTargetProject(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteTargetProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetProjectAsync</summary>
        public async Task DeleteTargetProjectRequestObjectAsync()
        {
            // Snippet: DeleteTargetProjectAsync(DeleteTargetProjectRequest, CallSettings)
            // Additional: DeleteTargetProjectAsync(DeleteTargetProjectRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTargetProjectRequest request = new DeleteTargetProjectRequest
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteTargetProjectAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteTargetProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetProject</summary>
        public void DeleteTargetProject()
        {
            // Snippet: DeleteTargetProject(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/targetProjects/[TARGET_PROJECT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteTargetProject(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteTargetProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetProjectAsync</summary>
        public async Task DeleteTargetProjectAsync()
        {
            // Snippet: DeleteTargetProjectAsync(string, CallSettings)
            // Additional: DeleteTargetProjectAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/targetProjects/[TARGET_PROJECT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteTargetProjectAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteTargetProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetProject</summary>
        public void DeleteTargetProjectResourceNames()
        {
            // Snippet: DeleteTargetProject(TargetProjectName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            TargetProjectName name = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmMigrationClient.DeleteTargetProject(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceDeleteTargetProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetProjectAsync</summary>
        public async Task DeleteTargetProjectResourceNamesAsync()
        {
            // Snippet: DeleteTargetProjectAsync(TargetProjectName, CallSettings)
            // Additional: DeleteTargetProjectAsync(TargetProjectName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            TargetProjectName name = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmMigrationClient.DeleteTargetProjectAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceDeleteTargetProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListReplicationCycles</summary>
        public void ListReplicationCyclesRequestObject()
        {
            // Snippet: ListReplicationCycles(ListReplicationCyclesRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            ListReplicationCyclesRequest request = new ListReplicationCyclesRequest
            {
                ParentAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListReplicationCyclesResponse, ReplicationCycle> response = vmMigrationClient.ListReplicationCycles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReplicationCycle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReplicationCyclesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReplicationCycle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReplicationCycle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReplicationCycle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplicationCyclesAsync</summary>
        public async Task ListReplicationCyclesRequestObjectAsync()
        {
            // Snippet: ListReplicationCyclesAsync(ListReplicationCyclesRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            ListReplicationCyclesRequest request = new ListReplicationCyclesRequest
            {
                ParentAsMigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListReplicationCyclesResponse, ReplicationCycle> response = vmMigrationClient.ListReplicationCyclesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReplicationCycle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReplicationCyclesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReplicationCycle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReplicationCycle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReplicationCycle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplicationCycles</summary>
        public void ListReplicationCycles()
        {
            // Snippet: ListReplicationCycles(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            PagedEnumerable<ListReplicationCyclesResponse, ReplicationCycle> response = vmMigrationClient.ListReplicationCycles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReplicationCycle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReplicationCyclesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReplicationCycle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReplicationCycle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReplicationCycle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplicationCyclesAsync</summary>
        public async Task ListReplicationCyclesAsync()
        {
            // Snippet: ListReplicationCyclesAsync(string, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            PagedAsyncEnumerable<ListReplicationCyclesResponse, ReplicationCycle> response = vmMigrationClient.ListReplicationCyclesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReplicationCycle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReplicationCyclesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReplicationCycle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReplicationCycle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReplicationCycle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplicationCycles</summary>
        public void ListReplicationCyclesResourceNames()
        {
            // Snippet: ListReplicationCycles(MigratingVmName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            MigratingVmName parent = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            // Make the request
            PagedEnumerable<ListReplicationCyclesResponse, ReplicationCycle> response = vmMigrationClient.ListReplicationCycles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReplicationCycle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReplicationCyclesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReplicationCycle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReplicationCycle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReplicationCycle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplicationCyclesAsync</summary>
        public async Task ListReplicationCyclesResourceNamesAsync()
        {
            // Snippet: ListReplicationCyclesAsync(MigratingVmName, string, int?, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            MigratingVmName parent = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]");
            // Make the request
            PagedAsyncEnumerable<ListReplicationCyclesResponse, ReplicationCycle> response = vmMigrationClient.ListReplicationCyclesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReplicationCycle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReplicationCyclesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReplicationCycle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReplicationCycle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReplicationCycle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetReplicationCycle</summary>
        public void GetReplicationCycleRequestObject()
        {
            // Snippet: GetReplicationCycle(GetReplicationCycleRequest, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            GetReplicationCycleRequest request = new GetReplicationCycleRequest
            {
                ReplicationCycleName = ReplicationCycleName.FromProjectLocationSourceMigratingVmReplicationCycle("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[REPLICATION_CYCLE]"),
            };
            // Make the request
            ReplicationCycle response = vmMigrationClient.GetReplicationCycle(request);
            // End snippet
        }

        /// <summary>Snippet for GetReplicationCycleAsync</summary>
        public async Task GetReplicationCycleRequestObjectAsync()
        {
            // Snippet: GetReplicationCycleAsync(GetReplicationCycleRequest, CallSettings)
            // Additional: GetReplicationCycleAsync(GetReplicationCycleRequest, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            GetReplicationCycleRequest request = new GetReplicationCycleRequest
            {
                ReplicationCycleName = ReplicationCycleName.FromProjectLocationSourceMigratingVmReplicationCycle("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[REPLICATION_CYCLE]"),
            };
            // Make the request
            ReplicationCycle response = await vmMigrationClient.GetReplicationCycleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReplicationCycle</summary>
        public void GetReplicationCycle()
        {
            // Snippet: GetReplicationCycle(string, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]/replicationCycles/[REPLICATION_CYCLE]";
            // Make the request
            ReplicationCycle response = vmMigrationClient.GetReplicationCycle(name);
            // End snippet
        }

        /// <summary>Snippet for GetReplicationCycleAsync</summary>
        public async Task GetReplicationCycleAsync()
        {
            // Snippet: GetReplicationCycleAsync(string, CallSettings)
            // Additional: GetReplicationCycleAsync(string, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]/replicationCycles/[REPLICATION_CYCLE]";
            // Make the request
            ReplicationCycle response = await vmMigrationClient.GetReplicationCycleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReplicationCycle</summary>
        public void GetReplicationCycleResourceNames()
        {
            // Snippet: GetReplicationCycle(ReplicationCycleName, CallSettings)
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            ReplicationCycleName name = ReplicationCycleName.FromProjectLocationSourceMigratingVmReplicationCycle("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[REPLICATION_CYCLE]");
            // Make the request
            ReplicationCycle response = vmMigrationClient.GetReplicationCycle(name);
            // End snippet
        }

        /// <summary>Snippet for GetReplicationCycleAsync</summary>
        public async Task GetReplicationCycleResourceNamesAsync()
        {
            // Snippet: GetReplicationCycleAsync(ReplicationCycleName, CallSettings)
            // Additional: GetReplicationCycleAsync(ReplicationCycleName, CancellationToken)
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            ReplicationCycleName name = ReplicationCycleName.FromProjectLocationSourceMigratingVmReplicationCycle("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[REPLICATION_CYCLE]");
            // Make the request
            ReplicationCycle response = await vmMigrationClient.GetReplicationCycleAsync(name);
            // End snippet
        }
    }
}
