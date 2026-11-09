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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedProposalServiceClientSnippets
    {
        /// <summary>Snippet for GetProposal</summary>
        public void GetProposalRequestObject()
        {
            // Snippet: GetProposal(GetProposalRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            GetProposalRequest request = new GetProposalRequest
            {
                ProposalName = ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            Proposal response = proposalServiceClient.GetProposal(request);
            // End snippet
        }

        /// <summary>Snippet for GetProposalAsync</summary>
        public async Task GetProposalRequestObjectAsync()
        {
            // Snippet: GetProposalAsync(GetProposalRequest, CallSettings)
            // Additional: GetProposalAsync(GetProposalRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProposalRequest request = new GetProposalRequest
            {
                ProposalName = ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            Proposal response = await proposalServiceClient.GetProposalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProposal</summary>
        public void GetProposal()
        {
            // Snippet: GetProposal(string, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/proposals/[PROPOSAL]";
            // Make the request
            Proposal response = proposalServiceClient.GetProposal(name);
            // End snippet
        }

        /// <summary>Snippet for GetProposalAsync</summary>
        public async Task GetProposalAsync()
        {
            // Snippet: GetProposalAsync(string, CallSettings)
            // Additional: GetProposalAsync(string, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/proposals/[PROPOSAL]";
            // Make the request
            Proposal response = await proposalServiceClient.GetProposalAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProposal</summary>
        public void GetProposalResourceNames()
        {
            // Snippet: GetProposal(ProposalName, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            ProposalName name = ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]");
            // Make the request
            Proposal response = proposalServiceClient.GetProposal(name);
            // End snippet
        }

        /// <summary>Snippet for GetProposalAsync</summary>
        public async Task GetProposalResourceNamesAsync()
        {
            // Snippet: GetProposalAsync(ProposalName, CallSettings)
            // Additional: GetProposalAsync(ProposalName, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProposalName name = ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]");
            // Make the request
            Proposal response = await proposalServiceClient.GetProposalAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProposals</summary>
        public void ListProposalsRequestObject()
        {
            // Snippet: ListProposals(ListProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            ListProposalsRequest request = new ListProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListProposalsResponse, Proposal> response = proposalServiceClient.ListProposals(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Proposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Proposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Proposal> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Proposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProposalsAsync</summary>
        public async Task ListProposalsRequestObjectAsync()
        {
            // Snippet: ListProposalsAsync(ListProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListProposalsRequest request = new ListProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListProposalsResponse, Proposal> response = proposalServiceClient.ListProposalsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Proposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Proposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Proposal> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Proposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProposals</summary>
        public void ListProposals()
        {
            // Snippet: ListProposals(string, string, int?, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListProposalsResponse, Proposal> response = proposalServiceClient.ListProposals(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Proposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Proposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Proposal> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Proposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProposalsAsync</summary>
        public async Task ListProposalsAsync()
        {
            // Snippet: ListProposalsAsync(string, string, int?, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListProposalsResponse, Proposal> response = proposalServiceClient.ListProposalsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Proposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Proposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Proposal> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Proposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProposals</summary>
        public void ListProposalsResourceNames()
        {
            // Snippet: ListProposals(NetworkName, string, int?, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListProposalsResponse, Proposal> response = proposalServiceClient.ListProposals(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Proposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Proposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Proposal> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Proposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProposalsAsync</summary>
        public async Task ListProposalsResourceNamesAsync()
        {
            // Snippet: ListProposalsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListProposalsResponse, Proposal> response = proposalServiceClient.ListProposalsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Proposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Proposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Proposal> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Proposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateProposal</summary>
        public void CreateProposalRequestObject()
        {
            // Snippet: CreateProposal(CreateProposalRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            CreateProposalRequest request = new CreateProposalRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Proposal = new Proposal(),
            };
            // Make the request
            Proposal response = proposalServiceClient.CreateProposal(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProposalAsync</summary>
        public async Task CreateProposalRequestObjectAsync()
        {
            // Snippet: CreateProposalAsync(CreateProposalRequest, CallSettings)
            // Additional: CreateProposalAsync(CreateProposalRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateProposalRequest request = new CreateProposalRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Proposal = new Proposal(),
            };
            // Make the request
            Proposal response = await proposalServiceClient.CreateProposalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProposal</summary>
        public void CreateProposal()
        {
            // Snippet: CreateProposal(string, Proposal, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Proposal proposal = new Proposal();
            // Make the request
            Proposal response = proposalServiceClient.CreateProposal(parent, proposal);
            // End snippet
        }

        /// <summary>Snippet for CreateProposalAsync</summary>
        public async Task CreateProposalAsync()
        {
            // Snippet: CreateProposalAsync(string, Proposal, CallSettings)
            // Additional: CreateProposalAsync(string, Proposal, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Proposal proposal = new Proposal();
            // Make the request
            Proposal response = await proposalServiceClient.CreateProposalAsync(parent, proposal);
            // End snippet
        }

        /// <summary>Snippet for CreateProposal</summary>
        public void CreateProposalResourceNames()
        {
            // Snippet: CreateProposal(NetworkName, Proposal, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Proposal proposal = new Proposal();
            // Make the request
            Proposal response = proposalServiceClient.CreateProposal(parent, proposal);
            // End snippet
        }

        /// <summary>Snippet for CreateProposalAsync</summary>
        public async Task CreateProposalResourceNamesAsync()
        {
            // Snippet: CreateProposalAsync(NetworkName, Proposal, CallSettings)
            // Additional: CreateProposalAsync(NetworkName, Proposal, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Proposal proposal = new Proposal();
            // Make the request
            Proposal response = await proposalServiceClient.CreateProposalAsync(parent, proposal);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateProposals</summary>
        public void BatchCreateProposalsRequestObject()
        {
            // Snippet: BatchCreateProposals(BatchCreateProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateProposalsRequest request = new BatchCreateProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateProposalRequest(),
                },
            };
            // Make the request
            BatchCreateProposalsResponse response = proposalServiceClient.BatchCreateProposals(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateProposalsAsync</summary>
        public async Task BatchCreateProposalsRequestObjectAsync()
        {
            // Snippet: BatchCreateProposalsAsync(BatchCreateProposalsRequest, CallSettings)
            // Additional: BatchCreateProposalsAsync(BatchCreateProposalsRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateProposalsRequest request = new BatchCreateProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateProposalRequest(),
                },
            };
            // Make the request
            BatchCreateProposalsResponse response = await proposalServiceClient.BatchCreateProposalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateProposals</summary>
        public void BatchCreateProposals()
        {
            // Snippet: BatchCreateProposals(string, IEnumerable<CreateProposalRequest>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateProposalRequest> requests = new CreateProposalRequest[]
            {
                new CreateProposalRequest(),
            };
            // Make the request
            BatchCreateProposalsResponse response = proposalServiceClient.BatchCreateProposals(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateProposalsAsync</summary>
        public async Task BatchCreateProposalsAsync()
        {
            // Snippet: BatchCreateProposalsAsync(string, IEnumerable<CreateProposalRequest>, CallSettings)
            // Additional: BatchCreateProposalsAsync(string, IEnumerable<CreateProposalRequest>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateProposalRequest> requests = new CreateProposalRequest[]
            {
                new CreateProposalRequest(),
            };
            // Make the request
            BatchCreateProposalsResponse response = await proposalServiceClient.BatchCreateProposalsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateProposals</summary>
        public void BatchCreateProposalsResourceNames()
        {
            // Snippet: BatchCreateProposals(NetworkName, IEnumerable<CreateProposalRequest>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateProposalRequest> requests = new CreateProposalRequest[]
            {
                new CreateProposalRequest(),
            };
            // Make the request
            BatchCreateProposalsResponse response = proposalServiceClient.BatchCreateProposals(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateProposalsAsync</summary>
        public async Task BatchCreateProposalsResourceNamesAsync()
        {
            // Snippet: BatchCreateProposalsAsync(NetworkName, IEnumerable<CreateProposalRequest>, CallSettings)
            // Additional: BatchCreateProposalsAsync(NetworkName, IEnumerable<CreateProposalRequest>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateProposalRequest> requests = new CreateProposalRequest[]
            {
                new CreateProposalRequest(),
            };
            // Make the request
            BatchCreateProposalsResponse response = await proposalServiceClient.BatchCreateProposalsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateProposal</summary>
        public void UpdateProposalRequestObject()
        {
            // Snippet: UpdateProposal(UpdateProposalRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            UpdateProposalRequest request = new UpdateProposalRequest
            {
                Proposal = new Proposal(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Proposal response = proposalServiceClient.UpdateProposal(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProposalAsync</summary>
        public async Task UpdateProposalRequestObjectAsync()
        {
            // Snippet: UpdateProposalAsync(UpdateProposalRequest, CallSettings)
            // Additional: UpdateProposalAsync(UpdateProposalRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProposalRequest request = new UpdateProposalRequest
            {
                Proposal = new Proposal(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Proposal response = await proposalServiceClient.UpdateProposalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProposal</summary>
        public void UpdateProposal()
        {
            // Snippet: UpdateProposal(Proposal, FieldMask, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            Proposal proposal = new Proposal();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Proposal response = proposalServiceClient.UpdateProposal(proposal, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProposalAsync</summary>
        public async Task UpdateProposalAsync()
        {
            // Snippet: UpdateProposalAsync(Proposal, FieldMask, CallSettings)
            // Additional: UpdateProposalAsync(Proposal, FieldMask, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            Proposal proposal = new Proposal();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Proposal response = await proposalServiceClient.UpdateProposalAsync(proposal, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateProposals</summary>
        public void BatchUpdateProposalsRequestObject()
        {
            // Snippet: BatchUpdateProposals(BatchUpdateProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateProposalsRequest request = new BatchUpdateProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateProposalRequest(),
                },
            };
            // Make the request
            BatchUpdateProposalsResponse response = proposalServiceClient.BatchUpdateProposals(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateProposalsAsync</summary>
        public async Task BatchUpdateProposalsRequestObjectAsync()
        {
            // Snippet: BatchUpdateProposalsAsync(BatchUpdateProposalsRequest, CallSettings)
            // Additional: BatchUpdateProposalsAsync(BatchUpdateProposalsRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateProposalsRequest request = new BatchUpdateProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateProposalRequest(),
                },
            };
            // Make the request
            BatchUpdateProposalsResponse response = await proposalServiceClient.BatchUpdateProposalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateProposals</summary>
        public void BatchUpdateProposals()
        {
            // Snippet: BatchUpdateProposals(string, IEnumerable<UpdateProposalRequest>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateProposalRequest> requests = new UpdateProposalRequest[]
            {
                new UpdateProposalRequest(),
            };
            // Make the request
            BatchUpdateProposalsResponse response = proposalServiceClient.BatchUpdateProposals(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateProposalsAsync</summary>
        public async Task BatchUpdateProposalsAsync()
        {
            // Snippet: BatchUpdateProposalsAsync(string, IEnumerable<UpdateProposalRequest>, CallSettings)
            // Additional: BatchUpdateProposalsAsync(string, IEnumerable<UpdateProposalRequest>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateProposalRequest> requests = new UpdateProposalRequest[]
            {
                new UpdateProposalRequest(),
            };
            // Make the request
            BatchUpdateProposalsResponse response = await proposalServiceClient.BatchUpdateProposalsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateProposals</summary>
        public void BatchUpdateProposalsResourceNames()
        {
            // Snippet: BatchUpdateProposals(NetworkName, IEnumerable<UpdateProposalRequest>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateProposalRequest> requests = new UpdateProposalRequest[]
            {
                new UpdateProposalRequest(),
            };
            // Make the request
            BatchUpdateProposalsResponse response = proposalServiceClient.BatchUpdateProposals(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateProposalsAsync</summary>
        public async Task BatchUpdateProposalsResourceNamesAsync()
        {
            // Snippet: BatchUpdateProposalsAsync(NetworkName, IEnumerable<UpdateProposalRequest>, CallSettings)
            // Additional: BatchUpdateProposalsAsync(NetworkName, IEnumerable<UpdateProposalRequest>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateProposalRequest> requests = new UpdateProposalRequest[]
            {
                new UpdateProposalRequest(),
            };
            // Make the request
            BatchUpdateProposalsResponse response = await proposalServiceClient.BatchUpdateProposalsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveProposals</summary>
        public void BatchArchiveProposalsRequestObject()
        {
            // Snippet: BatchArchiveProposals(BatchArchiveProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            BatchArchiveProposalsRequest request = new BatchArchiveProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchArchiveProposalsResponse response = proposalServiceClient.BatchArchiveProposals(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveProposalsAsync</summary>
        public async Task BatchArchiveProposalsRequestObjectAsync()
        {
            // Snippet: BatchArchiveProposalsAsync(BatchArchiveProposalsRequest, CallSettings)
            // Additional: BatchArchiveProposalsAsync(BatchArchiveProposalsRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchArchiveProposalsRequest request = new BatchArchiveProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchArchiveProposalsResponse response = await proposalServiceClient.BatchArchiveProposalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveProposals</summary>
        public void BatchArchiveProposals()
        {
            // Snippet: BatchArchiveProposals(string, IEnumerable<string>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchArchiveProposalsResponse response = proposalServiceClient.BatchArchiveProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveProposalsAsync</summary>
        public async Task BatchArchiveProposalsAsync()
        {
            // Snippet: BatchArchiveProposalsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchArchiveProposalsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchArchiveProposalsResponse response = await proposalServiceClient.BatchArchiveProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveProposals</summary>
        public void BatchArchiveProposalsResourceNames()
        {
            // Snippet: BatchArchiveProposals(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchArchiveProposalsResponse response = proposalServiceClient.BatchArchiveProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveProposalsAsync</summary>
        public async Task BatchArchiveProposalsResourceNamesAsync()
        {
            // Snippet: BatchArchiveProposalsAsync(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Additional: BatchArchiveProposalsAsync(NetworkName, IEnumerable<ProposalName>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchArchiveProposalsResponse response = await proposalServiceClient.BatchArchiveProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveProposals</summary>
        public void BatchUnarchiveProposalsRequestObject()
        {
            // Snippet: BatchUnarchiveProposals(BatchUnarchiveProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            BatchUnarchiveProposalsRequest request = new BatchUnarchiveProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchUnarchiveProposalsResponse response = proposalServiceClient.BatchUnarchiveProposals(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveProposalsAsync</summary>
        public async Task BatchUnarchiveProposalsRequestObjectAsync()
        {
            // Snippet: BatchUnarchiveProposalsAsync(BatchUnarchiveProposalsRequest, CallSettings)
            // Additional: BatchUnarchiveProposalsAsync(BatchUnarchiveProposalsRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUnarchiveProposalsRequest request = new BatchUnarchiveProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchUnarchiveProposalsResponse response = await proposalServiceClient.BatchUnarchiveProposalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveProposals</summary>
        public void BatchUnarchiveProposals()
        {
            // Snippet: BatchUnarchiveProposals(string, IEnumerable<string>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchUnarchiveProposalsResponse response = proposalServiceClient.BatchUnarchiveProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveProposalsAsync</summary>
        public async Task BatchUnarchiveProposalsAsync()
        {
            // Snippet: BatchUnarchiveProposalsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchUnarchiveProposalsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchUnarchiveProposalsResponse response = await proposalServiceClient.BatchUnarchiveProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveProposals</summary>
        public void BatchUnarchiveProposalsResourceNames()
        {
            // Snippet: BatchUnarchiveProposals(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchUnarchiveProposalsResponse response = proposalServiceClient.BatchUnarchiveProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveProposalsAsync</summary>
        public async Task BatchUnarchiveProposalsResourceNamesAsync()
        {
            // Snippet: BatchUnarchiveProposalsAsync(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Additional: BatchUnarchiveProposalsAsync(NetworkName, IEnumerable<ProposalName>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchUnarchiveProposalsResponse response = await proposalServiceClient.BatchUnarchiveProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseProposals</summary>
        public void BatchPauseProposalsRequestObject()
        {
            // Snippet: BatchPauseProposals(BatchPauseProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            BatchPauseProposalsRequest request = new BatchPauseProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
                Reason = "",
            };
            // Make the request
            BatchPauseProposalsResponse response = proposalServiceClient.BatchPauseProposals(request);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseProposalsAsync</summary>
        public async Task BatchPauseProposalsRequestObjectAsync()
        {
            // Snippet: BatchPauseProposalsAsync(BatchPauseProposalsRequest, CallSettings)
            // Additional: BatchPauseProposalsAsync(BatchPauseProposalsRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchPauseProposalsRequest request = new BatchPauseProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
                Reason = "",
            };
            // Make the request
            BatchPauseProposalsResponse response = await proposalServiceClient.BatchPauseProposalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseProposals</summary>
        public void BatchPauseProposals()
        {
            // Snippet: BatchPauseProposals(string, IEnumerable<string>, string, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            string reason = "";
            // Make the request
            BatchPauseProposalsResponse response = proposalServiceClient.BatchPauseProposals(parent, names, reason);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseProposalsAsync</summary>
        public async Task BatchPauseProposalsAsync()
        {
            // Snippet: BatchPauseProposalsAsync(string, IEnumerable<string>, string, CallSettings)
            // Additional: BatchPauseProposalsAsync(string, IEnumerable<string>, string, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            string reason = "";
            // Make the request
            BatchPauseProposalsResponse response = await proposalServiceClient.BatchPauseProposalsAsync(parent, names, reason);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseProposals</summary>
        public void BatchPauseProposalsResourceNames()
        {
            // Snippet: BatchPauseProposals(NetworkName, IEnumerable<ProposalName>, string, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            string reason = "";
            // Make the request
            BatchPauseProposalsResponse response = proposalServiceClient.BatchPauseProposals(parent, names, reason);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseProposalsAsync</summary>
        public async Task BatchPauseProposalsResourceNamesAsync()
        {
            // Snippet: BatchPauseProposalsAsync(NetworkName, IEnumerable<ProposalName>, string, CallSettings)
            // Additional: BatchPauseProposalsAsync(NetworkName, IEnumerable<ProposalName>, string, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            string reason = "";
            // Make the request
            BatchPauseProposalsResponse response = await proposalServiceClient.BatchPauseProposalsAsync(parent, names, reason);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeProposals</summary>
        public void BatchResumeProposalsRequestObject()
        {
            // Snippet: BatchResumeProposals(BatchResumeProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            BatchResumeProposalsRequest request = new BatchResumeProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchResumeProposalsResponse response = proposalServiceClient.BatchResumeProposals(request);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeProposalsAsync</summary>
        public async Task BatchResumeProposalsRequestObjectAsync()
        {
            // Snippet: BatchResumeProposalsAsync(BatchResumeProposalsRequest, CallSettings)
            // Additional: BatchResumeProposalsAsync(BatchResumeProposalsRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchResumeProposalsRequest request = new BatchResumeProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchResumeProposalsResponse response = await proposalServiceClient.BatchResumeProposalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeProposals</summary>
        public void BatchResumeProposals()
        {
            // Snippet: BatchResumeProposals(string, IEnumerable<string>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchResumeProposalsResponse response = proposalServiceClient.BatchResumeProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeProposalsAsync</summary>
        public async Task BatchResumeProposalsAsync()
        {
            // Snippet: BatchResumeProposalsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchResumeProposalsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchResumeProposalsResponse response = await proposalServiceClient.BatchResumeProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeProposals</summary>
        public void BatchResumeProposalsResourceNames()
        {
            // Snippet: BatchResumeProposals(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchResumeProposalsResponse response = proposalServiceClient.BatchResumeProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeProposalsAsync</summary>
        public async Task BatchResumeProposalsResourceNamesAsync()
        {
            // Snippet: BatchResumeProposalsAsync(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Additional: BatchResumeProposalsAsync(NetworkName, IEnumerable<ProposalName>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchResumeProposalsResponse response = await proposalServiceClient.BatchResumeProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRequestBuyerReviewProposals</summary>
        public void BatchRequestBuyerReviewProposalsRequestObject()
        {
            // Snippet: BatchRequestBuyerReviewProposals(BatchRequestBuyerReviewProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            BatchRequestBuyerReviewProposalsRequest request = new BatchRequestBuyerReviewProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchRequestBuyerReviewProposalsResponse response = proposalServiceClient.BatchRequestBuyerReviewProposals(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRequestBuyerReviewProposalsAsync</summary>
        public async Task BatchRequestBuyerReviewProposalsRequestObjectAsync()
        {
            // Snippet: BatchRequestBuyerReviewProposalsAsync(BatchRequestBuyerReviewProposalsRequest, CallSettings)
            // Additional: BatchRequestBuyerReviewProposalsAsync(BatchRequestBuyerReviewProposalsRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchRequestBuyerReviewProposalsRequest request = new BatchRequestBuyerReviewProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchRequestBuyerReviewProposalsResponse response = await proposalServiceClient.BatchRequestBuyerReviewProposalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRequestBuyerReviewProposals</summary>
        public void BatchRequestBuyerReviewProposals()
        {
            // Snippet: BatchRequestBuyerReviewProposals(string, IEnumerable<string>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchRequestBuyerReviewProposalsResponse response = proposalServiceClient.BatchRequestBuyerReviewProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRequestBuyerReviewProposalsAsync</summary>
        public async Task BatchRequestBuyerReviewProposalsAsync()
        {
            // Snippet: BatchRequestBuyerReviewProposalsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchRequestBuyerReviewProposalsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchRequestBuyerReviewProposalsResponse response = await proposalServiceClient.BatchRequestBuyerReviewProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRequestBuyerReviewProposals</summary>
        public void BatchRequestBuyerReviewProposalsResourceNames()
        {
            // Snippet: BatchRequestBuyerReviewProposals(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchRequestBuyerReviewProposalsResponse response = proposalServiceClient.BatchRequestBuyerReviewProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRequestBuyerReviewProposalsAsync</summary>
        public async Task BatchRequestBuyerReviewProposalsResourceNamesAsync()
        {
            // Snippet: BatchRequestBuyerReviewProposalsAsync(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Additional: BatchRequestBuyerReviewProposalsAsync(NetworkName, IEnumerable<ProposalName>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchRequestBuyerReviewProposalsResponse response = await proposalServiceClient.BatchRequestBuyerReviewProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRequestBuyerAcceptProposals</summary>
        public void BatchRequestBuyerAcceptProposalsRequestObject()
        {
            // Snippet: BatchRequestBuyerAcceptProposals(BatchRequestBuyerAcceptProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            BatchRequestBuyerAcceptProposalsRequest request = new BatchRequestBuyerAcceptProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
                OverbookingAllowed = false,
            };
            // Make the request
            BatchRequestBuyerAcceptProposalsResponse response = proposalServiceClient.BatchRequestBuyerAcceptProposals(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRequestBuyerAcceptProposalsAsync</summary>
        public async Task BatchRequestBuyerAcceptProposalsRequestObjectAsync()
        {
            // Snippet: BatchRequestBuyerAcceptProposalsAsync(BatchRequestBuyerAcceptProposalsRequest, CallSettings)
            // Additional: BatchRequestBuyerAcceptProposalsAsync(BatchRequestBuyerAcceptProposalsRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchRequestBuyerAcceptProposalsRequest request = new BatchRequestBuyerAcceptProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
                OverbookingAllowed = false,
            };
            // Make the request
            BatchRequestBuyerAcceptProposalsResponse response = await proposalServiceClient.BatchRequestBuyerAcceptProposalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRequestBuyerAcceptProposals</summary>
        public void BatchRequestBuyerAcceptProposals()
        {
            // Snippet: BatchRequestBuyerAcceptProposals(string, IEnumerable<string>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchRequestBuyerAcceptProposalsResponse response = proposalServiceClient.BatchRequestBuyerAcceptProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRequestBuyerAcceptProposalsAsync</summary>
        public async Task BatchRequestBuyerAcceptProposalsAsync()
        {
            // Snippet: BatchRequestBuyerAcceptProposalsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchRequestBuyerAcceptProposalsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchRequestBuyerAcceptProposalsResponse response = await proposalServiceClient.BatchRequestBuyerAcceptProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRequestBuyerAcceptProposals</summary>
        public void BatchRequestBuyerAcceptProposalsResourceNames()
        {
            // Snippet: BatchRequestBuyerAcceptProposals(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchRequestBuyerAcceptProposalsResponse response = proposalServiceClient.BatchRequestBuyerAcceptProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRequestBuyerAcceptProposalsAsync</summary>
        public async Task BatchRequestBuyerAcceptProposalsResourceNamesAsync()
        {
            // Snippet: BatchRequestBuyerAcceptProposalsAsync(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Additional: BatchRequestBuyerAcceptProposalsAsync(NetworkName, IEnumerable<ProposalName>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchRequestBuyerAcceptProposalsResponse response = await proposalServiceClient.BatchRequestBuyerAcceptProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveProposals</summary>
        public void BatchReserveProposalsRequestObject()
        {
            // Snippet: BatchReserveProposals(BatchReserveProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            BatchReserveProposalsRequest request = new BatchReserveProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
                OverbookingAllowed = false,
            };
            // Make the request
            BatchReserveProposalsResponse response = proposalServiceClient.BatchReserveProposals(request);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveProposalsAsync</summary>
        public async Task BatchReserveProposalsRequestObjectAsync()
        {
            // Snippet: BatchReserveProposalsAsync(BatchReserveProposalsRequest, CallSettings)
            // Additional: BatchReserveProposalsAsync(BatchReserveProposalsRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchReserveProposalsRequest request = new BatchReserveProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
                OverbookingAllowed = false,
            };
            // Make the request
            BatchReserveProposalsResponse response = await proposalServiceClient.BatchReserveProposalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveProposals</summary>
        public void BatchReserveProposals()
        {
            // Snippet: BatchReserveProposals(string, IEnumerable<string>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchReserveProposalsResponse response = proposalServiceClient.BatchReserveProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveProposalsAsync</summary>
        public async Task BatchReserveProposalsAsync()
        {
            // Snippet: BatchReserveProposalsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchReserveProposalsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchReserveProposalsResponse response = await proposalServiceClient.BatchReserveProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveProposals</summary>
        public void BatchReserveProposalsResourceNames()
        {
            // Snippet: BatchReserveProposals(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchReserveProposalsResponse response = proposalServiceClient.BatchReserveProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveProposalsAsync</summary>
        public async Task BatchReserveProposalsResourceNamesAsync()
        {
            // Snippet: BatchReserveProposalsAsync(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Additional: BatchReserveProposalsAsync(NetworkName, IEnumerable<ProposalName>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchReserveProposalsResponse response = await proposalServiceClient.BatchReserveProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRedraftProposals</summary>
        public void BatchRedraftProposalsRequestObject()
        {
            // Snippet: BatchRedraftProposals(BatchRedraftProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            BatchRedraftProposalsRequest request = new BatchRedraftProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchRedraftProposalsResponse response = proposalServiceClient.BatchRedraftProposals(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRedraftProposalsAsync</summary>
        public async Task BatchRedraftProposalsRequestObjectAsync()
        {
            // Snippet: BatchRedraftProposalsAsync(BatchRedraftProposalsRequest, CallSettings)
            // Additional: BatchRedraftProposalsAsync(BatchRedraftProposalsRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchRedraftProposalsRequest request = new BatchRedraftProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchRedraftProposalsResponse response = await proposalServiceClient.BatchRedraftProposalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRedraftProposals</summary>
        public void BatchRedraftProposals()
        {
            // Snippet: BatchRedraftProposals(string, IEnumerable<string>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchRedraftProposalsResponse response = proposalServiceClient.BatchRedraftProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRedraftProposalsAsync</summary>
        public async Task BatchRedraftProposalsAsync()
        {
            // Snippet: BatchRedraftProposalsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchRedraftProposalsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchRedraftProposalsResponse response = await proposalServiceClient.BatchRedraftProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRedraftProposals</summary>
        public void BatchRedraftProposalsResourceNames()
        {
            // Snippet: BatchRedraftProposals(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchRedraftProposalsResponse response = proposalServiceClient.BatchRedraftProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRedraftProposalsAsync</summary>
        public async Task BatchRedraftProposalsResourceNamesAsync()
        {
            // Snippet: BatchRedraftProposalsAsync(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Additional: BatchRedraftProposalsAsync(NetworkName, IEnumerable<ProposalName>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchRedraftProposalsResponse response = await proposalServiceClient.BatchRedraftProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDiscardDraftProposals</summary>
        public void BatchDiscardDraftProposalsRequestObject()
        {
            // Snippet: BatchDiscardDraftProposals(BatchDiscardDraftProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            BatchDiscardDraftProposalsRequest request = new BatchDiscardDraftProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchDiscardDraftProposalsResponse response = proposalServiceClient.BatchDiscardDraftProposals(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDiscardDraftProposalsAsync</summary>
        public async Task BatchDiscardDraftProposalsRequestObjectAsync()
        {
            // Snippet: BatchDiscardDraftProposalsAsync(BatchDiscardDraftProposalsRequest, CallSettings)
            // Additional: BatchDiscardDraftProposalsAsync(BatchDiscardDraftProposalsRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDiscardDraftProposalsRequest request = new BatchDiscardDraftProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchDiscardDraftProposalsResponse response = await proposalServiceClient.BatchDiscardDraftProposalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDiscardDraftProposals</summary>
        public void BatchDiscardDraftProposals()
        {
            // Snippet: BatchDiscardDraftProposals(string, IEnumerable<string>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchDiscardDraftProposalsResponse response = proposalServiceClient.BatchDiscardDraftProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDiscardDraftProposalsAsync</summary>
        public async Task BatchDiscardDraftProposalsAsync()
        {
            // Snippet: BatchDiscardDraftProposalsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDiscardDraftProposalsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchDiscardDraftProposalsResponse response = await proposalServiceClient.BatchDiscardDraftProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDiscardDraftProposals</summary>
        public void BatchDiscardDraftProposalsResourceNames()
        {
            // Snippet: BatchDiscardDraftProposals(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchDiscardDraftProposalsResponse response = proposalServiceClient.BatchDiscardDraftProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDiscardDraftProposalsAsync</summary>
        public async Task BatchDiscardDraftProposalsResourceNamesAsync()
        {
            // Snippet: BatchDiscardDraftProposalsAsync(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Additional: BatchDiscardDraftProposalsAsync(NetworkName, IEnumerable<ProposalName>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchDiscardDraftProposalsResponse response = await proposalServiceClient.BatchDiscardDraftProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchTerminateProposals</summary>
        public void BatchTerminateProposalsRequestObject()
        {
            // Snippet: BatchTerminateProposals(BatchTerminateProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            BatchTerminateProposalsRequest request = new BatchTerminateProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchTerminateProposalsResponse response = proposalServiceClient.BatchTerminateProposals(request);
            // End snippet
        }

        /// <summary>Snippet for BatchTerminateProposalsAsync</summary>
        public async Task BatchTerminateProposalsRequestObjectAsync()
        {
            // Snippet: BatchTerminateProposalsAsync(BatchTerminateProposalsRequest, CallSettings)
            // Additional: BatchTerminateProposalsAsync(BatchTerminateProposalsRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchTerminateProposalsRequest request = new BatchTerminateProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchTerminateProposalsResponse response = await proposalServiceClient.BatchTerminateProposalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchTerminateProposals</summary>
        public void BatchTerminateProposals()
        {
            // Snippet: BatchTerminateProposals(string, IEnumerable<string>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchTerminateProposalsResponse response = proposalServiceClient.BatchTerminateProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchTerminateProposalsAsync</summary>
        public async Task BatchTerminateProposalsAsync()
        {
            // Snippet: BatchTerminateProposalsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchTerminateProposalsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchTerminateProposalsResponse response = await proposalServiceClient.BatchTerminateProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchTerminateProposals</summary>
        public void BatchTerminateProposalsResourceNames()
        {
            // Snippet: BatchTerminateProposals(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchTerminateProposalsResponse response = proposalServiceClient.BatchTerminateProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchTerminateProposalsAsync</summary>
        public async Task BatchTerminateProposalsResourceNamesAsync()
        {
            // Snippet: BatchTerminateProposalsAsync(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Additional: BatchTerminateProposalsAsync(NetworkName, IEnumerable<ProposalName>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchTerminateProposalsResponse response = await proposalServiceClient.BatchTerminateProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPushToOrderProposals</summary>
        public void BatchPushToOrderProposalsRequestObject()
        {
            // Snippet: BatchPushToOrderProposals(BatchPushToOrderProposalsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            BatchPushToOrderProposalsRequest request = new BatchPushToOrderProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchPushToOrderProposalsResponse response = proposalServiceClient.BatchPushToOrderProposals(request);
            // End snippet
        }

        /// <summary>Snippet for BatchPushToOrderProposalsAsync</summary>
        public async Task BatchPushToOrderProposalsRequestObjectAsync()
        {
            // Snippet: BatchPushToOrderProposalsAsync(BatchPushToOrderProposalsRequest, CallSettings)
            // Additional: BatchPushToOrderProposalsAsync(BatchPushToOrderProposalsRequest, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchPushToOrderProposalsRequest request = new BatchPushToOrderProposalsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
            };
            // Make the request
            BatchPushToOrderProposalsResponse response = await proposalServiceClient.BatchPushToOrderProposalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchPushToOrderProposals</summary>
        public void BatchPushToOrderProposals()
        {
            // Snippet: BatchPushToOrderProposals(string, IEnumerable<string>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchPushToOrderProposalsResponse response = proposalServiceClient.BatchPushToOrderProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPushToOrderProposalsAsync</summary>
        public async Task BatchPushToOrderProposalsAsync()
        {
            // Snippet: BatchPushToOrderProposalsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchPushToOrderProposalsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            BatchPushToOrderProposalsResponse response = await proposalServiceClient.BatchPushToOrderProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPushToOrderProposals</summary>
        public void BatchPushToOrderProposalsResourceNames()
        {
            // Snippet: BatchPushToOrderProposals(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchPushToOrderProposalsResponse response = proposalServiceClient.BatchPushToOrderProposals(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPushToOrderProposalsAsync</summary>
        public async Task BatchPushToOrderProposalsResourceNamesAsync()
        {
            // Snippet: BatchPushToOrderProposalsAsync(NetworkName, IEnumerable<ProposalName>, CallSettings)
            // Additional: BatchPushToOrderProposalsAsync(NetworkName, IEnumerable<ProposalName>, CancellationToken)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            BatchPushToOrderProposalsResponse response = await proposalServiceClient.BatchPushToOrderProposalsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for FetchMarketplaceComments</summary>
        public void FetchMarketplaceCommentsRequestObject()
        {
            // Snippet: FetchMarketplaceComments(FetchMarketplaceCommentsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            FetchMarketplaceCommentsRequest request = new FetchMarketplaceCommentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<FetchMarketplaceCommentsResponse, MarketplaceComment> response = proposalServiceClient.FetchMarketplaceComments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MarketplaceComment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchMarketplaceCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MarketplaceComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MarketplaceComment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MarketplaceComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchMarketplaceCommentsAsync</summary>
        public async Task FetchMarketplaceCommentsRequestObjectAsync()
        {
            // Snippet: FetchMarketplaceCommentsAsync(FetchMarketplaceCommentsRequest, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            FetchMarketplaceCommentsRequest request = new FetchMarketplaceCommentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ProposalNames =
                {
                    ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
                },
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<FetchMarketplaceCommentsResponse, MarketplaceComment> response = proposalServiceClient.FetchMarketplaceCommentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MarketplaceComment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchMarketplaceCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MarketplaceComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MarketplaceComment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MarketplaceComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchMarketplaceComments</summary>
        public void FetchMarketplaceComments()
        {
            // Snippet: FetchMarketplaceComments(string, IEnumerable<string>, string, int?, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            PagedEnumerable<FetchMarketplaceCommentsResponse, MarketplaceComment> response = proposalServiceClient.FetchMarketplaceComments(parent, names);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MarketplaceComment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchMarketplaceCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MarketplaceComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MarketplaceComment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MarketplaceComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchMarketplaceCommentsAsync</summary>
        public async Task FetchMarketplaceCommentsAsync()
        {
            // Snippet: FetchMarketplaceCommentsAsync(string, IEnumerable<string>, string, int?, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/proposals/[PROPOSAL]",
            };
            // Make the request
            PagedAsyncEnumerable<FetchMarketplaceCommentsResponse, MarketplaceComment> response = proposalServiceClient.FetchMarketplaceCommentsAsync(parent, names);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MarketplaceComment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchMarketplaceCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MarketplaceComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MarketplaceComment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MarketplaceComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchMarketplaceComments</summary>
        public void FetchMarketplaceCommentsResourceNames()
        {
            // Snippet: FetchMarketplaceComments(NetworkName, IEnumerable<ProposalName>, string, int?, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = ProposalServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            PagedEnumerable<FetchMarketplaceCommentsResponse, MarketplaceComment> response = proposalServiceClient.FetchMarketplaceComments(parent, names);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MarketplaceComment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchMarketplaceCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MarketplaceComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MarketplaceComment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MarketplaceComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchMarketplaceCommentsAsync</summary>
        public async Task FetchMarketplaceCommentsResourceNamesAsync()
        {
            // Snippet: FetchMarketplaceCommentsAsync(NetworkName, IEnumerable<ProposalName>, string, int?, CallSettings)
            // Create client
            ProposalServiceClient proposalServiceClient = await ProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ProposalName> names = new ProposalName[]
            {
                ProposalName.FromNetworkCodeProposal("[NETWORK_CODE]", "[PROPOSAL]"),
            };
            // Make the request
            PagedAsyncEnumerable<FetchMarketplaceCommentsResponse, MarketplaceComment> response = proposalServiceClient.FetchMarketplaceCommentsAsync(parent, names);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MarketplaceComment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchMarketplaceCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MarketplaceComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MarketplaceComment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MarketplaceComment item in singlePage)
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
