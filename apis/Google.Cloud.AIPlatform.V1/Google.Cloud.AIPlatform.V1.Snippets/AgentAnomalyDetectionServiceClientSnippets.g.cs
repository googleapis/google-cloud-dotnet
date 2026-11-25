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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAgentAnomalyDetectionServiceClientSnippets
    {
        /// <summary>Snippet for GetAgentAnomalyDetectionScope</summary>
        public void GetAgentAnomalyDetectionScopeRequestObject()
        {
            // Snippet: GetAgentAnomalyDetectionScope(GetAgentAnomalyDetectionScopeRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            GetAgentAnomalyDetectionScopeRequest request = new GetAgentAnomalyDetectionScopeRequest
            {
                AgentAnomalyDetectionScopeName = AgentAnomalyDetectionScopeName.FromProjectLocationAgentAnomalyDetectionScope("[PROJECT]", "[LOCATION]", "[AGENT_ANOMALY_DETECTION_SCOPE]"),
            };
            // Make the request
            AgentAnomalyDetectionScope response = agentAnomalyDetectionServiceClient.GetAgentAnomalyDetectionScope(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAnomalyDetectionScopeAsync</summary>
        public async Task GetAgentAnomalyDetectionScopeRequestObjectAsync()
        {
            // Snippet: GetAgentAnomalyDetectionScopeAsync(GetAgentAnomalyDetectionScopeRequest, CallSettings)
            // Additional: GetAgentAnomalyDetectionScopeAsync(GetAgentAnomalyDetectionScopeRequest, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAgentAnomalyDetectionScopeRequest request = new GetAgentAnomalyDetectionScopeRequest
            {
                AgentAnomalyDetectionScopeName = AgentAnomalyDetectionScopeName.FromProjectLocationAgentAnomalyDetectionScope("[PROJECT]", "[LOCATION]", "[AGENT_ANOMALY_DETECTION_SCOPE]"),
            };
            // Make the request
            AgentAnomalyDetectionScope response = await agentAnomalyDetectionServiceClient.GetAgentAnomalyDetectionScopeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAnomalyDetectionScope</summary>
        public void GetAgentAnomalyDetectionScope()
        {
            // Snippet: GetAgentAnomalyDetectionScope(string, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agentAnomalyDetectionScopes/[AGENT_ANOMALY_DETECTION_SCOPE]";
            // Make the request
            AgentAnomalyDetectionScope response = agentAnomalyDetectionServiceClient.GetAgentAnomalyDetectionScope(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAnomalyDetectionScopeAsync</summary>
        public async Task GetAgentAnomalyDetectionScopeAsync()
        {
            // Snippet: GetAgentAnomalyDetectionScopeAsync(string, CallSettings)
            // Additional: GetAgentAnomalyDetectionScopeAsync(string, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agentAnomalyDetectionScopes/[AGENT_ANOMALY_DETECTION_SCOPE]";
            // Make the request
            AgentAnomalyDetectionScope response = await agentAnomalyDetectionServiceClient.GetAgentAnomalyDetectionScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAnomalyDetectionScope</summary>
        public void GetAgentAnomalyDetectionScopeResourceNames()
        {
            // Snippet: GetAgentAnomalyDetectionScope(AgentAnomalyDetectionScopeName, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            AgentAnomalyDetectionScopeName name = AgentAnomalyDetectionScopeName.FromProjectLocationAgentAnomalyDetectionScope("[PROJECT]", "[LOCATION]", "[AGENT_ANOMALY_DETECTION_SCOPE]");
            // Make the request
            AgentAnomalyDetectionScope response = agentAnomalyDetectionServiceClient.GetAgentAnomalyDetectionScope(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAnomalyDetectionScopeAsync</summary>
        public async Task GetAgentAnomalyDetectionScopeResourceNamesAsync()
        {
            // Snippet: GetAgentAnomalyDetectionScopeAsync(AgentAnomalyDetectionScopeName, CallSettings)
            // Additional: GetAgentAnomalyDetectionScopeAsync(AgentAnomalyDetectionScopeName, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            AgentAnomalyDetectionScopeName name = AgentAnomalyDetectionScopeName.FromProjectLocationAgentAnomalyDetectionScope("[PROJECT]", "[LOCATION]", "[AGENT_ANOMALY_DETECTION_SCOPE]");
            // Make the request
            AgentAnomalyDetectionScope response = await agentAnomalyDetectionServiceClient.GetAgentAnomalyDetectionScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMonitoredAgent</summary>
        public void GetMonitoredAgentRequestObject()
        {
            // Snippet: GetMonitoredAgent(GetMonitoredAgentRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            GetMonitoredAgentRequest request = new GetMonitoredAgentRequest
            {
                MonitoredAgentName = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]"),
            };
            // Make the request
            MonitoredAgent response = agentAnomalyDetectionServiceClient.GetMonitoredAgent(request);
            // End snippet
        }

        /// <summary>Snippet for GetMonitoredAgentAsync</summary>
        public async Task GetMonitoredAgentRequestObjectAsync()
        {
            // Snippet: GetMonitoredAgentAsync(GetMonitoredAgentRequest, CallSettings)
            // Additional: GetMonitoredAgentAsync(GetMonitoredAgentRequest, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMonitoredAgentRequest request = new GetMonitoredAgentRequest
            {
                MonitoredAgentName = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]"),
            };
            // Make the request
            MonitoredAgent response = await agentAnomalyDetectionServiceClient.GetMonitoredAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMonitoredAgent</summary>
        public void GetMonitoredAgent()
        {
            // Snippet: GetMonitoredAgent(string, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]";
            // Make the request
            MonitoredAgent response = agentAnomalyDetectionServiceClient.GetMonitoredAgent(name);
            // End snippet
        }

        /// <summary>Snippet for GetMonitoredAgentAsync</summary>
        public async Task GetMonitoredAgentAsync()
        {
            // Snippet: GetMonitoredAgentAsync(string, CallSettings)
            // Additional: GetMonitoredAgentAsync(string, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]";
            // Make the request
            MonitoredAgent response = await agentAnomalyDetectionServiceClient.GetMonitoredAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMonitoredAgent</summary>
        public void GetMonitoredAgentResourceNames()
        {
            // Snippet: GetMonitoredAgent(MonitoredAgentName, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            MonitoredAgentName name = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]");
            // Make the request
            MonitoredAgent response = agentAnomalyDetectionServiceClient.GetMonitoredAgent(name);
            // End snippet
        }

        /// <summary>Snippet for GetMonitoredAgentAsync</summary>
        public async Task GetMonitoredAgentResourceNamesAsync()
        {
            // Snippet: GetMonitoredAgentAsync(MonitoredAgentName, CallSettings)
            // Additional: GetMonitoredAgentAsync(MonitoredAgentName, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            MonitoredAgentName name = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]");
            // Make the request
            MonitoredAgent response = await agentAnomalyDetectionServiceClient.GetMonitoredAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredAgents</summary>
        public void ListMonitoredAgentsRequestObject()
        {
            // Snippet: ListMonitoredAgents(ListMonitoredAgentsRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            ListMonitoredAgentsRequest request = new ListMonitoredAgentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListMonitoredAgentsResponse, MonitoredAgent> response = agentAnomalyDetectionServiceClient.ListMonitoredAgents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredAgent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMonitoredAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredAgent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredAgentsAsync</summary>
        public async Task ListMonitoredAgentsRequestObjectAsync()
        {
            // Snippet: ListMonitoredAgentsAsync(ListMonitoredAgentsRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMonitoredAgentsRequest request = new ListMonitoredAgentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMonitoredAgentsResponse, MonitoredAgent> response = agentAnomalyDetectionServiceClient.ListMonitoredAgentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MonitoredAgent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMonitoredAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredAgent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredAgents</summary>
        public void ListMonitoredAgents()
        {
            // Snippet: ListMonitoredAgents(string, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMonitoredAgentsResponse, MonitoredAgent> response = agentAnomalyDetectionServiceClient.ListMonitoredAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredAgent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMonitoredAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredAgent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredAgentsAsync</summary>
        public async Task ListMonitoredAgentsAsync()
        {
            // Snippet: ListMonitoredAgentsAsync(string, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMonitoredAgentsResponse, MonitoredAgent> response = agentAnomalyDetectionServiceClient.ListMonitoredAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MonitoredAgent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMonitoredAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredAgent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredAgents</summary>
        public void ListMonitoredAgentsResourceNames()
        {
            // Snippet: ListMonitoredAgents(LocationName, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMonitoredAgentsResponse, MonitoredAgent> response = agentAnomalyDetectionServiceClient.ListMonitoredAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredAgent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMonitoredAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredAgent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredAgentsAsync</summary>
        public async Task ListMonitoredAgentsResourceNamesAsync()
        {
            // Snippet: ListMonitoredAgentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMonitoredAgentsResponse, MonitoredAgent> response = agentAnomalyDetectionServiceClient.ListMonitoredAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MonitoredAgent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMonitoredAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredAgent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for EnableMonitoredAgent</summary>
        public void EnableMonitoredAgentRequestObject()
        {
            // Snippet: EnableMonitoredAgent(EnableMonitoredAgentRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            EnableMonitoredAgentRequest request = new EnableMonitoredAgentRequest
            {
                MonitoredAgentName = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]"),
            };
            // Make the request
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> response = agentAnomalyDetectionServiceClient.EnableMonitoredAgent(request);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MonitoredAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceEnableMonitoredAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableMonitoredAgentAsync</summary>
        public async Task EnableMonitoredAgentRequestObjectAsync()
        {
            // Snippet: EnableMonitoredAgentAsync(EnableMonitoredAgentRequest, CallSettings)
            // Additional: EnableMonitoredAgentAsync(EnableMonitoredAgentRequest, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            EnableMonitoredAgentRequest request = new EnableMonitoredAgentRequest
            {
                MonitoredAgentName = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]"),
            };
            // Make the request
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> response = await agentAnomalyDetectionServiceClient.EnableMonitoredAgentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MonitoredAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceEnableMonitoredAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableMonitoredAgent</summary>
        public void EnableMonitoredAgent()
        {
            // Snippet: EnableMonitoredAgent(string, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]";
            // Make the request
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> response = agentAnomalyDetectionServiceClient.EnableMonitoredAgent(name);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MonitoredAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceEnableMonitoredAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableMonitoredAgentAsync</summary>
        public async Task EnableMonitoredAgentAsync()
        {
            // Snippet: EnableMonitoredAgentAsync(string, CallSettings)
            // Additional: EnableMonitoredAgentAsync(string, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]";
            // Make the request
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> response = await agentAnomalyDetectionServiceClient.EnableMonitoredAgentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MonitoredAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceEnableMonitoredAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableMonitoredAgent</summary>
        public void EnableMonitoredAgentResourceNames()
        {
            // Snippet: EnableMonitoredAgent(MonitoredAgentName, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            MonitoredAgentName name = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]");
            // Make the request
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> response = agentAnomalyDetectionServiceClient.EnableMonitoredAgent(name);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MonitoredAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceEnableMonitoredAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableMonitoredAgentAsync</summary>
        public async Task EnableMonitoredAgentResourceNamesAsync()
        {
            // Snippet: EnableMonitoredAgentAsync(MonitoredAgentName, CallSettings)
            // Additional: EnableMonitoredAgentAsync(MonitoredAgentName, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            MonitoredAgentName name = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]");
            // Make the request
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> response = await agentAnomalyDetectionServiceClient.EnableMonitoredAgentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MonitoredAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceEnableMonitoredAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableMonitoredAgent</summary>
        public void DisableMonitoredAgentRequestObject()
        {
            // Snippet: DisableMonitoredAgent(DisableMonitoredAgentRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            DisableMonitoredAgentRequest request = new DisableMonitoredAgentRequest
            {
                MonitoredAgentName = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]"),
            };
            // Make the request
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> response = agentAnomalyDetectionServiceClient.DisableMonitoredAgent(request);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MonitoredAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceDisableMonitoredAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableMonitoredAgentAsync</summary>
        public async Task DisableMonitoredAgentRequestObjectAsync()
        {
            // Snippet: DisableMonitoredAgentAsync(DisableMonitoredAgentRequest, CallSettings)
            // Additional: DisableMonitoredAgentAsync(DisableMonitoredAgentRequest, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DisableMonitoredAgentRequest request = new DisableMonitoredAgentRequest
            {
                MonitoredAgentName = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]"),
            };
            // Make the request
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> response = await agentAnomalyDetectionServiceClient.DisableMonitoredAgentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MonitoredAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceDisableMonitoredAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableMonitoredAgent</summary>
        public void DisableMonitoredAgent()
        {
            // Snippet: DisableMonitoredAgent(string, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]";
            // Make the request
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> response = agentAnomalyDetectionServiceClient.DisableMonitoredAgent(name);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MonitoredAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceDisableMonitoredAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableMonitoredAgentAsync</summary>
        public async Task DisableMonitoredAgentAsync()
        {
            // Snippet: DisableMonitoredAgentAsync(string, CallSettings)
            // Additional: DisableMonitoredAgentAsync(string, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]";
            // Make the request
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> response = await agentAnomalyDetectionServiceClient.DisableMonitoredAgentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MonitoredAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceDisableMonitoredAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableMonitoredAgent</summary>
        public void DisableMonitoredAgentResourceNames()
        {
            // Snippet: DisableMonitoredAgent(MonitoredAgentName, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            MonitoredAgentName name = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]");
            // Make the request
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> response = agentAnomalyDetectionServiceClient.DisableMonitoredAgent(name);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MonitoredAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceDisableMonitoredAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableMonitoredAgentAsync</summary>
        public async Task DisableMonitoredAgentResourceNamesAsync()
        {
            // Snippet: DisableMonitoredAgentAsync(MonitoredAgentName, CallSettings)
            // Additional: DisableMonitoredAgentAsync(MonitoredAgentName, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            MonitoredAgentName name = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]");
            // Make the request
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> response = await agentAnomalyDetectionServiceClient.DisableMonitoredAgentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MonitoredAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceDisableMonitoredAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentAnomalyDetectionScope</summary>
        public void DeleteAgentAnomalyDetectionScopeRequestObject()
        {
            // Snippet: DeleteAgentAnomalyDetectionScope(DeleteAgentAnomalyDetectionScopeRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            DeleteAgentAnomalyDetectionScopeRequest request = new DeleteAgentAnomalyDetectionScopeRequest
            {
                AgentAnomalyDetectionScopeName = AgentAnomalyDetectionScopeName.FromProjectLocationAgentAnomalyDetectionScope("[PROJECT]", "[LOCATION]", "[AGENT_ANOMALY_DETECTION_SCOPE]"),
            };
            // Make the request
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> response = agentAnomalyDetectionServiceClient.DeleteAgentAnomalyDetectionScope(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceDeleteAgentAnomalyDetectionScope(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentAnomalyDetectionScopeAsync</summary>
        public async Task DeleteAgentAnomalyDetectionScopeRequestObjectAsync()
        {
            // Snippet: DeleteAgentAnomalyDetectionScopeAsync(DeleteAgentAnomalyDetectionScopeRequest, CallSettings)
            // Additional: DeleteAgentAnomalyDetectionScopeAsync(DeleteAgentAnomalyDetectionScopeRequest, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAgentAnomalyDetectionScopeRequest request = new DeleteAgentAnomalyDetectionScopeRequest
            {
                AgentAnomalyDetectionScopeName = AgentAnomalyDetectionScopeName.FromProjectLocationAgentAnomalyDetectionScope("[PROJECT]", "[LOCATION]", "[AGENT_ANOMALY_DETECTION_SCOPE]"),
            };
            // Make the request
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> response = await agentAnomalyDetectionServiceClient.DeleteAgentAnomalyDetectionScopeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceDeleteAgentAnomalyDetectionScopeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentAnomalyDetectionScope</summary>
        public void DeleteAgentAnomalyDetectionScope()
        {
            // Snippet: DeleteAgentAnomalyDetectionScope(string, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agentAnomalyDetectionScopes/[AGENT_ANOMALY_DETECTION_SCOPE]";
            // Make the request
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> response = agentAnomalyDetectionServiceClient.DeleteAgentAnomalyDetectionScope(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceDeleteAgentAnomalyDetectionScope(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentAnomalyDetectionScopeAsync</summary>
        public async Task DeleteAgentAnomalyDetectionScopeAsync()
        {
            // Snippet: DeleteAgentAnomalyDetectionScopeAsync(string, CallSettings)
            // Additional: DeleteAgentAnomalyDetectionScopeAsync(string, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agentAnomalyDetectionScopes/[AGENT_ANOMALY_DETECTION_SCOPE]";
            // Make the request
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> response = await agentAnomalyDetectionServiceClient.DeleteAgentAnomalyDetectionScopeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceDeleteAgentAnomalyDetectionScopeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentAnomalyDetectionScope</summary>
        public void DeleteAgentAnomalyDetectionScopeResourceNames()
        {
            // Snippet: DeleteAgentAnomalyDetectionScope(AgentAnomalyDetectionScopeName, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            AgentAnomalyDetectionScopeName name = AgentAnomalyDetectionScopeName.FromProjectLocationAgentAnomalyDetectionScope("[PROJECT]", "[LOCATION]", "[AGENT_ANOMALY_DETECTION_SCOPE]");
            // Make the request
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> response = agentAnomalyDetectionServiceClient.DeleteAgentAnomalyDetectionScope(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceDeleteAgentAnomalyDetectionScope(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentAnomalyDetectionScopeAsync</summary>
        public async Task DeleteAgentAnomalyDetectionScopeResourceNamesAsync()
        {
            // Snippet: DeleteAgentAnomalyDetectionScopeAsync(AgentAnomalyDetectionScopeName, CallSettings)
            // Additional: DeleteAgentAnomalyDetectionScopeAsync(AgentAnomalyDetectionScopeName, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            AgentAnomalyDetectionScopeName name = AgentAnomalyDetectionScopeName.FromProjectLocationAgentAnomalyDetectionScope("[PROJECT]", "[LOCATION]", "[AGENT_ANOMALY_DETECTION_SCOPE]");
            // Make the request
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> response = await agentAnomalyDetectionServiceClient.DeleteAgentAnomalyDetectionScopeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceDeleteAgentAnomalyDetectionScopeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAgentAnomalyDetectionScope</summary>
        public void CreateAgentAnomalyDetectionScopeRequestObject()
        {
            // Snippet: CreateAgentAnomalyDetectionScope(CreateAgentAnomalyDetectionScopeRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            CreateAgentAnomalyDetectionScopeRequest request = new CreateAgentAnomalyDetectionScopeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AgentAnomalyDetectionScope = new AgentAnomalyDetectionScope(),
                AgentAnomalyDetectionScopeId = "",
            };
            // Make the request
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> response = agentAnomalyDetectionServiceClient.CreateAgentAnomalyDetectionScope(request);

            // Poll until the returned long-running operation is complete
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AgentAnomalyDetectionScope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceCreateAgentAnomalyDetectionScope(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AgentAnomalyDetectionScope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAgentAnomalyDetectionScopeAsync</summary>
        public async Task CreateAgentAnomalyDetectionScopeRequestObjectAsync()
        {
            // Snippet: CreateAgentAnomalyDetectionScopeAsync(CreateAgentAnomalyDetectionScopeRequest, CallSettings)
            // Additional: CreateAgentAnomalyDetectionScopeAsync(CreateAgentAnomalyDetectionScopeRequest, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAgentAnomalyDetectionScopeRequest request = new CreateAgentAnomalyDetectionScopeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AgentAnomalyDetectionScope = new AgentAnomalyDetectionScope(),
                AgentAnomalyDetectionScopeId = "",
            };
            // Make the request
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> response = await agentAnomalyDetectionServiceClient.CreateAgentAnomalyDetectionScopeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AgentAnomalyDetectionScope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceCreateAgentAnomalyDetectionScopeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AgentAnomalyDetectionScope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAgentAnomalyDetectionScope</summary>
        public void CreateAgentAnomalyDetectionScope()
        {
            // Snippet: CreateAgentAnomalyDetectionScope(string, AgentAnomalyDetectionScope, string, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AgentAnomalyDetectionScope agentAnomalyDetectionScope = new AgentAnomalyDetectionScope();
            string agentAnomalyDetectionScopeId = "";
            // Make the request
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> response = agentAnomalyDetectionServiceClient.CreateAgentAnomalyDetectionScope(parent, agentAnomalyDetectionScope, agentAnomalyDetectionScopeId);

            // Poll until the returned long-running operation is complete
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AgentAnomalyDetectionScope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceCreateAgentAnomalyDetectionScope(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AgentAnomalyDetectionScope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAgentAnomalyDetectionScopeAsync</summary>
        public async Task CreateAgentAnomalyDetectionScopeAsync()
        {
            // Snippet: CreateAgentAnomalyDetectionScopeAsync(string, AgentAnomalyDetectionScope, string, CallSettings)
            // Additional: CreateAgentAnomalyDetectionScopeAsync(string, AgentAnomalyDetectionScope, string, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AgentAnomalyDetectionScope agentAnomalyDetectionScope = new AgentAnomalyDetectionScope();
            string agentAnomalyDetectionScopeId = "";
            // Make the request
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> response = await agentAnomalyDetectionServiceClient.CreateAgentAnomalyDetectionScopeAsync(parent, agentAnomalyDetectionScope, agentAnomalyDetectionScopeId);

            // Poll until the returned long-running operation is complete
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AgentAnomalyDetectionScope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceCreateAgentAnomalyDetectionScopeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AgentAnomalyDetectionScope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAgentAnomalyDetectionScope</summary>
        public void CreateAgentAnomalyDetectionScopeResourceNames()
        {
            // Snippet: CreateAgentAnomalyDetectionScope(LocationName, AgentAnomalyDetectionScope, string, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AgentAnomalyDetectionScope agentAnomalyDetectionScope = new AgentAnomalyDetectionScope();
            string agentAnomalyDetectionScopeId = "";
            // Make the request
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> response = agentAnomalyDetectionServiceClient.CreateAgentAnomalyDetectionScope(parent, agentAnomalyDetectionScope, agentAnomalyDetectionScopeId);

            // Poll until the returned long-running operation is complete
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AgentAnomalyDetectionScope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceCreateAgentAnomalyDetectionScope(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AgentAnomalyDetectionScope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAgentAnomalyDetectionScopeAsync</summary>
        public async Task CreateAgentAnomalyDetectionScopeResourceNamesAsync()
        {
            // Snippet: CreateAgentAnomalyDetectionScopeAsync(LocationName, AgentAnomalyDetectionScope, string, CallSettings)
            // Additional: CreateAgentAnomalyDetectionScopeAsync(LocationName, AgentAnomalyDetectionScope, string, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AgentAnomalyDetectionScope agentAnomalyDetectionScope = new AgentAnomalyDetectionScope();
            string agentAnomalyDetectionScopeId = "";
            // Make the request
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> response = await agentAnomalyDetectionServiceClient.CreateAgentAnomalyDetectionScopeAsync(parent, agentAnomalyDetectionScope, agentAnomalyDetectionScopeId);

            // Poll until the returned long-running operation is complete
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AgentAnomalyDetectionScope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceCreateAgentAnomalyDetectionScopeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AgentAnomalyDetectionScope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListAgentAnomalyDetectionScopes</summary>
        public void ListAgentAnomalyDetectionScopesRequestObject()
        {
            // Snippet: ListAgentAnomalyDetectionScopes(ListAgentAnomalyDetectionScopesRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            ListAgentAnomalyDetectionScopesRequest request = new ListAgentAnomalyDetectionScopesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope> response = agentAnomalyDetectionServiceClient.ListAgentAnomalyDetectionScopes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AgentAnomalyDetectionScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAgentAnomalyDetectionScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AgentAnomalyDetectionScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AgentAnomalyDetectionScope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AgentAnomalyDetectionScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgentAnomalyDetectionScopesAsync</summary>
        public async Task ListAgentAnomalyDetectionScopesRequestObjectAsync()
        {
            // Snippet: ListAgentAnomalyDetectionScopesAsync(ListAgentAnomalyDetectionScopesRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAgentAnomalyDetectionScopesRequest request = new ListAgentAnomalyDetectionScopesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope> response = agentAnomalyDetectionServiceClient.ListAgentAnomalyDetectionScopesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AgentAnomalyDetectionScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAgentAnomalyDetectionScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AgentAnomalyDetectionScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AgentAnomalyDetectionScope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AgentAnomalyDetectionScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgentAnomalyDetectionScopes</summary>
        public void ListAgentAnomalyDetectionScopes()
        {
            // Snippet: ListAgentAnomalyDetectionScopes(string, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope> response = agentAnomalyDetectionServiceClient.ListAgentAnomalyDetectionScopes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AgentAnomalyDetectionScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAgentAnomalyDetectionScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AgentAnomalyDetectionScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AgentAnomalyDetectionScope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AgentAnomalyDetectionScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgentAnomalyDetectionScopesAsync</summary>
        public async Task ListAgentAnomalyDetectionScopesAsync()
        {
            // Snippet: ListAgentAnomalyDetectionScopesAsync(string, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope> response = agentAnomalyDetectionServiceClient.ListAgentAnomalyDetectionScopesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AgentAnomalyDetectionScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAgentAnomalyDetectionScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AgentAnomalyDetectionScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AgentAnomalyDetectionScope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AgentAnomalyDetectionScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgentAnomalyDetectionScopes</summary>
        public void ListAgentAnomalyDetectionScopesResourceNames()
        {
            // Snippet: ListAgentAnomalyDetectionScopes(LocationName, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope> response = agentAnomalyDetectionServiceClient.ListAgentAnomalyDetectionScopes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AgentAnomalyDetectionScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAgentAnomalyDetectionScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AgentAnomalyDetectionScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AgentAnomalyDetectionScope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AgentAnomalyDetectionScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgentAnomalyDetectionScopesAsync</summary>
        public async Task ListAgentAnomalyDetectionScopesResourceNamesAsync()
        {
            // Snippet: ListAgentAnomalyDetectionScopesAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope> response = agentAnomalyDetectionServiceClient.ListAgentAnomalyDetectionScopesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AgentAnomalyDetectionScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAgentAnomalyDetectionScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AgentAnomalyDetectionScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AgentAnomalyDetectionScope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AgentAnomalyDetectionScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyzedSessions</summary>
        public void ListAnalyzedSessionsRequestObject()
        {
            // Snippet: ListAnalyzedSessions(ListAnalyzedSessionsRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            ListAnalyzedSessionsRequest request = new ListAnalyzedSessionsRequest
            {
                ParentAsMonitoredAgentName = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]"),
                Filter = "",
                View = AnalyzedSessionView.Unspecified,
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAnalyzedSessionsResponse, AnalyzedSession> response = agentAnomalyDetectionServiceClient.ListAnalyzedSessions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyzedSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalyzedSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzedSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzedSession> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzedSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyzedSessionsAsync</summary>
        public async Task ListAnalyzedSessionsRequestObjectAsync()
        {
            // Snippet: ListAnalyzedSessionsAsync(ListAnalyzedSessionsRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAnalyzedSessionsRequest request = new ListAnalyzedSessionsRequest
            {
                ParentAsMonitoredAgentName = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]"),
                Filter = "",
                View = AnalyzedSessionView.Unspecified,
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAnalyzedSessionsResponse, AnalyzedSession> response = agentAnomalyDetectionServiceClient.ListAnalyzedSessionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AnalyzedSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAnalyzedSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzedSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzedSession> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzedSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyzedSessions</summary>
        public void ListAnalyzedSessions()
        {
            // Snippet: ListAnalyzedSessions(string, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]";
            // Make the request
            PagedEnumerable<ListAnalyzedSessionsResponse, AnalyzedSession> response = agentAnomalyDetectionServiceClient.ListAnalyzedSessions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyzedSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalyzedSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzedSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzedSession> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzedSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyzedSessionsAsync</summary>
        public async Task ListAnalyzedSessionsAsync()
        {
            // Snippet: ListAnalyzedSessionsAsync(string, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]";
            // Make the request
            PagedAsyncEnumerable<ListAnalyzedSessionsResponse, AnalyzedSession> response = agentAnomalyDetectionServiceClient.ListAnalyzedSessionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AnalyzedSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAnalyzedSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzedSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzedSession> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzedSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyzedSessions</summary>
        public void ListAnalyzedSessionsResourceNames()
        {
            // Snippet: ListAnalyzedSessions(MonitoredAgentName, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            MonitoredAgentName parent = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]");
            // Make the request
            PagedEnumerable<ListAnalyzedSessionsResponse, AnalyzedSession> response = agentAnomalyDetectionServiceClient.ListAnalyzedSessions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyzedSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalyzedSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzedSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzedSession> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzedSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyzedSessionsAsync</summary>
        public async Task ListAnalyzedSessionsResourceNamesAsync()
        {
            // Snippet: ListAnalyzedSessionsAsync(MonitoredAgentName, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            MonitoredAgentName parent = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]");
            // Make the request
            PagedAsyncEnumerable<ListAnalyzedSessionsResponse, AnalyzedSession> response = agentAnomalyDetectionServiceClient.ListAnalyzedSessionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AnalyzedSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAnalyzedSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzedSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzedSession> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzedSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAnalyzedSession</summary>
        public void GetAnalyzedSessionRequestObject()
        {
            // Snippet: GetAnalyzedSession(GetAnalyzedSessionRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            GetAnalyzedSessionRequest request = new GetAnalyzedSessionRequest
            {
                AnalyzedSessionName = AnalyzedSessionName.FromProjectLocationMonitoredAgentAnalyzedSession("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]", "[ANALYZED_SESSION]"),
                View = AnalyzedSessionView.Unspecified,
            };
            // Make the request
            AnalyzedSession response = agentAnomalyDetectionServiceClient.GetAnalyzedSession(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnalyzedSessionAsync</summary>
        public async Task GetAnalyzedSessionRequestObjectAsync()
        {
            // Snippet: GetAnalyzedSessionAsync(GetAnalyzedSessionRequest, CallSettings)
            // Additional: GetAnalyzedSessionAsync(GetAnalyzedSessionRequest, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAnalyzedSessionRequest request = new GetAnalyzedSessionRequest
            {
                AnalyzedSessionName = AnalyzedSessionName.FromProjectLocationMonitoredAgentAnalyzedSession("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]", "[ANALYZED_SESSION]"),
                View = AnalyzedSessionView.Unspecified,
            };
            // Make the request
            AnalyzedSession response = await agentAnomalyDetectionServiceClient.GetAnalyzedSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnalyzedSession</summary>
        public void GetAnalyzedSession()
        {
            // Snippet: GetAnalyzedSession(string, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]/analyzedSessions/[ANALYZED_SESSION]";
            // Make the request
            AnalyzedSession response = agentAnomalyDetectionServiceClient.GetAnalyzedSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnalyzedSessionAsync</summary>
        public async Task GetAnalyzedSessionAsync()
        {
            // Snippet: GetAnalyzedSessionAsync(string, CallSettings)
            // Additional: GetAnalyzedSessionAsync(string, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]/analyzedSessions/[ANALYZED_SESSION]";
            // Make the request
            AnalyzedSession response = await agentAnomalyDetectionServiceClient.GetAnalyzedSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnalyzedSession</summary>
        public void GetAnalyzedSessionResourceNames()
        {
            // Snippet: GetAnalyzedSession(AnalyzedSessionName, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            AnalyzedSessionName name = AnalyzedSessionName.FromProjectLocationMonitoredAgentAnalyzedSession("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]", "[ANALYZED_SESSION]");
            // Make the request
            AnalyzedSession response = agentAnomalyDetectionServiceClient.GetAnalyzedSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnalyzedSessionAsync</summary>
        public async Task GetAnalyzedSessionResourceNamesAsync()
        {
            // Snippet: GetAnalyzedSessionAsync(AnalyzedSessionName, CallSettings)
            // Additional: GetAnalyzedSessionAsync(AnalyzedSessionName, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzedSessionName name = AnalyzedSessionName.FromProjectLocationMonitoredAgentAnalyzedSession("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]", "[ANALYZED_SESSION]");
            // Make the request
            AnalyzedSession response = await agentAnomalyDetectionServiceClient.GetAnalyzedSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAnalyzedInvocations</summary>
        public void ListAnalyzedInvocationsRequestObject()
        {
            // Snippet: ListAnalyzedInvocations(ListAnalyzedInvocationsRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            ListAnalyzedInvocationsRequest request = new ListAnalyzedInvocationsRequest
            {
                ParentAsAnalyzedSessionName = AnalyzedSessionName.FromProjectLocationMonitoredAgentAnalyzedSession("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]", "[ANALYZED_SESSION]"),
            };
            // Make the request
            PagedEnumerable<ListAnalyzedInvocationsResponse, AnalyzedInvocation> response = agentAnomalyDetectionServiceClient.ListAnalyzedInvocations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyzedInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalyzedInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzedInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzedInvocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzedInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyzedInvocationsAsync</summary>
        public async Task ListAnalyzedInvocationsRequestObjectAsync()
        {
            // Snippet: ListAnalyzedInvocationsAsync(ListAnalyzedInvocationsRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAnalyzedInvocationsRequest request = new ListAnalyzedInvocationsRequest
            {
                ParentAsAnalyzedSessionName = AnalyzedSessionName.FromProjectLocationMonitoredAgentAnalyzedSession("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]", "[ANALYZED_SESSION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAnalyzedInvocationsResponse, AnalyzedInvocation> response = agentAnomalyDetectionServiceClient.ListAnalyzedInvocationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AnalyzedInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAnalyzedInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzedInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzedInvocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzedInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyzedInvocations</summary>
        public void ListAnalyzedInvocations()
        {
            // Snippet: ListAnalyzedInvocations(string, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]/analyzedSessions/[ANALYZED_SESSION]";
            // Make the request
            PagedEnumerable<ListAnalyzedInvocationsResponse, AnalyzedInvocation> response = agentAnomalyDetectionServiceClient.ListAnalyzedInvocations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyzedInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalyzedInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzedInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzedInvocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzedInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyzedInvocationsAsync</summary>
        public async Task ListAnalyzedInvocationsAsync()
        {
            // Snippet: ListAnalyzedInvocationsAsync(string, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]/analyzedSessions/[ANALYZED_SESSION]";
            // Make the request
            PagedAsyncEnumerable<ListAnalyzedInvocationsResponse, AnalyzedInvocation> response = agentAnomalyDetectionServiceClient.ListAnalyzedInvocationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AnalyzedInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAnalyzedInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzedInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzedInvocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzedInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyzedInvocations</summary>
        public void ListAnalyzedInvocationsResourceNames()
        {
            // Snippet: ListAnalyzedInvocations(AnalyzedSessionName, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            AnalyzedSessionName parent = AnalyzedSessionName.FromProjectLocationMonitoredAgentAnalyzedSession("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]", "[ANALYZED_SESSION]");
            // Make the request
            PagedEnumerable<ListAnalyzedInvocationsResponse, AnalyzedInvocation> response = agentAnomalyDetectionServiceClient.ListAnalyzedInvocations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyzedInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalyzedInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzedInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzedInvocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzedInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyzedInvocationsAsync</summary>
        public async Task ListAnalyzedInvocationsResourceNamesAsync()
        {
            // Snippet: ListAnalyzedInvocationsAsync(AnalyzedSessionName, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzedSessionName parent = AnalyzedSessionName.FromProjectLocationMonitoredAgentAnalyzedSession("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]", "[ANALYZED_SESSION]");
            // Make the request
            PagedAsyncEnumerable<ListAnalyzedInvocationsResponse, AnalyzedInvocation> response = agentAnomalyDetectionServiceClient.ListAnalyzedInvocationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AnalyzedInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAnalyzedInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzedInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzedInvocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzedInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAnalyzedInvocation</summary>
        public void GetAnalyzedInvocationRequestObject()
        {
            // Snippet: GetAnalyzedInvocation(GetAnalyzedInvocationRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            GetAnalyzedInvocationRequest request = new GetAnalyzedInvocationRequest
            {
                AnalyzedInvocationName = AnalyzedInvocationName.FromProjectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]", "[ANALYZED_SESSION]", "[ANALYZED_INVOCATION]"),
            };
            // Make the request
            AnalyzedInvocation response = agentAnomalyDetectionServiceClient.GetAnalyzedInvocation(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnalyzedInvocationAsync</summary>
        public async Task GetAnalyzedInvocationRequestObjectAsync()
        {
            // Snippet: GetAnalyzedInvocationAsync(GetAnalyzedInvocationRequest, CallSettings)
            // Additional: GetAnalyzedInvocationAsync(GetAnalyzedInvocationRequest, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAnalyzedInvocationRequest request = new GetAnalyzedInvocationRequest
            {
                AnalyzedInvocationName = AnalyzedInvocationName.FromProjectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]", "[ANALYZED_SESSION]", "[ANALYZED_INVOCATION]"),
            };
            // Make the request
            AnalyzedInvocation response = await agentAnomalyDetectionServiceClient.GetAnalyzedInvocationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnalyzedInvocation</summary>
        public void GetAnalyzedInvocation()
        {
            // Snippet: GetAnalyzedInvocation(string, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]/analyzedSessions/[ANALYZED_SESSION]/analyzedInvocations/[ANALYZED_INVOCATION]";
            // Make the request
            AnalyzedInvocation response = agentAnomalyDetectionServiceClient.GetAnalyzedInvocation(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnalyzedInvocationAsync</summary>
        public async Task GetAnalyzedInvocationAsync()
        {
            // Snippet: GetAnalyzedInvocationAsync(string, CallSettings)
            // Additional: GetAnalyzedInvocationAsync(string, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]/analyzedSessions/[ANALYZED_SESSION]/analyzedInvocations/[ANALYZED_INVOCATION]";
            // Make the request
            AnalyzedInvocation response = await agentAnomalyDetectionServiceClient.GetAnalyzedInvocationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnalyzedInvocation</summary>
        public void GetAnalyzedInvocationResourceNames()
        {
            // Snippet: GetAnalyzedInvocation(AnalyzedInvocationName, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            AnalyzedInvocationName name = AnalyzedInvocationName.FromProjectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]", "[ANALYZED_SESSION]", "[ANALYZED_INVOCATION]");
            // Make the request
            AnalyzedInvocation response = agentAnomalyDetectionServiceClient.GetAnalyzedInvocation(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnalyzedInvocationAsync</summary>
        public async Task GetAnalyzedInvocationResourceNamesAsync()
        {
            // Snippet: GetAnalyzedInvocationAsync(AnalyzedInvocationName, CallSettings)
            // Additional: GetAnalyzedInvocationAsync(AnalyzedInvocationName, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzedInvocationName name = AnalyzedInvocationName.FromProjectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]", "[ANALYZED_SESSION]", "[ANALYZED_INVOCATION]");
            // Make the request
            AnalyzedInvocation response = await agentAnomalyDetectionServiceClient.GetAnalyzedInvocationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for AggregateAnalyzedSessions</summary>
        public void AggregateAnalyzedSessionsRequestObject()
        {
            // Snippet: AggregateAnalyzedSessions(AggregateAnalyzedSessionsRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            AggregateAnalyzedSessionsRequest request = new AggregateAnalyzedSessionsRequest
            {
                ParentAsMonitoredAgentName = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate> response = agentAnomalyDetectionServiceClient.AggregateAnalyzedSessions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AggregateAnalyzedSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AggregateAnalyzedSessionsResponse.Types.AgentAggregate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregateAnalyzedSessionsAsync</summary>
        public async Task AggregateAnalyzedSessionsRequestObjectAsync()
        {
            // Snippet: AggregateAnalyzedSessionsAsync(AggregateAnalyzedSessionsRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            AggregateAnalyzedSessionsRequest request = new AggregateAnalyzedSessionsRequest
            {
                ParentAsMonitoredAgentName = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate> response = agentAnomalyDetectionServiceClient.AggregateAnalyzedSessionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (AggregateAnalyzedSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AggregateAnalyzedSessionsResponse.Types.AgentAggregate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregateAnalyzedSessions</summary>
        public void AggregateAnalyzedSessions()
        {
            // Snippet: AggregateAnalyzedSessions(string, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]";
            // Make the request
            PagedEnumerable<AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate> response = agentAnomalyDetectionServiceClient.AggregateAnalyzedSessions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AggregateAnalyzedSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AggregateAnalyzedSessionsResponse.Types.AgentAggregate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregateAnalyzedSessionsAsync</summary>
        public async Task AggregateAnalyzedSessionsAsync()
        {
            // Snippet: AggregateAnalyzedSessionsAsync(string, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]";
            // Make the request
            PagedAsyncEnumerable<AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate> response = agentAnomalyDetectionServiceClient.AggregateAnalyzedSessionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (AggregateAnalyzedSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AggregateAnalyzedSessionsResponse.Types.AgentAggregate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregateAnalyzedSessions</summary>
        public void AggregateAnalyzedSessionsResourceNames()
        {
            // Snippet: AggregateAnalyzedSessions(MonitoredAgentName, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            MonitoredAgentName parent = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]");
            // Make the request
            PagedEnumerable<AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate> response = agentAnomalyDetectionServiceClient.AggregateAnalyzedSessions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AggregateAnalyzedSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AggregateAnalyzedSessionsResponse.Types.AgentAggregate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregateAnalyzedSessionsAsync</summary>
        public async Task AggregateAnalyzedSessionsResourceNamesAsync()
        {
            // Snippet: AggregateAnalyzedSessionsAsync(MonitoredAgentName, string, int?, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            MonitoredAgentName parent = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]");
            // Make the request
            PagedAsyncEnumerable<AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate> response = agentAnomalyDetectionServiceClient.AggregateAnalyzedSessionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (AggregateAnalyzedSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AggregateAnalyzedSessionsResponse.Types.AgentAggregate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AggregateAnalyzedSessionsResponse.Types.AgentAggregate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ClearTrainingData</summary>
        public void ClearTrainingDataRequestObject()
        {
            // Snippet: ClearTrainingData(ClearTrainingDataRequest, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            ClearTrainingDataRequest request = new ClearTrainingDataRequest
            {
                MonitoredAgentName = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]"),
            };
            // Make the request
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> response = agentAnomalyDetectionServiceClient.ClearTrainingData(request);

            // Poll until the returned long-running operation is complete
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClearTrainingDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceClearTrainingData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClearTrainingDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ClearTrainingDataAsync</summary>
        public async Task ClearTrainingDataRequestObjectAsync()
        {
            // Snippet: ClearTrainingDataAsync(ClearTrainingDataRequest, CallSettings)
            // Additional: ClearTrainingDataAsync(ClearTrainingDataRequest, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClearTrainingDataRequest request = new ClearTrainingDataRequest
            {
                MonitoredAgentName = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]"),
            };
            // Make the request
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> response = await agentAnomalyDetectionServiceClient.ClearTrainingDataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClearTrainingDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceClearTrainingDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClearTrainingDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ClearTrainingData</summary>
        public void ClearTrainingData()
        {
            // Snippet: ClearTrainingData(string, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]";
            // Make the request
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> response = agentAnomalyDetectionServiceClient.ClearTrainingData(name);

            // Poll until the returned long-running operation is complete
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClearTrainingDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceClearTrainingData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClearTrainingDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ClearTrainingDataAsync</summary>
        public async Task ClearTrainingDataAsync()
        {
            // Snippet: ClearTrainingDataAsync(string, CallSettings)
            // Additional: ClearTrainingDataAsync(string, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/monitoredAgents/[MONITORED_AGENT]";
            // Make the request
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> response = await agentAnomalyDetectionServiceClient.ClearTrainingDataAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClearTrainingDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceClearTrainingDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClearTrainingDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ClearTrainingData</summary>
        public void ClearTrainingDataResourceNames()
        {
            // Snippet: ClearTrainingData(MonitoredAgentName, CallSettings)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            MonitoredAgentName name = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]");
            // Make the request
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> response = agentAnomalyDetectionServiceClient.ClearTrainingData(name);

            // Poll until the returned long-running operation is complete
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClearTrainingDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceClearTrainingData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClearTrainingDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ClearTrainingDataAsync</summary>
        public async Task ClearTrainingDataResourceNamesAsync()
        {
            // Snippet: ClearTrainingDataAsync(MonitoredAgentName, CallSettings)
            // Additional: ClearTrainingDataAsync(MonitoredAgentName, CancellationToken)
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = await AgentAnomalyDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            MonitoredAgentName name = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]");
            // Make the request
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> response = await agentAnomalyDetectionServiceClient.ClearTrainingDataAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClearTrainingDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> retrievedResponse = await agentAnomalyDetectionServiceClient.PollOnceClearTrainingDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClearTrainingDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
