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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedBackendBucketsClientSnippets
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
                SignedUrlKeyResource = new SignedUrlKey(),
                Project = "",
            };
            // Make the request
            Operation response = backendBucketsClient.AddSignedUrlKey(request);
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
                SignedUrlKeyResource = new SignedUrlKey(),
                Project = "",
            };
            // Make the request
            Operation response = await backendBucketsClient.AddSignedUrlKeyAsync(request);
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
            Operation response = backendBucketsClient.AddSignedUrlKey(project, backendBucket, signedUrlKeyResource);
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
            Operation response = await backendBucketsClient.AddSignedUrlKeyAsync(project, backendBucket, signedUrlKeyResource);
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
            Operation response = backendBucketsClient.Delete(request);
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
            Operation response = await backendBucketsClient.DeleteAsync(request);
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
            Operation response = backendBucketsClient.Delete(project, backendBucket);
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
            Operation response = await backendBucketsClient.DeleteAsync(project, backendBucket);
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
            Operation response = backendBucketsClient.DeleteSignedUrlKey(request);
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
            Operation response = await backendBucketsClient.DeleteSignedUrlKeyAsync(request);
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
            Operation response = backendBucketsClient.DeleteSignedUrlKey(project, backendBucket, keyName);
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
            Operation response = await backendBucketsClient.DeleteSignedUrlKeyAsync(project, backendBucket, keyName);
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
                BackendBucketResource = new BackendBucket(),
                Project = "",
            };
            // Make the request
            Operation response = backendBucketsClient.Insert(request);
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
                BackendBucketResource = new BackendBucket(),
                Project = "",
            };
            // Make the request
            Operation response = await backendBucketsClient.InsertAsync(request);
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
            Operation response = backendBucketsClient.Insert(project, backendBucketResource);
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
            Operation response = await backendBucketsClient.InsertAsync(project, backendBucketResource);
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
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            BackendBucketList response = backendBucketsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListBackendBucketsRequest, CallSettings)
            // Additional: ListAsync(ListBackendBucketsRequest, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            ListBackendBucketsRequest request = new ListBackendBucketsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            BackendBucketList response = await backendBucketsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            BackendBucketsClient backendBucketsClient = BackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            BackendBucketList response = backendBucketsClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            BackendBucketsClient backendBucketsClient = await BackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            BackendBucketList response = await backendBucketsClient.ListAsync(project);
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
                BackendBucketResource = new BackendBucket(),
                Project = "",
            };
            // Make the request
            Operation response = backendBucketsClient.Patch(request);
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
                BackendBucketResource = new BackendBucket(),
                Project = "",
            };
            // Make the request
            Operation response = await backendBucketsClient.PatchAsync(request);
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
            Operation response = backendBucketsClient.Patch(project, backendBucket, backendBucketResource);
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
            Operation response = await backendBucketsClient.PatchAsync(project, backendBucket, backendBucketResource);
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
                BackendBucketResource = new BackendBucket(),
                Project = "",
            };
            // Make the request
            Operation response = backendBucketsClient.Update(request);
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
                BackendBucketResource = new BackendBucket(),
                Project = "",
            };
            // Make the request
            Operation response = await backendBucketsClient.UpdateAsync(request);
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
            Operation response = backendBucketsClient.Update(project, backendBucket, backendBucketResource);
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
            Operation response = await backendBucketsClient.UpdateAsync(project, backendBucket, backendBucketResource);
            // End snippet
        }
    }
}
