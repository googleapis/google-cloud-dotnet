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
    using Google.Cloud.VmwareEngine.V1;
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

        /// <summary>Snippet for ListNodes</summary>
        public void ListNodesRequestObject()
        {
            // Snippet: ListNodes(ListNodesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListNodesRequest request = new ListNodesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationPrivateCloudCluster("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]"),
            };
            // Make the request
            PagedEnumerable<ListNodesResponse, Node> response = vmwareEngineClient.ListNodes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Node item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNodesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Node item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Node> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Node item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodesAsync</summary>
        public async Task ListNodesRequestObjectAsync()
        {
            // Snippet: ListNodesAsync(ListNodesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListNodesRequest request = new ListNodesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationPrivateCloudCluster("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNodesResponse, Node> response = vmwareEngineClient.ListNodesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Node item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNodesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Node item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Node> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Node item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodes</summary>
        public void ListNodes()
        {
            // Snippet: ListNodes(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListNodesResponse, Node> response = vmwareEngineClient.ListNodes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Node item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNodesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Node item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Node> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Node item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodesAsync</summary>
        public async Task ListNodesAsync()
        {
            // Snippet: ListNodesAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListNodesResponse, Node> response = vmwareEngineClient.ListNodesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Node item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNodesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Node item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Node> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Node item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodes</summary>
        public void ListNodesResourceNames()
        {
            // Snippet: ListNodes(ClusterName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationPrivateCloudCluster("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListNodesResponse, Node> response = vmwareEngineClient.ListNodes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Node item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNodesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Node item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Node> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Node item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNodesAsync</summary>
        public async Task ListNodesResourceNamesAsync()
        {
            // Snippet: ListNodesAsync(ClusterName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationPrivateCloudCluster("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListNodesResponse, Node> response = vmwareEngineClient.ListNodesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Node item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNodesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Node item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Node> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Node item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNode</summary>
        public void GetNodeRequestObject()
        {
            // Snippet: GetNode(GetNodeRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationPrivateCloudClusterNode("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]", "[NODE]"),
            };
            // Make the request
            Node response = vmwareEngineClient.GetNode(request);
            // End snippet
        }

        /// <summary>Snippet for GetNodeAsync</summary>
        public async Task GetNodeRequestObjectAsync()
        {
            // Snippet: GetNodeAsync(GetNodeRequest, CallSettings)
            // Additional: GetNodeAsync(GetNodeRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationPrivateCloudClusterNode("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]", "[NODE]"),
            };
            // Make the request
            Node response = await vmwareEngineClient.GetNodeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNode</summary>
        public void GetNode()
        {
            // Snippet: GetNode(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/clusters/[CLUSTER]/nodes/[NODE]";
            // Make the request
            Node response = vmwareEngineClient.GetNode(name);
            // End snippet
        }

        /// <summary>Snippet for GetNodeAsync</summary>
        public async Task GetNodeAsync()
        {
            // Snippet: GetNodeAsync(string, CallSettings)
            // Additional: GetNodeAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/clusters/[CLUSTER]/nodes/[NODE]";
            // Make the request
            Node response = await vmwareEngineClient.GetNodeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNode</summary>
        public void GetNodeResourceNames()
        {
            // Snippet: GetNode(NodeName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            NodeName name = NodeName.FromProjectLocationPrivateCloudClusterNode("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]", "[NODE]");
            // Make the request
            Node response = vmwareEngineClient.GetNode(name);
            // End snippet
        }

        /// <summary>Snippet for GetNodeAsync</summary>
        public async Task GetNodeResourceNamesAsync()
        {
            // Snippet: GetNodeAsync(NodeName, CallSettings)
            // Additional: GetNodeAsync(NodeName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            NodeName name = NodeName.FromProjectLocationPrivateCloudClusterNode("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[CLUSTER]", "[NODE]");
            // Make the request
            Node response = await vmwareEngineClient.GetNodeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListExternalAddresses</summary>
        public void ListExternalAddressesRequestObject()
        {
            // Snippet: ListExternalAddresses(ListExternalAddressesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListExternalAddressesRequest request = new ListExternalAddressesRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListExternalAddressesResponse, ExternalAddress> response = vmwareEngineClient.ListExternalAddresses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExternalAddress item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExternalAddressesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAddress item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAddress> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAddress item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalAddressesAsync</summary>
        public async Task ListExternalAddressesRequestObjectAsync()
        {
            // Snippet: ListExternalAddressesAsync(ListExternalAddressesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListExternalAddressesRequest request = new ListExternalAddressesRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListExternalAddressesResponse, ExternalAddress> response = vmwareEngineClient.ListExternalAddressesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExternalAddress item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExternalAddressesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAddress item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAddress> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAddress item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalAddresses</summary>
        public void ListExternalAddresses()
        {
            // Snippet: ListExternalAddresses(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            PagedEnumerable<ListExternalAddressesResponse, ExternalAddress> response = vmwareEngineClient.ListExternalAddresses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExternalAddress item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExternalAddressesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAddress item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAddress> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAddress item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalAddressesAsync</summary>
        public async Task ListExternalAddressesAsync()
        {
            // Snippet: ListExternalAddressesAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            PagedAsyncEnumerable<ListExternalAddressesResponse, ExternalAddress> response = vmwareEngineClient.ListExternalAddressesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExternalAddress item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExternalAddressesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAddress item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAddress> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAddress item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalAddresses</summary>
        public void ListExternalAddressesResourceNames()
        {
            // Snippet: ListExternalAddresses(PrivateCloudName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            PagedEnumerable<ListExternalAddressesResponse, ExternalAddress> response = vmwareEngineClient.ListExternalAddresses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExternalAddress item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExternalAddressesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAddress item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAddress> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAddress item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalAddressesAsync</summary>
        public async Task ListExternalAddressesResourceNamesAsync()
        {
            // Snippet: ListExternalAddressesAsync(PrivateCloudName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            PagedAsyncEnumerable<ListExternalAddressesResponse, ExternalAddress> response = vmwareEngineClient.ListExternalAddressesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExternalAddress item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExternalAddressesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAddress item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAddress> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAddress item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchNetworkPolicyExternalAddresses</summary>
        public void FetchNetworkPolicyExternalAddressesRequestObject()
        {
            // Snippet: FetchNetworkPolicyExternalAddresses(FetchNetworkPolicyExternalAddressesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            FetchNetworkPolicyExternalAddressesRequest request = new FetchNetworkPolicyExternalAddressesRequest
            {
                NetworkPolicyAsNetworkPolicyName = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]"),
            };
            // Make the request
            PagedEnumerable<FetchNetworkPolicyExternalAddressesResponse, ExternalAddress> response = vmwareEngineClient.FetchNetworkPolicyExternalAddresses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExternalAddress item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchNetworkPolicyExternalAddressesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAddress item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAddress> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAddress item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchNetworkPolicyExternalAddressesAsync</summary>
        public async Task FetchNetworkPolicyExternalAddressesRequestObjectAsync()
        {
            // Snippet: FetchNetworkPolicyExternalAddressesAsync(FetchNetworkPolicyExternalAddressesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            FetchNetworkPolicyExternalAddressesRequest request = new FetchNetworkPolicyExternalAddressesRequest
            {
                NetworkPolicyAsNetworkPolicyName = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]"),
            };
            // Make the request
            PagedAsyncEnumerable<FetchNetworkPolicyExternalAddressesResponse, ExternalAddress> response = vmwareEngineClient.FetchNetworkPolicyExternalAddressesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExternalAddress item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchNetworkPolicyExternalAddressesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAddress item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAddress> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAddress item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchNetworkPolicyExternalAddresses</summary>
        public void FetchNetworkPolicyExternalAddresses()
        {
            // Snippet: FetchNetworkPolicyExternalAddresses(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string networkPolicy = "projects/[PROJECT]/locations/[LOCATION]/networkPolicies/[NETWORK_POLICY]";
            // Make the request
            PagedEnumerable<FetchNetworkPolicyExternalAddressesResponse, ExternalAddress> response = vmwareEngineClient.FetchNetworkPolicyExternalAddresses(networkPolicy);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExternalAddress item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchNetworkPolicyExternalAddressesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAddress item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAddress> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAddress item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchNetworkPolicyExternalAddressesAsync</summary>
        public async Task FetchNetworkPolicyExternalAddressesAsync()
        {
            // Snippet: FetchNetworkPolicyExternalAddressesAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string networkPolicy = "projects/[PROJECT]/locations/[LOCATION]/networkPolicies/[NETWORK_POLICY]";
            // Make the request
            PagedAsyncEnumerable<FetchNetworkPolicyExternalAddressesResponse, ExternalAddress> response = vmwareEngineClient.FetchNetworkPolicyExternalAddressesAsync(networkPolicy);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExternalAddress item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchNetworkPolicyExternalAddressesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAddress item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAddress> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAddress item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchNetworkPolicyExternalAddresses</summary>
        public void FetchNetworkPolicyExternalAddressesResourceNames()
        {
            // Snippet: FetchNetworkPolicyExternalAddresses(NetworkPolicyName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            NetworkPolicyName networkPolicy = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]");
            // Make the request
            PagedEnumerable<FetchNetworkPolicyExternalAddressesResponse, ExternalAddress> response = vmwareEngineClient.FetchNetworkPolicyExternalAddresses(networkPolicy);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExternalAddress item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchNetworkPolicyExternalAddressesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAddress item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAddress> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAddress item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchNetworkPolicyExternalAddressesAsync</summary>
        public async Task FetchNetworkPolicyExternalAddressesResourceNamesAsync()
        {
            // Snippet: FetchNetworkPolicyExternalAddressesAsync(NetworkPolicyName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            NetworkPolicyName networkPolicy = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]");
            // Make the request
            PagedAsyncEnumerable<FetchNetworkPolicyExternalAddressesResponse, ExternalAddress> response = vmwareEngineClient.FetchNetworkPolicyExternalAddressesAsync(networkPolicy);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExternalAddress item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchNetworkPolicyExternalAddressesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAddress item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAddress> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAddress item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetExternalAddress</summary>
        public void GetExternalAddressRequestObject()
        {
            // Snippet: GetExternalAddress(GetExternalAddressRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetExternalAddressRequest request = new GetExternalAddressRequest
            {
                ExternalAddressName = ExternalAddressName.FromProjectLocationPrivateCloudExternalAddress("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[EXTERNAL_ADDRESS]"),
            };
            // Make the request
            ExternalAddress response = vmwareEngineClient.GetExternalAddress(request);
            // End snippet
        }

        /// <summary>Snippet for GetExternalAddressAsync</summary>
        public async Task GetExternalAddressRequestObjectAsync()
        {
            // Snippet: GetExternalAddressAsync(GetExternalAddressRequest, CallSettings)
            // Additional: GetExternalAddressAsync(GetExternalAddressRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetExternalAddressRequest request = new GetExternalAddressRequest
            {
                ExternalAddressName = ExternalAddressName.FromProjectLocationPrivateCloudExternalAddress("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[EXTERNAL_ADDRESS]"),
            };
            // Make the request
            ExternalAddress response = await vmwareEngineClient.GetExternalAddressAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExternalAddress</summary>
        public void GetExternalAddress()
        {
            // Snippet: GetExternalAddress(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/externalAddresses/[EXTERNAL_ADDRESS]";
            // Make the request
            ExternalAddress response = vmwareEngineClient.GetExternalAddress(name);
            // End snippet
        }

        /// <summary>Snippet for GetExternalAddressAsync</summary>
        public async Task GetExternalAddressAsync()
        {
            // Snippet: GetExternalAddressAsync(string, CallSettings)
            // Additional: GetExternalAddressAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/externalAddresses/[EXTERNAL_ADDRESS]";
            // Make the request
            ExternalAddress response = await vmwareEngineClient.GetExternalAddressAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExternalAddress</summary>
        public void GetExternalAddressResourceNames()
        {
            // Snippet: GetExternalAddress(ExternalAddressName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ExternalAddressName name = ExternalAddressName.FromProjectLocationPrivateCloudExternalAddress("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[EXTERNAL_ADDRESS]");
            // Make the request
            ExternalAddress response = vmwareEngineClient.GetExternalAddress(name);
            // End snippet
        }

        /// <summary>Snippet for GetExternalAddressAsync</summary>
        public async Task GetExternalAddressResourceNamesAsync()
        {
            // Snippet: GetExternalAddressAsync(ExternalAddressName, CallSettings)
            // Additional: GetExternalAddressAsync(ExternalAddressName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ExternalAddressName name = ExternalAddressName.FromProjectLocationPrivateCloudExternalAddress("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[EXTERNAL_ADDRESS]");
            // Make the request
            ExternalAddress response = await vmwareEngineClient.GetExternalAddressAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAddress</summary>
        public void CreateExternalAddressRequestObject()
        {
            // Snippet: CreateExternalAddress(CreateExternalAddressRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            CreateExternalAddressRequest request = new CreateExternalAddressRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                ExternalAddress = new ExternalAddress(),
                ExternalAddressId = "",
                RequestId = "",
            };
            // Make the request
            Operation<ExternalAddress, OperationMetadata> response = vmwareEngineClient.CreateExternalAddress(request);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAddress, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExternalAddress result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAddress, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateExternalAddress(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAddress retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAddressAsync</summary>
        public async Task CreateExternalAddressRequestObjectAsync()
        {
            // Snippet: CreateExternalAddressAsync(CreateExternalAddressRequest, CallSettings)
            // Additional: CreateExternalAddressAsync(CreateExternalAddressRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            CreateExternalAddressRequest request = new CreateExternalAddressRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                ExternalAddress = new ExternalAddress(),
                ExternalAddressId = "",
                RequestId = "",
            };
            // Make the request
            Operation<ExternalAddress, OperationMetadata> response = await vmwareEngineClient.CreateExternalAddressAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAddress, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExternalAddress result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAddress, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateExternalAddressAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAddress retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAddress</summary>
        public void CreateExternalAddress()
        {
            // Snippet: CreateExternalAddress(string, ExternalAddress, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            ExternalAddress externalAddress = new ExternalAddress();
            string externalAddressId = "";
            // Make the request
            Operation<ExternalAddress, OperationMetadata> response = vmwareEngineClient.CreateExternalAddress(parent, externalAddress, externalAddressId);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAddress, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExternalAddress result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAddress, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateExternalAddress(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAddress retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAddressAsync</summary>
        public async Task CreateExternalAddressAsync()
        {
            // Snippet: CreateExternalAddressAsync(string, ExternalAddress, string, CallSettings)
            // Additional: CreateExternalAddressAsync(string, ExternalAddress, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            ExternalAddress externalAddress = new ExternalAddress();
            string externalAddressId = "";
            // Make the request
            Operation<ExternalAddress, OperationMetadata> response = await vmwareEngineClient.CreateExternalAddressAsync(parent, externalAddress, externalAddressId);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAddress, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExternalAddress result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAddress, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateExternalAddressAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAddress retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAddress</summary>
        public void CreateExternalAddressResourceNames()
        {
            // Snippet: CreateExternalAddress(PrivateCloudName, ExternalAddress, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            ExternalAddress externalAddress = new ExternalAddress();
            string externalAddressId = "";
            // Make the request
            Operation<ExternalAddress, OperationMetadata> response = vmwareEngineClient.CreateExternalAddress(parent, externalAddress, externalAddressId);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAddress, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExternalAddress result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAddress, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateExternalAddress(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAddress retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAddressAsync</summary>
        public async Task CreateExternalAddressResourceNamesAsync()
        {
            // Snippet: CreateExternalAddressAsync(PrivateCloudName, ExternalAddress, string, CallSettings)
            // Additional: CreateExternalAddressAsync(PrivateCloudName, ExternalAddress, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            ExternalAddress externalAddress = new ExternalAddress();
            string externalAddressId = "";
            // Make the request
            Operation<ExternalAddress, OperationMetadata> response = await vmwareEngineClient.CreateExternalAddressAsync(parent, externalAddress, externalAddressId);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAddress, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExternalAddress result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAddress, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateExternalAddressAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAddress retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalAddress</summary>
        public void UpdateExternalAddressRequestObject()
        {
            // Snippet: UpdateExternalAddress(UpdateExternalAddressRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            UpdateExternalAddressRequest request = new UpdateExternalAddressRequest
            {
                UpdateMask = new FieldMask(),
                ExternalAddress = new ExternalAddress(),
                RequestId = "",
            };
            // Make the request
            Operation<ExternalAddress, OperationMetadata> response = vmwareEngineClient.UpdateExternalAddress(request);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAddress, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExternalAddress result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAddress, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateExternalAddress(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAddress retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalAddressAsync</summary>
        public async Task UpdateExternalAddressRequestObjectAsync()
        {
            // Snippet: UpdateExternalAddressAsync(UpdateExternalAddressRequest, CallSettings)
            // Additional: UpdateExternalAddressAsync(UpdateExternalAddressRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            UpdateExternalAddressRequest request = new UpdateExternalAddressRequest
            {
                UpdateMask = new FieldMask(),
                ExternalAddress = new ExternalAddress(),
                RequestId = "",
            };
            // Make the request
            Operation<ExternalAddress, OperationMetadata> response = await vmwareEngineClient.UpdateExternalAddressAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAddress, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExternalAddress result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAddress, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateExternalAddressAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAddress retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalAddress</summary>
        public void UpdateExternalAddress()
        {
            // Snippet: UpdateExternalAddress(ExternalAddress, FieldMask, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ExternalAddress externalAddress = new ExternalAddress();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ExternalAddress, OperationMetadata> response = vmwareEngineClient.UpdateExternalAddress(externalAddress, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAddress, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExternalAddress result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAddress, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateExternalAddress(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAddress retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalAddressAsync</summary>
        public async Task UpdateExternalAddressAsync()
        {
            // Snippet: UpdateExternalAddressAsync(ExternalAddress, FieldMask, CallSettings)
            // Additional: UpdateExternalAddressAsync(ExternalAddress, FieldMask, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ExternalAddress externalAddress = new ExternalAddress();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ExternalAddress, OperationMetadata> response = await vmwareEngineClient.UpdateExternalAddressAsync(externalAddress, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAddress, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExternalAddress result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAddress, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateExternalAddressAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAddress retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalAddress</summary>
        public void DeleteExternalAddressRequestObject()
        {
            // Snippet: DeleteExternalAddress(DeleteExternalAddressRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DeleteExternalAddressRequest request = new DeleteExternalAddressRequest
            {
                ExternalAddressName = ExternalAddressName.FromProjectLocationPrivateCloudExternalAddress("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[EXTERNAL_ADDRESS]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteExternalAddress(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteExternalAddress(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalAddressAsync</summary>
        public async Task DeleteExternalAddressRequestObjectAsync()
        {
            // Snippet: DeleteExternalAddressAsync(DeleteExternalAddressRequest, CallSettings)
            // Additional: DeleteExternalAddressAsync(DeleteExternalAddressRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExternalAddressRequest request = new DeleteExternalAddressRequest
            {
                ExternalAddressName = ExternalAddressName.FromProjectLocationPrivateCloudExternalAddress("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[EXTERNAL_ADDRESS]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteExternalAddressAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteExternalAddressAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalAddress</summary>
        public void DeleteExternalAddress()
        {
            // Snippet: DeleteExternalAddress(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/externalAddresses/[EXTERNAL_ADDRESS]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteExternalAddress(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteExternalAddress(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalAddressAsync</summary>
        public async Task DeleteExternalAddressAsync()
        {
            // Snippet: DeleteExternalAddressAsync(string, CallSettings)
            // Additional: DeleteExternalAddressAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/externalAddresses/[EXTERNAL_ADDRESS]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteExternalAddressAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteExternalAddressAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalAddress</summary>
        public void DeleteExternalAddressResourceNames()
        {
            // Snippet: DeleteExternalAddress(ExternalAddressName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ExternalAddressName name = ExternalAddressName.FromProjectLocationPrivateCloudExternalAddress("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[EXTERNAL_ADDRESS]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteExternalAddress(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteExternalAddress(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalAddressAsync</summary>
        public async Task DeleteExternalAddressResourceNamesAsync()
        {
            // Snippet: DeleteExternalAddressAsync(ExternalAddressName, CallSettings)
            // Additional: DeleteExternalAddressAsync(ExternalAddressName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ExternalAddressName name = ExternalAddressName.FromProjectLocationPrivateCloudExternalAddress("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[EXTERNAL_ADDRESS]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteExternalAddressAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteExternalAddressAsync(operationName);
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

        /// <summary>Snippet for GetSubnet</summary>
        public void GetSubnetRequestObject()
        {
            // Snippet: GetSubnet(GetSubnetRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetSubnetRequest request = new GetSubnetRequest
            {
                SubnetName = SubnetName.FromProjectLocationPrivateCloudSubnet("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[SUBNET]"),
            };
            // Make the request
            Subnet response = vmwareEngineClient.GetSubnet(request);
            // End snippet
        }

        /// <summary>Snippet for GetSubnetAsync</summary>
        public async Task GetSubnetRequestObjectAsync()
        {
            // Snippet: GetSubnetAsync(GetSubnetRequest, CallSettings)
            // Additional: GetSubnetAsync(GetSubnetRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetSubnetRequest request = new GetSubnetRequest
            {
                SubnetName = SubnetName.FromProjectLocationPrivateCloudSubnet("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[SUBNET]"),
            };
            // Make the request
            Subnet response = await vmwareEngineClient.GetSubnetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSubnet</summary>
        public void GetSubnet()
        {
            // Snippet: GetSubnet(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/subnets/[SUBNET]";
            // Make the request
            Subnet response = vmwareEngineClient.GetSubnet(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubnetAsync</summary>
        public async Task GetSubnetAsync()
        {
            // Snippet: GetSubnetAsync(string, CallSettings)
            // Additional: GetSubnetAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/subnets/[SUBNET]";
            // Make the request
            Subnet response = await vmwareEngineClient.GetSubnetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubnet</summary>
        public void GetSubnetResourceNames()
        {
            // Snippet: GetSubnet(SubnetName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            SubnetName name = SubnetName.FromProjectLocationPrivateCloudSubnet("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[SUBNET]");
            // Make the request
            Subnet response = vmwareEngineClient.GetSubnet(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubnetAsync</summary>
        public async Task GetSubnetResourceNamesAsync()
        {
            // Snippet: GetSubnetAsync(SubnetName, CallSettings)
            // Additional: GetSubnetAsync(SubnetName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            SubnetName name = SubnetName.FromProjectLocationPrivateCloudSubnet("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[SUBNET]");
            // Make the request
            Subnet response = await vmwareEngineClient.GetSubnetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubnet</summary>
        public void UpdateSubnetRequestObject()
        {
            // Snippet: UpdateSubnet(UpdateSubnetRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            UpdateSubnetRequest request = new UpdateSubnetRequest
            {
                UpdateMask = new FieldMask(),
                Subnet = new Subnet(),
            };
            // Make the request
            Operation<Subnet, OperationMetadata> response = vmwareEngineClient.UpdateSubnet(request);

            // Poll until the returned long-running operation is complete
            Operation<Subnet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subnet, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSubnetAsync</summary>
        public async Task UpdateSubnetRequestObjectAsync()
        {
            // Snippet: UpdateSubnetAsync(UpdateSubnetRequest, CallSettings)
            // Additional: UpdateSubnetAsync(UpdateSubnetRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSubnetRequest request = new UpdateSubnetRequest
            {
                UpdateMask = new FieldMask(),
                Subnet = new Subnet(),
            };
            // Make the request
            Operation<Subnet, OperationMetadata> response = await vmwareEngineClient.UpdateSubnetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Subnet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subnet, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSubnet</summary>
        public void UpdateSubnet()
        {
            // Snippet: UpdateSubnet(Subnet, FieldMask, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            Subnet subnet = new Subnet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Subnet, OperationMetadata> response = vmwareEngineClient.UpdateSubnet(subnet, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Subnet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subnet, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSubnetAsync</summary>
        public async Task UpdateSubnetAsync()
        {
            // Snippet: UpdateSubnetAsync(Subnet, FieldMask, CallSettings)
            // Additional: UpdateSubnetAsync(Subnet, FieldMask, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            Subnet subnet = new Subnet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Subnet, OperationMetadata> response = await vmwareEngineClient.UpdateSubnetAsync(subnet, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Subnet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subnet, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListExternalAccessRules</summary>
        public void ListExternalAccessRulesRequestObject()
        {
            // Snippet: ListExternalAccessRules(ListExternalAccessRulesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListExternalAccessRulesRequest request = new ListExternalAccessRulesRequest
            {
                ParentAsNetworkPolicyName = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListExternalAccessRulesResponse, ExternalAccessRule> response = vmwareEngineClient.ListExternalAccessRules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExternalAccessRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExternalAccessRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAccessRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAccessRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAccessRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalAccessRulesAsync</summary>
        public async Task ListExternalAccessRulesRequestObjectAsync()
        {
            // Snippet: ListExternalAccessRulesAsync(ListExternalAccessRulesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListExternalAccessRulesRequest request = new ListExternalAccessRulesRequest
            {
                ParentAsNetworkPolicyName = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListExternalAccessRulesResponse, ExternalAccessRule> response = vmwareEngineClient.ListExternalAccessRulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExternalAccessRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExternalAccessRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAccessRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAccessRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAccessRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalAccessRules</summary>
        public void ListExternalAccessRules()
        {
            // Snippet: ListExternalAccessRules(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/networkPolicies/[NETWORK_POLICY]";
            // Make the request
            PagedEnumerable<ListExternalAccessRulesResponse, ExternalAccessRule> response = vmwareEngineClient.ListExternalAccessRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExternalAccessRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExternalAccessRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAccessRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAccessRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAccessRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalAccessRulesAsync</summary>
        public async Task ListExternalAccessRulesAsync()
        {
            // Snippet: ListExternalAccessRulesAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/networkPolicies/[NETWORK_POLICY]";
            // Make the request
            PagedAsyncEnumerable<ListExternalAccessRulesResponse, ExternalAccessRule> response = vmwareEngineClient.ListExternalAccessRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExternalAccessRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExternalAccessRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAccessRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAccessRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAccessRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalAccessRules</summary>
        public void ListExternalAccessRulesResourceNames()
        {
            // Snippet: ListExternalAccessRules(NetworkPolicyName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            NetworkPolicyName parent = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]");
            // Make the request
            PagedEnumerable<ListExternalAccessRulesResponse, ExternalAccessRule> response = vmwareEngineClient.ListExternalAccessRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExternalAccessRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExternalAccessRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAccessRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAccessRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAccessRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalAccessRulesAsync</summary>
        public async Task ListExternalAccessRulesResourceNamesAsync()
        {
            // Snippet: ListExternalAccessRulesAsync(NetworkPolicyName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            NetworkPolicyName parent = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]");
            // Make the request
            PagedAsyncEnumerable<ListExternalAccessRulesResponse, ExternalAccessRule> response = vmwareEngineClient.ListExternalAccessRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExternalAccessRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExternalAccessRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalAccessRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalAccessRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalAccessRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetExternalAccessRule</summary>
        public void GetExternalAccessRuleRequestObject()
        {
            // Snippet: GetExternalAccessRule(GetExternalAccessRuleRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetExternalAccessRuleRequest request = new GetExternalAccessRuleRequest
            {
                ExternalAccessRuleName = ExternalAccessRuleName.FromProjectLocationNetworkPolicyExternalAccessRule("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]", "[EXTERNAL_ACCESS_RULE]"),
            };
            // Make the request
            ExternalAccessRule response = vmwareEngineClient.GetExternalAccessRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetExternalAccessRuleAsync</summary>
        public async Task GetExternalAccessRuleRequestObjectAsync()
        {
            // Snippet: GetExternalAccessRuleAsync(GetExternalAccessRuleRequest, CallSettings)
            // Additional: GetExternalAccessRuleAsync(GetExternalAccessRuleRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetExternalAccessRuleRequest request = new GetExternalAccessRuleRequest
            {
                ExternalAccessRuleName = ExternalAccessRuleName.FromProjectLocationNetworkPolicyExternalAccessRule("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]", "[EXTERNAL_ACCESS_RULE]"),
            };
            // Make the request
            ExternalAccessRule response = await vmwareEngineClient.GetExternalAccessRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExternalAccessRule</summary>
        public void GetExternalAccessRule()
        {
            // Snippet: GetExternalAccessRule(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networkPolicies/[NETWORK_POLICY]/externalAccessRules/[EXTERNAL_ACCESS_RULE]";
            // Make the request
            ExternalAccessRule response = vmwareEngineClient.GetExternalAccessRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetExternalAccessRuleAsync</summary>
        public async Task GetExternalAccessRuleAsync()
        {
            // Snippet: GetExternalAccessRuleAsync(string, CallSettings)
            // Additional: GetExternalAccessRuleAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networkPolicies/[NETWORK_POLICY]/externalAccessRules/[EXTERNAL_ACCESS_RULE]";
            // Make the request
            ExternalAccessRule response = await vmwareEngineClient.GetExternalAccessRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExternalAccessRule</summary>
        public void GetExternalAccessRuleResourceNames()
        {
            // Snippet: GetExternalAccessRule(ExternalAccessRuleName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ExternalAccessRuleName name = ExternalAccessRuleName.FromProjectLocationNetworkPolicyExternalAccessRule("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]", "[EXTERNAL_ACCESS_RULE]");
            // Make the request
            ExternalAccessRule response = vmwareEngineClient.GetExternalAccessRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetExternalAccessRuleAsync</summary>
        public async Task GetExternalAccessRuleResourceNamesAsync()
        {
            // Snippet: GetExternalAccessRuleAsync(ExternalAccessRuleName, CallSettings)
            // Additional: GetExternalAccessRuleAsync(ExternalAccessRuleName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ExternalAccessRuleName name = ExternalAccessRuleName.FromProjectLocationNetworkPolicyExternalAccessRule("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]", "[EXTERNAL_ACCESS_RULE]");
            // Make the request
            ExternalAccessRule response = await vmwareEngineClient.GetExternalAccessRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAccessRule</summary>
        public void CreateExternalAccessRuleRequestObject()
        {
            // Snippet: CreateExternalAccessRule(CreateExternalAccessRuleRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            CreateExternalAccessRuleRequest request = new CreateExternalAccessRuleRequest
            {
                ParentAsNetworkPolicyName = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]"),
                ExternalAccessRule = new ExternalAccessRule(),
                ExternalAccessRuleId = "",
                RequestId = "",
            };
            // Make the request
            Operation<ExternalAccessRule, OperationMetadata> response = vmwareEngineClient.CreateExternalAccessRule(request);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAccessRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExternalAccessRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAccessRule, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateExternalAccessRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAccessRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAccessRuleAsync</summary>
        public async Task CreateExternalAccessRuleRequestObjectAsync()
        {
            // Snippet: CreateExternalAccessRuleAsync(CreateExternalAccessRuleRequest, CallSettings)
            // Additional: CreateExternalAccessRuleAsync(CreateExternalAccessRuleRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            CreateExternalAccessRuleRequest request = new CreateExternalAccessRuleRequest
            {
                ParentAsNetworkPolicyName = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]"),
                ExternalAccessRule = new ExternalAccessRule(),
                ExternalAccessRuleId = "",
                RequestId = "",
            };
            // Make the request
            Operation<ExternalAccessRule, OperationMetadata> response = await vmwareEngineClient.CreateExternalAccessRuleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAccessRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExternalAccessRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAccessRule, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateExternalAccessRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAccessRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAccessRule</summary>
        public void CreateExternalAccessRule()
        {
            // Snippet: CreateExternalAccessRule(string, ExternalAccessRule, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/networkPolicies/[NETWORK_POLICY]";
            ExternalAccessRule externalAccessRule = new ExternalAccessRule();
            string externalAccessRuleId = "";
            // Make the request
            Operation<ExternalAccessRule, OperationMetadata> response = vmwareEngineClient.CreateExternalAccessRule(parent, externalAccessRule, externalAccessRuleId);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAccessRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExternalAccessRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAccessRule, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateExternalAccessRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAccessRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAccessRuleAsync</summary>
        public async Task CreateExternalAccessRuleAsync()
        {
            // Snippet: CreateExternalAccessRuleAsync(string, ExternalAccessRule, string, CallSettings)
            // Additional: CreateExternalAccessRuleAsync(string, ExternalAccessRule, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/networkPolicies/[NETWORK_POLICY]";
            ExternalAccessRule externalAccessRule = new ExternalAccessRule();
            string externalAccessRuleId = "";
            // Make the request
            Operation<ExternalAccessRule, OperationMetadata> response = await vmwareEngineClient.CreateExternalAccessRuleAsync(parent, externalAccessRule, externalAccessRuleId);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAccessRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExternalAccessRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAccessRule, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateExternalAccessRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAccessRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAccessRule</summary>
        public void CreateExternalAccessRuleResourceNames()
        {
            // Snippet: CreateExternalAccessRule(NetworkPolicyName, ExternalAccessRule, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            NetworkPolicyName parent = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]");
            ExternalAccessRule externalAccessRule = new ExternalAccessRule();
            string externalAccessRuleId = "";
            // Make the request
            Operation<ExternalAccessRule, OperationMetadata> response = vmwareEngineClient.CreateExternalAccessRule(parent, externalAccessRule, externalAccessRuleId);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAccessRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExternalAccessRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAccessRule, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateExternalAccessRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAccessRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAccessRuleAsync</summary>
        public async Task CreateExternalAccessRuleResourceNamesAsync()
        {
            // Snippet: CreateExternalAccessRuleAsync(NetworkPolicyName, ExternalAccessRule, string, CallSettings)
            // Additional: CreateExternalAccessRuleAsync(NetworkPolicyName, ExternalAccessRule, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            NetworkPolicyName parent = NetworkPolicyName.FromProjectLocationNetworkPolicy("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]");
            ExternalAccessRule externalAccessRule = new ExternalAccessRule();
            string externalAccessRuleId = "";
            // Make the request
            Operation<ExternalAccessRule, OperationMetadata> response = await vmwareEngineClient.CreateExternalAccessRuleAsync(parent, externalAccessRule, externalAccessRuleId);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAccessRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExternalAccessRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAccessRule, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateExternalAccessRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAccessRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalAccessRule</summary>
        public void UpdateExternalAccessRuleRequestObject()
        {
            // Snippet: UpdateExternalAccessRule(UpdateExternalAccessRuleRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            UpdateExternalAccessRuleRequest request = new UpdateExternalAccessRuleRequest
            {
                UpdateMask = new FieldMask(),
                ExternalAccessRule = new ExternalAccessRule(),
                RequestId = "",
            };
            // Make the request
            Operation<ExternalAccessRule, OperationMetadata> response = vmwareEngineClient.UpdateExternalAccessRule(request);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAccessRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExternalAccessRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAccessRule, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateExternalAccessRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAccessRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalAccessRuleAsync</summary>
        public async Task UpdateExternalAccessRuleRequestObjectAsync()
        {
            // Snippet: UpdateExternalAccessRuleAsync(UpdateExternalAccessRuleRequest, CallSettings)
            // Additional: UpdateExternalAccessRuleAsync(UpdateExternalAccessRuleRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            UpdateExternalAccessRuleRequest request = new UpdateExternalAccessRuleRequest
            {
                UpdateMask = new FieldMask(),
                ExternalAccessRule = new ExternalAccessRule(),
                RequestId = "",
            };
            // Make the request
            Operation<ExternalAccessRule, OperationMetadata> response = await vmwareEngineClient.UpdateExternalAccessRuleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAccessRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExternalAccessRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAccessRule, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateExternalAccessRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAccessRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalAccessRule</summary>
        public void UpdateExternalAccessRule()
        {
            // Snippet: UpdateExternalAccessRule(ExternalAccessRule, FieldMask, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ExternalAccessRule externalAccessRule = new ExternalAccessRule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ExternalAccessRule, OperationMetadata> response = vmwareEngineClient.UpdateExternalAccessRule(externalAccessRule, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAccessRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExternalAccessRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAccessRule, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateExternalAccessRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAccessRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalAccessRuleAsync</summary>
        public async Task UpdateExternalAccessRuleAsync()
        {
            // Snippet: UpdateExternalAccessRuleAsync(ExternalAccessRule, FieldMask, CallSettings)
            // Additional: UpdateExternalAccessRuleAsync(ExternalAccessRule, FieldMask, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ExternalAccessRule externalAccessRule = new ExternalAccessRule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ExternalAccessRule, OperationMetadata> response = await vmwareEngineClient.UpdateExternalAccessRuleAsync(externalAccessRule, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ExternalAccessRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExternalAccessRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExternalAccessRule, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateExternalAccessRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExternalAccessRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalAccessRule</summary>
        public void DeleteExternalAccessRuleRequestObject()
        {
            // Snippet: DeleteExternalAccessRule(DeleteExternalAccessRuleRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DeleteExternalAccessRuleRequest request = new DeleteExternalAccessRuleRequest
            {
                ExternalAccessRuleName = ExternalAccessRuleName.FromProjectLocationNetworkPolicyExternalAccessRule("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]", "[EXTERNAL_ACCESS_RULE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteExternalAccessRule(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteExternalAccessRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalAccessRuleAsync</summary>
        public async Task DeleteExternalAccessRuleRequestObjectAsync()
        {
            // Snippet: DeleteExternalAccessRuleAsync(DeleteExternalAccessRuleRequest, CallSettings)
            // Additional: DeleteExternalAccessRuleAsync(DeleteExternalAccessRuleRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExternalAccessRuleRequest request = new DeleteExternalAccessRuleRequest
            {
                ExternalAccessRuleName = ExternalAccessRuleName.FromProjectLocationNetworkPolicyExternalAccessRule("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]", "[EXTERNAL_ACCESS_RULE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteExternalAccessRuleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteExternalAccessRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalAccessRule</summary>
        public void DeleteExternalAccessRule()
        {
            // Snippet: DeleteExternalAccessRule(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networkPolicies/[NETWORK_POLICY]/externalAccessRules/[EXTERNAL_ACCESS_RULE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteExternalAccessRule(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteExternalAccessRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalAccessRuleAsync</summary>
        public async Task DeleteExternalAccessRuleAsync()
        {
            // Snippet: DeleteExternalAccessRuleAsync(string, CallSettings)
            // Additional: DeleteExternalAccessRuleAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networkPolicies/[NETWORK_POLICY]/externalAccessRules/[EXTERNAL_ACCESS_RULE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteExternalAccessRuleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteExternalAccessRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalAccessRule</summary>
        public void DeleteExternalAccessRuleResourceNames()
        {
            // Snippet: DeleteExternalAccessRule(ExternalAccessRuleName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ExternalAccessRuleName name = ExternalAccessRuleName.FromProjectLocationNetworkPolicyExternalAccessRule("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]", "[EXTERNAL_ACCESS_RULE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteExternalAccessRule(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteExternalAccessRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalAccessRuleAsync</summary>
        public async Task DeleteExternalAccessRuleResourceNamesAsync()
        {
            // Snippet: DeleteExternalAccessRuleAsync(ExternalAccessRuleName, CallSettings)
            // Additional: DeleteExternalAccessRuleAsync(ExternalAccessRuleName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ExternalAccessRuleName name = ExternalAccessRuleName.FromProjectLocationNetworkPolicyExternalAccessRule("[PROJECT]", "[LOCATION]", "[NETWORK_POLICY]", "[EXTERNAL_ACCESS_RULE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteExternalAccessRuleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteExternalAccessRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListLoggingServers</summary>
        public void ListLoggingServersRequestObject()
        {
            // Snippet: ListLoggingServers(ListLoggingServersRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListLoggingServersRequest request = new ListLoggingServersRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListLoggingServersResponse, LoggingServer> response = vmwareEngineClient.ListLoggingServers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LoggingServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLoggingServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LoggingServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LoggingServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LoggingServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLoggingServersAsync</summary>
        public async Task ListLoggingServersRequestObjectAsync()
        {
            // Snippet: ListLoggingServersAsync(ListLoggingServersRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListLoggingServersRequest request = new ListLoggingServersRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListLoggingServersResponse, LoggingServer> response = vmwareEngineClient.ListLoggingServersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LoggingServer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLoggingServersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LoggingServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LoggingServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LoggingServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLoggingServers</summary>
        public void ListLoggingServers()
        {
            // Snippet: ListLoggingServers(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            PagedEnumerable<ListLoggingServersResponse, LoggingServer> response = vmwareEngineClient.ListLoggingServers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LoggingServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLoggingServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LoggingServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LoggingServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LoggingServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLoggingServersAsync</summary>
        public async Task ListLoggingServersAsync()
        {
            // Snippet: ListLoggingServersAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            PagedAsyncEnumerable<ListLoggingServersResponse, LoggingServer> response = vmwareEngineClient.ListLoggingServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LoggingServer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLoggingServersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LoggingServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LoggingServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LoggingServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLoggingServers</summary>
        public void ListLoggingServersResourceNames()
        {
            // Snippet: ListLoggingServers(PrivateCloudName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            PagedEnumerable<ListLoggingServersResponse, LoggingServer> response = vmwareEngineClient.ListLoggingServers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LoggingServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLoggingServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LoggingServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LoggingServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LoggingServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLoggingServersAsync</summary>
        public async Task ListLoggingServersResourceNamesAsync()
        {
            // Snippet: ListLoggingServersAsync(PrivateCloudName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            PagedAsyncEnumerable<ListLoggingServersResponse, LoggingServer> response = vmwareEngineClient.ListLoggingServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LoggingServer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLoggingServersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LoggingServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LoggingServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LoggingServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetLoggingServer</summary>
        public void GetLoggingServerRequestObject()
        {
            // Snippet: GetLoggingServer(GetLoggingServerRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetLoggingServerRequest request = new GetLoggingServerRequest
            {
                LoggingServerName = LoggingServerName.FromProjectLocationPrivateCloudLoggingServer("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[LOGGING_SERVER]"),
            };
            // Make the request
            LoggingServer response = vmwareEngineClient.GetLoggingServer(request);
            // End snippet
        }

        /// <summary>Snippet for GetLoggingServerAsync</summary>
        public async Task GetLoggingServerRequestObjectAsync()
        {
            // Snippet: GetLoggingServerAsync(GetLoggingServerRequest, CallSettings)
            // Additional: GetLoggingServerAsync(GetLoggingServerRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetLoggingServerRequest request = new GetLoggingServerRequest
            {
                LoggingServerName = LoggingServerName.FromProjectLocationPrivateCloudLoggingServer("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[LOGGING_SERVER]"),
            };
            // Make the request
            LoggingServer response = await vmwareEngineClient.GetLoggingServerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLoggingServer</summary>
        public void GetLoggingServer()
        {
            // Snippet: GetLoggingServer(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/loggingServers/[LOGGING_SERVER]";
            // Make the request
            LoggingServer response = vmwareEngineClient.GetLoggingServer(name);
            // End snippet
        }

        /// <summary>Snippet for GetLoggingServerAsync</summary>
        public async Task GetLoggingServerAsync()
        {
            // Snippet: GetLoggingServerAsync(string, CallSettings)
            // Additional: GetLoggingServerAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/loggingServers/[LOGGING_SERVER]";
            // Make the request
            LoggingServer response = await vmwareEngineClient.GetLoggingServerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLoggingServer</summary>
        public void GetLoggingServerResourceNames()
        {
            // Snippet: GetLoggingServer(LoggingServerName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            LoggingServerName name = LoggingServerName.FromProjectLocationPrivateCloudLoggingServer("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[LOGGING_SERVER]");
            // Make the request
            LoggingServer response = vmwareEngineClient.GetLoggingServer(name);
            // End snippet
        }

        /// <summary>Snippet for GetLoggingServerAsync</summary>
        public async Task GetLoggingServerResourceNamesAsync()
        {
            // Snippet: GetLoggingServerAsync(LoggingServerName, CallSettings)
            // Additional: GetLoggingServerAsync(LoggingServerName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            LoggingServerName name = LoggingServerName.FromProjectLocationPrivateCloudLoggingServer("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[LOGGING_SERVER]");
            // Make the request
            LoggingServer response = await vmwareEngineClient.GetLoggingServerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateLoggingServer</summary>
        public void CreateLoggingServerRequestObject()
        {
            // Snippet: CreateLoggingServer(CreateLoggingServerRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            CreateLoggingServerRequest request = new CreateLoggingServerRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                LoggingServer = new LoggingServer(),
                LoggingServerId = "",
                RequestId = "",
            };
            // Make the request
            Operation<LoggingServer, OperationMetadata> response = vmwareEngineClient.CreateLoggingServer(request);

            // Poll until the returned long-running operation is complete
            Operation<LoggingServer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LoggingServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LoggingServer, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateLoggingServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LoggingServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLoggingServerAsync</summary>
        public async Task CreateLoggingServerRequestObjectAsync()
        {
            // Snippet: CreateLoggingServerAsync(CreateLoggingServerRequest, CallSettings)
            // Additional: CreateLoggingServerAsync(CreateLoggingServerRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            CreateLoggingServerRequest request = new CreateLoggingServerRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                LoggingServer = new LoggingServer(),
                LoggingServerId = "",
                RequestId = "",
            };
            // Make the request
            Operation<LoggingServer, OperationMetadata> response = await vmwareEngineClient.CreateLoggingServerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<LoggingServer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LoggingServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LoggingServer, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateLoggingServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LoggingServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLoggingServer</summary>
        public void CreateLoggingServer()
        {
            // Snippet: CreateLoggingServer(string, LoggingServer, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            LoggingServer loggingServer = new LoggingServer();
            string loggingServerId = "";
            // Make the request
            Operation<LoggingServer, OperationMetadata> response = vmwareEngineClient.CreateLoggingServer(parent, loggingServer, loggingServerId);

            // Poll until the returned long-running operation is complete
            Operation<LoggingServer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LoggingServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LoggingServer, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateLoggingServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LoggingServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLoggingServerAsync</summary>
        public async Task CreateLoggingServerAsync()
        {
            // Snippet: CreateLoggingServerAsync(string, LoggingServer, string, CallSettings)
            // Additional: CreateLoggingServerAsync(string, LoggingServer, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            LoggingServer loggingServer = new LoggingServer();
            string loggingServerId = "";
            // Make the request
            Operation<LoggingServer, OperationMetadata> response = await vmwareEngineClient.CreateLoggingServerAsync(parent, loggingServer, loggingServerId);

            // Poll until the returned long-running operation is complete
            Operation<LoggingServer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LoggingServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LoggingServer, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateLoggingServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LoggingServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLoggingServer</summary>
        public void CreateLoggingServerResourceNames()
        {
            // Snippet: CreateLoggingServer(PrivateCloudName, LoggingServer, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            LoggingServer loggingServer = new LoggingServer();
            string loggingServerId = "";
            // Make the request
            Operation<LoggingServer, OperationMetadata> response = vmwareEngineClient.CreateLoggingServer(parent, loggingServer, loggingServerId);

            // Poll until the returned long-running operation is complete
            Operation<LoggingServer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LoggingServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LoggingServer, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateLoggingServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LoggingServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLoggingServerAsync</summary>
        public async Task CreateLoggingServerResourceNamesAsync()
        {
            // Snippet: CreateLoggingServerAsync(PrivateCloudName, LoggingServer, string, CallSettings)
            // Additional: CreateLoggingServerAsync(PrivateCloudName, LoggingServer, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            LoggingServer loggingServer = new LoggingServer();
            string loggingServerId = "";
            // Make the request
            Operation<LoggingServer, OperationMetadata> response = await vmwareEngineClient.CreateLoggingServerAsync(parent, loggingServer, loggingServerId);

            // Poll until the returned long-running operation is complete
            Operation<LoggingServer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LoggingServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LoggingServer, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateLoggingServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LoggingServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLoggingServer</summary>
        public void UpdateLoggingServerRequestObject()
        {
            // Snippet: UpdateLoggingServer(UpdateLoggingServerRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            UpdateLoggingServerRequest request = new UpdateLoggingServerRequest
            {
                UpdateMask = new FieldMask(),
                LoggingServer = new LoggingServer(),
                RequestId = "",
            };
            // Make the request
            Operation<LoggingServer, OperationMetadata> response = vmwareEngineClient.UpdateLoggingServer(request);

            // Poll until the returned long-running operation is complete
            Operation<LoggingServer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LoggingServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LoggingServer, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateLoggingServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LoggingServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLoggingServerAsync</summary>
        public async Task UpdateLoggingServerRequestObjectAsync()
        {
            // Snippet: UpdateLoggingServerAsync(UpdateLoggingServerRequest, CallSettings)
            // Additional: UpdateLoggingServerAsync(UpdateLoggingServerRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            UpdateLoggingServerRequest request = new UpdateLoggingServerRequest
            {
                UpdateMask = new FieldMask(),
                LoggingServer = new LoggingServer(),
                RequestId = "",
            };
            // Make the request
            Operation<LoggingServer, OperationMetadata> response = await vmwareEngineClient.UpdateLoggingServerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<LoggingServer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LoggingServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LoggingServer, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateLoggingServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LoggingServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLoggingServer</summary>
        public void UpdateLoggingServer()
        {
            // Snippet: UpdateLoggingServer(LoggingServer, FieldMask, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            LoggingServer loggingServer = new LoggingServer();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<LoggingServer, OperationMetadata> response = vmwareEngineClient.UpdateLoggingServer(loggingServer, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<LoggingServer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LoggingServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LoggingServer, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateLoggingServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LoggingServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLoggingServerAsync</summary>
        public async Task UpdateLoggingServerAsync()
        {
            // Snippet: UpdateLoggingServerAsync(LoggingServer, FieldMask, CallSettings)
            // Additional: UpdateLoggingServerAsync(LoggingServer, FieldMask, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            LoggingServer loggingServer = new LoggingServer();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<LoggingServer, OperationMetadata> response = await vmwareEngineClient.UpdateLoggingServerAsync(loggingServer, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<LoggingServer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LoggingServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LoggingServer, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateLoggingServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LoggingServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLoggingServer</summary>
        public void DeleteLoggingServerRequestObject()
        {
            // Snippet: DeleteLoggingServer(DeleteLoggingServerRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DeleteLoggingServerRequest request = new DeleteLoggingServerRequest
            {
                LoggingServerName = LoggingServerName.FromProjectLocationPrivateCloudLoggingServer("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[LOGGING_SERVER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteLoggingServer(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteLoggingServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLoggingServerAsync</summary>
        public async Task DeleteLoggingServerRequestObjectAsync()
        {
            // Snippet: DeleteLoggingServerAsync(DeleteLoggingServerRequest, CallSettings)
            // Additional: DeleteLoggingServerAsync(DeleteLoggingServerRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DeleteLoggingServerRequest request = new DeleteLoggingServerRequest
            {
                LoggingServerName = LoggingServerName.FromProjectLocationPrivateCloudLoggingServer("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[LOGGING_SERVER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteLoggingServerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteLoggingServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLoggingServer</summary>
        public void DeleteLoggingServer()
        {
            // Snippet: DeleteLoggingServer(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/loggingServers/[LOGGING_SERVER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteLoggingServer(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteLoggingServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLoggingServerAsync</summary>
        public async Task DeleteLoggingServerAsync()
        {
            // Snippet: DeleteLoggingServerAsync(string, CallSettings)
            // Additional: DeleteLoggingServerAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/loggingServers/[LOGGING_SERVER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteLoggingServerAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteLoggingServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLoggingServer</summary>
        public void DeleteLoggingServerResourceNames()
        {
            // Snippet: DeleteLoggingServer(LoggingServerName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            LoggingServerName name = LoggingServerName.FromProjectLocationPrivateCloudLoggingServer("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[LOGGING_SERVER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteLoggingServer(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteLoggingServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLoggingServerAsync</summary>
        public async Task DeleteLoggingServerResourceNamesAsync()
        {
            // Snippet: DeleteLoggingServerAsync(LoggingServerName, CallSettings)
            // Additional: DeleteLoggingServerAsync(LoggingServerName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            LoggingServerName name = LoggingServerName.FromProjectLocationPrivateCloudLoggingServer("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[LOGGING_SERVER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteLoggingServerAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteLoggingServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
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
                Username = "",
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
                Username = "",
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
                Username = "",
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
                Username = "",
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

        /// <summary>Snippet for GetDnsForwarding</summary>
        public void GetDnsForwardingRequestObject()
        {
            // Snippet: GetDnsForwarding(GetDnsForwardingRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetDnsForwardingRequest request = new GetDnsForwardingRequest
            {
                DnsForwardingName = DnsForwardingName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
            };
            // Make the request
            DnsForwarding response = vmwareEngineClient.GetDnsForwarding(request);
            // End snippet
        }

        /// <summary>Snippet for GetDnsForwardingAsync</summary>
        public async Task GetDnsForwardingRequestObjectAsync()
        {
            // Snippet: GetDnsForwardingAsync(GetDnsForwardingRequest, CallSettings)
            // Additional: GetDnsForwardingAsync(GetDnsForwardingRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetDnsForwardingRequest request = new GetDnsForwardingRequest
            {
                DnsForwardingName = DnsForwardingName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
            };
            // Make the request
            DnsForwarding response = await vmwareEngineClient.GetDnsForwardingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDnsForwarding</summary>
        public void GetDnsForwarding()
        {
            // Snippet: GetDnsForwarding(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/dnsForwarding";
            // Make the request
            DnsForwarding response = vmwareEngineClient.GetDnsForwarding(name);
            // End snippet
        }

        /// <summary>Snippet for GetDnsForwardingAsync</summary>
        public async Task GetDnsForwardingAsync()
        {
            // Snippet: GetDnsForwardingAsync(string, CallSettings)
            // Additional: GetDnsForwardingAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/dnsForwarding";
            // Make the request
            DnsForwarding response = await vmwareEngineClient.GetDnsForwardingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDnsForwarding</summary>
        public void GetDnsForwardingResourceNames()
        {
            // Snippet: GetDnsForwarding(DnsForwardingName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DnsForwardingName name = DnsForwardingName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            DnsForwarding response = vmwareEngineClient.GetDnsForwarding(name);
            // End snippet
        }

        /// <summary>Snippet for GetDnsForwardingAsync</summary>
        public async Task GetDnsForwardingResourceNamesAsync()
        {
            // Snippet: GetDnsForwardingAsync(DnsForwardingName, CallSettings)
            // Additional: GetDnsForwardingAsync(DnsForwardingName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DnsForwardingName name = DnsForwardingName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            DnsForwarding response = await vmwareEngineClient.GetDnsForwardingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDnsForwarding</summary>
        public void UpdateDnsForwardingRequestObject()
        {
            // Snippet: UpdateDnsForwarding(UpdateDnsForwardingRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            UpdateDnsForwardingRequest request = new UpdateDnsForwardingRequest
            {
                DnsForwarding = new DnsForwarding(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<DnsForwarding, OperationMetadata> response = vmwareEngineClient.UpdateDnsForwarding(request);

            // Poll until the returned long-running operation is complete
            Operation<DnsForwarding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DnsForwarding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsForwarding, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateDnsForwarding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsForwarding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDnsForwardingAsync</summary>
        public async Task UpdateDnsForwardingRequestObjectAsync()
        {
            // Snippet: UpdateDnsForwardingAsync(UpdateDnsForwardingRequest, CallSettings)
            // Additional: UpdateDnsForwardingAsync(UpdateDnsForwardingRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDnsForwardingRequest request = new UpdateDnsForwardingRequest
            {
                DnsForwarding = new DnsForwarding(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<DnsForwarding, OperationMetadata> response = await vmwareEngineClient.UpdateDnsForwardingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DnsForwarding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DnsForwarding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsForwarding, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateDnsForwardingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsForwarding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDnsForwarding</summary>
        public void UpdateDnsForwarding()
        {
            // Snippet: UpdateDnsForwarding(DnsForwarding, FieldMask, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DnsForwarding dnsForwarding = new DnsForwarding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DnsForwarding, OperationMetadata> response = vmwareEngineClient.UpdateDnsForwarding(dnsForwarding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DnsForwarding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DnsForwarding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsForwarding, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateDnsForwarding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsForwarding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDnsForwardingAsync</summary>
        public async Task UpdateDnsForwardingAsync()
        {
            // Snippet: UpdateDnsForwardingAsync(DnsForwarding, FieldMask, CallSettings)
            // Additional: UpdateDnsForwardingAsync(DnsForwarding, FieldMask, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DnsForwarding dnsForwarding = new DnsForwarding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DnsForwarding, OperationMetadata> response = await vmwareEngineClient.UpdateDnsForwardingAsync(dnsForwarding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DnsForwarding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DnsForwarding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsForwarding, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateDnsForwardingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsForwarding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetNetworkPeering</summary>
        public void GetNetworkPeeringRequestObject()
        {
            // Snippet: GetNetworkPeering(GetNetworkPeeringRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetNetworkPeeringRequest request = new GetNetworkPeeringRequest
            {
                NetworkPeeringName = NetworkPeeringName.FromProjectLocationNetworkPeering("[PROJECT]", "[LOCATION]", "[NETWORK_PEERING]"),
            };
            // Make the request
            NetworkPeering response = vmwareEngineClient.GetNetworkPeering(request);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkPeeringAsync</summary>
        public async Task GetNetworkPeeringRequestObjectAsync()
        {
            // Snippet: GetNetworkPeeringAsync(GetNetworkPeeringRequest, CallSettings)
            // Additional: GetNetworkPeeringAsync(GetNetworkPeeringRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetNetworkPeeringRequest request = new GetNetworkPeeringRequest
            {
                NetworkPeeringName = NetworkPeeringName.FromProjectLocationNetworkPeering("[PROJECT]", "[LOCATION]", "[NETWORK_PEERING]"),
            };
            // Make the request
            NetworkPeering response = await vmwareEngineClient.GetNetworkPeeringAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkPeering</summary>
        public void GetNetworkPeering()
        {
            // Snippet: GetNetworkPeering(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networkPeerings/[NETWORK_PEERING]";
            // Make the request
            NetworkPeering response = vmwareEngineClient.GetNetworkPeering(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkPeeringAsync</summary>
        public async Task GetNetworkPeeringAsync()
        {
            // Snippet: GetNetworkPeeringAsync(string, CallSettings)
            // Additional: GetNetworkPeeringAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networkPeerings/[NETWORK_PEERING]";
            // Make the request
            NetworkPeering response = await vmwareEngineClient.GetNetworkPeeringAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkPeering</summary>
        public void GetNetworkPeeringResourceNames()
        {
            // Snippet: GetNetworkPeering(NetworkPeeringName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            NetworkPeeringName name = NetworkPeeringName.FromProjectLocationNetworkPeering("[PROJECT]", "[LOCATION]", "[NETWORK_PEERING]");
            // Make the request
            NetworkPeering response = vmwareEngineClient.GetNetworkPeering(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkPeeringAsync</summary>
        public async Task GetNetworkPeeringResourceNamesAsync()
        {
            // Snippet: GetNetworkPeeringAsync(NetworkPeeringName, CallSettings)
            // Additional: GetNetworkPeeringAsync(NetworkPeeringName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            NetworkPeeringName name = NetworkPeeringName.FromProjectLocationNetworkPeering("[PROJECT]", "[LOCATION]", "[NETWORK_PEERING]");
            // Make the request
            NetworkPeering response = await vmwareEngineClient.GetNetworkPeeringAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNetworkPeerings</summary>
        public void ListNetworkPeeringsRequestObject()
        {
            // Snippet: ListNetworkPeerings(ListNetworkPeeringsRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListNetworkPeeringsRequest request = new ListNetworkPeeringsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListNetworkPeeringsResponse, NetworkPeering> response = vmwareEngineClient.ListNetworkPeerings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkPeering item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworkPeeringsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkPeering item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkPeering> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkPeering item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkPeeringsAsync</summary>
        public async Task ListNetworkPeeringsRequestObjectAsync()
        {
            // Snippet: ListNetworkPeeringsAsync(ListNetworkPeeringsRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworkPeeringsRequest request = new ListNetworkPeeringsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListNetworkPeeringsResponse, NetworkPeering> response = vmwareEngineClient.ListNetworkPeeringsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkPeering item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworkPeeringsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkPeering item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkPeering> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkPeering item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkPeerings</summary>
        public void ListNetworkPeerings()
        {
            // Snippet: ListNetworkPeerings(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListNetworkPeeringsResponse, NetworkPeering> response = vmwareEngineClient.ListNetworkPeerings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkPeering item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworkPeeringsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkPeering item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkPeering> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkPeering item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkPeeringsAsync</summary>
        public async Task ListNetworkPeeringsAsync()
        {
            // Snippet: ListNetworkPeeringsAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListNetworkPeeringsResponse, NetworkPeering> response = vmwareEngineClient.ListNetworkPeeringsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkPeering item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworkPeeringsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkPeering item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkPeering> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkPeering item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkPeerings</summary>
        public void ListNetworkPeeringsResourceNames()
        {
            // Snippet: ListNetworkPeerings(LocationName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNetworkPeeringsResponse, NetworkPeering> response = vmwareEngineClient.ListNetworkPeerings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkPeering item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworkPeeringsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkPeering item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkPeering> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkPeering item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkPeeringsAsync</summary>
        public async Task ListNetworkPeeringsResourceNamesAsync()
        {
            // Snippet: ListNetworkPeeringsAsync(LocationName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNetworkPeeringsResponse, NetworkPeering> response = vmwareEngineClient.ListNetworkPeeringsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkPeering item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworkPeeringsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkPeering item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkPeering> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkPeering item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkPeering</summary>
        public void CreateNetworkPeeringRequestObject()
        {
            // Snippet: CreateNetworkPeering(CreateNetworkPeeringRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            CreateNetworkPeeringRequest request = new CreateNetworkPeeringRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NetworkPeeringId = "",
                NetworkPeering = new NetworkPeering(),
                RequestId = "",
            };
            // Make the request
            Operation<NetworkPeering, OperationMetadata> response = vmwareEngineClient.CreateNetworkPeering(request);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPeering, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NetworkPeering result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPeering, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateNetworkPeering(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPeering retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkPeeringAsync</summary>
        public async Task CreateNetworkPeeringRequestObjectAsync()
        {
            // Snippet: CreateNetworkPeeringAsync(CreateNetworkPeeringRequest, CallSettings)
            // Additional: CreateNetworkPeeringAsync(CreateNetworkPeeringRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            CreateNetworkPeeringRequest request = new CreateNetworkPeeringRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NetworkPeeringId = "",
                NetworkPeering = new NetworkPeering(),
                RequestId = "",
            };
            // Make the request
            Operation<NetworkPeering, OperationMetadata> response = await vmwareEngineClient.CreateNetworkPeeringAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPeering, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NetworkPeering result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPeering, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateNetworkPeeringAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPeering retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkPeering</summary>
        public void CreateNetworkPeering()
        {
            // Snippet: CreateNetworkPeering(string, NetworkPeering, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            NetworkPeering networkPeering = new NetworkPeering();
            string networkPeeringId = "";
            // Make the request
            Operation<NetworkPeering, OperationMetadata> response = vmwareEngineClient.CreateNetworkPeering(parent, networkPeering, networkPeeringId);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPeering, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NetworkPeering result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPeering, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateNetworkPeering(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPeering retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkPeeringAsync</summary>
        public async Task CreateNetworkPeeringAsync()
        {
            // Snippet: CreateNetworkPeeringAsync(string, NetworkPeering, string, CallSettings)
            // Additional: CreateNetworkPeeringAsync(string, NetworkPeering, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            NetworkPeering networkPeering = new NetworkPeering();
            string networkPeeringId = "";
            // Make the request
            Operation<NetworkPeering, OperationMetadata> response = await vmwareEngineClient.CreateNetworkPeeringAsync(parent, networkPeering, networkPeeringId);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPeering, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NetworkPeering result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPeering, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateNetworkPeeringAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPeering retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkPeering</summary>
        public void CreateNetworkPeeringResourceNames()
        {
            // Snippet: CreateNetworkPeering(LocationName, NetworkPeering, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NetworkPeering networkPeering = new NetworkPeering();
            string networkPeeringId = "";
            // Make the request
            Operation<NetworkPeering, OperationMetadata> response = vmwareEngineClient.CreateNetworkPeering(parent, networkPeering, networkPeeringId);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPeering, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NetworkPeering result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPeering, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateNetworkPeering(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPeering retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkPeeringAsync</summary>
        public async Task CreateNetworkPeeringResourceNamesAsync()
        {
            // Snippet: CreateNetworkPeeringAsync(LocationName, NetworkPeering, string, CallSettings)
            // Additional: CreateNetworkPeeringAsync(LocationName, NetworkPeering, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NetworkPeering networkPeering = new NetworkPeering();
            string networkPeeringId = "";
            // Make the request
            Operation<NetworkPeering, OperationMetadata> response = await vmwareEngineClient.CreateNetworkPeeringAsync(parent, networkPeering, networkPeeringId);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPeering, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NetworkPeering result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPeering, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateNetworkPeeringAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPeering retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkPeering</summary>
        public void DeleteNetworkPeeringRequestObject()
        {
            // Snippet: DeleteNetworkPeering(DeleteNetworkPeeringRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DeleteNetworkPeeringRequest request = new DeleteNetworkPeeringRequest
            {
                NetworkPeeringName = NetworkPeeringName.FromProjectLocationNetworkPeering("[PROJECT]", "[LOCATION]", "[NETWORK_PEERING]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteNetworkPeering(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteNetworkPeering(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkPeeringAsync</summary>
        public async Task DeleteNetworkPeeringRequestObjectAsync()
        {
            // Snippet: DeleteNetworkPeeringAsync(DeleteNetworkPeeringRequest, CallSettings)
            // Additional: DeleteNetworkPeeringAsync(DeleteNetworkPeeringRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNetworkPeeringRequest request = new DeleteNetworkPeeringRequest
            {
                NetworkPeeringName = NetworkPeeringName.FromProjectLocationNetworkPeering("[PROJECT]", "[LOCATION]", "[NETWORK_PEERING]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteNetworkPeeringAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteNetworkPeeringAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkPeering</summary>
        public void DeleteNetworkPeering()
        {
            // Snippet: DeleteNetworkPeering(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networkPeerings/[NETWORK_PEERING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteNetworkPeering(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteNetworkPeering(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkPeeringAsync</summary>
        public async Task DeleteNetworkPeeringAsync()
        {
            // Snippet: DeleteNetworkPeeringAsync(string, CallSettings)
            // Additional: DeleteNetworkPeeringAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networkPeerings/[NETWORK_PEERING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteNetworkPeeringAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteNetworkPeeringAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkPeering</summary>
        public void DeleteNetworkPeeringResourceNames()
        {
            // Snippet: DeleteNetworkPeering(NetworkPeeringName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            NetworkPeeringName name = NetworkPeeringName.FromProjectLocationNetworkPeering("[PROJECT]", "[LOCATION]", "[NETWORK_PEERING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteNetworkPeering(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteNetworkPeering(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkPeeringAsync</summary>
        public async Task DeleteNetworkPeeringResourceNamesAsync()
        {
            // Snippet: DeleteNetworkPeeringAsync(NetworkPeeringName, CallSettings)
            // Additional: DeleteNetworkPeeringAsync(NetworkPeeringName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            NetworkPeeringName name = NetworkPeeringName.FromProjectLocationNetworkPeering("[PROJECT]", "[LOCATION]", "[NETWORK_PEERING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteNetworkPeeringAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteNetworkPeeringAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNetworkPeering</summary>
        public void UpdateNetworkPeeringRequestObject()
        {
            // Snippet: UpdateNetworkPeering(UpdateNetworkPeeringRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            UpdateNetworkPeeringRequest request = new UpdateNetworkPeeringRequest
            {
                NetworkPeering = new NetworkPeering(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<NetworkPeering, OperationMetadata> response = vmwareEngineClient.UpdateNetworkPeering(request);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPeering, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NetworkPeering result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPeering, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateNetworkPeering(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPeering retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNetworkPeeringAsync</summary>
        public async Task UpdateNetworkPeeringRequestObjectAsync()
        {
            // Snippet: UpdateNetworkPeeringAsync(UpdateNetworkPeeringRequest, CallSettings)
            // Additional: UpdateNetworkPeeringAsync(UpdateNetworkPeeringRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNetworkPeeringRequest request = new UpdateNetworkPeeringRequest
            {
                NetworkPeering = new NetworkPeering(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<NetworkPeering, OperationMetadata> response = await vmwareEngineClient.UpdateNetworkPeeringAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPeering, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NetworkPeering result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPeering, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateNetworkPeeringAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPeering retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNetworkPeering</summary>
        public void UpdateNetworkPeering()
        {
            // Snippet: UpdateNetworkPeering(NetworkPeering, FieldMask, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            NetworkPeering networkPeering = new NetworkPeering();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<NetworkPeering, OperationMetadata> response = vmwareEngineClient.UpdateNetworkPeering(networkPeering, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPeering, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NetworkPeering result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPeering, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateNetworkPeering(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPeering retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNetworkPeeringAsync</summary>
        public async Task UpdateNetworkPeeringAsync()
        {
            // Snippet: UpdateNetworkPeeringAsync(NetworkPeering, FieldMask, CallSettings)
            // Additional: UpdateNetworkPeeringAsync(NetworkPeering, FieldMask, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            NetworkPeering networkPeering = new NetworkPeering();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<NetworkPeering, OperationMetadata> response = await vmwareEngineClient.UpdateNetworkPeeringAsync(networkPeering, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<NetworkPeering, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NetworkPeering result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NetworkPeering, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateNetworkPeeringAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NetworkPeering retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListPeeringRoutes</summary>
        public void ListPeeringRoutesRequestObject()
        {
            // Snippet: ListPeeringRoutes(ListPeeringRoutesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListPeeringRoutesRequest request = new ListPeeringRoutesRequest
            {
                ParentAsNetworkPeeringName = NetworkPeeringName.FromProjectLocationNetworkPeering("[PROJECT]", "[LOCATION]", "[NETWORK_PEERING]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListPeeringRoutesResponse, PeeringRoute> response = vmwareEngineClient.ListPeeringRoutes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PeeringRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPeeringRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PeeringRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PeeringRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PeeringRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPeeringRoutesAsync</summary>
        public async Task ListPeeringRoutesRequestObjectAsync()
        {
            // Snippet: ListPeeringRoutesAsync(ListPeeringRoutesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListPeeringRoutesRequest request = new ListPeeringRoutesRequest
            {
                ParentAsNetworkPeeringName = NetworkPeeringName.FromProjectLocationNetworkPeering("[PROJECT]", "[LOCATION]", "[NETWORK_PEERING]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPeeringRoutesResponse, PeeringRoute> response = vmwareEngineClient.ListPeeringRoutesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PeeringRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPeeringRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PeeringRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PeeringRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PeeringRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPeeringRoutes</summary>
        public void ListPeeringRoutes()
        {
            // Snippet: ListPeeringRoutes(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/networkPeerings/[NETWORK_PEERING]";
            // Make the request
            PagedEnumerable<ListPeeringRoutesResponse, PeeringRoute> response = vmwareEngineClient.ListPeeringRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PeeringRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPeeringRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PeeringRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PeeringRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PeeringRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPeeringRoutesAsync</summary>
        public async Task ListPeeringRoutesAsync()
        {
            // Snippet: ListPeeringRoutesAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/networkPeerings/[NETWORK_PEERING]";
            // Make the request
            PagedAsyncEnumerable<ListPeeringRoutesResponse, PeeringRoute> response = vmwareEngineClient.ListPeeringRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PeeringRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPeeringRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PeeringRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PeeringRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PeeringRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPeeringRoutes</summary>
        public void ListPeeringRoutesResourceNames()
        {
            // Snippet: ListPeeringRoutes(NetworkPeeringName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            NetworkPeeringName parent = NetworkPeeringName.FromProjectLocationNetworkPeering("[PROJECT]", "[LOCATION]", "[NETWORK_PEERING]");
            // Make the request
            PagedEnumerable<ListPeeringRoutesResponse, PeeringRoute> response = vmwareEngineClient.ListPeeringRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PeeringRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPeeringRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PeeringRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PeeringRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PeeringRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPeeringRoutesAsync</summary>
        public async Task ListPeeringRoutesResourceNamesAsync()
        {
            // Snippet: ListPeeringRoutesAsync(NetworkPeeringName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            NetworkPeeringName parent = NetworkPeeringName.FromProjectLocationNetworkPeering("[PROJECT]", "[LOCATION]", "[NETWORK_PEERING]");
            // Make the request
            PagedAsyncEnumerable<ListPeeringRoutesResponse, PeeringRoute> response = vmwareEngineClient.ListPeeringRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PeeringRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPeeringRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PeeringRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PeeringRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PeeringRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
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

        /// <summary>Snippet for ListManagementDnsZoneBindings</summary>
        public void ListManagementDnsZoneBindingsRequestObject()
        {
            // Snippet: ListManagementDnsZoneBindings(ListManagementDnsZoneBindingsRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListManagementDnsZoneBindingsRequest request = new ListManagementDnsZoneBindingsRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListManagementDnsZoneBindingsResponse, ManagementDnsZoneBinding> response = vmwareEngineClient.ListManagementDnsZoneBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagementDnsZoneBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListManagementDnsZoneBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagementDnsZoneBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagementDnsZoneBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagementDnsZoneBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagementDnsZoneBindingsAsync</summary>
        public async Task ListManagementDnsZoneBindingsRequestObjectAsync()
        {
            // Snippet: ListManagementDnsZoneBindingsAsync(ListManagementDnsZoneBindingsRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListManagementDnsZoneBindingsRequest request = new ListManagementDnsZoneBindingsRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListManagementDnsZoneBindingsResponse, ManagementDnsZoneBinding> response = vmwareEngineClient.ListManagementDnsZoneBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagementDnsZoneBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListManagementDnsZoneBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagementDnsZoneBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagementDnsZoneBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagementDnsZoneBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagementDnsZoneBindings</summary>
        public void ListManagementDnsZoneBindings()
        {
            // Snippet: ListManagementDnsZoneBindings(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            PagedEnumerable<ListManagementDnsZoneBindingsResponse, ManagementDnsZoneBinding> response = vmwareEngineClient.ListManagementDnsZoneBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagementDnsZoneBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListManagementDnsZoneBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagementDnsZoneBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagementDnsZoneBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagementDnsZoneBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagementDnsZoneBindingsAsync</summary>
        public async Task ListManagementDnsZoneBindingsAsync()
        {
            // Snippet: ListManagementDnsZoneBindingsAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            // Make the request
            PagedAsyncEnumerable<ListManagementDnsZoneBindingsResponse, ManagementDnsZoneBinding> response = vmwareEngineClient.ListManagementDnsZoneBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagementDnsZoneBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListManagementDnsZoneBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagementDnsZoneBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagementDnsZoneBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagementDnsZoneBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagementDnsZoneBindings</summary>
        public void ListManagementDnsZoneBindingsResourceNames()
        {
            // Snippet: ListManagementDnsZoneBindings(PrivateCloudName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            PagedEnumerable<ListManagementDnsZoneBindingsResponse, ManagementDnsZoneBinding> response = vmwareEngineClient.ListManagementDnsZoneBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagementDnsZoneBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListManagementDnsZoneBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagementDnsZoneBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagementDnsZoneBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagementDnsZoneBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagementDnsZoneBindingsAsync</summary>
        public async Task ListManagementDnsZoneBindingsResourceNamesAsync()
        {
            // Snippet: ListManagementDnsZoneBindingsAsync(PrivateCloudName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            // Make the request
            PagedAsyncEnumerable<ListManagementDnsZoneBindingsResponse, ManagementDnsZoneBinding> response = vmwareEngineClient.ListManagementDnsZoneBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagementDnsZoneBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListManagementDnsZoneBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagementDnsZoneBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagementDnsZoneBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagementDnsZoneBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetManagementDnsZoneBinding</summary>
        public void GetManagementDnsZoneBindingRequestObject()
        {
            // Snippet: GetManagementDnsZoneBinding(GetManagementDnsZoneBindingRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetManagementDnsZoneBindingRequest request = new GetManagementDnsZoneBindingRequest
            {
                ManagementDnsZoneBindingName = ManagementDnsZoneBindingName.FromProjectLocationPrivateCloudManagementDnsZoneBinding("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[MANAGEMENT_DNS_ZONE_BINDING]"),
            };
            // Make the request
            ManagementDnsZoneBinding response = vmwareEngineClient.GetManagementDnsZoneBinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetManagementDnsZoneBindingAsync</summary>
        public async Task GetManagementDnsZoneBindingRequestObjectAsync()
        {
            // Snippet: GetManagementDnsZoneBindingAsync(GetManagementDnsZoneBindingRequest, CallSettings)
            // Additional: GetManagementDnsZoneBindingAsync(GetManagementDnsZoneBindingRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetManagementDnsZoneBindingRequest request = new GetManagementDnsZoneBindingRequest
            {
                ManagementDnsZoneBindingName = ManagementDnsZoneBindingName.FromProjectLocationPrivateCloudManagementDnsZoneBinding("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[MANAGEMENT_DNS_ZONE_BINDING]"),
            };
            // Make the request
            ManagementDnsZoneBinding response = await vmwareEngineClient.GetManagementDnsZoneBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetManagementDnsZoneBinding</summary>
        public void GetManagementDnsZoneBinding()
        {
            // Snippet: GetManagementDnsZoneBinding(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/managementDnsZoneBindings/[MANAGEMENT_DNS_ZONE_BINDING]";
            // Make the request
            ManagementDnsZoneBinding response = vmwareEngineClient.GetManagementDnsZoneBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetManagementDnsZoneBindingAsync</summary>
        public async Task GetManagementDnsZoneBindingAsync()
        {
            // Snippet: GetManagementDnsZoneBindingAsync(string, CallSettings)
            // Additional: GetManagementDnsZoneBindingAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/managementDnsZoneBindings/[MANAGEMENT_DNS_ZONE_BINDING]";
            // Make the request
            ManagementDnsZoneBinding response = await vmwareEngineClient.GetManagementDnsZoneBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetManagementDnsZoneBinding</summary>
        public void GetManagementDnsZoneBindingResourceNames()
        {
            // Snippet: GetManagementDnsZoneBinding(ManagementDnsZoneBindingName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ManagementDnsZoneBindingName name = ManagementDnsZoneBindingName.FromProjectLocationPrivateCloudManagementDnsZoneBinding("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[MANAGEMENT_DNS_ZONE_BINDING]");
            // Make the request
            ManagementDnsZoneBinding response = vmwareEngineClient.GetManagementDnsZoneBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetManagementDnsZoneBindingAsync</summary>
        public async Task GetManagementDnsZoneBindingResourceNamesAsync()
        {
            // Snippet: GetManagementDnsZoneBindingAsync(ManagementDnsZoneBindingName, CallSettings)
            // Additional: GetManagementDnsZoneBindingAsync(ManagementDnsZoneBindingName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ManagementDnsZoneBindingName name = ManagementDnsZoneBindingName.FromProjectLocationPrivateCloudManagementDnsZoneBinding("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[MANAGEMENT_DNS_ZONE_BINDING]");
            // Make the request
            ManagementDnsZoneBinding response = await vmwareEngineClient.GetManagementDnsZoneBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateManagementDnsZoneBinding</summary>
        public void CreateManagementDnsZoneBindingRequestObject()
        {
            // Snippet: CreateManagementDnsZoneBinding(CreateManagementDnsZoneBindingRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            CreateManagementDnsZoneBindingRequest request = new CreateManagementDnsZoneBindingRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                ManagementDnsZoneBinding = new ManagementDnsZoneBinding(),
                ManagementDnsZoneBindingId = "",
                RequestId = "",
            };
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = vmwareEngineClient.CreateManagementDnsZoneBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateManagementDnsZoneBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateManagementDnsZoneBindingAsync</summary>
        public async Task CreateManagementDnsZoneBindingRequestObjectAsync()
        {
            // Snippet: CreateManagementDnsZoneBindingAsync(CreateManagementDnsZoneBindingRequest, CallSettings)
            // Additional: CreateManagementDnsZoneBindingAsync(CreateManagementDnsZoneBindingRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            CreateManagementDnsZoneBindingRequest request = new CreateManagementDnsZoneBindingRequest
            {
                ParentAsPrivateCloudName = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]"),
                ManagementDnsZoneBinding = new ManagementDnsZoneBinding(),
                ManagementDnsZoneBindingId = "",
                RequestId = "",
            };
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = await vmwareEngineClient.CreateManagementDnsZoneBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateManagementDnsZoneBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateManagementDnsZoneBinding</summary>
        public void CreateManagementDnsZoneBinding()
        {
            // Snippet: CreateManagementDnsZoneBinding(string, ManagementDnsZoneBinding, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            ManagementDnsZoneBinding managementDnsZoneBinding = new ManagementDnsZoneBinding();
            string managementDnsZoneBindingId = "";
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = vmwareEngineClient.CreateManagementDnsZoneBinding(parent, managementDnsZoneBinding, managementDnsZoneBindingId);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateManagementDnsZoneBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateManagementDnsZoneBindingAsync</summary>
        public async Task CreateManagementDnsZoneBindingAsync()
        {
            // Snippet: CreateManagementDnsZoneBindingAsync(string, ManagementDnsZoneBinding, string, CallSettings)
            // Additional: CreateManagementDnsZoneBindingAsync(string, ManagementDnsZoneBinding, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]";
            ManagementDnsZoneBinding managementDnsZoneBinding = new ManagementDnsZoneBinding();
            string managementDnsZoneBindingId = "";
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = await vmwareEngineClient.CreateManagementDnsZoneBindingAsync(parent, managementDnsZoneBinding, managementDnsZoneBindingId);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateManagementDnsZoneBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateManagementDnsZoneBinding</summary>
        public void CreateManagementDnsZoneBindingResourceNames()
        {
            // Snippet: CreateManagementDnsZoneBinding(PrivateCloudName, ManagementDnsZoneBinding, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            ManagementDnsZoneBinding managementDnsZoneBinding = new ManagementDnsZoneBinding();
            string managementDnsZoneBindingId = "";
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = vmwareEngineClient.CreateManagementDnsZoneBinding(parent, managementDnsZoneBinding, managementDnsZoneBindingId);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreateManagementDnsZoneBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateManagementDnsZoneBindingAsync</summary>
        public async Task CreateManagementDnsZoneBindingResourceNamesAsync()
        {
            // Snippet: CreateManagementDnsZoneBindingAsync(PrivateCloudName, ManagementDnsZoneBinding, string, CallSettings)
            // Additional: CreateManagementDnsZoneBindingAsync(PrivateCloudName, ManagementDnsZoneBinding, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateCloudName parent = PrivateCloudName.FromProjectLocationPrivateCloud("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]");
            ManagementDnsZoneBinding managementDnsZoneBinding = new ManagementDnsZoneBinding();
            string managementDnsZoneBindingId = "";
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = await vmwareEngineClient.CreateManagementDnsZoneBindingAsync(parent, managementDnsZoneBinding, managementDnsZoneBindingId);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreateManagementDnsZoneBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateManagementDnsZoneBinding</summary>
        public void UpdateManagementDnsZoneBindingRequestObject()
        {
            // Snippet: UpdateManagementDnsZoneBinding(UpdateManagementDnsZoneBindingRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            UpdateManagementDnsZoneBindingRequest request = new UpdateManagementDnsZoneBindingRequest
            {
                UpdateMask = new FieldMask(),
                ManagementDnsZoneBinding = new ManagementDnsZoneBinding(),
                RequestId = "",
            };
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = vmwareEngineClient.UpdateManagementDnsZoneBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateManagementDnsZoneBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateManagementDnsZoneBindingAsync</summary>
        public async Task UpdateManagementDnsZoneBindingRequestObjectAsync()
        {
            // Snippet: UpdateManagementDnsZoneBindingAsync(UpdateManagementDnsZoneBindingRequest, CallSettings)
            // Additional: UpdateManagementDnsZoneBindingAsync(UpdateManagementDnsZoneBindingRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            UpdateManagementDnsZoneBindingRequest request = new UpdateManagementDnsZoneBindingRequest
            {
                UpdateMask = new FieldMask(),
                ManagementDnsZoneBinding = new ManagementDnsZoneBinding(),
                RequestId = "",
            };
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = await vmwareEngineClient.UpdateManagementDnsZoneBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateManagementDnsZoneBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateManagementDnsZoneBinding</summary>
        public void UpdateManagementDnsZoneBinding()
        {
            // Snippet: UpdateManagementDnsZoneBinding(ManagementDnsZoneBinding, FieldMask, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ManagementDnsZoneBinding managementDnsZoneBinding = new ManagementDnsZoneBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = vmwareEngineClient.UpdateManagementDnsZoneBinding(managementDnsZoneBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdateManagementDnsZoneBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateManagementDnsZoneBindingAsync</summary>
        public async Task UpdateManagementDnsZoneBindingAsync()
        {
            // Snippet: UpdateManagementDnsZoneBindingAsync(ManagementDnsZoneBinding, FieldMask, CallSettings)
            // Additional: UpdateManagementDnsZoneBindingAsync(ManagementDnsZoneBinding, FieldMask, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ManagementDnsZoneBinding managementDnsZoneBinding = new ManagementDnsZoneBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = await vmwareEngineClient.UpdateManagementDnsZoneBindingAsync(managementDnsZoneBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdateManagementDnsZoneBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteManagementDnsZoneBinding</summary>
        public void DeleteManagementDnsZoneBindingRequestObject()
        {
            // Snippet: DeleteManagementDnsZoneBinding(DeleteManagementDnsZoneBindingRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DeleteManagementDnsZoneBindingRequest request = new DeleteManagementDnsZoneBindingRequest
            {
                ManagementDnsZoneBindingName = ManagementDnsZoneBindingName.FromProjectLocationPrivateCloudManagementDnsZoneBinding("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[MANAGEMENT_DNS_ZONE_BINDING]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteManagementDnsZoneBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteManagementDnsZoneBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteManagementDnsZoneBindingAsync</summary>
        public async Task DeleteManagementDnsZoneBindingRequestObjectAsync()
        {
            // Snippet: DeleteManagementDnsZoneBindingAsync(DeleteManagementDnsZoneBindingRequest, CallSettings)
            // Additional: DeleteManagementDnsZoneBindingAsync(DeleteManagementDnsZoneBindingRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DeleteManagementDnsZoneBindingRequest request = new DeleteManagementDnsZoneBindingRequest
            {
                ManagementDnsZoneBindingName = ManagementDnsZoneBindingName.FromProjectLocationPrivateCloudManagementDnsZoneBinding("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[MANAGEMENT_DNS_ZONE_BINDING]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteManagementDnsZoneBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteManagementDnsZoneBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteManagementDnsZoneBinding</summary>
        public void DeleteManagementDnsZoneBinding()
        {
            // Snippet: DeleteManagementDnsZoneBinding(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/managementDnsZoneBindings/[MANAGEMENT_DNS_ZONE_BINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteManagementDnsZoneBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteManagementDnsZoneBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteManagementDnsZoneBindingAsync</summary>
        public async Task DeleteManagementDnsZoneBindingAsync()
        {
            // Snippet: DeleteManagementDnsZoneBindingAsync(string, CallSettings)
            // Additional: DeleteManagementDnsZoneBindingAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/managementDnsZoneBindings/[MANAGEMENT_DNS_ZONE_BINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteManagementDnsZoneBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteManagementDnsZoneBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteManagementDnsZoneBinding</summary>
        public void DeleteManagementDnsZoneBindingResourceNames()
        {
            // Snippet: DeleteManagementDnsZoneBinding(ManagementDnsZoneBindingName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ManagementDnsZoneBindingName name = ManagementDnsZoneBindingName.FromProjectLocationPrivateCloudManagementDnsZoneBinding("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[MANAGEMENT_DNS_ZONE_BINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeleteManagementDnsZoneBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeleteManagementDnsZoneBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteManagementDnsZoneBindingAsync</summary>
        public async Task DeleteManagementDnsZoneBindingResourceNamesAsync()
        {
            // Snippet: DeleteManagementDnsZoneBindingAsync(ManagementDnsZoneBindingName, CallSettings)
            // Additional: DeleteManagementDnsZoneBindingAsync(ManagementDnsZoneBindingName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ManagementDnsZoneBindingName name = ManagementDnsZoneBindingName.FromProjectLocationPrivateCloudManagementDnsZoneBinding("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[MANAGEMENT_DNS_ZONE_BINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeleteManagementDnsZoneBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeleteManagementDnsZoneBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RepairManagementDnsZoneBinding</summary>
        public void RepairManagementDnsZoneBindingRequestObject()
        {
            // Snippet: RepairManagementDnsZoneBinding(RepairManagementDnsZoneBindingRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            RepairManagementDnsZoneBindingRequest request = new RepairManagementDnsZoneBindingRequest
            {
                ManagementDnsZoneBindingName = ManagementDnsZoneBindingName.FromProjectLocationPrivateCloudManagementDnsZoneBinding("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[MANAGEMENT_DNS_ZONE_BINDING]"),
                RequestId = "",
            };
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = vmwareEngineClient.RepairManagementDnsZoneBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceRepairManagementDnsZoneBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RepairManagementDnsZoneBindingAsync</summary>
        public async Task RepairManagementDnsZoneBindingRequestObjectAsync()
        {
            // Snippet: RepairManagementDnsZoneBindingAsync(RepairManagementDnsZoneBindingRequest, CallSettings)
            // Additional: RepairManagementDnsZoneBindingAsync(RepairManagementDnsZoneBindingRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            RepairManagementDnsZoneBindingRequest request = new RepairManagementDnsZoneBindingRequest
            {
                ManagementDnsZoneBindingName = ManagementDnsZoneBindingName.FromProjectLocationPrivateCloudManagementDnsZoneBinding("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[MANAGEMENT_DNS_ZONE_BINDING]"),
                RequestId = "",
            };
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = await vmwareEngineClient.RepairManagementDnsZoneBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceRepairManagementDnsZoneBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RepairManagementDnsZoneBinding</summary>
        public void RepairManagementDnsZoneBinding()
        {
            // Snippet: RepairManagementDnsZoneBinding(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/managementDnsZoneBindings/[MANAGEMENT_DNS_ZONE_BINDING]";
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = vmwareEngineClient.RepairManagementDnsZoneBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceRepairManagementDnsZoneBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RepairManagementDnsZoneBindingAsync</summary>
        public async Task RepairManagementDnsZoneBindingAsync()
        {
            // Snippet: RepairManagementDnsZoneBindingAsync(string, CallSettings)
            // Additional: RepairManagementDnsZoneBindingAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateClouds/[PRIVATE_CLOUD]/managementDnsZoneBindings/[MANAGEMENT_DNS_ZONE_BINDING]";
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = await vmwareEngineClient.RepairManagementDnsZoneBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceRepairManagementDnsZoneBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RepairManagementDnsZoneBinding</summary>
        public void RepairManagementDnsZoneBindingResourceNames()
        {
            // Snippet: RepairManagementDnsZoneBinding(ManagementDnsZoneBindingName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ManagementDnsZoneBindingName name = ManagementDnsZoneBindingName.FromProjectLocationPrivateCloudManagementDnsZoneBinding("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[MANAGEMENT_DNS_ZONE_BINDING]");
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = vmwareEngineClient.RepairManagementDnsZoneBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceRepairManagementDnsZoneBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RepairManagementDnsZoneBindingAsync</summary>
        public async Task RepairManagementDnsZoneBindingResourceNamesAsync()
        {
            // Snippet: RepairManagementDnsZoneBindingAsync(ManagementDnsZoneBindingName, CallSettings)
            // Additional: RepairManagementDnsZoneBindingAsync(ManagementDnsZoneBindingName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ManagementDnsZoneBindingName name = ManagementDnsZoneBindingName.FromProjectLocationPrivateCloudManagementDnsZoneBinding("[PROJECT]", "[LOCATION]", "[PRIVATE_CLOUD]", "[MANAGEMENT_DNS_ZONE_BINDING]");
            // Make the request
            Operation<ManagementDnsZoneBinding, OperationMetadata> response = await vmwareEngineClient.RepairManagementDnsZoneBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ManagementDnsZoneBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ManagementDnsZoneBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementDnsZoneBinding, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceRepairManagementDnsZoneBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementDnsZoneBinding retrievedResult = retrievedResponse.Result;
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

        /// <summary>Snippet for CreatePrivateConnection</summary>
        public void CreatePrivateConnectionRequestObject()
        {
            // Snippet: CreatePrivateConnection(CreatePrivateConnectionRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            CreatePrivateConnectionRequest request = new CreatePrivateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PrivateConnectionId = "",
                PrivateConnection = new PrivateConnection(),
                RequestId = "",
            };
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = vmwareEngineClient.CreatePrivateConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreatePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnectionAsync</summary>
        public async Task CreatePrivateConnectionRequestObjectAsync()
        {
            // Snippet: CreatePrivateConnectionAsync(CreatePrivateConnectionRequest, CallSettings)
            // Additional: CreatePrivateConnectionAsync(CreatePrivateConnectionRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            CreatePrivateConnectionRequest request = new CreatePrivateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PrivateConnectionId = "",
                PrivateConnection = new PrivateConnection(),
                RequestId = "",
            };
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = await vmwareEngineClient.CreatePrivateConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreatePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnection</summary>
        public void CreatePrivateConnection()
        {
            // Snippet: CreatePrivateConnection(string, PrivateConnection, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PrivateConnection privateConnection = new PrivateConnection();
            string privateConnectionId = "";
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = vmwareEngineClient.CreatePrivateConnection(parent, privateConnection, privateConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreatePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnectionAsync</summary>
        public async Task CreatePrivateConnectionAsync()
        {
            // Snippet: CreatePrivateConnectionAsync(string, PrivateConnection, string, CallSettings)
            // Additional: CreatePrivateConnectionAsync(string, PrivateConnection, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PrivateConnection privateConnection = new PrivateConnection();
            string privateConnectionId = "";
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = await vmwareEngineClient.CreatePrivateConnectionAsync(parent, privateConnection, privateConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreatePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnection</summary>
        public void CreatePrivateConnectionResourceNames()
        {
            // Snippet: CreatePrivateConnection(LocationName, PrivateConnection, string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PrivateConnection privateConnection = new PrivateConnection();
            string privateConnectionId = "";
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = vmwareEngineClient.CreatePrivateConnection(parent, privateConnection, privateConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceCreatePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnectionAsync</summary>
        public async Task CreatePrivateConnectionResourceNamesAsync()
        {
            // Snippet: CreatePrivateConnectionAsync(LocationName, PrivateConnection, string, CallSettings)
            // Additional: CreatePrivateConnectionAsync(LocationName, PrivateConnection, string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PrivateConnection privateConnection = new PrivateConnection();
            string privateConnectionId = "";
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = await vmwareEngineClient.CreatePrivateConnectionAsync(parent, privateConnection, privateConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceCreatePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnection</summary>
        public void GetPrivateConnectionRequestObject()
        {
            // Snippet: GetPrivateConnection(GetPrivateConnectionRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetPrivateConnectionRequest request = new GetPrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
            };
            // Make the request
            PrivateConnection response = vmwareEngineClient.GetPrivateConnection(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnectionAsync</summary>
        public async Task GetPrivateConnectionRequestObjectAsync()
        {
            // Snippet: GetPrivateConnectionAsync(GetPrivateConnectionRequest, CallSettings)
            // Additional: GetPrivateConnectionAsync(GetPrivateConnectionRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetPrivateConnectionRequest request = new GetPrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
            };
            // Make the request
            PrivateConnection response = await vmwareEngineClient.GetPrivateConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnection</summary>
        public void GetPrivateConnection()
        {
            // Snippet: GetPrivateConnection(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            PrivateConnection response = vmwareEngineClient.GetPrivateConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnectionAsync</summary>
        public async Task GetPrivateConnectionAsync()
        {
            // Snippet: GetPrivateConnectionAsync(string, CallSettings)
            // Additional: GetPrivateConnectionAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            PrivateConnection response = await vmwareEngineClient.GetPrivateConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnection</summary>
        public void GetPrivateConnectionResourceNames()
        {
            // Snippet: GetPrivateConnection(PrivateConnectionName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateConnectionName name = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            PrivateConnection response = vmwareEngineClient.GetPrivateConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnectionAsync</summary>
        public async Task GetPrivateConnectionResourceNamesAsync()
        {
            // Snippet: GetPrivateConnectionAsync(PrivateConnectionName, CallSettings)
            // Additional: GetPrivateConnectionAsync(PrivateConnectionName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateConnectionName name = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            PrivateConnection response = await vmwareEngineClient.GetPrivateConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnections</summary>
        public void ListPrivateConnectionsRequestObject()
        {
            // Snippet: ListPrivateConnections(ListPrivateConnectionsRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListPrivateConnectionsRequest request = new ListPrivateConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = vmwareEngineClient.ListPrivateConnections(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionsAsync</summary>
        public async Task ListPrivateConnectionsRequestObjectAsync()
        {
            // Snippet: ListPrivateConnectionsAsync(ListPrivateConnectionsRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListPrivateConnectionsRequest request = new ListPrivateConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = vmwareEngineClient.ListPrivateConnectionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnections</summary>
        public void ListPrivateConnections()
        {
            // Snippet: ListPrivateConnections(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = vmwareEngineClient.ListPrivateConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionsAsync</summary>
        public async Task ListPrivateConnectionsAsync()
        {
            // Snippet: ListPrivateConnectionsAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = vmwareEngineClient.ListPrivateConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnections</summary>
        public void ListPrivateConnectionsResourceNames()
        {
            // Snippet: ListPrivateConnections(LocationName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = vmwareEngineClient.ListPrivateConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionsAsync</summary>
        public async Task ListPrivateConnectionsResourceNamesAsync()
        {
            // Snippet: ListPrivateConnectionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = vmwareEngineClient.ListPrivateConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateConnection</summary>
        public void UpdatePrivateConnectionRequestObject()
        {
            // Snippet: UpdatePrivateConnection(UpdatePrivateConnectionRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            UpdatePrivateConnectionRequest request = new UpdatePrivateConnectionRequest
            {
                PrivateConnection = new PrivateConnection(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = vmwareEngineClient.UpdatePrivateConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdatePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateConnectionAsync</summary>
        public async Task UpdatePrivateConnectionRequestObjectAsync()
        {
            // Snippet: UpdatePrivateConnectionAsync(UpdatePrivateConnectionRequest, CallSettings)
            // Additional: UpdatePrivateConnectionAsync(UpdatePrivateConnectionRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePrivateConnectionRequest request = new UpdatePrivateConnectionRequest
            {
                PrivateConnection = new PrivateConnection(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = await vmwareEngineClient.UpdatePrivateConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdatePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateConnection</summary>
        public void UpdatePrivateConnection()
        {
            // Snippet: UpdatePrivateConnection(PrivateConnection, FieldMask, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateConnection privateConnection = new PrivateConnection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = vmwareEngineClient.UpdatePrivateConnection(privateConnection, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceUpdatePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateConnectionAsync</summary>
        public async Task UpdatePrivateConnectionAsync()
        {
            // Snippet: UpdatePrivateConnectionAsync(PrivateConnection, FieldMask, CallSettings)
            // Additional: UpdatePrivateConnectionAsync(PrivateConnection, FieldMask, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateConnection privateConnection = new PrivateConnection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = await vmwareEngineClient.UpdatePrivateConnectionAsync(privateConnection, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceUpdatePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnection</summary>
        public void DeletePrivateConnectionRequestObject()
        {
            // Snippet: DeletePrivateConnection(DeletePrivateConnectionRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DeletePrivateConnectionRequest request = new DeletePrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeletePrivateConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeletePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnectionAsync</summary>
        public async Task DeletePrivateConnectionRequestObjectAsync()
        {
            // Snippet: DeletePrivateConnectionAsync(DeletePrivateConnectionRequest, CallSettings)
            // Additional: DeletePrivateConnectionAsync(DeletePrivateConnectionRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DeletePrivateConnectionRequest request = new DeletePrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeletePrivateConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeletePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnection</summary>
        public void DeletePrivateConnection()
        {
            // Snippet: DeletePrivateConnection(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeletePrivateConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeletePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnectionAsync</summary>
        public async Task DeletePrivateConnectionAsync()
        {
            // Snippet: DeletePrivateConnectionAsync(string, CallSettings)
            // Additional: DeletePrivateConnectionAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeletePrivateConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeletePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnection</summary>
        public void DeletePrivateConnectionResourceNames()
        {
            // Snippet: DeletePrivateConnection(PrivateConnectionName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateConnectionName name = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vmwareEngineClient.DeletePrivateConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceDeletePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnectionAsync</summary>
        public async Task DeletePrivateConnectionResourceNamesAsync()
        {
            // Snippet: DeletePrivateConnectionAsync(PrivateConnectionName, CallSettings)
            // Additional: DeletePrivateConnectionAsync(PrivateConnectionName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateConnectionName name = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vmwareEngineClient.DeletePrivateConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceDeletePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionPeeringRoutes</summary>
        public void ListPrivateConnectionPeeringRoutesRequestObject()
        {
            // Snippet: ListPrivateConnectionPeeringRoutes(ListPrivateConnectionPeeringRoutesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            ListPrivateConnectionPeeringRoutesRequest request = new ListPrivateConnectionPeeringRoutesRequest
            {
                ParentAsPrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
            };
            // Make the request
            PagedEnumerable<ListPrivateConnectionPeeringRoutesResponse, PeeringRoute> response = vmwareEngineClient.ListPrivateConnectionPeeringRoutes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PeeringRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateConnectionPeeringRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PeeringRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PeeringRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PeeringRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionPeeringRoutesAsync</summary>
        public async Task ListPrivateConnectionPeeringRoutesRequestObjectAsync()
        {
            // Snippet: ListPrivateConnectionPeeringRoutesAsync(ListPrivateConnectionPeeringRoutesRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            ListPrivateConnectionPeeringRoutesRequest request = new ListPrivateConnectionPeeringRoutesRequest
            {
                ParentAsPrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPrivateConnectionPeeringRoutesResponse, PeeringRoute> response = vmwareEngineClient.ListPrivateConnectionPeeringRoutesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PeeringRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateConnectionPeeringRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PeeringRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PeeringRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PeeringRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionPeeringRoutes</summary>
        public void ListPrivateConnectionPeeringRoutes()
        {
            // Snippet: ListPrivateConnectionPeeringRoutes(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            PagedEnumerable<ListPrivateConnectionPeeringRoutesResponse, PeeringRoute> response = vmwareEngineClient.ListPrivateConnectionPeeringRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PeeringRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateConnectionPeeringRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PeeringRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PeeringRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PeeringRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionPeeringRoutesAsync</summary>
        public async Task ListPrivateConnectionPeeringRoutesAsync()
        {
            // Snippet: ListPrivateConnectionPeeringRoutesAsync(string, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            PagedAsyncEnumerable<ListPrivateConnectionPeeringRoutesResponse, PeeringRoute> response = vmwareEngineClient.ListPrivateConnectionPeeringRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PeeringRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateConnectionPeeringRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PeeringRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PeeringRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PeeringRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionPeeringRoutes</summary>
        public void ListPrivateConnectionPeeringRoutesResourceNames()
        {
            // Snippet: ListPrivateConnectionPeeringRoutes(PrivateConnectionName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            PrivateConnectionName parent = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            PagedEnumerable<ListPrivateConnectionPeeringRoutesResponse, PeeringRoute> response = vmwareEngineClient.ListPrivateConnectionPeeringRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PeeringRoute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateConnectionPeeringRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PeeringRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PeeringRoute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PeeringRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionPeeringRoutesAsync</summary>
        public async Task ListPrivateConnectionPeeringRoutesResourceNamesAsync()
        {
            // Snippet: ListPrivateConnectionPeeringRoutesAsync(PrivateConnectionName, string, int?, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            PrivateConnectionName parent = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            PagedAsyncEnumerable<ListPrivateConnectionPeeringRoutesResponse, PeeringRoute> response = vmwareEngineClient.ListPrivateConnectionPeeringRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PeeringRoute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateConnectionPeeringRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PeeringRoute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PeeringRoute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PeeringRoute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GrantDnsBindPermission</summary>
        public void GrantDnsBindPermissionRequestObject()
        {
            // Snippet: GrantDnsBindPermission(GrantDnsBindPermissionRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GrantDnsBindPermissionRequest request = new GrantDnsBindPermissionRequest
            {
                DnsBindPermissionName = DnsBindPermissionName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Principal = new Principal(),
                RequestId = "",
            };
            // Make the request
            Operation<DnsBindPermission, OperationMetadata> response = vmwareEngineClient.GrantDnsBindPermission(request);

            // Poll until the returned long-running operation is complete
            Operation<DnsBindPermission, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DnsBindPermission result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsBindPermission, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceGrantDnsBindPermission(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsBindPermission retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GrantDnsBindPermissionAsync</summary>
        public async Task GrantDnsBindPermissionRequestObjectAsync()
        {
            // Snippet: GrantDnsBindPermissionAsync(GrantDnsBindPermissionRequest, CallSettings)
            // Additional: GrantDnsBindPermissionAsync(GrantDnsBindPermissionRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GrantDnsBindPermissionRequest request = new GrantDnsBindPermissionRequest
            {
                DnsBindPermissionName = DnsBindPermissionName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Principal = new Principal(),
                RequestId = "",
            };
            // Make the request
            Operation<DnsBindPermission, OperationMetadata> response = await vmwareEngineClient.GrantDnsBindPermissionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DnsBindPermission, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DnsBindPermission result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsBindPermission, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceGrantDnsBindPermissionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsBindPermission retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GrantDnsBindPermission</summary>
        public void GrantDnsBindPermission()
        {
            // Snippet: GrantDnsBindPermission(string, Principal, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dnsBindPermission";
            Principal principal = new Principal();
            // Make the request
            Operation<DnsBindPermission, OperationMetadata> response = vmwareEngineClient.GrantDnsBindPermission(name, principal);

            // Poll until the returned long-running operation is complete
            Operation<DnsBindPermission, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DnsBindPermission result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsBindPermission, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceGrantDnsBindPermission(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsBindPermission retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GrantDnsBindPermissionAsync</summary>
        public async Task GrantDnsBindPermissionAsync()
        {
            // Snippet: GrantDnsBindPermissionAsync(string, Principal, CallSettings)
            // Additional: GrantDnsBindPermissionAsync(string, Principal, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dnsBindPermission";
            Principal principal = new Principal();
            // Make the request
            Operation<DnsBindPermission, OperationMetadata> response = await vmwareEngineClient.GrantDnsBindPermissionAsync(name, principal);

            // Poll until the returned long-running operation is complete
            Operation<DnsBindPermission, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DnsBindPermission result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsBindPermission, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceGrantDnsBindPermissionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsBindPermission retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GrantDnsBindPermission</summary>
        public void GrantDnsBindPermissionResourceNames()
        {
            // Snippet: GrantDnsBindPermission(DnsBindPermissionName, Principal, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DnsBindPermissionName name = DnsBindPermissionName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Principal principal = new Principal();
            // Make the request
            Operation<DnsBindPermission, OperationMetadata> response = vmwareEngineClient.GrantDnsBindPermission(name, principal);

            // Poll until the returned long-running operation is complete
            Operation<DnsBindPermission, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DnsBindPermission result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsBindPermission, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceGrantDnsBindPermission(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsBindPermission retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GrantDnsBindPermissionAsync</summary>
        public async Task GrantDnsBindPermissionResourceNamesAsync()
        {
            // Snippet: GrantDnsBindPermissionAsync(DnsBindPermissionName, Principal, CallSettings)
            // Additional: GrantDnsBindPermissionAsync(DnsBindPermissionName, Principal, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DnsBindPermissionName name = DnsBindPermissionName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Principal principal = new Principal();
            // Make the request
            Operation<DnsBindPermission, OperationMetadata> response = await vmwareEngineClient.GrantDnsBindPermissionAsync(name, principal);

            // Poll until the returned long-running operation is complete
            Operation<DnsBindPermission, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DnsBindPermission result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsBindPermission, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceGrantDnsBindPermissionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsBindPermission retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDnsBindPermission</summary>
        public void GetDnsBindPermissionRequestObject()
        {
            // Snippet: GetDnsBindPermission(GetDnsBindPermissionRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            GetDnsBindPermissionRequest request = new GetDnsBindPermissionRequest
            {
                DnsBindPermissionName = DnsBindPermissionName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            DnsBindPermission response = vmwareEngineClient.GetDnsBindPermission(request);
            // End snippet
        }

        /// <summary>Snippet for GetDnsBindPermissionAsync</summary>
        public async Task GetDnsBindPermissionRequestObjectAsync()
        {
            // Snippet: GetDnsBindPermissionAsync(GetDnsBindPermissionRequest, CallSettings)
            // Additional: GetDnsBindPermissionAsync(GetDnsBindPermissionRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            GetDnsBindPermissionRequest request = new GetDnsBindPermissionRequest
            {
                DnsBindPermissionName = DnsBindPermissionName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            DnsBindPermission response = await vmwareEngineClient.GetDnsBindPermissionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDnsBindPermission</summary>
        public void GetDnsBindPermission()
        {
            // Snippet: GetDnsBindPermission(string, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dnsBindPermission";
            // Make the request
            DnsBindPermission response = vmwareEngineClient.GetDnsBindPermission(name);
            // End snippet
        }

        /// <summary>Snippet for GetDnsBindPermissionAsync</summary>
        public async Task GetDnsBindPermissionAsync()
        {
            // Snippet: GetDnsBindPermissionAsync(string, CallSettings)
            // Additional: GetDnsBindPermissionAsync(string, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dnsBindPermission";
            // Make the request
            DnsBindPermission response = await vmwareEngineClient.GetDnsBindPermissionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDnsBindPermission</summary>
        public void GetDnsBindPermissionResourceNames()
        {
            // Snippet: GetDnsBindPermission(DnsBindPermissionName, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DnsBindPermissionName name = DnsBindPermissionName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            DnsBindPermission response = vmwareEngineClient.GetDnsBindPermission(name);
            // End snippet
        }

        /// <summary>Snippet for GetDnsBindPermissionAsync</summary>
        public async Task GetDnsBindPermissionResourceNamesAsync()
        {
            // Snippet: GetDnsBindPermissionAsync(DnsBindPermissionName, CallSettings)
            // Additional: GetDnsBindPermissionAsync(DnsBindPermissionName, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DnsBindPermissionName name = DnsBindPermissionName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            DnsBindPermission response = await vmwareEngineClient.GetDnsBindPermissionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RevokeDnsBindPermission</summary>
        public void RevokeDnsBindPermissionRequestObject()
        {
            // Snippet: RevokeDnsBindPermission(RevokeDnsBindPermissionRequest, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            RevokeDnsBindPermissionRequest request = new RevokeDnsBindPermissionRequest
            {
                DnsBindPermissionName = DnsBindPermissionName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Principal = new Principal(),
                RequestId = "",
            };
            // Make the request
            Operation<DnsBindPermission, OperationMetadata> response = vmwareEngineClient.RevokeDnsBindPermission(request);

            // Poll until the returned long-running operation is complete
            Operation<DnsBindPermission, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DnsBindPermission result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsBindPermission, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceRevokeDnsBindPermission(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsBindPermission retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RevokeDnsBindPermissionAsync</summary>
        public async Task RevokeDnsBindPermissionRequestObjectAsync()
        {
            // Snippet: RevokeDnsBindPermissionAsync(RevokeDnsBindPermissionRequest, CallSettings)
            // Additional: RevokeDnsBindPermissionAsync(RevokeDnsBindPermissionRequest, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            RevokeDnsBindPermissionRequest request = new RevokeDnsBindPermissionRequest
            {
                DnsBindPermissionName = DnsBindPermissionName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Principal = new Principal(),
                RequestId = "",
            };
            // Make the request
            Operation<DnsBindPermission, OperationMetadata> response = await vmwareEngineClient.RevokeDnsBindPermissionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DnsBindPermission, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DnsBindPermission result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsBindPermission, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceRevokeDnsBindPermissionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsBindPermission retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RevokeDnsBindPermission</summary>
        public void RevokeDnsBindPermission()
        {
            // Snippet: RevokeDnsBindPermission(string, Principal, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dnsBindPermission";
            Principal principal = new Principal();
            // Make the request
            Operation<DnsBindPermission, OperationMetadata> response = vmwareEngineClient.RevokeDnsBindPermission(name, principal);

            // Poll until the returned long-running operation is complete
            Operation<DnsBindPermission, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DnsBindPermission result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsBindPermission, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceRevokeDnsBindPermission(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsBindPermission retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RevokeDnsBindPermissionAsync</summary>
        public async Task RevokeDnsBindPermissionAsync()
        {
            // Snippet: RevokeDnsBindPermissionAsync(string, Principal, CallSettings)
            // Additional: RevokeDnsBindPermissionAsync(string, Principal, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dnsBindPermission";
            Principal principal = new Principal();
            // Make the request
            Operation<DnsBindPermission, OperationMetadata> response = await vmwareEngineClient.RevokeDnsBindPermissionAsync(name, principal);

            // Poll until the returned long-running operation is complete
            Operation<DnsBindPermission, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DnsBindPermission result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsBindPermission, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceRevokeDnsBindPermissionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsBindPermission retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RevokeDnsBindPermission</summary>
        public void RevokeDnsBindPermissionResourceNames()
        {
            // Snippet: RevokeDnsBindPermission(DnsBindPermissionName, Principal, CallSettings)
            // Create client
            VmwareEngineClient vmwareEngineClient = VmwareEngineClient.Create();
            // Initialize request argument(s)
            DnsBindPermissionName name = DnsBindPermissionName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Principal principal = new Principal();
            // Make the request
            Operation<DnsBindPermission, OperationMetadata> response = vmwareEngineClient.RevokeDnsBindPermission(name, principal);

            // Poll until the returned long-running operation is complete
            Operation<DnsBindPermission, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DnsBindPermission result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsBindPermission, OperationMetadata> retrievedResponse = vmwareEngineClient.PollOnceRevokeDnsBindPermission(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsBindPermission retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RevokeDnsBindPermissionAsync</summary>
        public async Task RevokeDnsBindPermissionResourceNamesAsync()
        {
            // Snippet: RevokeDnsBindPermissionAsync(DnsBindPermissionName, Principal, CallSettings)
            // Additional: RevokeDnsBindPermissionAsync(DnsBindPermissionName, Principal, CancellationToken)
            // Create client
            VmwareEngineClient vmwareEngineClient = await VmwareEngineClient.CreateAsync();
            // Initialize request argument(s)
            DnsBindPermissionName name = DnsBindPermissionName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Principal principal = new Principal();
            // Make the request
            Operation<DnsBindPermission, OperationMetadata> response = await vmwareEngineClient.RevokeDnsBindPermissionAsync(name, principal);

            // Poll until the returned long-running operation is complete
            Operation<DnsBindPermission, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DnsBindPermission result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsBindPermission, OperationMetadata> retrievedResponse = await vmwareEngineClient.PollOnceRevokeDnsBindPermissionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsBindPermission retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
