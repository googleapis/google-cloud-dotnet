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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedExtensionRegistryServiceClientSnippets
    {
        /// <summary>Snippet for ImportExtension</summary>
        public void ImportExtensionRequestObject()
        {
            // Snippet: ImportExtension(ImportExtensionRequest, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = ExtensionRegistryServiceClient.Create();
            // Initialize request argument(s)
            ImportExtensionRequest request = new ImportExtensionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Extension = new Extension(),
            };
            // Make the request
            Operation<Extension, ImportExtensionOperationMetadata> response = extensionRegistryServiceClient.ImportExtension(request);

            // Poll until the returned long-running operation is complete
            Operation<Extension, ImportExtensionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Extension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Extension, ImportExtensionOperationMetadata> retrievedResponse = extensionRegistryServiceClient.PollOnceImportExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Extension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportExtensionAsync</summary>
        public async Task ImportExtensionRequestObjectAsync()
        {
            // Snippet: ImportExtensionAsync(ImportExtensionRequest, CallSettings)
            // Additional: ImportExtensionAsync(ImportExtensionRequest, CancellationToken)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = await ExtensionRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportExtensionRequest request = new ImportExtensionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Extension = new Extension(),
            };
            // Make the request
            Operation<Extension, ImportExtensionOperationMetadata> response = await extensionRegistryServiceClient.ImportExtensionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Extension, ImportExtensionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Extension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Extension, ImportExtensionOperationMetadata> retrievedResponse = await extensionRegistryServiceClient.PollOnceImportExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Extension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportExtension</summary>
        public void ImportExtension()
        {
            // Snippet: ImportExtension(string, Extension, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = ExtensionRegistryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Extension extension = new Extension();
            // Make the request
            Operation<Extension, ImportExtensionOperationMetadata> response = extensionRegistryServiceClient.ImportExtension(parent, extension);

            // Poll until the returned long-running operation is complete
            Operation<Extension, ImportExtensionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Extension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Extension, ImportExtensionOperationMetadata> retrievedResponse = extensionRegistryServiceClient.PollOnceImportExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Extension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportExtensionAsync</summary>
        public async Task ImportExtensionAsync()
        {
            // Snippet: ImportExtensionAsync(string, Extension, CallSettings)
            // Additional: ImportExtensionAsync(string, Extension, CancellationToken)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = await ExtensionRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Extension extension = new Extension();
            // Make the request
            Operation<Extension, ImportExtensionOperationMetadata> response = await extensionRegistryServiceClient.ImportExtensionAsync(parent, extension);

            // Poll until the returned long-running operation is complete
            Operation<Extension, ImportExtensionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Extension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Extension, ImportExtensionOperationMetadata> retrievedResponse = await extensionRegistryServiceClient.PollOnceImportExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Extension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportExtension</summary>
        public void ImportExtensionResourceNames()
        {
            // Snippet: ImportExtension(LocationName, Extension, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = ExtensionRegistryServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Extension extension = new Extension();
            // Make the request
            Operation<Extension, ImportExtensionOperationMetadata> response = extensionRegistryServiceClient.ImportExtension(parent, extension);

            // Poll until the returned long-running operation is complete
            Operation<Extension, ImportExtensionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Extension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Extension, ImportExtensionOperationMetadata> retrievedResponse = extensionRegistryServiceClient.PollOnceImportExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Extension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportExtensionAsync</summary>
        public async Task ImportExtensionResourceNamesAsync()
        {
            // Snippet: ImportExtensionAsync(LocationName, Extension, CallSettings)
            // Additional: ImportExtensionAsync(LocationName, Extension, CancellationToken)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = await ExtensionRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Extension extension = new Extension();
            // Make the request
            Operation<Extension, ImportExtensionOperationMetadata> response = await extensionRegistryServiceClient.ImportExtensionAsync(parent, extension);

            // Poll until the returned long-running operation is complete
            Operation<Extension, ImportExtensionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Extension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Extension, ImportExtensionOperationMetadata> retrievedResponse = await extensionRegistryServiceClient.PollOnceImportExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Extension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetExtension</summary>
        public void GetExtensionRequestObject()
        {
            // Snippet: GetExtension(GetExtensionRequest, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = ExtensionRegistryServiceClient.Create();
            // Initialize request argument(s)
            GetExtensionRequest request = new GetExtensionRequest
            {
                ExtensionName = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]"),
            };
            // Make the request
            Extension response = extensionRegistryServiceClient.GetExtension(request);
            // End snippet
        }

        /// <summary>Snippet for GetExtensionAsync</summary>
        public async Task GetExtensionRequestObjectAsync()
        {
            // Snippet: GetExtensionAsync(GetExtensionRequest, CallSettings)
            // Additional: GetExtensionAsync(GetExtensionRequest, CancellationToken)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = await ExtensionRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetExtensionRequest request = new GetExtensionRequest
            {
                ExtensionName = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]"),
            };
            // Make the request
            Extension response = await extensionRegistryServiceClient.GetExtensionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExtension</summary>
        public void GetExtension()
        {
            // Snippet: GetExtension(string, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = ExtensionRegistryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/extensions/[EXTENSION]";
            // Make the request
            Extension response = extensionRegistryServiceClient.GetExtension(name);
            // End snippet
        }

        /// <summary>Snippet for GetExtensionAsync</summary>
        public async Task GetExtensionAsync()
        {
            // Snippet: GetExtensionAsync(string, CallSettings)
            // Additional: GetExtensionAsync(string, CancellationToken)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = await ExtensionRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/extensions/[EXTENSION]";
            // Make the request
            Extension response = await extensionRegistryServiceClient.GetExtensionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExtension</summary>
        public void GetExtensionResourceNames()
        {
            // Snippet: GetExtension(ExtensionName, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = ExtensionRegistryServiceClient.Create();
            // Initialize request argument(s)
            ExtensionName name = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]");
            // Make the request
            Extension response = extensionRegistryServiceClient.GetExtension(name);
            // End snippet
        }

        /// <summary>Snippet for GetExtensionAsync</summary>
        public async Task GetExtensionResourceNamesAsync()
        {
            // Snippet: GetExtensionAsync(ExtensionName, CallSettings)
            // Additional: GetExtensionAsync(ExtensionName, CancellationToken)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = await ExtensionRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExtensionName name = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]");
            // Make the request
            Extension response = await extensionRegistryServiceClient.GetExtensionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListExtensions</summary>
        public void ListExtensionsRequestObject()
        {
            // Snippet: ListExtensions(ListExtensionsRequest, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = ExtensionRegistryServiceClient.Create();
            // Initialize request argument(s)
            ListExtensionsRequest request = new ListExtensionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListExtensionsResponse, Extension> response = extensionRegistryServiceClient.ListExtensions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Extension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Extension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Extension> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Extension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExtensionsAsync</summary>
        public async Task ListExtensionsRequestObjectAsync()
        {
            // Snippet: ListExtensionsAsync(ListExtensionsRequest, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = await ExtensionRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListExtensionsRequest request = new ListExtensionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListExtensionsResponse, Extension> response = extensionRegistryServiceClient.ListExtensionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Extension item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExtensionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Extension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Extension> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Extension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExtensions</summary>
        public void ListExtensions()
        {
            // Snippet: ListExtensions(string, string, int?, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = ExtensionRegistryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListExtensionsResponse, Extension> response = extensionRegistryServiceClient.ListExtensions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Extension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Extension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Extension> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Extension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExtensionsAsync</summary>
        public async Task ListExtensionsAsync()
        {
            // Snippet: ListExtensionsAsync(string, string, int?, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = await ExtensionRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListExtensionsResponse, Extension> response = extensionRegistryServiceClient.ListExtensionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Extension item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExtensionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Extension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Extension> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Extension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExtensions</summary>
        public void ListExtensionsResourceNames()
        {
            // Snippet: ListExtensions(LocationName, string, int?, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = ExtensionRegistryServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListExtensionsResponse, Extension> response = extensionRegistryServiceClient.ListExtensions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Extension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Extension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Extension> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Extension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExtensionsAsync</summary>
        public async Task ListExtensionsResourceNamesAsync()
        {
            // Snippet: ListExtensionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = await ExtensionRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListExtensionsResponse, Extension> response = extensionRegistryServiceClient.ListExtensionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Extension item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExtensionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Extension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Extension> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Extension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateExtension</summary>
        public void UpdateExtensionRequestObject()
        {
            // Snippet: UpdateExtension(UpdateExtensionRequest, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = ExtensionRegistryServiceClient.Create();
            // Initialize request argument(s)
            UpdateExtensionRequest request = new UpdateExtensionRequest
            {
                Extension = new Extension(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Extension response = extensionRegistryServiceClient.UpdateExtension(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExtensionAsync</summary>
        public async Task UpdateExtensionRequestObjectAsync()
        {
            // Snippet: UpdateExtensionAsync(UpdateExtensionRequest, CallSettings)
            // Additional: UpdateExtensionAsync(UpdateExtensionRequest, CancellationToken)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = await ExtensionRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateExtensionRequest request = new UpdateExtensionRequest
            {
                Extension = new Extension(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Extension response = await extensionRegistryServiceClient.UpdateExtensionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExtension</summary>
        public void UpdateExtension()
        {
            // Snippet: UpdateExtension(Extension, FieldMask, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = ExtensionRegistryServiceClient.Create();
            // Initialize request argument(s)
            Extension extension = new Extension();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Extension response = extensionRegistryServiceClient.UpdateExtension(extension, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateExtensionAsync</summary>
        public async Task UpdateExtensionAsync()
        {
            // Snippet: UpdateExtensionAsync(Extension, FieldMask, CallSettings)
            // Additional: UpdateExtensionAsync(Extension, FieldMask, CancellationToken)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = await ExtensionRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            Extension extension = new Extension();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Extension response = await extensionRegistryServiceClient.UpdateExtensionAsync(extension, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteExtension</summary>
        public void DeleteExtensionRequestObject()
        {
            // Snippet: DeleteExtension(DeleteExtensionRequest, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = ExtensionRegistryServiceClient.Create();
            // Initialize request argument(s)
            DeleteExtensionRequest request = new DeleteExtensionRequest
            {
                ExtensionName = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = extensionRegistryServiceClient.DeleteExtension(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = extensionRegistryServiceClient.PollOnceDeleteExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExtensionAsync</summary>
        public async Task DeleteExtensionRequestObjectAsync()
        {
            // Snippet: DeleteExtensionAsync(DeleteExtensionRequest, CallSettings)
            // Additional: DeleteExtensionAsync(DeleteExtensionRequest, CancellationToken)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = await ExtensionRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExtensionRequest request = new DeleteExtensionRequest
            {
                ExtensionName = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await extensionRegistryServiceClient.DeleteExtensionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await extensionRegistryServiceClient.PollOnceDeleteExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExtension</summary>
        public void DeleteExtension()
        {
            // Snippet: DeleteExtension(string, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = ExtensionRegistryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/extensions/[EXTENSION]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = extensionRegistryServiceClient.DeleteExtension(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = extensionRegistryServiceClient.PollOnceDeleteExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExtensionAsync</summary>
        public async Task DeleteExtensionAsync()
        {
            // Snippet: DeleteExtensionAsync(string, CallSettings)
            // Additional: DeleteExtensionAsync(string, CancellationToken)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = await ExtensionRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/extensions/[EXTENSION]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await extensionRegistryServiceClient.DeleteExtensionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await extensionRegistryServiceClient.PollOnceDeleteExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExtension</summary>
        public void DeleteExtensionResourceNames()
        {
            // Snippet: DeleteExtension(ExtensionName, CallSettings)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = ExtensionRegistryServiceClient.Create();
            // Initialize request argument(s)
            ExtensionName name = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = extensionRegistryServiceClient.DeleteExtension(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = extensionRegistryServiceClient.PollOnceDeleteExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExtensionAsync</summary>
        public async Task DeleteExtensionResourceNamesAsync()
        {
            // Snippet: DeleteExtensionAsync(ExtensionName, CallSettings)
            // Additional: DeleteExtensionAsync(ExtensionName, CancellationToken)
            // Create client
            ExtensionRegistryServiceClient extensionRegistryServiceClient = await ExtensionRegistryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExtensionName name = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await extensionRegistryServiceClient.DeleteExtensionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await extensionRegistryServiceClient.PollOnceDeleteExtensionAsync(operationName);
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
