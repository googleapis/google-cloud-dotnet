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
                ExternalVpnGatewayResource = new ExternalVpnGateway(),
                Project = "",
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
                ExternalVpnGatewayResource = new ExternalVpnGateway(),
                Project = "",
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
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ExternalVpnGatewayList response = externalVpnGatewaysClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListExternalVpnGatewaysRequest, CallSettings)
            // Additional: ListAsync(ListExternalVpnGatewaysRequest, CancellationToken)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = await ExternalVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            ListExternalVpnGatewaysRequest request = new ListExternalVpnGatewaysRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ExternalVpnGatewayList response = await externalVpnGatewaysClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = ExternalVpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            ExternalVpnGatewayList response = externalVpnGatewaysClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            ExternalVpnGatewaysClient externalVpnGatewaysClient = await ExternalVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            ExternalVpnGatewayList response = await externalVpnGatewaysClient.ListAsync(project);
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
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
                Resource = "",
                Project = "",
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
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
                Resource = "",
                Project = "",
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
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
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
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
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
