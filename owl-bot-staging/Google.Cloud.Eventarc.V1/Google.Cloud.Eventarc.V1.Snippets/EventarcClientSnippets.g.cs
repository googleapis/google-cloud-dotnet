// Copyright 2022 Google LLC
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

namespace Google.Cloud.Eventarc.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedEventarcClientSnippets
    {
        /// <summary>Snippet for GetTrigger</summary>
        public void GetTriggerRequestObject()
        {
            // Snippet: GetTrigger(GetTriggerRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            GetTriggerRequest request = new GetTriggerRequest
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
            };
            // Make the request
            Trigger response = eventarcClient.GetTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for GetTriggerAsync</summary>
        public async Task GetTriggerRequestObjectAsync()
        {
            // Snippet: GetTriggerAsync(GetTriggerRequest, CallSettings)
            // Additional: GetTriggerAsync(GetTriggerRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            GetTriggerRequest request = new GetTriggerRequest
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
            };
            // Make the request
            Trigger response = await eventarcClient.GetTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTrigger</summary>
        public void GetTrigger()
        {
            // Snippet: GetTrigger(string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/triggers/[TRIGGER]";
            // Make the request
            Trigger response = eventarcClient.GetTrigger(name);
            // End snippet
        }

        /// <summary>Snippet for GetTriggerAsync</summary>
        public async Task GetTriggerAsync()
        {
            // Snippet: GetTriggerAsync(string, CallSettings)
            // Additional: GetTriggerAsync(string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/triggers/[TRIGGER]";
            // Make the request
            Trigger response = await eventarcClient.GetTriggerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTrigger</summary>
        public void GetTriggerResourceNames()
        {
            // Snippet: GetTrigger(TriggerName, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            TriggerName name = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]");
            // Make the request
            Trigger response = eventarcClient.GetTrigger(name);
            // End snippet
        }

        /// <summary>Snippet for GetTriggerAsync</summary>
        public async Task GetTriggerResourceNamesAsync()
        {
            // Snippet: GetTriggerAsync(TriggerName, CallSettings)
            // Additional: GetTriggerAsync(TriggerName, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            TriggerName name = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]");
            // Make the request
            Trigger response = await eventarcClient.GetTriggerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTriggers</summary>
        public void ListTriggersRequestObject()
        {
            // Snippet: ListTriggers(ListTriggersRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            ListTriggersRequest request = new ListTriggersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListTriggersResponse, Trigger> response = eventarcClient.ListTriggers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Trigger item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTriggersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trigger item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trigger> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trigger item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTriggersAsync</summary>
        public async Task ListTriggersRequestObjectAsync()
        {
            // Snippet: ListTriggersAsync(ListTriggersRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            ListTriggersRequest request = new ListTriggersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTriggersResponse, Trigger> response = eventarcClient.ListTriggersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Trigger item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTriggersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trigger item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trigger> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trigger item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTriggers</summary>
        public void ListTriggers()
        {
            // Snippet: ListTriggers(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTriggersResponse, Trigger> response = eventarcClient.ListTriggers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Trigger item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTriggersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trigger item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trigger> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trigger item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTriggersAsync</summary>
        public async Task ListTriggersAsync()
        {
            // Snippet: ListTriggersAsync(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTriggersResponse, Trigger> response = eventarcClient.ListTriggersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Trigger item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTriggersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trigger item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trigger> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trigger item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTriggers</summary>
        public void ListTriggersResourceNames()
        {
            // Snippet: ListTriggers(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTriggersResponse, Trigger> response = eventarcClient.ListTriggers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Trigger item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTriggersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trigger item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trigger> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trigger item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTriggersAsync</summary>
        public async Task ListTriggersResourceNamesAsync()
        {
            // Snippet: ListTriggersAsync(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTriggersResponse, Trigger> response = eventarcClient.ListTriggersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Trigger item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTriggersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trigger item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trigger> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trigger item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateTrigger</summary>
        public void CreateTriggerRequestObject()
        {
            // Snippet: CreateTrigger(CreateTriggerRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            CreateTriggerRequest request = new CreateTriggerRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Trigger = new Trigger(),
                TriggerId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Trigger, OperationMetadata> response = eventarcClient.CreateTrigger(request);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateTrigger(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTriggerAsync</summary>
        public async Task CreateTriggerRequestObjectAsync()
        {
            // Snippet: CreateTriggerAsync(CreateTriggerRequest, CallSettings)
            // Additional: CreateTriggerAsync(CreateTriggerRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            CreateTriggerRequest request = new CreateTriggerRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Trigger = new Trigger(),
                TriggerId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Trigger, OperationMetadata> response = await eventarcClient.CreateTriggerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateTriggerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTrigger</summary>
        public void CreateTrigger()
        {
            // Snippet: CreateTrigger(string, Trigger, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Trigger trigger = new Trigger();
            string triggerId = "";
            // Make the request
            Operation<Trigger, OperationMetadata> response = eventarcClient.CreateTrigger(parent, trigger, triggerId);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateTrigger(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTriggerAsync</summary>
        public async Task CreateTriggerAsync()
        {
            // Snippet: CreateTriggerAsync(string, Trigger, string, CallSettings)
            // Additional: CreateTriggerAsync(string, Trigger, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Trigger trigger = new Trigger();
            string triggerId = "";
            // Make the request
            Operation<Trigger, OperationMetadata> response = await eventarcClient.CreateTriggerAsync(parent, trigger, triggerId);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateTriggerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTrigger</summary>
        public void CreateTriggerResourceNames()
        {
            // Snippet: CreateTrigger(LocationName, Trigger, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Trigger trigger = new Trigger();
            string triggerId = "";
            // Make the request
            Operation<Trigger, OperationMetadata> response = eventarcClient.CreateTrigger(parent, trigger, triggerId);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateTrigger(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTriggerAsync</summary>
        public async Task CreateTriggerResourceNamesAsync()
        {
            // Snippet: CreateTriggerAsync(LocationName, Trigger, string, CallSettings)
            // Additional: CreateTriggerAsync(LocationName, Trigger, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Trigger trigger = new Trigger();
            string triggerId = "";
            // Make the request
            Operation<Trigger, OperationMetadata> response = await eventarcClient.CreateTriggerAsync(parent, trigger, triggerId);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateTriggerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTrigger</summary>
        public void UpdateTriggerRequestObject()
        {
            // Snippet: UpdateTrigger(UpdateTriggerRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            UpdateTriggerRequest request = new UpdateTriggerRequest
            {
                Trigger = new Trigger(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Trigger, OperationMetadata> response = eventarcClient.UpdateTrigger(request);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = eventarcClient.PollOnceUpdateTrigger(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTriggerAsync</summary>
        public async Task UpdateTriggerRequestObjectAsync()
        {
            // Snippet: UpdateTriggerAsync(UpdateTriggerRequest, CallSettings)
            // Additional: UpdateTriggerAsync(UpdateTriggerRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTriggerRequest request = new UpdateTriggerRequest
            {
                Trigger = new Trigger(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Trigger, OperationMetadata> response = await eventarcClient.UpdateTriggerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceUpdateTriggerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTrigger</summary>
        public void UpdateTrigger()
        {
            // Snippet: UpdateTrigger(Trigger, FieldMask, bool, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            Trigger trigger = new Trigger();
            FieldMask updateMask = new FieldMask();
            bool allowMissing = false;
            // Make the request
            Operation<Trigger, OperationMetadata> response = eventarcClient.UpdateTrigger(trigger, updateMask, allowMissing);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = eventarcClient.PollOnceUpdateTrigger(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTriggerAsync</summary>
        public async Task UpdateTriggerAsync()
        {
            // Snippet: UpdateTriggerAsync(Trigger, FieldMask, bool, CallSettings)
            // Additional: UpdateTriggerAsync(Trigger, FieldMask, bool, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            Trigger trigger = new Trigger();
            FieldMask updateMask = new FieldMask();
            bool allowMissing = false;
            // Make the request
            Operation<Trigger, OperationMetadata> response = await eventarcClient.UpdateTriggerAsync(trigger, updateMask, allowMissing);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceUpdateTriggerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTrigger</summary>
        public void DeleteTriggerRequestObject()
        {
            // Snippet: DeleteTrigger(DeleteTriggerRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            DeleteTriggerRequest request = new DeleteTriggerRequest
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
                Etag = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Trigger, OperationMetadata> response = eventarcClient.DeleteTrigger(request);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteTrigger(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTriggerAsync</summary>
        public async Task DeleteTriggerRequestObjectAsync()
        {
            // Snippet: DeleteTriggerAsync(DeleteTriggerRequest, CallSettings)
            // Additional: DeleteTriggerAsync(DeleteTriggerRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTriggerRequest request = new DeleteTriggerRequest
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
                Etag = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Trigger, OperationMetadata> response = await eventarcClient.DeleteTriggerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteTriggerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTrigger</summary>
        public void DeleteTrigger()
        {
            // Snippet: DeleteTrigger(string, bool, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/triggers/[TRIGGER]";
            bool allowMissing = false;
            // Make the request
            Operation<Trigger, OperationMetadata> response = eventarcClient.DeleteTrigger(name, allowMissing);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteTrigger(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTriggerAsync</summary>
        public async Task DeleteTriggerAsync()
        {
            // Snippet: DeleteTriggerAsync(string, bool, CallSettings)
            // Additional: DeleteTriggerAsync(string, bool, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/triggers/[TRIGGER]";
            bool allowMissing = false;
            // Make the request
            Operation<Trigger, OperationMetadata> response = await eventarcClient.DeleteTriggerAsync(name, allowMissing);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteTriggerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTrigger</summary>
        public void DeleteTriggerResourceNames()
        {
            // Snippet: DeleteTrigger(TriggerName, bool, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            TriggerName name = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]");
            bool allowMissing = false;
            // Make the request
            Operation<Trigger, OperationMetadata> response = eventarcClient.DeleteTrigger(name, allowMissing);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteTrigger(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTriggerAsync</summary>
        public async Task DeleteTriggerResourceNamesAsync()
        {
            // Snippet: DeleteTriggerAsync(TriggerName, bool, CallSettings)
            // Additional: DeleteTriggerAsync(TriggerName, bool, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            TriggerName name = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]");
            bool allowMissing = false;
            // Make the request
            Operation<Trigger, OperationMetadata> response = await eventarcClient.DeleteTriggerAsync(name, allowMissing);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteTriggerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
