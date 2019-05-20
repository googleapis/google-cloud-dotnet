// Copyright 2019 Google LLC
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
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedContainerAnalysisClientSnippets
    {
        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(IamResourceNameOneof,Policy,CallSettings)
            // Additional: SetIamPolicyAsync(IamResourceNameOneof,Policy,CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            Policy policy = new Policy();
            // Make the request
            Policy response = await containerAnalysisClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(IamResourceNameOneof,Policy,CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            Policy policy = new Policy();
            // Make the request
            Policy response = containerAnalysisClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest,CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest,CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await containerAnalysisClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest,CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = containerAnalysisClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(IamResourceNameOneof,CallSettings)
            // Additional: GetIamPolicyAsync(IamResourceNameOneof,CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            // Make the request
            Policy response = await containerAnalysisClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(IamResourceNameOneof,CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            // Make the request
            Policy response = containerAnalysisClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest,CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest,CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
            };
            // Make the request
            Policy response = await containerAnalysisClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest,CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
            };
            // Make the request
            Policy response = containerAnalysisClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(IamResourceNameOneof,IEnumerable<string>,CallSettings)
            // Additional: TestIamPermissionsAsync(IamResourceNameOneof,IEnumerable<string>,CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = await containerAnalysisClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(IamResourceNameOneof,IEnumerable<string>,CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = containerAnalysisClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest,CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest,CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = await containerAnalysisClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest,CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = containerAnalysisClient.TestIamPermissions(request);
            // End snippet
        }

    }
}
