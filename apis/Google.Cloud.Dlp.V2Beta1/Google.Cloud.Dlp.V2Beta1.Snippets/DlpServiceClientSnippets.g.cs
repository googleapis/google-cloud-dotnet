// Copyright 2017, Google Inc. All rights reserved.
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Dlp.V2Beta1;
using Google.LongRunning;
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

namespace Google.Cloud.Dlp.V2Beta1.Snippets
{
    public class GeneratedDlpServiceClientSnippets
    {
        public async Task InspectContentAsync()
        {
            // Snippet: InspectContentAsync(InspectConfig,IEnumerable<ContentItem>,CallSettings)
            // Additional: InspectContentAsync(InspectConfig,IEnumerable<ContentItem>,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            InspectConfig inspectConfig = new InspectConfig();
            IEnumerable<ContentItem> items = new List<ContentItem>();
            // Make the request
            InspectContentResponse response = await dlpServiceClient.InspectContentAsync(inspectConfig, items);
            // End snippet
        }

        public void InspectContent()
        {
            // Snippet: InspectContent(InspectConfig,IEnumerable<ContentItem>,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            InspectConfig inspectConfig = new InspectConfig();
            IEnumerable<ContentItem> items = new List<ContentItem>();
            // Make the request
            InspectContentResponse response = dlpServiceClient.InspectContent(inspectConfig, items);
            // End snippet
        }

        public async Task InspectContentAsync_RequestObject()
        {
            // Snippet: InspectContentAsync(InspectContentRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            InspectContentRequest request = new InspectContentRequest
            {
                InspectConfig = new InspectConfig(),
                Items = { },
            };
            // Make the request
            InspectContentResponse response = await dlpServiceClient.InspectContentAsync(request);
            // End snippet
        }

        public void InspectContent_RequestObject()
        {
            // Snippet: InspectContent(InspectContentRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            InspectContentRequest request = new InspectContentRequest
            {
                InspectConfig = new InspectConfig(),
                Items = { },
            };
            // Make the request
            InspectContentResponse response = dlpServiceClient.InspectContent(request);
            // End snippet
        }

        public async Task RedactContentAsync()
        {
            // Snippet: RedactContentAsync(InspectConfig,IEnumerable<ContentItem>,IEnumerable<RedactContentRequest.Types.ReplaceConfig>,CallSettings)
            // Additional: RedactContentAsync(InspectConfig,IEnumerable<ContentItem>,IEnumerable<RedactContentRequest.Types.ReplaceConfig>,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            InspectConfig inspectConfig = new InspectConfig();
            IEnumerable<ContentItem> items = new List<ContentItem>();
            IEnumerable<RedactContentRequest.Types.ReplaceConfig> replaceConfigs = new List<RedactContentRequest.Types.ReplaceConfig>();
            // Make the request
            RedactContentResponse response = await dlpServiceClient.RedactContentAsync(inspectConfig, items, replaceConfigs);
            // End snippet
        }

        public void RedactContent()
        {
            // Snippet: RedactContent(InspectConfig,IEnumerable<ContentItem>,IEnumerable<RedactContentRequest.Types.ReplaceConfig>,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            InspectConfig inspectConfig = new InspectConfig();
            IEnumerable<ContentItem> items = new List<ContentItem>();
            IEnumerable<RedactContentRequest.Types.ReplaceConfig> replaceConfigs = new List<RedactContentRequest.Types.ReplaceConfig>();
            // Make the request
            RedactContentResponse response = dlpServiceClient.RedactContent(inspectConfig, items, replaceConfigs);
            // End snippet
        }

        public async Task RedactContentAsync_RequestObject()
        {
            // Snippet: RedactContentAsync(RedactContentRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            RedactContentRequest request = new RedactContentRequest
            {
                InspectConfig = new InspectConfig(),
                Items = { },
                ReplaceConfigs = { },
            };
            // Make the request
            RedactContentResponse response = await dlpServiceClient.RedactContentAsync(request);
            // End snippet
        }

