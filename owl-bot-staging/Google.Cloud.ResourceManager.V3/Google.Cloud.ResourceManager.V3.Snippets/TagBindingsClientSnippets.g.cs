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
    public sealed class AllGeneratedTagBindingsClientSnippets
    {
        /// <summary>Snippet for ListTagBindings</summary>
        public void ListTagBindingsRequestObject()
        {
            // Snippet: ListTagBindings(ListTagBindingsRequest, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = TagBindingsClient.Create();
            // Initialize request argument(s)
            ListTagBindingsRequest request = new ListTagBindingsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
            };
            // Make the request
            PagedEnumerable<ListTagBindingsResponse, TagBinding> response = tagBindingsClient.ListTagBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TagBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagBindingsAsync</summary>
        public async Task ListTagBindingsRequestObjectAsync()
        {
            // Snippet: ListTagBindingsAsync(ListTagBindingsRequest, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = await TagBindingsClient.CreateAsync();
            // Initialize request argument(s)
            ListTagBindingsRequest request = new ListTagBindingsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTagBindingsResponse, TagBinding> response = tagBindingsClient.ListTagBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TagBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagBindings</summary>
        public void ListTagBindings()
        {
            // Snippet: ListTagBindings(string, string, int?, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = TagBindingsClient.Create();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            PagedEnumerable<ListTagBindingsResponse, TagBinding> response = tagBindingsClient.ListTagBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TagBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagBindingsAsync</summary>
        public async Task ListTagBindingsAsync()
        {
            // Snippet: ListTagBindingsAsync(string, string, int?, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = await TagBindingsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            PagedAsyncEnumerable<ListTagBindingsResponse, TagBinding> response = tagBindingsClient.ListTagBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TagBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagBindings</summary>
        public void ListTagBindingsResourceNames()
        {
            // Snippet: ListTagBindings(IResourceName, string, int?, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = TagBindingsClient.Create();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListTagBindingsResponse, TagBinding> response = tagBindingsClient.ListTagBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TagBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagBindingsAsync</summary>
        public async Task ListTagBindingsResourceNamesAsync()
        {
            // Snippet: ListTagBindingsAsync(IResourceName, string, int?, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = await TagBindingsClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListTagBindingsResponse, TagBinding> response = tagBindingsClient.ListTagBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TagBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateTagBinding</summary>
        public void CreateTagBindingRequestObject()
        {
            // Snippet: CreateTagBinding(CreateTagBindingRequest, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = TagBindingsClient.Create();
            // Initialize request argument(s)
            CreateTagBindingRequest request = new CreateTagBindingRequest
            {
                TagBinding = new TagBinding(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<TagBinding, CreateTagBindingMetadata> response = tagBindingsClient.CreateTagBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<TagBinding, CreateTagBindingMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagBinding, CreateTagBindingMetadata> retrievedResponse = tagBindingsClient.PollOnceCreateTagBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTagBindingAsync</summary>
        public async Task CreateTagBindingRequestObjectAsync()
        {
            // Snippet: CreateTagBindingAsync(CreateTagBindingRequest, CallSettings)
            // Additional: CreateTagBindingAsync(CreateTagBindingRequest, CancellationToken)
            // Create client
            TagBindingsClient tagBindingsClient = await TagBindingsClient.CreateAsync();
            // Initialize request argument(s)
            CreateTagBindingRequest request = new CreateTagBindingRequest
            {
                TagBinding = new TagBinding(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<TagBinding, CreateTagBindingMetadata> response = await tagBindingsClient.CreateTagBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TagBinding, CreateTagBindingMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagBinding, CreateTagBindingMetadata> retrievedResponse = await tagBindingsClient.PollOnceCreateTagBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTagBinding</summary>
        public void CreateTagBinding()
        {
            // Snippet: CreateTagBinding(TagBinding, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = TagBindingsClient.Create();
            // Initialize request argument(s)
            TagBinding tagBinding = new TagBinding();
            // Make the request
            Operation<TagBinding, CreateTagBindingMetadata> response = tagBindingsClient.CreateTagBinding(tagBinding);

            // Poll until the returned long-running operation is complete
            Operation<TagBinding, CreateTagBindingMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagBinding, CreateTagBindingMetadata> retrievedResponse = tagBindingsClient.PollOnceCreateTagBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTagBindingAsync</summary>
        public async Task CreateTagBindingAsync()
        {
            // Snippet: CreateTagBindingAsync(TagBinding, CallSettings)
            // Additional: CreateTagBindingAsync(TagBinding, CancellationToken)
            // Create client
            TagBindingsClient tagBindingsClient = await TagBindingsClient.CreateAsync();
            // Initialize request argument(s)
            TagBinding tagBinding = new TagBinding();
            // Make the request
            Operation<TagBinding, CreateTagBindingMetadata> response = await tagBindingsClient.CreateTagBindingAsync(tagBinding);

            // Poll until the returned long-running operation is complete
            Operation<TagBinding, CreateTagBindingMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagBinding, CreateTagBindingMetadata> retrievedResponse = await tagBindingsClient.PollOnceCreateTagBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagBinding</summary>
        public void DeleteTagBindingRequestObject()
        {
            // Snippet: DeleteTagBinding(DeleteTagBindingRequest, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = TagBindingsClient.Create();
            // Initialize request argument(s)
            DeleteTagBindingRequest request = new DeleteTagBindingRequest
            {
                TagBindingName = TagBindingName.FromTagBinding("[TAG_BINDING]"),
            };
            // Make the request
            Operation<Empty, DeleteTagBindingMetadata> response = tagBindingsClient.DeleteTagBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTagBindingMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTagBindingMetadata> retrievedResponse = tagBindingsClient.PollOnceDeleteTagBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagBindingAsync</summary>
        public async Task DeleteTagBindingRequestObjectAsync()
        {
            // Snippet: DeleteTagBindingAsync(DeleteTagBindingRequest, CallSettings)
            // Additional: DeleteTagBindingAsync(DeleteTagBindingRequest, CancellationToken)
            // Create client
            TagBindingsClient tagBindingsClient = await TagBindingsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTagBindingRequest request = new DeleteTagBindingRequest
            {
                TagBindingName = TagBindingName.FromTagBinding("[TAG_BINDING]"),
            };
            // Make the request
            Operation<Empty, DeleteTagBindingMetadata> response = await tagBindingsClient.DeleteTagBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTagBindingMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTagBindingMetadata> retrievedResponse = await tagBindingsClient.PollOnceDeleteTagBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagBinding</summary>
        public void DeleteTagBinding()
        {
            // Snippet: DeleteTagBinding(string, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = TagBindingsClient.Create();
            // Initialize request argument(s)
            string name = "tagBindings/[TAG_BINDING]";
            // Make the request
            Operation<Empty, DeleteTagBindingMetadata> response = tagBindingsClient.DeleteTagBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTagBindingMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTagBindingMetadata> retrievedResponse = tagBindingsClient.PollOnceDeleteTagBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagBindingAsync</summary>
        public async Task DeleteTagBindingAsync()
        {
            // Snippet: DeleteTagBindingAsync(string, CallSettings)
            // Additional: DeleteTagBindingAsync(string, CancellationToken)
            // Create client
            TagBindingsClient tagBindingsClient = await TagBindingsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "tagBindings/[TAG_BINDING]";
            // Make the request
            Operation<Empty, DeleteTagBindingMetadata> response = await tagBindingsClient.DeleteTagBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTagBindingMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTagBindingMetadata> retrievedResponse = await tagBindingsClient.PollOnceDeleteTagBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagBinding</summary>
        public void DeleteTagBindingResourceNames()
        {
            // Snippet: DeleteTagBinding(TagBindingName, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = TagBindingsClient.Create();
            // Initialize request argument(s)
            TagBindingName name = TagBindingName.FromTagBinding("[TAG_BINDING]");
            // Make the request
            Operation<Empty, DeleteTagBindingMetadata> response = tagBindingsClient.DeleteTagBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTagBindingMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTagBindingMetadata> retrievedResponse = tagBindingsClient.PollOnceDeleteTagBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagBindingAsync</summary>
        public async Task DeleteTagBindingResourceNamesAsync()
        {
            // Snippet: DeleteTagBindingAsync(TagBindingName, CallSettings)
            // Additional: DeleteTagBindingAsync(TagBindingName, CancellationToken)
            // Create client
            TagBindingsClient tagBindingsClient = await TagBindingsClient.CreateAsync();
            // Initialize request argument(s)
            TagBindingName name = TagBindingName.FromTagBinding("[TAG_BINDING]");
            // Make the request
            Operation<Empty, DeleteTagBindingMetadata> response = await tagBindingsClient.DeleteTagBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTagBindingMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTagBindingMetadata> retrievedResponse = await tagBindingsClient.PollOnceDeleteTagBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveTags</summary>
        public void ListEffectiveTagsRequestObject()
        {
            // Snippet: ListEffectiveTags(ListEffectiveTagsRequest, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = TagBindingsClient.Create();
            // Initialize request argument(s)
            ListEffectiveTagsRequest request = new ListEffectiveTagsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListEffectiveTagsResponse, EffectiveTag> response = tagBindingsClient.ListEffectiveTags(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EffectiveTag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEffectiveTagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveTag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveTag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveTag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveTagsAsync</summary>
        public async Task ListEffectiveTagsRequestObjectAsync()
        {
            // Snippet: ListEffectiveTagsAsync(ListEffectiveTagsRequest, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = await TagBindingsClient.CreateAsync();
            // Initialize request argument(s)
            ListEffectiveTagsRequest request = new ListEffectiveTagsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListEffectiveTagsResponse, EffectiveTag> response = tagBindingsClient.ListEffectiveTagsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EffectiveTag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEffectiveTagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveTag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveTag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveTag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveTags</summary>
        public void ListEffectiveTags()
        {
            // Snippet: ListEffectiveTags(string, string, int?, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = TagBindingsClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListEffectiveTagsResponse, EffectiveTag> response = tagBindingsClient.ListEffectiveTags(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EffectiveTag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEffectiveTagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveTag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveTag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveTag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveTagsAsync</summary>
        public async Task ListEffectiveTagsAsync()
        {
            // Snippet: ListEffectiveTagsAsync(string, string, int?, CallSettings)
            // Create client
            TagBindingsClient tagBindingsClient = await TagBindingsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListEffectiveTagsResponse, EffectiveTag> response = tagBindingsClient.ListEffectiveTagsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EffectiveTag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEffectiveTagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveTag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveTag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveTag item in singlePage)
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
