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
    using Google.Cloud.BigQuery.Migration.V2;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMigrationServiceClientSnippets
    {
        /// <summary>Snippet for CreateMigrationWorkflow</summary>
        public void CreateMigrationWorkflowRequestObject()
        {
            // Snippet: CreateMigrationWorkflow(CreateMigrationWorkflowRequest, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            CreateMigrationWorkflowRequest request = new CreateMigrationWorkflowRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MigrationWorkflow = new MigrationWorkflow(),
            };
            // Make the request
            MigrationWorkflow response = migrationServiceClient.CreateMigrationWorkflow(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMigrationWorkflowAsync</summary>
        public async Task CreateMigrationWorkflowRequestObjectAsync()
        {
            // Snippet: CreateMigrationWorkflowAsync(CreateMigrationWorkflowRequest, CallSettings)
            // Additional: CreateMigrationWorkflowAsync(CreateMigrationWorkflowRequest, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMigrationWorkflowRequest request = new CreateMigrationWorkflowRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MigrationWorkflow = new MigrationWorkflow(),
            };
            // Make the request
            MigrationWorkflow response = await migrationServiceClient.CreateMigrationWorkflowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMigrationWorkflow</summary>
        public void CreateMigrationWorkflow()
        {
            // Snippet: CreateMigrationWorkflow(string, MigrationWorkflow, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MigrationWorkflow migrationWorkflow = new MigrationWorkflow();
            // Make the request
            MigrationWorkflow response = migrationServiceClient.CreateMigrationWorkflow(parent, migrationWorkflow);
            // End snippet
        }

        /// <summary>Snippet for CreateMigrationWorkflowAsync</summary>
        public async Task CreateMigrationWorkflowAsync()
        {
            // Snippet: CreateMigrationWorkflowAsync(string, MigrationWorkflow, CallSettings)
            // Additional: CreateMigrationWorkflowAsync(string, MigrationWorkflow, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MigrationWorkflow migrationWorkflow = new MigrationWorkflow();
            // Make the request
            MigrationWorkflow response = await migrationServiceClient.CreateMigrationWorkflowAsync(parent, migrationWorkflow);
            // End snippet
        }

        /// <summary>Snippet for CreateMigrationWorkflow</summary>
        public void CreateMigrationWorkflowResourceNames()
        {
            // Snippet: CreateMigrationWorkflow(LocationName, MigrationWorkflow, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MigrationWorkflow migrationWorkflow = new MigrationWorkflow();
            // Make the request
            MigrationWorkflow response = migrationServiceClient.CreateMigrationWorkflow(parent, migrationWorkflow);
            // End snippet
        }

        /// <summary>Snippet for CreateMigrationWorkflowAsync</summary>
        public async Task CreateMigrationWorkflowResourceNamesAsync()
        {
            // Snippet: CreateMigrationWorkflowAsync(LocationName, MigrationWorkflow, CallSettings)
            // Additional: CreateMigrationWorkflowAsync(LocationName, MigrationWorkflow, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MigrationWorkflow migrationWorkflow = new MigrationWorkflow();
            // Make the request
            MigrationWorkflow response = await migrationServiceClient.CreateMigrationWorkflowAsync(parent, migrationWorkflow);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationWorkflow</summary>
        public void GetMigrationWorkflowRequestObject()
        {
            // Snippet: GetMigrationWorkflow(GetMigrationWorkflowRequest, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            GetMigrationWorkflowRequest request = new GetMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            MigrationWorkflow response = migrationServiceClient.GetMigrationWorkflow(request);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationWorkflowAsync</summary>
        public async Task GetMigrationWorkflowRequestObjectAsync()
        {
            // Snippet: GetMigrationWorkflowAsync(GetMigrationWorkflowRequest, CallSettings)
            // Additional: GetMigrationWorkflowAsync(GetMigrationWorkflowRequest, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMigrationWorkflowRequest request = new GetMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            MigrationWorkflow response = await migrationServiceClient.GetMigrationWorkflowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationWorkflow</summary>
        public void GetMigrationWorkflow()
        {
            // Snippet: GetMigrationWorkflow(string, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            // Make the request
            MigrationWorkflow response = migrationServiceClient.GetMigrationWorkflow(name);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationWorkflowAsync</summary>
        public async Task GetMigrationWorkflowAsync()
        {
            // Snippet: GetMigrationWorkflowAsync(string, CallSettings)
            // Additional: GetMigrationWorkflowAsync(string, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            // Make the request
            MigrationWorkflow response = await migrationServiceClient.GetMigrationWorkflowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationWorkflow</summary>
        public void GetMigrationWorkflowResourceNames()
        {
            // Snippet: GetMigrationWorkflow(MigrationWorkflowName, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            MigrationWorkflowName name = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            // Make the request
            MigrationWorkflow response = migrationServiceClient.GetMigrationWorkflow(name);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationWorkflowAsync</summary>
        public async Task GetMigrationWorkflowResourceNamesAsync()
        {
            // Snippet: GetMigrationWorkflowAsync(MigrationWorkflowName, CallSettings)
            // Additional: GetMigrationWorkflowAsync(MigrationWorkflowName, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            MigrationWorkflowName name = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            // Make the request
            MigrationWorkflow response = await migrationServiceClient.GetMigrationWorkflowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMigrationWorkflows</summary>
        public void ListMigrationWorkflowsRequestObject()
        {
            // Snippet: ListMigrationWorkflows(ListMigrationWorkflowsRequest, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            ListMigrationWorkflowsRequest request = new ListMigrationWorkflowsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListMigrationWorkflowsResponse, MigrationWorkflow> response = migrationServiceClient.ListMigrationWorkflows(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigrationWorkflow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMigrationWorkflowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationWorkflow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationWorkflow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationWorkflow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationWorkflowsAsync</summary>
        public async Task ListMigrationWorkflowsRequestObjectAsync()
        {
            // Snippet: ListMigrationWorkflowsAsync(ListMigrationWorkflowsRequest, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMigrationWorkflowsRequest request = new ListMigrationWorkflowsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListMigrationWorkflowsResponse, MigrationWorkflow> response = migrationServiceClient.ListMigrationWorkflowsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigrationWorkflow item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMigrationWorkflowsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationWorkflow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationWorkflow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationWorkflow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationWorkflows</summary>
        public void ListMigrationWorkflows()
        {
            // Snippet: ListMigrationWorkflows(string, string, int?, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMigrationWorkflowsResponse, MigrationWorkflow> response = migrationServiceClient.ListMigrationWorkflows(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigrationWorkflow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMigrationWorkflowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationWorkflow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationWorkflow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationWorkflow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationWorkflowsAsync</summary>
        public async Task ListMigrationWorkflowsAsync()
        {
            // Snippet: ListMigrationWorkflowsAsync(string, string, int?, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMigrationWorkflowsResponse, MigrationWorkflow> response = migrationServiceClient.ListMigrationWorkflowsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigrationWorkflow item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMigrationWorkflowsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationWorkflow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationWorkflow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationWorkflow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationWorkflows</summary>
        public void ListMigrationWorkflowsResourceNames()
        {
            // Snippet: ListMigrationWorkflows(LocationName, string, int?, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMigrationWorkflowsResponse, MigrationWorkflow> response = migrationServiceClient.ListMigrationWorkflows(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigrationWorkflow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMigrationWorkflowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationWorkflow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationWorkflow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationWorkflow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationWorkflowsAsync</summary>
        public async Task ListMigrationWorkflowsResourceNamesAsync()
        {
            // Snippet: ListMigrationWorkflowsAsync(LocationName, string, int?, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMigrationWorkflowsResponse, MigrationWorkflow> response = migrationServiceClient.ListMigrationWorkflowsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigrationWorkflow item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMigrationWorkflowsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationWorkflow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationWorkflow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationWorkflow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteMigrationWorkflow</summary>
        public void DeleteMigrationWorkflowRequestObject()
        {
            // Snippet: DeleteMigrationWorkflow(DeleteMigrationWorkflowRequest, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            DeleteMigrationWorkflowRequest request = new DeleteMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            // Make the request
            migrationServiceClient.DeleteMigrationWorkflow(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMigrationWorkflowAsync</summary>
        public async Task DeleteMigrationWorkflowRequestObjectAsync()
        {
            // Snippet: DeleteMigrationWorkflowAsync(DeleteMigrationWorkflowRequest, CallSettings)
            // Additional: DeleteMigrationWorkflowAsync(DeleteMigrationWorkflowRequest, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMigrationWorkflowRequest request = new DeleteMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            // Make the request
            await migrationServiceClient.DeleteMigrationWorkflowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMigrationWorkflow</summary>
        public void DeleteMigrationWorkflow()
        {
            // Snippet: DeleteMigrationWorkflow(string, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            // Make the request
            migrationServiceClient.DeleteMigrationWorkflow(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMigrationWorkflowAsync</summary>
        public async Task DeleteMigrationWorkflowAsync()
        {
            // Snippet: DeleteMigrationWorkflowAsync(string, CallSettings)
            // Additional: DeleteMigrationWorkflowAsync(string, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            // Make the request
            await migrationServiceClient.DeleteMigrationWorkflowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMigrationWorkflow</summary>
        public void DeleteMigrationWorkflowResourceNames()
        {
            // Snippet: DeleteMigrationWorkflow(MigrationWorkflowName, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            MigrationWorkflowName name = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            // Make the request
            migrationServiceClient.DeleteMigrationWorkflow(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMigrationWorkflowAsync</summary>
        public async Task DeleteMigrationWorkflowResourceNamesAsync()
        {
            // Snippet: DeleteMigrationWorkflowAsync(MigrationWorkflowName, CallSettings)
            // Additional: DeleteMigrationWorkflowAsync(MigrationWorkflowName, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            MigrationWorkflowName name = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            // Make the request
            await migrationServiceClient.DeleteMigrationWorkflowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for StartMigrationWorkflow</summary>
        public void StartMigrationWorkflowRequestObject()
        {
            // Snippet: StartMigrationWorkflow(StartMigrationWorkflowRequest, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            StartMigrationWorkflowRequest request = new StartMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            // Make the request
            migrationServiceClient.StartMigrationWorkflow(request);
            // End snippet
        }

        /// <summary>Snippet for StartMigrationWorkflowAsync</summary>
        public async Task StartMigrationWorkflowRequestObjectAsync()
        {
            // Snippet: StartMigrationWorkflowAsync(StartMigrationWorkflowRequest, CallSettings)
            // Additional: StartMigrationWorkflowAsync(StartMigrationWorkflowRequest, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartMigrationWorkflowRequest request = new StartMigrationWorkflowRequest
            {
                MigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            // Make the request
            await migrationServiceClient.StartMigrationWorkflowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartMigrationWorkflow</summary>
        public void StartMigrationWorkflow()
        {
            // Snippet: StartMigrationWorkflow(string, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            // Make the request
            migrationServiceClient.StartMigrationWorkflow(name);
            // End snippet
        }

        /// <summary>Snippet for StartMigrationWorkflowAsync</summary>
        public async Task StartMigrationWorkflowAsync()
        {
            // Snippet: StartMigrationWorkflowAsync(string, CallSettings)
            // Additional: StartMigrationWorkflowAsync(string, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            // Make the request
            await migrationServiceClient.StartMigrationWorkflowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for StartMigrationWorkflow</summary>
        public void StartMigrationWorkflowResourceNames()
        {
            // Snippet: StartMigrationWorkflow(MigrationWorkflowName, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            MigrationWorkflowName name = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            // Make the request
            migrationServiceClient.StartMigrationWorkflow(name);
            // End snippet
        }

        /// <summary>Snippet for StartMigrationWorkflowAsync</summary>
        public async Task StartMigrationWorkflowResourceNamesAsync()
        {
            // Snippet: StartMigrationWorkflowAsync(MigrationWorkflowName, CallSettings)
            // Additional: StartMigrationWorkflowAsync(MigrationWorkflowName, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            MigrationWorkflowName name = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            // Make the request
            await migrationServiceClient.StartMigrationWorkflowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationSubtask</summary>
        public void GetMigrationSubtaskRequestObject()
        {
            // Snippet: GetMigrationSubtask(GetMigrationSubtaskRequest, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            GetMigrationSubtaskRequest request = new GetMigrationSubtaskRequest
            {
                MigrationSubtaskName = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            MigrationSubtask response = migrationServiceClient.GetMigrationSubtask(request);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationSubtaskAsync</summary>
        public async Task GetMigrationSubtaskRequestObjectAsync()
        {
            // Snippet: GetMigrationSubtaskAsync(GetMigrationSubtaskRequest, CallSettings)
            // Additional: GetMigrationSubtaskAsync(GetMigrationSubtaskRequest, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMigrationSubtaskRequest request = new GetMigrationSubtaskRequest
            {
                MigrationSubtaskName = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            MigrationSubtask response = await migrationServiceClient.GetMigrationSubtaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationSubtask</summary>
        public void GetMigrationSubtask()
        {
            // Snippet: GetMigrationSubtask(string, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]/subtasks/[SUBTASK]";
            // Make the request
            MigrationSubtask response = migrationServiceClient.GetMigrationSubtask(name);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationSubtaskAsync</summary>
        public async Task GetMigrationSubtaskAsync()
        {
            // Snippet: GetMigrationSubtaskAsync(string, CallSettings)
            // Additional: GetMigrationSubtaskAsync(string, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]/subtasks/[SUBTASK]";
            // Make the request
            MigrationSubtask response = await migrationServiceClient.GetMigrationSubtaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationSubtask</summary>
        public void GetMigrationSubtaskResourceNames()
        {
            // Snippet: GetMigrationSubtask(MigrationSubtaskName, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            MigrationSubtaskName name = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]");
            // Make the request
            MigrationSubtask response = migrationServiceClient.GetMigrationSubtask(name);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationSubtaskAsync</summary>
        public async Task GetMigrationSubtaskResourceNamesAsync()
        {
            // Snippet: GetMigrationSubtaskAsync(MigrationSubtaskName, CallSettings)
            // Additional: GetMigrationSubtaskAsync(MigrationSubtaskName, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            MigrationSubtaskName name = MigrationSubtaskName.FromProjectLocationWorkflowSubtask("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[SUBTASK]");
            // Make the request
            MigrationSubtask response = await migrationServiceClient.GetMigrationSubtaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMigrationSubtasks</summary>
        public void ListMigrationSubtasksRequestObject()
        {
            // Snippet: ListMigrationSubtasks(ListMigrationSubtasksRequest, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            ListMigrationSubtasksRequest request = new ListMigrationSubtasksRequest
            {
                ParentAsMigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                ReadMask = new FieldMask(),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListMigrationSubtasksResponse, MigrationSubtask> response = migrationServiceClient.ListMigrationSubtasks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigrationSubtask item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMigrationSubtasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationSubtask item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationSubtask> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationSubtask item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationSubtasksAsync</summary>
        public async Task ListMigrationSubtasksRequestObjectAsync()
        {
            // Snippet: ListMigrationSubtasksAsync(ListMigrationSubtasksRequest, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMigrationSubtasksRequest request = new ListMigrationSubtasksRequest
            {
                ParentAsMigrationWorkflowName = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                ReadMask = new FieldMask(),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMigrationSubtasksResponse, MigrationSubtask> response = migrationServiceClient.ListMigrationSubtasksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigrationSubtask item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMigrationSubtasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationSubtask item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationSubtask> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationSubtask item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationSubtasks</summary>
        public void ListMigrationSubtasks()
        {
            // Snippet: ListMigrationSubtasks(string, string, int?, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            // Make the request
            PagedEnumerable<ListMigrationSubtasksResponse, MigrationSubtask> response = migrationServiceClient.ListMigrationSubtasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigrationSubtask item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMigrationSubtasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationSubtask item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationSubtask> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationSubtask item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationSubtasksAsync</summary>
        public async Task ListMigrationSubtasksAsync()
        {
            // Snippet: ListMigrationSubtasksAsync(string, string, int?, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            // Make the request
            PagedAsyncEnumerable<ListMigrationSubtasksResponse, MigrationSubtask> response = migrationServiceClient.ListMigrationSubtasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigrationSubtask item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMigrationSubtasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationSubtask item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationSubtask> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationSubtask item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationSubtasks</summary>
        public void ListMigrationSubtasksResourceNames()
        {
            // Snippet: ListMigrationSubtasks(MigrationWorkflowName, string, int?, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            MigrationWorkflowName parent = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            // Make the request
            PagedEnumerable<ListMigrationSubtasksResponse, MigrationSubtask> response = migrationServiceClient.ListMigrationSubtasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigrationSubtask item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMigrationSubtasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationSubtask item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationSubtask> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationSubtask item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationSubtasksAsync</summary>
        public async Task ListMigrationSubtasksResourceNamesAsync()
        {
            // Snippet: ListMigrationSubtasksAsync(MigrationWorkflowName, string, int?, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            MigrationWorkflowName parent = MigrationWorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            // Make the request
            PagedAsyncEnumerable<ListMigrationSubtasksResponse, MigrationSubtask> response = migrationServiceClient.ListMigrationSubtasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigrationSubtask item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMigrationSubtasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationSubtask item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationSubtask> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationSubtask item in singlePage)
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
