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
    public sealed class AllGeneratedTargetSslProxiesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteTargetSslProxyRequest, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            DeleteTargetSslProxyRequest request = new DeleteTargetSslProxyRequest
            {
                RequestId = "",
                Project = "",
                TargetSslProxy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetSslProxiesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetSslProxiesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteTargetSslProxyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteTargetSslProxyRequest, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTargetSslProxyRequest request = new DeleteTargetSslProxyRequest
            {
                RequestId = "",
                Project = "",
                TargetSslProxy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetSslProxiesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetSslProxiesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetSslProxy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = targetSslProxiesClient.Delete(project, targetSslProxy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetSslProxiesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetSslProxy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await targetSslProxiesClient.DeleteAsync(project, targetSslProxy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetSslProxiesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetTargetSslProxyRequest, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            GetTargetSslProxyRequest request = new GetTargetSslProxyRequest
            {
                Project = "",
                TargetSslProxy = "",
            };
            // Make the request
            TargetSslProxy response = targetSslProxiesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetTargetSslProxyRequest, CallSettings)
            // Additional: GetAsync(GetTargetSslProxyRequest, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            GetTargetSslProxyRequest request = new GetTargetSslProxyRequest
            {
                Project = "",
                TargetSslProxy = "",
            };
            // Make the request
            TargetSslProxy response = await targetSslProxiesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetSslProxy = "";
            // Make the request
            TargetSslProxy response = targetSslProxiesClient.Get(project, targetSslProxy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetSslProxy = "";
            // Make the request
            TargetSslProxy response = await targetSslProxiesClient.GetAsync(project, targetSslProxy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertTargetSslProxyRequest, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            InsertTargetSslProxyRequest request = new InsertTargetSslProxyRequest
            {
                RequestId = "",
                TargetSslProxyResource = new TargetSslProxy(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetSslProxiesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetSslProxiesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertTargetSslProxyRequest, CallSettings)
            // Additional: InsertAsync(InsertTargetSslProxyRequest, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            InsertTargetSslProxyRequest request = new InsertTargetSslProxyRequest
            {
                RequestId = "",
                TargetSslProxyResource = new TargetSslProxy(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetSslProxiesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetSslProxiesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, TargetSslProxy, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            TargetSslProxy targetSslProxyResource = new TargetSslProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = targetSslProxiesClient.Insert(project, targetSslProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetSslProxiesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, TargetSslProxy, CallSettings)
            // Additional: InsertAsync(string, TargetSslProxy, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            TargetSslProxy targetSslProxyResource = new TargetSslProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetSslProxiesClient.InsertAsync(project, targetSslProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetSslProxiesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListTargetSslProxiesRequest, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            ListTargetSslProxiesRequest request = new ListTargetSslProxiesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<TargetSslProxyList, TargetSslProxy> response = targetSslProxiesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetSslProxy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetSslProxyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetSslProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetSslProxy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetSslProxy item in singlePage)
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
            // Snippet: ListAsync(ListTargetSslProxiesRequest, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetSslProxiesRequest request = new ListTargetSslProxiesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<TargetSslProxyList, TargetSslProxy> response = targetSslProxiesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetSslProxy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetSslProxyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetSslProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetSslProxy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetSslProxy item in singlePage)
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
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<TargetSslProxyList, TargetSslProxy> response = targetSslProxiesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetSslProxy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetSslProxyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetSslProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetSslProxy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetSslProxy item in singlePage)
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
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<TargetSslProxyList, TargetSslProxy> response = targetSslProxiesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetSslProxy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetSslProxyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetSslProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetSslProxy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetSslProxy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SetBackendService</summary>
        public void SetBackendServiceRequestObject()
        {
            // Snippet: SetBackendService(SetBackendServiceTargetSslProxyRequest, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            SetBackendServiceTargetSslProxyRequest request = new SetBackendServiceTargetSslProxyRequest
            {
                RequestId = "",
                TargetSslProxiesSetBackendServiceRequestResource = new TargetSslProxiesSetBackendServiceRequest(),
                Project = "",
                TargetSslProxy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetSslProxiesClient.SetBackendService(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetSslProxiesClient.PollOnceSetBackendService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetBackendServiceAsync</summary>
        public async Task SetBackendServiceRequestObjectAsync()
        {
            // Snippet: SetBackendServiceAsync(SetBackendServiceTargetSslProxyRequest, CallSettings)
            // Additional: SetBackendServiceAsync(SetBackendServiceTargetSslProxyRequest, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetBackendServiceTargetSslProxyRequest request = new SetBackendServiceTargetSslProxyRequest
            {
                RequestId = "",
                TargetSslProxiesSetBackendServiceRequestResource = new TargetSslProxiesSetBackendServiceRequest(),
                Project = "",
                TargetSslProxy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetSslProxiesClient.SetBackendServiceAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetSslProxiesClient.PollOnceSetBackendServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetBackendService</summary>
        public void SetBackendService()
        {
            // Snippet: SetBackendService(string, string, TargetSslProxiesSetBackendServiceRequest, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetSslProxy = "";
            TargetSslProxiesSetBackendServiceRequest targetSslProxiesSetBackendServiceRequestResource = new TargetSslProxiesSetBackendServiceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = targetSslProxiesClient.SetBackendService(project, targetSslProxy, targetSslProxiesSetBackendServiceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetSslProxiesClient.PollOnceSetBackendService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetBackendServiceAsync</summary>
        public async Task SetBackendServiceAsync()
        {
            // Snippet: SetBackendServiceAsync(string, string, TargetSslProxiesSetBackendServiceRequest, CallSettings)
            // Additional: SetBackendServiceAsync(string, string, TargetSslProxiesSetBackendServiceRequest, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetSslProxy = "";
            TargetSslProxiesSetBackendServiceRequest targetSslProxiesSetBackendServiceRequestResource = new TargetSslProxiesSetBackendServiceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetSslProxiesClient.SetBackendServiceAsync(project, targetSslProxy, targetSslProxiesSetBackendServiceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetSslProxiesClient.PollOnceSetBackendServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCertificateMap</summary>
        public void SetCertificateMapRequestObject()
        {
            // Snippet: SetCertificateMap(SetCertificateMapTargetSslProxyRequest, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            SetCertificateMapTargetSslProxyRequest request = new SetCertificateMapTargetSslProxyRequest
            {
                RequestId = "",
                Project = "",
                TargetSslProxy = "",
                TargetSslProxiesSetCertificateMapRequestResource = new TargetSslProxiesSetCertificateMapRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetSslProxiesClient.SetCertificateMap(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetSslProxiesClient.PollOnceSetCertificateMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCertificateMapAsync</summary>
        public async Task SetCertificateMapRequestObjectAsync()
        {
            // Snippet: SetCertificateMapAsync(SetCertificateMapTargetSslProxyRequest, CallSettings)
            // Additional: SetCertificateMapAsync(SetCertificateMapTargetSslProxyRequest, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetCertificateMapTargetSslProxyRequest request = new SetCertificateMapTargetSslProxyRequest
            {
                RequestId = "",
                Project = "",
                TargetSslProxy = "",
                TargetSslProxiesSetCertificateMapRequestResource = new TargetSslProxiesSetCertificateMapRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetSslProxiesClient.SetCertificateMapAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetSslProxiesClient.PollOnceSetCertificateMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCertificateMap</summary>
        public void SetCertificateMap()
        {
            // Snippet: SetCertificateMap(string, string, TargetSslProxiesSetCertificateMapRequest, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetSslProxy = "";
            TargetSslProxiesSetCertificateMapRequest targetSslProxiesSetCertificateMapRequestResource = new TargetSslProxiesSetCertificateMapRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = targetSslProxiesClient.SetCertificateMap(project, targetSslProxy, targetSslProxiesSetCertificateMapRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetSslProxiesClient.PollOnceSetCertificateMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCertificateMapAsync</summary>
        public async Task SetCertificateMapAsync()
        {
            // Snippet: SetCertificateMapAsync(string, string, TargetSslProxiesSetCertificateMapRequest, CallSettings)
            // Additional: SetCertificateMapAsync(string, string, TargetSslProxiesSetCertificateMapRequest, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetSslProxy = "";
            TargetSslProxiesSetCertificateMapRequest targetSslProxiesSetCertificateMapRequestResource = new TargetSslProxiesSetCertificateMapRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetSslProxiesClient.SetCertificateMapAsync(project, targetSslProxy, targetSslProxiesSetCertificateMapRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetSslProxiesClient.PollOnceSetCertificateMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetProxyHeader</summary>
        public void SetProxyHeaderRequestObject()
        {
            // Snippet: SetProxyHeader(SetProxyHeaderTargetSslProxyRequest, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            SetProxyHeaderTargetSslProxyRequest request = new SetProxyHeaderTargetSslProxyRequest
            {
                RequestId = "",
                TargetSslProxiesSetProxyHeaderRequestResource = new TargetSslProxiesSetProxyHeaderRequest(),
                Project = "",
                TargetSslProxy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetSslProxiesClient.SetProxyHeader(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetSslProxiesClient.PollOnceSetProxyHeader(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetProxyHeaderAsync</summary>
        public async Task SetProxyHeaderRequestObjectAsync()
        {
            // Snippet: SetProxyHeaderAsync(SetProxyHeaderTargetSslProxyRequest, CallSettings)
            // Additional: SetProxyHeaderAsync(SetProxyHeaderTargetSslProxyRequest, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetProxyHeaderTargetSslProxyRequest request = new SetProxyHeaderTargetSslProxyRequest
            {
                RequestId = "",
                TargetSslProxiesSetProxyHeaderRequestResource = new TargetSslProxiesSetProxyHeaderRequest(),
                Project = "",
                TargetSslProxy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetSslProxiesClient.SetProxyHeaderAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetSslProxiesClient.PollOnceSetProxyHeaderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetProxyHeader</summary>
        public void SetProxyHeader()
        {
            // Snippet: SetProxyHeader(string, string, TargetSslProxiesSetProxyHeaderRequest, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetSslProxy = "";
            TargetSslProxiesSetProxyHeaderRequest targetSslProxiesSetProxyHeaderRequestResource = new TargetSslProxiesSetProxyHeaderRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = targetSslProxiesClient.SetProxyHeader(project, targetSslProxy, targetSslProxiesSetProxyHeaderRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetSslProxiesClient.PollOnceSetProxyHeader(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetProxyHeaderAsync</summary>
        public async Task SetProxyHeaderAsync()
        {
            // Snippet: SetProxyHeaderAsync(string, string, TargetSslProxiesSetProxyHeaderRequest, CallSettings)
            // Additional: SetProxyHeaderAsync(string, string, TargetSslProxiesSetProxyHeaderRequest, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetSslProxy = "";
            TargetSslProxiesSetProxyHeaderRequest targetSslProxiesSetProxyHeaderRequestResource = new TargetSslProxiesSetProxyHeaderRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetSslProxiesClient.SetProxyHeaderAsync(project, targetSslProxy, targetSslProxiesSetProxyHeaderRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetSslProxiesClient.PollOnceSetProxyHeaderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslCertificates</summary>
        public void SetSslCertificatesRequestObject()
        {
            // Snippet: SetSslCertificates(SetSslCertificatesTargetSslProxyRequest, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            SetSslCertificatesTargetSslProxyRequest request = new SetSslCertificatesTargetSslProxyRequest
            {
                RequestId = "",
                TargetSslProxiesSetSslCertificatesRequestResource = new TargetSslProxiesSetSslCertificatesRequest(),
                Project = "",
                TargetSslProxy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetSslProxiesClient.SetSslCertificates(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetSslProxiesClient.PollOnceSetSslCertificates(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslCertificatesAsync</summary>
        public async Task SetSslCertificatesRequestObjectAsync()
        {
            // Snippet: SetSslCertificatesAsync(SetSslCertificatesTargetSslProxyRequest, CallSettings)
            // Additional: SetSslCertificatesAsync(SetSslCertificatesTargetSslProxyRequest, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetSslCertificatesTargetSslProxyRequest request = new SetSslCertificatesTargetSslProxyRequest
            {
                RequestId = "",
                TargetSslProxiesSetSslCertificatesRequestResource = new TargetSslProxiesSetSslCertificatesRequest(),
                Project = "",
                TargetSslProxy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetSslProxiesClient.SetSslCertificatesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetSslProxiesClient.PollOnceSetSslCertificatesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslCertificates</summary>
        public void SetSslCertificates()
        {
            // Snippet: SetSslCertificates(string, string, TargetSslProxiesSetSslCertificatesRequest, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetSslProxy = "";
            TargetSslProxiesSetSslCertificatesRequest targetSslProxiesSetSslCertificatesRequestResource = new TargetSslProxiesSetSslCertificatesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = targetSslProxiesClient.SetSslCertificates(project, targetSslProxy, targetSslProxiesSetSslCertificatesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetSslProxiesClient.PollOnceSetSslCertificates(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslCertificatesAsync</summary>
        public async Task SetSslCertificatesAsync()
        {
            // Snippet: SetSslCertificatesAsync(string, string, TargetSslProxiesSetSslCertificatesRequest, CallSettings)
            // Additional: SetSslCertificatesAsync(string, string, TargetSslProxiesSetSslCertificatesRequest, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetSslProxy = "";
            TargetSslProxiesSetSslCertificatesRequest targetSslProxiesSetSslCertificatesRequestResource = new TargetSslProxiesSetSslCertificatesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetSslProxiesClient.SetSslCertificatesAsync(project, targetSslProxy, targetSslProxiesSetSslCertificatesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetSslProxiesClient.PollOnceSetSslCertificatesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslPolicy</summary>
        public void SetSslPolicyRequestObject()
        {
            // Snippet: SetSslPolicy(SetSslPolicyTargetSslProxyRequest, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            SetSslPolicyTargetSslProxyRequest request = new SetSslPolicyTargetSslProxyRequest
            {
                RequestId = "",
                Project = "",
                SslPolicyReferenceResource = new SslPolicyReference(),
                TargetSslProxy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetSslProxiesClient.SetSslPolicy(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetSslProxiesClient.PollOnceSetSslPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslPolicyAsync</summary>
        public async Task SetSslPolicyRequestObjectAsync()
        {
            // Snippet: SetSslPolicyAsync(SetSslPolicyTargetSslProxyRequest, CallSettings)
            // Additional: SetSslPolicyAsync(SetSslPolicyTargetSslProxyRequest, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetSslPolicyTargetSslProxyRequest request = new SetSslPolicyTargetSslProxyRequest
            {
                RequestId = "",
                Project = "",
                SslPolicyReferenceResource = new SslPolicyReference(),
                TargetSslProxy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetSslProxiesClient.SetSslPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetSslProxiesClient.PollOnceSetSslPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslPolicy</summary>
        public void SetSslPolicy()
        {
            // Snippet: SetSslPolicy(string, string, SslPolicyReference, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetSslProxy = "";
            SslPolicyReference sslPolicyReferenceResource = new SslPolicyReference();
            // Make the request
            lro::Operation<Operation, Operation> response = targetSslProxiesClient.SetSslPolicy(project, targetSslProxy, sslPolicyReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetSslProxiesClient.PollOnceSetSslPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslPolicyAsync</summary>
        public async Task SetSslPolicyAsync()
        {
            // Snippet: SetSslPolicyAsync(string, string, SslPolicyReference, CallSettings)
            // Additional: SetSslPolicyAsync(string, string, SslPolicyReference, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetSslProxy = "";
            SslPolicyReference sslPolicyReferenceResource = new SslPolicyReference();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetSslProxiesClient.SetSslPolicyAsync(project, targetSslProxy, sslPolicyReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetSslProxiesClient.PollOnceSetSslPolicyAsync(operationName);
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
