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
    public sealed class AllGeneratedMachineImagesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteMachineImageRequest, CallSettings)
            // Create client
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            DeleteMachineImageRequest request = new DeleteMachineImageRequest
            {
                RequestId = "",
                MachineImage = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = machineImagesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = machineImagesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteMachineImageRequest, CallSettings)
            // Additional: DeleteAsync(DeleteMachineImageRequest, CancellationToken)
            // Create client
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMachineImageRequest request = new DeleteMachineImageRequest
            {
                RequestId = "",
                MachineImage = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await machineImagesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await machineImagesClient.PollOnceDeleteAsync(operationName);
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
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string machineImage = "";
            // Make the request
            lro::Operation<Operation, Operation> response = machineImagesClient.Delete(project, machineImage);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = machineImagesClient.PollOnceDelete(operationName);
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
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string machineImage = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await machineImagesClient.DeleteAsync(project, machineImage);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await machineImagesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetMachineImageRequest, CallSettings)
            // Create client
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            GetMachineImageRequest request = new GetMachineImageRequest
            {
                MachineImage = "",
                Project = "",
            };
            // Make the request
            MachineImage response = machineImagesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetMachineImageRequest, CallSettings)
            // Additional: GetAsync(GetMachineImageRequest, CancellationToken)
            // Create client
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            GetMachineImageRequest request = new GetMachineImageRequest
            {
                MachineImage = "",
                Project = "",
            };
            // Make the request
            MachineImage response = await machineImagesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string machineImage = "";
            // Make the request
            MachineImage response = machineImagesClient.Get(project, machineImage);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string machineImage = "";
            // Make the request
            MachineImage response = await machineImagesClient.GetAsync(project, machineImage);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyMachineImageRequest, CallSettings)
            // Create client
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            GetIamPolicyMachineImageRequest request = new GetIamPolicyMachineImageRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = machineImagesClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyMachineImageRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyMachineImageRequest, CancellationToken)
            // Create client
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyMachineImageRequest request = new GetIamPolicyMachineImageRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await machineImagesClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, CallSettings)
            // Create client
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = machineImagesClient.GetIamPolicy(project, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, CancellationToken)
            // Create client
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = await machineImagesClient.GetIamPolicyAsync(project, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertMachineImageRequest, CallSettings)
            // Create client
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            InsertMachineImageRequest request = new InsertMachineImageRequest
            {
                RequestId = "",
                MachineImageResource = new MachineImage(),
                Project = "",
                SourceInstance = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = machineImagesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = machineImagesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertMachineImageRequest, CallSettings)
            // Additional: InsertAsync(InsertMachineImageRequest, CancellationToken)
            // Create client
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            InsertMachineImageRequest request = new InsertMachineImageRequest
            {
                RequestId = "",
                MachineImageResource = new MachineImage(),
                Project = "",
                SourceInstance = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await machineImagesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await machineImagesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, MachineImage, CallSettings)
            // Create client
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            MachineImage machineImageResource = new MachineImage();
            // Make the request
            lro::Operation<Operation, Operation> response = machineImagesClient.Insert(project, machineImageResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = machineImagesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, MachineImage, CallSettings)
            // Additional: InsertAsync(string, MachineImage, CancellationToken)
            // Create client
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            MachineImage machineImageResource = new MachineImage();
            // Make the request
            lro::Operation<Operation, Operation> response = await machineImagesClient.InsertAsync(project, machineImageResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await machineImagesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListMachineImagesRequest, CallSettings)
            // Create client
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            ListMachineImagesRequest request = new ListMachineImagesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<MachineImageList, MachineImage> response = machineImagesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MachineImage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (MachineImageList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MachineImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MachineImage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MachineImage item in singlePage)
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
            // Snippet: ListAsync(ListMachineImagesRequest, CallSettings)
            // Create client
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            ListMachineImagesRequest request = new ListMachineImagesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<MachineImageList, MachineImage> response = machineImagesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MachineImage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((MachineImageList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MachineImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MachineImage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MachineImage item in singlePage)
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
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<MachineImageList, MachineImage> response = machineImagesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MachineImage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (MachineImageList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MachineImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MachineImage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MachineImage item in singlePage)
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
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<MachineImageList, MachineImage> response = machineImagesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MachineImage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((MachineImageList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MachineImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MachineImage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MachineImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyMachineImageRequest, CallSettings)
            // Create client
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            SetIamPolicyMachineImageRequest request = new SetIamPolicyMachineImageRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = machineImagesClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyMachineImageRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyMachineImageRequest, CancellationToken)
            // Create client
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyMachineImageRequest request = new SetIamPolicyMachineImageRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = await machineImagesClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, GlobalSetPolicyRequest, CallSettings)
            // Create client
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = machineImagesClient.SetIamPolicy(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CancellationToken)
            // Create client
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = await machineImagesClient.SetIamPolicyAsync(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsMachineImageRequest, CallSettings)
            // Create client
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            SetLabelsMachineImageRequest request = new SetLabelsMachineImageRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = machineImagesClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = machineImagesClient.PollOnceSetLabels(operationName);
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
            // Snippet: SetLabelsAsync(SetLabelsMachineImageRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsMachineImageRequest, CancellationToken)
            // Create client
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsMachineImageRequest request = new SetLabelsMachineImageRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await machineImagesClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await machineImagesClient.PollOnceSetLabelsAsync(operationName);
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
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = machineImagesClient.SetLabels(project, resource, globalSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = machineImagesClient.PollOnceSetLabels(operationName);
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
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await machineImagesClient.SetLabelsAsync(project, resource, globalSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await machineImagesClient.PollOnceSetLabelsAsync(operationName);
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
            // Snippet: TestIamPermissions(TestIamPermissionsMachineImageRequest, CallSettings)
            // Create client
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsMachineImageRequest request = new TestIamPermissionsMachineImageRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = machineImagesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsMachineImageRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsMachineImageRequest, CancellationToken)
            // Create client
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsMachineImageRequest request = new TestIamPermissionsMachineImageRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await machineImagesClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, TestPermissionsRequest, CallSettings)
            // Create client
            MachineImagesClient machineImagesClient = MachineImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = machineImagesClient.TestIamPermissions(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            MachineImagesClient machineImagesClient = await MachineImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await machineImagesClient.TestIamPermissionsAsync(project, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
