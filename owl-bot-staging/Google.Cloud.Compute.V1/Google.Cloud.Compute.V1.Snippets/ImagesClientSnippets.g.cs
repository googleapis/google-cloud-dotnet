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
    public sealed class AllGeneratedImagesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            DeleteImageRequest request = new DeleteImageRequest
            {
                RequestId = "",
                Image = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = imagesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = imagesClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteImageRequest, CallSettings)
            // Additional: DeleteAsync(DeleteImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteImageRequest request = new DeleteImageRequest
            {
                RequestId = "",
                Image = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await imagesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await imagesClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            // Make the request
            lro::Operation<Operation, Operation> response = imagesClient.Delete(project, image);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = imagesClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await imagesClient.DeleteAsync(project, image);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await imagesClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Deprecate</summary>
        public void DeprecateRequestObject()
        {
            // Snippet: Deprecate(DeprecateImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            DeprecateImageRequest request = new DeprecateImageRequest
            {
                RequestId = "",
                Image = "",
                Project = "",
                DeprecationStatusResource = new DeprecationStatus(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = imagesClient.Deprecate(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = imagesClient.PollOnceDeprecate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeprecateAsync</summary>
        public async Task DeprecateRequestObjectAsync()
        {
            // Snippet: DeprecateAsync(DeprecateImageRequest, CallSettings)
            // Additional: DeprecateAsync(DeprecateImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            DeprecateImageRequest request = new DeprecateImageRequest
            {
                RequestId = "",
                Image = "",
                Project = "",
                DeprecationStatusResource = new DeprecationStatus(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await imagesClient.DeprecateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await imagesClient.PollOnceDeprecateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Deprecate</summary>
        public void Deprecate()
        {
            // Snippet: Deprecate(string, string, DeprecationStatus, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            DeprecationStatus deprecationStatusResource = new DeprecationStatus();
            // Make the request
            lro::Operation<Operation, Operation> response = imagesClient.Deprecate(project, image, deprecationStatusResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = imagesClient.PollOnceDeprecate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeprecateAsync</summary>
        public async Task DeprecateAsync()
        {
            // Snippet: DeprecateAsync(string, string, DeprecationStatus, CallSettings)
            // Additional: DeprecateAsync(string, string, DeprecationStatus, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            DeprecationStatus deprecationStatusResource = new DeprecationStatus();
            // Make the request
            lro::Operation<Operation, Operation> response = await imagesClient.DeprecateAsync(project, image, deprecationStatusResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await imagesClient.PollOnceDeprecateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            GetImageRequest request = new GetImageRequest
            {
                Image = "",
                Project = "",
            };
            // Make the request
            Image response = imagesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetImageRequest, CallSettings)
            // Additional: GetAsync(GetImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            GetImageRequest request = new GetImageRequest
            {
                Image = "",
                Project = "",
            };
            // Make the request
            Image response = await imagesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            // Make the request
            Image response = imagesClient.Get(project, image);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            // Make the request
            Image response = await imagesClient.GetAsync(project, image);
            // End snippet
        }

        /// <summary>Snippet for GetFromFamily</summary>
        public void GetFromFamilyRequestObject()
        {
            // Snippet: GetFromFamily(GetFromFamilyImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            GetFromFamilyImageRequest request = new GetFromFamilyImageRequest
            {
                Project = "",
                Family = "",
            };
            // Make the request
            Image response = imagesClient.GetFromFamily(request);
            // End snippet
        }

        /// <summary>Snippet for GetFromFamilyAsync</summary>
        public async Task GetFromFamilyRequestObjectAsync()
        {
            // Snippet: GetFromFamilyAsync(GetFromFamilyImageRequest, CallSettings)
            // Additional: GetFromFamilyAsync(GetFromFamilyImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            GetFromFamilyImageRequest request = new GetFromFamilyImageRequest
            {
                Project = "",
                Family = "",
            };
            // Make the request
            Image response = await imagesClient.GetFromFamilyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFromFamily</summary>
        public void GetFromFamily()
        {
            // Snippet: GetFromFamily(string, string, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string family = "";
            // Make the request
            Image response = imagesClient.GetFromFamily(project, family);
            // End snippet
        }

        /// <summary>Snippet for GetFromFamilyAsync</summary>
        public async Task GetFromFamilyAsync()
        {
            // Snippet: GetFromFamilyAsync(string, string, CallSettings)
            // Additional: GetFromFamilyAsync(string, string, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string family = "";
            // Make the request
            Image response = await imagesClient.GetFromFamilyAsync(project, family);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            GetIamPolicyImageRequest request = new GetIamPolicyImageRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = imagesClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyImageRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyImageRequest request = new GetIamPolicyImageRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await imagesClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = imagesClient.GetIamPolicy(project, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = await imagesClient.GetIamPolicyAsync(project, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            InsertImageRequest request = new InsertImageRequest
            {
                RequestId = "",
                ForceCreate = false,
                Project = "",
                ImageResource = new Image(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = imagesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = imagesClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertImageRequest, CallSettings)
            // Additional: InsertAsync(InsertImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            InsertImageRequest request = new InsertImageRequest
            {
                RequestId = "",
                ForceCreate = false,
                Project = "",
                ImageResource = new Image(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await imagesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await imagesClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, Image, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            Image imageResource = new Image();
            // Make the request
            lro::Operation<Operation, Operation> response = imagesClient.Insert(project, imageResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = imagesClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, Image, CallSettings)
            // Additional: InsertAsync(string, Image, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            Image imageResource = new Image();
            // Make the request
            lro::Operation<Operation, Operation> response = await imagesClient.InsertAsync(project, imageResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await imagesClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListImagesRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            ListImagesRequest request = new ListImagesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ImageList, Image> response = imagesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Image item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ImageList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Image item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Image> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Image item in singlePage)
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
            // Snippet: ListAsync(ListImagesRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            ListImagesRequest request = new ListImagesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ImageList, Image> response = imagesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Image item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ImageList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Image item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Image> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Image item in singlePage)
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
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<ImageList, Image> response = imagesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Image item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ImageList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Image item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Image> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Image item in singlePage)
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
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<ImageList, Image> response = imagesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Image item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ImageList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Image item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Image> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Image item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            PatchImageRequest request = new PatchImageRequest
            {
                RequestId = "",
                Image = "",
                Project = "",
                ImageResource = new Image(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = imagesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = imagesClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchImageRequest, CallSettings)
            // Additional: PatchAsync(PatchImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            PatchImageRequest request = new PatchImageRequest
            {
                RequestId = "",
                Image = "",
                Project = "",
                ImageResource = new Image(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await imagesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await imagesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, Image, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            Image imageResource = new Image();
            // Make the request
            lro::Operation<Operation, Operation> response = imagesClient.Patch(project, image, imageResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = imagesClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, Image, CallSettings)
            // Additional: PatchAsync(string, string, Image, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            Image imageResource = new Image();
            // Make the request
            lro::Operation<Operation, Operation> response = await imagesClient.PatchAsync(project, image, imageResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await imagesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            SetIamPolicyImageRequest request = new SetIamPolicyImageRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = imagesClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyImageRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyImageRequest request = new SetIamPolicyImageRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = await imagesClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, GlobalSetPolicyRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = imagesClient.SetIamPolicy(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = await imagesClient.SetIamPolicyAsync(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            SetLabelsImageRequest request = new SetLabelsImageRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = imagesClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = imagesClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsImageRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsImageRequest request = new SetLabelsImageRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await imagesClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await imagesClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, GlobalSetLabelsRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = imagesClient.SetLabels(project, resource, globalSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = imagesClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await imagesClient.SetLabelsAsync(project, resource, globalSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await imagesClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsImageRequest request = new TestIamPermissionsImageRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = imagesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsImageRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsImageRequest request = new TestIamPermissionsImageRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await imagesClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, TestPermissionsRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = imagesClient.TestIamPermissions(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await imagesClient.TestIamPermissionsAsync(project, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
