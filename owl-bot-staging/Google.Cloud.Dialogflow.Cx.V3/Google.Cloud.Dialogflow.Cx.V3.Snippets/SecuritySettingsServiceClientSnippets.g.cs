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
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSecuritySettingsServiceClientSnippets
    {
        /// <summary>Snippet for CreateSecuritySettings</summary>
        public void CreateSecuritySettingsRequestObject()
        {
            // Snippet: CreateSecuritySettings(CreateSecuritySettingsRequest, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            CreateSecuritySettingsRequest request = new CreateSecuritySettingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SecuritySettings = new SecuritySettings(),
            };
            // Make the request
            SecuritySettings response = securitySettingsServiceClient.CreateSecuritySettings(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSecuritySettingsAsync</summary>
        public async Task CreateSecuritySettingsRequestObjectAsync()
        {
            // Snippet: CreateSecuritySettingsAsync(CreateSecuritySettingsRequest, CallSettings)
            // Additional: CreateSecuritySettingsAsync(CreateSecuritySettingsRequest, CancellationToken)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSecuritySettingsRequest request = new CreateSecuritySettingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SecuritySettings = new SecuritySettings(),
            };
            // Make the request
            SecuritySettings response = await securitySettingsServiceClient.CreateSecuritySettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSecuritySettings</summary>
        public void CreateSecuritySettings()
        {
            // Snippet: CreateSecuritySettings(string, SecuritySettings, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SecuritySettings securitySettings = new SecuritySettings();
            // Make the request
            SecuritySettings response = securitySettingsServiceClient.CreateSecuritySettings(parent, securitySettings);
            // End snippet
        }

        /// <summary>Snippet for CreateSecuritySettingsAsync</summary>
        public async Task CreateSecuritySettingsAsync()
        {
            // Snippet: CreateSecuritySettingsAsync(string, SecuritySettings, CallSettings)
            // Additional: CreateSecuritySettingsAsync(string, SecuritySettings, CancellationToken)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SecuritySettings securitySettings = new SecuritySettings();
            // Make the request
            SecuritySettings response = await securitySettingsServiceClient.CreateSecuritySettingsAsync(parent, securitySettings);
            // End snippet
        }

        /// <summary>Snippet for CreateSecuritySettings</summary>
        public void CreateSecuritySettingsResourceNames()
        {
            // Snippet: CreateSecuritySettings(LocationName, SecuritySettings, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SecuritySettings securitySettings = new SecuritySettings();
            // Make the request
            SecuritySettings response = securitySettingsServiceClient.CreateSecuritySettings(parent, securitySettings);
            // End snippet
        }

        /// <summary>Snippet for CreateSecuritySettingsAsync</summary>
        public async Task CreateSecuritySettingsResourceNamesAsync()
        {
            // Snippet: CreateSecuritySettingsAsync(LocationName, SecuritySettings, CallSettings)
            // Additional: CreateSecuritySettingsAsync(LocationName, SecuritySettings, CancellationToken)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SecuritySettings securitySettings = new SecuritySettings();
            // Make the request
            SecuritySettings response = await securitySettingsServiceClient.CreateSecuritySettingsAsync(parent, securitySettings);
            // End snippet
        }

        /// <summary>Snippet for GetSecuritySettings</summary>
        public void GetSecuritySettingsRequestObject()
        {
            // Snippet: GetSecuritySettings(GetSecuritySettingsRequest, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            GetSecuritySettingsRequest request = new GetSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            // Make the request
            SecuritySettings response = securitySettingsServiceClient.GetSecuritySettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecuritySettingsAsync</summary>
        public async Task GetSecuritySettingsRequestObjectAsync()
        {
            // Snippet: GetSecuritySettingsAsync(GetSecuritySettingsRequest, CallSettings)
            // Additional: GetSecuritySettingsAsync(GetSecuritySettingsRequest, CancellationToken)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSecuritySettingsRequest request = new GetSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            // Make the request
            SecuritySettings response = await securitySettingsServiceClient.GetSecuritySettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecuritySettings</summary>
        public void GetSecuritySettings()
        {
            // Snippet: GetSecuritySettings(string, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/securitySettings/[SECURITY_SETTINGS]";
            // Make the request
            SecuritySettings response = securitySettingsServiceClient.GetSecuritySettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecuritySettingsAsync</summary>
        public async Task GetSecuritySettingsAsync()
        {
            // Snippet: GetSecuritySettingsAsync(string, CallSettings)
            // Additional: GetSecuritySettingsAsync(string, CancellationToken)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/securitySettings/[SECURITY_SETTINGS]";
            // Make the request
            SecuritySettings response = await securitySettingsServiceClient.GetSecuritySettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecuritySettings</summary>
        public void GetSecuritySettingsResourceNames()
        {
            // Snippet: GetSecuritySettings(SecuritySettingsName, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            SecuritySettingsName name = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]");
            // Make the request
            SecuritySettings response = securitySettingsServiceClient.GetSecuritySettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecuritySettingsAsync</summary>
        public async Task GetSecuritySettingsResourceNamesAsync()
        {
            // Snippet: GetSecuritySettingsAsync(SecuritySettingsName, CallSettings)
            // Additional: GetSecuritySettingsAsync(SecuritySettingsName, CancellationToken)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecuritySettingsName name = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]");
            // Make the request
            SecuritySettings response = await securitySettingsServiceClient.GetSecuritySettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecuritySettings</summary>
        public void UpdateSecuritySettingsRequestObject()
        {
            // Snippet: UpdateSecuritySettings(UpdateSecuritySettingsRequest, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            UpdateSecuritySettingsRequest request = new UpdateSecuritySettingsRequest
            {
                SecuritySettings = new SecuritySettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SecuritySettings response = securitySettingsServiceClient.UpdateSecuritySettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecuritySettingsAsync</summary>
        public async Task UpdateSecuritySettingsRequestObjectAsync()
        {
            // Snippet: UpdateSecuritySettingsAsync(UpdateSecuritySettingsRequest, CallSettings)
            // Additional: UpdateSecuritySettingsAsync(UpdateSecuritySettingsRequest, CancellationToken)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSecuritySettingsRequest request = new UpdateSecuritySettingsRequest
            {
                SecuritySettings = new SecuritySettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SecuritySettings response = await securitySettingsServiceClient.UpdateSecuritySettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecuritySettings</summary>
        public void UpdateSecuritySettings()
        {
            // Snippet: UpdateSecuritySettings(SecuritySettings, FieldMask, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            SecuritySettings securitySettings = new SecuritySettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SecuritySettings response = securitySettingsServiceClient.UpdateSecuritySettings(securitySettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecuritySettingsAsync</summary>
        public async Task UpdateSecuritySettingsAsync()
        {
            // Snippet: UpdateSecuritySettingsAsync(SecuritySettings, FieldMask, CallSettings)
            // Additional: UpdateSecuritySettingsAsync(SecuritySettings, FieldMask, CancellationToken)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecuritySettings securitySettings = new SecuritySettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SecuritySettings response = await securitySettingsServiceClient.UpdateSecuritySettingsAsync(securitySettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListSecuritySettings</summary>
        public void ListSecuritySettingsRequestObject()
        {
            // Snippet: ListSecuritySettings(ListSecuritySettingsRequest, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            ListSecuritySettingsRequest request = new ListSecuritySettingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListSecuritySettingsResponse, SecuritySettings> response = securitySettingsServiceClient.ListSecuritySettings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecuritySettings item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecuritySettingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecuritySettings item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecuritySettings> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecuritySettings item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecuritySettingsAsync</summary>
        public async Task ListSecuritySettingsRequestObjectAsync()
        {
            // Snippet: ListSecuritySettingsAsync(ListSecuritySettingsRequest, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSecuritySettingsRequest request = new ListSecuritySettingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSecuritySettingsResponse, SecuritySettings> response = securitySettingsServiceClient.ListSecuritySettingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecuritySettings item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecuritySettingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecuritySettings item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecuritySettings> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecuritySettings item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecuritySettings</summary>
        public void ListSecuritySettings()
        {
            // Snippet: ListSecuritySettings(string, string, int?, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSecuritySettingsResponse, SecuritySettings> response = securitySettingsServiceClient.ListSecuritySettings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecuritySettings item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecuritySettingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecuritySettings item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecuritySettings> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecuritySettings item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecuritySettingsAsync</summary>
        public async Task ListSecuritySettingsAsync()
        {
            // Snippet: ListSecuritySettingsAsync(string, string, int?, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSecuritySettingsResponse, SecuritySettings> response = securitySettingsServiceClient.ListSecuritySettingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecuritySettings item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecuritySettingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecuritySettings item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecuritySettings> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecuritySettings item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecuritySettings</summary>
        public void ListSecuritySettingsResourceNames()
        {
            // Snippet: ListSecuritySettings(LocationName, string, int?, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSecuritySettingsResponse, SecuritySettings> response = securitySettingsServiceClient.ListSecuritySettings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecuritySettings item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecuritySettingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecuritySettings item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecuritySettings> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecuritySettings item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecuritySettingsAsync</summary>
        public async Task ListSecuritySettingsResourceNamesAsync()
        {
            // Snippet: ListSecuritySettingsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSecuritySettingsResponse, SecuritySettings> response = securitySettingsServiceClient.ListSecuritySettingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecuritySettings item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecuritySettingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecuritySettings item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecuritySettings> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecuritySettings item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteSecuritySettings</summary>
        public void DeleteSecuritySettingsRequestObject()
        {
            // Snippet: DeleteSecuritySettings(DeleteSecuritySettingsRequest, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            DeleteSecuritySettingsRequest request = new DeleteSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            // Make the request
            securitySettingsServiceClient.DeleteSecuritySettings(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecuritySettingsAsync</summary>
        public async Task DeleteSecuritySettingsRequestObjectAsync()
        {
            // Snippet: DeleteSecuritySettingsAsync(DeleteSecuritySettingsRequest, CallSettings)
            // Additional: DeleteSecuritySettingsAsync(DeleteSecuritySettingsRequest, CancellationToken)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSecuritySettingsRequest request = new DeleteSecuritySettingsRequest
            {
                SecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
            };
            // Make the request
            await securitySettingsServiceClient.DeleteSecuritySettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecuritySettings</summary>
        public void DeleteSecuritySettings()
        {
            // Snippet: DeleteSecuritySettings(string, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/securitySettings/[SECURITY_SETTINGS]";
            // Make the request
            securitySettingsServiceClient.DeleteSecuritySettings(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecuritySettingsAsync</summary>
        public async Task DeleteSecuritySettingsAsync()
        {
            // Snippet: DeleteSecuritySettingsAsync(string, CallSettings)
            // Additional: DeleteSecuritySettingsAsync(string, CancellationToken)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/securitySettings/[SECURITY_SETTINGS]";
            // Make the request
            await securitySettingsServiceClient.DeleteSecuritySettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecuritySettings</summary>
        public void DeleteSecuritySettingsResourceNames()
        {
            // Snippet: DeleteSecuritySettings(SecuritySettingsName, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            SecuritySettingsName name = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]");
            // Make the request
            securitySettingsServiceClient.DeleteSecuritySettings(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecuritySettingsAsync</summary>
        public async Task DeleteSecuritySettingsResourceNamesAsync()
        {
            // Snippet: DeleteSecuritySettingsAsync(SecuritySettingsName, CallSettings)
            // Additional: DeleteSecuritySettingsAsync(SecuritySettingsName, CancellationToken)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecuritySettingsName name = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]");
            // Make the request
            await securitySettingsServiceClient.DeleteSecuritySettingsAsync(name);
            // End snippet
        }
    }
}
