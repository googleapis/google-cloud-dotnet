// Copyright 2020 Google LLC
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

namespace Google.Cloud.DevTools.ContainerAnalysis.V1.Snippets
{
    using Grafeas.V1;
    using Google.Api.Gax;
    using Google.Cloud.Iam.V1;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedContainerAnalysisClientSnippets
    {
        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = containerAnalysisClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await containerAnalysisClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = containerAnalysisClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await containerAnalysisClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_ResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnknownResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = containerAnalysisClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_ResourceNames()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnknownResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await containerAnalysisClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = containerAnalysisClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await containerAnalysisClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = containerAnalysisClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await containerAnalysisClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_ResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnknownResourceName("a/wildcard/resource");
            // Make the request
            Policy response = containerAnalysisClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_ResourceNames()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnknownResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await containerAnalysisClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = containerAnalysisClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await containerAnalysisClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = containerAnalysisClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await containerAnalysisClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_ResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnknownResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = containerAnalysisClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_ResourceNames()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnknownResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await containerAnalysisClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }
    }
}
