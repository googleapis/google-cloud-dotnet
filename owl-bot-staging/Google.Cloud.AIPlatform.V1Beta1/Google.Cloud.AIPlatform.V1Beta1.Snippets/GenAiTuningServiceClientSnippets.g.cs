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
    public sealed class AllGeneratedGenAiTuningServiceClientSnippets
    {
        /// <summary>Snippet for CreateTuningJob</summary>
        public void CreateTuningJobRequestObject()
        {
            // Snippet: CreateTuningJob(CreateTuningJobRequest, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            CreateTuningJobRequest request = new CreateTuningJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TuningJob = new TuningJob(),
            };
            // Make the request
            TuningJob response = genAiTuningServiceClient.CreateTuningJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTuningJobAsync</summary>
        public async Task CreateTuningJobRequestObjectAsync()
        {
            // Snippet: CreateTuningJobAsync(CreateTuningJobRequest, CallSettings)
            // Additional: CreateTuningJobAsync(CreateTuningJobRequest, CancellationToken)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTuningJobRequest request = new CreateTuningJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TuningJob = new TuningJob(),
            };
            // Make the request
            TuningJob response = await genAiTuningServiceClient.CreateTuningJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTuningJob</summary>
        public void CreateTuningJob()
        {
            // Snippet: CreateTuningJob(string, TuningJob, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TuningJob tuningJob = new TuningJob();
            // Make the request
            TuningJob response = genAiTuningServiceClient.CreateTuningJob(parent, tuningJob);
            // End snippet
        }

        /// <summary>Snippet for CreateTuningJobAsync</summary>
        public async Task CreateTuningJobAsync()
        {
            // Snippet: CreateTuningJobAsync(string, TuningJob, CallSettings)
            // Additional: CreateTuningJobAsync(string, TuningJob, CancellationToken)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TuningJob tuningJob = new TuningJob();
            // Make the request
            TuningJob response = await genAiTuningServiceClient.CreateTuningJobAsync(parent, tuningJob);
            // End snippet
        }

        /// <summary>Snippet for CreateTuningJob</summary>
        public void CreateTuningJobResourceNames()
        {
            // Snippet: CreateTuningJob(LocationName, TuningJob, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TuningJob tuningJob = new TuningJob();
            // Make the request
            TuningJob response = genAiTuningServiceClient.CreateTuningJob(parent, tuningJob);
            // End snippet
        }

        /// <summary>Snippet for CreateTuningJobAsync</summary>
        public async Task CreateTuningJobResourceNamesAsync()
        {
            // Snippet: CreateTuningJobAsync(LocationName, TuningJob, CallSettings)
            // Additional: CreateTuningJobAsync(LocationName, TuningJob, CancellationToken)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TuningJob tuningJob = new TuningJob();
            // Make the request
            TuningJob response = await genAiTuningServiceClient.CreateTuningJobAsync(parent, tuningJob);
            // End snippet
        }

        /// <summary>Snippet for GetTuningJob</summary>
        public void GetTuningJobRequestObject()
        {
            // Snippet: GetTuningJob(GetTuningJobRequest, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            GetTuningJobRequest request = new GetTuningJobRequest
            {
                TuningJobName = TuningJobName.FromProjectLocationTuningJob("[PROJECT]", "[LOCATION]", "[TUNING_JOB]"),
            };
            // Make the request
            TuningJob response = genAiTuningServiceClient.GetTuningJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetTuningJobAsync</summary>
        public async Task GetTuningJobRequestObjectAsync()
        {
            // Snippet: GetTuningJobAsync(GetTuningJobRequest, CallSettings)
            // Additional: GetTuningJobAsync(GetTuningJobRequest, CancellationToken)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTuningJobRequest request = new GetTuningJobRequest
            {
                TuningJobName = TuningJobName.FromProjectLocationTuningJob("[PROJECT]", "[LOCATION]", "[TUNING_JOB]"),
            };
            // Make the request
            TuningJob response = await genAiTuningServiceClient.GetTuningJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTuningJob</summary>
        public void GetTuningJob()
        {
            // Snippet: GetTuningJob(string, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tuningJobs/[TUNING_JOB]";
            // Make the request
            TuningJob response = genAiTuningServiceClient.GetTuningJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetTuningJobAsync</summary>
        public async Task GetTuningJobAsync()
        {
            // Snippet: GetTuningJobAsync(string, CallSettings)
            // Additional: GetTuningJobAsync(string, CancellationToken)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tuningJobs/[TUNING_JOB]";
            // Make the request
            TuningJob response = await genAiTuningServiceClient.GetTuningJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTuningJob</summary>
        public void GetTuningJobResourceNames()
        {
            // Snippet: GetTuningJob(TuningJobName, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            TuningJobName name = TuningJobName.FromProjectLocationTuningJob("[PROJECT]", "[LOCATION]", "[TUNING_JOB]");
            // Make the request
            TuningJob response = genAiTuningServiceClient.GetTuningJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetTuningJobAsync</summary>
        public async Task GetTuningJobResourceNamesAsync()
        {
            // Snippet: GetTuningJobAsync(TuningJobName, CallSettings)
            // Additional: GetTuningJobAsync(TuningJobName, CancellationToken)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            TuningJobName name = TuningJobName.FromProjectLocationTuningJob("[PROJECT]", "[LOCATION]", "[TUNING_JOB]");
            // Make the request
            TuningJob response = await genAiTuningServiceClient.GetTuningJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTuningJobs</summary>
        public void ListTuningJobsRequestObject()
        {
            // Snippet: ListTuningJobs(ListTuningJobsRequest, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            ListTuningJobsRequest request = new ListTuningJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListTuningJobsResponse, TuningJob> response = genAiTuningServiceClient.ListTuningJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TuningJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTuningJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TuningJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TuningJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TuningJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTuningJobsAsync</summary>
        public async Task ListTuningJobsRequestObjectAsync()
        {
            // Snippet: ListTuningJobsAsync(ListTuningJobsRequest, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTuningJobsRequest request = new ListTuningJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTuningJobsResponse, TuningJob> response = genAiTuningServiceClient.ListTuningJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TuningJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTuningJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TuningJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TuningJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TuningJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTuningJobs</summary>
        public void ListTuningJobs()
        {
            // Snippet: ListTuningJobs(string, string, int?, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTuningJobsResponse, TuningJob> response = genAiTuningServiceClient.ListTuningJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TuningJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTuningJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TuningJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TuningJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TuningJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTuningJobsAsync</summary>
        public async Task ListTuningJobsAsync()
        {
            // Snippet: ListTuningJobsAsync(string, string, int?, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTuningJobsResponse, TuningJob> response = genAiTuningServiceClient.ListTuningJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TuningJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTuningJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TuningJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TuningJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TuningJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTuningJobs</summary>
        public void ListTuningJobsResourceNames()
        {
            // Snippet: ListTuningJobs(LocationName, string, int?, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTuningJobsResponse, TuningJob> response = genAiTuningServiceClient.ListTuningJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TuningJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTuningJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TuningJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TuningJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TuningJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTuningJobsAsync</summary>
        public async Task ListTuningJobsResourceNamesAsync()
        {
            // Snippet: ListTuningJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTuningJobsResponse, TuningJob> response = genAiTuningServiceClient.ListTuningJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TuningJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTuningJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TuningJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TuningJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TuningJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CancelTuningJob</summary>
        public void CancelTuningJobRequestObject()
        {
            // Snippet: CancelTuningJob(CancelTuningJobRequest, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            CancelTuningJobRequest request = new CancelTuningJobRequest
            {
                TuningJobName = TuningJobName.FromProjectLocationTuningJob("[PROJECT]", "[LOCATION]", "[TUNING_JOB]"),
            };
            // Make the request
            genAiTuningServiceClient.CancelTuningJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelTuningJobAsync</summary>
        public async Task CancelTuningJobRequestObjectAsync()
        {
            // Snippet: CancelTuningJobAsync(CancelTuningJobRequest, CallSettings)
            // Additional: CancelTuningJobAsync(CancelTuningJobRequest, CancellationToken)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelTuningJobRequest request = new CancelTuningJobRequest
            {
                TuningJobName = TuningJobName.FromProjectLocationTuningJob("[PROJECT]", "[LOCATION]", "[TUNING_JOB]"),
            };
            // Make the request
            await genAiTuningServiceClient.CancelTuningJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelTuningJob</summary>
        public void CancelTuningJob()
        {
            // Snippet: CancelTuningJob(string, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tuningJobs/[TUNING_JOB]";
            // Make the request
            genAiTuningServiceClient.CancelTuningJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelTuningJobAsync</summary>
        public async Task CancelTuningJobAsync()
        {
            // Snippet: CancelTuningJobAsync(string, CallSettings)
            // Additional: CancelTuningJobAsync(string, CancellationToken)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tuningJobs/[TUNING_JOB]";
            // Make the request
            await genAiTuningServiceClient.CancelTuningJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelTuningJob</summary>
        public void CancelTuningJobResourceNames()
        {
            // Snippet: CancelTuningJob(TuningJobName, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            TuningJobName name = TuningJobName.FromProjectLocationTuningJob("[PROJECT]", "[LOCATION]", "[TUNING_JOB]");
            // Make the request
            genAiTuningServiceClient.CancelTuningJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelTuningJobAsync</summary>
        public async Task CancelTuningJobResourceNamesAsync()
        {
            // Snippet: CancelTuningJobAsync(TuningJobName, CallSettings)
            // Additional: CancelTuningJobAsync(TuningJobName, CancellationToken)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            TuningJobName name = TuningJobName.FromProjectLocationTuningJob("[PROJECT]", "[LOCATION]", "[TUNING_JOB]");
            // Make the request
            await genAiTuningServiceClient.CancelTuningJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RebaseTunedModel</summary>
        public void RebaseTunedModelRequestObject()
        {
            // Snippet: RebaseTunedModel(RebaseTunedModelRequest, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            RebaseTunedModelRequest request = new RebaseTunedModelRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TunedModelRef = new TunedModelRef(),
                TuningJob = new TuningJob(),
                ArtifactDestination = new GcsDestination(),
                DeployToSameEndpoint = false,
            };
            // Make the request
            Operation<TuningJob, RebaseTunedModelOperationMetadata> response = genAiTuningServiceClient.RebaseTunedModel(request);

            // Poll until the returned long-running operation is complete
            Operation<TuningJob, RebaseTunedModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TuningJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuningJob, RebaseTunedModelOperationMetadata> retrievedResponse = genAiTuningServiceClient.PollOnceRebaseTunedModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuningJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RebaseTunedModelAsync</summary>
        public async Task RebaseTunedModelRequestObjectAsync()
        {
            // Snippet: RebaseTunedModelAsync(RebaseTunedModelRequest, CallSettings)
            // Additional: RebaseTunedModelAsync(RebaseTunedModelRequest, CancellationToken)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            RebaseTunedModelRequest request = new RebaseTunedModelRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TunedModelRef = new TunedModelRef(),
                TuningJob = new TuningJob(),
                ArtifactDestination = new GcsDestination(),
                DeployToSameEndpoint = false,
            };
            // Make the request
            Operation<TuningJob, RebaseTunedModelOperationMetadata> response = await genAiTuningServiceClient.RebaseTunedModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TuningJob, RebaseTunedModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TuningJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuningJob, RebaseTunedModelOperationMetadata> retrievedResponse = await genAiTuningServiceClient.PollOnceRebaseTunedModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuningJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RebaseTunedModel</summary>
        public void RebaseTunedModel()
        {
            // Snippet: RebaseTunedModel(string, TunedModelRef, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TunedModelRef tunedModelRef = new TunedModelRef();
            // Make the request
            Operation<TuningJob, RebaseTunedModelOperationMetadata> response = genAiTuningServiceClient.RebaseTunedModel(parent, tunedModelRef);

            // Poll until the returned long-running operation is complete
            Operation<TuningJob, RebaseTunedModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TuningJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuningJob, RebaseTunedModelOperationMetadata> retrievedResponse = genAiTuningServiceClient.PollOnceRebaseTunedModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuningJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RebaseTunedModelAsync</summary>
        public async Task RebaseTunedModelAsync()
        {
            // Snippet: RebaseTunedModelAsync(string, TunedModelRef, CallSettings)
            // Additional: RebaseTunedModelAsync(string, TunedModelRef, CancellationToken)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TunedModelRef tunedModelRef = new TunedModelRef();
            // Make the request
            Operation<TuningJob, RebaseTunedModelOperationMetadata> response = await genAiTuningServiceClient.RebaseTunedModelAsync(parent, tunedModelRef);

            // Poll until the returned long-running operation is complete
            Operation<TuningJob, RebaseTunedModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TuningJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuningJob, RebaseTunedModelOperationMetadata> retrievedResponse = await genAiTuningServiceClient.PollOnceRebaseTunedModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuningJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RebaseTunedModel</summary>
        public void RebaseTunedModelResourceNames()
        {
            // Snippet: RebaseTunedModel(LocationName, TunedModelRef, CallSettings)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TunedModelRef tunedModelRef = new TunedModelRef();
            // Make the request
            Operation<TuningJob, RebaseTunedModelOperationMetadata> response = genAiTuningServiceClient.RebaseTunedModel(parent, tunedModelRef);

            // Poll until the returned long-running operation is complete
            Operation<TuningJob, RebaseTunedModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TuningJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuningJob, RebaseTunedModelOperationMetadata> retrievedResponse = genAiTuningServiceClient.PollOnceRebaseTunedModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuningJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RebaseTunedModelAsync</summary>
        public async Task RebaseTunedModelResourceNamesAsync()
        {
            // Snippet: RebaseTunedModelAsync(LocationName, TunedModelRef, CallSettings)
            // Additional: RebaseTunedModelAsync(LocationName, TunedModelRef, CancellationToken)
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = await GenAiTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TunedModelRef tunedModelRef = new TunedModelRef();
            // Make the request
            Operation<TuningJob, RebaseTunedModelOperationMetadata> response = await genAiTuningServiceClient.RebaseTunedModelAsync(parent, tunedModelRef);

            // Poll until the returned long-running operation is complete
            Operation<TuningJob, RebaseTunedModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TuningJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuningJob, RebaseTunedModelOperationMetadata> retrievedResponse = await genAiTuningServiceClient.PollOnceRebaseTunedModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuningJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
