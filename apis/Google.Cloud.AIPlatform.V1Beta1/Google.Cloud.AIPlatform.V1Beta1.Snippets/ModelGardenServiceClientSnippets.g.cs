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
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedModelGardenServiceClientSnippets
    {
        /// <summary>Snippet for GetPublisherModel</summary>
        public void GetPublisherModelRequestObject()
        {
            // Snippet: GetPublisherModel(GetPublisherModelRequest, CallSettings)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = ModelGardenServiceClient.Create();
            // Initialize request argument(s)
            GetPublisherModelRequest request = new GetPublisherModelRequest
            {
                PublisherModelName = PublisherModelName.FromPublisherModel("[PUBLISHER]", "[MODEL]"),
                LanguageCode = "",
                View = PublisherModelView.Unspecified,
                IsHuggingFaceModel = false,
                HuggingFaceToken = "",
            };
            // Make the request
            PublisherModel response = modelGardenServiceClient.GetPublisherModel(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherModelAsync</summary>
        public async Task GetPublisherModelRequestObjectAsync()
        {
            // Snippet: GetPublisherModelAsync(GetPublisherModelRequest, CallSettings)
            // Additional: GetPublisherModelAsync(GetPublisherModelRequest, CancellationToken)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = await ModelGardenServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPublisherModelRequest request = new GetPublisherModelRequest
            {
                PublisherModelName = PublisherModelName.FromPublisherModel("[PUBLISHER]", "[MODEL]"),
                LanguageCode = "",
                View = PublisherModelView.Unspecified,
                IsHuggingFaceModel = false,
                HuggingFaceToken = "",
            };
            // Make the request
            PublisherModel response = await modelGardenServiceClient.GetPublisherModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherModel</summary>
        public void GetPublisherModel()
        {
            // Snippet: GetPublisherModel(string, CallSettings)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = ModelGardenServiceClient.Create();
            // Initialize request argument(s)
            string name = "publishers/[PUBLISHER]/models/[MODEL]";
            // Make the request
            PublisherModel response = modelGardenServiceClient.GetPublisherModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherModelAsync</summary>
        public async Task GetPublisherModelAsync()
        {
            // Snippet: GetPublisherModelAsync(string, CallSettings)
            // Additional: GetPublisherModelAsync(string, CancellationToken)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = await ModelGardenServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "publishers/[PUBLISHER]/models/[MODEL]";
            // Make the request
            PublisherModel response = await modelGardenServiceClient.GetPublisherModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherModel</summary>
        public void GetPublisherModelResourceNames()
        {
            // Snippet: GetPublisherModel(PublisherModelName, CallSettings)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = ModelGardenServiceClient.Create();
            // Initialize request argument(s)
            PublisherModelName name = PublisherModelName.FromPublisherModel("[PUBLISHER]", "[MODEL]");
            // Make the request
            PublisherModel response = modelGardenServiceClient.GetPublisherModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherModelAsync</summary>
        public async Task GetPublisherModelResourceNamesAsync()
        {
            // Snippet: GetPublisherModelAsync(PublisherModelName, CallSettings)
            // Additional: GetPublisherModelAsync(PublisherModelName, CancellationToken)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = await ModelGardenServiceClient.CreateAsync();
            // Initialize request argument(s)
            PublisherModelName name = PublisherModelName.FromPublisherModel("[PUBLISHER]", "[MODEL]");
            // Make the request
            PublisherModel response = await modelGardenServiceClient.GetPublisherModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPublisherModels</summary>
        public void ListPublisherModelsRequestObject()
        {
            // Snippet: ListPublisherModels(ListPublisherModelsRequest, CallSettings)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = ModelGardenServiceClient.Create();
            // Initialize request argument(s)
            ListPublisherModelsRequest request = new ListPublisherModelsRequest
            {
                Parent = "",
                Filter = "",
                View = PublisherModelView.Unspecified,
                OrderBy = "",
                LanguageCode = "",
                ListAllVersions = false,
            };
            // Make the request
            PagedEnumerable<ListPublisherModelsResponse, PublisherModel> response = modelGardenServiceClient.ListPublisherModels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PublisherModel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPublisherModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublisherModel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublisherModel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublisherModel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublisherModelsAsync</summary>
        public async Task ListPublisherModelsRequestObjectAsync()
        {
            // Snippet: ListPublisherModelsAsync(ListPublisherModelsRequest, CallSettings)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = await ModelGardenServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPublisherModelsRequest request = new ListPublisherModelsRequest
            {
                Parent = "",
                Filter = "",
                View = PublisherModelView.Unspecified,
                OrderBy = "",
                LanguageCode = "",
                ListAllVersions = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListPublisherModelsResponse, PublisherModel> response = modelGardenServiceClient.ListPublisherModelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PublisherModel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPublisherModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublisherModel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublisherModel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublisherModel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublisherModels</summary>
        public void ListPublisherModels()
        {
            // Snippet: ListPublisherModels(string, string, int?, CallSettings)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = ModelGardenServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListPublisherModelsResponse, PublisherModel> response = modelGardenServiceClient.ListPublisherModels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PublisherModel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPublisherModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublisherModel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublisherModel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublisherModel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublisherModelsAsync</summary>
        public async Task ListPublisherModelsAsync()
        {
            // Snippet: ListPublisherModelsAsync(string, string, int?, CallSettings)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = await ModelGardenServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListPublisherModelsResponse, PublisherModel> response = modelGardenServiceClient.ListPublisherModelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PublisherModel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPublisherModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublisherModel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublisherModel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublisherModel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Deploy</summary>
        public void DeployRequestObject()
        {
            // Snippet: Deploy(DeployRequest, CallSettings)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = ModelGardenServiceClient.Create();
            // Initialize request argument(s)
            DeployRequest request = new DeployRequest
            {
                PublisherModelNameAsPublisherModelName = PublisherModelName.FromPublisherModel("[PUBLISHER]", "[MODEL]"),
                DestinationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ModelConfig = new DeployRequest.Types.ModelConfig(),
                EndpointConfig = new DeployRequest.Types.EndpointConfig(),
                DeployConfig = new DeployRequest.Types.DeployConfig(),
            };
            // Make the request
            Operation<DeployResponse, DeployOperationMetadata> response = modelGardenServiceClient.Deploy(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployResponse, DeployOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployResponse, DeployOperationMetadata> retrievedResponse = modelGardenServiceClient.PollOnceDeploy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployAsync</summary>
        public async Task DeployRequestObjectAsync()
        {
            // Snippet: DeployAsync(DeployRequest, CallSettings)
            // Additional: DeployAsync(DeployRequest, CancellationToken)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = await ModelGardenServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeployRequest request = new DeployRequest
            {
                PublisherModelNameAsPublisherModelName = PublisherModelName.FromPublisherModel("[PUBLISHER]", "[MODEL]"),
                DestinationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ModelConfig = new DeployRequest.Types.ModelConfig(),
                EndpointConfig = new DeployRequest.Types.EndpointConfig(),
                DeployConfig = new DeployRequest.Types.DeployConfig(),
            };
            // Make the request
            Operation<DeployResponse, DeployOperationMetadata> response = await modelGardenServiceClient.DeployAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployResponse, DeployOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployResponse, DeployOperationMetadata> retrievedResponse = await modelGardenServiceClient.PollOnceDeployAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployPublisherModel</summary>
        public void DeployPublisherModelRequestObject()
        {
            // Snippet: DeployPublisherModel(DeployPublisherModelRequest, CallSettings)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = ModelGardenServiceClient.Create();
            // Initialize request argument(s)
            DeployPublisherModelRequest request = new DeployPublisherModelRequest
            {
                Model = "",
                DestinationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EndpointDisplayName = "",
                DedicatedResources = new DedicatedResources(),
                ModelDisplayName = "",
                HuggingFaceAccessToken = "",
                AcceptEula = false,
            };
            // Make the request
            Operation<DeployPublisherModelResponse, DeployPublisherModelOperationMetadata> response = modelGardenServiceClient.DeployPublisherModel(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployPublisherModelResponse, DeployPublisherModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployPublisherModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployPublisherModelResponse, DeployPublisherModelOperationMetadata> retrievedResponse = modelGardenServiceClient.PollOnceDeployPublisherModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployPublisherModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployPublisherModelAsync</summary>
        public async Task DeployPublisherModelRequestObjectAsync()
        {
            // Snippet: DeployPublisherModelAsync(DeployPublisherModelRequest, CallSettings)
            // Additional: DeployPublisherModelAsync(DeployPublisherModelRequest, CancellationToken)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = await ModelGardenServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeployPublisherModelRequest request = new DeployPublisherModelRequest
            {
                Model = "",
                DestinationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EndpointDisplayName = "",
                DedicatedResources = new DedicatedResources(),
                ModelDisplayName = "",
                HuggingFaceAccessToken = "",
                AcceptEula = false,
            };
            // Make the request
            Operation<DeployPublisherModelResponse, DeployPublisherModelOperationMetadata> response = await modelGardenServiceClient.DeployPublisherModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployPublisherModelResponse, DeployPublisherModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployPublisherModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployPublisherModelResponse, DeployPublisherModelOperationMetadata> retrievedResponse = await modelGardenServiceClient.PollOnceDeployPublisherModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployPublisherModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
