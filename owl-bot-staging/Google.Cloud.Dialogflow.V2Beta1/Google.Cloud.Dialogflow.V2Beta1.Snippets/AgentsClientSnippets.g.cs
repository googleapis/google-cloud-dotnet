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
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAgentsClientSnippets
    {
        /// <summary>Snippet for GetAgent</summary>
        public void GetAgentRequestObject()
        {
            // Snippet: GetAgent(GetAgentRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            GetAgentRequest request = new GetAgentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Agent response = agentsClient.GetAgent(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAsync</summary>
        public async Task GetAgentRequestObjectAsync()
        {
            // Snippet: GetAgentAsync(GetAgentRequest, CallSettings)
            // Additional: GetAgentAsync(GetAgentRequest, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            GetAgentRequest request = new GetAgentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Agent response = await agentsClient.GetAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgent</summary>
        public void GetAgent()
        {
            // Snippet: GetAgent(string, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            Agent response = agentsClient.GetAgent(parent);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAsync</summary>
        public async Task GetAgentAsync()
        {
            // Snippet: GetAgentAsync(string, CallSettings)
            // Additional: GetAgentAsync(string, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            Agent response = await agentsClient.GetAgentAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for GetAgent</summary>
        public void GetAgentResourceNames1()
        {
            // Snippet: GetAgent(ProjectName, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            Agent response = agentsClient.GetAgent(parent);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAsync</summary>
        public async Task GetAgentResourceNames1Async()
        {
            // Snippet: GetAgentAsync(ProjectName, CallSettings)
            // Additional: GetAgentAsync(ProjectName, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            Agent response = await agentsClient.GetAgentAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for GetAgent</summary>
        public void GetAgentResourceNames2()
        {
            // Snippet: GetAgent(LocationName, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Agent response = agentsClient.GetAgent(parent);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAsync</summary>
        public async Task GetAgentResourceNames2Async()
        {
            // Snippet: GetAgentAsync(LocationName, CallSettings)
            // Additional: GetAgentAsync(LocationName, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Agent response = await agentsClient.GetAgentAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for SetAgent</summary>
        public void SetAgentRequestObject()
        {
            // Snippet: SetAgent(SetAgentRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            SetAgentRequest request = new SetAgentRequest
            {
                Agent = new Agent(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Agent response = agentsClient.SetAgent(request);
            // End snippet
        }

        /// <summary>Snippet for SetAgentAsync</summary>
        public async Task SetAgentRequestObjectAsync()
        {
            // Snippet: SetAgentAsync(SetAgentRequest, CallSettings)
            // Additional: SetAgentAsync(SetAgentRequest, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            SetAgentRequest request = new SetAgentRequest
            {
                Agent = new Agent(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Agent response = await agentsClient.SetAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetAgent</summary>
        public void SetAgent()
        {
            // Snippet: SetAgent(Agent, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            Agent agent = new Agent();
            // Make the request
            Agent response = agentsClient.SetAgent(agent);
            // End snippet
        }

        /// <summary>Snippet for SetAgentAsync</summary>
        public async Task SetAgentAsync()
        {
            // Snippet: SetAgentAsync(Agent, CallSettings)
            // Additional: SetAgentAsync(Agent, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            Agent agent = new Agent();
            // Make the request
            Agent response = await agentsClient.SetAgentAsync(agent);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgent</summary>
        public void DeleteAgentRequestObject()
        {
            // Snippet: DeleteAgent(DeleteAgentRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            agentsClient.DeleteAgent(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentAsync</summary>
        public async Task DeleteAgentRequestObjectAsync()
        {
            // Snippet: DeleteAgentAsync(DeleteAgentRequest, CallSettings)
            // Additional: DeleteAgentAsync(DeleteAgentRequest, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            await agentsClient.DeleteAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgent</summary>
        public void DeleteAgent()
        {
            // Snippet: DeleteAgent(string, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            agentsClient.DeleteAgent(parent);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentAsync</summary>
        public async Task DeleteAgentAsync()
        {
            // Snippet: DeleteAgentAsync(string, CallSettings)
            // Additional: DeleteAgentAsync(string, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            await agentsClient.DeleteAgentAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgent</summary>
        public void DeleteAgentResourceNames1()
        {
            // Snippet: DeleteAgent(ProjectName, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            agentsClient.DeleteAgent(parent);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentAsync</summary>
        public async Task DeleteAgentResourceNames1Async()
        {
            // Snippet: DeleteAgentAsync(ProjectName, CallSettings)
            // Additional: DeleteAgentAsync(ProjectName, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            await agentsClient.DeleteAgentAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgent</summary>
        public void DeleteAgentResourceNames2()
        {
            // Snippet: DeleteAgent(LocationName, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            agentsClient.DeleteAgent(parent);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentAsync</summary>
        public async Task DeleteAgentResourceNames2Async()
        {
            // Snippet: DeleteAgentAsync(LocationName, CallSettings)
            // Additional: DeleteAgentAsync(LocationName, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            await agentsClient.DeleteAgentAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for SearchAgents</summary>
        public void SearchAgentsRequestObject()
        {
            // Snippet: SearchAgents(SearchAgentsRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            SearchAgentsRequest request = new SearchAgentsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<SearchAgentsResponse, Agent> response = agentsClient.SearchAgents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAgentsAsync</summary>
        public async Task SearchAgentsRequestObjectAsync()
        {
            // Snippet: SearchAgentsAsync(SearchAgentsRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            SearchAgentsRequest request = new SearchAgentsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<SearchAgentsResponse, Agent> response = agentsClient.SearchAgentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Agent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAgentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAgents</summary>
        public void SearchAgents()
        {
            // Snippet: SearchAgents(string, string, int?, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<SearchAgentsResponse, Agent> response = agentsClient.SearchAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAgentsAsync</summary>
        public async Task SearchAgentsAsync()
        {
            // Snippet: SearchAgentsAsync(string, string, int?, CallSettings)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<SearchAgentsResponse, Agent> response = agentsClient.SearchAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Agent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAgentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAgents</summary>
        public void SearchAgentsResourceNames1()
        {
            // Snippet: SearchAgents(ProjectName, string, int?, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<SearchAgentsResponse, Agent> response = agentsClient.SearchAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAgentsAsync</summary>
        public async Task SearchAgentsResourceNames1Async()
        {
            // Snippet: SearchAgentsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<SearchAgentsResponse, Agent> response = agentsClient.SearchAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Agent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAgentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAgents</summary>
        public void SearchAgentsResourceNames2()
        {
            // Snippet: SearchAgents(LocationName, string, int?, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<SearchAgentsResponse, Agent> response = agentsClient.SearchAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAgentsAsync</summary>
        public async Task SearchAgentsResourceNames2Async()
        {
            // Snippet: SearchAgentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<SearchAgentsResponse, Agent> response = agentsClient.SearchAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Agent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAgentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for TrainAgent</summary>
        public void TrainAgentRequestObject()
        {
            // Snippet: TrainAgent(TrainAgentRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            TrainAgentRequest request = new TrainAgentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Operation<Empty, Struct> response = agentsClient.TrainAgent(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = agentsClient.PollOnceTrainAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainAgentAsync</summary>
        public async Task TrainAgentRequestObjectAsync()
        {
            // Snippet: TrainAgentAsync(TrainAgentRequest, CallSettings)
            // Additional: TrainAgentAsync(TrainAgentRequest, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            TrainAgentRequest request = new TrainAgentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Operation<Empty, Struct> response = await agentsClient.TrainAgentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await agentsClient.PollOnceTrainAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainAgent</summary>
        public void TrainAgent()
        {
            // Snippet: TrainAgent(string, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            Operation<Empty, Struct> response = agentsClient.TrainAgent(parent);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = agentsClient.PollOnceTrainAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainAgentAsync</summary>
        public async Task TrainAgentAsync()
        {
            // Snippet: TrainAgentAsync(string, CallSettings)
            // Additional: TrainAgentAsync(string, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            Operation<Empty, Struct> response = await agentsClient.TrainAgentAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await agentsClient.PollOnceTrainAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainAgent</summary>
        public void TrainAgentResourceNames1()
        {
            // Snippet: TrainAgent(ProjectName, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            Operation<Empty, Struct> response = agentsClient.TrainAgent(parent);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = agentsClient.PollOnceTrainAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainAgentAsync</summary>
        public async Task TrainAgentResourceNames1Async()
        {
            // Snippet: TrainAgentAsync(ProjectName, CallSettings)
            // Additional: TrainAgentAsync(ProjectName, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            Operation<Empty, Struct> response = await agentsClient.TrainAgentAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await agentsClient.PollOnceTrainAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainAgent</summary>
        public void TrainAgentResourceNames2()
        {
            // Snippet: TrainAgent(LocationName, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Operation<Empty, Struct> response = agentsClient.TrainAgent(parent);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = agentsClient.PollOnceTrainAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainAgentAsync</summary>
        public async Task TrainAgentResourceNames2Async()
        {
            // Snippet: TrainAgentAsync(LocationName, CallSettings)
            // Additional: TrainAgentAsync(LocationName, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Operation<Empty, Struct> response = await agentsClient.TrainAgentAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await agentsClient.PollOnceTrainAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAgent</summary>
        public void ExportAgentRequestObject()
        {
            // Snippet: ExportAgent(ExportAgentRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            ExportAgentRequest request = new ExportAgentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                AgentUri = "",
            };
            // Make the request
            Operation<ExportAgentResponse, Struct> response = agentsClient.ExportAgent(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportAgentResponse, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportAgentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAgentResponse, Struct> retrievedResponse = agentsClient.PollOnceExportAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAgentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAgentAsync</summary>
        public async Task ExportAgentRequestObjectAsync()
        {
            // Snippet: ExportAgentAsync(ExportAgentRequest, CallSettings)
            // Additional: ExportAgentAsync(ExportAgentRequest, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            ExportAgentRequest request = new ExportAgentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                AgentUri = "",
            };
            // Make the request
            Operation<ExportAgentResponse, Struct> response = await agentsClient.ExportAgentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportAgentResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportAgentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAgentResponse, Struct> retrievedResponse = await agentsClient.PollOnceExportAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAgentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAgent</summary>
        public void ExportAgent()
        {
            // Snippet: ExportAgent(string, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            Operation<ExportAgentResponse, Struct> response = agentsClient.ExportAgent(parent);

            // Poll until the returned long-running operation is complete
            Operation<ExportAgentResponse, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportAgentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAgentResponse, Struct> retrievedResponse = agentsClient.PollOnceExportAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAgentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAgentAsync</summary>
        public async Task ExportAgentAsync()
        {
            // Snippet: ExportAgentAsync(string, CallSettings)
            // Additional: ExportAgentAsync(string, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            Operation<ExportAgentResponse, Struct> response = await agentsClient.ExportAgentAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<ExportAgentResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportAgentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAgentResponse, Struct> retrievedResponse = await agentsClient.PollOnceExportAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAgentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAgent</summary>
        public void ExportAgentResourceNames1()
        {
            // Snippet: ExportAgent(ProjectName, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            Operation<ExportAgentResponse, Struct> response = agentsClient.ExportAgent(parent);

            // Poll until the returned long-running operation is complete
            Operation<ExportAgentResponse, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportAgentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAgentResponse, Struct> retrievedResponse = agentsClient.PollOnceExportAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAgentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAgentAsync</summary>
        public async Task ExportAgentResourceNames1Async()
        {
            // Snippet: ExportAgentAsync(ProjectName, CallSettings)
            // Additional: ExportAgentAsync(ProjectName, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            Operation<ExportAgentResponse, Struct> response = await agentsClient.ExportAgentAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<ExportAgentResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportAgentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAgentResponse, Struct> retrievedResponse = await agentsClient.PollOnceExportAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAgentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAgent</summary>
        public void ExportAgentResourceNames2()
        {
            // Snippet: ExportAgent(LocationName, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Operation<ExportAgentResponse, Struct> response = agentsClient.ExportAgent(parent);

            // Poll until the returned long-running operation is complete
            Operation<ExportAgentResponse, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportAgentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAgentResponse, Struct> retrievedResponse = agentsClient.PollOnceExportAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAgentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAgentAsync</summary>
        public async Task ExportAgentResourceNames2Async()
        {
            // Snippet: ExportAgentAsync(LocationName, CallSettings)
            // Additional: ExportAgentAsync(LocationName, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Operation<ExportAgentResponse, Struct> response = await agentsClient.ExportAgentAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<ExportAgentResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportAgentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAgentResponse, Struct> retrievedResponse = await agentsClient.PollOnceExportAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAgentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAgent</summary>
        public void ImportAgentRequestObject()
        {
            // Snippet: ImportAgent(ImportAgentRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            ImportAgentRequest request = new ImportAgentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                AgentUri = "",
            };
            // Make the request
            Operation<Empty, Struct> response = agentsClient.ImportAgent(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = agentsClient.PollOnceImportAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAgentAsync</summary>
        public async Task ImportAgentRequestObjectAsync()
        {
            // Snippet: ImportAgentAsync(ImportAgentRequest, CallSettings)
            // Additional: ImportAgentAsync(ImportAgentRequest, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            ImportAgentRequest request = new ImportAgentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                AgentUri = "",
            };
            // Make the request
            Operation<Empty, Struct> response = await agentsClient.ImportAgentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await agentsClient.PollOnceImportAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreAgent</summary>
        public void RestoreAgentRequestObject()
        {
            // Snippet: RestoreAgent(RestoreAgentRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            RestoreAgentRequest request = new RestoreAgentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                AgentUri = "",
            };
            // Make the request
            Operation<Empty, Struct> response = agentsClient.RestoreAgent(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = agentsClient.PollOnceRestoreAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreAgentAsync</summary>
        public async Task RestoreAgentRequestObjectAsync()
        {
            // Snippet: RestoreAgentAsync(RestoreAgentRequest, CallSettings)
            // Additional: RestoreAgentAsync(RestoreAgentRequest, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            RestoreAgentRequest request = new RestoreAgentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                AgentUri = "",
            };
            // Make the request
            Operation<Empty, Struct> response = await agentsClient.RestoreAgentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await agentsClient.PollOnceRestoreAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetValidationResult</summary>
        public void GetValidationResultRequestObject()
        {
            // Snippet: GetValidationResult(GetValidationResultRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            GetValidationResultRequest request = new GetValidationResultRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                LanguageCode = "",
            };
            // Make the request
            ValidationResult response = agentsClient.GetValidationResult(request);
            // End snippet
        }

        /// <summary>Snippet for GetValidationResultAsync</summary>
        public async Task GetValidationResultRequestObjectAsync()
        {
            // Snippet: GetValidationResultAsync(GetValidationResultRequest, CallSettings)
            // Additional: GetValidationResultAsync(GetValidationResultRequest, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            GetValidationResultRequest request = new GetValidationResultRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                LanguageCode = "",
            };
            // Make the request
            ValidationResult response = await agentsClient.GetValidationResultAsync(request);
            // End snippet
        }
    }
}
