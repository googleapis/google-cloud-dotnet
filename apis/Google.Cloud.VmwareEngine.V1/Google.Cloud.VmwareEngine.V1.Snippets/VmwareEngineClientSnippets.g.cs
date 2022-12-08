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

namespace Google.Cloud.VmwareEngine.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedVmwareEngineClientSnippets
    {
        /// <summary>Snippet for ListPrivateClouds</summary>
        public void ListPrivateCloudsRequestObject()
        {
            // Snippet: ListPrivateClouds(ListPrivateCloudsRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListPrivateCloudsRequest request = new ListPrivateCloudsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListPrivateCloudsResponse, PrivateCloud> response = vmwareEngineClient.ListPrivateClouds(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateCloud item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateCloudsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateCloud item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateCloud> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateCloud item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateCloudsAsync</summary>
        public async Task ListPrivateCloudsRequestObjectAsync()
        {
            // Snippet: ListPrivateCloudsAsync(ListPrivateCloudsRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListPrivateCloudsRequest request = new ListPrivateCloudsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPrivateCloudsResponse, PrivateCloud> response = vmwareEngineClient.ListPrivateCloudsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateCloud item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateCloudsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateCloud item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateCloud> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateCloud item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateClouds</summary>
        public void ListPrivateClouds()
        {
            // Snippet: ListPrivateClouds(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPrivateCloudsResponse, PrivateCloud> response = vmwareEngineClient.ListPrivateClouds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateCloud item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateCloudsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateCloud item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateCloud> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateCloud item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateCloudsAsync</summary>
        public async Task ListPrivateCloudsAsync()
        {
            // Snippet: ListPrivateCloudsAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPrivateCloudsResponse, PrivateCloud> response = vmwareEngineClient.ListPrivateCloudsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateCloud item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateCloudsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateCloud item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateCloud> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateCloud item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateClouds</summary>
        public void ListPrivateCloudsResourceNames()
        {
            // Snippet: ListPrivateClouds(LocationName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPrivateCloudsResponse, PrivateCloud> response = vmwareEngineClient.ListPrivateClouds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateCloud item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateCloudsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateCloud item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateCloud> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateCloud item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateCloudsAsync</summary>
        public async Task ListPrivateCloudsResourceNamesAsync()
        {
            // Snippet: ListPrivateCloudsAsync(LocationName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPrivateCloudsResponse, PrivateCloud> response = vmwareEngineClient.ListPrivateCloudsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateCloud item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateCloudsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateCloud item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateCloud> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateCloud item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPrivateCloud</summary>
        public void GetPrivateCloudRequestObject()
        {
            // Snippet: GetPrivateCloud(GetPrivateCloudRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetPrivateCloudRequest request = new GetPrivateCloudRequest
            {
                PrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
            };
            // Make the request
            PrivateCloud response = vmwareEngineClient.GetPrivateCloud(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateCloudAsync</summary>
        public async Task GetPrivateCloudRequestObjectAsync()
        {
            // Snippet: GetPrivateCloudAsync(GetPrivateCloudRequest, CallSettings)
            // Additional: GetPrivateCloudAsync(GetPrivateCloudRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetPrivateCloudRequest request = new GetPrivateCloudRequest
            {
                PrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
            };
            // Make the request
            PrivateCloud response = await vmwareEngineClient.GetPrivateCloudAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateCloud</summary>
        public void GetPrivateCloud()
        {
            // Snippet: GetPrivateCloud(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            PrivateCloud response = vmwareEngineClient.GetPrivateCloud(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateCloudAsync</summary>
        public async Task GetPrivateCloudAsync()
        {
            // Snippet: GetPrivateCloudAsync(string, CallSettings)
            // Additional: GetPrivateCloudAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            PrivateCloud response = await vmwareEngineClient.GetPrivateCloudAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateCloud</summary>
        public void GetPrivateCloudResourceNames()
        {
            // Snippet: GetPrivateCloud(PrivateCloudName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName name = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            PrivateCloud response = vmwareEngineClient.GetPrivateCloud(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateCloudAsync</summary>
        public async Task GetPrivateCloudResourceNamesAsync()
        {
            // Snippet: GetPrivateCloudAsync(PrivateCloudName, CallSettings)
            // Additional: GetPrivateCloudAsync(PrivateCloudName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName name = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            PrivateCloud response = await vmwareEngineClient.GetPrivateCloudAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateCloud</summary>
        public void CreatePrivateCloudRequestObject()
        {
            // Snippet: CreatePrivateCloud(CreatePrivateCloudRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            CreatePrivateCloudRequest request = new CreatePrivateCloudRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PrivateCloudId = "",
                PrivateCloud = new PrivateCloud(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.CreatePrivateCloud(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreatePrivateCloud(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateCloudAsync</summary>
        public async Task CreatePrivateCloudRequestObjectAsync()
        {
            // Snippet: CreatePrivateCloudAsync(CreatePrivateCloudRequest, CallSettings)
            // Additional: CreatePrivateCloudAsync(CreatePrivateCloudRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            CreatePrivateCloudRequest request = new CreatePrivateCloudRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PrivateCloudId = "",
                PrivateCloud = new PrivateCloud(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.CreatePrivateCloudAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreatePrivateCloudAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateCloud</summary>
        public void CreatePrivateCloud()
        {
            // Snippet: CreatePrivateCloud(string, PrivateCloud, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PrivateCloud privateCloud = new PrivateCloud();
            string privateCloudId = "";
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.CreatePrivateCloud(parent, privateCloud, privateCloudId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreatePrivateCloud(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateCloudAsync</summary>
        public async Task CreatePrivateCloudAsync()
        {
            // Snippet: CreatePrivateCloudAsync(string, PrivateCloud, string, CallSettings)
            // Additional: CreatePrivateCloudAsync(string, PrivateCloud, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PrivateCloud privateCloud = new PrivateCloud();
            string privateCloudId = "";
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.CreatePrivateCloudAsync(parent, privateCloud, privateCloudId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreatePrivateCloudAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateCloud</summary>
        public void CreatePrivateCloudResourceNames()
        {
            // Snippet: CreatePrivateCloud(LocationName, PrivateCloud, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PrivateCloud privateCloud = new PrivateCloud();
            string privateCloudId = "";
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.CreatePrivateCloud(parent, privateCloud, privateCloudId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreatePrivateCloud(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateCloudAsync</summary>
        public async Task CreatePrivateCloudResourceNamesAsync()
        {
            // Snippet: CreatePrivateCloudAsync(LocationName, PrivateCloud, string, CallSettings)
            // Additional: CreatePrivateCloudAsync(LocationName, PrivateCloud, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PrivateCloud privateCloud = new PrivateCloud();
            string privateCloudId = "";
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.CreatePrivateCloudAsync(parent, privateCloud, privateCloudId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreatePrivateCloudAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateCloud</summary>
        public void UpdatePrivateCloudRequestObject()
        {
            // Snippet: UpdatePrivateCloud(UpdatePrivateCloudRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            UpdatePrivateCloudRequest request = new UpdatePrivateCloudRequest
            {
                PrivateCloud = new PrivateCloud(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.UpdatePrivateCloud(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdatePrivateCloud(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateCloudAsync</summary>
        public async Task UpdatePrivateCloudRequestObjectAsync()
        {
            // Snippet: UpdatePrivateCloudAsync(UpdatePrivateCloudRequest, CallSettings)
            // Additional: UpdatePrivateCloudAsync(UpdatePrivateCloudRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePrivateCloudRequest request = new UpdatePrivateCloudRequest
            {
                PrivateCloud = new PrivateCloud(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.UpdatePrivateCloudAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdatePrivateCloudAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateCloud</summary>
        public void UpdatePrivateCloud()
        {
            // Snippet: UpdatePrivateCloud(PrivateCloud, FieldMask, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloud privateCloud = new PrivateCloud();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.UpdatePrivateCloud(privateCloud, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdatePrivateCloud(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateCloudAsync</summary>
        public async Task UpdatePrivateCloudAsync()
        {
            // Snippet: UpdatePrivateCloudAsync(PrivateCloud, FieldMask, CallSettings)
            // Additional: UpdatePrivateCloudAsync(PrivateCloud, FieldMask, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloud privateCloud = new PrivateCloud();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.UpdatePrivateCloudAsync(privateCloud, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdatePrivateCloudAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateCloud</summary>
        public void DeletePrivateCloudRequestObject()
        {
            // Snippet: DeletePrivateCloud(DeletePrivateCloudRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DeletePrivateCloudRequest request = new DeletePrivateCloudRequest
            {
                PrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                RequestId = "",
                Force = false,
                DelayHours = 0,
            };
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.DeletePrivateCloud(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeletePrivateCloud(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateCloudAsync</summary>
        public async Task DeletePrivateCloudRequestObjectAsync()
        {
            // Snippet: DeletePrivateCloudAsync(DeletePrivateCloudRequest, CallSettings)
            // Additional: DeletePrivateCloudAsync(DeletePrivateCloudRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DeletePrivateCloudRequest request = new DeletePrivateCloudRequest
            {
                PrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                RequestId = "",
                Force = false,
                DelayHours = 0,
            };
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.DeletePrivateCloudAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeletePrivateCloudAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateCloud</summary>
        public void DeletePrivateCloud()
        {
            // Snippet: DeletePrivateCloud(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.DeletePrivateCloud(name);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeletePrivateCloud(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateCloudAsync</summary>
        public async Task DeletePrivateCloudAsync()
        {
            // Snippet: DeletePrivateCloudAsync(string, CallSettings)
            // Additional: DeletePrivateCloudAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.DeletePrivateCloudAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeletePrivateCloudAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateCloud</summary>
        public void DeletePrivateCloudResourceNames()
        {
            // Snippet: DeletePrivateCloud(PrivateCloudName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName name = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.DeletePrivateCloud(name);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeletePrivateCloud(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateCloudAsync</summary>
        public async Task DeletePrivateCloudResourceNamesAsync()
        {
            // Snippet: DeletePrivateCloudAsync(PrivateCloudName, CallSettings)
            // Additional: DeletePrivateCloudAsync(PrivateCloudName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName name = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.DeletePrivateCloudAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeletePrivateCloudAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeletePrivateCloud</summary>
        public void UndeletePrivateCloudRequestObject()
        {
            // Snippet: UndeletePrivateCloud(UndeletePrivateCloudRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            UndeletePrivateCloudRequest request = new UndeletePrivateCloudRequest
            {
                PrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                RequestId = "",
            };
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.UndeletePrivateCloud(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUndeletePrivateCloud(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeletePrivateCloudAsync</summary>
        public async Task UndeletePrivateCloudRequestObjectAsync()
        {
            // Snippet: UndeletePrivateCloudAsync(UndeletePrivateCloudRequest, CallSettings)
            // Additional: UndeletePrivateCloudAsync(UndeletePrivateCloudRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            UndeletePrivateCloudRequest request = new UndeletePrivateCloudRequest
            {
                PrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                RequestId = "",
            };
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.UndeletePrivateCloudAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUndeletePrivateCloudAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeletePrivateCloud</summary>
        public void UndeletePrivateCloud()
        {
            // Snippet: UndeletePrivateCloud(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.UndeletePrivateCloud(name);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUndeletePrivateCloud(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeletePrivateCloudAsync</summary>
        public async Task UndeletePrivateCloudAsync()
        {
            // Snippet: UndeletePrivateCloudAsync(string, CallSettings)
            // Additional: UndeletePrivateCloudAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.UndeletePrivateCloudAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUndeletePrivateCloudAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeletePrivateCloud</summary>
        public void UndeletePrivateCloudResourceNames()
        {
            // Snippet: UndeletePrivateCloud(PrivateCloudName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName name = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.UndeletePrivateCloud(name);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUndeletePrivateCloud(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeletePrivateCloudAsync</summary>
        public async Task UndeletePrivateCloudResourceNamesAsync()
        {
            // Snippet: UndeletePrivateCloudAsync(PrivateCloudName, CallSettings)
            // Additional: UndeletePrivateCloudAsync(PrivateCloudName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName name = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.UndeletePrivateCloudAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUndeletePrivateCloudAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClustersRequestObject()
        {
            // Snippet: ListClusters(ListClustersRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = vmwareEngineClient.ListClusters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Cluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Cluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Cluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Cluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersRequestObjectAsync()
        {
            // Snippet: ListClustersAsync(ListClustersRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = vmwareEngineClient.ListClustersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Cluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Cluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Cluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Cluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClusters()
        {
            // Snippet: ListClusters(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = vmwareEngineClient.ListClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Cluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Cluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Cluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Cluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersAsync()
        {
            // Snippet: ListClustersAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = vmwareEngineClient.ListClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Cluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Cluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Cluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Cluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClustersResourceNames()
        {
            // Snippet: ListClusters(PrivateCloudName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = vmwareEngineClient.ListClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Cluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Cluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Cluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Cluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersResourceNamesAsync()
        {
            // Snippet: ListClustersAsync(PrivateCloudName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = vmwareEngineClient.ListClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Cluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Cluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Cluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Cluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetClusterRequestObject()
        {
            // Snippet: GetCluster(GetClusterRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationPrivateCloudCluster("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]"),
            };
            // Make the request
            Cluster response = vmwareEngineClient.GetCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterRequestObjectAsync()
        {
            // Snippet: GetClusterAsync(GetClusterRequest, CallSettings)
            // Additional: GetClusterAsync(GetClusterRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationPrivateCloudCluster("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]"),
            };
            // Make the request
            Cluster response = await vmwareEngineClient.GetClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster()
        {
            // Snippet: GetCluster(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/clusters/[CLUSTER]";
            // Make the request
            Cluster response = vmwareEngineClient.GetCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterAsync()
        {
            // Snippet: GetClusterAsync(string, CallSettings)
            // Additional: GetClusterAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/clusters/[CLUSTER]";
            // Make the request
            Cluster response = await vmwareEngineClient.GetClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetClusterResourceNames()
        {
            // Snippet: GetCluster(ClusterName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationPrivateCloudCluster("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]");
            // Make the request
            Cluster response = vmwareEngineClient.GetCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterResourceNamesAsync()
        {
            // Snippet: GetClusterAsync(ClusterName, CallSettings)
            // Additional: GetClusterAsync(ClusterName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationPrivateCloudCluster("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]");
            // Make the request
            Cluster response = await vmwareEngineClient.GetClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateClusterRequestObject()
        {
            // Snippet: CreateCluster(CreateClusterRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                ClusterId = "",
                Cluster = new Cluster(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = vmwareEngineClient.CreateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterRequestObjectAsync()
        {
            // Snippet: CreateClusterAsync(CreateClusterRequest, CallSettings)
            // Additional: CreateClusterAsync(CreateClusterRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                ClusterId = "",
                Cluster = new Cluster(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = await vmwareEngineClient.CreateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateCluster()
        {
            // Snippet: CreateCluster(string, Cluster, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = vmwareEngineClient.CreateCluster(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterAsync()
        {
            // Snippet: CreateClusterAsync(string, Cluster, string, CallSettings)
            // Additional: CreateClusterAsync(string, Cluster, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = await vmwareEngineClient.CreateClusterAsync(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateClusterResourceNames()
        {
            // Snippet: CreateCluster(PrivateCloudName, Cluster, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = vmwareEngineClient.CreateCluster(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterResourceNamesAsync()
        {
            // Snippet: CreateClusterAsync(PrivateCloudName, Cluster, string, CallSettings)
            // Additional: CreateClusterAsync(PrivateCloudName, Cluster, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = await vmwareEngineClient.CreateClusterAsync(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateClusterRequestObject()
        {
            // Snippet: UpdateCluster(UpdateClusterRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                UpdateMask = new FieldMask(),
                Cluster = new Cluster(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = vmwareEngineClient.UpdateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClusterAsync</summary>
        public async Task UpdateClusterRequestObjectAsync()
        {
            // Snippet: UpdateClusterAsync(UpdateClusterRequest, CallSettings)
            // Additional: UpdateClusterAsync(UpdateClusterRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                UpdateMask = new FieldMask(),
                Cluster = new Cluster(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = await vmwareEngineClient.UpdateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateCluster()
        {
            // Snippet: UpdateCluster(Cluster, FieldMask, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            Cluster cluster = new Cluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Cluster, OperationMetadata> response = vmwareEngineClient.UpdateCluster(cluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClusterAsync</summary>
        public async Task UpdateClusterAsync()
        {
            // Snippet: UpdateClusterAsync(Cluster, FieldMask, CallSettings)
            // Additional: UpdateClusterAsync(Cluster, FieldMask, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            Cluster cluster = new Cluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Cluster, OperationMetadata> response = await vmwareEngineClient.UpdateClusterAsync(cluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteClusterRequestObject()
        {
            // Snippet: DeleteCluster(DeleteClusterRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationPrivateCloudCluster("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterRequestObjectAsync()
        {
            // Snippet: DeleteClusterAsync(DeleteClusterRequest, CallSettings)
            // Additional: DeleteClusterAsync(DeleteClusterRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationPrivateCloudCluster("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteCluster()
        {
            // Snippet: DeleteCluster(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/clusters/[CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterAsync()
        {
            // Snippet: DeleteClusterAsync(string, CallSettings)
            // Additional: DeleteClusterAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/clusters/[CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteClusterResourceNames()
        {
            // Snippet: DeleteCluster(ClusterName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationPrivateCloudCluster("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterResourceNamesAsync()
        {
            // Snippet: DeleteClusterAsync(ClusterName, CallSettings)
            // Additional: DeleteClusterAsync(ClusterName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationPrivateCloudCluster("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListSubnets</summary>
        public void ListSubnetsRequestObject()
        {
            // Snippet: ListSubnets(ListSubnetsRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListSubnetsRequest request = new ListSubnetsRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
            };
            // Make the request
            PagedEnumerable<ListSubnetsResponse, Subnet> response = vmwareEngineClient.ListSubnets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subnet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubnetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubnetsAsync</summary>
        public async Task ListSubnetsRequestObjectAsync()
        {
            // Snippet: ListSubnetsAsync(ListSubnetsRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListSubnetsRequest request = new ListSubnetsRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSubnetsResponse, Subnet> response = vmwareEngineClient.ListSubnetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subnet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubnetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubnets</summary>
        public void ListSubnets()
        {
            // Snippet: ListSubnets(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            PagedEnumerable<ListSubnetsResponse, Subnet> response = vmwareEngineClient.ListSubnets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subnet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubnetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubnetsAsync</summary>
        public async Task ListSubnetsAsync()
        {
            // Snippet: ListSubnetsAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            PagedAsyncEnumerable<ListSubnetsResponse, Subnet> response = vmwareEngineClient.ListSubnetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subnet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubnetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubnets</summary>
        public void ListSubnetsResourceNames()
        {
            // Snippet: ListSubnets(PrivateCloudName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            PagedEnumerable<ListSubnetsResponse, Subnet> response = vmwareEngineClient.ListSubnets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subnet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubnetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubnetsAsync</summary>
        public async Task ListSubnetsResourceNamesAsync()
        {
            // Snippet: ListSubnetsAsync(PrivateCloudName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            PagedAsyncEnumerable<ListSubnetsResponse, Subnet> response = vmwareEngineClient.ListSubnetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subnet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubnetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodeTypes</summary>
        public void ListNodeTypesRequestObject()
        {
            // Snippet: ListNodeTypes(ListNodeTypesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListNodeTypesRequest request = new ListNodeTypesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListNodeTypesResponse, NodeType> response = vmwareEngineClient.ListNodeTypes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NodeType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNodeTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NodeType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NodeType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NodeType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodeTypesAsync</summary>
        public async Task ListNodeTypesRequestObjectAsync()
        {
            // Snippet: ListNodeTypesAsync(ListNodeTypesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListNodeTypesRequest request = new ListNodeTypesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListNodeTypesResponse, NodeType> response = vmwareEngineClient.ListNodeTypesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NodeType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNodeTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NodeType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NodeType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NodeType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodeTypes</summary>
        public void ListNodeTypes()
        {
            // Snippet: ListNodeTypes(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListNodeTypesResponse, NodeType> response = vmwareEngineClient.ListNodeTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NodeType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNodeTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NodeType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NodeType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NodeType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodeTypesAsync</summary>
        public async Task ListNodeTypesAsync()
        {
            // Snippet: ListNodeTypesAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListNodeTypesResponse, NodeType> response = vmwareEngineClient.ListNodeTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NodeType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNodeTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NodeType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NodeType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NodeType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodeTypes</summary>
        public void ListNodeTypesResourceNames()
        {
            // Snippet: ListNodeTypes(LocationName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNodeTypesResponse, NodeType> response = vmwareEngineClient.ListNodeTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NodeType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNodeTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NodeType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NodeType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NodeType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodeTypesAsync</summary>
        public async Task ListNodeTypesResourceNamesAsync()
        {
            // Snippet: ListNodeTypesAsync(LocationName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNodeTypesResponse, NodeType> response = vmwareEngineClient.ListNodeTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NodeType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNodeTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NodeType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NodeType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NodeType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNodeType</summary>
        public void GetNodeTypeRequestObject()
        {
            // Snippet: GetNodeType(GetNodeTypeRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetNodeTypeRequest request = new GetNodeTypeRequest
            {
                NodeTypeName = NodeTypeName.FromProjectLocationNodeType("[PROJECT]", "[LOCATION]", "[NODE_TYPE]"),
            };
            // Make the request
            NodeType response = vmwareEngineClient.GetNodeType(request);
            // End snippet
        }

        /// <summary>Snippet for GetNodeTypeAsync</summary>
        public async Task GetNodeTypeRequestObjectAsync()
        {
            // Snippet: GetNodeTypeAsync(GetNodeTypeRequest, CallSettings)
            // Additional: GetNodeTypeAsync(GetNodeTypeRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetNodeTypeRequest request = new GetNodeTypeRequest
            {
                NodeTypeName = NodeTypeName.FromProjectLocationNodeType("[PROJECT]", "[LOCATION]", "[NODE_TYPE]"),
            };
            // Make the request
            NodeType response = await vmwareEngineClient.GetNodeTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNodeType</summary>
        public void GetNodeType()
        {
            // Snippet: GetNodeType(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nodeTypes/[NODE_TYPE]";
            // Make the request
            NodeType response = vmwareEngineClient.GetNodeType(name);
            // End snippet
        }

        /// <summary>Snippet for GetNodeTypeAsync</summary>
        public async Task GetNodeTypeAsync()
        {
            // Snippet: GetNodeTypeAsync(string, CallSettings)
            // Additional: GetNodeTypeAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nodeTypes/[NODE_TYPE]";
            // Make the request
            NodeType response = await vmwareEngineClient.GetNodeTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNodeType</summary>
        public void GetNodeTypeResourceNames()
        {
            // Snippet: GetNodeType(NodeTypeName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            NodeTypeName name = NodeTypeName.FromProjectLocationNodeType("[PROJECT]", "[LOCATION]", "[NODE_TYPE]");
            // Make the request
            NodeType response = vmwareEngineClient.GetNodeType(name);
            // End snippet
        }

        /// <summary>Snippet for GetNodeTypeAsync</summary>
        public async Task GetNodeTypeResourceNamesAsync()
        {
            // Snippet: GetNodeTypeAsync(NodeTypeName, CallSettings)
            // Additional: GetNodeTypeAsync(NodeTypeName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            NodeTypeName name = NodeTypeName.FromProjectLocationNodeType("[PROJECT]", "[LOCATION]", "[NODE_TYPE]");
            // Make the request
            NodeType response = await vmwareEngineClient.GetNodeTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ShowNsxCredentials</summary>
        public void ShowNsxCredentialsRequestObject()
        {
            // Snippet: ShowNsxCredentials(ShowNsxCredentialsRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ShowNsxCredentialsRequest request = new ShowNsxCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
            };
            // Make the request
            Credentials response = vmwareEngineClient.ShowNsxCredentials(request);
            // End snippet
        }

        /// <summary>Snippet for ShowNsxCredentialsAsync</summary>
        public async Task ShowNsxCredentialsRequestObjectAsync()
        {
            // Snippet: ShowNsxCredentialsAsync(ShowNsxCredentialsRequest, CallSettings)
            // Additional: ShowNsxCredentialsAsync(ShowNsxCredentialsRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ShowNsxCredentialsRequest request = new ShowNsxCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
            };
            // Make the request
            Credentials response = await vmwareEngineClient.ShowNsxCredentialsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ShowNsxCredentials</summary>
        public void ShowNsxCredentials()
        {
            // Snippet: ShowNsxCredentials(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string privateCloud = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            Credentials response = vmwareEngineClient.ShowNsxCredentials(privateCloud);
            // End snippet
        }

        /// <summary>Snippet for ShowNsxCredentialsAsync</summary>
        public async Task ShowNsxCredentialsAsync()
        {
            // Snippet: ShowNsxCredentialsAsync(string, CallSettings)
            // Additional: ShowNsxCredentialsAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string privateCloud = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            Credentials response = await vmwareEngineClient.ShowNsxCredentialsAsync(privateCloud);
            // End snippet
        }

        /// <summary>Snippet for ShowNsxCredentials</summary>
        public void ShowNsxCredentialsResourceNames()
        {
            // Snippet: ShowNsxCredentials(PrivateCloudName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName privateCloud = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            Credentials response = vmwareEngineClient.ShowNsxCredentials(privateCloud);
            // End snippet
        }

        /// <summary>Snippet for ShowNsxCredentialsAsync</summary>
        public async Task ShowNsxCredentialsResourceNamesAsync()
        {
            // Snippet: ShowNsxCredentialsAsync(PrivateCloudName, CallSettings)
            // Additional: ShowNsxCredentialsAsync(PrivateCloudName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName privateCloud = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            Credentials response = await vmwareEngineClient.ShowNsxCredentialsAsync(privateCloud);
            // End snippet
        }

        /// <summary>Snippet for ShowVcenterCredentials</summary>
        public void ShowVcenterCredentialsRequestObject()
        {
            // Snippet: ShowVcenterCredentials(ShowVcenterCredentialsRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ShowVcenterCredentialsRequest request = new ShowVcenterCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
            };
            // Make the request
            Credentials response = vmwareEngineClient.ShowVcenterCredentials(request);
            // End snippet
        }

        /// <summary>Snippet for ShowVcenterCredentialsAsync</summary>
        public async Task ShowVcenterCredentialsRequestObjectAsync()
        {
            // Snippet: ShowVcenterCredentialsAsync(ShowVcenterCredentialsRequest, CallSettings)
            // Additional: ShowVcenterCredentialsAsync(ShowVcenterCredentialsRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ShowVcenterCredentialsRequest request = new ShowVcenterCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
            };
            // Make the request
            Credentials response = await vmwareEngineClient.ShowVcenterCredentialsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ShowVcenterCredentials</summary>
        public void ShowVcenterCredentials()
        {
            // Snippet: ShowVcenterCredentials(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string privateCloud = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            Credentials response = vmwareEngineClient.ShowVcenterCredentials(privateCloud);
            // End snippet
        }

        /// <summary>Snippet for ShowVcenterCredentialsAsync</summary>
        public async Task ShowVcenterCredentialsAsync()
        {
            // Snippet: ShowVcenterCredentialsAsync(string, CallSettings)
            // Additional: ShowVcenterCredentialsAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string privateCloud = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            Credentials response = await vmwareEngineClient.ShowVcenterCredentialsAsync(privateCloud);
            // End snippet
        }

        /// <summary>Snippet for ShowVcenterCredentials</summary>
        public void ShowVcenterCredentialsResourceNames()
        {
            // Snippet: ShowVcenterCredentials(PrivateCloudName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName privateCloud = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            Credentials response = vmwareEngineClient.ShowVcenterCredentials(privateCloud);
            // End snippet
        }

        /// <summary>Snippet for ShowVcenterCredentialsAsync</summary>
        public async Task ShowVcenterCredentialsResourceNamesAsync()
        {
            // Snippet: ShowVcenterCredentialsAsync(PrivateCloudName, CallSettings)
            // Additional: ShowVcenterCredentialsAsync(PrivateCloudName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName privateCloud = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            Credentials response = await vmwareEngineClient.ShowVcenterCredentialsAsync(privateCloud);
            // End snippet
        }

        /// <summary>Snippet for ResetNsxCredentials</summary>
        public void ResetNsxCredentialsRequestObject()
        {
            // Snippet: ResetNsxCredentials(ResetNsxCredentialsRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ResetNsxCredentialsRequest request = new ResetNsxCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                RequestId = "",
            };
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.ResetNsxCredentials(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceResetNsxCredentials(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetNsxCredentialsAsync</summary>
        public async Task ResetNsxCredentialsRequestObjectAsync()
        {
            // Snippet: ResetNsxCredentialsAsync(ResetNsxCredentialsRequest, CallSettings)
            // Additional: ResetNsxCredentialsAsync(ResetNsxCredentialsRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ResetNsxCredentialsRequest request = new ResetNsxCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                RequestId = "",
            };
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.ResetNsxCredentialsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceResetNsxCredentialsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetNsxCredentials</summary>
        public void ResetNsxCredentials()
        {
            // Snippet: ResetNsxCredentials(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string privateCloud = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.ResetNsxCredentials(privateCloud);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceResetNsxCredentials(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetNsxCredentialsAsync</summary>
        public async Task ResetNsxCredentialsAsync()
        {
            // Snippet: ResetNsxCredentialsAsync(string, CallSettings)
            // Additional: ResetNsxCredentialsAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string privateCloud = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.ResetNsxCredentialsAsync(privateCloud);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceResetNsxCredentialsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetNsxCredentials</summary>
        public void ResetNsxCredentialsResourceNames()
        {
            // Snippet: ResetNsxCredentials(PrivateCloudName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName privateCloud = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.ResetNsxCredentials(privateCloud);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceResetNsxCredentials(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetNsxCredentialsAsync</summary>
        public async Task ResetNsxCredentialsResourceNamesAsync()
        {
            // Snippet: ResetNsxCredentialsAsync(PrivateCloudName, CallSettings)
            // Additional: ResetNsxCredentialsAsync(PrivateCloudName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName privateCloud = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.ResetNsxCredentialsAsync(privateCloud);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceResetNsxCredentialsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetVcenterCredentials</summary>
        public void ResetVcenterCredentialsRequestObject()
        {
            // Snippet: ResetVcenterCredentials(ResetVcenterCredentialsRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ResetVcenterCredentialsRequest request = new ResetVcenterCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                RequestId = "",
            };
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.ResetVcenterCredentials(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceResetVcenterCredentials(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetVcenterCredentialsAsync</summary>
        public async Task ResetVcenterCredentialsRequestObjectAsync()
        {
            // Snippet: ResetVcenterCredentialsAsync(ResetVcenterCredentialsRequest, CallSettings)
            // Additional: ResetVcenterCredentialsAsync(ResetVcenterCredentialsRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ResetVcenterCredentialsRequest request = new ResetVcenterCredentialsRequest
            {
                PrivateCloudAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                RequestId = "",
            };
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.ResetVcenterCredentialsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceResetVcenterCredentialsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetVcenterCredentials</summary>
        public void ResetVcenterCredentials()
        {
            // Snippet: ResetVcenterCredentials(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string privateCloud = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.ResetVcenterCredentials(privateCloud);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceResetVcenterCredentials(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetVcenterCredentialsAsync</summary>
        public async Task ResetVcenterCredentialsAsync()
        {
            // Snippet: ResetVcenterCredentialsAsync(string, CallSettings)
            // Additional: ResetVcenterCredentialsAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string privateCloud = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.ResetVcenterCredentialsAsync(privateCloud);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceResetVcenterCredentialsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetVcenterCredentials</summary>
        public void ResetVcenterCredentialsResourceNames()
        {
            // Snippet: ResetVcenterCredentials(PrivateCloudName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName privateCloud = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = vmwareEngineClient.ResetVcenterCredentials(privateCloud);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceResetVcenterCredentials(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetVcenterCredentialsAsync</summary>
        public async Task ResetVcenterCredentialsResourceNamesAsync()
        {
            // Snippet: ResetVcenterCredentialsAsync(PrivateCloudName, CallSettings)
            // Additional: ResetVcenterCredentialsAsync(PrivateCloudName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName privateCloud = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            Operation<PrivateCloud, OperationMetadata> response = await vmwareEngineClient.ResetVcenterCredentialsAsync(privateCloud);

            // Poll until the returned long-running operation is complete
            Operation<PrivateCloud, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateCloud result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateCloud, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceResetVcenterCredentialsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateCloud retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHcxActivationKey</summary>
        public void CreateHcxActivationKeyRequestObject()
        {
            // Snippet: CreateHcxActivationKey(CreateHcxActivationKeyRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            CreateHcxActivationKeyRequest request = new CreateHcxActivationKeyRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                HcxActivationKey = new HcxActivationKey(),
                HcxActivationKeyId = "",
                RequestId = "",
            };
            // Make the request
            Operation<HcxActivationKey, OperationMetadata> response = vmwareEngineClient.CreateHcxActivationKey(request);

            // Poll until the returned long-running operation is complete
            Operation<HcxActivationKey, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            HcxActivationKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HcxActivationKey, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateHcxActivationKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HcxActivationKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHcxActivationKeyAsync</summary>
        public async Task CreateHcxActivationKeyRequestObjectAsync()
        {
            // Snippet: CreateHcxActivationKeyAsync(CreateHcxActivationKeyRequest, CallSettings)
            // Additional: CreateHcxActivationKeyAsync(CreateHcxActivationKeyRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            CreateHcxActivationKeyRequest request = new CreateHcxActivationKeyRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                HcxActivationKey = new HcxActivationKey(),
                HcxActivationKeyId = "",
                RequestId = "",
            };
            // Make the request
            Operation<HcxActivationKey, OperationMetadata> response = await vmwareEngineClient.CreateHcxActivationKeyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<HcxActivationKey, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            HcxActivationKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HcxActivationKey, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateHcxActivationKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HcxActivationKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHcxActivationKey</summary>
        public void CreateHcxActivationKey()
        {
            // Snippet: CreateHcxActivationKey(string, HcxActivationKey, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            HcxActivationKey hcxActivationKey = new HcxActivationKey();
            string hcxActivationKeyId = "";
            // Make the request
            Operation<HcxActivationKey, OperationMetadata> response = vmwareEngineClient.CreateHcxActivationKey(parent, hcxActivationKey, hcxActivationKeyId);

            // Poll until the returned long-running operation is complete
            Operation<HcxActivationKey, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            HcxActivationKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HcxActivationKey, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateHcxActivationKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HcxActivationKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHcxActivationKeyAsync</summary>
        public async Task CreateHcxActivationKeyAsync()
        {
            // Snippet: CreateHcxActivationKeyAsync(string, HcxActivationKey, string, CallSettings)
            // Additional: CreateHcxActivationKeyAsync(string, HcxActivationKey, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            HcxActivationKey hcxActivationKey = new HcxActivationKey();
            string hcxActivationKeyId = "";
            // Make the request
            Operation<HcxActivationKey, OperationMetadata> response = await vmwareEngineClient.CreateHcxActivationKeyAsync(parent, hcxActivationKey, hcxActivationKeyId);

            // Poll until the returned long-running operation is complete
            Operation<HcxActivationKey, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            HcxActivationKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HcxActivationKey, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateHcxActivationKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HcxActivationKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHcxActivationKey</summary>
        public void CreateHcxActivationKeyResourceNames()
        {
            // Snippet: CreateHcxActivationKey(PrivateCloudName, HcxActivationKey, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            HcxActivationKey hcxActivationKey = new HcxActivationKey();
            string hcxActivationKeyId = "";
            // Make the request
            Operation<HcxActivationKey, OperationMetadata> response = vmwareEngineClient.CreateHcxActivationKey(parent, hcxActivationKey, hcxActivationKeyId);

            // Poll until the returned long-running operation is complete
            Operation<HcxActivationKey, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            HcxActivationKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HcxActivationKey, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateHcxActivationKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HcxActivationKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHcxActivationKeyAsync</summary>
        public async Task CreateHcxActivationKeyResourceNamesAsync()
        {
            // Snippet: CreateHcxActivationKeyAsync(PrivateCloudName, HcxActivationKey, string, CallSettings)
            // Additional: CreateHcxActivationKeyAsync(PrivateCloudName, HcxActivationKey, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            HcxActivationKey hcxActivationKey = new HcxActivationKey();
            string hcxActivationKeyId = "";
            // Make the request
            Operation<HcxActivationKey, OperationMetadata> response = await vmwareEngineClient.CreateHcxActivationKeyAsync(parent, hcxActivationKey, hcxActivationKeyId);

            // Poll until the returned long-running operation is complete
            Operation<HcxActivationKey, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            HcxActivationKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HcxActivationKey, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateHcxActivationKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HcxActivationKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListHcxActivationKeys</summary>
        public void ListHcxActivationKeysRequestObject()
        {
            // Snippet: ListHcxActivationKeys(ListHcxActivationKeysRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListHcxActivationKeysRequest request = new ListHcxActivationKeysRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
            };
            // Make the request
            PagedEnumerable<ListHcxActivationKeysResponse, HcxActivationKey> response = vmwareEngineClient.ListHcxActivationKeys(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HcxActivationKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHcxActivationKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HcxActivationKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HcxActivationKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HcxActivationKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHcxActivationKeysAsync</summary>
        public async Task ListHcxActivationKeysRequestObjectAsync()
        {
            // Snippet: ListHcxActivationKeysAsync(ListHcxActivationKeysRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListHcxActivationKeysRequest request = new ListHcxActivationKeysRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListHcxActivationKeysResponse, HcxActivationKey> response = vmwareEngineClient.ListHcxActivationKeysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HcxActivationKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHcxActivationKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HcxActivationKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HcxActivationKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HcxActivationKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHcxActivationKeys</summary>
        public void ListHcxActivationKeys()
        {
            // Snippet: ListHcxActivationKeys(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            PagedEnumerable<ListHcxActivationKeysResponse, HcxActivationKey> response = vmwareEngineClient.ListHcxActivationKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HcxActivationKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHcxActivationKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HcxActivationKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HcxActivationKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HcxActivationKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHcxActivationKeysAsync</summary>
        public async Task ListHcxActivationKeysAsync()
        {
            // Snippet: ListHcxActivationKeysAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            PagedAsyncEnumerable<ListHcxActivationKeysResponse, HcxActivationKey> response = vmwareEngineClient.ListHcxActivationKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HcxActivationKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHcxActivationKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HcxActivationKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HcxActivationKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HcxActivationKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHcxActivationKeys</summary>
        public void ListHcxActivationKeysResourceNames()
        {
            // Snippet: ListHcxActivationKeys(PrivateCloudName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            PagedEnumerable<ListHcxActivationKeysResponse, HcxActivationKey> response = vmwareEngineClient.ListHcxActivationKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HcxActivationKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHcxActivationKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HcxActivationKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HcxActivationKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HcxActivationKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHcxActivationKeysAsync</summary>
        public async Task ListHcxActivationKeysResourceNamesAsync()
        {
            // Snippet: ListHcxActivationKeysAsync(PrivateCloudName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            PagedAsyncEnumerable<ListHcxActivationKeysResponse, HcxActivationKey> response = vmwareEngineClient.ListHcxActivationKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HcxActivationKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHcxActivationKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HcxActivationKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HcxActivationKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HcxActivationKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetHcxActivationKey</summary>
        public void GetHcxActivationKeyRequestObject()
        {
            // Snippet: GetHcxActivationKey(GetHcxActivationKeyRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetHcxActivationKeyRequest request = new GetHcxActivationKeyRequest
            {
                HcxActivationKeyName = HcxActivationKeyName.FromProjectLocationPrivateCloudHcxActivationKey("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[HCX_ACTIVATION_KEY]"),
            };
            // Make the request
            HcxActivationKey response = vmwareEngineClient.GetHcxActivationKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetHcxActivationKeyAsync</summary>
        public async Task GetHcxActivationKeyRequestObjectAsync()
        {
            // Snippet: GetHcxActivationKeyAsync(GetHcxActivationKeyRequest, CallSettings)
            // Additional: GetHcxActivationKeyAsync(GetHcxActivationKeyRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetHcxActivationKeyRequest request = new GetHcxActivationKeyRequest
            {
                HcxActivationKeyName = HcxActivationKeyName.FromProjectLocationPrivateCloudHcxActivationKey("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[HCX_ACTIVATION_KEY]"),
            };
            // Make the request
            HcxActivationKey response = await vmwareEngineClient.GetHcxActivationKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHcxActivationKey</summary>
        public void GetHcxActivationKey()
        {
            // Snippet: GetHcxActivationKey(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/hcxActivationKeys/[HCX_ACTIVATION_KEY]";
            // Make the request
            HcxActivationKey response = vmwareEngineClient.GetHcxActivationKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetHcxActivationKeyAsync</summary>
        public async Task GetHcxActivationKeyAsync()
        {
            // Snippet: GetHcxActivationKeyAsync(string, CallSettings)
            // Additional: GetHcxActivationKeyAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/hcxActivationKeys/[HCX_ACTIVATION_KEY]";
            // Make the request
            HcxActivationKey response = await vmwareEngineClient.GetHcxActivationKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetHcxActivationKey</summary>
        public void GetHcxActivationKeyResourceNames()
        {
            // Snippet: GetHcxActivationKey(HcxActivationKeyName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            HcxActivationKeyName name = HcxActivationKeyName.FromProjectLocationPrivateCloudHcxActivationKey("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[HCX_ACTIVATION_KEY]");
            // Make the request
            HcxActivationKey response = vmwareEngineClient.GetHcxActivationKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetHcxActivationKeyAsync</summary>
        public async Task GetHcxActivationKeyResourceNamesAsync()
        {
            // Snippet: GetHcxActivationKeyAsync(HcxActivationKeyName, CallSettings)
            // Additional: GetHcxActivationKeyAsync(HcxActivationKeyName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            HcxActivationKeyName name = HcxActivationKeyName.FromProjectLocationPrivateCloudHcxActivationKey("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[HCX_ACTIVATION_KEY]");
            // Make the request
            HcxActivationKey response = await vmwareEngineClient.GetHcxActivationKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkPolicy</summary>
        public void GetNetworkPolicyRequestObject()
        {
            // Snippet: GetNetworkPolicy(GetNetworkPolicyRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetNetworkPolicyRequest request = new GetNetworkPolicyRequest
            {
                NetworkPolicyName = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]"),
            };
            // Make the request
            NetworkPolicy response = vmwareEngineClient.GetNetworkPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkPolicyAsync</summary>
        public async Task GetNetworkPolicyRequestObjectAsync()
        {
            // Snippet: GetNetworkPolicyAsync(GetNetworkPolicyRequest, CallSettings)
            // Additional: GetNetworkPolicyAsync(GetNetworkPolicyRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetNetworkPolicyRequest request = new GetNetworkPolicyRequest
            {
                NetworkPolicyName = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]"),
            };
            // Make the request
            NetworkPolicy response = await vmwareEngineClient.GetNetworkPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkPolicy</summary>
        public void GetNetworkPolicy()
        {
            // Snippet: GetNetworkPolicy(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networkPolicies/[NETWORK_POLICY]";
            // Make the request
            NetworkPolicy response = vmwareEngineClient.GetNetworkPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkPolicyAsync</summary>
        public async Task GetNetworkPolicyAsync()
        {
            // Snippet: GetNetworkPolicyAsync(string, CallSettings)
            // Additional: GetNetworkPolicyAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networkPolicies/[NETWORK_POLICY]";
            // Make the request
            NetworkPolicy response = await vmwareEngineClient.GetNetworkPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkPolicy</summary>
        public void GetNetworkPolicyResourceNames()
        {
            // Snippet: GetNetworkPolicy(NetworkPolicyName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            NetworkPolicyName name = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]");
            // Make the request
            NetworkPolicy response = vmwareEngineClient.GetNetworkPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkPolicyAsync</summary>
        public async Task GetNetworkPolicyResourceNamesAsync()
        {
            // Snippet: GetNetworkPolicyAsync(NetworkPolicyName, CallSettings)
            // Additional: GetNetworkPolicyAsync(NetworkPolicyName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            NetworkPolicyName name = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]");
            // Make the request
            NetworkPolicy response = await vmwareEngineClient.GetNetworkPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNetworkPolicies</summary>
        public void ListNetworkPoliciesRequestObject()
        {
            // Snippet: ListNetworkPolicies(ListNetworkPoliciesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListNetworkPoliciesRequest request = new ListNetworkPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListNetworkPoliciesResponse, NetworkPolicy> response = vmwareEngineClient.ListNetworkPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworkPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkPoliciesAsync</summary>
        public async Task ListNetworkPoliciesRequestObjectAsync()
        {
            // Snippet: ListNetworkPoliciesAsync(ListNetworkPoliciesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworkPoliciesRequest request = new ListNetworkPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListNetworkPoliciesResponse, NetworkPolicy> response = vmwareEngineClient.ListNetworkPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworkPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkPolicies</summary>
        public void ListNetworkPolicies()
        {
            // Snippet: ListNetworkPolicies(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListNetworkPoliciesResponse, NetworkPolicy> response = vmwareEngineClient.ListNetworkPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworkPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkPoliciesAsync</summary>
        public async Task ListNetworkPoliciesAsync()
        {
            // Snippet: ListNetworkPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListNetworkPoliciesResponse, NetworkPolicy> response = vmwareEngineClient.ListNetworkPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworkPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkPolicies</summary>
        public void ListNetworkPoliciesResourceNames()
        {
            // Snippet: ListNetworkPolicies(LocationName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNetworkPoliciesResponse, NetworkPolicy> response = vmwareEngineClient.ListNetworkPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworkPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkPoliciesAsync</summary>
        public async Task ListNetworkPoliciesResourceNamesAsync()
        {
            // Snippet: ListNetworkPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNetworkPoliciesResponse, NetworkPolicy> response = vmwareEngineClient.ListNetworkPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworkPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkPolicy</summary>
        public void CreateNetworkPolicyRequestObject()
        {
            // Snippet: CreateNetworkPolicy(CreateNetworkPolicyRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            CreateNetworkPolicyRequest request = new CreateNetworkPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NetworkPolicyId = "",
                NetworkPolicy = new NetworkPolicy(),
                RequestId = "",
            };
            // Make the request
            Operation<NetworkPolicy, OperationMetadata> response = vmwareEngineClient.CreateNetworkPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NetworkPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPolicy, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateNetworkPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkPolicyAsync</summary>
        public async Task CreateNetworkPolicyRequestObjectAsync()
        {
            // Snippet: CreateNetworkPolicyAsync(CreateNetworkPolicyRequest, CallSettings)
            // Additional: CreateNetworkPolicyAsync(CreateNetworkPolicyRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            CreateNetworkPolicyRequest request = new CreateNetworkPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NetworkPolicyId = "",
                NetworkPolicy = new NetworkPolicy(),
                RequestId = "",
            };
            // Make the request
            Operation<NetworkPolicy, OperationMetadata> response = await vmwareEngineClient.CreateNetworkPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NetworkPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPolicy, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateNetworkPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkPolicy</summary>
        public void CreateNetworkPolicy()
        {
            // Snippet: CreateNetworkPolicy(string, NetworkPolicy, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            NetworkPolicy networkPolicy = new NetworkPolicy();
            string networkPolicyId = "";
            // Make the request
            Operation<NetworkPolicy, OperationMetadata> response = vmwareEngineClient.CreateNetworkPolicy(parent, networkPolicy, networkPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NetworkPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPolicy, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateNetworkPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkPolicyAsync</summary>
        public async Task CreateNetworkPolicyAsync()
        {
            // Snippet: CreateNetworkPolicyAsync(string, NetworkPolicy, string, CallSettings)
            // Additional: CreateNetworkPolicyAsync(string, NetworkPolicy, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            NetworkPolicy networkPolicy = new NetworkPolicy();
            string networkPolicyId = "";
            // Make the request
            Operation<NetworkPolicy, OperationMetadata> response = await vmwareEngineClient.CreateNetworkPolicyAsync(parent, networkPolicy, networkPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NetworkPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPolicy, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateNetworkPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkPolicy</summary>
        public void CreateNetworkPolicyResourceNames()
        {
            // Snippet: CreateNetworkPolicy(LocationName, NetworkPolicy, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NetworkPolicy networkPolicy = new NetworkPolicy();
            string networkPolicyId = "";
            // Make the request
            Operation<NetworkPolicy, OperationMetadata> response = vmwareEngineClient.CreateNetworkPolicy(parent, networkPolicy, networkPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NetworkPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPolicy, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateNetworkPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkPolicyAsync</summary>
        public async Task CreateNetworkPolicyResourceNamesAsync()
        {
            // Snippet: CreateNetworkPolicyAsync(LocationName, NetworkPolicy, string, CallSettings)
            // Additional: CreateNetworkPolicyAsync(LocationName, NetworkPolicy, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NetworkPolicy networkPolicy = new NetworkPolicy();
            string networkPolicyId = "";
            // Make the request
            Operation<NetworkPolicy, OperationMetadata> response = await vmwareEngineClient.CreateNetworkPolicyAsync(parent, networkPolicy, networkPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NetworkPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPolicy, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateNetworkPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNetworkPolicy</summary>
        public void UpdateNetworkPolicyRequestObject()
        {
            // Snippet: UpdateNetworkPolicy(UpdateNetworkPolicyRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            UpdateNetworkPolicyRequest request = new UpdateNetworkPolicyRequest
            {
                NetworkPolicy = new NetworkPolicy(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<NetworkPolicy, OperationMetadata> response = vmwareEngineClient.UpdateNetworkPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NetworkPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPolicy, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateNetworkPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNetworkPolicyAsync</summary>
        public async Task UpdateNetworkPolicyRequestObjectAsync()
        {
            // Snippet: UpdateNetworkPolicyAsync(UpdateNetworkPolicyRequest, CallSettings)
            // Additional: UpdateNetworkPolicyAsync(UpdateNetworkPolicyRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNetworkPolicyRequest request = new UpdateNetworkPolicyRequest
            {
                NetworkPolicy = new NetworkPolicy(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<NetworkPolicy, OperationMetadata> response = await vmwareEngineClient.UpdateNetworkPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NetworkPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPolicy, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateNetworkPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNetworkPolicy</summary>
        public void UpdateNetworkPolicy()
        {
            // Snippet: UpdateNetworkPolicy(NetworkPolicy, FieldMask, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            NetworkPolicy networkPolicy = new NetworkPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<NetworkPolicy, OperationMetadata> response = vmwareEngineClient.UpdateNetworkPolicy(networkPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NetworkPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPolicy, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateNetworkPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNetworkPolicyAsync</summary>
        public async Task UpdateNetworkPolicyAsync()
        {
            // Snippet: UpdateNetworkPolicyAsync(NetworkPolicy, FieldMask, CallSettings)
            // Additional: UpdateNetworkPolicyAsync(NetworkPolicy, FieldMask, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            NetworkPolicy networkPolicy = new NetworkPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<NetworkPolicy, OperationMetadata> response = await vmwareEngineClient.UpdateNetworkPolicyAsync(networkPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NetworkPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPolicy, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateNetworkPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkPolicy</summary>
        public void DeleteNetworkPolicyRequestObject()
        {
            // Snippet: DeleteNetworkPolicy(DeleteNetworkPolicyRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DeleteNetworkPolicyRequest request = new DeleteNetworkPolicyRequest
            {
                NetworkPolicyName = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteNetworkPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteNetworkPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkPolicyAsync</summary>
        public async Task DeleteNetworkPolicyRequestObjectAsync()
        {
            // Snippet: DeleteNetworkPolicyAsync(DeleteNetworkPolicyRequest, CallSettings)
            // Additional: DeleteNetworkPolicyAsync(DeleteNetworkPolicyRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNetworkPolicyRequest request = new DeleteNetworkPolicyRequest
            {
                NetworkPolicyName = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteNetworkPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteNetworkPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkPolicy</summary>
        public void DeleteNetworkPolicy()
        {
            // Snippet: DeleteNetworkPolicy(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networkPolicies/[NETWORK_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteNetworkPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteNetworkPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkPolicyAsync</summary>
        public async Task DeleteNetworkPolicyAsync()
        {
            // Snippet: DeleteNetworkPolicyAsync(string, CallSettings)
            // Additional: DeleteNetworkPolicyAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networkPolicies/[NETWORK_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteNetworkPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteNetworkPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkPolicy</summary>
        public void DeleteNetworkPolicyResourceNames()
        {
            // Snippet: DeleteNetworkPolicy(NetworkPolicyName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            NetworkPolicyName name = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteNetworkPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteNetworkPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkPolicyAsync</summary>
        public async Task DeleteNetworkPolicyResourceNamesAsync()
        {
            // Snippet: DeleteNetworkPolicyAsync(NetworkPolicyName, CallSettings)
            // Additional: DeleteNetworkPolicyAsync(NetworkPolicyName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            NetworkPolicyName name = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteNetworkPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteNetworkPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVmwareEngineNetwork</summary>
        public void CreateVmwareEngineNetworkRequestObject()
        {
            // Snippet: CreateVmwareEngineNetwork(CreateVmwareEngineNetworkRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            CreateVmwareEngineNetworkRequest request = new CreateVmwareEngineNetworkRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VmwareEngineNetworkId = "",
                VmwareEngineNetwork = new VmwareEngineNetwork(),
                RequestId = "",
            };
            // Make the request
            Operation<VmwareEngineNetwork, OperationMetadata> response = vmwareEngineClient.CreateVmwareEngineNetwork(request);

            // Poll until the returned long-running operation is complete
            Operation<VmwareEngineNetwork, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VmwareEngineNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VmwareEngineNetwork, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateVmwareEngineNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VmwareEngineNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVmwareEngineNetworkAsync</summary>
        public async Task CreateVmwareEngineNetworkRequestObjectAsync()
        {
            // Snippet: CreateVmwareEngineNetworkAsync(CreateVmwareEngineNetworkRequest, CallSettings)
            // Additional: CreateVmwareEngineNetworkAsync(CreateVmwareEngineNetworkRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            CreateVmwareEngineNetworkRequest request = new CreateVmwareEngineNetworkRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VmwareEngineNetworkId = "",
                VmwareEngineNetwork = new VmwareEngineNetwork(),
                RequestId = "",
            };
            // Make the request
            Operation<VmwareEngineNetwork, OperationMetadata> response = await vmwareEngineClient.CreateVmwareEngineNetworkAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<VmwareEngineNetwork, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VmwareEngineNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VmwareEngineNetwork, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateVmwareEngineNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VmwareEngineNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVmwareEngineNetwork</summary>
        public void CreateVmwareEngineNetwork()
        {
            // Snippet: CreateVmwareEngineNetwork(string, VmwareEngineNetwork, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            VmwareEngineNetwork vmwareEngineNetwork = new VmwareEngineNetwork();
            string vmwareEngineNetworkId = "";
            // Make the request
            Operation<VmwareEngineNetwork, OperationMetadata> response = vmwareEngineClient.CreateVmwareEngineNetwork(parent, vmwareEngineNetwork, vmwareEngineNetworkId);

            // Poll until the returned long-running operation is complete
            Operation<VmwareEngineNetwork, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VmwareEngineNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VmwareEngineNetwork, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateVmwareEngineNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VmwareEngineNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVmwareEngineNetworkAsync</summary>
        public async Task CreateVmwareEngineNetworkAsync()
        {
            // Snippet: CreateVmwareEngineNetworkAsync(string, VmwareEngineNetwork, string, CallSettings)
            // Additional: CreateVmwareEngineNetworkAsync(string, VmwareEngineNetwork, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            VmwareEngineNetwork vmwareEngineNetwork = new VmwareEngineNetwork();
            string vmwareEngineNetworkId = "";
            // Make the request
            Operation<VmwareEngineNetwork, OperationMetadata> response = await vmwareEngineClient.CreateVmwareEngineNetworkAsync(parent, vmwareEngineNetwork, vmwareEngineNetworkId);

            // Poll until the returned long-running operation is complete
            Operation<VmwareEngineNetwork, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VmwareEngineNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VmwareEngineNetwork, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateVmwareEngineNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VmwareEngineNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVmwareEngineNetwork</summary>
        public void CreateVmwareEngineNetworkResourceNames()
        {
            // Snippet: CreateVmwareEngineNetwork(LocationName, VmwareEngineNetwork, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            VmwareEngineNetwork vmwareEngineNetwork = new VmwareEngineNetwork();
            string vmwareEngineNetworkId = "";
            // Make the request
            Operation<VmwareEngineNetwork, OperationMetadata> response = vmwareEngineClient.CreateVmwareEngineNetwork(parent, vmwareEngineNetwork, vmwareEngineNetworkId);

            // Poll until the returned long-running operation is complete
            Operation<VmwareEngineNetwork, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VmwareEngineNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VmwareEngineNetwork, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateVmwareEngineNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VmwareEngineNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVmwareEngineNetworkAsync</summary>
        public async Task CreateVmwareEngineNetworkResourceNamesAsync()
        {
            // Snippet: CreateVmwareEngineNetworkAsync(LocationName, VmwareEngineNetwork, string, CallSettings)
            // Additional: CreateVmwareEngineNetworkAsync(LocationName, VmwareEngineNetwork, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            VmwareEngineNetwork vmwareEngineNetwork = new VmwareEngineNetwork();
            string vmwareEngineNetworkId = "";
            // Make the request
            Operation<VmwareEngineNetwork, OperationMetadata> response = await vmwareEngineClient.CreateVmwareEngineNetworkAsync(parent, vmwareEngineNetwork, vmwareEngineNetworkId);

            // Poll until the returned long-running operation is complete
            Operation<VmwareEngineNetwork, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VmwareEngineNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VmwareEngineNetwork, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateVmwareEngineNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VmwareEngineNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVmwareEngineNetwork</summary>
        public void UpdateVmwareEngineNetworkRequestObject()
        {
            // Snippet: UpdateVmwareEngineNetwork(UpdateVmwareEngineNetworkRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            UpdateVmwareEngineNetworkRequest request = new UpdateVmwareEngineNetworkRequest
            {
                VmwareEngineNetwork = new VmwareEngineNetwork(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<VmwareEngineNetwork, OperationMetadata> response = vmwareEngineClient.UpdateVmwareEngineNetwork(request);

            // Poll until the returned long-running operation is complete
            Operation<VmwareEngineNetwork, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VmwareEngineNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VmwareEngineNetwork, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateVmwareEngineNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VmwareEngineNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVmwareEngineNetworkAsync</summary>
        public async Task UpdateVmwareEngineNetworkRequestObjectAsync()
        {
            // Snippet: UpdateVmwareEngineNetworkAsync(UpdateVmwareEngineNetworkRequest, CallSettings)
            // Additional: UpdateVmwareEngineNetworkAsync(UpdateVmwareEngineNetworkRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            UpdateVmwareEngineNetworkRequest request = new UpdateVmwareEngineNetworkRequest
            {
                VmwareEngineNetwork = new VmwareEngineNetwork(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<VmwareEngineNetwork, OperationMetadata> response = await vmwareEngineClient.UpdateVmwareEngineNetworkAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<VmwareEngineNetwork, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VmwareEngineNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VmwareEngineNetwork, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateVmwareEngineNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VmwareEngineNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVmwareEngineNetwork</summary>
        public void UpdateVmwareEngineNetwork()
        {
            // Snippet: UpdateVmwareEngineNetwork(VmwareEngineNetwork, FieldMask, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            VmwareEngineNetwork vmwareEngineNetwork = new VmwareEngineNetwork();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<VmwareEngineNetwork, OperationMetadata> response = vmwareEngineClient.UpdateVmwareEngineNetwork(vmwareEngineNetwork, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<VmwareEngineNetwork, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VmwareEngineNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VmwareEngineNetwork, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateVmwareEngineNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VmwareEngineNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVmwareEngineNetworkAsync</summary>
        public async Task UpdateVmwareEngineNetworkAsync()
        {
            // Snippet: UpdateVmwareEngineNetworkAsync(VmwareEngineNetwork, FieldMask, CallSettings)
            // Additional: UpdateVmwareEngineNetworkAsync(VmwareEngineNetwork, FieldMask, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            VmwareEngineNetwork vmwareEngineNetwork = new VmwareEngineNetwork();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<VmwareEngineNetwork, OperationMetadata> response = await vmwareEngineClient.UpdateVmwareEngineNetworkAsync(vmwareEngineNetwork, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<VmwareEngineNetwork, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VmwareEngineNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VmwareEngineNetwork, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateVmwareEngineNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VmwareEngineNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVmwareEngineNetwork</summary>
        public void DeleteVmwareEngineNetworkRequestObject()
        {
            // Snippet: DeleteVmwareEngineNetwork(DeleteVmwareEngineNetworkRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DeleteVmwareEngineNetworkRequest request = new DeleteVmwareEngineNetworkRequest
            {
                VmwareEngineNetworkName = VmwareEngineNetworkName.FromProjectLocationVmwareEngineNetwork("[PROJECT]", "[LOCATION]", "[VMWARE_ENGINE_NETWORK]"),
                RequestId = "",
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteVmwareEngineNetwork(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteVmwareEngineNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVmwareEngineNetworkAsync</summary>
        public async Task DeleteVmwareEngineNetworkRequestObjectAsync()
        {
            // Snippet: DeleteVmwareEngineNetworkAsync(DeleteVmwareEngineNetworkRequest, CallSettings)
            // Additional: DeleteVmwareEngineNetworkAsync(DeleteVmwareEngineNetworkRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DeleteVmwareEngineNetworkRequest request = new DeleteVmwareEngineNetworkRequest
            {
                VmwareEngineNetworkName = VmwareEngineNetworkName.FromProjectLocationVmwareEngineNetwork("[PROJECT]", "[LOCATION]", "[VMWARE_ENGINE_NETWORK]"),
                RequestId = "",
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteVmwareEngineNetworkAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteVmwareEngineNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVmwareEngineNetwork</summary>
        public void DeleteVmwareEngineNetwork()
        {
            // Snippet: DeleteVmwareEngineNetwork(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vmwareEngineNetworks/[VMWARE_ENGINE_NETWORK]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteVmwareEngineNetwork(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteVmwareEngineNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVmwareEngineNetworkAsync</summary>
        public async Task DeleteVmwareEngineNetworkAsync()
        {
            // Snippet: DeleteVmwareEngineNetworkAsync(string, CallSettings)
            // Additional: DeleteVmwareEngineNetworkAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vmwareEngineNetworks/[VMWARE_ENGINE_NETWORK]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteVmwareEngineNetworkAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteVmwareEngineNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVmwareEngineNetwork</summary>
        public void DeleteVmwareEngineNetworkResourceNames()
        {
            // Snippet: DeleteVmwareEngineNetwork(VmwareEngineNetworkName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            VmwareEngineNetworkName name = VmwareEngineNetworkName.FromProjectLocationVmwareEngineNetwork("[PROJECT]", "[LOCATION]", "[VMWARE_ENGINE_NETWORK]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteVmwareEngineNetwork(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteVmwareEngineNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVmwareEngineNetworkAsync</summary>
        public async Task DeleteVmwareEngineNetworkResourceNamesAsync()
        {
            // Snippet: DeleteVmwareEngineNetworkAsync(VmwareEngineNetworkName, CallSettings)
            // Additional: DeleteVmwareEngineNetworkAsync(VmwareEngineNetworkName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            VmwareEngineNetworkName name = VmwareEngineNetworkName.FromProjectLocationVmwareEngineNetwork("[PROJECT]", "[LOCATION]", "[VMWARE_ENGINE_NETWORK]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteVmwareEngineNetworkAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteVmwareEngineNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetVmwareEngineNetwork</summary>
        public void GetVmwareEngineNetworkRequestObject()
        {
            // Snippet: GetVmwareEngineNetwork(GetVmwareEngineNetworkRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetVmwareEngineNetworkRequest request = new GetVmwareEngineNetworkRequest
            {
                VmwareEngineNetworkName = VmwareEngineNetworkName.FromProjectLocationVmwareEngineNetwork("[PROJECT]", "[LOCATION]", "[VMWARE_ENGINE_NETWORK]"),
            };
            // Make the request
            VmwareEngineNetwork response = vmwareEngineClient.GetVmwareEngineNetwork(request);
            // End snippet
        }

        /// <summary>Snippet for GetVmwareEngineNetworkAsync</summary>
        public async Task GetVmwareEngineNetworkRequestObjectAsync()
        {
            // Snippet: GetVmwareEngineNetworkAsync(GetVmwareEngineNetworkRequest, CallSettings)
            // Additional: GetVmwareEngineNetworkAsync(GetVmwareEngineNetworkRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetVmwareEngineNetworkRequest request = new GetVmwareEngineNetworkRequest
            {
                VmwareEngineNetworkName = VmwareEngineNetworkName.FromProjectLocationVmwareEngineNetwork("[PROJECT]", "[LOCATION]", "[VMWARE_ENGINE_NETWORK]"),
            };
            // Make the request
            VmwareEngineNetwork response = await vmwareEngineClient.GetVmwareEngineNetworkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVmwareEngineNetwork</summary>
        public void GetVmwareEngineNetwork()
        {
            // Snippet: GetVmwareEngineNetwork(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vmwareEngineNetworks/[VMWARE_ENGINE_NETWORK]";
            // Make the request
            VmwareEngineNetwork response = vmwareEngineClient.GetVmwareEngineNetwork(name);
            // End snippet
        }

        /// <summary>Snippet for GetVmwareEngineNetworkAsync</summary>
        public async Task GetVmwareEngineNetworkAsync()
        {
            // Snippet: GetVmwareEngineNetworkAsync(string, CallSettings)
            // Additional: GetVmwareEngineNetworkAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vmwareEngineNetworks/[VMWARE_ENGINE_NETWORK]";
            // Make the request
            VmwareEngineNetwork response = await vmwareEngineClient.GetVmwareEngineNetworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVmwareEngineNetwork</summary>
        public void GetVmwareEngineNetworkResourceNames()
        {
            // Snippet: GetVmwareEngineNetwork(VmwareEngineNetworkName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            VmwareEngineNetworkName name = VmwareEngineNetworkName.FromProjectLocationVmwareEngineNetwork("[PROJECT]", "[LOCATION]", "[VMWARE_ENGINE_NETWORK]");
            // Make the request
            VmwareEngineNetwork response = vmwareEngineClient.GetVmwareEngineNetwork(name);
            // End snippet
        }

        /// <summary>Snippet for GetVmwareEngineNetworkAsync</summary>
        public async Task GetVmwareEngineNetworkResourceNamesAsync()
        {
            // Snippet: GetVmwareEngineNetworkAsync(VmwareEngineNetworkName, CallSettings)
            // Additional: GetVmwareEngineNetworkAsync(VmwareEngineNetworkName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            VmwareEngineNetworkName name = VmwareEngineNetworkName.FromProjectLocationVmwareEngineNetwork("[PROJECT]", "[LOCATION]", "[VMWARE_ENGINE_NETWORK]");
            // Make the request
            VmwareEngineNetwork response = await vmwareEngineClient.GetVmwareEngineNetworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListVmwareEngineNetworks</summary>
        public void ListVmwareEngineNetworksRequestObject()
        {
            // Snippet: ListVmwareEngineNetworks(ListVmwareEngineNetworksRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListVmwareEngineNetworksRequest request = new ListVmwareEngineNetworksRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListVmwareEngineNetworksResponse, VmwareEngineNetwork> response = vmwareEngineClient.ListVmwareEngineNetworks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VmwareEngineNetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVmwareEngineNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VmwareEngineNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VmwareEngineNetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VmwareEngineNetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVmwareEngineNetworksAsync</summary>
        public async Task ListVmwareEngineNetworksRequestObjectAsync()
        {
            // Snippet: ListVmwareEngineNetworksAsync(ListVmwareEngineNetworksRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListVmwareEngineNetworksRequest request = new ListVmwareEngineNetworksRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListVmwareEngineNetworksResponse, VmwareEngineNetwork> response = vmwareEngineClient.ListVmwareEngineNetworksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VmwareEngineNetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVmwareEngineNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VmwareEngineNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VmwareEngineNetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VmwareEngineNetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVmwareEngineNetworks</summary>
        public void ListVmwareEngineNetworks()
        {
            // Snippet: ListVmwareEngineNetworks(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListVmwareEngineNetworksResponse, VmwareEngineNetwork> response = vmwareEngineClient.ListVmwareEngineNetworks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VmwareEngineNetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVmwareEngineNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VmwareEngineNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VmwareEngineNetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VmwareEngineNetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVmwareEngineNetworksAsync</summary>
        public async Task ListVmwareEngineNetworksAsync()
        {
            // Snippet: ListVmwareEngineNetworksAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListVmwareEngineNetworksResponse, VmwareEngineNetwork> response = vmwareEngineClient.ListVmwareEngineNetworksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VmwareEngineNetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVmwareEngineNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VmwareEngineNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VmwareEngineNetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VmwareEngineNetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVmwareEngineNetworks</summary>
        public void ListVmwareEngineNetworksResourceNames()
        {
            // Snippet: ListVmwareEngineNetworks(LocationName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListVmwareEngineNetworksResponse, VmwareEngineNetwork> response = vmwareEngineClient.ListVmwareEngineNetworks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VmwareEngineNetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVmwareEngineNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VmwareEngineNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VmwareEngineNetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VmwareEngineNetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVmwareEngineNetworksAsync</summary>
        public async Task ListVmwareEngineNetworksResourceNamesAsync()
        {
            // Snippet: ListVmwareEngineNetworksAsync(LocationName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListVmwareEngineNetworksResponse, VmwareEngineNetwork> response = vmwareEngineClient.ListVmwareEngineNetworksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VmwareEngineNetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVmwareEngineNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VmwareEngineNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VmwareEngineNetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VmwareEngineNetwork item in singlePage)
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
