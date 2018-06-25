// Copyright 2018 Google LLC
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

namespace Google.Cloud.Tasks.V2Beta2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Iam.V1;
    using apis = Google.Cloud.Tasks.V2Beta2;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedCloudTasksClientSnippets
    {
        /// <summary>Snippet for ListQueuesAsync</summary>
        public async Task ListQueuesAsync()
        {
            // Snippet: ListQueuesAsync(LocationName,string,int?,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListQueuesResponse, apis::Queue> response =
                cloudTasksClient.ListQueuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((apis::Queue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQueuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (apis::Queue item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<apis::Queue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (apis::Queue item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueues</summary>
        public void ListQueues()
        {
            // Snippet: ListQueues(LocationName,string,int?,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListQueuesResponse, apis::Queue> response =
                cloudTasksClient.ListQueues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (apis::Queue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQueuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (apis::Queue item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<apis::Queue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (apis::Queue item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueuesAsync</summary>
        public async Task ListQueuesAsync_RequestObject()
        {
            // Snippet: ListQueuesAsync(ListQueuesRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            ListQueuesRequest request = new ListQueuesRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListQueuesResponse, apis::Queue> response =
                cloudTasksClient.ListQueuesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((apis::Queue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQueuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (apis::Queue item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<apis::Queue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (apis::Queue item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueues</summary>
        public void ListQueues_RequestObject()
        {
            // Snippet: ListQueues(ListQueuesRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            ListQueuesRequest request = new ListQueuesRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListQueuesResponse, apis::Queue> response =
                cloudTasksClient.ListQueues(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (apis::Queue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQueuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (apis::Queue item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<apis::Queue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (apis::Queue item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetQueueAsync</summary>
        public async Task GetQueueAsync()
        {
            // Snippet: GetQueueAsync(QueueName,CallSettings)
            // Additional: GetQueueAsync(QueueName,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            apis::Queue response = await cloudTasksClient.GetQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetQueue</summary>
        public void GetQueue()
        {
            // Snippet: GetQueue(QueueName,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            apis::Queue response = cloudTasksClient.GetQueue(name);
            // End snippet
        }

        /// <summary>Snippet for GetQueueAsync</summary>
        public async Task GetQueueAsync_RequestObject()
        {
            // Snippet: GetQueueAsync(GetQueueRequest,CallSettings)
            // Additional: GetQueueAsync(GetQueueRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            apis::Queue response = await cloudTasksClient.GetQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetQueue</summary>
        public void GetQueue_RequestObject()
        {
            // Snippet: GetQueue(GetQueueRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            apis::Queue response = cloudTasksClient.GetQueue(request);
            // End snippet
        }

        /// <summary>Snippet for CreateQueueAsync</summary>
        public async Task CreateQueueAsync()
        {
            // Snippet: CreateQueueAsync(LocationName,apis::Queue,CallSettings)
            // Additional: CreateQueueAsync(LocationName,apis::Queue,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            apis::Queue queue = new apis::Queue();
            // Make the request
            apis::Queue response = await cloudTasksClient.CreateQueueAsync(parent, queue);
            // End snippet
        }

        /// <summary>Snippet for CreateQueue</summary>
        public void CreateQueue()
        {
            // Snippet: CreateQueue(LocationName,apis::Queue,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            apis::Queue queue = new apis::Queue();
            // Make the request
            apis::Queue response = cloudTasksClient.CreateQueue(parent, queue);
            // End snippet
        }

        /// <summary>Snippet for CreateQueueAsync</summary>
        public async Task CreateQueueAsync_RequestObject()
        {
            // Snippet: CreateQueueAsync(CreateQueueRequest,CallSettings)
            // Additional: CreateQueueAsync(CreateQueueRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Queue = new apis::Queue(),
            };
            // Make the request
            apis::Queue response = await cloudTasksClient.CreateQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateQueue</summary>
        public void CreateQueue_RequestObject()
        {
            // Snippet: CreateQueue(CreateQueueRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Queue = new apis::Queue(),
            };
            // Make the request
            apis::Queue response = cloudTasksClient.CreateQueue(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueueAsync</summary>
        public async Task UpdateQueueAsync()
        {
            // Snippet: UpdateQueueAsync(apis::Queue,FieldMask,CallSettings)
            // Additional: UpdateQueueAsync(apis::Queue,FieldMask,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            apis::Queue queue = new apis::Queue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            apis::Queue response = await cloudTasksClient.UpdateQueueAsync(queue, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueue</summary>
        public void UpdateQueue()
        {
            // Snippet: UpdateQueue(apis::Queue,FieldMask,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            apis::Queue queue = new apis::Queue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            apis::Queue response = cloudTasksClient.UpdateQueue(queue, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueueAsync</summary>
        public async Task UpdateQueueAsync_RequestObject()
        {
            // Snippet: UpdateQueueAsync(UpdateQueueRequest,CallSettings)
            // Additional: UpdateQueueAsync(UpdateQueueRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new apis::Queue(),
            };
            // Make the request
            apis::Queue response = await cloudTasksClient.UpdateQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueue</summary>
        public void UpdateQueue_RequestObject()
        {
            // Snippet: UpdateQueue(UpdateQueueRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new apis::Queue(),
            };
            // Make the request
            apis::Queue response = cloudTasksClient.UpdateQueue(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueueAsync</summary>
        public async Task DeleteQueueAsync()
        {
            // Snippet: DeleteQueueAsync(QueueName,CallSettings)
            // Additional: DeleteQueueAsync(QueueName,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            await cloudTasksClient.DeleteQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueue</summary>
        public void DeleteQueue()
        {
            // Snippet: DeleteQueue(QueueName,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            cloudTasksClient.DeleteQueue(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueueAsync</summary>
        public async Task DeleteQueueAsync_RequestObject()
        {
            // Snippet: DeleteQueueAsync(DeleteQueueRequest,CallSettings)
            // Additional: DeleteQueueAsync(DeleteQueueRequest,CancellationToken)
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
        public void DeleteQueue_RequestObject()
        {
            // Snippet: DeleteQueue(DeleteQueueRequest,CallSettings)
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

        /// <summary>Snippet for PurgeQueueAsync</summary>
        public async Task PurgeQueueAsync()
        {
            // Snippet: PurgeQueueAsync(QueueName,CallSettings)
            // Additional: PurgeQueueAsync(QueueName,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            apis::Queue response = await cloudTasksClient.PurgeQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueue</summary>
        public void PurgeQueue()
        {
            // Snippet: PurgeQueue(QueueName,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            apis::Queue response = cloudTasksClient.PurgeQueue(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueueAsync</summary>
        public async Task PurgeQueueAsync_RequestObject()
        {
            // Snippet: PurgeQueueAsync(PurgeQueueRequest,CallSettings)
            // Additional: PurgeQueueAsync(PurgeQueueRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            apis::Queue response = await cloudTasksClient.PurgeQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueue</summary>
        public void PurgeQueue_RequestObject()
        {
            // Snippet: PurgeQueue(PurgeQueueRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            apis::Queue response = cloudTasksClient.PurgeQueue(request);
            // End snippet
        }

        /// <summary>Snippet for PauseQueueAsync</summary>
        public async Task PauseQueueAsync()
        {
            // Snippet: PauseQueueAsync(QueueName,CallSettings)
            // Additional: PauseQueueAsync(QueueName,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            apis::Queue response = await cloudTasksClient.PauseQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseQueue</summary>
        public void PauseQueue()
        {
            // Snippet: PauseQueue(QueueName,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            apis::Queue response = cloudTasksClient.PauseQueue(name);
            // End snippet
        }

        /// <summary>Snippet for PauseQueueAsync</summary>
        public async Task PauseQueueAsync_RequestObject()
        {
            // Snippet: PauseQueueAsync(PauseQueueRequest,CallSettings)
            // Additional: PauseQueueAsync(PauseQueueRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            apis::Queue response = await cloudTasksClient.PauseQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PauseQueue</summary>
        public void PauseQueue_RequestObject()
        {
            // Snippet: PauseQueue(PauseQueueRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            apis::Queue response = cloudTasksClient.PauseQueue(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueueAsync</summary>
        public async Task ResumeQueueAsync()
        {
            // Snippet: ResumeQueueAsync(QueueName,CallSettings)
            // Additional: ResumeQueueAsync(QueueName,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            apis::Queue response = await cloudTasksClient.ResumeQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueue</summary>
        public void ResumeQueue()
        {
            // Snippet: ResumeQueue(QueueName,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            apis::Queue response = cloudTasksClient.ResumeQueue(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueueAsync</summary>
        public async Task ResumeQueueAsync_RequestObject()
        {
            // Snippet: ResumeQueueAsync(ResumeQueueRequest,CallSettings)
            // Additional: ResumeQueueAsync(ResumeQueueRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            apis::Queue response = await cloudTasksClient.ResumeQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueue</summary>
        public void ResumeQueue_RequestObject()
        {
            // Snippet: ResumeQueue(ResumeQueueRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            apis::Queue response = cloudTasksClient.ResumeQueue(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(QueueName,CallSettings)
            // Additional: GetIamPolicyAsync(QueueName,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Policy response = await cloudTasksClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(QueueName,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Policy response = cloudTasksClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest,CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]").ToString(),
            };
            // Make the request
            Policy response = await cloudTasksClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]").ToString(),
            };
            // Make the request
            Policy response = cloudTasksClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(QueueName,Policy,CallSettings)
            // Additional: SetIamPolicyAsync(QueueName,Policy,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            Policy policy = new Policy();
            // Make the request
            Policy response = await cloudTasksClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(QueueName,Policy,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            Policy policy = new Policy();
            // Make the request
            Policy response = cloudTasksClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest,CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await cloudTasksClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = cloudTasksClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(QueueName,IEnumerable<string>,CallSettings)
            // Additional: TestIamPermissionsAsync(QueueName,IEnumerable<string>,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = await cloudTasksClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(QueueName,IEnumerable<string>,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = cloudTasksClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest,CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = await cloudTasksClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = cloudTasksClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksAsync()
        {
            // Snippet: ListTasksAsync(QueueName,string,int?,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName parent = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            PagedAsyncEnumerable<ListTasksResponse, apis::Task> response =
                cloudTasksClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((apis::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (apis::Task item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<apis::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (apis::Task item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasks()
        {
            // Snippet: ListTasks(QueueName,string,int?,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName parent = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            PagedEnumerable<ListTasksResponse, apis::Task> response =
                cloudTasksClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (apis::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (apis::Task item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<apis::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (apis::Task item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksAsync_RequestObject()
        {
            // Snippet: ListTasksAsync(ListTasksRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsQueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTasksResponse, apis::Task> response =
                cloudTasksClient.ListTasksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((apis::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (apis::Task item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<apis::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (apis::Task item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasks_RequestObject()
        {
            // Snippet: ListTasks(ListTasksRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsQueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            PagedEnumerable<ListTasksResponse, apis::Task> response =
                cloudTasksClient.ListTasks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (apis::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (apis::Task item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<apis::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (apis::Task item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskAsync()
        {
            // Snippet: GetTaskAsync(TaskName,CallSettings)
            // Additional: GetTaskAsync(TaskName,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            apis::Task response = await cloudTasksClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTask()
        {
            // Snippet: GetTask(TaskName,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            apis::Task response = cloudTasksClient.GetTask(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskAsync_RequestObject()
        {
            // Snippet: GetTaskAsync(GetTaskRequest,CallSettings)
            // Additional: GetTaskAsync(GetTaskRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            // Make the request
            apis::Task response = await cloudTasksClient.GetTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTask_RequestObject()
        {
            // Snippet: GetTask(GetTaskRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            // Make the request
            apis::Task response = cloudTasksClient.GetTask(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskAsync()
        {
            // Snippet: CreateTaskAsync(QueueName,apis::Task,CallSettings)
            // Additional: CreateTaskAsync(QueueName,apis::Task,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName parent = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            apis::Task task = new apis::Task();
            // Make the request
            apis::Task response = await cloudTasksClient.CreateTaskAsync(parent, task);
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTask()
        {
            // Snippet: CreateTask(QueueName,apis::Task,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName parent = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]");
            apis::Task task = new apis::Task();
            // Make the request
            apis::Task response = cloudTasksClient.CreateTask(parent, task);
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskAsync_RequestObject()
        {
            // Snippet: CreateTaskAsync(CreateTaskRequest,CallSettings)
            // Additional: CreateTaskAsync(CreateTaskRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new apis::Task(),
            };
            // Make the request
            apis::Task response = await cloudTasksClient.CreateTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTask_RequestObject()
        {
            // Snippet: CreateTask(CreateTaskRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new apis::Task(),
            };
            // Make the request
            apis::Task response = cloudTasksClient.CreateTask(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaskAsync</summary>
        public async Task DeleteTaskAsync()
        {
            // Snippet: DeleteTaskAsync(TaskName,CallSettings)
            // Additional: DeleteTaskAsync(TaskName,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            await cloudTasksClient.DeleteTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTask</summary>
        public void DeleteTask()
        {
            // Snippet: DeleteTask(TaskName,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            cloudTasksClient.DeleteTask(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaskAsync</summary>
        public async Task DeleteTaskAsync_RequestObject()
        {
            // Snippet: DeleteTaskAsync(DeleteTaskRequest,CallSettings)
            // Additional: DeleteTaskAsync(DeleteTaskRequest,CancellationToken)
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
        public void DeleteTask_RequestObject()
        {
            // Snippet: DeleteTask(DeleteTaskRequest,CallSettings)
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

        /// <summary>Snippet for LeaseTasksAsync</summary>
        public async Task LeaseTasksAsync_RequestObject()
        {
            // Snippet: LeaseTasksAsync(LeaseTasksRequest,CallSettings)
            // Additional: LeaseTasksAsync(LeaseTasksRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            LeaseTasksRequest request = new LeaseTasksRequest
            {
                ParentAsQueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                LeaseDuration = new Duration(),
            };
            // Make the request
            LeaseTasksResponse response = await cloudTasksClient.LeaseTasksAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LeaseTasks</summary>
        public void LeaseTasks_RequestObject()
        {
            // Snippet: LeaseTasks(LeaseTasksRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            LeaseTasksRequest request = new LeaseTasksRequest
            {
                ParentAsQueueName = new QueueName("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                LeaseDuration = new Duration(),
            };
            // Make the request
            LeaseTasksResponse response = cloudTasksClient.LeaseTasks(request);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeTaskAsync</summary>
        public async Task AcknowledgeTaskAsync()
        {
            // Snippet: AcknowledgeTaskAsync(TaskName,Timestamp,CallSettings)
            // Additional: AcknowledgeTaskAsync(TaskName,Timestamp,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            await cloudTasksClient.AcknowledgeTaskAsync(name, scheduleTime);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeTask</summary>
        public void AcknowledgeTask()
        {
            // Snippet: AcknowledgeTask(TaskName,Timestamp,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            cloudTasksClient.AcknowledgeTask(name, scheduleTime);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeTaskAsync</summary>
        public async Task AcknowledgeTaskAsync_RequestObject()
        {
            // Snippet: AcknowledgeTaskAsync(AcknowledgeTaskRequest,CallSettings)
            // Additional: AcknowledgeTaskAsync(AcknowledgeTaskRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            AcknowledgeTaskRequest request = new AcknowledgeTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ScheduleTime = new Timestamp(),
            };
            // Make the request
            await cloudTasksClient.AcknowledgeTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeTask</summary>
        public void AcknowledgeTask_RequestObject()
        {
            // Snippet: AcknowledgeTask(AcknowledgeTaskRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            AcknowledgeTaskRequest request = new AcknowledgeTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ScheduleTime = new Timestamp(),
            };
            // Make the request
            cloudTasksClient.AcknowledgeTask(request);
            // End snippet
        }

        /// <summary>Snippet for RenewLeaseAsync</summary>
        public async Task RenewLeaseAsync()
        {
            // Snippet: RenewLeaseAsync(TaskName,Timestamp,Duration,CallSettings)
            // Additional: RenewLeaseAsync(TaskName,Timestamp,Duration,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            Timestamp scheduleTime = new Timestamp();
            Duration leaseDuration = new Duration();
            // Make the request
            apis::Task response = await cloudTasksClient.RenewLeaseAsync(name, scheduleTime, leaseDuration);
            // End snippet
        }

        /// <summary>Snippet for RenewLease</summary>
        public void RenewLease()
        {
            // Snippet: RenewLease(TaskName,Timestamp,Duration,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            Timestamp scheduleTime = new Timestamp();
            Duration leaseDuration = new Duration();
            // Make the request
            apis::Task response = cloudTasksClient.RenewLease(name, scheduleTime, leaseDuration);
            // End snippet
        }

        /// <summary>Snippet for RenewLeaseAsync</summary>
        public async Task RenewLeaseAsync_RequestObject()
        {
            // Snippet: RenewLeaseAsync(RenewLeaseRequest,CallSettings)
            // Additional: RenewLeaseAsync(RenewLeaseRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            RenewLeaseRequest request = new RenewLeaseRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ScheduleTime = new Timestamp(),
                LeaseDuration = new Duration(),
            };
            // Make the request
            apis::Task response = await cloudTasksClient.RenewLeaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenewLease</summary>
        public void RenewLease_RequestObject()
        {
            // Snippet: RenewLease(RenewLeaseRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            RenewLeaseRequest request = new RenewLeaseRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ScheduleTime = new Timestamp(),
                LeaseDuration = new Duration(),
            };
            // Make the request
            apis::Task response = cloudTasksClient.RenewLease(request);
            // End snippet
        }

        /// <summary>Snippet for CancelLeaseAsync</summary>
        public async Task CancelLeaseAsync()
        {
            // Snippet: CancelLeaseAsync(TaskName,Timestamp,CallSettings)
            // Additional: CancelLeaseAsync(TaskName,Timestamp,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            apis::Task response = await cloudTasksClient.CancelLeaseAsync(name, scheduleTime);
            // End snippet
        }

        /// <summary>Snippet for CancelLease</summary>
        public void CancelLease()
        {
            // Snippet: CancelLease(TaskName,Timestamp,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            apis::Task response = cloudTasksClient.CancelLease(name, scheduleTime);
            // End snippet
        }

        /// <summary>Snippet for CancelLeaseAsync</summary>
        public async Task CancelLeaseAsync_RequestObject()
        {
            // Snippet: CancelLeaseAsync(CancelLeaseRequest,CallSettings)
            // Additional: CancelLeaseAsync(CancelLeaseRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            CancelLeaseRequest request = new CancelLeaseRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ScheduleTime = new Timestamp(),
            };
            // Make the request
            apis::Task response = await cloudTasksClient.CancelLeaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelLease</summary>
        public void CancelLease_RequestObject()
        {
            // Snippet: CancelLease(CancelLeaseRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            CancelLeaseRequest request = new CancelLeaseRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ScheduleTime = new Timestamp(),
            };
            // Make the request
            apis::Task response = cloudTasksClient.CancelLease(request);
            // End snippet
        }

        /// <summary>Snippet for RunTaskAsync</summary>
        public async Task RunTaskAsync()
        {
            // Snippet: RunTaskAsync(TaskName,CallSettings)
            // Additional: RunTaskAsync(TaskName,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            apis::Task response = await cloudTasksClient.RunTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RunTask</summary>
        public void RunTask()
        {
            // Snippet: RunTask(TaskName,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            apis::Task response = cloudTasksClient.RunTask(name);
            // End snippet
        }

        /// <summary>Snippet for RunTaskAsync</summary>
        public async Task RunTaskAsync_RequestObject()
        {
            // Snippet: RunTaskAsync(RunTaskRequest,CallSettings)
            // Additional: RunTaskAsync(RunTaskRequest,CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            // Make the request
            apis::Task response = await cloudTasksClient.RunTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunTask</summary>
        public void RunTask_RequestObject()
        {
            // Snippet: RunTask(RunTaskRequest,CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = new TaskName("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            // Make the request
            apis::Task response = cloudTasksClient.RunTask(request);
            // End snippet
        }

    }
}
