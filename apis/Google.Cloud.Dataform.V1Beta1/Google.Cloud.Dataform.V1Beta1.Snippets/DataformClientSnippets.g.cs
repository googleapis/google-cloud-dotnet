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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataform.V1Beta1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataformClientSnippets
    {
        /// <summary>Snippet for GetTeamFolder</summary>
        public void GetTeamFolderRequestObject()
        {
            // Snippet: GetTeamFolder(GetTeamFolderRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::GetTeamFolderRequest request = new gcdv::GetTeamFolderRequest
            {
                TeamFolderName = gcdv::TeamFolderName.FromProjectLocationTeamFolder("[PROJECT]", "[LOCATION]", "[TEAM_FOLDER]"),
            };
            // Make the request
            gcdv::TeamFolder response = dataformClient.GetTeamFolder(request);
            // End snippet
        }

        /// <summary>Snippet for GetTeamFolderAsync</summary>
        public async Task GetTeamFolderRequestObjectAsync()
        {
            // Snippet: GetTeamFolderAsync(GetTeamFolderRequest, CallSettings)
            // Additional: GetTeamFolderAsync(GetTeamFolderRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetTeamFolderRequest request = new gcdv::GetTeamFolderRequest
            {
                TeamFolderName = gcdv::TeamFolderName.FromProjectLocationTeamFolder("[PROJECT]", "[LOCATION]", "[TEAM_FOLDER]"),
            };
            // Make the request
            gcdv::TeamFolder response = await dataformClient.GetTeamFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTeamFolder</summary>
        public void GetTeamFolder()
        {
            // Snippet: GetTeamFolder(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/teamFolders/[TEAM_FOLDER]";
            // Make the request
            gcdv::TeamFolder response = dataformClient.GetTeamFolder(name);
            // End snippet
        }

        /// <summary>Snippet for GetTeamFolderAsync</summary>
        public async Task GetTeamFolderAsync()
        {
            // Snippet: GetTeamFolderAsync(string, CallSettings)
            // Additional: GetTeamFolderAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/teamFolders/[TEAM_FOLDER]";
            // Make the request
            gcdv::TeamFolder response = await dataformClient.GetTeamFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTeamFolder</summary>
        public void GetTeamFolderResourceNames()
        {
            // Snippet: GetTeamFolder(TeamFolderName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::TeamFolderName name = gcdv::TeamFolderName.FromProjectLocationTeamFolder("[PROJECT]", "[LOCATION]", "[TEAM_FOLDER]");
            // Make the request
            gcdv::TeamFolder response = dataformClient.GetTeamFolder(name);
            // End snippet
        }

        /// <summary>Snippet for GetTeamFolderAsync</summary>
        public async Task GetTeamFolderResourceNamesAsync()
        {
            // Snippet: GetTeamFolderAsync(TeamFolderName, CallSettings)
            // Additional: GetTeamFolderAsync(TeamFolderName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::TeamFolderName name = gcdv::TeamFolderName.FromProjectLocationTeamFolder("[PROJECT]", "[LOCATION]", "[TEAM_FOLDER]");
            // Make the request
            gcdv::TeamFolder response = await dataformClient.GetTeamFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTeamFolder</summary>
        public void CreateTeamFolderRequestObject()
        {
            // Snippet: CreateTeamFolder(CreateTeamFolderRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::CreateTeamFolderRequest request = new gcdv::CreateTeamFolderRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TeamFolder = new gcdv::TeamFolder(),
                TeamFolderId = "",
            };
            // Make the request
            gcdv::TeamFolder response = dataformClient.CreateTeamFolder(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTeamFolderAsync</summary>
        public async Task CreateTeamFolderRequestObjectAsync()
        {
            // Snippet: CreateTeamFolderAsync(CreateTeamFolderRequest, CallSettings)
            // Additional: CreateTeamFolderAsync(CreateTeamFolderRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateTeamFolderRequest request = new gcdv::CreateTeamFolderRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TeamFolder = new gcdv::TeamFolder(),
                TeamFolderId = "",
            };
            // Make the request
            gcdv::TeamFolder response = await dataformClient.CreateTeamFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTeamFolder</summary>
        public void CreateTeamFolder()
        {
            // Snippet: CreateTeamFolder(string, TeamFolder, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::TeamFolder teamFolder = new gcdv::TeamFolder();
            // Make the request
            gcdv::TeamFolder response = dataformClient.CreateTeamFolder(parent, teamFolder);
            // End snippet
        }

        /// <summary>Snippet for CreateTeamFolderAsync</summary>
        public async Task CreateTeamFolderAsync()
        {
            // Snippet: CreateTeamFolderAsync(string, TeamFolder, CallSettings)
            // Additional: CreateTeamFolderAsync(string, TeamFolder, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::TeamFolder teamFolder = new gcdv::TeamFolder();
            // Make the request
            gcdv::TeamFolder response = await dataformClient.CreateTeamFolderAsync(parent, teamFolder);
            // End snippet
        }

        /// <summary>Snippet for CreateTeamFolder</summary>
        public void CreateTeamFolderResourceNames()
        {
            // Snippet: CreateTeamFolder(LocationName, TeamFolder, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::TeamFolder teamFolder = new gcdv::TeamFolder();
            // Make the request
            gcdv::TeamFolder response = dataformClient.CreateTeamFolder(parent, teamFolder);
            // End snippet
        }

        /// <summary>Snippet for CreateTeamFolderAsync</summary>
        public async Task CreateTeamFolderResourceNamesAsync()
        {
            // Snippet: CreateTeamFolderAsync(LocationName, TeamFolder, CallSettings)
            // Additional: CreateTeamFolderAsync(LocationName, TeamFolder, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::TeamFolder teamFolder = new gcdv::TeamFolder();
            // Make the request
            gcdv::TeamFolder response = await dataformClient.CreateTeamFolderAsync(parent, teamFolder);
            // End snippet
        }

        /// <summary>Snippet for UpdateTeamFolder</summary>
        public void UpdateTeamFolderRequestObject()
        {
            // Snippet: UpdateTeamFolder(UpdateTeamFolderRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateTeamFolderRequest request = new gcdv::UpdateTeamFolderRequest
            {
                UpdateMask = new FieldMask(),
                TeamFolder = new gcdv::TeamFolder(),
            };
            // Make the request
            gcdv::TeamFolder response = dataformClient.UpdateTeamFolder(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTeamFolderAsync</summary>
        public async Task UpdateTeamFolderRequestObjectAsync()
        {
            // Snippet: UpdateTeamFolderAsync(UpdateTeamFolderRequest, CallSettings)
            // Additional: UpdateTeamFolderAsync(UpdateTeamFolderRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateTeamFolderRequest request = new gcdv::UpdateTeamFolderRequest
            {
                UpdateMask = new FieldMask(),
                TeamFolder = new gcdv::TeamFolder(),
            };
            // Make the request
            gcdv::TeamFolder response = await dataformClient.UpdateTeamFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTeamFolder</summary>
        public void UpdateTeamFolder()
        {
            // Snippet: UpdateTeamFolder(TeamFolder, FieldMask, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::TeamFolder teamFolder = new gcdv::TeamFolder();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::TeamFolder response = dataformClient.UpdateTeamFolder(teamFolder, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTeamFolderAsync</summary>
        public async Task UpdateTeamFolderAsync()
        {
            // Snippet: UpdateTeamFolderAsync(TeamFolder, FieldMask, CallSettings)
            // Additional: UpdateTeamFolderAsync(TeamFolder, FieldMask, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::TeamFolder teamFolder = new gcdv::TeamFolder();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::TeamFolder response = await dataformClient.UpdateTeamFolderAsync(teamFolder, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTeamFolder</summary>
        public void DeleteTeamFolderRequestObject()
        {
            // Snippet: DeleteTeamFolder(DeleteTeamFolderRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteTeamFolderRequest request = new gcdv::DeleteTeamFolderRequest
            {
                TeamFolderName = gcdv::TeamFolderName.FromProjectLocationTeamFolder("[PROJECT]", "[LOCATION]", "[TEAM_FOLDER]"),
            };
            // Make the request
            dataformClient.DeleteTeamFolder(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTeamFolderAsync</summary>
        public async Task DeleteTeamFolderRequestObjectAsync()
        {
            // Snippet: DeleteTeamFolderAsync(DeleteTeamFolderRequest, CallSettings)
            // Additional: DeleteTeamFolderAsync(DeleteTeamFolderRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteTeamFolderRequest request = new gcdv::DeleteTeamFolderRequest
            {
                TeamFolderName = gcdv::TeamFolderName.FromProjectLocationTeamFolder("[PROJECT]", "[LOCATION]", "[TEAM_FOLDER]"),
            };
            // Make the request
            await dataformClient.DeleteTeamFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTeamFolder</summary>
        public void DeleteTeamFolder()
        {
            // Snippet: DeleteTeamFolder(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/teamFolders/[TEAM_FOLDER]";
            // Make the request
            dataformClient.DeleteTeamFolder(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTeamFolderAsync</summary>
        public async Task DeleteTeamFolderAsync()
        {
            // Snippet: DeleteTeamFolderAsync(string, CallSettings)
            // Additional: DeleteTeamFolderAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/teamFolders/[TEAM_FOLDER]";
            // Make the request
            await dataformClient.DeleteTeamFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTeamFolder</summary>
        public void DeleteTeamFolderResourceNames()
        {
            // Snippet: DeleteTeamFolder(TeamFolderName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::TeamFolderName name = gcdv::TeamFolderName.FromProjectLocationTeamFolder("[PROJECT]", "[LOCATION]", "[TEAM_FOLDER]");
            // Make the request
            dataformClient.DeleteTeamFolder(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTeamFolderAsync</summary>
        public async Task DeleteTeamFolderResourceNamesAsync()
        {
            // Snippet: DeleteTeamFolderAsync(TeamFolderName, CallSettings)
            // Additional: DeleteTeamFolderAsync(TeamFolderName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::TeamFolderName name = gcdv::TeamFolderName.FromProjectLocationTeamFolder("[PROJECT]", "[LOCATION]", "[TEAM_FOLDER]");
            // Make the request
            await dataformClient.DeleteTeamFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for QueryTeamFolderContents</summary>
        public void QueryTeamFolderContentsRequestObject()
        {
            // Snippet: QueryTeamFolderContents(QueryTeamFolderContentsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::QueryTeamFolderContentsRequest request = new gcdv::QueryTeamFolderContentsRequest
            {
                TeamFolderAsTeamFolderName = gcdv::TeamFolderName.FromProjectLocationTeamFolder("[PROJECT]", "[LOCATION]", "[TEAM_FOLDER]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::QueryTeamFolderContentsResponse, gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> response = dataformClient.QueryTeamFolderContents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::QueryTeamFolderContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryTeamFolderContentsAsync</summary>
        public async Task QueryTeamFolderContentsRequestObjectAsync()
        {
            // Snippet: QueryTeamFolderContentsAsync(QueryTeamFolderContentsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::QueryTeamFolderContentsRequest request = new gcdv::QueryTeamFolderContentsRequest
            {
                TeamFolderAsTeamFolderName = gcdv::TeamFolderName.FromProjectLocationTeamFolder("[PROJECT]", "[LOCATION]", "[TEAM_FOLDER]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::QueryTeamFolderContentsResponse, gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> response = dataformClient.QueryTeamFolderContentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::QueryTeamFolderContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryTeamFolderContents</summary>
        public void QueryTeamFolderContents()
        {
            // Snippet: QueryTeamFolderContents(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string teamFolder = "projects/[PROJECT]/locations/[LOCATION]/teamFolders/[TEAM_FOLDER]";
            // Make the request
            PagedEnumerable<gcdv::QueryTeamFolderContentsResponse, gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> response = dataformClient.QueryTeamFolderContents(teamFolder);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::QueryTeamFolderContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryTeamFolderContentsAsync</summary>
        public async Task QueryTeamFolderContentsAsync()
        {
            // Snippet: QueryTeamFolderContentsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string teamFolder = "projects/[PROJECT]/locations/[LOCATION]/teamFolders/[TEAM_FOLDER]";
            // Make the request
            PagedAsyncEnumerable<gcdv::QueryTeamFolderContentsResponse, gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> response = dataformClient.QueryTeamFolderContentsAsync(teamFolder);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::QueryTeamFolderContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryTeamFolderContents</summary>
        public void QueryTeamFolderContentsResourceNames()
        {
            // Snippet: QueryTeamFolderContents(TeamFolderName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::TeamFolderName teamFolder = gcdv::TeamFolderName.FromProjectLocationTeamFolder("[PROJECT]", "[LOCATION]", "[TEAM_FOLDER]");
            // Make the request
            PagedEnumerable<gcdv::QueryTeamFolderContentsResponse, gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> response = dataformClient.QueryTeamFolderContents(teamFolder);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::QueryTeamFolderContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryTeamFolderContentsAsync</summary>
        public async Task QueryTeamFolderContentsResourceNamesAsync()
        {
            // Snippet: QueryTeamFolderContentsAsync(TeamFolderName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::TeamFolderName teamFolder = gcdv::TeamFolderName.FromProjectLocationTeamFolder("[PROJECT]", "[LOCATION]", "[TEAM_FOLDER]");
            // Make the request
            PagedAsyncEnumerable<gcdv::QueryTeamFolderContentsResponse, gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> response = dataformClient.QueryTeamFolderContentsAsync(teamFolder);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::QueryTeamFolderContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchTeamFolders</summary>
        public void SearchTeamFoldersRequestObject()
        {
            // Snippet: SearchTeamFolders(SearchTeamFoldersRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::SearchTeamFoldersRequest request = new gcdv::SearchTeamFoldersRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::SearchTeamFoldersResponse, gcdv::SearchTeamFoldersResponse.Types.TeamFolderSearchResult> response = dataformClient.SearchTeamFolders(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::SearchTeamFoldersResponse.Types.TeamFolderSearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::SearchTeamFoldersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::SearchTeamFoldersResponse.Types.TeamFolderSearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::SearchTeamFoldersResponse.Types.TeamFolderSearchResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::SearchTeamFoldersResponse.Types.TeamFolderSearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchTeamFoldersAsync</summary>
        public async Task SearchTeamFoldersRequestObjectAsync()
        {
            // Snippet: SearchTeamFoldersAsync(SearchTeamFoldersRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::SearchTeamFoldersRequest request = new gcdv::SearchTeamFoldersRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::SearchTeamFoldersResponse, gcdv::SearchTeamFoldersResponse.Types.TeamFolderSearchResult> response = dataformClient.SearchTeamFoldersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::SearchTeamFoldersResponse.Types.TeamFolderSearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::SearchTeamFoldersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::SearchTeamFoldersResponse.Types.TeamFolderSearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::SearchTeamFoldersResponse.Types.TeamFolderSearchResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::SearchTeamFoldersResponse.Types.TeamFolderSearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFolder</summary>
        public void GetFolderRequestObject()
        {
            // Snippet: GetFolder(GetFolderRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::GetFolderRequest request = new gcdv::GetFolderRequest
            {
                FolderName = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]"),
            };
            // Make the request
            gcdv::Folder response = dataformClient.GetFolder(request);
            // End snippet
        }

        /// <summary>Snippet for GetFolderAsync</summary>
        public async Task GetFolderRequestObjectAsync()
        {
            // Snippet: GetFolderAsync(GetFolderRequest, CallSettings)
            // Additional: GetFolderAsync(GetFolderRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetFolderRequest request = new gcdv::GetFolderRequest
            {
                FolderName = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]"),
            };
            // Make the request
            gcdv::Folder response = await dataformClient.GetFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFolder</summary>
        public void GetFolder()
        {
            // Snippet: GetFolder(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/folders/[FOLDER]";
            // Make the request
            gcdv::Folder response = dataformClient.GetFolder(name);
            // End snippet
        }

        /// <summary>Snippet for GetFolderAsync</summary>
        public async Task GetFolderAsync()
        {
            // Snippet: GetFolderAsync(string, CallSettings)
            // Additional: GetFolderAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/folders/[FOLDER]";
            // Make the request
            gcdv::Folder response = await dataformClient.GetFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFolder</summary>
        public void GetFolderResourceNames()
        {
            // Snippet: GetFolder(FolderName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::FolderName name = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]");
            // Make the request
            gcdv::Folder response = dataformClient.GetFolder(name);
            // End snippet
        }

        /// <summary>Snippet for GetFolderAsync</summary>
        public async Task GetFolderResourceNamesAsync()
        {
            // Snippet: GetFolderAsync(FolderName, CallSettings)
            // Additional: GetFolderAsync(FolderName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::FolderName name = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]");
            // Make the request
            gcdv::Folder response = await dataformClient.GetFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateFolder</summary>
        public void CreateFolderRequestObject()
        {
            // Snippet: CreateFolder(CreateFolderRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::CreateFolderRequest request = new gcdv::CreateFolderRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Folder = new gcdv::Folder(),
                FolderId = "",
            };
            // Make the request
            gcdv::Folder response = dataformClient.CreateFolder(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFolderAsync</summary>
        public async Task CreateFolderRequestObjectAsync()
        {
            // Snippet: CreateFolderAsync(CreateFolderRequest, CallSettings)
            // Additional: CreateFolderAsync(CreateFolderRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateFolderRequest request = new gcdv::CreateFolderRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Folder = new gcdv::Folder(),
                FolderId = "",
            };
            // Make the request
            gcdv::Folder response = await dataformClient.CreateFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFolder</summary>
        public void CreateFolder()
        {
            // Snippet: CreateFolder(string, Folder, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::Folder folder = new gcdv::Folder();
            // Make the request
            gcdv::Folder response = dataformClient.CreateFolder(parent, folder);
            // End snippet
        }

        /// <summary>Snippet for CreateFolderAsync</summary>
        public async Task CreateFolderAsync()
        {
            // Snippet: CreateFolderAsync(string, Folder, CallSettings)
            // Additional: CreateFolderAsync(string, Folder, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::Folder folder = new gcdv::Folder();
            // Make the request
            gcdv::Folder response = await dataformClient.CreateFolderAsync(parent, folder);
            // End snippet
        }

        /// <summary>Snippet for CreateFolder</summary>
        public void CreateFolderResourceNames()
        {
            // Snippet: CreateFolder(LocationName, Folder, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::Folder folder = new gcdv::Folder();
            // Make the request
            gcdv::Folder response = dataformClient.CreateFolder(parent, folder);
            // End snippet
        }

        /// <summary>Snippet for CreateFolderAsync</summary>
        public async Task CreateFolderResourceNamesAsync()
        {
            // Snippet: CreateFolderAsync(LocationName, Folder, CallSettings)
            // Additional: CreateFolderAsync(LocationName, Folder, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::Folder folder = new gcdv::Folder();
            // Make the request
            gcdv::Folder response = await dataformClient.CreateFolderAsync(parent, folder);
            // End snippet
        }

        /// <summary>Snippet for UpdateFolder</summary>
        public void UpdateFolderRequestObject()
        {
            // Snippet: UpdateFolder(UpdateFolderRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateFolderRequest request = new gcdv::UpdateFolderRequest
            {
                UpdateMask = new FieldMask(),
                Folder = new gcdv::Folder(),
            };
            // Make the request
            gcdv::Folder response = dataformClient.UpdateFolder(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFolderAsync</summary>
        public async Task UpdateFolderRequestObjectAsync()
        {
            // Snippet: UpdateFolderAsync(UpdateFolderRequest, CallSettings)
            // Additional: UpdateFolderAsync(UpdateFolderRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateFolderRequest request = new gcdv::UpdateFolderRequest
            {
                UpdateMask = new FieldMask(),
                Folder = new gcdv::Folder(),
            };
            // Make the request
            gcdv::Folder response = await dataformClient.UpdateFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFolder</summary>
        public void UpdateFolder()
        {
            // Snippet: UpdateFolder(Folder, FieldMask, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::Folder folder = new gcdv::Folder();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::Folder response = dataformClient.UpdateFolder(folder, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFolderAsync</summary>
        public async Task UpdateFolderAsync()
        {
            // Snippet: UpdateFolderAsync(Folder, FieldMask, CallSettings)
            // Additional: UpdateFolderAsync(Folder, FieldMask, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::Folder folder = new gcdv::Folder();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::Folder response = await dataformClient.UpdateFolderAsync(folder, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolder</summary>
        public void DeleteFolderRequestObject()
        {
            // Snippet: DeleteFolder(DeleteFolderRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteFolderRequest request = new gcdv::DeleteFolderRequest
            {
                FolderName = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]"),
            };
            // Make the request
            dataformClient.DeleteFolder(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolderAsync</summary>
        public async Task DeleteFolderRequestObjectAsync()
        {
            // Snippet: DeleteFolderAsync(DeleteFolderRequest, CallSettings)
            // Additional: DeleteFolderAsync(DeleteFolderRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteFolderRequest request = new gcdv::DeleteFolderRequest
            {
                FolderName = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]"),
            };
            // Make the request
            await dataformClient.DeleteFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolder</summary>
        public void DeleteFolder()
        {
            // Snippet: DeleteFolder(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/folders/[FOLDER]";
            // Make the request
            dataformClient.DeleteFolder(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolderAsync</summary>
        public async Task DeleteFolderAsync()
        {
            // Snippet: DeleteFolderAsync(string, CallSettings)
            // Additional: DeleteFolderAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/folders/[FOLDER]";
            // Make the request
            await dataformClient.DeleteFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolder</summary>
        public void DeleteFolderResourceNames()
        {
            // Snippet: DeleteFolder(FolderName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::FolderName name = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]");
            // Make the request
            dataformClient.DeleteFolder(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolderAsync</summary>
        public async Task DeleteFolderResourceNamesAsync()
        {
            // Snippet: DeleteFolderAsync(FolderName, CallSettings)
            // Additional: DeleteFolderAsync(FolderName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::FolderName name = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]");
            // Make the request
            await dataformClient.DeleteFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for QueryFolderContents</summary>
        public void QueryFolderContentsRequestObject()
        {
            // Snippet: QueryFolderContents(QueryFolderContentsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::QueryFolderContentsRequest request = new gcdv::QueryFolderContentsRequest
            {
                FolderAsFolderName = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::QueryFolderContentsResponse, gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry> response = dataformClient.QueryFolderContents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::QueryFolderContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryFolderContentsAsync</summary>
        public async Task QueryFolderContentsRequestObjectAsync()
        {
            // Snippet: QueryFolderContentsAsync(QueryFolderContentsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::QueryFolderContentsRequest request = new gcdv::QueryFolderContentsRequest
            {
                FolderAsFolderName = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::QueryFolderContentsResponse, gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry> response = dataformClient.QueryFolderContentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::QueryFolderContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryFolderContents</summary>
        public void QueryFolderContents()
        {
            // Snippet: QueryFolderContents(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string folder = "projects/[PROJECT]/locations/[LOCATION]/folders/[FOLDER]";
            // Make the request
            PagedEnumerable<gcdv::QueryFolderContentsResponse, gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry> response = dataformClient.QueryFolderContents(folder);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::QueryFolderContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryFolderContentsAsync</summary>
        public async Task QueryFolderContentsAsync()
        {
            // Snippet: QueryFolderContentsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string folder = "projects/[PROJECT]/locations/[LOCATION]/folders/[FOLDER]";
            // Make the request
            PagedAsyncEnumerable<gcdv::QueryFolderContentsResponse, gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry> response = dataformClient.QueryFolderContentsAsync(folder);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::QueryFolderContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryFolderContents</summary>
        public void QueryFolderContentsResourceNames()
        {
            // Snippet: QueryFolderContents(FolderName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::FolderName folder = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]");
            // Make the request
            PagedEnumerable<gcdv::QueryFolderContentsResponse, gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry> response = dataformClient.QueryFolderContents(folder);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::QueryFolderContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryFolderContentsAsync</summary>
        public async Task QueryFolderContentsResourceNamesAsync()
        {
            // Snippet: QueryFolderContentsAsync(FolderName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::FolderName folder = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<gcdv::QueryFolderContentsResponse, gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry> response = dataformClient.QueryFolderContentsAsync(folder);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::QueryFolderContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryFolderContentsResponse.Types.FolderContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryUserRootContents</summary>
        public void QueryUserRootContentsRequestObject()
        {
            // Snippet: QueryUserRootContents(QueryUserRootContentsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::QueryUserRootContentsRequest request = new gcdv::QueryUserRootContentsRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::QueryUserRootContentsResponse, gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry> response = dataformClient.QueryUserRootContents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::QueryUserRootContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryUserRootContentsAsync</summary>
        public async Task QueryUserRootContentsRequestObjectAsync()
        {
            // Snippet: QueryUserRootContentsAsync(QueryUserRootContentsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::QueryUserRootContentsRequest request = new gcdv::QueryUserRootContentsRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::QueryUserRootContentsResponse, gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry> response = dataformClient.QueryUserRootContentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::QueryUserRootContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryUserRootContents</summary>
        public void QueryUserRootContents()
        {
            // Snippet: QueryUserRootContents(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::QueryUserRootContentsResponse, gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry> response = dataformClient.QueryUserRootContents(location);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::QueryUserRootContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryUserRootContentsAsync</summary>
        public async Task QueryUserRootContentsAsync()
        {
            // Snippet: QueryUserRootContentsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::QueryUserRootContentsResponse, gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry> response = dataformClient.QueryUserRootContentsAsync(location);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::QueryUserRootContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryUserRootContents</summary>
        public void QueryUserRootContentsResourceNames()
        {
            // Snippet: QueryUserRootContents(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::QueryUserRootContentsResponse, gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry> response = dataformClient.QueryUserRootContents(location);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::QueryUserRootContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryUserRootContentsAsync</summary>
        public async Task QueryUserRootContentsResourceNamesAsync()
        {
            // Snippet: QueryUserRootContentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::QueryUserRootContentsResponse, gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry> response = dataformClient.QueryUserRootContentsAsync(location);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::QueryUserRootContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::QueryUserRootContentsResponse.Types.RootContentsEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for MoveFolder</summary>
        public void MoveFolderRequestObject()
        {
            // Snippet: MoveFolder(MoveFolderRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::MoveFolderRequest request = new gcdv::MoveFolderRequest
            {
                FolderName = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]"),
                DestinationContainingFolder = "",
            };
            // Make the request
            Operation<Empty, gcdv::MoveFolderMetadata> response = dataformClient.MoveFolder(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::MoveFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::MoveFolderMetadata> retrievedResponse = dataformClient.PollOnceMoveFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveFolderAsync</summary>
        public async Task MoveFolderRequestObjectAsync()
        {
            // Snippet: MoveFolderAsync(MoveFolderRequest, CallSettings)
            // Additional: MoveFolderAsync(MoveFolderRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::MoveFolderRequest request = new gcdv::MoveFolderRequest
            {
                FolderName = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]"),
                DestinationContainingFolder = "",
            };
            // Make the request
            Operation<Empty, gcdv::MoveFolderMetadata> response = await dataformClient.MoveFolderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::MoveFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::MoveFolderMetadata> retrievedResponse = await dataformClient.PollOnceMoveFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveFolder</summary>
        public void MoveFolder()
        {
            // Snippet: MoveFolder(string, string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/folders/[FOLDER]";
            string destinationContainingFolder = "";
            // Make the request
            Operation<Empty, gcdv::MoveFolderMetadata> response = dataformClient.MoveFolder(name, destinationContainingFolder);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::MoveFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::MoveFolderMetadata> retrievedResponse = dataformClient.PollOnceMoveFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveFolderAsync</summary>
        public async Task MoveFolderAsync()
        {
            // Snippet: MoveFolderAsync(string, string, CallSettings)
            // Additional: MoveFolderAsync(string, string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/folders/[FOLDER]";
            string destinationContainingFolder = "";
            // Make the request
            Operation<Empty, gcdv::MoveFolderMetadata> response = await dataformClient.MoveFolderAsync(name, destinationContainingFolder);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::MoveFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::MoveFolderMetadata> retrievedResponse = await dataformClient.PollOnceMoveFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveFolder</summary>
        public void MoveFolderResourceNames()
        {
            // Snippet: MoveFolder(FolderName, string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::FolderName name = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]");
            string destinationContainingFolder = "";
            // Make the request
            Operation<Empty, gcdv::MoveFolderMetadata> response = dataformClient.MoveFolder(name, destinationContainingFolder);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::MoveFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::MoveFolderMetadata> retrievedResponse = dataformClient.PollOnceMoveFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveFolderAsync</summary>
        public async Task MoveFolderResourceNamesAsync()
        {
            // Snippet: MoveFolderAsync(FolderName, string, CallSettings)
            // Additional: MoveFolderAsync(FolderName, string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::FolderName name = gcdv::FolderName.FromProjectLocationFolder("[PROJECT]", "[LOCATION]", "[FOLDER]");
            string destinationContainingFolder = "";
            // Make the request
            Operation<Empty, gcdv::MoveFolderMetadata> response = await dataformClient.MoveFolderAsync(name, destinationContainingFolder);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::MoveFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::MoveFolderMetadata> retrievedResponse = await dataformClient.PollOnceMoveFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositoriesRequestObject()
        {
            // Snippet: ListRepositories(ListRepositoriesRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::ListRepositoriesRequest request = new gcdv::ListRepositoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListRepositoriesResponse, gcdv::Repository> response = dataformClient.ListRepositories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesRequestObjectAsync()
        {
            // Snippet: ListRepositoriesAsync(ListRepositoriesRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListRepositoriesRequest request = new gcdv::ListRepositoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListRepositoriesResponse, gcdv::Repository> response = dataformClient.ListRepositoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositories()
        {
            // Snippet: ListRepositories(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::ListRepositoriesResponse, gcdv::Repository> response = dataformClient.ListRepositories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesAsync()
        {
            // Snippet: ListRepositoriesAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListRepositoriesResponse, gcdv::Repository> response = dataformClient.ListRepositoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositoriesResourceNames()
        {
            // Snippet: ListRepositories(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListRepositoriesResponse, gcdv::Repository> response = dataformClient.ListRepositories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesResourceNamesAsync()
        {
            // Snippet: ListRepositoriesAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListRepositoriesResponse, gcdv::Repository> response = dataformClient.ListRepositoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepositoryRequestObject()
        {
            // Snippet: GetRepository(GetRepositoryRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::GetRepositoryRequest request = new gcdv::GetRepositoryRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            gcdv::Repository response = dataformClient.GetRepository(request);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryRequestObjectAsync()
        {
            // Snippet: GetRepositoryAsync(GetRepositoryRequest, CallSettings)
            // Additional: GetRepositoryAsync(GetRepositoryRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetRepositoryRequest request = new gcdv::GetRepositoryRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            gcdv::Repository response = await dataformClient.GetRepositoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepository()
        {
            // Snippet: GetRepository(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            gcdv::Repository response = dataformClient.GetRepository(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryAsync()
        {
            // Snippet: GetRepositoryAsync(string, CallSettings)
            // Additional: GetRepositoryAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            gcdv::Repository response = await dataformClient.GetRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepositoryResourceNames()
        {
            // Snippet: GetRepository(RepositoryName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RepositoryName name = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            gcdv::Repository response = dataformClient.GetRepository(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryResourceNamesAsync()
        {
            // Snippet: GetRepositoryAsync(RepositoryName, CallSettings)
            // Additional: GetRepositoryAsync(RepositoryName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RepositoryName name = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            gcdv::Repository response = await dataformClient.GetRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepositoryRequestObject()
        {
            // Snippet: CreateRepository(CreateRepositoryRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::CreateRepositoryRequest request = new gcdv::CreateRepositoryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Repository = new gcdv::Repository(),
                RepositoryId = "",
            };
            // Make the request
            gcdv::Repository response = dataformClient.CreateRepository(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryRequestObjectAsync()
        {
            // Snippet: CreateRepositoryAsync(CreateRepositoryRequest, CallSettings)
            // Additional: CreateRepositoryAsync(CreateRepositoryRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateRepositoryRequest request = new gcdv::CreateRepositoryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Repository = new gcdv::Repository(),
                RepositoryId = "",
            };
            // Make the request
            gcdv::Repository response = await dataformClient.CreateRepositoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepository()
        {
            // Snippet: CreateRepository(string, Repository, string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::Repository repository = new gcdv::Repository();
            string repositoryId = "";
            // Make the request
            gcdv::Repository response = dataformClient.CreateRepository(parent, repository, repositoryId);
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryAsync()
        {
            // Snippet: CreateRepositoryAsync(string, Repository, string, CallSettings)
            // Additional: CreateRepositoryAsync(string, Repository, string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::Repository repository = new gcdv::Repository();
            string repositoryId = "";
            // Make the request
            gcdv::Repository response = await dataformClient.CreateRepositoryAsync(parent, repository, repositoryId);
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepositoryResourceNames()
        {
            // Snippet: CreateRepository(LocationName, Repository, string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::Repository repository = new gcdv::Repository();
            string repositoryId = "";
            // Make the request
            gcdv::Repository response = dataformClient.CreateRepository(parent, repository, repositoryId);
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryResourceNamesAsync()
        {
            // Snippet: CreateRepositoryAsync(LocationName, Repository, string, CallSettings)
            // Additional: CreateRepositoryAsync(LocationName, Repository, string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::Repository repository = new gcdv::Repository();
            string repositoryId = "";
            // Make the request
            gcdv::Repository response = await dataformClient.CreateRepositoryAsync(parent, repository, repositoryId);
            // End snippet
        }

        /// <summary>Snippet for UpdateRepository</summary>
        public void UpdateRepositoryRequestObject()
        {
            // Snippet: UpdateRepository(UpdateRepositoryRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateRepositoryRequest request = new gcdv::UpdateRepositoryRequest
            {
                UpdateMask = new FieldMask(),
                Repository = new gcdv::Repository(),
            };
            // Make the request
            gcdv::Repository response = dataformClient.UpdateRepository(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRepositoryAsync</summary>
        public async Task UpdateRepositoryRequestObjectAsync()
        {
            // Snippet: UpdateRepositoryAsync(UpdateRepositoryRequest, CallSettings)
            // Additional: UpdateRepositoryAsync(UpdateRepositoryRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateRepositoryRequest request = new gcdv::UpdateRepositoryRequest
            {
                UpdateMask = new FieldMask(),
                Repository = new gcdv::Repository(),
            };
            // Make the request
            gcdv::Repository response = await dataformClient.UpdateRepositoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRepository</summary>
        public void UpdateRepository()
        {
            // Snippet: UpdateRepository(Repository, FieldMask, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::Repository repository = new gcdv::Repository();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::Repository response = dataformClient.UpdateRepository(repository, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateRepositoryAsync</summary>
        public async Task UpdateRepositoryAsync()
        {
            // Snippet: UpdateRepositoryAsync(Repository, FieldMask, CallSettings)
            // Additional: UpdateRepositoryAsync(Repository, FieldMask, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::Repository repository = new gcdv::Repository();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::Repository response = await dataformClient.UpdateRepositoryAsync(repository, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepositoryRequestObject()
        {
            // Snippet: DeleteRepository(DeleteRepositoryRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteRepositoryRequest request = new gcdv::DeleteRepositoryRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Force = false,
            };
            // Make the request
            dataformClient.DeleteRepository(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryRequestObjectAsync()
        {
            // Snippet: DeleteRepositoryAsync(DeleteRepositoryRequest, CallSettings)
            // Additional: DeleteRepositoryAsync(DeleteRepositoryRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteRepositoryRequest request = new gcdv::DeleteRepositoryRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Force = false,
            };
            // Make the request
            await dataformClient.DeleteRepositoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepository()
        {
            // Snippet: DeleteRepository(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            dataformClient.DeleteRepository(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryAsync()
        {
            // Snippet: DeleteRepositoryAsync(string, CallSettings)
            // Additional: DeleteRepositoryAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            await dataformClient.DeleteRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepositoryResourceNames()
        {
            // Snippet: DeleteRepository(RepositoryName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RepositoryName name = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            dataformClient.DeleteRepository(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryResourceNamesAsync()
        {
            // Snippet: DeleteRepositoryAsync(RepositoryName, CallSettings)
            // Additional: DeleteRepositoryAsync(RepositoryName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RepositoryName name = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            await dataformClient.DeleteRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for MoveRepository</summary>
        public void MoveRepositoryRequestObject()
        {
            // Snippet: MoveRepository(MoveRepositoryRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::MoveRepositoryRequest request = new gcdv::MoveRepositoryRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                DestinationContainingFolder = "",
            };
            // Make the request
            Operation<Empty, gcdv::MoveRepositoryMetadata> response = dataformClient.MoveRepository(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::MoveRepositoryMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::MoveRepositoryMetadata> retrievedResponse = dataformClient.PollOnceMoveRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveRepositoryAsync</summary>
        public async Task MoveRepositoryRequestObjectAsync()
        {
            // Snippet: MoveRepositoryAsync(MoveRepositoryRequest, CallSettings)
            // Additional: MoveRepositoryAsync(MoveRepositoryRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::MoveRepositoryRequest request = new gcdv::MoveRepositoryRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                DestinationContainingFolder = "",
            };
            // Make the request
            Operation<Empty, gcdv::MoveRepositoryMetadata> response = await dataformClient.MoveRepositoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::MoveRepositoryMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::MoveRepositoryMetadata> retrievedResponse = await dataformClient.PollOnceMoveRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveRepository</summary>
        public void MoveRepository()
        {
            // Snippet: MoveRepository(string, string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            string destinationContainingFolder = "";
            // Make the request
            Operation<Empty, gcdv::MoveRepositoryMetadata> response = dataformClient.MoveRepository(name, destinationContainingFolder);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::MoveRepositoryMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::MoveRepositoryMetadata> retrievedResponse = dataformClient.PollOnceMoveRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveRepositoryAsync</summary>
        public async Task MoveRepositoryAsync()
        {
            // Snippet: MoveRepositoryAsync(string, string, CallSettings)
            // Additional: MoveRepositoryAsync(string, string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            string destinationContainingFolder = "";
            // Make the request
            Operation<Empty, gcdv::MoveRepositoryMetadata> response = await dataformClient.MoveRepositoryAsync(name, destinationContainingFolder);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::MoveRepositoryMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::MoveRepositoryMetadata> retrievedResponse = await dataformClient.PollOnceMoveRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveRepository</summary>
        public void MoveRepositoryResourceNames()
        {
            // Snippet: MoveRepository(RepositoryName, string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RepositoryName name = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            string destinationContainingFolder = "";
            // Make the request
            Operation<Empty, gcdv::MoveRepositoryMetadata> response = dataformClient.MoveRepository(name, destinationContainingFolder);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::MoveRepositoryMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::MoveRepositoryMetadata> retrievedResponse = dataformClient.PollOnceMoveRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveRepositoryAsync</summary>
        public async Task MoveRepositoryResourceNamesAsync()
        {
            // Snippet: MoveRepositoryAsync(RepositoryName, string, CallSettings)
            // Additional: MoveRepositoryAsync(RepositoryName, string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RepositoryName name = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            string destinationContainingFolder = "";
            // Make the request
            Operation<Empty, gcdv::MoveRepositoryMetadata> response = await dataformClient.MoveRepositoryAsync(name, destinationContainingFolder);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::MoveRepositoryMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::MoveRepositoryMetadata> retrievedResponse = await dataformClient.PollOnceMoveRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CommitRepositoryChanges</summary>
        public void CommitRepositoryChangesRequestObject()
        {
            // Snippet: CommitRepositoryChanges(CommitRepositoryChangesRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::CommitRepositoryChangesRequest request = new gcdv::CommitRepositoryChangesRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CommitMetadata = new gcdv::CommitMetadata(),
                FileOperations =
                {
                    {
                        "",
                        new gcdv::CommitRepositoryChangesRequest.Types.FileOperation()
                    },
                },
                RequiredHeadCommitSha = "",
            };
            // Make the request
            gcdv::CommitRepositoryChangesResponse response = dataformClient.CommitRepositoryChanges(request);
            // End snippet
        }

        /// <summary>Snippet for CommitRepositoryChangesAsync</summary>
        public async Task CommitRepositoryChangesRequestObjectAsync()
        {
            // Snippet: CommitRepositoryChangesAsync(CommitRepositoryChangesRequest, CallSettings)
            // Additional: CommitRepositoryChangesAsync(CommitRepositoryChangesRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CommitRepositoryChangesRequest request = new gcdv::CommitRepositoryChangesRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CommitMetadata = new gcdv::CommitMetadata(),
                FileOperations =
                {
                    {
                        "",
                        new gcdv::CommitRepositoryChangesRequest.Types.FileOperation()
                    },
                },
                RequiredHeadCommitSha = "",
            };
            // Make the request
            gcdv::CommitRepositoryChangesResponse response = await dataformClient.CommitRepositoryChangesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReadRepositoryFile</summary>
        public void ReadRepositoryFileRequestObject()
        {
            // Snippet: ReadRepositoryFile(ReadRepositoryFileRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::ReadRepositoryFileRequest request = new gcdv::ReadRepositoryFileRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CommitSha = "",
                Path = "",
            };
            // Make the request
            gcdv::ReadRepositoryFileResponse response = dataformClient.ReadRepositoryFile(request);
            // End snippet
        }

        /// <summary>Snippet for ReadRepositoryFileAsync</summary>
        public async Task ReadRepositoryFileRequestObjectAsync()
        {
            // Snippet: ReadRepositoryFileAsync(ReadRepositoryFileRequest, CallSettings)
            // Additional: ReadRepositoryFileAsync(ReadRepositoryFileRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ReadRepositoryFileRequest request = new gcdv::ReadRepositoryFileRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CommitSha = "",
                Path = "",
            };
            // Make the request
            gcdv::ReadRepositoryFileResponse response = await dataformClient.ReadRepositoryFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryRepositoryDirectoryContents</summary>
        public void QueryRepositoryDirectoryContentsRequestObject()
        {
            // Snippet: QueryRepositoryDirectoryContents(QueryRepositoryDirectoryContentsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::QueryRepositoryDirectoryContentsRequest request = new gcdv::QueryRepositoryDirectoryContentsRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CommitSha = "",
                Path = "",
            };
            // Make the request
            PagedEnumerable<gcdv::QueryRepositoryDirectoryContentsResponse, gcdv::DirectoryEntry> response = dataformClient.QueryRepositoryDirectoryContents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DirectoryEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::QueryRepositoryDirectoryContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DirectoryEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DirectoryEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DirectoryEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryRepositoryDirectoryContentsAsync</summary>
        public async Task QueryRepositoryDirectoryContentsRequestObjectAsync()
        {
            // Snippet: QueryRepositoryDirectoryContentsAsync(QueryRepositoryDirectoryContentsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::QueryRepositoryDirectoryContentsRequest request = new gcdv::QueryRepositoryDirectoryContentsRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CommitSha = "",
                Path = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::QueryRepositoryDirectoryContentsResponse, gcdv::DirectoryEntry> response = dataformClient.QueryRepositoryDirectoryContentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::DirectoryEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::QueryRepositoryDirectoryContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DirectoryEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DirectoryEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DirectoryEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchRepositoryHistory</summary>
        public void FetchRepositoryHistoryRequestObject()
        {
            // Snippet: FetchRepositoryHistory(FetchRepositoryHistoryRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::FetchRepositoryHistoryRequest request = new gcdv::FetchRepositoryHistoryRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<gcdv::FetchRepositoryHistoryResponse, gcdv::CommitLogEntry> response = dataformClient.FetchRepositoryHistory(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::CommitLogEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::FetchRepositoryHistoryResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::CommitLogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::CommitLogEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::CommitLogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchRepositoryHistoryAsync</summary>
        public async Task FetchRepositoryHistoryRequestObjectAsync()
        {
            // Snippet: FetchRepositoryHistoryAsync(FetchRepositoryHistoryRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::FetchRepositoryHistoryRequest request = new gcdv::FetchRepositoryHistoryRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::FetchRepositoryHistoryResponse, gcdv::CommitLogEntry> response = dataformClient.FetchRepositoryHistoryAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::CommitLogEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::FetchRepositoryHistoryResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::CommitLogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::CommitLogEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::CommitLogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ComputeRepositoryAccessTokenStatus</summary>
        public void ComputeRepositoryAccessTokenStatusRequestObject()
        {
            // Snippet: ComputeRepositoryAccessTokenStatus(ComputeRepositoryAccessTokenStatusRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::ComputeRepositoryAccessTokenStatusRequest request = new gcdv::ComputeRepositoryAccessTokenStatusRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            gcdv::ComputeRepositoryAccessTokenStatusResponse response = dataformClient.ComputeRepositoryAccessTokenStatus(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeRepositoryAccessTokenStatusAsync</summary>
        public async Task ComputeRepositoryAccessTokenStatusRequestObjectAsync()
        {
            // Snippet: ComputeRepositoryAccessTokenStatusAsync(ComputeRepositoryAccessTokenStatusRequest, CallSettings)
            // Additional: ComputeRepositoryAccessTokenStatusAsync(ComputeRepositoryAccessTokenStatusRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ComputeRepositoryAccessTokenStatusRequest request = new gcdv::ComputeRepositoryAccessTokenStatusRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            gcdv::ComputeRepositoryAccessTokenStatusResponse response = await dataformClient.ComputeRepositoryAccessTokenStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchRemoteBranches</summary>
        public void FetchRemoteBranchesRequestObject()
        {
            // Snippet: FetchRemoteBranches(FetchRemoteBranchesRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::FetchRemoteBranchesRequest request = new gcdv::FetchRemoteBranchesRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            gcdv::FetchRemoteBranchesResponse response = dataformClient.FetchRemoteBranches(request);
            // End snippet
        }

        /// <summary>Snippet for FetchRemoteBranchesAsync</summary>
        public async Task FetchRemoteBranchesRequestObjectAsync()
        {
            // Snippet: FetchRemoteBranchesAsync(FetchRemoteBranchesRequest, CallSettings)
            // Additional: FetchRemoteBranchesAsync(FetchRemoteBranchesRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::FetchRemoteBranchesRequest request = new gcdv::FetchRemoteBranchesRequest
            {
                RepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            gcdv::FetchRemoteBranchesResponse response = await dataformClient.FetchRemoteBranchesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListWorkspaces</summary>
        public void ListWorkspacesRequestObject()
        {
            // Snippet: ListWorkspaces(ListWorkspacesRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::ListWorkspacesRequest request = new gcdv::ListWorkspacesRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListWorkspacesResponse, gcdv::Workspace> response = dataformClient.ListWorkspaces(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Workspace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListWorkspacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Workspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Workspace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Workspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkspacesAsync</summary>
        public async Task ListWorkspacesRequestObjectAsync()
        {
            // Snippet: ListWorkspacesAsync(ListWorkspacesRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListWorkspacesRequest request = new gcdv::ListWorkspacesRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListWorkspacesResponse, gcdv::Workspace> response = dataformClient.ListWorkspacesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::Workspace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListWorkspacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Workspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Workspace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Workspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkspaces</summary>
        public void ListWorkspaces()
        {
            // Snippet: ListWorkspaces(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<gcdv::ListWorkspacesResponse, gcdv::Workspace> response = dataformClient.ListWorkspaces(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Workspace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListWorkspacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Workspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Workspace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Workspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkspacesAsync</summary>
        public async Task ListWorkspacesAsync()
        {
            // Snippet: ListWorkspacesAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListWorkspacesResponse, gcdv::Workspace> response = dataformClient.ListWorkspacesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::Workspace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListWorkspacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Workspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Workspace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Workspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkspaces</summary>
        public void ListWorkspacesResourceNames()
        {
            // Snippet: ListWorkspaces(RepositoryName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<gcdv::ListWorkspacesResponse, gcdv::Workspace> response = dataformClient.ListWorkspaces(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Workspace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListWorkspacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Workspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Workspace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Workspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkspacesAsync</summary>
        public async Task ListWorkspacesResourceNamesAsync()
        {
            // Snippet: ListWorkspacesAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListWorkspacesResponse, gcdv::Workspace> response = dataformClient.ListWorkspacesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::Workspace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListWorkspacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Workspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Workspace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Workspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetWorkspace</summary>
        public void GetWorkspaceRequestObject()
        {
            // Snippet: GetWorkspace(GetWorkspaceRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::GetWorkspaceRequest request = new gcdv::GetWorkspaceRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            gcdv::Workspace response = dataformClient.GetWorkspace(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspaceAsync</summary>
        public async Task GetWorkspaceRequestObjectAsync()
        {
            // Snippet: GetWorkspaceAsync(GetWorkspaceRequest, CallSettings)
            // Additional: GetWorkspaceAsync(GetWorkspaceRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetWorkspaceRequest request = new gcdv::GetWorkspaceRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            gcdv::Workspace response = await dataformClient.GetWorkspaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspace</summary>
        public void GetWorkspace()
        {
            // Snippet: GetWorkspace(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workspaces/[WORKSPACE]";
            // Make the request
            gcdv::Workspace response = dataformClient.GetWorkspace(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspaceAsync</summary>
        public async Task GetWorkspaceAsync()
        {
            // Snippet: GetWorkspaceAsync(string, CallSettings)
            // Additional: GetWorkspaceAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workspaces/[WORKSPACE]";
            // Make the request
            gcdv::Workspace response = await dataformClient.GetWorkspaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspace</summary>
        public void GetWorkspaceResourceNames()
        {
            // Snippet: GetWorkspace(WorkspaceName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::WorkspaceName name = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]");
            // Make the request
            gcdv::Workspace response = dataformClient.GetWorkspace(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspaceAsync</summary>
        public async Task GetWorkspaceResourceNamesAsync()
        {
            // Snippet: GetWorkspaceAsync(WorkspaceName, CallSettings)
            // Additional: GetWorkspaceAsync(WorkspaceName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::WorkspaceName name = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]");
            // Make the request
            gcdv::Workspace response = await dataformClient.GetWorkspaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkspace</summary>
        public void CreateWorkspaceRequestObject()
        {
            // Snippet: CreateWorkspace(CreateWorkspaceRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::CreateWorkspaceRequest request = new gcdv::CreateWorkspaceRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Workspace = new gcdv::Workspace(),
                WorkspaceId = "",
            };
            // Make the request
            gcdv::Workspace response = dataformClient.CreateWorkspace(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkspaceAsync</summary>
        public async Task CreateWorkspaceRequestObjectAsync()
        {
            // Snippet: CreateWorkspaceAsync(CreateWorkspaceRequest, CallSettings)
            // Additional: CreateWorkspaceAsync(CreateWorkspaceRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateWorkspaceRequest request = new gcdv::CreateWorkspaceRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Workspace = new gcdv::Workspace(),
                WorkspaceId = "",
            };
            // Make the request
            gcdv::Workspace response = await dataformClient.CreateWorkspaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkspace</summary>
        public void CreateWorkspace()
        {
            // Snippet: CreateWorkspace(string, Workspace, string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            gcdv::Workspace workspace = new gcdv::Workspace();
            string workspaceId = "";
            // Make the request
            gcdv::Workspace response = dataformClient.CreateWorkspace(parent, workspace, workspaceId);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkspaceAsync</summary>
        public async Task CreateWorkspaceAsync()
        {
            // Snippet: CreateWorkspaceAsync(string, Workspace, string, CallSettings)
            // Additional: CreateWorkspaceAsync(string, Workspace, string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            gcdv::Workspace workspace = new gcdv::Workspace();
            string workspaceId = "";
            // Make the request
            gcdv::Workspace response = await dataformClient.CreateWorkspaceAsync(parent, workspace, workspaceId);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkspace</summary>
        public void CreateWorkspaceResourceNames()
        {
            // Snippet: CreateWorkspace(RepositoryName, Workspace, string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            gcdv::Workspace workspace = new gcdv::Workspace();
            string workspaceId = "";
            // Make the request
            gcdv::Workspace response = dataformClient.CreateWorkspace(parent, workspace, workspaceId);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkspaceAsync</summary>
        public async Task CreateWorkspaceResourceNamesAsync()
        {
            // Snippet: CreateWorkspaceAsync(RepositoryName, Workspace, string, CallSettings)
            // Additional: CreateWorkspaceAsync(RepositoryName, Workspace, string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            gcdv::Workspace workspace = new gcdv::Workspace();
            string workspaceId = "";
            // Make the request
            gcdv::Workspace response = await dataformClient.CreateWorkspaceAsync(parent, workspace, workspaceId);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkspace</summary>
        public void DeleteWorkspaceRequestObject()
        {
            // Snippet: DeleteWorkspace(DeleteWorkspaceRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteWorkspaceRequest request = new gcdv::DeleteWorkspaceRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            dataformClient.DeleteWorkspace(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkspaceAsync</summary>
        public async Task DeleteWorkspaceRequestObjectAsync()
        {
            // Snippet: DeleteWorkspaceAsync(DeleteWorkspaceRequest, CallSettings)
            // Additional: DeleteWorkspaceAsync(DeleteWorkspaceRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteWorkspaceRequest request = new gcdv::DeleteWorkspaceRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            await dataformClient.DeleteWorkspaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkspace</summary>
        public void DeleteWorkspace()
        {
            // Snippet: DeleteWorkspace(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workspaces/[WORKSPACE]";
            // Make the request
            dataformClient.DeleteWorkspace(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkspaceAsync</summary>
        public async Task DeleteWorkspaceAsync()
        {
            // Snippet: DeleteWorkspaceAsync(string, CallSettings)
            // Additional: DeleteWorkspaceAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workspaces/[WORKSPACE]";
            // Make the request
            await dataformClient.DeleteWorkspaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkspace</summary>
        public void DeleteWorkspaceResourceNames()
        {
            // Snippet: DeleteWorkspace(WorkspaceName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::WorkspaceName name = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]");
            // Make the request
            dataformClient.DeleteWorkspace(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkspaceAsync</summary>
        public async Task DeleteWorkspaceResourceNamesAsync()
        {
            // Snippet: DeleteWorkspaceAsync(WorkspaceName, CallSettings)
            // Additional: DeleteWorkspaceAsync(WorkspaceName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::WorkspaceName name = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]");
            // Make the request
            await dataformClient.DeleteWorkspaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for InstallNpmPackages</summary>
        public void InstallNpmPackagesRequestObject()
        {
            // Snippet: InstallNpmPackages(InstallNpmPackagesRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::InstallNpmPackagesRequest request = new gcdv::InstallNpmPackagesRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            gcdv::InstallNpmPackagesResponse response = dataformClient.InstallNpmPackages(request);
            // End snippet
        }

        /// <summary>Snippet for InstallNpmPackagesAsync</summary>
        public async Task InstallNpmPackagesRequestObjectAsync()
        {
            // Snippet: InstallNpmPackagesAsync(InstallNpmPackagesRequest, CallSettings)
            // Additional: InstallNpmPackagesAsync(InstallNpmPackagesRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::InstallNpmPackagesRequest request = new gcdv::InstallNpmPackagesRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            gcdv::InstallNpmPackagesResponse response = await dataformClient.InstallNpmPackagesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PullGitCommits</summary>
        public void PullGitCommitsRequestObject()
        {
            // Snippet: PullGitCommits(PullGitCommitsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::PullGitCommitsRequest request = new gcdv::PullGitCommitsRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "",
                Author = new gcdv::CommitAuthor(),
            };
            // Make the request
            gcdv::PullGitCommitsResponse response = dataformClient.PullGitCommits(request);
            // End snippet
        }

        /// <summary>Snippet for PullGitCommitsAsync</summary>
        public async Task PullGitCommitsRequestObjectAsync()
        {
            // Snippet: PullGitCommitsAsync(PullGitCommitsRequest, CallSettings)
            // Additional: PullGitCommitsAsync(PullGitCommitsRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::PullGitCommitsRequest request = new gcdv::PullGitCommitsRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "",
                Author = new gcdv::CommitAuthor(),
            };
            // Make the request
            gcdv::PullGitCommitsResponse response = await dataformClient.PullGitCommitsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PushGitCommits</summary>
        public void PushGitCommitsRequestObject()
        {
            // Snippet: PushGitCommits(PushGitCommitsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::PushGitCommitsRequest request = new gcdv::PushGitCommitsRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "",
            };
            // Make the request
            gcdv::PushGitCommitsResponse response = dataformClient.PushGitCommits(request);
            // End snippet
        }

        /// <summary>Snippet for PushGitCommitsAsync</summary>
        public async Task PushGitCommitsRequestObjectAsync()
        {
            // Snippet: PushGitCommitsAsync(PushGitCommitsRequest, CallSettings)
            // Additional: PushGitCommitsAsync(PushGitCommitsRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::PushGitCommitsRequest request = new gcdv::PushGitCommitsRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "",
            };
            // Make the request
            gcdv::PushGitCommitsResponse response = await dataformClient.PushGitCommitsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchFileGitStatuses</summary>
        public void FetchFileGitStatusesRequestObject()
        {
            // Snippet: FetchFileGitStatuses(FetchFileGitStatusesRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::FetchFileGitStatusesRequest request = new gcdv::FetchFileGitStatusesRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            gcdv::FetchFileGitStatusesResponse response = dataformClient.FetchFileGitStatuses(request);
            // End snippet
        }

        /// <summary>Snippet for FetchFileGitStatusesAsync</summary>
        public async Task FetchFileGitStatusesRequestObjectAsync()
        {
            // Snippet: FetchFileGitStatusesAsync(FetchFileGitStatusesRequest, CallSettings)
            // Additional: FetchFileGitStatusesAsync(FetchFileGitStatusesRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::FetchFileGitStatusesRequest request = new gcdv::FetchFileGitStatusesRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            gcdv::FetchFileGitStatusesResponse response = await dataformClient.FetchFileGitStatusesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchGitAheadBehind</summary>
        public void FetchGitAheadBehindRequestObject()
        {
            // Snippet: FetchGitAheadBehind(FetchGitAheadBehindRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::FetchGitAheadBehindRequest request = new gcdv::FetchGitAheadBehindRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "",
            };
            // Make the request
            gcdv::FetchGitAheadBehindResponse response = dataformClient.FetchGitAheadBehind(request);
            // End snippet
        }

        /// <summary>Snippet for FetchGitAheadBehindAsync</summary>
        public async Task FetchGitAheadBehindRequestObjectAsync()
        {
            // Snippet: FetchGitAheadBehindAsync(FetchGitAheadBehindRequest, CallSettings)
            // Additional: FetchGitAheadBehindAsync(FetchGitAheadBehindRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::FetchGitAheadBehindRequest request = new gcdv::FetchGitAheadBehindRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "",
            };
            // Make the request
            gcdv::FetchGitAheadBehindResponse response = await dataformClient.FetchGitAheadBehindAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CommitWorkspaceChanges</summary>
        public void CommitWorkspaceChangesRequestObject()
        {
            // Snippet: CommitWorkspaceChanges(CommitWorkspaceChangesRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::CommitWorkspaceChangesRequest request = new gcdv::CommitWorkspaceChangesRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CommitMessage = "",
                Paths = { "", },
                Author = new gcdv::CommitAuthor(),
            };
            // Make the request
            gcdv::CommitWorkspaceChangesResponse response = dataformClient.CommitWorkspaceChanges(request);
            // End snippet
        }

        /// <summary>Snippet for CommitWorkspaceChangesAsync</summary>
        public async Task CommitWorkspaceChangesRequestObjectAsync()
        {
            // Snippet: CommitWorkspaceChangesAsync(CommitWorkspaceChangesRequest, CallSettings)
            // Additional: CommitWorkspaceChangesAsync(CommitWorkspaceChangesRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CommitWorkspaceChangesRequest request = new gcdv::CommitWorkspaceChangesRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CommitMessage = "",
                Paths = { "", },
                Author = new gcdv::CommitAuthor(),
            };
            // Make the request
            gcdv::CommitWorkspaceChangesResponse response = await dataformClient.CommitWorkspaceChangesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResetWorkspaceChanges</summary>
        public void ResetWorkspaceChangesRequestObject()
        {
            // Snippet: ResetWorkspaceChanges(ResetWorkspaceChangesRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::ResetWorkspaceChangesRequest request = new gcdv::ResetWorkspaceChangesRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Paths = { "", },
                Clean = false,
            };
            // Make the request
            gcdv::ResetWorkspaceChangesResponse response = dataformClient.ResetWorkspaceChanges(request);
            // End snippet
        }

        /// <summary>Snippet for ResetWorkspaceChangesAsync</summary>
        public async Task ResetWorkspaceChangesRequestObjectAsync()
        {
            // Snippet: ResetWorkspaceChangesAsync(ResetWorkspaceChangesRequest, CallSettings)
            // Additional: ResetWorkspaceChangesAsync(ResetWorkspaceChangesRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ResetWorkspaceChangesRequest request = new gcdv::ResetWorkspaceChangesRequest
            {
                WorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Paths = { "", },
                Clean = false,
            };
            // Make the request
            gcdv::ResetWorkspaceChangesResponse response = await dataformClient.ResetWorkspaceChangesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchFileDiff</summary>
        public void FetchFileDiffRequestObject()
        {
            // Snippet: FetchFileDiff(FetchFileDiffRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::FetchFileDiffRequest request = new gcdv::FetchFileDiffRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            gcdv::FetchFileDiffResponse response = dataformClient.FetchFileDiff(request);
            // End snippet
        }

        /// <summary>Snippet for FetchFileDiffAsync</summary>
        public async Task FetchFileDiffRequestObjectAsync()
        {
            // Snippet: FetchFileDiffAsync(FetchFileDiffRequest, CallSettings)
            // Additional: FetchFileDiffAsync(FetchFileDiffRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::FetchFileDiffRequest request = new gcdv::FetchFileDiffRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            gcdv::FetchFileDiffResponse response = await dataformClient.FetchFileDiffAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryDirectoryContents</summary>
        public void QueryDirectoryContentsRequestObject()
        {
            // Snippet: QueryDirectoryContents(QueryDirectoryContentsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::QueryDirectoryContentsRequest request = new gcdv::QueryDirectoryContentsRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            PagedEnumerable<gcdv::QueryDirectoryContentsResponse, gcdv::DirectoryEntry> response = dataformClient.QueryDirectoryContents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DirectoryEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::QueryDirectoryContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DirectoryEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DirectoryEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DirectoryEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryDirectoryContentsAsync</summary>
        public async Task QueryDirectoryContentsRequestObjectAsync()
        {
            // Snippet: QueryDirectoryContentsAsync(QueryDirectoryContentsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::QueryDirectoryContentsRequest request = new gcdv::QueryDirectoryContentsRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::QueryDirectoryContentsResponse, gcdv::DirectoryEntry> response = dataformClient.QueryDirectoryContentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::DirectoryEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::QueryDirectoryContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DirectoryEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DirectoryEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DirectoryEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFiles</summary>
        public void SearchFilesRequestObject()
        {
            // Snippet: SearchFiles(SearchFilesRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::SearchFilesRequest request = new gcdv::SearchFilesRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::SearchFilesResponse, gcdv::SearchResult> response = dataformClient.SearchFiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::SearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::SearchFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::SearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::SearchResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::SearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFilesAsync</summary>
        public async Task SearchFilesRequestObjectAsync()
        {
            // Snippet: SearchFilesAsync(SearchFilesRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::SearchFilesRequest request = new gcdv::SearchFilesRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::SearchFilesResponse, gcdv::SearchResult> response = dataformClient.SearchFilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::SearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::SearchFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::SearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::SearchResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::SearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for MakeDirectory</summary>
        public void MakeDirectoryRequestObject()
        {
            // Snippet: MakeDirectory(MakeDirectoryRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::MakeDirectoryRequest request = new gcdv::MakeDirectoryRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            gcdv::MakeDirectoryResponse response = dataformClient.MakeDirectory(request);
            // End snippet
        }

        /// <summary>Snippet for MakeDirectoryAsync</summary>
        public async Task MakeDirectoryRequestObjectAsync()
        {
            // Snippet: MakeDirectoryAsync(MakeDirectoryRequest, CallSettings)
            // Additional: MakeDirectoryAsync(MakeDirectoryRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::MakeDirectoryRequest request = new gcdv::MakeDirectoryRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            gcdv::MakeDirectoryResponse response = await dataformClient.MakeDirectoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveDirectory</summary>
        public void RemoveDirectoryRequestObject()
        {
            // Snippet: RemoveDirectory(RemoveDirectoryRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RemoveDirectoryRequest request = new gcdv::RemoveDirectoryRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            gcdv::RemoveDirectoryResponse response = dataformClient.RemoveDirectory(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveDirectoryAsync</summary>
        public async Task RemoveDirectoryRequestObjectAsync()
        {
            // Snippet: RemoveDirectoryAsync(RemoveDirectoryRequest, CallSettings)
            // Additional: RemoveDirectoryAsync(RemoveDirectoryRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RemoveDirectoryRequest request = new gcdv::RemoveDirectoryRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            gcdv::RemoveDirectoryResponse response = await dataformClient.RemoveDirectoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MoveDirectory</summary>
        public void MoveDirectoryRequestObject()
        {
            // Snippet: MoveDirectory(MoveDirectoryRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::MoveDirectoryRequest request = new gcdv::MoveDirectoryRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
                NewPath = "",
            };
            // Make the request
            gcdv::MoveDirectoryResponse response = dataformClient.MoveDirectory(request);
            // End snippet
        }

        /// <summary>Snippet for MoveDirectoryAsync</summary>
        public async Task MoveDirectoryRequestObjectAsync()
        {
            // Snippet: MoveDirectoryAsync(MoveDirectoryRequest, CallSettings)
            // Additional: MoveDirectoryAsync(MoveDirectoryRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::MoveDirectoryRequest request = new gcdv::MoveDirectoryRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
                NewPath = "",
            };
            // Make the request
            gcdv::MoveDirectoryResponse response = await dataformClient.MoveDirectoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReadFile</summary>
        public void ReadFileRequestObject()
        {
            // Snippet: ReadFile(ReadFileRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::ReadFileRequest request = new gcdv::ReadFileRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
                Revision = "",
            };
            // Make the request
            gcdv::ReadFileResponse response = dataformClient.ReadFile(request);
            // End snippet
        }

        /// <summary>Snippet for ReadFileAsync</summary>
        public async Task ReadFileRequestObjectAsync()
        {
            // Snippet: ReadFileAsync(ReadFileRequest, CallSettings)
            // Additional: ReadFileAsync(ReadFileRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ReadFileRequest request = new gcdv::ReadFileRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
                Revision = "",
            };
            // Make the request
            gcdv::ReadFileResponse response = await dataformClient.ReadFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveFile</summary>
        public void RemoveFileRequestObject()
        {
            // Snippet: RemoveFile(RemoveFileRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RemoveFileRequest request = new gcdv::RemoveFileRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            gcdv::RemoveFileResponse response = dataformClient.RemoveFile(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveFileAsync</summary>
        public async Task RemoveFileRequestObjectAsync()
        {
            // Snippet: RemoveFileAsync(RemoveFileRequest, CallSettings)
            // Additional: RemoveFileAsync(RemoveFileRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RemoveFileRequest request = new gcdv::RemoveFileRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            gcdv::RemoveFileResponse response = await dataformClient.RemoveFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MoveFile</summary>
        public void MoveFileRequestObject()
        {
            // Snippet: MoveFile(MoveFileRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::MoveFileRequest request = new gcdv::MoveFileRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
                NewPath = "",
            };
            // Make the request
            gcdv::MoveFileResponse response = dataformClient.MoveFile(request);
            // End snippet
        }

        /// <summary>Snippet for MoveFileAsync</summary>
        public async Task MoveFileRequestObjectAsync()
        {
            // Snippet: MoveFileAsync(MoveFileRequest, CallSettings)
            // Additional: MoveFileAsync(MoveFileRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::MoveFileRequest request = new gcdv::MoveFileRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
                NewPath = "",
            };
            // Make the request
            gcdv::MoveFileResponse response = await dataformClient.MoveFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for WriteFile</summary>
        public void WriteFileRequestObject()
        {
            // Snippet: WriteFile(WriteFileRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::WriteFileRequest request = new gcdv::WriteFileRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
                Contents = ByteString.Empty,
            };
            // Make the request
            gcdv::WriteFileResponse response = dataformClient.WriteFile(request);
            // End snippet
        }

        /// <summary>Snippet for WriteFileAsync</summary>
        public async Task WriteFileRequestObjectAsync()
        {
            // Snippet: WriteFileAsync(WriteFileRequest, CallSettings)
            // Additional: WriteFileAsync(WriteFileRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::WriteFileRequest request = new gcdv::WriteFileRequest
            {
                WorkspaceAsWorkspaceName = gcdv::WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
                Contents = ByteString.Empty,
            };
            // Make the request
            gcdv::WriteFileResponse response = await dataformClient.WriteFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListReleaseConfigs</summary>
        public void ListReleaseConfigsRequestObject()
        {
            // Snippet: ListReleaseConfigs(ListReleaseConfigsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::ListReleaseConfigsRequest request = new gcdv::ListReleaseConfigsRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<gcdv::ListReleaseConfigsResponse, gcdv::ReleaseConfig> response = dataformClient.ListReleaseConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::ReleaseConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListReleaseConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ReleaseConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ReleaseConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ReleaseConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleaseConfigsAsync</summary>
        public async Task ListReleaseConfigsRequestObjectAsync()
        {
            // Snippet: ListReleaseConfigsAsync(ListReleaseConfigsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListReleaseConfigsRequest request = new gcdv::ListReleaseConfigsRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListReleaseConfigsResponse, gcdv::ReleaseConfig> response = dataformClient.ListReleaseConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::ReleaseConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListReleaseConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ReleaseConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ReleaseConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ReleaseConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleaseConfigs</summary>
        public void ListReleaseConfigs()
        {
            // Snippet: ListReleaseConfigs(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<gcdv::ListReleaseConfigsResponse, gcdv::ReleaseConfig> response = dataformClient.ListReleaseConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::ReleaseConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListReleaseConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ReleaseConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ReleaseConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ReleaseConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleaseConfigsAsync</summary>
        public async Task ListReleaseConfigsAsync()
        {
            // Snippet: ListReleaseConfigsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListReleaseConfigsResponse, gcdv::ReleaseConfig> response = dataformClient.ListReleaseConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::ReleaseConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListReleaseConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ReleaseConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ReleaseConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ReleaseConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleaseConfigs</summary>
        public void ListReleaseConfigsResourceNames()
        {
            // Snippet: ListReleaseConfigs(RepositoryName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<gcdv::ListReleaseConfigsResponse, gcdv::ReleaseConfig> response = dataformClient.ListReleaseConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::ReleaseConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListReleaseConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ReleaseConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ReleaseConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ReleaseConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleaseConfigsAsync</summary>
        public async Task ListReleaseConfigsResourceNamesAsync()
        {
            // Snippet: ListReleaseConfigsAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListReleaseConfigsResponse, gcdv::ReleaseConfig> response = dataformClient.ListReleaseConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::ReleaseConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListReleaseConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ReleaseConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ReleaseConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ReleaseConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetReleaseConfig</summary>
        public void GetReleaseConfigRequestObject()
        {
            // Snippet: GetReleaseConfig(GetReleaseConfigRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::GetReleaseConfigRequest request = new gcdv::GetReleaseConfigRequest
            {
                ReleaseConfigName = gcdv::ReleaseConfigName.FromProjectLocationRepositoryReleaseConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[RELEASE_CONFIG]"),
            };
            // Make the request
            gcdv::ReleaseConfig response = dataformClient.GetReleaseConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetReleaseConfigAsync</summary>
        public async Task GetReleaseConfigRequestObjectAsync()
        {
            // Snippet: GetReleaseConfigAsync(GetReleaseConfigRequest, CallSettings)
            // Additional: GetReleaseConfigAsync(GetReleaseConfigRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetReleaseConfigRequest request = new gcdv::GetReleaseConfigRequest
            {
                ReleaseConfigName = gcdv::ReleaseConfigName.FromProjectLocationRepositoryReleaseConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[RELEASE_CONFIG]"),
            };
            // Make the request
            gcdv::ReleaseConfig response = await dataformClient.GetReleaseConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReleaseConfig</summary>
        public void GetReleaseConfig()
        {
            // Snippet: GetReleaseConfig(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/releaseConfigs/[RELEASE_CONFIG]";
            // Make the request
            gcdv::ReleaseConfig response = dataformClient.GetReleaseConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetReleaseConfigAsync</summary>
        public async Task GetReleaseConfigAsync()
        {
            // Snippet: GetReleaseConfigAsync(string, CallSettings)
            // Additional: GetReleaseConfigAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/releaseConfigs/[RELEASE_CONFIG]";
            // Make the request
            gcdv::ReleaseConfig response = await dataformClient.GetReleaseConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReleaseConfig</summary>
        public void GetReleaseConfigResourceNames()
        {
            // Snippet: GetReleaseConfig(ReleaseConfigName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::ReleaseConfigName name = gcdv::ReleaseConfigName.FromProjectLocationRepositoryReleaseConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[RELEASE_CONFIG]");
            // Make the request
            gcdv::ReleaseConfig response = dataformClient.GetReleaseConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetReleaseConfigAsync</summary>
        public async Task GetReleaseConfigResourceNamesAsync()
        {
            // Snippet: GetReleaseConfigAsync(ReleaseConfigName, CallSettings)
            // Additional: GetReleaseConfigAsync(ReleaseConfigName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ReleaseConfigName name = gcdv::ReleaseConfigName.FromProjectLocationRepositoryReleaseConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[RELEASE_CONFIG]");
            // Make the request
            gcdv::ReleaseConfig response = await dataformClient.GetReleaseConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseConfig</summary>
        public void CreateReleaseConfigRequestObject()
        {
            // Snippet: CreateReleaseConfig(CreateReleaseConfigRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::CreateReleaseConfigRequest request = new gcdv::CreateReleaseConfigRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                ReleaseConfig = new gcdv::ReleaseConfig(),
                ReleaseConfigId = "",
            };
            // Make the request
            gcdv::ReleaseConfig response = dataformClient.CreateReleaseConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseConfigAsync</summary>
        public async Task CreateReleaseConfigRequestObjectAsync()
        {
            // Snippet: CreateReleaseConfigAsync(CreateReleaseConfigRequest, CallSettings)
            // Additional: CreateReleaseConfigAsync(CreateReleaseConfigRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateReleaseConfigRequest request = new gcdv::CreateReleaseConfigRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                ReleaseConfig = new gcdv::ReleaseConfig(),
                ReleaseConfigId = "",
            };
            // Make the request
            gcdv::ReleaseConfig response = await dataformClient.CreateReleaseConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseConfig</summary>
        public void CreateReleaseConfig()
        {
            // Snippet: CreateReleaseConfig(string, ReleaseConfig, string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            gcdv::ReleaseConfig releaseConfig = new gcdv::ReleaseConfig();
            string releaseConfigId = "";
            // Make the request
            gcdv::ReleaseConfig response = dataformClient.CreateReleaseConfig(parent, releaseConfig, releaseConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseConfigAsync</summary>
        public async Task CreateReleaseConfigAsync()
        {
            // Snippet: CreateReleaseConfigAsync(string, ReleaseConfig, string, CallSettings)
            // Additional: CreateReleaseConfigAsync(string, ReleaseConfig, string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            gcdv::ReleaseConfig releaseConfig = new gcdv::ReleaseConfig();
            string releaseConfigId = "";
            // Make the request
            gcdv::ReleaseConfig response = await dataformClient.CreateReleaseConfigAsync(parent, releaseConfig, releaseConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseConfig</summary>
        public void CreateReleaseConfigResourceNames()
        {
            // Snippet: CreateReleaseConfig(RepositoryName, ReleaseConfig, string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            gcdv::ReleaseConfig releaseConfig = new gcdv::ReleaseConfig();
            string releaseConfigId = "";
            // Make the request
            gcdv::ReleaseConfig response = dataformClient.CreateReleaseConfig(parent, releaseConfig, releaseConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseConfigAsync</summary>
        public async Task CreateReleaseConfigResourceNamesAsync()
        {
            // Snippet: CreateReleaseConfigAsync(RepositoryName, ReleaseConfig, string, CallSettings)
            // Additional: CreateReleaseConfigAsync(RepositoryName, ReleaseConfig, string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            gcdv::ReleaseConfig releaseConfig = new gcdv::ReleaseConfig();
            string releaseConfigId = "";
            // Make the request
            gcdv::ReleaseConfig response = await dataformClient.CreateReleaseConfigAsync(parent, releaseConfig, releaseConfigId);
            // End snippet
        }

        /// <summary>Snippet for UpdateReleaseConfig</summary>
        public void UpdateReleaseConfigRequestObject()
        {
            // Snippet: UpdateReleaseConfig(UpdateReleaseConfigRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateReleaseConfigRequest request = new gcdv::UpdateReleaseConfigRequest
            {
                UpdateMask = new FieldMask(),
                ReleaseConfig = new gcdv::ReleaseConfig(),
            };
            // Make the request
            gcdv::ReleaseConfig response = dataformClient.UpdateReleaseConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateReleaseConfigAsync</summary>
        public async Task UpdateReleaseConfigRequestObjectAsync()
        {
            // Snippet: UpdateReleaseConfigAsync(UpdateReleaseConfigRequest, CallSettings)
            // Additional: UpdateReleaseConfigAsync(UpdateReleaseConfigRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateReleaseConfigRequest request = new gcdv::UpdateReleaseConfigRequest
            {
                UpdateMask = new FieldMask(),
                ReleaseConfig = new gcdv::ReleaseConfig(),
            };
            // Make the request
            gcdv::ReleaseConfig response = await dataformClient.UpdateReleaseConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateReleaseConfig</summary>
        public void UpdateReleaseConfig()
        {
            // Snippet: UpdateReleaseConfig(ReleaseConfig, FieldMask, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::ReleaseConfig releaseConfig = new gcdv::ReleaseConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::ReleaseConfig response = dataformClient.UpdateReleaseConfig(releaseConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateReleaseConfigAsync</summary>
        public async Task UpdateReleaseConfigAsync()
        {
            // Snippet: UpdateReleaseConfigAsync(ReleaseConfig, FieldMask, CallSettings)
            // Additional: UpdateReleaseConfigAsync(ReleaseConfig, FieldMask, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ReleaseConfig releaseConfig = new gcdv::ReleaseConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::ReleaseConfig response = await dataformClient.UpdateReleaseConfigAsync(releaseConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteReleaseConfig</summary>
        public void DeleteReleaseConfigRequestObject()
        {
            // Snippet: DeleteReleaseConfig(DeleteReleaseConfigRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteReleaseConfigRequest request = new gcdv::DeleteReleaseConfigRequest
            {
                ReleaseConfigName = gcdv::ReleaseConfigName.FromProjectLocationRepositoryReleaseConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[RELEASE_CONFIG]"),
            };
            // Make the request
            dataformClient.DeleteReleaseConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReleaseConfigAsync</summary>
        public async Task DeleteReleaseConfigRequestObjectAsync()
        {
            // Snippet: DeleteReleaseConfigAsync(DeleteReleaseConfigRequest, CallSettings)
            // Additional: DeleteReleaseConfigAsync(DeleteReleaseConfigRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteReleaseConfigRequest request = new gcdv::DeleteReleaseConfigRequest
            {
                ReleaseConfigName = gcdv::ReleaseConfigName.FromProjectLocationRepositoryReleaseConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[RELEASE_CONFIG]"),
            };
            // Make the request
            await dataformClient.DeleteReleaseConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReleaseConfig</summary>
        public void DeleteReleaseConfig()
        {
            // Snippet: DeleteReleaseConfig(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/releaseConfigs/[RELEASE_CONFIG]";
            // Make the request
            dataformClient.DeleteReleaseConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReleaseConfigAsync</summary>
        public async Task DeleteReleaseConfigAsync()
        {
            // Snippet: DeleteReleaseConfigAsync(string, CallSettings)
            // Additional: DeleteReleaseConfigAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/releaseConfigs/[RELEASE_CONFIG]";
            // Make the request
            await dataformClient.DeleteReleaseConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReleaseConfig</summary>
        public void DeleteReleaseConfigResourceNames()
        {
            // Snippet: DeleteReleaseConfig(ReleaseConfigName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::ReleaseConfigName name = gcdv::ReleaseConfigName.FromProjectLocationRepositoryReleaseConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[RELEASE_CONFIG]");
            // Make the request
            dataformClient.DeleteReleaseConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReleaseConfigAsync</summary>
        public async Task DeleteReleaseConfigResourceNamesAsync()
        {
            // Snippet: DeleteReleaseConfigAsync(ReleaseConfigName, CallSettings)
            // Additional: DeleteReleaseConfigAsync(ReleaseConfigName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ReleaseConfigName name = gcdv::ReleaseConfigName.FromProjectLocationRepositoryReleaseConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[RELEASE_CONFIG]");
            // Make the request
            await dataformClient.DeleteReleaseConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCompilationResults</summary>
        public void ListCompilationResultsRequestObject()
        {
            // Snippet: ListCompilationResults(ListCompilationResultsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::ListCompilationResultsRequest request = new gcdv::ListCompilationResultsRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListCompilationResultsResponse, gcdv::CompilationResult> response = dataformClient.ListCompilationResults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::CompilationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListCompilationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::CompilationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::CompilationResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::CompilationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompilationResultsAsync</summary>
        public async Task ListCompilationResultsRequestObjectAsync()
        {
            // Snippet: ListCompilationResultsAsync(ListCompilationResultsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListCompilationResultsRequest request = new gcdv::ListCompilationResultsRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListCompilationResultsResponse, gcdv::CompilationResult> response = dataformClient.ListCompilationResultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::CompilationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListCompilationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::CompilationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::CompilationResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::CompilationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompilationResults</summary>
        public void ListCompilationResults()
        {
            // Snippet: ListCompilationResults(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<gcdv::ListCompilationResultsResponse, gcdv::CompilationResult> response = dataformClient.ListCompilationResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::CompilationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListCompilationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::CompilationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::CompilationResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::CompilationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompilationResultsAsync</summary>
        public async Task ListCompilationResultsAsync()
        {
            // Snippet: ListCompilationResultsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListCompilationResultsResponse, gcdv::CompilationResult> response = dataformClient.ListCompilationResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::CompilationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListCompilationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::CompilationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::CompilationResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::CompilationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompilationResults</summary>
        public void ListCompilationResultsResourceNames()
        {
            // Snippet: ListCompilationResults(RepositoryName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<gcdv::ListCompilationResultsResponse, gcdv::CompilationResult> response = dataformClient.ListCompilationResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::CompilationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListCompilationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::CompilationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::CompilationResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::CompilationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompilationResultsAsync</summary>
        public async Task ListCompilationResultsResourceNamesAsync()
        {
            // Snippet: ListCompilationResultsAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListCompilationResultsResponse, gcdv::CompilationResult> response = dataformClient.ListCompilationResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::CompilationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListCompilationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::CompilationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::CompilationResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::CompilationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCompilationResult</summary>
        public void GetCompilationResultRequestObject()
        {
            // Snippet: GetCompilationResult(GetCompilationResultRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::GetCompilationResultRequest request = new gcdv::GetCompilationResultRequest
            {
                CompilationResultName = gcdv::CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
            };
            // Make the request
            gcdv::CompilationResult response = dataformClient.GetCompilationResult(request);
            // End snippet
        }

        /// <summary>Snippet for GetCompilationResultAsync</summary>
        public async Task GetCompilationResultRequestObjectAsync()
        {
            // Snippet: GetCompilationResultAsync(GetCompilationResultRequest, CallSettings)
            // Additional: GetCompilationResultAsync(GetCompilationResultRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetCompilationResultRequest request = new gcdv::GetCompilationResultRequest
            {
                CompilationResultName = gcdv::CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
            };
            // Make the request
            gcdv::CompilationResult response = await dataformClient.GetCompilationResultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCompilationResult</summary>
        public void GetCompilationResult()
        {
            // Snippet: GetCompilationResult(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/compilationResults/[COMPILATION_RESULT]";
            // Make the request
            gcdv::CompilationResult response = dataformClient.GetCompilationResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetCompilationResultAsync</summary>
        public async Task GetCompilationResultAsync()
        {
            // Snippet: GetCompilationResultAsync(string, CallSettings)
            // Additional: GetCompilationResultAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/compilationResults/[COMPILATION_RESULT]";
            // Make the request
            gcdv::CompilationResult response = await dataformClient.GetCompilationResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCompilationResult</summary>
        public void GetCompilationResultResourceNames()
        {
            // Snippet: GetCompilationResult(CompilationResultName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::CompilationResultName name = gcdv::CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]");
            // Make the request
            gcdv::CompilationResult response = dataformClient.GetCompilationResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetCompilationResultAsync</summary>
        public async Task GetCompilationResultResourceNamesAsync()
        {
            // Snippet: GetCompilationResultAsync(CompilationResultName, CallSettings)
            // Additional: GetCompilationResultAsync(CompilationResultName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CompilationResultName name = gcdv::CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]");
            // Make the request
            gcdv::CompilationResult response = await dataformClient.GetCompilationResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCompilationResult</summary>
        public void CreateCompilationResultRequestObject()
        {
            // Snippet: CreateCompilationResult(CreateCompilationResultRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::CreateCompilationResultRequest request = new gcdv::CreateCompilationResultRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CompilationResult = new gcdv::CompilationResult(),
            };
            // Make the request
            gcdv::CompilationResult response = dataformClient.CreateCompilationResult(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCompilationResultAsync</summary>
        public async Task CreateCompilationResultRequestObjectAsync()
        {
            // Snippet: CreateCompilationResultAsync(CreateCompilationResultRequest, CallSettings)
            // Additional: CreateCompilationResultAsync(CreateCompilationResultRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateCompilationResultRequest request = new gcdv::CreateCompilationResultRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CompilationResult = new gcdv::CompilationResult(),
            };
            // Make the request
            gcdv::CompilationResult response = await dataformClient.CreateCompilationResultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCompilationResult</summary>
        public void CreateCompilationResult()
        {
            // Snippet: CreateCompilationResult(string, CompilationResult, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            gcdv::CompilationResult compilationResult = new gcdv::CompilationResult();
            // Make the request
            gcdv::CompilationResult response = dataformClient.CreateCompilationResult(parent, compilationResult);
            // End snippet
        }

        /// <summary>Snippet for CreateCompilationResultAsync</summary>
        public async Task CreateCompilationResultAsync()
        {
            // Snippet: CreateCompilationResultAsync(string, CompilationResult, CallSettings)
            // Additional: CreateCompilationResultAsync(string, CompilationResult, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            gcdv::CompilationResult compilationResult = new gcdv::CompilationResult();
            // Make the request
            gcdv::CompilationResult response = await dataformClient.CreateCompilationResultAsync(parent, compilationResult);
            // End snippet
        }

        /// <summary>Snippet for CreateCompilationResult</summary>
        public void CreateCompilationResultResourceNames()
        {
            // Snippet: CreateCompilationResult(RepositoryName, CompilationResult, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            gcdv::CompilationResult compilationResult = new gcdv::CompilationResult();
            // Make the request
            gcdv::CompilationResult response = dataformClient.CreateCompilationResult(parent, compilationResult);
            // End snippet
        }

        /// <summary>Snippet for CreateCompilationResultAsync</summary>
        public async Task CreateCompilationResultResourceNamesAsync()
        {
            // Snippet: CreateCompilationResultAsync(RepositoryName, CompilationResult, CallSettings)
            // Additional: CreateCompilationResultAsync(RepositoryName, CompilationResult, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            gcdv::CompilationResult compilationResult = new gcdv::CompilationResult();
            // Make the request
            gcdv::CompilationResult response = await dataformClient.CreateCompilationResultAsync(parent, compilationResult);
            // End snippet
        }

        /// <summary>Snippet for QueryCompilationResultActions</summary>
        public void QueryCompilationResultActionsRequestObject()
        {
            // Snippet: QueryCompilationResultActions(QueryCompilationResultActionsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::QueryCompilationResultActionsRequest request = new gcdv::QueryCompilationResultActionsRequest
            {
                CompilationResultName = gcdv::CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::QueryCompilationResultActionsResponse, gcdv::CompilationResultAction> response = dataformClient.QueryCompilationResultActions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::CompilationResultAction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::QueryCompilationResultActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::CompilationResultAction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::CompilationResultAction> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::CompilationResultAction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryCompilationResultActionsAsync</summary>
        public async Task QueryCompilationResultActionsRequestObjectAsync()
        {
            // Snippet: QueryCompilationResultActionsAsync(QueryCompilationResultActionsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::QueryCompilationResultActionsRequest request = new gcdv::QueryCompilationResultActionsRequest
            {
                CompilationResultName = gcdv::CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::QueryCompilationResultActionsResponse, gcdv::CompilationResultAction> response = dataformClient.QueryCompilationResultActionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::CompilationResultAction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::QueryCompilationResultActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::CompilationResultAction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::CompilationResultAction> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::CompilationResultAction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowConfigs</summary>
        public void ListWorkflowConfigsRequestObject()
        {
            // Snippet: ListWorkflowConfigs(ListWorkflowConfigsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::ListWorkflowConfigsRequest request = new gcdv::ListWorkflowConfigsRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<gcdv::ListWorkflowConfigsResponse, gcdv::WorkflowConfig> response = dataformClient.ListWorkflowConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::WorkflowConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListWorkflowConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::WorkflowConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::WorkflowConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::WorkflowConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowConfigsAsync</summary>
        public async Task ListWorkflowConfigsRequestObjectAsync()
        {
            // Snippet: ListWorkflowConfigsAsync(ListWorkflowConfigsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListWorkflowConfigsRequest request = new gcdv::ListWorkflowConfigsRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListWorkflowConfigsResponse, gcdv::WorkflowConfig> response = dataformClient.ListWorkflowConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::WorkflowConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListWorkflowConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::WorkflowConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::WorkflowConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::WorkflowConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowConfigs</summary>
        public void ListWorkflowConfigs()
        {
            // Snippet: ListWorkflowConfigs(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<gcdv::ListWorkflowConfigsResponse, gcdv::WorkflowConfig> response = dataformClient.ListWorkflowConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::WorkflowConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListWorkflowConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::WorkflowConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::WorkflowConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::WorkflowConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowConfigsAsync</summary>
        public async Task ListWorkflowConfigsAsync()
        {
            // Snippet: ListWorkflowConfigsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListWorkflowConfigsResponse, gcdv::WorkflowConfig> response = dataformClient.ListWorkflowConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::WorkflowConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListWorkflowConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::WorkflowConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::WorkflowConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::WorkflowConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowConfigs</summary>
        public void ListWorkflowConfigsResourceNames()
        {
            // Snippet: ListWorkflowConfigs(RepositoryName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<gcdv::ListWorkflowConfigsResponse, gcdv::WorkflowConfig> response = dataformClient.ListWorkflowConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::WorkflowConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListWorkflowConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::WorkflowConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::WorkflowConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::WorkflowConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowConfigsAsync</summary>
        public async Task ListWorkflowConfigsResourceNamesAsync()
        {
            // Snippet: ListWorkflowConfigsAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListWorkflowConfigsResponse, gcdv::WorkflowConfig> response = dataformClient.ListWorkflowConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::WorkflowConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListWorkflowConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::WorkflowConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::WorkflowConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::WorkflowConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowConfig</summary>
        public void GetWorkflowConfigRequestObject()
        {
            // Snippet: GetWorkflowConfig(GetWorkflowConfigRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::GetWorkflowConfigRequest request = new gcdv::GetWorkflowConfigRequest
            {
                WorkflowConfigName = gcdv::WorkflowConfigName.FromProjectLocationRepositoryWorkflowConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_CONFIG]"),
            };
            // Make the request
            gcdv::WorkflowConfig response = dataformClient.GetWorkflowConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowConfigAsync</summary>
        public async Task GetWorkflowConfigRequestObjectAsync()
        {
            // Snippet: GetWorkflowConfigAsync(GetWorkflowConfigRequest, CallSettings)
            // Additional: GetWorkflowConfigAsync(GetWorkflowConfigRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetWorkflowConfigRequest request = new gcdv::GetWorkflowConfigRequest
            {
                WorkflowConfigName = gcdv::WorkflowConfigName.FromProjectLocationRepositoryWorkflowConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_CONFIG]"),
            };
            // Make the request
            gcdv::WorkflowConfig response = await dataformClient.GetWorkflowConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowConfig</summary>
        public void GetWorkflowConfig()
        {
            // Snippet: GetWorkflowConfig(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workflowConfigs/[WORKFLOW_CONFIG]";
            // Make the request
            gcdv::WorkflowConfig response = dataformClient.GetWorkflowConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowConfigAsync</summary>
        public async Task GetWorkflowConfigAsync()
        {
            // Snippet: GetWorkflowConfigAsync(string, CallSettings)
            // Additional: GetWorkflowConfigAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workflowConfigs/[WORKFLOW_CONFIG]";
            // Make the request
            gcdv::WorkflowConfig response = await dataformClient.GetWorkflowConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowConfig</summary>
        public void GetWorkflowConfigResourceNames()
        {
            // Snippet: GetWorkflowConfig(WorkflowConfigName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::WorkflowConfigName name = gcdv::WorkflowConfigName.FromProjectLocationRepositoryWorkflowConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_CONFIG]");
            // Make the request
            gcdv::WorkflowConfig response = dataformClient.GetWorkflowConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowConfigAsync</summary>
        public async Task GetWorkflowConfigResourceNamesAsync()
        {
            // Snippet: GetWorkflowConfigAsync(WorkflowConfigName, CallSettings)
            // Additional: GetWorkflowConfigAsync(WorkflowConfigName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::WorkflowConfigName name = gcdv::WorkflowConfigName.FromProjectLocationRepositoryWorkflowConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_CONFIG]");
            // Make the request
            gcdv::WorkflowConfig response = await dataformClient.GetWorkflowConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowConfig</summary>
        public void CreateWorkflowConfigRequestObject()
        {
            // Snippet: CreateWorkflowConfig(CreateWorkflowConfigRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::CreateWorkflowConfigRequest request = new gcdv::CreateWorkflowConfigRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                WorkflowConfig = new gcdv::WorkflowConfig(),
                WorkflowConfigId = "",
            };
            // Make the request
            gcdv::WorkflowConfig response = dataformClient.CreateWorkflowConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowConfigAsync</summary>
        public async Task CreateWorkflowConfigRequestObjectAsync()
        {
            // Snippet: CreateWorkflowConfigAsync(CreateWorkflowConfigRequest, CallSettings)
            // Additional: CreateWorkflowConfigAsync(CreateWorkflowConfigRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateWorkflowConfigRequest request = new gcdv::CreateWorkflowConfigRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                WorkflowConfig = new gcdv::WorkflowConfig(),
                WorkflowConfigId = "",
            };
            // Make the request
            gcdv::WorkflowConfig response = await dataformClient.CreateWorkflowConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowConfig</summary>
        public void CreateWorkflowConfig()
        {
            // Snippet: CreateWorkflowConfig(string, WorkflowConfig, string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            gcdv::WorkflowConfig workflowConfig = new gcdv::WorkflowConfig();
            string workflowConfigId = "";
            // Make the request
            gcdv::WorkflowConfig response = dataformClient.CreateWorkflowConfig(parent, workflowConfig, workflowConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowConfigAsync</summary>
        public async Task CreateWorkflowConfigAsync()
        {
            // Snippet: CreateWorkflowConfigAsync(string, WorkflowConfig, string, CallSettings)
            // Additional: CreateWorkflowConfigAsync(string, WorkflowConfig, string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            gcdv::WorkflowConfig workflowConfig = new gcdv::WorkflowConfig();
            string workflowConfigId = "";
            // Make the request
            gcdv::WorkflowConfig response = await dataformClient.CreateWorkflowConfigAsync(parent, workflowConfig, workflowConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowConfig</summary>
        public void CreateWorkflowConfigResourceNames()
        {
            // Snippet: CreateWorkflowConfig(RepositoryName, WorkflowConfig, string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            gcdv::WorkflowConfig workflowConfig = new gcdv::WorkflowConfig();
            string workflowConfigId = "";
            // Make the request
            gcdv::WorkflowConfig response = dataformClient.CreateWorkflowConfig(parent, workflowConfig, workflowConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowConfigAsync</summary>
        public async Task CreateWorkflowConfigResourceNamesAsync()
        {
            // Snippet: CreateWorkflowConfigAsync(RepositoryName, WorkflowConfig, string, CallSettings)
            // Additional: CreateWorkflowConfigAsync(RepositoryName, WorkflowConfig, string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            gcdv::WorkflowConfig workflowConfig = new gcdv::WorkflowConfig();
            string workflowConfigId = "";
            // Make the request
            gcdv::WorkflowConfig response = await dataformClient.CreateWorkflowConfigAsync(parent, workflowConfig, workflowConfigId);
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkflowConfig</summary>
        public void UpdateWorkflowConfigRequestObject()
        {
            // Snippet: UpdateWorkflowConfig(UpdateWorkflowConfigRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateWorkflowConfigRequest request = new gcdv::UpdateWorkflowConfigRequest
            {
                UpdateMask = new FieldMask(),
                WorkflowConfig = new gcdv::WorkflowConfig(),
            };
            // Make the request
            gcdv::WorkflowConfig response = dataformClient.UpdateWorkflowConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkflowConfigAsync</summary>
        public async Task UpdateWorkflowConfigRequestObjectAsync()
        {
            // Snippet: UpdateWorkflowConfigAsync(UpdateWorkflowConfigRequest, CallSettings)
            // Additional: UpdateWorkflowConfigAsync(UpdateWorkflowConfigRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateWorkflowConfigRequest request = new gcdv::UpdateWorkflowConfigRequest
            {
                UpdateMask = new FieldMask(),
                WorkflowConfig = new gcdv::WorkflowConfig(),
            };
            // Make the request
            gcdv::WorkflowConfig response = await dataformClient.UpdateWorkflowConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkflowConfig</summary>
        public void UpdateWorkflowConfig()
        {
            // Snippet: UpdateWorkflowConfig(WorkflowConfig, FieldMask, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::WorkflowConfig workflowConfig = new gcdv::WorkflowConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::WorkflowConfig response = dataformClient.UpdateWorkflowConfig(workflowConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkflowConfigAsync</summary>
        public async Task UpdateWorkflowConfigAsync()
        {
            // Snippet: UpdateWorkflowConfigAsync(WorkflowConfig, FieldMask, CallSettings)
            // Additional: UpdateWorkflowConfigAsync(WorkflowConfig, FieldMask, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::WorkflowConfig workflowConfig = new gcdv::WorkflowConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::WorkflowConfig response = await dataformClient.UpdateWorkflowConfigAsync(workflowConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowConfig</summary>
        public void DeleteWorkflowConfigRequestObject()
        {
            // Snippet: DeleteWorkflowConfig(DeleteWorkflowConfigRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteWorkflowConfigRequest request = new gcdv::DeleteWorkflowConfigRequest
            {
                WorkflowConfigName = gcdv::WorkflowConfigName.FromProjectLocationRepositoryWorkflowConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_CONFIG]"),
            };
            // Make the request
            dataformClient.DeleteWorkflowConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowConfigAsync</summary>
        public async Task DeleteWorkflowConfigRequestObjectAsync()
        {
            // Snippet: DeleteWorkflowConfigAsync(DeleteWorkflowConfigRequest, CallSettings)
            // Additional: DeleteWorkflowConfigAsync(DeleteWorkflowConfigRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteWorkflowConfigRequest request = new gcdv::DeleteWorkflowConfigRequest
            {
                WorkflowConfigName = gcdv::WorkflowConfigName.FromProjectLocationRepositoryWorkflowConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_CONFIG]"),
            };
            // Make the request
            await dataformClient.DeleteWorkflowConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowConfig</summary>
        public void DeleteWorkflowConfig()
        {
            // Snippet: DeleteWorkflowConfig(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workflowConfigs/[WORKFLOW_CONFIG]";
            // Make the request
            dataformClient.DeleteWorkflowConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowConfigAsync</summary>
        public async Task DeleteWorkflowConfigAsync()
        {
            // Snippet: DeleteWorkflowConfigAsync(string, CallSettings)
            // Additional: DeleteWorkflowConfigAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workflowConfigs/[WORKFLOW_CONFIG]";
            // Make the request
            await dataformClient.DeleteWorkflowConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowConfig</summary>
        public void DeleteWorkflowConfigResourceNames()
        {
            // Snippet: DeleteWorkflowConfig(WorkflowConfigName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::WorkflowConfigName name = gcdv::WorkflowConfigName.FromProjectLocationRepositoryWorkflowConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_CONFIG]");
            // Make the request
            dataformClient.DeleteWorkflowConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowConfigAsync</summary>
        public async Task DeleteWorkflowConfigResourceNamesAsync()
        {
            // Snippet: DeleteWorkflowConfigAsync(WorkflowConfigName, CallSettings)
            // Additional: DeleteWorkflowConfigAsync(WorkflowConfigName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::WorkflowConfigName name = gcdv::WorkflowConfigName.FromProjectLocationRepositoryWorkflowConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_CONFIG]");
            // Make the request
            await dataformClient.DeleteWorkflowConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowInvocations</summary>
        public void ListWorkflowInvocationsRequestObject()
        {
            // Snippet: ListWorkflowInvocations(ListWorkflowInvocationsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::ListWorkflowInvocationsRequest request = new gcdv::ListWorkflowInvocationsRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListWorkflowInvocationsResponse, gcdv::WorkflowInvocation> response = dataformClient.ListWorkflowInvocations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::WorkflowInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListWorkflowInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::WorkflowInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::WorkflowInvocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::WorkflowInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowInvocationsAsync</summary>
        public async Task ListWorkflowInvocationsRequestObjectAsync()
        {
            // Snippet: ListWorkflowInvocationsAsync(ListWorkflowInvocationsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListWorkflowInvocationsRequest request = new gcdv::ListWorkflowInvocationsRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListWorkflowInvocationsResponse, gcdv::WorkflowInvocation> response = dataformClient.ListWorkflowInvocationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::WorkflowInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListWorkflowInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::WorkflowInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::WorkflowInvocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::WorkflowInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowInvocations</summary>
        public void ListWorkflowInvocations()
        {
            // Snippet: ListWorkflowInvocations(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<gcdv::ListWorkflowInvocationsResponse, gcdv::WorkflowInvocation> response = dataformClient.ListWorkflowInvocations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::WorkflowInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListWorkflowInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::WorkflowInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::WorkflowInvocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::WorkflowInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowInvocationsAsync</summary>
        public async Task ListWorkflowInvocationsAsync()
        {
            // Snippet: ListWorkflowInvocationsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListWorkflowInvocationsResponse, gcdv::WorkflowInvocation> response = dataformClient.ListWorkflowInvocationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::WorkflowInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListWorkflowInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::WorkflowInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::WorkflowInvocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::WorkflowInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowInvocations</summary>
        public void ListWorkflowInvocationsResourceNames()
        {
            // Snippet: ListWorkflowInvocations(RepositoryName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<gcdv::ListWorkflowInvocationsResponse, gcdv::WorkflowInvocation> response = dataformClient.ListWorkflowInvocations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::WorkflowInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListWorkflowInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::WorkflowInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::WorkflowInvocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::WorkflowInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowInvocationsAsync</summary>
        public async Task ListWorkflowInvocationsResourceNamesAsync()
        {
            // Snippet: ListWorkflowInvocationsAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListWorkflowInvocationsResponse, gcdv::WorkflowInvocation> response = dataformClient.ListWorkflowInvocationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::WorkflowInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListWorkflowInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::WorkflowInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::WorkflowInvocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::WorkflowInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowInvocation</summary>
        public void GetWorkflowInvocationRequestObject()
        {
            // Snippet: GetWorkflowInvocation(GetWorkflowInvocationRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::GetWorkflowInvocationRequest request = new gcdv::GetWorkflowInvocationRequest
            {
                WorkflowInvocationName = gcdv::WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            gcdv::WorkflowInvocation response = dataformClient.GetWorkflowInvocation(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowInvocationAsync</summary>
        public async Task GetWorkflowInvocationRequestObjectAsync()
        {
            // Snippet: GetWorkflowInvocationAsync(GetWorkflowInvocationRequest, CallSettings)
            // Additional: GetWorkflowInvocationAsync(GetWorkflowInvocationRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetWorkflowInvocationRequest request = new gcdv::GetWorkflowInvocationRequest
            {
                WorkflowInvocationName = gcdv::WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            gcdv::WorkflowInvocation response = await dataformClient.GetWorkflowInvocationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowInvocation</summary>
        public void GetWorkflowInvocation()
        {
            // Snippet: GetWorkflowInvocation(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workflowInvocations/[WORKFLOW_INVOCATION]";
            // Make the request
            gcdv::WorkflowInvocation response = dataformClient.GetWorkflowInvocation(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowInvocationAsync</summary>
        public async Task GetWorkflowInvocationAsync()
        {
            // Snippet: GetWorkflowInvocationAsync(string, CallSettings)
            // Additional: GetWorkflowInvocationAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workflowInvocations/[WORKFLOW_INVOCATION]";
            // Make the request
            gcdv::WorkflowInvocation response = await dataformClient.GetWorkflowInvocationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowInvocation</summary>
        public void GetWorkflowInvocationResourceNames()
        {
            // Snippet: GetWorkflowInvocation(WorkflowInvocationName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::WorkflowInvocationName name = gcdv::WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]");
            // Make the request
            gcdv::WorkflowInvocation response = dataformClient.GetWorkflowInvocation(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowInvocationAsync</summary>
        public async Task GetWorkflowInvocationResourceNamesAsync()
        {
            // Snippet: GetWorkflowInvocationAsync(WorkflowInvocationName, CallSettings)
            // Additional: GetWorkflowInvocationAsync(WorkflowInvocationName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::WorkflowInvocationName name = gcdv::WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]");
            // Make the request
            gcdv::WorkflowInvocation response = await dataformClient.GetWorkflowInvocationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowInvocation</summary>
        public void CreateWorkflowInvocationRequestObject()
        {
            // Snippet: CreateWorkflowInvocation(CreateWorkflowInvocationRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::CreateWorkflowInvocationRequest request = new gcdv::CreateWorkflowInvocationRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                WorkflowInvocation = new gcdv::WorkflowInvocation(),
            };
            // Make the request
            gcdv::WorkflowInvocation response = dataformClient.CreateWorkflowInvocation(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowInvocationAsync</summary>
        public async Task CreateWorkflowInvocationRequestObjectAsync()
        {
            // Snippet: CreateWorkflowInvocationAsync(CreateWorkflowInvocationRequest, CallSettings)
            // Additional: CreateWorkflowInvocationAsync(CreateWorkflowInvocationRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateWorkflowInvocationRequest request = new gcdv::CreateWorkflowInvocationRequest
            {
                ParentAsRepositoryName = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                WorkflowInvocation = new gcdv::WorkflowInvocation(),
            };
            // Make the request
            gcdv::WorkflowInvocation response = await dataformClient.CreateWorkflowInvocationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowInvocation</summary>
        public void CreateWorkflowInvocation()
        {
            // Snippet: CreateWorkflowInvocation(string, WorkflowInvocation, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            gcdv::WorkflowInvocation workflowInvocation = new gcdv::WorkflowInvocation();
            // Make the request
            gcdv::WorkflowInvocation response = dataformClient.CreateWorkflowInvocation(parent, workflowInvocation);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowInvocationAsync</summary>
        public async Task CreateWorkflowInvocationAsync()
        {
            // Snippet: CreateWorkflowInvocationAsync(string, WorkflowInvocation, CallSettings)
            // Additional: CreateWorkflowInvocationAsync(string, WorkflowInvocation, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            gcdv::WorkflowInvocation workflowInvocation = new gcdv::WorkflowInvocation();
            // Make the request
            gcdv::WorkflowInvocation response = await dataformClient.CreateWorkflowInvocationAsync(parent, workflowInvocation);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowInvocation</summary>
        public void CreateWorkflowInvocationResourceNames()
        {
            // Snippet: CreateWorkflowInvocation(RepositoryName, WorkflowInvocation, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            gcdv::WorkflowInvocation workflowInvocation = new gcdv::WorkflowInvocation();
            // Make the request
            gcdv::WorkflowInvocation response = dataformClient.CreateWorkflowInvocation(parent, workflowInvocation);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowInvocationAsync</summary>
        public async Task CreateWorkflowInvocationResourceNamesAsync()
        {
            // Snippet: CreateWorkflowInvocationAsync(RepositoryName, WorkflowInvocation, CallSettings)
            // Additional: CreateWorkflowInvocationAsync(RepositoryName, WorkflowInvocation, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RepositoryName parent = gcdv::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            gcdv::WorkflowInvocation workflowInvocation = new gcdv::WorkflowInvocation();
            // Make the request
            gcdv::WorkflowInvocation response = await dataformClient.CreateWorkflowInvocationAsync(parent, workflowInvocation);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowInvocation</summary>
        public void DeleteWorkflowInvocationRequestObject()
        {
            // Snippet: DeleteWorkflowInvocation(DeleteWorkflowInvocationRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteWorkflowInvocationRequest request = new gcdv::DeleteWorkflowInvocationRequest
            {
                WorkflowInvocationName = gcdv::WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            dataformClient.DeleteWorkflowInvocation(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowInvocationAsync</summary>
        public async Task DeleteWorkflowInvocationRequestObjectAsync()
        {
            // Snippet: DeleteWorkflowInvocationAsync(DeleteWorkflowInvocationRequest, CallSettings)
            // Additional: DeleteWorkflowInvocationAsync(DeleteWorkflowInvocationRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteWorkflowInvocationRequest request = new gcdv::DeleteWorkflowInvocationRequest
            {
                WorkflowInvocationName = gcdv::WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            await dataformClient.DeleteWorkflowInvocationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowInvocation</summary>
        public void DeleteWorkflowInvocation()
        {
            // Snippet: DeleteWorkflowInvocation(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workflowInvocations/[WORKFLOW_INVOCATION]";
            // Make the request
            dataformClient.DeleteWorkflowInvocation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowInvocationAsync</summary>
        public async Task DeleteWorkflowInvocationAsync()
        {
            // Snippet: DeleteWorkflowInvocationAsync(string, CallSettings)
            // Additional: DeleteWorkflowInvocationAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workflowInvocations/[WORKFLOW_INVOCATION]";
            // Make the request
            await dataformClient.DeleteWorkflowInvocationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowInvocation</summary>
        public void DeleteWorkflowInvocationResourceNames()
        {
            // Snippet: DeleteWorkflowInvocation(WorkflowInvocationName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::WorkflowInvocationName name = gcdv::WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]");
            // Make the request
            dataformClient.DeleteWorkflowInvocation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowInvocationAsync</summary>
        public async Task DeleteWorkflowInvocationResourceNamesAsync()
        {
            // Snippet: DeleteWorkflowInvocationAsync(WorkflowInvocationName, CallSettings)
            // Additional: DeleteWorkflowInvocationAsync(WorkflowInvocationName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::WorkflowInvocationName name = gcdv::WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]");
            // Make the request
            await dataformClient.DeleteWorkflowInvocationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelWorkflowInvocation</summary>
        public void CancelWorkflowInvocationRequestObject()
        {
            // Snippet: CancelWorkflowInvocation(CancelWorkflowInvocationRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::CancelWorkflowInvocationRequest request = new gcdv::CancelWorkflowInvocationRequest
            {
                WorkflowInvocationName = gcdv::WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            gcdv::CancelWorkflowInvocationResponse response = dataformClient.CancelWorkflowInvocation(request);
            // End snippet
        }

        /// <summary>Snippet for CancelWorkflowInvocationAsync</summary>
        public async Task CancelWorkflowInvocationRequestObjectAsync()
        {
            // Snippet: CancelWorkflowInvocationAsync(CancelWorkflowInvocationRequest, CallSettings)
            // Additional: CancelWorkflowInvocationAsync(CancelWorkflowInvocationRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CancelWorkflowInvocationRequest request = new gcdv::CancelWorkflowInvocationRequest
            {
                WorkflowInvocationName = gcdv::WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            gcdv::CancelWorkflowInvocationResponse response = await dataformClient.CancelWorkflowInvocationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryWorkflowInvocationActions</summary>
        public void QueryWorkflowInvocationActionsRequestObject()
        {
            // Snippet: QueryWorkflowInvocationActions(QueryWorkflowInvocationActionsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::QueryWorkflowInvocationActionsRequest request = new gcdv::QueryWorkflowInvocationActionsRequest
            {
                WorkflowInvocationName = gcdv::WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            PagedEnumerable<gcdv::QueryWorkflowInvocationActionsResponse, gcdv::WorkflowInvocationAction> response = dataformClient.QueryWorkflowInvocationActions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::WorkflowInvocationAction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::QueryWorkflowInvocationActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::WorkflowInvocationAction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::WorkflowInvocationAction> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::WorkflowInvocationAction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryWorkflowInvocationActionsAsync</summary>
        public async Task QueryWorkflowInvocationActionsRequestObjectAsync()
        {
            // Snippet: QueryWorkflowInvocationActionsAsync(QueryWorkflowInvocationActionsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::QueryWorkflowInvocationActionsRequest request = new gcdv::QueryWorkflowInvocationActionsRequest
            {
                WorkflowInvocationName = gcdv::WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::QueryWorkflowInvocationActionsResponse, gcdv::WorkflowInvocationAction> response = dataformClient.QueryWorkflowInvocationActionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::WorkflowInvocationAction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::QueryWorkflowInvocationActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::WorkflowInvocationAction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::WorkflowInvocationAction> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::WorkflowInvocationAction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetConfig</summary>
        public void GetConfigRequestObject()
        {
            // Snippet: GetConfig(GetConfigRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::GetConfigRequest request = new gcdv::GetConfigRequest
            {
                ConfigName = gcdv::ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            gcdv::Config response = dataformClient.GetConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetConfigAsync</summary>
        public async Task GetConfigRequestObjectAsync()
        {
            // Snippet: GetConfigAsync(GetConfigRequest, CallSettings)
            // Additional: GetConfigAsync(GetConfigRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetConfigRequest request = new gcdv::GetConfigRequest
            {
                ConfigName = gcdv::ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            gcdv::Config response = await dataformClient.GetConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConfig</summary>
        public void GetConfig()
        {
            // Snippet: GetConfig(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/config";
            // Make the request
            gcdv::Config response = dataformClient.GetConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfigAsync</summary>
        public async Task GetConfigAsync()
        {
            // Snippet: GetConfigAsync(string, CallSettings)
            // Additional: GetConfigAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/config";
            // Make the request
            gcdv::Config response = await dataformClient.GetConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfig</summary>
        public void GetConfigResourceNames()
        {
            // Snippet: GetConfig(ConfigName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::ConfigName name = gcdv::ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            gcdv::Config response = dataformClient.GetConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfigAsync</summary>
        public async Task GetConfigResourceNamesAsync()
        {
            // Snippet: GetConfigAsync(ConfigName, CallSettings)
            // Additional: GetConfigAsync(ConfigName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ConfigName name = gcdv::ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            gcdv::Config response = await dataformClient.GetConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateConfig</summary>
        public void UpdateConfigRequestObject()
        {
            // Snippet: UpdateConfig(UpdateConfigRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateConfigRequest request = new gcdv::UpdateConfigRequest
            {
                Config = new gcdv::Config(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcdv::Config response = dataformClient.UpdateConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConfigAsync</summary>
        public async Task UpdateConfigRequestObjectAsync()
        {
            // Snippet: UpdateConfigAsync(UpdateConfigRequest, CallSettings)
            // Additional: UpdateConfigAsync(UpdateConfigRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateConfigRequest request = new gcdv::UpdateConfigRequest
            {
                Config = new gcdv::Config(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcdv::Config response = await dataformClient.UpdateConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConfig</summary>
        public void UpdateConfig()
        {
            // Snippet: UpdateConfig(Config, FieldMask, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            gcdv::Config config = new gcdv::Config();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::Config response = dataformClient.UpdateConfig(config, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateConfigAsync</summary>
        public async Task UpdateConfigAsync()
        {
            // Snippet: UpdateConfigAsync(Config, FieldMask, CallSettings)
            // Additional: UpdateConfigAsync(Config, FieldMask, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::Config config = new gcdv::Config();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::Config response = await dataformClient.UpdateConfigAsync(config, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = dataformClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await dataformClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = dataformClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await dataformClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = dataformClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await dataformClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = dataformClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await dataformClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            gcdv::DataformClient dataformClient = gcdv::DataformClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = dataformClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            gcdv::DataformClient dataformClient = await gcdv::DataformClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await dataformClient.TestIamPermissionsAsync(request);
            // End snippet
        }
    }
}
