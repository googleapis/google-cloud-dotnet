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
    using Google.Cloud.Retail.V2;
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
                Parent = "",
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
                Parent = "",
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
                Parent = "",
                UserEvent = "",
                Uri = "",
                Ets = 0L,
                RawJson = "",
                PrebuiltRule = "",
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
                Parent = "",
                UserEvent = "",
                Uri = "",
                Ets = 0L,
                RawJson = "",
                PrebuiltRule = "",
            };
            // Make the request
            HttpBody response = await userEventServiceClient.CollectUserEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PurgeUserEvents</summary>
        public void PurgeUserEventsRequestObject()
        {
            // Snippet: PurgeUserEvents(PurgeUserEventsRequest, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            PurgeUserEventsRequest request = new PurgeUserEventsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<PurgeUserEventsResponse, PurgeMetadata> response = userEventServiceClient.PurgeUserEvents(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeUserEventsResponse, PurgeMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeUserEventsResponse, PurgeMetadata> retrievedResponse = userEventServiceClient.PollOncePurgeUserEvents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeUserEventsAsync</summary>
        public async Task PurgeUserEventsRequestObjectAsync()
        {
            // Snippet: PurgeUserEventsAsync(PurgeUserEventsRequest, CallSettings)
            // Additional: PurgeUserEventsAsync(PurgeUserEventsRequest, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            PurgeUserEventsRequest request = new PurgeUserEventsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<PurgeUserEventsResponse, PurgeMetadata> response = await userEventServiceClient.PurgeUserEventsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeUserEventsResponse, PurgeMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeUserEventsResponse, PurgeMetadata> retrievedResponse = await userEventServiceClient.PollOncePurgeUserEventsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
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
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                InputConfig = new UserEventInputConfig(),
                ErrorsConfig = new ImportErrorsConfig(),
            };
            // Make the request
            Operation<ImportUserEventsResponse, ImportMetadata> response = userEventServiceClient.ImportUserEvents(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportUserEventsResponse, ImportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportUserEventsResponse, ImportMetadata> retrievedResponse = userEventServiceClient.PollOnceImportUserEvents(operationName);
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
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                InputConfig = new UserEventInputConfig(),
                ErrorsConfig = new ImportErrorsConfig(),
            };
            // Make the request
            Operation<ImportUserEventsResponse, ImportMetadata> response = await userEventServiceClient.ImportUserEventsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportUserEventsResponse, ImportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportUserEventsResponse, ImportMetadata> retrievedResponse = await userEventServiceClient.PollOnceImportUserEventsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RejoinUserEvents</summary>
        public void RejoinUserEventsRequestObject()
        {
            // Snippet: RejoinUserEvents(RejoinUserEventsRequest, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            RejoinUserEventsRequest request = new RejoinUserEventsRequest
            {
                Parent = "",
                UserEventRejoinScope = RejoinUserEventsRequest.Types.UserEventRejoinScope.Unspecified,
            };
            // Make the request
            Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata> response = userEventServiceClient.RejoinUserEvents(request);

            // Poll until the returned long-running operation is complete
            Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RejoinUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata> retrievedResponse = userEventServiceClient.PollOnceRejoinUserEvents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RejoinUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RejoinUserEventsAsync</summary>
        public async Task RejoinUserEventsRequestObjectAsync()
        {
            // Snippet: RejoinUserEventsAsync(RejoinUserEventsRequest, CallSettings)
            // Additional: RejoinUserEventsAsync(RejoinUserEventsRequest, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            RejoinUserEventsRequest request = new RejoinUserEventsRequest
            {
                Parent = "",
                UserEventRejoinScope = RejoinUserEventsRequest.Types.UserEventRejoinScope.Unspecified,
            };
            // Make the request
            Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata> response = await userEventServiceClient.RejoinUserEventsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RejoinUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata> retrievedResponse = await userEventServiceClient.PollOnceRejoinUserEventsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RejoinUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
