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
    using Google.Cloud.BigQuery.DataPolicies.V1;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataPolicyServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataPolicy</summary>
        public void CreateDataPolicyRequestObject()
        {
            // Snippet: CreateDataPolicy(CreateDataPolicyRequest, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            CreateDataPolicyRequest request = new CreateDataPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataPolicy = new DataPolicy(),
            };
            // Make the request
            DataPolicy response = dataPolicyServiceClient.CreateDataPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataPolicyAsync</summary>
        public async Task CreateDataPolicyRequestObjectAsync()
        {
            // Snippet: CreateDataPolicyAsync(CreateDataPolicyRequest, CallSettings)
            // Additional: CreateDataPolicyAsync(CreateDataPolicyRequest, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataPolicyRequest request = new CreateDataPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataPolicy = new DataPolicy(),
            };
            // Make the request
            DataPolicy response = await dataPolicyServiceClient.CreateDataPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataPolicy</summary>
        public void CreateDataPolicy()
        {
            // Snippet: CreateDataPolicy(string, DataPolicy, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DataPolicy dataPolicy = new DataPolicy();
            // Make the request
            DataPolicy response = dataPolicyServiceClient.CreateDataPolicy(parent, dataPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateDataPolicyAsync</summary>
        public async Task CreateDataPolicyAsync()
        {
            // Snippet: CreateDataPolicyAsync(string, DataPolicy, CallSettings)
            // Additional: CreateDataPolicyAsync(string, DataPolicy, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DataPolicy dataPolicy = new DataPolicy();
            // Make the request
            DataPolicy response = await dataPolicyServiceClient.CreateDataPolicyAsync(parent, dataPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateDataPolicy</summary>
        public void CreateDataPolicyResourceNames()
        {
            // Snippet: CreateDataPolicy(LocationName, DataPolicy, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DataPolicy dataPolicy = new DataPolicy();
            // Make the request
            DataPolicy response = dataPolicyServiceClient.CreateDataPolicy(parent, dataPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateDataPolicyAsync</summary>
        public async Task CreateDataPolicyResourceNamesAsync()
        {
            // Snippet: CreateDataPolicyAsync(LocationName, DataPolicy, CallSettings)
            // Additional: CreateDataPolicyAsync(LocationName, DataPolicy, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DataPolicy dataPolicy = new DataPolicy();
            // Make the request
            DataPolicy response = await dataPolicyServiceClient.CreateDataPolicyAsync(parent, dataPolicy);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataPolicy</summary>
        public void UpdateDataPolicyRequestObject()
        {
            // Snippet: UpdateDataPolicy(UpdateDataPolicyRequest, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataPolicyRequest request = new UpdateDataPolicyRequest
            {
                DataPolicy = new DataPolicy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataPolicy response = dataPolicyServiceClient.UpdateDataPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataPolicyAsync</summary>
        public async Task UpdateDataPolicyRequestObjectAsync()
        {
            // Snippet: UpdateDataPolicyAsync(UpdateDataPolicyRequest, CallSettings)
            // Additional: UpdateDataPolicyAsync(UpdateDataPolicyRequest, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataPolicyRequest request = new UpdateDataPolicyRequest
            {
                DataPolicy = new DataPolicy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataPolicy response = await dataPolicyServiceClient.UpdateDataPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataPolicy</summary>
        public void UpdateDataPolicy()
        {
            // Snippet: UpdateDataPolicy(DataPolicy, FieldMask, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            DataPolicy dataPolicy = new DataPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataPolicy response = dataPolicyServiceClient.UpdateDataPolicy(dataPolicy, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataPolicyAsync</summary>
        public async Task UpdateDataPolicyAsync()
        {
            // Snippet: UpdateDataPolicyAsync(DataPolicy, FieldMask, CallSettings)
            // Additional: UpdateDataPolicyAsync(DataPolicy, FieldMask, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataPolicy dataPolicy = new DataPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataPolicy response = await dataPolicyServiceClient.UpdateDataPolicyAsync(dataPolicy, updateMask);
            // End snippet
        }

        /// <summary>Snippet for RenameDataPolicy</summary>
        public void RenameDataPolicyRequestObject()
        {
            // Snippet: RenameDataPolicy(RenameDataPolicyRequest, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            RenameDataPolicyRequest request = new RenameDataPolicyRequest
            {
                Name = "",
                NewDataPolicyId = "",
            };
            // Make the request
            DataPolicy response = dataPolicyServiceClient.RenameDataPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for RenameDataPolicyAsync</summary>
        public async Task RenameDataPolicyRequestObjectAsync()
        {
            // Snippet: RenameDataPolicyAsync(RenameDataPolicyRequest, CallSettings)
            // Additional: RenameDataPolicyAsync(RenameDataPolicyRequest, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            RenameDataPolicyRequest request = new RenameDataPolicyRequest
            {
                Name = "",
                NewDataPolicyId = "",
            };
            // Make the request
            DataPolicy response = await dataPolicyServiceClient.RenameDataPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenameDataPolicy</summary>
        public void RenameDataPolicy()
        {
            // Snippet: RenameDataPolicy(string, string, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            string newDataPolicyId = "";
            // Make the request
            DataPolicy response = dataPolicyServiceClient.RenameDataPolicy(name, newDataPolicyId);
            // End snippet
        }

        /// <summary>Snippet for RenameDataPolicyAsync</summary>
        public async Task RenameDataPolicyAsync()
        {
            // Snippet: RenameDataPolicyAsync(string, string, CallSettings)
            // Additional: RenameDataPolicyAsync(string, string, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            string newDataPolicyId = "";
            // Make the request
            DataPolicy response = await dataPolicyServiceClient.RenameDataPolicyAsync(name, newDataPolicyId);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataPolicy</summary>
        public void DeleteDataPolicyRequestObject()
        {
            // Snippet: DeleteDataPolicy(DeleteDataPolicyRequest, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            DeleteDataPolicyRequest request = new DeleteDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            // Make the request
            dataPolicyServiceClient.DeleteDataPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataPolicyAsync</summary>
        public async Task DeleteDataPolicyRequestObjectAsync()
        {
            // Snippet: DeleteDataPolicyAsync(DeleteDataPolicyRequest, CallSettings)
            // Additional: DeleteDataPolicyAsync(DeleteDataPolicyRequest, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDataPolicyRequest request = new DeleteDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            // Make the request
            await dataPolicyServiceClient.DeleteDataPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataPolicy</summary>
        public void DeleteDataPolicy()
        {
            // Snippet: DeleteDataPolicy(string, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataPolicies/[DATA_POLICY]";
            // Make the request
            dataPolicyServiceClient.DeleteDataPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataPolicyAsync</summary>
        public async Task DeleteDataPolicyAsync()
        {
            // Snippet: DeleteDataPolicyAsync(string, CallSettings)
            // Additional: DeleteDataPolicyAsync(string, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataPolicies/[DATA_POLICY]";
            // Make the request
            await dataPolicyServiceClient.DeleteDataPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataPolicy</summary>
        public void DeleteDataPolicyResourceNames()
        {
            // Snippet: DeleteDataPolicy(DataPolicyName, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            DataPolicyName name = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]");
            // Make the request
            dataPolicyServiceClient.DeleteDataPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataPolicyAsync</summary>
        public async Task DeleteDataPolicyResourceNamesAsync()
        {
            // Snippet: DeleteDataPolicyAsync(DataPolicyName, CallSettings)
            // Additional: DeleteDataPolicyAsync(DataPolicyName, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataPolicyName name = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]");
            // Make the request
            await dataPolicyServiceClient.DeleteDataPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataPolicy</summary>
        public void GetDataPolicyRequestObject()
        {
            // Snippet: GetDataPolicy(GetDataPolicyRequest, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            GetDataPolicyRequest request = new GetDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            // Make the request
            DataPolicy response = dataPolicyServiceClient.GetDataPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataPolicyAsync</summary>
        public async Task GetDataPolicyRequestObjectAsync()
        {
            // Snippet: GetDataPolicyAsync(GetDataPolicyRequest, CallSettings)
            // Additional: GetDataPolicyAsync(GetDataPolicyRequest, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataPolicyRequest request = new GetDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            // Make the request
            DataPolicy response = await dataPolicyServiceClient.GetDataPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataPolicy</summary>
        public void GetDataPolicy()
        {
            // Snippet: GetDataPolicy(string, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataPolicies/[DATA_POLICY]";
            // Make the request
            DataPolicy response = dataPolicyServiceClient.GetDataPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataPolicyAsync</summary>
        public async Task GetDataPolicyAsync()
        {
            // Snippet: GetDataPolicyAsync(string, CallSettings)
            // Additional: GetDataPolicyAsync(string, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataPolicies/[DATA_POLICY]";
            // Make the request
            DataPolicy response = await dataPolicyServiceClient.GetDataPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataPolicy</summary>
        public void GetDataPolicyResourceNames()
        {
            // Snippet: GetDataPolicy(DataPolicyName, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            DataPolicyName name = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]");
            // Make the request
            DataPolicy response = dataPolicyServiceClient.GetDataPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataPolicyAsync</summary>
        public async Task GetDataPolicyResourceNamesAsync()
        {
            // Snippet: GetDataPolicyAsync(DataPolicyName, CallSettings)
            // Additional: GetDataPolicyAsync(DataPolicyName, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataPolicyName name = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]");
            // Make the request
            DataPolicy response = await dataPolicyServiceClient.GetDataPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDataPolicies</summary>
        public void ListDataPoliciesRequestObject()
        {
            // Snippet: ListDataPolicies(ListDataPoliciesRequest, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            ListDataPoliciesRequest request = new ListDataPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDataPoliciesResponse, DataPolicy> response = dataPolicyServiceClient.ListDataPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataPoliciesAsync</summary>
        public async Task ListDataPoliciesRequestObjectAsync()
        {
            // Snippet: ListDataPoliciesAsync(ListDataPoliciesRequest, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataPoliciesRequest request = new ListDataPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDataPoliciesResponse, DataPolicy> response = dataPolicyServiceClient.ListDataPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataPolicies</summary>
        public void ListDataPolicies()
        {
            // Snippet: ListDataPolicies(string, string, int?, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDataPoliciesResponse, DataPolicy> response = dataPolicyServiceClient.ListDataPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataPoliciesAsync</summary>
        public async Task ListDataPoliciesAsync()
        {
            // Snippet: ListDataPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDataPoliciesResponse, DataPolicy> response = dataPolicyServiceClient.ListDataPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataPolicies</summary>
        public void ListDataPoliciesResourceNames()
        {
            // Snippet: ListDataPolicies(LocationName, string, int?, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDataPoliciesResponse, DataPolicy> response = dataPolicyServiceClient.ListDataPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataPoliciesAsync</summary>
        public async Task ListDataPoliciesResourceNamesAsync()
        {
            // Snippet: ListDataPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDataPoliciesResponse, DataPolicy> response = dataPolicyServiceClient.ListDataPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = dataPolicyServiceClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await dataPolicyServiceClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = dataPolicyServiceClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await dataPolicyServiceClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = DataPolicyServiceClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = dataPolicyServiceClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await dataPolicyServiceClient.TestIamPermissionsAsync(request);
            // End snippet
        }
    }
}
