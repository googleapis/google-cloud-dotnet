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
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLicenseConfigServiceClientSnippets
    {
        /// <summary>Snippet for CreateLicenseConfig</summary>
        public void CreateLicenseConfigRequestObject()
        {
            // Snippet: CreateLicenseConfig(CreateLicenseConfigRequest, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            CreateLicenseConfigRequest request = new CreateLicenseConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                LicenseConfig = new LicenseConfig(),
                LicenseConfigId = "",
            };
            // Make the request
            LicenseConfig response = licenseConfigServiceClient.CreateLicenseConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLicenseConfigAsync</summary>
        public async Task CreateLicenseConfigRequestObjectAsync()
        {
            // Snippet: CreateLicenseConfigAsync(CreateLicenseConfigRequest, CallSettings)
            // Additional: CreateLicenseConfigAsync(CreateLicenseConfigRequest, CancellationToken)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateLicenseConfigRequest request = new CreateLicenseConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                LicenseConfig = new LicenseConfig(),
                LicenseConfigId = "",
            };
            // Make the request
            LicenseConfig response = await licenseConfigServiceClient.CreateLicenseConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLicenseConfig</summary>
        public void CreateLicenseConfig()
        {
            // Snippet: CreateLicenseConfig(string, LicenseConfig, string, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            LicenseConfig licenseConfig = new LicenseConfig();
            string licenseConfigId = "";
            // Make the request
            LicenseConfig response = licenseConfigServiceClient.CreateLicenseConfig(parent, licenseConfig, licenseConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateLicenseConfigAsync</summary>
        public async Task CreateLicenseConfigAsync()
        {
            // Snippet: CreateLicenseConfigAsync(string, LicenseConfig, string, CallSettings)
            // Additional: CreateLicenseConfigAsync(string, LicenseConfig, string, CancellationToken)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            LicenseConfig licenseConfig = new LicenseConfig();
            string licenseConfigId = "";
            // Make the request
            LicenseConfig response = await licenseConfigServiceClient.CreateLicenseConfigAsync(parent, licenseConfig, licenseConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateLicenseConfig</summary>
        public void CreateLicenseConfigResourceNames()
        {
            // Snippet: CreateLicenseConfig(LocationName, LicenseConfig, string, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            LicenseConfig licenseConfig = new LicenseConfig();
            string licenseConfigId = "";
            // Make the request
            LicenseConfig response = licenseConfigServiceClient.CreateLicenseConfig(parent, licenseConfig, licenseConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateLicenseConfigAsync</summary>
        public async Task CreateLicenseConfigResourceNamesAsync()
        {
            // Snippet: CreateLicenseConfigAsync(LocationName, LicenseConfig, string, CallSettings)
            // Additional: CreateLicenseConfigAsync(LocationName, LicenseConfig, string, CancellationToken)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            LicenseConfig licenseConfig = new LicenseConfig();
            string licenseConfigId = "";
            // Make the request
            LicenseConfig response = await licenseConfigServiceClient.CreateLicenseConfigAsync(parent, licenseConfig, licenseConfigId);
            // End snippet
        }

        /// <summary>Snippet for UpdateLicenseConfig</summary>
        public void UpdateLicenseConfigRequestObject()
        {
            // Snippet: UpdateLicenseConfig(UpdateLicenseConfigRequest, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            UpdateLicenseConfigRequest request = new UpdateLicenseConfigRequest
            {
                LicenseConfig = new LicenseConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LicenseConfig response = licenseConfigServiceClient.UpdateLicenseConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLicenseConfigAsync</summary>
        public async Task UpdateLicenseConfigRequestObjectAsync()
        {
            // Snippet: UpdateLicenseConfigAsync(UpdateLicenseConfigRequest, CallSettings)
            // Additional: UpdateLicenseConfigAsync(UpdateLicenseConfigRequest, CancellationToken)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateLicenseConfigRequest request = new UpdateLicenseConfigRequest
            {
                LicenseConfig = new LicenseConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LicenseConfig response = await licenseConfigServiceClient.UpdateLicenseConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLicenseConfig</summary>
        public void UpdateLicenseConfig()
        {
            // Snippet: UpdateLicenseConfig(LicenseConfig, FieldMask, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            LicenseConfig licenseConfig = new LicenseConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LicenseConfig response = licenseConfigServiceClient.UpdateLicenseConfig(licenseConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateLicenseConfigAsync</summary>
        public async Task UpdateLicenseConfigAsync()
        {
            // Snippet: UpdateLicenseConfigAsync(LicenseConfig, FieldMask, CallSettings)
            // Additional: UpdateLicenseConfigAsync(LicenseConfig, FieldMask, CancellationToken)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            LicenseConfig licenseConfig = new LicenseConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LicenseConfig response = await licenseConfigServiceClient.UpdateLicenseConfigAsync(licenseConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetLicenseConfig</summary>
        public void GetLicenseConfigRequestObject()
        {
            // Snippet: GetLicenseConfig(GetLicenseConfigRequest, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            GetLicenseConfigRequest request = new GetLicenseConfigRequest
            {
                LicenseConfigName = LicenseConfigName.FromProjectLocationLicenseConfig("[PROJECT]", "[LOCATION]", "[LICENSE_CONFIG]"),
            };
            // Make the request
            LicenseConfig response = licenseConfigServiceClient.GetLicenseConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetLicenseConfigAsync</summary>
        public async Task GetLicenseConfigRequestObjectAsync()
        {
            // Snippet: GetLicenseConfigAsync(GetLicenseConfigRequest, CallSettings)
            // Additional: GetLicenseConfigAsync(GetLicenseConfigRequest, CancellationToken)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLicenseConfigRequest request = new GetLicenseConfigRequest
            {
                LicenseConfigName = LicenseConfigName.FromProjectLocationLicenseConfig("[PROJECT]", "[LOCATION]", "[LICENSE_CONFIG]"),
            };
            // Make the request
            LicenseConfig response = await licenseConfigServiceClient.GetLicenseConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLicenseConfig</summary>
        public void GetLicenseConfig()
        {
            // Snippet: GetLicenseConfig(string, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/licenseConfigs/[LICENSE_CONFIG]";
            // Make the request
            LicenseConfig response = licenseConfigServiceClient.GetLicenseConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetLicenseConfigAsync</summary>
        public async Task GetLicenseConfigAsync()
        {
            // Snippet: GetLicenseConfigAsync(string, CallSettings)
            // Additional: GetLicenseConfigAsync(string, CancellationToken)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/licenseConfigs/[LICENSE_CONFIG]";
            // Make the request
            LicenseConfig response = await licenseConfigServiceClient.GetLicenseConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLicenseConfig</summary>
        public void GetLicenseConfigResourceNames()
        {
            // Snippet: GetLicenseConfig(LicenseConfigName, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            LicenseConfigName name = LicenseConfigName.FromProjectLocationLicenseConfig("[PROJECT]", "[LOCATION]", "[LICENSE_CONFIG]");
            // Make the request
            LicenseConfig response = licenseConfigServiceClient.GetLicenseConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetLicenseConfigAsync</summary>
        public async Task GetLicenseConfigResourceNamesAsync()
        {
            // Snippet: GetLicenseConfigAsync(LicenseConfigName, CallSettings)
            // Additional: GetLicenseConfigAsync(LicenseConfigName, CancellationToken)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            LicenseConfigName name = LicenseConfigName.FromProjectLocationLicenseConfig("[PROJECT]", "[LOCATION]", "[LICENSE_CONFIG]");
            // Make the request
            LicenseConfig response = await licenseConfigServiceClient.GetLicenseConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLicenseConfigs</summary>
        public void ListLicenseConfigsRequestObject()
        {
            // Snippet: ListLicenseConfigs(ListLicenseConfigsRequest, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            ListLicenseConfigsRequest request = new ListLicenseConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListLicenseConfigsResponse, LicenseConfig> response = licenseConfigServiceClient.ListLicenseConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LicenseConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLicenseConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LicenseConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LicenseConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LicenseConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLicenseConfigsAsync</summary>
        public async Task ListLicenseConfigsRequestObjectAsync()
        {
            // Snippet: ListLicenseConfigsAsync(ListLicenseConfigsRequest, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLicenseConfigsRequest request = new ListLicenseConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListLicenseConfigsResponse, LicenseConfig> response = licenseConfigServiceClient.ListLicenseConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LicenseConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLicenseConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LicenseConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LicenseConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LicenseConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLicenseConfigs</summary>
        public void ListLicenseConfigs()
        {
            // Snippet: ListLicenseConfigs(string, string, int?, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListLicenseConfigsResponse, LicenseConfig> response = licenseConfigServiceClient.ListLicenseConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LicenseConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLicenseConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LicenseConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LicenseConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LicenseConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLicenseConfigsAsync</summary>
        public async Task ListLicenseConfigsAsync()
        {
            // Snippet: ListLicenseConfigsAsync(string, string, int?, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListLicenseConfigsResponse, LicenseConfig> response = licenseConfigServiceClient.ListLicenseConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LicenseConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLicenseConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LicenseConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LicenseConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LicenseConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLicenseConfigs</summary>
        public void ListLicenseConfigsResourceNames()
        {
            // Snippet: ListLicenseConfigs(LocationName, string, int?, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListLicenseConfigsResponse, LicenseConfig> response = licenseConfigServiceClient.ListLicenseConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LicenseConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLicenseConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LicenseConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LicenseConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LicenseConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLicenseConfigsAsync</summary>
        public async Task ListLicenseConfigsResourceNamesAsync()
        {
            // Snippet: ListLicenseConfigsAsync(LocationName, string, int?, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListLicenseConfigsResponse, LicenseConfig> response = licenseConfigServiceClient.ListLicenseConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LicenseConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLicenseConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LicenseConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LicenseConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LicenseConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DistributeLicenseConfig</summary>
        public void DistributeLicenseConfigRequestObject()
        {
            // Snippet: DistributeLicenseConfig(DistributeLicenseConfigRequest, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            DistributeLicenseConfigRequest request = new DistributeLicenseConfigRequest
            {
                BillingAccountLicenseConfigAsBillingAccountLicenseConfigName = BillingAccountLicenseConfigName.FromBillingAccountBillingAccountLicenseConfig("[BILLING_ACCOUNT]", "[BILLING_ACCOUNT_LICENSE_CONFIG]"),
                ProjectNumber = 0L,
                Location = "",
                LicenseCount = 0L,
                LicenseConfigId = "",
            };
            // Make the request
            DistributeLicenseConfigResponse response = licenseConfigServiceClient.DistributeLicenseConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DistributeLicenseConfigAsync</summary>
        public async Task DistributeLicenseConfigRequestObjectAsync()
        {
            // Snippet: DistributeLicenseConfigAsync(DistributeLicenseConfigRequest, CallSettings)
            // Additional: DistributeLicenseConfigAsync(DistributeLicenseConfigRequest, CancellationToken)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            DistributeLicenseConfigRequest request = new DistributeLicenseConfigRequest
            {
                BillingAccountLicenseConfigAsBillingAccountLicenseConfigName = BillingAccountLicenseConfigName.FromBillingAccountBillingAccountLicenseConfig("[BILLING_ACCOUNT]", "[BILLING_ACCOUNT_LICENSE_CONFIG]"),
                ProjectNumber = 0L,
                Location = "",
                LicenseCount = 0L,
                LicenseConfigId = "",
            };
            // Make the request
            DistributeLicenseConfigResponse response = await licenseConfigServiceClient.DistributeLicenseConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DistributeLicenseConfig</summary>
        public void DistributeLicenseConfig()
        {
            // Snippet: DistributeLicenseConfig(string, long, string, long, string, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            string billingAccountLicenseConfig = "billingAccounts/[BILLING_ACCOUNT]/billingAccountLicenseConfigs/[BILLING_ACCOUNT_LICENSE_CONFIG]";
            long projectNumber = 0L;
            string location = "";
            long licenseCount = 0L;
            string licenseConfigId = "";
            // Make the request
            DistributeLicenseConfigResponse response = licenseConfigServiceClient.DistributeLicenseConfig(billingAccountLicenseConfig, projectNumber, location, licenseCount, licenseConfigId);
            // End snippet
        }

        /// <summary>Snippet for DistributeLicenseConfigAsync</summary>
        public async Task DistributeLicenseConfigAsync()
        {
            // Snippet: DistributeLicenseConfigAsync(string, long, string, long, string, CallSettings)
            // Additional: DistributeLicenseConfigAsync(string, long, string, long, string, CancellationToken)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string billingAccountLicenseConfig = "billingAccounts/[BILLING_ACCOUNT]/billingAccountLicenseConfigs/[BILLING_ACCOUNT_LICENSE_CONFIG]";
            long projectNumber = 0L;
            string location = "";
            long licenseCount = 0L;
            string licenseConfigId = "";
            // Make the request
            DistributeLicenseConfigResponse response = await licenseConfigServiceClient.DistributeLicenseConfigAsync(billingAccountLicenseConfig, projectNumber, location, licenseCount, licenseConfigId);
            // End snippet
        }

        /// <summary>Snippet for DistributeLicenseConfig</summary>
        public void DistributeLicenseConfigResourceNames()
        {
            // Snippet: DistributeLicenseConfig(BillingAccountLicenseConfigName, long, string, long, string, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            BillingAccountLicenseConfigName billingAccountLicenseConfig = BillingAccountLicenseConfigName.FromBillingAccountBillingAccountLicenseConfig("[BILLING_ACCOUNT]", "[BILLING_ACCOUNT_LICENSE_CONFIG]");
            long projectNumber = 0L;
            string location = "";
            long licenseCount = 0L;
            string licenseConfigId = "";
            // Make the request
            DistributeLicenseConfigResponse response = licenseConfigServiceClient.DistributeLicenseConfig(billingAccountLicenseConfig, projectNumber, location, licenseCount, licenseConfigId);
            // End snippet
        }

        /// <summary>Snippet for DistributeLicenseConfigAsync</summary>
        public async Task DistributeLicenseConfigResourceNamesAsync()
        {
            // Snippet: DistributeLicenseConfigAsync(BillingAccountLicenseConfigName, long, string, long, string, CallSettings)
            // Additional: DistributeLicenseConfigAsync(BillingAccountLicenseConfigName, long, string, long, string, CancellationToken)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            BillingAccountLicenseConfigName billingAccountLicenseConfig = BillingAccountLicenseConfigName.FromBillingAccountBillingAccountLicenseConfig("[BILLING_ACCOUNT]", "[BILLING_ACCOUNT_LICENSE_CONFIG]");
            long projectNumber = 0L;
            string location = "";
            long licenseCount = 0L;
            string licenseConfigId = "";
            // Make the request
            DistributeLicenseConfigResponse response = await licenseConfigServiceClient.DistributeLicenseConfigAsync(billingAccountLicenseConfig, projectNumber, location, licenseCount, licenseConfigId);
            // End snippet
        }

        /// <summary>Snippet for RetractLicenseConfig</summary>
        public void RetractLicenseConfigRequestObject()
        {
            // Snippet: RetractLicenseConfig(RetractLicenseConfigRequest, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            RetractLicenseConfigRequest request = new RetractLicenseConfigRequest
            {
                BillingAccountLicenseConfigAsBillingAccountLicenseConfigName = BillingAccountLicenseConfigName.FromBillingAccountBillingAccountLicenseConfig("[BILLING_ACCOUNT]", "[BILLING_ACCOUNT_LICENSE_CONFIG]"),
                LicenseConfigAsLicenseConfigName = LicenseConfigName.FromProjectLocationLicenseConfig("[PROJECT]", "[LOCATION]", "[LICENSE_CONFIG]"),
                FullRetract = false,
                LicenseCount = 0L,
            };
            // Make the request
            RetractLicenseConfigResponse response = licenseConfigServiceClient.RetractLicenseConfig(request);
            // End snippet
        }

        /// <summary>Snippet for RetractLicenseConfigAsync</summary>
        public async Task RetractLicenseConfigRequestObjectAsync()
        {
            // Snippet: RetractLicenseConfigAsync(RetractLicenseConfigRequest, CallSettings)
            // Additional: RetractLicenseConfigAsync(RetractLicenseConfigRequest, CancellationToken)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetractLicenseConfigRequest request = new RetractLicenseConfigRequest
            {
                BillingAccountLicenseConfigAsBillingAccountLicenseConfigName = BillingAccountLicenseConfigName.FromBillingAccountBillingAccountLicenseConfig("[BILLING_ACCOUNT]", "[BILLING_ACCOUNT_LICENSE_CONFIG]"),
                LicenseConfigAsLicenseConfigName = LicenseConfigName.FromProjectLocationLicenseConfig("[PROJECT]", "[LOCATION]", "[LICENSE_CONFIG]"),
                FullRetract = false,
                LicenseCount = 0L,
            };
            // Make the request
            RetractLicenseConfigResponse response = await licenseConfigServiceClient.RetractLicenseConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetractLicenseConfig</summary>
        public void RetractLicenseConfig()
        {
            // Snippet: RetractLicenseConfig(string, string, bool, long, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            string billingAccountLicenseConfig = "billingAccounts/[BILLING_ACCOUNT]/billingAccountLicenseConfigs/[BILLING_ACCOUNT_LICENSE_CONFIG]";
            string licenseConfig = "projects/[PROJECT]/locations/[LOCATION]/licenseConfigs/[LICENSE_CONFIG]";
            bool fullRetract = false;
            long licenseCount = 0L;
            // Make the request
            RetractLicenseConfigResponse response = licenseConfigServiceClient.RetractLicenseConfig(billingAccountLicenseConfig, licenseConfig, fullRetract, licenseCount);
            // End snippet
        }

        /// <summary>Snippet for RetractLicenseConfigAsync</summary>
        public async Task RetractLicenseConfigAsync()
        {
            // Snippet: RetractLicenseConfigAsync(string, string, bool, long, CallSettings)
            // Additional: RetractLicenseConfigAsync(string, string, bool, long, CancellationToken)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string billingAccountLicenseConfig = "billingAccounts/[BILLING_ACCOUNT]/billingAccountLicenseConfigs/[BILLING_ACCOUNT_LICENSE_CONFIG]";
            string licenseConfig = "projects/[PROJECT]/locations/[LOCATION]/licenseConfigs/[LICENSE_CONFIG]";
            bool fullRetract = false;
            long licenseCount = 0L;
            // Make the request
            RetractLicenseConfigResponse response = await licenseConfigServiceClient.RetractLicenseConfigAsync(billingAccountLicenseConfig, licenseConfig, fullRetract, licenseCount);
            // End snippet
        }

        /// <summary>Snippet for RetractLicenseConfig</summary>
        public void RetractLicenseConfigResourceNames()
        {
            // Snippet: RetractLicenseConfig(BillingAccountLicenseConfigName, LicenseConfigName, bool, long, CallSettings)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = LicenseConfigServiceClient.Create();
            // Initialize request argument(s)
            BillingAccountLicenseConfigName billingAccountLicenseConfig = BillingAccountLicenseConfigName.FromBillingAccountBillingAccountLicenseConfig("[BILLING_ACCOUNT]", "[BILLING_ACCOUNT_LICENSE_CONFIG]");
            LicenseConfigName licenseConfig = LicenseConfigName.FromProjectLocationLicenseConfig("[PROJECT]", "[LOCATION]", "[LICENSE_CONFIG]");
            bool fullRetract = false;
            long licenseCount = 0L;
            // Make the request
            RetractLicenseConfigResponse response = licenseConfigServiceClient.RetractLicenseConfig(billingAccountLicenseConfig, licenseConfig, fullRetract, licenseCount);
            // End snippet
        }

        /// <summary>Snippet for RetractLicenseConfigAsync</summary>
        public async Task RetractLicenseConfigResourceNamesAsync()
        {
            // Snippet: RetractLicenseConfigAsync(BillingAccountLicenseConfigName, LicenseConfigName, bool, long, CallSettings)
            // Additional: RetractLicenseConfigAsync(BillingAccountLicenseConfigName, LicenseConfigName, bool, long, CancellationToken)
            // Create client
            LicenseConfigServiceClient licenseConfigServiceClient = await LicenseConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            BillingAccountLicenseConfigName billingAccountLicenseConfig = BillingAccountLicenseConfigName.FromBillingAccountBillingAccountLicenseConfig("[BILLING_ACCOUNT]", "[BILLING_ACCOUNT_LICENSE_CONFIG]");
            LicenseConfigName licenseConfig = LicenseConfigName.FromProjectLocationLicenseConfig("[PROJECT]", "[LOCATION]", "[LICENSE_CONFIG]");
            bool fullRetract = false;
            long licenseCount = 0L;
            // Make the request
            RetractLicenseConfigResponse response = await licenseConfigServiceClient.RetractLicenseConfigAsync(billingAccountLicenseConfig, licenseConfig, fullRetract, licenseCount);
            // End snippet
        }
    }
}
