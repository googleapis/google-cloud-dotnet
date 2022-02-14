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

namespace Google.Cloud.AIPlatform.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedModelServiceClientSnippets
    {
        /// <summary>Snippet for UploadModel</summary>
        public void UploadModelRequestObject()
        {
            // Snippet: UploadModel(UploadModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            UploadModelRequest request = new UploadModelRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Model = new Model(),
            };
            // Make the request
            Operation<UploadModelResponse, UploadModelOperationMetadata> response = modelServiceClient.UploadModel(request);

            // Poll until the returned long-running operation is complete
            Operation<UploadModelResponse, UploadModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UploadModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UploadModelResponse, UploadModelOperationMetadata> retrievedResponse = modelServiceClient.PollOnceUploadModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UploadModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UploadModelAsync</summary>
        public async Task UploadModelRequestObjectAsync()
        {
            // Snippet: UploadModelAsync(UploadModelRequest, CallSettings)
            // Additional: UploadModelAsync(UploadModelRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            UploadModelRequest request = new UploadModelRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Model = new Model(),
            };
            // Make the request
            Operation<UploadModelResponse, UploadModelOperationMetadata> response = await modelServiceClient.UploadModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UploadModelResponse, UploadModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UploadModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UploadModelResponse, UploadModelOperationMetadata> retrievedResponse = await modelServiceClient.PollOnceUploadModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UploadModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UploadModel</summary>
        public void UploadModel()
        {
            // Snippet: UploadModel(string, Model, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Model model = new Model();
            // Make the request
            Operation<UploadModelResponse, UploadModelOperationMetadata> response = modelServiceClient.UploadModel(parent, model);

            // Poll until the returned long-running operation is complete
            Operation<UploadModelResponse, UploadModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UploadModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UploadModelResponse, UploadModelOperationMetadata> retrievedResponse = modelServiceClient.PollOnceUploadModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UploadModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UploadModelAsync</summary>
        public async Task UploadModelAsync()
        {
            // Snippet: UploadModelAsync(string, Model, CallSettings)
            // Additional: UploadModelAsync(string, Model, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Model model = new Model();
            // Make the request
            Operation<UploadModelResponse, UploadModelOperationMetadata> response = await modelServiceClient.UploadModelAsync(parent, model);

            // Poll until the returned long-running operation is complete
            Operation<UploadModelResponse, UploadModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UploadModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UploadModelResponse, UploadModelOperationMetadata> retrievedResponse = await modelServiceClient.PollOnceUploadModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UploadModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UploadModel</summary>
        public void UploadModelResourceNames()
        {
            // Snippet: UploadModel(LocationName, Model, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Model model = new Model();
            // Make the request
            Operation<UploadModelResponse, UploadModelOperationMetadata> response = modelServiceClient.UploadModel(parent, model);

            // Poll until the returned long-running operation is complete
            Operation<UploadModelResponse, UploadModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UploadModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UploadModelResponse, UploadModelOperationMetadata> retrievedResponse = modelServiceClient.PollOnceUploadModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UploadModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UploadModelAsync</summary>
        public async Task UploadModelResourceNamesAsync()
        {
            // Snippet: UploadModelAsync(LocationName, Model, CallSettings)
            // Additional: UploadModelAsync(LocationName, Model, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Model model = new Model();
            // Make the request
            Operation<UploadModelResponse, UploadModelOperationMetadata> response = await modelServiceClient.UploadModelAsync(parent, model);

            // Poll until the returned long-running operation is complete
            Operation<UploadModelResponse, UploadModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UploadModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UploadModelResponse, UploadModelOperationMetadata> retrievedResponse = await modelServiceClient.PollOnceUploadModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UploadModelResponse retrievedResult = retrievedResponse.Result;
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
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
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
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
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
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
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
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Model response = await modelServiceClient.GetModelAsync(name);
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
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
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
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
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
            // Snippet: ListModels(LocationName, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
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
            // Snippet: ListModelsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
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

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModelRequestObject()
        {
            // Snippet: DeleteModel(DeleteModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            DeleteModelRequest request = new DeleteModelRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = modelServiceClient.DeleteModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = modelServiceClient.PollOnceDeleteModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
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
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await modelServiceClient.DeleteModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await modelServiceClient.PollOnceDeleteModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModel()
        {
            // Snippet: DeleteModel(string, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = modelServiceClient.DeleteModel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = modelServiceClient.PollOnceDeleteModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await modelServiceClient.DeleteModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await modelServiceClient.PollOnceDeleteModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModelResourceNames()
        {
            // Snippet: DeleteModel(ModelName, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = modelServiceClient.DeleteModel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = modelServiceClient.PollOnceDeleteModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
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
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await modelServiceClient.DeleteModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await modelServiceClient.PollOnceDeleteModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportModel</summary>
        public void ExportModelRequestObject()
        {
            // Snippet: ExportModel(ExportModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ExportModelRequest request = new ExportModelRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                OutputConfig = new ExportModelRequest.Types.OutputConfig(),
            };
            // Make the request
            Operation<ExportModelResponse, ExportModelOperationMetadata> response = modelServiceClient.ExportModel(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportModelResponse, ExportModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportModelResponse, ExportModelOperationMetadata> retrievedResponse = modelServiceClient.PollOnceExportModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportModelAsync</summary>
        public async Task ExportModelRequestObjectAsync()
        {
            // Snippet: ExportModelAsync(ExportModelRequest, CallSettings)
            // Additional: ExportModelAsync(ExportModelRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportModelRequest request = new ExportModelRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                OutputConfig = new ExportModelRequest.Types.OutputConfig(),
            };
            // Make the request
            Operation<ExportModelResponse, ExportModelOperationMetadata> response = await modelServiceClient.ExportModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportModelResponse, ExportModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportModelResponse, ExportModelOperationMetadata> retrievedResponse = await modelServiceClient.PollOnceExportModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportModel</summary>
        public void ExportModel()
        {
            // Snippet: ExportModel(string, ExportModelRequest.Types.OutputConfig, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            ExportModelRequest.Types.OutputConfig outputConfig = new ExportModelRequest.Types.OutputConfig();
            // Make the request
            Operation<ExportModelResponse, ExportModelOperationMetadata> response = modelServiceClient.ExportModel(name, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ExportModelResponse, ExportModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportModelResponse, ExportModelOperationMetadata> retrievedResponse = modelServiceClient.PollOnceExportModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportModelAsync</summary>
        public async Task ExportModelAsync()
        {
            // Snippet: ExportModelAsync(string, ExportModelRequest.Types.OutputConfig, CallSettings)
            // Additional: ExportModelAsync(string, ExportModelRequest.Types.OutputConfig, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            ExportModelRequest.Types.OutputConfig outputConfig = new ExportModelRequest.Types.OutputConfig();
            // Make the request
            Operation<ExportModelResponse, ExportModelOperationMetadata> response = await modelServiceClient.ExportModelAsync(name, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ExportModelResponse, ExportModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportModelResponse, ExportModelOperationMetadata> retrievedResponse = await modelServiceClient.PollOnceExportModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportModel</summary>
        public void ExportModelResourceNames()
        {
            // Snippet: ExportModel(ModelName, ExportModelRequest.Types.OutputConfig, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            ExportModelRequest.Types.OutputConfig outputConfig = new ExportModelRequest.Types.OutputConfig();
            // Make the request
            Operation<ExportModelResponse, ExportModelOperationMetadata> response = modelServiceClient.ExportModel(name, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ExportModelResponse, ExportModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportModelResponse, ExportModelOperationMetadata> retrievedResponse = modelServiceClient.PollOnceExportModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportModelAsync</summary>
        public async Task ExportModelResourceNamesAsync()
        {
            // Snippet: ExportModelAsync(ModelName, ExportModelRequest.Types.OutputConfig, CallSettings)
            // Additional: ExportModelAsync(ModelName, ExportModelRequest.Types.OutputConfig, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            ExportModelRequest.Types.OutputConfig outputConfig = new ExportModelRequest.Types.OutputConfig();
            // Make the request
            Operation<ExportModelResponse, ExportModelOperationMetadata> response = await modelServiceClient.ExportModelAsync(name, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ExportModelResponse, ExportModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportModelResponse, ExportModelOperationMetadata> retrievedResponse = await modelServiceClient.PollOnceExportModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluation</summary>
        public void GetModelEvaluationRequestObject()
        {
            // Snippet: GetModelEvaluation(GetModelEvaluationRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            GetModelEvaluationRequest request = new GetModelEvaluationRequest
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
            };
            // Make the request
            ModelEvaluation response = modelServiceClient.GetModelEvaluation(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluationAsync</summary>
        public async Task GetModelEvaluationRequestObjectAsync()
        {
            // Snippet: GetModelEvaluationAsync(GetModelEvaluationRequest, CallSettings)
            // Additional: GetModelEvaluationAsync(GetModelEvaluationRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetModelEvaluationRequest request = new GetModelEvaluationRequest
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
            };
            // Make the request
            ModelEvaluation response = await modelServiceClient.GetModelEvaluationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluation</summary>
        public void GetModelEvaluation()
        {
            // Snippet: GetModelEvaluation(string, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]/evaluations/[EVALUATION]";
            // Make the request
            ModelEvaluation response = modelServiceClient.GetModelEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluationAsync</summary>
        public async Task GetModelEvaluationAsync()
        {
            // Snippet: GetModelEvaluationAsync(string, CallSettings)
            // Additional: GetModelEvaluationAsync(string, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]/evaluations/[EVALUATION]";
            // Make the request
            ModelEvaluation response = await modelServiceClient.GetModelEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluation</summary>
        public void GetModelEvaluationResourceNames()
        {
            // Snippet: GetModelEvaluation(ModelEvaluationName, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ModelEvaluationName name = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]");
            // Make the request
            ModelEvaluation response = modelServiceClient.GetModelEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluationAsync</summary>
        public async Task GetModelEvaluationResourceNamesAsync()
        {
            // Snippet: GetModelEvaluationAsync(ModelEvaluationName, CallSettings)
            // Additional: GetModelEvaluationAsync(ModelEvaluationName, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelEvaluationName name = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]");
            // Make the request
            ModelEvaluation response = await modelServiceClient.GetModelEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluations</summary>
        public void ListModelEvaluationsRequestObject()
        {
            // Snippet: ListModelEvaluations(ListModelEvaluationsRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ListModelEvaluationsRequest request = new ListModelEvaluationsRequest
            {
                ParentAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> response = modelServiceClient.ListModelEvaluations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelEvaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluationsAsync</summary>
        public async Task ListModelEvaluationsRequestObjectAsync()
        {
            // Snippet: ListModelEvaluationsAsync(ListModelEvaluationsRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListModelEvaluationsRequest request = new ListModelEvaluationsRequest
            {
                ParentAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> response = modelServiceClient.ListModelEvaluationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelEvaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluations</summary>
        public void ListModelEvaluations()
        {
            // Snippet: ListModelEvaluations(string, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            // Make the request
            PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> response = modelServiceClient.ListModelEvaluations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelEvaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluationsAsync</summary>
        public async Task ListModelEvaluationsAsync()
        {
            // Snippet: ListModelEvaluationsAsync(string, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            // Make the request
            PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> response = modelServiceClient.ListModelEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelEvaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluations</summary>
        public void ListModelEvaluationsResourceNames()
        {
            // Snippet: ListModelEvaluations(ModelName, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ModelName parent = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> response = modelServiceClient.ListModelEvaluations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelEvaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluationsAsync</summary>
        public async Task ListModelEvaluationsResourceNamesAsync()
        {
            // Snippet: ListModelEvaluationsAsync(ModelName, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName parent = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> response = modelServiceClient.ListModelEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelEvaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluationSlice</summary>
        public void GetModelEvaluationSliceRequestObject()
        {
            // Snippet: GetModelEvaluationSlice(GetModelEvaluationSliceRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            GetModelEvaluationSliceRequest request = new GetModelEvaluationSliceRequest
            {
                ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
            };
            // Make the request
            ModelEvaluationSlice response = modelServiceClient.GetModelEvaluationSlice(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluationSliceAsync</summary>
        public async Task GetModelEvaluationSliceRequestObjectAsync()
        {
            // Snippet: GetModelEvaluationSliceAsync(GetModelEvaluationSliceRequest, CallSettings)
            // Additional: GetModelEvaluationSliceAsync(GetModelEvaluationSliceRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetModelEvaluationSliceRequest request = new GetModelEvaluationSliceRequest
            {
                ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
            };
            // Make the request
            ModelEvaluationSlice response = await modelServiceClient.GetModelEvaluationSliceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluationSlice</summary>
        public void GetModelEvaluationSlice()
        {
            // Snippet: GetModelEvaluationSlice(string, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]/evaluations/[EVALUATION]/slices/[SLICE]";
            // Make the request
            ModelEvaluationSlice response = modelServiceClient.GetModelEvaluationSlice(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluationSliceAsync</summary>
        public async Task GetModelEvaluationSliceAsync()
        {
            // Snippet: GetModelEvaluationSliceAsync(string, CallSettings)
            // Additional: GetModelEvaluationSliceAsync(string, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]/evaluations/[EVALUATION]/slices/[SLICE]";
            // Make the request
            ModelEvaluationSlice response = await modelServiceClient.GetModelEvaluationSliceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluationSlice</summary>
        public void GetModelEvaluationSliceResourceNames()
        {
            // Snippet: GetModelEvaluationSlice(ModelEvaluationSliceName, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ModelEvaluationSliceName name = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]");
            // Make the request
            ModelEvaluationSlice response = modelServiceClient.GetModelEvaluationSlice(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluationSliceAsync</summary>
        public async Task GetModelEvaluationSliceResourceNamesAsync()
        {
            // Snippet: GetModelEvaluationSliceAsync(ModelEvaluationSliceName, CallSettings)
            // Additional: GetModelEvaluationSliceAsync(ModelEvaluationSliceName, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelEvaluationSliceName name = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]");
            // Make the request
            ModelEvaluationSlice response = await modelServiceClient.GetModelEvaluationSliceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluationSlices</summary>
        public void ListModelEvaluationSlicesRequestObject()
        {
            // Snippet: ListModelEvaluationSlices(ListModelEvaluationSlicesRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ListModelEvaluationSlicesRequest request = new ListModelEvaluationSlicesRequest
            {
                ParentAsModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> response = modelServiceClient.ListModelEvaluationSlices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelEvaluationSlice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelEvaluationSlicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluationSlice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluationSlice> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluationSlice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluationSlicesAsync</summary>
        public async Task ListModelEvaluationSlicesRequestObjectAsync()
        {
            // Snippet: ListModelEvaluationSlicesAsync(ListModelEvaluationSlicesRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListModelEvaluationSlicesRequest request = new ListModelEvaluationSlicesRequest
            {
                ParentAsModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> response = modelServiceClient.ListModelEvaluationSlicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelEvaluationSlice item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelEvaluationSlicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluationSlice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluationSlice> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluationSlice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluationSlices</summary>
        public void ListModelEvaluationSlices()
        {
            // Snippet: ListModelEvaluationSlices(string, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]/evaluations/[EVALUATION]";
            // Make the request
            PagedEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> response = modelServiceClient.ListModelEvaluationSlices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelEvaluationSlice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelEvaluationSlicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluationSlice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluationSlice> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluationSlice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluationSlicesAsync</summary>
        public async Task ListModelEvaluationSlicesAsync()
        {
            // Snippet: ListModelEvaluationSlicesAsync(string, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]/evaluations/[EVALUATION]";
            // Make the request
            PagedAsyncEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> response = modelServiceClient.ListModelEvaluationSlicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelEvaluationSlice item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelEvaluationSlicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluationSlice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluationSlice> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluationSlice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluationSlices</summary>
        public void ListModelEvaluationSlicesResourceNames()
        {
            // Snippet: ListModelEvaluationSlices(ModelEvaluationName, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ModelEvaluationName parent = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]");
            // Make the request
            PagedEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> response = modelServiceClient.ListModelEvaluationSlices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelEvaluationSlice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelEvaluationSlicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluationSlice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluationSlice> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluationSlice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluationSlicesAsync</summary>
        public async Task ListModelEvaluationSlicesResourceNamesAsync()
        {
            // Snippet: ListModelEvaluationSlicesAsync(ModelEvaluationName, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelEvaluationName parent = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]");
            // Make the request
            PagedAsyncEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> response = modelServiceClient.ListModelEvaluationSlicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelEvaluationSlice item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelEvaluationSlicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluationSlice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluationSlice> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluationSlice item in singlePage)
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