        public void RedactContent_RequestObject()
        {
            // Snippet: RedactContent(RedactContentRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            RedactContentRequest request = new RedactContentRequest
            {
                InspectConfig = new InspectConfig(),
                Items = { },
                ReplaceConfigs = { },
            };
            // Make the request
            RedactContentResponse response = dlpServiceClient.RedactContent(request);
            // End snippet
        }

        public async Task CreateInspectOperationAsync()
        {
            // Snippet: CreateInspectOperationAsync(InspectConfig,StorageConfig,OutputStorageConfig,CallSettings)
            // Additional: CreateInspectOperationAsync(InspectConfig,StorageConfig,OutputStorageConfig,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            InspectConfig inspectConfig = new InspectConfig();
            StorageConfig storageConfig = new StorageConfig();
            OutputStorageConfig outputConfig = new OutputStorageConfig();
            // Make the request
            Operation<InspectOperationResult, InspectOperationMetadata> response =
                await dlpServiceClient.CreateInspectOperationAsync(inspectConfig, storageConfig, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<InspectOperationResult, InspectOperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InspectOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InspectOperationResult, InspectOperationMetadata> retrievedResponse =
                await dlpServiceClient.PollOnceCreateInspectOperationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InspectOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public void CreateInspectOperation()
        {
            // Snippet: CreateInspectOperation(InspectConfig,StorageConfig,OutputStorageConfig,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            InspectConfig inspectConfig = new InspectConfig();
            StorageConfig storageConfig = new StorageConfig();
            OutputStorageConfig outputConfig = new OutputStorageConfig();
            // Make the request
            Operation<InspectOperationResult, InspectOperationMetadata> response =
                dlpServiceClient.CreateInspectOperation(inspectConfig, storageConfig, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<InspectOperationResult, InspectOperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            InspectOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InspectOperationResult, InspectOperationMetadata> retrievedResponse =
                dlpServiceClient.PollOnceCreateInspectOperation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InspectOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public async Task CreateInspectOperationAsync_RequestObject()
        {
            // Snippet: CreateInspectOperationAsync(CreateInspectOperationRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateInspectOperationRequest request = new CreateInspectOperationRequest
            {
                InspectConfig = new InspectConfig(),
                StorageConfig = new StorageConfig(),
                OutputConfig = new OutputStorageConfig(),
            };
            // Make the request
            Operation<InspectOperationResult, InspectOperationMetadata> response =
                await dlpServiceClient.CreateInspectOperationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InspectOperationResult, InspectOperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InspectOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InspectOperationResult, InspectOperationMetadata> retrievedResponse =
                await dlpServiceClient.PollOnceCreateInspectOperationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InspectOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public void CreateInspectOperation_RequestObject()
        {
            // Snippet: CreateInspectOperation(CreateInspectOperationRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CreateInspectOperationRequest request = new CreateInspectOperationRequest
            {
                InspectConfig = new InspectConfig(),
                StorageConfig = new StorageConfig(),
                OutputConfig = new OutputStorageConfig(),
            };
            // Make the request
            Operation<InspectOperationResult, InspectOperationMetadata> response =
                dlpServiceClient.CreateInspectOperation(request);

            // Poll until the returned long-running operation is complete
            Operation<InspectOperationResult, InspectOperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            InspectOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InspectOperationResult, InspectOperationMetadata> retrievedResponse =
                dlpServiceClient.PollOnceCreateInspectOperation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InspectOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public async Task ListInspectFindingsAsync()
        {
            // Snippet: ListInspectFindingsAsync(ResultName,CallSettings)
            // Additional: ListInspectFindingsAsync(ResultName,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResultName name = new ResultName("[RESULT]");
            // Make the request
            ListInspectFindingsResponse response = await dlpServiceClient.ListInspectFindingsAsync(name);
            // End snippet
        }

        public void ListInspectFindings()
        {
            // Snippet: ListInspectFindings(ResultName,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ResultName name = new ResultName("[RESULT]");
            // Make the request
            ListInspectFindingsResponse response = dlpServiceClient.ListInspectFindings(name);
            // End snippet
        }

        public async Task ListInspectFindingsAsync_RequestObject()
        {
            // Snippet: ListInspectFindingsAsync(ListInspectFindingsRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInspectFindingsRequest request = new ListInspectFindingsRequest
            {
                ResultName = new ResultName("[RESULT]"),
            };
            // Make the request
            ListInspectFindingsResponse response = await dlpServiceClient.ListInspectFindingsAsync(request);
            // End snippet
        }

        public void ListInspectFindings_RequestObject()
        {
            // Snippet: ListInspectFindings(ListInspectFindingsRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListInspectFindingsRequest request = new ListInspectFindingsRequest
            {
                ResultName = new ResultName("[RESULT]"),
            };
            // Make the request
            ListInspectFindingsResponse response = dlpServiceClient.ListInspectFindings(request);
            // End snippet
        }

        public async Task ListInfoTypesAsync()
        {
            // Snippet: ListInfoTypesAsync(string,string,CallSettings)
            // Additional: ListInfoTypesAsync(string,string,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string category = "";
            string languageCode = "";
            // Make the request
            ListInfoTypesResponse response = await dlpServiceClient.ListInfoTypesAsync(category, languageCode);
            // End snippet
        }

        public void ListInfoTypes()
        {
            // Snippet: ListInfoTypes(string,string,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string category = "";
            string languageCode = "";
            // Make the request
            ListInfoTypesResponse response = dlpServiceClient.ListInfoTypes(category, languageCode);
            // End snippet
        }

        public async Task ListInfoTypesAsync_RequestObject()
        {
            // Snippet: ListInfoTypesAsync(ListInfoTypesRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInfoTypesRequest request = new ListInfoTypesRequest
            {
                Category = "",
                LanguageCode = "",
            };
            // Make the request
            ListInfoTypesResponse response = await dlpServiceClient.ListInfoTypesAsync(request);
            // End snippet
        }

        public void ListInfoTypes_RequestObject()
        {
            // Snippet: ListInfoTypes(ListInfoTypesRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListInfoTypesRequest request = new ListInfoTypesRequest
            {
                Category = "",
                LanguageCode = "",
            };
            // Make the request
            ListInfoTypesResponse response = dlpServiceClient.ListInfoTypes(request);
            // End snippet
        }

        public async Task ListRootCategoriesAsync()
        {
            // Snippet: ListRootCategoriesAsync(string,CallSettings)
            // Additional: ListRootCategoriesAsync(string,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string languageCode = "";
            // Make the request
            ListRootCategoriesResponse response = await dlpServiceClient.ListRootCategoriesAsync(languageCode);
            // End snippet
        }

        public void ListRootCategories()
        {
            // Snippet: ListRootCategories(string,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string languageCode = "";
            // Make the request
            ListRootCategoriesResponse response = dlpServiceClient.ListRootCategories(languageCode);
            // End snippet
        }

        public async Task ListRootCategoriesAsync_RequestObject()
        {
            // Snippet: ListRootCategoriesAsync(ListRootCategoriesRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRootCategoriesRequest request = new ListRootCategoriesRequest
            {
                LanguageCode = "",
            };
            // Make the request
            ListRootCategoriesResponse response = await dlpServiceClient.ListRootCategoriesAsync(request);
            // End snippet
        }

        public void ListRootCategories_RequestObject()
        {
            // Snippet: ListRootCategories(ListRootCategoriesRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListRootCategoriesRequest request = new ListRootCategoriesRequest
            {
                LanguageCode = "",
            };
            // Make the request
            ListRootCategoriesResponse response = dlpServiceClient.ListRootCategories(request);
            // End snippet
        }

    }
}
