// Copyright 2021 Google LLC
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

namespace Google.Cloud.Compute.V1.Snippets
{
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedExternalVpnGatewaysClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteExternalVpnGatewayRequest, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = ExternalVpnGatewaysClient.Create();
            // Initialize request argument(s)
            DeleteExternalVpnGatewayRequest request = new DeleteExternalVpnGatewayRequest
            {
                RequestId = "",
                ExternalVpnGateway = "",
                Project = "",
            };
            // Make the request
            Operation response = externalVpnGatewaysClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteExternalVpnGatewayRequest, CallSettings)
            // Additional: DeleteAsync(DeleteExternalVpnGatewayRequest, CancellationToken)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = await ExternalVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExternalVpnGatewayRequest request = new DeleteExternalVpnGatewayRequest
            {
                RequestId = "",
                ExternalVpnGateway = "",
                Project = "",
            };
            // Make the request
            Operation response = await externalVpnGatewaysClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = ExternalVpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string externalVpnGateway = "";
            // Make the request
            Operation response = externalVpnGatewaysClient.Delete(project, externalVpnGateway);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = await ExternalVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string externalVpnGateway = "";
            // Make the request
            Operation response = await externalVpnGatewaysClient.DeleteAsync(project, externalVpnGateway);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetExternalVpnGatewayRequest, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = ExternalVpnGatewaysClient.Create();
            // Initialize request argument(s)
            GetExternalVpnGatewayRequest request = new GetExternalVpnGatewayRequest
            {
                ExternalVpnGateway = "",
                Project = "",
            };
            // Make the request
            ExternalVpnGateway response = externalVpnGatewaysClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetExternalVpnGatewayRequest, CallSettings)
            // Additional: GetAsync(GetExternalVpnGatewayRequest, CancellationToken)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = await ExternalVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            GetExternalVpnGatewayRequest request = new GetExternalVpnGatewayRequest
            {
                ExternalVpnGateway = "",
                Project = "",
            };
            // Make the request
            ExternalVpnGateway response = await externalVpnGatewaysClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = ExternalVpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string externalVpnGateway = "";
            // Make the request
            ExternalVpnGateway response = externalVpnGatewaysClient.Get(project, externalVpnGateway);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = await ExternalVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string externalVpnGateway = "";
            // Make the request
            ExternalVpnGateway response = await externalVpnGatewaysClient.GetAsync(project, externalVpnGateway);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertExternalVpnGatewayRequest, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = ExternalVpnGatewaysClient.Create();
            // Initialize request argument(s)
            InsertExternalVpnGatewayRequest request = new InsertExternalVpnGatewayRequest
            {
                RequestId = "",
                Project = "",
                ExternalVpnGatewayResource = new ExternalVpnGateway(),
            };
            // Make the request
            Operation response = externalVpnGatewaysClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertExternalVpnGatewayRequest, CallSettings)
            // Additional: InsertAsync(InsertExternalVpnGatewayRequest, CancellationToken)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = await ExternalVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            InsertExternalVpnGatewayRequest request = new InsertExternalVpnGatewayRequest
            {
                RequestId = "",
                Project = "",
                ExternalVpnGatewayResource = new ExternalVpnGateway(),
            };
            // Make the request
            Operation response = await externalVpnGatewaysClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, ExternalVpnGateway, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = ExternalVpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            ExternalVpnGateway externalVpnGatewayResource = new ExternalVpnGateway();
            // Make the request
            Operation response = externalVpnGatewaysClient.Insert(project, externalVpnGatewayResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, ExternalVpnGateway, CallSettings)
            // Additional: InsertAsync(string, ExternalVpnGateway, CancellationToken)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = await ExternalVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            ExternalVpnGateway externalVpnGatewayResource = new ExternalVpnGateway();
            // Make the request
            Operation response = await externalVpnGatewaysClient.InsertAsync(project, externalVpnGatewayResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListExternalVpnGatewaysRequest, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = ExternalVpnGatewaysClient.Create();
            // Initialize request argument(s)
            ListExternalVpnGatewaysRequest request = new ListExternalVpnGatewaysRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ExternalVpnGatewayList, ExternalVpnGateway> response = externalVpnGatewaysClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExternalVpnGateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ExternalVpnGatewayList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalVpnGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalVpnGateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalVpnGateway item in singlePage)
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
            // Snippet: ListAsync(ListExternalVpnGatewaysRequest, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = await ExternalVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            ListExternalVpnGatewaysRequest request = new ListExternalVpnGatewaysRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ExternalVpnGatewayList, ExternalVpnGateway> response = externalVpnGatewaysClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExternalVpnGateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ExternalVpnGatewayList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalVpnGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalVpnGateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalVpnGateway item in singlePage)
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
            // Snippet: List(string, string, int?, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = ExternalVpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<ExternalVpnGatewayList, ExternalVpnGateway> response = externalVpnGatewaysClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExternalVpnGateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ExternalVpnGatewayList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalVpnGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalVpnGateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalVpnGateway item in singlePage)
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
            // Snippet: ListAsync(string, string, int?, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = await ExternalVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<ExternalVpnGatewayList, ExternalVpnGateway> response = externalVpnGatewaysClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExternalVpnGateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ExternalVpnGatewayList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExternalVpnGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExternalVpnGateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExternalVpnGateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsExternalVpnGatewayRequest, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = ExternalVpnGatewaysClient.Create();
            // Initialize request argument(s)
            SetLabelsExternalVpnGatewayRequest request = new SetLabelsExternalVpnGatewayRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            Operation response = externalVpnGatewaysClient.SetLabels(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsExternalVpnGatewayRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsExternalVpnGatewayRequest, CancellationToken)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = await ExternalVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsExternalVpnGatewayRequest request = new SetLabelsExternalVpnGatewayRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            Operation response = await externalVpnGatewaysClient.SetLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, GlobalSetLabelsRequest, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = ExternalVpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            Operation response = externalVpnGatewaysClient.SetLabels(project, resource, globalSetLabelsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CancellationToken)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = await ExternalVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            Operation response = await externalVpnGatewaysClient.SetLabelsAsync(project, resource, globalSetLabelsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsExternalVpnGatewayRequest, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = ExternalVpnGatewaysClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsExternalVpnGatewayRequest request = new TestIamPermissionsExternalVpnGatewayRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = externalVpnGatewaysClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsExternalVpnGatewayRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsExternalVpnGatewayRequest, CancellationToken)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = await ExternalVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsExternalVpnGatewayRequest request = new TestIamPermissionsExternalVpnGatewayRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await externalVpnGatewaysClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, TestPermissionsRequest, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = ExternalVpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = externalVpnGatewaysClient.TestIamPermissions(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = await ExternalVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await externalVpnGatewaysClient.TestIamPermissionsAsync(project, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
