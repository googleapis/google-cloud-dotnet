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
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcdcv = Google.Cloud.Dialogflow.Cx.V3;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedVersionsClientSnippets
    {
        /// <summary>Snippet for ListVersions</summary>
        public void ListVersionsRequestObject()
        {
            // Snippet: ListVersions(ListVersionsRequest, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            gcdcv::ListVersionsRequest request = new gcdcv::ListVersionsRequest
            {
                ParentAsFlowName = gcdcv::FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            // Make the request
            PagedEnumerable<gcdcv::ListVersionsResponse, gcdcv::Version> response = versionsClient.ListVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdcv::Version item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdcv::ListVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Version> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Version item in singlePage)
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
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::ListVersionsRequest request = new gcdcv::ListVersionsRequest
            {
                ParentAsFlowName = gcdcv::FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdcv::ListVersionsResponse, gcdcv::Version> response = versionsClient.ListVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdcv::Version item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdcv::ListVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Version> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVersions</summary>
        public void ListVersions()
        {
            // Snippet: ListVersions(string, string, int?, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            // Make the request
            PagedEnumerable<gcdcv::ListVersionsResponse, gcdcv::Version> response = versionsClient.ListVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdcv::Version item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdcv::ListVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Version> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVersionsAsync</summary>
        public async Task ListVersionsAsync()
        {
            // Snippet: ListVersionsAsync(string, string, int?, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            // Make the request
            PagedAsyncEnumerable<gcdcv::ListVersionsResponse, gcdcv::Version> response = versionsClient.ListVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdcv::Version item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdcv::ListVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Version> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVersions</summary>
        public void ListVersionsResourceNames()
        {
            // Snippet: ListVersions(FlowName, string, int?, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            gcdcv::FlowName parent = gcdcv::FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            // Make the request
            PagedEnumerable<gcdcv::ListVersionsResponse, gcdcv::Version> response = versionsClient.ListVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdcv::Version item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdcv::ListVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Version> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVersionsAsync</summary>
        public async Task ListVersionsResourceNamesAsync()
        {
            // Snippet: ListVersionsAsync(FlowName, string, int?, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::FlowName parent = gcdcv::FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            // Make the request
            PagedAsyncEnumerable<gcdcv::ListVersionsResponse, gcdcv::Version> response = versionsClient.ListVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdcv::Version item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdcv::ListVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Version> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Version item in singlePage)
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
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            gcdcv::GetVersionRequest request = new gcdcv::GetVersionRequest
            {
                VersionName = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            // Make the request
            gcdcv::Version response = versionsClient.GetVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetVersionAsync</summary>
        public async Task GetVersionRequestObjectAsync()
        {
            // Snippet: GetVersionAsync(GetVersionRequest, CallSettings)
            // Additional: GetVersionAsync(GetVersionRequest, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::GetVersionRequest request = new gcdcv::GetVersionRequest
            {
                VersionName = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            // Make the request
            gcdcv::Version response = await versionsClient.GetVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVersion</summary>
        public void GetVersion()
        {
            // Snippet: GetVersion(string, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/versions/[VERSION]";
            // Make the request
            gcdcv::Version response = versionsClient.GetVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetVersionAsync</summary>
        public async Task GetVersionAsync()
        {
            // Snippet: GetVersionAsync(string, CallSettings)
            // Additional: GetVersionAsync(string, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/versions/[VERSION]";
            // Make the request
            gcdcv::Version response = await versionsClient.GetVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVersion</summary>
        public void GetVersionResourceNames()
        {
            // Snippet: GetVersion(VersionName, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            gcdcv::VersionName name = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]");
            // Make the request
            gcdcv::Version response = versionsClient.GetVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetVersionAsync</summary>
        public async Task GetVersionResourceNamesAsync()
        {
            // Snippet: GetVersionAsync(VersionName, CallSettings)
            // Additional: GetVersionAsync(VersionName, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::VersionName name = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]");
            // Make the request
            gcdcv::Version response = await versionsClient.GetVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateVersion</summary>
        public void CreateVersionRequestObject()
        {
            // Snippet: CreateVersion(CreateVersionRequest, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            gcdcv::CreateVersionRequest request = new gcdcv::CreateVersionRequest
            {
                ParentAsFlowName = gcdcv::FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                Version = new gcdcv::Version(),
            };
            // Make the request
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> response = versionsClient.CreateVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdcv::Version result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> retrievedResponse = versionsClient.PollOnceCreateVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Version retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVersionAsync</summary>
        public async Task CreateVersionRequestObjectAsync()
        {
            // Snippet: CreateVersionAsync(CreateVersionRequest, CallSettings)
            // Additional: CreateVersionAsync(CreateVersionRequest, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::CreateVersionRequest request = new gcdcv::CreateVersionRequest
            {
                ParentAsFlowName = gcdcv::FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                Version = new gcdcv::Version(),
            };
            // Make the request
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> response = await versionsClient.CreateVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdcv::Version result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> retrievedResponse = await versionsClient.PollOnceCreateVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Version retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVersion</summary>
        public void CreateVersion()
        {
            // Snippet: CreateVersion(string, Version, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            gcdcv::Version version = new gcdcv::Version();
            // Make the request
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> response = versionsClient.CreateVersion(parent, version);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdcv::Version result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> retrievedResponse = versionsClient.PollOnceCreateVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Version retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVersionAsync</summary>
        public async Task CreateVersionAsync()
        {
            // Snippet: CreateVersionAsync(string, Version, CallSettings)
            // Additional: CreateVersionAsync(string, Version, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            gcdcv::Version version = new gcdcv::Version();
            // Make the request
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> response = await versionsClient.CreateVersionAsync(parent, version);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdcv::Version result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> retrievedResponse = await versionsClient.PollOnceCreateVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Version retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVersion</summary>
        public void CreateVersionResourceNames()
        {
            // Snippet: CreateVersion(FlowName, Version, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            gcdcv::FlowName parent = gcdcv::FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            gcdcv::Version version = new gcdcv::Version();
            // Make the request
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> response = versionsClient.CreateVersion(parent, version);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdcv::Version result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> retrievedResponse = versionsClient.PollOnceCreateVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Version retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVersionAsync</summary>
        public async Task CreateVersionResourceNamesAsync()
        {
            // Snippet: CreateVersionAsync(FlowName, Version, CallSettings)
            // Additional: CreateVersionAsync(FlowName, Version, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::FlowName parent = gcdcv::FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            gcdcv::Version version = new gcdcv::Version();
            // Make the request
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> response = await versionsClient.CreateVersionAsync(parent, version);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdcv::Version result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Version, gcdcv::CreateVersionOperationMetadata> retrievedResponse = await versionsClient.PollOnceCreateVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Version retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVersion</summary>
        public void UpdateVersionRequestObject()
        {
            // Snippet: UpdateVersion(UpdateVersionRequest, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            gcdcv::UpdateVersionRequest request = new gcdcv::UpdateVersionRequest
            {
                Version = new gcdcv::Version(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcdcv::Version response = versionsClient.UpdateVersion(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateVersionAsync</summary>
        public async Task UpdateVersionRequestObjectAsync()
        {
            // Snippet: UpdateVersionAsync(UpdateVersionRequest, CallSettings)
            // Additional: UpdateVersionAsync(UpdateVersionRequest, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::UpdateVersionRequest request = new gcdcv::UpdateVersionRequest
            {
                Version = new gcdcv::Version(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcdcv::Version response = await versionsClient.UpdateVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateVersion</summary>
        public void UpdateVersion()
        {
            // Snippet: UpdateVersion(Version, FieldMask, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            gcdcv::Version version = new gcdcv::Version();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdcv::Version response = versionsClient.UpdateVersion(version, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateVersionAsync</summary>
        public async Task UpdateVersionAsync()
        {
            // Snippet: UpdateVersionAsync(Version, FieldMask, CallSettings)
            // Additional: UpdateVersionAsync(Version, FieldMask, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::Version version = new gcdcv::Version();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdcv::Version response = await versionsClient.UpdateVersionAsync(version, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteVersion</summary>
        public void DeleteVersionRequestObject()
        {
            // Snippet: DeleteVersion(DeleteVersionRequest, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            gcdcv::DeleteVersionRequest request = new gcdcv::DeleteVersionRequest
            {
                VersionName = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            // Make the request
            versionsClient.DeleteVersion(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteVersionAsync</summary>
        public async Task DeleteVersionRequestObjectAsync()
        {
            // Snippet: DeleteVersionAsync(DeleteVersionRequest, CallSettings)
            // Additional: DeleteVersionAsync(DeleteVersionRequest, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::DeleteVersionRequest request = new gcdcv::DeleteVersionRequest
            {
                VersionName = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            // Make the request
            await versionsClient.DeleteVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteVersion</summary>
        public void DeleteVersion()
        {
            // Snippet: DeleteVersion(string, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/versions/[VERSION]";
            // Make the request
            versionsClient.DeleteVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteVersionAsync</summary>
        public async Task DeleteVersionAsync()
        {
            // Snippet: DeleteVersionAsync(string, CallSettings)
            // Additional: DeleteVersionAsync(string, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/versions/[VERSION]";
            // Make the request
            await versionsClient.DeleteVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteVersion</summary>
        public void DeleteVersionResourceNames()
        {
            // Snippet: DeleteVersion(VersionName, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            gcdcv::VersionName name = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]");
            // Make the request
            versionsClient.DeleteVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteVersionAsync</summary>
        public async Task DeleteVersionResourceNamesAsync()
        {
            // Snippet: DeleteVersionAsync(VersionName, CallSettings)
            // Additional: DeleteVersionAsync(VersionName, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::VersionName name = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]");
            // Make the request
            await versionsClient.DeleteVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LoadVersion</summary>
        public void LoadVersionRequestObject()
        {
            // Snippet: LoadVersion(LoadVersionRequest, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            gcdcv::LoadVersionRequest request = new gcdcv::LoadVersionRequest
            {
                VersionName = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                AllowOverrideAgentResources = false,
            };
            // Make the request
            Operation<Empty, Struct> response = versionsClient.LoadVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = versionsClient.PollOnceLoadVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LoadVersionAsync</summary>
        public async Task LoadVersionRequestObjectAsync()
        {
            // Snippet: LoadVersionAsync(LoadVersionRequest, CallSettings)
            // Additional: LoadVersionAsync(LoadVersionRequest, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::LoadVersionRequest request = new gcdcv::LoadVersionRequest
            {
                VersionName = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                AllowOverrideAgentResources = false,
            };
            // Make the request
            Operation<Empty, Struct> response = await versionsClient.LoadVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await versionsClient.PollOnceLoadVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LoadVersion</summary>
        public void LoadVersion()
        {
            // Snippet: LoadVersion(string, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/versions/[VERSION]";
            // Make the request
            Operation<Empty, Struct> response = versionsClient.LoadVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = versionsClient.PollOnceLoadVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LoadVersionAsync</summary>
        public async Task LoadVersionAsync()
        {
            // Snippet: LoadVersionAsync(string, CallSettings)
            // Additional: LoadVersionAsync(string, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/versions/[VERSION]";
            // Make the request
            Operation<Empty, Struct> response = await versionsClient.LoadVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await versionsClient.PollOnceLoadVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LoadVersion</summary>
        public void LoadVersionResourceNames()
        {
            // Snippet: LoadVersion(VersionName, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            gcdcv::VersionName name = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]");
            // Make the request
            Operation<Empty, Struct> response = versionsClient.LoadVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = versionsClient.PollOnceLoadVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LoadVersionAsync</summary>
        public async Task LoadVersionResourceNamesAsync()
        {
            // Snippet: LoadVersionAsync(VersionName, CallSettings)
            // Additional: LoadVersionAsync(VersionName, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::VersionName name = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]");
            // Make the request
            Operation<Empty, Struct> response = await versionsClient.LoadVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await versionsClient.PollOnceLoadVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CompareVersions</summary>
        public void CompareVersionsRequestObject()
        {
            // Snippet: CompareVersions(CompareVersionsRequest, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            gcdcv::CompareVersionsRequest request = new gcdcv::CompareVersionsRequest
            {
                BaseVersionAsVersionName = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                TargetVersionAsVersionName = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                LanguageCode = "",
            };
            // Make the request
            gcdcv::CompareVersionsResponse response = versionsClient.CompareVersions(request);
            // End snippet
        }

        /// <summary>Snippet for CompareVersionsAsync</summary>
        public async Task CompareVersionsRequestObjectAsync()
        {
            // Snippet: CompareVersionsAsync(CompareVersionsRequest, CallSettings)
            // Additional: CompareVersionsAsync(CompareVersionsRequest, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::CompareVersionsRequest request = new gcdcv::CompareVersionsRequest
            {
                BaseVersionAsVersionName = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                TargetVersionAsVersionName = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                LanguageCode = "",
            };
            // Make the request
            gcdcv::CompareVersionsResponse response = await versionsClient.CompareVersionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CompareVersions</summary>
        public void CompareVersions()
        {
            // Snippet: CompareVersions(string, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            string baseVersion = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/versions/[VERSION]";
            // Make the request
            gcdcv::CompareVersionsResponse response = versionsClient.CompareVersions(baseVersion);
            // End snippet
        }

        /// <summary>Snippet for CompareVersionsAsync</summary>
        public async Task CompareVersionsAsync()
        {
            // Snippet: CompareVersionsAsync(string, CallSettings)
            // Additional: CompareVersionsAsync(string, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            string baseVersion = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/versions/[VERSION]";
            // Make the request
            gcdcv::CompareVersionsResponse response = await versionsClient.CompareVersionsAsync(baseVersion);
            // End snippet
        }

        /// <summary>Snippet for CompareVersions</summary>
        public void CompareVersionsResourceNames()
        {
            // Snippet: CompareVersions(VersionName, CallSettings)
            // Create client
            gcdcv::VersionsClient versionsClient = gcdcv::VersionsClient.Create();
            // Initialize request argument(s)
            gcdcv::VersionName baseVersion = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]");
            // Make the request
            gcdcv::CompareVersionsResponse response = versionsClient.CompareVersions(baseVersion);
            // End snippet
        }

        /// <summary>Snippet for CompareVersionsAsync</summary>
        public async Task CompareVersionsResourceNamesAsync()
        {
            // Snippet: CompareVersionsAsync(VersionName, CallSettings)
            // Additional: CompareVersionsAsync(VersionName, CancellationToken)
            // Create client
            gcdcv::VersionsClient versionsClient = await gcdcv::VersionsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::VersionName baseVersion = gcdcv::VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]");
            // Make the request
            gcdcv::CompareVersionsResponse response = await versionsClient.CompareVersionsAsync(baseVersion);
            // End snippet
        }
    }
}
