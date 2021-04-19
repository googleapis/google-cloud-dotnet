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
    public sealed class GeneratedInstanceTemplatesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteInstanceTemplateRequest, CallSettings)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            // Initialize request argument(s)
            DeleteInstanceTemplateRequest request = new DeleteInstanceTemplateRequest
            {
                RequestId = "",
                InstanceTemplate = "",
                Project = "",
            };
            // Make the request
            Operation response = instanceTemplatesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteInstanceTemplateRequest, CallSettings)
            // Additional: DeleteAsync(DeleteInstanceTemplateRequest, CancellationToken)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = await InstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceTemplateRequest request = new DeleteInstanceTemplateRequest
            {
                RequestId = "",
                InstanceTemplate = "",
                Project = "",
            };
            // Make the request
            Operation response = await instanceTemplatesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string instanceTemplate = "";
            // Make the request
            Operation response = instanceTemplatesClient.Delete(project, instanceTemplate);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = await InstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string instanceTemplate = "";
            // Make the request
            Operation response = await instanceTemplatesClient.DeleteAsync(project, instanceTemplate);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetInstanceTemplateRequest, CallSettings)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            // Initialize request argument(s)
            GetInstanceTemplateRequest request = new GetInstanceTemplateRequest
            {
                InstanceTemplate = "",
                Project = "",
            };
            // Make the request
            InstanceTemplate response = instanceTemplatesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInstanceTemplateRequest, CallSettings)
            // Additional: GetAsync(GetInstanceTemplateRequest, CancellationToken)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = await InstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceTemplateRequest request = new GetInstanceTemplateRequest
            {
                InstanceTemplate = "",
                Project = "",
            };
            // Make the request
            InstanceTemplate response = await instanceTemplatesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string instanceTemplate = "";
            // Make the request
            InstanceTemplate response = instanceTemplatesClient.Get(project, instanceTemplate);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = await InstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string instanceTemplate = "";
            // Make the request
            InstanceTemplate response = await instanceTemplatesClient.GetAsync(project, instanceTemplate);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyInstanceTemplateRequest, CallSettings)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            // Initialize request argument(s)
            GetIamPolicyInstanceTemplateRequest request = new GetIamPolicyInstanceTemplateRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = instanceTemplatesClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyInstanceTemplateRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyInstanceTemplateRequest, CancellationToken)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = await InstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyInstanceTemplateRequest request = new GetIamPolicyInstanceTemplateRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await instanceTemplatesClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, CallSettings)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = instanceTemplatesClient.GetIamPolicy(project, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, CancellationToken)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = await InstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = await instanceTemplatesClient.GetIamPolicyAsync(project, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertInstanceTemplateRequest, CallSettings)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            // Initialize request argument(s)
            InsertInstanceTemplateRequest request = new InsertInstanceTemplateRequest
            {
                InstanceTemplateResource = new InstanceTemplate(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = instanceTemplatesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertInstanceTemplateRequest, CallSettings)
            // Additional: InsertAsync(InsertInstanceTemplateRequest, CancellationToken)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = await InstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            InsertInstanceTemplateRequest request = new InsertInstanceTemplateRequest
            {
                InstanceTemplateResource = new InstanceTemplate(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = await instanceTemplatesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, InstanceTemplate, CallSettings)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            InstanceTemplate instanceTemplateResource = new InstanceTemplate();
            // Make the request
            Operation response = instanceTemplatesClient.Insert(project, instanceTemplateResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, InstanceTemplate, CallSettings)
            // Additional: InsertAsync(string, InstanceTemplate, CancellationToken)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = await InstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            InstanceTemplate instanceTemplateResource = new InstanceTemplate();
            // Make the request
            Operation response = await instanceTemplatesClient.InsertAsync(project, instanceTemplateResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListInstanceTemplatesRequest, CallSettings)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            // Initialize request argument(s)
            ListInstanceTemplatesRequest request = new ListInstanceTemplatesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            InstanceTemplateList response = instanceTemplatesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListInstanceTemplatesRequest, CallSettings)
            // Additional: ListAsync(ListInstanceTemplatesRequest, CancellationToken)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = await InstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            ListInstanceTemplatesRequest request = new ListInstanceTemplatesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            InstanceTemplateList response = await instanceTemplatesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            InstanceTemplateList response = instanceTemplatesClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = await InstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            InstanceTemplateList response = await instanceTemplatesClient.ListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyInstanceTemplateRequest, CallSettings)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            // Initialize request argument(s)
            SetIamPolicyInstanceTemplateRequest request = new SetIamPolicyInstanceTemplateRequest
            {
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = instanceTemplatesClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyInstanceTemplateRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyInstanceTemplateRequest, CancellationToken)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = await InstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyInstanceTemplateRequest request = new SetIamPolicyInstanceTemplateRequest
            {
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = await instanceTemplatesClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, GlobalSetPolicyRequest, CallSettings)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = instanceTemplatesClient.SetIamPolicy(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CancellationToken)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = await InstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = await instanceTemplatesClient.SetIamPolicyAsync(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsInstanceTemplateRequest, CallSettings)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsInstanceTemplateRequest request = new TestIamPermissionsInstanceTemplateRequest
            {
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = instanceTemplatesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsInstanceTemplateRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsInstanceTemplateRequest, CancellationToken)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = await InstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsInstanceTemplateRequest request = new TestIamPermissionsInstanceTemplateRequest
            {
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = await instanceTemplatesClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, TestPermissionsRequest, CallSettings)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = instanceTemplatesClient.TestIamPermissions(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            InstanceTemplatesClient instanceTemplatesClient = await InstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await instanceTemplatesClient.TestIamPermissionsAsync(project, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
