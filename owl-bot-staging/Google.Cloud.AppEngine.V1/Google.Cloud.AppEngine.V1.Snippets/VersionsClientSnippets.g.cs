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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcav = Google.Cloud.AppEngine.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedVersionsClientSnippets
    {
        /// <summary>Snippet for ListVersions</summary>
        public void ListVersionsRequestObject()
        {
            // Snippet: ListVersions(ListVersionsRequest, CallSettings)
            // Create client
            gcav::VersionsClient versionsClient = gcav::VersionsClient.Create();
            // Initialize request argument(s)
            gcav::ListVersionsRequest request = new gcav::ListVersionsRequest
            {
                Parent = "",
                View = gcav::VersionView.Basic,
            };
            // Make the request
            PagedEnumerable<gcav::ListVersionsResponse, gcav::Version> response = versionsClient.ListVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Version item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Version> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVersionsAsync</summary>
        public async Task ListVersionsRequestObjectAsync()
        {
            // Snippet: ListVersionsAsync(ListVersionsRequest, CallSettings)
            // Create client
            gcav::VersionsClient versionsClient = await gcav::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListVersionsRequest request = new gcav::ListVersionsRequest
            {
                Parent = "",
                View = gcav::VersionView.Basic,
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListVersionsResponse, gcav::Version> response = versionsClient.ListVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Version item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Version> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetVersion</summary>
        public void GetVersionRequestObject()
        {
            // Snippet: GetVersion(GetVersionRequest, CallSettings)
            // Create client
            gcav::VersionsClient versionsClient = gcav::VersionsClient.Create();
            // Initialize request argument(s)
            gcav::GetVersionRequest request = new gcav::GetVersionRequest
            {
                Name = "",
                View = gcav::VersionView.Basic,
            };
            // Make the request
            gcav::Version response = versionsClient.GetVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetVersionAsync</summary>
        public async Task GetVersionRequestObjectAsync()
        {
            // Snippet: GetVersionAsync(GetVersionRequest, CallSettings)
            // Additional: GetVersionAsync(GetVersionRequest, CancellationToken)
            // Create client
            gcav::VersionsClient versionsClient = await gcav::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetVersionRequest request = new gcav::GetVersionRequest
            {
                Name = "",
                View = gcav::VersionView.Basic,
            };
            // Make the request
            gcav::Version response = await versionsClient.GetVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateVersion</summary>
        public void CreateVersionRequestObject()
        {
            // Snippet: CreateVersion(CreateVersionRequest, CallSettings)
            // Create client
            gcav::VersionsClient versionsClient = gcav::VersionsClient.Create();
            // Initialize request argument(s)
            gcav::CreateVersionRequest request = new gcav::CreateVersionRequest
            {
                Parent = "",
                Version = new gcav::Version(),
            };
            // Make the request
            Operation<gcav::Version, gcav::CreateVersionMetadataV1> response = versionsClient.CreateVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Version, gcav::CreateVersionMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Version result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Version, gcav::CreateVersionMetadataV1> retrievedResponse = versionsClient.PollOnceCreateVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Version retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVersionAsync</summary>
        public async Task CreateVersionRequestObjectAsync()
        {
            // Snippet: CreateVersionAsync(CreateVersionRequest, CallSettings)
            // Additional: CreateVersionAsync(CreateVersionRequest, CancellationToken)
            // Create client
            gcav::VersionsClient versionsClient = await gcav::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcav::CreateVersionRequest request = new gcav::CreateVersionRequest
            {
                Parent = "",
                Version = new gcav::Version(),
            };
            // Make the request
            Operation<gcav::Version, gcav::CreateVersionMetadataV1> response = await versionsClient.CreateVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Version, gcav::CreateVersionMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Version result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Version, gcav::CreateVersionMetadataV1> retrievedResponse = await versionsClient.PollOnceCreateVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Version retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVersion</summary>
        public void UpdateVersionRequestObject()
        {
            // Snippet: UpdateVersion(UpdateVersionRequest, CallSettings)
            // Create client
            gcav::VersionsClient versionsClient = gcav::VersionsClient.Create();
            // Initialize request argument(s)
            gcav::UpdateVersionRequest request = new gcav::UpdateVersionRequest
            {
                Name = "",
                Version = new gcav::Version(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcav::Version, gcav::OperationMetadataV1> response = versionsClient.UpdateVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Version, gcav::OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Version result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Version, gcav::OperationMetadataV1> retrievedResponse = versionsClient.PollOnceUpdateVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Version retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVersionAsync</summary>
        public async Task UpdateVersionRequestObjectAsync()
        {
            // Snippet: UpdateVersionAsync(UpdateVersionRequest, CallSettings)
            // Additional: UpdateVersionAsync(UpdateVersionRequest, CancellationToken)
            // Create client
            gcav::VersionsClient versionsClient = await gcav::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcav::UpdateVersionRequest request = new gcav::UpdateVersionRequest
            {
                Name = "",
                Version = new gcav::Version(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcav::Version, gcav::OperationMetadataV1> response = await versionsClient.UpdateVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Version, gcav::OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Version result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Version, gcav::OperationMetadataV1> retrievedResponse = await versionsClient.PollOnceUpdateVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Version retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVersion</summary>
        public void DeleteVersionRequestObject()
        {
            // Snippet: DeleteVersion(DeleteVersionRequest, CallSettings)
            // Create client
            gcav::VersionsClient versionsClient = gcav::VersionsClient.Create();
            // Initialize request argument(s)
            gcav::DeleteVersionRequest request = new gcav::DeleteVersionRequest { Name = "", };
            // Make the request
            Operation<Empty, gcav::OperationMetadataV1> response = versionsClient.DeleteVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadataV1> retrievedResponse = versionsClient.PollOnceDeleteVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVersionAsync</summary>
        public async Task DeleteVersionRequestObjectAsync()
        {
            // Snippet: DeleteVersionAsync(DeleteVersionRequest, CallSettings)
            // Additional: DeleteVersionAsync(DeleteVersionRequest, CancellationToken)
            // Create client
            gcav::VersionsClient versionsClient = await gcav::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DeleteVersionRequest request = new gcav::DeleteVersionRequest { Name = "", };
            // Make the request
            Operation<Empty, gcav::OperationMetadataV1> response = await versionsClient.DeleteVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadataV1> retrievedResponse = await versionsClient.PollOnceDeleteVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
