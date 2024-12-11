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
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using gcsv = Google.Cloud.Storage.V2;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedStorageClientSnippets
    {
        /// <summary>Snippet for DeleteBucket</summary>
        public void DeleteBucketRequestObject()
        {
            // Snippet: DeleteBucket(DeleteBucketRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::DeleteBucketRequest request = new gcsv::DeleteBucketRequest
            {
                BucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
            };
            // Make the request
            storageClient.DeleteBucket(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBucketAsync</summary>
        public async Task DeleteBucketRequestObjectAsync()
        {
            // Snippet: DeleteBucketAsync(DeleteBucketRequest, CallSettings)
            // Additional: DeleteBucketAsync(DeleteBucketRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::DeleteBucketRequest request = new gcsv::DeleteBucketRequest
            {
                BucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
            };
            // Make the request
            await storageClient.DeleteBucketAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBucket</summary>
        public void DeleteBucket()
        {
            // Snippet: DeleteBucket(string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            storageClient.DeleteBucket(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBucketAsync</summary>
        public async Task DeleteBucketAsync()
        {
            // Snippet: DeleteBucketAsync(string, CallSettings)
            // Additional: DeleteBucketAsync(string, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            await storageClient.DeleteBucketAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBucket</summary>
        public void DeleteBucketResourceNames()
        {
            // Snippet: DeleteBucket(BucketName, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::BucketName name = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            storageClient.DeleteBucket(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBucketAsync</summary>
        public async Task DeleteBucketResourceNamesAsync()
        {
            // Snippet: DeleteBucketAsync(BucketName, CallSettings)
            // Additional: DeleteBucketAsync(BucketName, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::BucketName name = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            await storageClient.DeleteBucketAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBucket</summary>
        public void GetBucketRequestObject()
        {
            // Snippet: GetBucket(GetBucketRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::GetBucketRequest request = new gcsv::GetBucketRequest
            {
                BucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                ReadMask = new FieldMask(),
            };
            // Make the request
            gcsv::Bucket response = storageClient.GetBucket(request);
            // End snippet
        }

        /// <summary>Snippet for GetBucketAsync</summary>
        public async Task GetBucketRequestObjectAsync()
        {
            // Snippet: GetBucketAsync(GetBucketRequest, CallSettings)
            // Additional: GetBucketAsync(GetBucketRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::GetBucketRequest request = new gcsv::GetBucketRequest
            {
                BucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                ReadMask = new FieldMask(),
            };
            // Make the request
            gcsv::Bucket response = await storageClient.GetBucketAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBucket</summary>
        public void GetBucket()
        {
            // Snippet: GetBucket(string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            gcsv::Bucket response = storageClient.GetBucket(name);
            // End snippet
        }

        /// <summary>Snippet for GetBucketAsync</summary>
        public async Task GetBucketAsync()
        {
            // Snippet: GetBucketAsync(string, CallSettings)
            // Additional: GetBucketAsync(string, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            gcsv::Bucket response = await storageClient.GetBucketAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBucket</summary>
        public void GetBucketResourceNames()
        {
            // Snippet: GetBucket(BucketName, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::BucketName name = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            gcsv::Bucket response = storageClient.GetBucket(name);
            // End snippet
        }

        /// <summary>Snippet for GetBucketAsync</summary>
        public async Task GetBucketResourceNamesAsync()
        {
            // Snippet: GetBucketAsync(BucketName, CallSettings)
            // Additional: GetBucketAsync(BucketName, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::BucketName name = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            gcsv::Bucket response = await storageClient.GetBucketAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateBucket</summary>
        public void CreateBucketRequestObject()
        {
            // Snippet: CreateBucket(CreateBucketRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::CreateBucketRequest request = new gcsv::CreateBucketRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Bucket = new gcsv::Bucket(),
                BucketId = "",
                PredefinedAcl = "",
                PredefinedDefaultObjectAcl = "",
            };
            // Make the request
            gcsv::Bucket response = storageClient.CreateBucket(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBucketAsync</summary>
        public async Task CreateBucketRequestObjectAsync()
        {
            // Snippet: CreateBucketAsync(CreateBucketRequest, CallSettings)
            // Additional: CreateBucketAsync(CreateBucketRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::CreateBucketRequest request = new gcsv::CreateBucketRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Bucket = new gcsv::Bucket(),
                BucketId = "",
                PredefinedAcl = "",
                PredefinedDefaultObjectAcl = "",
            };
            // Make the request
            gcsv::Bucket response = await storageClient.CreateBucketAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBucket</summary>
        public void CreateBucket()
        {
            // Snippet: CreateBucket(string, Bucket, string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            gcsv::Bucket bucket = new gcsv::Bucket();
            string bucketId = "";
            // Make the request
            gcsv::Bucket response = storageClient.CreateBucket(parent, bucket, bucketId);
            // End snippet
        }

        /// <summary>Snippet for CreateBucketAsync</summary>
        public async Task CreateBucketAsync()
        {
            // Snippet: CreateBucketAsync(string, Bucket, string, CallSettings)
            // Additional: CreateBucketAsync(string, Bucket, string, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            gcsv::Bucket bucket = new gcsv::Bucket();
            string bucketId = "";
            // Make the request
            gcsv::Bucket response = await storageClient.CreateBucketAsync(parent, bucket, bucketId);
            // End snippet
        }

        /// <summary>Snippet for CreateBucket</summary>
        public void CreateBucketResourceNames()
        {
            // Snippet: CreateBucket(ProjectName, Bucket, string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            gcsv::Bucket bucket = new gcsv::Bucket();
            string bucketId = "";
            // Make the request
            gcsv::Bucket response = storageClient.CreateBucket(parent, bucket, bucketId);
            // End snippet
        }

        /// <summary>Snippet for CreateBucketAsync</summary>
        public async Task CreateBucketResourceNamesAsync()
        {
            // Snippet: CreateBucketAsync(ProjectName, Bucket, string, CallSettings)
            // Additional: CreateBucketAsync(ProjectName, Bucket, string, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            gcsv::Bucket bucket = new gcsv::Bucket();
            string bucketId = "";
            // Make the request
            gcsv::Bucket response = await storageClient.CreateBucketAsync(parent, bucket, bucketId);
            // End snippet
        }

        /// <summary>Snippet for ListBuckets</summary>
        public void ListBucketsRequestObject()
        {
            // Snippet: ListBuckets(ListBucketsRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::ListBucketsRequest request = new gcsv::ListBucketsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Prefix = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<gcsv::ListBucketsResponse, gcsv::Bucket> response = storageClient.ListBuckets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcsv::Bucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcsv::ListBucketsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Bucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Bucket item in singlePage)
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
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::ListBucketsRequest request = new gcsv::ListBucketsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Prefix = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<gcsv::ListBucketsResponse, gcsv::Bucket> response = storageClient.ListBucketsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcsv::Bucket item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcsv::ListBucketsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Bucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Bucket item in singlePage)
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
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<gcsv::ListBucketsResponse, gcsv::Bucket> response = storageClient.ListBuckets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcsv::Bucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcsv::ListBucketsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Bucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Bucket item in singlePage)
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
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<gcsv::ListBucketsResponse, gcsv::Bucket> response = storageClient.ListBucketsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcsv::Bucket item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcsv::ListBucketsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Bucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Bucket item in singlePage)
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
            // Snippet: ListBuckets(ProjectName, string, int?, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<gcsv::ListBucketsResponse, gcsv::Bucket> response = storageClient.ListBuckets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcsv::Bucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcsv::ListBucketsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Bucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Bucket item in singlePage)
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
            // Snippet: ListBucketsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<gcsv::ListBucketsResponse, gcsv::Bucket> response = storageClient.ListBucketsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcsv::Bucket item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcsv::ListBucketsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Bucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Bucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LockBucketRetentionPolicy</summary>
        public void LockBucketRetentionPolicyRequestObject()
        {
            // Snippet: LockBucketRetentionPolicy(LockBucketRetentionPolicyRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::LockBucketRetentionPolicyRequest request = new gcsv::LockBucketRetentionPolicyRequest
            {
                BucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                IfMetagenerationMatch = 0L,
            };
            // Make the request
            gcsv::Bucket response = storageClient.LockBucketRetentionPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for LockBucketRetentionPolicyAsync</summary>
        public async Task LockBucketRetentionPolicyRequestObjectAsync()
        {
            // Snippet: LockBucketRetentionPolicyAsync(LockBucketRetentionPolicyRequest, CallSettings)
            // Additional: LockBucketRetentionPolicyAsync(LockBucketRetentionPolicyRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::LockBucketRetentionPolicyRequest request = new gcsv::LockBucketRetentionPolicyRequest
            {
                BucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                IfMetagenerationMatch = 0L,
            };
            // Make the request
            gcsv::Bucket response = await storageClient.LockBucketRetentionPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LockBucketRetentionPolicy</summary>
        public void LockBucketRetentionPolicy()
        {
            // Snippet: LockBucketRetentionPolicy(string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            gcsv::Bucket response = storageClient.LockBucketRetentionPolicy(bucket);
            // End snippet
        }

        /// <summary>Snippet for LockBucketRetentionPolicyAsync</summary>
        public async Task LockBucketRetentionPolicyAsync()
        {
            // Snippet: LockBucketRetentionPolicyAsync(string, CallSettings)
            // Additional: LockBucketRetentionPolicyAsync(string, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            gcsv::Bucket response = await storageClient.LockBucketRetentionPolicyAsync(bucket);
            // End snippet
        }

        /// <summary>Snippet for LockBucketRetentionPolicy</summary>
        public void LockBucketRetentionPolicyResourceNames()
        {
            // Snippet: LockBucketRetentionPolicy(BucketName, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            gcsv::Bucket response = storageClient.LockBucketRetentionPolicy(bucket);
            // End snippet
        }

        /// <summary>Snippet for LockBucketRetentionPolicyAsync</summary>
        public async Task LockBucketRetentionPolicyResourceNamesAsync()
        {
            // Snippet: LockBucketRetentionPolicyAsync(BucketName, CallSettings)
            // Additional: LockBucketRetentionPolicyAsync(BucketName, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            gcsv::Bucket response = await storageClient.LockBucketRetentionPolicyAsync(bucket);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = storageClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await storageClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = storageClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await storageClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = storageClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await storageClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = storageClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await storageClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = storageClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await storageClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = storageClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await storageClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = storageClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await storageClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = storageClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await storageClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = storageClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await storageClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for UpdateBucket</summary>
        public void UpdateBucketRequestObject()
        {
            // Snippet: UpdateBucket(UpdateBucketRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::UpdateBucketRequest request = new gcsv::UpdateBucketRequest
            {
                Bucket = new gcsv::Bucket(),
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                UpdateMask = new FieldMask(),
                PredefinedAcl = "",
                PredefinedDefaultObjectAcl = "",
            };
            // Make the request
            gcsv::Bucket response = storageClient.UpdateBucket(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBucketAsync</summary>
        public async Task UpdateBucketRequestObjectAsync()
        {
            // Snippet: UpdateBucketAsync(UpdateBucketRequest, CallSettings)
            // Additional: UpdateBucketAsync(UpdateBucketRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::UpdateBucketRequest request = new gcsv::UpdateBucketRequest
            {
                Bucket = new gcsv::Bucket(),
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                UpdateMask = new FieldMask(),
                PredefinedAcl = "",
                PredefinedDefaultObjectAcl = "",
            };
            // Make the request
            gcsv::Bucket response = await storageClient.UpdateBucketAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBucket</summary>
        public void UpdateBucket()
        {
            // Snippet: UpdateBucket(Bucket, FieldMask, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::Bucket bucket = new gcsv::Bucket();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcsv::Bucket response = storageClient.UpdateBucket(bucket, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateBucketAsync</summary>
        public async Task UpdateBucketAsync()
        {
            // Snippet: UpdateBucketAsync(Bucket, FieldMask, CallSettings)
            // Additional: UpdateBucketAsync(Bucket, FieldMask, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::Bucket bucket = new gcsv::Bucket();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcsv::Bucket response = await storageClient.UpdateBucketAsync(bucket, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ComposeObject</summary>
        public void ComposeObjectRequestObject()
        {
            // Snippet: ComposeObject(ComposeObjectRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::ComposeObjectRequest request = new gcsv::ComposeObjectRequest
            {
                Destination = new gcsv::Object(),
                SourceObjects =
                {
                    new gcsv::ComposeObjectRequest.Types.SourceObject(),
                },
                IfGenerationMatch = 0L,
                IfMetagenerationMatch = 0L,
                KmsKeyAsCryptoKeyName = gcsv::CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
                DestinationPredefinedAcl = "",
                ObjectChecksums = new gcsv::ObjectChecksums(),
            };
            // Make the request
            gcsv::Object response = storageClient.ComposeObject(request);
            // End snippet
        }

        /// <summary>Snippet for ComposeObjectAsync</summary>
        public async Task ComposeObjectRequestObjectAsync()
        {
            // Snippet: ComposeObjectAsync(ComposeObjectRequest, CallSettings)
            // Additional: ComposeObjectAsync(ComposeObjectRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::ComposeObjectRequest request = new gcsv::ComposeObjectRequest
            {
                Destination = new gcsv::Object(),
                SourceObjects =
                {
                    new gcsv::ComposeObjectRequest.Types.SourceObject(),
                },
                IfGenerationMatch = 0L,
                IfMetagenerationMatch = 0L,
                KmsKeyAsCryptoKeyName = gcsv::CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
                DestinationPredefinedAcl = "",
                ObjectChecksums = new gcsv::ObjectChecksums(),
            };
            // Make the request
            gcsv::Object response = await storageClient.ComposeObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteObject</summary>
        public void DeleteObjectRequestObject()
        {
            // Snippet: DeleteObject(DeleteObjectRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::DeleteObjectRequest request = new gcsv::DeleteObjectRequest
            {
                BucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Object = "",
                Generation = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
            };
            // Make the request
            storageClient.DeleteObject(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteObjectAsync</summary>
        public async Task DeleteObjectRequestObjectAsync()
        {
            // Snippet: DeleteObjectAsync(DeleteObjectRequest, CallSettings)
            // Additional: DeleteObjectAsync(DeleteObjectRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::DeleteObjectRequest request = new gcsv::DeleteObjectRequest
            {
                BucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Object = "",
                Generation = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
            };
            // Make the request
            await storageClient.DeleteObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteObject</summary>
        public void DeleteObject1()
        {
            // Snippet: DeleteObject(string, string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            string @object = "";
            // Make the request
            storageClient.DeleteObject(bucket, @object);
            // End snippet
        }

        /// <summary>Snippet for DeleteObjectAsync</summary>
        public async Task DeleteObject1Async()
        {
            // Snippet: DeleteObjectAsync(string, string, CallSettings)
            // Additional: DeleteObjectAsync(string, string, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            string @object = "";
            // Make the request
            await storageClient.DeleteObjectAsync(bucket, @object);
            // End snippet
        }

        /// <summary>Snippet for DeleteObject</summary>
        public void DeleteObject1ResourceNames()
        {
            // Snippet: DeleteObject(BucketName, string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            string @object = "";
            // Make the request
            storageClient.DeleteObject(bucket, @object);
            // End snippet
        }

        /// <summary>Snippet for DeleteObjectAsync</summary>
        public async Task DeleteObject1ResourceNamesAsync()
        {
            // Snippet: DeleteObjectAsync(BucketName, string, CallSettings)
            // Additional: DeleteObjectAsync(BucketName, string, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            string @object = "";
            // Make the request
            await storageClient.DeleteObjectAsync(bucket, @object);
            // End snippet
        }

        /// <summary>Snippet for DeleteObject</summary>
        public void DeleteObject2()
        {
            // Snippet: DeleteObject(string, string, long, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            string @object = "";
            long generation = 0L;
            // Make the request
            storageClient.DeleteObject(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for DeleteObjectAsync</summary>
        public async Task DeleteObject2Async()
        {
            // Snippet: DeleteObjectAsync(string, string, long, CallSettings)
            // Additional: DeleteObjectAsync(string, string, long, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            string @object = "";
            long generation = 0L;
            // Make the request
            await storageClient.DeleteObjectAsync(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for DeleteObject</summary>
        public void DeleteObject2ResourceNames()
        {
            // Snippet: DeleteObject(BucketName, string, long, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            string @object = "";
            long generation = 0L;
            // Make the request
            storageClient.DeleteObject(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for DeleteObjectAsync</summary>
        public async Task DeleteObject2ResourceNamesAsync()
        {
            // Snippet: DeleteObjectAsync(BucketName, string, long, CallSettings)
            // Additional: DeleteObjectAsync(BucketName, string, long, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            string @object = "";
            long generation = 0L;
            // Make the request
            await storageClient.DeleteObjectAsync(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for RestoreObject</summary>
        public void RestoreObjectRequestObject()
        {
            // Snippet: RestoreObject(RestoreObjectRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::RestoreObjectRequest request = new gcsv::RestoreObjectRequest
            {
                BucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Object = "",
                Generation = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
                CopySourceAcl = false,
                RestoreToken = "",
            };
            // Make the request
            gcsv::Object response = storageClient.RestoreObject(request);
            // End snippet
        }

        /// <summary>Snippet for RestoreObjectAsync</summary>
        public async Task RestoreObjectRequestObjectAsync()
        {
            // Snippet: RestoreObjectAsync(RestoreObjectRequest, CallSettings)
            // Additional: RestoreObjectAsync(RestoreObjectRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::RestoreObjectRequest request = new gcsv::RestoreObjectRequest
            {
                BucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Object = "",
                Generation = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
                CopySourceAcl = false,
                RestoreToken = "",
            };
            // Make the request
            gcsv::Object response = await storageClient.RestoreObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RestoreObject</summary>
        public void RestoreObject()
        {
            // Snippet: RestoreObject(string, string, long, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            string @object = "";
            long generation = 0L;
            // Make the request
            gcsv::Object response = storageClient.RestoreObject(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for RestoreObjectAsync</summary>
        public async Task RestoreObjectAsync()
        {
            // Snippet: RestoreObjectAsync(string, string, long, CallSettings)
            // Additional: RestoreObjectAsync(string, string, long, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            string @object = "";
            long generation = 0L;
            // Make the request
            gcsv::Object response = await storageClient.RestoreObjectAsync(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for RestoreObject</summary>
        public void RestoreObjectResourceNames()
        {
            // Snippet: RestoreObject(BucketName, string, long, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            string @object = "";
            long generation = 0L;
            // Make the request
            gcsv::Object response = storageClient.RestoreObject(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for RestoreObjectAsync</summary>
        public async Task RestoreObjectResourceNamesAsync()
        {
            // Snippet: RestoreObjectAsync(BucketName, string, long, CallSettings)
            // Additional: RestoreObjectAsync(BucketName, string, long, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            string @object = "";
            long generation = 0L;
            // Make the request
            gcsv::Object response = await storageClient.RestoreObjectAsync(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for CancelResumableWrite</summary>
        public void CancelResumableWriteRequestObject()
        {
            // Snippet: CancelResumableWrite(CancelResumableWriteRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::CancelResumableWriteRequest request = new gcsv::CancelResumableWriteRequest { UploadId = "", };
            // Make the request
            gcsv::CancelResumableWriteResponse response = storageClient.CancelResumableWrite(request);
            // End snippet
        }

        /// <summary>Snippet for CancelResumableWriteAsync</summary>
        public async Task CancelResumableWriteRequestObjectAsync()
        {
            // Snippet: CancelResumableWriteAsync(CancelResumableWriteRequest, CallSettings)
            // Additional: CancelResumableWriteAsync(CancelResumableWriteRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::CancelResumableWriteRequest request = new gcsv::CancelResumableWriteRequest { UploadId = "", };
            // Make the request
            gcsv::CancelResumableWriteResponse response = await storageClient.CancelResumableWriteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelResumableWrite</summary>
        public void CancelResumableWrite()
        {
            // Snippet: CancelResumableWrite(string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string uploadId = "";
            // Make the request
            gcsv::CancelResumableWriteResponse response = storageClient.CancelResumableWrite(uploadId);
            // End snippet
        }

        /// <summary>Snippet for CancelResumableWriteAsync</summary>
        public async Task CancelResumableWriteAsync()
        {
            // Snippet: CancelResumableWriteAsync(string, CallSettings)
            // Additional: CancelResumableWriteAsync(string, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string uploadId = "";
            // Make the request
            gcsv::CancelResumableWriteResponse response = await storageClient.CancelResumableWriteAsync(uploadId);
            // End snippet
        }

        /// <summary>Snippet for GetObject</summary>
        public void GetObjectRequestObject()
        {
            // Snippet: GetObject(GetObjectRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::GetObjectRequest request = new gcsv::GetObjectRequest
            {
                BucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Object = "",
                Generation = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
                ReadMask = new FieldMask(),
                SoftDeleted = false,
                RestoreToken = "",
            };
            // Make the request
            gcsv::Object response = storageClient.GetObject(request);
            // End snippet
        }

        /// <summary>Snippet for GetObjectAsync</summary>
        public async Task GetObjectRequestObjectAsync()
        {
            // Snippet: GetObjectAsync(GetObjectRequest, CallSettings)
            // Additional: GetObjectAsync(GetObjectRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::GetObjectRequest request = new gcsv::GetObjectRequest
            {
                BucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Object = "",
                Generation = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
                ReadMask = new FieldMask(),
                SoftDeleted = false,
                RestoreToken = "",
            };
            // Make the request
            gcsv::Object response = await storageClient.GetObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetObject</summary>
        public void GetObject1()
        {
            // Snippet: GetObject(string, string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            string @object = "";
            // Make the request
            gcsv::Object response = storageClient.GetObject(bucket, @object);
            // End snippet
        }

        /// <summary>Snippet for GetObjectAsync</summary>
        public async Task GetObject1Async()
        {
            // Snippet: GetObjectAsync(string, string, CallSettings)
            // Additional: GetObjectAsync(string, string, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            string @object = "";
            // Make the request
            gcsv::Object response = await storageClient.GetObjectAsync(bucket, @object);
            // End snippet
        }

        /// <summary>Snippet for GetObject</summary>
        public void GetObject1ResourceNames()
        {
            // Snippet: GetObject(BucketName, string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            string @object = "";
            // Make the request
            gcsv::Object response = storageClient.GetObject(bucket, @object);
            // End snippet
        }

        /// <summary>Snippet for GetObjectAsync</summary>
        public async Task GetObject1ResourceNamesAsync()
        {
            // Snippet: GetObjectAsync(BucketName, string, CallSettings)
            // Additional: GetObjectAsync(BucketName, string, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            string @object = "";
            // Make the request
            gcsv::Object response = await storageClient.GetObjectAsync(bucket, @object);
            // End snippet
        }

        /// <summary>Snippet for GetObject</summary>
        public void GetObject2()
        {
            // Snippet: GetObject(string, string, long, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            string @object = "";
            long generation = 0L;
            // Make the request
            gcsv::Object response = storageClient.GetObject(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for GetObjectAsync</summary>
        public async Task GetObject2Async()
        {
            // Snippet: GetObjectAsync(string, string, long, CallSettings)
            // Additional: GetObjectAsync(string, string, long, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            string @object = "";
            long generation = 0L;
            // Make the request
            gcsv::Object response = await storageClient.GetObjectAsync(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for GetObject</summary>
        public void GetObject2ResourceNames()
        {
            // Snippet: GetObject(BucketName, string, long, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            string @object = "";
            long generation = 0L;
            // Make the request
            gcsv::Object response = storageClient.GetObject(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for GetObjectAsync</summary>
        public async Task GetObject2ResourceNamesAsync()
        {
            // Snippet: GetObjectAsync(BucketName, string, long, CallSettings)
            // Additional: GetObjectAsync(BucketName, string, long, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            string @object = "";
            long generation = 0L;
            // Make the request
            gcsv::Object response = await storageClient.GetObjectAsync(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for ReadObject</summary>
        public async Task ReadObjectRequestObject()
        {
            // Snippet: ReadObject(ReadObjectRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::ReadObjectRequest request = new gcsv::ReadObjectRequest
            {
                BucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Object = "",
                Generation = 0L,
                ReadOffset = 0L,
                ReadLimit = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
                ReadMask = new FieldMask(),
            };
            // Make the request, returning a streaming response
            using gcsv::StorageClient.ReadObjectStream response = storageClient.ReadObject(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcsv::ReadObjectResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcsv::ReadObjectResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadObject</summary>
        public async Task ReadObject1()
        {
            // Snippet: ReadObject(string, string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            string @object = "";
            // Make the request, returning a streaming response
            using gcsv::StorageClient.ReadObjectStream response = storageClient.ReadObject(bucket, @object);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcsv::ReadObjectResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcsv::ReadObjectResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadObject</summary>
        public async Task ReadObject1ResourceNames()
        {
            // Snippet: ReadObject(BucketName, string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            string @object = "";
            // Make the request, returning a streaming response
            using gcsv::StorageClient.ReadObjectStream response = storageClient.ReadObject(bucket, @object);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcsv::ReadObjectResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcsv::ReadObjectResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadObject</summary>
        public async Task ReadObject2()
        {
            // Snippet: ReadObject(string, string, long, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            string @object = "";
            long generation = 0L;
            // Make the request, returning a streaming response
            using gcsv::StorageClient.ReadObjectStream response = storageClient.ReadObject(bucket, @object, generation);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcsv::ReadObjectResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcsv::ReadObjectResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadObject</summary>
        public async Task ReadObject2ResourceNames()
        {
            // Snippet: ReadObject(BucketName, string, long, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            string @object = "";
            long generation = 0L;
            // Make the request, returning a streaming response
            using gcsv::StorageClient.ReadObjectStream response = storageClient.ReadObject(bucket, @object, generation);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcsv::ReadObjectResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcsv::ReadObjectResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for UpdateObject</summary>
        public void UpdateObjectRequestObject()
        {
            // Snippet: UpdateObject(UpdateObjectRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::UpdateObjectRequest request = new gcsv::UpdateObjectRequest
            {
                Object = new gcsv::Object(),
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                UpdateMask = new FieldMask(),
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
                PredefinedAcl = "",
            };
            // Make the request
            gcsv::Object response = storageClient.UpdateObject(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateObjectAsync</summary>
        public async Task UpdateObjectRequestObjectAsync()
        {
            // Snippet: UpdateObjectAsync(UpdateObjectRequest, CallSettings)
            // Additional: UpdateObjectAsync(UpdateObjectRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::UpdateObjectRequest request = new gcsv::UpdateObjectRequest
            {
                Object = new gcsv::Object(),
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                UpdateMask = new FieldMask(),
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
                PredefinedAcl = "",
            };
            // Make the request
            gcsv::Object response = await storageClient.UpdateObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateObject</summary>
        public void UpdateObject()
        {
            // Snippet: UpdateObject(Object, FieldMask, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::Object @object = new gcsv::Object();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcsv::Object response = storageClient.UpdateObject(@object, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateObjectAsync</summary>
        public async Task UpdateObjectAsync()
        {
            // Snippet: UpdateObjectAsync(Object, FieldMask, CallSettings)
            // Additional: UpdateObjectAsync(Object, FieldMask, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::Object @object = new gcsv::Object();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcsv::Object response = await storageClient.UpdateObjectAsync(@object, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BidiWriteObject</summary>
        public async Task BidiWriteObject()
        {
            // Snippet: BidiWriteObject(CallSettings, BidirectionalStreamingSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize streaming call, retrieving the stream object
            using gcsv::StorageClient.BidiWriteObjectStream response = storageClient.BidiWriteObject();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<gcsv::BidiWriteObjectResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    gcsv::BidiWriteObjectResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                gcsv::BidiWriteObjectRequest request = new gcsv::BidiWriteObjectRequest
                {
                    UploadId = "",
                    WriteOffset = 0L,
                    ChecksummedData = new gcsv::ChecksummedData(),
                    ObjectChecksums = new gcsv::ObjectChecksums(),
                    StateLookup = false,
                    Flush = false,
                    FinishWrite = false,
                    CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for ListObjects</summary>
        public void ListObjectsRequestObject()
        {
            // Snippet: ListObjects(ListObjectsRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::ListObjectsRequest request = new gcsv::ListObjectsRequest
            {
                ParentAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Delimiter = "",
                IncludeTrailingDelimiter = false,
                Prefix = "",
                Versions = false,
                ReadMask = new FieldMask(),
                LexicographicStart = "",
                LexicographicEnd = "",
                SoftDeleted = false,
                IncludeFoldersAsPrefixes = false,
                MatchGlob = "",
            };
            // Make the request
            PagedEnumerable<gcsv::ListObjectsResponse, gcsv::Object> response = storageClient.ListObjects(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcsv::Object item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcsv::ListObjectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Object item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Object> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Object item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListObjectsAsync</summary>
        public async Task ListObjectsRequestObjectAsync()
        {
            // Snippet: ListObjectsAsync(ListObjectsRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::ListObjectsRequest request = new gcsv::ListObjectsRequest
            {
                ParentAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Delimiter = "",
                IncludeTrailingDelimiter = false,
                Prefix = "",
                Versions = false,
                ReadMask = new FieldMask(),
                LexicographicStart = "",
                LexicographicEnd = "",
                SoftDeleted = false,
                IncludeFoldersAsPrefixes = false,
                MatchGlob = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcsv::ListObjectsResponse, gcsv::Object> response = storageClient.ListObjectsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcsv::Object item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcsv::ListObjectsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Object item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Object> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Object item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListObjects</summary>
        public void ListObjects()
        {
            // Snippet: ListObjects(string, string, int?, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            PagedEnumerable<gcsv::ListObjectsResponse, gcsv::Object> response = storageClient.ListObjects(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcsv::Object item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcsv::ListObjectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Object item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Object> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Object item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListObjectsAsync</summary>
        public async Task ListObjectsAsync()
        {
            // Snippet: ListObjectsAsync(string, string, int?, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            PagedAsyncEnumerable<gcsv::ListObjectsResponse, gcsv::Object> response = storageClient.ListObjectsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcsv::Object item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcsv::ListObjectsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Object item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Object> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Object item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListObjects</summary>
        public void ListObjectsResourceNames()
        {
            // Snippet: ListObjects(BucketName, string, int?, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::BucketName parent = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            PagedEnumerable<gcsv::ListObjectsResponse, gcsv::Object> response = storageClient.ListObjects(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcsv::Object item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcsv::ListObjectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Object item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Object> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Object item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListObjectsAsync</summary>
        public async Task ListObjectsResourceNamesAsync()
        {
            // Snippet: ListObjectsAsync(BucketName, string, int?, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::BucketName parent = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            PagedAsyncEnumerable<gcsv::ListObjectsResponse, gcsv::Object> response = storageClient.ListObjectsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcsv::Object item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcsv::ListObjectsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Object item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Object> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Object item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RewriteObject</summary>
        public void RewriteObjectRequestObject()
        {
            // Snippet: RewriteObject(RewriteObjectRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::RewriteObjectRequest request = new gcsv::RewriteObjectRequest
            {
                Destination = new gcsv::Object(),
                SourceBucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                SourceObject = "",
                SourceGeneration = 0L,
                RewriteToken = "",
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                IfSourceGenerationMatch = 0L,
                IfSourceGenerationNotMatch = 0L,
                IfSourceMetagenerationMatch = 0L,
                IfSourceMetagenerationNotMatch = 0L,
                MaxBytesRewrittenPerCall = 0L,
                CopySourceEncryptionAlgorithm = "",
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
                CopySourceEncryptionKeyBytes = ByteString.Empty,
                CopySourceEncryptionKeySha256Bytes = ByteString.Empty,
                DestinationName = "",
                DestinationBucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                DestinationKmsKeyAsCryptoKeyName = gcsv::CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                DestinationPredefinedAcl = "",
                ObjectChecksums = new gcsv::ObjectChecksums(),
            };
            // Make the request
            gcsv::RewriteResponse response = storageClient.RewriteObject(request);
            // End snippet
        }

        /// <summary>Snippet for RewriteObjectAsync</summary>
        public async Task RewriteObjectRequestObjectAsync()
        {
            // Snippet: RewriteObjectAsync(RewriteObjectRequest, CallSettings)
            // Additional: RewriteObjectAsync(RewriteObjectRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::RewriteObjectRequest request = new gcsv::RewriteObjectRequest
            {
                Destination = new gcsv::Object(),
                SourceBucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                SourceObject = "",
                SourceGeneration = 0L,
                RewriteToken = "",
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                IfSourceGenerationMatch = 0L,
                IfSourceGenerationNotMatch = 0L,
                IfSourceMetagenerationMatch = 0L,
                IfSourceMetagenerationNotMatch = 0L,
                MaxBytesRewrittenPerCall = 0L,
                CopySourceEncryptionAlgorithm = "",
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
                CopySourceEncryptionKeyBytes = ByteString.Empty,
                CopySourceEncryptionKeySha256Bytes = ByteString.Empty,
                DestinationName = "",
                DestinationBucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                DestinationKmsKeyAsCryptoKeyName = gcsv::CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                DestinationPredefinedAcl = "",
                ObjectChecksums = new gcsv::ObjectChecksums(),
            };
            // Make the request
            gcsv::RewriteResponse response = await storageClient.RewriteObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartResumableWrite</summary>
        public void StartResumableWriteRequestObject()
        {
            // Snippet: StartResumableWrite(StartResumableWriteRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::StartResumableWriteRequest request = new gcsv::StartResumableWriteRequest
            {
                WriteObjectSpec = new gcsv::WriteObjectSpec(),
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
                ObjectChecksums = new gcsv::ObjectChecksums(),
            };
            // Make the request
            gcsv::StartResumableWriteResponse response = storageClient.StartResumableWrite(request);
            // End snippet
        }

        /// <summary>Snippet for StartResumableWriteAsync</summary>
        public async Task StartResumableWriteRequestObjectAsync()
        {
            // Snippet: StartResumableWriteAsync(StartResumableWriteRequest, CallSettings)
            // Additional: StartResumableWriteAsync(StartResumableWriteRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::StartResumableWriteRequest request = new gcsv::StartResumableWriteRequest
            {
                WriteObjectSpec = new gcsv::WriteObjectSpec(),
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
                ObjectChecksums = new gcsv::ObjectChecksums(),
            };
            // Make the request
            gcsv::StartResumableWriteResponse response = await storageClient.StartResumableWriteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryWriteStatus</summary>
        public void QueryWriteStatusRequestObject()
        {
            // Snippet: QueryWriteStatus(QueryWriteStatusRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::QueryWriteStatusRequest request = new gcsv::QueryWriteStatusRequest
            {
                UploadId = "",
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
            };
            // Make the request
            gcsv::QueryWriteStatusResponse response = storageClient.QueryWriteStatus(request);
            // End snippet
        }

        /// <summary>Snippet for QueryWriteStatusAsync</summary>
        public async Task QueryWriteStatusRequestObjectAsync()
        {
            // Snippet: QueryWriteStatusAsync(QueryWriteStatusRequest, CallSettings)
            // Additional: QueryWriteStatusAsync(QueryWriteStatusRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::QueryWriteStatusRequest request = new gcsv::QueryWriteStatusRequest
            {
                UploadId = "",
                CommonObjectRequestParams = new gcsv::CommonObjectRequestParams(),
            };
            // Make the request
            gcsv::QueryWriteStatusResponse response = await storageClient.QueryWriteStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryWriteStatus</summary>
        public void QueryWriteStatus()
        {
            // Snippet: QueryWriteStatus(string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string uploadId = "";
            // Make the request
            gcsv::QueryWriteStatusResponse response = storageClient.QueryWriteStatus(uploadId);
            // End snippet
        }

        /// <summary>Snippet for QueryWriteStatusAsync</summary>
        public async Task QueryWriteStatusAsync()
        {
            // Snippet: QueryWriteStatusAsync(string, CallSettings)
            // Additional: QueryWriteStatusAsync(string, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string uploadId = "";
            // Make the request
            gcsv::QueryWriteStatusResponse response = await storageClient.QueryWriteStatusAsync(uploadId);
            // End snippet
        }

        /// <summary>Snippet for MoveObject</summary>
        public void MoveObjectRequestObject()
        {
            // Snippet: MoveObject(MoveObjectRequest, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::MoveObjectRequest request = new gcsv::MoveObjectRequest
            {
                BucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                SourceObject = "",
                DestinationObject = "",
                IfSourceGenerationMatch = 0L,
                IfSourceGenerationNotMatch = 0L,
                IfSourceMetagenerationMatch = 0L,
                IfSourceMetagenerationNotMatch = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
            };
            // Make the request
            gcsv::Object response = storageClient.MoveObject(request);
            // End snippet
        }

        /// <summary>Snippet for MoveObjectAsync</summary>
        public async Task MoveObjectRequestObjectAsync()
        {
            // Snippet: MoveObjectAsync(MoveObjectRequest, CallSettings)
            // Additional: MoveObjectAsync(MoveObjectRequest, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::MoveObjectRequest request = new gcsv::MoveObjectRequest
            {
                BucketAsBucketName = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                SourceObject = "",
                DestinationObject = "",
                IfSourceGenerationMatch = 0L,
                IfSourceGenerationNotMatch = 0L,
                IfSourceMetagenerationMatch = 0L,
                IfSourceMetagenerationNotMatch = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
            };
            // Make the request
            gcsv::Object response = await storageClient.MoveObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MoveObject</summary>
        public void MoveObject()
        {
            // Snippet: MoveObject(string, string, string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            string sourceObject = "";
            string destinationObject = "";
            // Make the request
            gcsv::Object response = storageClient.MoveObject(bucket, sourceObject, destinationObject);
            // End snippet
        }

        /// <summary>Snippet for MoveObjectAsync</summary>
        public async Task MoveObjectAsync()
        {
            // Snippet: MoveObjectAsync(string, string, string, CallSettings)
            // Additional: MoveObjectAsync(string, string, string, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            string sourceObject = "";
            string destinationObject = "";
            // Make the request
            gcsv::Object response = await storageClient.MoveObjectAsync(bucket, sourceObject, destinationObject);
            // End snippet
        }

        /// <summary>Snippet for MoveObject</summary>
        public void MoveObjectResourceNames()
        {
            // Snippet: MoveObject(BucketName, string, string, CallSettings)
            // Create client
            gcsv::StorageClient storageClient = gcsv::StorageClient.Create();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            string sourceObject = "";
            string destinationObject = "";
            // Make the request
            gcsv::Object response = storageClient.MoveObject(bucket, sourceObject, destinationObject);
            // End snippet
        }

        /// <summary>Snippet for MoveObjectAsync</summary>
        public async Task MoveObjectResourceNamesAsync()
        {
            // Snippet: MoveObjectAsync(BucketName, string, string, CallSettings)
            // Additional: MoveObjectAsync(BucketName, string, string, CancellationToken)
            // Create client
            gcsv::StorageClient storageClient = await gcsv::StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::BucketName bucket = gcsv::BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            string sourceObject = "";
            string destinationObject = "";
            // Make the request
            gcsv::Object response = await storageClient.MoveObjectAsync(bucket, sourceObject, destinationObject);
            // End snippet
        }
    }
}
