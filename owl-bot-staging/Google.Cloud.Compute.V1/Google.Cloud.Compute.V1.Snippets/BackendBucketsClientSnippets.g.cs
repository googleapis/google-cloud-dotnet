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
    public sealed class AllGeneratedBackendBucketsClientSnippets
    {
        /// <summary>Snippet for AddSignedUrlKey</summary>
        public void AddSignedUrlKeyRequestObject()
        {
            // Snippet: AddSignedUrlKey(AddSignedUrlKeyBackendBucketRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            AddSignedUrlKeyBackendBucketRequest request = new AddSignedUrlKeyBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                Project = "",
                SignedUrlKeyResource = new SignedUrlKey(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendBucketsClient.AddSignedUrlKey(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendBucketsClient.PollOnceAddSignedUrlKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddSignedUrlKeyAsync</summary>
        public async Task AddSignedUrlKeyRequestObjectAsync()
        {
            // Snippet: AddSignedUrlKeyAsync(AddSignedUrlKeyBackendBucketRequest, CallSettings)
            // Additional: AddSignedUrlKeyAsync(AddSignedUrlKeyBackendBucketRequest, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            AddSignedUrlKeyBackendBucketRequest request = new AddSignedUrlKeyBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                Project = "",
                SignedUrlKeyResource = new SignedUrlKey(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendBucketsClient.AddSignedUrlKeyAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendBucketsClient.PollOnceAddSignedUrlKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddSignedUrlKey</summary>
        public void AddSignedUrlKey()
        {
            // Snippet: AddSignedUrlKey(string, string, SignedUrlKey, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendBucket = "";
            SignedUrlKey signedUrlKeyResource = new SignedUrlKey();
            // Make the request
            lro::Operation<Operation, Operation> response = backendBucketsClient.AddSignedUrlKey(project, backendBucket, signedUrlKeyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendBucketsClient.PollOnceAddSignedUrlKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddSignedUrlKeyAsync</summary>
        public async Task AddSignedUrlKeyAsync()
        {
            // Snippet: AddSignedUrlKeyAsync(string, string, SignedUrlKey, CallSettings)
            // Additional: AddSignedUrlKeyAsync(string, string, SignedUrlKey, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendBucket = "";
            SignedUrlKey signedUrlKeyResource = new SignedUrlKey();
            // Make the request
            lro::Operation<Operation, Operation> response = await backendBucketsClient.AddSignedUrlKeyAsync(project, backendBucket, signedUrlKeyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendBucketsClient.PollOnceAddSignedUrlKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteBackendBucketRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            DeleteBackendBucketRequest request = new DeleteBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendBucketsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendBucketsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteBackendBucketRequest, CallSettings)
            // Additional: DeleteAsync(DeleteBackendBucketRequest, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackendBucketRequest request = new DeleteBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendBucketsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendBucketsClient.PollOnceDeleteAsync(operationName);
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
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendBucket = "";
            // Make the request
            lro::Operation<Operation, Operation> response = backendBucketsClient.Delete(project, backendBucket);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendBucketsClient.PollOnceDelete(operationName);
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
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendBucket = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await backendBucketsClient.DeleteAsync(project, backendBucket);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendBucketsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSignedUrlKey</summary>
        public void DeleteSignedUrlKeyRequestObject()
        {
            // Snippet: DeleteSignedUrlKey(DeleteSignedUrlKeyBackendBucketRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            DeleteSignedUrlKeyBackendBucketRequest request = new DeleteSignedUrlKeyBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                Project = "",
                KeyName = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendBucketsClient.DeleteSignedUrlKey(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendBucketsClient.PollOnceDeleteSignedUrlKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSignedUrlKeyAsync</summary>
        public async Task DeleteSignedUrlKeyRequestObjectAsync()
        {
            // Snippet: DeleteSignedUrlKeyAsync(DeleteSignedUrlKeyBackendBucketRequest, CallSettings)
            // Additional: DeleteSignedUrlKeyAsync(DeleteSignedUrlKeyBackendBucketRequest, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSignedUrlKeyBackendBucketRequest request = new DeleteSignedUrlKeyBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                Project = "",
                KeyName = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendBucketsClient.DeleteSignedUrlKeyAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendBucketsClient.PollOnceDeleteSignedUrlKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSignedUrlKey</summary>
        public void DeleteSignedUrlKey()
        {
            // Snippet: DeleteSignedUrlKey(string, string, string, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendBucket = "";
            string keyName = "";
            // Make the request
            lro::Operation<Operation, Operation> response = backendBucketsClient.DeleteSignedUrlKey(project, backendBucket, keyName);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendBucketsClient.PollOnceDeleteSignedUrlKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSignedUrlKeyAsync</summary>
        public async Task DeleteSignedUrlKeyAsync()
        {
            // Snippet: DeleteSignedUrlKeyAsync(string, string, string, CallSettings)
            // Additional: DeleteSignedUrlKeyAsync(string, string, string, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendBucket = "";
            string keyName = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await backendBucketsClient.DeleteSignedUrlKeyAsync(project, backendBucket, keyName);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendBucketsClient.PollOnceDeleteSignedUrlKeyAsync(operationName);
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
            // Snippet: Get(GetBackendBucketRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            GetBackendBucketRequest request = new GetBackendBucketRequest
            {
                BackendBucket = "",
                Project = "",
            };
            // Make the request
            BackendBucket response = backendBucketsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetBackendBucketRequest, CallSettings)
            // Additional: GetAsync(GetBackendBucketRequest, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            GetBackendBucketRequest request = new GetBackendBucketRequest
            {
                BackendBucket = "",
                Project = "",
            };
            // Make the request
            BackendBucket response = await backendBucketsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendBucket = "";
            // Make the request
            BackendBucket response = backendBucketsClient.Get(project, backendBucket);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendBucket = "";
            // Make the request
            BackendBucket response = await backendBucketsClient.GetAsync(project, backendBucket);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyBackendBucketRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyBackendBucketRequest request = new GetIamPolicyBackendBucketRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = backendBucketsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyBackendBucketRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyBackendBucketRequest, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyBackendBucketRequest request = new GetIamPolicyBackendBucketRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await backendBucketsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = backendBucketsClient.GetIamPolicy(project, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = await backendBucketsClient.GetIamPolicyAsync(project, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertBackendBucketRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            InsertBackendBucketRequest request = new InsertBackendBucketRequest
            {
                RequestId = "",
                Project = "",
                BackendBucketResource = new BackendBucket(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendBucketsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendBucketsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertBackendBucketRequest, CallSettings)
            // Additional: InsertAsync(InsertBackendBucketRequest, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            InsertBackendBucketRequest request = new InsertBackendBucketRequest
            {
                RequestId = "",
                Project = "",
                BackendBucketResource = new BackendBucket(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendBucketsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendBucketsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, BackendBucket, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            BackendBucket backendBucketResource = new BackendBucket();
            // Make the request
            lro::Operation<Operation, Operation> response = backendBucketsClient.Insert(project, backendBucketResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendBucketsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, BackendBucket, CallSettings)
            // Additional: InsertAsync(string, BackendBucket, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            BackendBucket backendBucketResource = new BackendBucket();
            // Make the request
            lro::Operation<Operation, Operation> response = await backendBucketsClient.InsertAsync(project, backendBucketResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendBucketsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListBackendBucketsRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            ListBackendBucketsRequest request = new ListBackendBucketsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<BackendBucketList, BackendBucket> response = backendBucketsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendBucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackendBucketList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendBucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendBucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendBucket item in singlePage)
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
            // Snippet: ListAsync(ListBackendBucketsRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            ListBackendBucketsRequest request = new ListBackendBucketsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<BackendBucketList, BackendBucket> response = backendBucketsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackendBucket item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((BackendBucketList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendBucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendBucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendBucket item in singlePage)
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
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<BackendBucketList, BackendBucket> response = backendBucketsClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendBucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackendBucketList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendBucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendBucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendBucket item in singlePage)
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
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<BackendBucketList, BackendBucket> response = backendBucketsClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackendBucket item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((BackendBucketList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendBucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendBucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendBucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchBackendBucketRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            PatchBackendBucketRequest request = new PatchBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                Project = "",
                BackendBucketResource = new BackendBucket(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendBucketsClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendBucketsClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchBackendBucketRequest, CallSettings)
            // Additional: PatchAsync(PatchBackendBucketRequest, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            PatchBackendBucketRequest request = new PatchBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                Project = "",
                BackendBucketResource = new BackendBucket(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendBucketsClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendBucketsClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, BackendBucket, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendBucket = "";
            BackendBucket backendBucketResource = new BackendBucket();
            // Make the request
            lro::Operation<Operation, Operation> response = backendBucketsClient.Patch(project, backendBucket, backendBucketResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendBucketsClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, BackendBucket, CallSettings)
            // Additional: PatchAsync(string, string, BackendBucket, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendBucket = "";
            BackendBucket backendBucketResource = new BackendBucket();
            // Make the request
            lro::Operation<Operation, Operation> response = await backendBucketsClient.PatchAsync(project, backendBucket, backendBucketResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendBucketsClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetEdgeSecurityPolicy</summary>
        public void SetEdgeSecurityPolicyRequestObject()
        {
            // Snippet: SetEdgeSecurityPolicy(SetEdgeSecurityPolicyBackendBucketRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            SetEdgeSecurityPolicyBackendBucketRequest request = new SetEdgeSecurityPolicyBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendBucketsClient.SetEdgeSecurityPolicy(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendBucketsClient.PollOnceSetEdgeSecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetEdgeSecurityPolicyAsync</summary>
        public async Task SetEdgeSecurityPolicyRequestObjectAsync()
        {
            // Snippet: SetEdgeSecurityPolicyAsync(SetEdgeSecurityPolicyBackendBucketRequest, CallSettings)
            // Additional: SetEdgeSecurityPolicyAsync(SetEdgeSecurityPolicyBackendBucketRequest, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            SetEdgeSecurityPolicyBackendBucketRequest request = new SetEdgeSecurityPolicyBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendBucketsClient.SetEdgeSecurityPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendBucketsClient.PollOnceSetEdgeSecurityPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetEdgeSecurityPolicy</summary>
        public void SetEdgeSecurityPolicy()
        {
            // Snippet: SetEdgeSecurityPolicy(string, string, SecurityPolicyReference, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendBucket = "";
            SecurityPolicyReference securityPolicyReferenceResource = new SecurityPolicyReference();
            // Make the request
            lro::Operation<Operation, Operation> response = backendBucketsClient.SetEdgeSecurityPolicy(project, backendBucket, securityPolicyReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendBucketsClient.PollOnceSetEdgeSecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetEdgeSecurityPolicyAsync</summary>
        public async Task SetEdgeSecurityPolicyAsync()
        {
            // Snippet: SetEdgeSecurityPolicyAsync(string, string, SecurityPolicyReference, CallSettings)
            // Additional: SetEdgeSecurityPolicyAsync(string, string, SecurityPolicyReference, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendBucket = "";
            SecurityPolicyReference securityPolicyReferenceResource = new SecurityPolicyReference();
            // Make the request
            lro::Operation<Operation, Operation> response = await backendBucketsClient.SetEdgeSecurityPolicyAsync(project, backendBucket, securityPolicyReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendBucketsClient.PollOnceSetEdgeSecurityPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyBackendBucketRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyBackendBucketRequest request = new SetIamPolicyBackendBucketRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = backendBucketsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyBackendBucketRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyBackendBucketRequest, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyBackendBucketRequest request = new SetIamPolicyBackendBucketRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = await backendBucketsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, GlobalSetPolicyRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = backendBucketsClient.SetIamPolicy(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = await backendBucketsClient.SetIamPolicyAsync(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsBackendBucketRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsBackendBucketRequest request = new TestIamPermissionsBackendBucketRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = backendBucketsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsBackendBucketRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsBackendBucketRequest, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsBackendBucketRequest request = new TestIamPermissionsBackendBucketRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await backendBucketsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, TestPermissionsRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = backendBucketsClient.TestIamPermissions(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await backendBucketsClient.TestIamPermissionsAsync(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateBackendBucketRequest, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            UpdateBackendBucketRequest request = new UpdateBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                Project = "",
                BackendBucketResource = new BackendBucket(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendBucketsClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendBucketsClient.PollOnceUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(UpdateBackendBucketRequest, CallSettings)
            // Additional: UpdateAsync(UpdateBackendBucketRequest, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackendBucketRequest request = new UpdateBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                Project = "",
                BackendBucketResource = new BackendBucket(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendBucketsClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendBucketsClient.PollOnceUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void Update()
        {
            // Snippet: Update(string, string, BackendBucket, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendBucket = "";
            BackendBucket backendBucketResource = new BackendBucket();
            // Make the request
            lro::Operation<Operation, Operation> response = backendBucketsClient.Update(project, backendBucket, backendBucketResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendBucketsClient.PollOnceUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateAsync()
        {
            // Snippet: UpdateAsync(string, string, BackendBucket, CallSettings)
            // Additional: UpdateAsync(string, string, BackendBucket, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendBucket = "";
            BackendBucket backendBucketResource = new BackendBucket();
            // Make the request
            lro::Operation<Operation, Operation> response = await backendBucketsClient.UpdateAsync(project, backendBucket, backendBucketResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendBucketsClient.PollOnceUpdateAsync(operationName);
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
