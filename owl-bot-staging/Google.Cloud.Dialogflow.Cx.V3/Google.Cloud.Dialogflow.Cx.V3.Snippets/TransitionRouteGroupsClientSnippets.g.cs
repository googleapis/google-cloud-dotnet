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
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTransitionRouteGroupsClientSnippets
    {
        /// <summary>Snippet for ListTransitionRouteGroups</summary>
        public void ListTransitionRouteGroupsRequestObject()
        {
            // Snippet: ListTransitionRouteGroups(ListTransitionRouteGroupsRequest, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            ListTransitionRouteGroupsRequest request = new ListTransitionRouteGroupsRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> response = transitionRouteGroupsClient.ListTransitionRouteGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TransitionRouteGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransitionRouteGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransitionRouteGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransitionRouteGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransitionRouteGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransitionRouteGroupsAsync</summary>
        public async Task ListTransitionRouteGroupsRequestObjectAsync()
        {
            // Snippet: ListTransitionRouteGroupsAsync(ListTransitionRouteGroupsRequest, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListTransitionRouteGroupsRequest request = new ListTransitionRouteGroupsRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> response = transitionRouteGroupsClient.ListTransitionRouteGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TransitionRouteGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTransitionRouteGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransitionRouteGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransitionRouteGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransitionRouteGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransitionRouteGroups</summary>
        public void ListTransitionRouteGroups()
        {
            // Snippet: ListTransitionRouteGroups(string, string, int?, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            // Make the request
            PagedEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> response = transitionRouteGroupsClient.ListTransitionRouteGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TransitionRouteGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransitionRouteGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransitionRouteGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransitionRouteGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransitionRouteGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransitionRouteGroupsAsync</summary>
        public async Task ListTransitionRouteGroupsAsync()
        {
            // Snippet: ListTransitionRouteGroupsAsync(string, string, int?, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            // Make the request
            PagedAsyncEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> response = transitionRouteGroupsClient.ListTransitionRouteGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TransitionRouteGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTransitionRouteGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransitionRouteGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransitionRouteGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransitionRouteGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransitionRouteGroups</summary>
        public void ListTransitionRouteGroupsResourceNames1()
        {
            // Snippet: ListTransitionRouteGroups(FlowName, string, int?, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            FlowName parent = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            // Make the request
            PagedEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> response = transitionRouteGroupsClient.ListTransitionRouteGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TransitionRouteGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransitionRouteGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransitionRouteGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransitionRouteGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransitionRouteGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransitionRouteGroupsAsync</summary>
        public async Task ListTransitionRouteGroupsResourceNames1Async()
        {
            // Snippet: ListTransitionRouteGroupsAsync(FlowName, string, int?, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            FlowName parent = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            // Make the request
            PagedAsyncEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> response = transitionRouteGroupsClient.ListTransitionRouteGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TransitionRouteGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTransitionRouteGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransitionRouteGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransitionRouteGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransitionRouteGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransitionRouteGroups</summary>
        public void ListTransitionRouteGroupsResourceNames2()
        {
            // Snippet: ListTransitionRouteGroups(AgentName, string, int?, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> response = transitionRouteGroupsClient.ListTransitionRouteGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TransitionRouteGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransitionRouteGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransitionRouteGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransitionRouteGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransitionRouteGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransitionRouteGroupsAsync</summary>
        public async Task ListTransitionRouteGroupsResourceNames2Async()
        {
            // Snippet: ListTransitionRouteGroupsAsync(AgentName, string, int?, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedAsyncEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> response = transitionRouteGroupsClient.ListTransitionRouteGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TransitionRouteGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTransitionRouteGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransitionRouteGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransitionRouteGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransitionRouteGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTransitionRouteGroup</summary>
        public void GetTransitionRouteGroupRequestObject()
        {
            // Snippet: GetTransitionRouteGroup(GetTransitionRouteGroupRequest, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            GetTransitionRouteGroupRequest request = new GetTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                LanguageCode = "",
            };
            // Make the request
            TransitionRouteGroup response = transitionRouteGroupsClient.GetTransitionRouteGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransitionRouteGroupAsync</summary>
        public async Task GetTransitionRouteGroupRequestObjectAsync()
        {
            // Snippet: GetTransitionRouteGroupAsync(GetTransitionRouteGroupRequest, CallSettings)
            // Additional: GetTransitionRouteGroupAsync(GetTransitionRouteGroupRequest, CancellationToken)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetTransitionRouteGroupRequest request = new GetTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                LanguageCode = "",
            };
            // Make the request
            TransitionRouteGroup response = await transitionRouteGroupsClient.GetTransitionRouteGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransitionRouteGroup</summary>
        public void GetTransitionRouteGroup()
        {
            // Snippet: GetTransitionRouteGroup(string, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/transitionRouteGroups/[TRANSITION_ROUTE_GROUP]";
            // Make the request
            TransitionRouteGroup response = transitionRouteGroupsClient.GetTransitionRouteGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransitionRouteGroupAsync</summary>
        public async Task GetTransitionRouteGroupAsync()
        {
            // Snippet: GetTransitionRouteGroupAsync(string, CallSettings)
            // Additional: GetTransitionRouteGroupAsync(string, CancellationToken)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/transitionRouteGroups/[TRANSITION_ROUTE_GROUP]";
            // Make the request
            TransitionRouteGroup response = await transitionRouteGroupsClient.GetTransitionRouteGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransitionRouteGroup</summary>
        public void GetTransitionRouteGroupResourceNames()
        {
            // Snippet: GetTransitionRouteGroup(TransitionRouteGroupName, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            TransitionRouteGroupName name = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]");
            // Make the request
            TransitionRouteGroup response = transitionRouteGroupsClient.GetTransitionRouteGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransitionRouteGroupAsync</summary>
        public async Task GetTransitionRouteGroupResourceNamesAsync()
        {
            // Snippet: GetTransitionRouteGroupAsync(TransitionRouteGroupName, CallSettings)
            // Additional: GetTransitionRouteGroupAsync(TransitionRouteGroupName, CancellationToken)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            TransitionRouteGroupName name = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]");
            // Make the request
            TransitionRouteGroup response = await transitionRouteGroupsClient.GetTransitionRouteGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTransitionRouteGroup</summary>
        public void CreateTransitionRouteGroupRequestObject()
        {
            // Snippet: CreateTransitionRouteGroup(CreateTransitionRouteGroupRequest, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            CreateTransitionRouteGroupRequest request = new CreateTransitionRouteGroupRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                TransitionRouteGroup = new TransitionRouteGroup(),
                LanguageCode = "",
            };
            // Make the request
            TransitionRouteGroup response = transitionRouteGroupsClient.CreateTransitionRouteGroup(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTransitionRouteGroupAsync</summary>
        public async Task CreateTransitionRouteGroupRequestObjectAsync()
        {
            // Snippet: CreateTransitionRouteGroupAsync(CreateTransitionRouteGroupRequest, CallSettings)
            // Additional: CreateTransitionRouteGroupAsync(CreateTransitionRouteGroupRequest, CancellationToken)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            CreateTransitionRouteGroupRequest request = new CreateTransitionRouteGroupRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                TransitionRouteGroup = new TransitionRouteGroup(),
                LanguageCode = "",
            };
            // Make the request
            TransitionRouteGroup response = await transitionRouteGroupsClient.CreateTransitionRouteGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTransitionRouteGroup</summary>
        public void CreateTransitionRouteGroup()
        {
            // Snippet: CreateTransitionRouteGroup(string, TransitionRouteGroup, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            TransitionRouteGroup transitionRouteGroup = new TransitionRouteGroup();
            // Make the request
            TransitionRouteGroup response = transitionRouteGroupsClient.CreateTransitionRouteGroup(parent, transitionRouteGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateTransitionRouteGroupAsync</summary>
        public async Task CreateTransitionRouteGroupAsync()
        {
            // Snippet: CreateTransitionRouteGroupAsync(string, TransitionRouteGroup, CallSettings)
            // Additional: CreateTransitionRouteGroupAsync(string, TransitionRouteGroup, CancellationToken)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            TransitionRouteGroup transitionRouteGroup = new TransitionRouteGroup();
            // Make the request
            TransitionRouteGroup response = await transitionRouteGroupsClient.CreateTransitionRouteGroupAsync(parent, transitionRouteGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateTransitionRouteGroup</summary>
        public void CreateTransitionRouteGroupResourceNames1()
        {
            // Snippet: CreateTransitionRouteGroup(FlowName, TransitionRouteGroup, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            FlowName parent = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            TransitionRouteGroup transitionRouteGroup = new TransitionRouteGroup();
            // Make the request
            TransitionRouteGroup response = transitionRouteGroupsClient.CreateTransitionRouteGroup(parent, transitionRouteGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateTransitionRouteGroupAsync</summary>
        public async Task CreateTransitionRouteGroupResourceNames1Async()
        {
            // Snippet: CreateTransitionRouteGroupAsync(FlowName, TransitionRouteGroup, CallSettings)
            // Additional: CreateTransitionRouteGroupAsync(FlowName, TransitionRouteGroup, CancellationToken)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            FlowName parent = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            TransitionRouteGroup transitionRouteGroup = new TransitionRouteGroup();
            // Make the request
            TransitionRouteGroup response = await transitionRouteGroupsClient.CreateTransitionRouteGroupAsync(parent, transitionRouteGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateTransitionRouteGroup</summary>
        public void CreateTransitionRouteGroupResourceNames2()
        {
            // Snippet: CreateTransitionRouteGroup(AgentName, TransitionRouteGroup, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            TransitionRouteGroup transitionRouteGroup = new TransitionRouteGroup();
            // Make the request
            TransitionRouteGroup response = transitionRouteGroupsClient.CreateTransitionRouteGroup(parent, transitionRouteGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateTransitionRouteGroupAsync</summary>
        public async Task CreateTransitionRouteGroupResourceNames2Async()
        {
            // Snippet: CreateTransitionRouteGroupAsync(AgentName, TransitionRouteGroup, CallSettings)
            // Additional: CreateTransitionRouteGroupAsync(AgentName, TransitionRouteGroup, CancellationToken)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            TransitionRouteGroup transitionRouteGroup = new TransitionRouteGroup();
            // Make the request
            TransitionRouteGroup response = await transitionRouteGroupsClient.CreateTransitionRouteGroupAsync(parent, transitionRouteGroup);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransitionRouteGroup</summary>
        public void UpdateTransitionRouteGroupRequestObject()
        {
            // Snippet: UpdateTransitionRouteGroup(UpdateTransitionRouteGroupRequest, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            UpdateTransitionRouteGroupRequest request = new UpdateTransitionRouteGroupRequest
            {
                TransitionRouteGroup = new TransitionRouteGroup(),
                UpdateMask = new FieldMask(),
                LanguageCode = "",
            };
            // Make the request
            TransitionRouteGroup response = transitionRouteGroupsClient.UpdateTransitionRouteGroup(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransitionRouteGroupAsync</summary>
        public async Task UpdateTransitionRouteGroupRequestObjectAsync()
        {
            // Snippet: UpdateTransitionRouteGroupAsync(UpdateTransitionRouteGroupRequest, CallSettings)
            // Additional: UpdateTransitionRouteGroupAsync(UpdateTransitionRouteGroupRequest, CancellationToken)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTransitionRouteGroupRequest request = new UpdateTransitionRouteGroupRequest
            {
                TransitionRouteGroup = new TransitionRouteGroup(),
                UpdateMask = new FieldMask(),
                LanguageCode = "",
            };
            // Make the request
            TransitionRouteGroup response = await transitionRouteGroupsClient.UpdateTransitionRouteGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransitionRouteGroup</summary>
        public void UpdateTransitionRouteGroup()
        {
            // Snippet: UpdateTransitionRouteGroup(TransitionRouteGroup, FieldMask, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            TransitionRouteGroup transitionRouteGroup = new TransitionRouteGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TransitionRouteGroup response = transitionRouteGroupsClient.UpdateTransitionRouteGroup(transitionRouteGroup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransitionRouteGroupAsync</summary>
        public async Task UpdateTransitionRouteGroupAsync()
        {
            // Snippet: UpdateTransitionRouteGroupAsync(TransitionRouteGroup, FieldMask, CallSettings)
            // Additional: UpdateTransitionRouteGroupAsync(TransitionRouteGroup, FieldMask, CancellationToken)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            TransitionRouteGroup transitionRouteGroup = new TransitionRouteGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TransitionRouteGroup response = await transitionRouteGroupsClient.UpdateTransitionRouteGroupAsync(transitionRouteGroup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransitionRouteGroup</summary>
        public void DeleteTransitionRouteGroupRequestObject()
        {
            // Snippet: DeleteTransitionRouteGroup(DeleteTransitionRouteGroupRequest, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            DeleteTransitionRouteGroupRequest request = new DeleteTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                Force = false,
            };
            // Make the request
            transitionRouteGroupsClient.DeleteTransitionRouteGroup(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransitionRouteGroupAsync</summary>
        public async Task DeleteTransitionRouteGroupRequestObjectAsync()
        {
            // Snippet: DeleteTransitionRouteGroupAsync(DeleteTransitionRouteGroupRequest, CallSettings)
            // Additional: DeleteTransitionRouteGroupAsync(DeleteTransitionRouteGroupRequest, CancellationToken)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTransitionRouteGroupRequest request = new DeleteTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                Force = false,
            };
            // Make the request
            await transitionRouteGroupsClient.DeleteTransitionRouteGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransitionRouteGroup</summary>
        public void DeleteTransitionRouteGroup()
        {
            // Snippet: DeleteTransitionRouteGroup(string, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/transitionRouteGroups/[TRANSITION_ROUTE_GROUP]";
            // Make the request
            transitionRouteGroupsClient.DeleteTransitionRouteGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransitionRouteGroupAsync</summary>
        public async Task DeleteTransitionRouteGroupAsync()
        {
            // Snippet: DeleteTransitionRouteGroupAsync(string, CallSettings)
            // Additional: DeleteTransitionRouteGroupAsync(string, CancellationToken)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/transitionRouteGroups/[TRANSITION_ROUTE_GROUP]";
            // Make the request
            await transitionRouteGroupsClient.DeleteTransitionRouteGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransitionRouteGroup</summary>
        public void DeleteTransitionRouteGroupResourceNames()
        {
            // Snippet: DeleteTransitionRouteGroup(TransitionRouteGroupName, CallSettings)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = TransitionRouteGroupsClient.Create();
            // Initialize request argument(s)
            TransitionRouteGroupName name = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]");
            // Make the request
            transitionRouteGroupsClient.DeleteTransitionRouteGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransitionRouteGroupAsync</summary>
        public async Task DeleteTransitionRouteGroupResourceNamesAsync()
        {
            // Snippet: DeleteTransitionRouteGroupAsync(TransitionRouteGroupName, CallSettings)
            // Additional: DeleteTransitionRouteGroupAsync(TransitionRouteGroupName, CancellationToken)
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            TransitionRouteGroupName name = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]");
            // Make the request
            await transitionRouteGroupsClient.DeleteTransitionRouteGroupAsync(name);
            // End snippet
        }
    }
}
