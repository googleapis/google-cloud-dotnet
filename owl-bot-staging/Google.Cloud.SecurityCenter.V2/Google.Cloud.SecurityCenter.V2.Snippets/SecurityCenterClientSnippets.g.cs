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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.Cloud.SecurityCenter.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSecurityCenterClientSnippets
    {
        /// <summary>Snippet for BatchCreateResourceValueConfigs</summary>
        public void BatchCreateResourceValueConfigsRequestObject()
        {
            // Snippet: BatchCreateResourceValueConfigs(BatchCreateResourceValueConfigsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            BatchCreateResourceValueConfigsRequest request = new BatchCreateResourceValueConfigsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Requests =
                {
                    new CreateResourceValueConfigRequest(),
                },
            };
            // Make the request
            BatchCreateResourceValueConfigsResponse response = securityCenterClient.BatchCreateResourceValueConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateResourceValueConfigsAsync</summary>
        public async Task BatchCreateResourceValueConfigsRequestObjectAsync()
        {
            // Snippet: BatchCreateResourceValueConfigsAsync(BatchCreateResourceValueConfigsRequest, CallSettings)
            // Additional: BatchCreateResourceValueConfigsAsync(BatchCreateResourceValueConfigsRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateResourceValueConfigsRequest request = new BatchCreateResourceValueConfigsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Requests =
                {
                    new CreateResourceValueConfigRequest(),
                },
            };
            // Make the request
            BatchCreateResourceValueConfigsResponse response = await securityCenterClient.BatchCreateResourceValueConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateResourceValueConfigs</summary>
        public void BatchCreateResourceValueConfigs()
        {
            // Snippet: BatchCreateResourceValueConfigs(string, IEnumerable<CreateResourceValueConfigRequest>, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            IEnumerable<CreateResourceValueConfigRequest> requests = new CreateResourceValueConfigRequest[]
            {
                new CreateResourceValueConfigRequest(),
            };
            // Make the request
            BatchCreateResourceValueConfigsResponse response = securityCenterClient.BatchCreateResourceValueConfigs(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateResourceValueConfigsAsync</summary>
        public async Task BatchCreateResourceValueConfigsAsync()
        {
            // Snippet: BatchCreateResourceValueConfigsAsync(string, IEnumerable<CreateResourceValueConfigRequest>, CallSettings)
            // Additional: BatchCreateResourceValueConfigsAsync(string, IEnumerable<CreateResourceValueConfigRequest>, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            IEnumerable<CreateResourceValueConfigRequest> requests = new CreateResourceValueConfigRequest[]
            {
                new CreateResourceValueConfigRequest(),
            };
            // Make the request
            BatchCreateResourceValueConfigsResponse response = await securityCenterClient.BatchCreateResourceValueConfigsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateResourceValueConfigs</summary>
        public void BatchCreateResourceValueConfigsResourceNames1()
        {
            // Snippet: BatchCreateResourceValueConfigs(OrganizationName, IEnumerable<CreateResourceValueConfigRequest>, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            IEnumerable<CreateResourceValueConfigRequest> requests = new CreateResourceValueConfigRequest[]
            {
                new CreateResourceValueConfigRequest(),
            };
            // Make the request
            BatchCreateResourceValueConfigsResponse response = securityCenterClient.BatchCreateResourceValueConfigs(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateResourceValueConfigsAsync</summary>
        public async Task BatchCreateResourceValueConfigsResourceNames1Async()
        {
            // Snippet: BatchCreateResourceValueConfigsAsync(OrganizationName, IEnumerable<CreateResourceValueConfigRequest>, CallSettings)
            // Additional: BatchCreateResourceValueConfigsAsync(OrganizationName, IEnumerable<CreateResourceValueConfigRequest>, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            IEnumerable<CreateResourceValueConfigRequest> requests = new CreateResourceValueConfigRequest[]
            {
                new CreateResourceValueConfigRequest(),
            };
            // Make the request
            BatchCreateResourceValueConfigsResponse response = await securityCenterClient.BatchCreateResourceValueConfigsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateResourceValueConfigs</summary>
        public void BatchCreateResourceValueConfigsResourceNames2()
        {
            // Snippet: BatchCreateResourceValueConfigs(OrganizationLocationName, IEnumerable<CreateResourceValueConfigRequest>, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            IEnumerable<CreateResourceValueConfigRequest> requests = new CreateResourceValueConfigRequest[]
            {
                new CreateResourceValueConfigRequest(),
            };
            // Make the request
            BatchCreateResourceValueConfigsResponse response = securityCenterClient.BatchCreateResourceValueConfigs(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateResourceValueConfigsAsync</summary>
        public async Task BatchCreateResourceValueConfigsResourceNames2Async()
        {
            // Snippet: BatchCreateResourceValueConfigsAsync(OrganizationLocationName, IEnumerable<CreateResourceValueConfigRequest>, CallSettings)
            // Additional: BatchCreateResourceValueConfigsAsync(OrganizationLocationName, IEnumerable<CreateResourceValueConfigRequest>, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            IEnumerable<CreateResourceValueConfigRequest> requests = new CreateResourceValueConfigRequest[]
            {
                new CreateResourceValueConfigRequest(),
            };
            // Make the request
            BatchCreateResourceValueConfigsResponse response = await securityCenterClient.BatchCreateResourceValueConfigsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkMuteFindings</summary>
        public void BulkMuteFindingsRequestObject()
        {
            // Snippet: BulkMuteFindings(BulkMuteFindingsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            BulkMuteFindingsRequest request = new BulkMuteFindingsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Filter = "",
            };
            // Make the request
            Operation<BulkMuteFindingsResponse, Empty> response = securityCenterClient.BulkMuteFindings(request);

            // Poll until the returned long-running operation is complete
            Operation<BulkMuteFindingsResponse, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BulkMuteFindingsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkMuteFindingsResponse, Empty> retrievedResponse = securityCenterClient.PollOnceBulkMuteFindings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkMuteFindingsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkMuteFindingsAsync</summary>
        public async Task BulkMuteFindingsRequestObjectAsync()
        {
            // Snippet: BulkMuteFindingsAsync(BulkMuteFindingsRequest, CallSettings)
            // Additional: BulkMuteFindingsAsync(BulkMuteFindingsRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            BulkMuteFindingsRequest request = new BulkMuteFindingsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Filter = "",
            };
            // Make the request
            Operation<BulkMuteFindingsResponse, Empty> response = await securityCenterClient.BulkMuteFindingsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BulkMuteFindingsResponse, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BulkMuteFindingsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkMuteFindingsResponse, Empty> retrievedResponse = await securityCenterClient.PollOnceBulkMuteFindingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkMuteFindingsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkMuteFindings</summary>
        public void BulkMuteFindings()
        {
            // Snippet: BulkMuteFindings(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            Operation<BulkMuteFindingsResponse, Empty> response = securityCenterClient.BulkMuteFindings(parent);

            // Poll until the returned long-running operation is complete
            Operation<BulkMuteFindingsResponse, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BulkMuteFindingsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkMuteFindingsResponse, Empty> retrievedResponse = securityCenterClient.PollOnceBulkMuteFindings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkMuteFindingsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkMuteFindingsAsync</summary>
        public async Task BulkMuteFindingsAsync()
        {
            // Snippet: BulkMuteFindingsAsync(string, CallSettings)
            // Additional: BulkMuteFindingsAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            Operation<BulkMuteFindingsResponse, Empty> response = await securityCenterClient.BulkMuteFindingsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<BulkMuteFindingsResponse, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BulkMuteFindingsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkMuteFindingsResponse, Empty> retrievedResponse = await securityCenterClient.PollOnceBulkMuteFindingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkMuteFindingsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkMuteFindings</summary>
        public void BulkMuteFindingsResourceNames()
        {
            // Snippet: BulkMuteFindings(IResourceName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Operation<BulkMuteFindingsResponse, Empty> response = securityCenterClient.BulkMuteFindings(parent);

            // Poll until the returned long-running operation is complete
            Operation<BulkMuteFindingsResponse, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BulkMuteFindingsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkMuteFindingsResponse, Empty> retrievedResponse = securityCenterClient.PollOnceBulkMuteFindings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkMuteFindingsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkMuteFindingsAsync</summary>
        public async Task BulkMuteFindingsResourceNamesAsync()
        {
            // Snippet: BulkMuteFindingsAsync(IResourceName, CallSettings)
            // Additional: BulkMuteFindingsAsync(IResourceName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Operation<BulkMuteFindingsResponse, Empty> response = await securityCenterClient.BulkMuteFindingsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<BulkMuteFindingsResponse, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BulkMuteFindingsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkMuteFindingsResponse, Empty> retrievedResponse = await securityCenterClient.PollOnceBulkMuteFindingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkMuteFindingsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryExport</summary>
        public void CreateBigQueryExportRequestObject()
        {
            // Snippet: CreateBigQueryExport(CreateBigQueryExportRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            CreateBigQueryExportRequest request = new CreateBigQueryExportRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                BigQueryExport = new BigQueryExport(),
                BigQueryExportId = "",
            };
            // Make the request
            BigQueryExport response = securityCenterClient.CreateBigQueryExport(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryExportAsync</summary>
        public async Task CreateBigQueryExportRequestObjectAsync()
        {
            // Snippet: CreateBigQueryExportAsync(CreateBigQueryExportRequest, CallSettings)
            // Additional: CreateBigQueryExportAsync(CreateBigQueryExportRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateBigQueryExportRequest request = new CreateBigQueryExportRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                BigQueryExport = new BigQueryExport(),
                BigQueryExportId = "",
            };
            // Make the request
            BigQueryExport response = await securityCenterClient.CreateBigQueryExportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryExport</summary>
        public void CreateBigQueryExport()
        {
            // Snippet: CreateBigQueryExport(string, BigQueryExport, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            BigQueryExport bigQueryExport = new BigQueryExport();
            string bigQueryExportId = "";
            // Make the request
            BigQueryExport response = securityCenterClient.CreateBigQueryExport(parent, bigQueryExport, bigQueryExportId);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryExportAsync</summary>
        public async Task CreateBigQueryExportAsync()
        {
            // Snippet: CreateBigQueryExportAsync(string, BigQueryExport, string, CallSettings)
            // Additional: CreateBigQueryExportAsync(string, BigQueryExport, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            BigQueryExport bigQueryExport = new BigQueryExport();
            string bigQueryExportId = "";
            // Make the request
            BigQueryExport response = await securityCenterClient.CreateBigQueryExportAsync(parent, bigQueryExport, bigQueryExportId);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryExport</summary>
        public void CreateBigQueryExportResourceNames1()
        {
            // Snippet: CreateBigQueryExport(OrganizationLocationName, BigQueryExport, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            BigQueryExport bigQueryExport = new BigQueryExport();
            string bigQueryExportId = "";
            // Make the request
            BigQueryExport response = securityCenterClient.CreateBigQueryExport(parent, bigQueryExport, bigQueryExportId);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryExportAsync</summary>
        public async Task CreateBigQueryExportResourceNames1Async()
        {
            // Snippet: CreateBigQueryExportAsync(OrganizationLocationName, BigQueryExport, string, CallSettings)
            // Additional: CreateBigQueryExportAsync(OrganizationLocationName, BigQueryExport, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            BigQueryExport bigQueryExport = new BigQueryExport();
            string bigQueryExportId = "";
            // Make the request
            BigQueryExport response = await securityCenterClient.CreateBigQueryExportAsync(parent, bigQueryExport, bigQueryExportId);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryExport</summary>
        public void CreateBigQueryExportResourceNames2()
        {
            // Snippet: CreateBigQueryExport(FolderLocationName, BigQueryExport, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            BigQueryExport bigQueryExport = new BigQueryExport();
            string bigQueryExportId = "";
            // Make the request
            BigQueryExport response = securityCenterClient.CreateBigQueryExport(parent, bigQueryExport, bigQueryExportId);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryExportAsync</summary>
        public async Task CreateBigQueryExportResourceNames2Async()
        {
            // Snippet: CreateBigQueryExportAsync(FolderLocationName, BigQueryExport, string, CallSettings)
            // Additional: CreateBigQueryExportAsync(FolderLocationName, BigQueryExport, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            BigQueryExport bigQueryExport = new BigQueryExport();
            string bigQueryExportId = "";
            // Make the request
            BigQueryExport response = await securityCenterClient.CreateBigQueryExportAsync(parent, bigQueryExport, bigQueryExportId);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryExport</summary>
        public void CreateBigQueryExportResourceNames3()
        {
            // Snippet: CreateBigQueryExport(LocationName, BigQueryExport, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BigQueryExport bigQueryExport = new BigQueryExport();
            string bigQueryExportId = "";
            // Make the request
            BigQueryExport response = securityCenterClient.CreateBigQueryExport(parent, bigQueryExport, bigQueryExportId);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryExportAsync</summary>
        public async Task CreateBigQueryExportResourceNames3Async()
        {
            // Snippet: CreateBigQueryExportAsync(LocationName, BigQueryExport, string, CallSettings)
            // Additional: CreateBigQueryExportAsync(LocationName, BigQueryExport, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BigQueryExport bigQueryExport = new BigQueryExport();
            string bigQueryExportId = "";
            // Make the request
            BigQueryExport response = await securityCenterClient.CreateBigQueryExportAsync(parent, bigQueryExport, bigQueryExportId);
            // End snippet
        }

        /// <summary>Snippet for CreateFinding</summary>
        public void CreateFindingRequestObject()
        {
            // Snippet: CreateFinding(CreateFindingRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            CreateFindingRequest request = new CreateFindingRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                FindingId = "",
                Finding = new Finding(),
            };
            // Make the request
            Finding response = securityCenterClient.CreateFinding(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFindingAsync</summary>
        public async Task CreateFindingRequestObjectAsync()
        {
            // Snippet: CreateFindingAsync(CreateFindingRequest, CallSettings)
            // Additional: CreateFindingAsync(CreateFindingRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateFindingRequest request = new CreateFindingRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                FindingId = "",
                Finding = new Finding(),
            };
            // Make the request
            Finding response = await securityCenterClient.CreateFindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFinding</summary>
        public void CreateFinding()
        {
            // Snippet: CreateFinding(string, Finding, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/sources/[SOURCE]";
            Finding finding = new Finding();
            string findingId = "";
            // Make the request
            Finding response = securityCenterClient.CreateFinding(parent, finding, findingId);
            // End snippet
        }

        /// <summary>Snippet for CreateFindingAsync</summary>
        public async Task CreateFindingAsync()
        {
            // Snippet: CreateFindingAsync(string, Finding, string, CallSettings)
            // Additional: CreateFindingAsync(string, Finding, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/sources/[SOURCE]";
            Finding finding = new Finding();
            string findingId = "";
            // Make the request
            Finding response = await securityCenterClient.CreateFindingAsync(parent, finding, findingId);
            // End snippet
        }

        /// <summary>Snippet for CreateFinding</summary>
        public void CreateFindingResourceNames()
        {
            // Snippet: CreateFinding(SourceName, Finding, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            Finding finding = new Finding();
            string findingId = "";
            // Make the request
            Finding response = securityCenterClient.CreateFinding(parent, finding, findingId);
            // End snippet
        }

        /// <summary>Snippet for CreateFindingAsync</summary>
        public async Task CreateFindingResourceNamesAsync()
        {
            // Snippet: CreateFindingAsync(SourceName, Finding, string, CallSettings)
            // Additional: CreateFindingAsync(SourceName, Finding, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            Finding finding = new Finding();
            string findingId = "";
            // Make the request
            Finding response = await securityCenterClient.CreateFindingAsync(parent, finding, findingId);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfig</summary>
        public void CreateMuteConfigRequestObject()
        {
            // Snippet: CreateMuteConfig(CreateMuteConfigRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
                MuteConfigId = "",
            };
            // Make the request
            MuteConfig response = securityCenterClient.CreateMuteConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfigAsync</summary>
        public async Task CreateMuteConfigRequestObjectAsync()
        {
            // Snippet: CreateMuteConfigAsync(CreateMuteConfigRequest, CallSettings)
            // Additional: CreateMuteConfigAsync(CreateMuteConfigRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateMuteConfigRequest request = new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                MuteConfig = new MuteConfig(),
                MuteConfigId = "",
            };
            // Make the request
            MuteConfig response = await securityCenterClient.CreateMuteConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfig</summary>
        public void CreateMuteConfig()
        {
            // Snippet: CreateMuteConfig(string, MuteConfig, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            MuteConfig muteConfig = new MuteConfig();
            string muteConfigId = "";
            // Make the request
            MuteConfig response = securityCenterClient.CreateMuteConfig(parent, muteConfig, muteConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfigAsync</summary>
        public async Task CreateMuteConfigAsync()
        {
            // Snippet: CreateMuteConfigAsync(string, MuteConfig, string, CallSettings)
            // Additional: CreateMuteConfigAsync(string, MuteConfig, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            MuteConfig muteConfig = new MuteConfig();
            string muteConfigId = "";
            // Make the request
            MuteConfig response = await securityCenterClient.CreateMuteConfigAsync(parent, muteConfig, muteConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfig</summary>
        public void CreateMuteConfigResourceNames1()
        {
            // Snippet: CreateMuteConfig(OrganizationName, MuteConfig, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            MuteConfig muteConfig = new MuteConfig();
            string muteConfigId = "";
            // Make the request
            MuteConfig response = securityCenterClient.CreateMuteConfig(parent, muteConfig, muteConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfigAsync</summary>
        public async Task CreateMuteConfigResourceNames1Async()
        {
            // Snippet: CreateMuteConfigAsync(OrganizationName, MuteConfig, string, CallSettings)
            // Additional: CreateMuteConfigAsync(OrganizationName, MuteConfig, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            MuteConfig muteConfig = new MuteConfig();
            string muteConfigId = "";
            // Make the request
            MuteConfig response = await securityCenterClient.CreateMuteConfigAsync(parent, muteConfig, muteConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfig</summary>
        public void CreateMuteConfigResourceNames2()
        {
            // Snippet: CreateMuteConfig(OrganizationLocationName, MuteConfig, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            MuteConfig muteConfig = new MuteConfig();
            string muteConfigId = "";
            // Make the request
            MuteConfig response = securityCenterClient.CreateMuteConfig(parent, muteConfig, muteConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfigAsync</summary>
        public async Task CreateMuteConfigResourceNames2Async()
        {
            // Snippet: CreateMuteConfigAsync(OrganizationLocationName, MuteConfig, string, CallSettings)
            // Additional: CreateMuteConfigAsync(OrganizationLocationName, MuteConfig, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            MuteConfig muteConfig = new MuteConfig();
            string muteConfigId = "";
            // Make the request
            MuteConfig response = await securityCenterClient.CreateMuteConfigAsync(parent, muteConfig, muteConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfig</summary>
        public void CreateMuteConfigResourceNames3()
        {
            // Snippet: CreateMuteConfig(FolderName, MuteConfig, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            MuteConfig muteConfig = new MuteConfig();
            string muteConfigId = "";
            // Make the request
            MuteConfig response = securityCenterClient.CreateMuteConfig(parent, muteConfig, muteConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfigAsync</summary>
        public async Task CreateMuteConfigResourceNames3Async()
        {
            // Snippet: CreateMuteConfigAsync(FolderName, MuteConfig, string, CallSettings)
            // Additional: CreateMuteConfigAsync(FolderName, MuteConfig, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            MuteConfig muteConfig = new MuteConfig();
            string muteConfigId = "";
            // Make the request
            MuteConfig response = await securityCenterClient.CreateMuteConfigAsync(parent, muteConfig, muteConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfig</summary>
        public void CreateMuteConfigResourceNames4()
        {
            // Snippet: CreateMuteConfig(FolderLocationName, MuteConfig, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            MuteConfig muteConfig = new MuteConfig();
            string muteConfigId = "";
            // Make the request
            MuteConfig response = securityCenterClient.CreateMuteConfig(parent, muteConfig, muteConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfigAsync</summary>
        public async Task CreateMuteConfigResourceNames4Async()
        {
            // Snippet: CreateMuteConfigAsync(FolderLocationName, MuteConfig, string, CallSettings)
            // Additional: CreateMuteConfigAsync(FolderLocationName, MuteConfig, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            MuteConfig muteConfig = new MuteConfig();
            string muteConfigId = "";
            // Make the request
            MuteConfig response = await securityCenterClient.CreateMuteConfigAsync(parent, muteConfig, muteConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfig</summary>
        public void CreateMuteConfigResourceNames5()
        {
            // Snippet: CreateMuteConfig(ProjectName, MuteConfig, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            MuteConfig muteConfig = new MuteConfig();
            string muteConfigId = "";
            // Make the request
            MuteConfig response = securityCenterClient.CreateMuteConfig(parent, muteConfig, muteConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfigAsync</summary>
        public async Task CreateMuteConfigResourceNames5Async()
        {
            // Snippet: CreateMuteConfigAsync(ProjectName, MuteConfig, string, CallSettings)
            // Additional: CreateMuteConfigAsync(ProjectName, MuteConfig, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            MuteConfig muteConfig = new MuteConfig();
            string muteConfigId = "";
            // Make the request
            MuteConfig response = await securityCenterClient.CreateMuteConfigAsync(parent, muteConfig, muteConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfig</summary>
        public void CreateMuteConfigResourceNames6()
        {
            // Snippet: CreateMuteConfig(LocationName, MuteConfig, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MuteConfig muteConfig = new MuteConfig();
            string muteConfigId = "";
            // Make the request
            MuteConfig response = securityCenterClient.CreateMuteConfig(parent, muteConfig, muteConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateMuteConfigAsync</summary>
        public async Task CreateMuteConfigResourceNames6Async()
        {
            // Snippet: CreateMuteConfigAsync(LocationName, MuteConfig, string, CallSettings)
            // Additional: CreateMuteConfigAsync(LocationName, MuteConfig, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MuteConfig muteConfig = new MuteConfig();
            string muteConfigId = "";
            // Make the request
            MuteConfig response = await securityCenterClient.CreateMuteConfigAsync(parent, muteConfig, muteConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationConfig</summary>
        public void CreateNotificationConfigRequestObject()
        {
            // Snippet: CreateNotificationConfig(CreateNotificationConfigRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            CreateNotificationConfigRequest request = new CreateNotificationConfigRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                ConfigId = "",
                NotificationConfig = new NotificationConfig(),
            };
            // Make the request
            NotificationConfig response = securityCenterClient.CreateNotificationConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationConfigAsync</summary>
        public async Task CreateNotificationConfigRequestObjectAsync()
        {
            // Snippet: CreateNotificationConfigAsync(CreateNotificationConfigRequest, CallSettings)
            // Additional: CreateNotificationConfigAsync(CreateNotificationConfigRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateNotificationConfigRequest request = new CreateNotificationConfigRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                ConfigId = "",
                NotificationConfig = new NotificationConfig(),
            };
            // Make the request
            NotificationConfig response = await securityCenterClient.CreateNotificationConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationConfig</summary>
        public void CreateNotificationConfig()
        {
            // Snippet: CreateNotificationConfig(string, NotificationConfig, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            NotificationConfig notificationConfig = new NotificationConfig();
            string configId = "";
            // Make the request
            NotificationConfig response = securityCenterClient.CreateNotificationConfig(parent, notificationConfig, configId);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationConfigAsync</summary>
        public async Task CreateNotificationConfigAsync()
        {
            // Snippet: CreateNotificationConfigAsync(string, NotificationConfig, string, CallSettings)
            // Additional: CreateNotificationConfigAsync(string, NotificationConfig, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            NotificationConfig notificationConfig = new NotificationConfig();
            string configId = "";
            // Make the request
            NotificationConfig response = await securityCenterClient.CreateNotificationConfigAsync(parent, notificationConfig, configId);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationConfig</summary>
        public void CreateNotificationConfigResourceNames1()
        {
            // Snippet: CreateNotificationConfig(OrganizationLocationName, NotificationConfig, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            NotificationConfig notificationConfig = new NotificationConfig();
            string configId = "";
            // Make the request
            NotificationConfig response = securityCenterClient.CreateNotificationConfig(parent, notificationConfig, configId);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationConfigAsync</summary>
        public async Task CreateNotificationConfigResourceNames1Async()
        {
            // Snippet: CreateNotificationConfigAsync(OrganizationLocationName, NotificationConfig, string, CallSettings)
            // Additional: CreateNotificationConfigAsync(OrganizationLocationName, NotificationConfig, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            NotificationConfig notificationConfig = new NotificationConfig();
            string configId = "";
            // Make the request
            NotificationConfig response = await securityCenterClient.CreateNotificationConfigAsync(parent, notificationConfig, configId);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationConfig</summary>
        public void CreateNotificationConfigResourceNames2()
        {
            // Snippet: CreateNotificationConfig(FolderLocationName, NotificationConfig, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            NotificationConfig notificationConfig = new NotificationConfig();
            string configId = "";
            // Make the request
            NotificationConfig response = securityCenterClient.CreateNotificationConfig(parent, notificationConfig, configId);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationConfigAsync</summary>
        public async Task CreateNotificationConfigResourceNames2Async()
        {
            // Snippet: CreateNotificationConfigAsync(FolderLocationName, NotificationConfig, string, CallSettings)
            // Additional: CreateNotificationConfigAsync(FolderLocationName, NotificationConfig, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            NotificationConfig notificationConfig = new NotificationConfig();
            string configId = "";
            // Make the request
            NotificationConfig response = await securityCenterClient.CreateNotificationConfigAsync(parent, notificationConfig, configId);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationConfig</summary>
        public void CreateNotificationConfigResourceNames3()
        {
            // Snippet: CreateNotificationConfig(LocationName, NotificationConfig, string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NotificationConfig notificationConfig = new NotificationConfig();
            string configId = "";
            // Make the request
            NotificationConfig response = securityCenterClient.CreateNotificationConfig(parent, notificationConfig, configId);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationConfigAsync</summary>
        public async Task CreateNotificationConfigResourceNames3Async()
        {
            // Snippet: CreateNotificationConfigAsync(LocationName, NotificationConfig, string, CallSettings)
            // Additional: CreateNotificationConfigAsync(LocationName, NotificationConfig, string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NotificationConfig notificationConfig = new NotificationConfig();
            string configId = "";
            // Make the request
            NotificationConfig response = await securityCenterClient.CreateNotificationConfigAsync(parent, notificationConfig, configId);
            // End snippet
        }

        /// <summary>Snippet for CreateSource</summary>
        public void CreateSourceRequestObject()
        {
            // Snippet: CreateSource(CreateSourceRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Source = new Source(),
            };
            // Make the request
            Source response = securityCenterClient.CreateSource(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSourceAsync</summary>
        public async Task CreateSourceRequestObjectAsync()
        {
            // Snippet: CreateSourceAsync(CreateSourceRequest, CallSettings)
            // Additional: CreateSourceAsync(CreateSourceRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Source = new Source(),
            };
            // Make the request
            Source response = await securityCenterClient.CreateSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSource</summary>
        public void CreateSource()
        {
            // Snippet: CreateSource(string, Source, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            Source source = new Source();
            // Make the request
            Source response = securityCenterClient.CreateSource(parent, source);
            // End snippet
        }

        /// <summary>Snippet for CreateSourceAsync</summary>
        public async Task CreateSourceAsync()
        {
            // Snippet: CreateSourceAsync(string, Source, CallSettings)
            // Additional: CreateSourceAsync(string, Source, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            Source source = new Source();
            // Make the request
            Source response = await securityCenterClient.CreateSourceAsync(parent, source);
            // End snippet
        }

        /// <summary>Snippet for CreateSource</summary>
        public void CreateSourceResourceNames()
        {
            // Snippet: CreateSource(OrganizationName, Source, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            Source source = new Source();
            // Make the request
            Source response = securityCenterClient.CreateSource(parent, source);
            // End snippet
        }

        /// <summary>Snippet for CreateSourceAsync</summary>
        public async Task CreateSourceResourceNamesAsync()
        {
            // Snippet: CreateSourceAsync(OrganizationName, Source, CallSettings)
            // Additional: CreateSourceAsync(OrganizationName, Source, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            Source source = new Source();
            // Make the request
            Source response = await securityCenterClient.CreateSourceAsync(parent, source);
            // End snippet
        }

        /// <summary>Snippet for DeleteBigQueryExport</summary>
        public void DeleteBigQueryExportRequestObject()
        {
            // Snippet: DeleteBigQueryExport(DeleteBigQueryExportRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            DeleteBigQueryExportRequest request = new DeleteBigQueryExportRequest
            {
                BigQueryExportName = BigQueryExportName.FromOrganizationLocationExport("[ORGANIZATION]", "[LOCATION]", "[EXPORT]"),
            };
            // Make the request
            securityCenterClient.DeleteBigQueryExport(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBigQueryExportAsync</summary>
        public async Task DeleteBigQueryExportRequestObjectAsync()
        {
            // Snippet: DeleteBigQueryExportAsync(DeleteBigQueryExportRequest, CallSettings)
            // Additional: DeleteBigQueryExportAsync(DeleteBigQueryExportRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBigQueryExportRequest request = new DeleteBigQueryExportRequest
            {
                BigQueryExportName = BigQueryExportName.FromOrganizationLocationExport("[ORGANIZATION]", "[LOCATION]", "[EXPORT]"),
            };
            // Make the request
            await securityCenterClient.DeleteBigQueryExportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBigQueryExport</summary>
        public void DeleteBigQueryExport()
        {
            // Snippet: DeleteBigQueryExport(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/bigQueryExports/[EXPORT]";
            // Make the request
            securityCenterClient.DeleteBigQueryExport(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBigQueryExportAsync</summary>
        public async Task DeleteBigQueryExportAsync()
        {
            // Snippet: DeleteBigQueryExportAsync(string, CallSettings)
            // Additional: DeleteBigQueryExportAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/bigQueryExports/[EXPORT]";
            // Make the request
            await securityCenterClient.DeleteBigQueryExportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBigQueryExport</summary>
        public void DeleteBigQueryExportResourceNames()
        {
            // Snippet: DeleteBigQueryExport(BigQueryExportName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            BigQueryExportName name = BigQueryExportName.FromOrganizationLocationExport("[ORGANIZATION]", "[LOCATION]", "[EXPORT]");
            // Make the request
            securityCenterClient.DeleteBigQueryExport(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBigQueryExportAsync</summary>
        public async Task DeleteBigQueryExportResourceNamesAsync()
        {
            // Snippet: DeleteBigQueryExportAsync(BigQueryExportName, CallSettings)
            // Additional: DeleteBigQueryExportAsync(BigQueryExportName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            BigQueryExportName name = BigQueryExportName.FromOrganizationLocationExport("[ORGANIZATION]", "[LOCATION]", "[EXPORT]");
            // Make the request
            await securityCenterClient.DeleteBigQueryExportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMuteConfig</summary>
        public void DeleteMuteConfigRequestObject()
        {
            // Snippet: DeleteMuteConfig(DeleteMuteConfigRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            DeleteMuteConfigRequest request = new DeleteMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            // Make the request
            securityCenterClient.DeleteMuteConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMuteConfigAsync</summary>
        public async Task DeleteMuteConfigRequestObjectAsync()
        {
            // Snippet: DeleteMuteConfigAsync(DeleteMuteConfigRequest, CallSettings)
            // Additional: DeleteMuteConfigAsync(DeleteMuteConfigRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMuteConfigRequest request = new DeleteMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            // Make the request
            await securityCenterClient.DeleteMuteConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMuteConfig</summary>
        public void DeleteMuteConfig()
        {
            // Snippet: DeleteMuteConfig(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/muteConfigs/[MUTE_CONFIG]";
            // Make the request
            securityCenterClient.DeleteMuteConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMuteConfigAsync</summary>
        public async Task DeleteMuteConfigAsync()
        {
            // Snippet: DeleteMuteConfigAsync(string, CallSettings)
            // Additional: DeleteMuteConfigAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/muteConfigs/[MUTE_CONFIG]";
            // Make the request
            await securityCenterClient.DeleteMuteConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMuteConfig</summary>
        public void DeleteMuteConfigResourceNames()
        {
            // Snippet: DeleteMuteConfig(MuteConfigName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            MuteConfigName name = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]");
            // Make the request
            securityCenterClient.DeleteMuteConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMuteConfigAsync</summary>
        public async Task DeleteMuteConfigResourceNamesAsync()
        {
            // Snippet: DeleteMuteConfigAsync(MuteConfigName, CallSettings)
            // Additional: DeleteMuteConfigAsync(MuteConfigName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            MuteConfigName name = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]");
            // Make the request
            await securityCenterClient.DeleteMuteConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationConfig</summary>
        public void DeleteNotificationConfigRequestObject()
        {
            // Snippet: DeleteNotificationConfig(DeleteNotificationConfigRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            DeleteNotificationConfigRequest request = new DeleteNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationLocationNotificationConfig("[ORGANIZATION]", "[LOCATION]", "[NOTIFICATION_CONFIG]"),
            };
            // Make the request
            securityCenterClient.DeleteNotificationConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationConfigAsync</summary>
        public async Task DeleteNotificationConfigRequestObjectAsync()
        {
            // Snippet: DeleteNotificationConfigAsync(DeleteNotificationConfigRequest, CallSettings)
            // Additional: DeleteNotificationConfigAsync(DeleteNotificationConfigRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNotificationConfigRequest request = new DeleteNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationLocationNotificationConfig("[ORGANIZATION]", "[LOCATION]", "[NOTIFICATION_CONFIG]"),
            };
            // Make the request
            await securityCenterClient.DeleteNotificationConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationConfig</summary>
        public void DeleteNotificationConfig()
        {
            // Snippet: DeleteNotificationConfig(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/notificationConfigs/[NOTIFICATION_CONFIG]";
            // Make the request
            securityCenterClient.DeleteNotificationConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationConfigAsync</summary>
        public async Task DeleteNotificationConfigAsync()
        {
            // Snippet: DeleteNotificationConfigAsync(string, CallSettings)
            // Additional: DeleteNotificationConfigAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/notificationConfigs/[NOTIFICATION_CONFIG]";
            // Make the request
            await securityCenterClient.DeleteNotificationConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationConfig</summary>
        public void DeleteNotificationConfigResourceNames()
        {
            // Snippet: DeleteNotificationConfig(NotificationConfigName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            NotificationConfigName name = NotificationConfigName.FromOrganizationLocationNotificationConfig("[ORGANIZATION]", "[LOCATION]", "[NOTIFICATION_CONFIG]");
            // Make the request
            securityCenterClient.DeleteNotificationConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationConfigAsync</summary>
        public async Task DeleteNotificationConfigResourceNamesAsync()
        {
            // Snippet: DeleteNotificationConfigAsync(NotificationConfigName, CallSettings)
            // Additional: DeleteNotificationConfigAsync(NotificationConfigName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            NotificationConfigName name = NotificationConfigName.FromOrganizationLocationNotificationConfig("[ORGANIZATION]", "[LOCATION]", "[NOTIFICATION_CONFIG]");
            // Make the request
            await securityCenterClient.DeleteNotificationConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceValueConfig</summary>
        public void DeleteResourceValueConfigRequestObject()
        {
            // Snippet: DeleteResourceValueConfig(DeleteResourceValueConfigRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            DeleteResourceValueConfigRequest request = new DeleteResourceValueConfigRequest
            {
                ResourceValueConfigName = ResourceValueConfigName.FromOrganizationResourceValueConfig("[ORGANIZATION]", "[RESOURCE_VALUE_CONFIG]"),
            };
            // Make the request
            securityCenterClient.DeleteResourceValueConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceValueConfigAsync</summary>
        public async Task DeleteResourceValueConfigRequestObjectAsync()
        {
            // Snippet: DeleteResourceValueConfigAsync(DeleteResourceValueConfigRequest, CallSettings)
            // Additional: DeleteResourceValueConfigAsync(DeleteResourceValueConfigRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteResourceValueConfigRequest request = new DeleteResourceValueConfigRequest
            {
                ResourceValueConfigName = ResourceValueConfigName.FromOrganizationResourceValueConfig("[ORGANIZATION]", "[RESOURCE_VALUE_CONFIG]"),
            };
            // Make the request
            await securityCenterClient.DeleteResourceValueConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceValueConfig</summary>
        public void DeleteResourceValueConfig()
        {
            // Snippet: DeleteResourceValueConfig(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/resourceValueConfigs/[RESOURCE_VALUE_CONFIG]";
            // Make the request
            securityCenterClient.DeleteResourceValueConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceValueConfigAsync</summary>
        public async Task DeleteResourceValueConfigAsync()
        {
            // Snippet: DeleteResourceValueConfigAsync(string, CallSettings)
            // Additional: DeleteResourceValueConfigAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/resourceValueConfigs/[RESOURCE_VALUE_CONFIG]";
            // Make the request
            await securityCenterClient.DeleteResourceValueConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceValueConfig</summary>
        public void DeleteResourceValueConfigResourceNames()
        {
            // Snippet: DeleteResourceValueConfig(ResourceValueConfigName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ResourceValueConfigName name = ResourceValueConfigName.FromOrganizationResourceValueConfig("[ORGANIZATION]", "[RESOURCE_VALUE_CONFIG]");
            // Make the request
            securityCenterClient.DeleteResourceValueConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceValueConfigAsync</summary>
        public async Task DeleteResourceValueConfigResourceNamesAsync()
        {
            // Snippet: DeleteResourceValueConfigAsync(ResourceValueConfigName, CallSettings)
            // Additional: DeleteResourceValueConfigAsync(ResourceValueConfigName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ResourceValueConfigName name = ResourceValueConfigName.FromOrganizationResourceValueConfig("[ORGANIZATION]", "[RESOURCE_VALUE_CONFIG]");
            // Make the request
            await securityCenterClient.DeleteResourceValueConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryExport</summary>
        public void GetBigQueryExportRequestObject()
        {
            // Snippet: GetBigQueryExport(GetBigQueryExportRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            GetBigQueryExportRequest request = new GetBigQueryExportRequest
            {
                BigQueryExportName = BigQueryExportName.FromOrganizationLocationExport("[ORGANIZATION]", "[LOCATION]", "[EXPORT]"),
            };
            // Make the request
            BigQueryExport response = securityCenterClient.GetBigQueryExport(request);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryExportAsync</summary>
        public async Task GetBigQueryExportRequestObjectAsync()
        {
            // Snippet: GetBigQueryExportAsync(GetBigQueryExportRequest, CallSettings)
            // Additional: GetBigQueryExportAsync(GetBigQueryExportRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetBigQueryExportRequest request = new GetBigQueryExportRequest
            {
                BigQueryExportName = BigQueryExportName.FromOrganizationLocationExport("[ORGANIZATION]", "[LOCATION]", "[EXPORT]"),
            };
            // Make the request
            BigQueryExport response = await securityCenterClient.GetBigQueryExportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryExport</summary>
        public void GetBigQueryExport()
        {
            // Snippet: GetBigQueryExport(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/bigQueryExports/[EXPORT]";
            // Make the request
            BigQueryExport response = securityCenterClient.GetBigQueryExport(name);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryExportAsync</summary>
        public async Task GetBigQueryExportAsync()
        {
            // Snippet: GetBigQueryExportAsync(string, CallSettings)
            // Additional: GetBigQueryExportAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/bigQueryExports/[EXPORT]";
            // Make the request
            BigQueryExport response = await securityCenterClient.GetBigQueryExportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryExport</summary>
        public void GetBigQueryExportResourceNames()
        {
            // Snippet: GetBigQueryExport(BigQueryExportName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            BigQueryExportName name = BigQueryExportName.FromOrganizationLocationExport("[ORGANIZATION]", "[LOCATION]", "[EXPORT]");
            // Make the request
            BigQueryExport response = securityCenterClient.GetBigQueryExport(name);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryExportAsync</summary>
        public async Task GetBigQueryExportResourceNamesAsync()
        {
            // Snippet: GetBigQueryExportAsync(BigQueryExportName, CallSettings)
            // Additional: GetBigQueryExportAsync(BigQueryExportName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            BigQueryExportName name = BigQueryExportName.FromOrganizationLocationExport("[ORGANIZATION]", "[LOCATION]", "[EXPORT]");
            // Make the request
            BigQueryExport response = await securityCenterClient.GetBigQueryExportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSimulation</summary>
        public void GetSimulationRequestObject()
        {
            // Snippet: GetSimulation(GetSimulationRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            GetSimulationRequest request = new GetSimulationRequest
            {
                SimulationName = SimulationName.FromOrganizationSimulation("[ORGANIZATION]", "[SIMULATION]"),
            };
            // Make the request
            Simulation response = securityCenterClient.GetSimulation(request);
            // End snippet
        }

        /// <summary>Snippet for GetSimulationAsync</summary>
        public async Task GetSimulationRequestObjectAsync()
        {
            // Snippet: GetSimulationAsync(GetSimulationRequest, CallSettings)
            // Additional: GetSimulationAsync(GetSimulationRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetSimulationRequest request = new GetSimulationRequest
            {
                SimulationName = SimulationName.FromOrganizationSimulation("[ORGANIZATION]", "[SIMULATION]"),
            };
            // Make the request
            Simulation response = await securityCenterClient.GetSimulationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSimulation</summary>
        public void GetSimulation()
        {
            // Snippet: GetSimulation(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/simulations/[SIMULATION]";
            // Make the request
            Simulation response = securityCenterClient.GetSimulation(name);
            // End snippet
        }

        /// <summary>Snippet for GetSimulationAsync</summary>
        public async Task GetSimulationAsync()
        {
            // Snippet: GetSimulationAsync(string, CallSettings)
            // Additional: GetSimulationAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/simulations/[SIMULATION]";
            // Make the request
            Simulation response = await securityCenterClient.GetSimulationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSimulation</summary>
        public void GetSimulationResourceNames()
        {
            // Snippet: GetSimulation(SimulationName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SimulationName name = SimulationName.FromOrganizationSimulation("[ORGANIZATION]", "[SIMULATION]");
            // Make the request
            Simulation response = securityCenterClient.GetSimulation(name);
            // End snippet
        }

        /// <summary>Snippet for GetSimulationAsync</summary>
        public async Task GetSimulationResourceNamesAsync()
        {
            // Snippet: GetSimulationAsync(SimulationName, CallSettings)
            // Additional: GetSimulationAsync(SimulationName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SimulationName name = SimulationName.FromOrganizationSimulation("[ORGANIZATION]", "[SIMULATION]");
            // Make the request
            Simulation response = await securityCenterClient.GetSimulationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetValuedResource</summary>
        public void GetValuedResourceRequestObject()
        {
            // Snippet: GetValuedResource(GetValuedResourceRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            GetValuedResourceRequest request = new GetValuedResourceRequest
            {
                ValuedResourceName = ValuedResourceName.FromOrganizationSimulationValuedResource("[ORGANIZATION]", "[SIMULATION]", "[VALUED_RESOURCE]"),
            };
            // Make the request
            ValuedResource response = securityCenterClient.GetValuedResource(request);
            // End snippet
        }

        /// <summary>Snippet for GetValuedResourceAsync</summary>
        public async Task GetValuedResourceRequestObjectAsync()
        {
            // Snippet: GetValuedResourceAsync(GetValuedResourceRequest, CallSettings)
            // Additional: GetValuedResourceAsync(GetValuedResourceRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetValuedResourceRequest request = new GetValuedResourceRequest
            {
                ValuedResourceName = ValuedResourceName.FromOrganizationSimulationValuedResource("[ORGANIZATION]", "[SIMULATION]", "[VALUED_RESOURCE]"),
            };
            // Make the request
            ValuedResource response = await securityCenterClient.GetValuedResourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetValuedResource</summary>
        public void GetValuedResource()
        {
            // Snippet: GetValuedResource(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/simulations/[SIMULATION]/valuedResources/[VALUED_RESOURCE]";
            // Make the request
            ValuedResource response = securityCenterClient.GetValuedResource(name);
            // End snippet
        }

        /// <summary>Snippet for GetValuedResourceAsync</summary>
        public async Task GetValuedResourceAsync()
        {
            // Snippet: GetValuedResourceAsync(string, CallSettings)
            // Additional: GetValuedResourceAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/simulations/[SIMULATION]/valuedResources/[VALUED_RESOURCE]";
            // Make the request
            ValuedResource response = await securityCenterClient.GetValuedResourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetValuedResource</summary>
        public void GetValuedResourceResourceNames()
        {
            // Snippet: GetValuedResource(ValuedResourceName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ValuedResourceName name = ValuedResourceName.FromOrganizationSimulationValuedResource("[ORGANIZATION]", "[SIMULATION]", "[VALUED_RESOURCE]");
            // Make the request
            ValuedResource response = securityCenterClient.GetValuedResource(name);
            // End snippet
        }

        /// <summary>Snippet for GetValuedResourceAsync</summary>
        public async Task GetValuedResourceResourceNamesAsync()
        {
            // Snippet: GetValuedResourceAsync(ValuedResourceName, CallSettings)
            // Additional: GetValuedResourceAsync(ValuedResourceName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ValuedResourceName name = ValuedResourceName.FromOrganizationSimulationValuedResource("[ORGANIZATION]", "[SIMULATION]", "[VALUED_RESOURCE]");
            // Make the request
            ValuedResource response = await securityCenterClient.GetValuedResourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = securityCenterClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await securityCenterClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = securityCenterClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await securityCenterClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = securityCenterClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await securityCenterClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetMuteConfig</summary>
        public void GetMuteConfigRequestObject()
        {
            // Snippet: GetMuteConfig(GetMuteConfigRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            GetMuteConfigRequest request = new GetMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            // Make the request
            MuteConfig response = securityCenterClient.GetMuteConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetMuteConfigAsync</summary>
        public async Task GetMuteConfigRequestObjectAsync()
        {
            // Snippet: GetMuteConfigAsync(GetMuteConfigRequest, CallSettings)
            // Additional: GetMuteConfigAsync(GetMuteConfigRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetMuteConfigRequest request = new GetMuteConfigRequest
            {
                MuteConfigName = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]"),
            };
            // Make the request
            MuteConfig response = await securityCenterClient.GetMuteConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMuteConfig</summary>
        public void GetMuteConfig()
        {
            // Snippet: GetMuteConfig(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/muteConfigs/[MUTE_CONFIG]";
            // Make the request
            MuteConfig response = securityCenterClient.GetMuteConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetMuteConfigAsync</summary>
        public async Task GetMuteConfigAsync()
        {
            // Snippet: GetMuteConfigAsync(string, CallSettings)
            // Additional: GetMuteConfigAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/muteConfigs/[MUTE_CONFIG]";
            // Make the request
            MuteConfig response = await securityCenterClient.GetMuteConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMuteConfig</summary>
        public void GetMuteConfigResourceNames()
        {
            // Snippet: GetMuteConfig(MuteConfigName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            MuteConfigName name = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]");
            // Make the request
            MuteConfig response = securityCenterClient.GetMuteConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetMuteConfigAsync</summary>
        public async Task GetMuteConfigResourceNamesAsync()
        {
            // Snippet: GetMuteConfigAsync(MuteConfigName, CallSettings)
            // Additional: GetMuteConfigAsync(MuteConfigName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            MuteConfigName name = MuteConfigName.FromOrganizationMuteConfig("[ORGANIZATION]", "[MUTE_CONFIG]");
            // Make the request
            MuteConfig response = await securityCenterClient.GetMuteConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationConfig</summary>
        public void GetNotificationConfigRequestObject()
        {
            // Snippet: GetNotificationConfig(GetNotificationConfigRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            GetNotificationConfigRequest request = new GetNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationLocationNotificationConfig("[ORGANIZATION]", "[LOCATION]", "[NOTIFICATION_CONFIG]"),
            };
            // Make the request
            NotificationConfig response = securityCenterClient.GetNotificationConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationConfigAsync</summary>
        public async Task GetNotificationConfigRequestObjectAsync()
        {
            // Snippet: GetNotificationConfigAsync(GetNotificationConfigRequest, CallSettings)
            // Additional: GetNotificationConfigAsync(GetNotificationConfigRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetNotificationConfigRequest request = new GetNotificationConfigRequest
            {
                NotificationConfigName = NotificationConfigName.FromOrganizationLocationNotificationConfig("[ORGANIZATION]", "[LOCATION]", "[NOTIFICATION_CONFIG]"),
            };
            // Make the request
            NotificationConfig response = await securityCenterClient.GetNotificationConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationConfig</summary>
        public void GetNotificationConfig()
        {
            // Snippet: GetNotificationConfig(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/notificationConfigs/[NOTIFICATION_CONFIG]";
            // Make the request
            NotificationConfig response = securityCenterClient.GetNotificationConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationConfigAsync</summary>
        public async Task GetNotificationConfigAsync()
        {
            // Snippet: GetNotificationConfigAsync(string, CallSettings)
            // Additional: GetNotificationConfigAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/notificationConfigs/[NOTIFICATION_CONFIG]";
            // Make the request
            NotificationConfig response = await securityCenterClient.GetNotificationConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationConfig</summary>
        public void GetNotificationConfigResourceNames()
        {
            // Snippet: GetNotificationConfig(NotificationConfigName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            NotificationConfigName name = NotificationConfigName.FromOrganizationLocationNotificationConfig("[ORGANIZATION]", "[LOCATION]", "[NOTIFICATION_CONFIG]");
            // Make the request
            NotificationConfig response = securityCenterClient.GetNotificationConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationConfigAsync</summary>
        public async Task GetNotificationConfigResourceNamesAsync()
        {
            // Snippet: GetNotificationConfigAsync(NotificationConfigName, CallSettings)
            // Additional: GetNotificationConfigAsync(NotificationConfigName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            NotificationConfigName name = NotificationConfigName.FromOrganizationLocationNotificationConfig("[ORGANIZATION]", "[LOCATION]", "[NOTIFICATION_CONFIG]");
            // Make the request
            NotificationConfig response = await securityCenterClient.GetNotificationConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceValueConfig</summary>
        public void GetResourceValueConfigRequestObject()
        {
            // Snippet: GetResourceValueConfig(GetResourceValueConfigRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            GetResourceValueConfigRequest request = new GetResourceValueConfigRequest
            {
                ResourceValueConfigName = ResourceValueConfigName.FromOrganizationResourceValueConfig("[ORGANIZATION]", "[RESOURCE_VALUE_CONFIG]"),
            };
            // Make the request
            ResourceValueConfig response = securityCenterClient.GetResourceValueConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceValueConfigAsync</summary>
        public async Task GetResourceValueConfigRequestObjectAsync()
        {
            // Snippet: GetResourceValueConfigAsync(GetResourceValueConfigRequest, CallSettings)
            // Additional: GetResourceValueConfigAsync(GetResourceValueConfigRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetResourceValueConfigRequest request = new GetResourceValueConfigRequest
            {
                ResourceValueConfigName = ResourceValueConfigName.FromOrganizationResourceValueConfig("[ORGANIZATION]", "[RESOURCE_VALUE_CONFIG]"),
            };
            // Make the request
            ResourceValueConfig response = await securityCenterClient.GetResourceValueConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceValueConfig</summary>
        public void GetResourceValueConfig()
        {
            // Snippet: GetResourceValueConfig(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/resourceValueConfigs/[RESOURCE_VALUE_CONFIG]";
            // Make the request
            ResourceValueConfig response = securityCenterClient.GetResourceValueConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceValueConfigAsync</summary>
        public async Task GetResourceValueConfigAsync()
        {
            // Snippet: GetResourceValueConfigAsync(string, CallSettings)
            // Additional: GetResourceValueConfigAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/resourceValueConfigs/[RESOURCE_VALUE_CONFIG]";
            // Make the request
            ResourceValueConfig response = await securityCenterClient.GetResourceValueConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceValueConfig</summary>
        public void GetResourceValueConfigResourceNames()
        {
            // Snippet: GetResourceValueConfig(ResourceValueConfigName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ResourceValueConfigName name = ResourceValueConfigName.FromOrganizationResourceValueConfig("[ORGANIZATION]", "[RESOURCE_VALUE_CONFIG]");
            // Make the request
            ResourceValueConfig response = securityCenterClient.GetResourceValueConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceValueConfigAsync</summary>
        public async Task GetResourceValueConfigResourceNamesAsync()
        {
            // Snippet: GetResourceValueConfigAsync(ResourceValueConfigName, CallSettings)
            // Additional: GetResourceValueConfigAsync(ResourceValueConfigName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ResourceValueConfigName name = ResourceValueConfigName.FromOrganizationResourceValueConfig("[ORGANIZATION]", "[RESOURCE_VALUE_CONFIG]");
            // Make the request
            ResourceValueConfig response = await securityCenterClient.GetResourceValueConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSource</summary>
        public void GetSourceRequestObject()
        {
            // Snippet: GetSource(GetSourceRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
            };
            // Make the request
            Source response = securityCenterClient.GetSource(request);
            // End snippet
        }

        /// <summary>Snippet for GetSourceAsync</summary>
        public async Task GetSourceRequestObjectAsync()
        {
            // Snippet: GetSourceAsync(GetSourceRequest, CallSettings)
            // Additional: GetSourceAsync(GetSourceRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
            };
            // Make the request
            Source response = await securityCenterClient.GetSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSource</summary>
        public void GetSource()
        {
            // Snippet: GetSource(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/sources/[SOURCE]";
            // Make the request
            Source response = securityCenterClient.GetSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetSourceAsync</summary>
        public async Task GetSourceAsync()
        {
            // Snippet: GetSourceAsync(string, CallSettings)
            // Additional: GetSourceAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/sources/[SOURCE]";
            // Make the request
            Source response = await securityCenterClient.GetSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSource</summary>
        public void GetSourceResourceNames()
        {
            // Snippet: GetSource(SourceName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SourceName name = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            // Make the request
            Source response = securityCenterClient.GetSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetSourceAsync</summary>
        public async Task GetSourceResourceNamesAsync()
        {
            // Snippet: GetSourceAsync(SourceName, CallSettings)
            // Additional: GetSourceAsync(SourceName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SourceName name = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            // Make the request
            Source response = await securityCenterClient.GetSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GroupFindings</summary>
        public void GroupFindingsRequestObject()
        {
            // Snippet: GroupFindings(GroupFindingsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            GroupFindingsRequest request = new GroupFindingsRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                Filter = "",
                GroupBy = "",
            };
            // Make the request
            PagedEnumerable<GroupFindingsResponse, GroupResult> response = securityCenterClient.GroupFindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GroupResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (GroupFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GroupResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GroupResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GroupResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GroupFindingsAsync</summary>
        public async Task GroupFindingsRequestObjectAsync()
        {
            // Snippet: GroupFindingsAsync(GroupFindingsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            GroupFindingsRequest request = new GroupFindingsRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                Filter = "",
                GroupBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<GroupFindingsResponse, GroupResult> response = securityCenterClient.GroupFindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GroupResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((GroupFindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GroupResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GroupResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GroupResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GroupFindings</summary>
        public void GroupFindings()
        {
            // Snippet: GroupFindings(string, string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/sources/[SOURCE]";
            string groupBy = "";
            // Make the request
            PagedEnumerable<GroupFindingsResponse, GroupResult> response = securityCenterClient.GroupFindings(parent, groupBy);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GroupResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (GroupFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GroupResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GroupResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GroupResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GroupFindingsAsync</summary>
        public async Task GroupFindingsAsync()
        {
            // Snippet: GroupFindingsAsync(string, string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/sources/[SOURCE]";
            string groupBy = "";
            // Make the request
            PagedAsyncEnumerable<GroupFindingsResponse, GroupResult> response = securityCenterClient.GroupFindingsAsync(parent, groupBy);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GroupResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((GroupFindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GroupResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GroupResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GroupResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GroupFindings</summary>
        public void GroupFindingsResourceNames()
        {
            // Snippet: GroupFindings(SourceName, string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            string groupBy = "";
            // Make the request
            PagedEnumerable<GroupFindingsResponse, GroupResult> response = securityCenterClient.GroupFindings(parent, groupBy);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GroupResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (GroupFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GroupResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GroupResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GroupResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GroupFindingsAsync</summary>
        public async Task GroupFindingsResourceNamesAsync()
        {
            // Snippet: GroupFindingsAsync(SourceName, string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            string groupBy = "";
            // Make the request
            PagedAsyncEnumerable<GroupFindingsResponse, GroupResult> response = securityCenterClient.GroupFindingsAsync(parent, groupBy);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GroupResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((GroupFindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GroupResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GroupResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GroupResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttackPaths</summary>
        public void ListAttackPathsRequestObject()
        {
            // Snippet: ListAttackPaths(ListAttackPathsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ListAttackPathsRequest request = new ListAttackPathsRequest
            {
                ParentAsOrganizationValuedResourceName = OrganizationValuedResourceName.FromOrganizationLocationSimulationValuedResource("[ORGANIZATION]", "[LOCATION]", "[SIMULATION]", "[VALUED_RESOURCE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListAttackPathsResponse, AttackPath> response = securityCenterClient.ListAttackPaths(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AttackPath item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAttackPathsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AttackPath item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AttackPath> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AttackPath item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttackPathsAsync</summary>
        public async Task ListAttackPathsRequestObjectAsync()
        {
            // Snippet: ListAttackPathsAsync(ListAttackPathsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListAttackPathsRequest request = new ListAttackPathsRequest
            {
                ParentAsOrganizationValuedResourceName = OrganizationValuedResourceName.FromOrganizationLocationSimulationValuedResource("[ORGANIZATION]", "[LOCATION]", "[SIMULATION]", "[VALUED_RESOURCE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAttackPathsResponse, AttackPath> response = securityCenterClient.ListAttackPathsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AttackPath item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAttackPathsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AttackPath item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AttackPath> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AttackPath item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttackPaths</summary>
        public void ListAttackPaths()
        {
            // Snippet: ListAttackPaths(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]/simulations/[SIMULATION]/valuedResources/[VALUED_RESOURCE]";
            // Make the request
            PagedEnumerable<ListAttackPathsResponse, AttackPath> response = securityCenterClient.ListAttackPaths(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AttackPath item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAttackPathsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AttackPath item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AttackPath> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AttackPath item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttackPathsAsync</summary>
        public async Task ListAttackPathsAsync()
        {
            // Snippet: ListAttackPathsAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]/simulations/[SIMULATION]/valuedResources/[VALUED_RESOURCE]";
            // Make the request
            PagedAsyncEnumerable<ListAttackPathsResponse, AttackPath> response = securityCenterClient.ListAttackPathsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AttackPath item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAttackPathsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AttackPath item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AttackPath> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AttackPath item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttackPaths</summary>
        public void ListAttackPathsResourceNames1()
        {
            // Snippet: ListAttackPaths(OrganizationValuedResourceName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationValuedResourceName parent = OrganizationValuedResourceName.FromOrganizationLocationSimulationValuedResource("[ORGANIZATION]", "[LOCATION]", "[SIMULATION]", "[VALUED_RESOURCE]");
            // Make the request
            PagedEnumerable<ListAttackPathsResponse, AttackPath> response = securityCenterClient.ListAttackPaths(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AttackPath item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAttackPathsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AttackPath item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AttackPath> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AttackPath item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttackPathsAsync</summary>
        public async Task ListAttackPathsResourceNames1Async()
        {
            // Snippet: ListAttackPathsAsync(OrganizationValuedResourceName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationValuedResourceName parent = OrganizationValuedResourceName.FromOrganizationLocationSimulationValuedResource("[ORGANIZATION]", "[LOCATION]", "[SIMULATION]", "[VALUED_RESOURCE]");
            // Make the request
            PagedAsyncEnumerable<ListAttackPathsResponse, AttackPath> response = securityCenterClient.ListAttackPathsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AttackPath item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAttackPathsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AttackPath item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AttackPath> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AttackPath item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttackPaths</summary>
        public void ListAttackPathsResourceNames2()
        {
            // Snippet: ListAttackPaths(ValuedResourceName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ValuedResourceName parent = ValuedResourceName.FromOrganizationSimulationValuedResource("[ORGANIZATION]", "[SIMULATION]", "[VALUED_RESOURCE]");
            // Make the request
            PagedEnumerable<ListAttackPathsResponse, AttackPath> response = securityCenterClient.ListAttackPaths(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AttackPath item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAttackPathsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AttackPath item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AttackPath> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AttackPath item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttackPathsAsync</summary>
        public async Task ListAttackPathsResourceNames2Async()
        {
            // Snippet: ListAttackPathsAsync(ValuedResourceName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ValuedResourceName parent = ValuedResourceName.FromOrganizationSimulationValuedResource("[ORGANIZATION]", "[SIMULATION]", "[VALUED_RESOURCE]");
            // Make the request
            PagedAsyncEnumerable<ListAttackPathsResponse, AttackPath> response = securityCenterClient.ListAttackPathsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AttackPath item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAttackPathsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AttackPath item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AttackPath> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AttackPath item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryExports</summary>
        public void ListBigQueryExportsRequestObject()
        {
            // Snippet: ListBigQueryExports(ListBigQueryExportsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ListBigQueryExportsRequest request = new ListBigQueryExportsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListBigQueryExportsResponse, BigQueryExport> response = securityCenterClient.ListBigQueryExports(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BigQueryExport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBigQueryExportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryExport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryExportsAsync</summary>
        public async Task ListBigQueryExportsRequestObjectAsync()
        {
            // Snippet: ListBigQueryExportsAsync(ListBigQueryExportsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListBigQueryExportsRequest request = new ListBigQueryExportsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListBigQueryExportsResponse, BigQueryExport> response = securityCenterClient.ListBigQueryExportsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BigQueryExport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBigQueryExportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryExport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryExports</summary>
        public void ListBigQueryExports()
        {
            // Snippet: ListBigQueryExports(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBigQueryExportsResponse, BigQueryExport> response = securityCenterClient.ListBigQueryExports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BigQueryExport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBigQueryExportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryExport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryExportsAsync</summary>
        public async Task ListBigQueryExportsAsync()
        {
            // Snippet: ListBigQueryExportsAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBigQueryExportsResponse, BigQueryExport> response = securityCenterClient.ListBigQueryExportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BigQueryExport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBigQueryExportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryExport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryExports</summary>
        public void ListBigQueryExportsResourceNames1()
        {
            // Snippet: ListBigQueryExports(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBigQueryExportsResponse, BigQueryExport> response = securityCenterClient.ListBigQueryExports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BigQueryExport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBigQueryExportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryExport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryExportsAsync</summary>
        public async Task ListBigQueryExportsResourceNames1Async()
        {
            // Snippet: ListBigQueryExportsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBigQueryExportsResponse, BigQueryExport> response = securityCenterClient.ListBigQueryExportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BigQueryExport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBigQueryExportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryExport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryExports</summary>
        public void ListBigQueryExportsResourceNames2()
        {
            // Snippet: ListBigQueryExports(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBigQueryExportsResponse, BigQueryExport> response = securityCenterClient.ListBigQueryExports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BigQueryExport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBigQueryExportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryExport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryExportsAsync</summary>
        public async Task ListBigQueryExportsResourceNames2Async()
        {
            // Snippet: ListBigQueryExportsAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBigQueryExportsResponse, BigQueryExport> response = securityCenterClient.ListBigQueryExportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BigQueryExport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBigQueryExportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryExport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryExports</summary>
        public void ListBigQueryExportsResourceNames3()
        {
            // Snippet: ListBigQueryExports(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBigQueryExportsResponse, BigQueryExport> response = securityCenterClient.ListBigQueryExports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BigQueryExport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBigQueryExportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryExport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryExportsAsync</summary>
        public async Task ListBigQueryExportsResourceNames3Async()
        {
            // Snippet: ListBigQueryExportsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBigQueryExportsResponse, BigQueryExport> response = securityCenterClient.ListBigQueryExportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BigQueryExport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBigQueryExportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryExport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindings</summary>
        public void ListFindingsRequestObject()
        {
            // Snippet: ListFindings(ListFindingsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ListFindingsRequest request = new ListFindingsRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                Filter = "",
                OrderBy = "",
                FieldMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> response = securityCenterClient.ListFindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ListFindingsResponse.Types.ListFindingsResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListFindingsResponse.Types.ListFindingsResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListFindingsResponse.Types.ListFindingsResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListFindingsResponse.Types.ListFindingsResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsAsync</summary>
        public async Task ListFindingsRequestObjectAsync()
        {
            // Snippet: ListFindingsAsync(ListFindingsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListFindingsRequest request = new ListFindingsRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                Filter = "",
                OrderBy = "",
                FieldMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> response = securityCenterClient.ListFindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ListFindingsResponse.Types.ListFindingsResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListFindingsResponse.Types.ListFindingsResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListFindingsResponse.Types.ListFindingsResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListFindingsResponse.Types.ListFindingsResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindings</summary>
        public void ListFindings()
        {
            // Snippet: ListFindings(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/sources/[SOURCE]";
            // Make the request
            PagedEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> response = securityCenterClient.ListFindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ListFindingsResponse.Types.ListFindingsResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListFindingsResponse.Types.ListFindingsResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListFindingsResponse.Types.ListFindingsResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListFindingsResponse.Types.ListFindingsResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsAsync</summary>
        public async Task ListFindingsAsync()
        {
            // Snippet: ListFindingsAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/sources/[SOURCE]";
            // Make the request
            PagedAsyncEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> response = securityCenterClient.ListFindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ListFindingsResponse.Types.ListFindingsResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListFindingsResponse.Types.ListFindingsResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListFindingsResponse.Types.ListFindingsResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListFindingsResponse.Types.ListFindingsResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindings</summary>
        public void ListFindingsResourceNames()
        {
            // Snippet: ListFindings(SourceName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            // Make the request
            PagedEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> response = securityCenterClient.ListFindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ListFindingsResponse.Types.ListFindingsResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListFindingsResponse.Types.ListFindingsResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListFindingsResponse.Types.ListFindingsResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListFindingsResponse.Types.ListFindingsResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsAsync</summary>
        public async Task ListFindingsResourceNamesAsync()
        {
            // Snippet: ListFindingsAsync(SourceName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            // Make the request
            PagedAsyncEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> response = securityCenterClient.ListFindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ListFindingsResponse.Types.ListFindingsResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListFindingsResponse.Types.ListFindingsResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListFindingsResponse.Types.ListFindingsResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListFindingsResponse.Types.ListFindingsResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigs</summary>
        public void ListMuteConfigsRequestObject()
        {
            // Snippet: ListMuteConfigs(ListMuteConfigsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MuteConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMuteConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigsAsync</summary>
        public async Task ListMuteConfigsRequestObjectAsync()
        {
            // Snippet: ListMuteConfigsAsync(ListMuteConfigsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MuteConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMuteConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigs</summary>
        public void ListMuteConfigs()
        {
            // Snippet: ListMuteConfigs(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MuteConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMuteConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigsAsync</summary>
        public async Task ListMuteConfigsAsync()
        {
            // Snippet: ListMuteConfigsAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MuteConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMuteConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigs</summary>
        public void ListMuteConfigsResourceNames1()
        {
            // Snippet: ListMuteConfigs(OrganizationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MuteConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMuteConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigsAsync</summary>
        public async Task ListMuteConfigsResourceNames1Async()
        {
            // Snippet: ListMuteConfigsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MuteConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMuteConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigs</summary>
        public void ListMuteConfigsResourceNames2()
        {
            // Snippet: ListMuteConfigs(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MuteConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMuteConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigsAsync</summary>
        public async Task ListMuteConfigsResourceNames2Async()
        {
            // Snippet: ListMuteConfigsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MuteConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMuteConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigs</summary>
        public void ListMuteConfigsResourceNames3()
        {
            // Snippet: ListMuteConfigs(FolderName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MuteConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMuteConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigsAsync</summary>
        public async Task ListMuteConfigsResourceNames3Async()
        {
            // Snippet: ListMuteConfigsAsync(FolderName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MuteConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMuteConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigs</summary>
        public void ListMuteConfigsResourceNames4()
        {
            // Snippet: ListMuteConfigs(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MuteConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMuteConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigsAsync</summary>
        public async Task ListMuteConfigsResourceNames4Async()
        {
            // Snippet: ListMuteConfigsAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MuteConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMuteConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigs</summary>
        public void ListMuteConfigsResourceNames5()
        {
            // Snippet: ListMuteConfigs(ProjectName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MuteConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMuteConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigsAsync</summary>
        public async Task ListMuteConfigsResourceNames5Async()
        {
            // Snippet: ListMuteConfigsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MuteConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMuteConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigs</summary>
        public void ListMuteConfigsResourceNames6()
        {
            // Snippet: ListMuteConfigs(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MuteConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMuteConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMuteConfigsAsync</summary>
        public async Task ListMuteConfigsResourceNames6Async()
        {
            // Snippet: ListMuteConfigsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> response = securityCenterClient.ListMuteConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MuteConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMuteConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MuteConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MuteConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MuteConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationConfigs</summary>
        public void ListNotificationConfigsRequestObject()
        {
            // Snippet: ListNotificationConfigs(ListNotificationConfigsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ListNotificationConfigsRequest request = new ListNotificationConfigsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> response = securityCenterClient.ListNotificationConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationConfigsAsync</summary>
        public async Task ListNotificationConfigsRequestObjectAsync()
        {
            // Snippet: ListNotificationConfigsAsync(ListNotificationConfigsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListNotificationConfigsRequest request = new ListNotificationConfigsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> response = securityCenterClient.ListNotificationConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationConfigs</summary>
        public void ListNotificationConfigs()
        {
            // Snippet: ListNotificationConfigs(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> response = securityCenterClient.ListNotificationConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationConfigsAsync</summary>
        public async Task ListNotificationConfigsAsync()
        {
            // Snippet: ListNotificationConfigsAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> response = securityCenterClient.ListNotificationConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationConfigs</summary>
        public void ListNotificationConfigsResourceNames1()
        {
            // Snippet: ListNotificationConfigs(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> response = securityCenterClient.ListNotificationConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationConfigsAsync</summary>
        public async Task ListNotificationConfigsResourceNames1Async()
        {
            // Snippet: ListNotificationConfigsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> response = securityCenterClient.ListNotificationConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationConfigs</summary>
        public void ListNotificationConfigsResourceNames2()
        {
            // Snippet: ListNotificationConfigs(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> response = securityCenterClient.ListNotificationConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationConfigsAsync</summary>
        public async Task ListNotificationConfigsResourceNames2Async()
        {
            // Snippet: ListNotificationConfigsAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> response = securityCenterClient.ListNotificationConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationConfigs</summary>
        public void ListNotificationConfigsResourceNames3()
        {
            // Snippet: ListNotificationConfigs(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> response = securityCenterClient.ListNotificationConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationConfigsAsync</summary>
        public async Task ListNotificationConfigsResourceNames3Async()
        {
            // Snippet: ListNotificationConfigsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> response = securityCenterClient.ListNotificationConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceValueConfigs</summary>
        public void ListResourceValueConfigsRequestObject()
        {
            // Snippet: ListResourceValueConfigs(ListResourceValueConfigsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ListResourceValueConfigsRequest request = new ListResourceValueConfigsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> response = securityCenterClient.ListResourceValueConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceValueConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceValueConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceValueConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceValueConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceValueConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceValueConfigsAsync</summary>
        public async Task ListResourceValueConfigsRequestObjectAsync()
        {
            // Snippet: ListResourceValueConfigsAsync(ListResourceValueConfigsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListResourceValueConfigsRequest request = new ListResourceValueConfigsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> response = securityCenterClient.ListResourceValueConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResourceValueConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListResourceValueConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceValueConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceValueConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceValueConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceValueConfigs</summary>
        public void ListResourceValueConfigs()
        {
            // Snippet: ListResourceValueConfigs(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> response = securityCenterClient.ListResourceValueConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceValueConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceValueConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceValueConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceValueConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceValueConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceValueConfigsAsync</summary>
        public async Task ListResourceValueConfigsAsync()
        {
            // Snippet: ListResourceValueConfigsAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> response = securityCenterClient.ListResourceValueConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResourceValueConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListResourceValueConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceValueConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceValueConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceValueConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceValueConfigs</summary>
        public void ListResourceValueConfigsResourceNames1()
        {
            // Snippet: ListResourceValueConfigs(OrganizationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> response = securityCenterClient.ListResourceValueConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceValueConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceValueConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceValueConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceValueConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceValueConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceValueConfigsAsync</summary>
        public async Task ListResourceValueConfigsResourceNames1Async()
        {
            // Snippet: ListResourceValueConfigsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> response = securityCenterClient.ListResourceValueConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResourceValueConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListResourceValueConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceValueConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceValueConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceValueConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceValueConfigs</summary>
        public void ListResourceValueConfigsResourceNames2()
        {
            // Snippet: ListResourceValueConfigs(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> response = securityCenterClient.ListResourceValueConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceValueConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceValueConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceValueConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceValueConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceValueConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceValueConfigsAsync</summary>
        public async Task ListResourceValueConfigsResourceNames2Async()
        {
            // Snippet: ListResourceValueConfigsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> response = securityCenterClient.ListResourceValueConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResourceValueConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListResourceValueConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceValueConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceValueConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceValueConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public void ListSourcesRequestObject()
        {
            // Snippet: ListSources(ListSourcesRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ListSourcesRequest request = new ListSourcesRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Source item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSourcesAsync</summary>
        public async Task ListSourcesRequestObjectAsync()
        {
            // Snippet: ListSourcesAsync(ListSourcesRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListSourcesRequest request = new ListSourcesRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Source item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public void ListSources()
        {
            // Snippet: ListSources(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Source item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSourcesAsync</summary>
        public async Task ListSourcesAsync()
        {
            // Snippet: ListSourcesAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Source item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public void ListSourcesResourceNames1()
        {
            // Snippet: ListSources(OrganizationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Source item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSourcesAsync</summary>
        public async Task ListSourcesResourceNames1Async()
        {
            // Snippet: ListSourcesAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Source item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public void ListSourcesResourceNames2()
        {
            // Snippet: ListSources(FolderName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Source item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSourcesAsync</summary>
        public async Task ListSourcesResourceNames2Async()
        {
            // Snippet: ListSourcesAsync(FolderName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Source item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public void ListSourcesResourceNames3()
        {
            // Snippet: ListSources(ProjectName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Source item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSourcesAsync</summary>
        public async Task ListSourcesResourceNames3Async()
        {
            // Snippet: ListSourcesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Source item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListValuedResources</summary>
        public void ListValuedResourcesRequestObject()
        {
            // Snippet: ListValuedResources(ListValuedResourcesRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ListValuedResourcesRequest request = new ListValuedResourcesRequest
            {
                ParentAsSimulationName = SimulationName.FromOrganizationSimulation("[ORGANIZATION]", "[SIMULATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListValuedResourcesResponse, ValuedResource> response = securityCenterClient.ListValuedResources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ValuedResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListValuedResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ValuedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ValuedResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ValuedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListValuedResourcesAsync</summary>
        public async Task ListValuedResourcesRequestObjectAsync()
        {
            // Snippet: ListValuedResourcesAsync(ListValuedResourcesRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListValuedResourcesRequest request = new ListValuedResourcesRequest
            {
                ParentAsSimulationName = SimulationName.FromOrganizationSimulation("[ORGANIZATION]", "[SIMULATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListValuedResourcesResponse, ValuedResource> response = securityCenterClient.ListValuedResourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ValuedResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListValuedResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ValuedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ValuedResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ValuedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListValuedResources</summary>
        public void ListValuedResources()
        {
            // Snippet: ListValuedResources(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/simulations/[SIMULATION]";
            // Make the request
            PagedEnumerable<ListValuedResourcesResponse, ValuedResource> response = securityCenterClient.ListValuedResources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ValuedResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListValuedResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ValuedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ValuedResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ValuedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListValuedResourcesAsync</summary>
        public async Task ListValuedResourcesAsync()
        {
            // Snippet: ListValuedResourcesAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/simulations/[SIMULATION]";
            // Make the request
            PagedAsyncEnumerable<ListValuedResourcesResponse, ValuedResource> response = securityCenterClient.ListValuedResourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ValuedResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListValuedResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ValuedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ValuedResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ValuedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListValuedResources</summary>
        public void ListValuedResourcesResourceNames()
        {
            // Snippet: ListValuedResources(SimulationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SimulationName parent = SimulationName.FromOrganizationSimulation("[ORGANIZATION]", "[SIMULATION]");
            // Make the request
            PagedEnumerable<ListValuedResourcesResponse, ValuedResource> response = securityCenterClient.ListValuedResources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ValuedResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListValuedResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ValuedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ValuedResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ValuedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListValuedResourcesAsync</summary>
        public async Task ListValuedResourcesResourceNamesAsync()
        {
            // Snippet: ListValuedResourcesAsync(SimulationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SimulationName parent = SimulationName.FromOrganizationSimulation("[ORGANIZATION]", "[SIMULATION]");
            // Make the request
            PagedAsyncEnumerable<ListValuedResourcesResponse, ValuedResource> response = securityCenterClient.ListValuedResourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ValuedResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListValuedResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ValuedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ValuedResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ValuedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SetFindingState</summary>
        public void SetFindingStateRequestObject()
        {
            // Snippet: SetFindingState(SetFindingStateRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SetFindingStateRequest request = new SetFindingStateRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                State = Finding.Types.State.Unspecified,
            };
            // Make the request
            Finding response = securityCenterClient.SetFindingState(request);
            // End snippet
        }

        /// <summary>Snippet for SetFindingStateAsync</summary>
        public async Task SetFindingStateRequestObjectAsync()
        {
            // Snippet: SetFindingStateAsync(SetFindingStateRequest, CallSettings)
            // Additional: SetFindingStateAsync(SetFindingStateRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SetFindingStateRequest request = new SetFindingStateRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                State = Finding.Types.State.Unspecified,
            };
            // Make the request
            Finding response = await securityCenterClient.SetFindingStateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetFindingState</summary>
        public void SetFindingState()
        {
            // Snippet: SetFindingState(string, Finding.Types.State, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/sources/[SOURCE]/findings/[FINDING]";
            Finding.Types.State state = Finding.Types.State.Unspecified;
            // Make the request
            Finding response = securityCenterClient.SetFindingState(name, state);
            // End snippet
        }

        /// <summary>Snippet for SetFindingStateAsync</summary>
        public async Task SetFindingStateAsync()
        {
            // Snippet: SetFindingStateAsync(string, Finding.Types.State, CallSettings)
            // Additional: SetFindingStateAsync(string, Finding.Types.State, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/sources/[SOURCE]/findings/[FINDING]";
            Finding.Types.State state = Finding.Types.State.Unspecified;
            // Make the request
            Finding response = await securityCenterClient.SetFindingStateAsync(name, state);
            // End snippet
        }

        /// <summary>Snippet for SetFindingState</summary>
        public void SetFindingStateResourceNames()
        {
            // Snippet: SetFindingState(FindingName, Finding.Types.State, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            FindingName name = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]");
            Finding.Types.State state = Finding.Types.State.Unspecified;
            // Make the request
            Finding response = securityCenterClient.SetFindingState(name, state);
            // End snippet
        }

        /// <summary>Snippet for SetFindingStateAsync</summary>
        public async Task SetFindingStateResourceNamesAsync()
        {
            // Snippet: SetFindingStateAsync(FindingName, Finding.Types.State, CallSettings)
            // Additional: SetFindingStateAsync(FindingName, Finding.Types.State, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            FindingName name = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]");
            Finding.Types.State state = Finding.Types.State.Unspecified;
            // Make the request
            Finding response = await securityCenterClient.SetFindingStateAsync(name, state);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = securityCenterClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await securityCenterClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = securityCenterClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await securityCenterClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = securityCenterClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await securityCenterClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetMute</summary>
        public void SetMuteRequestObject()
        {
            // Snippet: SetMute(SetMuteRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SetMuteRequest request = new SetMuteRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Mute = Finding.Types.Mute.Unspecified,
            };
            // Make the request
            Finding response = securityCenterClient.SetMute(request);
            // End snippet
        }

        /// <summary>Snippet for SetMuteAsync</summary>
        public async Task SetMuteRequestObjectAsync()
        {
            // Snippet: SetMuteAsync(SetMuteRequest, CallSettings)
            // Additional: SetMuteAsync(SetMuteRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SetMuteRequest request = new SetMuteRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Mute = Finding.Types.Mute.Unspecified,
            };
            // Make the request
            Finding response = await securityCenterClient.SetMuteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetMute</summary>
        public void SetMute()
        {
            // Snippet: SetMute(string, Finding.Types.Mute, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/sources/[SOURCE]/findings/[FINDING]";
            Finding.Types.Mute mute = Finding.Types.Mute.Unspecified;
            // Make the request
            Finding response = securityCenterClient.SetMute(name, mute);
            // End snippet
        }

        /// <summary>Snippet for SetMuteAsync</summary>
        public async Task SetMuteAsync()
        {
            // Snippet: SetMuteAsync(string, Finding.Types.Mute, CallSettings)
            // Additional: SetMuteAsync(string, Finding.Types.Mute, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/sources/[SOURCE]/findings/[FINDING]";
            Finding.Types.Mute mute = Finding.Types.Mute.Unspecified;
            // Make the request
            Finding response = await securityCenterClient.SetMuteAsync(name, mute);
            // End snippet
        }

        /// <summary>Snippet for SetMute</summary>
        public void SetMuteResourceNames()
        {
            // Snippet: SetMute(FindingName, Finding.Types.Mute, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            FindingName name = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]");
            Finding.Types.Mute mute = Finding.Types.Mute.Unspecified;
            // Make the request
            Finding response = securityCenterClient.SetMute(name, mute);
            // End snippet
        }

        /// <summary>Snippet for SetMuteAsync</summary>
        public async Task SetMuteResourceNamesAsync()
        {
            // Snippet: SetMuteAsync(FindingName, Finding.Types.Mute, CallSettings)
            // Additional: SetMuteAsync(FindingName, Finding.Types.Mute, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            FindingName name = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]");
            Finding.Types.Mute mute = Finding.Types.Mute.Unspecified;
            // Make the request
            Finding response = await securityCenterClient.SetMuteAsync(name, mute);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = securityCenterClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await securityCenterClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = securityCenterClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await securityCenterClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = securityCenterClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await securityCenterClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for UpdateBigQueryExport</summary>
        public void UpdateBigQueryExportRequestObject()
        {
            // Snippet: UpdateBigQueryExport(UpdateBigQueryExportRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            UpdateBigQueryExportRequest request = new UpdateBigQueryExportRequest
            {
                BigQueryExport = new BigQueryExport(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BigQueryExport response = securityCenterClient.UpdateBigQueryExport(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBigQueryExportAsync</summary>
        public async Task UpdateBigQueryExportRequestObjectAsync()
        {
            // Snippet: UpdateBigQueryExportAsync(UpdateBigQueryExportRequest, CallSettings)
            // Additional: UpdateBigQueryExportAsync(UpdateBigQueryExportRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBigQueryExportRequest request = new UpdateBigQueryExportRequest
            {
                BigQueryExport = new BigQueryExport(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BigQueryExport response = await securityCenterClient.UpdateBigQueryExportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBigQueryExport</summary>
        public void UpdateBigQueryExport()
        {
            // Snippet: UpdateBigQueryExport(BigQueryExport, FieldMask, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            BigQueryExport bigQueryExport = new BigQueryExport();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BigQueryExport response = securityCenterClient.UpdateBigQueryExport(bigQueryExport, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateBigQueryExportAsync</summary>
        public async Task UpdateBigQueryExportAsync()
        {
            // Snippet: UpdateBigQueryExportAsync(BigQueryExport, FieldMask, CallSettings)
            // Additional: UpdateBigQueryExportAsync(BigQueryExport, FieldMask, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            BigQueryExport bigQueryExport = new BigQueryExport();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BigQueryExport response = await securityCenterClient.UpdateBigQueryExportAsync(bigQueryExport, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalSystem</summary>
        public void UpdateExternalSystemRequestObject()
        {
            // Snippet: UpdateExternalSystem(UpdateExternalSystemRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            UpdateExternalSystemRequest request = new UpdateExternalSystemRequest
            {
                ExternalSystem = new ExternalSystem(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ExternalSystem response = securityCenterClient.UpdateExternalSystem(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalSystemAsync</summary>
        public async Task UpdateExternalSystemRequestObjectAsync()
        {
            // Snippet: UpdateExternalSystemAsync(UpdateExternalSystemRequest, CallSettings)
            // Additional: UpdateExternalSystemAsync(UpdateExternalSystemRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateExternalSystemRequest request = new UpdateExternalSystemRequest
            {
                ExternalSystem = new ExternalSystem(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ExternalSystem response = await securityCenterClient.UpdateExternalSystemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalSystem</summary>
        public void UpdateExternalSystem()
        {
            // Snippet: UpdateExternalSystem(ExternalSystem, FieldMask, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ExternalSystem externalSystem = new ExternalSystem();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ExternalSystem response = securityCenterClient.UpdateExternalSystem(externalSystem, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalSystemAsync</summary>
        public async Task UpdateExternalSystemAsync()
        {
            // Snippet: UpdateExternalSystemAsync(ExternalSystem, FieldMask, CallSettings)
            // Additional: UpdateExternalSystemAsync(ExternalSystem, FieldMask, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ExternalSystem externalSystem = new ExternalSystem();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ExternalSystem response = await securityCenterClient.UpdateExternalSystemAsync(externalSystem, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFinding</summary>
        public void UpdateFindingRequestObject()
        {
            // Snippet: UpdateFinding(UpdateFindingRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            UpdateFindingRequest request = new UpdateFindingRequest
            {
                Finding = new Finding(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Finding response = securityCenterClient.UpdateFinding(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFindingAsync</summary>
        public async Task UpdateFindingRequestObjectAsync()
        {
            // Snippet: UpdateFindingAsync(UpdateFindingRequest, CallSettings)
            // Additional: UpdateFindingAsync(UpdateFindingRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFindingRequest request = new UpdateFindingRequest
            {
                Finding = new Finding(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Finding response = await securityCenterClient.UpdateFindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFinding</summary>
        public void UpdateFinding()
        {
            // Snippet: UpdateFinding(Finding, FieldMask, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            Finding finding = new Finding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Finding response = securityCenterClient.UpdateFinding(finding, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFindingAsync</summary>
        public async Task UpdateFindingAsync()
        {
            // Snippet: UpdateFindingAsync(Finding, FieldMask, CallSettings)
            // Additional: UpdateFindingAsync(Finding, FieldMask, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            Finding finding = new Finding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Finding response = await securityCenterClient.UpdateFindingAsync(finding, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateMuteConfig</summary>
        public void UpdateMuteConfigRequestObject()
        {
            // Snippet: UpdateMuteConfig(UpdateMuteConfigRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            UpdateMuteConfigRequest request = new UpdateMuteConfigRequest
            {
                MuteConfig = new MuteConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            MuteConfig response = securityCenterClient.UpdateMuteConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMuteConfigAsync</summary>
        public async Task UpdateMuteConfigRequestObjectAsync()
        {
            // Snippet: UpdateMuteConfigAsync(UpdateMuteConfigRequest, CallSettings)
            // Additional: UpdateMuteConfigAsync(UpdateMuteConfigRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMuteConfigRequest request = new UpdateMuteConfigRequest
            {
                MuteConfig = new MuteConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            MuteConfig response = await securityCenterClient.UpdateMuteConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMuteConfig</summary>
        public void UpdateMuteConfig()
        {
            // Snippet: UpdateMuteConfig(MuteConfig, FieldMask, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            MuteConfig muteConfig = new MuteConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            MuteConfig response = securityCenterClient.UpdateMuteConfig(muteConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateMuteConfigAsync</summary>
        public async Task UpdateMuteConfigAsync()
        {
            // Snippet: UpdateMuteConfigAsync(MuteConfig, FieldMask, CallSettings)
            // Additional: UpdateMuteConfigAsync(MuteConfig, FieldMask, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            MuteConfig muteConfig = new MuteConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            MuteConfig response = await securityCenterClient.UpdateMuteConfigAsync(muteConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationConfig</summary>
        public void UpdateNotificationConfigRequestObject()
        {
            // Snippet: UpdateNotificationConfig(UpdateNotificationConfigRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            UpdateNotificationConfigRequest request = new UpdateNotificationConfigRequest
            {
                NotificationConfig = new NotificationConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            NotificationConfig response = securityCenterClient.UpdateNotificationConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationConfigAsync</summary>
        public async Task UpdateNotificationConfigRequestObjectAsync()
        {
            // Snippet: UpdateNotificationConfigAsync(UpdateNotificationConfigRequest, CallSettings)
            // Additional: UpdateNotificationConfigAsync(UpdateNotificationConfigRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNotificationConfigRequest request = new UpdateNotificationConfigRequest
            {
                NotificationConfig = new NotificationConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            NotificationConfig response = await securityCenterClient.UpdateNotificationConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationConfig</summary>
        public void UpdateNotificationConfig()
        {
            // Snippet: UpdateNotificationConfig(NotificationConfig, FieldMask, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            NotificationConfig notificationConfig = new NotificationConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            NotificationConfig response = securityCenterClient.UpdateNotificationConfig(notificationConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationConfigAsync</summary>
        public async Task UpdateNotificationConfigAsync()
        {
            // Snippet: UpdateNotificationConfigAsync(NotificationConfig, FieldMask, CallSettings)
            // Additional: UpdateNotificationConfigAsync(NotificationConfig, FieldMask, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            NotificationConfig notificationConfig = new NotificationConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            NotificationConfig response = await securityCenterClient.UpdateNotificationConfigAsync(notificationConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateResourceValueConfig</summary>
        public void UpdateResourceValueConfigRequestObject()
        {
            // Snippet: UpdateResourceValueConfig(UpdateResourceValueConfigRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            UpdateResourceValueConfigRequest request = new UpdateResourceValueConfigRequest
            {
                ResourceValueConfig = new ResourceValueConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ResourceValueConfig response = securityCenterClient.UpdateResourceValueConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateResourceValueConfigAsync</summary>
        public async Task UpdateResourceValueConfigRequestObjectAsync()
        {
            // Snippet: UpdateResourceValueConfigAsync(UpdateResourceValueConfigRequest, CallSettings)
            // Additional: UpdateResourceValueConfigAsync(UpdateResourceValueConfigRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateResourceValueConfigRequest request = new UpdateResourceValueConfigRequest
            {
                ResourceValueConfig = new ResourceValueConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ResourceValueConfig response = await securityCenterClient.UpdateResourceValueConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateResourceValueConfig</summary>
        public void UpdateResourceValueConfig()
        {
            // Snippet: UpdateResourceValueConfig(ResourceValueConfig, FieldMask, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ResourceValueConfig resourceValueConfig = new ResourceValueConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ResourceValueConfig response = securityCenterClient.UpdateResourceValueConfig(resourceValueConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateResourceValueConfigAsync</summary>
        public async Task UpdateResourceValueConfigAsync()
        {
            // Snippet: UpdateResourceValueConfigAsync(ResourceValueConfig, FieldMask, CallSettings)
            // Additional: UpdateResourceValueConfigAsync(ResourceValueConfig, FieldMask, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ResourceValueConfig resourceValueConfig = new ResourceValueConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ResourceValueConfig response = await securityCenterClient.UpdateResourceValueConfigAsync(resourceValueConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityMarks</summary>
        public void UpdateSecurityMarksRequestObject()
        {
            // Snippet: UpdateSecurityMarks(UpdateSecurityMarksRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            UpdateSecurityMarksRequest request = new UpdateSecurityMarksRequest
            {
                SecurityMarks = new SecurityMarks(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SecurityMarks response = securityCenterClient.UpdateSecurityMarks(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityMarksAsync</summary>
        public async Task UpdateSecurityMarksRequestObjectAsync()
        {
            // Snippet: UpdateSecurityMarksAsync(UpdateSecurityMarksRequest, CallSettings)
            // Additional: UpdateSecurityMarksAsync(UpdateSecurityMarksRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSecurityMarksRequest request = new UpdateSecurityMarksRequest
            {
                SecurityMarks = new SecurityMarks(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SecurityMarks response = await securityCenterClient.UpdateSecurityMarksAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityMarks</summary>
        public void UpdateSecurityMarks()
        {
            // Snippet: UpdateSecurityMarks(SecurityMarks, FieldMask, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SecurityMarks securityMarks = new SecurityMarks();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SecurityMarks response = securityCenterClient.UpdateSecurityMarks(securityMarks, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityMarksAsync</summary>
        public async Task UpdateSecurityMarksAsync()
        {
            // Snippet: UpdateSecurityMarksAsync(SecurityMarks, FieldMask, CallSettings)
            // Additional: UpdateSecurityMarksAsync(SecurityMarks, FieldMask, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SecurityMarks securityMarks = new SecurityMarks();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SecurityMarks response = await securityCenterClient.UpdateSecurityMarksAsync(securityMarks, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSource</summary>
        public void UpdateSourceRequestObject()
        {
            // Snippet: UpdateSource(UpdateSourceRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            UpdateSourceRequest request = new UpdateSourceRequest
            {
                Source = new Source(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Source response = securityCenterClient.UpdateSource(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSourceAsync</summary>
        public async Task UpdateSourceRequestObjectAsync()
        {
            // Snippet: UpdateSourceAsync(UpdateSourceRequest, CallSettings)
            // Additional: UpdateSourceAsync(UpdateSourceRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSourceRequest request = new UpdateSourceRequest
            {
                Source = new Source(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Source response = await securityCenterClient.UpdateSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSource</summary>
        public void UpdateSource()
        {
            // Snippet: UpdateSource(Source, FieldMask, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            Source source = new Source();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Source response = securityCenterClient.UpdateSource(source, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSourceAsync</summary>
        public async Task UpdateSourceAsync()
        {
            // Snippet: UpdateSourceAsync(Source, FieldMask, CallSettings)
            // Additional: UpdateSourceAsync(Source, FieldMask, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            Source source = new Source();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Source response = await securityCenterClient.UpdateSourceAsync(source, updateMask);
            // End snippet
        }
    }
}
