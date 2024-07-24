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
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dialogflow.V2Beta1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEnvironmentsClientSnippets
    {
        /// <summary>Snippet for ListEnvironments</summary>
        public void ListEnvironmentsRequestObject()
        {
            // Snippet: ListEnvironments(ListEnvironmentsRequest, CallSettings)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = gcdv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcdv::ListEnvironmentsRequest request = new gcdv::ListEnvironmentsRequest
            {
                ParentAsAgentName = gcdv::AgentName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<gcdv::ListEnvironmentsResponse, gcdv::Environment> response = environmentsClient.ListEnvironments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEnvironmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironmentsAsync</summary>
        public async Task ListEnvironmentsRequestObjectAsync()
        {
            // Snippet: ListEnvironmentsAsync(ListEnvironmentsRequest, CallSettings)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = await gcdv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListEnvironmentsRequest request = new gcdv::ListEnvironmentsRequest
            {
                ParentAsAgentName = gcdv::AgentName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEnvironmentsResponse, gcdv::Environment> response = environmentsClient.ListEnvironmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEnvironmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironments</summary>
        public void ListEnvironments()
        {
            // Snippet: ListEnvironments(string, string, int?, CallSettings)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = gcdv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            // Make the request
            PagedEnumerable<gcdv::ListEnvironmentsResponse, gcdv::Environment> response = environmentsClient.ListEnvironments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEnvironmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironmentsAsync</summary>
        public async Task ListEnvironmentsAsync()
        {
            // Snippet: ListEnvironmentsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = await gcdv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEnvironmentsResponse, gcdv::Environment> response = environmentsClient.ListEnvironmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEnvironmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironments</summary>
        public void ListEnvironmentsResourceNames()
        {
            // Snippet: ListEnvironments(AgentName, string, int?, CallSettings)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = gcdv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcdv::AgentName parent = gcdv::AgentName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<gcdv::ListEnvironmentsResponse, gcdv::Environment> response = environmentsClient.ListEnvironments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEnvironmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironmentsAsync</summary>
        public async Task ListEnvironmentsResourceNamesAsync()
        {
            // Snippet: ListEnvironmentsAsync(AgentName, string, int?, CallSettings)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = await gcdv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::AgentName parent = gcdv::AgentName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEnvironmentsResponse, gcdv::Environment> response = environmentsClient.ListEnvironmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEnvironmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironmentRequestObject()
        {
            // Snippet: GetEnvironment(GetEnvironmentRequest, CallSettings)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = gcdv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcdv::GetEnvironmentRequest request = new gcdv::GetEnvironmentRequest
            {
                EnvironmentName = gcdv::EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
            };
            // Make the request
            gcdv::Environment response = environmentsClient.GetEnvironment(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentAsync</summary>
        public async Task GetEnvironmentRequestObjectAsync()
        {
            // Snippet: GetEnvironmentAsync(GetEnvironmentRequest, CallSettings)
            // Additional: GetEnvironmentAsync(GetEnvironmentRequest, CancellationToken)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = await gcdv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetEnvironmentRequest request = new gcdv::GetEnvironmentRequest
            {
                EnvironmentName = gcdv::EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
            };
            // Make the request
            gcdv::Environment response = await environmentsClient.GetEnvironmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironment</summary>
        public void CreateEnvironmentRequestObject()
        {
            // Snippet: CreateEnvironment(CreateEnvironmentRequest, CallSettings)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = gcdv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcdv::CreateEnvironmentRequest request = new gcdv::CreateEnvironmentRequest
            {
                ParentAsAgentName = gcdv::AgentName.FromProject("[PROJECT]"),
                Environment = new gcdv::Environment(),
                EnvironmentId = "",
            };
            // Make the request
            gcdv::Environment response = environmentsClient.CreateEnvironment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironmentAsync</summary>
        public async Task CreateEnvironmentRequestObjectAsync()
        {
            // Snippet: CreateEnvironmentAsync(CreateEnvironmentRequest, CallSettings)
            // Additional: CreateEnvironmentAsync(CreateEnvironmentRequest, CancellationToken)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = await gcdv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateEnvironmentRequest request = new gcdv::CreateEnvironmentRequest
            {
                ParentAsAgentName = gcdv::AgentName.FromProject("[PROJECT]"),
                Environment = new gcdv::Environment(),
                EnvironmentId = "",
            };
            // Make the request
            gcdv::Environment response = await environmentsClient.CreateEnvironmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEnvironment</summary>
        public void UpdateEnvironmentRequestObject()
        {
            // Snippet: UpdateEnvironment(UpdateEnvironmentRequest, CallSettings)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = gcdv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateEnvironmentRequest request = new gcdv::UpdateEnvironmentRequest
            {
                Environment = new gcdv::Environment(),
                UpdateMask = new FieldMask(),
                AllowLoadToDraftAndDiscardChanges = false,
            };
            // Make the request
            gcdv::Environment response = environmentsClient.UpdateEnvironment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEnvironmentAsync</summary>
        public async Task UpdateEnvironmentRequestObjectAsync()
        {
            // Snippet: UpdateEnvironmentAsync(UpdateEnvironmentRequest, CallSettings)
            // Additional: UpdateEnvironmentAsync(UpdateEnvironmentRequest, CancellationToken)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = await gcdv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateEnvironmentRequest request = new gcdv::UpdateEnvironmentRequest
            {
                Environment = new gcdv::Environment(),
                UpdateMask = new FieldMask(),
                AllowLoadToDraftAndDiscardChanges = false,
            };
            // Make the request
            gcdv::Environment response = await environmentsClient.UpdateEnvironmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironment</summary>
        public void DeleteEnvironmentRequestObject()
        {
            // Snippet: DeleteEnvironment(DeleteEnvironmentRequest, CallSettings)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = gcdv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteEnvironmentRequest request = new gcdv::DeleteEnvironmentRequest
            {
                EnvironmentName = gcdv::EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
            };
            // Make the request
            environmentsClient.DeleteEnvironment(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironmentAsync</summary>
        public async Task DeleteEnvironmentRequestObjectAsync()
        {
            // Snippet: DeleteEnvironmentAsync(DeleteEnvironmentRequest, CallSettings)
            // Additional: DeleteEnvironmentAsync(DeleteEnvironmentRequest, CancellationToken)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = await gcdv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteEnvironmentRequest request = new gcdv::DeleteEnvironmentRequest
            {
                EnvironmentName = gcdv::EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
            };
            // Make the request
            await environmentsClient.DeleteEnvironmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentHistory</summary>
        public void GetEnvironmentHistoryRequestObject()
        {
            // Snippet: GetEnvironmentHistory(GetEnvironmentHistoryRequest, CallSettings)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = gcdv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcdv::GetEnvironmentHistoryRequest request = new gcdv::GetEnvironmentHistoryRequest
            {
                ParentAsEnvironmentName = gcdv::EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
            };
            // Make the request
            PagedEnumerable<gcdv::EnvironmentHistory, gcdv::EnvironmentHistory.Types.Entry> response = environmentsClient.GetEnvironmentHistory(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::EnvironmentHistory.Types.Entry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::EnvironmentHistory page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EnvironmentHistory.Types.Entry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EnvironmentHistory.Types.Entry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EnvironmentHistory.Types.Entry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentHistoryAsync</summary>
        public async Task GetEnvironmentHistoryRequestObjectAsync()
        {
            // Snippet: GetEnvironmentHistoryAsync(GetEnvironmentHistoryRequest, CallSettings)
            // Create client
            gcdv::EnvironmentsClient environmentsClient = await gcdv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetEnvironmentHistoryRequest request = new gcdv::GetEnvironmentHistoryRequest
            {
                ParentAsEnvironmentName = gcdv::EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::EnvironmentHistory, gcdv::EnvironmentHistory.Types.Entry> response = environmentsClient.GetEnvironmentHistoryAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::EnvironmentHistory.Types.Entry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::EnvironmentHistory page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EnvironmentHistory.Types.Entry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EnvironmentHistory.Types.Entry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EnvironmentHistory.Types.Entry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
