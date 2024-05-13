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
    // [START aiplatform_v1_generated_DatasetService_CreateDataset_sync_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedDatasetServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataset</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateDatasetResourceNames()
        {
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Dataset dataset = new Dataset
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DisplayName = "",
                MetadataSchemaUri = "",
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
                Etag = "",
                Labels = { { "", "" }, },
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
                SavedQueries =
                {
                    new SavedQuery
                    {
                        SavedQueryName = SavedQueryName.FromProjectLocationDatasetSavedQuery("[PROJECT]", "[LOCATION]", "[DATASET]", "[SAVED_QUERY]"),
                        DisplayName = "",
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
                        AnnotationFilter = "",
                        ProblemType = "",
                        Etag = "",
                        SupportAutomlTraining = false,
                        AnnotationSpecCount = 0,
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
                    },
                },
                DataItemCount = 0L,
                EncryptionSpec = new EncryptionSpec { KmsKeyName = "", },
                Description = "",
                MetadataArtifact = "",
            };
            // Make the request
            Operation<Dataset, CreateDatasetOperationMetadata> response = datasetServiceClient.CreateDataset(parent, dataset);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, CreateDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, CreateDatasetOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceCreateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_DatasetService_CreateDataset_sync_flattened_resourceNames]
}
