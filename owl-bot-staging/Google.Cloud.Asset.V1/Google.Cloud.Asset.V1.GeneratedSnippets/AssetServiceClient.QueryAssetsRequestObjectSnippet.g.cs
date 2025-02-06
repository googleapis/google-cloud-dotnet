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
    // [START cloudasset_v1_generated_AssetService_QueryAssets_sync]
    using Google.Api.Gax;
    using Google.Cloud.Asset.V1;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedAssetServiceClientSnippets
    {
        /// <summary>Snippet for QueryAssets</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void QueryAssetsRequestObject()
        {
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            QueryAssetsRequest request = new QueryAssetsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Statement = "",
                PageSize = 0,
                PageToken = "",
                Timeout = new Duration(),
                ReadTimeWindow = new TimeWindow(),
                OutputConfig = new QueryAssetsOutputConfig(),
            };
            // Make the request
            QueryAssetsResponse response = assetServiceClient.QueryAssets(request);
        }
    }
    // [END cloudasset_v1_generated_AssetService_QueryAssets_sync]
}
