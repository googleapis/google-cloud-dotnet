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
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAgentsClientSnippets
    {
        /// <summary>Snippet for ListAgents</summary>
        public void ListAgentsRequestObject()
        {
            // Snippet: ListAgents(ListAgentsRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            ListAgentsRequest request = new ListAgentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListAgentsResponse, Agent> response = agentsClient.ListAgents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAgentsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListAgentsAsync</summary>
        public async Task ListAgentsRequestObjectAsync()
        {
            // Snippet: ListAgentsAsync(ListAgentsRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            ListAgentsRequest request = new ListAgentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAgentsResponse, Agent> response = agentsClient.ListAgentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Agent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAgentsResponse page) =>
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

        /// <summary>Snippet for ListAgents</summary>
        public void ListAgents()
        {
            // Snippet: ListAgents(string, string, int?, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAgentsResponse, Agent> response = agentsClient.ListAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAgentsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListAgentsAsync</summary>
        public async Task ListAgentsAsync()
        {
            // Snippet: ListAgentsAsync(string, string, int?, CallSettings)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAgentsResponse, Agent> response = agentsClient.ListAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Agent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAgentsResponse page) =>
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

        /// <summary>Snippet for ListAgents</summary>
        public void ListAgentsResourceNames()
        {
            // Snippet: ListAgents(LocationName, string, int?, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAgentsResponse, Agent> response = agentsClient.ListAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAgentsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListAgentsAsync</summary>
        public async Task ListAgentsResourceNamesAsync()
        {
            // Snippet: ListAgentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAgentsResponse, Agent> response = agentsClient.ListAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Agent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAgentsResponse page) =>
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

        /// <summary>Snippet for GetAgent</summary>
        public void GetAgentRequestObject()
        {
            // Snippet: GetAgent(GetAgentRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            GetAgentRequest request = new GetAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
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
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            Agent response = agentsClient.GetAgent(name);
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            Agent response = await agentsClient.GetAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgent</summary>
        public void GetAgentResourceNames()
        {
            // Snippet: GetAgent(AgentName, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            AgentName name = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            Agent response = agentsClient.GetAgent(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAsync</summary>
        public async Task GetAgentResourceNamesAsync()
        {
            // Snippet: GetAgentAsync(AgentName, CallSettings)
            // Additional: GetAgentAsync(AgentName, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName name = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            Agent response = await agentsClient.GetAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAgent</summary>
        public void CreateAgentRequestObject()
        {
            // Snippet: CreateAgent(CreateAgentRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            CreateAgentRequest request = new CreateAgentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Agent = new Agent(),
            };
            // Make the request
            Agent response = agentsClient.CreateAgent(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAgentAsync</summary>
        public async Task CreateAgentRequestObjectAsync()
        {
            // Snippet: CreateAgentAsync(CreateAgentRequest, CallSettings)
            // Additional: CreateAgentAsync(CreateAgentRequest, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            CreateAgentRequest request = new CreateAgentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Agent = new Agent(),
            };
            // Make the request
            Agent response = await agentsClient.CreateAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAgent</summary>
        public void CreateAgent()
        {
            // Snippet: CreateAgent(string, Agent, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Agent agent = new Agent();
            // Make the request
            Agent response = agentsClient.CreateAgent(parent, agent);
            // End snippet
        }

        /// <summary>Snippet for CreateAgentAsync</summary>
        public async Task CreateAgentAsync()
        {
            // Snippet: CreateAgentAsync(string, Agent, CallSettings)
            // Additional: CreateAgentAsync(string, Agent, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Agent agent = new Agent();
            // Make the request
            Agent response = await agentsClient.CreateAgentAsync(parent, agent);
            // End snippet
        }

        /// <summary>Snippet for CreateAgent</summary>
        public void CreateAgentResourceNames()
        {
            // Snippet: CreateAgent(LocationName, Agent, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Agent agent = new Agent();
            // Make the request
            Agent response = agentsClient.CreateAgent(parent, agent);
            // End snippet
        }

        /// <summary>Snippet for CreateAgentAsync</summary>
        public async Task CreateAgentResourceNamesAsync()
        {
            // Snippet: CreateAgentAsync(LocationName, Agent, CallSettings)
            // Additional: CreateAgentAsync(LocationName, Agent, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Agent agent = new Agent();
            // Make the request
            Agent response = await agentsClient.CreateAgentAsync(parent, agent);
            // End snippet
        }

        /// <summary>Snippet for UpdateAgent</summary>
        public void UpdateAgentRequestObject()
        {
            // Snippet: UpdateAgent(UpdateAgentRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            UpdateAgentRequest request = new UpdateAgentRequest
            {
                Agent = new Agent(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Agent response = agentsClient.UpdateAgent(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAgentAsync</summary>
        public async Task UpdateAgentRequestObjectAsync()
        {
            // Snippet: UpdateAgentAsync(UpdateAgentRequest, CallSettings)
            // Additional: UpdateAgentAsync(UpdateAgentRequest, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAgentRequest request = new UpdateAgentRequest
            {
                Agent = new Agent(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Agent response = await agentsClient.UpdateAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAgent</summary>
        public void UpdateAgent()
        {
            // Snippet: UpdateAgent(Agent, FieldMask, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            Agent agent = new Agent();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Agent response = agentsClient.UpdateAgent(agent, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAgentAsync</summary>
        public async Task UpdateAgentAsync()
        {
            // Snippet: UpdateAgentAsync(Agent, FieldMask, CallSettings)
            // Additional: UpdateAgentAsync(Agent, FieldMask, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            Agent agent = new Agent();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Agent response = await agentsClient.UpdateAgentAsync(agent, updateMask);
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
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
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
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            agentsClient.DeleteAgent(name);
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            await agentsClient.DeleteAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgent</summary>
        public void DeleteAgentResourceNames()
        {
            // Snippet: DeleteAgent(AgentName, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            AgentName name = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            agentsClient.DeleteAgent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentAsync</summary>
        public async Task DeleteAgentResourceNamesAsync()
        {
            // Snippet: DeleteAgentAsync(AgentName, CallSettings)
            // Additional: DeleteAgentAsync(AgentName, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName name = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            await agentsClient.DeleteAgentAsync(name);
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
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                AgentUri = "",
                DataFormat = ExportAgentRequest.Types.DataFormat.Unspecified,
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                GitDestination = new ExportAgentRequest.Types.GitDestination(),
                IncludeBigqueryExportSettings = false,
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
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                AgentUri = "",
                DataFormat = ExportAgentRequest.Types.DataFormat.Unspecified,
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                GitDestination = new ExportAgentRequest.Types.GitDestination(),
                IncludeBigqueryExportSettings = false,
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

        /// <summary>Snippet for RestoreAgent</summary>
        public void RestoreAgentRequestObject()
        {
            // Snippet: RestoreAgent(RestoreAgentRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            RestoreAgentRequest request = new RestoreAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                AgentUri = "",
                RestoreOption = RestoreAgentRequest.Types.RestoreOption.Unspecified,
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
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                AgentUri = "",
                RestoreOption = RestoreAgentRequest.Types.RestoreOption.Unspecified,
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

        /// <summary>Snippet for ValidateAgent</summary>
        public void ValidateAgentRequestObject()
        {
            // Snippet: ValidateAgent(ValidateAgentRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            ValidateAgentRequest request = new ValidateAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                LanguageCode = "",
            };
            // Make the request
            AgentValidationResult response = agentsClient.ValidateAgent(request);
            // End snippet
        }

        /// <summary>Snippet for ValidateAgentAsync</summary>
        public async Task ValidateAgentRequestObjectAsync()
        {
            // Snippet: ValidateAgentAsync(ValidateAgentRequest, CallSettings)
            // Additional: ValidateAgentAsync(ValidateAgentRequest, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            ValidateAgentRequest request = new ValidateAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                LanguageCode = "",
            };
            // Make the request
            AgentValidationResult response = await agentsClient.ValidateAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgentValidationResult</summary>
        public void GetAgentValidationResultRequestObject()
        {
            // Snippet: GetAgentValidationResult(GetAgentValidationResultRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            GetAgentValidationResultRequest request = new GetAgentValidationResultRequest
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                LanguageCode = "",
            };
            // Make the request
            AgentValidationResult response = agentsClient.GetAgentValidationResult(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgentValidationResultAsync</summary>
        public async Task GetAgentValidationResultRequestObjectAsync()
        {
            // Snippet: GetAgentValidationResultAsync(GetAgentValidationResultRequest, CallSettings)
            // Additional: GetAgentValidationResultAsync(GetAgentValidationResultRequest, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            GetAgentValidationResultRequest request = new GetAgentValidationResultRequest
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                LanguageCode = "",
            };
            // Make the request
            AgentValidationResult response = await agentsClient.GetAgentValidationResultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgentValidationResult</summary>
        public void GetAgentValidationResult()
        {
            // Snippet: GetAgentValidationResult(string, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/validationResult";
            // Make the request
            AgentValidationResult response = agentsClient.GetAgentValidationResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgentValidationResultAsync</summary>
        public async Task GetAgentValidationResultAsync()
        {
            // Snippet: GetAgentValidationResultAsync(string, CallSettings)
            // Additional: GetAgentValidationResultAsync(string, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/validationResult";
            // Make the request
            AgentValidationResult response = await agentsClient.GetAgentValidationResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgentValidationResult</summary>
        public void GetAgentValidationResultResourceNames()
        {
            // Snippet: GetAgentValidationResult(AgentValidationResultName, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            AgentValidationResultName name = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            AgentValidationResult response = agentsClient.GetAgentValidationResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgentValidationResultAsync</summary>
        public async Task GetAgentValidationResultResourceNamesAsync()
        {
            // Snippet: GetAgentValidationResultAsync(AgentValidationResultName, CallSettings)
            // Additional: GetAgentValidationResultAsync(AgentValidationResultName, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            AgentValidationResultName name = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            AgentValidationResult response = await agentsClient.GetAgentValidationResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGenerativeSettings</summary>
        public void GetGenerativeSettingsRequestObject()
        {
            // Snippet: GetGenerativeSettings(GetGenerativeSettingsRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            GetGenerativeSettingsRequest request = new GetGenerativeSettingsRequest
            {
                AgentGenerativeSettingsName = AgentGenerativeSettingsName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                LanguageCode = "",
            };
            // Make the request
            GenerativeSettings response = agentsClient.GetGenerativeSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetGenerativeSettingsAsync</summary>
        public async Task GetGenerativeSettingsRequestObjectAsync()
        {
            // Snippet: GetGenerativeSettingsAsync(GetGenerativeSettingsRequest, CallSettings)
            // Additional: GetGenerativeSettingsAsync(GetGenerativeSettingsRequest, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            GetGenerativeSettingsRequest request = new GetGenerativeSettingsRequest
            {
                AgentGenerativeSettingsName = AgentGenerativeSettingsName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                LanguageCode = "",
            };
            // Make the request
            GenerativeSettings response = await agentsClient.GetGenerativeSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGenerativeSettings</summary>
        public void GetGenerativeSettings()
        {
            // Snippet: GetGenerativeSettings(string, string, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/generativeSettings";
            string languageCode = "";
            // Make the request
            GenerativeSettings response = agentsClient.GetGenerativeSettings(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for GetGenerativeSettingsAsync</summary>
        public async Task GetGenerativeSettingsAsync()
        {
            // Snippet: GetGenerativeSettingsAsync(string, string, CallSettings)
            // Additional: GetGenerativeSettingsAsync(string, string, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/generativeSettings";
            string languageCode = "";
            // Make the request
            GenerativeSettings response = await agentsClient.GetGenerativeSettingsAsync(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for GetGenerativeSettings</summary>
        public void GetGenerativeSettingsResourceNames()
        {
            // Snippet: GetGenerativeSettings(AgentGenerativeSettingsName, string, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            AgentGenerativeSettingsName name = AgentGenerativeSettingsName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            string languageCode = "";
            // Make the request
            GenerativeSettings response = agentsClient.GetGenerativeSettings(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for GetGenerativeSettingsAsync</summary>
        public async Task GetGenerativeSettingsResourceNamesAsync()
        {
            // Snippet: GetGenerativeSettingsAsync(AgentGenerativeSettingsName, string, CallSettings)
            // Additional: GetGenerativeSettingsAsync(AgentGenerativeSettingsName, string, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            AgentGenerativeSettingsName name = AgentGenerativeSettingsName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            string languageCode = "";
            // Make the request
            GenerativeSettings response = await agentsClient.GetGenerativeSettingsAsync(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for UpdateGenerativeSettings</summary>
        public void UpdateGenerativeSettingsRequestObject()
        {
            // Snippet: UpdateGenerativeSettings(UpdateGenerativeSettingsRequest, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            UpdateGenerativeSettingsRequest request = new UpdateGenerativeSettingsRequest
            {
                GenerativeSettings = new GenerativeSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GenerativeSettings response = agentsClient.UpdateGenerativeSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGenerativeSettingsAsync</summary>
        public async Task UpdateGenerativeSettingsRequestObjectAsync()
        {
            // Snippet: UpdateGenerativeSettingsAsync(UpdateGenerativeSettingsRequest, CallSettings)
            // Additional: UpdateGenerativeSettingsAsync(UpdateGenerativeSettingsRequest, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGenerativeSettingsRequest request = new UpdateGenerativeSettingsRequest
            {
                GenerativeSettings = new GenerativeSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GenerativeSettings response = await agentsClient.UpdateGenerativeSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGenerativeSettings</summary>
        public void UpdateGenerativeSettings()
        {
            // Snippet: UpdateGenerativeSettings(GenerativeSettings, FieldMask, CallSettings)
            // Create client
            AgentsClient agentsClient = AgentsClient.Create();
            // Initialize request argument(s)
            GenerativeSettings generativeSettings = new GenerativeSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            GenerativeSettings response = agentsClient.UpdateGenerativeSettings(generativeSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateGenerativeSettingsAsync</summary>
        public async Task UpdateGenerativeSettingsAsync()
        {
            // Snippet: UpdateGenerativeSettingsAsync(GenerativeSettings, FieldMask, CallSettings)
            // Additional: UpdateGenerativeSettingsAsync(GenerativeSettings, FieldMask, CancellationToken)
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            GenerativeSettings generativeSettings = new GenerativeSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            GenerativeSettings response = await agentsClient.UpdateGenerativeSettingsAsync(generativeSettings, updateMask);
            // End snippet
        }
    }
}
