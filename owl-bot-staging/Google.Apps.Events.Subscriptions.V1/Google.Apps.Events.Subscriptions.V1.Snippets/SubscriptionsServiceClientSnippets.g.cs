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
    using Google.Apps.Events.Subscriptions.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSubscriptionsServiceClientSnippets
    {
        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscriptionRequestObject()
        {
            // Snippet: CreateSubscription(CreateSubscriptionRequest, CallSettings)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                Subscription = new Subscription(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Subscription, CreateSubscriptionMetadata> response = subscriptionsServiceClient.CreateSubscription(request);

            // Poll until the returned long-running operation is complete
            Operation<Subscription, CreateSubscriptionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subscription result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscription, CreateSubscriptionMetadata> retrievedResponse = subscriptionsServiceClient.PollOnceCreateSubscription(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscription retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionRequestObjectAsync()
        {
            // Snippet: CreateSubscriptionAsync(CreateSubscriptionRequest, CallSettings)
            // Additional: CreateSubscriptionAsync(CreateSubscriptionRequest, CancellationToken)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                Subscription = new Subscription(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Subscription, CreateSubscriptionMetadata> response = await subscriptionsServiceClient.CreateSubscriptionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Subscription, CreateSubscriptionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subscription result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscription, CreateSubscriptionMetadata> retrievedResponse = await subscriptionsServiceClient.PollOnceCreateSubscriptionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscription retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscription()
        {
            // Snippet: CreateSubscription(Subscription, CallSettings)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            Subscription subscription = new Subscription();
            // Make the request
            Operation<Subscription, CreateSubscriptionMetadata> response = subscriptionsServiceClient.CreateSubscription(subscription);

            // Poll until the returned long-running operation is complete
            Operation<Subscription, CreateSubscriptionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subscription result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscription, CreateSubscriptionMetadata> retrievedResponse = subscriptionsServiceClient.PollOnceCreateSubscription(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscription retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionAsync()
        {
            // Snippet: CreateSubscriptionAsync(Subscription, CallSettings)
            // Additional: CreateSubscriptionAsync(Subscription, CancellationToken)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Subscription subscription = new Subscription();
            // Make the request
            Operation<Subscription, CreateSubscriptionMetadata> response = await subscriptionsServiceClient.CreateSubscriptionAsync(subscription);

            // Poll until the returned long-running operation is complete
            Operation<Subscription, CreateSubscriptionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subscription result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscription, CreateSubscriptionMetadata> retrievedResponse = await subscriptionsServiceClient.PollOnceCreateSubscriptionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscription retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscriptionRequestObject()
        {
            // Snippet: DeleteSubscription(DeleteSubscriptionRequest, CallSettings)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromSubscription("[SUBSCRIPTION]"),
                ValidateOnly = false,
                AllowMissing = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, DeleteSubscriptionMetadata> response = subscriptionsServiceClient.DeleteSubscription(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSubscriptionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSubscriptionMetadata> retrievedResponse = subscriptionsServiceClient.PollOnceDeleteSubscription(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionRequestObjectAsync()
        {
            // Snippet: DeleteSubscriptionAsync(DeleteSubscriptionRequest, CallSettings)
            // Additional: DeleteSubscriptionAsync(DeleteSubscriptionRequest, CancellationToken)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromSubscription("[SUBSCRIPTION]"),
                ValidateOnly = false,
                AllowMissing = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, DeleteSubscriptionMetadata> response = await subscriptionsServiceClient.DeleteSubscriptionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSubscriptionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSubscriptionMetadata> retrievedResponse = await subscriptionsServiceClient.PollOnceDeleteSubscriptionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscription()
        {
            // Snippet: DeleteSubscription(string, CallSettings)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            string name = "subscriptions/[SUBSCRIPTION]";
            // Make the request
            Operation<Empty, DeleteSubscriptionMetadata> response = subscriptionsServiceClient.DeleteSubscription(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSubscriptionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSubscriptionMetadata> retrievedResponse = subscriptionsServiceClient.PollOnceDeleteSubscription(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionAsync()
        {
            // Snippet: DeleteSubscriptionAsync(string, CallSettings)
            // Additional: DeleteSubscriptionAsync(string, CancellationToken)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "subscriptions/[SUBSCRIPTION]";
            // Make the request
            Operation<Empty, DeleteSubscriptionMetadata> response = await subscriptionsServiceClient.DeleteSubscriptionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSubscriptionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSubscriptionMetadata> retrievedResponse = await subscriptionsServiceClient.PollOnceDeleteSubscriptionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscriptionResourceNames()
        {
            // Snippet: DeleteSubscription(SubscriptionName, CallSettings)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromSubscription("[SUBSCRIPTION]");
            // Make the request
            Operation<Empty, DeleteSubscriptionMetadata> response = subscriptionsServiceClient.DeleteSubscription(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSubscriptionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSubscriptionMetadata> retrievedResponse = subscriptionsServiceClient.PollOnceDeleteSubscription(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionResourceNamesAsync()
        {
            // Snippet: DeleteSubscriptionAsync(SubscriptionName, CallSettings)
            // Additional: DeleteSubscriptionAsync(SubscriptionName, CancellationToken)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromSubscription("[SUBSCRIPTION]");
            // Make the request
            Operation<Empty, DeleteSubscriptionMetadata> response = await subscriptionsServiceClient.DeleteSubscriptionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSubscriptionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSubscriptionMetadata> retrievedResponse = await subscriptionsServiceClient.PollOnceDeleteSubscriptionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetSubscription</summary>
        public void GetSubscriptionRequestObject()
        {
            // Snippet: GetSubscription(GetSubscriptionRequest, CallSettings)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromSubscription("[SUBSCRIPTION]"),
            };
            // Make the request
            Subscription response = subscriptionsServiceClient.GetSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for GetSubscriptionAsync</summary>
        public async Task GetSubscriptionRequestObjectAsync()
        {
            // Snippet: GetSubscriptionAsync(GetSubscriptionRequest, CallSettings)
            // Additional: GetSubscriptionAsync(GetSubscriptionRequest, CancellationToken)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromSubscription("[SUBSCRIPTION]"),
            };
            // Make the request
            Subscription response = await subscriptionsServiceClient.GetSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSubscription</summary>
        public void GetSubscription()
        {
            // Snippet: GetSubscription(string, CallSettings)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            string name = "subscriptions/[SUBSCRIPTION]";
            // Make the request
            Subscription response = subscriptionsServiceClient.GetSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubscriptionAsync</summary>
        public async Task GetSubscriptionAsync()
        {
            // Snippet: GetSubscriptionAsync(string, CallSettings)
            // Additional: GetSubscriptionAsync(string, CancellationToken)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "subscriptions/[SUBSCRIPTION]";
            // Make the request
            Subscription response = await subscriptionsServiceClient.GetSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubscription</summary>
        public void GetSubscriptionResourceNames()
        {
            // Snippet: GetSubscription(SubscriptionName, CallSettings)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromSubscription("[SUBSCRIPTION]");
            // Make the request
            Subscription response = subscriptionsServiceClient.GetSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubscriptionAsync</summary>
        public async Task GetSubscriptionResourceNamesAsync()
        {
            // Snippet: GetSubscriptionAsync(SubscriptionName, CallSettings)
            // Additional: GetSubscriptionAsync(SubscriptionName, CancellationToken)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromSubscription("[SUBSCRIPTION]");
            // Make the request
            Subscription response = await subscriptionsServiceClient.GetSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptions</summary>
        public void ListSubscriptionsRequestObject()
        {
            // Snippet: ListSubscriptions(ListSubscriptionsRequest, CallSettings)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            ListSubscriptionsRequest request = new ListSubscriptionsRequest { Filter = "", };
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response = subscriptionsServiceClient.ListSubscriptions(request);

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
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSubscriptionsRequest request = new ListSubscriptionsRequest { Filter = "", };
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response = subscriptionsServiceClient.ListSubscriptionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subscription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            string filter = "";
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response = subscriptionsServiceClient.ListSubscriptions(filter);

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
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response = subscriptionsServiceClient.ListSubscriptionsAsync(filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subscription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Subscription, UpdateSubscriptionMetadata> response = subscriptionsServiceClient.UpdateSubscription(request);

            // Poll until the returned long-running operation is complete
            Operation<Subscription, UpdateSubscriptionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subscription result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscription, UpdateSubscriptionMetadata> retrievedResponse = subscriptionsServiceClient.PollOnceUpdateSubscription(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscription retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriptionAsync</summary>
        public async Task UpdateSubscriptionRequestObjectAsync()
        {
            // Snippet: UpdateSubscriptionAsync(UpdateSubscriptionRequest, CallSettings)
            // Additional: UpdateSubscriptionAsync(UpdateSubscriptionRequest, CancellationToken)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Subscription, UpdateSubscriptionMetadata> response = await subscriptionsServiceClient.UpdateSubscriptionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Subscription, UpdateSubscriptionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subscription result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscription, UpdateSubscriptionMetadata> retrievedResponse = await subscriptionsServiceClient.PollOnceUpdateSubscriptionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscription retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscription</summary>
        public void UpdateSubscription()
        {
            // Snippet: UpdateSubscription(Subscription, FieldMask, CallSettings)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            Subscription subscription = new Subscription();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Subscription, UpdateSubscriptionMetadata> response = subscriptionsServiceClient.UpdateSubscription(subscription, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Subscription, UpdateSubscriptionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subscription result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscription, UpdateSubscriptionMetadata> retrievedResponse = subscriptionsServiceClient.PollOnceUpdateSubscription(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscription retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriptionAsync</summary>
        public async Task UpdateSubscriptionAsync()
        {
            // Snippet: UpdateSubscriptionAsync(Subscription, FieldMask, CallSettings)
            // Additional: UpdateSubscriptionAsync(Subscription, FieldMask, CancellationToken)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Subscription subscription = new Subscription();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Subscription, UpdateSubscriptionMetadata> response = await subscriptionsServiceClient.UpdateSubscriptionAsync(subscription, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Subscription, UpdateSubscriptionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subscription result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscription, UpdateSubscriptionMetadata> retrievedResponse = await subscriptionsServiceClient.PollOnceUpdateSubscriptionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscription retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReactivateSubscription</summary>
        public void ReactivateSubscriptionRequestObject()
        {
            // Snippet: ReactivateSubscription(ReactivateSubscriptionRequest, CallSettings)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            ReactivateSubscriptionRequest request = new ReactivateSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromSubscription("[SUBSCRIPTION]"),
            };
            // Make the request
            Operation<Subscription, ReactivateSubscriptionMetadata> response = subscriptionsServiceClient.ReactivateSubscription(request);

            // Poll until the returned long-running operation is complete
            Operation<Subscription, ReactivateSubscriptionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subscription result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscription, ReactivateSubscriptionMetadata> retrievedResponse = subscriptionsServiceClient.PollOnceReactivateSubscription(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscription retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReactivateSubscriptionAsync</summary>
        public async Task ReactivateSubscriptionRequestObjectAsync()
        {
            // Snippet: ReactivateSubscriptionAsync(ReactivateSubscriptionRequest, CallSettings)
            // Additional: ReactivateSubscriptionAsync(ReactivateSubscriptionRequest, CancellationToken)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReactivateSubscriptionRequest request = new ReactivateSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromSubscription("[SUBSCRIPTION]"),
            };
            // Make the request
            Operation<Subscription, ReactivateSubscriptionMetadata> response = await subscriptionsServiceClient.ReactivateSubscriptionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Subscription, ReactivateSubscriptionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subscription result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscription, ReactivateSubscriptionMetadata> retrievedResponse = await subscriptionsServiceClient.PollOnceReactivateSubscriptionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscription retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReactivateSubscription</summary>
        public void ReactivateSubscription()
        {
            // Snippet: ReactivateSubscription(string, CallSettings)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            string name = "subscriptions/[SUBSCRIPTION]";
            // Make the request
            Operation<Subscription, ReactivateSubscriptionMetadata> response = subscriptionsServiceClient.ReactivateSubscription(name);

            // Poll until the returned long-running operation is complete
            Operation<Subscription, ReactivateSubscriptionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subscription result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscription, ReactivateSubscriptionMetadata> retrievedResponse = subscriptionsServiceClient.PollOnceReactivateSubscription(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscription retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReactivateSubscriptionAsync</summary>
        public async Task ReactivateSubscriptionAsync()
        {
            // Snippet: ReactivateSubscriptionAsync(string, CallSettings)
            // Additional: ReactivateSubscriptionAsync(string, CancellationToken)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "subscriptions/[SUBSCRIPTION]";
            // Make the request
            Operation<Subscription, ReactivateSubscriptionMetadata> response = await subscriptionsServiceClient.ReactivateSubscriptionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Subscription, ReactivateSubscriptionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subscription result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscription, ReactivateSubscriptionMetadata> retrievedResponse = await subscriptionsServiceClient.PollOnceReactivateSubscriptionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscription retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReactivateSubscription</summary>
        public void ReactivateSubscriptionResourceNames()
        {
            // Snippet: ReactivateSubscription(SubscriptionName, CallSettings)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = SubscriptionsServiceClient.Create();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromSubscription("[SUBSCRIPTION]");
            // Make the request
            Operation<Subscription, ReactivateSubscriptionMetadata> response = subscriptionsServiceClient.ReactivateSubscription(name);

            // Poll until the returned long-running operation is complete
            Operation<Subscription, ReactivateSubscriptionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subscription result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscription, ReactivateSubscriptionMetadata> retrievedResponse = subscriptionsServiceClient.PollOnceReactivateSubscription(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscription retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReactivateSubscriptionAsync</summary>
        public async Task ReactivateSubscriptionResourceNamesAsync()
        {
            // Snippet: ReactivateSubscriptionAsync(SubscriptionName, CallSettings)
            // Additional: ReactivateSubscriptionAsync(SubscriptionName, CancellationToken)
            // Create client
            SubscriptionsServiceClient subscriptionsServiceClient = await SubscriptionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromSubscription("[SUBSCRIPTION]");
            // Make the request
            Operation<Subscription, ReactivateSubscriptionMetadata> response = await subscriptionsServiceClient.ReactivateSubscriptionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Subscription, ReactivateSubscriptionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subscription result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subscription, ReactivateSubscriptionMetadata> retrievedResponse = await subscriptionsServiceClient.PollOnceReactivateSubscriptionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subscription retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
