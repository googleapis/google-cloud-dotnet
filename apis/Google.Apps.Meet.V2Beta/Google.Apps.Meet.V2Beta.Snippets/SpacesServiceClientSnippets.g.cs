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
    using Google.Apps.Meet.V2Beta;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSpacesServiceClientSnippets
    {
        /// <summary>Snippet for CreateSpace</summary>
        public void CreateSpaceRequestObject()
        {
            // Snippet: CreateSpace(CreateSpaceRequest, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            CreateSpaceRequest request = new CreateSpaceRequest { Space = new Space(), };
            // Make the request
            Space response = spacesServiceClient.CreateSpace(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSpaceAsync</summary>
        public async Task CreateSpaceRequestObjectAsync()
        {
            // Snippet: CreateSpaceAsync(CreateSpaceRequest, CallSettings)
            // Additional: CreateSpaceAsync(CreateSpaceRequest, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSpaceRequest request = new CreateSpaceRequest { Space = new Space(), };
            // Make the request
            Space response = await spacesServiceClient.CreateSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSpace</summary>
        public void CreateSpace()
        {
            // Snippet: CreateSpace(Space, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            Space space = new Space();
            // Make the request
            Space response = spacesServiceClient.CreateSpace(space);
            // End snippet
        }

        /// <summary>Snippet for CreateSpaceAsync</summary>
        public async Task CreateSpaceAsync()
        {
            // Snippet: CreateSpaceAsync(Space, CallSettings)
            // Additional: CreateSpaceAsync(Space, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            Space space = new Space();
            // Make the request
            Space response = await spacesServiceClient.CreateSpaceAsync(space);
            // End snippet
        }

        /// <summary>Snippet for GetSpace</summary>
        public void GetSpaceRequestObject()
        {
            // Snippet: GetSpace(GetSpaceRequest, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            GetSpaceRequest request = new GetSpaceRequest
            {
                SpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            Space response = spacesServiceClient.GetSpace(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceAsync</summary>
        public async Task GetSpaceRequestObjectAsync()
        {
            // Snippet: GetSpaceAsync(GetSpaceRequest, CallSettings)
            // Additional: GetSpaceAsync(GetSpaceRequest, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSpaceRequest request = new GetSpaceRequest
            {
                SpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            Space response = await spacesServiceClient.GetSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpace</summary>
        public void GetSpace()
        {
            // Snippet: GetSpace(string, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]";
            // Make the request
            Space response = spacesServiceClient.GetSpace(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceAsync</summary>
        public async Task GetSpaceAsync()
        {
            // Snippet: GetSpaceAsync(string, CallSettings)
            // Additional: GetSpaceAsync(string, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]";
            // Make the request
            Space response = await spacesServiceClient.GetSpaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpace</summary>
        public void GetSpaceResourceNames()
        {
            // Snippet: GetSpace(SpaceName, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromSpace("[SPACE]");
            // Make the request
            Space response = spacesServiceClient.GetSpace(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceAsync</summary>
        public async Task GetSpaceResourceNamesAsync()
        {
            // Snippet: GetSpaceAsync(SpaceName, CallSettings)
            // Additional: GetSpaceAsync(SpaceName, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromSpace("[SPACE]");
            // Make the request
            Space response = await spacesServiceClient.GetSpaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpace</summary>
        public void UpdateSpaceRequestObject()
        {
            // Snippet: UpdateSpace(UpdateSpaceRequest, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            UpdateSpaceRequest request = new UpdateSpaceRequest
            {
                Space = new Space(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Space response = spacesServiceClient.UpdateSpace(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpaceAsync</summary>
        public async Task UpdateSpaceRequestObjectAsync()
        {
            // Snippet: UpdateSpaceAsync(UpdateSpaceRequest, CallSettings)
            // Additional: UpdateSpaceAsync(UpdateSpaceRequest, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSpaceRequest request = new UpdateSpaceRequest
            {
                Space = new Space(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Space response = await spacesServiceClient.UpdateSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpace</summary>
        public void UpdateSpace()
        {
            // Snippet: UpdateSpace(Space, FieldMask, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            Space space = new Space();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Space response = spacesServiceClient.UpdateSpace(space, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpaceAsync</summary>
        public async Task UpdateSpaceAsync()
        {
            // Snippet: UpdateSpaceAsync(Space, FieldMask, CallSettings)
            // Additional: UpdateSpaceAsync(Space, FieldMask, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            Space space = new Space();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Space response = await spacesServiceClient.UpdateSpaceAsync(space, updateMask);
            // End snippet
        }

        /// <summary>Snippet for EndActiveConference</summary>
        public void EndActiveConferenceRequestObject()
        {
            // Snippet: EndActiveConference(EndActiveConferenceRequest, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            EndActiveConferenceRequest request = new EndActiveConferenceRequest
            {
                SpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            spacesServiceClient.EndActiveConference(request);
            // End snippet
        }

        /// <summary>Snippet for EndActiveConferenceAsync</summary>
        public async Task EndActiveConferenceRequestObjectAsync()
        {
            // Snippet: EndActiveConferenceAsync(EndActiveConferenceRequest, CallSettings)
            // Additional: EndActiveConferenceAsync(EndActiveConferenceRequest, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndActiveConferenceRequest request = new EndActiveConferenceRequest
            {
                SpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            await spacesServiceClient.EndActiveConferenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EndActiveConference</summary>
        public void EndActiveConference()
        {
            // Snippet: EndActiveConference(string, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]";
            // Make the request
            spacesServiceClient.EndActiveConference(name);
            // End snippet
        }

        /// <summary>Snippet for EndActiveConferenceAsync</summary>
        public async Task EndActiveConferenceAsync()
        {
            // Snippet: EndActiveConferenceAsync(string, CallSettings)
            // Additional: EndActiveConferenceAsync(string, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]";
            // Make the request
            await spacesServiceClient.EndActiveConferenceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EndActiveConference</summary>
        public void EndActiveConferenceResourceNames()
        {
            // Snippet: EndActiveConference(SpaceName, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromSpace("[SPACE]");
            // Make the request
            spacesServiceClient.EndActiveConference(name);
            // End snippet
        }

        /// <summary>Snippet for EndActiveConferenceAsync</summary>
        public async Task EndActiveConferenceResourceNamesAsync()
        {
            // Snippet: EndActiveConferenceAsync(SpaceName, CallSettings)
            // Additional: EndActiveConferenceAsync(SpaceName, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromSpace("[SPACE]");
            // Make the request
            await spacesServiceClient.EndActiveConferenceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateMember</summary>
        public void CreateMemberRequestObject()
        {
            // Snippet: CreateMember(CreateMemberRequest, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            CreateMemberRequest request = new CreateMemberRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
                Member = new Member(),
            };
            // Make the request
            Member response = spacesServiceClient.CreateMember(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMemberAsync</summary>
        public async Task CreateMemberRequestObjectAsync()
        {
            // Snippet: CreateMemberAsync(CreateMemberRequest, CallSettings)
            // Additional: CreateMemberAsync(CreateMemberRequest, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMemberRequest request = new CreateMemberRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
                Member = new Member(),
            };
            // Make the request
            Member response = await spacesServiceClient.CreateMemberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMember</summary>
        public void CreateMember()
        {
            // Snippet: CreateMember(string, Member, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]";
            Member member = new Member();
            // Make the request
            Member response = spacesServiceClient.CreateMember(parent, member);
            // End snippet
        }

        /// <summary>Snippet for CreateMemberAsync</summary>
        public async Task CreateMemberAsync()
        {
            // Snippet: CreateMemberAsync(string, Member, CallSettings)
            // Additional: CreateMemberAsync(string, Member, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]";
            Member member = new Member();
            // Make the request
            Member response = await spacesServiceClient.CreateMemberAsync(parent, member);
            // End snippet
        }

        /// <summary>Snippet for CreateMember</summary>
        public void CreateMemberResourceNames()
        {
            // Snippet: CreateMember(SpaceName, Member, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromSpace("[SPACE]");
            Member member = new Member();
            // Make the request
            Member response = spacesServiceClient.CreateMember(parent, member);
            // End snippet
        }

        /// <summary>Snippet for CreateMemberAsync</summary>
        public async Task CreateMemberResourceNamesAsync()
        {
            // Snippet: CreateMemberAsync(SpaceName, Member, CallSettings)
            // Additional: CreateMemberAsync(SpaceName, Member, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromSpace("[SPACE]");
            Member member = new Member();
            // Make the request
            Member response = await spacesServiceClient.CreateMemberAsync(parent, member);
            // End snippet
        }

        /// <summary>Snippet for GetMember</summary>
        public void GetMemberRequestObject()
        {
            // Snippet: GetMember(GetMemberRequest, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            GetMemberRequest request = new GetMemberRequest
            {
                MemberName = MemberName.FromSpaceMember("[SPACE]", "[MEMBER]"),
            };
            // Make the request
            Member response = spacesServiceClient.GetMember(request);
            // End snippet
        }

        /// <summary>Snippet for GetMemberAsync</summary>
        public async Task GetMemberRequestObjectAsync()
        {
            // Snippet: GetMemberAsync(GetMemberRequest, CallSettings)
            // Additional: GetMemberAsync(GetMemberRequest, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMemberRequest request = new GetMemberRequest
            {
                MemberName = MemberName.FromSpaceMember("[SPACE]", "[MEMBER]"),
            };
            // Make the request
            Member response = await spacesServiceClient.GetMemberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMember</summary>
        public void GetMember()
        {
            // Snippet: GetMember(string, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/members/[MEMBER]";
            // Make the request
            Member response = spacesServiceClient.GetMember(name);
            // End snippet
        }

        /// <summary>Snippet for GetMemberAsync</summary>
        public async Task GetMemberAsync()
        {
            // Snippet: GetMemberAsync(string, CallSettings)
            // Additional: GetMemberAsync(string, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/members/[MEMBER]";
            // Make the request
            Member response = await spacesServiceClient.GetMemberAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMember</summary>
        public void GetMemberResourceNames()
        {
            // Snippet: GetMember(MemberName, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            MemberName name = MemberName.FromSpaceMember("[SPACE]", "[MEMBER]");
            // Make the request
            Member response = spacesServiceClient.GetMember(name);
            // End snippet
        }

        /// <summary>Snippet for GetMemberAsync</summary>
        public async Task GetMemberResourceNamesAsync()
        {
            // Snippet: GetMemberAsync(MemberName, CallSettings)
            // Additional: GetMemberAsync(MemberName, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            MemberName name = MemberName.FromSpaceMember("[SPACE]", "[MEMBER]");
            // Make the request
            Member response = await spacesServiceClient.GetMemberAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMembers</summary>
        public void ListMembersRequestObject()
        {
            // Snippet: ListMembers(ListMembersRequest, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            ListMembersRequest request = new ListMembersRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            PagedEnumerable<ListMembersResponse, Member> response = spacesServiceClient.ListMembers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Member item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Member item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Member> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Member item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembersAsync</summary>
        public async Task ListMembersRequestObjectAsync()
        {
            // Snippet: ListMembersAsync(ListMembersRequest, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMembersRequest request = new ListMembersRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMembersResponse, Member> response = spacesServiceClient.ListMembersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Member item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMembersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Member item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Member> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Member item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembers</summary>
        public void ListMembers()
        {
            // Snippet: ListMembers(string, string, int?, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]";
            // Make the request
            PagedEnumerable<ListMembersResponse, Member> response = spacesServiceClient.ListMembers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Member item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Member item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Member> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Member item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembersAsync</summary>
        public async Task ListMembersAsync()
        {
            // Snippet: ListMembersAsync(string, string, int?, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]";
            // Make the request
            PagedAsyncEnumerable<ListMembersResponse, Member> response = spacesServiceClient.ListMembersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Member item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMembersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Member item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Member> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Member item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembers</summary>
        public void ListMembersResourceNames()
        {
            // Snippet: ListMembers(SpaceName, string, int?, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromSpace("[SPACE]");
            // Make the request
            PagedEnumerable<ListMembersResponse, Member> response = spacesServiceClient.ListMembers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Member item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Member item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Member> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Member item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembersAsync</summary>
        public async Task ListMembersResourceNamesAsync()
        {
            // Snippet: ListMembersAsync(SpaceName, string, int?, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromSpace("[SPACE]");
            // Make the request
            PagedAsyncEnumerable<ListMembersResponse, Member> response = spacesServiceClient.ListMembersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Member item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMembersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Member item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Member> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Member item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteMember</summary>
        public void DeleteMemberRequestObject()
        {
            // Snippet: DeleteMember(DeleteMemberRequest, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            DeleteMemberRequest request = new DeleteMemberRequest
            {
                MemberName = MemberName.FromSpaceMember("[SPACE]", "[MEMBER]"),
            };
            // Make the request
            spacesServiceClient.DeleteMember(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMemberAsync</summary>
        public async Task DeleteMemberRequestObjectAsync()
        {
            // Snippet: DeleteMemberAsync(DeleteMemberRequest, CallSettings)
            // Additional: DeleteMemberAsync(DeleteMemberRequest, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMemberRequest request = new DeleteMemberRequest
            {
                MemberName = MemberName.FromSpaceMember("[SPACE]", "[MEMBER]"),
            };
            // Make the request
            await spacesServiceClient.DeleteMemberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMember</summary>
        public void DeleteMember()
        {
            // Snippet: DeleteMember(string, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/members/[MEMBER]";
            // Make the request
            spacesServiceClient.DeleteMember(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMemberAsync</summary>
        public async Task DeleteMemberAsync()
        {
            // Snippet: DeleteMemberAsync(string, CallSettings)
            // Additional: DeleteMemberAsync(string, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/members/[MEMBER]";
            // Make the request
            await spacesServiceClient.DeleteMemberAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMember</summary>
        public void DeleteMemberResourceNames()
        {
            // Snippet: DeleteMember(MemberName, CallSettings)
            // Create client
            SpacesServiceClient spacesServiceClient = SpacesServiceClient.Create();
            // Initialize request argument(s)
            MemberName name = MemberName.FromSpaceMember("[SPACE]", "[MEMBER]");
            // Make the request
            spacesServiceClient.DeleteMember(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMemberAsync</summary>
        public async Task DeleteMemberResourceNamesAsync()
        {
            // Snippet: DeleteMemberAsync(MemberName, CallSettings)
            // Additional: DeleteMemberAsync(MemberName, CancellationToken)
            // Create client
            SpacesServiceClient spacesServiceClient = await SpacesServiceClient.CreateAsync();
            // Initialize request argument(s)
            MemberName name = MemberName.FromSpaceMember("[SPACE]", "[MEMBER]");
            // Make the request
            await spacesServiceClient.DeleteMemberAsync(name);
            // End snippet
        }
    }
}
