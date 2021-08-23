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

namespace Google.Cloud.Iap.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedIdentityAwareProxyAdminServiceClientSnippets
    {
        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = identityAwareProxyAdminServiceClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await identityAwareProxyAdminServiceClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = identityAwareProxyAdminServiceClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await identityAwareProxyAdminServiceClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = identityAwareProxyAdminServiceClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await identityAwareProxyAdminServiceClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIapSettings</summary>
        public void GetIapSettingsRequestObject()
        {
            // Snippet: GetIapSettings(GetIapSettingsRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            GetIapSettingsRequest request = new GetIapSettingsRequest { Name = "", };
            // Make the request
            IapSettings response = identityAwareProxyAdminServiceClient.GetIapSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetIapSettingsAsync</summary>
        public async Task GetIapSettingsRequestObjectAsync()
        {
            // Snippet: GetIapSettingsAsync(GetIapSettingsRequest, CallSettings)
            // Additional: GetIapSettingsAsync(GetIapSettingsRequest, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIapSettingsRequest request = new GetIapSettingsRequest { Name = "", };
            // Make the request
            IapSettings response = await identityAwareProxyAdminServiceClient.GetIapSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIapSettings</summary>
        public void UpdateIapSettingsRequestObject()
        {
            // Snippet: UpdateIapSettings(UpdateIapSettingsRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateIapSettingsRequest request = new UpdateIapSettingsRequest
            {
                IapSettings = new IapSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            IapSettings response = identityAwareProxyAdminServiceClient.UpdateIapSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIapSettingsAsync</summary>
        public async Task UpdateIapSettingsRequestObjectAsync()
        {
            // Snippet: UpdateIapSettingsAsync(UpdateIapSettingsRequest, CallSettings)
            // Additional: UpdateIapSettingsAsync(UpdateIapSettingsRequest, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateIapSettingsRequest request = new UpdateIapSettingsRequest
            {
                IapSettings = new IapSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            IapSettings response = await identityAwareProxyAdminServiceClient.UpdateIapSettingsAsync(request);
            // End snippet
        }
    }
}
