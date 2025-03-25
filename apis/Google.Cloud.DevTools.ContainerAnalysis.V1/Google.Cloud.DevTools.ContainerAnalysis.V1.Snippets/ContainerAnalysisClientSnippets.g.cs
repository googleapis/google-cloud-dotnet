// Copyright 2025 Google LLC
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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.DevTools.ContainerAnalysis.V1;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedContainerAnalysisClientSnippets
    {
        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = containerAnalysisClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
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
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = containerAnalysisClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await containerAnalysisClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = containerAnalysisClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
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
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = containerAnalysisClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await containerAnalysisClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = containerAnalysisClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
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
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = containerAnalysisClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await containerAnalysisClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityOccurrencesSummary</summary>
        public void GetVulnerabilityOccurrencesSummaryRequestObject()
        {
            // Snippet: GetVulnerabilityOccurrencesSummary(GetVulnerabilityOccurrencesSummaryRequest, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            GetVulnerabilityOccurrencesSummaryRequest request = new GetVulnerabilityOccurrencesSummaryRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            VulnerabilityOccurrencesSummary response = containerAnalysisClient.GetVulnerabilityOccurrencesSummary(request);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityOccurrencesSummaryAsync</summary>
        public async Task GetVulnerabilityOccurrencesSummaryRequestObjectAsync()
        {
            // Snippet: GetVulnerabilityOccurrencesSummaryAsync(GetVulnerabilityOccurrencesSummaryRequest, CallSettings)
            // Additional: GetVulnerabilityOccurrencesSummaryAsync(GetVulnerabilityOccurrencesSummaryRequest, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            GetVulnerabilityOccurrencesSummaryRequest request = new GetVulnerabilityOccurrencesSummaryRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            VulnerabilityOccurrencesSummary response = await containerAnalysisClient.GetVulnerabilityOccurrencesSummaryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityOccurrencesSummary</summary>
        public void GetVulnerabilityOccurrencesSummary()
        {
            // Snippet: GetVulnerabilityOccurrencesSummary(string, string, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string filter = "";
            // Make the request
            VulnerabilityOccurrencesSummary response = containerAnalysisClient.GetVulnerabilityOccurrencesSummary(parent, filter);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityOccurrencesSummaryAsync</summary>
        public async Task GetVulnerabilityOccurrencesSummaryAsync()
        {
            // Snippet: GetVulnerabilityOccurrencesSummaryAsync(string, string, CallSettings)
            // Additional: GetVulnerabilityOccurrencesSummaryAsync(string, string, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string filter = "";
            // Make the request
            VulnerabilityOccurrencesSummary response = await containerAnalysisClient.GetVulnerabilityOccurrencesSummaryAsync(parent, filter);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityOccurrencesSummary</summary>
        public void GetVulnerabilityOccurrencesSummaryResourceNames()
        {
            // Snippet: GetVulnerabilityOccurrencesSummary(ProjectName, string, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            VulnerabilityOccurrencesSummary response = containerAnalysisClient.GetVulnerabilityOccurrencesSummary(parent, filter);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityOccurrencesSummaryAsync</summary>
        public async Task GetVulnerabilityOccurrencesSummaryResourceNamesAsync()
        {
            // Snippet: GetVulnerabilityOccurrencesSummaryAsync(ProjectName, string, CallSettings)
            // Additional: GetVulnerabilityOccurrencesSummaryAsync(ProjectName, string, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            VulnerabilityOccurrencesSummary response = await containerAnalysisClient.GetVulnerabilityOccurrencesSummaryAsync(parent, filter);
            // End snippet
        }

        /// <summary>Snippet for ExportSBOM</summary>
        public void ExportSBOMRequestObject()
        {
            // Snippet: ExportSBOM(ExportSBOMRequest, CallSettings)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            ExportSBOMRequest request = new ExportSBOMRequest
            {
                Name = "",
                CloudStorageLocation = new ExportSBOMRequest.Types.CloudStorageLocation(),
            };
            // Make the request
            ExportSBOMResponse response = containerAnalysisClient.ExportSBOM(request);
            // End snippet
        }

        /// <summary>Snippet for ExportSBOMAsync</summary>
        public async Task ExportSBOMRequestObjectAsync()
        {
            // Snippet: ExportSBOMAsync(ExportSBOMRequest, CallSettings)
            // Additional: ExportSBOMAsync(ExportSBOMRequest, CancellationToken)
            // Create client
            ContainerAnalysisClient containerAnalysisClient = await ContainerAnalysisClient.CreateAsync();
            // Initialize request argument(s)
            ExportSBOMRequest request = new ExportSBOMRequest
            {
                Name = "",
                CloudStorageLocation = new ExportSBOMRequest.Types.CloudStorageLocation(),
            };
            // Make the request
            ExportSBOMResponse response = await containerAnalysisClient.ExportSBOMAsync(request);
            // End snippet
        }
    }
}
