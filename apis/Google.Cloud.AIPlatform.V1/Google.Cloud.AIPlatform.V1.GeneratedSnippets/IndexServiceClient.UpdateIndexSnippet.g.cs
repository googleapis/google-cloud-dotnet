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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    // [START aiplatform_v1_generated_IndexService_UpdateIndex_sync_flattened]
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedIndexServiceClientSnippets
    {
        /// <summary>Snippet for UpdateIndex</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void UpdateIndex()
        {
            // Create client
            IndexServiceClient indexServiceClient = IndexServiceClient.Create();
            // Initialize request argument(s)
            Index index = new Index
            {
                IndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
                DisplayName = "",
                Description = "",
                MetadataSchemaUri = "",
                Metadata = new wkt::Value
                {
                    NullValue = wkt::NullValue.NullValue,
                    NumberValue = 0,
                    StringValue = "",
                    BoolValue = false,
                    StructValue = new wkt::Struct
                    {
                        Fields =
                        {
                            {
                                "",
                                new wkt::Value { }
                            },
                        },
                    },
                    ListValue = new wkt::ListValue
                    {
                        Values = { new wkt::Value { }, },
                    },
                },
                DeployedIndexes =
                {
                    new DeployedIndexRef
                    {
                        IndexEndpointAsIndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                        DeployedIndexId = "",
                        DisplayName = "",
                    },
                },
                Etag = "",
                Labels = { { "", "" }, },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = 0L,
                    Nanos = 0,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = 0L,
                    Nanos = 0,
                },
                IndexStats = new IndexStats
                {
                    VectorsCount = 0L,
                    ShardsCount = 0,
                },
                IndexUpdateMethod = Index.Types.IndexUpdateMethod.Unspecified,
                EncryptionSpec = new EncryptionSpec { KmsKeyName = "", },
            };
            wkt::FieldMask updateMask = new wkt::FieldMask { Paths = { "", }, };
            // Make the request
            Operation<Index, UpdateIndexOperationMetadata> response = indexServiceClient.UpdateIndex(index, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Index, UpdateIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Index, UpdateIndexOperationMetadata> retrievedResponse = indexServiceClient.PollOnceUpdateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Index retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_IndexService_UpdateIndex_sync_flattened]
}
