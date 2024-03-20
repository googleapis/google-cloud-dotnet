// Copyright 2024 Google LLC
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

namespace GoogleCSharpSnippets
{
    using Google.Cloud.Compute.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLicenseCodesClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetLicenseCodeRequest, CallSettings)
            // Create client
            LicenseCodesClient licenseCodesClient = LicenseCodesClient.Create();
            // Initialize request argument(s)
            GetLicenseCodeRequest request = new GetLicenseCodeRequest
            {
                LicenseCode = "",
                Project = "",
            };
            // Make the request
            LicenseCode response = licenseCodesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetLicenseCodeRequest, CallSettings)
            // Additional: GetAsync(GetLicenseCodeRequest, CancellationToken)
            // Create client
            LicenseCodesClient licenseCodesClient = await LicenseCodesClient.CreateAsync();
            // Initialize request argument(s)
            GetLicenseCodeRequest request = new GetLicenseCodeRequest
            {
                LicenseCode = "",
                Project = "",
            };
            // Make the request
            LicenseCode response = await licenseCodesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            LicenseCodesClient licenseCodesClient = LicenseCodesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string licenseCode = "";
            // Make the request
            LicenseCode response = licenseCodesClient.Get(project, licenseCode);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            LicenseCodesClient licenseCodesClient = await LicenseCodesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string licenseCode = "";
            // Make the request
            LicenseCode response = await licenseCodesClient.GetAsync(project, licenseCode);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsLicenseCodeRequest, CallSettings)
            // Create client
            LicenseCodesClient licenseCodesClient = LicenseCodesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsLicenseCodeRequest request = new TestIamPermissionsLicenseCodeRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = licenseCodesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsLicenseCodeRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsLicenseCodeRequest, CancellationToken)
            // Create client
            LicenseCodesClient licenseCodesClient = await LicenseCodesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsLicenseCodeRequest request = new TestIamPermissionsLicenseCodeRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await licenseCodesClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, TestPermissionsRequest, CallSettings)
            // Create client
            LicenseCodesClient licenseCodesClient = LicenseCodesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = licenseCodesClient.TestIamPermissions(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            LicenseCodesClient licenseCodesClient = await LicenseCodesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await licenseCodesClient.TestIamPermissionsAsync(project, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
