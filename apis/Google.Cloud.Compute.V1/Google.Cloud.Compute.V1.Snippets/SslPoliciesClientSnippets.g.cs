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
    public sealed class GeneratedSslPoliciesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteSslPolicyRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            DeleteSslPolicyRequest request = new DeleteSslPolicyRequest
            {
                SslPolicy = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = sslPoliciesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteSslPolicyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteSslPolicyRequest, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSslPolicyRequest request = new DeleteSslPolicyRequest
            {
                SslPolicy = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = await sslPoliciesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string sslPolicy = "";
            // Make the request
            Operation response = sslPoliciesClient.Delete(project, sslPolicy);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string sslPolicy = "";
            // Make the request
            Operation response = await sslPoliciesClient.DeleteAsync(project, sslPolicy);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetSslPolicyRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            GetSslPolicyRequest request = new GetSslPolicyRequest
            {
                SslPolicy = "",
                Project = "",
            };
            // Make the request
            SslPolicy response = sslPoliciesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetSslPolicyRequest, CallSettings)
            // Additional: GetAsync(GetSslPolicyRequest, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetSslPolicyRequest request = new GetSslPolicyRequest
            {
                SslPolicy = "",
                Project = "",
            };
            // Make the request
            SslPolicy response = await sslPoliciesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string sslPolicy = "";
            // Make the request
            SslPolicy response = sslPoliciesClient.Get(project, sslPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string sslPolicy = "";
            // Make the request
            SslPolicy response = await sslPoliciesClient.GetAsync(project, sslPolicy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertSslPolicyRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            InsertSslPolicyRequest request = new InsertSslPolicyRequest
            {
                SslPolicyResource = new SslPolicy(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = sslPoliciesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertSslPolicyRequest, CallSettings)
            // Additional: InsertAsync(InsertSslPolicyRequest, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            InsertSslPolicyRequest request = new InsertSslPolicyRequest
            {
                SslPolicyResource = new SslPolicy(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = await sslPoliciesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, SslPolicy, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            SslPolicy sslPolicyResource = new SslPolicy();
            // Make the request
            Operation response = sslPoliciesClient.Insert(project, sslPolicyResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, SslPolicy, CallSettings)
            // Additional: InsertAsync(string, SslPolicy, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            SslPolicy sslPolicyResource = new SslPolicy();
            // Make the request
            Operation response = await sslPoliciesClient.InsertAsync(project, sslPolicyResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListSslPoliciesRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            ListSslPoliciesRequest request = new ListSslPoliciesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SslPoliciesList response = sslPoliciesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListSslPoliciesRequest, CallSettings)
            // Additional: ListAsync(ListSslPoliciesRequest, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListSslPoliciesRequest request = new ListSslPoliciesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SslPoliciesList response = await sslPoliciesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SslPoliciesList response = sslPoliciesClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SslPoliciesList response = await sslPoliciesClient.ListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for ListAvailableFeatures</summary>
        public void ListAvailableFeaturesRequestObject()
        {
            // Snippet: ListAvailableFeatures(ListAvailableFeaturesSslPoliciesRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            ListAvailableFeaturesSslPoliciesRequest request = new ListAvailableFeaturesSslPoliciesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SslPoliciesListAvailableFeaturesResponse response = sslPoliciesClient.ListAvailableFeatures(request);
            // End snippet
        }

        /// <summary>Snippet for ListAvailableFeaturesAsync</summary>
        public async Task ListAvailableFeaturesRequestObjectAsync()
        {
            // Snippet: ListAvailableFeaturesAsync(ListAvailableFeaturesSslPoliciesRequest, CallSettings)
            // Additional: ListAvailableFeaturesAsync(ListAvailableFeaturesSslPoliciesRequest, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListAvailableFeaturesSslPoliciesRequest request = new ListAvailableFeaturesSslPoliciesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SslPoliciesListAvailableFeaturesResponse response = await sslPoliciesClient.ListAvailableFeaturesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListAvailableFeatures</summary>
        public void ListAvailableFeatures()
        {
            // Snippet: ListAvailableFeatures(string, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SslPoliciesListAvailableFeaturesResponse response = sslPoliciesClient.ListAvailableFeatures(project);
            // End snippet
        }

        /// <summary>Snippet for ListAvailableFeaturesAsync</summary>
        public async Task ListAvailableFeaturesAsync()
        {
            // Snippet: ListAvailableFeaturesAsync(string, CallSettings)
            // Additional: ListAvailableFeaturesAsync(string, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SslPoliciesListAvailableFeaturesResponse response = await sslPoliciesClient.ListAvailableFeaturesAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchSslPolicyRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            PatchSslPolicyRequest request = new PatchSslPolicyRequest
            {
                SslPolicyResource = new SslPolicy(),
                SslPolicy = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = sslPoliciesClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchSslPolicyRequest, CallSettings)
            // Additional: PatchAsync(PatchSslPolicyRequest, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchSslPolicyRequest request = new PatchSslPolicyRequest
            {
                SslPolicyResource = new SslPolicy(),
                SslPolicy = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = await sslPoliciesClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, SslPolicy, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string sslPolicy = "";
            SslPolicy sslPolicyResource = new SslPolicy();
            // Make the request
            Operation response = sslPoliciesClient.Patch(project, sslPolicy, sslPolicyResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, SslPolicy, CallSettings)
            // Additional: PatchAsync(string, string, SslPolicy, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string sslPolicy = "";
            SslPolicy sslPolicyResource = new SslPolicy();
            // Make the request
            Operation response = await sslPoliciesClient.PatchAsync(project, sslPolicy, sslPolicyResource);
            // End snippet
        }
    }
}
