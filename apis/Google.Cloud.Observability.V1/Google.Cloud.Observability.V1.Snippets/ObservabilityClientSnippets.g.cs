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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Observability.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedObservabilityClientSnippets
    {
        /// <summary>Snippet for GetScope</summary>
        public void GetScopeRequestObject()
        {
            // Snippet: GetScope(GetScopeRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            GetScopeRequest request = new GetScopeRequest
            {
                ScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
            };
            // Make the request
            Scope response = observabilityClient.GetScope(request);
            // End snippet
        }

        /// <summary>Snippet for GetScopeAsync</summary>
        public async Task GetScopeRequestObjectAsync()
        {
            // Snippet: GetScopeAsync(GetScopeRequest, CallSettings)
            // Additional: GetScopeAsync(GetScopeRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            GetScopeRequest request = new GetScopeRequest
            {
                ScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
            };
            // Make the request
            Scope response = await observabilityClient.GetScopeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetScope</summary>
        public void GetScope()
        {
            // Snippet: GetScope(string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            // Make the request
            Scope response = observabilityClient.GetScope(name);
            // End snippet
        }

        /// <summary>Snippet for GetScopeAsync</summary>
        public async Task GetScopeAsync()
        {
            // Snippet: GetScopeAsync(string, CallSettings)
            // Additional: GetScopeAsync(string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            // Make the request
            Scope response = await observabilityClient.GetScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetScope</summary>
        public void GetScopeResourceNames()
        {
            // Snippet: GetScope(ScopeName, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            ScopeName name = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            // Make the request
            Scope response = observabilityClient.GetScope(name);
            // End snippet
        }

        /// <summary>Snippet for GetScopeAsync</summary>
        public async Task GetScopeResourceNamesAsync()
        {
            // Snippet: GetScopeAsync(ScopeName, CallSettings)
            // Additional: GetScopeAsync(ScopeName, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            ScopeName name = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            // Make the request
            Scope response = await observabilityClient.GetScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateScope</summary>
        public void UpdateScopeRequestObject()
        {
            // Snippet: UpdateScope(UpdateScopeRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            UpdateScopeRequest request = new UpdateScopeRequest
            {
                UpdateMask = new FieldMask(),
                Scope = new Scope(),
            };
            // Make the request
            Scope response = observabilityClient.UpdateScope(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateScopeAsync</summary>
        public async Task UpdateScopeRequestObjectAsync()
        {
            // Snippet: UpdateScopeAsync(UpdateScopeRequest, CallSettings)
            // Additional: UpdateScopeAsync(UpdateScopeRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            UpdateScopeRequest request = new UpdateScopeRequest
            {
                UpdateMask = new FieldMask(),
                Scope = new Scope(),
            };
            // Make the request
            Scope response = await observabilityClient.UpdateScopeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateScope</summary>
        public void UpdateScope()
        {
            // Snippet: UpdateScope(Scope, FieldMask, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            Scope scope = new Scope();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Scope response = observabilityClient.UpdateScope(scope, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateScopeAsync</summary>
        public async Task UpdateScopeAsync()
        {
            // Snippet: UpdateScopeAsync(Scope, FieldMask, CallSettings)
            // Additional: UpdateScopeAsync(Scope, FieldMask, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            Scope scope = new Scope();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Scope response = await observabilityClient.UpdateScopeAsync(scope, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetBucket</summary>
        public void GetBucketRequestObject()
        {
            // Snippet: GetBucket(GetBucketRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            GetBucketRequest request = new GetBucketRequest
            {
                BucketName = BucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
            };
            // Make the request
            Bucket response = observabilityClient.GetBucket(request);
            // End snippet
        }

        /// <summary>Snippet for GetBucketAsync</summary>
        public async Task GetBucketRequestObjectAsync()
        {
            // Snippet: GetBucketAsync(GetBucketRequest, CallSettings)
            // Additional: GetBucketAsync(GetBucketRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            GetBucketRequest request = new GetBucketRequest
            {
                BucketName = BucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
            };
            // Make the request
            Bucket response = await observabilityClient.GetBucketAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBucket</summary>
        public void GetBucket()
        {
            // Snippet: GetBucket(string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]";
            // Make the request
            Bucket response = observabilityClient.GetBucket(name);
            // End snippet
        }

        /// <summary>Snippet for GetBucketAsync</summary>
        public async Task GetBucketAsync()
        {
            // Snippet: GetBucketAsync(string, CallSettings)
            // Additional: GetBucketAsync(string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]";
            // Make the request
            Bucket response = await observabilityClient.GetBucketAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBucket</summary>
        public void GetBucketResourceNames()
        {
            // Snippet: GetBucket(BucketName, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            BucketName name = BucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]");
            // Make the request
            Bucket response = observabilityClient.GetBucket(name);
            // End snippet
        }

        /// <summary>Snippet for GetBucketAsync</summary>
        public async Task GetBucketResourceNamesAsync()
        {
            // Snippet: GetBucketAsync(BucketName, CallSettings)
            // Additional: GetBucketAsync(BucketName, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            BucketName name = BucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]");
            // Make the request
            Bucket response = await observabilityClient.GetBucketAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBuckets</summary>
        public void ListBucketsRequestObject()
        {
            // Snippet: ListBuckets(ListBucketsRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            ListBucketsRequest request = new ListBucketsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListBucketsResponse, Bucket> response = observabilityClient.ListBuckets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Bucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBucketsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Bucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Bucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBucketsAsync</summary>
        public async Task ListBucketsRequestObjectAsync()
        {
            // Snippet: ListBucketsAsync(ListBucketsRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            ListBucketsRequest request = new ListBucketsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListBucketsResponse, Bucket> response = observabilityClient.ListBucketsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Bucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBucketsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Bucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Bucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuckets</summary>
        public void ListBuckets()
        {
            // Snippet: ListBuckets(string, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBucketsResponse, Bucket> response = observabilityClient.ListBuckets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Bucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBucketsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Bucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Bucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBucketsAsync</summary>
        public async Task ListBucketsAsync()
        {
            // Snippet: ListBucketsAsync(string, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBucketsResponse, Bucket> response = observabilityClient.ListBucketsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Bucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBucketsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Bucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Bucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuckets</summary>
        public void ListBucketsResourceNames()
        {
            // Snippet: ListBuckets(LocationName, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBucketsResponse, Bucket> response = observabilityClient.ListBuckets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Bucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBucketsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Bucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Bucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBucketsAsync</summary>
        public async Task ListBucketsResourceNamesAsync()
        {
            // Snippet: ListBucketsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBucketsResponse, Bucket> response = observabilityClient.ListBucketsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Bucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBucketsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Bucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Bucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateBucket</summary>
        public void CreateBucketRequestObject()
        {
            // Snippet: CreateBucket(CreateBucketRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            CreateBucketRequest request = new CreateBucketRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BucketId = "",
                Bucket = new Bucket(),
            };
            // Make the request
            Operation<Bucket, OperationMetadata> response = observabilityClient.CreateBucket(request);

            // Poll until the returned long-running operation is complete
            Operation<Bucket, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Bucket result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Bucket, OperationMetadata> retrievedResponse = observabilityClient.PollOnceCreateBucket(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Bucket retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBucketAsync</summary>
        public async Task CreateBucketRequestObjectAsync()
        {
            // Snippet: CreateBucketAsync(CreateBucketRequest, CallSettings)
            // Additional: CreateBucketAsync(CreateBucketRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            CreateBucketRequest request = new CreateBucketRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BucketId = "",
                Bucket = new Bucket(),
            };
            // Make the request
            Operation<Bucket, OperationMetadata> response = await observabilityClient.CreateBucketAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Bucket, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Bucket result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Bucket, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceCreateBucketAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Bucket retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBucket</summary>
        public void CreateBucket()
        {
            // Snippet: CreateBucket(string, Bucket, string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Bucket bucket = new Bucket();
            string bucketId = "";
            // Make the request
            Operation<Bucket, OperationMetadata> response = observabilityClient.CreateBucket(parent, bucket, bucketId);

            // Poll until the returned long-running operation is complete
            Operation<Bucket, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Bucket result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Bucket, OperationMetadata> retrievedResponse = observabilityClient.PollOnceCreateBucket(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Bucket retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBucketAsync</summary>
        public async Task CreateBucketAsync()
        {
            // Snippet: CreateBucketAsync(string, Bucket, string, CallSettings)
            // Additional: CreateBucketAsync(string, Bucket, string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Bucket bucket = new Bucket();
            string bucketId = "";
            // Make the request
            Operation<Bucket, OperationMetadata> response = await observabilityClient.CreateBucketAsync(parent, bucket, bucketId);

            // Poll until the returned long-running operation is complete
            Operation<Bucket, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Bucket result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Bucket, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceCreateBucketAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Bucket retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBucket</summary>
        public void CreateBucketResourceNames()
        {
            // Snippet: CreateBucket(LocationName, Bucket, string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Bucket bucket = new Bucket();
            string bucketId = "";
            // Make the request
            Operation<Bucket, OperationMetadata> response = observabilityClient.CreateBucket(parent, bucket, bucketId);

            // Poll until the returned long-running operation is complete
            Operation<Bucket, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Bucket result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Bucket, OperationMetadata> retrievedResponse = observabilityClient.PollOnceCreateBucket(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Bucket retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBucketAsync</summary>
        public async Task CreateBucketResourceNamesAsync()
        {
            // Snippet: CreateBucketAsync(LocationName, Bucket, string, CallSettings)
            // Additional: CreateBucketAsync(LocationName, Bucket, string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Bucket bucket = new Bucket();
            string bucketId = "";
            // Make the request
            Operation<Bucket, OperationMetadata> response = await observabilityClient.CreateBucketAsync(parent, bucket, bucketId);

            // Poll until the returned long-running operation is complete
            Operation<Bucket, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Bucket result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Bucket, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceCreateBucketAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Bucket retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBucket</summary>
        public void UpdateBucketRequestObject()
        {
            // Snippet: UpdateBucket(UpdateBucketRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            UpdateBucketRequest request = new UpdateBucketRequest
            {
                Bucket = new Bucket(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Bucket, OperationMetadata> response = observabilityClient.UpdateBucket(request);

            // Poll until the returned long-running operation is complete
            Operation<Bucket, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Bucket result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Bucket, OperationMetadata> retrievedResponse = observabilityClient.PollOnceUpdateBucket(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Bucket retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBucketAsync</summary>
        public async Task UpdateBucketRequestObjectAsync()
        {
            // Snippet: UpdateBucketAsync(UpdateBucketRequest, CallSettings)
            // Additional: UpdateBucketAsync(UpdateBucketRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBucketRequest request = new UpdateBucketRequest
            {
                Bucket = new Bucket(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Bucket, OperationMetadata> response = await observabilityClient.UpdateBucketAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Bucket, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Bucket result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Bucket, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceUpdateBucketAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Bucket retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBucket</summary>
        public void UpdateBucket()
        {
            // Snippet: UpdateBucket(Bucket, FieldMask, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            Bucket bucket = new Bucket();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Bucket, OperationMetadata> response = observabilityClient.UpdateBucket(bucket, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Bucket, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Bucket result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Bucket, OperationMetadata> retrievedResponse = observabilityClient.PollOnceUpdateBucket(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Bucket retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBucketAsync</summary>
        public async Task UpdateBucketAsync()
        {
            // Snippet: UpdateBucketAsync(Bucket, FieldMask, CallSettings)
            // Additional: UpdateBucketAsync(Bucket, FieldMask, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            Bucket bucket = new Bucket();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Bucket, OperationMetadata> response = await observabilityClient.UpdateBucketAsync(bucket, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Bucket, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Bucket result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Bucket, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceUpdateBucketAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Bucket retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetRequestObject()
        {
            // Snippet: GetDataset(GetDatasetRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]"),
            };
            // Make the request
            Dataset response = observabilityClient.GetDataset(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetRequestObjectAsync()
        {
            // Snippet: GetDatasetAsync(GetDatasetRequest, CallSettings)
            // Additional: GetDatasetAsync(GetDatasetRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]"),
            };
            // Make the request
            Dataset response = await observabilityClient.GetDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDataset()
        {
            // Snippet: GetDataset(string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]/datasets/[DATASET]";
            // Make the request
            Dataset response = observabilityClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetAsync()
        {
            // Snippet: GetDatasetAsync(string, CallSettings)
            // Additional: GetDatasetAsync(string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]/datasets/[DATASET]";
            // Make the request
            Dataset response = await observabilityClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetResourceNames()
        {
            // Snippet: GetDataset(DatasetName, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]");
            // Make the request
            Dataset response = observabilityClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetResourceNamesAsync()
        {
            // Snippet: GetDatasetAsync(DatasetName, CallSettings)
            // Additional: GetDatasetAsync(DatasetName, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]");
            // Make the request
            Dataset response = await observabilityClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasetsRequestObject()
        {
            // Snippet: ListDatasets(ListDatasetsRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsBucketName = BucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = observabilityClient.ListDatasets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetsAsync</summary>
        public async Task ListDatasetsRequestObjectAsync()
        {
            // Snippet: ListDatasetsAsync(ListDatasetsRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsBucketName = BucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = observabilityClient.ListDatasetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasets()
        {
            // Snippet: ListDatasets(string, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]";
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = observabilityClient.ListDatasets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetsAsync</summary>
        public async Task ListDatasetsAsync()
        {
            // Snippet: ListDatasetsAsync(string, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]";
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = observabilityClient.ListDatasetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasetsResourceNames()
        {
            // Snippet: ListDatasets(BucketName, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]");
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = observabilityClient.ListDatasets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetsAsync</summary>
        public async Task ListDatasetsResourceNamesAsync()
        {
            // Snippet: ListDatasetsAsync(BucketName, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]");
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = observabilityClient.ListDatasetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetView</summary>
        public void GetViewRequestObject()
        {
            // Snippet: GetView(GetViewRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            GetViewRequest request = new GetViewRequest
            {
                ViewName = ViewName.FromProjectLocationBucketDatasetView("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]", "[VIEW]"),
            };
            // Make the request
            View response = observabilityClient.GetView(request);
            // End snippet
        }

        /// <summary>Snippet for GetViewAsync</summary>
        public async Task GetViewRequestObjectAsync()
        {
            // Snippet: GetViewAsync(GetViewRequest, CallSettings)
            // Additional: GetViewAsync(GetViewRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            GetViewRequest request = new GetViewRequest
            {
                ViewName = ViewName.FromProjectLocationBucketDatasetView("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]", "[VIEW]"),
            };
            // Make the request
            View response = await observabilityClient.GetViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetView</summary>
        public void GetView()
        {
            // Snippet: GetView(string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]/datasets/[DATASET]/views/[VIEW]";
            // Make the request
            View response = observabilityClient.GetView(name);
            // End snippet
        }

        /// <summary>Snippet for GetViewAsync</summary>
        public async Task GetViewAsync()
        {
            // Snippet: GetViewAsync(string, CallSettings)
            // Additional: GetViewAsync(string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]/datasets/[DATASET]/views/[VIEW]";
            // Make the request
            View response = await observabilityClient.GetViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetView</summary>
        public void GetViewResourceNames()
        {
            // Snippet: GetView(ViewName, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            ViewName name = ViewName.FromProjectLocationBucketDatasetView("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]", "[VIEW]");
            // Make the request
            View response = observabilityClient.GetView(name);
            // End snippet
        }

        /// <summary>Snippet for GetViewAsync</summary>
        public async Task GetViewResourceNamesAsync()
        {
            // Snippet: GetViewAsync(ViewName, CallSettings)
            // Additional: GetViewAsync(ViewName, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            ViewName name = ViewName.FromProjectLocationBucketDatasetView("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]", "[VIEW]");
            // Make the request
            View response = await observabilityClient.GetViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListViews</summary>
        public void ListViewsRequestObject()
        {
            // Snippet: ListViews(ListViewsRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            ListViewsRequest request = new ListViewsRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]"),
            };
            // Make the request
            PagedEnumerable<ListViewsResponse, View> response = observabilityClient.ListViews(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (View item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (View item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<View> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (View item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViewsAsync</summary>
        public async Task ListViewsRequestObjectAsync()
        {
            // Snippet: ListViewsAsync(ListViewsRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            ListViewsRequest request = new ListViewsRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListViewsResponse, View> response = observabilityClient.ListViewsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (View item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (View item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<View> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (View item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViews</summary>
        public void ListViews()
        {
            // Snippet: ListViews(string, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]/datasets/[DATASET]";
            // Make the request
            PagedEnumerable<ListViewsResponse, View> response = observabilityClient.ListViews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (View item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (View item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<View> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (View item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViewsAsync</summary>
        public async Task ListViewsAsync()
        {
            // Snippet: ListViewsAsync(string, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]/datasets/[DATASET]";
            // Make the request
            PagedAsyncEnumerable<ListViewsResponse, View> response = observabilityClient.ListViewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (View item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (View item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<View> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (View item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViews</summary>
        public void ListViewsResourceNames()
        {
            // Snippet: ListViews(DatasetName, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]");
            // Make the request
            PagedEnumerable<ListViewsResponse, View> response = observabilityClient.ListViews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (View item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (View item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<View> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (View item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViewsAsync</summary>
        public async Task ListViewsResourceNamesAsync()
        {
            // Snippet: ListViewsAsync(DatasetName, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]");
            // Make the request
            PagedAsyncEnumerable<ListViewsResponse, View> response = observabilityClient.ListViewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (View item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (View item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<View> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (View item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetLink</summary>
        public void GetLinkRequestObject()
        {
            // Snippet: GetLink(GetLinkRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            GetLinkRequest request = new GetLinkRequest
            {
                LinkName = LinkName.FromProjectLocationBucketDatasetLink("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]", "[LINK]"),
            };
            // Make the request
            Link response = observabilityClient.GetLink(request);
            // End snippet
        }

        /// <summary>Snippet for GetLinkAsync</summary>
        public async Task GetLinkRequestObjectAsync()
        {
            // Snippet: GetLinkAsync(GetLinkRequest, CallSettings)
            // Additional: GetLinkAsync(GetLinkRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            GetLinkRequest request = new GetLinkRequest
            {
                LinkName = LinkName.FromProjectLocationBucketDatasetLink("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]", "[LINK]"),
            };
            // Make the request
            Link response = await observabilityClient.GetLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLink</summary>
        public void GetLink()
        {
            // Snippet: GetLink(string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]/datasets/[DATASET]/links/[LINK]";
            // Make the request
            Link response = observabilityClient.GetLink(name);
            // End snippet
        }

        /// <summary>Snippet for GetLinkAsync</summary>
        public async Task GetLinkAsync()
        {
            // Snippet: GetLinkAsync(string, CallSettings)
            // Additional: GetLinkAsync(string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]/datasets/[DATASET]/links/[LINK]";
            // Make the request
            Link response = await observabilityClient.GetLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLink</summary>
        public void GetLinkResourceNames()
        {
            // Snippet: GetLink(LinkName, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            LinkName name = LinkName.FromProjectLocationBucketDatasetLink("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]", "[LINK]");
            // Make the request
            Link response = observabilityClient.GetLink(name);
            // End snippet
        }

        /// <summary>Snippet for GetLinkAsync</summary>
        public async Task GetLinkResourceNamesAsync()
        {
            // Snippet: GetLinkAsync(LinkName, CallSettings)
            // Additional: GetLinkAsync(LinkName, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            LinkName name = LinkName.FromProjectLocationBucketDatasetLink("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]", "[LINK]");
            // Make the request
            Link response = await observabilityClient.GetLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLinks</summary>
        public void ListLinksRequestObject()
        {
            // Snippet: ListLinks(ListLinksRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            ListLinksRequest request = new ListLinksRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]"),
            };
            // Make the request
            PagedEnumerable<ListLinksResponse, Link> response = observabilityClient.ListLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Link item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Link item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Link> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Link item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLinksAsync</summary>
        public async Task ListLinksRequestObjectAsync()
        {
            // Snippet: ListLinksAsync(ListLinksRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            ListLinksRequest request = new ListLinksRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListLinksResponse, Link> response = observabilityClient.ListLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Link item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Link item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Link> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Link item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLinks</summary>
        public void ListLinks()
        {
            // Snippet: ListLinks(string, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]/datasets/[DATASET]";
            // Make the request
            PagedEnumerable<ListLinksResponse, Link> response = observabilityClient.ListLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Link item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Link item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Link> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Link item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLinksAsync</summary>
        public async Task ListLinksAsync()
        {
            // Snippet: ListLinksAsync(string, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]/datasets/[DATASET]";
            // Make the request
            PagedAsyncEnumerable<ListLinksResponse, Link> response = observabilityClient.ListLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Link item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Link item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Link> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Link item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLinks</summary>
        public void ListLinksResourceNames()
        {
            // Snippet: ListLinks(DatasetName, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]");
            // Make the request
            PagedEnumerable<ListLinksResponse, Link> response = observabilityClient.ListLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Link item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Link item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Link> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Link item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLinksAsync</summary>
        public async Task ListLinksResourceNamesAsync()
        {
            // Snippet: ListLinksAsync(DatasetName, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]");
            // Make the request
            PagedAsyncEnumerable<ListLinksResponse, Link> response = observabilityClient.ListLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Link item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Link item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Link> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Link item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateLink</summary>
        public void CreateLinkRequestObject()
        {
            // Snippet: CreateLink(CreateLinkRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            CreateLinkRequest request = new CreateLinkRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]"),
                LinkId = "",
                Link = new Link(),
            };
            // Make the request
            Operation<Link, OperationMetadata> response = observabilityClient.CreateLink(request);

            // Poll until the returned long-running operation is complete
            Operation<Link, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Link result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Link, OperationMetadata> retrievedResponse = observabilityClient.PollOnceCreateLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Link retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLinkAsync</summary>
        public async Task CreateLinkRequestObjectAsync()
        {
            // Snippet: CreateLinkAsync(CreateLinkRequest, CallSettings)
            // Additional: CreateLinkAsync(CreateLinkRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            CreateLinkRequest request = new CreateLinkRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]"),
                LinkId = "",
                Link = new Link(),
            };
            // Make the request
            Operation<Link, OperationMetadata> response = await observabilityClient.CreateLinkAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Link, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Link result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Link, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceCreateLinkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Link retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLink</summary>
        public void CreateLink()
        {
            // Snippet: CreateLink(string, Link, string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]/datasets/[DATASET]";
            Link link = new Link();
            string linkId = "";
            // Make the request
            Operation<Link, OperationMetadata> response = observabilityClient.CreateLink(parent, link, linkId);

            // Poll until the returned long-running operation is complete
            Operation<Link, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Link result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Link, OperationMetadata> retrievedResponse = observabilityClient.PollOnceCreateLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Link retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLinkAsync</summary>
        public async Task CreateLinkAsync()
        {
            // Snippet: CreateLinkAsync(string, Link, string, CallSettings)
            // Additional: CreateLinkAsync(string, Link, string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]/datasets/[DATASET]";
            Link link = new Link();
            string linkId = "";
            // Make the request
            Operation<Link, OperationMetadata> response = await observabilityClient.CreateLinkAsync(parent, link, linkId);

            // Poll until the returned long-running operation is complete
            Operation<Link, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Link result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Link, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceCreateLinkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Link retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLink</summary>
        public void CreateLinkResourceNames()
        {
            // Snippet: CreateLink(DatasetName, Link, string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]");
            Link link = new Link();
            string linkId = "";
            // Make the request
            Operation<Link, OperationMetadata> response = observabilityClient.CreateLink(parent, link, linkId);

            // Poll until the returned long-running operation is complete
            Operation<Link, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Link result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Link, OperationMetadata> retrievedResponse = observabilityClient.PollOnceCreateLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Link retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLinkAsync</summary>
        public async Task CreateLinkResourceNamesAsync()
        {
            // Snippet: CreateLinkAsync(DatasetName, Link, string, CallSettings)
            // Additional: CreateLinkAsync(DatasetName, Link, string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationBucketDataset("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]");
            Link link = new Link();
            string linkId = "";
            // Make the request
            Operation<Link, OperationMetadata> response = await observabilityClient.CreateLinkAsync(parent, link, linkId);

            // Poll until the returned long-running operation is complete
            Operation<Link, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Link result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Link, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceCreateLinkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Link retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLink</summary>
        public void UpdateLinkRequestObject()
        {
            // Snippet: UpdateLink(UpdateLinkRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            UpdateLinkRequest request = new UpdateLinkRequest
            {
                Link = new Link(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Link, OperationMetadata> response = observabilityClient.UpdateLink(request);

            // Poll until the returned long-running operation is complete
            Operation<Link, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Link result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Link, OperationMetadata> retrievedResponse = observabilityClient.PollOnceUpdateLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Link retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLinkAsync</summary>
        public async Task UpdateLinkRequestObjectAsync()
        {
            // Snippet: UpdateLinkAsync(UpdateLinkRequest, CallSettings)
            // Additional: UpdateLinkAsync(UpdateLinkRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            UpdateLinkRequest request = new UpdateLinkRequest
            {
                Link = new Link(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Link, OperationMetadata> response = await observabilityClient.UpdateLinkAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Link, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Link result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Link, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceUpdateLinkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Link retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLink</summary>
        public void UpdateLink()
        {
            // Snippet: UpdateLink(Link, FieldMask, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            Link link = new Link();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Link, OperationMetadata> response = observabilityClient.UpdateLink(link, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Link, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Link result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Link, OperationMetadata> retrievedResponse = observabilityClient.PollOnceUpdateLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Link retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLinkAsync</summary>
        public async Task UpdateLinkAsync()
        {
            // Snippet: UpdateLinkAsync(Link, FieldMask, CallSettings)
            // Additional: UpdateLinkAsync(Link, FieldMask, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            Link link = new Link();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Link, OperationMetadata> response = await observabilityClient.UpdateLinkAsync(link, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Link, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Link result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Link, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceUpdateLinkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Link retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLink</summary>
        public void DeleteLinkRequestObject()
        {
            // Snippet: DeleteLink(DeleteLinkRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            DeleteLinkRequest request = new DeleteLinkRequest
            {
                LinkName = LinkName.FromProjectLocationBucketDatasetLink("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]", "[LINK]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = observabilityClient.DeleteLink(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = observabilityClient.PollOnceDeleteLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLinkAsync</summary>
        public async Task DeleteLinkRequestObjectAsync()
        {
            // Snippet: DeleteLinkAsync(DeleteLinkRequest, CallSettings)
            // Additional: DeleteLinkAsync(DeleteLinkRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            DeleteLinkRequest request = new DeleteLinkRequest
            {
                LinkName = LinkName.FromProjectLocationBucketDatasetLink("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]", "[LINK]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await observabilityClient.DeleteLinkAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceDeleteLinkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLink</summary>
        public void DeleteLink()
        {
            // Snippet: DeleteLink(string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]/datasets/[DATASET]/links/[LINK]";
            // Make the request
            Operation<Empty, OperationMetadata> response = observabilityClient.DeleteLink(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = observabilityClient.PollOnceDeleteLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLinkAsync</summary>
        public async Task DeleteLinkAsync()
        {
            // Snippet: DeleteLinkAsync(string, CallSettings)
            // Additional: DeleteLinkAsync(string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/buckets/[BUCKET]/datasets/[DATASET]/links/[LINK]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await observabilityClient.DeleteLinkAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceDeleteLinkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLink</summary>
        public void DeleteLinkResourceNames()
        {
            // Snippet: DeleteLink(LinkName, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            LinkName name = LinkName.FromProjectLocationBucketDatasetLink("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]", "[LINK]");
            // Make the request
            Operation<Empty, OperationMetadata> response = observabilityClient.DeleteLink(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = observabilityClient.PollOnceDeleteLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLinkAsync</summary>
        public async Task DeleteLinkResourceNamesAsync()
        {
            // Snippet: DeleteLinkAsync(LinkName, CallSettings)
            // Additional: DeleteLinkAsync(LinkName, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            LinkName name = LinkName.FromProjectLocationBucketDatasetLink("[PROJECT]", "[LOCATION]", "[BUCKET]", "[DATASET]", "[LINK]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await observabilityClient.DeleteLinkAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceDeleteLinkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetTraceScope</summary>
        public void GetTraceScopeRequestObject()
        {
            // Snippet: GetTraceScope(GetTraceScopeRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            GetTraceScopeRequest request = new GetTraceScopeRequest
            {
                TraceScopeName = TraceScopeName.FromProjectLocationTraceScope("[PROJECT]", "[LOCATION]", "[TRACE_SCOPE]"),
            };
            // Make the request
            TraceScope response = observabilityClient.GetTraceScope(request);
            // End snippet
        }

        /// <summary>Snippet for GetTraceScopeAsync</summary>
        public async Task GetTraceScopeRequestObjectAsync()
        {
            // Snippet: GetTraceScopeAsync(GetTraceScopeRequest, CallSettings)
            // Additional: GetTraceScopeAsync(GetTraceScopeRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            GetTraceScopeRequest request = new GetTraceScopeRequest
            {
                TraceScopeName = TraceScopeName.FromProjectLocationTraceScope("[PROJECT]", "[LOCATION]", "[TRACE_SCOPE]"),
            };
            // Make the request
            TraceScope response = await observabilityClient.GetTraceScopeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTraceScope</summary>
        public void GetTraceScope()
        {
            // Snippet: GetTraceScope(string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/traceScopes/[TRACE_SCOPE]";
            // Make the request
            TraceScope response = observabilityClient.GetTraceScope(name);
            // End snippet
        }

        /// <summary>Snippet for GetTraceScopeAsync</summary>
        public async Task GetTraceScopeAsync()
        {
            // Snippet: GetTraceScopeAsync(string, CallSettings)
            // Additional: GetTraceScopeAsync(string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/traceScopes/[TRACE_SCOPE]";
            // Make the request
            TraceScope response = await observabilityClient.GetTraceScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTraceScope</summary>
        public void GetTraceScopeResourceNames()
        {
            // Snippet: GetTraceScope(TraceScopeName, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            TraceScopeName name = TraceScopeName.FromProjectLocationTraceScope("[PROJECT]", "[LOCATION]", "[TRACE_SCOPE]");
            // Make the request
            TraceScope response = observabilityClient.GetTraceScope(name);
            // End snippet
        }

        /// <summary>Snippet for GetTraceScopeAsync</summary>
        public async Task GetTraceScopeResourceNamesAsync()
        {
            // Snippet: GetTraceScopeAsync(TraceScopeName, CallSettings)
            // Additional: GetTraceScopeAsync(TraceScopeName, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            TraceScopeName name = TraceScopeName.FromProjectLocationTraceScope("[PROJECT]", "[LOCATION]", "[TRACE_SCOPE]");
            // Make the request
            TraceScope response = await observabilityClient.GetTraceScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTraceScopes</summary>
        public void ListTraceScopesRequestObject()
        {
            // Snippet: ListTraceScopes(ListTraceScopesRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            ListTraceScopesRequest request = new ListTraceScopesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListTraceScopesResponse, TraceScope> response = observabilityClient.ListTraceScopes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TraceScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTraceScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TraceScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TraceScope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TraceScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTraceScopesAsync</summary>
        public async Task ListTraceScopesRequestObjectAsync()
        {
            // Snippet: ListTraceScopesAsync(ListTraceScopesRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            ListTraceScopesRequest request = new ListTraceScopesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTraceScopesResponse, TraceScope> response = observabilityClient.ListTraceScopesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TraceScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTraceScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TraceScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TraceScope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TraceScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTraceScopes</summary>
        public void ListTraceScopes()
        {
            // Snippet: ListTraceScopes(string, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTraceScopesResponse, TraceScope> response = observabilityClient.ListTraceScopes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TraceScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTraceScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TraceScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TraceScope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TraceScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTraceScopesAsync</summary>
        public async Task ListTraceScopesAsync()
        {
            // Snippet: ListTraceScopesAsync(string, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTraceScopesResponse, TraceScope> response = observabilityClient.ListTraceScopesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TraceScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTraceScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TraceScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TraceScope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TraceScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTraceScopes</summary>
        public void ListTraceScopesResourceNames()
        {
            // Snippet: ListTraceScopes(LocationName, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTraceScopesResponse, TraceScope> response = observabilityClient.ListTraceScopes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TraceScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTraceScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TraceScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TraceScope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TraceScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTraceScopesAsync</summary>
        public async Task ListTraceScopesResourceNamesAsync()
        {
            // Snippet: ListTraceScopesAsync(LocationName, string, int?, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTraceScopesResponse, TraceScope> response = observabilityClient.ListTraceScopesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TraceScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTraceScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TraceScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TraceScope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TraceScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateTraceScope</summary>
        public void CreateTraceScopeRequestObject()
        {
            // Snippet: CreateTraceScope(CreateTraceScopeRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            CreateTraceScopeRequest request = new CreateTraceScopeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TraceScopeId = "",
                TraceScope = new TraceScope(),
            };
            // Make the request
            TraceScope response = observabilityClient.CreateTraceScope(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTraceScopeAsync</summary>
        public async Task CreateTraceScopeRequestObjectAsync()
        {
            // Snippet: CreateTraceScopeAsync(CreateTraceScopeRequest, CallSettings)
            // Additional: CreateTraceScopeAsync(CreateTraceScopeRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            CreateTraceScopeRequest request = new CreateTraceScopeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TraceScopeId = "",
                TraceScope = new TraceScope(),
            };
            // Make the request
            TraceScope response = await observabilityClient.CreateTraceScopeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTraceScope</summary>
        public void CreateTraceScope()
        {
            // Snippet: CreateTraceScope(string, TraceScope, string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TraceScope traceScope = new TraceScope();
            string traceScopeId = "";
            // Make the request
            TraceScope response = observabilityClient.CreateTraceScope(parent, traceScope, traceScopeId);
            // End snippet
        }

        /// <summary>Snippet for CreateTraceScopeAsync</summary>
        public async Task CreateTraceScopeAsync()
        {
            // Snippet: CreateTraceScopeAsync(string, TraceScope, string, CallSettings)
            // Additional: CreateTraceScopeAsync(string, TraceScope, string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TraceScope traceScope = new TraceScope();
            string traceScopeId = "";
            // Make the request
            TraceScope response = await observabilityClient.CreateTraceScopeAsync(parent, traceScope, traceScopeId);
            // End snippet
        }

        /// <summary>Snippet for CreateTraceScope</summary>
        public void CreateTraceScopeResourceNames()
        {
            // Snippet: CreateTraceScope(LocationName, TraceScope, string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TraceScope traceScope = new TraceScope();
            string traceScopeId = "";
            // Make the request
            TraceScope response = observabilityClient.CreateTraceScope(parent, traceScope, traceScopeId);
            // End snippet
        }

        /// <summary>Snippet for CreateTraceScopeAsync</summary>
        public async Task CreateTraceScopeResourceNamesAsync()
        {
            // Snippet: CreateTraceScopeAsync(LocationName, TraceScope, string, CallSettings)
            // Additional: CreateTraceScopeAsync(LocationName, TraceScope, string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TraceScope traceScope = new TraceScope();
            string traceScopeId = "";
            // Make the request
            TraceScope response = await observabilityClient.CreateTraceScopeAsync(parent, traceScope, traceScopeId);
            // End snippet
        }

        /// <summary>Snippet for UpdateTraceScope</summary>
        public void UpdateTraceScopeRequestObject()
        {
            // Snippet: UpdateTraceScope(UpdateTraceScopeRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            UpdateTraceScopeRequest request = new UpdateTraceScopeRequest
            {
                TraceScope = new TraceScope(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TraceScope response = observabilityClient.UpdateTraceScope(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTraceScopeAsync</summary>
        public async Task UpdateTraceScopeRequestObjectAsync()
        {
            // Snippet: UpdateTraceScopeAsync(UpdateTraceScopeRequest, CallSettings)
            // Additional: UpdateTraceScopeAsync(UpdateTraceScopeRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTraceScopeRequest request = new UpdateTraceScopeRequest
            {
                TraceScope = new TraceScope(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TraceScope response = await observabilityClient.UpdateTraceScopeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTraceScope</summary>
        public void UpdateTraceScope()
        {
            // Snippet: UpdateTraceScope(TraceScope, FieldMask, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            TraceScope traceScope = new TraceScope();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TraceScope response = observabilityClient.UpdateTraceScope(traceScope, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTraceScopeAsync</summary>
        public async Task UpdateTraceScopeAsync()
        {
            // Snippet: UpdateTraceScopeAsync(TraceScope, FieldMask, CallSettings)
            // Additional: UpdateTraceScopeAsync(TraceScope, FieldMask, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            TraceScope traceScope = new TraceScope();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TraceScope response = await observabilityClient.UpdateTraceScopeAsync(traceScope, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTraceScope</summary>
        public void DeleteTraceScopeRequestObject()
        {
            // Snippet: DeleteTraceScope(DeleteTraceScopeRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            DeleteTraceScopeRequest request = new DeleteTraceScopeRequest
            {
                TraceScopeName = TraceScopeName.FromProjectLocationTraceScope("[PROJECT]", "[LOCATION]", "[TRACE_SCOPE]"),
            };
            // Make the request
            observabilityClient.DeleteTraceScope(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTraceScopeAsync</summary>
        public async Task DeleteTraceScopeRequestObjectAsync()
        {
            // Snippet: DeleteTraceScopeAsync(DeleteTraceScopeRequest, CallSettings)
            // Additional: DeleteTraceScopeAsync(DeleteTraceScopeRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTraceScopeRequest request = new DeleteTraceScopeRequest
            {
                TraceScopeName = TraceScopeName.FromProjectLocationTraceScope("[PROJECT]", "[LOCATION]", "[TRACE_SCOPE]"),
            };
            // Make the request
            await observabilityClient.DeleteTraceScopeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTraceScope</summary>
        public void DeleteTraceScope()
        {
            // Snippet: DeleteTraceScope(string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/traceScopes/[TRACE_SCOPE]";
            // Make the request
            observabilityClient.DeleteTraceScope(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTraceScopeAsync</summary>
        public async Task DeleteTraceScopeAsync()
        {
            // Snippet: DeleteTraceScopeAsync(string, CallSettings)
            // Additional: DeleteTraceScopeAsync(string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/traceScopes/[TRACE_SCOPE]";
            // Make the request
            await observabilityClient.DeleteTraceScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTraceScope</summary>
        public void DeleteTraceScopeResourceNames()
        {
            // Snippet: DeleteTraceScope(TraceScopeName, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            TraceScopeName name = TraceScopeName.FromProjectLocationTraceScope("[PROJECT]", "[LOCATION]", "[TRACE_SCOPE]");
            // Make the request
            observabilityClient.DeleteTraceScope(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTraceScopeAsync</summary>
        public async Task DeleteTraceScopeResourceNamesAsync()
        {
            // Snippet: DeleteTraceScopeAsync(TraceScopeName, CallSettings)
            // Additional: DeleteTraceScopeAsync(TraceScopeName, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            TraceScopeName name = TraceScopeName.FromProjectLocationTraceScope("[PROJECT]", "[LOCATION]", "[TRACE_SCOPE]");
            // Make the request
            await observabilityClient.DeleteTraceScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettingsRequestObject()
        {
            // Snippet: GetSettings(GetSettingsRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Settings response = observabilityClient.GetSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsRequestObjectAsync()
        {
            // Snippet: GetSettingsAsync(GetSettingsRequest, CallSettings)
            // Additional: GetSettingsAsync(GetSettingsRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Settings response = await observabilityClient.GetSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettings()
        {
            // Snippet: GetSettings(string, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/settings";
            // Make the request
            Settings response = observabilityClient.GetSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsAsync()
        {
            // Snippet: GetSettingsAsync(string, CallSettings)
            // Additional: GetSettingsAsync(string, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/settings";
            // Make the request
            Settings response = await observabilityClient.GetSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettingsResourceNames()
        {
            // Snippet: GetSettings(SettingsName, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Settings response = observabilityClient.GetSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsResourceNamesAsync()
        {
            // Snippet: GetSettingsAsync(SettingsName, CallSettings)
            // Additional: GetSettingsAsync(SettingsName, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Settings response = await observabilityClient.GetSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettings</summary>
        public void UpdateSettingsRequestObject()
        {
            // Snippet: UpdateSettings(UpdateSettingsRequest, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Settings, OperationMetadata> response = observabilityClient.UpdateSettings(request);

            // Poll until the returned long-running operation is complete
            Operation<Settings, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Settings result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Settings, OperationMetadata> retrievedResponse = observabilityClient.PollOnceUpdateSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Settings retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSettingsAsync</summary>
        public async Task UpdateSettingsRequestObjectAsync()
        {
            // Snippet: UpdateSettingsAsync(UpdateSettingsRequest, CallSettings)
            // Additional: UpdateSettingsAsync(UpdateSettingsRequest, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Settings, OperationMetadata> response = await observabilityClient.UpdateSettingsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Settings, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Settings result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Settings, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceUpdateSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Settings retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSettings</summary>
        public void UpdateSettings()
        {
            // Snippet: UpdateSettings(Settings, FieldMask, CallSettings)
            // Create client
            ObservabilityClient observabilityClient = ObservabilityClient.Create();
            // Initialize request argument(s)
            Settings settings = new Settings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Settings, OperationMetadata> response = observabilityClient.UpdateSettings(settings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Settings, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Settings result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Settings, OperationMetadata> retrievedResponse = observabilityClient.PollOnceUpdateSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Settings retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSettingsAsync</summary>
        public async Task UpdateSettingsAsync()
        {
            // Snippet: UpdateSettingsAsync(Settings, FieldMask, CallSettings)
            // Additional: UpdateSettingsAsync(Settings, FieldMask, CancellationToken)
            // Create client
            ObservabilityClient observabilityClient = await ObservabilityClient.CreateAsync();
            // Initialize request argument(s)
            Settings settings = new Settings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Settings, OperationMetadata> response = await observabilityClient.UpdateSettingsAsync(settings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Settings, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Settings result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Settings, OperationMetadata> retrievedResponse = await observabilityClient.PollOnceUpdateSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Settings retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
