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
    public sealed class AllGeneratedRegionSslCertificatesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionSslCertificateRequest, CallSettings)
            // Create client
            RegionSslCertificatesClient regionSslCertificatesClient = RegionSslCertificatesClient.Create();
            // Initialize request argument(s)
            DeleteRegionSslCertificateRequest request = new DeleteRegionSslCertificateRequest
            {
                RequestId = "",
                SslCertificate = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSslCertificatesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSslCertificatesClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteRegionSslCertificateRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionSslCertificateRequest, CancellationToken)
            // Create client
            RegionSslCertificatesClient regionSslCertificatesClient = await RegionSslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionSslCertificateRequest request = new DeleteRegionSslCertificateRequest
            {
                RequestId = "",
                SslCertificate = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSslCertificatesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSslCertificatesClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            RegionSslCertificatesClient regionSslCertificatesClient = RegionSslCertificatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string sslCertificate = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionSslCertificatesClient.Delete(project, region, sslCertificate);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSslCertificatesClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            RegionSslCertificatesClient regionSslCertificatesClient = await RegionSslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string sslCertificate = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSslCertificatesClient.DeleteAsync(project, region, sslCertificate);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSslCertificatesClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionSslCertificateRequest, CallSettings)
            // Create client
            RegionSslCertificatesClient regionSslCertificatesClient = RegionSslCertificatesClient.Create();
            // Initialize request argument(s)
            GetRegionSslCertificateRequest request = new GetRegionSslCertificateRequest
            {
                SslCertificate = "",
                Region = "",
                Project = "",
            };
            // Make the request
            SslCertificate response = regionSslCertificatesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionSslCertificateRequest, CallSettings)
            // Additional: GetAsync(GetRegionSslCertificateRequest, CancellationToken)
            // Create client
            RegionSslCertificatesClient regionSslCertificatesClient = await RegionSslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionSslCertificateRequest request = new GetRegionSslCertificateRequest
            {
                SslCertificate = "",
                Region = "",
                Project = "",
            };
            // Make the request
            SslCertificate response = await regionSslCertificatesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionSslCertificatesClient regionSslCertificatesClient = RegionSslCertificatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string sslCertificate = "";
            // Make the request
            SslCertificate response = regionSslCertificatesClient.Get(project, region, sslCertificate);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionSslCertificatesClient regionSslCertificatesClient = await RegionSslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string sslCertificate = "";
            // Make the request
            SslCertificate response = await regionSslCertificatesClient.GetAsync(project, region, sslCertificate);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionSslCertificateRequest, CallSettings)
            // Create client
            RegionSslCertificatesClient regionSslCertificatesClient = RegionSslCertificatesClient.Create();
            // Initialize request argument(s)
            InsertRegionSslCertificateRequest request = new InsertRegionSslCertificateRequest
            {
                RequestId = "",
                Region = "",
                SslCertificateResource = new SslCertificate(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSslCertificatesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSslCertificatesClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertRegionSslCertificateRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionSslCertificateRequest, CancellationToken)
            // Create client
            RegionSslCertificatesClient regionSslCertificatesClient = await RegionSslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionSslCertificateRequest request = new InsertRegionSslCertificateRequest
            {
                RequestId = "",
                Region = "",
                SslCertificateResource = new SslCertificate(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSslCertificatesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSslCertificatesClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, SslCertificate, CallSettings)
            // Create client
            RegionSslCertificatesClient regionSslCertificatesClient = RegionSslCertificatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            SslCertificate sslCertificateResource = new SslCertificate();
            // Make the request
            lro::Operation<Operation, Operation> response = regionSslCertificatesClient.Insert(project, region, sslCertificateResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSslCertificatesClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, SslCertificate, CallSettings)
            // Additional: InsertAsync(string, string, SslCertificate, CancellationToken)
            // Create client
            RegionSslCertificatesClient regionSslCertificatesClient = await RegionSslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            SslCertificate sslCertificateResource = new SslCertificate();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSslCertificatesClient.InsertAsync(project, region, sslCertificateResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSslCertificatesClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionSslCertificatesRequest, CallSettings)
            // Create client
            RegionSslCertificatesClient regionSslCertificatesClient = RegionSslCertificatesClient.Create();
            // Initialize request argument(s)
            ListRegionSslCertificatesRequest request = new ListRegionSslCertificatesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<SslCertificateList, SslCertificate> response = regionSslCertificatesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SslCertificate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SslCertificateList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SslCertificate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SslCertificate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SslCertificate item in singlePage)
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
            // Snippet: ListAsync(ListRegionSslCertificatesRequest, CallSettings)
            // Create client
            RegionSslCertificatesClient regionSslCertificatesClient = await RegionSslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionSslCertificatesRequest request = new ListRegionSslCertificatesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<SslCertificateList, SslCertificate> response = regionSslCertificatesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SslCertificate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SslCertificateList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SslCertificate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SslCertificate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SslCertificate item in singlePage)
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
            RegionSslCertificatesClient regionSslCertificatesClient = RegionSslCertificatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<SslCertificateList, SslCertificate> response = regionSslCertificatesClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SslCertificate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SslCertificateList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SslCertificate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SslCertificate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SslCertificate item in singlePage)
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
            RegionSslCertificatesClient regionSslCertificatesClient = await RegionSslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<SslCertificateList, SslCertificate> response = regionSslCertificatesClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SslCertificate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SslCertificateList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SslCertificate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SslCertificate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SslCertificate item in singlePage)
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
