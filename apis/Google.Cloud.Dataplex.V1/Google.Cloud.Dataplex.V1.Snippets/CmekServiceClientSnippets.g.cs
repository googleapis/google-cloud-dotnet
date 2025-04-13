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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCmekServiceClientSnippets
    {
        /// <summary>Snippet for CreateEncryptionConfig</summary>
        public void CreateEncryptionConfigRequestObject()
        {
            // Snippet: CreateEncryptionConfig(CreateEncryptionConfigRequest, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = gcdv::CmekServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateEncryptionConfigRequest request = new gcdv::CreateEncryptionConfigRequest
            {
                ParentAsOrganizationLocationName = gcdv::OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                EncryptionConfigId = "",
                EncryptionConfig = new gcdv::EncryptionConfig(),
            };
            // Make the request
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> response = cmekServiceClient.CreateEncryptionConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EncryptionConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> retrievedResponse = cmekServiceClient.PollOnceCreateEncryptionConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EncryptionConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEncryptionConfigAsync</summary>
        public async Task CreateEncryptionConfigRequestObjectAsync()
        {
            // Snippet: CreateEncryptionConfigAsync(CreateEncryptionConfigRequest, CallSettings)
            // Additional: CreateEncryptionConfigAsync(CreateEncryptionConfigRequest, CancellationToken)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = await gcdv::CmekServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateEncryptionConfigRequest request = new gcdv::CreateEncryptionConfigRequest
            {
                ParentAsOrganizationLocationName = gcdv::OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                EncryptionConfigId = "",
                EncryptionConfig = new gcdv::EncryptionConfig(),
            };
            // Make the request
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> response = await cmekServiceClient.CreateEncryptionConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EncryptionConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> retrievedResponse = await cmekServiceClient.PollOnceCreateEncryptionConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EncryptionConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEncryptionConfig</summary>
        public void CreateEncryptionConfig()
        {
            // Snippet: CreateEncryptionConfig(string, EncryptionConfig, string, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = gcdv::CmekServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            gcdv::EncryptionConfig encryptionConfig = new gcdv::EncryptionConfig();
            string encryptionConfigId = "";
            // Make the request
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> response = cmekServiceClient.CreateEncryptionConfig(parent, encryptionConfig, encryptionConfigId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EncryptionConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> retrievedResponse = cmekServiceClient.PollOnceCreateEncryptionConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EncryptionConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEncryptionConfigAsync</summary>
        public async Task CreateEncryptionConfigAsync()
        {
            // Snippet: CreateEncryptionConfigAsync(string, EncryptionConfig, string, CallSettings)
            // Additional: CreateEncryptionConfigAsync(string, EncryptionConfig, string, CancellationToken)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = await gcdv::CmekServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            gcdv::EncryptionConfig encryptionConfig = new gcdv::EncryptionConfig();
            string encryptionConfigId = "";
            // Make the request
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> response = await cmekServiceClient.CreateEncryptionConfigAsync(parent, encryptionConfig, encryptionConfigId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EncryptionConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> retrievedResponse = await cmekServiceClient.PollOnceCreateEncryptionConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EncryptionConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEncryptionConfig</summary>
        public void CreateEncryptionConfigResourceNames()
        {
            // Snippet: CreateEncryptionConfig(OrganizationLocationName, EncryptionConfig, string, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = gcdv::CmekServiceClient.Create();
            // Initialize request argument(s)
            gcdv::OrganizationLocationName parent = gcdv::OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            gcdv::EncryptionConfig encryptionConfig = new gcdv::EncryptionConfig();
            string encryptionConfigId = "";
            // Make the request
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> response = cmekServiceClient.CreateEncryptionConfig(parent, encryptionConfig, encryptionConfigId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EncryptionConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> retrievedResponse = cmekServiceClient.PollOnceCreateEncryptionConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EncryptionConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEncryptionConfigAsync</summary>
        public async Task CreateEncryptionConfigResourceNamesAsync()
        {
            // Snippet: CreateEncryptionConfigAsync(OrganizationLocationName, EncryptionConfig, string, CallSettings)
            // Additional: CreateEncryptionConfigAsync(OrganizationLocationName, EncryptionConfig, string, CancellationToken)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = await gcdv::CmekServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::OrganizationLocationName parent = gcdv::OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            gcdv::EncryptionConfig encryptionConfig = new gcdv::EncryptionConfig();
            string encryptionConfigId = "";
            // Make the request
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> response = await cmekServiceClient.CreateEncryptionConfigAsync(parent, encryptionConfig, encryptionConfigId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EncryptionConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> retrievedResponse = await cmekServiceClient.PollOnceCreateEncryptionConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EncryptionConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEncryptionConfig</summary>
        public void UpdateEncryptionConfigRequestObject()
        {
            // Snippet: UpdateEncryptionConfig(UpdateEncryptionConfigRequest, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = gcdv::CmekServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateEncryptionConfigRequest request = new gcdv::UpdateEncryptionConfigRequest
            {
                EncryptionConfig = new gcdv::EncryptionConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> response = cmekServiceClient.UpdateEncryptionConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EncryptionConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> retrievedResponse = cmekServiceClient.PollOnceUpdateEncryptionConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EncryptionConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEncryptionConfigAsync</summary>
        public async Task UpdateEncryptionConfigRequestObjectAsync()
        {
            // Snippet: UpdateEncryptionConfigAsync(UpdateEncryptionConfigRequest, CallSettings)
            // Additional: UpdateEncryptionConfigAsync(UpdateEncryptionConfigRequest, CancellationToken)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = await gcdv::CmekServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateEncryptionConfigRequest request = new gcdv::UpdateEncryptionConfigRequest
            {
                EncryptionConfig = new gcdv::EncryptionConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> response = await cmekServiceClient.UpdateEncryptionConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EncryptionConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> retrievedResponse = await cmekServiceClient.PollOnceUpdateEncryptionConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EncryptionConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEncryptionConfig</summary>
        public void UpdateEncryptionConfig()
        {
            // Snippet: UpdateEncryptionConfig(EncryptionConfig, FieldMask, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = gcdv::CmekServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EncryptionConfig encryptionConfig = new gcdv::EncryptionConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> response = cmekServiceClient.UpdateEncryptionConfig(encryptionConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EncryptionConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> retrievedResponse = cmekServiceClient.PollOnceUpdateEncryptionConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EncryptionConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEncryptionConfigAsync</summary>
        public async Task UpdateEncryptionConfigAsync()
        {
            // Snippet: UpdateEncryptionConfigAsync(EncryptionConfig, FieldMask, CallSettings)
            // Additional: UpdateEncryptionConfigAsync(EncryptionConfig, FieldMask, CancellationToken)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = await gcdv::CmekServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EncryptionConfig encryptionConfig = new gcdv::EncryptionConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> response = await cmekServiceClient.UpdateEncryptionConfigAsync(encryptionConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EncryptionConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EncryptionConfig, gcdv::OperationMetadata> retrievedResponse = await cmekServiceClient.PollOnceUpdateEncryptionConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EncryptionConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEncryptionConfig</summary>
        public void DeleteEncryptionConfigRequestObject()
        {
            // Snippet: DeleteEncryptionConfig(DeleteEncryptionConfigRequest, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = gcdv::CmekServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteEncryptionConfigRequest request = new gcdv::DeleteEncryptionConfigRequest
            {
                EncryptionConfigName = gcdv::EncryptionConfigName.FromOrganizationLocationEncryptionConfig("[ORGANIZATION]", "[LOCATION]", "[ENCRYPTION_CONFIG]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = cmekServiceClient.DeleteEncryptionConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = cmekServiceClient.PollOnceDeleteEncryptionConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEncryptionConfigAsync</summary>
        public async Task DeleteEncryptionConfigRequestObjectAsync()
        {
            // Snippet: DeleteEncryptionConfigAsync(DeleteEncryptionConfigRequest, CallSettings)
            // Additional: DeleteEncryptionConfigAsync(DeleteEncryptionConfigRequest, CancellationToken)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = await gcdv::CmekServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteEncryptionConfigRequest request = new gcdv::DeleteEncryptionConfigRequest
            {
                EncryptionConfigName = gcdv::EncryptionConfigName.FromOrganizationLocationEncryptionConfig("[ORGANIZATION]", "[LOCATION]", "[ENCRYPTION_CONFIG]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await cmekServiceClient.DeleteEncryptionConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await cmekServiceClient.PollOnceDeleteEncryptionConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEncryptionConfig</summary>
        public void DeleteEncryptionConfig()
        {
            // Snippet: DeleteEncryptionConfig(string, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = gcdv::CmekServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/encryptionConfigs/[ENCRYPTION_CONFIG]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = cmekServiceClient.DeleteEncryptionConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = cmekServiceClient.PollOnceDeleteEncryptionConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEncryptionConfigAsync</summary>
        public async Task DeleteEncryptionConfigAsync()
        {
            // Snippet: DeleteEncryptionConfigAsync(string, CallSettings)
            // Additional: DeleteEncryptionConfigAsync(string, CancellationToken)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = await gcdv::CmekServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/encryptionConfigs/[ENCRYPTION_CONFIG]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await cmekServiceClient.DeleteEncryptionConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await cmekServiceClient.PollOnceDeleteEncryptionConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEncryptionConfig</summary>
        public void DeleteEncryptionConfigResourceNames()
        {
            // Snippet: DeleteEncryptionConfig(EncryptionConfigName, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = gcdv::CmekServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EncryptionConfigName name = gcdv::EncryptionConfigName.FromOrganizationLocationEncryptionConfig("[ORGANIZATION]", "[LOCATION]", "[ENCRYPTION_CONFIG]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = cmekServiceClient.DeleteEncryptionConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = cmekServiceClient.PollOnceDeleteEncryptionConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEncryptionConfigAsync</summary>
        public async Task DeleteEncryptionConfigResourceNamesAsync()
        {
            // Snippet: DeleteEncryptionConfigAsync(EncryptionConfigName, CallSettings)
            // Additional: DeleteEncryptionConfigAsync(EncryptionConfigName, CancellationToken)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = await gcdv::CmekServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EncryptionConfigName name = gcdv::EncryptionConfigName.FromOrganizationLocationEncryptionConfig("[ORGANIZATION]", "[LOCATION]", "[ENCRYPTION_CONFIG]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await cmekServiceClient.DeleteEncryptionConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await cmekServiceClient.PollOnceDeleteEncryptionConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListEncryptionConfigs</summary>
        public void ListEncryptionConfigsRequestObject()
        {
            // Snippet: ListEncryptionConfigs(ListEncryptionConfigsRequest, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = gcdv::CmekServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListEncryptionConfigsRequest request = new gcdv::ListEncryptionConfigsRequest
            {
                ParentAsOrganizationLocationName = gcdv::OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListEncryptionConfigsResponse, gcdv::EncryptionConfig> response = cmekServiceClient.ListEncryptionConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::EncryptionConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEncryptionConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EncryptionConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EncryptionConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EncryptionConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEncryptionConfigsAsync</summary>
        public async Task ListEncryptionConfigsRequestObjectAsync()
        {
            // Snippet: ListEncryptionConfigsAsync(ListEncryptionConfigsRequest, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = await gcdv::CmekServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListEncryptionConfigsRequest request = new gcdv::ListEncryptionConfigsRequest
            {
                ParentAsOrganizationLocationName = gcdv::OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEncryptionConfigsResponse, gcdv::EncryptionConfig> response = cmekServiceClient.ListEncryptionConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::EncryptionConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEncryptionConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EncryptionConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EncryptionConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EncryptionConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEncryptionConfigs</summary>
        public void ListEncryptionConfigs()
        {
            // Snippet: ListEncryptionConfigs(string, string, int?, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = gcdv::CmekServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::ListEncryptionConfigsResponse, gcdv::EncryptionConfig> response = cmekServiceClient.ListEncryptionConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::EncryptionConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEncryptionConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EncryptionConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EncryptionConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EncryptionConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEncryptionConfigsAsync</summary>
        public async Task ListEncryptionConfigsAsync()
        {
            // Snippet: ListEncryptionConfigsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = await gcdv::CmekServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEncryptionConfigsResponse, gcdv::EncryptionConfig> response = cmekServiceClient.ListEncryptionConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::EncryptionConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEncryptionConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EncryptionConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EncryptionConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EncryptionConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEncryptionConfigs</summary>
        public void ListEncryptionConfigsResourceNames()
        {
            // Snippet: ListEncryptionConfigs(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = gcdv::CmekServiceClient.Create();
            // Initialize request argument(s)
            gcdv::OrganizationLocationName parent = gcdv::OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListEncryptionConfigsResponse, gcdv::EncryptionConfig> response = cmekServiceClient.ListEncryptionConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::EncryptionConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEncryptionConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EncryptionConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EncryptionConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EncryptionConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEncryptionConfigsAsync</summary>
        public async Task ListEncryptionConfigsResourceNamesAsync()
        {
            // Snippet: ListEncryptionConfigsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = await gcdv::CmekServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::OrganizationLocationName parent = gcdv::OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEncryptionConfigsResponse, gcdv::EncryptionConfig> response = cmekServiceClient.ListEncryptionConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::EncryptionConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEncryptionConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EncryptionConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EncryptionConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EncryptionConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEncryptionConfig</summary>
        public void GetEncryptionConfigRequestObject()
        {
            // Snippet: GetEncryptionConfig(GetEncryptionConfigRequest, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = gcdv::CmekServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetEncryptionConfigRequest request = new gcdv::GetEncryptionConfigRequest
            {
                EncryptionConfigName = gcdv::EncryptionConfigName.FromOrganizationLocationEncryptionConfig("[ORGANIZATION]", "[LOCATION]", "[ENCRYPTION_CONFIG]"),
            };
            // Make the request
            gcdv::EncryptionConfig response = cmekServiceClient.GetEncryptionConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetEncryptionConfigAsync</summary>
        public async Task GetEncryptionConfigRequestObjectAsync()
        {
            // Snippet: GetEncryptionConfigAsync(GetEncryptionConfigRequest, CallSettings)
            // Additional: GetEncryptionConfigAsync(GetEncryptionConfigRequest, CancellationToken)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = await gcdv::CmekServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetEncryptionConfigRequest request = new gcdv::GetEncryptionConfigRequest
            {
                EncryptionConfigName = gcdv::EncryptionConfigName.FromOrganizationLocationEncryptionConfig("[ORGANIZATION]", "[LOCATION]", "[ENCRYPTION_CONFIG]"),
            };
            // Make the request
            gcdv::EncryptionConfig response = await cmekServiceClient.GetEncryptionConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEncryptionConfig</summary>
        public void GetEncryptionConfig()
        {
            // Snippet: GetEncryptionConfig(string, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = gcdv::CmekServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/encryptionConfigs/[ENCRYPTION_CONFIG]";
            // Make the request
            gcdv::EncryptionConfig response = cmekServiceClient.GetEncryptionConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetEncryptionConfigAsync</summary>
        public async Task GetEncryptionConfigAsync()
        {
            // Snippet: GetEncryptionConfigAsync(string, CallSettings)
            // Additional: GetEncryptionConfigAsync(string, CancellationToken)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = await gcdv::CmekServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/encryptionConfigs/[ENCRYPTION_CONFIG]";
            // Make the request
            gcdv::EncryptionConfig response = await cmekServiceClient.GetEncryptionConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEncryptionConfig</summary>
        public void GetEncryptionConfigResourceNames()
        {
            // Snippet: GetEncryptionConfig(EncryptionConfigName, CallSettings)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = gcdv::CmekServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EncryptionConfigName name = gcdv::EncryptionConfigName.FromOrganizationLocationEncryptionConfig("[ORGANIZATION]", "[LOCATION]", "[ENCRYPTION_CONFIG]");
            // Make the request
            gcdv::EncryptionConfig response = cmekServiceClient.GetEncryptionConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetEncryptionConfigAsync</summary>
        public async Task GetEncryptionConfigResourceNamesAsync()
        {
            // Snippet: GetEncryptionConfigAsync(EncryptionConfigName, CallSettings)
            // Additional: GetEncryptionConfigAsync(EncryptionConfigName, CancellationToken)
            // Create client
            gcdv::CmekServiceClient cmekServiceClient = await gcdv::CmekServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EncryptionConfigName name = gcdv::EncryptionConfigName.FromOrganizationLocationEncryptionConfig("[ORGANIZATION]", "[LOCATION]", "[ENCRYPTION_CONFIG]");
            // Make the request
            gcdv::EncryptionConfig response = await cmekServiceClient.GetEncryptionConfigAsync(name);
            // End snippet
        }
    }
}
