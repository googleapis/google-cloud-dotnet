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
    public sealed class AllGeneratedJobServiceClientSnippets
    {
        /// <summary>Snippet for CreateCustomJob</summary>
        public void CreateCustomJobRequestObject()
        {
            // Snippet: CreateCustomJob(CreateCustomJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CreateCustomJobRequest request = new CreateCustomJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomJob = new CustomJob(),
            };
            // Make the request
            CustomJob response = jobServiceClient.CreateCustomJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomJobAsync</summary>
        public async Task CreateCustomJobRequestObjectAsync()
        {
            // Snippet: CreateCustomJobAsync(CreateCustomJobRequest, CallSettings)
            // Additional: CreateCustomJobAsync(CreateCustomJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCustomJobRequest request = new CreateCustomJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomJob = new CustomJob(),
            };
            // Make the request
            CustomJob response = await jobServiceClient.CreateCustomJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomJob</summary>
        public void CreateCustomJob()
        {
            // Snippet: CreateCustomJob(string, CustomJob, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CustomJob customJob = new CustomJob();
            // Make the request
            CustomJob response = jobServiceClient.CreateCustomJob(parent, customJob);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomJobAsync</summary>
        public async Task CreateCustomJobAsync()
        {
            // Snippet: CreateCustomJobAsync(string, CustomJob, CallSettings)
            // Additional: CreateCustomJobAsync(string, CustomJob, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CustomJob customJob = new CustomJob();
            // Make the request
            CustomJob response = await jobServiceClient.CreateCustomJobAsync(parent, customJob);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomJob</summary>
        public void CreateCustomJobResourceNames()
        {
            // Snippet: CreateCustomJob(LocationName, CustomJob, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CustomJob customJob = new CustomJob();
            // Make the request
            CustomJob response = jobServiceClient.CreateCustomJob(parent, customJob);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomJobAsync</summary>
        public async Task CreateCustomJobResourceNamesAsync()
        {
            // Snippet: CreateCustomJobAsync(LocationName, CustomJob, CallSettings)
            // Additional: CreateCustomJobAsync(LocationName, CustomJob, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CustomJob customJob = new CustomJob();
            // Make the request
            CustomJob response = await jobServiceClient.CreateCustomJobAsync(parent, customJob);
            // End snippet
        }

        /// <summary>Snippet for GetCustomJob</summary>
        public void GetCustomJobRequestObject()
        {
            // Snippet: GetCustomJob(GetCustomJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            GetCustomJobRequest request = new GetCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            // Make the request
            CustomJob response = jobServiceClient.GetCustomJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomJobAsync</summary>
        public async Task GetCustomJobRequestObjectAsync()
        {
            // Snippet: GetCustomJobAsync(GetCustomJobRequest, CallSettings)
            // Additional: GetCustomJobAsync(GetCustomJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomJobRequest request = new GetCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            // Make the request
            CustomJob response = await jobServiceClient.GetCustomJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomJob</summary>
        public void GetCustomJob()
        {
            // Snippet: GetCustomJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customJobs/[CUSTOM_JOB]";
            // Make the request
            CustomJob response = jobServiceClient.GetCustomJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomJobAsync</summary>
        public async Task GetCustomJobAsync()
        {
            // Snippet: GetCustomJobAsync(string, CallSettings)
            // Additional: GetCustomJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customJobs/[CUSTOM_JOB]";
            // Make the request
            CustomJob response = await jobServiceClient.GetCustomJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomJob</summary>
        public void GetCustomJobResourceNames()
        {
            // Snippet: GetCustomJob(CustomJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CustomJobName name = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]");
            // Make the request
            CustomJob response = jobServiceClient.GetCustomJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomJobAsync</summary>
        public async Task GetCustomJobResourceNamesAsync()
        {
            // Snippet: GetCustomJobAsync(CustomJobName, CallSettings)
            // Additional: GetCustomJobAsync(CustomJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomJobName name = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]");
            // Make the request
            CustomJob response = await jobServiceClient.GetCustomJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCustomJobs</summary>
        public void ListCustomJobsRequestObject()
        {
            // Snippet: ListCustomJobs(ListCustomJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ListCustomJobsRequest request = new ListCustomJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListCustomJobsResponse, CustomJob> response = jobServiceClient.ListCustomJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomJobsAsync</summary>
        public async Task ListCustomJobsRequestObjectAsync()
        {
            // Snippet: ListCustomJobsAsync(ListCustomJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCustomJobsRequest request = new ListCustomJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListCustomJobsResponse, CustomJob> response = jobServiceClient.ListCustomJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomJobs</summary>
        public void ListCustomJobs()
        {
            // Snippet: ListCustomJobs(string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCustomJobsResponse, CustomJob> response = jobServiceClient.ListCustomJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomJobsAsync</summary>
        public async Task ListCustomJobsAsync()
        {
            // Snippet: ListCustomJobsAsync(string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCustomJobsResponse, CustomJob> response = jobServiceClient.ListCustomJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomJobs</summary>
        public void ListCustomJobsResourceNames()
        {
            // Snippet: ListCustomJobs(LocationName, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCustomJobsResponse, CustomJob> response = jobServiceClient.ListCustomJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomJobsAsync</summary>
        public async Task ListCustomJobsResourceNamesAsync()
        {
            // Snippet: ListCustomJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCustomJobsResponse, CustomJob> response = jobServiceClient.ListCustomJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomJob</summary>
        public void DeleteCustomJobRequestObject()
        {
            // Snippet: DeleteCustomJob(DeleteCustomJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            DeleteCustomJobRequest request = new DeleteCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteCustomJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteCustomJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomJobAsync</summary>
        public async Task DeleteCustomJobRequestObjectAsync()
        {
            // Snippet: DeleteCustomJobAsync(DeleteCustomJobRequest, CallSettings)
            // Additional: DeleteCustomJobAsync(DeleteCustomJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCustomJobRequest request = new DeleteCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteCustomJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteCustomJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomJob</summary>
        public void DeleteCustomJob()
        {
            // Snippet: DeleteCustomJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customJobs/[CUSTOM_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteCustomJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteCustomJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomJobAsync</summary>
        public async Task DeleteCustomJobAsync()
        {
            // Snippet: DeleteCustomJobAsync(string, CallSettings)
            // Additional: DeleteCustomJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customJobs/[CUSTOM_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteCustomJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteCustomJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomJob</summary>
        public void DeleteCustomJobResourceNames()
        {
            // Snippet: DeleteCustomJob(CustomJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CustomJobName name = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteCustomJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteCustomJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomJobAsync</summary>
        public async Task DeleteCustomJobResourceNamesAsync()
        {
            // Snippet: DeleteCustomJobAsync(CustomJobName, CallSettings)
            // Additional: DeleteCustomJobAsync(CustomJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomJobName name = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteCustomJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteCustomJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelCustomJob</summary>
        public void CancelCustomJobRequestObject()
        {
            // Snippet: CancelCustomJob(CancelCustomJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CancelCustomJobRequest request = new CancelCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            // Make the request
            jobServiceClient.CancelCustomJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelCustomJobAsync</summary>
        public async Task CancelCustomJobRequestObjectAsync()
        {
            // Snippet: CancelCustomJobAsync(CancelCustomJobRequest, CallSettings)
            // Additional: CancelCustomJobAsync(CancelCustomJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelCustomJobRequest request = new CancelCustomJobRequest
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
            };
            // Make the request
            await jobServiceClient.CancelCustomJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelCustomJob</summary>
        public void CancelCustomJob()
        {
            // Snippet: CancelCustomJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customJobs/[CUSTOM_JOB]";
            // Make the request
            jobServiceClient.CancelCustomJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelCustomJobAsync</summary>
        public async Task CancelCustomJobAsync()
        {
            // Snippet: CancelCustomJobAsync(string, CallSettings)
            // Additional: CancelCustomJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customJobs/[CUSTOM_JOB]";
            // Make the request
            await jobServiceClient.CancelCustomJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelCustomJob</summary>
        public void CancelCustomJobResourceNames()
        {
            // Snippet: CancelCustomJob(CustomJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CustomJobName name = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]");
            // Make the request
            jobServiceClient.CancelCustomJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelCustomJobAsync</summary>
        public async Task CancelCustomJobResourceNamesAsync()
        {
            // Snippet: CancelCustomJobAsync(CustomJobName, CallSettings)
            // Additional: CancelCustomJobAsync(CustomJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomJobName name = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]");
            // Make the request
            await jobServiceClient.CancelCustomJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDataLabelingJob</summary>
        public void CreateDataLabelingJobRequestObject()
        {
            // Snippet: CreateDataLabelingJob(CreateDataLabelingJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CreateDataLabelingJobRequest request = new CreateDataLabelingJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataLabelingJob = new DataLabelingJob(),
            };
            // Make the request
            DataLabelingJob response = jobServiceClient.CreateDataLabelingJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataLabelingJobAsync</summary>
        public async Task CreateDataLabelingJobRequestObjectAsync()
        {
            // Snippet: CreateDataLabelingJobAsync(CreateDataLabelingJobRequest, CallSettings)
            // Additional: CreateDataLabelingJobAsync(CreateDataLabelingJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataLabelingJobRequest request = new CreateDataLabelingJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataLabelingJob = new DataLabelingJob(),
            };
            // Make the request
            DataLabelingJob response = await jobServiceClient.CreateDataLabelingJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataLabelingJob</summary>
        public void CreateDataLabelingJob()
        {
            // Snippet: CreateDataLabelingJob(string, DataLabelingJob, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DataLabelingJob dataLabelingJob = new DataLabelingJob();
            // Make the request
            DataLabelingJob response = jobServiceClient.CreateDataLabelingJob(parent, dataLabelingJob);
            // End snippet
        }

        /// <summary>Snippet for CreateDataLabelingJobAsync</summary>
        public async Task CreateDataLabelingJobAsync()
        {
            // Snippet: CreateDataLabelingJobAsync(string, DataLabelingJob, CallSettings)
            // Additional: CreateDataLabelingJobAsync(string, DataLabelingJob, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DataLabelingJob dataLabelingJob = new DataLabelingJob();
            // Make the request
            DataLabelingJob response = await jobServiceClient.CreateDataLabelingJobAsync(parent, dataLabelingJob);
            // End snippet
        }

        /// <summary>Snippet for CreateDataLabelingJob</summary>
        public void CreateDataLabelingJobResourceNames()
        {
            // Snippet: CreateDataLabelingJob(LocationName, DataLabelingJob, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DataLabelingJob dataLabelingJob = new DataLabelingJob();
            // Make the request
            DataLabelingJob response = jobServiceClient.CreateDataLabelingJob(parent, dataLabelingJob);
            // End snippet
        }

        /// <summary>Snippet for CreateDataLabelingJobAsync</summary>
        public async Task CreateDataLabelingJobResourceNamesAsync()
        {
            // Snippet: CreateDataLabelingJobAsync(LocationName, DataLabelingJob, CallSettings)
            // Additional: CreateDataLabelingJobAsync(LocationName, DataLabelingJob, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DataLabelingJob dataLabelingJob = new DataLabelingJob();
            // Make the request
            DataLabelingJob response = await jobServiceClient.CreateDataLabelingJobAsync(parent, dataLabelingJob);
            // End snippet
        }

        /// <summary>Snippet for GetDataLabelingJob</summary>
        public void GetDataLabelingJobRequestObject()
        {
            // Snippet: GetDataLabelingJob(GetDataLabelingJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            GetDataLabelingJobRequest request = new GetDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            // Make the request
            DataLabelingJob response = jobServiceClient.GetDataLabelingJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataLabelingJobAsync</summary>
        public async Task GetDataLabelingJobRequestObjectAsync()
        {
            // Snippet: GetDataLabelingJobAsync(GetDataLabelingJobRequest, CallSettings)
            // Additional: GetDataLabelingJobAsync(GetDataLabelingJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataLabelingJobRequest request = new GetDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            // Make the request
            DataLabelingJob response = await jobServiceClient.GetDataLabelingJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataLabelingJob</summary>
        public void GetDataLabelingJob()
        {
            // Snippet: GetDataLabelingJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataLabelingJobs/[DATA_LABELING_JOB]";
            // Make the request
            DataLabelingJob response = jobServiceClient.GetDataLabelingJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataLabelingJobAsync</summary>
        public async Task GetDataLabelingJobAsync()
        {
            // Snippet: GetDataLabelingJobAsync(string, CallSettings)
            // Additional: GetDataLabelingJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataLabelingJobs/[DATA_LABELING_JOB]";
            // Make the request
            DataLabelingJob response = await jobServiceClient.GetDataLabelingJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataLabelingJob</summary>
        public void GetDataLabelingJobResourceNames()
        {
            // Snippet: GetDataLabelingJob(DataLabelingJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            DataLabelingJobName name = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]");
            // Make the request
            DataLabelingJob response = jobServiceClient.GetDataLabelingJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataLabelingJobAsync</summary>
        public async Task GetDataLabelingJobResourceNamesAsync()
        {
            // Snippet: GetDataLabelingJobAsync(DataLabelingJobName, CallSettings)
            // Additional: GetDataLabelingJobAsync(DataLabelingJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataLabelingJobName name = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]");
            // Make the request
            DataLabelingJob response = await jobServiceClient.GetDataLabelingJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDataLabelingJobs</summary>
        public void ListDataLabelingJobsRequestObject()
        {
            // Snippet: ListDataLabelingJobs(ListDataLabelingJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ListDataLabelingJobsRequest request = new ListDataLabelingJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDataLabelingJobsResponse, DataLabelingJob> response = jobServiceClient.ListDataLabelingJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataLabelingJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataLabelingJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataLabelingJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataLabelingJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataLabelingJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataLabelingJobsAsync</summary>
        public async Task ListDataLabelingJobsRequestObjectAsync()
        {
            // Snippet: ListDataLabelingJobsAsync(ListDataLabelingJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataLabelingJobsRequest request = new ListDataLabelingJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDataLabelingJobsResponse, DataLabelingJob> response = jobServiceClient.ListDataLabelingJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataLabelingJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataLabelingJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataLabelingJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataLabelingJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataLabelingJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataLabelingJobs</summary>
        public void ListDataLabelingJobs()
        {
            // Snippet: ListDataLabelingJobs(string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDataLabelingJobsResponse, DataLabelingJob> response = jobServiceClient.ListDataLabelingJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataLabelingJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataLabelingJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataLabelingJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataLabelingJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataLabelingJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataLabelingJobsAsync</summary>
        public async Task ListDataLabelingJobsAsync()
        {
            // Snippet: ListDataLabelingJobsAsync(string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDataLabelingJobsResponse, DataLabelingJob> response = jobServiceClient.ListDataLabelingJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataLabelingJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataLabelingJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataLabelingJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataLabelingJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataLabelingJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataLabelingJobs</summary>
        public void ListDataLabelingJobsResourceNames()
        {
            // Snippet: ListDataLabelingJobs(LocationName, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDataLabelingJobsResponse, DataLabelingJob> response = jobServiceClient.ListDataLabelingJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataLabelingJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataLabelingJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataLabelingJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataLabelingJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataLabelingJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataLabelingJobsAsync</summary>
        public async Task ListDataLabelingJobsResourceNamesAsync()
        {
            // Snippet: ListDataLabelingJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDataLabelingJobsResponse, DataLabelingJob> response = jobServiceClient.ListDataLabelingJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataLabelingJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataLabelingJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataLabelingJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataLabelingJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataLabelingJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteDataLabelingJob</summary>
        public void DeleteDataLabelingJobRequestObject()
        {
            // Snippet: DeleteDataLabelingJob(DeleteDataLabelingJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            DeleteDataLabelingJobRequest request = new DeleteDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteDataLabelingJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteDataLabelingJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataLabelingJobAsync</summary>
        public async Task DeleteDataLabelingJobRequestObjectAsync()
        {
            // Snippet: DeleteDataLabelingJobAsync(DeleteDataLabelingJobRequest, CallSettings)
            // Additional: DeleteDataLabelingJobAsync(DeleteDataLabelingJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDataLabelingJobRequest request = new DeleteDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteDataLabelingJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteDataLabelingJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataLabelingJob</summary>
        public void DeleteDataLabelingJob()
        {
            // Snippet: DeleteDataLabelingJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataLabelingJobs/[DATA_LABELING_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteDataLabelingJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteDataLabelingJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataLabelingJobAsync</summary>
        public async Task DeleteDataLabelingJobAsync()
        {
            // Snippet: DeleteDataLabelingJobAsync(string, CallSettings)
            // Additional: DeleteDataLabelingJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataLabelingJobs/[DATA_LABELING_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteDataLabelingJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteDataLabelingJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataLabelingJob</summary>
        public void DeleteDataLabelingJobResourceNames()
        {
            // Snippet: DeleteDataLabelingJob(DataLabelingJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            DataLabelingJobName name = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteDataLabelingJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteDataLabelingJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataLabelingJobAsync</summary>
        public async Task DeleteDataLabelingJobResourceNamesAsync()
        {
            // Snippet: DeleteDataLabelingJobAsync(DataLabelingJobName, CallSettings)
            // Additional: DeleteDataLabelingJobAsync(DataLabelingJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataLabelingJobName name = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteDataLabelingJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteDataLabelingJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelDataLabelingJob</summary>
        public void CancelDataLabelingJobRequestObject()
        {
            // Snippet: CancelDataLabelingJob(CancelDataLabelingJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CancelDataLabelingJobRequest request = new CancelDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            // Make the request
            jobServiceClient.CancelDataLabelingJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelDataLabelingJobAsync</summary>
        public async Task CancelDataLabelingJobRequestObjectAsync()
        {
            // Snippet: CancelDataLabelingJobAsync(CancelDataLabelingJobRequest, CallSettings)
            // Additional: CancelDataLabelingJobAsync(CancelDataLabelingJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelDataLabelingJobRequest request = new CancelDataLabelingJobRequest
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
            };
            // Make the request
            await jobServiceClient.CancelDataLabelingJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelDataLabelingJob</summary>
        public void CancelDataLabelingJob()
        {
            // Snippet: CancelDataLabelingJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataLabelingJobs/[DATA_LABELING_JOB]";
            // Make the request
            jobServiceClient.CancelDataLabelingJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelDataLabelingJobAsync</summary>
        public async Task CancelDataLabelingJobAsync()
        {
            // Snippet: CancelDataLabelingJobAsync(string, CallSettings)
            // Additional: CancelDataLabelingJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataLabelingJobs/[DATA_LABELING_JOB]";
            // Make the request
            await jobServiceClient.CancelDataLabelingJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelDataLabelingJob</summary>
        public void CancelDataLabelingJobResourceNames()
        {
            // Snippet: CancelDataLabelingJob(DataLabelingJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            DataLabelingJobName name = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]");
            // Make the request
            jobServiceClient.CancelDataLabelingJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelDataLabelingJobAsync</summary>
        public async Task CancelDataLabelingJobResourceNamesAsync()
        {
            // Snippet: CancelDataLabelingJobAsync(DataLabelingJobName, CallSettings)
            // Additional: CancelDataLabelingJobAsync(DataLabelingJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataLabelingJobName name = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]");
            // Make the request
            await jobServiceClient.CancelDataLabelingJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateHyperparameterTuningJob</summary>
        public void CreateHyperparameterTuningJobRequestObject()
        {
            // Snippet: CreateHyperparameterTuningJob(CreateHyperparameterTuningJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CreateHyperparameterTuningJobRequest request = new CreateHyperparameterTuningJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HyperparameterTuningJob = new HyperparameterTuningJob(),
            };
            // Make the request
            HyperparameterTuningJob response = jobServiceClient.CreateHyperparameterTuningJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateHyperparameterTuningJobAsync</summary>
        public async Task CreateHyperparameterTuningJobRequestObjectAsync()
        {
            // Snippet: CreateHyperparameterTuningJobAsync(CreateHyperparameterTuningJobRequest, CallSettings)
            // Additional: CreateHyperparameterTuningJobAsync(CreateHyperparameterTuningJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateHyperparameterTuningJobRequest request = new CreateHyperparameterTuningJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HyperparameterTuningJob = new HyperparameterTuningJob(),
            };
            // Make the request
            HyperparameterTuningJob response = await jobServiceClient.CreateHyperparameterTuningJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateHyperparameterTuningJob</summary>
        public void CreateHyperparameterTuningJob()
        {
            // Snippet: CreateHyperparameterTuningJob(string, HyperparameterTuningJob, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            HyperparameterTuningJob hyperparameterTuningJob = new HyperparameterTuningJob();
            // Make the request
            HyperparameterTuningJob response = jobServiceClient.CreateHyperparameterTuningJob(parent, hyperparameterTuningJob);
            // End snippet
        }

        /// <summary>Snippet for CreateHyperparameterTuningJobAsync</summary>
        public async Task CreateHyperparameterTuningJobAsync()
        {
            // Snippet: CreateHyperparameterTuningJobAsync(string, HyperparameterTuningJob, CallSettings)
            // Additional: CreateHyperparameterTuningJobAsync(string, HyperparameterTuningJob, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            HyperparameterTuningJob hyperparameterTuningJob = new HyperparameterTuningJob();
            // Make the request
            HyperparameterTuningJob response = await jobServiceClient.CreateHyperparameterTuningJobAsync(parent, hyperparameterTuningJob);
            // End snippet
        }

        /// <summary>Snippet for CreateHyperparameterTuningJob</summary>
        public void CreateHyperparameterTuningJobResourceNames()
        {
            // Snippet: CreateHyperparameterTuningJob(LocationName, HyperparameterTuningJob, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            HyperparameterTuningJob hyperparameterTuningJob = new HyperparameterTuningJob();
            // Make the request
            HyperparameterTuningJob response = jobServiceClient.CreateHyperparameterTuningJob(parent, hyperparameterTuningJob);
            // End snippet
        }

        /// <summary>Snippet for CreateHyperparameterTuningJobAsync</summary>
        public async Task CreateHyperparameterTuningJobResourceNamesAsync()
        {
            // Snippet: CreateHyperparameterTuningJobAsync(LocationName, HyperparameterTuningJob, CallSettings)
            // Additional: CreateHyperparameterTuningJobAsync(LocationName, HyperparameterTuningJob, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            HyperparameterTuningJob hyperparameterTuningJob = new HyperparameterTuningJob();
            // Make the request
            HyperparameterTuningJob response = await jobServiceClient.CreateHyperparameterTuningJobAsync(parent, hyperparameterTuningJob);
            // End snippet
        }

        /// <summary>Snippet for GetHyperparameterTuningJob</summary>
        public void GetHyperparameterTuningJobRequestObject()
        {
            // Snippet: GetHyperparameterTuningJob(GetHyperparameterTuningJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            GetHyperparameterTuningJobRequest request = new GetHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            // Make the request
            HyperparameterTuningJob response = jobServiceClient.GetHyperparameterTuningJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetHyperparameterTuningJobAsync</summary>
        public async Task GetHyperparameterTuningJobRequestObjectAsync()
        {
            // Snippet: GetHyperparameterTuningJobAsync(GetHyperparameterTuningJobRequest, CallSettings)
            // Additional: GetHyperparameterTuningJobAsync(GetHyperparameterTuningJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetHyperparameterTuningJobRequest request = new GetHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            // Make the request
            HyperparameterTuningJob response = await jobServiceClient.GetHyperparameterTuningJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHyperparameterTuningJob</summary>
        public void GetHyperparameterTuningJob()
        {
            // Snippet: GetHyperparameterTuningJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/hyperparameterTuningJobs/[HYPERPARAMETER_TUNING_JOB]";
            // Make the request
            HyperparameterTuningJob response = jobServiceClient.GetHyperparameterTuningJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetHyperparameterTuningJobAsync</summary>
        public async Task GetHyperparameterTuningJobAsync()
        {
            // Snippet: GetHyperparameterTuningJobAsync(string, CallSettings)
            // Additional: GetHyperparameterTuningJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/hyperparameterTuningJobs/[HYPERPARAMETER_TUNING_JOB]";
            // Make the request
            HyperparameterTuningJob response = await jobServiceClient.GetHyperparameterTuningJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetHyperparameterTuningJob</summary>
        public void GetHyperparameterTuningJobResourceNames()
        {
            // Snippet: GetHyperparameterTuningJob(HyperparameterTuningJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            HyperparameterTuningJobName name = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]");
            // Make the request
            HyperparameterTuningJob response = jobServiceClient.GetHyperparameterTuningJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetHyperparameterTuningJobAsync</summary>
        public async Task GetHyperparameterTuningJobResourceNamesAsync()
        {
            // Snippet: GetHyperparameterTuningJobAsync(HyperparameterTuningJobName, CallSettings)
            // Additional: GetHyperparameterTuningJobAsync(HyperparameterTuningJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            HyperparameterTuningJobName name = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]");
            // Make the request
            HyperparameterTuningJob response = await jobServiceClient.GetHyperparameterTuningJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListHyperparameterTuningJobs</summary>
        public void ListHyperparameterTuningJobsRequestObject()
        {
            // Snippet: ListHyperparameterTuningJobs(ListHyperparameterTuningJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ListHyperparameterTuningJobsRequest request = new ListHyperparameterTuningJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListHyperparameterTuningJobsResponse, HyperparameterTuningJob> response = jobServiceClient.ListHyperparameterTuningJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HyperparameterTuningJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHyperparameterTuningJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HyperparameterTuningJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HyperparameterTuningJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HyperparameterTuningJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHyperparameterTuningJobsAsync</summary>
        public async Task ListHyperparameterTuningJobsRequestObjectAsync()
        {
            // Snippet: ListHyperparameterTuningJobsAsync(ListHyperparameterTuningJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListHyperparameterTuningJobsRequest request = new ListHyperparameterTuningJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListHyperparameterTuningJobsResponse, HyperparameterTuningJob> response = jobServiceClient.ListHyperparameterTuningJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HyperparameterTuningJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHyperparameterTuningJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HyperparameterTuningJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HyperparameterTuningJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HyperparameterTuningJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHyperparameterTuningJobs</summary>
        public void ListHyperparameterTuningJobs()
        {
            // Snippet: ListHyperparameterTuningJobs(string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListHyperparameterTuningJobsResponse, HyperparameterTuningJob> response = jobServiceClient.ListHyperparameterTuningJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HyperparameterTuningJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHyperparameterTuningJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HyperparameterTuningJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HyperparameterTuningJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HyperparameterTuningJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHyperparameterTuningJobsAsync</summary>
        public async Task ListHyperparameterTuningJobsAsync()
        {
            // Snippet: ListHyperparameterTuningJobsAsync(string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListHyperparameterTuningJobsResponse, HyperparameterTuningJob> response = jobServiceClient.ListHyperparameterTuningJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HyperparameterTuningJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHyperparameterTuningJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HyperparameterTuningJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HyperparameterTuningJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HyperparameterTuningJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHyperparameterTuningJobs</summary>
        public void ListHyperparameterTuningJobsResourceNames()
        {
            // Snippet: ListHyperparameterTuningJobs(LocationName, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListHyperparameterTuningJobsResponse, HyperparameterTuningJob> response = jobServiceClient.ListHyperparameterTuningJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HyperparameterTuningJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHyperparameterTuningJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HyperparameterTuningJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HyperparameterTuningJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HyperparameterTuningJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHyperparameterTuningJobsAsync</summary>
        public async Task ListHyperparameterTuningJobsResourceNamesAsync()
        {
            // Snippet: ListHyperparameterTuningJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListHyperparameterTuningJobsResponse, HyperparameterTuningJob> response = jobServiceClient.ListHyperparameterTuningJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HyperparameterTuningJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHyperparameterTuningJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HyperparameterTuningJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HyperparameterTuningJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HyperparameterTuningJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteHyperparameterTuningJob</summary>
        public void DeleteHyperparameterTuningJobRequestObject()
        {
            // Snippet: DeleteHyperparameterTuningJob(DeleteHyperparameterTuningJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            DeleteHyperparameterTuningJobRequest request = new DeleteHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteHyperparameterTuningJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteHyperparameterTuningJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHyperparameterTuningJobAsync</summary>
        public async Task DeleteHyperparameterTuningJobRequestObjectAsync()
        {
            // Snippet: DeleteHyperparameterTuningJobAsync(DeleteHyperparameterTuningJobRequest, CallSettings)
            // Additional: DeleteHyperparameterTuningJobAsync(DeleteHyperparameterTuningJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteHyperparameterTuningJobRequest request = new DeleteHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteHyperparameterTuningJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteHyperparameterTuningJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHyperparameterTuningJob</summary>
        public void DeleteHyperparameterTuningJob()
        {
            // Snippet: DeleteHyperparameterTuningJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/hyperparameterTuningJobs/[HYPERPARAMETER_TUNING_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteHyperparameterTuningJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteHyperparameterTuningJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHyperparameterTuningJobAsync</summary>
        public async Task DeleteHyperparameterTuningJobAsync()
        {
            // Snippet: DeleteHyperparameterTuningJobAsync(string, CallSettings)
            // Additional: DeleteHyperparameterTuningJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/hyperparameterTuningJobs/[HYPERPARAMETER_TUNING_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteHyperparameterTuningJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteHyperparameterTuningJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHyperparameterTuningJob</summary>
        public void DeleteHyperparameterTuningJobResourceNames()
        {
            // Snippet: DeleteHyperparameterTuningJob(HyperparameterTuningJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            HyperparameterTuningJobName name = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteHyperparameterTuningJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteHyperparameterTuningJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHyperparameterTuningJobAsync</summary>
        public async Task DeleteHyperparameterTuningJobResourceNamesAsync()
        {
            // Snippet: DeleteHyperparameterTuningJobAsync(HyperparameterTuningJobName, CallSettings)
            // Additional: DeleteHyperparameterTuningJobAsync(HyperparameterTuningJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            HyperparameterTuningJobName name = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteHyperparameterTuningJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteHyperparameterTuningJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelHyperparameterTuningJob</summary>
        public void CancelHyperparameterTuningJobRequestObject()
        {
            // Snippet: CancelHyperparameterTuningJob(CancelHyperparameterTuningJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CancelHyperparameterTuningJobRequest request = new CancelHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            // Make the request
            jobServiceClient.CancelHyperparameterTuningJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelHyperparameterTuningJobAsync</summary>
        public async Task CancelHyperparameterTuningJobRequestObjectAsync()
        {
            // Snippet: CancelHyperparameterTuningJobAsync(CancelHyperparameterTuningJobRequest, CallSettings)
            // Additional: CancelHyperparameterTuningJobAsync(CancelHyperparameterTuningJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelHyperparameterTuningJobRequest request = new CancelHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
            };
            // Make the request
            await jobServiceClient.CancelHyperparameterTuningJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelHyperparameterTuningJob</summary>
        public void CancelHyperparameterTuningJob()
        {
            // Snippet: CancelHyperparameterTuningJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/hyperparameterTuningJobs/[HYPERPARAMETER_TUNING_JOB]";
            // Make the request
            jobServiceClient.CancelHyperparameterTuningJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelHyperparameterTuningJobAsync</summary>
        public async Task CancelHyperparameterTuningJobAsync()
        {
            // Snippet: CancelHyperparameterTuningJobAsync(string, CallSettings)
            // Additional: CancelHyperparameterTuningJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/hyperparameterTuningJobs/[HYPERPARAMETER_TUNING_JOB]";
            // Make the request
            await jobServiceClient.CancelHyperparameterTuningJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelHyperparameterTuningJob</summary>
        public void CancelHyperparameterTuningJobResourceNames()
        {
            // Snippet: CancelHyperparameterTuningJob(HyperparameterTuningJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            HyperparameterTuningJobName name = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]");
            // Make the request
            jobServiceClient.CancelHyperparameterTuningJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelHyperparameterTuningJobAsync</summary>
        public async Task CancelHyperparameterTuningJobResourceNamesAsync()
        {
            // Snippet: CancelHyperparameterTuningJobAsync(HyperparameterTuningJobName, CallSettings)
            // Additional: CancelHyperparameterTuningJobAsync(HyperparameterTuningJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            HyperparameterTuningJobName name = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]");
            // Make the request
            await jobServiceClient.CancelHyperparameterTuningJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateNasJob</summary>
        public void CreateNasJobRequestObject()
        {
            // Snippet: CreateNasJob(CreateNasJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CreateNasJobRequest request = new CreateNasJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NasJob = new NasJob(),
            };
            // Make the request
            NasJob response = jobServiceClient.CreateNasJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNasJobAsync</summary>
        public async Task CreateNasJobRequestObjectAsync()
        {
            // Snippet: CreateNasJobAsync(CreateNasJobRequest, CallSettings)
            // Additional: CreateNasJobAsync(CreateNasJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateNasJobRequest request = new CreateNasJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NasJob = new NasJob(),
            };
            // Make the request
            NasJob response = await jobServiceClient.CreateNasJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNasJob</summary>
        public void CreateNasJob()
        {
            // Snippet: CreateNasJob(string, NasJob, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            NasJob nasJob = new NasJob();
            // Make the request
            NasJob response = jobServiceClient.CreateNasJob(parent, nasJob);
            // End snippet
        }

        /// <summary>Snippet for CreateNasJobAsync</summary>
        public async Task CreateNasJobAsync()
        {
            // Snippet: CreateNasJobAsync(string, NasJob, CallSettings)
            // Additional: CreateNasJobAsync(string, NasJob, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            NasJob nasJob = new NasJob();
            // Make the request
            NasJob response = await jobServiceClient.CreateNasJobAsync(parent, nasJob);
            // End snippet
        }

        /// <summary>Snippet for CreateNasJob</summary>
        public void CreateNasJobResourceNames()
        {
            // Snippet: CreateNasJob(LocationName, NasJob, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NasJob nasJob = new NasJob();
            // Make the request
            NasJob response = jobServiceClient.CreateNasJob(parent, nasJob);
            // End snippet
        }

        /// <summary>Snippet for CreateNasJobAsync</summary>
        public async Task CreateNasJobResourceNamesAsync()
        {
            // Snippet: CreateNasJobAsync(LocationName, NasJob, CallSettings)
            // Additional: CreateNasJobAsync(LocationName, NasJob, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NasJob nasJob = new NasJob();
            // Make the request
            NasJob response = await jobServiceClient.CreateNasJobAsync(parent, nasJob);
            // End snippet
        }

        /// <summary>Snippet for GetNasJob</summary>
        public void GetNasJobRequestObject()
        {
            // Snippet: GetNasJob(GetNasJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            GetNasJobRequest request = new GetNasJobRequest
            {
                NasJobName = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]"),
            };
            // Make the request
            NasJob response = jobServiceClient.GetNasJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetNasJobAsync</summary>
        public async Task GetNasJobRequestObjectAsync()
        {
            // Snippet: GetNasJobAsync(GetNasJobRequest, CallSettings)
            // Additional: GetNasJobAsync(GetNasJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNasJobRequest request = new GetNasJobRequest
            {
                NasJobName = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]"),
            };
            // Make the request
            NasJob response = await jobServiceClient.GetNasJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNasJob</summary>
        public void GetNasJob()
        {
            // Snippet: GetNasJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nasJobs/[NAS_JOB]";
            // Make the request
            NasJob response = jobServiceClient.GetNasJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetNasJobAsync</summary>
        public async Task GetNasJobAsync()
        {
            // Snippet: GetNasJobAsync(string, CallSettings)
            // Additional: GetNasJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nasJobs/[NAS_JOB]";
            // Make the request
            NasJob response = await jobServiceClient.GetNasJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNasJob</summary>
        public void GetNasJobResourceNames()
        {
            // Snippet: GetNasJob(NasJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            NasJobName name = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]");
            // Make the request
            NasJob response = jobServiceClient.GetNasJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetNasJobAsync</summary>
        public async Task GetNasJobResourceNamesAsync()
        {
            // Snippet: GetNasJobAsync(NasJobName, CallSettings)
            // Additional: GetNasJobAsync(NasJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            NasJobName name = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]");
            // Make the request
            NasJob response = await jobServiceClient.GetNasJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNasJobs</summary>
        public void ListNasJobsRequestObject()
        {
            // Snippet: ListNasJobs(ListNasJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ListNasJobsRequest request = new ListNasJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListNasJobsResponse, NasJob> response = jobServiceClient.ListNasJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NasJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNasJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NasJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NasJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NasJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNasJobsAsync</summary>
        public async Task ListNasJobsRequestObjectAsync()
        {
            // Snippet: ListNasJobsAsync(ListNasJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNasJobsRequest request = new ListNasJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListNasJobsResponse, NasJob> response = jobServiceClient.ListNasJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NasJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNasJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NasJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NasJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NasJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNasJobs</summary>
        public void ListNasJobs()
        {
            // Snippet: ListNasJobs(string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListNasJobsResponse, NasJob> response = jobServiceClient.ListNasJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NasJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNasJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NasJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NasJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NasJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNasJobsAsync</summary>
        public async Task ListNasJobsAsync()
        {
            // Snippet: ListNasJobsAsync(string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListNasJobsResponse, NasJob> response = jobServiceClient.ListNasJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NasJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNasJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NasJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NasJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NasJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNasJobs</summary>
        public void ListNasJobsResourceNames()
        {
            // Snippet: ListNasJobs(LocationName, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNasJobsResponse, NasJob> response = jobServiceClient.ListNasJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NasJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNasJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NasJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NasJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NasJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNasJobsAsync</summary>
        public async Task ListNasJobsResourceNamesAsync()
        {
            // Snippet: ListNasJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNasJobsResponse, NasJob> response = jobServiceClient.ListNasJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NasJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNasJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NasJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NasJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NasJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteNasJob</summary>
        public void DeleteNasJobRequestObject()
        {
            // Snippet: DeleteNasJob(DeleteNasJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            DeleteNasJobRequest request = new DeleteNasJobRequest
            {
                NasJobName = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteNasJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteNasJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNasJobAsync</summary>
        public async Task DeleteNasJobRequestObjectAsync()
        {
            // Snippet: DeleteNasJobAsync(DeleteNasJobRequest, CallSettings)
            // Additional: DeleteNasJobAsync(DeleteNasJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNasJobRequest request = new DeleteNasJobRequest
            {
                NasJobName = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteNasJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteNasJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNasJob</summary>
        public void DeleteNasJob()
        {
            // Snippet: DeleteNasJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nasJobs/[NAS_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteNasJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteNasJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNasJobAsync</summary>
        public async Task DeleteNasJobAsync()
        {
            // Snippet: DeleteNasJobAsync(string, CallSettings)
            // Additional: DeleteNasJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nasJobs/[NAS_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteNasJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteNasJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNasJob</summary>
        public void DeleteNasJobResourceNames()
        {
            // Snippet: DeleteNasJob(NasJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            NasJobName name = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteNasJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteNasJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNasJobAsync</summary>
        public async Task DeleteNasJobResourceNamesAsync()
        {
            // Snippet: DeleteNasJobAsync(NasJobName, CallSettings)
            // Additional: DeleteNasJobAsync(NasJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            NasJobName name = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteNasJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteNasJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelNasJob</summary>
        public void CancelNasJobRequestObject()
        {
            // Snippet: CancelNasJob(CancelNasJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CancelNasJobRequest request = new CancelNasJobRequest
            {
                NasJobName = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]"),
            };
            // Make the request
            jobServiceClient.CancelNasJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelNasJobAsync</summary>
        public async Task CancelNasJobRequestObjectAsync()
        {
            // Snippet: CancelNasJobAsync(CancelNasJobRequest, CallSettings)
            // Additional: CancelNasJobAsync(CancelNasJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelNasJobRequest request = new CancelNasJobRequest
            {
                NasJobName = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]"),
            };
            // Make the request
            await jobServiceClient.CancelNasJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelNasJob</summary>
        public void CancelNasJob()
        {
            // Snippet: CancelNasJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nasJobs/[NAS_JOB]";
            // Make the request
            jobServiceClient.CancelNasJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelNasJobAsync</summary>
        public async Task CancelNasJobAsync()
        {
            // Snippet: CancelNasJobAsync(string, CallSettings)
            // Additional: CancelNasJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nasJobs/[NAS_JOB]";
            // Make the request
            await jobServiceClient.CancelNasJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelNasJob</summary>
        public void CancelNasJobResourceNames()
        {
            // Snippet: CancelNasJob(NasJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            NasJobName name = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]");
            // Make the request
            jobServiceClient.CancelNasJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelNasJobAsync</summary>
        public async Task CancelNasJobResourceNamesAsync()
        {
            // Snippet: CancelNasJobAsync(NasJobName, CallSettings)
            // Additional: CancelNasJobAsync(NasJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            NasJobName name = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]");
            // Make the request
            await jobServiceClient.CancelNasJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNasTrialDetail</summary>
        public void GetNasTrialDetailRequestObject()
        {
            // Snippet: GetNasTrialDetail(GetNasTrialDetailRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            GetNasTrialDetailRequest request = new GetNasTrialDetailRequest
            {
                NasTrialDetailName = NasTrialDetailName.FromProjectLocationNasJobNasTrialDetail("[PROJECT]", "[LOCATION]", "[NAS_JOB]", "[NAS_TRIAL_DETAIL]"),
            };
            // Make the request
            NasTrialDetail response = jobServiceClient.GetNasTrialDetail(request);
            // End snippet
        }

        /// <summary>Snippet for GetNasTrialDetailAsync</summary>
        public async Task GetNasTrialDetailRequestObjectAsync()
        {
            // Snippet: GetNasTrialDetailAsync(GetNasTrialDetailRequest, CallSettings)
            // Additional: GetNasTrialDetailAsync(GetNasTrialDetailRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNasTrialDetailRequest request = new GetNasTrialDetailRequest
            {
                NasTrialDetailName = NasTrialDetailName.FromProjectLocationNasJobNasTrialDetail("[PROJECT]", "[LOCATION]", "[NAS_JOB]", "[NAS_TRIAL_DETAIL]"),
            };
            // Make the request
            NasTrialDetail response = await jobServiceClient.GetNasTrialDetailAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNasTrialDetail</summary>
        public void GetNasTrialDetail()
        {
            // Snippet: GetNasTrialDetail(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nasJobs/[NAS_JOB]/nasTrialDetails/[NAS_TRIAL_DETAIL]";
            // Make the request
            NasTrialDetail response = jobServiceClient.GetNasTrialDetail(name);
            // End snippet
        }

        /// <summary>Snippet for GetNasTrialDetailAsync</summary>
        public async Task GetNasTrialDetailAsync()
        {
            // Snippet: GetNasTrialDetailAsync(string, CallSettings)
            // Additional: GetNasTrialDetailAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nasJobs/[NAS_JOB]/nasTrialDetails/[NAS_TRIAL_DETAIL]";
            // Make the request
            NasTrialDetail response = await jobServiceClient.GetNasTrialDetailAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNasTrialDetail</summary>
        public void GetNasTrialDetailResourceNames()
        {
            // Snippet: GetNasTrialDetail(NasTrialDetailName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            NasTrialDetailName name = NasTrialDetailName.FromProjectLocationNasJobNasTrialDetail("[PROJECT]", "[LOCATION]", "[NAS_JOB]", "[NAS_TRIAL_DETAIL]");
            // Make the request
            NasTrialDetail response = jobServiceClient.GetNasTrialDetail(name);
            // End snippet
        }

        /// <summary>Snippet for GetNasTrialDetailAsync</summary>
        public async Task GetNasTrialDetailResourceNamesAsync()
        {
            // Snippet: GetNasTrialDetailAsync(NasTrialDetailName, CallSettings)
            // Additional: GetNasTrialDetailAsync(NasTrialDetailName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            NasTrialDetailName name = NasTrialDetailName.FromProjectLocationNasJobNasTrialDetail("[PROJECT]", "[LOCATION]", "[NAS_JOB]", "[NAS_TRIAL_DETAIL]");
            // Make the request
            NasTrialDetail response = await jobServiceClient.GetNasTrialDetailAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNasTrialDetails</summary>
        public void ListNasTrialDetailsRequestObject()
        {
            // Snippet: ListNasTrialDetails(ListNasTrialDetailsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ListNasTrialDetailsRequest request = new ListNasTrialDetailsRequest
            {
                ParentAsNasJobName = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]"),
            };
            // Make the request
            PagedEnumerable<ListNasTrialDetailsResponse, NasTrialDetail> response = jobServiceClient.ListNasTrialDetails(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NasTrialDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNasTrialDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NasTrialDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NasTrialDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NasTrialDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNasTrialDetailsAsync</summary>
        public async Task ListNasTrialDetailsRequestObjectAsync()
        {
            // Snippet: ListNasTrialDetailsAsync(ListNasTrialDetailsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNasTrialDetailsRequest request = new ListNasTrialDetailsRequest
            {
                ParentAsNasJobName = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNasTrialDetailsResponse, NasTrialDetail> response = jobServiceClient.ListNasTrialDetailsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NasTrialDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNasTrialDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NasTrialDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NasTrialDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NasTrialDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNasTrialDetails</summary>
        public void ListNasTrialDetails()
        {
            // Snippet: ListNasTrialDetails(string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/nasJobs/[NAS_JOB]";
            // Make the request
            PagedEnumerable<ListNasTrialDetailsResponse, NasTrialDetail> response = jobServiceClient.ListNasTrialDetails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NasTrialDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNasTrialDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NasTrialDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NasTrialDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NasTrialDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNasTrialDetailsAsync</summary>
        public async Task ListNasTrialDetailsAsync()
        {
            // Snippet: ListNasTrialDetailsAsync(string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/nasJobs/[NAS_JOB]";
            // Make the request
            PagedAsyncEnumerable<ListNasTrialDetailsResponse, NasTrialDetail> response = jobServiceClient.ListNasTrialDetailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NasTrialDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNasTrialDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NasTrialDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NasTrialDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NasTrialDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNasTrialDetails</summary>
        public void ListNasTrialDetailsResourceNames()
        {
            // Snippet: ListNasTrialDetails(NasJobName, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            NasJobName parent = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]");
            // Make the request
            PagedEnumerable<ListNasTrialDetailsResponse, NasTrialDetail> response = jobServiceClient.ListNasTrialDetails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NasTrialDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNasTrialDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NasTrialDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NasTrialDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NasTrialDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNasTrialDetailsAsync</summary>
        public async Task ListNasTrialDetailsResourceNamesAsync()
        {
            // Snippet: ListNasTrialDetailsAsync(NasJobName, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            NasJobName parent = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]");
            // Make the request
            PagedAsyncEnumerable<ListNasTrialDetailsResponse, NasTrialDetail> response = jobServiceClient.ListNasTrialDetailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NasTrialDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNasTrialDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NasTrialDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NasTrialDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NasTrialDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateBatchPredictionJob</summary>
        public void CreateBatchPredictionJobRequestObject()
        {
            // Snippet: CreateBatchPredictionJob(CreateBatchPredictionJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CreateBatchPredictionJobRequest request = new CreateBatchPredictionJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BatchPredictionJob = new BatchPredictionJob(),
            };
            // Make the request
            BatchPredictionJob response = jobServiceClient.CreateBatchPredictionJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBatchPredictionJobAsync</summary>
        public async Task CreateBatchPredictionJobRequestObjectAsync()
        {
            // Snippet: CreateBatchPredictionJobAsync(CreateBatchPredictionJobRequest, CallSettings)
            // Additional: CreateBatchPredictionJobAsync(CreateBatchPredictionJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateBatchPredictionJobRequest request = new CreateBatchPredictionJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BatchPredictionJob = new BatchPredictionJob(),
            };
            // Make the request
            BatchPredictionJob response = await jobServiceClient.CreateBatchPredictionJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBatchPredictionJob</summary>
        public void CreateBatchPredictionJob()
        {
            // Snippet: CreateBatchPredictionJob(string, BatchPredictionJob, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BatchPredictionJob batchPredictionJob = new BatchPredictionJob();
            // Make the request
            BatchPredictionJob response = jobServiceClient.CreateBatchPredictionJob(parent, batchPredictionJob);
            // End snippet
        }

        /// <summary>Snippet for CreateBatchPredictionJobAsync</summary>
        public async Task CreateBatchPredictionJobAsync()
        {
            // Snippet: CreateBatchPredictionJobAsync(string, BatchPredictionJob, CallSettings)
            // Additional: CreateBatchPredictionJobAsync(string, BatchPredictionJob, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BatchPredictionJob batchPredictionJob = new BatchPredictionJob();
            // Make the request
            BatchPredictionJob response = await jobServiceClient.CreateBatchPredictionJobAsync(parent, batchPredictionJob);
            // End snippet
        }

        /// <summary>Snippet for CreateBatchPredictionJob</summary>
        public void CreateBatchPredictionJobResourceNames()
        {
            // Snippet: CreateBatchPredictionJob(LocationName, BatchPredictionJob, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BatchPredictionJob batchPredictionJob = new BatchPredictionJob();
            // Make the request
            BatchPredictionJob response = jobServiceClient.CreateBatchPredictionJob(parent, batchPredictionJob);
            // End snippet
        }

        /// <summary>Snippet for CreateBatchPredictionJobAsync</summary>
        public async Task CreateBatchPredictionJobResourceNamesAsync()
        {
            // Snippet: CreateBatchPredictionJobAsync(LocationName, BatchPredictionJob, CallSettings)
            // Additional: CreateBatchPredictionJobAsync(LocationName, BatchPredictionJob, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BatchPredictionJob batchPredictionJob = new BatchPredictionJob();
            // Make the request
            BatchPredictionJob response = await jobServiceClient.CreateBatchPredictionJobAsync(parent, batchPredictionJob);
            // End snippet
        }

        /// <summary>Snippet for GetBatchPredictionJob</summary>
        public void GetBatchPredictionJobRequestObject()
        {
            // Snippet: GetBatchPredictionJob(GetBatchPredictionJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            GetBatchPredictionJobRequest request = new GetBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            // Make the request
            BatchPredictionJob response = jobServiceClient.GetBatchPredictionJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetBatchPredictionJobAsync</summary>
        public async Task GetBatchPredictionJobRequestObjectAsync()
        {
            // Snippet: GetBatchPredictionJobAsync(GetBatchPredictionJobRequest, CallSettings)
            // Additional: GetBatchPredictionJobAsync(GetBatchPredictionJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBatchPredictionJobRequest request = new GetBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            // Make the request
            BatchPredictionJob response = await jobServiceClient.GetBatchPredictionJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBatchPredictionJob</summary>
        public void GetBatchPredictionJob()
        {
            // Snippet: GetBatchPredictionJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/batchPredictionJobs/[BATCH_PREDICTION_JOB]";
            // Make the request
            BatchPredictionJob response = jobServiceClient.GetBatchPredictionJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetBatchPredictionJobAsync</summary>
        public async Task GetBatchPredictionJobAsync()
        {
            // Snippet: GetBatchPredictionJobAsync(string, CallSettings)
            // Additional: GetBatchPredictionJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/batchPredictionJobs/[BATCH_PREDICTION_JOB]";
            // Make the request
            BatchPredictionJob response = await jobServiceClient.GetBatchPredictionJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBatchPredictionJob</summary>
        public void GetBatchPredictionJobResourceNames()
        {
            // Snippet: GetBatchPredictionJob(BatchPredictionJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            BatchPredictionJobName name = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]");
            // Make the request
            BatchPredictionJob response = jobServiceClient.GetBatchPredictionJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetBatchPredictionJobAsync</summary>
        public async Task GetBatchPredictionJobResourceNamesAsync()
        {
            // Snippet: GetBatchPredictionJobAsync(BatchPredictionJobName, CallSettings)
            // Additional: GetBatchPredictionJobAsync(BatchPredictionJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchPredictionJobName name = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]");
            // Make the request
            BatchPredictionJob response = await jobServiceClient.GetBatchPredictionJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBatchPredictionJobs</summary>
        public void ListBatchPredictionJobsRequestObject()
        {
            // Snippet: ListBatchPredictionJobs(ListBatchPredictionJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ListBatchPredictionJobsRequest request = new ListBatchPredictionJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListBatchPredictionJobsResponse, BatchPredictionJob> response = jobServiceClient.ListBatchPredictionJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BatchPredictionJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBatchPredictionJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BatchPredictionJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BatchPredictionJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BatchPredictionJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatchPredictionJobsAsync</summary>
        public async Task ListBatchPredictionJobsRequestObjectAsync()
        {
            // Snippet: ListBatchPredictionJobsAsync(ListBatchPredictionJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListBatchPredictionJobsRequest request = new ListBatchPredictionJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListBatchPredictionJobsResponse, BatchPredictionJob> response = jobServiceClient.ListBatchPredictionJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BatchPredictionJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBatchPredictionJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BatchPredictionJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BatchPredictionJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BatchPredictionJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatchPredictionJobs</summary>
        public void ListBatchPredictionJobs()
        {
            // Snippet: ListBatchPredictionJobs(string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBatchPredictionJobsResponse, BatchPredictionJob> response = jobServiceClient.ListBatchPredictionJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BatchPredictionJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBatchPredictionJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BatchPredictionJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BatchPredictionJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BatchPredictionJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatchPredictionJobsAsync</summary>
        public async Task ListBatchPredictionJobsAsync()
        {
            // Snippet: ListBatchPredictionJobsAsync(string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBatchPredictionJobsResponse, BatchPredictionJob> response = jobServiceClient.ListBatchPredictionJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BatchPredictionJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBatchPredictionJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BatchPredictionJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BatchPredictionJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BatchPredictionJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatchPredictionJobs</summary>
        public void ListBatchPredictionJobsResourceNames()
        {
            // Snippet: ListBatchPredictionJobs(LocationName, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBatchPredictionJobsResponse, BatchPredictionJob> response = jobServiceClient.ListBatchPredictionJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BatchPredictionJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBatchPredictionJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BatchPredictionJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BatchPredictionJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BatchPredictionJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatchPredictionJobsAsync</summary>
        public async Task ListBatchPredictionJobsResourceNamesAsync()
        {
            // Snippet: ListBatchPredictionJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBatchPredictionJobsResponse, BatchPredictionJob> response = jobServiceClient.ListBatchPredictionJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BatchPredictionJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBatchPredictionJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BatchPredictionJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BatchPredictionJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BatchPredictionJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteBatchPredictionJob</summary>
        public void DeleteBatchPredictionJobRequestObject()
        {
            // Snippet: DeleteBatchPredictionJob(DeleteBatchPredictionJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            DeleteBatchPredictionJobRequest request = new DeleteBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteBatchPredictionJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteBatchPredictionJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBatchPredictionJobAsync</summary>
        public async Task DeleteBatchPredictionJobRequestObjectAsync()
        {
            // Snippet: DeleteBatchPredictionJobAsync(DeleteBatchPredictionJobRequest, CallSettings)
            // Additional: DeleteBatchPredictionJobAsync(DeleteBatchPredictionJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBatchPredictionJobRequest request = new DeleteBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteBatchPredictionJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteBatchPredictionJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBatchPredictionJob</summary>
        public void DeleteBatchPredictionJob()
        {
            // Snippet: DeleteBatchPredictionJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/batchPredictionJobs/[BATCH_PREDICTION_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteBatchPredictionJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteBatchPredictionJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBatchPredictionJobAsync</summary>
        public async Task DeleteBatchPredictionJobAsync()
        {
            // Snippet: DeleteBatchPredictionJobAsync(string, CallSettings)
            // Additional: DeleteBatchPredictionJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/batchPredictionJobs/[BATCH_PREDICTION_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteBatchPredictionJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteBatchPredictionJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBatchPredictionJob</summary>
        public void DeleteBatchPredictionJobResourceNames()
        {
            // Snippet: DeleteBatchPredictionJob(BatchPredictionJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            BatchPredictionJobName name = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteBatchPredictionJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteBatchPredictionJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBatchPredictionJobAsync</summary>
        public async Task DeleteBatchPredictionJobResourceNamesAsync()
        {
            // Snippet: DeleteBatchPredictionJobAsync(BatchPredictionJobName, CallSettings)
            // Additional: DeleteBatchPredictionJobAsync(BatchPredictionJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchPredictionJobName name = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteBatchPredictionJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteBatchPredictionJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelBatchPredictionJob</summary>
        public void CancelBatchPredictionJobRequestObject()
        {
            // Snippet: CancelBatchPredictionJob(CancelBatchPredictionJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CancelBatchPredictionJobRequest request = new CancelBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            // Make the request
            jobServiceClient.CancelBatchPredictionJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelBatchPredictionJobAsync</summary>
        public async Task CancelBatchPredictionJobRequestObjectAsync()
        {
            // Snippet: CancelBatchPredictionJobAsync(CancelBatchPredictionJobRequest, CallSettings)
            // Additional: CancelBatchPredictionJobAsync(CancelBatchPredictionJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelBatchPredictionJobRequest request = new CancelBatchPredictionJobRequest
            {
                BatchPredictionJobName = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]"),
            };
            // Make the request
            await jobServiceClient.CancelBatchPredictionJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelBatchPredictionJob</summary>
        public void CancelBatchPredictionJob()
        {
            // Snippet: CancelBatchPredictionJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/batchPredictionJobs/[BATCH_PREDICTION_JOB]";
            // Make the request
            jobServiceClient.CancelBatchPredictionJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelBatchPredictionJobAsync</summary>
        public async Task CancelBatchPredictionJobAsync()
        {
            // Snippet: CancelBatchPredictionJobAsync(string, CallSettings)
            // Additional: CancelBatchPredictionJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/batchPredictionJobs/[BATCH_PREDICTION_JOB]";
            // Make the request
            await jobServiceClient.CancelBatchPredictionJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelBatchPredictionJob</summary>
        public void CancelBatchPredictionJobResourceNames()
        {
            // Snippet: CancelBatchPredictionJob(BatchPredictionJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            BatchPredictionJobName name = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]");
            // Make the request
            jobServiceClient.CancelBatchPredictionJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelBatchPredictionJobAsync</summary>
        public async Task CancelBatchPredictionJobResourceNamesAsync()
        {
            // Snippet: CancelBatchPredictionJobAsync(BatchPredictionJobName, CallSettings)
            // Additional: CancelBatchPredictionJobAsync(BatchPredictionJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchPredictionJobName name = BatchPredictionJobName.FromProjectLocationBatchPredictionJob("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]");
            // Make the request
            await jobServiceClient.CancelBatchPredictionJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateModelDeploymentMonitoringJob</summary>
        public void CreateModelDeploymentMonitoringJobRequestObject()
        {
            // Snippet: CreateModelDeploymentMonitoringJob(CreateModelDeploymentMonitoringJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CreateModelDeploymentMonitoringJobRequest request = new CreateModelDeploymentMonitoringJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ModelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob(),
            };
            // Make the request
            ModelDeploymentMonitoringJob response = jobServiceClient.CreateModelDeploymentMonitoringJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateModelDeploymentMonitoringJobAsync</summary>
        public async Task CreateModelDeploymentMonitoringJobRequestObjectAsync()
        {
            // Snippet: CreateModelDeploymentMonitoringJobAsync(CreateModelDeploymentMonitoringJobRequest, CallSettings)
            // Additional: CreateModelDeploymentMonitoringJobAsync(CreateModelDeploymentMonitoringJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateModelDeploymentMonitoringJobRequest request = new CreateModelDeploymentMonitoringJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ModelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob(),
            };
            // Make the request
            ModelDeploymentMonitoringJob response = await jobServiceClient.CreateModelDeploymentMonitoringJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateModelDeploymentMonitoringJob</summary>
        public void CreateModelDeploymentMonitoringJob()
        {
            // Snippet: CreateModelDeploymentMonitoringJob(string, ModelDeploymentMonitoringJob, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ModelDeploymentMonitoringJob modelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob();
            // Make the request
            ModelDeploymentMonitoringJob response = jobServiceClient.CreateModelDeploymentMonitoringJob(parent, modelDeploymentMonitoringJob);
            // End snippet
        }

        /// <summary>Snippet for CreateModelDeploymentMonitoringJobAsync</summary>
        public async Task CreateModelDeploymentMonitoringJobAsync()
        {
            // Snippet: CreateModelDeploymentMonitoringJobAsync(string, ModelDeploymentMonitoringJob, CallSettings)
            // Additional: CreateModelDeploymentMonitoringJobAsync(string, ModelDeploymentMonitoringJob, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ModelDeploymentMonitoringJob modelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob();
            // Make the request
            ModelDeploymentMonitoringJob response = await jobServiceClient.CreateModelDeploymentMonitoringJobAsync(parent, modelDeploymentMonitoringJob);
            // End snippet
        }

        /// <summary>Snippet for CreateModelDeploymentMonitoringJob</summary>
        public void CreateModelDeploymentMonitoringJobResourceNames()
        {
            // Snippet: CreateModelDeploymentMonitoringJob(LocationName, ModelDeploymentMonitoringJob, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ModelDeploymentMonitoringJob modelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob();
            // Make the request
            ModelDeploymentMonitoringJob response = jobServiceClient.CreateModelDeploymentMonitoringJob(parent, modelDeploymentMonitoringJob);
            // End snippet
        }

        /// <summary>Snippet for CreateModelDeploymentMonitoringJobAsync</summary>
        public async Task CreateModelDeploymentMonitoringJobResourceNamesAsync()
        {
            // Snippet: CreateModelDeploymentMonitoringJobAsync(LocationName, ModelDeploymentMonitoringJob, CallSettings)
            // Additional: CreateModelDeploymentMonitoringJobAsync(LocationName, ModelDeploymentMonitoringJob, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ModelDeploymentMonitoringJob modelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob();
            // Make the request
            ModelDeploymentMonitoringJob response = await jobServiceClient.CreateModelDeploymentMonitoringJobAsync(parent, modelDeploymentMonitoringJob);
            // End snippet
        }

        /// <summary>Snippet for SearchModelDeploymentMonitoringStatsAnomalies</summary>
        public void SearchModelDeploymentMonitoringStatsAnomaliesRequestObject()
        {
            // Snippet: SearchModelDeploymentMonitoringStatsAnomalies(SearchModelDeploymentMonitoringStatsAnomaliesRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            SearchModelDeploymentMonitoringStatsAnomaliesRequest request = new SearchModelDeploymentMonitoringStatsAnomaliesRequest
            {
                ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DeployedModelId = "",
                FeatureDisplayName = "",
                Objectives =
                {
                    new SearchModelDeploymentMonitoringStatsAnomaliesRequest.Types.StatsAnomaliesObjective(),
                },
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            PagedEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies> response = jobServiceClient.SearchModelDeploymentMonitoringStatsAnomalies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitoringStatsAnomalies item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchModelDeploymentMonitoringStatsAnomaliesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringStatsAnomalies item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringStatsAnomalies> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringStatsAnomalies item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelDeploymentMonitoringStatsAnomaliesAsync</summary>
        public async Task SearchModelDeploymentMonitoringStatsAnomaliesRequestObjectAsync()
        {
            // Snippet: SearchModelDeploymentMonitoringStatsAnomaliesAsync(SearchModelDeploymentMonitoringStatsAnomaliesRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchModelDeploymentMonitoringStatsAnomaliesRequest request = new SearchModelDeploymentMonitoringStatsAnomaliesRequest
            {
                ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DeployedModelId = "",
                FeatureDisplayName = "",
                Objectives =
                {
                    new SearchModelDeploymentMonitoringStatsAnomaliesRequest.Types.StatsAnomaliesObjective(),
                },
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            PagedAsyncEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies> response = jobServiceClient.SearchModelDeploymentMonitoringStatsAnomaliesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitoringStatsAnomalies item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchModelDeploymentMonitoringStatsAnomaliesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringStatsAnomalies item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringStatsAnomalies> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringStatsAnomalies item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelDeploymentMonitoringStatsAnomalies</summary>
        public void SearchModelDeploymentMonitoringStatsAnomalies()
        {
            // Snippet: SearchModelDeploymentMonitoringStatsAnomalies(string, string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string modelDeploymentMonitoringJob = "projects/[PROJECT]/locations/[LOCATION]/modelDeploymentMonitoringJobs/[MODEL_DEPLOYMENT_MONITORING_JOB]";
            string deployedModelId = "";
            // Make the request
            PagedEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies> response = jobServiceClient.SearchModelDeploymentMonitoringStatsAnomalies(modelDeploymentMonitoringJob, deployedModelId);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitoringStatsAnomalies item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchModelDeploymentMonitoringStatsAnomaliesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringStatsAnomalies item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringStatsAnomalies> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringStatsAnomalies item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelDeploymentMonitoringStatsAnomaliesAsync</summary>
        public async Task SearchModelDeploymentMonitoringStatsAnomaliesAsync()
        {
            // Snippet: SearchModelDeploymentMonitoringStatsAnomaliesAsync(string, string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string modelDeploymentMonitoringJob = "projects/[PROJECT]/locations/[LOCATION]/modelDeploymentMonitoringJobs/[MODEL_DEPLOYMENT_MONITORING_JOB]";
            string deployedModelId = "";
            // Make the request
            PagedAsyncEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies> response = jobServiceClient.SearchModelDeploymentMonitoringStatsAnomaliesAsync(modelDeploymentMonitoringJob, deployedModelId);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitoringStatsAnomalies item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchModelDeploymentMonitoringStatsAnomaliesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringStatsAnomalies item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringStatsAnomalies> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringStatsAnomalies item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelDeploymentMonitoringStatsAnomalies</summary>
        public void SearchModelDeploymentMonitoringStatsAnomaliesResourceNames()
        {
            // Snippet: SearchModelDeploymentMonitoringStatsAnomalies(ModelDeploymentMonitoringJobName, string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ModelDeploymentMonitoringJobName modelDeploymentMonitoringJob = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]");
            string deployedModelId = "";
            // Make the request
            PagedEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies> response = jobServiceClient.SearchModelDeploymentMonitoringStatsAnomalies(modelDeploymentMonitoringJob, deployedModelId);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitoringStatsAnomalies item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchModelDeploymentMonitoringStatsAnomaliesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringStatsAnomalies item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringStatsAnomalies> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringStatsAnomalies item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelDeploymentMonitoringStatsAnomaliesAsync</summary>
        public async Task SearchModelDeploymentMonitoringStatsAnomaliesResourceNamesAsync()
        {
            // Snippet: SearchModelDeploymentMonitoringStatsAnomaliesAsync(ModelDeploymentMonitoringJobName, string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelDeploymentMonitoringJobName modelDeploymentMonitoringJob = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]");
            string deployedModelId = "";
            // Make the request
            PagedAsyncEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies> response = jobServiceClient.SearchModelDeploymentMonitoringStatsAnomaliesAsync(modelDeploymentMonitoringJob, deployedModelId);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitoringStatsAnomalies item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchModelDeploymentMonitoringStatsAnomaliesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringStatsAnomalies item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringStatsAnomalies> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringStatsAnomalies item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetModelDeploymentMonitoringJob</summary>
        public void GetModelDeploymentMonitoringJobRequestObject()
        {
            // Snippet: GetModelDeploymentMonitoringJob(GetModelDeploymentMonitoringJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            GetModelDeploymentMonitoringJobRequest request = new GetModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            // Make the request
            ModelDeploymentMonitoringJob response = jobServiceClient.GetModelDeploymentMonitoringJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelDeploymentMonitoringJobAsync</summary>
        public async Task GetModelDeploymentMonitoringJobRequestObjectAsync()
        {
            // Snippet: GetModelDeploymentMonitoringJobAsync(GetModelDeploymentMonitoringJobRequest, CallSettings)
            // Additional: GetModelDeploymentMonitoringJobAsync(GetModelDeploymentMonitoringJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetModelDeploymentMonitoringJobRequest request = new GetModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            // Make the request
            ModelDeploymentMonitoringJob response = await jobServiceClient.GetModelDeploymentMonitoringJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelDeploymentMonitoringJob</summary>
        public void GetModelDeploymentMonitoringJob()
        {
            // Snippet: GetModelDeploymentMonitoringJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelDeploymentMonitoringJobs/[MODEL_DEPLOYMENT_MONITORING_JOB]";
            // Make the request
            ModelDeploymentMonitoringJob response = jobServiceClient.GetModelDeploymentMonitoringJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelDeploymentMonitoringJobAsync</summary>
        public async Task GetModelDeploymentMonitoringJobAsync()
        {
            // Snippet: GetModelDeploymentMonitoringJobAsync(string, CallSettings)
            // Additional: GetModelDeploymentMonitoringJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelDeploymentMonitoringJobs/[MODEL_DEPLOYMENT_MONITORING_JOB]";
            // Make the request
            ModelDeploymentMonitoringJob response = await jobServiceClient.GetModelDeploymentMonitoringJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelDeploymentMonitoringJob</summary>
        public void GetModelDeploymentMonitoringJobResourceNames()
        {
            // Snippet: GetModelDeploymentMonitoringJob(ModelDeploymentMonitoringJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ModelDeploymentMonitoringJobName name = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]");
            // Make the request
            ModelDeploymentMonitoringJob response = jobServiceClient.GetModelDeploymentMonitoringJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelDeploymentMonitoringJobAsync</summary>
        public async Task GetModelDeploymentMonitoringJobResourceNamesAsync()
        {
            // Snippet: GetModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName, CallSettings)
            // Additional: GetModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelDeploymentMonitoringJobName name = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]");
            // Make the request
            ModelDeploymentMonitoringJob response = await jobServiceClient.GetModelDeploymentMonitoringJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListModelDeploymentMonitoringJobs</summary>
        public void ListModelDeploymentMonitoringJobsRequestObject()
        {
            // Snippet: ListModelDeploymentMonitoringJobs(ListModelDeploymentMonitoringJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ListModelDeploymentMonitoringJobsRequest request = new ListModelDeploymentMonitoringJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob> response = jobServiceClient.ListModelDeploymentMonitoringJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelDeploymentMonitoringJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelDeploymentMonitoringJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelDeploymentMonitoringJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelDeploymentMonitoringJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelDeploymentMonitoringJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelDeploymentMonitoringJobsAsync</summary>
        public async Task ListModelDeploymentMonitoringJobsRequestObjectAsync()
        {
            // Snippet: ListModelDeploymentMonitoringJobsAsync(ListModelDeploymentMonitoringJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListModelDeploymentMonitoringJobsRequest request = new ListModelDeploymentMonitoringJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob> response = jobServiceClient.ListModelDeploymentMonitoringJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelDeploymentMonitoringJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelDeploymentMonitoringJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelDeploymentMonitoringJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelDeploymentMonitoringJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelDeploymentMonitoringJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelDeploymentMonitoringJobs</summary>
        public void ListModelDeploymentMonitoringJobs()
        {
            // Snippet: ListModelDeploymentMonitoringJobs(string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob> response = jobServiceClient.ListModelDeploymentMonitoringJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelDeploymentMonitoringJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelDeploymentMonitoringJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelDeploymentMonitoringJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelDeploymentMonitoringJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelDeploymentMonitoringJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelDeploymentMonitoringJobsAsync</summary>
        public async Task ListModelDeploymentMonitoringJobsAsync()
        {
            // Snippet: ListModelDeploymentMonitoringJobsAsync(string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob> response = jobServiceClient.ListModelDeploymentMonitoringJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelDeploymentMonitoringJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelDeploymentMonitoringJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelDeploymentMonitoringJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelDeploymentMonitoringJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelDeploymentMonitoringJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelDeploymentMonitoringJobs</summary>
        public void ListModelDeploymentMonitoringJobsResourceNames()
        {
            // Snippet: ListModelDeploymentMonitoringJobs(LocationName, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob> response = jobServiceClient.ListModelDeploymentMonitoringJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelDeploymentMonitoringJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelDeploymentMonitoringJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelDeploymentMonitoringJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelDeploymentMonitoringJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelDeploymentMonitoringJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelDeploymentMonitoringJobsAsync</summary>
        public async Task ListModelDeploymentMonitoringJobsResourceNamesAsync()
        {
            // Snippet: ListModelDeploymentMonitoringJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob> response = jobServiceClient.ListModelDeploymentMonitoringJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelDeploymentMonitoringJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelDeploymentMonitoringJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelDeploymentMonitoringJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelDeploymentMonitoringJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelDeploymentMonitoringJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateModelDeploymentMonitoringJob</summary>
        public void UpdateModelDeploymentMonitoringJobRequestObject()
        {
            // Snippet: UpdateModelDeploymentMonitoringJob(UpdateModelDeploymentMonitoringJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            UpdateModelDeploymentMonitoringJobRequest request = new UpdateModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> response = jobServiceClient.UpdateModelDeploymentMonitoringJob(request);

            // Poll until the returned long-running operation is complete
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ModelDeploymentMonitoringJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> retrievedResponse = jobServiceClient.PollOnceUpdateModelDeploymentMonitoringJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelDeploymentMonitoringJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateModelDeploymentMonitoringJobAsync</summary>
        public async Task UpdateModelDeploymentMonitoringJobRequestObjectAsync()
        {
            // Snippet: UpdateModelDeploymentMonitoringJobAsync(UpdateModelDeploymentMonitoringJobRequest, CallSettings)
            // Additional: UpdateModelDeploymentMonitoringJobAsync(UpdateModelDeploymentMonitoringJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateModelDeploymentMonitoringJobRequest request = new UpdateModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> response = await jobServiceClient.UpdateModelDeploymentMonitoringJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ModelDeploymentMonitoringJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceUpdateModelDeploymentMonitoringJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelDeploymentMonitoringJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateModelDeploymentMonitoringJob</summary>
        public void UpdateModelDeploymentMonitoringJob()
        {
            // Snippet: UpdateModelDeploymentMonitoringJob(ModelDeploymentMonitoringJob, FieldMask, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ModelDeploymentMonitoringJob modelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> response = jobServiceClient.UpdateModelDeploymentMonitoringJob(modelDeploymentMonitoringJob, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ModelDeploymentMonitoringJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> retrievedResponse = jobServiceClient.PollOnceUpdateModelDeploymentMonitoringJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelDeploymentMonitoringJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateModelDeploymentMonitoringJobAsync</summary>
        public async Task UpdateModelDeploymentMonitoringJobAsync()
        {
            // Snippet: UpdateModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJob, FieldMask, CallSettings)
            // Additional: UpdateModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJob, FieldMask, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelDeploymentMonitoringJob modelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> response = await jobServiceClient.UpdateModelDeploymentMonitoringJobAsync(modelDeploymentMonitoringJob, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ModelDeploymentMonitoringJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceUpdateModelDeploymentMonitoringJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelDeploymentMonitoringJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelDeploymentMonitoringJob</summary>
        public void DeleteModelDeploymentMonitoringJobRequestObject()
        {
            // Snippet: DeleteModelDeploymentMonitoringJob(DeleteModelDeploymentMonitoringJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            DeleteModelDeploymentMonitoringJobRequest request = new DeleteModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteModelDeploymentMonitoringJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteModelDeploymentMonitoringJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelDeploymentMonitoringJobAsync</summary>
        public async Task DeleteModelDeploymentMonitoringJobRequestObjectAsync()
        {
            // Snippet: DeleteModelDeploymentMonitoringJobAsync(DeleteModelDeploymentMonitoringJobRequest, CallSettings)
            // Additional: DeleteModelDeploymentMonitoringJobAsync(DeleteModelDeploymentMonitoringJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteModelDeploymentMonitoringJobRequest request = new DeleteModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteModelDeploymentMonitoringJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteModelDeploymentMonitoringJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelDeploymentMonitoringJob</summary>
        public void DeleteModelDeploymentMonitoringJob()
        {
            // Snippet: DeleteModelDeploymentMonitoringJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelDeploymentMonitoringJobs/[MODEL_DEPLOYMENT_MONITORING_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteModelDeploymentMonitoringJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteModelDeploymentMonitoringJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelDeploymentMonitoringJobAsync</summary>
        public async Task DeleteModelDeploymentMonitoringJobAsync()
        {
            // Snippet: DeleteModelDeploymentMonitoringJobAsync(string, CallSettings)
            // Additional: DeleteModelDeploymentMonitoringJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelDeploymentMonitoringJobs/[MODEL_DEPLOYMENT_MONITORING_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteModelDeploymentMonitoringJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteModelDeploymentMonitoringJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelDeploymentMonitoringJob</summary>
        public void DeleteModelDeploymentMonitoringJobResourceNames()
        {
            // Snippet: DeleteModelDeploymentMonitoringJob(ModelDeploymentMonitoringJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ModelDeploymentMonitoringJobName name = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = jobServiceClient.DeleteModelDeploymentMonitoringJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = jobServiceClient.PollOnceDeleteModelDeploymentMonitoringJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelDeploymentMonitoringJobAsync</summary>
        public async Task DeleteModelDeploymentMonitoringJobResourceNamesAsync()
        {
            // Snippet: DeleteModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName, CallSettings)
            // Additional: DeleteModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelDeploymentMonitoringJobName name = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await jobServiceClient.DeleteModelDeploymentMonitoringJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceDeleteModelDeploymentMonitoringJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PauseModelDeploymentMonitoringJob</summary>
        public void PauseModelDeploymentMonitoringJobRequestObject()
        {
            // Snippet: PauseModelDeploymentMonitoringJob(PauseModelDeploymentMonitoringJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            PauseModelDeploymentMonitoringJobRequest request = new PauseModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            // Make the request
            jobServiceClient.PauseModelDeploymentMonitoringJob(request);
            // End snippet
        }

        /// <summary>Snippet for PauseModelDeploymentMonitoringJobAsync</summary>
        public async Task PauseModelDeploymentMonitoringJobRequestObjectAsync()
        {
            // Snippet: PauseModelDeploymentMonitoringJobAsync(PauseModelDeploymentMonitoringJobRequest, CallSettings)
            // Additional: PauseModelDeploymentMonitoringJobAsync(PauseModelDeploymentMonitoringJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            PauseModelDeploymentMonitoringJobRequest request = new PauseModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            // Make the request
            await jobServiceClient.PauseModelDeploymentMonitoringJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PauseModelDeploymentMonitoringJob</summary>
        public void PauseModelDeploymentMonitoringJob()
        {
            // Snippet: PauseModelDeploymentMonitoringJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelDeploymentMonitoringJobs/[MODEL_DEPLOYMENT_MONITORING_JOB]";
            // Make the request
            jobServiceClient.PauseModelDeploymentMonitoringJob(name);
            // End snippet
        }

        /// <summary>Snippet for PauseModelDeploymentMonitoringJobAsync</summary>
        public async Task PauseModelDeploymentMonitoringJobAsync()
        {
            // Snippet: PauseModelDeploymentMonitoringJobAsync(string, CallSettings)
            // Additional: PauseModelDeploymentMonitoringJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelDeploymentMonitoringJobs/[MODEL_DEPLOYMENT_MONITORING_JOB]";
            // Make the request
            await jobServiceClient.PauseModelDeploymentMonitoringJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseModelDeploymentMonitoringJob</summary>
        public void PauseModelDeploymentMonitoringJobResourceNames()
        {
            // Snippet: PauseModelDeploymentMonitoringJob(ModelDeploymentMonitoringJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ModelDeploymentMonitoringJobName name = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]");
            // Make the request
            jobServiceClient.PauseModelDeploymentMonitoringJob(name);
            // End snippet
        }

        /// <summary>Snippet for PauseModelDeploymentMonitoringJobAsync</summary>
        public async Task PauseModelDeploymentMonitoringJobResourceNamesAsync()
        {
            // Snippet: PauseModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName, CallSettings)
            // Additional: PauseModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelDeploymentMonitoringJobName name = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]");
            // Make the request
            await jobServiceClient.PauseModelDeploymentMonitoringJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeModelDeploymentMonitoringJob</summary>
        public void ResumeModelDeploymentMonitoringJobRequestObject()
        {
            // Snippet: ResumeModelDeploymentMonitoringJob(ResumeModelDeploymentMonitoringJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ResumeModelDeploymentMonitoringJobRequest request = new ResumeModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            // Make the request
            jobServiceClient.ResumeModelDeploymentMonitoringJob(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeModelDeploymentMonitoringJobAsync</summary>
        public async Task ResumeModelDeploymentMonitoringJobRequestObjectAsync()
        {
            // Snippet: ResumeModelDeploymentMonitoringJobAsync(ResumeModelDeploymentMonitoringJobRequest, CallSettings)
            // Additional: ResumeModelDeploymentMonitoringJobAsync(ResumeModelDeploymentMonitoringJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResumeModelDeploymentMonitoringJobRequest request = new ResumeModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            // Make the request
            await jobServiceClient.ResumeModelDeploymentMonitoringJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeModelDeploymentMonitoringJob</summary>
        public void ResumeModelDeploymentMonitoringJob()
        {
            // Snippet: ResumeModelDeploymentMonitoringJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelDeploymentMonitoringJobs/[MODEL_DEPLOYMENT_MONITORING_JOB]";
            // Make the request
            jobServiceClient.ResumeModelDeploymentMonitoringJob(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeModelDeploymentMonitoringJobAsync</summary>
        public async Task ResumeModelDeploymentMonitoringJobAsync()
        {
            // Snippet: ResumeModelDeploymentMonitoringJobAsync(string, CallSettings)
            // Additional: ResumeModelDeploymentMonitoringJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelDeploymentMonitoringJobs/[MODEL_DEPLOYMENT_MONITORING_JOB]";
            // Make the request
            await jobServiceClient.ResumeModelDeploymentMonitoringJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeModelDeploymentMonitoringJob</summary>
        public void ResumeModelDeploymentMonitoringJobResourceNames()
        {
            // Snippet: ResumeModelDeploymentMonitoringJob(ModelDeploymentMonitoringJobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ModelDeploymentMonitoringJobName name = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]");
            // Make the request
            jobServiceClient.ResumeModelDeploymentMonitoringJob(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeModelDeploymentMonitoringJobAsync</summary>
        public async Task ResumeModelDeploymentMonitoringJobResourceNamesAsync()
        {
            // Snippet: ResumeModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName, CallSettings)
            // Additional: ResumeModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelDeploymentMonitoringJobName name = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]");
            // Make the request
            await jobServiceClient.ResumeModelDeploymentMonitoringJobAsync(name);
            // End snippet
        }
    }
}
