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
    public sealed class GeneratedSnapshotsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteSnapshotRequest, CallSettings)
            // Create client
            SnapshotsClient snapshotsClient = SnapshotsClient.Create();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                Snapshot = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = snapshotsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteSnapshotRequest, CallSettings)
            // Additional: DeleteAsync(DeleteSnapshotRequest, CancellationToken)
            // Create client
            SnapshotsClient snapshotsClient = await SnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                Snapshot = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = await snapshotsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            SnapshotsClient snapshotsClient = SnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string snapshot = "";
            // Make the request
            Operation response = snapshotsClient.Delete(project, snapshot);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            SnapshotsClient snapshotsClient = await SnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string snapshot = "";
            // Make the request
            Operation response = await snapshotsClient.DeleteAsync(project, snapshot);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetSnapshotRequest, CallSettings)
            // Create client
            SnapshotsClient snapshotsClient = SnapshotsClient.Create();
            // Initialize request argument(s)
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                Snapshot = "",
                Project = "",
            };
            // Make the request
            Snapshot response = snapshotsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetSnapshotRequest, CallSettings)
            // Additional: GetAsync(GetSnapshotRequest, CancellationToken)
            // Create client
            SnapshotsClient snapshotsClient = await SnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                Snapshot = "",
                Project = "",
            };
            // Make the request
            Snapshot response = await snapshotsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            SnapshotsClient snapshotsClient = SnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string snapshot = "";
            // Make the request
            Snapshot response = snapshotsClient.Get(project, snapshot);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            SnapshotsClient snapshotsClient = await SnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string snapshot = "";
            // Make the request
            Snapshot response = await snapshotsClient.GetAsync(project, snapshot);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicySnapshotRequest, CallSettings)
            // Create client
            SnapshotsClient snapshotsClient = SnapshotsClient.Create();
            // Initialize request argument(s)
            GetIamPolicySnapshotRequest request = new GetIamPolicySnapshotRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = snapshotsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicySnapshotRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicySnapshotRequest, CancellationToken)
            // Create client
            SnapshotsClient snapshotsClient = await SnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicySnapshotRequest request = new GetIamPolicySnapshotRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await snapshotsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, CallSettings)
            // Create client
            SnapshotsClient snapshotsClient = SnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = snapshotsClient.GetIamPolicy(project, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, CancellationToken)
            // Create client
            SnapshotsClient snapshotsClient = await SnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = await snapshotsClient.GetIamPolicyAsync(project, resource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListSnapshotsRequest, CallSettings)
            // Create client
            SnapshotsClient snapshotsClient = SnapshotsClient.Create();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SnapshotList response = snapshotsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListSnapshotsRequest, CallSettings)
            // Additional: ListAsync(ListSnapshotsRequest, CancellationToken)
            // Create client
            SnapshotsClient snapshotsClient = await SnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SnapshotList response = await snapshotsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            SnapshotsClient snapshotsClient = SnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SnapshotList response = snapshotsClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            SnapshotsClient snapshotsClient = await SnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SnapshotList response = await snapshotsClient.ListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicySnapshotRequest, CallSettings)
            // Create client
            SnapshotsClient snapshotsClient = SnapshotsClient.Create();
            // Initialize request argument(s)
            SetIamPolicySnapshotRequest request = new SetIamPolicySnapshotRequest
            {
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = snapshotsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicySnapshotRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicySnapshotRequest, CancellationToken)
            // Create client
            SnapshotsClient snapshotsClient = await SnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicySnapshotRequest request = new SetIamPolicySnapshotRequest
            {
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = await snapshotsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, GlobalSetPolicyRequest, CallSettings)
            // Create client
            SnapshotsClient snapshotsClient = SnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = snapshotsClient.SetIamPolicy(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CancellationToken)
            // Create client
            SnapshotsClient snapshotsClient = await SnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = await snapshotsClient.SetIamPolicyAsync(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsSnapshotRequest, CallSettings)
            // Create client
            SnapshotsClient snapshotsClient = SnapshotsClient.Create();
            // Initialize request argument(s)
            SetLabelsSnapshotRequest request = new SetLabelsSnapshotRequest
            {
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Operation response = snapshotsClient.SetLabels(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsSnapshotRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsSnapshotRequest, CancellationToken)
            // Create client
            SnapshotsClient snapshotsClient = await SnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsSnapshotRequest request = new SetLabelsSnapshotRequest
            {
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Operation response = await snapshotsClient.SetLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, GlobalSetLabelsRequest, CallSettings)
            // Create client
            SnapshotsClient snapshotsClient = SnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            Operation response = snapshotsClient.SetLabels(project, resource, globalSetLabelsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CancellationToken)
            // Create client
            SnapshotsClient snapshotsClient = await SnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            Operation response = await snapshotsClient.SetLabelsAsync(project, resource, globalSetLabelsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsSnapshotRequest, CallSettings)
            // Create client
            SnapshotsClient snapshotsClient = SnapshotsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsSnapshotRequest request = new TestIamPermissionsSnapshotRequest
            {
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = snapshotsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsSnapshotRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsSnapshotRequest, CancellationToken)
            // Create client
            SnapshotsClient snapshotsClient = await SnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsSnapshotRequest request = new TestIamPermissionsSnapshotRequest
            {
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = await snapshotsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, TestPermissionsRequest, CallSettings)
            // Create client
            SnapshotsClient snapshotsClient = SnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = snapshotsClient.TestIamPermissions(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            SnapshotsClient snapshotsClient = await SnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await snapshotsClient.TestIamPermissionsAsync(project, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
