// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax.Grpc;
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

namespace Google.Iam.V1.Snippets
{
    public class GeneratedIamPolicyClientSnippets
    {
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string,Policy,CallSettings)
            // Additional: SetIamPolicyAsync(string,Policy,CancellationToken)
            // Create client
            IamPolicyClient iamPolicyClient = IamPolicyClient.Create();
            // Initialize request argument(s)
            string resource = "";
            Policy policy = new Policy();
            // Make the request
            Policy response = await iamPolicyClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string,Policy,CallSettings)
            // Create client
            IamPolicyClient iamPolicyClient = IamPolicyClient.Create();
            // Initialize request argument(s)
            string resource = "";
            Policy policy = new Policy();
            // Make the request
            Policy response = iamPolicyClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string,CallSettings)
            // Additional: GetIamPolicyAsync(string,CancellationToken)
            // Create client
            IamPolicyClient iamPolicyClient = IamPolicyClient.Create();
            // Initialize request argument(s)
            string resource = "";
            // Make the request
            Policy response = await iamPolicyClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string,CallSettings)
            // Create client
            IamPolicyClient iamPolicyClient = IamPolicyClient.Create();
            // Initialize request argument(s)
            string resource = "";
            // Make the request
            Policy response = iamPolicyClient.GetIamPolicy(resource);
            // End snippet
        }

        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string,IEnumerable<string>,CallSettings)
            // Additional: TestIamPermissionsAsync(string,IEnumerable<string>,CancellationToken)
            // Create client
            IamPolicyClient iamPolicyClient = IamPolicyClient.Create();
            // Initialize request argument(s)
            string resource = "";
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = await iamPolicyClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string,IEnumerable<string>,CallSettings)
            // Create client
            IamPolicyClient iamPolicyClient = IamPolicyClient.Create();
            // Initialize request argument(s)
            string resource = "";
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = iamPolicyClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

    }
}
