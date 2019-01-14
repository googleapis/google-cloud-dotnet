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

namespace Google.Cloud.Asset.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.Asset.V1Beta1;
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

    /// <summary>Generated snippets</summary>
    public class GeneratedAssetServiceClientSnippets
    {
        /// <summary>Snippet for ExportAssetsAsync</summary>
        public async Task ExportAssetsAsync_RequestObject()
        {
            // Snippet: ExportAssetsAsync(ExportAssetsRequest,CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportAssetsRequest request = new ExportAssetsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                OutputConfig = new OutputConfig(),
            };
            // Make the request
            Operation<ExportAssetsResponse, ExportAssetsRequest> response =
                await assetServiceClient.ExportAssetsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportAssetsResponse, ExportAssetsRequest> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportAssetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAssetsResponse, ExportAssetsRequest> retrievedResponse =
                await assetServiceClient.PollOnceExportAssetsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAssetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAssets</summary>
        public void ExportAssets_RequestObject()
        {
            // Snippet: ExportAssets(ExportAssetsRequest,CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            ExportAssetsRequest request = new ExportAssetsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                OutputConfig = new OutputConfig(),
            };
            // Make the request
            Operation<ExportAssetsResponse, ExportAssetsRequest> response =
                assetServiceClient.ExportAssets(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportAssetsResponse, ExportAssetsRequest> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            ExportAssetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAssetsResponse, ExportAssetsRequest> retrievedResponse =
                assetServiceClient.PollOnceExportAssets(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAssetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchGetAssetsHistoryAsync</summary>
        public async Task BatchGetAssetsHistoryAsync_RequestObject()
        {
            // Snippet: BatchGetAssetsHistoryAsync(BatchGetAssetsHistoryRequest,CallSettings)
            // Additional: BatchGetAssetsHistoryAsync(BatchGetAssetsHistoryRequest,CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchGetAssetsHistoryRequest request = new BatchGetAssetsHistoryRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                ContentType = ContentType.Unspecified,
                ReadTimeWindow = new TimeWindow(),
            };
            // Make the request
            BatchGetAssetsHistoryResponse response = await assetServiceClient.BatchGetAssetsHistoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetAssetsHistory</summary>
        public void BatchGetAssetsHistory_RequestObject()
        {
            // Snippet: BatchGetAssetsHistory(BatchGetAssetsHistoryRequest,CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            BatchGetAssetsHistoryRequest request = new BatchGetAssetsHistoryRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                ContentType = ContentType.Unspecified,
                ReadTimeWindow = new TimeWindow(),
            };
            // Make the request
            BatchGetAssetsHistoryResponse response = assetServiceClient.BatchGetAssetsHistory(request);
            // End snippet
        }

    }
}
