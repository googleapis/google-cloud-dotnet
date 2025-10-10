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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPreviewFeaturesClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetPreviewFeatureRequest, CallSettings)
            // Create client
            PreviewFeaturesClient previewFeaturesClient = PreviewFeaturesClient.Create();
            // Initialize request argument(s)
            GetPreviewFeatureRequest request = new GetPreviewFeatureRequest
            {
                Project = "",
                PreviewFeature = "",
            };
            // Make the request
            PreviewFeature response = previewFeaturesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetPreviewFeatureRequest, CallSettings)
            // Additional: GetAsync(GetPreviewFeatureRequest, CancellationToken)
            // Create client
            PreviewFeaturesClient previewFeaturesClient = await PreviewFeaturesClient.CreateAsync();
            // Initialize request argument(s)
            GetPreviewFeatureRequest request = new GetPreviewFeatureRequest
            {
                Project = "",
                PreviewFeature = "",
            };
            // Make the request
            PreviewFeature response = await previewFeaturesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            PreviewFeaturesClient previewFeaturesClient = PreviewFeaturesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string previewFeature = "";
            // Make the request
            PreviewFeature response = previewFeaturesClient.Get(project, previewFeature);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            PreviewFeaturesClient previewFeaturesClient = await PreviewFeaturesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string previewFeature = "";
            // Make the request
            PreviewFeature response = await previewFeaturesClient.GetAsync(project, previewFeature);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListPreviewFeaturesRequest, CallSettings)
            // Create client
            PreviewFeaturesClient previewFeaturesClient = PreviewFeaturesClient.Create();
            // Initialize request argument(s)
            ListPreviewFeaturesRequest request = new ListPreviewFeaturesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<PreviewFeatureList, PreviewFeature> response = previewFeaturesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PreviewFeature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PreviewFeatureList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PreviewFeature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PreviewFeature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PreviewFeature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListPreviewFeaturesRequest, CallSettings)
            // Create client
            PreviewFeaturesClient previewFeaturesClient = await PreviewFeaturesClient.CreateAsync();
            // Initialize request argument(s)
            ListPreviewFeaturesRequest request = new ListPreviewFeaturesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<PreviewFeatureList, PreviewFeature> response = previewFeaturesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PreviewFeature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PreviewFeatureList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PreviewFeature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PreviewFeature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PreviewFeature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, int?, CallSettings)
            // Create client
            PreviewFeaturesClient previewFeaturesClient = PreviewFeaturesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<PreviewFeatureList, PreviewFeature> response = previewFeaturesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PreviewFeature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PreviewFeatureList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PreviewFeature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PreviewFeature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PreviewFeature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, int?, CallSettings)
            // Create client
            PreviewFeaturesClient previewFeaturesClient = await PreviewFeaturesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<PreviewFeatureList, PreviewFeature> response = previewFeaturesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PreviewFeature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PreviewFeatureList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PreviewFeature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PreviewFeature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PreviewFeature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdatePreviewFeatureRequest, CallSettings)
            // Create client
            PreviewFeaturesClient previewFeaturesClient = PreviewFeaturesClient.Create();
            // Initialize request argument(s)
            UpdatePreviewFeatureRequest request = new UpdatePreviewFeatureRequest
            {
                PreviewFeatureResource = new PreviewFeature(),
                RequestId = "",
                Project = "",
                PreviewFeature = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = previewFeaturesClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = previewFeaturesClient.PollOnceUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(UpdatePreviewFeatureRequest, CallSettings)
            // Additional: UpdateAsync(UpdatePreviewFeatureRequest, CancellationToken)
            // Create client
            PreviewFeaturesClient previewFeaturesClient = await PreviewFeaturesClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePreviewFeatureRequest request = new UpdatePreviewFeatureRequest
            {
                PreviewFeatureResource = new PreviewFeature(),
                RequestId = "",
                Project = "",
                PreviewFeature = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await previewFeaturesClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await previewFeaturesClient.PollOnceUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void Update()
        {
            // Snippet: Update(string, string, PreviewFeature, CallSettings)
            // Create client
            PreviewFeaturesClient previewFeaturesClient = PreviewFeaturesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string previewFeature = "";
            PreviewFeature previewFeatureResource = new PreviewFeature();
            // Make the request
            lro::Operation<Operation, Operation> response = previewFeaturesClient.Update(project, previewFeature, previewFeatureResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = previewFeaturesClient.PollOnceUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateAsync()
        {
            // Snippet: UpdateAsync(string, string, PreviewFeature, CallSettings)
            // Additional: UpdateAsync(string, string, PreviewFeature, CancellationToken)
            // Create client
            PreviewFeaturesClient previewFeaturesClient = await PreviewFeaturesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string previewFeature = "";
            PreviewFeature previewFeatureResource = new PreviewFeature();
            // Make the request
            lro::Operation<Operation, Operation> response = await previewFeaturesClient.UpdateAsync(project, previewFeature, previewFeatureResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await previewFeaturesClient.PollOnceUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
