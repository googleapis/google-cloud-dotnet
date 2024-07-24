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
    using Google.Api.Gax;
    using Google.Cloud.ResourceManager.V3;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTagHoldsClientSnippets
    {
        /// <summary>Snippet for CreateTagHold</summary>
        public void CreateTagHoldRequestObject()
        {
            // Snippet: CreateTagHold(CreateTagHoldRequest, CallSettings)
            // Create client
            TagHoldsClient tagHoldsClient = TagHoldsClient.Create();
            // Initialize request argument(s)
            CreateTagHoldRequest request = new CreateTagHoldRequest
            {
                ParentAsTagValueName = TagValueName.FromTagValue("[TAG_VALUE]"),
                TagHold = new TagHold(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<TagHold, CreateTagHoldMetadata> response = tagHoldsClient.CreateTagHold(request);

            // Poll until the returned long-running operation is complete
            Operation<TagHold, CreateTagHoldMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagHold result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagHold, CreateTagHoldMetadata> retrievedResponse = tagHoldsClient.PollOnceCreateTagHold(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagHold retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTagHoldAsync</summary>
        public async Task CreateTagHoldRequestObjectAsync()
        {
            // Snippet: CreateTagHoldAsync(CreateTagHoldRequest, CallSettings)
            // Additional: CreateTagHoldAsync(CreateTagHoldRequest, CancellationToken)
            // Create client
            TagHoldsClient tagHoldsClient = await TagHoldsClient.CreateAsync();
            // Initialize request argument(s)
            CreateTagHoldRequest request = new CreateTagHoldRequest
            {
                ParentAsTagValueName = TagValueName.FromTagValue("[TAG_VALUE]"),
                TagHold = new TagHold(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<TagHold, CreateTagHoldMetadata> response = await tagHoldsClient.CreateTagHoldAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TagHold, CreateTagHoldMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagHold result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagHold, CreateTagHoldMetadata> retrievedResponse = await tagHoldsClient.PollOnceCreateTagHoldAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagHold retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTagHold</summary>
        public void CreateTagHold()
        {
            // Snippet: CreateTagHold(string, TagHold, CallSettings)
            // Create client
            TagHoldsClient tagHoldsClient = TagHoldsClient.Create();
            // Initialize request argument(s)
            string parent = "tagValues/[TAG_VALUE]";
            TagHold tagHold = new TagHold();
            // Make the request
            Operation<TagHold, CreateTagHoldMetadata> response = tagHoldsClient.CreateTagHold(parent, tagHold);

            // Poll until the returned long-running operation is complete
            Operation<TagHold, CreateTagHoldMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagHold result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagHold, CreateTagHoldMetadata> retrievedResponse = tagHoldsClient.PollOnceCreateTagHold(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagHold retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTagHoldAsync</summary>
        public async Task CreateTagHoldAsync()
        {
            // Snippet: CreateTagHoldAsync(string, TagHold, CallSettings)
            // Additional: CreateTagHoldAsync(string, TagHold, CancellationToken)
            // Create client
            TagHoldsClient tagHoldsClient = await TagHoldsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "tagValues/[TAG_VALUE]";
            TagHold tagHold = new TagHold();
            // Make the request
            Operation<TagHold, CreateTagHoldMetadata> response = await tagHoldsClient.CreateTagHoldAsync(parent, tagHold);

            // Poll until the returned long-running operation is complete
            Operation<TagHold, CreateTagHoldMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagHold result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagHold, CreateTagHoldMetadata> retrievedResponse = await tagHoldsClient.PollOnceCreateTagHoldAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagHold retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTagHold</summary>
        public void CreateTagHoldResourceNames()
        {
            // Snippet: CreateTagHold(TagValueName, TagHold, CallSettings)
            // Create client
            TagHoldsClient tagHoldsClient = TagHoldsClient.Create();
            // Initialize request argument(s)
            TagValueName parent = TagValueName.FromTagValue("[TAG_VALUE]");
            TagHold tagHold = new TagHold();
            // Make the request
            Operation<TagHold, CreateTagHoldMetadata> response = tagHoldsClient.CreateTagHold(parent, tagHold);

            // Poll until the returned long-running operation is complete
            Operation<TagHold, CreateTagHoldMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagHold result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagHold, CreateTagHoldMetadata> retrievedResponse = tagHoldsClient.PollOnceCreateTagHold(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagHold retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTagHoldAsync</summary>
        public async Task CreateTagHoldResourceNamesAsync()
        {
            // Snippet: CreateTagHoldAsync(TagValueName, TagHold, CallSettings)
            // Additional: CreateTagHoldAsync(TagValueName, TagHold, CancellationToken)
            // Create client
            TagHoldsClient tagHoldsClient = await TagHoldsClient.CreateAsync();
            // Initialize request argument(s)
            TagValueName parent = TagValueName.FromTagValue("[TAG_VALUE]");
            TagHold tagHold = new TagHold();
            // Make the request
            Operation<TagHold, CreateTagHoldMetadata> response = await tagHoldsClient.CreateTagHoldAsync(parent, tagHold);

            // Poll until the returned long-running operation is complete
            Operation<TagHold, CreateTagHoldMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagHold result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagHold, CreateTagHoldMetadata> retrievedResponse = await tagHoldsClient.PollOnceCreateTagHoldAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagHold retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagHold</summary>
        public void DeleteTagHoldRequestObject()
        {
            // Snippet: DeleteTagHold(DeleteTagHoldRequest, CallSettings)
            // Create client
            TagHoldsClient tagHoldsClient = TagHoldsClient.Create();
            // Initialize request argument(s)
            DeleteTagHoldRequest request = new DeleteTagHoldRequest
            {
                TagHoldName = TagHoldName.FromTagValueTagHold("[TAG_VALUE]", "[TAG_HOLD]"),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, DeleteTagHoldMetadata> response = tagHoldsClient.DeleteTagHold(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTagHoldMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTagHoldMetadata> retrievedResponse = tagHoldsClient.PollOnceDeleteTagHold(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagHoldAsync</summary>
        public async Task DeleteTagHoldRequestObjectAsync()
        {
            // Snippet: DeleteTagHoldAsync(DeleteTagHoldRequest, CallSettings)
            // Additional: DeleteTagHoldAsync(DeleteTagHoldRequest, CancellationToken)
            // Create client
            TagHoldsClient tagHoldsClient = await TagHoldsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTagHoldRequest request = new DeleteTagHoldRequest
            {
                TagHoldName = TagHoldName.FromTagValueTagHold("[TAG_VALUE]", "[TAG_HOLD]"),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, DeleteTagHoldMetadata> response = await tagHoldsClient.DeleteTagHoldAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTagHoldMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTagHoldMetadata> retrievedResponse = await tagHoldsClient.PollOnceDeleteTagHoldAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagHold</summary>
        public void DeleteTagHold()
        {
            // Snippet: DeleteTagHold(string, CallSettings)
            // Create client
            TagHoldsClient tagHoldsClient = TagHoldsClient.Create();
            // Initialize request argument(s)
            string name = "tagValues/[TAG_VALUE]/tagHolds/[TAG_HOLD]";
            // Make the request
            Operation<Empty, DeleteTagHoldMetadata> response = tagHoldsClient.DeleteTagHold(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTagHoldMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTagHoldMetadata> retrievedResponse = tagHoldsClient.PollOnceDeleteTagHold(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagHoldAsync</summary>
        public async Task DeleteTagHoldAsync()
        {
            // Snippet: DeleteTagHoldAsync(string, CallSettings)
            // Additional: DeleteTagHoldAsync(string, CancellationToken)
            // Create client
            TagHoldsClient tagHoldsClient = await TagHoldsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "tagValues/[TAG_VALUE]/tagHolds/[TAG_HOLD]";
            // Make the request
            Operation<Empty, DeleteTagHoldMetadata> response = await tagHoldsClient.DeleteTagHoldAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTagHoldMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTagHoldMetadata> retrievedResponse = await tagHoldsClient.PollOnceDeleteTagHoldAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagHold</summary>
        public void DeleteTagHoldResourceNames()
        {
            // Snippet: DeleteTagHold(TagHoldName, CallSettings)
            // Create client
            TagHoldsClient tagHoldsClient = TagHoldsClient.Create();
            // Initialize request argument(s)
            TagHoldName name = TagHoldName.FromTagValueTagHold("[TAG_VALUE]", "[TAG_HOLD]");
            // Make the request
            Operation<Empty, DeleteTagHoldMetadata> response = tagHoldsClient.DeleteTagHold(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTagHoldMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTagHoldMetadata> retrievedResponse = tagHoldsClient.PollOnceDeleteTagHold(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagHoldAsync</summary>
        public async Task DeleteTagHoldResourceNamesAsync()
        {
            // Snippet: DeleteTagHoldAsync(TagHoldName, CallSettings)
            // Additional: DeleteTagHoldAsync(TagHoldName, CancellationToken)
            // Create client
            TagHoldsClient tagHoldsClient = await TagHoldsClient.CreateAsync();
            // Initialize request argument(s)
            TagHoldName name = TagHoldName.FromTagValueTagHold("[TAG_VALUE]", "[TAG_HOLD]");
            // Make the request
            Operation<Empty, DeleteTagHoldMetadata> response = await tagHoldsClient.DeleteTagHoldAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTagHoldMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTagHoldMetadata> retrievedResponse = await tagHoldsClient.PollOnceDeleteTagHoldAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListTagHolds</summary>
        public void ListTagHoldsRequestObject()
        {
            // Snippet: ListTagHolds(ListTagHoldsRequest, CallSettings)
            // Create client
            TagHoldsClient tagHoldsClient = TagHoldsClient.Create();
            // Initialize request argument(s)
            ListTagHoldsRequest request = new ListTagHoldsRequest
            {
                ParentAsTagValueName = TagValueName.FromTagValue("[TAG_VALUE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListTagHoldsResponse, TagHold> response = tagHoldsClient.ListTagHolds(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TagHold item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagHoldsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagHold item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagHold> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagHold item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagHoldsAsync</summary>
        public async Task ListTagHoldsRequestObjectAsync()
        {
            // Snippet: ListTagHoldsAsync(ListTagHoldsRequest, CallSettings)
            // Create client
            TagHoldsClient tagHoldsClient = await TagHoldsClient.CreateAsync();
            // Initialize request argument(s)
            ListTagHoldsRequest request = new ListTagHoldsRequest
            {
                ParentAsTagValueName = TagValueName.FromTagValue("[TAG_VALUE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTagHoldsResponse, TagHold> response = tagHoldsClient.ListTagHoldsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TagHold item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagHoldsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagHold item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagHold> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagHold item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagHolds</summary>
        public void ListTagHolds()
        {
            // Snippet: ListTagHolds(string, string, int?, CallSettings)
            // Create client
            TagHoldsClient tagHoldsClient = TagHoldsClient.Create();
            // Initialize request argument(s)
            string parent = "tagValues/[TAG_VALUE]";
            // Make the request
            PagedEnumerable<ListTagHoldsResponse, TagHold> response = tagHoldsClient.ListTagHolds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TagHold item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagHoldsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagHold item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagHold> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagHold item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagHoldsAsync</summary>
        public async Task ListTagHoldsAsync()
        {
            // Snippet: ListTagHoldsAsync(string, string, int?, CallSettings)
            // Create client
            TagHoldsClient tagHoldsClient = await TagHoldsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "tagValues/[TAG_VALUE]";
            // Make the request
            PagedAsyncEnumerable<ListTagHoldsResponse, TagHold> response = tagHoldsClient.ListTagHoldsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TagHold item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagHoldsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagHold item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagHold> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagHold item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagHolds</summary>
        public void ListTagHoldsResourceNames()
        {
            // Snippet: ListTagHolds(TagValueName, string, int?, CallSettings)
            // Create client
            TagHoldsClient tagHoldsClient = TagHoldsClient.Create();
            // Initialize request argument(s)
            TagValueName parent = TagValueName.FromTagValue("[TAG_VALUE]");
            // Make the request
            PagedEnumerable<ListTagHoldsResponse, TagHold> response = tagHoldsClient.ListTagHolds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TagHold item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagHoldsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagHold item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagHold> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagHold item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagHoldsAsync</summary>
        public async Task ListTagHoldsResourceNamesAsync()
        {
            // Snippet: ListTagHoldsAsync(TagValueName, string, int?, CallSettings)
            // Create client
            TagHoldsClient tagHoldsClient = await TagHoldsClient.CreateAsync();
            // Initialize request argument(s)
            TagValueName parent = TagValueName.FromTagValue("[TAG_VALUE]");
            // Make the request
            PagedAsyncEnumerable<ListTagHoldsResponse, TagHold> response = tagHoldsClient.ListTagHoldsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TagHold item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagHoldsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagHold item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagHold> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagHold item in singlePage)
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
