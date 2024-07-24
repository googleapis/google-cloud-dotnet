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
    using Google.Cloud.Iam.V1;
    using Google.Cloud.ResourceManager.V3;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTagKeysClientSnippets
    {
        /// <summary>Snippet for ListTagKeys</summary>
        public void ListTagKeysRequestObject()
        {
            // Snippet: ListTagKeys(ListTagKeysRequest, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            ListTagKeysRequest request = new ListTagKeysRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
            };
            // Make the request
            PagedEnumerable<ListTagKeysResponse, TagKey> response = tagKeysClient.ListTagKeys(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TagKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagKeysAsync</summary>
        public async Task ListTagKeysRequestObjectAsync()
        {
            // Snippet: ListTagKeysAsync(ListTagKeysRequest, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            ListTagKeysRequest request = new ListTagKeysRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTagKeysResponse, TagKey> response = tagKeysClient.ListTagKeysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TagKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagKeys</summary>
        public void ListTagKeys()
        {
            // Snippet: ListTagKeys(string, string, int?, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            PagedEnumerable<ListTagKeysResponse, TagKey> response = tagKeysClient.ListTagKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TagKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagKeysAsync</summary>
        public async Task ListTagKeysAsync()
        {
            // Snippet: ListTagKeysAsync(string, string, int?, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            PagedAsyncEnumerable<ListTagKeysResponse, TagKey> response = tagKeysClient.ListTagKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TagKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagKeys</summary>
        public void ListTagKeysResourceNames()
        {
            // Snippet: ListTagKeys(IResourceName, string, int?, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListTagKeysResponse, TagKey> response = tagKeysClient.ListTagKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TagKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagKeysAsync</summary>
        public async Task ListTagKeysResourceNamesAsync()
        {
            // Snippet: ListTagKeysAsync(IResourceName, string, int?, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListTagKeysResponse, TagKey> response = tagKeysClient.ListTagKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TagKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTagKey</summary>
        public void GetTagKeyRequestObject()
        {
            // Snippet: GetTagKey(GetTagKeyRequest, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            GetTagKeyRequest request = new GetTagKeyRequest
            {
                TagKeyName = TagKeyName.FromTagKey("[TAG_KEY]"),
            };
            // Make the request
            TagKey response = tagKeysClient.GetTagKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetTagKeyAsync</summary>
        public async Task GetTagKeyRequestObjectAsync()
        {
            // Snippet: GetTagKeyAsync(GetTagKeyRequest, CallSettings)
            // Additional: GetTagKeyAsync(GetTagKeyRequest, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            GetTagKeyRequest request = new GetTagKeyRequest
            {
                TagKeyName = TagKeyName.FromTagKey("[TAG_KEY]"),
            };
            // Make the request
            TagKey response = await tagKeysClient.GetTagKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTagKey</summary>
        public void GetTagKey()
        {
            // Snippet: GetTagKey(string, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            string name = "tagKeys/[TAG_KEY]";
            // Make the request
            TagKey response = tagKeysClient.GetTagKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetTagKeyAsync</summary>
        public async Task GetTagKeyAsync()
        {
            // Snippet: GetTagKeyAsync(string, CallSettings)
            // Additional: GetTagKeyAsync(string, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            string name = "tagKeys/[TAG_KEY]";
            // Make the request
            TagKey response = await tagKeysClient.GetTagKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTagKey</summary>
        public void GetTagKeyResourceNames()
        {
            // Snippet: GetTagKey(TagKeyName, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            TagKeyName name = TagKeyName.FromTagKey("[TAG_KEY]");
            // Make the request
            TagKey response = tagKeysClient.GetTagKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetTagKeyAsync</summary>
        public async Task GetTagKeyResourceNamesAsync()
        {
            // Snippet: GetTagKeyAsync(TagKeyName, CallSettings)
            // Additional: GetTagKeyAsync(TagKeyName, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            TagKeyName name = TagKeyName.FromTagKey("[TAG_KEY]");
            // Make the request
            TagKey response = await tagKeysClient.GetTagKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNamespacedTagKey</summary>
        public void GetNamespacedTagKeyRequestObject()
        {
            // Snippet: GetNamespacedTagKey(GetNamespacedTagKeyRequest, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            GetNamespacedTagKeyRequest request = new GetNamespacedTagKeyRequest
            {
                TagKeyName = TagKeyName.FromTagKey("[TAG_KEY]"),
            };
            // Make the request
            TagKey response = tagKeysClient.GetNamespacedTagKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetNamespacedTagKeyAsync</summary>
        public async Task GetNamespacedTagKeyRequestObjectAsync()
        {
            // Snippet: GetNamespacedTagKeyAsync(GetNamespacedTagKeyRequest, CallSettings)
            // Additional: GetNamespacedTagKeyAsync(GetNamespacedTagKeyRequest, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            GetNamespacedTagKeyRequest request = new GetNamespacedTagKeyRequest
            {
                TagKeyName = TagKeyName.FromTagKey("[TAG_KEY]"),
            };
            // Make the request
            TagKey response = await tagKeysClient.GetNamespacedTagKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNamespacedTagKey</summary>
        public void GetNamespacedTagKey()
        {
            // Snippet: GetNamespacedTagKey(string, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            string name = "tagKeys/[TAG_KEY]";
            // Make the request
            TagKey response = tagKeysClient.GetNamespacedTagKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetNamespacedTagKeyAsync</summary>
        public async Task GetNamespacedTagKeyAsync()
        {
            // Snippet: GetNamespacedTagKeyAsync(string, CallSettings)
            // Additional: GetNamespacedTagKeyAsync(string, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            string name = "tagKeys/[TAG_KEY]";
            // Make the request
            TagKey response = await tagKeysClient.GetNamespacedTagKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNamespacedTagKey</summary>
        public void GetNamespacedTagKeyResourceNames()
        {
            // Snippet: GetNamespacedTagKey(TagKeyName, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            TagKeyName name = TagKeyName.FromTagKey("[TAG_KEY]");
            // Make the request
            TagKey response = tagKeysClient.GetNamespacedTagKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetNamespacedTagKeyAsync</summary>
        public async Task GetNamespacedTagKeyResourceNamesAsync()
        {
            // Snippet: GetNamespacedTagKeyAsync(TagKeyName, CallSettings)
            // Additional: GetNamespacedTagKeyAsync(TagKeyName, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            TagKeyName name = TagKeyName.FromTagKey("[TAG_KEY]");
            // Make the request
            TagKey response = await tagKeysClient.GetNamespacedTagKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTagKey</summary>
        public void CreateTagKeyRequestObject()
        {
            // Snippet: CreateTagKey(CreateTagKeyRequest, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            CreateTagKeyRequest request = new CreateTagKeyRequest
            {
                TagKey = new TagKey(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<TagKey, CreateTagKeyMetadata> response = tagKeysClient.CreateTagKey(request);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, CreateTagKeyMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, CreateTagKeyMetadata> retrievedResponse = tagKeysClient.PollOnceCreateTagKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTagKeyAsync</summary>
        public async Task CreateTagKeyRequestObjectAsync()
        {
            // Snippet: CreateTagKeyAsync(CreateTagKeyRequest, CallSettings)
            // Additional: CreateTagKeyAsync(CreateTagKeyRequest, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            CreateTagKeyRequest request = new CreateTagKeyRequest
            {
                TagKey = new TagKey(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<TagKey, CreateTagKeyMetadata> response = await tagKeysClient.CreateTagKeyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, CreateTagKeyMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, CreateTagKeyMetadata> retrievedResponse = await tagKeysClient.PollOnceCreateTagKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTagKey</summary>
        public void CreateTagKey()
        {
            // Snippet: CreateTagKey(TagKey, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            TagKey tagKey = new TagKey();
            // Make the request
            Operation<TagKey, CreateTagKeyMetadata> response = tagKeysClient.CreateTagKey(tagKey);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, CreateTagKeyMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, CreateTagKeyMetadata> retrievedResponse = tagKeysClient.PollOnceCreateTagKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTagKeyAsync</summary>
        public async Task CreateTagKeyAsync()
        {
            // Snippet: CreateTagKeyAsync(TagKey, CallSettings)
            // Additional: CreateTagKeyAsync(TagKey, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            TagKey tagKey = new TagKey();
            // Make the request
            Operation<TagKey, CreateTagKeyMetadata> response = await tagKeysClient.CreateTagKeyAsync(tagKey);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, CreateTagKeyMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, CreateTagKeyMetadata> retrievedResponse = await tagKeysClient.PollOnceCreateTagKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTagKey</summary>
        public void UpdateTagKeyRequestObject()
        {
            // Snippet: UpdateTagKey(UpdateTagKeyRequest, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            UpdateTagKeyRequest request = new UpdateTagKeyRequest
            {
                TagKey = new TagKey(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<TagKey, UpdateTagKeyMetadata> response = tagKeysClient.UpdateTagKey(request);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, UpdateTagKeyMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, UpdateTagKeyMetadata> retrievedResponse = tagKeysClient.PollOnceUpdateTagKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTagKeyAsync</summary>
        public async Task UpdateTagKeyRequestObjectAsync()
        {
            // Snippet: UpdateTagKeyAsync(UpdateTagKeyRequest, CallSettings)
            // Additional: UpdateTagKeyAsync(UpdateTagKeyRequest, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTagKeyRequest request = new UpdateTagKeyRequest
            {
                TagKey = new TagKey(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<TagKey, UpdateTagKeyMetadata> response = await tagKeysClient.UpdateTagKeyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, UpdateTagKeyMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, UpdateTagKeyMetadata> retrievedResponse = await tagKeysClient.PollOnceUpdateTagKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTagKey</summary>
        public void UpdateTagKey()
        {
            // Snippet: UpdateTagKey(TagKey, FieldMask, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            TagKey tagKey = new TagKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<TagKey, UpdateTagKeyMetadata> response = tagKeysClient.UpdateTagKey(tagKey, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, UpdateTagKeyMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, UpdateTagKeyMetadata> retrievedResponse = tagKeysClient.PollOnceUpdateTagKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTagKeyAsync</summary>
        public async Task UpdateTagKeyAsync()
        {
            // Snippet: UpdateTagKeyAsync(TagKey, FieldMask, CallSettings)
            // Additional: UpdateTagKeyAsync(TagKey, FieldMask, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            TagKey tagKey = new TagKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<TagKey, UpdateTagKeyMetadata> response = await tagKeysClient.UpdateTagKeyAsync(tagKey, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, UpdateTagKeyMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, UpdateTagKeyMetadata> retrievedResponse = await tagKeysClient.PollOnceUpdateTagKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagKey</summary>
        public void DeleteTagKeyRequestObject()
        {
            // Snippet: DeleteTagKey(DeleteTagKeyRequest, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            DeleteTagKeyRequest request = new DeleteTagKeyRequest
            {
                TagKeyName = TagKeyName.FromTagKey("[TAG_KEY]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<TagKey, DeleteTagKeyMetadata> response = tagKeysClient.DeleteTagKey(request);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, DeleteTagKeyMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, DeleteTagKeyMetadata> retrievedResponse = tagKeysClient.PollOnceDeleteTagKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagKeyAsync</summary>
        public async Task DeleteTagKeyRequestObjectAsync()
        {
            // Snippet: DeleteTagKeyAsync(DeleteTagKeyRequest, CallSettings)
            // Additional: DeleteTagKeyAsync(DeleteTagKeyRequest, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTagKeyRequest request = new DeleteTagKeyRequest
            {
                TagKeyName = TagKeyName.FromTagKey("[TAG_KEY]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<TagKey, DeleteTagKeyMetadata> response = await tagKeysClient.DeleteTagKeyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, DeleteTagKeyMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, DeleteTagKeyMetadata> retrievedResponse = await tagKeysClient.PollOnceDeleteTagKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagKey</summary>
        public void DeleteTagKey()
        {
            // Snippet: DeleteTagKey(string, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            string name = "tagKeys/[TAG_KEY]";
            // Make the request
            Operation<TagKey, DeleteTagKeyMetadata> response = tagKeysClient.DeleteTagKey(name);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, DeleteTagKeyMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, DeleteTagKeyMetadata> retrievedResponse = tagKeysClient.PollOnceDeleteTagKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagKeyAsync</summary>
        public async Task DeleteTagKeyAsync()
        {
            // Snippet: DeleteTagKeyAsync(string, CallSettings)
            // Additional: DeleteTagKeyAsync(string, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            string name = "tagKeys/[TAG_KEY]";
            // Make the request
            Operation<TagKey, DeleteTagKeyMetadata> response = await tagKeysClient.DeleteTagKeyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, DeleteTagKeyMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, DeleteTagKeyMetadata> retrievedResponse = await tagKeysClient.PollOnceDeleteTagKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagKey</summary>
        public void DeleteTagKeyResourceNames()
        {
            // Snippet: DeleteTagKey(TagKeyName, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            TagKeyName name = TagKeyName.FromTagKey("[TAG_KEY]");
            // Make the request
            Operation<TagKey, DeleteTagKeyMetadata> response = tagKeysClient.DeleteTagKey(name);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, DeleteTagKeyMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, DeleteTagKeyMetadata> retrievedResponse = tagKeysClient.PollOnceDeleteTagKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagKeyAsync</summary>
        public async Task DeleteTagKeyResourceNamesAsync()
        {
            // Snippet: DeleteTagKeyAsync(TagKeyName, CallSettings)
            // Additional: DeleteTagKeyAsync(TagKeyName, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            TagKeyName name = TagKeyName.FromTagKey("[TAG_KEY]");
            // Make the request
            Operation<TagKey, DeleteTagKeyMetadata> response = await tagKeysClient.DeleteTagKeyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, DeleteTagKeyMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, DeleteTagKeyMetadata> retrievedResponse = await tagKeysClient.PollOnceDeleteTagKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = tagKeysClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await tagKeysClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = tagKeysClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await tagKeysClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = tagKeysClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await tagKeysClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = tagKeysClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await tagKeysClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = tagKeysClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await tagKeysClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = tagKeysClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await tagKeysClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = tagKeysClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await tagKeysClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = tagKeysClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await tagKeysClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = tagKeysClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            TagKeysClient tagKeysClient = await TagKeysClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await tagKeysClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }
    }
}
