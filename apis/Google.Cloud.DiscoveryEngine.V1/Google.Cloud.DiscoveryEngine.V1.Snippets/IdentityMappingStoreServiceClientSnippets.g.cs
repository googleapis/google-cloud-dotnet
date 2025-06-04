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
    using Google.Cloud.DiscoveryEngine.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedIdentityMappingStoreServiceClientSnippets
    {
        /// <summary>Snippet for CreateIdentityMappingStore</summary>
        public void CreateIdentityMappingStoreRequestObject()
        {
            // Snippet: CreateIdentityMappingStore(CreateIdentityMappingStoreRequest, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            CreateIdentityMappingStoreRequest request = new CreateIdentityMappingStoreRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                IdentityMappingStoreId = "",
                IdentityMappingStore = new IdentityMappingStore(),
                CmekConfigNameAsCmekConfigName = CmekConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            IdentityMappingStore response = identityMappingStoreServiceClient.CreateIdentityMappingStore(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIdentityMappingStoreAsync</summary>
        public async Task CreateIdentityMappingStoreRequestObjectAsync()
        {
            // Snippet: CreateIdentityMappingStoreAsync(CreateIdentityMappingStoreRequest, CallSettings)
            // Additional: CreateIdentityMappingStoreAsync(CreateIdentityMappingStoreRequest, CancellationToken)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateIdentityMappingStoreRequest request = new CreateIdentityMappingStoreRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                IdentityMappingStoreId = "",
                IdentityMappingStore = new IdentityMappingStore(),
                CmekConfigNameAsCmekConfigName = CmekConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            IdentityMappingStore response = await identityMappingStoreServiceClient.CreateIdentityMappingStoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIdentityMappingStore</summary>
        public void CreateIdentityMappingStore()
        {
            // Snippet: CreateIdentityMappingStore(string, IdentityMappingStore, string, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IdentityMappingStore identityMappingStore = new IdentityMappingStore();
            string identityMappingStoreId = "";
            // Make the request
            IdentityMappingStore response = identityMappingStoreServiceClient.CreateIdentityMappingStore(parent, identityMappingStore, identityMappingStoreId);
            // End snippet
        }

        /// <summary>Snippet for CreateIdentityMappingStoreAsync</summary>
        public async Task CreateIdentityMappingStoreAsync()
        {
            // Snippet: CreateIdentityMappingStoreAsync(string, IdentityMappingStore, string, CallSettings)
            // Additional: CreateIdentityMappingStoreAsync(string, IdentityMappingStore, string, CancellationToken)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IdentityMappingStore identityMappingStore = new IdentityMappingStore();
            string identityMappingStoreId = "";
            // Make the request
            IdentityMappingStore response = await identityMappingStoreServiceClient.CreateIdentityMappingStoreAsync(parent, identityMappingStore, identityMappingStoreId);
            // End snippet
        }

        /// <summary>Snippet for CreateIdentityMappingStore</summary>
        public void CreateIdentityMappingStoreResourceNames()
        {
            // Snippet: CreateIdentityMappingStore(LocationName, IdentityMappingStore, string, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IdentityMappingStore identityMappingStore = new IdentityMappingStore();
            string identityMappingStoreId = "";
            // Make the request
            IdentityMappingStore response = identityMappingStoreServiceClient.CreateIdentityMappingStore(parent, identityMappingStore, identityMappingStoreId);
            // End snippet
        }

        /// <summary>Snippet for CreateIdentityMappingStoreAsync</summary>
        public async Task CreateIdentityMappingStoreResourceNamesAsync()
        {
            // Snippet: CreateIdentityMappingStoreAsync(LocationName, IdentityMappingStore, string, CallSettings)
            // Additional: CreateIdentityMappingStoreAsync(LocationName, IdentityMappingStore, string, CancellationToken)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IdentityMappingStore identityMappingStore = new IdentityMappingStore();
            string identityMappingStoreId = "";
            // Make the request
            IdentityMappingStore response = await identityMappingStoreServiceClient.CreateIdentityMappingStoreAsync(parent, identityMappingStore, identityMappingStoreId);
            // End snippet
        }

        /// <summary>Snippet for GetIdentityMappingStore</summary>
        public void GetIdentityMappingStoreRequestObject()
        {
            // Snippet: GetIdentityMappingStore(GetIdentityMappingStoreRequest, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            GetIdentityMappingStoreRequest request = new GetIdentityMappingStoreRequest
            {
                IdentityMappingStoreName = IdentityMappingStoreName.FromProjectLocationIdentityMappingStore("[PROJECT]", "[LOCATION]", "[IDENTITY_MAPPING_STORE]"),
            };
            // Make the request
            IdentityMappingStore response = identityMappingStoreServiceClient.GetIdentityMappingStore(request);
            // End snippet
        }

        /// <summary>Snippet for GetIdentityMappingStoreAsync</summary>
        public async Task GetIdentityMappingStoreRequestObjectAsync()
        {
            // Snippet: GetIdentityMappingStoreAsync(GetIdentityMappingStoreRequest, CallSettings)
            // Additional: GetIdentityMappingStoreAsync(GetIdentityMappingStoreRequest, CancellationToken)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIdentityMappingStoreRequest request = new GetIdentityMappingStoreRequest
            {
                IdentityMappingStoreName = IdentityMappingStoreName.FromProjectLocationIdentityMappingStore("[PROJECT]", "[LOCATION]", "[IDENTITY_MAPPING_STORE]"),
            };
            // Make the request
            IdentityMappingStore response = await identityMappingStoreServiceClient.GetIdentityMappingStoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIdentityMappingStore</summary>
        public void GetIdentityMappingStore()
        {
            // Snippet: GetIdentityMappingStore(string, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/identityMappingStores/[IDENTITY_MAPPING_STORE]";
            // Make the request
            IdentityMappingStore response = identityMappingStoreServiceClient.GetIdentityMappingStore(name);
            // End snippet
        }

        /// <summary>Snippet for GetIdentityMappingStoreAsync</summary>
        public async Task GetIdentityMappingStoreAsync()
        {
            // Snippet: GetIdentityMappingStoreAsync(string, CallSettings)
            // Additional: GetIdentityMappingStoreAsync(string, CancellationToken)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/identityMappingStores/[IDENTITY_MAPPING_STORE]";
            // Make the request
            IdentityMappingStore response = await identityMappingStoreServiceClient.GetIdentityMappingStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIdentityMappingStore</summary>
        public void GetIdentityMappingStoreResourceNames()
        {
            // Snippet: GetIdentityMappingStore(IdentityMappingStoreName, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            IdentityMappingStoreName name = IdentityMappingStoreName.FromProjectLocationIdentityMappingStore("[PROJECT]", "[LOCATION]", "[IDENTITY_MAPPING_STORE]");
            // Make the request
            IdentityMappingStore response = identityMappingStoreServiceClient.GetIdentityMappingStore(name);
            // End snippet
        }

        /// <summary>Snippet for GetIdentityMappingStoreAsync</summary>
        public async Task GetIdentityMappingStoreResourceNamesAsync()
        {
            // Snippet: GetIdentityMappingStoreAsync(IdentityMappingStoreName, CallSettings)
            // Additional: GetIdentityMappingStoreAsync(IdentityMappingStoreName, CancellationToken)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            IdentityMappingStoreName name = IdentityMappingStoreName.FromProjectLocationIdentityMappingStore("[PROJECT]", "[LOCATION]", "[IDENTITY_MAPPING_STORE]");
            // Make the request
            IdentityMappingStore response = await identityMappingStoreServiceClient.GetIdentityMappingStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIdentityMappingStore</summary>
        public void DeleteIdentityMappingStoreRequestObject()
        {
            // Snippet: DeleteIdentityMappingStore(DeleteIdentityMappingStoreRequest, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            DeleteIdentityMappingStoreRequest request = new DeleteIdentityMappingStoreRequest
            {
                IdentityMappingStoreName = IdentityMappingStoreName.FromProjectLocationIdentityMappingStore("[PROJECT]", "[LOCATION]", "[IDENTITY_MAPPING_STORE]"),
            };
            // Make the request
            Operation<Empty, DeleteIdentityMappingStoreMetadata> response = identityMappingStoreServiceClient.DeleteIdentityMappingStore(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteIdentityMappingStoreMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteIdentityMappingStoreMetadata> retrievedResponse = identityMappingStoreServiceClient.PollOnceDeleteIdentityMappingStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIdentityMappingStoreAsync</summary>
        public async Task DeleteIdentityMappingStoreRequestObjectAsync()
        {
            // Snippet: DeleteIdentityMappingStoreAsync(DeleteIdentityMappingStoreRequest, CallSettings)
            // Additional: DeleteIdentityMappingStoreAsync(DeleteIdentityMappingStoreRequest, CancellationToken)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIdentityMappingStoreRequest request = new DeleteIdentityMappingStoreRequest
            {
                IdentityMappingStoreName = IdentityMappingStoreName.FromProjectLocationIdentityMappingStore("[PROJECT]", "[LOCATION]", "[IDENTITY_MAPPING_STORE]"),
            };
            // Make the request
            Operation<Empty, DeleteIdentityMappingStoreMetadata> response = await identityMappingStoreServiceClient.DeleteIdentityMappingStoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteIdentityMappingStoreMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteIdentityMappingStoreMetadata> retrievedResponse = await identityMappingStoreServiceClient.PollOnceDeleteIdentityMappingStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIdentityMappingStore</summary>
        public void DeleteIdentityMappingStore()
        {
            // Snippet: DeleteIdentityMappingStore(string, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/identityMappingStores/[IDENTITY_MAPPING_STORE]";
            // Make the request
            Operation<Empty, DeleteIdentityMappingStoreMetadata> response = identityMappingStoreServiceClient.DeleteIdentityMappingStore(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteIdentityMappingStoreMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteIdentityMappingStoreMetadata> retrievedResponse = identityMappingStoreServiceClient.PollOnceDeleteIdentityMappingStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIdentityMappingStoreAsync</summary>
        public async Task DeleteIdentityMappingStoreAsync()
        {
            // Snippet: DeleteIdentityMappingStoreAsync(string, CallSettings)
            // Additional: DeleteIdentityMappingStoreAsync(string, CancellationToken)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/identityMappingStores/[IDENTITY_MAPPING_STORE]";
            // Make the request
            Operation<Empty, DeleteIdentityMappingStoreMetadata> response = await identityMappingStoreServiceClient.DeleteIdentityMappingStoreAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteIdentityMappingStoreMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteIdentityMappingStoreMetadata> retrievedResponse = await identityMappingStoreServiceClient.PollOnceDeleteIdentityMappingStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIdentityMappingStore</summary>
        public void DeleteIdentityMappingStoreResourceNames()
        {
            // Snippet: DeleteIdentityMappingStore(IdentityMappingStoreName, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            IdentityMappingStoreName name = IdentityMappingStoreName.FromProjectLocationIdentityMappingStore("[PROJECT]", "[LOCATION]", "[IDENTITY_MAPPING_STORE]");
            // Make the request
            Operation<Empty, DeleteIdentityMappingStoreMetadata> response = identityMappingStoreServiceClient.DeleteIdentityMappingStore(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteIdentityMappingStoreMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteIdentityMappingStoreMetadata> retrievedResponse = identityMappingStoreServiceClient.PollOnceDeleteIdentityMappingStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIdentityMappingStoreAsync</summary>
        public async Task DeleteIdentityMappingStoreResourceNamesAsync()
        {
            // Snippet: DeleteIdentityMappingStoreAsync(IdentityMappingStoreName, CallSettings)
            // Additional: DeleteIdentityMappingStoreAsync(IdentityMappingStoreName, CancellationToken)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            IdentityMappingStoreName name = IdentityMappingStoreName.FromProjectLocationIdentityMappingStore("[PROJECT]", "[LOCATION]", "[IDENTITY_MAPPING_STORE]");
            // Make the request
            Operation<Empty, DeleteIdentityMappingStoreMetadata> response = await identityMappingStoreServiceClient.DeleteIdentityMappingStoreAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteIdentityMappingStoreMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteIdentityMappingStoreMetadata> retrievedResponse = await identityMappingStoreServiceClient.PollOnceDeleteIdentityMappingStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportIdentityMappings</summary>
        public void ImportIdentityMappingsRequestObject()
        {
            // Snippet: ImportIdentityMappings(ImportIdentityMappingsRequest, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            ImportIdentityMappingsRequest request = new ImportIdentityMappingsRequest
            {
                IdentityMappingStoreAsIdentityMappingStoreName = IdentityMappingStoreName.FromProjectLocationIdentityMappingStore("[PROJECT]", "[LOCATION]", "[IDENTITY_MAPPING_STORE]"),
                InlineSource = new ImportIdentityMappingsRequest.Types.InlineSource(),
            };
            // Make the request
            Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata> response = identityMappingStoreServiceClient.ImportIdentityMappings(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportIdentityMappingsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata> retrievedResponse = identityMappingStoreServiceClient.PollOnceImportIdentityMappings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportIdentityMappingsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportIdentityMappingsAsync</summary>
        public async Task ImportIdentityMappingsRequestObjectAsync()
        {
            // Snippet: ImportIdentityMappingsAsync(ImportIdentityMappingsRequest, CallSettings)
            // Additional: ImportIdentityMappingsAsync(ImportIdentityMappingsRequest, CancellationToken)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportIdentityMappingsRequest request = new ImportIdentityMappingsRequest
            {
                IdentityMappingStoreAsIdentityMappingStoreName = IdentityMappingStoreName.FromProjectLocationIdentityMappingStore("[PROJECT]", "[LOCATION]", "[IDENTITY_MAPPING_STORE]"),
                InlineSource = new ImportIdentityMappingsRequest.Types.InlineSource(),
            };
            // Make the request
            Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata> response = await identityMappingStoreServiceClient.ImportIdentityMappingsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportIdentityMappingsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata> retrievedResponse = await identityMappingStoreServiceClient.PollOnceImportIdentityMappingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportIdentityMappingsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeIdentityMappings</summary>
        public void PurgeIdentityMappingsRequestObject()
        {
            // Snippet: PurgeIdentityMappings(PurgeIdentityMappingsRequest, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            PurgeIdentityMappingsRequest request = new PurgeIdentityMappingsRequest
            {
                IdentityMappingStoreAsIdentityMappingStoreName = IdentityMappingStoreName.FromProjectLocationIdentityMappingStore("[PROJECT]", "[LOCATION]", "[IDENTITY_MAPPING_STORE]"),
                InlineSource = new PurgeIdentityMappingsRequest.Types.InlineSource(),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, IdentityMappingEntryOperationMetadata> response = identityMappingStoreServiceClient.PurgeIdentityMappings(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, IdentityMappingEntryOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, IdentityMappingEntryOperationMetadata> retrievedResponse = identityMappingStoreServiceClient.PollOncePurgeIdentityMappings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeIdentityMappingsAsync</summary>
        public async Task PurgeIdentityMappingsRequestObjectAsync()
        {
            // Snippet: PurgeIdentityMappingsAsync(PurgeIdentityMappingsRequest, CallSettings)
            // Additional: PurgeIdentityMappingsAsync(PurgeIdentityMappingsRequest, CancellationToken)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            PurgeIdentityMappingsRequest request = new PurgeIdentityMappingsRequest
            {
                IdentityMappingStoreAsIdentityMappingStoreName = IdentityMappingStoreName.FromProjectLocationIdentityMappingStore("[PROJECT]", "[LOCATION]", "[IDENTITY_MAPPING_STORE]"),
                InlineSource = new PurgeIdentityMappingsRequest.Types.InlineSource(),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, IdentityMappingEntryOperationMetadata> response = await identityMappingStoreServiceClient.PurgeIdentityMappingsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, IdentityMappingEntryOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, IdentityMappingEntryOperationMetadata> retrievedResponse = await identityMappingStoreServiceClient.PollOncePurgeIdentityMappingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListIdentityMappings</summary>
        public void ListIdentityMappingsRequestObject()
        {
            // Snippet: ListIdentityMappings(ListIdentityMappingsRequest, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            ListIdentityMappingsRequest request = new ListIdentityMappingsRequest
            {
                IdentityMappingStoreAsIdentityMappingStoreName = IdentityMappingStoreName.FromProjectLocationIdentityMappingStore("[PROJECT]", "[LOCATION]", "[IDENTITY_MAPPING_STORE]"),
            };
            // Make the request
            PagedEnumerable<ListIdentityMappingsResponse, IdentityMappingEntry> response = identityMappingStoreServiceClient.ListIdentityMappings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IdentityMappingEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIdentityMappingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IdentityMappingEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IdentityMappingEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IdentityMappingEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIdentityMappingsAsync</summary>
        public async Task ListIdentityMappingsRequestObjectAsync()
        {
            // Snippet: ListIdentityMappingsAsync(ListIdentityMappingsRequest, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListIdentityMappingsRequest request = new ListIdentityMappingsRequest
            {
                IdentityMappingStoreAsIdentityMappingStoreName = IdentityMappingStoreName.FromProjectLocationIdentityMappingStore("[PROJECT]", "[LOCATION]", "[IDENTITY_MAPPING_STORE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListIdentityMappingsResponse, IdentityMappingEntry> response = identityMappingStoreServiceClient.ListIdentityMappingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IdentityMappingEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIdentityMappingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IdentityMappingEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IdentityMappingEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IdentityMappingEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIdentityMappingStores</summary>
        public void ListIdentityMappingStoresRequestObject()
        {
            // Snippet: ListIdentityMappingStores(ListIdentityMappingStoresRequest, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            ListIdentityMappingStoresRequest request = new ListIdentityMappingStoresRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListIdentityMappingStoresResponse, IdentityMappingStore> response = identityMappingStoreServiceClient.ListIdentityMappingStores(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IdentityMappingStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIdentityMappingStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IdentityMappingStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IdentityMappingStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IdentityMappingStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIdentityMappingStoresAsync</summary>
        public async Task ListIdentityMappingStoresRequestObjectAsync()
        {
            // Snippet: ListIdentityMappingStoresAsync(ListIdentityMappingStoresRequest, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListIdentityMappingStoresRequest request = new ListIdentityMappingStoresRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListIdentityMappingStoresResponse, IdentityMappingStore> response = identityMappingStoreServiceClient.ListIdentityMappingStoresAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IdentityMappingStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIdentityMappingStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IdentityMappingStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IdentityMappingStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IdentityMappingStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIdentityMappingStores</summary>
        public void ListIdentityMappingStores()
        {
            // Snippet: ListIdentityMappingStores(string, string, int?, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListIdentityMappingStoresResponse, IdentityMappingStore> response = identityMappingStoreServiceClient.ListIdentityMappingStores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IdentityMappingStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIdentityMappingStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IdentityMappingStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IdentityMappingStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IdentityMappingStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIdentityMappingStoresAsync</summary>
        public async Task ListIdentityMappingStoresAsync()
        {
            // Snippet: ListIdentityMappingStoresAsync(string, string, int?, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListIdentityMappingStoresResponse, IdentityMappingStore> response = identityMappingStoreServiceClient.ListIdentityMappingStoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IdentityMappingStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIdentityMappingStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IdentityMappingStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IdentityMappingStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IdentityMappingStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIdentityMappingStores</summary>
        public void ListIdentityMappingStoresResourceNames()
        {
            // Snippet: ListIdentityMappingStores(LocationName, string, int?, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = IdentityMappingStoreServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListIdentityMappingStoresResponse, IdentityMappingStore> response = identityMappingStoreServiceClient.ListIdentityMappingStores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IdentityMappingStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIdentityMappingStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IdentityMappingStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IdentityMappingStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IdentityMappingStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIdentityMappingStoresAsync</summary>
        public async Task ListIdentityMappingStoresResourceNamesAsync()
        {
            // Snippet: ListIdentityMappingStoresAsync(LocationName, string, int?, CallSettings)
            // Create client
            IdentityMappingStoreServiceClient identityMappingStoreServiceClient = await IdentityMappingStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListIdentityMappingStoresResponse, IdentityMappingStore> response = identityMappingStoreServiceClient.ListIdentityMappingStoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IdentityMappingStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIdentityMappingStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IdentityMappingStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IdentityMappingStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IdentityMappingStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
