// Copyright 2022 Google LLC
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

namespace Google.Cloud.Run.V2.Snippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRevisionsClientSnippets
    {
        /// <summary>Snippet for GetRevision</summary>
        public void GetRevisionRequestObject()
        {
            // Snippet: GetRevision(GetRevisionRequest, CallSettings)
            // Create client
            RevisionsClient revisionsClient = RevisionsClient.Create();
            // Initialize request argument(s)
            GetRevisionRequest request = new GetRevisionRequest
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
            };
            // Make the request
            Revision response = revisionsClient.GetRevision(request);
            // End snippet
        }

        /// <summary>Snippet for GetRevisionAsync</summary>
        public async Task GetRevisionRequestObjectAsync()
        {
            // Snippet: GetRevisionAsync(GetRevisionRequest, CallSettings)
            // Additional: GetRevisionAsync(GetRevisionRequest, CancellationToken)
            // Create client
            RevisionsClient revisionsClient = await RevisionsClient.CreateAsync();
            // Initialize request argument(s)
            GetRevisionRequest request = new GetRevisionRequest
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
            };
            // Make the request
            Revision response = await revisionsClient.GetRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRevision</summary>
        public void GetRevision()
        {
            // Snippet: GetRevision(string, CallSettings)
            // Create client
            RevisionsClient revisionsClient = RevisionsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]/revisions/[REVISION]";
            // Make the request
            Revision response = revisionsClient.GetRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetRevisionAsync</summary>
        public async Task GetRevisionAsync()
        {
            // Snippet: GetRevisionAsync(string, CallSettings)
            // Additional: GetRevisionAsync(string, CancellationToken)
            // Create client
            RevisionsClient revisionsClient = await RevisionsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]/revisions/[REVISION]";
            // Make the request
            Revision response = await revisionsClient.GetRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRevision</summary>
        public void GetRevisionResourceNames()
        {
            // Snippet: GetRevision(RevisionName, CallSettings)
            // Create client
            RevisionsClient revisionsClient = RevisionsClient.Create();
            // Initialize request argument(s)
            RevisionName name = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]");
            // Make the request
            Revision response = revisionsClient.GetRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetRevisionAsync</summary>
        public async Task GetRevisionResourceNamesAsync()
        {
            // Snippet: GetRevisionAsync(RevisionName, CallSettings)
            // Additional: GetRevisionAsync(RevisionName, CancellationToken)
            // Create client
            RevisionsClient revisionsClient = await RevisionsClient.CreateAsync();
            // Initialize request argument(s)
            RevisionName name = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]");
            // Make the request
            Revision response = await revisionsClient.GetRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRevisions</summary>
        public void ListRevisionsRequestObject()
        {
            // Snippet: ListRevisions(ListRevisionsRequest, CallSettings)
            // Create client
            RevisionsClient revisionsClient = RevisionsClient.Create();
            // Initialize request argument(s)
            ListRevisionsRequest request = new ListRevisionsRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListRevisionsResponse, Revision> response = revisionsClient.ListRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Revision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Revision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Revision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Revision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRevisionsAsync</summary>
        public async Task ListRevisionsRequestObjectAsync()
        {
            // Snippet: ListRevisionsAsync(ListRevisionsRequest, CallSettings)
            // Create client
            RevisionsClient revisionsClient = await RevisionsClient.CreateAsync();
            // Initialize request argument(s)
            ListRevisionsRequest request = new ListRevisionsRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListRevisionsResponse, Revision> response = revisionsClient.ListRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Revision item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Revision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Revision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Revision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRevisions</summary>
        public void ListRevisions()
        {
            // Snippet: ListRevisions(string, string, int?, CallSettings)
            // Create client
            RevisionsClient revisionsClient = RevisionsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            PagedEnumerable<ListRevisionsResponse, Revision> response = revisionsClient.ListRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Revision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Revision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Revision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Revision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRevisionsAsync</summary>
        public async Task ListRevisionsAsync()
        {
            // Snippet: ListRevisionsAsync(string, string, int?, CallSettings)
            // Create client
            RevisionsClient revisionsClient = await RevisionsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            PagedAsyncEnumerable<ListRevisionsResponse, Revision> response = revisionsClient.ListRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Revision item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Revision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Revision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Revision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRevisions</summary>
        public void ListRevisionsResourceNames()
        {
            // Snippet: ListRevisions(ServiceName, string, int?, CallSettings)
            // Create client
            RevisionsClient revisionsClient = RevisionsClient.Create();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            PagedEnumerable<ListRevisionsResponse, Revision> response = revisionsClient.ListRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Revision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Revision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Revision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Revision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRevisionsAsync</summary>
        public async Task ListRevisionsResourceNamesAsync()
        {
            // Snippet: ListRevisionsAsync(ServiceName, string, int?, CallSettings)
            // Create client
            RevisionsClient revisionsClient = await RevisionsClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            PagedAsyncEnumerable<ListRevisionsResponse, Revision> response = revisionsClient.ListRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Revision item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Revision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Revision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Revision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteRevision</summary>
        public void DeleteRevisionRequestObject()
        {
            // Snippet: DeleteRevision(DeleteRevisionRequest, CallSettings)
            // Create client
            RevisionsClient revisionsClient = RevisionsClient.Create();
            // Initialize request argument(s)
            DeleteRevisionRequest request = new DeleteRevisionRequest
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Revision, Revision> response = revisionsClient.DeleteRevision(request);

            // Poll until the returned long-running operation is complete
            Operation<Revision, Revision> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Revision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Revision, Revision> retrievedResponse = revisionsClient.PollOnceDeleteRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Revision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRevisionAsync</summary>
        public async Task DeleteRevisionRequestObjectAsync()
        {
            // Snippet: DeleteRevisionAsync(DeleteRevisionRequest, CallSettings)
            // Additional: DeleteRevisionAsync(DeleteRevisionRequest, CancellationToken)
            // Create client
            RevisionsClient revisionsClient = await RevisionsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRevisionRequest request = new DeleteRevisionRequest
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Revision, Revision> response = await revisionsClient.DeleteRevisionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Revision, Revision> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Revision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Revision, Revision> retrievedResponse = await revisionsClient.PollOnceDeleteRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Revision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRevision</summary>
        public void DeleteRevision()
        {
            // Snippet: DeleteRevision(string, CallSettings)
            // Create client
            RevisionsClient revisionsClient = RevisionsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]/revisions/[REVISION]";
            // Make the request
            Operation<Revision, Revision> response = revisionsClient.DeleteRevision(name);

            // Poll until the returned long-running operation is complete
            Operation<Revision, Revision> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Revision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Revision, Revision> retrievedResponse = revisionsClient.PollOnceDeleteRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Revision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRevisionAsync</summary>
        public async Task DeleteRevisionAsync()
        {
            // Snippet: DeleteRevisionAsync(string, CallSettings)
            // Additional: DeleteRevisionAsync(string, CancellationToken)
            // Create client
            RevisionsClient revisionsClient = await RevisionsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]/revisions/[REVISION]";
            // Make the request
            Operation<Revision, Revision> response = await revisionsClient.DeleteRevisionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Revision, Revision> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Revision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Revision, Revision> retrievedResponse = await revisionsClient.PollOnceDeleteRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Revision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRevision</summary>
        public void DeleteRevisionResourceNames()
        {
            // Snippet: DeleteRevision(RevisionName, CallSettings)
            // Create client
            RevisionsClient revisionsClient = RevisionsClient.Create();
            // Initialize request argument(s)
            RevisionName name = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]");
            // Make the request
            Operation<Revision, Revision> response = revisionsClient.DeleteRevision(name);

            // Poll until the returned long-running operation is complete
            Operation<Revision, Revision> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Revision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Revision, Revision> retrievedResponse = revisionsClient.PollOnceDeleteRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Revision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRevisionAsync</summary>
        public async Task DeleteRevisionResourceNamesAsync()
        {
            // Snippet: DeleteRevisionAsync(RevisionName, CallSettings)
            // Additional: DeleteRevisionAsync(RevisionName, CancellationToken)
            // Create client
            RevisionsClient revisionsClient = await RevisionsClient.CreateAsync();
            // Initialize request argument(s)
            RevisionName name = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]");
            // Make the request
            Operation<Revision, Revision> response = await revisionsClient.DeleteRevisionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Revision, Revision> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Revision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Revision, Revision> retrievedResponse = await revisionsClient.PollOnceDeleteRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Revision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
