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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataScanServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataScan</summary>
        public void CreateDataScanRequestObject()
        {
            // Snippet: CreateDataScan(CreateDataScanRequest, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateDataScanRequest request = new gcdv::CreateDataScanRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataScan = new gcdv::DataScan(),
                DataScanId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataScan, gcdv::OperationMetadata> response = dataScanServiceClient.CreateDataScan(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataScan, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataScan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataScan, gcdv::OperationMetadata> retrievedResponse = dataScanServiceClient.PollOnceCreateDataScan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataScan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataScanAsync</summary>
        public async Task CreateDataScanRequestObjectAsync()
        {
            // Snippet: CreateDataScanAsync(CreateDataScanRequest, CallSettings)
            // Additional: CreateDataScanAsync(CreateDataScanRequest, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateDataScanRequest request = new gcdv::CreateDataScanRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataScan = new gcdv::DataScan(),
                DataScanId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataScan, gcdv::OperationMetadata> response = await dataScanServiceClient.CreateDataScanAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataScan, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataScan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataScan, gcdv::OperationMetadata> retrievedResponse = await dataScanServiceClient.PollOnceCreateDataScanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataScan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataScan</summary>
        public void CreateDataScan()
        {
            // Snippet: CreateDataScan(string, DataScan, string, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::DataScan dataScan = new gcdv::DataScan();
            string dataScanId = "";
            // Make the request
            Operation<gcdv::DataScan, gcdv::OperationMetadata> response = dataScanServiceClient.CreateDataScan(parent, dataScan, dataScanId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataScan, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataScan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataScan, gcdv::OperationMetadata> retrievedResponse = dataScanServiceClient.PollOnceCreateDataScan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataScan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataScanAsync</summary>
        public async Task CreateDataScanAsync()
        {
            // Snippet: CreateDataScanAsync(string, DataScan, string, CallSettings)
            // Additional: CreateDataScanAsync(string, DataScan, string, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::DataScan dataScan = new gcdv::DataScan();
            string dataScanId = "";
            // Make the request
            Operation<gcdv::DataScan, gcdv::OperationMetadata> response = await dataScanServiceClient.CreateDataScanAsync(parent, dataScan, dataScanId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataScan, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataScan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataScan, gcdv::OperationMetadata> retrievedResponse = await dataScanServiceClient.PollOnceCreateDataScanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataScan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataScan</summary>
        public void CreateDataScanResourceNames()
        {
            // Snippet: CreateDataScan(LocationName, DataScan, string, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::DataScan dataScan = new gcdv::DataScan();
            string dataScanId = "";
            // Make the request
            Operation<gcdv::DataScan, gcdv::OperationMetadata> response = dataScanServiceClient.CreateDataScan(parent, dataScan, dataScanId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataScan, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataScan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataScan, gcdv::OperationMetadata> retrievedResponse = dataScanServiceClient.PollOnceCreateDataScan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataScan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataScanAsync</summary>
        public async Task CreateDataScanResourceNamesAsync()
        {
            // Snippet: CreateDataScanAsync(LocationName, DataScan, string, CallSettings)
            // Additional: CreateDataScanAsync(LocationName, DataScan, string, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::DataScan dataScan = new gcdv::DataScan();
            string dataScanId = "";
            // Make the request
            Operation<gcdv::DataScan, gcdv::OperationMetadata> response = await dataScanServiceClient.CreateDataScanAsync(parent, dataScan, dataScanId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataScan, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataScan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataScan, gcdv::OperationMetadata> retrievedResponse = await dataScanServiceClient.PollOnceCreateDataScanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataScan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataScan</summary>
        public void UpdateDataScanRequestObject()
        {
            // Snippet: UpdateDataScan(UpdateDataScanRequest, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateDataScanRequest request = new gcdv::UpdateDataScanRequest
            {
                DataScan = new gcdv::DataScan(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataScan, gcdv::OperationMetadata> response = dataScanServiceClient.UpdateDataScan(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataScan, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataScan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataScan, gcdv::OperationMetadata> retrievedResponse = dataScanServiceClient.PollOnceUpdateDataScan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataScan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataScanAsync</summary>
        public async Task UpdateDataScanRequestObjectAsync()
        {
            // Snippet: UpdateDataScanAsync(UpdateDataScanRequest, CallSettings)
            // Additional: UpdateDataScanAsync(UpdateDataScanRequest, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateDataScanRequest request = new gcdv::UpdateDataScanRequest
            {
                DataScan = new gcdv::DataScan(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataScan, gcdv::OperationMetadata> response = await dataScanServiceClient.UpdateDataScanAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataScan, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataScan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataScan, gcdv::OperationMetadata> retrievedResponse = await dataScanServiceClient.PollOnceUpdateDataScanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataScan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataScan</summary>
        public void UpdateDataScan()
        {
            // Snippet: UpdateDataScan(DataScan, FieldMask, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataScan dataScan = new gcdv::DataScan();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::DataScan, gcdv::OperationMetadata> response = dataScanServiceClient.UpdateDataScan(dataScan, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataScan, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataScan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataScan, gcdv::OperationMetadata> retrievedResponse = dataScanServiceClient.PollOnceUpdateDataScan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataScan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataScanAsync</summary>
        public async Task UpdateDataScanAsync()
        {
            // Snippet: UpdateDataScanAsync(DataScan, FieldMask, CallSettings)
            // Additional: UpdateDataScanAsync(DataScan, FieldMask, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataScan dataScan = new gcdv::DataScan();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::DataScan, gcdv::OperationMetadata> response = await dataScanServiceClient.UpdateDataScanAsync(dataScan, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataScan, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataScan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataScan, gcdv::OperationMetadata> retrievedResponse = await dataScanServiceClient.PollOnceUpdateDataScanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataScan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataScan</summary>
        public void DeleteDataScanRequestObject()
        {
            // Snippet: DeleteDataScan(DeleteDataScanRequest, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteDataScanRequest request = new gcdv::DeleteDataScanRequest
            {
                DataScanName = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataScanServiceClient.DeleteDataScan(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataScanServiceClient.PollOnceDeleteDataScan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataScanAsync</summary>
        public async Task DeleteDataScanRequestObjectAsync()
        {
            // Snippet: DeleteDataScanAsync(DeleteDataScanRequest, CallSettings)
            // Additional: DeleteDataScanAsync(DeleteDataScanRequest, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteDataScanRequest request = new gcdv::DeleteDataScanRequest
            {
                DataScanName = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataScanServiceClient.DeleteDataScanAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataScanServiceClient.PollOnceDeleteDataScanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataScan</summary>
        public void DeleteDataScan()
        {
            // Snippet: DeleteDataScan(string, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataScans/[DATASCAN]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataScanServiceClient.DeleteDataScan(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataScanServiceClient.PollOnceDeleteDataScan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataScanAsync</summary>
        public async Task DeleteDataScanAsync()
        {
            // Snippet: DeleteDataScanAsync(string, CallSettings)
            // Additional: DeleteDataScanAsync(string, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataScans/[DATASCAN]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataScanServiceClient.DeleteDataScanAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataScanServiceClient.PollOnceDeleteDataScanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataScan</summary>
        public void DeleteDataScanResourceNames()
        {
            // Snippet: DeleteDataScan(DataScanName, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataScanName name = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataScanServiceClient.DeleteDataScan(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataScanServiceClient.PollOnceDeleteDataScan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataScanAsync</summary>
        public async Task DeleteDataScanResourceNamesAsync()
        {
            // Snippet: DeleteDataScanAsync(DataScanName, CallSettings)
            // Additional: DeleteDataScanAsync(DataScanName, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataScanName name = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataScanServiceClient.DeleteDataScanAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataScanServiceClient.PollOnceDeleteDataScanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDataScan</summary>
        public void GetDataScanRequestObject()
        {
            // Snippet: GetDataScan(GetDataScanRequest, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetDataScanRequest request = new gcdv::GetDataScanRequest
            {
                DataScanName = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]"),
                View = gcdv::GetDataScanRequest.Types.DataScanView.Unspecified,
            };
            // Make the request
            gcdv::DataScan response = dataScanServiceClient.GetDataScan(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataScanAsync</summary>
        public async Task GetDataScanRequestObjectAsync()
        {
            // Snippet: GetDataScanAsync(GetDataScanRequest, CallSettings)
            // Additional: GetDataScanAsync(GetDataScanRequest, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetDataScanRequest request = new gcdv::GetDataScanRequest
            {
                DataScanName = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]"),
                View = gcdv::GetDataScanRequest.Types.DataScanView.Unspecified,
            };
            // Make the request
            gcdv::DataScan response = await dataScanServiceClient.GetDataScanAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataScan</summary>
        public void GetDataScan()
        {
            // Snippet: GetDataScan(string, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataScans/[DATASCAN]";
            // Make the request
            gcdv::DataScan response = dataScanServiceClient.GetDataScan(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataScanAsync</summary>
        public async Task GetDataScanAsync()
        {
            // Snippet: GetDataScanAsync(string, CallSettings)
            // Additional: GetDataScanAsync(string, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataScans/[DATASCAN]";
            // Make the request
            gcdv::DataScan response = await dataScanServiceClient.GetDataScanAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataScan</summary>
        public void GetDataScanResourceNames()
        {
            // Snippet: GetDataScan(DataScanName, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataScanName name = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]");
            // Make the request
            gcdv::DataScan response = dataScanServiceClient.GetDataScan(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataScanAsync</summary>
        public async Task GetDataScanResourceNamesAsync()
        {
            // Snippet: GetDataScanAsync(DataScanName, CallSettings)
            // Additional: GetDataScanAsync(DataScanName, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataScanName name = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]");
            // Make the request
            gcdv::DataScan response = await dataScanServiceClient.GetDataScanAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDataScans</summary>
        public void ListDataScansRequestObject()
        {
            // Snippet: ListDataScans(ListDataScansRequest, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListDataScansRequest request = new gcdv::ListDataScansRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListDataScansResponse, gcdv::DataScan> response = dataScanServiceClient.ListDataScans(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataScan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataScansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataScan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataScan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataScan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataScansAsync</summary>
        public async Task ListDataScansRequestObjectAsync()
        {
            // Snippet: ListDataScansAsync(ListDataScansRequest, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListDataScansRequest request = new gcdv::ListDataScansRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataScansResponse, gcdv::DataScan> response = dataScanServiceClient.ListDataScansAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataScan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataScansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataScan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataScan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataScan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataScans</summary>
        public void ListDataScans()
        {
            // Snippet: ListDataScans(string, string, int?, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::ListDataScansResponse, gcdv::DataScan> response = dataScanServiceClient.ListDataScans(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataScan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataScansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataScan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataScan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataScan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataScansAsync</summary>
        public async Task ListDataScansAsync()
        {
            // Snippet: ListDataScansAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataScansResponse, gcdv::DataScan> response = dataScanServiceClient.ListDataScansAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataScan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataScansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataScan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataScan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataScan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataScans</summary>
        public void ListDataScansResourceNames()
        {
            // Snippet: ListDataScans(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListDataScansResponse, gcdv::DataScan> response = dataScanServiceClient.ListDataScans(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataScan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataScansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataScan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataScan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataScan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataScansAsync</summary>
        public async Task ListDataScansResourceNamesAsync()
        {
            // Snippet: ListDataScansAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataScansResponse, gcdv::DataScan> response = dataScanServiceClient.ListDataScansAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataScan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataScansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataScan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataScan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataScan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RunDataScan</summary>
        public void RunDataScanRequestObject()
        {
            // Snippet: RunDataScan(RunDataScanRequest, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::RunDataScanRequest request = new gcdv::RunDataScanRequest
            {
                DataScanName = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]"),
            };
            // Make the request
            gcdv::RunDataScanResponse response = dataScanServiceClient.RunDataScan(request);
            // End snippet
        }

        /// <summary>Snippet for RunDataScanAsync</summary>
        public async Task RunDataScanRequestObjectAsync()
        {
            // Snippet: RunDataScanAsync(RunDataScanRequest, CallSettings)
            // Additional: RunDataScanAsync(RunDataScanRequest, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RunDataScanRequest request = new gcdv::RunDataScanRequest
            {
                DataScanName = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]"),
            };
            // Make the request
            gcdv::RunDataScanResponse response = await dataScanServiceClient.RunDataScanAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunDataScan</summary>
        public void RunDataScan()
        {
            // Snippet: RunDataScan(string, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataScans/[DATASCAN]";
            // Make the request
            gcdv::RunDataScanResponse response = dataScanServiceClient.RunDataScan(name);
            // End snippet
        }

        /// <summary>Snippet for RunDataScanAsync</summary>
        public async Task RunDataScanAsync()
        {
            // Snippet: RunDataScanAsync(string, CallSettings)
            // Additional: RunDataScanAsync(string, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataScans/[DATASCAN]";
            // Make the request
            gcdv::RunDataScanResponse response = await dataScanServiceClient.RunDataScanAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RunDataScan</summary>
        public void RunDataScanResourceNames()
        {
            // Snippet: RunDataScan(DataScanName, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataScanName name = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]");
            // Make the request
            gcdv::RunDataScanResponse response = dataScanServiceClient.RunDataScan(name);
            // End snippet
        }

        /// <summary>Snippet for RunDataScanAsync</summary>
        public async Task RunDataScanResourceNamesAsync()
        {
            // Snippet: RunDataScanAsync(DataScanName, CallSettings)
            // Additional: RunDataScanAsync(DataScanName, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataScanName name = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]");
            // Make the request
            gcdv::RunDataScanResponse response = await dataScanServiceClient.RunDataScanAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataScanJob</summary>
        public void GetDataScanJobRequestObject()
        {
            // Snippet: GetDataScanJob(GetDataScanJobRequest, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetDataScanJobRequest request = new gcdv::GetDataScanJobRequest
            {
                DataScanJobName = gcdv::DataScanJobName.FromProjectLocationDataScanJob("[PROJECT]", "[LOCATION]", "[DATASCAN]", "[JOB]"),
                View = gcdv::GetDataScanJobRequest.Types.DataScanJobView.Unspecified,
            };
            // Make the request
            gcdv::DataScanJob response = dataScanServiceClient.GetDataScanJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataScanJobAsync</summary>
        public async Task GetDataScanJobRequestObjectAsync()
        {
            // Snippet: GetDataScanJobAsync(GetDataScanJobRequest, CallSettings)
            // Additional: GetDataScanJobAsync(GetDataScanJobRequest, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetDataScanJobRequest request = new gcdv::GetDataScanJobRequest
            {
                DataScanJobName = gcdv::DataScanJobName.FromProjectLocationDataScanJob("[PROJECT]", "[LOCATION]", "[DATASCAN]", "[JOB]"),
                View = gcdv::GetDataScanJobRequest.Types.DataScanJobView.Unspecified,
            };
            // Make the request
            gcdv::DataScanJob response = await dataScanServiceClient.GetDataScanJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataScanJob</summary>
        public void GetDataScanJob()
        {
            // Snippet: GetDataScanJob(string, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataScans/[DATASCAN]/jobs/[JOB]";
            // Make the request
            gcdv::DataScanJob response = dataScanServiceClient.GetDataScanJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataScanJobAsync</summary>
        public async Task GetDataScanJobAsync()
        {
            // Snippet: GetDataScanJobAsync(string, CallSettings)
            // Additional: GetDataScanJobAsync(string, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataScans/[DATASCAN]/jobs/[JOB]";
            // Make the request
            gcdv::DataScanJob response = await dataScanServiceClient.GetDataScanJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataScanJob</summary>
        public void GetDataScanJobResourceNames()
        {
            // Snippet: GetDataScanJob(DataScanJobName, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataScanJobName name = gcdv::DataScanJobName.FromProjectLocationDataScanJob("[PROJECT]", "[LOCATION]", "[DATASCAN]", "[JOB]");
            // Make the request
            gcdv::DataScanJob response = dataScanServiceClient.GetDataScanJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataScanJobAsync</summary>
        public async Task GetDataScanJobResourceNamesAsync()
        {
            // Snippet: GetDataScanJobAsync(DataScanJobName, CallSettings)
            // Additional: GetDataScanJobAsync(DataScanJobName, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataScanJobName name = gcdv::DataScanJobName.FromProjectLocationDataScanJob("[PROJECT]", "[LOCATION]", "[DATASCAN]", "[JOB]");
            // Make the request
            gcdv::DataScanJob response = await dataScanServiceClient.GetDataScanJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDataScanJobs</summary>
        public void ListDataScanJobsRequestObject()
        {
            // Snippet: ListDataScanJobs(ListDataScanJobsRequest, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListDataScanJobsRequest request = new gcdv::ListDataScanJobsRequest
            {
                ParentAsDataScanName = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListDataScanJobsResponse, gcdv::DataScanJob> response = dataScanServiceClient.ListDataScanJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataScanJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataScanJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataScanJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataScanJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataScanJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataScanJobsAsync</summary>
        public async Task ListDataScanJobsRequestObjectAsync()
        {
            // Snippet: ListDataScanJobsAsync(ListDataScanJobsRequest, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListDataScanJobsRequest request = new gcdv::ListDataScanJobsRequest
            {
                ParentAsDataScanName = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataScanJobsResponse, gcdv::DataScanJob> response = dataScanServiceClient.ListDataScanJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataScanJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataScanJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataScanJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataScanJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataScanJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataScanJobs</summary>
        public void ListDataScanJobs()
        {
            // Snippet: ListDataScanJobs(string, string, int?, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataScans/[DATASCAN]";
            // Make the request
            PagedEnumerable<gcdv::ListDataScanJobsResponse, gcdv::DataScanJob> response = dataScanServiceClient.ListDataScanJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataScanJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataScanJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataScanJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataScanJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataScanJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataScanJobsAsync</summary>
        public async Task ListDataScanJobsAsync()
        {
            // Snippet: ListDataScanJobsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataScans/[DATASCAN]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataScanJobsResponse, gcdv::DataScanJob> response = dataScanServiceClient.ListDataScanJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataScanJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataScanJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataScanJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataScanJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataScanJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataScanJobs</summary>
        public void ListDataScanJobsResourceNames()
        {
            // Snippet: ListDataScanJobs(DataScanName, string, int?, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataScanName parent = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]");
            // Make the request
            PagedEnumerable<gcdv::ListDataScanJobsResponse, gcdv::DataScanJob> response = dataScanServiceClient.ListDataScanJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataScanJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataScanJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataScanJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataScanJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataScanJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataScanJobsAsync</summary>
        public async Task ListDataScanJobsResourceNamesAsync()
        {
            // Snippet: ListDataScanJobsAsync(DataScanName, string, int?, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataScanName parent = gcdv::DataScanName.FromProjectLocationDataScan("[PROJECT]", "[LOCATION]", "[DATASCAN]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataScanJobsResponse, gcdv::DataScanJob> response = dataScanServiceClient.ListDataScanJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataScanJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataScanJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataScanJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataScanJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataScanJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GenerateDataQualityRules</summary>
        public void GenerateDataQualityRulesRequestObject()
        {
            // Snippet: GenerateDataQualityRules(GenerateDataQualityRulesRequest, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GenerateDataQualityRulesRequest request = new gcdv::GenerateDataQualityRulesRequest { Name = "", };
            // Make the request
            gcdv::GenerateDataQualityRulesResponse response = dataScanServiceClient.GenerateDataQualityRules(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateDataQualityRulesAsync</summary>
        public async Task GenerateDataQualityRulesRequestObjectAsync()
        {
            // Snippet: GenerateDataQualityRulesAsync(GenerateDataQualityRulesRequest, CallSettings)
            // Additional: GenerateDataQualityRulesAsync(GenerateDataQualityRulesRequest, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GenerateDataQualityRulesRequest request = new gcdv::GenerateDataQualityRulesRequest { Name = "", };
            // Make the request
            gcdv::GenerateDataQualityRulesResponse response = await dataScanServiceClient.GenerateDataQualityRulesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateDataQualityRules</summary>
        public void GenerateDataQualityRules()
        {
            // Snippet: GenerateDataQualityRules(string, CallSettings)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = gcdv::DataScanServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            gcdv::GenerateDataQualityRulesResponse response = dataScanServiceClient.GenerateDataQualityRules(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateDataQualityRulesAsync</summary>
        public async Task GenerateDataQualityRulesAsync()
        {
            // Snippet: GenerateDataQualityRulesAsync(string, CallSettings)
            // Additional: GenerateDataQualityRulesAsync(string, CancellationToken)
            // Create client
            gcdv::DataScanServiceClient dataScanServiceClient = await gcdv::DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            gcdv::GenerateDataQualityRulesResponse response = await dataScanServiceClient.GenerateDataQualityRulesAsync(name);
            // End snippet
        }
    }
}
