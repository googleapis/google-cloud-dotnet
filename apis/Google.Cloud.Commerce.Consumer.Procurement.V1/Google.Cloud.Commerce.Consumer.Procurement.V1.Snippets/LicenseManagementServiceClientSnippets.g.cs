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
    using Google.Cloud.Commerce.Consumer.Procurement.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLicenseManagementServiceClientSnippets
    {
        /// <summary>Snippet for GetLicensePool</summary>
        public void GetLicensePoolRequestObject()
        {
            // Snippet: GetLicensePool(GetLicensePoolRequest, CallSettings)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = LicenseManagementServiceClient.Create();
            // Initialize request argument(s)
            GetLicensePoolRequest request = new GetLicensePoolRequest { Name = "", };
            // Make the request
            LicensePool response = licenseManagementServiceClient.GetLicensePool(request);
            // End snippet
        }

        /// <summary>Snippet for GetLicensePoolAsync</summary>
        public async Task GetLicensePoolRequestObjectAsync()
        {
            // Snippet: GetLicensePoolAsync(GetLicensePoolRequest, CallSettings)
            // Additional: GetLicensePoolAsync(GetLicensePoolRequest, CancellationToken)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = await LicenseManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLicensePoolRequest request = new GetLicensePoolRequest { Name = "", };
            // Make the request
            LicensePool response = await licenseManagementServiceClient.GetLicensePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLicensePool</summary>
        public void GetLicensePool()
        {
            // Snippet: GetLicensePool(string, CallSettings)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = LicenseManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            LicensePool response = licenseManagementServiceClient.GetLicensePool(name);
            // End snippet
        }

        /// <summary>Snippet for GetLicensePoolAsync</summary>
        public async Task GetLicensePoolAsync()
        {
            // Snippet: GetLicensePoolAsync(string, CallSettings)
            // Additional: GetLicensePoolAsync(string, CancellationToken)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = await LicenseManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            LicensePool response = await licenseManagementServiceClient.GetLicensePoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateLicensePool</summary>
        public void UpdateLicensePoolRequestObject()
        {
            // Snippet: UpdateLicensePool(UpdateLicensePoolRequest, CallSettings)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = LicenseManagementServiceClient.Create();
            // Initialize request argument(s)
            UpdateLicensePoolRequest request = new UpdateLicensePoolRequest
            {
                LicensePool = new LicensePool(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LicensePool response = licenseManagementServiceClient.UpdateLicensePool(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLicensePoolAsync</summary>
        public async Task UpdateLicensePoolRequestObjectAsync()
        {
            // Snippet: UpdateLicensePoolAsync(UpdateLicensePoolRequest, CallSettings)
            // Additional: UpdateLicensePoolAsync(UpdateLicensePoolRequest, CancellationToken)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = await LicenseManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateLicensePoolRequest request = new UpdateLicensePoolRequest
            {
                LicensePool = new LicensePool(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LicensePool response = await licenseManagementServiceClient.UpdateLicensePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLicensePool</summary>
        public void UpdateLicensePool()
        {
            // Snippet: UpdateLicensePool(LicensePool, FieldMask, CallSettings)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = LicenseManagementServiceClient.Create();
            // Initialize request argument(s)
            LicensePool licensePool = new LicensePool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LicensePool response = licenseManagementServiceClient.UpdateLicensePool(licensePool, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateLicensePoolAsync</summary>
        public async Task UpdateLicensePoolAsync()
        {
            // Snippet: UpdateLicensePoolAsync(LicensePool, FieldMask, CallSettings)
            // Additional: UpdateLicensePoolAsync(LicensePool, FieldMask, CancellationToken)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = await LicenseManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            LicensePool licensePool = new LicensePool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LicensePool response = await licenseManagementServiceClient.UpdateLicensePoolAsync(licensePool, updateMask);
            // End snippet
        }

        /// <summary>Snippet for Assign</summary>
        public void AssignRequestObject()
        {
            // Snippet: Assign(AssignRequest, CallSettings)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = LicenseManagementServiceClient.Create();
            // Initialize request argument(s)
            AssignRequest request = new AssignRequest
            {
                Parent = "",
                Usernames = { "", },
            };
            // Make the request
            AssignResponse response = licenseManagementServiceClient.Assign(request);
            // End snippet
        }

        /// <summary>Snippet for AssignAsync</summary>
        public async Task AssignRequestObjectAsync()
        {
            // Snippet: AssignAsync(AssignRequest, CallSettings)
            // Additional: AssignAsync(AssignRequest, CancellationToken)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = await LicenseManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssignRequest request = new AssignRequest
            {
                Parent = "",
                Usernames = { "", },
            };
            // Make the request
            AssignResponse response = await licenseManagementServiceClient.AssignAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Assign</summary>
        public void Assign()
        {
            // Snippet: Assign(string, IEnumerable<string>, CallSettings)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = LicenseManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            IEnumerable<string> usernames = new string[] { "", };
            // Make the request
            AssignResponse response = licenseManagementServiceClient.Assign(parent, usernames);
            // End snippet
        }

        /// <summary>Snippet for AssignAsync</summary>
        public async Task AssignAsync()
        {
            // Snippet: AssignAsync(string, IEnumerable<string>, CallSettings)
            // Additional: AssignAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = await LicenseManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            IEnumerable<string> usernames = new string[] { "", };
            // Make the request
            AssignResponse response = await licenseManagementServiceClient.AssignAsync(parent, usernames);
            // End snippet
        }

        /// <summary>Snippet for Unassign</summary>
        public void UnassignRequestObject()
        {
            // Snippet: Unassign(UnassignRequest, CallSettings)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = LicenseManagementServiceClient.Create();
            // Initialize request argument(s)
            UnassignRequest request = new UnassignRequest
            {
                Parent = "",
                Usernames = { "", },
            };
            // Make the request
            UnassignResponse response = licenseManagementServiceClient.Unassign(request);
            // End snippet
        }

        /// <summary>Snippet for UnassignAsync</summary>
        public async Task UnassignRequestObjectAsync()
        {
            // Snippet: UnassignAsync(UnassignRequest, CallSettings)
            // Additional: UnassignAsync(UnassignRequest, CancellationToken)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = await LicenseManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            UnassignRequest request = new UnassignRequest
            {
                Parent = "",
                Usernames = { "", },
            };
            // Make the request
            UnassignResponse response = await licenseManagementServiceClient.UnassignAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Unassign</summary>
        public void Unassign()
        {
            // Snippet: Unassign(string, IEnumerable<string>, CallSettings)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = LicenseManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            IEnumerable<string> usernames = new string[] { "", };
            // Make the request
            UnassignResponse response = licenseManagementServiceClient.Unassign(parent, usernames);
            // End snippet
        }

        /// <summary>Snippet for UnassignAsync</summary>
        public async Task UnassignAsync()
        {
            // Snippet: UnassignAsync(string, IEnumerable<string>, CallSettings)
            // Additional: UnassignAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = await LicenseManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            IEnumerable<string> usernames = new string[] { "", };
            // Make the request
            UnassignResponse response = await licenseManagementServiceClient.UnassignAsync(parent, usernames);
            // End snippet
        }

        /// <summary>Snippet for EnumerateLicensedUsers</summary>
        public void EnumerateLicensedUsersRequestObject()
        {
            // Snippet: EnumerateLicensedUsers(EnumerateLicensedUsersRequest, CallSettings)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = LicenseManagementServiceClient.Create();
            // Initialize request argument(s)
            EnumerateLicensedUsersRequest request = new EnumerateLicensedUsersRequest { Parent = "", };
            // Make the request
            PagedEnumerable<EnumerateLicensedUsersResponse, LicensedUser> response = licenseManagementServiceClient.EnumerateLicensedUsers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LicensedUser item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (EnumerateLicensedUsersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LicensedUser item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LicensedUser> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LicensedUser item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for EnumerateLicensedUsersAsync</summary>
        public async Task EnumerateLicensedUsersRequestObjectAsync()
        {
            // Snippet: EnumerateLicensedUsersAsync(EnumerateLicensedUsersRequest, CallSettings)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = await LicenseManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            EnumerateLicensedUsersRequest request = new EnumerateLicensedUsersRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<EnumerateLicensedUsersResponse, LicensedUser> response = licenseManagementServiceClient.EnumerateLicensedUsersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LicensedUser item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((EnumerateLicensedUsersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LicensedUser item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LicensedUser> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LicensedUser item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for EnumerateLicensedUsers</summary>
        public void EnumerateLicensedUsers()
        {
            // Snippet: EnumerateLicensedUsers(string, string, int?, CallSettings)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = LicenseManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<EnumerateLicensedUsersResponse, LicensedUser> response = licenseManagementServiceClient.EnumerateLicensedUsers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LicensedUser item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (EnumerateLicensedUsersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LicensedUser item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LicensedUser> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LicensedUser item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for EnumerateLicensedUsersAsync</summary>
        public async Task EnumerateLicensedUsersAsync()
        {
            // Snippet: EnumerateLicensedUsersAsync(string, string, int?, CallSettings)
            // Create client
            LicenseManagementServiceClient licenseManagementServiceClient = await LicenseManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<EnumerateLicensedUsersResponse, LicensedUser> response = licenseManagementServiceClient.EnumerateLicensedUsersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LicensedUser item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((EnumerateLicensedUsersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LicensedUser item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LicensedUser> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LicensedUser item in singlePage)
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
