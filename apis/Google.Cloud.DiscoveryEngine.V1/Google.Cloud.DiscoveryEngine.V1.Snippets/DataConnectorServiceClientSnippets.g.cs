// Copyright 2026 Google LLC
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
    using Google.Cloud.DiscoveryEngine.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataConnectorServiceClientSnippets
    {
        /// <summary>Snippet for SetUpDataConnector</summary>
        public void SetUpDataConnectorRequestObject()
        {
            // Snippet: SetUpDataConnector(SetUpDataConnectorRequest, CallSettings)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = DataConnectorServiceClient.Create();
            // Initialize request argument(s)
            SetUpDataConnectorRequest request = new SetUpDataConnectorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CollectionId = "",
                CollectionDisplayName = "",
                DataConnector = new DataConnector(),
            };
            // Make the request
            Operation<DataConnector, SetUpDataConnectorMetadata> response = dataConnectorServiceClient.SetUpDataConnector(request);

            // Poll until the returned long-running operation is complete
            Operation<DataConnector, SetUpDataConnectorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataConnector, SetUpDataConnectorMetadata> retrievedResponse = dataConnectorServiceClient.PollOnceSetUpDataConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUpDataConnectorAsync</summary>
        public async Task SetUpDataConnectorRequestObjectAsync()
        {
            // Snippet: SetUpDataConnectorAsync(SetUpDataConnectorRequest, CallSettings)
            // Additional: SetUpDataConnectorAsync(SetUpDataConnectorRequest, CancellationToken)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = await DataConnectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetUpDataConnectorRequest request = new SetUpDataConnectorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CollectionId = "",
                CollectionDisplayName = "",
                DataConnector = new DataConnector(),
            };
            // Make the request
            Operation<DataConnector, SetUpDataConnectorMetadata> response = await dataConnectorServiceClient.SetUpDataConnectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DataConnector, SetUpDataConnectorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataConnector, SetUpDataConnectorMetadata> retrievedResponse = await dataConnectorServiceClient.PollOnceSetUpDataConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUpDataConnector</summary>
        public void SetUpDataConnector()
        {
            // Snippet: SetUpDataConnector(string, string, string, DataConnector, CallSettings)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = DataConnectorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string collectionId = "";
            string collectionDisplayName = "";
            DataConnector dataConnector = new DataConnector();
            // Make the request
            Operation<DataConnector, SetUpDataConnectorMetadata> response = dataConnectorServiceClient.SetUpDataConnector(parent, collectionId, collectionDisplayName, dataConnector);

            // Poll until the returned long-running operation is complete
            Operation<DataConnector, SetUpDataConnectorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataConnector, SetUpDataConnectorMetadata> retrievedResponse = dataConnectorServiceClient.PollOnceSetUpDataConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUpDataConnectorAsync</summary>
        public async Task SetUpDataConnectorAsync()
        {
            // Snippet: SetUpDataConnectorAsync(string, string, string, DataConnector, CallSettings)
            // Additional: SetUpDataConnectorAsync(string, string, string, DataConnector, CancellationToken)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = await DataConnectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string collectionId = "";
            string collectionDisplayName = "";
            DataConnector dataConnector = new DataConnector();
            // Make the request
            Operation<DataConnector, SetUpDataConnectorMetadata> response = await dataConnectorServiceClient.SetUpDataConnectorAsync(parent, collectionId, collectionDisplayName, dataConnector);

            // Poll until the returned long-running operation is complete
            Operation<DataConnector, SetUpDataConnectorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataConnector, SetUpDataConnectorMetadata> retrievedResponse = await dataConnectorServiceClient.PollOnceSetUpDataConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUpDataConnector</summary>
        public void SetUpDataConnectorResourceNames()
        {
            // Snippet: SetUpDataConnector(LocationName, string, string, DataConnector, CallSettings)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = DataConnectorServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string collectionId = "";
            string collectionDisplayName = "";
            DataConnector dataConnector = new DataConnector();
            // Make the request
            Operation<DataConnector, SetUpDataConnectorMetadata> response = dataConnectorServiceClient.SetUpDataConnector(parent, collectionId, collectionDisplayName, dataConnector);

            // Poll until the returned long-running operation is complete
            Operation<DataConnector, SetUpDataConnectorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataConnector, SetUpDataConnectorMetadata> retrievedResponse = dataConnectorServiceClient.PollOnceSetUpDataConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUpDataConnectorAsync</summary>
        public async Task SetUpDataConnectorResourceNamesAsync()
        {
            // Snippet: SetUpDataConnectorAsync(LocationName, string, string, DataConnector, CallSettings)
            // Additional: SetUpDataConnectorAsync(LocationName, string, string, DataConnector, CancellationToken)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = await DataConnectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string collectionId = "";
            string collectionDisplayName = "";
            DataConnector dataConnector = new DataConnector();
            // Make the request
            Operation<DataConnector, SetUpDataConnectorMetadata> response = await dataConnectorServiceClient.SetUpDataConnectorAsync(parent, collectionId, collectionDisplayName, dataConnector);

            // Poll until the returned long-running operation is complete
            Operation<DataConnector, SetUpDataConnectorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataConnector, SetUpDataConnectorMetadata> retrievedResponse = await dataConnectorServiceClient.PollOnceSetUpDataConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDataConnector</summary>
        public void GetDataConnectorRequestObject()
        {
            // Snippet: GetDataConnector(GetDataConnectorRequest, CallSettings)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = DataConnectorServiceClient.Create();
            // Initialize request argument(s)
            GetDataConnectorRequest request = new GetDataConnectorRequest
            {
                DataConnectorName = DataConnectorName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
            };
            // Make the request
            DataConnector response = dataConnectorServiceClient.GetDataConnector(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataConnectorAsync</summary>
        public async Task GetDataConnectorRequestObjectAsync()
        {
            // Snippet: GetDataConnectorAsync(GetDataConnectorRequest, CallSettings)
            // Additional: GetDataConnectorAsync(GetDataConnectorRequest, CancellationToken)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = await DataConnectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataConnectorRequest request = new GetDataConnectorRequest
            {
                DataConnectorName = DataConnectorName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
            };
            // Make the request
            DataConnector response = await dataConnectorServiceClient.GetDataConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataConnector</summary>
        public void GetDataConnector()
        {
            // Snippet: GetDataConnector(string, CallSettings)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = DataConnectorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/dataConnector";
            // Make the request
            DataConnector response = dataConnectorServiceClient.GetDataConnector(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataConnectorAsync</summary>
        public async Task GetDataConnectorAsync()
        {
            // Snippet: GetDataConnectorAsync(string, CallSettings)
            // Additional: GetDataConnectorAsync(string, CancellationToken)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = await DataConnectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/dataConnector";
            // Make the request
            DataConnector response = await dataConnectorServiceClient.GetDataConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataConnector</summary>
        public void GetDataConnectorResourceNames()
        {
            // Snippet: GetDataConnector(DataConnectorName, CallSettings)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = DataConnectorServiceClient.Create();
            // Initialize request argument(s)
            DataConnectorName name = DataConnectorName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            // Make the request
            DataConnector response = dataConnectorServiceClient.GetDataConnector(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataConnectorAsync</summary>
        public async Task GetDataConnectorResourceNamesAsync()
        {
            // Snippet: GetDataConnectorAsync(DataConnectorName, CallSettings)
            // Additional: GetDataConnectorAsync(DataConnectorName, CancellationToken)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = await DataConnectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataConnectorName name = DataConnectorName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            // Make the request
            DataConnector response = await dataConnectorServiceClient.GetDataConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataConnector</summary>
        public void UpdateDataConnectorRequestObject()
        {
            // Snippet: UpdateDataConnector(UpdateDataConnectorRequest, CallSettings)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = DataConnectorServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataConnectorRequest request = new UpdateDataConnectorRequest
            {
                DataConnector = new DataConnector(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataConnector response = dataConnectorServiceClient.UpdateDataConnector(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataConnectorAsync</summary>
        public async Task UpdateDataConnectorRequestObjectAsync()
        {
            // Snippet: UpdateDataConnectorAsync(UpdateDataConnectorRequest, CallSettings)
            // Additional: UpdateDataConnectorAsync(UpdateDataConnectorRequest, CancellationToken)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = await DataConnectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataConnectorRequest request = new UpdateDataConnectorRequest
            {
                DataConnector = new DataConnector(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataConnector response = await dataConnectorServiceClient.UpdateDataConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataConnector</summary>
        public void UpdateDataConnector()
        {
            // Snippet: UpdateDataConnector(DataConnector, FieldMask, CallSettings)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = DataConnectorServiceClient.Create();
            // Initialize request argument(s)
            DataConnector dataConnector = new DataConnector();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataConnector response = dataConnectorServiceClient.UpdateDataConnector(dataConnector, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataConnectorAsync</summary>
        public async Task UpdateDataConnectorAsync()
        {
            // Snippet: UpdateDataConnectorAsync(DataConnector, FieldMask, CallSettings)
            // Additional: UpdateDataConnectorAsync(DataConnector, FieldMask, CancellationToken)
            // Create client
            DataConnectorServiceClient dataConnectorServiceClient = await DataConnectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataConnector dataConnector = new DataConnector();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataConnector response = await dataConnectorServiceClient.UpdateDataConnectorAsync(dataConnector, updateMask);
            // End snippet
        }
    }
}
