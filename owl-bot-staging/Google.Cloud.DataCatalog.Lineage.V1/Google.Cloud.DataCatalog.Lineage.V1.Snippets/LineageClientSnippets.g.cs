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
    using Google.Cloud.DataCatalog.Lineage.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLineageClientSnippets
    {
        /// <summary>Snippet for ProcessOpenLineageRunEvent</summary>
        public void ProcessOpenLineageRunEventRequestObject()
        {
            // Snippet: ProcessOpenLineageRunEvent(ProcessOpenLineageRunEventRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            ProcessOpenLineageRunEventRequest request = new ProcessOpenLineageRunEventRequest
            {
                Parent = "",
                OpenLineage = new Struct(),
                RequestId = "",
            };
            // Make the request
            ProcessOpenLineageRunEventResponse response = lineageClient.ProcessOpenLineageRunEvent(request);
            // End snippet
        }

        /// <summary>Snippet for ProcessOpenLineageRunEventAsync</summary>
        public async Task ProcessOpenLineageRunEventRequestObjectAsync()
        {
            // Snippet: ProcessOpenLineageRunEventAsync(ProcessOpenLineageRunEventRequest, CallSettings)
            // Additional: ProcessOpenLineageRunEventAsync(ProcessOpenLineageRunEventRequest, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            ProcessOpenLineageRunEventRequest request = new ProcessOpenLineageRunEventRequest
            {
                Parent = "",
                OpenLineage = new Struct(),
                RequestId = "",
            };
            // Make the request
            ProcessOpenLineageRunEventResponse response = await lineageClient.ProcessOpenLineageRunEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ProcessOpenLineageRunEvent</summary>
        public void ProcessOpenLineageRunEvent()
        {
            // Snippet: ProcessOpenLineageRunEvent(string, Struct, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            string parent = "";
            Struct openLineage = new Struct();
            // Make the request
            ProcessOpenLineageRunEventResponse response = lineageClient.ProcessOpenLineageRunEvent(parent, openLineage);
            // End snippet
        }

        /// <summary>Snippet for ProcessOpenLineageRunEventAsync</summary>
        public async Task ProcessOpenLineageRunEventAsync()
        {
            // Snippet: ProcessOpenLineageRunEventAsync(string, Struct, CallSettings)
            // Additional: ProcessOpenLineageRunEventAsync(string, Struct, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            Struct openLineage = new Struct();
            // Make the request
            ProcessOpenLineageRunEventResponse response = await lineageClient.ProcessOpenLineageRunEventAsync(parent, openLineage);
            // End snippet
        }

        /// <summary>Snippet for CreateProcess</summary>
        public void CreateProcessRequestObject()
        {
            // Snippet: CreateProcess(CreateProcessRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            CreateProcessRequest request = new CreateProcessRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Process = new Process(),
                RequestId = "",
            };
            // Make the request
            Process response = lineageClient.CreateProcess(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessAsync</summary>
        public async Task CreateProcessRequestObjectAsync()
        {
            // Snippet: CreateProcessAsync(CreateProcessRequest, CallSettings)
            // Additional: CreateProcessAsync(CreateProcessRequest, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            CreateProcessRequest request = new CreateProcessRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Process = new Process(),
                RequestId = "",
            };
            // Make the request
            Process response = await lineageClient.CreateProcessAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProcess</summary>
        public void CreateProcess()
        {
            // Snippet: CreateProcess(string, Process, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Process process = new Process();
            // Make the request
            Process response = lineageClient.CreateProcess(parent, process);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessAsync</summary>
        public async Task CreateProcessAsync()
        {
            // Snippet: CreateProcessAsync(string, Process, CallSettings)
            // Additional: CreateProcessAsync(string, Process, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Process process = new Process();
            // Make the request
            Process response = await lineageClient.CreateProcessAsync(parent, process);
            // End snippet
        }

        /// <summary>Snippet for CreateProcess</summary>
        public void CreateProcessResourceNames()
        {
            // Snippet: CreateProcess(LocationName, Process, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Process process = new Process();
            // Make the request
            Process response = lineageClient.CreateProcess(parent, process);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessAsync</summary>
        public async Task CreateProcessResourceNamesAsync()
        {
            // Snippet: CreateProcessAsync(LocationName, Process, CallSettings)
            // Additional: CreateProcessAsync(LocationName, Process, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Process process = new Process();
            // Make the request
            Process response = await lineageClient.CreateProcessAsync(parent, process);
            // End snippet
        }

        /// <summary>Snippet for UpdateProcess</summary>
        public void UpdateProcessRequestObject()
        {
            // Snippet: UpdateProcess(UpdateProcessRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            UpdateProcessRequest request = new UpdateProcessRequest
            {
                Process = new Process(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            Process response = lineageClient.UpdateProcess(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProcessAsync</summary>
        public async Task UpdateProcessRequestObjectAsync()
        {
            // Snippet: UpdateProcessAsync(UpdateProcessRequest, CallSettings)
            // Additional: UpdateProcessAsync(UpdateProcessRequest, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProcessRequest request = new UpdateProcessRequest
            {
                Process = new Process(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            Process response = await lineageClient.UpdateProcessAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProcess</summary>
        public void UpdateProcess()
        {
            // Snippet: UpdateProcess(Process, FieldMask, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            Process process = new Process();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Process response = lineageClient.UpdateProcess(process, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProcessAsync</summary>
        public async Task UpdateProcessAsync()
        {
            // Snippet: UpdateProcessAsync(Process, FieldMask, CallSettings)
            // Additional: UpdateProcessAsync(Process, FieldMask, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            Process process = new Process();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Process response = await lineageClient.UpdateProcessAsync(process, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetProcess</summary>
        public void GetProcessRequestObject()
        {
            // Snippet: GetProcess(GetProcessRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            GetProcessRequest request = new GetProcessRequest
            {
                ProcessName = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]"),
            };
            // Make the request
            Process response = lineageClient.GetProcess(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessAsync</summary>
        public async Task GetProcessRequestObjectAsync()
        {
            // Snippet: GetProcessAsync(GetProcessRequest, CallSettings)
            // Additional: GetProcessAsync(GetProcessRequest, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            GetProcessRequest request = new GetProcessRequest
            {
                ProcessName = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]"),
            };
            // Make the request
            Process response = await lineageClient.GetProcessAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcess</summary>
        public void GetProcess()
        {
            // Snippet: GetProcess(string, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]";
            // Make the request
            Process response = lineageClient.GetProcess(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessAsync</summary>
        public async Task GetProcessAsync()
        {
            // Snippet: GetProcessAsync(string, CallSettings)
            // Additional: GetProcessAsync(string, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]";
            // Make the request
            Process response = await lineageClient.GetProcessAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcess</summary>
        public void GetProcessResourceNames()
        {
            // Snippet: GetProcess(ProcessName, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            ProcessName name = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]");
            // Make the request
            Process response = lineageClient.GetProcess(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessAsync</summary>
        public async Task GetProcessResourceNamesAsync()
        {
            // Snippet: GetProcessAsync(ProcessName, CallSettings)
            // Additional: GetProcessAsync(ProcessName, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            ProcessName name = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]");
            // Make the request
            Process response = await lineageClient.GetProcessAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProcesses</summary>
        public void ListProcessesRequestObject()
        {
            // Snippet: ListProcesses(ListProcessesRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            ListProcessesRequest request = new ListProcessesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListProcessesResponse, Process> response = lineageClient.ListProcesses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Process item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Process item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Process> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Process item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessesAsync</summary>
        public async Task ListProcessesRequestObjectAsync()
        {
            // Snippet: ListProcessesAsync(ListProcessesRequest, CallSettings)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            ListProcessesRequest request = new ListProcessesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListProcessesResponse, Process> response = lineageClient.ListProcessesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Process item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Process item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Process> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Process item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcesses</summary>
        public void ListProcesses()
        {
            // Snippet: ListProcesses(string, string, int?, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListProcessesResponse, Process> response = lineageClient.ListProcesses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Process item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Process item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Process> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Process item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessesAsync</summary>
        public async Task ListProcessesAsync()
        {
            // Snippet: ListProcessesAsync(string, string, int?, CallSettings)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListProcessesResponse, Process> response = lineageClient.ListProcessesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Process item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Process item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Process> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Process item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcesses</summary>
        public void ListProcessesResourceNames()
        {
            // Snippet: ListProcesses(LocationName, string, int?, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListProcessesResponse, Process> response = lineageClient.ListProcesses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Process item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Process item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Process> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Process item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessesAsync</summary>
        public async Task ListProcessesResourceNamesAsync()
        {
            // Snippet: ListProcessesAsync(LocationName, string, int?, CallSettings)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListProcessesResponse, Process> response = lineageClient.ListProcessesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Process item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Process item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Process> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Process item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteProcess</summary>
        public void DeleteProcessRequestObject()
        {
            // Snippet: DeleteProcess(DeleteProcessRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            DeleteProcessRequest request = new DeleteProcessRequest
            {
                ProcessName = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]"),
                AllowMissing = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = lineageClient.DeleteProcess(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lineageClient.PollOnceDeleteProcess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessAsync</summary>
        public async Task DeleteProcessRequestObjectAsync()
        {
            // Snippet: DeleteProcessAsync(DeleteProcessRequest, CallSettings)
            // Additional: DeleteProcessAsync(DeleteProcessRequest, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            DeleteProcessRequest request = new DeleteProcessRequest
            {
                ProcessName = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]"),
                AllowMissing = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await lineageClient.DeleteProcessAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lineageClient.PollOnceDeleteProcessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcess</summary>
        public void DeleteProcess()
        {
            // Snippet: DeleteProcess(string, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]";
            // Make the request
            Operation<Empty, OperationMetadata> response = lineageClient.DeleteProcess(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lineageClient.PollOnceDeleteProcess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessAsync</summary>
        public async Task DeleteProcessAsync()
        {
            // Snippet: DeleteProcessAsync(string, CallSettings)
            // Additional: DeleteProcessAsync(string, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await lineageClient.DeleteProcessAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lineageClient.PollOnceDeleteProcessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcess</summary>
        public void DeleteProcessResourceNames()
        {
            // Snippet: DeleteProcess(ProcessName, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            ProcessName name = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]");
            // Make the request
            Operation<Empty, OperationMetadata> response = lineageClient.DeleteProcess(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lineageClient.PollOnceDeleteProcess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessAsync</summary>
        public async Task DeleteProcessResourceNamesAsync()
        {
            // Snippet: DeleteProcessAsync(ProcessName, CallSettings)
            // Additional: DeleteProcessAsync(ProcessName, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            ProcessName name = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await lineageClient.DeleteProcessAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lineageClient.PollOnceDeleteProcessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRun</summary>
        public void CreateRunRequestObject()
        {
            // Snippet: CreateRun(CreateRunRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            CreateRunRequest request = new CreateRunRequest
            {
                ParentAsProcessName = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]"),
                Run = new Run(),
                RequestId = "",
            };
            // Make the request
            Run response = lineageClient.CreateRun(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRunAsync</summary>
        public async Task CreateRunRequestObjectAsync()
        {
            // Snippet: CreateRunAsync(CreateRunRequest, CallSettings)
            // Additional: CreateRunAsync(CreateRunRequest, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            CreateRunRequest request = new CreateRunRequest
            {
                ParentAsProcessName = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]"),
                Run = new Run(),
                RequestId = "",
            };
            // Make the request
            Run response = await lineageClient.CreateRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRun</summary>
        public void CreateRun()
        {
            // Snippet: CreateRun(string, Run, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]";
            Run run = new Run();
            // Make the request
            Run response = lineageClient.CreateRun(parent, run);
            // End snippet
        }

        /// <summary>Snippet for CreateRunAsync</summary>
        public async Task CreateRunAsync()
        {
            // Snippet: CreateRunAsync(string, Run, CallSettings)
            // Additional: CreateRunAsync(string, Run, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]";
            Run run = new Run();
            // Make the request
            Run response = await lineageClient.CreateRunAsync(parent, run);
            // End snippet
        }

        /// <summary>Snippet for CreateRun</summary>
        public void CreateRunResourceNames()
        {
            // Snippet: CreateRun(ProcessName, Run, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            ProcessName parent = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]");
            Run run = new Run();
            // Make the request
            Run response = lineageClient.CreateRun(parent, run);
            // End snippet
        }

        /// <summary>Snippet for CreateRunAsync</summary>
        public async Task CreateRunResourceNamesAsync()
        {
            // Snippet: CreateRunAsync(ProcessName, Run, CallSettings)
            // Additional: CreateRunAsync(ProcessName, Run, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            ProcessName parent = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]");
            Run run = new Run();
            // Make the request
            Run response = await lineageClient.CreateRunAsync(parent, run);
            // End snippet
        }

        /// <summary>Snippet for UpdateRun</summary>
        public void UpdateRunRequestObject()
        {
            // Snippet: UpdateRun(UpdateRunRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            UpdateRunRequest request = new UpdateRunRequest
            {
                Run = new Run(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            Run response = lineageClient.UpdateRun(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRunAsync</summary>
        public async Task UpdateRunRequestObjectAsync()
        {
            // Snippet: UpdateRunAsync(UpdateRunRequest, CallSettings)
            // Additional: UpdateRunAsync(UpdateRunRequest, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRunRequest request = new UpdateRunRequest
            {
                Run = new Run(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            Run response = await lineageClient.UpdateRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRun</summary>
        public void UpdateRun()
        {
            // Snippet: UpdateRun(Run, FieldMask, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            Run run = new Run();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Run response = lineageClient.UpdateRun(run, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateRunAsync</summary>
        public async Task UpdateRunAsync()
        {
            // Snippet: UpdateRunAsync(Run, FieldMask, CallSettings)
            // Additional: UpdateRunAsync(Run, FieldMask, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            Run run = new Run();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Run response = await lineageClient.UpdateRunAsync(run, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetRun</summary>
        public void GetRunRequestObject()
        {
            // Snippet: GetRun(GetRunRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            GetRunRequest request = new GetRunRequest
            {
                RunName = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]"),
            };
            // Make the request
            Run response = lineageClient.GetRun(request);
            // End snippet
        }

        /// <summary>Snippet for GetRunAsync</summary>
        public async Task GetRunRequestObjectAsync()
        {
            // Snippet: GetRunAsync(GetRunRequest, CallSettings)
            // Additional: GetRunAsync(GetRunRequest, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            GetRunRequest request = new GetRunRequest
            {
                RunName = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]"),
            };
            // Make the request
            Run response = await lineageClient.GetRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRun</summary>
        public void GetRun()
        {
            // Snippet: GetRun(string, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]/runs/[RUN]";
            // Make the request
            Run response = lineageClient.GetRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetRunAsync</summary>
        public async Task GetRunAsync()
        {
            // Snippet: GetRunAsync(string, CallSettings)
            // Additional: GetRunAsync(string, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]/runs/[RUN]";
            // Make the request
            Run response = await lineageClient.GetRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRun</summary>
        public void GetRunResourceNames()
        {
            // Snippet: GetRun(RunName, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            RunName name = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]");
            // Make the request
            Run response = lineageClient.GetRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetRunAsync</summary>
        public async Task GetRunResourceNamesAsync()
        {
            // Snippet: GetRunAsync(RunName, CallSettings)
            // Additional: GetRunAsync(RunName, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            RunName name = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]");
            // Make the request
            Run response = await lineageClient.GetRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRuns</summary>
        public void ListRunsRequestObject()
        {
            // Snippet: ListRuns(ListRunsRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            ListRunsRequest request = new ListRunsRequest
            {
                ParentAsProcessName = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]"),
            };
            // Make the request
            PagedEnumerable<ListRunsResponse, Run> response = lineageClient.ListRuns(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Run item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Run item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Run> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Run item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRunsAsync</summary>
        public async Task ListRunsRequestObjectAsync()
        {
            // Snippet: ListRunsAsync(ListRunsRequest, CallSettings)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            ListRunsRequest request = new ListRunsRequest
            {
                ParentAsProcessName = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRunsResponse, Run> response = lineageClient.ListRunsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Run item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Run item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Run> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Run item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuns</summary>
        public void ListRuns()
        {
            // Snippet: ListRuns(string, string, int?, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]";
            // Make the request
            PagedEnumerable<ListRunsResponse, Run> response = lineageClient.ListRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Run item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Run item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Run> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Run item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRunsAsync</summary>
        public async Task ListRunsAsync()
        {
            // Snippet: ListRunsAsync(string, string, int?, CallSettings)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]";
            // Make the request
            PagedAsyncEnumerable<ListRunsResponse, Run> response = lineageClient.ListRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Run item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Run item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Run> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Run item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuns</summary>
        public void ListRunsResourceNames()
        {
            // Snippet: ListRuns(ProcessName, string, int?, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            ProcessName parent = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]");
            // Make the request
            PagedEnumerable<ListRunsResponse, Run> response = lineageClient.ListRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Run item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Run item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Run> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Run item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRunsAsync</summary>
        public async Task ListRunsResourceNamesAsync()
        {
            // Snippet: ListRunsAsync(ProcessName, string, int?, CallSettings)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            ProcessName parent = ProcessName.FromProjectLocationProcess("[PROJECT]", "[LOCATION]", "[PROCESS]");
            // Make the request
            PagedAsyncEnumerable<ListRunsResponse, Run> response = lineageClient.ListRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Run item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Run item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Run> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Run item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteRun</summary>
        public void DeleteRunRequestObject()
        {
            // Snippet: DeleteRun(DeleteRunRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            DeleteRunRequest request = new DeleteRunRequest
            {
                RunName = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]"),
                AllowMissing = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = lineageClient.DeleteRun(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lineageClient.PollOnceDeleteRun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRunAsync</summary>
        public async Task DeleteRunRequestObjectAsync()
        {
            // Snippet: DeleteRunAsync(DeleteRunRequest, CallSettings)
            // Additional: DeleteRunAsync(DeleteRunRequest, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRunRequest request = new DeleteRunRequest
            {
                RunName = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]"),
                AllowMissing = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await lineageClient.DeleteRunAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lineageClient.PollOnceDeleteRunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRun</summary>
        public void DeleteRun()
        {
            // Snippet: DeleteRun(string, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]/runs/[RUN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = lineageClient.DeleteRun(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lineageClient.PollOnceDeleteRun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRunAsync</summary>
        public async Task DeleteRunAsync()
        {
            // Snippet: DeleteRunAsync(string, CallSettings)
            // Additional: DeleteRunAsync(string, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]/runs/[RUN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await lineageClient.DeleteRunAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lineageClient.PollOnceDeleteRunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRun</summary>
        public void DeleteRunResourceNames()
        {
            // Snippet: DeleteRun(RunName, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            RunName name = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = lineageClient.DeleteRun(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lineageClient.PollOnceDeleteRun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRunAsync</summary>
        public async Task DeleteRunResourceNamesAsync()
        {
            // Snippet: DeleteRunAsync(RunName, CallSettings)
            // Additional: DeleteRunAsync(RunName, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            RunName name = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await lineageClient.DeleteRunAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lineageClient.PollOnceDeleteRunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLineageEvent</summary>
        public void CreateLineageEventRequestObject()
        {
            // Snippet: CreateLineageEvent(CreateLineageEventRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            CreateLineageEventRequest request = new CreateLineageEventRequest
            {
                ParentAsRunName = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]"),
                LineageEvent = new LineageEvent(),
                RequestId = "",
            };
            // Make the request
            LineageEvent response = lineageClient.CreateLineageEvent(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLineageEventAsync</summary>
        public async Task CreateLineageEventRequestObjectAsync()
        {
            // Snippet: CreateLineageEventAsync(CreateLineageEventRequest, CallSettings)
            // Additional: CreateLineageEventAsync(CreateLineageEventRequest, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            CreateLineageEventRequest request = new CreateLineageEventRequest
            {
                ParentAsRunName = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]"),
                LineageEvent = new LineageEvent(),
                RequestId = "",
            };
            // Make the request
            LineageEvent response = await lineageClient.CreateLineageEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLineageEvent</summary>
        public void CreateLineageEvent()
        {
            // Snippet: CreateLineageEvent(string, LineageEvent, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]/runs/[RUN]";
            LineageEvent lineageEvent = new LineageEvent();
            // Make the request
            LineageEvent response = lineageClient.CreateLineageEvent(parent, lineageEvent);
            // End snippet
        }

        /// <summary>Snippet for CreateLineageEventAsync</summary>
        public async Task CreateLineageEventAsync()
        {
            // Snippet: CreateLineageEventAsync(string, LineageEvent, CallSettings)
            // Additional: CreateLineageEventAsync(string, LineageEvent, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]/runs/[RUN]";
            LineageEvent lineageEvent = new LineageEvent();
            // Make the request
            LineageEvent response = await lineageClient.CreateLineageEventAsync(parent, lineageEvent);
            // End snippet
        }

        /// <summary>Snippet for CreateLineageEvent</summary>
        public void CreateLineageEventResourceNames()
        {
            // Snippet: CreateLineageEvent(RunName, LineageEvent, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            RunName parent = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]");
            LineageEvent lineageEvent = new LineageEvent();
            // Make the request
            LineageEvent response = lineageClient.CreateLineageEvent(parent, lineageEvent);
            // End snippet
        }

        /// <summary>Snippet for CreateLineageEventAsync</summary>
        public async Task CreateLineageEventResourceNamesAsync()
        {
            // Snippet: CreateLineageEventAsync(RunName, LineageEvent, CallSettings)
            // Additional: CreateLineageEventAsync(RunName, LineageEvent, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            RunName parent = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]");
            LineageEvent lineageEvent = new LineageEvent();
            // Make the request
            LineageEvent response = await lineageClient.CreateLineageEventAsync(parent, lineageEvent);
            // End snippet
        }

        /// <summary>Snippet for GetLineageEvent</summary>
        public void GetLineageEventRequestObject()
        {
            // Snippet: GetLineageEvent(GetLineageEventRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            GetLineageEventRequest request = new GetLineageEventRequest
            {
                LineageEventName = LineageEventName.FromProjectLocationProcessRunLineageEvent("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]", "[LINEAGE_EVENT]"),
            };
            // Make the request
            LineageEvent response = lineageClient.GetLineageEvent(request);
            // End snippet
        }

        /// <summary>Snippet for GetLineageEventAsync</summary>
        public async Task GetLineageEventRequestObjectAsync()
        {
            // Snippet: GetLineageEventAsync(GetLineageEventRequest, CallSettings)
            // Additional: GetLineageEventAsync(GetLineageEventRequest, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            GetLineageEventRequest request = new GetLineageEventRequest
            {
                LineageEventName = LineageEventName.FromProjectLocationProcessRunLineageEvent("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]", "[LINEAGE_EVENT]"),
            };
            // Make the request
            LineageEvent response = await lineageClient.GetLineageEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLineageEvent</summary>
        public void GetLineageEvent()
        {
            // Snippet: GetLineageEvent(string, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]/runs/[RUN]/lineageEvents/[LINEAGE_EVENT]";
            // Make the request
            LineageEvent response = lineageClient.GetLineageEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetLineageEventAsync</summary>
        public async Task GetLineageEventAsync()
        {
            // Snippet: GetLineageEventAsync(string, CallSettings)
            // Additional: GetLineageEventAsync(string, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]/runs/[RUN]/lineageEvents/[LINEAGE_EVENT]";
            // Make the request
            LineageEvent response = await lineageClient.GetLineageEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLineageEvent</summary>
        public void GetLineageEventResourceNames()
        {
            // Snippet: GetLineageEvent(LineageEventName, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            LineageEventName name = LineageEventName.FromProjectLocationProcessRunLineageEvent("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]", "[LINEAGE_EVENT]");
            // Make the request
            LineageEvent response = lineageClient.GetLineageEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetLineageEventAsync</summary>
        public async Task GetLineageEventResourceNamesAsync()
        {
            // Snippet: GetLineageEventAsync(LineageEventName, CallSettings)
            // Additional: GetLineageEventAsync(LineageEventName, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            LineageEventName name = LineageEventName.FromProjectLocationProcessRunLineageEvent("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]", "[LINEAGE_EVENT]");
            // Make the request
            LineageEvent response = await lineageClient.GetLineageEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLineageEvents</summary>
        public void ListLineageEventsRequestObject()
        {
            // Snippet: ListLineageEvents(ListLineageEventsRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            ListLineageEventsRequest request = new ListLineageEventsRequest
            {
                ParentAsRunName = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]"),
            };
            // Make the request
            PagedEnumerable<ListLineageEventsResponse, LineageEvent> response = lineageClient.ListLineageEvents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LineageEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLineageEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineageEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineageEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineageEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineageEventsAsync</summary>
        public async Task ListLineageEventsRequestObjectAsync()
        {
            // Snippet: ListLineageEventsAsync(ListLineageEventsRequest, CallSettings)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            ListLineageEventsRequest request = new ListLineageEventsRequest
            {
                ParentAsRunName = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListLineageEventsResponse, LineageEvent> response = lineageClient.ListLineageEventsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LineageEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLineageEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineageEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineageEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineageEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineageEvents</summary>
        public void ListLineageEvents()
        {
            // Snippet: ListLineageEvents(string, string, int?, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]/runs/[RUN]";
            // Make the request
            PagedEnumerable<ListLineageEventsResponse, LineageEvent> response = lineageClient.ListLineageEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LineageEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLineageEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineageEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineageEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineageEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineageEventsAsync</summary>
        public async Task ListLineageEventsAsync()
        {
            // Snippet: ListLineageEventsAsync(string, string, int?, CallSettings)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]/runs/[RUN]";
            // Make the request
            PagedAsyncEnumerable<ListLineageEventsResponse, LineageEvent> response = lineageClient.ListLineageEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LineageEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLineageEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineageEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineageEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineageEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineageEvents</summary>
        public void ListLineageEventsResourceNames()
        {
            // Snippet: ListLineageEvents(RunName, string, int?, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            RunName parent = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]");
            // Make the request
            PagedEnumerable<ListLineageEventsResponse, LineageEvent> response = lineageClient.ListLineageEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LineageEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLineageEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineageEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineageEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineageEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineageEventsAsync</summary>
        public async Task ListLineageEventsResourceNamesAsync()
        {
            // Snippet: ListLineageEventsAsync(RunName, string, int?, CallSettings)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            RunName parent = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]");
            // Make the request
            PagedAsyncEnumerable<ListLineageEventsResponse, LineageEvent> response = lineageClient.ListLineageEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LineageEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLineageEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineageEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineageEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineageEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteLineageEvent</summary>
        public void DeleteLineageEventRequestObject()
        {
            // Snippet: DeleteLineageEvent(DeleteLineageEventRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            DeleteLineageEventRequest request = new DeleteLineageEventRequest
            {
                LineageEventName = LineageEventName.FromProjectLocationProcessRunLineageEvent("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]", "[LINEAGE_EVENT]"),
                AllowMissing = false,
            };
            // Make the request
            lineageClient.DeleteLineageEvent(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteLineageEventAsync</summary>
        public async Task DeleteLineageEventRequestObjectAsync()
        {
            // Snippet: DeleteLineageEventAsync(DeleteLineageEventRequest, CallSettings)
            // Additional: DeleteLineageEventAsync(DeleteLineageEventRequest, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            DeleteLineageEventRequest request = new DeleteLineageEventRequest
            {
                LineageEventName = LineageEventName.FromProjectLocationProcessRunLineageEvent("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]", "[LINEAGE_EVENT]"),
                AllowMissing = false,
            };
            // Make the request
            await lineageClient.DeleteLineageEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteLineageEvent</summary>
        public void DeleteLineageEvent()
        {
            // Snippet: DeleteLineageEvent(string, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]/runs/[RUN]/lineageEvents/[LINEAGE_EVENT]";
            // Make the request
            lineageClient.DeleteLineageEvent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteLineageEventAsync</summary>
        public async Task DeleteLineageEventAsync()
        {
            // Snippet: DeleteLineageEventAsync(string, CallSettings)
            // Additional: DeleteLineageEventAsync(string, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processes/[PROCESS]/runs/[RUN]/lineageEvents/[LINEAGE_EVENT]";
            // Make the request
            await lineageClient.DeleteLineageEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteLineageEvent</summary>
        public void DeleteLineageEventResourceNames()
        {
            // Snippet: DeleteLineageEvent(LineageEventName, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            LineageEventName name = LineageEventName.FromProjectLocationProcessRunLineageEvent("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]", "[LINEAGE_EVENT]");
            // Make the request
            lineageClient.DeleteLineageEvent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteLineageEventAsync</summary>
        public async Task DeleteLineageEventResourceNamesAsync()
        {
            // Snippet: DeleteLineageEventAsync(LineageEventName, CallSettings)
            // Additional: DeleteLineageEventAsync(LineageEventName, CancellationToken)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            LineageEventName name = LineageEventName.FromProjectLocationProcessRunLineageEvent("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]", "[LINEAGE_EVENT]");
            // Make the request
            await lineageClient.DeleteLineageEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SearchLinks</summary>
        public void SearchLinksRequestObject()
        {
            // Snippet: SearchLinks(SearchLinksRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            SearchLinksRequest request = new SearchLinksRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Source = new EntityReference(),
            };
            // Make the request
            PagedEnumerable<SearchLinksResponse, Link> response = lineageClient.SearchLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Link item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Link item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Link> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Link item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchLinksAsync</summary>
        public async Task SearchLinksRequestObjectAsync()
        {
            // Snippet: SearchLinksAsync(SearchLinksRequest, CallSettings)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            SearchLinksRequest request = new SearchLinksRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Source = new EntityReference(),
            };
            // Make the request
            PagedAsyncEnumerable<SearchLinksResponse, Link> response = lineageClient.SearchLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Link item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Link item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Link> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Link item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchSearchLinkProcesses</summary>
        public void BatchSearchLinkProcessesRequestObject()
        {
            // Snippet: BatchSearchLinkProcesses(BatchSearchLinkProcessesRequest, CallSettings)
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            BatchSearchLinkProcessesRequest request = new BatchSearchLinkProcessesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Links = { "", },
            };
            // Make the request
            PagedEnumerable<BatchSearchLinkProcessesResponse, ProcessLinks> response = lineageClient.BatchSearchLinkProcesses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProcessLinks item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BatchSearchLinkProcessesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProcessLinks item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProcessLinks> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProcessLinks item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchSearchLinkProcessesAsync</summary>
        public async Task BatchSearchLinkProcessesRequestObjectAsync()
        {
            // Snippet: BatchSearchLinkProcessesAsync(BatchSearchLinkProcessesRequest, CallSettings)
            // Create client
            LineageClient lineageClient = await LineageClient.CreateAsync();
            // Initialize request argument(s)
            BatchSearchLinkProcessesRequest request = new BatchSearchLinkProcessesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Links = { "", },
            };
            // Make the request
            PagedAsyncEnumerable<BatchSearchLinkProcessesResponse, ProcessLinks> response = lineageClient.BatchSearchLinkProcessesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProcessLinks item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((BatchSearchLinkProcessesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProcessLinks item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProcessLinks> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProcessLinks item in singlePage)
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
