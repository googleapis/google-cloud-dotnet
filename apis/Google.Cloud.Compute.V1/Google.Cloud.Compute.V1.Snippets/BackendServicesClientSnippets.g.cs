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
    public sealed class GeneratedBackendServicesClientSnippets
    {
        /// <summary>Snippet for AddSignedUrlKey</summary>
        public void AddSignedUrlKeyRequestObject()
        {
            // Snippet: AddSignedUrlKey(AddSignedUrlKeyBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            AddSignedUrlKeyBackendServiceRequest request = new AddSignedUrlKeyBackendServiceRequest
            {
                RequestId = "",
                BackendService = "",
                SignedUrlKeyResource = new SignedUrlKey(),
                Project = "",
            };
            // Make the request
            Operation response = backendServicesClient.AddSignedUrlKey(request);
            // End snippet
        }

        /// <summary>Snippet for AddSignedUrlKeyAsync</summary>
        public async Task AddSignedUrlKeyRequestObjectAsync()
        {
            // Snippet: AddSignedUrlKeyAsync(AddSignedUrlKeyBackendServiceRequest, CallSettings)
            // Additional: AddSignedUrlKeyAsync(AddSignedUrlKeyBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            AddSignedUrlKeyBackendServiceRequest request = new AddSignedUrlKeyBackendServiceRequest
            {
                RequestId = "",
                BackendService = "",
                SignedUrlKeyResource = new SignedUrlKey(),
                Project = "",
            };
            // Make the request
            Operation response = await backendServicesClient.AddSignedUrlKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddSignedUrlKey</summary>
        public void AddSignedUrlKey()
        {
            // Snippet: AddSignedUrlKey(string, string, SignedUrlKey, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            SignedUrlKey signedUrlKeyResource = new SignedUrlKey();
            // Make the request
            Operation response = backendServicesClient.AddSignedUrlKey(project, backendService, signedUrlKeyResource);
            // End snippet
        }

        /// <summary>Snippet for AddSignedUrlKeyAsync</summary>
        public async Task AddSignedUrlKeyAsync()
        {
            // Snippet: AddSignedUrlKeyAsync(string, string, SignedUrlKey, CallSettings)
            // Additional: AddSignedUrlKeyAsync(string, string, SignedUrlKey, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            SignedUrlKey signedUrlKeyResource = new SignedUrlKey();
            // Make the request
            Operation response = await backendServicesClient.AddSignedUrlKeyAsync(project, backendService, signedUrlKeyResource);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListBackendServicesRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            AggregatedListBackendServicesRequest request = new AggregatedListBackendServicesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                IncludeAllScopes = false,
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            BackendServiceAggregatedList response = backendServicesClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListBackendServicesRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListBackendServicesRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListBackendServicesRequest request = new AggregatedListBackendServicesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                IncludeAllScopes = false,
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            BackendServiceAggregatedList response = await backendServicesClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            BackendServiceAggregatedList response = backendServicesClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            BackendServiceAggregatedList response = await backendServicesClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            DeleteBackendServiceRequest request = new DeleteBackendServiceRequest
            {
                RequestId = "",
                BackendService = "",
                Project = "",
            };
            // Make the request
            Operation response = backendServicesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteBackendServiceRequest, CallSettings)
            // Additional: DeleteAsync(DeleteBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackendServiceRequest request = new DeleteBackendServiceRequest
            {
                RequestId = "",
                BackendService = "",
                Project = "",
            };
            // Make the request
            Operation response = await backendServicesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            // Make the request
            Operation response = backendServicesClient.Delete(project, backendService);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            // Make the request
            Operation response = await backendServicesClient.DeleteAsync(project, backendService);
            // End snippet
        }

        /// <summary>Snippet for DeleteSignedUrlKey</summary>
        public void DeleteSignedUrlKeyRequestObject()
        {
            // Snippet: DeleteSignedUrlKey(DeleteSignedUrlKeyBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            DeleteSignedUrlKeyBackendServiceRequest request = new DeleteSignedUrlKeyBackendServiceRequest
            {
                RequestId = "",
                BackendService = "",
                Project = "",
                KeyName = "",
            };
            // Make the request
            Operation response = backendServicesClient.DeleteSignedUrlKey(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSignedUrlKeyAsync</summary>
        public async Task DeleteSignedUrlKeyRequestObjectAsync()
        {
            // Snippet: DeleteSignedUrlKeyAsync(DeleteSignedUrlKeyBackendServiceRequest, CallSettings)
            // Additional: DeleteSignedUrlKeyAsync(DeleteSignedUrlKeyBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSignedUrlKeyBackendServiceRequest request = new DeleteSignedUrlKeyBackendServiceRequest
            {
                RequestId = "",
                BackendService = "",
                Project = "",
                KeyName = "",
            };
            // Make the request
            Operation response = await backendServicesClient.DeleteSignedUrlKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSignedUrlKey</summary>
        public void DeleteSignedUrlKey()
        {
            // Snippet: DeleteSignedUrlKey(string, string, string, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            string keyName = "";
            // Make the request
            Operation response = backendServicesClient.DeleteSignedUrlKey(project, backendService, keyName);
            // End snippet
        }

        /// <summary>Snippet for DeleteSignedUrlKeyAsync</summary>
        public async Task DeleteSignedUrlKeyAsync()
        {
            // Snippet: DeleteSignedUrlKeyAsync(string, string, string, CallSettings)
            // Additional: DeleteSignedUrlKeyAsync(string, string, string, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            string keyName = "";
            // Make the request
            Operation response = await backendServicesClient.DeleteSignedUrlKeyAsync(project, backendService, keyName);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            GetBackendServiceRequest request = new GetBackendServiceRequest
            {
                BackendService = "",
                Project = "",
            };
            // Make the request
            BackendService response = backendServicesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetBackendServiceRequest, CallSettings)
            // Additional: GetAsync(GetBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetBackendServiceRequest request = new GetBackendServiceRequest
            {
                BackendService = "",
                Project = "",
            };
            // Make the request
            BackendService response = await backendServicesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            // Make the request
            BackendService response = backendServicesClient.Get(project, backendService);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            // Make the request
            BackendService response = await backendServicesClient.GetAsync(project, backendService);
            // End snippet
        }

        /// <summary>Snippet for GetHealth</summary>
        public void GetHealthRequestObject()
        {
            // Snippet: GetHealth(GetHealthBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            GetHealthBackendServiceRequest request = new GetHealthBackendServiceRequest
            {
                BackendService = "",
                ResourceGroupReferenceResource = new ResourceGroupReference(),
                Project = "",
            };
            // Make the request
            BackendServiceGroupHealth response = backendServicesClient.GetHealth(request);
            // End snippet
        }

        /// <summary>Snippet for GetHealthAsync</summary>
        public async Task GetHealthRequestObjectAsync()
        {
            // Snippet: GetHealthAsync(GetHealthBackendServiceRequest, CallSettings)
            // Additional: GetHealthAsync(GetHealthBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetHealthBackendServiceRequest request = new GetHealthBackendServiceRequest
            {
                BackendService = "",
                ResourceGroupReferenceResource = new ResourceGroupReference(),
                Project = "",
            };
            // Make the request
            BackendServiceGroupHealth response = await backendServicesClient.GetHealthAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHealth</summary>
        public void GetHealth()
        {
            // Snippet: GetHealth(string, string, ResourceGroupReference, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            ResourceGroupReference resourceGroupReferenceResource = new ResourceGroupReference();
            // Make the request
            BackendServiceGroupHealth response = backendServicesClient.GetHealth(project, backendService, resourceGroupReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for GetHealthAsync</summary>
        public async Task GetHealthAsync()
        {
            // Snippet: GetHealthAsync(string, string, ResourceGroupReference, CallSettings)
            // Additional: GetHealthAsync(string, string, ResourceGroupReference, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            ResourceGroupReference resourceGroupReferenceResource = new ResourceGroupReference();
            // Make the request
            BackendServiceGroupHealth response = await backendServicesClient.GetHealthAsync(project, backendService, resourceGroupReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            InsertBackendServiceRequest request = new InsertBackendServiceRequest
            {
                RequestId = "",
                BackendServiceResource = new BackendService(),
                Project = "",
            };
            // Make the request
            Operation response = backendServicesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertBackendServiceRequest, CallSettings)
            // Additional: InsertAsync(InsertBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            InsertBackendServiceRequest request = new InsertBackendServiceRequest
            {
                RequestId = "",
                BackendServiceResource = new BackendService(),
                Project = "",
            };
            // Make the request
            Operation response = await backendServicesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, BackendService, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            Operation response = backendServicesClient.Insert(project, backendServiceResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, BackendService, CallSettings)
            // Additional: InsertAsync(string, BackendService, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            Operation response = await backendServicesClient.InsertAsync(project, backendServiceResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListBackendServicesRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            ListBackendServicesRequest request = new ListBackendServicesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            BackendServiceList response = backendServicesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListBackendServicesRequest, CallSettings)
            // Additional: ListAsync(ListBackendServicesRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListBackendServicesRequest request = new ListBackendServicesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            BackendServiceList response = await backendServicesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            BackendServiceList response = backendServicesClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            BackendServiceList response = await backendServicesClient.ListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            PatchBackendServiceRequest request = new PatchBackendServiceRequest
            {
                RequestId = "",
                BackendService = "",
                BackendServiceResource = new BackendService(),
                Project = "",
            };
            // Make the request
            Operation response = backendServicesClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchBackendServiceRequest, CallSettings)
            // Additional: PatchAsync(PatchBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            PatchBackendServiceRequest request = new PatchBackendServiceRequest
            {
                RequestId = "",
                BackendService = "",
                BackendServiceResource = new BackendService(),
                Project = "",
            };
            // Make the request
            Operation response = await backendServicesClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, BackendService, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            Operation response = backendServicesClient.Patch(project, backendService, backendServiceResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, BackendService, CallSettings)
            // Additional: PatchAsync(string, string, BackendService, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            Operation response = await backendServicesClient.PatchAsync(project, backendService, backendServiceResource);
            // End snippet
        }

        /// <summary>Snippet for SetSecurityPolicy</summary>
        public void SetSecurityPolicyRequestObject()
        {
            // Snippet: SetSecurityPolicy(SetSecurityPolicyBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            SetSecurityPolicyBackendServiceRequest request = new SetSecurityPolicyBackendServiceRequest
            {
                RequestId = "",
                BackendService = "",
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "",
            };
            // Make the request
            Operation response = backendServicesClient.SetSecurityPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetSecurityPolicyAsync</summary>
        public async Task SetSecurityPolicyRequestObjectAsync()
        {
            // Snippet: SetSecurityPolicyAsync(SetSecurityPolicyBackendServiceRequest, CallSettings)
            // Additional: SetSecurityPolicyAsync(SetSecurityPolicyBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            SetSecurityPolicyBackendServiceRequest request = new SetSecurityPolicyBackendServiceRequest
            {
                RequestId = "",
                BackendService = "",
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "",
            };
            // Make the request
            Operation response = await backendServicesClient.SetSecurityPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetSecurityPolicy</summary>
        public void SetSecurityPolicy()
        {
            // Snippet: SetSecurityPolicy(string, string, SecurityPolicyReference, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            SecurityPolicyReference securityPolicyReferenceResource = new SecurityPolicyReference();
            // Make the request
            Operation response = backendServicesClient.SetSecurityPolicy(project, backendService, securityPolicyReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for SetSecurityPolicyAsync</summary>
        public async Task SetSecurityPolicyAsync()
        {
            // Snippet: SetSecurityPolicyAsync(string, string, SecurityPolicyReference, CallSettings)
            // Additional: SetSecurityPolicyAsync(string, string, SecurityPolicyReference, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            SecurityPolicyReference securityPolicyReferenceResource = new SecurityPolicyReference();
            // Make the request
            Operation response = await backendServicesClient.SetSecurityPolicyAsync(project, backendService, securityPolicyReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            UpdateBackendServiceRequest request = new UpdateBackendServiceRequest
            {
                RequestId = "",
                BackendService = "",
                BackendServiceResource = new BackendService(),
                Project = "",
            };
            // Make the request
            Operation response = backendServicesClient.Update(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(UpdateBackendServiceRequest, CallSettings)
            // Additional: UpdateAsync(UpdateBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackendServiceRequest request = new UpdateBackendServiceRequest
            {
                RequestId = "",
                BackendService = "",
                BackendServiceResource = new BackendService(),
                Project = "",
            };
            // Make the request
            Operation response = await backendServicesClient.UpdateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void Update()
        {
            // Snippet: Update(string, string, BackendService, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            Operation response = backendServicesClient.Update(project, backendService, backendServiceResource);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateAsync()
        {
            // Snippet: UpdateAsync(string, string, BackendService, CallSettings)
            // Additional: UpdateAsync(string, string, BackendService, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            Operation response = await backendServicesClient.UpdateAsync(project, backendService, backendServiceResource);
            // End snippet
        }
    }
}
