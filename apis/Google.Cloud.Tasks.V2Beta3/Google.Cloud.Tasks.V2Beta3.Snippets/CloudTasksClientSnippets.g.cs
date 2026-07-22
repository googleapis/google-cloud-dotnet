// Copyright 2026 Google LLC
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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using gctv = Google.Cloud.Tasks.V2Beta3;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudTasksClientSnippets
    {
        /// <summary>Snippet for ListQueues</summary>
        public void ListQueuesRequestObject()
        {
            // Snippet: ListQueues(ListQueuesRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::ListQueuesRequest request = new gctv::ListQueuesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<gctv::ListQueuesResponse, gctv::Queue> response = cloudTasksClient.ListQueues(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gctv::Queue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gctv::ListQueuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Queue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueuesAsync</summary>
        public async Task ListQueuesRequestObjectAsync()
        {
            // Snippet: ListQueuesAsync(ListQueuesRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::ListQueuesRequest request = new gctv::ListQueuesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<gctv::ListQueuesResponse, gctv::Queue> response = cloudTasksClient.ListQueuesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gctv::Queue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gctv::ListQueuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Queue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Queue item in singlePage)
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
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gctv::ListQueuesResponse, gctv::Queue> response = cloudTasksClient.ListQueues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gctv::Queue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gctv::ListQueuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Queue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueuesAsync</summary>
        public async Task ListQueuesAsync()
        {
            // Snippet: ListQueuesAsync(string, string, int?, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gctv::ListQueuesResponse, gctv::Queue> response = cloudTasksClient.ListQueuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gctv::Queue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gctv::ListQueuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Queue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueues</summary>
        public void ListQueuesResourceNames()
        {
            // Snippet: ListQueues(LocationName, string, int?, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gctv::ListQueuesResponse, gctv::Queue> response = cloudTasksClient.ListQueues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gctv::Queue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gctv::ListQueuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Queue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueuesAsync</summary>
        public async Task ListQueuesResourceNamesAsync()
        {
            // Snippet: ListQueuesAsync(LocationName, string, int?, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gctv::ListQueuesResponse, gctv::Queue> response = cloudTasksClient.ListQueuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gctv::Queue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gctv::ListQueuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Queue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetQueue</summary>
        public void GetQueueRequestObject()
        {
            // Snippet: GetQueue(GetQueueRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::GetQueueRequest request = new gctv::GetQueueRequest
            {
                QueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            gctv::Queue response = cloudTasksClient.GetQueue(request);
            // End snippet
        }

        /// <summary>Snippet for GetQueueAsync</summary>
        public async Task GetQueueRequestObjectAsync()
        {
            // Snippet: GetQueueAsync(GetQueueRequest, CallSettings)
            // Additional: GetQueueAsync(GetQueueRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::GetQueueRequest request = new gctv::GetQueueRequest
            {
                QueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            gctv::Queue response = await cloudTasksClient.GetQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetQueue</summary>
        public void GetQueue()
        {
            // Snippet: GetQueue(string, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            gctv::Queue response = cloudTasksClient.GetQueue(name);
            // End snippet
        }

        /// <summary>Snippet for GetQueueAsync</summary>
        public async Task GetQueueAsync()
        {
            // Snippet: GetQueueAsync(string, CallSettings)
            // Additional: GetQueueAsync(string, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            gctv::Queue response = await cloudTasksClient.GetQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetQueue</summary>
        public void GetQueueResourceNames()
        {
            // Snippet: GetQueue(QueueName, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::QueueName name = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            gctv::Queue response = cloudTasksClient.GetQueue(name);
            // End snippet
        }

        /// <summary>Snippet for GetQueueAsync</summary>
        public async Task GetQueueResourceNamesAsync()
        {
            // Snippet: GetQueueAsync(QueueName, CallSettings)
            // Additional: GetQueueAsync(QueueName, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::QueueName name = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            gctv::Queue response = await cloudTasksClient.GetQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateQueue</summary>
        public void CreateQueueRequestObject()
        {
            // Snippet: CreateQueue(CreateQueueRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::CreateQueueRequest request = new gctv::CreateQueueRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new gctv::Queue(),
            };
            // Make the request
            gctv::Queue response = cloudTasksClient.CreateQueue(request);
            // End snippet
        }

        /// <summary>Snippet for CreateQueueAsync</summary>
        public async Task CreateQueueRequestObjectAsync()
        {
            // Snippet: CreateQueueAsync(CreateQueueRequest, CallSettings)
            // Additional: CreateQueueAsync(CreateQueueRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::CreateQueueRequest request = new gctv::CreateQueueRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new gctv::Queue(),
            };
            // Make the request
            gctv::Queue response = await cloudTasksClient.CreateQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateQueue</summary>
        public void CreateQueue()
        {
            // Snippet: CreateQueue(string, Queue, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gctv::Queue queue = new gctv::Queue();
            // Make the request
            gctv::Queue response = cloudTasksClient.CreateQueue(parent, queue);
            // End snippet
        }

        /// <summary>Snippet for CreateQueueAsync</summary>
        public async Task CreateQueueAsync()
        {
            // Snippet: CreateQueueAsync(string, Queue, CallSettings)
            // Additional: CreateQueueAsync(string, Queue, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gctv::Queue queue = new gctv::Queue();
            // Make the request
            gctv::Queue response = await cloudTasksClient.CreateQueueAsync(parent, queue);
            // End snippet
        }

        /// <summary>Snippet for CreateQueue</summary>
        public void CreateQueueResourceNames()
        {
            // Snippet: CreateQueue(LocationName, Queue, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gctv::Queue queue = new gctv::Queue();
            // Make the request
            gctv::Queue response = cloudTasksClient.CreateQueue(parent, queue);
            // End snippet
        }

        /// <summary>Snippet for CreateQueueAsync</summary>
        public async Task CreateQueueResourceNamesAsync()
        {
            // Snippet: CreateQueueAsync(LocationName, Queue, CallSettings)
            // Additional: CreateQueueAsync(LocationName, Queue, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gctv::Queue queue = new gctv::Queue();
            // Make the request
            gctv::Queue response = await cloudTasksClient.CreateQueueAsync(parent, queue);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueue</summary>
        public void UpdateQueueRequestObject()
        {
            // Snippet: UpdateQueue(UpdateQueueRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::UpdateQueueRequest request = new gctv::UpdateQueueRequest
            {
                Queue = new gctv::Queue(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gctv::Queue response = cloudTasksClient.UpdateQueue(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueueAsync</summary>
        public async Task UpdateQueueRequestObjectAsync()
        {
            // Snippet: UpdateQueueAsync(UpdateQueueRequest, CallSettings)
            // Additional: UpdateQueueAsync(UpdateQueueRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::UpdateQueueRequest request = new gctv::UpdateQueueRequest
            {
                Queue = new gctv::Queue(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gctv::Queue response = await cloudTasksClient.UpdateQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueue</summary>
        public void UpdateQueue()
        {
            // Snippet: UpdateQueue(Queue, FieldMask, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::Queue queue = new gctv::Queue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gctv::Queue response = cloudTasksClient.UpdateQueue(queue, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueueAsync</summary>
        public async Task UpdateQueueAsync()
        {
            // Snippet: UpdateQueueAsync(Queue, FieldMask, CallSettings)
            // Additional: UpdateQueueAsync(Queue, FieldMask, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::Queue queue = new gctv::Queue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gctv::Queue response = await cloudTasksClient.UpdateQueueAsync(queue, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueue</summary>
        public void DeleteQueueRequestObject()
        {
            // Snippet: DeleteQueue(DeleteQueueRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::DeleteQueueRequest request = new gctv::DeleteQueueRequest
            {
                QueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            cloudTasksClient.DeleteQueue(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueueAsync</summary>
        public async Task DeleteQueueRequestObjectAsync()
        {
            // Snippet: DeleteQueueAsync(DeleteQueueRequest, CallSettings)
            // Additional: DeleteQueueAsync(DeleteQueueRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::DeleteQueueRequest request = new gctv::DeleteQueueRequest
            {
                QueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
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
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
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
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            await cloudTasksClient.DeleteQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueue</summary>
        public void DeleteQueueResourceNames()
        {
            // Snippet: DeleteQueue(QueueName, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::QueueName name = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            cloudTasksClient.DeleteQueue(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueueAsync</summary>
        public async Task DeleteQueueResourceNamesAsync()
        {
            // Snippet: DeleteQueueAsync(QueueName, CallSettings)
            // Additional: DeleteQueueAsync(QueueName, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::QueueName name = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            await cloudTasksClient.DeleteQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueue</summary>
        public void PurgeQueueRequestObject()
        {
            // Snippet: PurgeQueue(PurgeQueueRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::PurgeQueueRequest request = new gctv::PurgeQueueRequest
            {
                QueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            gctv::Queue response = cloudTasksClient.PurgeQueue(request);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueueAsync</summary>
        public async Task PurgeQueueRequestObjectAsync()
        {
            // Snippet: PurgeQueueAsync(PurgeQueueRequest, CallSettings)
            // Additional: PurgeQueueAsync(PurgeQueueRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::PurgeQueueRequest request = new gctv::PurgeQueueRequest
            {
                QueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            gctv::Queue response = await cloudTasksClient.PurgeQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueue</summary>
        public void PurgeQueue()
        {
            // Snippet: PurgeQueue(string, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            gctv::Queue response = cloudTasksClient.PurgeQueue(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueueAsync</summary>
        public async Task PurgeQueueAsync()
        {
            // Snippet: PurgeQueueAsync(string, CallSettings)
            // Additional: PurgeQueueAsync(string, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            gctv::Queue response = await cloudTasksClient.PurgeQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueue</summary>
        public void PurgeQueueResourceNames()
        {
            // Snippet: PurgeQueue(QueueName, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::QueueName name = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            gctv::Queue response = cloudTasksClient.PurgeQueue(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueueAsync</summary>
        public async Task PurgeQueueResourceNamesAsync()
        {
            // Snippet: PurgeQueueAsync(QueueName, CallSettings)
            // Additional: PurgeQueueAsync(QueueName, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::QueueName name = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            gctv::Queue response = await cloudTasksClient.PurgeQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseQueue</summary>
        public void PauseQueueRequestObject()
        {
            // Snippet: PauseQueue(PauseQueueRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::PauseQueueRequest request = new gctv::PauseQueueRequest
            {
                QueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            gctv::Queue response = cloudTasksClient.PauseQueue(request);
            // End snippet
        }

        /// <summary>Snippet for PauseQueueAsync</summary>
        public async Task PauseQueueRequestObjectAsync()
        {
            // Snippet: PauseQueueAsync(PauseQueueRequest, CallSettings)
            // Additional: PauseQueueAsync(PauseQueueRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::PauseQueueRequest request = new gctv::PauseQueueRequest
            {
                QueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            gctv::Queue response = await cloudTasksClient.PauseQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PauseQueue</summary>
        public void PauseQueue()
        {
            // Snippet: PauseQueue(string, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            gctv::Queue response = cloudTasksClient.PauseQueue(name);
            // End snippet
        }

        /// <summary>Snippet for PauseQueueAsync</summary>
        public async Task PauseQueueAsync()
        {
            // Snippet: PauseQueueAsync(string, CallSettings)
            // Additional: PauseQueueAsync(string, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            gctv::Queue response = await cloudTasksClient.PauseQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseQueue</summary>
        public void PauseQueueResourceNames()
        {
            // Snippet: PauseQueue(QueueName, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::QueueName name = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            gctv::Queue response = cloudTasksClient.PauseQueue(name);
            // End snippet
        }

        /// <summary>Snippet for PauseQueueAsync</summary>
        public async Task PauseQueueResourceNamesAsync()
        {
            // Snippet: PauseQueueAsync(QueueName, CallSettings)
            // Additional: PauseQueueAsync(QueueName, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::QueueName name = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            gctv::Queue response = await cloudTasksClient.PauseQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueue</summary>
        public void ResumeQueueRequestObject()
        {
            // Snippet: ResumeQueue(ResumeQueueRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::ResumeQueueRequest request = new gctv::ResumeQueueRequest
            {
                QueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            gctv::Queue response = cloudTasksClient.ResumeQueue(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueueAsync</summary>
        public async Task ResumeQueueRequestObjectAsync()
        {
            // Snippet: ResumeQueueAsync(ResumeQueueRequest, CallSettings)
            // Additional: ResumeQueueAsync(ResumeQueueRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::ResumeQueueRequest request = new gctv::ResumeQueueRequest
            {
                QueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            gctv::Queue response = await cloudTasksClient.ResumeQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueue</summary>
        public void ResumeQueue()
        {
            // Snippet: ResumeQueue(string, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            gctv::Queue response = cloudTasksClient.ResumeQueue(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueueAsync</summary>
        public async Task ResumeQueueAsync()
        {
            // Snippet: ResumeQueueAsync(string, CallSettings)
            // Additional: ResumeQueueAsync(string, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            gctv::Queue response = await cloudTasksClient.ResumeQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueue</summary>
        public void ResumeQueueResourceNames()
        {
            // Snippet: ResumeQueue(QueueName, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::QueueName name = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            gctv::Queue response = cloudTasksClient.ResumeQueue(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueueAsync</summary>
        public async Task ResumeQueueResourceNamesAsync()
        {
            // Snippet: ResumeQueueAsync(QueueName, CallSettings)
            // Additional: ResumeQueueAsync(QueueName, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::QueueName name = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            gctv::Queue response = await cloudTasksClient.ResumeQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = cloudTasksClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
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
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
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
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await cloudTasksClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = cloudTasksClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await cloudTasksClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = cloudTasksClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
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
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
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
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await cloudTasksClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = cloudTasksClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await cloudTasksClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = cloudTasksClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
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
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
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
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await cloudTasksClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = cloudTasksClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await cloudTasksClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasksRequestObject()
        {
            // Snippet: ListTasks(ListTasksRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::ListTasksRequest request = new gctv::ListTasksRequest
            {
                ParentAsQueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            PagedEnumerable<gctv::ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gctv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gctv::ListTasksResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksRequestObjectAsync()
        {
            // Snippet: ListTasksAsync(ListTasksRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::ListTasksRequest request = new gctv::ListTasksRequest
            {
                ParentAsQueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<gctv::ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gctv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gctv::ListTasksResponse page in response.AsRawResponses())
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
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            PagedEnumerable<gctv::ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gctv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gctv::ListTasksResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksAsync()
        {
            // Snippet: ListTasksAsync(string, string, int?, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            PagedAsyncEnumerable<gctv::ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gctv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gctv::ListTasksResponse page in response.AsRawResponses())
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
        public void ListTasksResourceNames()
        {
            // Snippet: ListTasks(QueueName, string, int?, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::QueueName parent = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            PagedEnumerable<gctv::ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gctv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gctv::ListTasksResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksResourceNamesAsync()
        {
            // Snippet: ListTasksAsync(QueueName, string, int?, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::QueueName parent = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            PagedAsyncEnumerable<gctv::ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gctv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gctv::ListTasksResponse page in response.AsRawResponses())
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
        public void GetTaskRequestObject()
        {
            // Snippet: GetTask(GetTaskRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::GetTaskRequest request = new gctv::GetTaskRequest
            {
                TaskName = gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = cloudTasksClient.GetTask(request);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskRequestObjectAsync()
        {
            // Snippet: GetTaskAsync(GetTaskRequest, CallSettings)
            // Additional: GetTaskAsync(GetTaskRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::GetTaskRequest request = new gctv::GetTaskRequest
            {
                TaskName = gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
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
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
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
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            gctv::Task response = await cloudTasksClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTaskResourceNames()
        {
            // Snippet: GetTask(TaskName, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::TaskName name = gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            gctv::Task response = cloudTasksClient.GetTask(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskResourceNamesAsync()
        {
            // Snippet: GetTaskAsync(TaskName, CallSettings)
            // Additional: GetTaskAsync(TaskName, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::TaskName name = gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            gctv::Task response = await cloudTasksClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTaskRequestObject()
        {
            // Snippet: CreateTask(CreateTaskRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::CreateTaskRequest request = new gctv::CreateTaskRequest
            {
                ParentAsQueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new gctv::Task(),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = cloudTasksClient.CreateTask(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskRequestObjectAsync()
        {
            // Snippet: CreateTaskAsync(CreateTaskRequest, CallSettings)
            // Additional: CreateTaskAsync(CreateTaskRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::CreateTaskRequest request = new gctv::CreateTaskRequest
            {
                ParentAsQueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
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
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
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
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            gctv::Task task = new gctv::Task();
            // Make the request
            gctv::Task response = await cloudTasksClient.CreateTaskAsync(parent, task);
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTaskResourceNames()
        {
            // Snippet: CreateTask(QueueName, Task, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::QueueName parent = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            gctv::Task task = new gctv::Task();
            // Make the request
            gctv::Task response = cloudTasksClient.CreateTask(parent, task);
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskResourceNamesAsync()
        {
            // Snippet: CreateTaskAsync(QueueName, Task, CallSettings)
            // Additional: CreateTaskAsync(QueueName, Task, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::QueueName parent = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            gctv::Task task = new gctv::Task();
            // Make the request
            gctv::Task response = await cloudTasksClient.CreateTaskAsync(parent, task);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTasks</summary>
        public void BatchCreateTasksRequestObject()
        {
            // Snippet: BatchCreateTasks(BatchCreateTasksRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::BatchCreateTasksRequest request = new gctv::BatchCreateTasksRequest
            {
                ParentAsQueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Requests =
                {
                    new gctv::CreateTaskRequest(),
                },
                RequestId = "",
            };
            // Make the request
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> response = cloudTasksClient.BatchCreateTasks(request);

            // Poll until the returned long-running operation is complete
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gctv::BatchCreateTasksResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> retrievedResponse = cloudTasksClient.PollOnceBatchCreateTasks(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gctv::BatchCreateTasksResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTasksAsync</summary>
        public async Task BatchCreateTasksRequestObjectAsync()
        {
            // Snippet: BatchCreateTasksAsync(BatchCreateTasksRequest, CallSettings)
            // Additional: BatchCreateTasksAsync(BatchCreateTasksRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::BatchCreateTasksRequest request = new gctv::BatchCreateTasksRequest
            {
                ParentAsQueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Requests =
                {
                    new gctv::CreateTaskRequest(),
                },
                RequestId = "",
            };
            // Make the request
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> response = await cloudTasksClient.BatchCreateTasksAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gctv::BatchCreateTasksResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> retrievedResponse = await cloudTasksClient.PollOnceBatchCreateTasksAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gctv::BatchCreateTasksResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTasks</summary>
        public void BatchCreateTasks()
        {
            // Snippet: BatchCreateTasks(string, IEnumerable<CreateTaskRequest>, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            IEnumerable<gctv::CreateTaskRequest> requests = new gctv::CreateTaskRequest[]
            {
                new gctv::CreateTaskRequest(),
            };
            // Make the request
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> response = cloudTasksClient.BatchCreateTasks(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gctv::BatchCreateTasksResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> retrievedResponse = cloudTasksClient.PollOnceBatchCreateTasks(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gctv::BatchCreateTasksResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTasksAsync</summary>
        public async Task BatchCreateTasksAsync()
        {
            // Snippet: BatchCreateTasksAsync(string, IEnumerable<CreateTaskRequest>, CallSettings)
            // Additional: BatchCreateTasksAsync(string, IEnumerable<CreateTaskRequest>, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            IEnumerable<gctv::CreateTaskRequest> requests = new gctv::CreateTaskRequest[]
            {
                new gctv::CreateTaskRequest(),
            };
            // Make the request
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> response = await cloudTasksClient.BatchCreateTasksAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gctv::BatchCreateTasksResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> retrievedResponse = await cloudTasksClient.PollOnceBatchCreateTasksAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gctv::BatchCreateTasksResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTasks</summary>
        public void BatchCreateTasksResourceNames()
        {
            // Snippet: BatchCreateTasks(QueueName, IEnumerable<CreateTaskRequest>, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::QueueName parent = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            IEnumerable<gctv::CreateTaskRequest> requests = new gctv::CreateTaskRequest[]
            {
                new gctv::CreateTaskRequest(),
            };
            // Make the request
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> response = cloudTasksClient.BatchCreateTasks(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gctv::BatchCreateTasksResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> retrievedResponse = cloudTasksClient.PollOnceBatchCreateTasks(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gctv::BatchCreateTasksResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTasksAsync</summary>
        public async Task BatchCreateTasksResourceNamesAsync()
        {
            // Snippet: BatchCreateTasksAsync(QueueName, IEnumerable<CreateTaskRequest>, CallSettings)
            // Additional: BatchCreateTasksAsync(QueueName, IEnumerable<CreateTaskRequest>, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::QueueName parent = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            IEnumerable<gctv::CreateTaskRequest> requests = new gctv::CreateTaskRequest[]
            {
                new gctv::CreateTaskRequest(),
            };
            // Make the request
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> response = await cloudTasksClient.BatchCreateTasksAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gctv::BatchCreateTasksResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> retrievedResponse = await cloudTasksClient.PollOnceBatchCreateTasksAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gctv::BatchCreateTasksResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTask</summary>
        public void DeleteTaskRequestObject()
        {
            // Snippet: DeleteTask(DeleteTaskRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::DeleteTaskRequest request = new gctv::DeleteTaskRequest
            {
                TaskName = gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            // Make the request
            cloudTasksClient.DeleteTask(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaskAsync</summary>
        public async Task DeleteTaskRequestObjectAsync()
        {
            // Snippet: DeleteTaskAsync(DeleteTaskRequest, CallSettings)
            // Additional: DeleteTaskAsync(DeleteTaskRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::DeleteTaskRequest request = new gctv::DeleteTaskRequest
            {
                TaskName = gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
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
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
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
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            await cloudTasksClient.DeleteTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTask</summary>
        public void DeleteTaskResourceNames()
        {
            // Snippet: DeleteTask(TaskName, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::TaskName name = gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            cloudTasksClient.DeleteTask(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaskAsync</summary>
        public async Task DeleteTaskResourceNamesAsync()
        {
            // Snippet: DeleteTaskAsync(TaskName, CallSettings)
            // Additional: DeleteTaskAsync(TaskName, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::TaskName name = gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            await cloudTasksClient.DeleteTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteTasks</summary>
        public void BatchDeleteTasksRequestObject()
        {
            // Snippet: BatchDeleteTasks(BatchDeleteTasksRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::BatchDeleteTasksRequest request = new gctv::BatchDeleteTasksRequest
            {
                ParentAsQueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                TaskNames =
                {
                    gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                },
                RequestId = "",
            };
            // Make the request
            Operation<Empty, gctv::BatchDeleteTasksMetadata> response = cloudTasksClient.BatchDeleteTasks(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gctv::BatchDeleteTasksMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gctv::BatchDeleteTasksMetadata> retrievedResponse = cloudTasksClient.PollOnceBatchDeleteTasks(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteTasksAsync</summary>
        public async Task BatchDeleteTasksRequestObjectAsync()
        {
            // Snippet: BatchDeleteTasksAsync(BatchDeleteTasksRequest, CallSettings)
            // Additional: BatchDeleteTasksAsync(BatchDeleteTasksRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::BatchDeleteTasksRequest request = new gctv::BatchDeleteTasksRequest
            {
                ParentAsQueueName = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                TaskNames =
                {
                    gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                },
                RequestId = "",
            };
            // Make the request
            Operation<Empty, gctv::BatchDeleteTasksMetadata> response = await cloudTasksClient.BatchDeleteTasksAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gctv::BatchDeleteTasksMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gctv::BatchDeleteTasksMetadata> retrievedResponse = await cloudTasksClient.PollOnceBatchDeleteTasksAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteTasks</summary>
        public void BatchDeleteTasks()
        {
            // Snippet: BatchDeleteTasks(string, IEnumerable<string>, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]",
            };
            // Make the request
            Operation<Empty, gctv::BatchDeleteTasksMetadata> response = cloudTasksClient.BatchDeleteTasks(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gctv::BatchDeleteTasksMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gctv::BatchDeleteTasksMetadata> retrievedResponse = cloudTasksClient.PollOnceBatchDeleteTasks(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteTasksAsync</summary>
        public async Task BatchDeleteTasksAsync()
        {
            // Snippet: BatchDeleteTasksAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeleteTasksAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]",
            };
            // Make the request
            Operation<Empty, gctv::BatchDeleteTasksMetadata> response = await cloudTasksClient.BatchDeleteTasksAsync(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gctv::BatchDeleteTasksMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gctv::BatchDeleteTasksMetadata> retrievedResponse = await cloudTasksClient.PollOnceBatchDeleteTasksAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteTasks</summary>
        public void BatchDeleteTasksResourceNames()
        {
            // Snippet: BatchDeleteTasks(QueueName, IEnumerable<TaskName>, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::QueueName parent = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            IEnumerable<gctv::TaskName> names = new gctv::TaskName[]
            {
                gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            // Make the request
            Operation<Empty, gctv::BatchDeleteTasksMetadata> response = cloudTasksClient.BatchDeleteTasks(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gctv::BatchDeleteTasksMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gctv::BatchDeleteTasksMetadata> retrievedResponse = cloudTasksClient.PollOnceBatchDeleteTasks(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteTasksAsync</summary>
        public async Task BatchDeleteTasksResourceNamesAsync()
        {
            // Snippet: BatchDeleteTasksAsync(QueueName, IEnumerable<TaskName>, CallSettings)
            // Additional: BatchDeleteTasksAsync(QueueName, IEnumerable<TaskName>, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::QueueName parent = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            IEnumerable<gctv::TaskName> names = new gctv::TaskName[]
            {
                gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            // Make the request
            Operation<Empty, gctv::BatchDeleteTasksMetadata> response = await cloudTasksClient.BatchDeleteTasksAsync(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gctv::BatchDeleteTasksMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gctv::BatchDeleteTasksMetadata> retrievedResponse = await cloudTasksClient.PollOnceBatchDeleteTasksAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunTask</summary>
        public void RunTaskRequestObject()
        {
            // Snippet: RunTask(RunTaskRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::RunTaskRequest request = new gctv::RunTaskRequest
            {
                TaskName = gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = cloudTasksClient.RunTask(request);
            // End snippet
        }

        /// <summary>Snippet for RunTaskAsync</summary>
        public async Task RunTaskRequestObjectAsync()
        {
            // Snippet: RunTaskAsync(RunTaskRequest, CallSettings)
            // Additional: RunTaskAsync(RunTaskRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::RunTaskRequest request = new gctv::RunTaskRequest
            {
                TaskName = gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
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
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
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
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            gctv::Task response = await cloudTasksClient.RunTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RunTask</summary>
        public void RunTaskResourceNames()
        {
            // Snippet: RunTask(TaskName, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::TaskName name = gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            gctv::Task response = cloudTasksClient.RunTask(name);
            // End snippet
        }

        /// <summary>Snippet for RunTaskAsync</summary>
        public async Task RunTaskResourceNamesAsync()
        {
            // Snippet: RunTaskAsync(TaskName, CallSettings)
            // Additional: RunTaskAsync(TaskName, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::TaskName name = gctv::TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            gctv::Task response = await cloudTasksClient.RunTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateCmekConfig</summary>
        public void UpdateCmekConfigRequestObject()
        {
            // Snippet: UpdateCmekConfig(UpdateCmekConfigRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::UpdateCmekConfigRequest request = new gctv::UpdateCmekConfigRequest
            {
                CmekConfig = new gctv::CmekConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gctv::CmekConfig response = cloudTasksClient.UpdateCmekConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCmekConfigAsync</summary>
        public async Task UpdateCmekConfigRequestObjectAsync()
        {
            // Snippet: UpdateCmekConfigAsync(UpdateCmekConfigRequest, CallSettings)
            // Additional: UpdateCmekConfigAsync(UpdateCmekConfigRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::UpdateCmekConfigRequest request = new gctv::UpdateCmekConfigRequest
            {
                CmekConfig = new gctv::CmekConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gctv::CmekConfig response = await cloudTasksClient.UpdateCmekConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCmekConfig</summary>
        public void UpdateCmekConfig()
        {
            // Snippet: UpdateCmekConfig(CmekConfig, FieldMask, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::CmekConfig cmekConfig = new gctv::CmekConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gctv::CmekConfig response = cloudTasksClient.UpdateCmekConfig(cmekConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCmekConfigAsync</summary>
        public async Task UpdateCmekConfigAsync()
        {
            // Snippet: UpdateCmekConfigAsync(CmekConfig, FieldMask, CallSettings)
            // Additional: UpdateCmekConfigAsync(CmekConfig, FieldMask, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::CmekConfig cmekConfig = new gctv::CmekConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gctv::CmekConfig response = await cloudTasksClient.UpdateCmekConfigAsync(cmekConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetCmekConfig</summary>
        public void GetCmekConfigRequestObject()
        {
            // Snippet: GetCmekConfig(GetCmekConfigRequest, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::GetCmekConfigRequest request = new gctv::GetCmekConfigRequest
            {
                CmekConfigName = gctv::CmekConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            gctv::CmekConfig response = cloudTasksClient.GetCmekConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetCmekConfigAsync</summary>
        public async Task GetCmekConfigRequestObjectAsync()
        {
            // Snippet: GetCmekConfigAsync(GetCmekConfigRequest, CallSettings)
            // Additional: GetCmekConfigAsync(GetCmekConfigRequest, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::GetCmekConfigRequest request = new gctv::GetCmekConfigRequest
            {
                CmekConfigName = gctv::CmekConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            gctv::CmekConfig response = await cloudTasksClient.GetCmekConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCmekConfig</summary>
        public void GetCmekConfig()
        {
            // Snippet: GetCmekConfig(string, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cmekConfig";
            // Make the request
            gctv::CmekConfig response = cloudTasksClient.GetCmekConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetCmekConfigAsync</summary>
        public async Task GetCmekConfigAsync()
        {
            // Snippet: GetCmekConfigAsync(string, CallSettings)
            // Additional: GetCmekConfigAsync(string, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cmekConfig";
            // Make the request
            gctv::CmekConfig response = await cloudTasksClient.GetCmekConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCmekConfig</summary>
        public void GetCmekConfigResourceNames()
        {
            // Snippet: GetCmekConfig(CmekConfigName, CallSettings)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = gctv::CloudTasksClient.Create();
            // Initialize request argument(s)
            gctv::CmekConfigName name = gctv::CmekConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            gctv::CmekConfig response = cloudTasksClient.GetCmekConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetCmekConfigAsync</summary>
        public async Task GetCmekConfigResourceNamesAsync()
        {
            // Snippet: GetCmekConfigAsync(CmekConfigName, CallSettings)
            // Additional: GetCmekConfigAsync(CmekConfigName, CancellationToken)
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::CmekConfigName name = gctv::CmekConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            gctv::CmekConfig response = await cloudTasksClient.GetCmekConfigAsync(name);
            // End snippet
        }
    }
}
