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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionInstanceGroupsClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionInstanceGroupRequest, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            GetRegionInstanceGroupRequest request = new GetRegionInstanceGroupRequest
            {
                InstanceGroup = "",
                Region = "",
                Project = "",
            };
            // Make the request
            InstanceGroup response = regionInstanceGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionInstanceGroupRequest, CallSettings)
            // Additional: GetAsync(GetRegionInstanceGroupRequest, CancellationToken)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionInstanceGroupRequest request = new GetRegionInstanceGroupRequest
            {
                InstanceGroup = "",
                Region = "",
                Project = "",
            };
            // Make the request
            InstanceGroup response = await regionInstanceGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroup = "";
            // Make the request
            InstanceGroup response = regionInstanceGroupsClient.Get(project, region, instanceGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroup = "";
            // Make the request
            InstanceGroup response = await regionInstanceGroupsClient.GetAsync(project, region, instanceGroup);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionInstanceGroupsRequest, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            ListRegionInstanceGroupsRequest request = new ListRegionInstanceGroupsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<RegionInstanceGroupList, InstanceGroup> response = regionInstanceGroupsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionInstanceGroupList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRegionInstanceGroupsRequest, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionInstanceGroupsRequest request = new ListRegionInstanceGroupsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<RegionInstanceGroupList, InstanceGroup> response = regionInstanceGroupsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionInstanceGroupList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, string, int?, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<RegionInstanceGroupList, InstanceGroup> response = regionInstanceGroupsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionInstanceGroupList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, string, int?, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<RegionInstanceGroupList, InstanceGroup> response = regionInstanceGroupsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionInstanceGroupList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRegionInstanceGroupsRequest, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            ListInstancesRegionInstanceGroupsRequest request = new ListInstancesRegionInstanceGroupsRequest
            {
                RegionInstanceGroupsListInstancesRequestResource = new RegionInstanceGroupsListInstancesRequest(),
                InstanceGroup = "",
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<RegionInstanceGroupsListInstances, InstanceWithNamedPorts> response = regionInstanceGroupsClient.ListInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceWithNamedPorts item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionInstanceGroupsListInstances page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceWithNamedPorts item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceWithNamedPorts> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceWithNamedPorts item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesRequestObjectAsync()
        {
            // Snippet: ListInstancesAsync(ListInstancesRegionInstanceGroupsRequest, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRegionInstanceGroupsRequest request = new ListInstancesRegionInstanceGroupsRequest
            {
                RegionInstanceGroupsListInstancesRequestResource = new RegionInstanceGroupsListInstancesRequest(),
                InstanceGroup = "",
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<RegionInstanceGroupsListInstances, InstanceWithNamedPorts> response = regionInstanceGroupsClient.ListInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceWithNamedPorts item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionInstanceGroupsListInstances page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceWithNamedPorts item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceWithNamedPorts> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceWithNamedPorts item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstances()
        {
            // Snippet: ListInstances(string, string, string, RegionInstanceGroupsListInstancesRequest, string, int?, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroup = "";
            RegionInstanceGroupsListInstancesRequest regionInstanceGroupsListInstancesRequestResource = new RegionInstanceGroupsListInstancesRequest();
            // Make the request
            PagedEnumerable<RegionInstanceGroupsListInstances, InstanceWithNamedPorts> response = regionInstanceGroupsClient.ListInstances(project, region, instanceGroup, regionInstanceGroupsListInstancesRequestResource);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceWithNamedPorts item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionInstanceGroupsListInstances page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceWithNamedPorts item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceWithNamedPorts> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceWithNamedPorts item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesAsync()
        {
            // Snippet: ListInstancesAsync(string, string, string, RegionInstanceGroupsListInstancesRequest, string, int?, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroup = "";
            RegionInstanceGroupsListInstancesRequest regionInstanceGroupsListInstancesRequestResource = new RegionInstanceGroupsListInstancesRequest();
            // Make the request
            PagedAsyncEnumerable<RegionInstanceGroupsListInstances, InstanceWithNamedPorts> response = regionInstanceGroupsClient.ListInstancesAsync(project, region, instanceGroup, regionInstanceGroupsListInstancesRequestResource);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceWithNamedPorts item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionInstanceGroupsListInstances page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceWithNamedPorts item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceWithNamedPorts> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceWithNamedPorts item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SetNamedPorts</summary>
        public void SetNamedPortsRequestObject()
        {
            // Snippet: SetNamedPorts(SetNamedPortsRegionInstanceGroupRequest, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            SetNamedPortsRegionInstanceGroupRequest request = new SetNamedPortsRegionInstanceGroupRequest
            {
                RegionInstanceGroupsSetNamedPortsRequestResource = new RegionInstanceGroupsSetNamedPortsRequest(),
                RequestId = "",
                InstanceGroup = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupsClient.SetNamedPorts(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupsClient.PollOnceSetNamedPorts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetNamedPortsAsync</summary>
        public async Task SetNamedPortsRequestObjectAsync()
        {
            // Snippet: SetNamedPortsAsync(SetNamedPortsRegionInstanceGroupRequest, CallSettings)
            // Additional: SetNamedPortsAsync(SetNamedPortsRegionInstanceGroupRequest, CancellationToken)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            SetNamedPortsRegionInstanceGroupRequest request = new SetNamedPortsRegionInstanceGroupRequest
            {
                RegionInstanceGroupsSetNamedPortsRequestResource = new RegionInstanceGroupsSetNamedPortsRequest(),
                RequestId = "",
                InstanceGroup = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupsClient.SetNamedPortsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupsClient.PollOnceSetNamedPortsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetNamedPorts</summary>
        public void SetNamedPorts()
        {
            // Snippet: SetNamedPorts(string, string, string, RegionInstanceGroupsSetNamedPortsRequest, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroup = "";
            RegionInstanceGroupsSetNamedPortsRequest regionInstanceGroupsSetNamedPortsRequestResource = new RegionInstanceGroupsSetNamedPortsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupsClient.SetNamedPorts(project, region, instanceGroup, regionInstanceGroupsSetNamedPortsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupsClient.PollOnceSetNamedPorts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetNamedPortsAsync</summary>
        public async Task SetNamedPortsAsync()
        {
            // Snippet: SetNamedPortsAsync(string, string, string, RegionInstanceGroupsSetNamedPortsRequest, CallSettings)
            // Additional: SetNamedPortsAsync(string, string, string, RegionInstanceGroupsSetNamedPortsRequest, CancellationToken)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroup = "";
            RegionInstanceGroupsSetNamedPortsRequest regionInstanceGroupsSetNamedPortsRequestResource = new RegionInstanceGroupsSetNamedPortsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupsClient.SetNamedPortsAsync(project, region, instanceGroup, regionInstanceGroupsSetNamedPortsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupsClient.PollOnceSetNamedPortsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
