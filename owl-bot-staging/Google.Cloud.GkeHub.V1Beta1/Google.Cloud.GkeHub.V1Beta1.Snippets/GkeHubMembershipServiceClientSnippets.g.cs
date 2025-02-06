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
    using Google.Cloud.GkeHub.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGkeHubMembershipServiceClientSnippets
    {
        /// <summary>Snippet for ListMemberships</summary>
        public void ListMembershipsRequestObject()
        {
            // Snippet: ListMemberships(ListMembershipsRequest, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            ListMembershipsRequest request = new ListMembershipsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListMembershipsResponse, Membership> response = gkeHubMembershipServiceClient.ListMemberships(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipsAsync</summary>
        public async Task ListMembershipsRequestObjectAsync()
        {
            // Snippet: ListMembershipsAsync(ListMembershipsRequest, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMembershipsRequest request = new ListMembershipsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMembershipsResponse, Membership> response = gkeHubMembershipServiceClient.ListMembershipsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Membership item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMembershipsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMemberships</summary>
        public void ListMemberships()
        {
            // Snippet: ListMemberships(string, string, int?, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMembershipsResponse, Membership> response = gkeHubMembershipServiceClient.ListMemberships(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipsAsync</summary>
        public async Task ListMembershipsAsync()
        {
            // Snippet: ListMembershipsAsync(string, string, int?, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMembershipsResponse, Membership> response = gkeHubMembershipServiceClient.ListMembershipsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Membership item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMembershipsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMemberships</summary>
        public void ListMembershipsResourceNames()
        {
            // Snippet: ListMemberships(LocationName, string, int?, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMembershipsResponse, Membership> response = gkeHubMembershipServiceClient.ListMemberships(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipsAsync</summary>
        public async Task ListMembershipsResourceNamesAsync()
        {
            // Snippet: ListMembershipsAsync(LocationName, string, int?, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMembershipsResponse, Membership> response = gkeHubMembershipServiceClient.ListMembershipsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Membership item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMembershipsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMembership</summary>
        public void GetMembershipRequestObject()
        {
            // Snippet: GetMembership(GetMembershipRequest, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            // Make the request
            Membership response = gkeHubMembershipServiceClient.GetMembership(request);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipAsync</summary>
        public async Task GetMembershipRequestObjectAsync()
        {
            // Snippet: GetMembershipAsync(GetMembershipRequest, CallSettings)
            // Additional: GetMembershipAsync(GetMembershipRequest, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            // Make the request
            Membership response = await gkeHubMembershipServiceClient.GetMembershipAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMembership</summary>
        public void GetMembership()
        {
            // Snippet: GetMembership(string, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            // Make the request
            Membership response = gkeHubMembershipServiceClient.GetMembership(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipAsync</summary>
        public async Task GetMembershipAsync()
        {
            // Snippet: GetMembershipAsync(string, CallSettings)
            // Additional: GetMembershipAsync(string, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            // Make the request
            Membership response = await gkeHubMembershipServiceClient.GetMembershipAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembership</summary>
        public void GetMembershipResourceNames()
        {
            // Snippet: GetMembership(MembershipName, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            // Make the request
            Membership response = gkeHubMembershipServiceClient.GetMembership(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipAsync</summary>
        public async Task GetMembershipResourceNamesAsync()
        {
            // Snippet: GetMembershipAsync(MembershipName, CallSettings)
            // Additional: GetMembershipAsync(MembershipName, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            // Make the request
            Membership response = await gkeHubMembershipServiceClient.GetMembershipAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateMembership</summary>
        public void CreateMembershipRequestObject()
        {
            // Snippet: CreateMembership(CreateMembershipRequest, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            CreateMembershipRequest request = new CreateMembershipRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MembershipId = "",
                Resource = new Membership(),
                RequestId = "",
            };
            // Make the request
            Operation<Membership, OperationMetadata> response = gkeHubMembershipServiceClient.CreateMembership(request);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = gkeHubMembershipServiceClient.PollOnceCreateMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipAsync</summary>
        public async Task CreateMembershipRequestObjectAsync()
        {
            // Snippet: CreateMembershipAsync(CreateMembershipRequest, CallSettings)
            // Additional: CreateMembershipAsync(CreateMembershipRequest, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMembershipRequest request = new CreateMembershipRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MembershipId = "",
                Resource = new Membership(),
                RequestId = "",
            };
            // Make the request
            Operation<Membership, OperationMetadata> response = await gkeHubMembershipServiceClient.CreateMembershipAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = await gkeHubMembershipServiceClient.PollOnceCreateMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembership</summary>
        public void CreateMembership()
        {
            // Snippet: CreateMembership(string, Membership, string, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Membership resource = new Membership();
            string membershipId = "";
            // Make the request
            Operation<Membership, OperationMetadata> response = gkeHubMembershipServiceClient.CreateMembership(parent, resource, membershipId);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = gkeHubMembershipServiceClient.PollOnceCreateMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipAsync</summary>
        public async Task CreateMembershipAsync()
        {
            // Snippet: CreateMembershipAsync(string, Membership, string, CallSettings)
            // Additional: CreateMembershipAsync(string, Membership, string, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Membership resource = new Membership();
            string membershipId = "";
            // Make the request
            Operation<Membership, OperationMetadata> response = await gkeHubMembershipServiceClient.CreateMembershipAsync(parent, resource, membershipId);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = await gkeHubMembershipServiceClient.PollOnceCreateMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembership</summary>
        public void CreateMembershipResourceNames()
        {
            // Snippet: CreateMembership(LocationName, Membership, string, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Membership resource = new Membership();
            string membershipId = "";
            // Make the request
            Operation<Membership, OperationMetadata> response = gkeHubMembershipServiceClient.CreateMembership(parent, resource, membershipId);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = gkeHubMembershipServiceClient.PollOnceCreateMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipAsync</summary>
        public async Task CreateMembershipResourceNamesAsync()
        {
            // Snippet: CreateMembershipAsync(LocationName, Membership, string, CallSettings)
            // Additional: CreateMembershipAsync(LocationName, Membership, string, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Membership resource = new Membership();
            string membershipId = "";
            // Make the request
            Operation<Membership, OperationMetadata> response = await gkeHubMembershipServiceClient.CreateMembershipAsync(parent, resource, membershipId);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = await gkeHubMembershipServiceClient.PollOnceCreateMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembership</summary>
        public void DeleteMembershipRequestObject()
        {
            // Snippet: DeleteMembership(DeleteMembershipRequest, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            DeleteMembershipRequest request = new DeleteMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubMembershipServiceClient.DeleteMembership(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubMembershipServiceClient.PollOnceDeleteMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipAsync</summary>
        public async Task DeleteMembershipRequestObjectAsync()
        {
            // Snippet: DeleteMembershipAsync(DeleteMembershipRequest, CallSettings)
            // Additional: DeleteMembershipAsync(DeleteMembershipRequest, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMembershipRequest request = new DeleteMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubMembershipServiceClient.DeleteMembershipAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubMembershipServiceClient.PollOnceDeleteMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembership</summary>
        public void DeleteMembership()
        {
            // Snippet: DeleteMembership(string, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubMembershipServiceClient.DeleteMembership(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubMembershipServiceClient.PollOnceDeleteMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipAsync</summary>
        public async Task DeleteMembershipAsync()
        {
            // Snippet: DeleteMembershipAsync(string, CallSettings)
            // Additional: DeleteMembershipAsync(string, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubMembershipServiceClient.DeleteMembershipAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubMembershipServiceClient.PollOnceDeleteMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembership</summary>
        public void DeleteMembershipResourceNames()
        {
            // Snippet: DeleteMembership(MembershipName, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubMembershipServiceClient.DeleteMembership(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubMembershipServiceClient.PollOnceDeleteMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipAsync</summary>
        public async Task DeleteMembershipResourceNamesAsync()
        {
            // Snippet: DeleteMembershipAsync(MembershipName, CallSettings)
            // Additional: DeleteMembershipAsync(MembershipName, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubMembershipServiceClient.DeleteMembershipAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubMembershipServiceClient.PollOnceDeleteMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembership</summary>
        public void UpdateMembershipRequestObject()
        {
            // Snippet: UpdateMembership(UpdateMembershipRequest, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            UpdateMembershipRequest request = new UpdateMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                UpdateMask = new FieldMask(),
                Resource = new Membership(),
                RequestId = "",
            };
            // Make the request
            Operation<Membership, OperationMetadata> response = gkeHubMembershipServiceClient.UpdateMembership(request);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = gkeHubMembershipServiceClient.PollOnceUpdateMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipAsync</summary>
        public async Task UpdateMembershipRequestObjectAsync()
        {
            // Snippet: UpdateMembershipAsync(UpdateMembershipRequest, CallSettings)
            // Additional: UpdateMembershipAsync(UpdateMembershipRequest, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMembershipRequest request = new UpdateMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                UpdateMask = new FieldMask(),
                Resource = new Membership(),
                RequestId = "",
            };
            // Make the request
            Operation<Membership, OperationMetadata> response = await gkeHubMembershipServiceClient.UpdateMembershipAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = await gkeHubMembershipServiceClient.PollOnceUpdateMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembership</summary>
        public void UpdateMembership()
        {
            // Snippet: UpdateMembership(string, Membership, FieldMask, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            Membership resource = new Membership();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Membership, OperationMetadata> response = gkeHubMembershipServiceClient.UpdateMembership(name, resource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = gkeHubMembershipServiceClient.PollOnceUpdateMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipAsync</summary>
        public async Task UpdateMembershipAsync()
        {
            // Snippet: UpdateMembershipAsync(string, Membership, FieldMask, CallSettings)
            // Additional: UpdateMembershipAsync(string, Membership, FieldMask, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            Membership resource = new Membership();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Membership, OperationMetadata> response = await gkeHubMembershipServiceClient.UpdateMembershipAsync(name, resource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = await gkeHubMembershipServiceClient.PollOnceUpdateMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembership</summary>
        public void UpdateMembershipResourceNames()
        {
            // Snippet: UpdateMembership(MembershipName, Membership, FieldMask, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            Membership resource = new Membership();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Membership, OperationMetadata> response = gkeHubMembershipServiceClient.UpdateMembership(name, resource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = gkeHubMembershipServiceClient.PollOnceUpdateMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipAsync</summary>
        public async Task UpdateMembershipResourceNamesAsync()
        {
            // Snippet: UpdateMembershipAsync(MembershipName, Membership, FieldMask, CallSettings)
            // Additional: UpdateMembershipAsync(MembershipName, Membership, FieldMask, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            Membership resource = new Membership();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Membership, OperationMetadata> response = await gkeHubMembershipServiceClient.UpdateMembershipAsync(name, resource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = await gkeHubMembershipServiceClient.PollOnceUpdateMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateConnectManifest</summary>
        public void GenerateConnectManifestRequestObject()
        {
            // Snippet: GenerateConnectManifest(GenerateConnectManifestRequest, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            GenerateConnectManifestRequest request = new GenerateConnectManifestRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                ConnectAgent = new ConnectAgent(),
                Version = "",
                IsUpgrade = false,
                Registry = "",
                ImagePullSecretContent = ByteString.Empty,
            };
            // Make the request
            GenerateConnectManifestResponse response = gkeHubMembershipServiceClient.GenerateConnectManifest(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateConnectManifestAsync</summary>
        public async Task GenerateConnectManifestRequestObjectAsync()
        {
            // Snippet: GenerateConnectManifestAsync(GenerateConnectManifestRequest, CallSettings)
            // Additional: GenerateConnectManifestAsync(GenerateConnectManifestRequest, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateConnectManifestRequest request = new GenerateConnectManifestRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                ConnectAgent = new ConnectAgent(),
                Version = "",
                IsUpgrade = false,
                Registry = "",
                ImagePullSecretContent = ByteString.Empty,
            };
            // Make the request
            GenerateConnectManifestResponse response = await gkeHubMembershipServiceClient.GenerateConnectManifestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ValidateExclusivity</summary>
        public void ValidateExclusivityRequestObject()
        {
            // Snippet: ValidateExclusivity(ValidateExclusivityRequest, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            ValidateExclusivityRequest request = new ValidateExclusivityRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CrManifest = "",
                IntendedMembership = "",
            };
            // Make the request
            ValidateExclusivityResponse response = gkeHubMembershipServiceClient.ValidateExclusivity(request);
            // End snippet
        }

        /// <summary>Snippet for ValidateExclusivityAsync</summary>
        public async Task ValidateExclusivityRequestObjectAsync()
        {
            // Snippet: ValidateExclusivityAsync(ValidateExclusivityRequest, CallSettings)
            // Additional: ValidateExclusivityAsync(ValidateExclusivityRequest, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            ValidateExclusivityRequest request = new ValidateExclusivityRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CrManifest = "",
                IntendedMembership = "",
            };
            // Make the request
            ValidateExclusivityResponse response = await gkeHubMembershipServiceClient.ValidateExclusivityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateExclusivityManifest</summary>
        public void GenerateExclusivityManifestRequestObject()
        {
            // Snippet: GenerateExclusivityManifest(GenerateExclusivityManifestRequest, CallSettings)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            GenerateExclusivityManifestRequest request = new GenerateExclusivityManifestRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                CrdManifest = "",
                CrManifest = "",
            };
            // Make the request
            GenerateExclusivityManifestResponse response = gkeHubMembershipServiceClient.GenerateExclusivityManifest(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateExclusivityManifestAsync</summary>
        public async Task GenerateExclusivityManifestRequestObjectAsync()
        {
            // Snippet: GenerateExclusivityManifestAsync(GenerateExclusivityManifestRequest, CallSettings)
            // Additional: GenerateExclusivityManifestAsync(GenerateExclusivityManifestRequest, CancellationToken)
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateExclusivityManifestRequest request = new GenerateExclusivityManifestRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                CrdManifest = "",
                CrManifest = "",
            };
            // Make the request
            GenerateExclusivityManifestResponse response = await gkeHubMembershipServiceClient.GenerateExclusivityManifestAsync(request);
            // End snippet
        }
    }
}
