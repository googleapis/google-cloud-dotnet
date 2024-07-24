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
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFlowsClientSnippets
    {
        /// <summary>Snippet for CreateFlow</summary>
        public void CreateFlowRequestObject()
        {
            // Snippet: CreateFlow(CreateFlowRequest, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            CreateFlowRequest request = new CreateFlowRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Flow = new Flow(),
                LanguageCode = "",
            };
            // Make the request
            Flow response = flowsClient.CreateFlow(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFlowAsync</summary>
        public async Task CreateFlowRequestObjectAsync()
        {
            // Snippet: CreateFlowAsync(CreateFlowRequest, CallSettings)
            // Additional: CreateFlowAsync(CreateFlowRequest, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            CreateFlowRequest request = new CreateFlowRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Flow = new Flow(),
                LanguageCode = "",
            };
            // Make the request
            Flow response = await flowsClient.CreateFlowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFlow</summary>
        public void CreateFlow()
        {
            // Snippet: CreateFlow(string, Flow, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            Flow flow = new Flow();
            // Make the request
            Flow response = flowsClient.CreateFlow(parent, flow);
            // End snippet
        }

        /// <summary>Snippet for CreateFlowAsync</summary>
        public async Task CreateFlowAsync()
        {
            // Snippet: CreateFlowAsync(string, Flow, CallSettings)
            // Additional: CreateFlowAsync(string, Flow, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            Flow flow = new Flow();
            // Make the request
            Flow response = await flowsClient.CreateFlowAsync(parent, flow);
            // End snippet
        }

        /// <summary>Snippet for CreateFlow</summary>
        public void CreateFlowResourceNames()
        {
            // Snippet: CreateFlow(AgentName, Flow, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            Flow flow = new Flow();
            // Make the request
            Flow response = flowsClient.CreateFlow(parent, flow);
            // End snippet
        }

        /// <summary>Snippet for CreateFlowAsync</summary>
        public async Task CreateFlowResourceNamesAsync()
        {
            // Snippet: CreateFlowAsync(AgentName, Flow, CallSettings)
            // Additional: CreateFlowAsync(AgentName, Flow, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            Flow flow = new Flow();
            // Make the request
            Flow response = await flowsClient.CreateFlowAsync(parent, flow);
            // End snippet
        }

        /// <summary>Snippet for DeleteFlow</summary>
        public void DeleteFlowRequestObject()
        {
            // Snippet: DeleteFlow(DeleteFlowRequest, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            DeleteFlowRequest request = new DeleteFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                Force = false,
            };
            // Make the request
            flowsClient.DeleteFlow(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFlowAsync</summary>
        public async Task DeleteFlowRequestObjectAsync()
        {
            // Snippet: DeleteFlowAsync(DeleteFlowRequest, CallSettings)
            // Additional: DeleteFlowAsync(DeleteFlowRequest, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFlowRequest request = new DeleteFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                Force = false,
            };
            // Make the request
            await flowsClient.DeleteFlowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFlow</summary>
        public void DeleteFlow()
        {
            // Snippet: DeleteFlow(string, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            // Make the request
            flowsClient.DeleteFlow(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFlowAsync</summary>
        public async Task DeleteFlowAsync()
        {
            // Snippet: DeleteFlowAsync(string, CallSettings)
            // Additional: DeleteFlowAsync(string, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            // Make the request
            await flowsClient.DeleteFlowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFlow</summary>
        public void DeleteFlowResourceNames()
        {
            // Snippet: DeleteFlow(FlowName, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            FlowName name = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            // Make the request
            flowsClient.DeleteFlow(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFlowAsync</summary>
        public async Task DeleteFlowResourceNamesAsync()
        {
            // Snippet: DeleteFlowAsync(FlowName, CallSettings)
            // Additional: DeleteFlowAsync(FlowName, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            FlowName name = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            // Make the request
            await flowsClient.DeleteFlowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFlows</summary>
        public void ListFlowsRequestObject()
        {
            // Snippet: ListFlows(ListFlowsRequest, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            ListFlowsRequest request = new ListFlowsRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<ListFlowsResponse, Flow> response = flowsClient.ListFlows(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Flow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFlowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Flow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Flow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Flow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFlowsAsync</summary>
        public async Task ListFlowsRequestObjectAsync()
        {
            // Snippet: ListFlowsAsync(ListFlowsRequest, CallSettings)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            ListFlowsRequest request = new ListFlowsRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFlowsResponse, Flow> response = flowsClient.ListFlowsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Flow item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFlowsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Flow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Flow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Flow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFlows</summary>
        public void ListFlows()
        {
            // Snippet: ListFlows(string, string, int?, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            PagedEnumerable<ListFlowsResponse, Flow> response = flowsClient.ListFlows(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Flow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFlowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Flow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Flow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Flow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFlowsAsync</summary>
        public async Task ListFlowsAsync()
        {
            // Snippet: ListFlowsAsync(string, string, int?, CallSettings)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            PagedAsyncEnumerable<ListFlowsResponse, Flow> response = flowsClient.ListFlowsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Flow item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFlowsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Flow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Flow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Flow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFlows</summary>
        public void ListFlowsResourceNames()
        {
            // Snippet: ListFlows(AgentName, string, int?, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedEnumerable<ListFlowsResponse, Flow> response = flowsClient.ListFlows(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Flow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFlowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Flow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Flow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Flow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFlowsAsync</summary>
        public async Task ListFlowsResourceNamesAsync()
        {
            // Snippet: ListFlowsAsync(AgentName, string, int?, CallSettings)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedAsyncEnumerable<ListFlowsResponse, Flow> response = flowsClient.ListFlowsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Flow item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFlowsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Flow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Flow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Flow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFlow</summary>
        public void GetFlowRequestObject()
        {
            // Snippet: GetFlow(GetFlowRequest, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            GetFlowRequest request = new GetFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "",
            };
            // Make the request
            Flow response = flowsClient.GetFlow(request);
            // End snippet
        }

        /// <summary>Snippet for GetFlowAsync</summary>
        public async Task GetFlowRequestObjectAsync()
        {
            // Snippet: GetFlowAsync(GetFlowRequest, CallSettings)
            // Additional: GetFlowAsync(GetFlowRequest, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            GetFlowRequest request = new GetFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "",
            };
            // Make the request
            Flow response = await flowsClient.GetFlowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFlow</summary>
        public void GetFlow()
        {
            // Snippet: GetFlow(string, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            // Make the request
            Flow response = flowsClient.GetFlow(name);
            // End snippet
        }

        /// <summary>Snippet for GetFlowAsync</summary>
        public async Task GetFlowAsync()
        {
            // Snippet: GetFlowAsync(string, CallSettings)
            // Additional: GetFlowAsync(string, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            // Make the request
            Flow response = await flowsClient.GetFlowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFlow</summary>
        public void GetFlowResourceNames()
        {
            // Snippet: GetFlow(FlowName, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            FlowName name = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            // Make the request
            Flow response = flowsClient.GetFlow(name);
            // End snippet
        }

        /// <summary>Snippet for GetFlowAsync</summary>
        public async Task GetFlowResourceNamesAsync()
        {
            // Snippet: GetFlowAsync(FlowName, CallSettings)
            // Additional: GetFlowAsync(FlowName, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            FlowName name = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            // Make the request
            Flow response = await flowsClient.GetFlowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateFlow</summary>
        public void UpdateFlowRequestObject()
        {
            // Snippet: UpdateFlow(UpdateFlowRequest, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            UpdateFlowRequest request = new UpdateFlowRequest
            {
                Flow = new Flow(),
                UpdateMask = new FieldMask(),
                LanguageCode = "",
            };
            // Make the request
            Flow response = flowsClient.UpdateFlow(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFlowAsync</summary>
        public async Task UpdateFlowRequestObjectAsync()
        {
            // Snippet: UpdateFlowAsync(UpdateFlowRequest, CallSettings)
            // Additional: UpdateFlowAsync(UpdateFlowRequest, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFlowRequest request = new UpdateFlowRequest
            {
                Flow = new Flow(),
                UpdateMask = new FieldMask(),
                LanguageCode = "",
            };
            // Make the request
            Flow response = await flowsClient.UpdateFlowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFlow</summary>
        public void UpdateFlow()
        {
            // Snippet: UpdateFlow(Flow, FieldMask, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            Flow flow = new Flow();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Flow response = flowsClient.UpdateFlow(flow, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFlowAsync</summary>
        public async Task UpdateFlowAsync()
        {
            // Snippet: UpdateFlowAsync(Flow, FieldMask, CallSettings)
            // Additional: UpdateFlowAsync(Flow, FieldMask, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            Flow flow = new Flow();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Flow response = await flowsClient.UpdateFlowAsync(flow, updateMask);
            // End snippet
        }

        /// <summary>Snippet for TrainFlow</summary>
        public void TrainFlowRequestObject()
        {
            // Snippet: TrainFlow(TrainFlowRequest, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            TrainFlowRequest request = new TrainFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            // Make the request
            Operation<Empty, Struct> response = flowsClient.TrainFlow(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = flowsClient.PollOnceTrainFlow(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainFlowAsync</summary>
        public async Task TrainFlowRequestObjectAsync()
        {
            // Snippet: TrainFlowAsync(TrainFlowRequest, CallSettings)
            // Additional: TrainFlowAsync(TrainFlowRequest, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            TrainFlowRequest request = new TrainFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            // Make the request
            Operation<Empty, Struct> response = await flowsClient.TrainFlowAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await flowsClient.PollOnceTrainFlowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainFlow</summary>
        public void TrainFlow()
        {
            // Snippet: TrainFlow(string, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            // Make the request
            Operation<Empty, Struct> response = flowsClient.TrainFlow(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = flowsClient.PollOnceTrainFlow(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainFlowAsync</summary>
        public async Task TrainFlowAsync()
        {
            // Snippet: TrainFlowAsync(string, CallSettings)
            // Additional: TrainFlowAsync(string, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            // Make the request
            Operation<Empty, Struct> response = await flowsClient.TrainFlowAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await flowsClient.PollOnceTrainFlowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainFlow</summary>
        public void TrainFlowResourceNames()
        {
            // Snippet: TrainFlow(FlowName, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            FlowName name = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            // Make the request
            Operation<Empty, Struct> response = flowsClient.TrainFlow(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = flowsClient.PollOnceTrainFlow(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainFlowAsync</summary>
        public async Task TrainFlowResourceNamesAsync()
        {
            // Snippet: TrainFlowAsync(FlowName, CallSettings)
            // Additional: TrainFlowAsync(FlowName, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            FlowName name = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            // Make the request
            Operation<Empty, Struct> response = await flowsClient.TrainFlowAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await flowsClient.PollOnceTrainFlowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ValidateFlow</summary>
        public void ValidateFlowRequestObject()
        {
            // Snippet: ValidateFlow(ValidateFlowRequest, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            ValidateFlowRequest request = new ValidateFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "",
            };
            // Make the request
            FlowValidationResult response = flowsClient.ValidateFlow(request);
            // End snippet
        }

        /// <summary>Snippet for ValidateFlowAsync</summary>
        public async Task ValidateFlowRequestObjectAsync()
        {
            // Snippet: ValidateFlowAsync(ValidateFlowRequest, CallSettings)
            // Additional: ValidateFlowAsync(ValidateFlowRequest, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            ValidateFlowRequest request = new ValidateFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "",
            };
            // Make the request
            FlowValidationResult response = await flowsClient.ValidateFlowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFlowValidationResult</summary>
        public void GetFlowValidationResultRequestObject()
        {
            // Snippet: GetFlowValidationResult(GetFlowValidationResultRequest, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            GetFlowValidationResultRequest request = new GetFlowValidationResultRequest
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "",
            };
            // Make the request
            FlowValidationResult response = flowsClient.GetFlowValidationResult(request);
            // End snippet
        }

        /// <summary>Snippet for GetFlowValidationResultAsync</summary>
        public async Task GetFlowValidationResultRequestObjectAsync()
        {
            // Snippet: GetFlowValidationResultAsync(GetFlowValidationResultRequest, CallSettings)
            // Additional: GetFlowValidationResultAsync(GetFlowValidationResultRequest, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            GetFlowValidationResultRequest request = new GetFlowValidationResultRequest
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "",
            };
            // Make the request
            FlowValidationResult response = await flowsClient.GetFlowValidationResultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFlowValidationResult</summary>
        public void GetFlowValidationResult()
        {
            // Snippet: GetFlowValidationResult(string, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/validationResult";
            // Make the request
            FlowValidationResult response = flowsClient.GetFlowValidationResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetFlowValidationResultAsync</summary>
        public async Task GetFlowValidationResultAsync()
        {
            // Snippet: GetFlowValidationResultAsync(string, CallSettings)
            // Additional: GetFlowValidationResultAsync(string, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/validationResult";
            // Make the request
            FlowValidationResult response = await flowsClient.GetFlowValidationResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFlowValidationResult</summary>
        public void GetFlowValidationResultResourceNames()
        {
            // Snippet: GetFlowValidationResult(FlowValidationResultName, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            FlowValidationResultName name = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            // Make the request
            FlowValidationResult response = flowsClient.GetFlowValidationResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetFlowValidationResultAsync</summary>
        public async Task GetFlowValidationResultResourceNamesAsync()
        {
            // Snippet: GetFlowValidationResultAsync(FlowValidationResultName, CallSettings)
            // Additional: GetFlowValidationResultAsync(FlowValidationResultName, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            FlowValidationResultName name = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            // Make the request
            FlowValidationResult response = await flowsClient.GetFlowValidationResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ImportFlow</summary>
        public void ImportFlowRequestObject()
        {
            // Snippet: ImportFlow(ImportFlowRequest, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            ImportFlowRequest request = new ImportFlowRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                FlowUri = "",
                ImportOption = ImportFlowRequest.Types.ImportOption.Unspecified,
                FlowImportStrategy = new FlowImportStrategy(),
            };
            // Make the request
            Operation<ImportFlowResponse, Struct> response = flowsClient.ImportFlow(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportFlowResponse, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportFlowResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportFlowResponse, Struct> retrievedResponse = flowsClient.PollOnceImportFlow(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportFlowResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportFlowAsync</summary>
        public async Task ImportFlowRequestObjectAsync()
        {
            // Snippet: ImportFlowAsync(ImportFlowRequest, CallSettings)
            // Additional: ImportFlowAsync(ImportFlowRequest, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            ImportFlowRequest request = new ImportFlowRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                FlowUri = "",
                ImportOption = ImportFlowRequest.Types.ImportOption.Unspecified,
                FlowImportStrategy = new FlowImportStrategy(),
            };
            // Make the request
            Operation<ImportFlowResponse, Struct> response = await flowsClient.ImportFlowAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportFlowResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportFlowResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportFlowResponse, Struct> retrievedResponse = await flowsClient.PollOnceImportFlowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportFlowResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportFlow</summary>
        public void ExportFlowRequestObject()
        {
            // Snippet: ExportFlow(ExportFlowRequest, CallSettings)
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            ExportFlowRequest request = new ExportFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                FlowUri = "",
                IncludeReferencedFlows = false,
            };
            // Make the request
            Operation<ExportFlowResponse, Struct> response = flowsClient.ExportFlow(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportFlowResponse, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportFlowResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportFlowResponse, Struct> retrievedResponse = flowsClient.PollOnceExportFlow(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportFlowResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportFlowAsync</summary>
        public async Task ExportFlowRequestObjectAsync()
        {
            // Snippet: ExportFlowAsync(ExportFlowRequest, CallSettings)
            // Additional: ExportFlowAsync(ExportFlowRequest, CancellationToken)
            // Create client
            FlowsClient flowsClient = await FlowsClient.CreateAsync();
            // Initialize request argument(s)
            ExportFlowRequest request = new ExportFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                FlowUri = "",
                IncludeReferencedFlows = false,
            };
            // Make the request
            Operation<ExportFlowResponse, Struct> response = await flowsClient.ExportFlowAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportFlowResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportFlowResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportFlowResponse, Struct> retrievedResponse = await flowsClient.PollOnceExportFlowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportFlowResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
