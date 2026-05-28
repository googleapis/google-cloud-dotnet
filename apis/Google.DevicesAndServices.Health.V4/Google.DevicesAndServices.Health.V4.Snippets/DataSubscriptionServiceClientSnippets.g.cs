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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.DevicesAndServices.Health.V4;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataSubscriptionServiceClientSnippets
    {
        /// <summary>Snippet for CreateSubscriber</summary>
        public void CreateSubscriberRequestObject()
        {
            // Snippet: CreateSubscriber(CreateSubscriberRequest, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            CreateSubscriberRequest request = new CreateSubscriberRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Subscriber = new CreateSubscriberPayload(),
                SubscriberId = "",
            };
            // Make the request
            Operation<Subscriber, CreateSubscriberMetadata> response = dataSubscriptionServiceClient.CreateSubscriber(request);

            // Poll until the returned long-running operation is complete
            Operation<Subscriber, CreateSubscriberMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subscriber result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscriber, CreateSubscriberMetadata> retrievedResponse = dataSubscriptionServiceClient.PollOnceCreateSubscriber(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscriber retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriberAsync</summary>
        public async Task CreateSubscriberRequestObjectAsync()
        {
            // Snippet: CreateSubscriberAsync(CreateSubscriberRequest, CallSettings)
            // Additional: CreateSubscriberAsync(CreateSubscriberRequest, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSubscriberRequest request = new CreateSubscriberRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Subscriber = new CreateSubscriberPayload(),
                SubscriberId = "",
            };
            // Make the request
            Operation<Subscriber, CreateSubscriberMetadata> response = await dataSubscriptionServiceClient.CreateSubscriberAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Subscriber, CreateSubscriberMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subscriber result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscriber, CreateSubscriberMetadata> retrievedResponse = await dataSubscriptionServiceClient.PollOnceCreateSubscriberAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscriber retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriber</summary>
        public void CreateSubscriber()
        {
            // Snippet: CreateSubscriber(string, CreateSubscriberPayload, string, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            CreateSubscriberPayload subscriber = new CreateSubscriberPayload();
            string subscriberId = "";
            // Make the request
            Operation<Subscriber, CreateSubscriberMetadata> response = dataSubscriptionServiceClient.CreateSubscriber(parent, subscriber, subscriberId);

            // Poll until the returned long-running operation is complete
            Operation<Subscriber, CreateSubscriberMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subscriber result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscriber, CreateSubscriberMetadata> retrievedResponse = dataSubscriptionServiceClient.PollOnceCreateSubscriber(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscriber retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriberAsync</summary>
        public async Task CreateSubscriberAsync()
        {
            // Snippet: CreateSubscriberAsync(string, CreateSubscriberPayload, string, CallSettings)
            // Additional: CreateSubscriberAsync(string, CreateSubscriberPayload, string, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            CreateSubscriberPayload subscriber = new CreateSubscriberPayload();
            string subscriberId = "";
            // Make the request
            Operation<Subscriber, CreateSubscriberMetadata> response = await dataSubscriptionServiceClient.CreateSubscriberAsync(parent, subscriber, subscriberId);

            // Poll until the returned long-running operation is complete
            Operation<Subscriber, CreateSubscriberMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subscriber result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscriber, CreateSubscriberMetadata> retrievedResponse = await dataSubscriptionServiceClient.PollOnceCreateSubscriberAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscriber retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriber</summary>
        public void CreateSubscriberResourceNames()
        {
            // Snippet: CreateSubscriber(ProjectName, CreateSubscriberPayload, string, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            CreateSubscriberPayload subscriber = new CreateSubscriberPayload();
            string subscriberId = "";
            // Make the request
            Operation<Subscriber, CreateSubscriberMetadata> response = dataSubscriptionServiceClient.CreateSubscriber(parent, subscriber, subscriberId);

            // Poll until the returned long-running operation is complete
            Operation<Subscriber, CreateSubscriberMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subscriber result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscriber, CreateSubscriberMetadata> retrievedResponse = dataSubscriptionServiceClient.PollOnceCreateSubscriber(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscriber retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriberAsync</summary>
        public async Task CreateSubscriberResourceNamesAsync()
        {
            // Snippet: CreateSubscriberAsync(ProjectName, CreateSubscriberPayload, string, CallSettings)
            // Additional: CreateSubscriberAsync(ProjectName, CreateSubscriberPayload, string, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            CreateSubscriberPayload subscriber = new CreateSubscriberPayload();
            string subscriberId = "";
            // Make the request
            Operation<Subscriber, CreateSubscriberMetadata> response = await dataSubscriptionServiceClient.CreateSubscriberAsync(parent, subscriber, subscriberId);

            // Poll until the returned long-running operation is complete
            Operation<Subscriber, CreateSubscriberMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subscriber result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscriber, CreateSubscriberMetadata> retrievedResponse = await dataSubscriptionServiceClient.PollOnceCreateSubscriberAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscriber retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListSubscribers</summary>
        public void ListSubscribersRequestObject()
        {
            // Snippet: ListSubscribers(ListSubscribersRequest, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            ListSubscribersRequest request = new ListSubscribersRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListSubscribersResponse, Subscriber> response = dataSubscriptionServiceClient.ListSubscribers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscriber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscribersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscriber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscriber> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscriber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscribersAsync</summary>
        public async Task ListSubscribersRequestObjectAsync()
        {
            // Snippet: ListSubscribersAsync(ListSubscribersRequest, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSubscribersRequest request = new ListSubscribersRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSubscribersResponse, Subscriber> response = dataSubscriptionServiceClient.ListSubscribersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Subscriber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSubscribersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscriber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscriber> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscriber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscribers</summary>
        public void ListSubscribers()
        {
            // Snippet: ListSubscribers(string, string, int?, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListSubscribersResponse, Subscriber> response = dataSubscriptionServiceClient.ListSubscribers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscriber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscribersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscriber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscriber> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscriber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscribersAsync</summary>
        public async Task ListSubscribersAsync()
        {
            // Snippet: ListSubscribersAsync(string, string, int?, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListSubscribersResponse, Subscriber> response = dataSubscriptionServiceClient.ListSubscribersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Subscriber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSubscribersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscriber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscriber> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscriber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscribers</summary>
        public void ListSubscribersResourceNames()
        {
            // Snippet: ListSubscribers(ProjectName, string, int?, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSubscribersResponse, Subscriber> response = dataSubscriptionServiceClient.ListSubscribers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscriber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscribersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscriber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscriber> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscriber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscribersAsync</summary>
        public async Task ListSubscribersResourceNamesAsync()
        {
            // Snippet: ListSubscribersAsync(ProjectName, string, int?, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSubscribersResponse, Subscriber> response = dataSubscriptionServiceClient.ListSubscribersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Subscriber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSubscribersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscriber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscriber> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscriber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriber</summary>
        public void UpdateSubscriberRequestObject()
        {
            // Snippet: UpdateSubscriber(UpdateSubscriberRequest, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            UpdateSubscriberRequest request = new UpdateSubscriberRequest
            {
                Subscriber = new Subscriber(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Subscriber, UpdateSubscriberMetadata> response = dataSubscriptionServiceClient.UpdateSubscriber(request);

            // Poll until the returned long-running operation is complete
            Operation<Subscriber, UpdateSubscriberMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subscriber result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscriber, UpdateSubscriberMetadata> retrievedResponse = dataSubscriptionServiceClient.PollOnceUpdateSubscriber(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscriber retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriberAsync</summary>
        public async Task UpdateSubscriberRequestObjectAsync()
        {
            // Snippet: UpdateSubscriberAsync(UpdateSubscriberRequest, CallSettings)
            // Additional: UpdateSubscriberAsync(UpdateSubscriberRequest, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSubscriberRequest request = new UpdateSubscriberRequest
            {
                Subscriber = new Subscriber(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Subscriber, UpdateSubscriberMetadata> response = await dataSubscriptionServiceClient.UpdateSubscriberAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Subscriber, UpdateSubscriberMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subscriber result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscriber, UpdateSubscriberMetadata> retrievedResponse = await dataSubscriptionServiceClient.PollOnceUpdateSubscriberAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscriber retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriber</summary>
        public void UpdateSubscriber()
        {
            // Snippet: UpdateSubscriber(Subscriber, FieldMask, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            Subscriber subscriber = new Subscriber();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Subscriber, UpdateSubscriberMetadata> response = dataSubscriptionServiceClient.UpdateSubscriber(subscriber, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Subscriber, UpdateSubscriberMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subscriber result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscriber, UpdateSubscriberMetadata> retrievedResponse = dataSubscriptionServiceClient.PollOnceUpdateSubscriber(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscriber retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriberAsync</summary>
        public async Task UpdateSubscriberAsync()
        {
            // Snippet: UpdateSubscriberAsync(Subscriber, FieldMask, CallSettings)
            // Additional: UpdateSubscriberAsync(Subscriber, FieldMask, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            Subscriber subscriber = new Subscriber();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Subscriber, UpdateSubscriberMetadata> response = await dataSubscriptionServiceClient.UpdateSubscriberAsync(subscriber, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Subscriber, UpdateSubscriberMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subscriber result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscriber, UpdateSubscriberMetadata> retrievedResponse = await dataSubscriptionServiceClient.PollOnceUpdateSubscriberAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscriber retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriber</summary>
        public void DeleteSubscriberRequestObject()
        {
            // Snippet: DeleteSubscriber(DeleteSubscriberRequest, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            DeleteSubscriberRequest request = new DeleteSubscriberRequest
            {
                SubscriberName = SubscriberName.FromProjectSubscriber("[PROJECT]", "[SUBSCRIBER]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteSubscriberMetadata> response = dataSubscriptionServiceClient.DeleteSubscriber(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSubscriberMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSubscriberMetadata> retrievedResponse = dataSubscriptionServiceClient.PollOnceDeleteSubscriber(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriberAsync</summary>
        public async Task DeleteSubscriberRequestObjectAsync()
        {
            // Snippet: DeleteSubscriberAsync(DeleteSubscriberRequest, CallSettings)
            // Additional: DeleteSubscriberAsync(DeleteSubscriberRequest, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSubscriberRequest request = new DeleteSubscriberRequest
            {
                SubscriberName = SubscriberName.FromProjectSubscriber("[PROJECT]", "[SUBSCRIBER]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteSubscriberMetadata> response = await dataSubscriptionServiceClient.DeleteSubscriberAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSubscriberMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSubscriberMetadata> retrievedResponse = await dataSubscriptionServiceClient.PollOnceDeleteSubscriberAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriber</summary>
        public void DeleteSubscriber()
        {
            // Snippet: DeleteSubscriber(string, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/subscribers/[SUBSCRIBER]";
            // Make the request
            Operation<Empty, DeleteSubscriberMetadata> response = dataSubscriptionServiceClient.DeleteSubscriber(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSubscriberMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSubscriberMetadata> retrievedResponse = dataSubscriptionServiceClient.PollOnceDeleteSubscriber(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriberAsync</summary>
        public async Task DeleteSubscriberAsync()
        {
            // Snippet: DeleteSubscriberAsync(string, CallSettings)
            // Additional: DeleteSubscriberAsync(string, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/subscribers/[SUBSCRIBER]";
            // Make the request
            Operation<Empty, DeleteSubscriberMetadata> response = await dataSubscriptionServiceClient.DeleteSubscriberAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSubscriberMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSubscriberMetadata> retrievedResponse = await dataSubscriptionServiceClient.PollOnceDeleteSubscriberAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriber</summary>
        public void DeleteSubscriberResourceNames()
        {
            // Snippet: DeleteSubscriber(SubscriberName, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            SubscriberName name = SubscriberName.FromProjectSubscriber("[PROJECT]", "[SUBSCRIBER]");
            // Make the request
            Operation<Empty, DeleteSubscriberMetadata> response = dataSubscriptionServiceClient.DeleteSubscriber(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSubscriberMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSubscriberMetadata> retrievedResponse = dataSubscriptionServiceClient.PollOnceDeleteSubscriber(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriberAsync</summary>
        public async Task DeleteSubscriberResourceNamesAsync()
        {
            // Snippet: DeleteSubscriberAsync(SubscriberName, CallSettings)
            // Additional: DeleteSubscriberAsync(SubscriberName, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubscriberName name = SubscriberName.FromProjectSubscriber("[PROJECT]", "[SUBSCRIBER]");
            // Make the request
            Operation<Empty, DeleteSubscriberMetadata> response = await dataSubscriptionServiceClient.DeleteSubscriberAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSubscriberMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSubscriberMetadata> retrievedResponse = await dataSubscriptionServiceClient.PollOnceDeleteSubscriberAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscriptionRequestObject()
        {
            // Snippet: CreateSubscription(CreateSubscriptionRequest, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                ParentAsSubscriberName = SubscriberName.FromProjectSubscriber("[PROJECT]", "[SUBSCRIBER]"),
                SubscriptionId = "",
                Subscription = new CreateSubscriptionPayload(),
            };
            // Make the request
            Subscription response = dataSubscriptionServiceClient.CreateSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionRequestObjectAsync()
        {
            // Snippet: CreateSubscriptionAsync(CreateSubscriptionRequest, CallSettings)
            // Additional: CreateSubscriptionAsync(CreateSubscriptionRequest, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                ParentAsSubscriberName = SubscriberName.FromProjectSubscriber("[PROJECT]", "[SUBSCRIBER]"),
                SubscriptionId = "",
                Subscription = new CreateSubscriptionPayload(),
            };
            // Make the request
            Subscription response = await dataSubscriptionServiceClient.CreateSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscription()
        {
            // Snippet: CreateSubscription(string, CreateSubscriptionPayload, string, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/subscribers/[SUBSCRIBER]";
            CreateSubscriptionPayload subscription = new CreateSubscriptionPayload();
            string subscriptionId = "";
            // Make the request
            Subscription response = dataSubscriptionServiceClient.CreateSubscription(parent, subscription, subscriptionId);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionAsync()
        {
            // Snippet: CreateSubscriptionAsync(string, CreateSubscriptionPayload, string, CallSettings)
            // Additional: CreateSubscriptionAsync(string, CreateSubscriptionPayload, string, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/subscribers/[SUBSCRIBER]";
            CreateSubscriptionPayload subscription = new CreateSubscriptionPayload();
            string subscriptionId = "";
            // Make the request
            Subscription response = await dataSubscriptionServiceClient.CreateSubscriptionAsync(parent, subscription, subscriptionId);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscriptionResourceNames()
        {
            // Snippet: CreateSubscription(SubscriberName, CreateSubscriptionPayload, string, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            SubscriberName parent = SubscriberName.FromProjectSubscriber("[PROJECT]", "[SUBSCRIBER]");
            CreateSubscriptionPayload subscription = new CreateSubscriptionPayload();
            string subscriptionId = "";
            // Make the request
            Subscription response = dataSubscriptionServiceClient.CreateSubscription(parent, subscription, subscriptionId);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionResourceNamesAsync()
        {
            // Snippet: CreateSubscriptionAsync(SubscriberName, CreateSubscriptionPayload, string, CallSettings)
            // Additional: CreateSubscriptionAsync(SubscriberName, CreateSubscriptionPayload, string, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubscriberName parent = SubscriberName.FromProjectSubscriber("[PROJECT]", "[SUBSCRIBER]");
            CreateSubscriptionPayload subscription = new CreateSubscriptionPayload();
            string subscriptionId = "";
            // Make the request
            Subscription response = await dataSubscriptionServiceClient.CreateSubscriptionAsync(parent, subscription, subscriptionId);
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptions</summary>
        public void ListSubscriptionsRequestObject()
        {
            // Snippet: ListSubscriptions(ListSubscriptionsRequest, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                ParentAsSubscriberName = SubscriberName.FromProjectSubscriber("[PROJECT]", "[SUBSCRIBER]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response = dataSubscriptionServiceClient.ListSubscriptions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptionsAsync</summary>
        public async Task ListSubscriptionsRequestObjectAsync()
        {
            // Snippet: ListSubscriptionsAsync(ListSubscriptionsRequest, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                ParentAsSubscriberName = SubscriberName.FromProjectSubscriber("[PROJECT]", "[SUBSCRIBER]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response = dataSubscriptionServiceClient.ListSubscriptionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptions</summary>
        public void ListSubscriptions()
        {
            // Snippet: ListSubscriptions(string, string, int?, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/subscribers/[SUBSCRIBER]";
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response = dataSubscriptionServiceClient.ListSubscriptions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptionsAsync</summary>
        public async Task ListSubscriptionsAsync()
        {
            // Snippet: ListSubscriptionsAsync(string, string, int?, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/subscribers/[SUBSCRIBER]";
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response = dataSubscriptionServiceClient.ListSubscriptionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptions</summary>
        public void ListSubscriptionsResourceNames()
        {
            // Snippet: ListSubscriptions(SubscriberName, string, int?, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            SubscriberName parent = SubscriberName.FromProjectSubscriber("[PROJECT]", "[SUBSCRIBER]");
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response = dataSubscriptionServiceClient.ListSubscriptions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptionsAsync</summary>
        public async Task ListSubscriptionsResourceNamesAsync()
        {
            // Snippet: ListSubscriptionsAsync(SubscriberName, string, int?, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubscriberName parent = SubscriberName.FromProjectSubscriber("[PROJECT]", "[SUBSCRIBER]");
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response = dataSubscriptionServiceClient.ListSubscriptionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscription</summary>
        public void UpdateSubscriptionRequestObject()
        {
            // Snippet: UpdateSubscription(UpdateSubscriptionRequest, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Subscription response = dataSubscriptionServiceClient.UpdateSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriptionAsync</summary>
        public async Task UpdateSubscriptionRequestObjectAsync()
        {
            // Snippet: UpdateSubscriptionAsync(UpdateSubscriptionRequest, CallSettings)
            // Additional: UpdateSubscriptionAsync(UpdateSubscriptionRequest, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Subscription response = await dataSubscriptionServiceClient.UpdateSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscription</summary>
        public void UpdateSubscription()
        {
            // Snippet: UpdateSubscription(Subscription, FieldMask, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            Subscription subscription = new Subscription();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Subscription response = dataSubscriptionServiceClient.UpdateSubscription(subscription, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriptionAsync</summary>
        public async Task UpdateSubscriptionAsync()
        {
            // Snippet: UpdateSubscriptionAsync(Subscription, FieldMask, CallSettings)
            // Additional: UpdateSubscriptionAsync(Subscription, FieldMask, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            Subscription subscription = new Subscription();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Subscription response = await dataSubscriptionServiceClient.UpdateSubscriptionAsync(subscription, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscriptionRequestObject()
        {
            // Snippet: DeleteSubscription(DeleteSubscriptionRequest, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectSubscriberSubscription("[PROJECT]", "[SUBSCRIBER]", "[SUBSCRIPTION]"),
            };
            // Make the request
            dataSubscriptionServiceClient.DeleteSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionRequestObjectAsync()
        {
            // Snippet: DeleteSubscriptionAsync(DeleteSubscriptionRequest, CallSettings)
            // Additional: DeleteSubscriptionAsync(DeleteSubscriptionRequest, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectSubscriberSubscription("[PROJECT]", "[SUBSCRIBER]", "[SUBSCRIPTION]"),
            };
            // Make the request
            await dataSubscriptionServiceClient.DeleteSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscription()
        {
            // Snippet: DeleteSubscription(string, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/subscribers/[SUBSCRIBER]/subscriptions/[SUBSCRIPTION]";
            // Make the request
            dataSubscriptionServiceClient.DeleteSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionAsync()
        {
            // Snippet: DeleteSubscriptionAsync(string, CallSettings)
            // Additional: DeleteSubscriptionAsync(string, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/subscribers/[SUBSCRIBER]/subscriptions/[SUBSCRIPTION]";
            // Make the request
            await dataSubscriptionServiceClient.DeleteSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscriptionResourceNames()
        {
            // Snippet: DeleteSubscription(SubscriptionName, CallSettings)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = DataSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromProjectSubscriberSubscription("[PROJECT]", "[SUBSCRIBER]", "[SUBSCRIPTION]");
            // Make the request
            dataSubscriptionServiceClient.DeleteSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionResourceNamesAsync()
        {
            // Snippet: DeleteSubscriptionAsync(SubscriptionName, CallSettings)
            // Additional: DeleteSubscriptionAsync(SubscriptionName, CancellationToken)
            // Create client
            DataSubscriptionServiceClient dataSubscriptionServiceClient = await DataSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromProjectSubscriberSubscription("[PROJECT]", "[SUBSCRIBER]", "[SUBSCRIPTION]");
            // Make the request
            await dataSubscriptionServiceClient.DeleteSubscriptionAsync(name);
            // End snippet
        }
    }
}
