// Copyright 2022 Google LLC
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

namespace Google.Cloud.Talent.V4Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedProfileServiceClientSnippets
    {
        /// <summary>Snippet for ListProfiles</summary>
        public void ListProfilesRequestObject()
        {
            // Snippet: ListProfiles(ListProfilesRequest, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            ListProfilesRequest request = new ListProfilesRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ReadMask = new FieldMask(),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListProfilesResponse, Profile> response = profileServiceClient.ListProfiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Profile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Profile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Profile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Profile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProfilesAsync</summary>
        public async Task ListProfilesRequestObjectAsync()
        {
            // Snippet: ListProfilesAsync(ListProfilesRequest, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListProfilesRequest request = new ListProfilesRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ReadMask = new FieldMask(),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListProfilesResponse, Profile> response = profileServiceClient.ListProfilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Profile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Profile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Profile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Profile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProfiles</summary>
        public void ListProfiles()
        {
            // Snippet: ListProfiles(string, string, int?, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            // Make the request
            PagedEnumerable<ListProfilesResponse, Profile> response = profileServiceClient.ListProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Profile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Profile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Profile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Profile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProfilesAsync</summary>
        public async Task ListProfilesAsync()
        {
            // Snippet: ListProfilesAsync(string, string, int?, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            // Make the request
            PagedAsyncEnumerable<ListProfilesResponse, Profile> response = profileServiceClient.ListProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Profile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Profile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Profile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Profile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProfiles</summary>
        public void ListProfilesResourceNames()
        {
            // Snippet: ListProfiles(TenantName, string, int?, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            // Make the request
            PagedEnumerable<ListProfilesResponse, Profile> response = profileServiceClient.ListProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Profile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Profile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Profile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Profile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProfilesAsync</summary>
        public async Task ListProfilesResourceNamesAsync()
        {
            // Snippet: ListProfilesAsync(TenantName, string, int?, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            // Make the request
            PagedAsyncEnumerable<ListProfilesResponse, Profile> response = profileServiceClient.ListProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Profile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Profile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Profile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Profile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateProfile</summary>
        public void CreateProfileRequestObject()
        {
            // Snippet: CreateProfile(CreateProfileRequest, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            CreateProfileRequest request = new CreateProfileRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Profile = new Profile(),
            };
            // Make the request
            Profile response = profileServiceClient.CreateProfile(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProfileAsync</summary>
        public async Task CreateProfileRequestObjectAsync()
        {
            // Snippet: CreateProfileAsync(CreateProfileRequest, CallSettings)
            // Additional: CreateProfileAsync(CreateProfileRequest, CancellationToken)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateProfileRequest request = new CreateProfileRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Profile = new Profile(),
            };
            // Make the request
            Profile response = await profileServiceClient.CreateProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProfile</summary>
        public void CreateProfile()
        {
            // Snippet: CreateProfile(string, Profile, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            Profile profile = new Profile();
            // Make the request
            Profile response = profileServiceClient.CreateProfile(parent, profile);
            // End snippet
        }

        /// <summary>Snippet for CreateProfileAsync</summary>
        public async Task CreateProfileAsync()
        {
            // Snippet: CreateProfileAsync(string, Profile, CallSettings)
            // Additional: CreateProfileAsync(string, Profile, CancellationToken)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            Profile profile = new Profile();
            // Make the request
            Profile response = await profileServiceClient.CreateProfileAsync(parent, profile);
            // End snippet
        }

        /// <summary>Snippet for CreateProfile</summary>
        public void CreateProfileResourceNames()
        {
            // Snippet: CreateProfile(TenantName, Profile, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            Profile profile = new Profile();
            // Make the request
            Profile response = profileServiceClient.CreateProfile(parent, profile);
            // End snippet
        }

        /// <summary>Snippet for CreateProfileAsync</summary>
        public async Task CreateProfileResourceNamesAsync()
        {
            // Snippet: CreateProfileAsync(TenantName, Profile, CallSettings)
            // Additional: CreateProfileAsync(TenantName, Profile, CancellationToken)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            Profile profile = new Profile();
            // Make the request
            Profile response = await profileServiceClient.CreateProfileAsync(parent, profile);
            // End snippet
        }

        /// <summary>Snippet for GetProfile</summary>
        public void GetProfileRequestObject()
        {
            // Snippet: GetProfile(GetProfileRequest, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            GetProfileRequest request = new GetProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            // Make the request
            Profile response = profileServiceClient.GetProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetProfileAsync</summary>
        public async Task GetProfileRequestObjectAsync()
        {
            // Snippet: GetProfileAsync(GetProfileRequest, CallSettings)
            // Additional: GetProfileAsync(GetProfileRequest, CancellationToken)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProfileRequest request = new GetProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            // Make the request
            Profile response = await profileServiceClient.GetProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProfile</summary>
        public void GetProfile()
        {
            // Snippet: GetProfile(string, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/profiles/[PROFILE]";
            // Make the request
            Profile response = profileServiceClient.GetProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetProfileAsync</summary>
        public async Task GetProfileAsync()
        {
            // Snippet: GetProfileAsync(string, CallSettings)
            // Additional: GetProfileAsync(string, CancellationToken)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/profiles/[PROFILE]";
            // Make the request
            Profile response = await profileServiceClient.GetProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProfile</summary>
        public void GetProfileResourceNames()
        {
            // Snippet: GetProfile(ProfileName, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            ProfileName name = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]");
            // Make the request
            Profile response = profileServiceClient.GetProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetProfileAsync</summary>
        public async Task GetProfileResourceNamesAsync()
        {
            // Snippet: GetProfileAsync(ProfileName, CallSettings)
            // Additional: GetProfileAsync(ProfileName, CancellationToken)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProfileName name = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]");
            // Make the request
            Profile response = await profileServiceClient.GetProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateProfile</summary>
        public void UpdateProfileRequestObject()
        {
            // Snippet: UpdateProfile(UpdateProfileRequest, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            UpdateProfileRequest request = new UpdateProfileRequest
            {
                Profile = new Profile(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Profile response = profileServiceClient.UpdateProfile(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProfileAsync</summary>
        public async Task UpdateProfileRequestObjectAsync()
        {
            // Snippet: UpdateProfileAsync(UpdateProfileRequest, CallSettings)
            // Additional: UpdateProfileAsync(UpdateProfileRequest, CancellationToken)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProfileRequest request = new UpdateProfileRequest
            {
                Profile = new Profile(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Profile response = await profileServiceClient.UpdateProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProfile</summary>
        public void UpdateProfile()
        {
            // Snippet: UpdateProfile(Profile, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            Profile profile = new Profile();
            // Make the request
            Profile response = profileServiceClient.UpdateProfile(profile);
            // End snippet
        }

        /// <summary>Snippet for UpdateProfileAsync</summary>
        public async Task UpdateProfileAsync()
        {
            // Snippet: UpdateProfileAsync(Profile, CallSettings)
            // Additional: UpdateProfileAsync(Profile, CancellationToken)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            Profile profile = new Profile();
            // Make the request
            Profile response = await profileServiceClient.UpdateProfileAsync(profile);
            // End snippet
        }

        /// <summary>Snippet for DeleteProfile</summary>
        public void DeleteProfileRequestObject()
        {
            // Snippet: DeleteProfile(DeleteProfileRequest, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            DeleteProfileRequest request = new DeleteProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            // Make the request
            profileServiceClient.DeleteProfile(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProfileAsync</summary>
        public async Task DeleteProfileRequestObjectAsync()
        {
            // Snippet: DeleteProfileAsync(DeleteProfileRequest, CallSettings)
            // Additional: DeleteProfileAsync(DeleteProfileRequest, CancellationToken)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteProfileRequest request = new DeleteProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            // Make the request
            await profileServiceClient.DeleteProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProfile</summary>
        public void DeleteProfile()
        {
            // Snippet: DeleteProfile(string, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/profiles/[PROFILE]";
            // Make the request
            profileServiceClient.DeleteProfile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProfileAsync</summary>
        public async Task DeleteProfileAsync()
        {
            // Snippet: DeleteProfileAsync(string, CallSettings)
            // Additional: DeleteProfileAsync(string, CancellationToken)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/profiles/[PROFILE]";
            // Make the request
            await profileServiceClient.DeleteProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProfile</summary>
        public void DeleteProfileResourceNames()
        {
            // Snippet: DeleteProfile(ProfileName, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            ProfileName name = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]");
            // Make the request
            profileServiceClient.DeleteProfile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProfileAsync</summary>
        public async Task DeleteProfileResourceNamesAsync()
        {
            // Snippet: DeleteProfileAsync(ProfileName, CallSettings)
            // Additional: DeleteProfileAsync(ProfileName, CancellationToken)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProfileName name = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]");
            // Make the request
            await profileServiceClient.DeleteProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SearchProfiles</summary>
        public void SearchProfilesRequestObject()
        {
            // Snippet: SearchProfiles(SearchProfilesRequest, CallSettings)
            // Create client
            ProfileServiceClient profileServiceClient = ProfileServiceClient.Create();
            // Initialize request argument(s)
            SearchProfilesRequest request = new SearchProfilesRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                RequestMetadata = new RequestMetadata(),
                ProfileQuery = new ProfileQuery(),
                PageSize = 0,
                PageToken = "",
                Offset = 0,
                DisableSpellCheck = false,
                OrderBy = "",
                CaseSensitiveSort = false,
                HistogramQueries =
                {
                    new HistogramQuery(),
                },
                ResultSetId = "",
                StrictKeywordsSearch = false,
            };
            // Make the request
            SearchProfilesResponse response = profileServiceClient.SearchProfiles(request);
            // End snippet
        }

        /// <summary>Snippet for SearchProfilesAsync</summary>
        public async Task SearchProfilesRequestObjectAsync()
        {
            // Snippet: SearchProfilesAsync(SearchProfilesRequest, CallSettings)
            // Additional: SearchProfilesAsync(SearchProfilesRequest, CancellationToken)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchProfilesRequest request = new SearchProfilesRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                RequestMetadata = new RequestMetadata(),
                ProfileQuery = new ProfileQuery(),
                PageSize = 0,
                PageToken = "",
                Offset = 0,
                DisableSpellCheck = false,
                OrderBy = "",
                CaseSensitiveSort = false,
                HistogramQueries =
                {
                    new HistogramQuery(),
                },
                ResultSetId = "",
                StrictKeywordsSearch = false,
            };
            // Make the request
            SearchProfilesResponse response = await profileServiceClient.SearchProfilesAsync(request);
            // End snippet
        }
    }
}
