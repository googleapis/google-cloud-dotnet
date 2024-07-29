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
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedScheduleServiceClientSnippets
    {
        /// <summary>Snippet for CreateSchedule</summary>
        public void CreateScheduleRequestObject()
        {
            // Snippet: CreateSchedule(CreateScheduleRequest, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            CreateScheduleRequest request = new CreateScheduleRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Schedule = new Schedule(),
            };
            // Make the request
            Schedule response = scheduleServiceClient.CreateSchedule(request);
            // End snippet
        }

        /// <summary>Snippet for CreateScheduleAsync</summary>
        public async Task CreateScheduleRequestObjectAsync()
        {
            // Snippet: CreateScheduleAsync(CreateScheduleRequest, CallSettings)
            // Additional: CreateScheduleAsync(CreateScheduleRequest, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateScheduleRequest request = new CreateScheduleRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Schedule = new Schedule(),
            };
            // Make the request
            Schedule response = await scheduleServiceClient.CreateScheduleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSchedule</summary>
        public void CreateSchedule()
        {
            // Snippet: CreateSchedule(string, Schedule, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Schedule schedule = new Schedule();
            // Make the request
            Schedule response = scheduleServiceClient.CreateSchedule(parent, schedule);
            // End snippet
        }

        /// <summary>Snippet for CreateScheduleAsync</summary>
        public async Task CreateScheduleAsync()
        {
            // Snippet: CreateScheduleAsync(string, Schedule, CallSettings)
            // Additional: CreateScheduleAsync(string, Schedule, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Schedule schedule = new Schedule();
            // Make the request
            Schedule response = await scheduleServiceClient.CreateScheduleAsync(parent, schedule);
            // End snippet
        }

        /// <summary>Snippet for CreateSchedule</summary>
        public void CreateScheduleResourceNames()
        {
            // Snippet: CreateSchedule(LocationName, Schedule, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Schedule schedule = new Schedule();
            // Make the request
            Schedule response = scheduleServiceClient.CreateSchedule(parent, schedule);
            // End snippet
        }

        /// <summary>Snippet for CreateScheduleAsync</summary>
        public async Task CreateScheduleResourceNamesAsync()
        {
            // Snippet: CreateScheduleAsync(LocationName, Schedule, CallSettings)
            // Additional: CreateScheduleAsync(LocationName, Schedule, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Schedule schedule = new Schedule();
            // Make the request
            Schedule response = await scheduleServiceClient.CreateScheduleAsync(parent, schedule);
            // End snippet
        }

        /// <summary>Snippet for DeleteSchedule</summary>
        public void DeleteScheduleRequestObject()
        {
            // Snippet: DeleteSchedule(DeleteScheduleRequest, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            DeleteScheduleRequest request = new DeleteScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = scheduleServiceClient.DeleteSchedule(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = scheduleServiceClient.PollOnceDeleteSchedule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScheduleAsync</summary>
        public async Task DeleteScheduleRequestObjectAsync()
        {
            // Snippet: DeleteScheduleAsync(DeleteScheduleRequest, CallSettings)
            // Additional: DeleteScheduleAsync(DeleteScheduleRequest, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteScheduleRequest request = new DeleteScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await scheduleServiceClient.DeleteScheduleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await scheduleServiceClient.PollOnceDeleteScheduleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSchedule</summary>
        public void DeleteSchedule()
        {
            // Snippet: DeleteSchedule(string, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = scheduleServiceClient.DeleteSchedule(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = scheduleServiceClient.PollOnceDeleteSchedule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScheduleAsync</summary>
        public async Task DeleteScheduleAsync()
        {
            // Snippet: DeleteScheduleAsync(string, CallSettings)
            // Additional: DeleteScheduleAsync(string, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await scheduleServiceClient.DeleteScheduleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await scheduleServiceClient.PollOnceDeleteScheduleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSchedule</summary>
        public void DeleteScheduleResourceNames()
        {
            // Snippet: DeleteSchedule(ScheduleName, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            ScheduleName name = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = scheduleServiceClient.DeleteSchedule(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = scheduleServiceClient.PollOnceDeleteSchedule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScheduleAsync</summary>
        public async Task DeleteScheduleResourceNamesAsync()
        {
            // Snippet: DeleteScheduleAsync(ScheduleName, CallSettings)
            // Additional: DeleteScheduleAsync(ScheduleName, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduleName name = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await scheduleServiceClient.DeleteScheduleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await scheduleServiceClient.PollOnceDeleteScheduleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetSchedule</summary>
        public void GetScheduleRequestObject()
        {
            // Snippet: GetSchedule(GetScheduleRequest, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            GetScheduleRequest request = new GetScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            Schedule response = scheduleServiceClient.GetSchedule(request);
            // End snippet
        }

        /// <summary>Snippet for GetScheduleAsync</summary>
        public async Task GetScheduleRequestObjectAsync()
        {
            // Snippet: GetScheduleAsync(GetScheduleRequest, CallSettings)
            // Additional: GetScheduleAsync(GetScheduleRequest, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetScheduleRequest request = new GetScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            Schedule response = await scheduleServiceClient.GetScheduleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSchedule</summary>
        public void GetSchedule()
        {
            // Snippet: GetSchedule(string, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            Schedule response = scheduleServiceClient.GetSchedule(name);
            // End snippet
        }

        /// <summary>Snippet for GetScheduleAsync</summary>
        public async Task GetScheduleAsync()
        {
            // Snippet: GetScheduleAsync(string, CallSettings)
            // Additional: GetScheduleAsync(string, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            Schedule response = await scheduleServiceClient.GetScheduleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSchedule</summary>
        public void GetScheduleResourceNames()
        {
            // Snippet: GetSchedule(ScheduleName, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            ScheduleName name = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            Schedule response = scheduleServiceClient.GetSchedule(name);
            // End snippet
        }

        /// <summary>Snippet for GetScheduleAsync</summary>
        public async Task GetScheduleResourceNamesAsync()
        {
            // Snippet: GetScheduleAsync(ScheduleName, CallSettings)
            // Additional: GetScheduleAsync(ScheduleName, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduleName name = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            Schedule response = await scheduleServiceClient.GetScheduleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSchedules</summary>
        public void ListSchedulesRequestObject()
        {
            // Snippet: ListSchedules(ListSchedulesRequest, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            ListSchedulesRequest request = new ListSchedulesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSchedulesResponse, Schedule> response = scheduleServiceClient.ListSchedules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schedule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchedulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schedule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schedule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchedulesAsync</summary>
        public async Task ListSchedulesRequestObjectAsync()
        {
            // Snippet: ListSchedulesAsync(ListSchedulesRequest, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSchedulesRequest request = new ListSchedulesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSchedulesResponse, Schedule> response = scheduleServiceClient.ListSchedulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schedule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchedulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schedule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schedule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchedules</summary>
        public void ListSchedules()
        {
            // Snippet: ListSchedules(string, string, int?, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSchedulesResponse, Schedule> response = scheduleServiceClient.ListSchedules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schedule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchedulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schedule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schedule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchedulesAsync</summary>
        public async Task ListSchedulesAsync()
        {
            // Snippet: ListSchedulesAsync(string, string, int?, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSchedulesResponse, Schedule> response = scheduleServiceClient.ListSchedulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schedule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchedulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schedule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schedule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchedules</summary>
        public void ListSchedulesResourceNames()
        {
            // Snippet: ListSchedules(LocationName, string, int?, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSchedulesResponse, Schedule> response = scheduleServiceClient.ListSchedules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schedule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchedulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schedule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schedule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchedulesAsync</summary>
        public async Task ListSchedulesResourceNamesAsync()
        {
            // Snippet: ListSchedulesAsync(LocationName, string, int?, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSchedulesResponse, Schedule> response = scheduleServiceClient.ListSchedulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schedule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchedulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schedule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schedule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for PauseSchedule</summary>
        public void PauseScheduleRequestObject()
        {
            // Snippet: PauseSchedule(PauseScheduleRequest, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            PauseScheduleRequest request = new PauseScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            scheduleServiceClient.PauseSchedule(request);
            // End snippet
        }

        /// <summary>Snippet for PauseScheduleAsync</summary>
        public async Task PauseScheduleRequestObjectAsync()
        {
            // Snippet: PauseScheduleAsync(PauseScheduleRequest, CallSettings)
            // Additional: PauseScheduleAsync(PauseScheduleRequest, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            PauseScheduleRequest request = new PauseScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            await scheduleServiceClient.PauseScheduleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PauseSchedule</summary>
        public void PauseSchedule()
        {
            // Snippet: PauseSchedule(string, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            scheduleServiceClient.PauseSchedule(name);
            // End snippet
        }

        /// <summary>Snippet for PauseScheduleAsync</summary>
        public async Task PauseScheduleAsync()
        {
            // Snippet: PauseScheduleAsync(string, CallSettings)
            // Additional: PauseScheduleAsync(string, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            await scheduleServiceClient.PauseScheduleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseSchedule</summary>
        public void PauseScheduleResourceNames()
        {
            // Snippet: PauseSchedule(ScheduleName, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            ScheduleName name = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            scheduleServiceClient.PauseSchedule(name);
            // End snippet
        }

        /// <summary>Snippet for PauseScheduleAsync</summary>
        public async Task PauseScheduleResourceNamesAsync()
        {
            // Snippet: PauseScheduleAsync(ScheduleName, CallSettings)
            // Additional: PauseScheduleAsync(ScheduleName, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduleName name = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            await scheduleServiceClient.PauseScheduleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeSchedule</summary>
        public void ResumeScheduleRequestObject()
        {
            // Snippet: ResumeSchedule(ResumeScheduleRequest, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            ResumeScheduleRequest request = new ResumeScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                CatchUp = false,
            };
            // Make the request
            scheduleServiceClient.ResumeSchedule(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeScheduleAsync</summary>
        public async Task ResumeScheduleRequestObjectAsync()
        {
            // Snippet: ResumeScheduleAsync(ResumeScheduleRequest, CallSettings)
            // Additional: ResumeScheduleAsync(ResumeScheduleRequest, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResumeScheduleRequest request = new ResumeScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                CatchUp = false,
            };
            // Make the request
            await scheduleServiceClient.ResumeScheduleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeSchedule</summary>
        public void ResumeSchedule1()
        {
            // Snippet: ResumeSchedule(string, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            scheduleServiceClient.ResumeSchedule(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeScheduleAsync</summary>
        public async Task ResumeSchedule1Async()
        {
            // Snippet: ResumeScheduleAsync(string, CallSettings)
            // Additional: ResumeScheduleAsync(string, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            await scheduleServiceClient.ResumeScheduleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeSchedule</summary>
        public void ResumeSchedule1ResourceNames()
        {
            // Snippet: ResumeSchedule(ScheduleName, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            ScheduleName name = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            scheduleServiceClient.ResumeSchedule(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeScheduleAsync</summary>
        public async Task ResumeSchedule1ResourceNamesAsync()
        {
            // Snippet: ResumeScheduleAsync(ScheduleName, CallSettings)
            // Additional: ResumeScheduleAsync(ScheduleName, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduleName name = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            await scheduleServiceClient.ResumeScheduleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeSchedule</summary>
        public void ResumeSchedule2()
        {
            // Snippet: ResumeSchedule(string, bool, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/schedules/[SCHEDULE]";
            bool catchUp = false;
            // Make the request
            scheduleServiceClient.ResumeSchedule(name, catchUp);
            // End snippet
        }

        /// <summary>Snippet for ResumeScheduleAsync</summary>
        public async Task ResumeSchedule2Async()
        {
            // Snippet: ResumeScheduleAsync(string, bool, CallSettings)
            // Additional: ResumeScheduleAsync(string, bool, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/schedules/[SCHEDULE]";
            bool catchUp = false;
            // Make the request
            await scheduleServiceClient.ResumeScheduleAsync(name, catchUp);
            // End snippet
        }

        /// <summary>Snippet for ResumeSchedule</summary>
        public void ResumeSchedule2ResourceNames()
        {
            // Snippet: ResumeSchedule(ScheduleName, bool, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            ScheduleName name = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            bool catchUp = false;
            // Make the request
            scheduleServiceClient.ResumeSchedule(name, catchUp);
            // End snippet
        }

        /// <summary>Snippet for ResumeScheduleAsync</summary>
        public async Task ResumeSchedule2ResourceNamesAsync()
        {
            // Snippet: ResumeScheduleAsync(ScheduleName, bool, CallSettings)
            // Additional: ResumeScheduleAsync(ScheduleName, bool, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduleName name = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            bool catchUp = false;
            // Make the request
            await scheduleServiceClient.ResumeScheduleAsync(name, catchUp);
            // End snippet
        }

        /// <summary>Snippet for UpdateSchedule</summary>
        public void UpdateScheduleRequestObject()
        {
            // Snippet: UpdateSchedule(UpdateScheduleRequest, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            UpdateScheduleRequest request = new UpdateScheduleRequest
            {
                Schedule = new Schedule(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Schedule response = scheduleServiceClient.UpdateSchedule(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateScheduleAsync</summary>
        public async Task UpdateScheduleRequestObjectAsync()
        {
            // Snippet: UpdateScheduleAsync(UpdateScheduleRequest, CallSettings)
            // Additional: UpdateScheduleAsync(UpdateScheduleRequest, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateScheduleRequest request = new UpdateScheduleRequest
            {
                Schedule = new Schedule(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Schedule response = await scheduleServiceClient.UpdateScheduleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSchedule</summary>
        public void UpdateSchedule()
        {
            // Snippet: UpdateSchedule(Schedule, FieldMask, CallSettings)
            // Create client
            ScheduleServiceClient scheduleServiceClient = ScheduleServiceClient.Create();
            // Initialize request argument(s)
            Schedule schedule = new Schedule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Schedule response = scheduleServiceClient.UpdateSchedule(schedule, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateScheduleAsync</summary>
        public async Task UpdateScheduleAsync()
        {
            // Snippet: UpdateScheduleAsync(Schedule, FieldMask, CallSettings)
            // Additional: UpdateScheduleAsync(Schedule, FieldMask, CancellationToken)
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            Schedule schedule = new Schedule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Schedule response = await scheduleServiceClient.UpdateScheduleAsync(schedule, updateMask);
            // End snippet
        }
    }
}
