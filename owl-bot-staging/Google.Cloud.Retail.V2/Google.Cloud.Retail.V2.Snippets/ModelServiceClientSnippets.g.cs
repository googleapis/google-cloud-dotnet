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
    using Google.Cloud.Retail.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedModelServiceClientSnippets
    {
        /// <summary>Snippet for CreateModel</summary>
        public void CreateModelRequestObject()
        {
            // Snippet: CreateModel(CreateModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            CreateModelRequest request = new CreateModelRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Model = new Model(),
                DryRun = false,
            };
            // Make the request
            Operation<Model, CreateModelMetadata> response = modelServiceClient.CreateModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Model, CreateModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, CreateModelMetadata> retrievedResponse = modelServiceClient.PollOnceCreateModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelAsync</summary>
        public async Task CreateModelRequestObjectAsync()
        {
            // Snippet: CreateModelAsync(CreateModelRequest, CallSettings)
            // Additional: CreateModelAsync(CreateModelRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateModelRequest request = new CreateModelRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Model = new Model(),
                DryRun = false,
            };
            // Make the request
            Operation<Model, CreateModelMetadata> response = await modelServiceClient.CreateModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Model, CreateModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, CreateModelMetadata> retrievedResponse = await modelServiceClient.PollOnceCreateModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModel</summary>
        public void CreateModel()
        {
            // Snippet: CreateModel(string, Model, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            Model model = new Model();
            // Make the request
            Operation<Model, CreateModelMetadata> response = modelServiceClient.CreateModel(parent, model);

            // Poll until the returned long-running operation is complete
            Operation<Model, CreateModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, CreateModelMetadata> retrievedResponse = modelServiceClient.PollOnceCreateModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelAsync</summary>
        public async Task CreateModelAsync()
        {
            // Snippet: CreateModelAsync(string, Model, CallSettings)
            // Additional: CreateModelAsync(string, Model, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            Model model = new Model();
            // Make the request
            Operation<Model, CreateModelMetadata> response = await modelServiceClient.CreateModelAsync(parent, model);

            // Poll until the returned long-running operation is complete
            Operation<Model, CreateModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, CreateModelMetadata> retrievedResponse = await modelServiceClient.PollOnceCreateModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModel</summary>
        public void CreateModelResourceNames()
        {
            // Snippet: CreateModel(CatalogName, Model, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            Model model = new Model();
            // Make the request
            Operation<Model, CreateModelMetadata> response = modelServiceClient.CreateModel(parent, model);

            // Poll until the returned long-running operation is complete
            Operation<Model, CreateModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, CreateModelMetadata> retrievedResponse = modelServiceClient.PollOnceCreateModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelAsync</summary>
        public async Task CreateModelResourceNamesAsync()
        {
            // Snippet: CreateModelAsync(CatalogName, Model, CallSettings)
            // Additional: CreateModelAsync(CatalogName, Model, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            Model model = new Model();
            // Make the request
            Operation<Model, CreateModelMetadata> response = await modelServiceClient.CreateModelAsync(parent, model);

            // Poll until the returned long-running operation is complete
            Operation<Model, CreateModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, CreateModelMetadata> retrievedResponse = await modelServiceClient.PollOnceCreateModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetModel</summary>
        public void GetModelRequestObject()
        {
            // Snippet: GetModel(GetModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            GetModelRequest request = new GetModelRequest
            {
                ModelName = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]"),
            };
            // Make the request
            Model response = modelServiceClient.GetModel(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelRequestObjectAsync()
        {
            // Snippet: GetModelAsync(GetModelRequest, CallSettings)
            // Additional: GetModelAsync(GetModelRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetModelRequest request = new GetModelRequest
            {
                ModelName = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]"),
            };
            // Make the request
            Model response = await modelServiceClient.GetModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetModel</summary>
        public void GetModel()
        {
            // Snippet: GetModel(string, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/models/[MODEL]";
            // Make the request
            Model response = modelServiceClient.GetModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelAsync()
        {
            // Snippet: GetModelAsync(string, CallSettings)
            // Additional: GetModelAsync(string, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/models/[MODEL]";
            // Make the request
            Model response = await modelServiceClient.GetModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetModel</summary>
        public void GetModelResourceNames()
        {
            // Snippet: GetModel(ModelName, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]");
            // Make the request
            Model response = modelServiceClient.GetModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelResourceNamesAsync()
        {
            // Snippet: GetModelAsync(ModelName, CallSettings)
            // Additional: GetModelAsync(ModelName, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]");
            // Make the request
            Model response = await modelServiceClient.GetModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseModel</summary>
        public void PauseModelRequestObject()
        {
            // Snippet: PauseModel(PauseModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            PauseModelRequest request = new PauseModelRequest
            {
                ModelName = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]"),
            };
            // Make the request
            Model response = modelServiceClient.PauseModel(request);
            // End snippet
        }

        /// <summary>Snippet for PauseModelAsync</summary>
        public async Task PauseModelRequestObjectAsync()
        {
            // Snippet: PauseModelAsync(PauseModelRequest, CallSettings)
            // Additional: PauseModelAsync(PauseModelRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            PauseModelRequest request = new PauseModelRequest
            {
                ModelName = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]"),
            };
            // Make the request
            Model response = await modelServiceClient.PauseModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PauseModel</summary>
        public void PauseModel()
        {
            // Snippet: PauseModel(string, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/models/[MODEL]";
            // Make the request
            Model response = modelServiceClient.PauseModel(name);
            // End snippet
        }

        /// <summary>Snippet for PauseModelAsync</summary>
        public async Task PauseModelAsync()
        {
            // Snippet: PauseModelAsync(string, CallSettings)
            // Additional: PauseModelAsync(string, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/models/[MODEL]";
            // Make the request
            Model response = await modelServiceClient.PauseModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseModel</summary>
        public void PauseModelResourceNames()
        {
            // Snippet: PauseModel(ModelName, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]");
            // Make the request
            Model response = modelServiceClient.PauseModel(name);
            // End snippet
        }

        /// <summary>Snippet for PauseModelAsync</summary>
        public async Task PauseModelResourceNamesAsync()
        {
            // Snippet: PauseModelAsync(ModelName, CallSettings)
            // Additional: PauseModelAsync(ModelName, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]");
            // Make the request
            Model response = await modelServiceClient.PauseModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeModel</summary>
        public void ResumeModelRequestObject()
        {
            // Snippet: ResumeModel(ResumeModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ResumeModelRequest request = new ResumeModelRequest { Name = "", };
            // Make the request
            Model response = modelServiceClient.ResumeModel(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeModelAsync</summary>
        public async Task ResumeModelRequestObjectAsync()
        {
            // Snippet: ResumeModelAsync(ResumeModelRequest, CallSettings)
            // Additional: ResumeModelAsync(ResumeModelRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResumeModelRequest request = new ResumeModelRequest { Name = "", };
            // Make the request
            Model response = await modelServiceClient.ResumeModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeModel</summary>
        public void ResumeModel()
        {
            // Snippet: ResumeModel(string, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Model response = modelServiceClient.ResumeModel(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeModelAsync</summary>
        public async Task ResumeModelAsync()
        {
            // Snippet: ResumeModelAsync(string, CallSettings)
            // Additional: ResumeModelAsync(string, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Model response = await modelServiceClient.ResumeModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModelRequestObject()
        {
            // Snippet: DeleteModel(DeleteModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            DeleteModelRequest request = new DeleteModelRequest
            {
                ModelName = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]"),
            };
            // Make the request
            modelServiceClient.DeleteModel(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteModelAsync</summary>
        public async Task DeleteModelRequestObjectAsync()
        {
            // Snippet: DeleteModelAsync(DeleteModelRequest, CallSettings)
            // Additional: DeleteModelAsync(DeleteModelRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteModelRequest request = new DeleteModelRequest
            {
                ModelName = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]"),
            };
            // Make the request
            await modelServiceClient.DeleteModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModel()
        {
            // Snippet: DeleteModel(string, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/models/[MODEL]";
            // Make the request
            modelServiceClient.DeleteModel(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteModelAsync</summary>
        public async Task DeleteModelAsync()
        {
            // Snippet: DeleteModelAsync(string, CallSettings)
            // Additional: DeleteModelAsync(string, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/models/[MODEL]";
            // Make the request
            await modelServiceClient.DeleteModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModelResourceNames()
        {
            // Snippet: DeleteModel(ModelName, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]");
            // Make the request
            modelServiceClient.DeleteModel(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteModelAsync</summary>
        public async Task DeleteModelResourceNamesAsync()
        {
            // Snippet: DeleteModelAsync(ModelName, CallSettings)
            // Additional: DeleteModelAsync(ModelName, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]");
            // Make the request
            await modelServiceClient.DeleteModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListModels</summary>
        public void ListModelsRequestObject()
        {
            // Snippet: ListModels(ListModelsRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ListModelsRequest request = new ListModelsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            // Make the request
            PagedEnumerable<ListModelsResponse, Model> response = modelServiceClient.ListModels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Model item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsRequestObjectAsync()
        {
            // Snippet: ListModelsAsync(ListModelsRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListModelsRequest request = new ListModelsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListModelsResponse, Model> response = modelServiceClient.ListModelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Model item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModels</summary>
        public void ListModels()
        {
            // Snippet: ListModels(string, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            // Make the request
            PagedEnumerable<ListModelsResponse, Model> response = modelServiceClient.ListModels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Model item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsAsync()
        {
            // Snippet: ListModelsAsync(string, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            // Make the request
            PagedAsyncEnumerable<ListModelsResponse, Model> response = modelServiceClient.ListModelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Model item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModels</summary>
        public void ListModelsResourceNames()
        {
            // Snippet: ListModels(CatalogName, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            // Make the request
            PagedEnumerable<ListModelsResponse, Model> response = modelServiceClient.ListModels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Model item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsResourceNamesAsync()
        {
            // Snippet: ListModelsAsync(CatalogName, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            // Make the request
            PagedAsyncEnumerable<ListModelsResponse, Model> response = modelServiceClient.ListModelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Model item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateModel</summary>
        public void UpdateModelRequestObject()
        {
            // Snippet: UpdateModel(UpdateModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            UpdateModelRequest request = new UpdateModelRequest
            {
                Model = new Model(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Model response = modelServiceClient.UpdateModel(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateModelAsync</summary>
        public async Task UpdateModelRequestObjectAsync()
        {
            // Snippet: UpdateModelAsync(UpdateModelRequest, CallSettings)
            // Additional: UpdateModelAsync(UpdateModelRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateModelRequest request = new UpdateModelRequest
            {
                Model = new Model(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Model response = await modelServiceClient.UpdateModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateModel</summary>
        public void UpdateModel()
        {
            // Snippet: UpdateModel(Model, FieldMask, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            Model model = new Model();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Model response = modelServiceClient.UpdateModel(model, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateModelAsync</summary>
        public async Task UpdateModelAsync()
        {
            // Snippet: UpdateModelAsync(Model, FieldMask, CallSettings)
            // Additional: UpdateModelAsync(Model, FieldMask, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            Model model = new Model();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Model response = await modelServiceClient.UpdateModelAsync(model, updateMask);
            // End snippet
        }

        /// <summary>Snippet for TuneModel</summary>
        public void TuneModelRequestObject()
        {
            // Snippet: TuneModel(TuneModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            TuneModelRequest request = new TuneModelRequest
            {
                ModelName = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]"),
            };
            // Make the request
            Operation<TuneModelResponse, TuneModelMetadata> response = modelServiceClient.TuneModel(request);

            // Poll until the returned long-running operation is complete
            Operation<TuneModelResponse, TuneModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TuneModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuneModelResponse, TuneModelMetadata> retrievedResponse = modelServiceClient.PollOnceTuneModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuneModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TuneModelAsync</summary>
        public async Task TuneModelRequestObjectAsync()
        {
            // Snippet: TuneModelAsync(TuneModelRequest, CallSettings)
            // Additional: TuneModelAsync(TuneModelRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            TuneModelRequest request = new TuneModelRequest
            {
                ModelName = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]"),
            };
            // Make the request
            Operation<TuneModelResponse, TuneModelMetadata> response = await modelServiceClient.TuneModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TuneModelResponse, TuneModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TuneModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuneModelResponse, TuneModelMetadata> retrievedResponse = await modelServiceClient.PollOnceTuneModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuneModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TuneModel</summary>
        public void TuneModel()
        {
            // Snippet: TuneModel(string, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/models/[MODEL]";
            // Make the request
            Operation<TuneModelResponse, TuneModelMetadata> response = modelServiceClient.TuneModel(name);

            // Poll until the returned long-running operation is complete
            Operation<TuneModelResponse, TuneModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TuneModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuneModelResponse, TuneModelMetadata> retrievedResponse = modelServiceClient.PollOnceTuneModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuneModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TuneModelAsync</summary>
        public async Task TuneModelAsync()
        {
            // Snippet: TuneModelAsync(string, CallSettings)
            // Additional: TuneModelAsync(string, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/models/[MODEL]";
            // Make the request
            Operation<TuneModelResponse, TuneModelMetadata> response = await modelServiceClient.TuneModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<TuneModelResponse, TuneModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TuneModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuneModelResponse, TuneModelMetadata> retrievedResponse = await modelServiceClient.PollOnceTuneModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuneModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TuneModel</summary>
        public void TuneModelResourceNames()
        {
            // Snippet: TuneModel(ModelName, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]");
            // Make the request
            Operation<TuneModelResponse, TuneModelMetadata> response = modelServiceClient.TuneModel(name);

            // Poll until the returned long-running operation is complete
            Operation<TuneModelResponse, TuneModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TuneModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuneModelResponse, TuneModelMetadata> retrievedResponse = modelServiceClient.PollOnceTuneModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuneModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TuneModelAsync</summary>
        public async Task TuneModelResourceNamesAsync()
        {
            // Snippet: TuneModelAsync(ModelName, CallSettings)
            // Additional: TuneModelAsync(ModelName, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationCatalogModel("[PROJECT]", "[LOCATION]", "[CATALOG]", "[MODEL]");
            // Make the request
            Operation<TuneModelResponse, TuneModelMetadata> response = await modelServiceClient.TuneModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<TuneModelResponse, TuneModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TuneModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuneModelResponse, TuneModelMetadata> retrievedResponse = await modelServiceClient.PollOnceTuneModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuneModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
