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
    public sealed class GeneratedTargetSslProxiesClientSnippets
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
                TargetSslProxy = "",
                Project = "",
            };
            // Make the request
            Operation response = targetSslProxiesClient.Delete(request);
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
                TargetSslProxy = "",
                Project = "",
            };
            // Make the request
            Operation response = await targetSslProxiesClient.DeleteAsync(request);
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
            Operation response = targetSslProxiesClient.Delete(project, targetSslProxy);
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
            Operation response = await targetSslProxiesClient.DeleteAsync(project, targetSslProxy);
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
                TargetSslProxy = "",
                Project = "",
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
                TargetSslProxy = "",
                Project = "",
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
            Operation response = targetSslProxiesClient.Insert(request);
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
            Operation response = await targetSslProxiesClient.InsertAsync(request);
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
            Operation response = targetSslProxiesClient.Insert(project, targetSslProxyResource);
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
            Operation response = await targetSslProxiesClient.InsertAsync(project, targetSslProxyResource);
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
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            TargetSslProxyList response = targetSslProxiesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListTargetSslProxiesRequest, CallSettings)
            // Additional: ListAsync(ListTargetSslProxiesRequest, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetSslProxiesRequest request = new ListTargetSslProxiesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            TargetSslProxyList response = await targetSslProxiesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = TargetSslProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            TargetSslProxyList response = targetSslProxiesClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            TargetSslProxiesClient targetSslProxiesClient = await TargetSslProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            TargetSslProxyList response = await targetSslProxiesClient.ListAsync(project);
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
                TargetSslProxy = "",
                TargetSslProxiesSetBackendServiceRequestResource = new TargetSslProxiesSetBackendServiceRequest(),
                Project = "",
            };
            // Make the request
            Operation response = targetSslProxiesClient.SetBackendService(request);
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
                TargetSslProxy = "",
                TargetSslProxiesSetBackendServiceRequestResource = new TargetSslProxiesSetBackendServiceRequest(),
                Project = "",
            };
            // Make the request
            Operation response = await targetSslProxiesClient.SetBackendServiceAsync(request);
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
            Operation response = targetSslProxiesClient.SetBackendService(project, targetSslProxy, targetSslProxiesSetBackendServiceRequestResource);
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
            Operation response = await targetSslProxiesClient.SetBackendServiceAsync(project, targetSslProxy, targetSslProxiesSetBackendServiceRequestResource);
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
                TargetSslProxy = "",
                TargetSslProxiesSetProxyHeaderRequestResource = new TargetSslProxiesSetProxyHeaderRequest(),
                Project = "",
            };
            // Make the request
            Operation response = targetSslProxiesClient.SetProxyHeader(request);
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
                TargetSslProxy = "",
                TargetSslProxiesSetProxyHeaderRequestResource = new TargetSslProxiesSetProxyHeaderRequest(),
                Project = "",
            };
            // Make the request
            Operation response = await targetSslProxiesClient.SetProxyHeaderAsync(request);
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
            Operation response = targetSslProxiesClient.SetProxyHeader(project, targetSslProxy, targetSslProxiesSetProxyHeaderRequestResource);
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
            Operation response = await targetSslProxiesClient.SetProxyHeaderAsync(project, targetSslProxy, targetSslProxiesSetProxyHeaderRequestResource);
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
                TargetSslProxy = "",
                TargetSslProxiesSetSslCertificatesRequestResource = new TargetSslProxiesSetSslCertificatesRequest(),
                Project = "",
            };
            // Make the request
            Operation response = targetSslProxiesClient.SetSslCertificates(request);
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
                TargetSslProxy = "",
                TargetSslProxiesSetSslCertificatesRequestResource = new TargetSslProxiesSetSslCertificatesRequest(),
                Project = "",
            };
            // Make the request
            Operation response = await targetSslProxiesClient.SetSslCertificatesAsync(request);
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
            Operation response = targetSslProxiesClient.SetSslCertificates(project, targetSslProxy, targetSslProxiesSetSslCertificatesRequestResource);
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
            Operation response = await targetSslProxiesClient.SetSslCertificatesAsync(project, targetSslProxy, targetSslProxiesSetSslCertificatesRequestResource);
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
                TargetSslProxy = "",
                Project = "",
                SslPolicyReferenceResource = new SslPolicyReference(),
            };
            // Make the request
            Operation response = targetSslProxiesClient.SetSslPolicy(request);
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
                TargetSslProxy = "",
                Project = "",
                SslPolicyReferenceResource = new SslPolicyReference(),
            };
            // Make the request
            Operation response = await targetSslProxiesClient.SetSslPolicyAsync(request);
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
            Operation response = targetSslProxiesClient.SetSslPolicy(project, targetSslProxy, sslPolicyReferenceResource);
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
            Operation response = await targetSslProxiesClient.SetSslPolicyAsync(project, targetSslProxy, sslPolicyReferenceResource);
            // End snippet
        }
    }
}
