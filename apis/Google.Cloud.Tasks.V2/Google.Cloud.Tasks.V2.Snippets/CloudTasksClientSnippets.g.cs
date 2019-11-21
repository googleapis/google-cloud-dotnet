// Copyright 2019 Google LLC
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

namespace Google.Cloud.Tasks.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using gctv = Google.Cloud.Tasks.V2;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCloudTasksClientSnippets
    {
        /// <summary>Snippet for ListQueues</summary>
        public void ListQueues_RequestObject()
        {
            // Snippet: ListQueues(ListQueuesRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            ListQueuesRequest request = new ListQueuesRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListQueuesResponse, Queue> response = cloudTasksClient.ListQueues(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Queue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQueuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Queue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueues</summary>
        public async Task ListQueuesAsync_RequestObject()
        {
            // Snippet: ListQueuesAsync(ListQueuesRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            ListQueuesRequest request = new ListQueuesRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListQueuesResponse, Queue> response = cloudTasksClient.ListQueuesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Queue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQueuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Queue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueues</summary>
        public void ListQueues()
        {
            // Snippet: ListQueues(string, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListQueuesResponse, Queue> response = cloudTasksClient.ListQueues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Queue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQueuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Queue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueues</summary>
        public async Task ListQueuesAsync()
        {
            // Snippet: ListQueuesAsync(string, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListQueuesResponse, Queue> response = cloudTasksClient.ListQueuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Queue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQueuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Queue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueues</summary>
        public void ListQueues_ResourceNames()
        {
            // Snippet: ListQueues(LocationName, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListQueuesResponse, Queue> response = cloudTasksClient.ListQueues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Queue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQueuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Queue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueues</summary>
        public async Task ListQueuesAsync_ResourceNames()
        {
            // Snippet: ListQueuesAsync(LocationName, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListQueuesResponse, Queue> response = cloudTasksClient.ListQueuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Queue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQueuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Queue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetQueue</summary>
        public void GetQueue_RequestObject()
        {
            // Snippet: GetQueue(GetQueueRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            Queue response = cloudTasksClient.GetQueue(request);
            // End snippet
        }

        /// <summary>Snippet for GetQueueAsync</summary>
        public async Task GetQueueAsync_RequestObject()
        {
            // Snippet: GetQueueAsync(GetQueueRequest, CallSettings)
            // Additional: GetQueueAsync(GetQueueRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            Queue response = await cloudTasksClient.GetQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetQueue</summary>
        public void GetQueue()
        {
            // Snippet: GetQueue(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = cloudTasksClient.GetQueue(name);
            // End snippet
        }

        /// <summary>Snippet for GetQueueAsync</summary>
        public async Task GetQueueAsync()
        {
            // Snippet: GetQueueAsync(string, CallSettings)
            // Additional: GetQueueAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = await cloudTasksClient.GetQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetQueue</summary>
        public void GetQueue_ResourceNames()
        {
            // Snippet: GetQueue(QueueName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = cloudTasksClient.GetQueue(name);
            // End snippet
        }

        /// <summary>Snippet for GetQueueAsync</summary>
        public async Task GetQueueAsync_ResourceNames()
        {
            // Snippet: GetQueueAsync(QueueName, CallSettings)
            // Additional: GetQueueAsync(QueueName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = await cloudTasksClient.GetQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateQueue</summary>
        public void CreateQueue_RequestObject()
        {
            // Snippet: CreateQueue(CreateQueueRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Queue = new Queue(),
            };
            // Make the request
            Queue response = cloudTasksClient.CreateQueue(request);
            // End snippet
        }

        /// <summary>Snippet for CreateQueueAsync</summary>
        public async Task CreateQueueAsync_RequestObject()
        {
            // Snippet: CreateQueueAsync(CreateQueueRequest, CallSettings)
            // Additional: CreateQueueAsync(CreateQueueRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Queue = new Queue(),
            };
            // Make the request
            Queue response = await cloudTasksClient.CreateQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateQueue</summary>
        public void CreateQueue()
        {
            // Snippet: CreateQueue(string, Queue, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Queue queue = new Queue();
            // Make the request
            Queue response = cloudTasksClient.CreateQueue(parent, queue);
            // End snippet
        }

        /// <summary>Snippet for CreateQueueAsync</summary>
        public async Task CreateQueueAsync()
        {
            // Snippet: CreateQueueAsync(string, Queue, CallSettings)
            // Additional: CreateQueueAsync(string, Queue, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Queue queue = new Queue();
            // Make the request
            Queue response = await cloudTasksClient.CreateQueueAsync(parent, queue);
            // End snippet
        }

        /// <summary>Snippet for CreateQueue</summary>
        public void CreateQueue_ResourceNames()
        {
            // Snippet: CreateQueue(LocationName, Queue, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            Queue queue = new Queue();
            // Make the request
            Queue response = cloudTasksClient.CreateQueue(parent, queue);
            // End snippet
        }

        /// <summary>Snippet for CreateQueueAsync</summary>
        public async Task CreateQueueAsync_ResourceNames()
        {
            // Snippet: CreateQueueAsync(LocationName, Queue, CallSettings)
            // Additional: CreateQueueAsync(LocationName, Queue, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            Queue queue = new Queue();
            // Make the request
            Queue response = await cloudTasksClient.CreateQueueAsync(parent, queue);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueue</summary>
        public void UpdateQueue_RequestObject()
        {
            // Snippet: UpdateQueue(UpdateQueueRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new Queue(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Queue response = cloudTasksClient.UpdateQueue(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueueAsync</summary>
        public async Task UpdateQueueAsync_RequestObject()
        {
            // Snippet: UpdateQueueAsync(UpdateQueueRequest, CallSettings)
            // Additional: UpdateQueueAsync(UpdateQueueRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new Queue(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Queue response = await cloudTasksClient.UpdateQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueue</summary>
        public void UpdateQueue()
        {
            // Snippet: UpdateQueue(Queue, FieldMask, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            Queue queue = new Queue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Queue response = cloudTasksClient.UpdateQueue(queue, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueueAsync</summary>
        public async Task UpdateQueueAsync()
        {
            // Snippet: UpdateQueueAsync(Queue, FieldMask, CallSettings)
            // Additional: UpdateQueueAsync(Queue, FieldMask, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            Queue queue = new Queue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Queue response = await cloudTasksClient.UpdateQueueAsync(queue, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueue</summary>
        public void DeleteQueue_RequestObject()
        {
            // Snippet: DeleteQueue(DeleteQueueRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            cloudTasksClient.DeleteQueue(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueueAsync</summary>
        public async Task DeleteQueueAsync_RequestObject()
        {
            // Snippet: DeleteQueueAsync(DeleteQueueRequest, CallSettings)
            // Additional: DeleteQueueAsync(DeleteQueueRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            await cloudTasksClient.DeleteQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueue</summary>
        public void DeleteQueue()
        {
            // Snippet: DeleteQueue(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            cloudTasksClient.DeleteQueue(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueueAsync</summary>
        public async Task DeleteQueueAsync()
        {
            // Snippet: DeleteQueueAsync(string, CallSettings)
            // Additional: DeleteQueueAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            await cloudTasksClient.DeleteQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueue</summary>
        public void DeleteQueue_ResourceNames()
        {
            // Snippet: DeleteQueue(QueueName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            cloudTasksClient.DeleteQueue(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueueAsync</summary>
        public async Task DeleteQueueAsync_ResourceNames()
        {
            // Snippet: DeleteQueueAsync(QueueName, CallSettings)
            // Additional: DeleteQueueAsync(QueueName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            await cloudTasksClient.DeleteQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueue</summary>
        public void PurgeQueue_RequestObject()
        {
            // Snippet: PurgeQueue(PurgeQueueRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            Queue response = cloudTasksClient.PurgeQueue(request);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueueAsync</summary>
        public async Task PurgeQueueAsync_RequestObject()
        {
            // Snippet: PurgeQueueAsync(PurgeQueueRequest, CallSettings)
            // Additional: PurgeQueueAsync(PurgeQueueRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            Queue response = await cloudTasksClient.PurgeQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueue</summary>
        public void PurgeQueue()
        {
            // Snippet: PurgeQueue(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = cloudTasksClient.PurgeQueue(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueueAsync</summary>
        public async Task PurgeQueueAsync()
        {
            // Snippet: PurgeQueueAsync(string, CallSettings)
            // Additional: PurgeQueueAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = await cloudTasksClient.PurgeQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueue</summary>
        public void PurgeQueue_ResourceNames()
        {
            // Snippet: PurgeQueue(QueueName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = cloudTasksClient.PurgeQueue(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueueAsync</summary>
        public async Task PurgeQueueAsync_ResourceNames()
        {
            // Snippet: PurgeQueueAsync(QueueName, CallSettings)
            // Additional: PurgeQueueAsync(QueueName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = await cloudTasksClient.PurgeQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseQueue</summary>
        public void PauseQueue_RequestObject()
        {
            // Snippet: PauseQueue(PauseQueueRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            Queue response = cloudTasksClient.PauseQueue(request);
            // End snippet
        }

        /// <summary>Snippet for PauseQueueAsync</summary>
        public async Task PauseQueueAsync_RequestObject()
        {
            // Snippet: PauseQueueAsync(PauseQueueRequest, CallSettings)
            // Additional: PauseQueueAsync(PauseQueueRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            Queue response = await cloudTasksClient.PauseQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PauseQueue</summary>
        public void PauseQueue()
        {
            // Snippet: PauseQueue(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = cloudTasksClient.PauseQueue(name);
            // End snippet
        }

        /// <summary>Snippet for PauseQueueAsync</summary>
        public async Task PauseQueueAsync()
        {
            // Snippet: PauseQueueAsync(string, CallSettings)
            // Additional: PauseQueueAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = await cloudTasksClient.PauseQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseQueue</summary>
        public void PauseQueue_ResourceNames()
        {
            // Snippet: PauseQueue(QueueName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = cloudTasksClient.PauseQueue(name);
            // End snippet
        }

        /// <summary>Snippet for PauseQueueAsync</summary>
        public async Task PauseQueueAsync_ResourceNames()
        {
            // Snippet: PauseQueueAsync(QueueName, CallSettings)
            // Additional: PauseQueueAsync(QueueName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = await cloudTasksClient.PauseQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueue</summary>
        public void ResumeQueue_RequestObject()
        {
            // Snippet: ResumeQueue(ResumeQueueRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            Queue response = cloudTasksClient.ResumeQueue(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueueAsync</summary>
        public async Task ResumeQueueAsync_RequestObject()
        {
            // Snippet: ResumeQueueAsync(ResumeQueueRequest, CallSettings)
            // Additional: ResumeQueueAsync(ResumeQueueRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            Queue response = await cloudTasksClient.ResumeQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueue</summary>
        public void ResumeQueue()
        {
            // Snippet: ResumeQueue(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = cloudTasksClient.ResumeQueue(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueueAsync</summary>
        public async Task ResumeQueueAsync()
        {
            // Snippet: ResumeQueueAsync(string, CallSettings)
            // Additional: ResumeQueueAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = await cloudTasksClient.ResumeQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueue</summary>
        public void ResumeQueue_ResourceNames()
        {
            // Snippet: ResumeQueue(QueueName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = cloudTasksClient.ResumeQueue(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueueAsync</summary>
        public async Task ResumeQueueAsync_ResourceNames()
        {
            // Snippet: ResumeQueueAsync(QueueName, CallSettings)
            // Additional: ResumeQueueAsync(QueueName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = await cloudTasksClient.ResumeQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = cloudTasksClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await cloudTasksClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = cloudTasksClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await cloudTasksClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_ResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnknownResourceName("a/wildcard/resource");
            // Make the request
            Policy response = cloudTasksClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_ResourceNames()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnknownResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await cloudTasksClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = cloudTasksClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await cloudTasksClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = cloudTasksClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await cloudTasksClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_ResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnknownResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = cloudTasksClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_ResourceNames()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnknownResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await cloudTasksClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = cloudTasksClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await cloudTasksClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = cloudTasksClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await cloudTasksClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_ResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnknownResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = cloudTasksClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_ResourceNames()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnknownResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await cloudTasksClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasks_RequestObject()
        {
            // Snippet: ListTasks(ListTasksRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsQueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gctv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public async Task ListTasksAsync_RequestObject()
        {
            // Snippet: ListTasksAsync(ListTasksRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsQueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gctv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Task item in singlePage)
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
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            PagedEnumerable<ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gctv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public async Task ListTasksAsync()
        {
            // Snippet: ListTasksAsync(string, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            PagedAsyncEnumerable<ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gctv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasks_ResourceNames()
        {
            // Snippet: ListTasks(QueueName, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName parent = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            PagedEnumerable<ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gctv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public async Task ListTasksAsync_ResourceNames()
        {
            // Snippet: ListTasksAsync(QueueName, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName parent = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            PagedAsyncEnumerable<ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gctv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTask_RequestObject()
        {
            // Snippet: GetTask(GetTaskRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = cloudTasksClient.GetTask(request);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskAsync_RequestObject()
        {
            // Snippet: GetTaskAsync(GetTaskRequest, CallSettings)
            // Additional: GetTaskAsync(GetTaskRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = await cloudTasksClient.GetTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTask()
        {
            // Snippet: GetTask(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            gctv::Task response = cloudTasksClient.GetTask(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskAsync()
        {
            // Snippet: GetTaskAsync(string, CallSettings)
            // Additional: GetTaskAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            gctv::Task response = await cloudTasksClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTask_ResourceNames()
        {
            // Snippet: GetTask(TaskName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            gctv::Task response = cloudTasksClient.GetTask(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskAsync_ResourceNames()
        {
            // Snippet: GetTaskAsync(TaskName, CallSettings)
            // Additional: GetTaskAsync(TaskName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            gctv::Task response = await cloudTasksClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTask_RequestObject()
        {
            // Snippet: CreateTask(CreateTaskRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new gctv::Task(),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = cloudTasksClient.CreateTask(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskAsync_RequestObject()
        {
            // Snippet: CreateTaskAsync(CreateTaskRequest, CallSettings)
            // Additional: CreateTaskAsync(CreateTaskRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new gctv::Task(),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = await cloudTasksClient.CreateTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTask()
        {
            // Snippet: CreateTask(string, Task, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            gctv::Task task = new gctv::Task();
            // Make the request
            gctv::Task response = cloudTasksClient.CreateTask(parent, task);
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskAsync()
        {
            // Snippet: CreateTaskAsync(string, Task, CallSettings)
            // Additional: CreateTaskAsync(string, Task, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            gctv::Task task = new gctv::Task();
            // Make the request
            gctv::Task response = await cloudTasksClient.CreateTaskAsync(parent, task);
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTask_ResourceNames()
        {
            // Snippet: CreateTask(QueueName, Task, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName parent = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            gctv::Task task = new gctv::Task();
            // Make the request
            gctv::Task response = cloudTasksClient.CreateTask(parent, task);
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskAsync_ResourceNames()
        {
            // Snippet: CreateTaskAsync(QueueName, Task, CallSettings)
            // Additional: CreateTaskAsync(QueueName, Task, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName parent = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            gctv::Task task = new gctv::Task();
            // Make the request
            gctv::Task response = await cloudTasksClient.CreateTaskAsync(parent, task);
            // End snippet
        }

        /// <summary>Snippet for DeleteTask</summary>
        public void DeleteTask_RequestObject()
        {
            // Snippet: DeleteTask(DeleteTaskRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            // Make the request
            cloudTasksClient.DeleteTask(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaskAsync</summary>
        public async Task DeleteTaskAsync_RequestObject()
        {
            // Snippet: DeleteTaskAsync(DeleteTaskRequest, CallSettings)
            // Additional: DeleteTaskAsync(DeleteTaskRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            // Make the request
            await cloudTasksClient.DeleteTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTask</summary>
        public void DeleteTask()
        {
            // Snippet: DeleteTask(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            cloudTasksClient.DeleteTask(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaskAsync</summary>
        public async Task DeleteTaskAsync()
        {
            // Snippet: DeleteTaskAsync(string, CallSettings)
            // Additional: DeleteTaskAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            await cloudTasksClient.DeleteTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTask</summary>
        public void DeleteTask_ResourceNames()
        {
            // Snippet: DeleteTask(TaskName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            cloudTasksClient.DeleteTask(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaskAsync</summary>
        public async Task DeleteTaskAsync_ResourceNames()
        {
            // Snippet: DeleteTaskAsync(TaskName, CallSettings)
            // Additional: DeleteTaskAsync(TaskName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            await cloudTasksClient.DeleteTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RunTask</summary>
        public void RunTask_RequestObject()
        {
            // Snippet: RunTask(RunTaskRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = cloudTasksClient.RunTask(request);
            // End snippet
        }

        /// <summary>Snippet for RunTaskAsync</summary>
        public async Task RunTaskAsync_RequestObject()
        {
            // Snippet: RunTaskAsync(RunTaskRequest, CallSettings)
            // Additional: RunTaskAsync(RunTaskRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = await cloudTasksClient.RunTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunTask</summary>
        public void RunTask()
        {
            // Snippet: RunTask(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            gctv::Task response = cloudTasksClient.RunTask(name);
            // End snippet
        }

        /// <summary>Snippet for RunTaskAsync</summary>
        public async Task RunTaskAsync()
        {
            // Snippet: RunTaskAsync(string, CallSettings)
            // Additional: RunTaskAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            gctv::Task response = await cloudTasksClient.RunTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RunTask</summary>
        public void RunTask_ResourceNames()
        {
            // Snippet: RunTask(TaskName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            gctv::Task response = cloudTasksClient.RunTask(name);
            // End snippet
        }

        /// <summary>Snippet for RunTaskAsync</summary>
        public async Task RunTaskAsync_ResourceNames()
        {
            // Snippet: RunTaskAsync(TaskName, CallSettings)
            // Additional: RunTaskAsync(TaskName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            gctv::Task response = await cloudTasksClient.RunTaskAsync(name);
            // End snippet
        }
    }
}
