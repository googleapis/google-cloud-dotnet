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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTeamServiceClientSnippets
    {
        /// <summary>Snippet for GetTeam</summary>
        public void GetTeamRequestObject()
        {
            // Snippet: GetTeam(GetTeamRequest, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            GetTeamRequest request = new GetTeamRequest
            {
                TeamName = TeamName.FromNetworkCodeTeam("[NETWORK_CODE]", "[TEAM]"),
            };
            // Make the request
            Team response = teamServiceClient.GetTeam(request);
            // End snippet
        }

        /// <summary>Snippet for GetTeamAsync</summary>
        public async Task GetTeamRequestObjectAsync()
        {
            // Snippet: GetTeamAsync(GetTeamRequest, CallSettings)
            // Additional: GetTeamAsync(GetTeamRequest, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTeamRequest request = new GetTeamRequest
            {
                TeamName = TeamName.FromNetworkCodeTeam("[NETWORK_CODE]", "[TEAM]"),
            };
            // Make the request
            Team response = await teamServiceClient.GetTeamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTeam</summary>
        public void GetTeam()
        {
            // Snippet: GetTeam(string, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/teams/[TEAM]";
            // Make the request
            Team response = teamServiceClient.GetTeam(name);
            // End snippet
        }

        /// <summary>Snippet for GetTeamAsync</summary>
        public async Task GetTeamAsync()
        {
            // Snippet: GetTeamAsync(string, CallSettings)
            // Additional: GetTeamAsync(string, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/teams/[TEAM]";
            // Make the request
            Team response = await teamServiceClient.GetTeamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTeam</summary>
        public void GetTeamResourceNames()
        {
            // Snippet: GetTeam(TeamName, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            TeamName name = TeamName.FromNetworkCodeTeam("[NETWORK_CODE]", "[TEAM]");
            // Make the request
            Team response = teamServiceClient.GetTeam(name);
            // End snippet
        }

        /// <summary>Snippet for GetTeamAsync</summary>
        public async Task GetTeamResourceNamesAsync()
        {
            // Snippet: GetTeamAsync(TeamName, CallSettings)
            // Additional: GetTeamAsync(TeamName, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            TeamName name = TeamName.FromNetworkCodeTeam("[NETWORK_CODE]", "[TEAM]");
            // Make the request
            Team response = await teamServiceClient.GetTeamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTeams</summary>
        public void ListTeamsRequestObject()
        {
            // Snippet: ListTeams(ListTeamsRequest, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            ListTeamsRequest request = new ListTeamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListTeamsResponse, Team> response = teamServiceClient.ListTeams(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Team item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTeamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Team item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Team> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Team item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTeamsAsync</summary>
        public async Task ListTeamsRequestObjectAsync()
        {
            // Snippet: ListTeamsAsync(ListTeamsRequest, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTeamsRequest request = new ListTeamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListTeamsResponse, Team> response = teamServiceClient.ListTeamsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Team item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTeamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Team item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Team> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Team item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTeams</summary>
        public void ListTeams()
        {
            // Snippet: ListTeams(string, string, int?, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListTeamsResponse, Team> response = teamServiceClient.ListTeams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Team item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTeamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Team item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Team> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Team item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTeamsAsync</summary>
        public async Task ListTeamsAsync()
        {
            // Snippet: ListTeamsAsync(string, string, int?, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListTeamsResponse, Team> response = teamServiceClient.ListTeamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Team item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTeamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Team item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Team> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Team item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTeams</summary>
        public void ListTeamsResourceNames()
        {
            // Snippet: ListTeams(NetworkName, string, int?, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListTeamsResponse, Team> response = teamServiceClient.ListTeams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Team item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTeamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Team item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Team> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Team item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTeamsAsync</summary>
        public async Task ListTeamsResourceNamesAsync()
        {
            // Snippet: ListTeamsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListTeamsResponse, Team> response = teamServiceClient.ListTeamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Team item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTeamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Team item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Team> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Team item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateTeam</summary>
        public void CreateTeamRequestObject()
        {
            // Snippet: CreateTeam(CreateTeamRequest, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            CreateTeamRequest request = new CreateTeamRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Team = new Team(),
            };
            // Make the request
            Team response = teamServiceClient.CreateTeam(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTeamAsync</summary>
        public async Task CreateTeamRequestObjectAsync()
        {
            // Snippet: CreateTeamAsync(CreateTeamRequest, CallSettings)
            // Additional: CreateTeamAsync(CreateTeamRequest, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTeamRequest request = new CreateTeamRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Team = new Team(),
            };
            // Make the request
            Team response = await teamServiceClient.CreateTeamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTeam</summary>
        public void CreateTeam()
        {
            // Snippet: CreateTeam(string, Team, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Team team = new Team();
            // Make the request
            Team response = teamServiceClient.CreateTeam(parent, team);
            // End snippet
        }

        /// <summary>Snippet for CreateTeamAsync</summary>
        public async Task CreateTeamAsync()
        {
            // Snippet: CreateTeamAsync(string, Team, CallSettings)
            // Additional: CreateTeamAsync(string, Team, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Team team = new Team();
            // Make the request
            Team response = await teamServiceClient.CreateTeamAsync(parent, team);
            // End snippet
        }

        /// <summary>Snippet for CreateTeam</summary>
        public void CreateTeamResourceNames()
        {
            // Snippet: CreateTeam(NetworkName, Team, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Team team = new Team();
            // Make the request
            Team response = teamServiceClient.CreateTeam(parent, team);
            // End snippet
        }

        /// <summary>Snippet for CreateTeamAsync</summary>
        public async Task CreateTeamResourceNamesAsync()
        {
            // Snippet: CreateTeamAsync(NetworkName, Team, CallSettings)
            // Additional: CreateTeamAsync(NetworkName, Team, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Team team = new Team();
            // Make the request
            Team response = await teamServiceClient.CreateTeamAsync(parent, team);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTeams</summary>
        public void BatchCreateTeamsRequestObject()
        {
            // Snippet: BatchCreateTeams(BatchCreateTeamsRequest, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateTeamsRequest request = new BatchCreateTeamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateTeamRequest(),
                },
            };
            // Make the request
            BatchCreateTeamsResponse response = teamServiceClient.BatchCreateTeams(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTeamsAsync</summary>
        public async Task BatchCreateTeamsRequestObjectAsync()
        {
            // Snippet: BatchCreateTeamsAsync(BatchCreateTeamsRequest, CallSettings)
            // Additional: BatchCreateTeamsAsync(BatchCreateTeamsRequest, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateTeamsRequest request = new BatchCreateTeamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateTeamRequest(),
                },
            };
            // Make the request
            BatchCreateTeamsResponse response = await teamServiceClient.BatchCreateTeamsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTeams</summary>
        public void BatchCreateTeams()
        {
            // Snippet: BatchCreateTeams(string, IEnumerable<CreateTeamRequest>, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateTeamRequest> requests = new CreateTeamRequest[]
            {
                new CreateTeamRequest(),
            };
            // Make the request
            BatchCreateTeamsResponse response = teamServiceClient.BatchCreateTeams(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTeamsAsync</summary>
        public async Task BatchCreateTeamsAsync()
        {
            // Snippet: BatchCreateTeamsAsync(string, IEnumerable<CreateTeamRequest>, CallSettings)
            // Additional: BatchCreateTeamsAsync(string, IEnumerable<CreateTeamRequest>, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateTeamRequest> requests = new CreateTeamRequest[]
            {
                new CreateTeamRequest(),
            };
            // Make the request
            BatchCreateTeamsResponse response = await teamServiceClient.BatchCreateTeamsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTeams</summary>
        public void BatchCreateTeamsResourceNames()
        {
            // Snippet: BatchCreateTeams(NetworkName, IEnumerable<CreateTeamRequest>, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateTeamRequest> requests = new CreateTeamRequest[]
            {
                new CreateTeamRequest(),
            };
            // Make the request
            BatchCreateTeamsResponse response = teamServiceClient.BatchCreateTeams(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTeamsAsync</summary>
        public async Task BatchCreateTeamsResourceNamesAsync()
        {
            // Snippet: BatchCreateTeamsAsync(NetworkName, IEnumerable<CreateTeamRequest>, CallSettings)
            // Additional: BatchCreateTeamsAsync(NetworkName, IEnumerable<CreateTeamRequest>, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateTeamRequest> requests = new CreateTeamRequest[]
            {
                new CreateTeamRequest(),
            };
            // Make the request
            BatchCreateTeamsResponse response = await teamServiceClient.BatchCreateTeamsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateTeam</summary>
        public void UpdateTeamRequestObject()
        {
            // Snippet: UpdateTeam(UpdateTeamRequest, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            UpdateTeamRequest request = new UpdateTeamRequest
            {
                Team = new Team(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Team response = teamServiceClient.UpdateTeam(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTeamAsync</summary>
        public async Task UpdateTeamRequestObjectAsync()
        {
            // Snippet: UpdateTeamAsync(UpdateTeamRequest, CallSettings)
            // Additional: UpdateTeamAsync(UpdateTeamRequest, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTeamRequest request = new UpdateTeamRequest
            {
                Team = new Team(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Team response = await teamServiceClient.UpdateTeamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTeam</summary>
        public void UpdateTeam()
        {
            // Snippet: UpdateTeam(Team, FieldMask, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            Team team = new Team();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Team response = teamServiceClient.UpdateTeam(team, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTeamAsync</summary>
        public async Task UpdateTeamAsync()
        {
            // Snippet: UpdateTeamAsync(Team, FieldMask, CallSettings)
            // Additional: UpdateTeamAsync(Team, FieldMask, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            Team team = new Team();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Team response = await teamServiceClient.UpdateTeamAsync(team, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTeams</summary>
        public void BatchUpdateTeamsRequestObject()
        {
            // Snippet: BatchUpdateTeams(BatchUpdateTeamsRequest, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateTeamsRequest request = new BatchUpdateTeamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateTeamRequest(),
                },
            };
            // Make the request
            BatchUpdateTeamsResponse response = teamServiceClient.BatchUpdateTeams(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTeamsAsync</summary>
        public async Task BatchUpdateTeamsRequestObjectAsync()
        {
            // Snippet: BatchUpdateTeamsAsync(BatchUpdateTeamsRequest, CallSettings)
            // Additional: BatchUpdateTeamsAsync(BatchUpdateTeamsRequest, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateTeamsRequest request = new BatchUpdateTeamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateTeamRequest(),
                },
            };
            // Make the request
            BatchUpdateTeamsResponse response = await teamServiceClient.BatchUpdateTeamsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTeams</summary>
        public void BatchUpdateTeams()
        {
            // Snippet: BatchUpdateTeams(string, IEnumerable<UpdateTeamRequest>, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateTeamRequest> requests = new UpdateTeamRequest[]
            {
                new UpdateTeamRequest(),
            };
            // Make the request
            BatchUpdateTeamsResponse response = teamServiceClient.BatchUpdateTeams(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTeamsAsync</summary>
        public async Task BatchUpdateTeamsAsync()
        {
            // Snippet: BatchUpdateTeamsAsync(string, IEnumerable<UpdateTeamRequest>, CallSettings)
            // Additional: BatchUpdateTeamsAsync(string, IEnumerable<UpdateTeamRequest>, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateTeamRequest> requests = new UpdateTeamRequest[]
            {
                new UpdateTeamRequest(),
            };
            // Make the request
            BatchUpdateTeamsResponse response = await teamServiceClient.BatchUpdateTeamsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTeams</summary>
        public void BatchUpdateTeamsResourceNames()
        {
            // Snippet: BatchUpdateTeams(NetworkName, IEnumerable<UpdateTeamRequest>, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateTeamRequest> requests = new UpdateTeamRequest[]
            {
                new UpdateTeamRequest(),
            };
            // Make the request
            BatchUpdateTeamsResponse response = teamServiceClient.BatchUpdateTeams(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTeamsAsync</summary>
        public async Task BatchUpdateTeamsResourceNamesAsync()
        {
            // Snippet: BatchUpdateTeamsAsync(NetworkName, IEnumerable<UpdateTeamRequest>, CallSettings)
            // Additional: BatchUpdateTeamsAsync(NetworkName, IEnumerable<UpdateTeamRequest>, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateTeamRequest> requests = new UpdateTeamRequest[]
            {
                new UpdateTeamRequest(),
            };
            // Make the request
            BatchUpdateTeamsResponse response = await teamServiceClient.BatchUpdateTeamsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateTeams</summary>
        public void BatchActivateTeamsRequestObject()
        {
            // Snippet: BatchActivateTeams(BatchActivateTeamsRequest, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateTeamsRequest request = new BatchActivateTeamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                TeamNames =
                {
                    TeamName.FromNetworkCodeTeam("[NETWORK_CODE]", "[TEAM]"),
                },
            };
            // Make the request
            BatchActivateTeamsResponse response = teamServiceClient.BatchActivateTeams(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateTeamsAsync</summary>
        public async Task BatchActivateTeamsRequestObjectAsync()
        {
            // Snippet: BatchActivateTeamsAsync(BatchActivateTeamsRequest, CallSettings)
            // Additional: BatchActivateTeamsAsync(BatchActivateTeamsRequest, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateTeamsRequest request = new BatchActivateTeamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                TeamNames =
                {
                    TeamName.FromNetworkCodeTeam("[NETWORK_CODE]", "[TEAM]"),
                },
            };
            // Make the request
            BatchActivateTeamsResponse response = await teamServiceClient.BatchActivateTeamsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateTeams</summary>
        public void BatchActivateTeams()
        {
            // Snippet: BatchActivateTeams(string, IEnumerable<string>, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/teams/[TEAM]",
            };
            // Make the request
            BatchActivateTeamsResponse response = teamServiceClient.BatchActivateTeams(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateTeamsAsync</summary>
        public async Task BatchActivateTeamsAsync()
        {
            // Snippet: BatchActivateTeamsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateTeamsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/teams/[TEAM]",
            };
            // Make the request
            BatchActivateTeamsResponse response = await teamServiceClient.BatchActivateTeamsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateTeams</summary>
        public void BatchActivateTeamsResourceNames()
        {
            // Snippet: BatchActivateTeams(NetworkName, IEnumerable<TeamName>, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<TeamName> names = new TeamName[]
            {
                TeamName.FromNetworkCodeTeam("[NETWORK_CODE]", "[TEAM]"),
            };
            // Make the request
            BatchActivateTeamsResponse response = teamServiceClient.BatchActivateTeams(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateTeamsAsync</summary>
        public async Task BatchActivateTeamsResourceNamesAsync()
        {
            // Snippet: BatchActivateTeamsAsync(NetworkName, IEnumerable<TeamName>, CallSettings)
            // Additional: BatchActivateTeamsAsync(NetworkName, IEnumerable<TeamName>, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<TeamName> names = new TeamName[]
            {
                TeamName.FromNetworkCodeTeam("[NETWORK_CODE]", "[TEAM]"),
            };
            // Make the request
            BatchActivateTeamsResponse response = await teamServiceClient.BatchActivateTeamsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateTeams</summary>
        public void BatchDeactivateTeamsRequestObject()
        {
            // Snippet: BatchDeactivateTeams(BatchDeactivateTeamsRequest, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateTeamsRequest request = new BatchDeactivateTeamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                TeamNames =
                {
                    TeamName.FromNetworkCodeTeam("[NETWORK_CODE]", "[TEAM]"),
                },
            };
            // Make the request
            BatchDeactivateTeamsResponse response = teamServiceClient.BatchDeactivateTeams(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateTeamsAsync</summary>
        public async Task BatchDeactivateTeamsRequestObjectAsync()
        {
            // Snippet: BatchDeactivateTeamsAsync(BatchDeactivateTeamsRequest, CallSettings)
            // Additional: BatchDeactivateTeamsAsync(BatchDeactivateTeamsRequest, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateTeamsRequest request = new BatchDeactivateTeamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                TeamNames =
                {
                    TeamName.FromNetworkCodeTeam("[NETWORK_CODE]", "[TEAM]"),
                },
            };
            // Make the request
            BatchDeactivateTeamsResponse response = await teamServiceClient.BatchDeactivateTeamsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateTeams</summary>
        public void BatchDeactivateTeams()
        {
            // Snippet: BatchDeactivateTeams(string, IEnumerable<string>, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/teams/[TEAM]",
            };
            // Make the request
            BatchDeactivateTeamsResponse response = teamServiceClient.BatchDeactivateTeams(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateTeamsAsync</summary>
        public async Task BatchDeactivateTeamsAsync()
        {
            // Snippet: BatchDeactivateTeamsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateTeamsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/teams/[TEAM]",
            };
            // Make the request
            BatchDeactivateTeamsResponse response = await teamServiceClient.BatchDeactivateTeamsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateTeams</summary>
        public void BatchDeactivateTeamsResourceNames()
        {
            // Snippet: BatchDeactivateTeams(NetworkName, IEnumerable<TeamName>, CallSettings)
            // Create client
            TeamServiceClient teamServiceClient = TeamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<TeamName> names = new TeamName[]
            {
                TeamName.FromNetworkCodeTeam("[NETWORK_CODE]", "[TEAM]"),
            };
            // Make the request
            BatchDeactivateTeamsResponse response = teamServiceClient.BatchDeactivateTeams(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateTeamsAsync</summary>
        public async Task BatchDeactivateTeamsResourceNamesAsync()
        {
            // Snippet: BatchDeactivateTeamsAsync(NetworkName, IEnumerable<TeamName>, CallSettings)
            // Additional: BatchDeactivateTeamsAsync(NetworkName, IEnumerable<TeamName>, CancellationToken)
            // Create client
            TeamServiceClient teamServiceClient = await TeamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<TeamName> names = new TeamName[]
            {
                TeamName.FromNetworkCodeTeam("[NETWORK_CODE]", "[TEAM]"),
            };
            // Make the request
            BatchDeactivateTeamsResponse response = await teamServiceClient.BatchDeactivateTeamsAsync(parent, names);
            // End snippet
        }
    }
}
