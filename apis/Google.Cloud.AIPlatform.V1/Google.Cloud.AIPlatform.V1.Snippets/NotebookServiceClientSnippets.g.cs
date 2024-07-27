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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNotebookServiceClientSnippets
    {
        /// <summary>Snippet for CreateNotebookRuntimeTemplate</summary>
        public void CreateNotebookRuntimeTemplateRequestObject()
        {
            // Snippet: CreateNotebookRuntimeTemplate(CreateNotebookRuntimeTemplateRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            CreateNotebookRuntimeTemplateRequest request = new CreateNotebookRuntimeTemplateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NotebookRuntimeTemplate = new NotebookRuntimeTemplate(),
                NotebookRuntimeTemplateId = "",
            };
            // Make the request
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> response = notebookServiceClient.CreateNotebookRuntimeTemplate(request);

            // Poll until the returned long-running operation is complete
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NotebookRuntimeTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateNotebookRuntimeTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookRuntimeTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNotebookRuntimeTemplateAsync</summary>
        public async Task CreateNotebookRuntimeTemplateRequestObjectAsync()
        {
            // Snippet: CreateNotebookRuntimeTemplateAsync(CreateNotebookRuntimeTemplateRequest, CallSettings)
            // Additional: CreateNotebookRuntimeTemplateAsync(CreateNotebookRuntimeTemplateRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateNotebookRuntimeTemplateRequest request = new CreateNotebookRuntimeTemplateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NotebookRuntimeTemplate = new NotebookRuntimeTemplate(),
                NotebookRuntimeTemplateId = "",
            };
            // Make the request
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> response = await notebookServiceClient.CreateNotebookRuntimeTemplateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NotebookRuntimeTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateNotebookRuntimeTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookRuntimeTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNotebookRuntimeTemplate</summary>
        public void CreateNotebookRuntimeTemplate()
        {
            // Snippet: CreateNotebookRuntimeTemplate(string, NotebookRuntimeTemplate, string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            NotebookRuntimeTemplate notebookRuntimeTemplate = new NotebookRuntimeTemplate();
            string notebookRuntimeTemplateId = "";
            // Make the request
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> response = notebookServiceClient.CreateNotebookRuntimeTemplate(parent, notebookRuntimeTemplate, notebookRuntimeTemplateId);

            // Poll until the returned long-running operation is complete
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NotebookRuntimeTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateNotebookRuntimeTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookRuntimeTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNotebookRuntimeTemplateAsync</summary>
        public async Task CreateNotebookRuntimeTemplateAsync()
        {
            // Snippet: CreateNotebookRuntimeTemplateAsync(string, NotebookRuntimeTemplate, string, CallSettings)
            // Additional: CreateNotebookRuntimeTemplateAsync(string, NotebookRuntimeTemplate, string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            NotebookRuntimeTemplate notebookRuntimeTemplate = new NotebookRuntimeTemplate();
            string notebookRuntimeTemplateId = "";
            // Make the request
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> response = await notebookServiceClient.CreateNotebookRuntimeTemplateAsync(parent, notebookRuntimeTemplate, notebookRuntimeTemplateId);

            // Poll until the returned long-running operation is complete
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NotebookRuntimeTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateNotebookRuntimeTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookRuntimeTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNotebookRuntimeTemplate</summary>
        public void CreateNotebookRuntimeTemplateResourceNames()
        {
            // Snippet: CreateNotebookRuntimeTemplate(LocationName, NotebookRuntimeTemplate, string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NotebookRuntimeTemplate notebookRuntimeTemplate = new NotebookRuntimeTemplate();
            string notebookRuntimeTemplateId = "";
            // Make the request
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> response = notebookServiceClient.CreateNotebookRuntimeTemplate(parent, notebookRuntimeTemplate, notebookRuntimeTemplateId);

            // Poll until the returned long-running operation is complete
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NotebookRuntimeTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateNotebookRuntimeTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookRuntimeTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNotebookRuntimeTemplateAsync</summary>
        public async Task CreateNotebookRuntimeTemplateResourceNamesAsync()
        {
            // Snippet: CreateNotebookRuntimeTemplateAsync(LocationName, NotebookRuntimeTemplate, string, CallSettings)
            // Additional: CreateNotebookRuntimeTemplateAsync(LocationName, NotebookRuntimeTemplate, string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NotebookRuntimeTemplate notebookRuntimeTemplate = new NotebookRuntimeTemplate();
            string notebookRuntimeTemplateId = "";
            // Make the request
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> response = await notebookServiceClient.CreateNotebookRuntimeTemplateAsync(parent, notebookRuntimeTemplate, notebookRuntimeTemplateId);

            // Poll until the returned long-running operation is complete
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NotebookRuntimeTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateNotebookRuntimeTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookRuntimeTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetNotebookRuntimeTemplate</summary>
        public void GetNotebookRuntimeTemplateRequestObject()
        {
            // Snippet: GetNotebookRuntimeTemplate(GetNotebookRuntimeTemplateRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            GetNotebookRuntimeTemplateRequest request = new GetNotebookRuntimeTemplateRequest
            {
                NotebookRuntimeTemplateName = NotebookRuntimeTemplateName.FromProjectLocationNotebookRuntimeTemplate("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME_TEMPLATE]"),
            };
            // Make the request
            NotebookRuntimeTemplate response = notebookServiceClient.GetNotebookRuntimeTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookRuntimeTemplateAsync</summary>
        public async Task GetNotebookRuntimeTemplateRequestObjectAsync()
        {
            // Snippet: GetNotebookRuntimeTemplateAsync(GetNotebookRuntimeTemplateRequest, CallSettings)
            // Additional: GetNotebookRuntimeTemplateAsync(GetNotebookRuntimeTemplateRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNotebookRuntimeTemplateRequest request = new GetNotebookRuntimeTemplateRequest
            {
                NotebookRuntimeTemplateName = NotebookRuntimeTemplateName.FromProjectLocationNotebookRuntimeTemplate("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME_TEMPLATE]"),
            };
            // Make the request
            NotebookRuntimeTemplate response = await notebookServiceClient.GetNotebookRuntimeTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookRuntimeTemplate</summary>
        public void GetNotebookRuntimeTemplate()
        {
            // Snippet: GetNotebookRuntimeTemplate(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookRuntimeTemplates/[NOTEBOOK_RUNTIME_TEMPLATE]";
            // Make the request
            NotebookRuntimeTemplate response = notebookServiceClient.GetNotebookRuntimeTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookRuntimeTemplateAsync</summary>
        public async Task GetNotebookRuntimeTemplateAsync()
        {
            // Snippet: GetNotebookRuntimeTemplateAsync(string, CallSettings)
            // Additional: GetNotebookRuntimeTemplateAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookRuntimeTemplates/[NOTEBOOK_RUNTIME_TEMPLATE]";
            // Make the request
            NotebookRuntimeTemplate response = await notebookServiceClient.GetNotebookRuntimeTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookRuntimeTemplate</summary>
        public void GetNotebookRuntimeTemplateResourceNames()
        {
            // Snippet: GetNotebookRuntimeTemplate(NotebookRuntimeTemplateName, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            NotebookRuntimeTemplateName name = NotebookRuntimeTemplateName.FromProjectLocationNotebookRuntimeTemplate("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME_TEMPLATE]");
            // Make the request
            NotebookRuntimeTemplate response = notebookServiceClient.GetNotebookRuntimeTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookRuntimeTemplateAsync</summary>
        public async Task GetNotebookRuntimeTemplateResourceNamesAsync()
        {
            // Snippet: GetNotebookRuntimeTemplateAsync(NotebookRuntimeTemplateName, CallSettings)
            // Additional: GetNotebookRuntimeTemplateAsync(NotebookRuntimeTemplateName, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotebookRuntimeTemplateName name = NotebookRuntimeTemplateName.FromProjectLocationNotebookRuntimeTemplate("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME_TEMPLATE]");
            // Make the request
            NotebookRuntimeTemplate response = await notebookServiceClient.GetNotebookRuntimeTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNotebookRuntimeTemplates</summary>
        public void ListNotebookRuntimeTemplatesRequestObject()
        {
            // Snippet: ListNotebookRuntimeTemplates(ListNotebookRuntimeTemplatesRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ListNotebookRuntimeTemplatesRequest request = new ListNotebookRuntimeTemplatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate> response = notebookServiceClient.ListNotebookRuntimeTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotebookRuntimeTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotebookRuntimeTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookRuntimeTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookRuntimeTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookRuntimeTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookRuntimeTemplatesAsync</summary>
        public async Task ListNotebookRuntimeTemplatesRequestObjectAsync()
        {
            // Snippet: ListNotebookRuntimeTemplatesAsync(ListNotebookRuntimeTemplatesRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNotebookRuntimeTemplatesRequest request = new ListNotebookRuntimeTemplatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate> response = notebookServiceClient.ListNotebookRuntimeTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotebookRuntimeTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotebookRuntimeTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookRuntimeTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookRuntimeTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookRuntimeTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookRuntimeTemplates</summary>
        public void ListNotebookRuntimeTemplates()
        {
            // Snippet: ListNotebookRuntimeTemplates(string, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate> response = notebookServiceClient.ListNotebookRuntimeTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotebookRuntimeTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotebookRuntimeTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookRuntimeTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookRuntimeTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookRuntimeTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookRuntimeTemplatesAsync</summary>
        public async Task ListNotebookRuntimeTemplatesAsync()
        {
            // Snippet: ListNotebookRuntimeTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate> response = notebookServiceClient.ListNotebookRuntimeTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotebookRuntimeTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotebookRuntimeTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookRuntimeTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookRuntimeTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookRuntimeTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookRuntimeTemplates</summary>
        public void ListNotebookRuntimeTemplatesResourceNames()
        {
            // Snippet: ListNotebookRuntimeTemplates(LocationName, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate> response = notebookServiceClient.ListNotebookRuntimeTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotebookRuntimeTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotebookRuntimeTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookRuntimeTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookRuntimeTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookRuntimeTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookRuntimeTemplatesAsync</summary>
        public async Task ListNotebookRuntimeTemplatesResourceNamesAsync()
        {
            // Snippet: ListNotebookRuntimeTemplatesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate> response = notebookServiceClient.ListNotebookRuntimeTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotebookRuntimeTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotebookRuntimeTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookRuntimeTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookRuntimeTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookRuntimeTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookRuntimeTemplate</summary>
        public void DeleteNotebookRuntimeTemplateRequestObject()
        {
            // Snippet: DeleteNotebookRuntimeTemplate(DeleteNotebookRuntimeTemplateRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            DeleteNotebookRuntimeTemplateRequest request = new DeleteNotebookRuntimeTemplateRequest
            {
                NotebookRuntimeTemplateName = NotebookRuntimeTemplateName.FromProjectLocationNotebookRuntimeTemplate("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME_TEMPLATE]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = notebookServiceClient.DeleteNotebookRuntimeTemplate(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteNotebookRuntimeTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookRuntimeTemplateAsync</summary>
        public async Task DeleteNotebookRuntimeTemplateRequestObjectAsync()
        {
            // Snippet: DeleteNotebookRuntimeTemplateAsync(DeleteNotebookRuntimeTemplateRequest, CallSettings)
            // Additional: DeleteNotebookRuntimeTemplateAsync(DeleteNotebookRuntimeTemplateRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNotebookRuntimeTemplateRequest request = new DeleteNotebookRuntimeTemplateRequest
            {
                NotebookRuntimeTemplateName = NotebookRuntimeTemplateName.FromProjectLocationNotebookRuntimeTemplate("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME_TEMPLATE]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await notebookServiceClient.DeleteNotebookRuntimeTemplateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteNotebookRuntimeTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookRuntimeTemplate</summary>
        public void DeleteNotebookRuntimeTemplate()
        {
            // Snippet: DeleteNotebookRuntimeTemplate(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookRuntimeTemplates/[NOTEBOOK_RUNTIME_TEMPLATE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = notebookServiceClient.DeleteNotebookRuntimeTemplate(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteNotebookRuntimeTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookRuntimeTemplateAsync</summary>
        public async Task DeleteNotebookRuntimeTemplateAsync()
        {
            // Snippet: DeleteNotebookRuntimeTemplateAsync(string, CallSettings)
            // Additional: DeleteNotebookRuntimeTemplateAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookRuntimeTemplates/[NOTEBOOK_RUNTIME_TEMPLATE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await notebookServiceClient.DeleteNotebookRuntimeTemplateAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteNotebookRuntimeTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookRuntimeTemplate</summary>
        public void DeleteNotebookRuntimeTemplateResourceNames()
        {
            // Snippet: DeleteNotebookRuntimeTemplate(NotebookRuntimeTemplateName, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            NotebookRuntimeTemplateName name = NotebookRuntimeTemplateName.FromProjectLocationNotebookRuntimeTemplate("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME_TEMPLATE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = notebookServiceClient.DeleteNotebookRuntimeTemplate(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteNotebookRuntimeTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookRuntimeTemplateAsync</summary>
        public async Task DeleteNotebookRuntimeTemplateResourceNamesAsync()
        {
            // Snippet: DeleteNotebookRuntimeTemplateAsync(NotebookRuntimeTemplateName, CallSettings)
            // Additional: DeleteNotebookRuntimeTemplateAsync(NotebookRuntimeTemplateName, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotebookRuntimeTemplateName name = NotebookRuntimeTemplateName.FromProjectLocationNotebookRuntimeTemplate("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME_TEMPLATE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await notebookServiceClient.DeleteNotebookRuntimeTemplateAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteNotebookRuntimeTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNotebookRuntimeTemplate</summary>
        public void UpdateNotebookRuntimeTemplateRequestObject()
        {
            // Snippet: UpdateNotebookRuntimeTemplate(UpdateNotebookRuntimeTemplateRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            UpdateNotebookRuntimeTemplateRequest request = new UpdateNotebookRuntimeTemplateRequest
            {
                NotebookRuntimeTemplate = new NotebookRuntimeTemplate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            NotebookRuntimeTemplate response = notebookServiceClient.UpdateNotebookRuntimeTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotebookRuntimeTemplateAsync</summary>
        public async Task UpdateNotebookRuntimeTemplateRequestObjectAsync()
        {
            // Snippet: UpdateNotebookRuntimeTemplateAsync(UpdateNotebookRuntimeTemplateRequest, CallSettings)
            // Additional: UpdateNotebookRuntimeTemplateAsync(UpdateNotebookRuntimeTemplateRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNotebookRuntimeTemplateRequest request = new UpdateNotebookRuntimeTemplateRequest
            {
                NotebookRuntimeTemplate = new NotebookRuntimeTemplate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            NotebookRuntimeTemplate response = await notebookServiceClient.UpdateNotebookRuntimeTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotebookRuntimeTemplate</summary>
        public void UpdateNotebookRuntimeTemplate()
        {
            // Snippet: UpdateNotebookRuntimeTemplate(NotebookRuntimeTemplate, FieldMask, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            NotebookRuntimeTemplate notebookRuntimeTemplate = new NotebookRuntimeTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            NotebookRuntimeTemplate response = notebookServiceClient.UpdateNotebookRuntimeTemplate(notebookRuntimeTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotebookRuntimeTemplateAsync</summary>
        public async Task UpdateNotebookRuntimeTemplateAsync()
        {
            // Snippet: UpdateNotebookRuntimeTemplateAsync(NotebookRuntimeTemplate, FieldMask, CallSettings)
            // Additional: UpdateNotebookRuntimeTemplateAsync(NotebookRuntimeTemplate, FieldMask, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotebookRuntimeTemplate notebookRuntimeTemplate = new NotebookRuntimeTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            NotebookRuntimeTemplate response = await notebookServiceClient.UpdateNotebookRuntimeTemplateAsync(notebookRuntimeTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for AssignNotebookRuntime</summary>
        public void AssignNotebookRuntimeRequestObject()
        {
            // Snippet: AssignNotebookRuntime(AssignNotebookRuntimeRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            AssignNotebookRuntimeRequest request = new AssignNotebookRuntimeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NotebookRuntimeTemplateAsNotebookRuntimeTemplateName = NotebookRuntimeTemplateName.FromProjectLocationNotebookRuntimeTemplate("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME_TEMPLATE]"),
                NotebookRuntime = new NotebookRuntime(),
                NotebookRuntimeId = "",
            };
            // Make the request
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> response = notebookServiceClient.AssignNotebookRuntime(request);

            // Poll until the returned long-running operation is complete
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NotebookRuntime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceAssignNotebookRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookRuntime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AssignNotebookRuntimeAsync</summary>
        public async Task AssignNotebookRuntimeRequestObjectAsync()
        {
            // Snippet: AssignNotebookRuntimeAsync(AssignNotebookRuntimeRequest, CallSettings)
            // Additional: AssignNotebookRuntimeAsync(AssignNotebookRuntimeRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssignNotebookRuntimeRequest request = new AssignNotebookRuntimeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NotebookRuntimeTemplateAsNotebookRuntimeTemplateName = NotebookRuntimeTemplateName.FromProjectLocationNotebookRuntimeTemplate("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME_TEMPLATE]"),
                NotebookRuntime = new NotebookRuntime(),
                NotebookRuntimeId = "",
            };
            // Make the request
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> response = await notebookServiceClient.AssignNotebookRuntimeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NotebookRuntime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceAssignNotebookRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookRuntime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AssignNotebookRuntime</summary>
        public void AssignNotebookRuntime()
        {
            // Snippet: AssignNotebookRuntime(string, string, NotebookRuntime, string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string notebookRuntimeTemplate = "projects/[PROJECT]/locations/[LOCATION]/notebookRuntimeTemplates/[NOTEBOOK_RUNTIME_TEMPLATE]";
            NotebookRuntime notebookRuntime = new NotebookRuntime();
            string notebookRuntimeId = "";
            // Make the request
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> response = notebookServiceClient.AssignNotebookRuntime(parent, notebookRuntimeTemplate, notebookRuntime, notebookRuntimeId);

            // Poll until the returned long-running operation is complete
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NotebookRuntime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceAssignNotebookRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookRuntime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AssignNotebookRuntimeAsync</summary>
        public async Task AssignNotebookRuntimeAsync()
        {
            // Snippet: AssignNotebookRuntimeAsync(string, string, NotebookRuntime, string, CallSettings)
            // Additional: AssignNotebookRuntimeAsync(string, string, NotebookRuntime, string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string notebookRuntimeTemplate = "projects/[PROJECT]/locations/[LOCATION]/notebookRuntimeTemplates/[NOTEBOOK_RUNTIME_TEMPLATE]";
            NotebookRuntime notebookRuntime = new NotebookRuntime();
            string notebookRuntimeId = "";
            // Make the request
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> response = await notebookServiceClient.AssignNotebookRuntimeAsync(parent, notebookRuntimeTemplate, notebookRuntime, notebookRuntimeId);

            // Poll until the returned long-running operation is complete
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NotebookRuntime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceAssignNotebookRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookRuntime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AssignNotebookRuntime</summary>
        public void AssignNotebookRuntimeResourceNames()
        {
            // Snippet: AssignNotebookRuntime(LocationName, NotebookRuntimeTemplateName, NotebookRuntime, string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NotebookRuntimeTemplateName notebookRuntimeTemplate = NotebookRuntimeTemplateName.FromProjectLocationNotebookRuntimeTemplate("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME_TEMPLATE]");
            NotebookRuntime notebookRuntime = new NotebookRuntime();
            string notebookRuntimeId = "";
            // Make the request
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> response = notebookServiceClient.AssignNotebookRuntime(parent, notebookRuntimeTemplate, notebookRuntime, notebookRuntimeId);

            // Poll until the returned long-running operation is complete
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NotebookRuntime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceAssignNotebookRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookRuntime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AssignNotebookRuntimeAsync</summary>
        public async Task AssignNotebookRuntimeResourceNamesAsync()
        {
            // Snippet: AssignNotebookRuntimeAsync(LocationName, NotebookRuntimeTemplateName, NotebookRuntime, string, CallSettings)
            // Additional: AssignNotebookRuntimeAsync(LocationName, NotebookRuntimeTemplateName, NotebookRuntime, string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NotebookRuntimeTemplateName notebookRuntimeTemplate = NotebookRuntimeTemplateName.FromProjectLocationNotebookRuntimeTemplate("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME_TEMPLATE]");
            NotebookRuntime notebookRuntime = new NotebookRuntime();
            string notebookRuntimeId = "";
            // Make the request
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> response = await notebookServiceClient.AssignNotebookRuntimeAsync(parent, notebookRuntimeTemplate, notebookRuntime, notebookRuntimeId);

            // Poll until the returned long-running operation is complete
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NotebookRuntime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceAssignNotebookRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookRuntime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetNotebookRuntime</summary>
        public void GetNotebookRuntimeRequestObject()
        {
            // Snippet: GetNotebookRuntime(GetNotebookRuntimeRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            GetNotebookRuntimeRequest request = new GetNotebookRuntimeRequest
            {
                NotebookRuntimeName = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]"),
            };
            // Make the request
            NotebookRuntime response = notebookServiceClient.GetNotebookRuntime(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookRuntimeAsync</summary>
        public async Task GetNotebookRuntimeRequestObjectAsync()
        {
            // Snippet: GetNotebookRuntimeAsync(GetNotebookRuntimeRequest, CallSettings)
            // Additional: GetNotebookRuntimeAsync(GetNotebookRuntimeRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNotebookRuntimeRequest request = new GetNotebookRuntimeRequest
            {
                NotebookRuntimeName = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]"),
            };
            // Make the request
            NotebookRuntime response = await notebookServiceClient.GetNotebookRuntimeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookRuntime</summary>
        public void GetNotebookRuntime()
        {
            // Snippet: GetNotebookRuntime(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookRuntimes/[NOTEBOOK_RUNTIME]";
            // Make the request
            NotebookRuntime response = notebookServiceClient.GetNotebookRuntime(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookRuntimeAsync</summary>
        public async Task GetNotebookRuntimeAsync()
        {
            // Snippet: GetNotebookRuntimeAsync(string, CallSettings)
            // Additional: GetNotebookRuntimeAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookRuntimes/[NOTEBOOK_RUNTIME]";
            // Make the request
            NotebookRuntime response = await notebookServiceClient.GetNotebookRuntimeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookRuntime</summary>
        public void GetNotebookRuntimeResourceNames()
        {
            // Snippet: GetNotebookRuntime(NotebookRuntimeName, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            NotebookRuntimeName name = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]");
            // Make the request
            NotebookRuntime response = notebookServiceClient.GetNotebookRuntime(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookRuntimeAsync</summary>
        public async Task GetNotebookRuntimeResourceNamesAsync()
        {
            // Snippet: GetNotebookRuntimeAsync(NotebookRuntimeName, CallSettings)
            // Additional: GetNotebookRuntimeAsync(NotebookRuntimeName, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotebookRuntimeName name = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]");
            // Make the request
            NotebookRuntime response = await notebookServiceClient.GetNotebookRuntimeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNotebookRuntimes</summary>
        public void ListNotebookRuntimesRequestObject()
        {
            // Snippet: ListNotebookRuntimes(ListNotebookRuntimesRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ListNotebookRuntimesRequest request = new ListNotebookRuntimesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListNotebookRuntimesResponse, NotebookRuntime> response = notebookServiceClient.ListNotebookRuntimes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotebookRuntime item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotebookRuntimesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookRuntime item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookRuntime> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookRuntime item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookRuntimesAsync</summary>
        public async Task ListNotebookRuntimesRequestObjectAsync()
        {
            // Snippet: ListNotebookRuntimesAsync(ListNotebookRuntimesRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNotebookRuntimesRequest request = new ListNotebookRuntimesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListNotebookRuntimesResponse, NotebookRuntime> response = notebookServiceClient.ListNotebookRuntimesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotebookRuntime item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotebookRuntimesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookRuntime item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookRuntime> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookRuntime item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookRuntimes</summary>
        public void ListNotebookRuntimes()
        {
            // Snippet: ListNotebookRuntimes(string, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListNotebookRuntimesResponse, NotebookRuntime> response = notebookServiceClient.ListNotebookRuntimes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotebookRuntime item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotebookRuntimesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookRuntime item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookRuntime> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookRuntime item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookRuntimesAsync</summary>
        public async Task ListNotebookRuntimesAsync()
        {
            // Snippet: ListNotebookRuntimesAsync(string, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListNotebookRuntimesResponse, NotebookRuntime> response = notebookServiceClient.ListNotebookRuntimesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotebookRuntime item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotebookRuntimesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookRuntime item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookRuntime> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookRuntime item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookRuntimes</summary>
        public void ListNotebookRuntimesResourceNames()
        {
            // Snippet: ListNotebookRuntimes(LocationName, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNotebookRuntimesResponse, NotebookRuntime> response = notebookServiceClient.ListNotebookRuntimes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotebookRuntime item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotebookRuntimesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookRuntime item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookRuntime> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookRuntime item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookRuntimesAsync</summary>
        public async Task ListNotebookRuntimesResourceNamesAsync()
        {
            // Snippet: ListNotebookRuntimesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNotebookRuntimesResponse, NotebookRuntime> response = notebookServiceClient.ListNotebookRuntimesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotebookRuntime item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotebookRuntimesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookRuntime item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookRuntime> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookRuntime item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookRuntime</summary>
        public void DeleteNotebookRuntimeRequestObject()
        {
            // Snippet: DeleteNotebookRuntime(DeleteNotebookRuntimeRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            DeleteNotebookRuntimeRequest request = new DeleteNotebookRuntimeRequest
            {
                NotebookRuntimeName = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = notebookServiceClient.DeleteNotebookRuntime(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteNotebookRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookRuntimeAsync</summary>
        public async Task DeleteNotebookRuntimeRequestObjectAsync()
        {
            // Snippet: DeleteNotebookRuntimeAsync(DeleteNotebookRuntimeRequest, CallSettings)
            // Additional: DeleteNotebookRuntimeAsync(DeleteNotebookRuntimeRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNotebookRuntimeRequest request = new DeleteNotebookRuntimeRequest
            {
                NotebookRuntimeName = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await notebookServiceClient.DeleteNotebookRuntimeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteNotebookRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookRuntime</summary>
        public void DeleteNotebookRuntime()
        {
            // Snippet: DeleteNotebookRuntime(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookRuntimes/[NOTEBOOK_RUNTIME]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = notebookServiceClient.DeleteNotebookRuntime(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteNotebookRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookRuntimeAsync</summary>
        public async Task DeleteNotebookRuntimeAsync()
        {
            // Snippet: DeleteNotebookRuntimeAsync(string, CallSettings)
            // Additional: DeleteNotebookRuntimeAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookRuntimes/[NOTEBOOK_RUNTIME]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await notebookServiceClient.DeleteNotebookRuntimeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteNotebookRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookRuntime</summary>
        public void DeleteNotebookRuntimeResourceNames()
        {
            // Snippet: DeleteNotebookRuntime(NotebookRuntimeName, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            NotebookRuntimeName name = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = notebookServiceClient.DeleteNotebookRuntime(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteNotebookRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookRuntimeAsync</summary>
        public async Task DeleteNotebookRuntimeResourceNamesAsync()
        {
            // Snippet: DeleteNotebookRuntimeAsync(NotebookRuntimeName, CallSettings)
            // Additional: DeleteNotebookRuntimeAsync(NotebookRuntimeName, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotebookRuntimeName name = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await notebookServiceClient.DeleteNotebookRuntimeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteNotebookRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeNotebookRuntime</summary>
        public void UpgradeNotebookRuntimeRequestObject()
        {
            // Snippet: UpgradeNotebookRuntime(UpgradeNotebookRuntimeRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            UpgradeNotebookRuntimeRequest request = new UpgradeNotebookRuntimeRequest
            {
                NotebookRuntimeName = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]"),
            };
            // Make the request
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> response = notebookServiceClient.UpgradeNotebookRuntime(request);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UpgradeNotebookRuntimeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceUpgradeNotebookRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeNotebookRuntimeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeNotebookRuntimeAsync</summary>
        public async Task UpgradeNotebookRuntimeRequestObjectAsync()
        {
            // Snippet: UpgradeNotebookRuntimeAsync(UpgradeNotebookRuntimeRequest, CallSettings)
            // Additional: UpgradeNotebookRuntimeAsync(UpgradeNotebookRuntimeRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpgradeNotebookRuntimeRequest request = new UpgradeNotebookRuntimeRequest
            {
                NotebookRuntimeName = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]"),
            };
            // Make the request
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> response = await notebookServiceClient.UpgradeNotebookRuntimeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UpgradeNotebookRuntimeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceUpgradeNotebookRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeNotebookRuntimeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeNotebookRuntime</summary>
        public void UpgradeNotebookRuntime()
        {
            // Snippet: UpgradeNotebookRuntime(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookRuntimes/[NOTEBOOK_RUNTIME]";
            // Make the request
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> response = notebookServiceClient.UpgradeNotebookRuntime(name);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UpgradeNotebookRuntimeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceUpgradeNotebookRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeNotebookRuntimeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeNotebookRuntimeAsync</summary>
        public async Task UpgradeNotebookRuntimeAsync()
        {
            // Snippet: UpgradeNotebookRuntimeAsync(string, CallSettings)
            // Additional: UpgradeNotebookRuntimeAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookRuntimes/[NOTEBOOK_RUNTIME]";
            // Make the request
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> response = await notebookServiceClient.UpgradeNotebookRuntimeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UpgradeNotebookRuntimeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceUpgradeNotebookRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeNotebookRuntimeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeNotebookRuntime</summary>
        public void UpgradeNotebookRuntimeResourceNames()
        {
            // Snippet: UpgradeNotebookRuntime(NotebookRuntimeName, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            NotebookRuntimeName name = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]");
            // Make the request
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> response = notebookServiceClient.UpgradeNotebookRuntime(name);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UpgradeNotebookRuntimeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceUpgradeNotebookRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeNotebookRuntimeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeNotebookRuntimeAsync</summary>
        public async Task UpgradeNotebookRuntimeResourceNamesAsync()
        {
            // Snippet: UpgradeNotebookRuntimeAsync(NotebookRuntimeName, CallSettings)
            // Additional: UpgradeNotebookRuntimeAsync(NotebookRuntimeName, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotebookRuntimeName name = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]");
            // Make the request
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> response = await notebookServiceClient.UpgradeNotebookRuntimeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UpgradeNotebookRuntimeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceUpgradeNotebookRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeNotebookRuntimeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartNotebookRuntime</summary>
        public void StartNotebookRuntimeRequestObject()
        {
            // Snippet: StartNotebookRuntime(StartNotebookRuntimeRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            StartNotebookRuntimeRequest request = new StartNotebookRuntimeRequest
            {
                NotebookRuntimeName = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]"),
            };
            // Make the request
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> response = notebookServiceClient.StartNotebookRuntime(request);

            // Poll until the returned long-running operation is complete
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StartNotebookRuntimeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceStartNotebookRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartNotebookRuntimeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartNotebookRuntimeAsync</summary>
        public async Task StartNotebookRuntimeRequestObjectAsync()
        {
            // Snippet: StartNotebookRuntimeAsync(StartNotebookRuntimeRequest, CallSettings)
            // Additional: StartNotebookRuntimeAsync(StartNotebookRuntimeRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartNotebookRuntimeRequest request = new StartNotebookRuntimeRequest
            {
                NotebookRuntimeName = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]"),
            };
            // Make the request
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> response = await notebookServiceClient.StartNotebookRuntimeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StartNotebookRuntimeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceStartNotebookRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartNotebookRuntimeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartNotebookRuntime</summary>
        public void StartNotebookRuntime()
        {
            // Snippet: StartNotebookRuntime(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookRuntimes/[NOTEBOOK_RUNTIME]";
            // Make the request
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> response = notebookServiceClient.StartNotebookRuntime(name);

            // Poll until the returned long-running operation is complete
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StartNotebookRuntimeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceStartNotebookRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartNotebookRuntimeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartNotebookRuntimeAsync</summary>
        public async Task StartNotebookRuntimeAsync()
        {
            // Snippet: StartNotebookRuntimeAsync(string, CallSettings)
            // Additional: StartNotebookRuntimeAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookRuntimes/[NOTEBOOK_RUNTIME]";
            // Make the request
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> response = await notebookServiceClient.StartNotebookRuntimeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StartNotebookRuntimeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceStartNotebookRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartNotebookRuntimeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartNotebookRuntime</summary>
        public void StartNotebookRuntimeResourceNames()
        {
            // Snippet: StartNotebookRuntime(NotebookRuntimeName, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            NotebookRuntimeName name = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]");
            // Make the request
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> response = notebookServiceClient.StartNotebookRuntime(name);

            // Poll until the returned long-running operation is complete
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StartNotebookRuntimeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceStartNotebookRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartNotebookRuntimeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartNotebookRuntimeAsync</summary>
        public async Task StartNotebookRuntimeResourceNamesAsync()
        {
            // Snippet: StartNotebookRuntimeAsync(NotebookRuntimeName, CallSettings)
            // Additional: StartNotebookRuntimeAsync(NotebookRuntimeName, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotebookRuntimeName name = NotebookRuntimeName.FromProjectLocationNotebookRuntime("[PROJECT]", "[LOCATION]", "[NOTEBOOK_RUNTIME]");
            // Make the request
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> response = await notebookServiceClient.StartNotebookRuntimeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StartNotebookRuntimeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceStartNotebookRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartNotebookRuntimeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNotebookExecutionJob</summary>
        public void CreateNotebookExecutionJobRequestObject()
        {
            // Snippet: CreateNotebookExecutionJob(CreateNotebookExecutionJobRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            CreateNotebookExecutionJobRequest request = new CreateNotebookExecutionJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NotebookExecutionJob = new NotebookExecutionJob(),
                NotebookExecutionJobId = "",
            };
            // Make the request
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> response = notebookServiceClient.CreateNotebookExecutionJob(request);

            // Poll until the returned long-running operation is complete
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NotebookExecutionJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateNotebookExecutionJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookExecutionJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNotebookExecutionJobAsync</summary>
        public async Task CreateNotebookExecutionJobRequestObjectAsync()
        {
            // Snippet: CreateNotebookExecutionJobAsync(CreateNotebookExecutionJobRequest, CallSettings)
            // Additional: CreateNotebookExecutionJobAsync(CreateNotebookExecutionJobRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateNotebookExecutionJobRequest request = new CreateNotebookExecutionJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NotebookExecutionJob = new NotebookExecutionJob(),
                NotebookExecutionJobId = "",
            };
            // Make the request
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> response = await notebookServiceClient.CreateNotebookExecutionJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NotebookExecutionJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateNotebookExecutionJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookExecutionJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNotebookExecutionJob</summary>
        public void CreateNotebookExecutionJob()
        {
            // Snippet: CreateNotebookExecutionJob(string, NotebookExecutionJob, string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            NotebookExecutionJob notebookExecutionJob = new NotebookExecutionJob();
            string notebookExecutionJobId = "";
            // Make the request
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> response = notebookServiceClient.CreateNotebookExecutionJob(parent, notebookExecutionJob, notebookExecutionJobId);

            // Poll until the returned long-running operation is complete
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NotebookExecutionJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateNotebookExecutionJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookExecutionJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNotebookExecutionJobAsync</summary>
        public async Task CreateNotebookExecutionJobAsync()
        {
            // Snippet: CreateNotebookExecutionJobAsync(string, NotebookExecutionJob, string, CallSettings)
            // Additional: CreateNotebookExecutionJobAsync(string, NotebookExecutionJob, string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            NotebookExecutionJob notebookExecutionJob = new NotebookExecutionJob();
            string notebookExecutionJobId = "";
            // Make the request
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> response = await notebookServiceClient.CreateNotebookExecutionJobAsync(parent, notebookExecutionJob, notebookExecutionJobId);

            // Poll until the returned long-running operation is complete
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NotebookExecutionJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateNotebookExecutionJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookExecutionJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNotebookExecutionJob</summary>
        public void CreateNotebookExecutionJobResourceNames()
        {
            // Snippet: CreateNotebookExecutionJob(LocationName, NotebookExecutionJob, string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NotebookExecutionJob notebookExecutionJob = new NotebookExecutionJob();
            string notebookExecutionJobId = "";
            // Make the request
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> response = notebookServiceClient.CreateNotebookExecutionJob(parent, notebookExecutionJob, notebookExecutionJobId);

            // Poll until the returned long-running operation is complete
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NotebookExecutionJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateNotebookExecutionJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookExecutionJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNotebookExecutionJobAsync</summary>
        public async Task CreateNotebookExecutionJobResourceNamesAsync()
        {
            // Snippet: CreateNotebookExecutionJobAsync(LocationName, NotebookExecutionJob, string, CallSettings)
            // Additional: CreateNotebookExecutionJobAsync(LocationName, NotebookExecutionJob, string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NotebookExecutionJob notebookExecutionJob = new NotebookExecutionJob();
            string notebookExecutionJobId = "";
            // Make the request
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> response = await notebookServiceClient.CreateNotebookExecutionJobAsync(parent, notebookExecutionJob, notebookExecutionJobId);

            // Poll until the returned long-running operation is complete
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NotebookExecutionJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookExecutionJob, CreateNotebookExecutionJobOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateNotebookExecutionJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookExecutionJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetNotebookExecutionJob</summary>
        public void GetNotebookExecutionJobRequestObject()
        {
            // Snippet: GetNotebookExecutionJob(GetNotebookExecutionJobRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            GetNotebookExecutionJobRequest request = new GetNotebookExecutionJobRequest
            {
                NotebookExecutionJobName = NotebookExecutionJobName.FromProjectLocationNotebookExecutionJob("[PROJECT]", "[LOCATION]", "[NOTEBOOK_EXECUTION_JOB]"),
                View = NotebookExecutionJobView.Unspecified,
            };
            // Make the request
            NotebookExecutionJob response = notebookServiceClient.GetNotebookExecutionJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookExecutionJobAsync</summary>
        public async Task GetNotebookExecutionJobRequestObjectAsync()
        {
            // Snippet: GetNotebookExecutionJobAsync(GetNotebookExecutionJobRequest, CallSettings)
            // Additional: GetNotebookExecutionJobAsync(GetNotebookExecutionJobRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNotebookExecutionJobRequest request = new GetNotebookExecutionJobRequest
            {
                NotebookExecutionJobName = NotebookExecutionJobName.FromProjectLocationNotebookExecutionJob("[PROJECT]", "[LOCATION]", "[NOTEBOOK_EXECUTION_JOB]"),
                View = NotebookExecutionJobView.Unspecified,
            };
            // Make the request
            NotebookExecutionJob response = await notebookServiceClient.GetNotebookExecutionJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookExecutionJob</summary>
        public void GetNotebookExecutionJob()
        {
            // Snippet: GetNotebookExecutionJob(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookExecutionJobs/[NOTEBOOK_EXECUTION_JOB]";
            // Make the request
            NotebookExecutionJob response = notebookServiceClient.GetNotebookExecutionJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookExecutionJobAsync</summary>
        public async Task GetNotebookExecutionJobAsync()
        {
            // Snippet: GetNotebookExecutionJobAsync(string, CallSettings)
            // Additional: GetNotebookExecutionJobAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookExecutionJobs/[NOTEBOOK_EXECUTION_JOB]";
            // Make the request
            NotebookExecutionJob response = await notebookServiceClient.GetNotebookExecutionJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookExecutionJob</summary>
        public void GetNotebookExecutionJobResourceNames()
        {
            // Snippet: GetNotebookExecutionJob(NotebookExecutionJobName, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            NotebookExecutionJobName name = NotebookExecutionJobName.FromProjectLocationNotebookExecutionJob("[PROJECT]", "[LOCATION]", "[NOTEBOOK_EXECUTION_JOB]");
            // Make the request
            NotebookExecutionJob response = notebookServiceClient.GetNotebookExecutionJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotebookExecutionJobAsync</summary>
        public async Task GetNotebookExecutionJobResourceNamesAsync()
        {
            // Snippet: GetNotebookExecutionJobAsync(NotebookExecutionJobName, CallSettings)
            // Additional: GetNotebookExecutionJobAsync(NotebookExecutionJobName, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotebookExecutionJobName name = NotebookExecutionJobName.FromProjectLocationNotebookExecutionJob("[PROJECT]", "[LOCATION]", "[NOTEBOOK_EXECUTION_JOB]");
            // Make the request
            NotebookExecutionJob response = await notebookServiceClient.GetNotebookExecutionJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNotebookExecutionJobs</summary>
        public void ListNotebookExecutionJobsRequestObject()
        {
            // Snippet: ListNotebookExecutionJobs(ListNotebookExecutionJobsRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ListNotebookExecutionJobsRequest request = new ListNotebookExecutionJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                View = NotebookExecutionJobView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListNotebookExecutionJobsResponse, NotebookExecutionJob> response = notebookServiceClient.ListNotebookExecutionJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotebookExecutionJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotebookExecutionJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookExecutionJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookExecutionJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookExecutionJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookExecutionJobsAsync</summary>
        public async Task ListNotebookExecutionJobsRequestObjectAsync()
        {
            // Snippet: ListNotebookExecutionJobsAsync(ListNotebookExecutionJobsRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNotebookExecutionJobsRequest request = new ListNotebookExecutionJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                View = NotebookExecutionJobView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListNotebookExecutionJobsResponse, NotebookExecutionJob> response = notebookServiceClient.ListNotebookExecutionJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotebookExecutionJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotebookExecutionJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookExecutionJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookExecutionJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookExecutionJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookExecutionJobs</summary>
        public void ListNotebookExecutionJobs()
        {
            // Snippet: ListNotebookExecutionJobs(string, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListNotebookExecutionJobsResponse, NotebookExecutionJob> response = notebookServiceClient.ListNotebookExecutionJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotebookExecutionJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotebookExecutionJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookExecutionJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookExecutionJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookExecutionJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookExecutionJobsAsync</summary>
        public async Task ListNotebookExecutionJobsAsync()
        {
            // Snippet: ListNotebookExecutionJobsAsync(string, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListNotebookExecutionJobsResponse, NotebookExecutionJob> response = notebookServiceClient.ListNotebookExecutionJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotebookExecutionJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotebookExecutionJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookExecutionJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookExecutionJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookExecutionJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookExecutionJobs</summary>
        public void ListNotebookExecutionJobsResourceNames()
        {
            // Snippet: ListNotebookExecutionJobs(LocationName, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNotebookExecutionJobsResponse, NotebookExecutionJob> response = notebookServiceClient.ListNotebookExecutionJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotebookExecutionJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotebookExecutionJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookExecutionJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookExecutionJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookExecutionJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotebookExecutionJobsAsync</summary>
        public async Task ListNotebookExecutionJobsResourceNamesAsync()
        {
            // Snippet: ListNotebookExecutionJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNotebookExecutionJobsResponse, NotebookExecutionJob> response = notebookServiceClient.ListNotebookExecutionJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotebookExecutionJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotebookExecutionJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotebookExecutionJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotebookExecutionJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotebookExecutionJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookExecutionJob</summary>
        public void DeleteNotebookExecutionJobRequestObject()
        {
            // Snippet: DeleteNotebookExecutionJob(DeleteNotebookExecutionJobRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            DeleteNotebookExecutionJobRequest request = new DeleteNotebookExecutionJobRequest
            {
                NotebookExecutionJobName = NotebookExecutionJobName.FromProjectLocationNotebookExecutionJob("[PROJECT]", "[LOCATION]", "[NOTEBOOK_EXECUTION_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = notebookServiceClient.DeleteNotebookExecutionJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteNotebookExecutionJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookExecutionJobAsync</summary>
        public async Task DeleteNotebookExecutionJobRequestObjectAsync()
        {
            // Snippet: DeleteNotebookExecutionJobAsync(DeleteNotebookExecutionJobRequest, CallSettings)
            // Additional: DeleteNotebookExecutionJobAsync(DeleteNotebookExecutionJobRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNotebookExecutionJobRequest request = new DeleteNotebookExecutionJobRequest
            {
                NotebookExecutionJobName = NotebookExecutionJobName.FromProjectLocationNotebookExecutionJob("[PROJECT]", "[LOCATION]", "[NOTEBOOK_EXECUTION_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await notebookServiceClient.DeleteNotebookExecutionJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteNotebookExecutionJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookExecutionJob</summary>
        public void DeleteNotebookExecutionJob()
        {
            // Snippet: DeleteNotebookExecutionJob(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookExecutionJobs/[NOTEBOOK_EXECUTION_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = notebookServiceClient.DeleteNotebookExecutionJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteNotebookExecutionJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookExecutionJobAsync</summary>
        public async Task DeleteNotebookExecutionJobAsync()
        {
            // Snippet: DeleteNotebookExecutionJobAsync(string, CallSettings)
            // Additional: DeleteNotebookExecutionJobAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/notebookExecutionJobs/[NOTEBOOK_EXECUTION_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await notebookServiceClient.DeleteNotebookExecutionJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteNotebookExecutionJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookExecutionJob</summary>
        public void DeleteNotebookExecutionJobResourceNames()
        {
            // Snippet: DeleteNotebookExecutionJob(NotebookExecutionJobName, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            NotebookExecutionJobName name = NotebookExecutionJobName.FromProjectLocationNotebookExecutionJob("[PROJECT]", "[LOCATION]", "[NOTEBOOK_EXECUTION_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = notebookServiceClient.DeleteNotebookExecutionJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteNotebookExecutionJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNotebookExecutionJobAsync</summary>
        public async Task DeleteNotebookExecutionJobResourceNamesAsync()
        {
            // Snippet: DeleteNotebookExecutionJobAsync(NotebookExecutionJobName, CallSettings)
            // Additional: DeleteNotebookExecutionJobAsync(NotebookExecutionJobName, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotebookExecutionJobName name = NotebookExecutionJobName.FromProjectLocationNotebookExecutionJob("[PROJECT]", "[LOCATION]", "[NOTEBOOK_EXECUTION_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await notebookServiceClient.DeleteNotebookExecutionJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteNotebookExecutionJobAsync(operationName);
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
