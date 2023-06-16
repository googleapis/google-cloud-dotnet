// Copyright 2023 Google LLC
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
    using Google.Cloud.DocumentAI.V1Beta3;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDocumentServiceClientSnippets
    {
        /// <summary>Snippet for UpdateDataset</summary>
        public void UpdateDatasetRequestObject()
        {
            // Snippet: UpdateDataset(UpdateDatasetRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Dataset, UpdateDatasetOperationMetadata> response = documentServiceClient.UpdateDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, UpdateDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, UpdateDatasetOperationMetadata> retrievedResponse = documentServiceClient.PollOnceUpdateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetAsync</summary>
        public async Task UpdateDatasetRequestObjectAsync()
        {
            // Snippet: UpdateDatasetAsync(UpdateDatasetRequest, CallSettings)
            // Additional: UpdateDatasetAsync(UpdateDatasetRequest, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Dataset, UpdateDatasetOperationMetadata> response = await documentServiceClient.UpdateDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, UpdateDatasetOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, UpdateDatasetOperationMetadata> retrievedResponse = await documentServiceClient.PollOnceUpdateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataset</summary>
        public void UpdateDataset()
        {
            // Snippet: UpdateDataset(Dataset, FieldMask, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Dataset, UpdateDatasetOperationMetadata> response = documentServiceClient.UpdateDataset(dataset, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, UpdateDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, UpdateDatasetOperationMetadata> retrievedResponse = documentServiceClient.PollOnceUpdateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetAsync</summary>
        public async Task UpdateDatasetAsync()
        {
            // Snippet: UpdateDatasetAsync(Dataset, FieldMask, CallSettings)
            // Additional: UpdateDatasetAsync(Dataset, FieldMask, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Dataset, UpdateDatasetOperationMetadata> response = await documentServiceClient.UpdateDatasetAsync(dataset, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, UpdateDatasetOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, UpdateDatasetOperationMetadata> retrievedResponse = await documentServiceClient.PollOnceUpdateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDatasetSchema</summary>
        public void GetDatasetSchemaRequestObject()
        {
            // Snippet: GetDatasetSchema(GetDatasetSchemaRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            GetDatasetSchemaRequest request = new GetDatasetSchemaRequest
            {
                DatasetSchemaName = DatasetSchemaName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                VisibleFieldsOnly = false,
            };
            // Make the request
            DatasetSchema response = documentServiceClient.GetDatasetSchema(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetSchemaAsync</summary>
        public async Task GetDatasetSchemaRequestObjectAsync()
        {
            // Snippet: GetDatasetSchemaAsync(GetDatasetSchemaRequest, CallSettings)
            // Additional: GetDatasetSchemaAsync(GetDatasetSchemaRequest, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDatasetSchemaRequest request = new GetDatasetSchemaRequest
            {
                DatasetSchemaName = DatasetSchemaName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                VisibleFieldsOnly = false,
            };
            // Make the request
            DatasetSchema response = await documentServiceClient.GetDatasetSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetSchema</summary>
        public void GetDatasetSchema()
        {
            // Snippet: GetDatasetSchema(string, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/dataset/datasetSchema";
            // Make the request
            DatasetSchema response = documentServiceClient.GetDatasetSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetSchemaAsync</summary>
        public async Task GetDatasetSchemaAsync()
        {
            // Snippet: GetDatasetSchemaAsync(string, CallSettings)
            // Additional: GetDatasetSchemaAsync(string, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/dataset/datasetSchema";
            // Make the request
            DatasetSchema response = await documentServiceClient.GetDatasetSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetSchema</summary>
        public void GetDatasetSchemaResourceNames()
        {
            // Snippet: GetDatasetSchema(DatasetSchemaName, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            DatasetSchemaName name = DatasetSchemaName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            DatasetSchema response = documentServiceClient.GetDatasetSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetSchemaAsync</summary>
        public async Task GetDatasetSchemaResourceNamesAsync()
        {
            // Snippet: GetDatasetSchemaAsync(DatasetSchemaName, CallSettings)
            // Additional: GetDatasetSchemaAsync(DatasetSchemaName, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetSchemaName name = DatasetSchemaName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            DatasetSchema response = await documentServiceClient.GetDatasetSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetSchema</summary>
        public void UpdateDatasetSchemaRequestObject()
        {
            // Snippet: UpdateDatasetSchema(UpdateDatasetSchemaRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            UpdateDatasetSchemaRequest request = new UpdateDatasetSchemaRequest
            {
                DatasetSchema = new DatasetSchema(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DatasetSchema response = documentServiceClient.UpdateDatasetSchema(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetSchemaAsync</summary>
        public async Task UpdateDatasetSchemaRequestObjectAsync()
        {
            // Snippet: UpdateDatasetSchemaAsync(UpdateDatasetSchemaRequest, CallSettings)
            // Additional: UpdateDatasetSchemaAsync(UpdateDatasetSchemaRequest, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatasetSchemaRequest request = new UpdateDatasetSchemaRequest
            {
                DatasetSchema = new DatasetSchema(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DatasetSchema response = await documentServiceClient.UpdateDatasetSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetSchema</summary>
        public void UpdateDatasetSchema()
        {
            // Snippet: UpdateDatasetSchema(DatasetSchema, FieldMask, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            DatasetSchema datasetSchema = new DatasetSchema();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DatasetSchema response = documentServiceClient.UpdateDatasetSchema(datasetSchema, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetSchemaAsync</summary>
        public async Task UpdateDatasetSchemaAsync()
        {
            // Snippet: UpdateDatasetSchemaAsync(DatasetSchema, FieldMask, CallSettings)
            // Additional: UpdateDatasetSchemaAsync(DatasetSchema, FieldMask, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetSchema datasetSchema = new DatasetSchema();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DatasetSchema response = await documentServiceClient.UpdateDatasetSchemaAsync(datasetSchema, updateMask);
            // End snippet
        }
    }
}
