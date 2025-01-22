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
    using Google.Geo.Type;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gmfdv = Google.Maps.FleetEngine.Delivery.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDeliveryServiceClientSnippets
    {
        /// <summary>Snippet for CreateDeliveryVehicle</summary>
        public void CreateDeliveryVehicleRequestObject()
        {
            // Snippet: CreateDeliveryVehicle(CreateDeliveryVehicleRequest, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::CreateDeliveryVehicleRequest request = new gmfdv::CreateDeliveryVehicleRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                Parent = "",
                DeliveryVehicleId = "",
                DeliveryVehicle = new gmfdv::DeliveryVehicle(),
            };
            // Make the request
            gmfdv::DeliveryVehicle response = deliveryServiceClient.CreateDeliveryVehicle(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeliveryVehicleAsync</summary>
        public async Task CreateDeliveryVehicleRequestObjectAsync()
        {
            // Snippet: CreateDeliveryVehicleAsync(CreateDeliveryVehicleRequest, CallSettings)
            // Additional: CreateDeliveryVehicleAsync(CreateDeliveryVehicleRequest, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::CreateDeliveryVehicleRequest request = new gmfdv::CreateDeliveryVehicleRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                Parent = "",
                DeliveryVehicleId = "",
                DeliveryVehicle = new gmfdv::DeliveryVehicle(),
            };
            // Make the request
            gmfdv::DeliveryVehicle response = await deliveryServiceClient.CreateDeliveryVehicleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeliveryVehicle</summary>
        public void CreateDeliveryVehicle()
        {
            // Snippet: CreateDeliveryVehicle(string, DeliveryVehicle, string, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            gmfdv::DeliveryVehicle deliveryVehicle = new gmfdv::DeliveryVehicle();
            string deliveryVehicleId = "";
            // Make the request
            gmfdv::DeliveryVehicle response = deliveryServiceClient.CreateDeliveryVehicle(parent, deliveryVehicle, deliveryVehicleId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeliveryVehicleAsync</summary>
        public async Task CreateDeliveryVehicleAsync()
        {
            // Snippet: CreateDeliveryVehicleAsync(string, DeliveryVehicle, string, CallSettings)
            // Additional: CreateDeliveryVehicleAsync(string, DeliveryVehicle, string, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            gmfdv::DeliveryVehicle deliveryVehicle = new gmfdv::DeliveryVehicle();
            string deliveryVehicleId = "";
            // Make the request
            gmfdv::DeliveryVehicle response = await deliveryServiceClient.CreateDeliveryVehicleAsync(parent, deliveryVehicle, deliveryVehicleId);
            // End snippet
        }

        /// <summary>Snippet for GetDeliveryVehicle</summary>
        public void GetDeliveryVehicleRequestObject()
        {
            // Snippet: GetDeliveryVehicle(GetDeliveryVehicleRequest, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::GetDeliveryVehicleRequest request = new gmfdv::GetDeliveryVehicleRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                DeliveryVehicleName = gmfdv::DeliveryVehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]"),
            };
            // Make the request
            gmfdv::DeliveryVehicle response = deliveryServiceClient.GetDeliveryVehicle(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeliveryVehicleAsync</summary>
        public async Task GetDeliveryVehicleRequestObjectAsync()
        {
            // Snippet: GetDeliveryVehicleAsync(GetDeliveryVehicleRequest, CallSettings)
            // Additional: GetDeliveryVehicleAsync(GetDeliveryVehicleRequest, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::GetDeliveryVehicleRequest request = new gmfdv::GetDeliveryVehicleRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                DeliveryVehicleName = gmfdv::DeliveryVehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]"),
            };
            // Make the request
            gmfdv::DeliveryVehicle response = await deliveryServiceClient.GetDeliveryVehicleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeliveryVehicle</summary>
        public void GetDeliveryVehicle()
        {
            // Snippet: GetDeliveryVehicle(string, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            string name = "providers/[PROVIDER]/deliveryVehicles/[VEHICLE]";
            // Make the request
            gmfdv::DeliveryVehicle response = deliveryServiceClient.GetDeliveryVehicle(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeliveryVehicleAsync</summary>
        public async Task GetDeliveryVehicleAsync()
        {
            // Snippet: GetDeliveryVehicleAsync(string, CallSettings)
            // Additional: GetDeliveryVehicleAsync(string, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "providers/[PROVIDER]/deliveryVehicles/[VEHICLE]";
            // Make the request
            gmfdv::DeliveryVehicle response = await deliveryServiceClient.GetDeliveryVehicleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeliveryVehicle</summary>
        public void GetDeliveryVehicleResourceNames()
        {
            // Snippet: GetDeliveryVehicle(DeliveryVehicleName, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::DeliveryVehicleName name = gmfdv::DeliveryVehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]");
            // Make the request
            gmfdv::DeliveryVehicle response = deliveryServiceClient.GetDeliveryVehicle(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeliveryVehicleAsync</summary>
        public async Task GetDeliveryVehicleResourceNamesAsync()
        {
            // Snippet: GetDeliveryVehicleAsync(DeliveryVehicleName, CallSettings)
            // Additional: GetDeliveryVehicleAsync(DeliveryVehicleName, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::DeliveryVehicleName name = gmfdv::DeliveryVehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]");
            // Make the request
            gmfdv::DeliveryVehicle response = await deliveryServiceClient.GetDeliveryVehicleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeliveryVehicle</summary>
        public void UpdateDeliveryVehicleRequestObject()
        {
            // Snippet: UpdateDeliveryVehicle(UpdateDeliveryVehicleRequest, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::UpdateDeliveryVehicleRequest request = new gmfdv::UpdateDeliveryVehicleRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                DeliveryVehicle = new gmfdv::DeliveryVehicle(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gmfdv::DeliveryVehicle response = deliveryServiceClient.UpdateDeliveryVehicle(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeliveryVehicleAsync</summary>
        public async Task UpdateDeliveryVehicleRequestObjectAsync()
        {
            // Snippet: UpdateDeliveryVehicleAsync(UpdateDeliveryVehicleRequest, CallSettings)
            // Additional: UpdateDeliveryVehicleAsync(UpdateDeliveryVehicleRequest, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::UpdateDeliveryVehicleRequest request = new gmfdv::UpdateDeliveryVehicleRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                DeliveryVehicle = new gmfdv::DeliveryVehicle(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gmfdv::DeliveryVehicle response = await deliveryServiceClient.UpdateDeliveryVehicleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeliveryVehicle</summary>
        public void UpdateDeliveryVehicle()
        {
            // Snippet: UpdateDeliveryVehicle(DeliveryVehicle, FieldMask, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::DeliveryVehicle deliveryVehicle = new gmfdv::DeliveryVehicle();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gmfdv::DeliveryVehicle response = deliveryServiceClient.UpdateDeliveryVehicle(deliveryVehicle, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeliveryVehicleAsync</summary>
        public async Task UpdateDeliveryVehicleAsync()
        {
            // Snippet: UpdateDeliveryVehicleAsync(DeliveryVehicle, FieldMask, CallSettings)
            // Additional: UpdateDeliveryVehicleAsync(DeliveryVehicle, FieldMask, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::DeliveryVehicle deliveryVehicle = new gmfdv::DeliveryVehicle();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gmfdv::DeliveryVehicle response = await deliveryServiceClient.UpdateDeliveryVehicleAsync(deliveryVehicle, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTasks</summary>
        public void BatchCreateTasksRequestObject()
        {
            // Snippet: BatchCreateTasks(BatchCreateTasksRequest, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::BatchCreateTasksRequest request = new gmfdv::BatchCreateTasksRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                ParentAsProviderName = gmfdv::ProviderName.FromProvider("[PROVIDER]"),
                Requests =
                {
                    new gmfdv::CreateTaskRequest(),
                },
            };
            // Make the request
            gmfdv::BatchCreateTasksResponse response = deliveryServiceClient.BatchCreateTasks(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTasksAsync</summary>
        public async Task BatchCreateTasksRequestObjectAsync()
        {
            // Snippet: BatchCreateTasksAsync(BatchCreateTasksRequest, CallSettings)
            // Additional: BatchCreateTasksAsync(BatchCreateTasksRequest, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::BatchCreateTasksRequest request = new gmfdv::BatchCreateTasksRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                ParentAsProviderName = gmfdv::ProviderName.FromProvider("[PROVIDER]"),
                Requests =
                {
                    new gmfdv::CreateTaskRequest(),
                },
            };
            // Make the request
            gmfdv::BatchCreateTasksResponse response = await deliveryServiceClient.BatchCreateTasksAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTaskRequestObject()
        {
            // Snippet: CreateTask(CreateTaskRequest, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::CreateTaskRequest request = new gmfdv::CreateTaskRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                Parent = "",
                Task = new gmfdv::Task(),
                TaskId = "",
            };
            // Make the request
            gmfdv::Task response = deliveryServiceClient.CreateTask(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskRequestObjectAsync()
        {
            // Snippet: CreateTaskAsync(CreateTaskRequest, CallSettings)
            // Additional: CreateTaskAsync(CreateTaskRequest, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::CreateTaskRequest request = new gmfdv::CreateTaskRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                Parent = "",
                Task = new gmfdv::Task(),
                TaskId = "",
            };
            // Make the request
            gmfdv::Task response = await deliveryServiceClient.CreateTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTask()
        {
            // Snippet: CreateTask(string, Task, string, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            gmfdv::Task task = new gmfdv::Task();
            string taskId = "";
            // Make the request
            gmfdv::Task response = deliveryServiceClient.CreateTask(parent, task, taskId);
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskAsync()
        {
            // Snippet: CreateTaskAsync(string, Task, string, CallSettings)
            // Additional: CreateTaskAsync(string, Task, string, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            gmfdv::Task task = new gmfdv::Task();
            string taskId = "";
            // Make the request
            gmfdv::Task response = await deliveryServiceClient.CreateTaskAsync(parent, task, taskId);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTaskRequestObject()
        {
            // Snippet: GetTask(GetTaskRequest, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::GetTaskRequest request = new gmfdv::GetTaskRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                TaskName = gmfdv::TaskName.FromProviderTask("[PROVIDER]", "[TASK]"),
            };
            // Make the request
            gmfdv::Task response = deliveryServiceClient.GetTask(request);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskRequestObjectAsync()
        {
            // Snippet: GetTaskAsync(GetTaskRequest, CallSettings)
            // Additional: GetTaskAsync(GetTaskRequest, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::GetTaskRequest request = new gmfdv::GetTaskRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                TaskName = gmfdv::TaskName.FromProviderTask("[PROVIDER]", "[TASK]"),
            };
            // Make the request
            gmfdv::Task response = await deliveryServiceClient.GetTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTask()
        {
            // Snippet: GetTask(string, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            string name = "providers/[PROVIDER]/tasks/[TASK]";
            // Make the request
            gmfdv::Task response = deliveryServiceClient.GetTask(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskAsync()
        {
            // Snippet: GetTaskAsync(string, CallSettings)
            // Additional: GetTaskAsync(string, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "providers/[PROVIDER]/tasks/[TASK]";
            // Make the request
            gmfdv::Task response = await deliveryServiceClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTaskResourceNames()
        {
            // Snippet: GetTask(TaskName, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::TaskName name = gmfdv::TaskName.FromProviderTask("[PROVIDER]", "[TASK]");
            // Make the request
            gmfdv::Task response = deliveryServiceClient.GetTask(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskResourceNamesAsync()
        {
            // Snippet: GetTaskAsync(TaskName, CallSettings)
            // Additional: GetTaskAsync(TaskName, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::TaskName name = gmfdv::TaskName.FromProviderTask("[PROVIDER]", "[TASK]");
            // Make the request
            gmfdv::Task response = await deliveryServiceClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateTask</summary>
        public void UpdateTaskRequestObject()
        {
            // Snippet: UpdateTask(UpdateTaskRequest, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::UpdateTaskRequest request = new gmfdv::UpdateTaskRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                Task = new gmfdv::Task(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gmfdv::Task response = deliveryServiceClient.UpdateTask(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTaskAsync</summary>
        public async Task UpdateTaskRequestObjectAsync()
        {
            // Snippet: UpdateTaskAsync(UpdateTaskRequest, CallSettings)
            // Additional: UpdateTaskAsync(UpdateTaskRequest, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::UpdateTaskRequest request = new gmfdv::UpdateTaskRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                Task = new gmfdv::Task(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gmfdv::Task response = await deliveryServiceClient.UpdateTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTask</summary>
        public void UpdateTask()
        {
            // Snippet: UpdateTask(Task, FieldMask, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::Task task = new gmfdv::Task();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gmfdv::Task response = deliveryServiceClient.UpdateTask(task, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTaskAsync</summary>
        public async Task UpdateTaskAsync()
        {
            // Snippet: UpdateTaskAsync(Task, FieldMask, CallSettings)
            // Additional: UpdateTaskAsync(Task, FieldMask, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::Task task = new gmfdv::Task();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gmfdv::Task response = await deliveryServiceClient.UpdateTaskAsync(task, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasksRequestObject()
        {
            // Snippet: ListTasks(ListTasksRequest, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::ListTasksRequest request = new gmfdv::ListTasksRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                ParentAsProviderName = gmfdv::ProviderName.FromProvider("[PROVIDER]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gmfdv::ListTasksResponse, gmfdv::Task> response = deliveryServiceClient.ListTasks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gmfdv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gmfdv::ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gmfdv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gmfdv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gmfdv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksRequestObjectAsync()
        {
            // Snippet: ListTasksAsync(ListTasksRequest, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::ListTasksRequest request = new gmfdv::ListTasksRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                ParentAsProviderName = gmfdv::ProviderName.FromProvider("[PROVIDER]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gmfdv::ListTasksResponse, gmfdv::Task> response = deliveryServiceClient.ListTasksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gmfdv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gmfdv::ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gmfdv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gmfdv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gmfdv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasks()
        {
            // Snippet: ListTasks(string, string, int?, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "providers/[PROVIDER]";
            // Make the request
            PagedEnumerable<gmfdv::ListTasksResponse, gmfdv::Task> response = deliveryServiceClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gmfdv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gmfdv::ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gmfdv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gmfdv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gmfdv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksAsync()
        {
            // Snippet: ListTasksAsync(string, string, int?, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "providers/[PROVIDER]";
            // Make the request
            PagedAsyncEnumerable<gmfdv::ListTasksResponse, gmfdv::Task> response = deliveryServiceClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gmfdv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gmfdv::ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gmfdv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gmfdv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gmfdv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasksResourceNames()
        {
            // Snippet: ListTasks(ProviderName, string, int?, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::ProviderName parent = gmfdv::ProviderName.FromProvider("[PROVIDER]");
            // Make the request
            PagedEnumerable<gmfdv::ListTasksResponse, gmfdv::Task> response = deliveryServiceClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gmfdv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gmfdv::ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gmfdv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gmfdv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gmfdv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksResourceNamesAsync()
        {
            // Snippet: ListTasksAsync(ProviderName, string, int?, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::ProviderName parent = gmfdv::ProviderName.FromProvider("[PROVIDER]");
            // Make the request
            PagedAsyncEnumerable<gmfdv::ListTasksResponse, gmfdv::Task> response = deliveryServiceClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gmfdv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gmfdv::ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gmfdv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gmfdv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gmfdv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTaskTrackingInfo</summary>
        public void GetTaskTrackingInfoRequestObject()
        {
            // Snippet: GetTaskTrackingInfo(GetTaskTrackingInfoRequest, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::GetTaskTrackingInfoRequest request = new gmfdv::GetTaskTrackingInfoRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                TaskTrackingInfoName = gmfdv::TaskTrackingInfoName.FromProviderTracking("[PROVIDER]", "[TRACKING]"),
            };
            // Make the request
            gmfdv::TaskTrackingInfo response = deliveryServiceClient.GetTaskTrackingInfo(request);
            // End snippet
        }

        /// <summary>Snippet for GetTaskTrackingInfoAsync</summary>
        public async Task GetTaskTrackingInfoRequestObjectAsync()
        {
            // Snippet: GetTaskTrackingInfoAsync(GetTaskTrackingInfoRequest, CallSettings)
            // Additional: GetTaskTrackingInfoAsync(GetTaskTrackingInfoRequest, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::GetTaskTrackingInfoRequest request = new gmfdv::GetTaskTrackingInfoRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                TaskTrackingInfoName = gmfdv::TaskTrackingInfoName.FromProviderTracking("[PROVIDER]", "[TRACKING]"),
            };
            // Make the request
            gmfdv::TaskTrackingInfo response = await deliveryServiceClient.GetTaskTrackingInfoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTaskTrackingInfo</summary>
        public void GetTaskTrackingInfo()
        {
            // Snippet: GetTaskTrackingInfo(string, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            string name = "providers/[PROVIDER]/taskTrackingInfo/[TRACKING]";
            // Make the request
            gmfdv::TaskTrackingInfo response = deliveryServiceClient.GetTaskTrackingInfo(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskTrackingInfoAsync</summary>
        public async Task GetTaskTrackingInfoAsync()
        {
            // Snippet: GetTaskTrackingInfoAsync(string, CallSettings)
            // Additional: GetTaskTrackingInfoAsync(string, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "providers/[PROVIDER]/taskTrackingInfo/[TRACKING]";
            // Make the request
            gmfdv::TaskTrackingInfo response = await deliveryServiceClient.GetTaskTrackingInfoAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskTrackingInfo</summary>
        public void GetTaskTrackingInfoResourceNames()
        {
            // Snippet: GetTaskTrackingInfo(TaskTrackingInfoName, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::TaskTrackingInfoName name = gmfdv::TaskTrackingInfoName.FromProviderTracking("[PROVIDER]", "[TRACKING]");
            // Make the request
            gmfdv::TaskTrackingInfo response = deliveryServiceClient.GetTaskTrackingInfo(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskTrackingInfoAsync</summary>
        public async Task GetTaskTrackingInfoResourceNamesAsync()
        {
            // Snippet: GetTaskTrackingInfoAsync(TaskTrackingInfoName, CallSettings)
            // Additional: GetTaskTrackingInfoAsync(TaskTrackingInfoName, CancellationToken)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::TaskTrackingInfoName name = gmfdv::TaskTrackingInfoName.FromProviderTracking("[PROVIDER]", "[TRACKING]");
            // Make the request
            gmfdv::TaskTrackingInfo response = await deliveryServiceClient.GetTaskTrackingInfoAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeliveryVehicles</summary>
        public void ListDeliveryVehiclesRequestObject()
        {
            // Snippet: ListDeliveryVehicles(ListDeliveryVehiclesRequest, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::ListDeliveryVehiclesRequest request = new gmfdv::ListDeliveryVehiclesRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                ParentAsProviderName = gmfdv::ProviderName.FromProvider("[PROVIDER]"),
                Filter = "",
                Viewport = new Viewport(),
            };
            // Make the request
            PagedEnumerable<gmfdv::ListDeliveryVehiclesResponse, gmfdv::DeliveryVehicle> response = deliveryServiceClient.ListDeliveryVehicles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gmfdv::DeliveryVehicle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gmfdv::ListDeliveryVehiclesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gmfdv::DeliveryVehicle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gmfdv::DeliveryVehicle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gmfdv::DeliveryVehicle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeliveryVehiclesAsync</summary>
        public async Task ListDeliveryVehiclesRequestObjectAsync()
        {
            // Snippet: ListDeliveryVehiclesAsync(ListDeliveryVehiclesRequest, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::ListDeliveryVehiclesRequest request = new gmfdv::ListDeliveryVehiclesRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                ParentAsProviderName = gmfdv::ProviderName.FromProvider("[PROVIDER]"),
                Filter = "",
                Viewport = new Viewport(),
            };
            // Make the request
            PagedAsyncEnumerable<gmfdv::ListDeliveryVehiclesResponse, gmfdv::DeliveryVehicle> response = deliveryServiceClient.ListDeliveryVehiclesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gmfdv::DeliveryVehicle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gmfdv::ListDeliveryVehiclesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gmfdv::DeliveryVehicle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gmfdv::DeliveryVehicle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gmfdv::DeliveryVehicle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeliveryVehicles</summary>
        public void ListDeliveryVehicles()
        {
            // Snippet: ListDeliveryVehicles(string, string, int?, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "providers/[PROVIDER]";
            // Make the request
            PagedEnumerable<gmfdv::ListDeliveryVehiclesResponse, gmfdv::DeliveryVehicle> response = deliveryServiceClient.ListDeliveryVehicles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gmfdv::DeliveryVehicle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gmfdv::ListDeliveryVehiclesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gmfdv::DeliveryVehicle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gmfdv::DeliveryVehicle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gmfdv::DeliveryVehicle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeliveryVehiclesAsync</summary>
        public async Task ListDeliveryVehiclesAsync()
        {
            // Snippet: ListDeliveryVehiclesAsync(string, string, int?, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "providers/[PROVIDER]";
            // Make the request
            PagedAsyncEnumerable<gmfdv::ListDeliveryVehiclesResponse, gmfdv::DeliveryVehicle> response = deliveryServiceClient.ListDeliveryVehiclesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gmfdv::DeliveryVehicle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gmfdv::ListDeliveryVehiclesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gmfdv::DeliveryVehicle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gmfdv::DeliveryVehicle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gmfdv::DeliveryVehicle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeliveryVehicles</summary>
        public void ListDeliveryVehiclesResourceNames()
        {
            // Snippet: ListDeliveryVehicles(ProviderName, string, int?, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = gmfdv::DeliveryServiceClient.Create();
            // Initialize request argument(s)
            gmfdv::ProviderName parent = gmfdv::ProviderName.FromProvider("[PROVIDER]");
            // Make the request
            PagedEnumerable<gmfdv::ListDeliveryVehiclesResponse, gmfdv::DeliveryVehicle> response = deliveryServiceClient.ListDeliveryVehicles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gmfdv::DeliveryVehicle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gmfdv::ListDeliveryVehiclesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gmfdv::DeliveryVehicle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gmfdv::DeliveryVehicle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gmfdv::DeliveryVehicle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeliveryVehiclesAsync</summary>
        public async Task ListDeliveryVehiclesResourceNamesAsync()
        {
            // Snippet: ListDeliveryVehiclesAsync(ProviderName, string, int?, CallSettings)
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::ProviderName parent = gmfdv::ProviderName.FromProvider("[PROVIDER]");
            // Make the request
            PagedAsyncEnumerable<gmfdv::ListDeliveryVehiclesResponse, gmfdv::DeliveryVehicle> response = deliveryServiceClient.ListDeliveryVehiclesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gmfdv::DeliveryVehicle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gmfdv::ListDeliveryVehiclesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gmfdv::DeliveryVehicle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gmfdv::DeliveryVehicle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gmfdv::DeliveryVehicle item in singlePage)
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
