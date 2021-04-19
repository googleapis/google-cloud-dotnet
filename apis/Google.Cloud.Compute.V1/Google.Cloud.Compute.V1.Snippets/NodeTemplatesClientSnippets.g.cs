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
    public sealed class GeneratedNodeTemplatesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListNodeTemplatesRequest, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            AggregatedListNodeTemplatesRequest request = new AggregatedListNodeTemplatesRequest
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
            NodeTemplateAggregatedList response = nodeTemplatesClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListNodeTemplatesRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListNodeTemplatesRequest, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListNodeTemplatesRequest request = new AggregatedListNodeTemplatesRequest
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
            NodeTemplateAggregatedList response = await nodeTemplatesClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            NodeTemplateAggregatedList response = nodeTemplatesClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            NodeTemplateAggregatedList response = await nodeTemplatesClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteNodeTemplateRequest, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            DeleteNodeTemplateRequest request = new DeleteNodeTemplateRequest
            {
                RequestId = "",
                NodeTemplate = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = nodeTemplatesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteNodeTemplateRequest, CallSettings)
            // Additional: DeleteAsync(DeleteNodeTemplateRequest, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNodeTemplateRequest request = new DeleteNodeTemplateRequest
            {
                RequestId = "",
                NodeTemplate = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await nodeTemplatesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string nodeTemplate = "";
            // Make the request
            Operation response = nodeTemplatesClient.Delete(project, region, nodeTemplate);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string nodeTemplate = "";
            // Make the request
            Operation response = await nodeTemplatesClient.DeleteAsync(project, region, nodeTemplate);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetNodeTemplateRequest, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            GetNodeTemplateRequest request = new GetNodeTemplateRequest
            {
                NodeTemplate = "",
                Region = "",
                Project = "",
            };
            // Make the request
            NodeTemplate response = nodeTemplatesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetNodeTemplateRequest, CallSettings)
            // Additional: GetAsync(GetNodeTemplateRequest, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            GetNodeTemplateRequest request = new GetNodeTemplateRequest
            {
                NodeTemplate = "",
                Region = "",
                Project = "",
            };
            // Make the request
            NodeTemplate response = await nodeTemplatesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string nodeTemplate = "";
            // Make the request
            NodeTemplate response = nodeTemplatesClient.Get(project, region, nodeTemplate);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string nodeTemplate = "";
            // Make the request
            NodeTemplate response = await nodeTemplatesClient.GetAsync(project, region, nodeTemplate);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyNodeTemplateRequest, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            GetIamPolicyNodeTemplateRequest request = new GetIamPolicyNodeTemplateRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = nodeTemplatesClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyNodeTemplateRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyNodeTemplateRequest, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyNodeTemplateRequest request = new GetIamPolicyNodeTemplateRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await nodeTemplatesClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = nodeTemplatesClient.GetIamPolicy(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = await nodeTemplatesClient.GetIamPolicyAsync(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertNodeTemplateRequest, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            InsertNodeTemplateRequest request = new InsertNodeTemplateRequest
            {
                RequestId = "",
                NodeTemplateResource = new NodeTemplate(),
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = nodeTemplatesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertNodeTemplateRequest, CallSettings)
            // Additional: InsertAsync(InsertNodeTemplateRequest, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            InsertNodeTemplateRequest request = new InsertNodeTemplateRequest
            {
                RequestId = "",
                NodeTemplateResource = new NodeTemplate(),
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await nodeTemplatesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, NodeTemplate, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            NodeTemplate nodeTemplateResource = new NodeTemplate();
            // Make the request
            Operation response = nodeTemplatesClient.Insert(project, region, nodeTemplateResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, NodeTemplate, CallSettings)
            // Additional: InsertAsync(string, string, NodeTemplate, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            NodeTemplate nodeTemplateResource = new NodeTemplate();
            // Make the request
            Operation response = await nodeTemplatesClient.InsertAsync(project, region, nodeTemplateResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListNodeTemplatesRequest, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            ListNodeTemplatesRequest request = new ListNodeTemplatesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NodeTemplateList response = nodeTemplatesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListNodeTemplatesRequest, CallSettings)
            // Additional: ListAsync(ListNodeTemplatesRequest, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            ListNodeTemplatesRequest request = new ListNodeTemplatesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NodeTemplateList response = await nodeTemplatesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            NodeTemplateList response = nodeTemplatesClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            NodeTemplateList response = await nodeTemplatesClient.ListAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyNodeTemplateRequest, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            SetIamPolicyNodeTemplateRequest request = new SetIamPolicyNodeTemplateRequest
            {
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
                Region = "",
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = nodeTemplatesClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyNodeTemplateRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyNodeTemplateRequest, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyNodeTemplateRequest request = new SetIamPolicyNodeTemplateRequest
            {
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
                Region = "",
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = await nodeTemplatesClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = nodeTemplatesClient.SetIamPolicy(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = await nodeTemplatesClient.SetIamPolicyAsync(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsNodeTemplateRequest, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsNodeTemplateRequest request = new TestIamPermissionsNodeTemplateRequest
            {
                Region = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = nodeTemplatesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsNodeTemplateRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsNodeTemplateRequest, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsNodeTemplateRequest request = new TestIamPermissionsNodeTemplateRequest
            {
                Region = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = await nodeTemplatesClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = NodeTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = nodeTemplatesClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            NodeTemplatesClient nodeTemplatesClient = await NodeTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await nodeTemplatesClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
