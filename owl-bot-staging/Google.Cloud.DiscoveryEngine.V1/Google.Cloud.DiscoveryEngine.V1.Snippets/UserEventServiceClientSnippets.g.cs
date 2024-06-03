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

namespace GoogleCSharpSnippets
{
    using Google.Api;
    using Google.Cloud.DiscoveryEngine.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedUserEventServiceClientSnippets
    {
        /// <summary>Snippet for WriteUserEvent</summary>
        public void WriteUserEventRequestObject()
        {
            // Snippet: WriteUserEvent(WriteUserEventRequest, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            WriteUserEventRequest request = new WriteUserEventRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                UserEvent = new UserEvent(),
                WriteAsync = false,
            };
            // Make the request
            UserEvent response = userEventServiceClient.WriteUserEvent(request);
            // End snippet
        }

        /// <summary>Snippet for WriteUserEventAsync</summary>
        public async Task WriteUserEventRequestObjectAsync()
        {
            // Snippet: WriteUserEventAsync(WriteUserEventRequest, CallSettings)
            // Additional: WriteUserEventAsync(WriteUserEventRequest, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            WriteUserEventRequest request = new WriteUserEventRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                UserEvent = new UserEvent(),
                WriteAsync = false,
            };
            // Make the request
            UserEvent response = await userEventServiceClient.WriteUserEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CollectUserEvent</summary>
        public void CollectUserEventRequestObject()
        {
            // Snippet: CollectUserEvent(CollectUserEventRequest, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            CollectUserEventRequest request = new CollectUserEventRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                UserEvent = "",
                Uri = "",
                Ets = 0L,
            };
            // Make the request
            HttpBody response = userEventServiceClient.CollectUserEvent(request);
            // End snippet
        }

        /// <summary>Snippet for CollectUserEventAsync</summary>
        public async Task CollectUserEventRequestObjectAsync()
        {
            // Snippet: CollectUserEventAsync(CollectUserEventRequest, CallSettings)
            // Additional: CollectUserEventAsync(CollectUserEventRequest, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            CollectUserEventRequest request = new CollectUserEventRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                UserEvent = "",
                Uri = "",
                Ets = 0L,
            };
            // Make the request
            HttpBody response = await userEventServiceClient.CollectUserEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportUserEvents</summary>
        public void ImportUserEventsRequestObject()
        {
            // Snippet: ImportUserEvents(ImportUserEventsRequest, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            ImportUserEventsRequest request = new ImportUserEventsRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                InlineSource = new ImportUserEventsRequest.Types.InlineSource(),
                ErrorConfig = new ImportErrorConfig(),
            };
            // Make the request
            Operation<ImportUserEventsResponse, ImportUserEventsMetadata> response = userEventServiceClient.ImportUserEvents(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportUserEventsResponse, ImportUserEventsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportUserEventsResponse, ImportUserEventsMetadata> retrievedResponse = userEventServiceClient.PollOnceImportUserEvents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportUserEventsAsync</summary>
        public async Task ImportUserEventsRequestObjectAsync()
        {
            // Snippet: ImportUserEventsAsync(ImportUserEventsRequest, CallSettings)
            // Additional: ImportUserEventsAsync(ImportUserEventsRequest, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportUserEventsRequest request = new ImportUserEventsRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                InlineSource = new ImportUserEventsRequest.Types.InlineSource(),
                ErrorConfig = new ImportErrorConfig(),
            };
            // Make the request
            Operation<ImportUserEventsResponse, ImportUserEventsMetadata> response = await userEventServiceClient.ImportUserEventsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportUserEventsResponse, ImportUserEventsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportUserEventsResponse, ImportUserEventsMetadata> retrievedResponse = await userEventServiceClient.PollOnceImportUserEventsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
