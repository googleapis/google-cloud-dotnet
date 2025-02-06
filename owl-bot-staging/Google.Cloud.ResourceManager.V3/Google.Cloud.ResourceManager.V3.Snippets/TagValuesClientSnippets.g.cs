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
    public sealed class AllGeneratedTagValuesClientSnippets
    {
        /// <summary>Snippet for ListTagValues</summary>
        public void ListTagValuesRequestObject()
        {
            // Snippet: ListTagValues(ListTagValuesRequest, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            ListTagValuesRequest request = new ListTagValuesRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
            };
            // Make the request
            PagedEnumerable<ListTagValuesResponse, TagValue> response = tagValuesClient.ListTagValues(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TagValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagValuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagValue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagValuesAsync</summary>
        public async Task ListTagValuesRequestObjectAsync()
        {
            // Snippet: ListTagValuesAsync(ListTagValuesRequest, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            ListTagValuesRequest request = new ListTagValuesRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTagValuesResponse, TagValue> response = tagValuesClient.ListTagValuesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TagValue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagValuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagValue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagValues</summary>
        public void ListTagValues()
        {
            // Snippet: ListTagValues(string, string, int?, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            PagedEnumerable<ListTagValuesResponse, TagValue> response = tagValuesClient.ListTagValues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TagValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagValuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagValue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagValuesAsync</summary>
        public async Task ListTagValuesAsync()
        {
            // Snippet: ListTagValuesAsync(string, string, int?, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            PagedAsyncEnumerable<ListTagValuesResponse, TagValue> response = tagValuesClient.ListTagValuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TagValue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagValuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagValue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagValues</summary>
        public void ListTagValuesResourceNames()
        {
            // Snippet: ListTagValues(IResourceName, string, int?, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListTagValuesResponse, TagValue> response = tagValuesClient.ListTagValues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TagValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagValuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagValue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagValuesAsync</summary>
        public async Task ListTagValuesResourceNamesAsync()
        {
            // Snippet: ListTagValuesAsync(IResourceName, string, int?, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListTagValuesResponse, TagValue> response = tagValuesClient.ListTagValuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TagValue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagValuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TagValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TagValue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TagValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTagValue</summary>
        public void GetTagValueRequestObject()
        {
            // Snippet: GetTagValue(GetTagValueRequest, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            GetTagValueRequest request = new GetTagValueRequest
            {
                TagValueName = TagValueName.FromTagValue("[TAG_VALUE]"),
            };
            // Make the request
            TagValue response = tagValuesClient.GetTagValue(request);
            // End snippet
        }

        /// <summary>Snippet for GetTagValueAsync</summary>
        public async Task GetTagValueRequestObjectAsync()
        {
            // Snippet: GetTagValueAsync(GetTagValueRequest, CallSettings)
            // Additional: GetTagValueAsync(GetTagValueRequest, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            GetTagValueRequest request = new GetTagValueRequest
            {
                TagValueName = TagValueName.FromTagValue("[TAG_VALUE]"),
            };
            // Make the request
            TagValue response = await tagValuesClient.GetTagValueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTagValue</summary>
        public void GetTagValue()
        {
            // Snippet: GetTagValue(string, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            string name = "tagValues/[TAG_VALUE]";
            // Make the request
            TagValue response = tagValuesClient.GetTagValue(name);
            // End snippet
        }

        /// <summary>Snippet for GetTagValueAsync</summary>
        public async Task GetTagValueAsync()
        {
            // Snippet: GetTagValueAsync(string, CallSettings)
            // Additional: GetTagValueAsync(string, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "tagValues/[TAG_VALUE]";
            // Make the request
            TagValue response = await tagValuesClient.GetTagValueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTagValue</summary>
        public void GetTagValueResourceNames()
        {
            // Snippet: GetTagValue(TagValueName, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            TagValueName name = TagValueName.FromTagValue("[TAG_VALUE]");
            // Make the request
            TagValue response = tagValuesClient.GetTagValue(name);
            // End snippet
        }

        /// <summary>Snippet for GetTagValueAsync</summary>
        public async Task GetTagValueResourceNamesAsync()
        {
            // Snippet: GetTagValueAsync(TagValueName, CallSettings)
            // Additional: GetTagValueAsync(TagValueName, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            TagValueName name = TagValueName.FromTagValue("[TAG_VALUE]");
            // Make the request
            TagValue response = await tagValuesClient.GetTagValueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNamespacedTagValue</summary>
        public void GetNamespacedTagValueRequestObject()
        {
            // Snippet: GetNamespacedTagValue(GetNamespacedTagValueRequest, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            GetNamespacedTagValueRequest request = new GetNamespacedTagValueRequest
            {
                TagValueName = TagValueName.FromTagValue("[TAG_VALUE]"),
            };
            // Make the request
            TagValue response = tagValuesClient.GetNamespacedTagValue(request);
            // End snippet
        }

        /// <summary>Snippet for GetNamespacedTagValueAsync</summary>
        public async Task GetNamespacedTagValueRequestObjectAsync()
        {
            // Snippet: GetNamespacedTagValueAsync(GetNamespacedTagValueRequest, CallSettings)
            // Additional: GetNamespacedTagValueAsync(GetNamespacedTagValueRequest, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            GetNamespacedTagValueRequest request = new GetNamespacedTagValueRequest
            {
                TagValueName = TagValueName.FromTagValue("[TAG_VALUE]"),
            };
            // Make the request
            TagValue response = await tagValuesClient.GetNamespacedTagValueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNamespacedTagValue</summary>
        public void GetNamespacedTagValue()
        {
            // Snippet: GetNamespacedTagValue(string, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            string name = "tagValues/[TAG_VALUE]";
            // Make the request
            TagValue response = tagValuesClient.GetNamespacedTagValue(name);
            // End snippet
        }

        /// <summary>Snippet for GetNamespacedTagValueAsync</summary>
        public async Task GetNamespacedTagValueAsync()
        {
            // Snippet: GetNamespacedTagValueAsync(string, CallSettings)
            // Additional: GetNamespacedTagValueAsync(string, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "tagValues/[TAG_VALUE]";
            // Make the request
            TagValue response = await tagValuesClient.GetNamespacedTagValueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNamespacedTagValue</summary>
        public void GetNamespacedTagValueResourceNames()
        {
            // Snippet: GetNamespacedTagValue(TagValueName, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            TagValueName name = TagValueName.FromTagValue("[TAG_VALUE]");
            // Make the request
            TagValue response = tagValuesClient.GetNamespacedTagValue(name);
            // End snippet
        }

        /// <summary>Snippet for GetNamespacedTagValueAsync</summary>
        public async Task GetNamespacedTagValueResourceNamesAsync()
        {
            // Snippet: GetNamespacedTagValueAsync(TagValueName, CallSettings)
            // Additional: GetNamespacedTagValueAsync(TagValueName, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            TagValueName name = TagValueName.FromTagValue("[TAG_VALUE]");
            // Make the request
            TagValue response = await tagValuesClient.GetNamespacedTagValueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTagValue</summary>
        public void CreateTagValueRequestObject()
        {
            // Snippet: CreateTagValue(CreateTagValueRequest, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            CreateTagValueRequest request = new CreateTagValueRequest
            {
                TagValue = new TagValue(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<TagValue, CreateTagValueMetadata> response = tagValuesClient.CreateTagValue(request);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, CreateTagValueMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, CreateTagValueMetadata> retrievedResponse = tagValuesClient.PollOnceCreateTagValue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTagValueAsync</summary>
        public async Task CreateTagValueRequestObjectAsync()
        {
            // Snippet: CreateTagValueAsync(CreateTagValueRequest, CallSettings)
            // Additional: CreateTagValueAsync(CreateTagValueRequest, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            CreateTagValueRequest request = new CreateTagValueRequest
            {
                TagValue = new TagValue(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<TagValue, CreateTagValueMetadata> response = await tagValuesClient.CreateTagValueAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, CreateTagValueMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, CreateTagValueMetadata> retrievedResponse = await tagValuesClient.PollOnceCreateTagValueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTagValue</summary>
        public void CreateTagValue()
        {
            // Snippet: CreateTagValue(TagValue, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            TagValue tagValue = new TagValue();
            // Make the request
            Operation<TagValue, CreateTagValueMetadata> response = tagValuesClient.CreateTagValue(tagValue);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, CreateTagValueMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, CreateTagValueMetadata> retrievedResponse = tagValuesClient.PollOnceCreateTagValue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTagValueAsync</summary>
        public async Task CreateTagValueAsync()
        {
            // Snippet: CreateTagValueAsync(TagValue, CallSettings)
            // Additional: CreateTagValueAsync(TagValue, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            TagValue tagValue = new TagValue();
            // Make the request
            Operation<TagValue, CreateTagValueMetadata> response = await tagValuesClient.CreateTagValueAsync(tagValue);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, CreateTagValueMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, CreateTagValueMetadata> retrievedResponse = await tagValuesClient.PollOnceCreateTagValueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTagValue</summary>
        public void UpdateTagValueRequestObject()
        {
            // Snippet: UpdateTagValue(UpdateTagValueRequest, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            UpdateTagValueRequest request = new UpdateTagValueRequest
            {
                TagValue = new TagValue(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<TagValue, UpdateTagValueMetadata> response = tagValuesClient.UpdateTagValue(request);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, UpdateTagValueMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, UpdateTagValueMetadata> retrievedResponse = tagValuesClient.PollOnceUpdateTagValue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTagValueAsync</summary>
        public async Task UpdateTagValueRequestObjectAsync()
        {
            // Snippet: UpdateTagValueAsync(UpdateTagValueRequest, CallSettings)
            // Additional: UpdateTagValueAsync(UpdateTagValueRequest, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTagValueRequest request = new UpdateTagValueRequest
            {
                TagValue = new TagValue(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<TagValue, UpdateTagValueMetadata> response = await tagValuesClient.UpdateTagValueAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, UpdateTagValueMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, UpdateTagValueMetadata> retrievedResponse = await tagValuesClient.PollOnceUpdateTagValueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTagValue</summary>
        public void UpdateTagValue()
        {
            // Snippet: UpdateTagValue(TagValue, FieldMask, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            TagValue tagValue = new TagValue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<TagValue, UpdateTagValueMetadata> response = tagValuesClient.UpdateTagValue(tagValue, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, UpdateTagValueMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, UpdateTagValueMetadata> retrievedResponse = tagValuesClient.PollOnceUpdateTagValue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTagValueAsync</summary>
        public async Task UpdateTagValueAsync()
        {
            // Snippet: UpdateTagValueAsync(TagValue, FieldMask, CallSettings)
            // Additional: UpdateTagValueAsync(TagValue, FieldMask, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            TagValue tagValue = new TagValue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<TagValue, UpdateTagValueMetadata> response = await tagValuesClient.UpdateTagValueAsync(tagValue, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, UpdateTagValueMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, UpdateTagValueMetadata> retrievedResponse = await tagValuesClient.PollOnceUpdateTagValueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagValue</summary>
        public void DeleteTagValueRequestObject()
        {
            // Snippet: DeleteTagValue(DeleteTagValueRequest, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            DeleteTagValueRequest request = new DeleteTagValueRequest
            {
                TagValueName = TagValueName.FromTagValue("[TAG_VALUE]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<TagValue, DeleteTagValueMetadata> response = tagValuesClient.DeleteTagValue(request);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, DeleteTagValueMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, DeleteTagValueMetadata> retrievedResponse = tagValuesClient.PollOnceDeleteTagValue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagValueAsync</summary>
        public async Task DeleteTagValueRequestObjectAsync()
        {
            // Snippet: DeleteTagValueAsync(DeleteTagValueRequest, CallSettings)
            // Additional: DeleteTagValueAsync(DeleteTagValueRequest, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTagValueRequest request = new DeleteTagValueRequest
            {
                TagValueName = TagValueName.FromTagValue("[TAG_VALUE]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<TagValue, DeleteTagValueMetadata> response = await tagValuesClient.DeleteTagValueAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, DeleteTagValueMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, DeleteTagValueMetadata> retrievedResponse = await tagValuesClient.PollOnceDeleteTagValueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagValue</summary>
        public void DeleteTagValue()
        {
            // Snippet: DeleteTagValue(string, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            string name = "tagValues/[TAG_VALUE]";
            // Make the request
            Operation<TagValue, DeleteTagValueMetadata> response = tagValuesClient.DeleteTagValue(name);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, DeleteTagValueMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, DeleteTagValueMetadata> retrievedResponse = tagValuesClient.PollOnceDeleteTagValue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagValueAsync</summary>
        public async Task DeleteTagValueAsync()
        {
            // Snippet: DeleteTagValueAsync(string, CallSettings)
            // Additional: DeleteTagValueAsync(string, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "tagValues/[TAG_VALUE]";
            // Make the request
            Operation<TagValue, DeleteTagValueMetadata> response = await tagValuesClient.DeleteTagValueAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, DeleteTagValueMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, DeleteTagValueMetadata> retrievedResponse = await tagValuesClient.PollOnceDeleteTagValueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagValue</summary>
        public void DeleteTagValueResourceNames()
        {
            // Snippet: DeleteTagValue(TagValueName, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            TagValueName name = TagValueName.FromTagValue("[TAG_VALUE]");
            // Make the request
            Operation<TagValue, DeleteTagValueMetadata> response = tagValuesClient.DeleteTagValue(name);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, DeleteTagValueMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, DeleteTagValueMetadata> retrievedResponse = tagValuesClient.PollOnceDeleteTagValue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTagValueAsync</summary>
        public async Task DeleteTagValueResourceNamesAsync()
        {
            // Snippet: DeleteTagValueAsync(TagValueName, CallSettings)
            // Additional: DeleteTagValueAsync(TagValueName, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            TagValueName name = TagValueName.FromTagValue("[TAG_VALUE]");
            // Make the request
            Operation<TagValue, DeleteTagValueMetadata> response = await tagValuesClient.DeleteTagValueAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<TagValue, DeleteTagValueMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TagValue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagValue, DeleteTagValueMetadata> retrievedResponse = await tagValuesClient.PollOnceDeleteTagValueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagValue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = tagValuesClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await tagValuesClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = tagValuesClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await tagValuesClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = tagValuesClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await tagValuesClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = tagValuesClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await tagValuesClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = tagValuesClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await tagValuesClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = tagValuesClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await tagValuesClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = tagValuesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await tagValuesClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = tagValuesClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await tagValuesClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            TagValuesClient tagValuesClient = TagValuesClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = tagValuesClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            TagValuesClient tagValuesClient = await TagValuesClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await tagValuesClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }
    }
}
