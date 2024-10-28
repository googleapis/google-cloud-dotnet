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
    using Google.Cloud.Eventarc.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEventarcClientSnippets
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
                Filter = "",
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
                Filter = "",
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

        /// <summary>Snippet for GetChannel</summary>
        public void GetChannelRequestObject()
        {
            // Snippet: GetChannel(GetChannelRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            GetChannelRequest request = new GetChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
            };
            // Make the request
            Channel response = eventarcClient.GetChannel(request);
            // End snippet
        }

        /// <summary>Snippet for GetChannelAsync</summary>
        public async Task GetChannelRequestObjectAsync()
        {
            // Snippet: GetChannelAsync(GetChannelRequest, CallSettings)
            // Additional: GetChannelAsync(GetChannelRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            GetChannelRequest request = new GetChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
            };
            // Make the request
            Channel response = await eventarcClient.GetChannelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetChannel</summary>
        public void GetChannel()
        {
            // Snippet: GetChannel(string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            // Make the request
            Channel response = eventarcClient.GetChannel(name);
            // End snippet
        }

        /// <summary>Snippet for GetChannelAsync</summary>
        public async Task GetChannelAsync()
        {
            // Snippet: GetChannelAsync(string, CallSettings)
            // Additional: GetChannelAsync(string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            // Make the request
            Channel response = await eventarcClient.GetChannelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetChannel</summary>
        public void GetChannelResourceNames()
        {
            // Snippet: GetChannel(ChannelName, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            ChannelName name = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            // Make the request
            Channel response = eventarcClient.GetChannel(name);
            // End snippet
        }

        /// <summary>Snippet for GetChannelAsync</summary>
        public async Task GetChannelResourceNamesAsync()
        {
            // Snippet: GetChannelAsync(ChannelName, CallSettings)
            // Additional: GetChannelAsync(ChannelName, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            ChannelName name = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            // Make the request
            Channel response = await eventarcClient.GetChannelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListChannels</summary>
        public void ListChannelsRequestObject()
        {
            // Snippet: ListChannels(ListChannelsRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            ListChannelsRequest request = new ListChannelsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListChannelsResponse, Channel> response = eventarcClient.ListChannels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Channel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChannelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Channel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Channel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Channel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelsAsync</summary>
        public async Task ListChannelsRequestObjectAsync()
        {
            // Snippet: ListChannelsAsync(ListChannelsRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            ListChannelsRequest request = new ListChannelsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListChannelsResponse, Channel> response = eventarcClient.ListChannelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Channel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChannelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Channel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Channel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Channel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannels</summary>
        public void ListChannels()
        {
            // Snippet: ListChannels(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListChannelsResponse, Channel> response = eventarcClient.ListChannels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Channel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChannelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Channel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Channel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Channel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelsAsync</summary>
        public async Task ListChannelsAsync()
        {
            // Snippet: ListChannelsAsync(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListChannelsResponse, Channel> response = eventarcClient.ListChannelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Channel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChannelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Channel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Channel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Channel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannels</summary>
        public void ListChannelsResourceNames()
        {
            // Snippet: ListChannels(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListChannelsResponse, Channel> response = eventarcClient.ListChannels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Channel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChannelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Channel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Channel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Channel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelsAsync</summary>
        public async Task ListChannelsResourceNamesAsync()
        {
            // Snippet: ListChannelsAsync(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListChannelsResponse, Channel> response = eventarcClient.ListChannelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Channel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChannelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Channel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Channel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Channel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateChannel</summary>
        public void CreateChannelRequestObject()
        {
            // Snippet: CreateChannel(CreateChannelRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            CreateChannelRequest request = new CreateChannelRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Channel = new Channel(),
                ChannelId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Channel, OperationMetadata> response = eventarcClient.CreateChannel(request);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannelAsync</summary>
        public async Task CreateChannelRequestObjectAsync()
        {
            // Snippet: CreateChannelAsync(CreateChannelRequest, CallSettings)
            // Additional: CreateChannelAsync(CreateChannelRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            CreateChannelRequest request = new CreateChannelRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Channel = new Channel(),
                ChannelId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Channel, OperationMetadata> response = await eventarcClient.CreateChannelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannel</summary>
        public void CreateChannel()
        {
            // Snippet: CreateChannel(string, Channel, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Channel channel = new Channel();
            string channelId = "";
            // Make the request
            Operation<Channel, OperationMetadata> response = eventarcClient.CreateChannel(parent, channel, channelId);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannelAsync</summary>
        public async Task CreateChannelAsync()
        {
            // Snippet: CreateChannelAsync(string, Channel, string, CallSettings)
            // Additional: CreateChannelAsync(string, Channel, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Channel channel = new Channel();
            string channelId = "";
            // Make the request
            Operation<Channel, OperationMetadata> response = await eventarcClient.CreateChannelAsync(parent, channel, channelId);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannel</summary>
        public void CreateChannelResourceNames()
        {
            // Snippet: CreateChannel(LocationName, Channel, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Channel channel = new Channel();
            string channelId = "";
            // Make the request
            Operation<Channel, OperationMetadata> response = eventarcClient.CreateChannel(parent, channel, channelId);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannelAsync</summary>
        public async Task CreateChannelResourceNamesAsync()
        {
            // Snippet: CreateChannelAsync(LocationName, Channel, string, CallSettings)
            // Additional: CreateChannelAsync(LocationName, Channel, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Channel channel = new Channel();
            string channelId = "";
            // Make the request
            Operation<Channel, OperationMetadata> response = await eventarcClient.CreateChannelAsync(parent, channel, channelId);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateChannel</summary>
        public void UpdateChannelRequestObject()
        {
            // Snippet: UpdateChannel(UpdateChannelRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            UpdateChannelRequest request = new UpdateChannelRequest
            {
                Channel = new Channel(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Channel, OperationMetadata> response = eventarcClient.UpdateChannel(request);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = eventarcClient.PollOnceUpdateChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateChannelAsync</summary>
        public async Task UpdateChannelRequestObjectAsync()
        {
            // Snippet: UpdateChannelAsync(UpdateChannelRequest, CallSettings)
            // Additional: UpdateChannelAsync(UpdateChannelRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            UpdateChannelRequest request = new UpdateChannelRequest
            {
                Channel = new Channel(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Channel, OperationMetadata> response = await eventarcClient.UpdateChannelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceUpdateChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateChannel</summary>
        public void UpdateChannel()
        {
            // Snippet: UpdateChannel(Channel, FieldMask, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            Channel channel = new Channel();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Channel, OperationMetadata> response = eventarcClient.UpdateChannel(channel, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = eventarcClient.PollOnceUpdateChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateChannelAsync</summary>
        public async Task UpdateChannelAsync()
        {
            // Snippet: UpdateChannelAsync(Channel, FieldMask, CallSettings)
            // Additional: UpdateChannelAsync(Channel, FieldMask, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            Channel channel = new Channel();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Channel, OperationMetadata> response = await eventarcClient.UpdateChannelAsync(channel, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceUpdateChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannel</summary>
        public void DeleteChannelRequestObject()
        {
            // Snippet: DeleteChannel(DeleteChannelRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            DeleteChannelRequest request = new DeleteChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Channel, OperationMetadata> response = eventarcClient.DeleteChannel(request);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelAsync</summary>
        public async Task DeleteChannelRequestObjectAsync()
        {
            // Snippet: DeleteChannelAsync(DeleteChannelRequest, CallSettings)
            // Additional: DeleteChannelAsync(DeleteChannelRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            DeleteChannelRequest request = new DeleteChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Channel, OperationMetadata> response = await eventarcClient.DeleteChannelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannel</summary>
        public void DeleteChannel()
        {
            // Snippet: DeleteChannel(string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            // Make the request
            Operation<Channel, OperationMetadata> response = eventarcClient.DeleteChannel(name);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelAsync</summary>
        public async Task DeleteChannelAsync()
        {
            // Snippet: DeleteChannelAsync(string, CallSettings)
            // Additional: DeleteChannelAsync(string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            // Make the request
            Operation<Channel, OperationMetadata> response = await eventarcClient.DeleteChannelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannel</summary>
        public void DeleteChannelResourceNames()
        {
            // Snippet: DeleteChannel(ChannelName, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            ChannelName name = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            // Make the request
            Operation<Channel, OperationMetadata> response = eventarcClient.DeleteChannel(name);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelAsync</summary>
        public async Task DeleteChannelResourceNamesAsync()
        {
            // Snippet: DeleteChannelAsync(ChannelName, CallSettings)
            // Additional: DeleteChannelAsync(ChannelName, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            ChannelName name = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            // Make the request
            Operation<Channel, OperationMetadata> response = await eventarcClient.DeleteChannelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetProvider</summary>
        public void GetProviderRequestObject()
        {
            // Snippet: GetProvider(GetProviderRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            GetProviderRequest request = new GetProviderRequest
            {
                ProviderName = ProviderName.FromProjectLocationProvider("[PROJECT]", "[LOCATION]", "[PROVIDER]"),
            };
            // Make the request
            Provider response = eventarcClient.GetProvider(request);
            // End snippet
        }

        /// <summary>Snippet for GetProviderAsync</summary>
        public async Task GetProviderRequestObjectAsync()
        {
            // Snippet: GetProviderAsync(GetProviderRequest, CallSettings)
            // Additional: GetProviderAsync(GetProviderRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            GetProviderRequest request = new GetProviderRequest
            {
                ProviderName = ProviderName.FromProjectLocationProvider("[PROJECT]", "[LOCATION]", "[PROVIDER]"),
            };
            // Make the request
            Provider response = await eventarcClient.GetProviderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProvider</summary>
        public void GetProvider()
        {
            // Snippet: GetProvider(string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/providers/[PROVIDER]";
            // Make the request
            Provider response = eventarcClient.GetProvider(name);
            // End snippet
        }

        /// <summary>Snippet for GetProviderAsync</summary>
        public async Task GetProviderAsync()
        {
            // Snippet: GetProviderAsync(string, CallSettings)
            // Additional: GetProviderAsync(string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/providers/[PROVIDER]";
            // Make the request
            Provider response = await eventarcClient.GetProviderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProvider</summary>
        public void GetProviderResourceNames()
        {
            // Snippet: GetProvider(ProviderName, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            ProviderName name = ProviderName.FromProjectLocationProvider("[PROJECT]", "[LOCATION]", "[PROVIDER]");
            // Make the request
            Provider response = eventarcClient.GetProvider(name);
            // End snippet
        }

        /// <summary>Snippet for GetProviderAsync</summary>
        public async Task GetProviderResourceNamesAsync()
        {
            // Snippet: GetProviderAsync(ProviderName, CallSettings)
            // Additional: GetProviderAsync(ProviderName, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            ProviderName name = ProviderName.FromProjectLocationProvider("[PROJECT]", "[LOCATION]", "[PROVIDER]");
            // Make the request
            Provider response = await eventarcClient.GetProviderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProviders</summary>
        public void ListProvidersRequestObject()
        {
            // Snippet: ListProviders(ListProvidersRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            ListProvidersRequest request = new ListProvidersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListProvidersResponse, Provider> response = eventarcClient.ListProviders(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Provider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Provider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Provider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Provider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProvidersAsync</summary>
        public async Task ListProvidersRequestObjectAsync()
        {
            // Snippet: ListProvidersAsync(ListProvidersRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            ListProvidersRequest request = new ListProvidersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListProvidersResponse, Provider> response = eventarcClient.ListProvidersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Provider item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProvidersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Provider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Provider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Provider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProviders</summary>
        public void ListProviders()
        {
            // Snippet: ListProviders(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListProvidersResponse, Provider> response = eventarcClient.ListProviders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Provider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Provider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Provider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Provider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProvidersAsync</summary>
        public async Task ListProvidersAsync()
        {
            // Snippet: ListProvidersAsync(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListProvidersResponse, Provider> response = eventarcClient.ListProvidersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Provider item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProvidersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Provider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Provider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Provider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProviders</summary>
        public void ListProvidersResourceNames()
        {
            // Snippet: ListProviders(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListProvidersResponse, Provider> response = eventarcClient.ListProviders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Provider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Provider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Provider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Provider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProvidersAsync</summary>
        public async Task ListProvidersResourceNamesAsync()
        {
            // Snippet: ListProvidersAsync(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListProvidersResponse, Provider> response = eventarcClient.ListProvidersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Provider item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProvidersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Provider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Provider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Provider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetChannelConnection</summary>
        public void GetChannelConnectionRequestObject()
        {
            // Snippet: GetChannelConnection(GetChannelConnectionRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            GetChannelConnectionRequest request = new GetChannelConnectionRequest
            {
                ChannelConnectionName = ChannelConnectionName.FromProjectLocationChannelConnection("[PROJECT]", "[LOCATION]", "[CHANNEL_CONNECTION]"),
            };
            // Make the request
            ChannelConnection response = eventarcClient.GetChannelConnection(request);
            // End snippet
        }

        /// <summary>Snippet for GetChannelConnectionAsync</summary>
        public async Task GetChannelConnectionRequestObjectAsync()
        {
            // Snippet: GetChannelConnectionAsync(GetChannelConnectionRequest, CallSettings)
            // Additional: GetChannelConnectionAsync(GetChannelConnectionRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            GetChannelConnectionRequest request = new GetChannelConnectionRequest
            {
                ChannelConnectionName = ChannelConnectionName.FromProjectLocationChannelConnection("[PROJECT]", "[LOCATION]", "[CHANNEL_CONNECTION]"),
            };
            // Make the request
            ChannelConnection response = await eventarcClient.GetChannelConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetChannelConnection</summary>
        public void GetChannelConnection()
        {
            // Snippet: GetChannelConnection(string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channelConnections/[CHANNEL_CONNECTION]";
            // Make the request
            ChannelConnection response = eventarcClient.GetChannelConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetChannelConnectionAsync</summary>
        public async Task GetChannelConnectionAsync()
        {
            // Snippet: GetChannelConnectionAsync(string, CallSettings)
            // Additional: GetChannelConnectionAsync(string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channelConnections/[CHANNEL_CONNECTION]";
            // Make the request
            ChannelConnection response = await eventarcClient.GetChannelConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetChannelConnection</summary>
        public void GetChannelConnectionResourceNames()
        {
            // Snippet: GetChannelConnection(ChannelConnectionName, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            ChannelConnectionName name = ChannelConnectionName.FromProjectLocationChannelConnection("[PROJECT]", "[LOCATION]", "[CHANNEL_CONNECTION]");
            // Make the request
            ChannelConnection response = eventarcClient.GetChannelConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetChannelConnectionAsync</summary>
        public async Task GetChannelConnectionResourceNamesAsync()
        {
            // Snippet: GetChannelConnectionAsync(ChannelConnectionName, CallSettings)
            // Additional: GetChannelConnectionAsync(ChannelConnectionName, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            ChannelConnectionName name = ChannelConnectionName.FromProjectLocationChannelConnection("[PROJECT]", "[LOCATION]", "[CHANNEL_CONNECTION]");
            // Make the request
            ChannelConnection response = await eventarcClient.GetChannelConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListChannelConnections</summary>
        public void ListChannelConnectionsRequestObject()
        {
            // Snippet: ListChannelConnections(ListChannelConnectionsRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            ListChannelConnectionsRequest request = new ListChannelConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListChannelConnectionsResponse, ChannelConnection> response = eventarcClient.ListChannelConnections(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChannelConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChannelConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChannelConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChannelConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChannelConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelConnectionsAsync</summary>
        public async Task ListChannelConnectionsRequestObjectAsync()
        {
            // Snippet: ListChannelConnectionsAsync(ListChannelConnectionsRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            ListChannelConnectionsRequest request = new ListChannelConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListChannelConnectionsResponse, ChannelConnection> response = eventarcClient.ListChannelConnectionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ChannelConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChannelConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChannelConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChannelConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChannelConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelConnections</summary>
        public void ListChannelConnections()
        {
            // Snippet: ListChannelConnections(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListChannelConnectionsResponse, ChannelConnection> response = eventarcClient.ListChannelConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChannelConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChannelConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChannelConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChannelConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChannelConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelConnectionsAsync</summary>
        public async Task ListChannelConnectionsAsync()
        {
            // Snippet: ListChannelConnectionsAsync(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListChannelConnectionsResponse, ChannelConnection> response = eventarcClient.ListChannelConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ChannelConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChannelConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChannelConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChannelConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChannelConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelConnections</summary>
        public void ListChannelConnectionsResourceNames()
        {
            // Snippet: ListChannelConnections(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListChannelConnectionsResponse, ChannelConnection> response = eventarcClient.ListChannelConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChannelConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChannelConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChannelConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChannelConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChannelConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelConnectionsAsync</summary>
        public async Task ListChannelConnectionsResourceNamesAsync()
        {
            // Snippet: ListChannelConnectionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListChannelConnectionsResponse, ChannelConnection> response = eventarcClient.ListChannelConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ChannelConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChannelConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChannelConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChannelConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChannelConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateChannelConnection</summary>
        public void CreateChannelConnectionRequestObject()
        {
            // Snippet: CreateChannelConnection(CreateChannelConnectionRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            CreateChannelConnectionRequest request = new CreateChannelConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ChannelConnection = new ChannelConnection(),
                ChannelConnectionId = "",
            };
            // Make the request
            Operation<ChannelConnection, OperationMetadata> response = eventarcClient.CreateChannelConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<ChannelConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ChannelConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelConnection, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateChannelConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannelConnectionAsync</summary>
        public async Task CreateChannelConnectionRequestObjectAsync()
        {
            // Snippet: CreateChannelConnectionAsync(CreateChannelConnectionRequest, CallSettings)
            // Additional: CreateChannelConnectionAsync(CreateChannelConnectionRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            CreateChannelConnectionRequest request = new CreateChannelConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ChannelConnection = new ChannelConnection(),
                ChannelConnectionId = "",
            };
            // Make the request
            Operation<ChannelConnection, OperationMetadata> response = await eventarcClient.CreateChannelConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ChannelConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ChannelConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelConnection, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateChannelConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannelConnection</summary>
        public void CreateChannelConnection()
        {
            // Snippet: CreateChannelConnection(string, ChannelConnection, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ChannelConnection channelConnection = new ChannelConnection();
            string channelConnectionId = "";
            // Make the request
            Operation<ChannelConnection, OperationMetadata> response = eventarcClient.CreateChannelConnection(parent, channelConnection, channelConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<ChannelConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ChannelConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelConnection, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateChannelConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannelConnectionAsync</summary>
        public async Task CreateChannelConnectionAsync()
        {
            // Snippet: CreateChannelConnectionAsync(string, ChannelConnection, string, CallSettings)
            // Additional: CreateChannelConnectionAsync(string, ChannelConnection, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ChannelConnection channelConnection = new ChannelConnection();
            string channelConnectionId = "";
            // Make the request
            Operation<ChannelConnection, OperationMetadata> response = await eventarcClient.CreateChannelConnectionAsync(parent, channelConnection, channelConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<ChannelConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ChannelConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelConnection, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateChannelConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannelConnection</summary>
        public void CreateChannelConnectionResourceNames()
        {
            // Snippet: CreateChannelConnection(LocationName, ChannelConnection, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ChannelConnection channelConnection = new ChannelConnection();
            string channelConnectionId = "";
            // Make the request
            Operation<ChannelConnection, OperationMetadata> response = eventarcClient.CreateChannelConnection(parent, channelConnection, channelConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<ChannelConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ChannelConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelConnection, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateChannelConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannelConnectionAsync</summary>
        public async Task CreateChannelConnectionResourceNamesAsync()
        {
            // Snippet: CreateChannelConnectionAsync(LocationName, ChannelConnection, string, CallSettings)
            // Additional: CreateChannelConnectionAsync(LocationName, ChannelConnection, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ChannelConnection channelConnection = new ChannelConnection();
            string channelConnectionId = "";
            // Make the request
            Operation<ChannelConnection, OperationMetadata> response = await eventarcClient.CreateChannelConnectionAsync(parent, channelConnection, channelConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<ChannelConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ChannelConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelConnection, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateChannelConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelConnection</summary>
        public void DeleteChannelConnectionRequestObject()
        {
            // Snippet: DeleteChannelConnection(DeleteChannelConnectionRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            DeleteChannelConnectionRequest request = new DeleteChannelConnectionRequest
            {
                ChannelConnectionName = ChannelConnectionName.FromProjectLocationChannelConnection("[PROJECT]", "[LOCATION]", "[CHANNEL_CONNECTION]"),
            };
            // Make the request
            Operation<ChannelConnection, OperationMetadata> response = eventarcClient.DeleteChannelConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<ChannelConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ChannelConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelConnection, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteChannelConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelConnectionAsync</summary>
        public async Task DeleteChannelConnectionRequestObjectAsync()
        {
            // Snippet: DeleteChannelConnectionAsync(DeleteChannelConnectionRequest, CallSettings)
            // Additional: DeleteChannelConnectionAsync(DeleteChannelConnectionRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            DeleteChannelConnectionRequest request = new DeleteChannelConnectionRequest
            {
                ChannelConnectionName = ChannelConnectionName.FromProjectLocationChannelConnection("[PROJECT]", "[LOCATION]", "[CHANNEL_CONNECTION]"),
            };
            // Make the request
            Operation<ChannelConnection, OperationMetadata> response = await eventarcClient.DeleteChannelConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ChannelConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ChannelConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelConnection, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteChannelConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelConnection</summary>
        public void DeleteChannelConnection()
        {
            // Snippet: DeleteChannelConnection(string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channelConnections/[CHANNEL_CONNECTION]";
            // Make the request
            Operation<ChannelConnection, OperationMetadata> response = eventarcClient.DeleteChannelConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<ChannelConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ChannelConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelConnection, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteChannelConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelConnectionAsync</summary>
        public async Task DeleteChannelConnectionAsync()
        {
            // Snippet: DeleteChannelConnectionAsync(string, CallSettings)
            // Additional: DeleteChannelConnectionAsync(string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channelConnections/[CHANNEL_CONNECTION]";
            // Make the request
            Operation<ChannelConnection, OperationMetadata> response = await eventarcClient.DeleteChannelConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ChannelConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ChannelConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelConnection, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteChannelConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelConnection</summary>
        public void DeleteChannelConnectionResourceNames()
        {
            // Snippet: DeleteChannelConnection(ChannelConnectionName, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            ChannelConnectionName name = ChannelConnectionName.FromProjectLocationChannelConnection("[PROJECT]", "[LOCATION]", "[CHANNEL_CONNECTION]");
            // Make the request
            Operation<ChannelConnection, OperationMetadata> response = eventarcClient.DeleteChannelConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<ChannelConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ChannelConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelConnection, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteChannelConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelConnectionAsync</summary>
        public async Task DeleteChannelConnectionResourceNamesAsync()
        {
            // Snippet: DeleteChannelConnectionAsync(ChannelConnectionName, CallSettings)
            // Additional: DeleteChannelConnectionAsync(ChannelConnectionName, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            ChannelConnectionName name = ChannelConnectionName.FromProjectLocationChannelConnection("[PROJECT]", "[LOCATION]", "[CHANNEL_CONNECTION]");
            // Make the request
            Operation<ChannelConnection, OperationMetadata> response = await eventarcClient.DeleteChannelConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ChannelConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ChannelConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelConnection, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteChannelConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetGoogleChannelConfig</summary>
        public void GetGoogleChannelConfigRequestObject()
        {
            // Snippet: GetGoogleChannelConfig(GetGoogleChannelConfigRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            GetGoogleChannelConfigRequest request = new GetGoogleChannelConfigRequest
            {
                GoogleChannelConfigName = GoogleChannelConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            GoogleChannelConfig response = eventarcClient.GetGoogleChannelConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleChannelConfigAsync</summary>
        public async Task GetGoogleChannelConfigRequestObjectAsync()
        {
            // Snippet: GetGoogleChannelConfigAsync(GetGoogleChannelConfigRequest, CallSettings)
            // Additional: GetGoogleChannelConfigAsync(GetGoogleChannelConfigRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            GetGoogleChannelConfigRequest request = new GetGoogleChannelConfigRequest
            {
                GoogleChannelConfigName = GoogleChannelConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            GoogleChannelConfig response = await eventarcClient.GetGoogleChannelConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleChannelConfig</summary>
        public void GetGoogleChannelConfig()
        {
            // Snippet: GetGoogleChannelConfig(string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/googleChannelConfig";
            // Make the request
            GoogleChannelConfig response = eventarcClient.GetGoogleChannelConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleChannelConfigAsync</summary>
        public async Task GetGoogleChannelConfigAsync()
        {
            // Snippet: GetGoogleChannelConfigAsync(string, CallSettings)
            // Additional: GetGoogleChannelConfigAsync(string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/googleChannelConfig";
            // Make the request
            GoogleChannelConfig response = await eventarcClient.GetGoogleChannelConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleChannelConfig</summary>
        public void GetGoogleChannelConfigResourceNames()
        {
            // Snippet: GetGoogleChannelConfig(GoogleChannelConfigName, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            GoogleChannelConfigName name = GoogleChannelConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            GoogleChannelConfig response = eventarcClient.GetGoogleChannelConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleChannelConfigAsync</summary>
        public async Task GetGoogleChannelConfigResourceNamesAsync()
        {
            // Snippet: GetGoogleChannelConfigAsync(GoogleChannelConfigName, CallSettings)
            // Additional: GetGoogleChannelConfigAsync(GoogleChannelConfigName, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            GoogleChannelConfigName name = GoogleChannelConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            GoogleChannelConfig response = await eventarcClient.GetGoogleChannelConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleChannelConfig</summary>
        public void UpdateGoogleChannelConfigRequestObject()
        {
            // Snippet: UpdateGoogleChannelConfig(UpdateGoogleChannelConfigRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            UpdateGoogleChannelConfigRequest request = new UpdateGoogleChannelConfigRequest
            {
                GoogleChannelConfig = new GoogleChannelConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GoogleChannelConfig response = eventarcClient.UpdateGoogleChannelConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleChannelConfigAsync</summary>
        public async Task UpdateGoogleChannelConfigRequestObjectAsync()
        {
            // Snippet: UpdateGoogleChannelConfigAsync(UpdateGoogleChannelConfigRequest, CallSettings)
            // Additional: UpdateGoogleChannelConfigAsync(UpdateGoogleChannelConfigRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGoogleChannelConfigRequest request = new UpdateGoogleChannelConfigRequest
            {
                GoogleChannelConfig = new GoogleChannelConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GoogleChannelConfig response = await eventarcClient.UpdateGoogleChannelConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleChannelConfig</summary>
        public void UpdateGoogleChannelConfig()
        {
            // Snippet: UpdateGoogleChannelConfig(GoogleChannelConfig, FieldMask, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            GoogleChannelConfig googleChannelConfig = new GoogleChannelConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            GoogleChannelConfig response = eventarcClient.UpdateGoogleChannelConfig(googleChannelConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleChannelConfigAsync</summary>
        public async Task UpdateGoogleChannelConfigAsync()
        {
            // Snippet: UpdateGoogleChannelConfigAsync(GoogleChannelConfig, FieldMask, CallSettings)
            // Additional: UpdateGoogleChannelConfigAsync(GoogleChannelConfig, FieldMask, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            GoogleChannelConfig googleChannelConfig = new GoogleChannelConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            GoogleChannelConfig response = await eventarcClient.UpdateGoogleChannelConfigAsync(googleChannelConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetMessageBus</summary>
        public void GetMessageBusRequestObject()
        {
            // Snippet: GetMessageBus(GetMessageBusRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            GetMessageBusRequest request = new GetMessageBusRequest
            {
                MessageBusName = MessageBusName.FromProjectLocationMessageBus("[PROJECT]", "[LOCATION]", "[MESSAGE_BUS]"),
            };
            // Make the request
            MessageBus response = eventarcClient.GetMessageBus(request);
            // End snippet
        }

        /// <summary>Snippet for GetMessageBusAsync</summary>
        public async Task GetMessageBusRequestObjectAsync()
        {
            // Snippet: GetMessageBusAsync(GetMessageBusRequest, CallSettings)
            // Additional: GetMessageBusAsync(GetMessageBusRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            GetMessageBusRequest request = new GetMessageBusRequest
            {
                MessageBusName = MessageBusName.FromProjectLocationMessageBus("[PROJECT]", "[LOCATION]", "[MESSAGE_BUS]"),
            };
            // Make the request
            MessageBus response = await eventarcClient.GetMessageBusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMessageBus</summary>
        public void GetMessageBus()
        {
            // Snippet: GetMessageBus(string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/messageBuses/[MESSAGE_BUS]";
            // Make the request
            MessageBus response = eventarcClient.GetMessageBus(name);
            // End snippet
        }

        /// <summary>Snippet for GetMessageBusAsync</summary>
        public async Task GetMessageBusAsync()
        {
            // Snippet: GetMessageBusAsync(string, CallSettings)
            // Additional: GetMessageBusAsync(string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/messageBuses/[MESSAGE_BUS]";
            // Make the request
            MessageBus response = await eventarcClient.GetMessageBusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMessageBus</summary>
        public void GetMessageBusResourceNames()
        {
            // Snippet: GetMessageBus(MessageBusName, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            MessageBusName name = MessageBusName.FromProjectLocationMessageBus("[PROJECT]", "[LOCATION]", "[MESSAGE_BUS]");
            // Make the request
            MessageBus response = eventarcClient.GetMessageBus(name);
            // End snippet
        }

        /// <summary>Snippet for GetMessageBusAsync</summary>
        public async Task GetMessageBusResourceNamesAsync()
        {
            // Snippet: GetMessageBusAsync(MessageBusName, CallSettings)
            // Additional: GetMessageBusAsync(MessageBusName, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            MessageBusName name = MessageBusName.FromProjectLocationMessageBus("[PROJECT]", "[LOCATION]", "[MESSAGE_BUS]");
            // Make the request
            MessageBus response = await eventarcClient.GetMessageBusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMessageBuses</summary>
        public void ListMessageBusesRequestObject()
        {
            // Snippet: ListMessageBuses(ListMessageBusesRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            ListMessageBusesRequest request = new ListMessageBusesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListMessageBusesResponse, MessageBus> response = eventarcClient.ListMessageBuses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MessageBus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMessageBusesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MessageBus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MessageBus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MessageBus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessageBusesAsync</summary>
        public async Task ListMessageBusesRequestObjectAsync()
        {
            // Snippet: ListMessageBusesAsync(ListMessageBusesRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            ListMessageBusesRequest request = new ListMessageBusesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMessageBusesResponse, MessageBus> response = eventarcClient.ListMessageBusesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MessageBus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMessageBusesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MessageBus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MessageBus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MessageBus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessageBuses</summary>
        public void ListMessageBuses()
        {
            // Snippet: ListMessageBuses(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMessageBusesResponse, MessageBus> response = eventarcClient.ListMessageBuses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MessageBus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMessageBusesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MessageBus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MessageBus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MessageBus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessageBusesAsync</summary>
        public async Task ListMessageBusesAsync()
        {
            // Snippet: ListMessageBusesAsync(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMessageBusesResponse, MessageBus> response = eventarcClient.ListMessageBusesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MessageBus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMessageBusesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MessageBus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MessageBus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MessageBus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessageBuses</summary>
        public void ListMessageBusesResourceNames()
        {
            // Snippet: ListMessageBuses(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMessageBusesResponse, MessageBus> response = eventarcClient.ListMessageBuses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MessageBus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMessageBusesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MessageBus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MessageBus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MessageBus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessageBusesAsync</summary>
        public async Task ListMessageBusesResourceNamesAsync()
        {
            // Snippet: ListMessageBusesAsync(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMessageBusesResponse, MessageBus> response = eventarcClient.ListMessageBusesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MessageBus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMessageBusesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MessageBus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MessageBus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MessageBus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessageBusEnrollments</summary>
        public void ListMessageBusEnrollmentsRequestObject()
        {
            // Snippet: ListMessageBusEnrollments(ListMessageBusEnrollmentsRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            ListMessageBusEnrollmentsRequest request = new ListMessageBusEnrollmentsRequest
            {
                ParentAsMessageBusName = MessageBusName.FromProjectLocationMessageBus("[PROJECT]", "[LOCATION]", "[MESSAGE_BUS]"),
            };
            // Make the request
            PagedEnumerable<ListMessageBusEnrollmentsResponse, string> response = eventarcClient.ListMessageBusEnrollments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMessageBusEnrollmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessageBusEnrollmentsAsync</summary>
        public async Task ListMessageBusEnrollmentsRequestObjectAsync()
        {
            // Snippet: ListMessageBusEnrollmentsAsync(ListMessageBusEnrollmentsRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            ListMessageBusEnrollmentsRequest request = new ListMessageBusEnrollmentsRequest
            {
                ParentAsMessageBusName = MessageBusName.FromProjectLocationMessageBus("[PROJECT]", "[LOCATION]", "[MESSAGE_BUS]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMessageBusEnrollmentsResponse, string> response = eventarcClient.ListMessageBusEnrollmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMessageBusEnrollmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessageBusEnrollments</summary>
        public void ListMessageBusEnrollments()
        {
            // Snippet: ListMessageBusEnrollments(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/messageBuses/[MESSAGE_BUS]";
            // Make the request
            PagedEnumerable<ListMessageBusEnrollmentsResponse, string> response = eventarcClient.ListMessageBusEnrollments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMessageBusEnrollmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessageBusEnrollmentsAsync</summary>
        public async Task ListMessageBusEnrollmentsAsync()
        {
            // Snippet: ListMessageBusEnrollmentsAsync(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/messageBuses/[MESSAGE_BUS]";
            // Make the request
            PagedAsyncEnumerable<ListMessageBusEnrollmentsResponse, string> response = eventarcClient.ListMessageBusEnrollmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMessageBusEnrollmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessageBusEnrollments</summary>
        public void ListMessageBusEnrollmentsResourceNames()
        {
            // Snippet: ListMessageBusEnrollments(MessageBusName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            MessageBusName parent = MessageBusName.FromProjectLocationMessageBus("[PROJECT]", "[LOCATION]", "[MESSAGE_BUS]");
            // Make the request
            PagedEnumerable<ListMessageBusEnrollmentsResponse, string> response = eventarcClient.ListMessageBusEnrollments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMessageBusEnrollmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessageBusEnrollmentsAsync</summary>
        public async Task ListMessageBusEnrollmentsResourceNamesAsync()
        {
            // Snippet: ListMessageBusEnrollmentsAsync(MessageBusName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            MessageBusName parent = MessageBusName.FromProjectLocationMessageBus("[PROJECT]", "[LOCATION]", "[MESSAGE_BUS]");
            // Make the request
            PagedAsyncEnumerable<ListMessageBusEnrollmentsResponse, string> response = eventarcClient.ListMessageBusEnrollmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMessageBusEnrollmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateMessageBus</summary>
        public void CreateMessageBusRequestObject()
        {
            // Snippet: CreateMessageBus(CreateMessageBusRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            CreateMessageBusRequest request = new CreateMessageBusRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MessageBus = new MessageBus(),
                MessageBusId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<MessageBus, OperationMetadata> response = eventarcClient.CreateMessageBus(request);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateMessageBus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMessageBusAsync</summary>
        public async Task CreateMessageBusRequestObjectAsync()
        {
            // Snippet: CreateMessageBusAsync(CreateMessageBusRequest, CallSettings)
            // Additional: CreateMessageBusAsync(CreateMessageBusRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            CreateMessageBusRequest request = new CreateMessageBusRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MessageBus = new MessageBus(),
                MessageBusId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<MessageBus, OperationMetadata> response = await eventarcClient.CreateMessageBusAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateMessageBusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMessageBus</summary>
        public void CreateMessageBus()
        {
            // Snippet: CreateMessageBus(string, MessageBus, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MessageBus messageBus = new MessageBus();
            string messageBusId = "";
            // Make the request
            Operation<MessageBus, OperationMetadata> response = eventarcClient.CreateMessageBus(parent, messageBus, messageBusId);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateMessageBus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMessageBusAsync</summary>
        public async Task CreateMessageBusAsync()
        {
            // Snippet: CreateMessageBusAsync(string, MessageBus, string, CallSettings)
            // Additional: CreateMessageBusAsync(string, MessageBus, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MessageBus messageBus = new MessageBus();
            string messageBusId = "";
            // Make the request
            Operation<MessageBus, OperationMetadata> response = await eventarcClient.CreateMessageBusAsync(parent, messageBus, messageBusId);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateMessageBusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMessageBus</summary>
        public void CreateMessageBusResourceNames()
        {
            // Snippet: CreateMessageBus(LocationName, MessageBus, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MessageBus messageBus = new MessageBus();
            string messageBusId = "";
            // Make the request
            Operation<MessageBus, OperationMetadata> response = eventarcClient.CreateMessageBus(parent, messageBus, messageBusId);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateMessageBus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMessageBusAsync</summary>
        public async Task CreateMessageBusResourceNamesAsync()
        {
            // Snippet: CreateMessageBusAsync(LocationName, MessageBus, string, CallSettings)
            // Additional: CreateMessageBusAsync(LocationName, MessageBus, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MessageBus messageBus = new MessageBus();
            string messageBusId = "";
            // Make the request
            Operation<MessageBus, OperationMetadata> response = await eventarcClient.CreateMessageBusAsync(parent, messageBus, messageBusId);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateMessageBusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMessageBus</summary>
        public void UpdateMessageBusRequestObject()
        {
            // Snippet: UpdateMessageBus(UpdateMessageBusRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            UpdateMessageBusRequest request = new UpdateMessageBusRequest
            {
                MessageBus = new MessageBus(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<MessageBus, OperationMetadata> response = eventarcClient.UpdateMessageBus(request);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = eventarcClient.PollOnceUpdateMessageBus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMessageBusAsync</summary>
        public async Task UpdateMessageBusRequestObjectAsync()
        {
            // Snippet: UpdateMessageBusAsync(UpdateMessageBusRequest, CallSettings)
            // Additional: UpdateMessageBusAsync(UpdateMessageBusRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMessageBusRequest request = new UpdateMessageBusRequest
            {
                MessageBus = new MessageBus(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<MessageBus, OperationMetadata> response = await eventarcClient.UpdateMessageBusAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceUpdateMessageBusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMessageBus</summary>
        public void UpdateMessageBus()
        {
            // Snippet: UpdateMessageBus(MessageBus, FieldMask, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            MessageBus messageBus = new MessageBus();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MessageBus, OperationMetadata> response = eventarcClient.UpdateMessageBus(messageBus, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = eventarcClient.PollOnceUpdateMessageBus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMessageBusAsync</summary>
        public async Task UpdateMessageBusAsync()
        {
            // Snippet: UpdateMessageBusAsync(MessageBus, FieldMask, CallSettings)
            // Additional: UpdateMessageBusAsync(MessageBus, FieldMask, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            MessageBus messageBus = new MessageBus();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MessageBus, OperationMetadata> response = await eventarcClient.UpdateMessageBusAsync(messageBus, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceUpdateMessageBusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMessageBus</summary>
        public void DeleteMessageBusRequestObject()
        {
            // Snippet: DeleteMessageBus(DeleteMessageBusRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            DeleteMessageBusRequest request = new DeleteMessageBusRequest
            {
                MessageBusName = MessageBusName.FromProjectLocationMessageBus("[PROJECT]", "[LOCATION]", "[MESSAGE_BUS]"),
                Etag = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<MessageBus, OperationMetadata> response = eventarcClient.DeleteMessageBus(request);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteMessageBus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMessageBusAsync</summary>
        public async Task DeleteMessageBusRequestObjectAsync()
        {
            // Snippet: DeleteMessageBusAsync(DeleteMessageBusRequest, CallSettings)
            // Additional: DeleteMessageBusAsync(DeleteMessageBusRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMessageBusRequest request = new DeleteMessageBusRequest
            {
                MessageBusName = MessageBusName.FromProjectLocationMessageBus("[PROJECT]", "[LOCATION]", "[MESSAGE_BUS]"),
                Etag = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<MessageBus, OperationMetadata> response = await eventarcClient.DeleteMessageBusAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteMessageBusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMessageBus</summary>
        public void DeleteMessageBus()
        {
            // Snippet: DeleteMessageBus(string, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/messageBuses/[MESSAGE_BUS]";
            string etag = "";
            // Make the request
            Operation<MessageBus, OperationMetadata> response = eventarcClient.DeleteMessageBus(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteMessageBus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMessageBusAsync</summary>
        public async Task DeleteMessageBusAsync()
        {
            // Snippet: DeleteMessageBusAsync(string, string, CallSettings)
            // Additional: DeleteMessageBusAsync(string, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/messageBuses/[MESSAGE_BUS]";
            string etag = "";
            // Make the request
            Operation<MessageBus, OperationMetadata> response = await eventarcClient.DeleteMessageBusAsync(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteMessageBusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMessageBus</summary>
        public void DeleteMessageBusResourceNames()
        {
            // Snippet: DeleteMessageBus(MessageBusName, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            MessageBusName name = MessageBusName.FromProjectLocationMessageBus("[PROJECT]", "[LOCATION]", "[MESSAGE_BUS]");
            string etag = "";
            // Make the request
            Operation<MessageBus, OperationMetadata> response = eventarcClient.DeleteMessageBus(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteMessageBus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMessageBusAsync</summary>
        public async Task DeleteMessageBusResourceNamesAsync()
        {
            // Snippet: DeleteMessageBusAsync(MessageBusName, string, CallSettings)
            // Additional: DeleteMessageBusAsync(MessageBusName, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            MessageBusName name = MessageBusName.FromProjectLocationMessageBus("[PROJECT]", "[LOCATION]", "[MESSAGE_BUS]");
            string etag = "";
            // Make the request
            Operation<MessageBus, OperationMetadata> response = await eventarcClient.DeleteMessageBusAsync(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteMessageBusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetEnrollment</summary>
        public void GetEnrollmentRequestObject()
        {
            // Snippet: GetEnrollment(GetEnrollmentRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            GetEnrollmentRequest request = new GetEnrollmentRequest
            {
                EnrollmentName = EnrollmentName.FromProjectLocationEnrollment("[PROJECT]", "[LOCATION]", "[ENROLLMENT]"),
            };
            // Make the request
            Enrollment response = eventarcClient.GetEnrollment(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnrollmentAsync</summary>
        public async Task GetEnrollmentRequestObjectAsync()
        {
            // Snippet: GetEnrollmentAsync(GetEnrollmentRequest, CallSettings)
            // Additional: GetEnrollmentAsync(GetEnrollmentRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            GetEnrollmentRequest request = new GetEnrollmentRequest
            {
                EnrollmentName = EnrollmentName.FromProjectLocationEnrollment("[PROJECT]", "[LOCATION]", "[ENROLLMENT]"),
            };
            // Make the request
            Enrollment response = await eventarcClient.GetEnrollmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnrollment</summary>
        public void GetEnrollment()
        {
            // Snippet: GetEnrollment(string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/enrollments/[ENROLLMENT]";
            // Make the request
            Enrollment response = eventarcClient.GetEnrollment(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnrollmentAsync</summary>
        public async Task GetEnrollmentAsync()
        {
            // Snippet: GetEnrollmentAsync(string, CallSettings)
            // Additional: GetEnrollmentAsync(string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/enrollments/[ENROLLMENT]";
            // Make the request
            Enrollment response = await eventarcClient.GetEnrollmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnrollment</summary>
        public void GetEnrollmentResourceNames()
        {
            // Snippet: GetEnrollment(EnrollmentName, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            EnrollmentName name = EnrollmentName.FromProjectLocationEnrollment("[PROJECT]", "[LOCATION]", "[ENROLLMENT]");
            // Make the request
            Enrollment response = eventarcClient.GetEnrollment(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnrollmentAsync</summary>
        public async Task GetEnrollmentResourceNamesAsync()
        {
            // Snippet: GetEnrollmentAsync(EnrollmentName, CallSettings)
            // Additional: GetEnrollmentAsync(EnrollmentName, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            EnrollmentName name = EnrollmentName.FromProjectLocationEnrollment("[PROJECT]", "[LOCATION]", "[ENROLLMENT]");
            // Make the request
            Enrollment response = await eventarcClient.GetEnrollmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEnrollments</summary>
        public void ListEnrollmentsRequestObject()
        {
            // Snippet: ListEnrollments(ListEnrollmentsRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            ListEnrollmentsRequest request = new ListEnrollmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListEnrollmentsResponse, Enrollment> response = eventarcClient.ListEnrollments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Enrollment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEnrollmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Enrollment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Enrollment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Enrollment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnrollmentsAsync</summary>
        public async Task ListEnrollmentsRequestObjectAsync()
        {
            // Snippet: ListEnrollmentsAsync(ListEnrollmentsRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            ListEnrollmentsRequest request = new ListEnrollmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEnrollmentsResponse, Enrollment> response = eventarcClient.ListEnrollmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Enrollment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEnrollmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Enrollment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Enrollment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Enrollment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnrollments</summary>
        public void ListEnrollments()
        {
            // Snippet: ListEnrollments(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEnrollmentsResponse, Enrollment> response = eventarcClient.ListEnrollments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Enrollment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEnrollmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Enrollment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Enrollment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Enrollment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnrollmentsAsync</summary>
        public async Task ListEnrollmentsAsync()
        {
            // Snippet: ListEnrollmentsAsync(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEnrollmentsResponse, Enrollment> response = eventarcClient.ListEnrollmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Enrollment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEnrollmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Enrollment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Enrollment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Enrollment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnrollments</summary>
        public void ListEnrollmentsResourceNames()
        {
            // Snippet: ListEnrollments(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEnrollmentsResponse, Enrollment> response = eventarcClient.ListEnrollments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Enrollment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEnrollmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Enrollment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Enrollment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Enrollment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnrollmentsAsync</summary>
        public async Task ListEnrollmentsResourceNamesAsync()
        {
            // Snippet: ListEnrollmentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEnrollmentsResponse, Enrollment> response = eventarcClient.ListEnrollmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Enrollment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEnrollmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Enrollment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Enrollment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Enrollment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateEnrollment</summary>
        public void CreateEnrollmentRequestObject()
        {
            // Snippet: CreateEnrollment(CreateEnrollmentRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            CreateEnrollmentRequest request = new CreateEnrollmentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Enrollment = new Enrollment(),
                EnrollmentId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Enrollment, OperationMetadata> response = eventarcClient.CreateEnrollment(request);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateEnrollment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnrollmentAsync</summary>
        public async Task CreateEnrollmentRequestObjectAsync()
        {
            // Snippet: CreateEnrollmentAsync(CreateEnrollmentRequest, CallSettings)
            // Additional: CreateEnrollmentAsync(CreateEnrollmentRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            CreateEnrollmentRequest request = new CreateEnrollmentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Enrollment = new Enrollment(),
                EnrollmentId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Enrollment, OperationMetadata> response = await eventarcClient.CreateEnrollmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateEnrollmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnrollment</summary>
        public void CreateEnrollment()
        {
            // Snippet: CreateEnrollment(string, Enrollment, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Enrollment enrollment = new Enrollment();
            string enrollmentId = "";
            // Make the request
            Operation<Enrollment, OperationMetadata> response = eventarcClient.CreateEnrollment(parent, enrollment, enrollmentId);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateEnrollment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnrollmentAsync</summary>
        public async Task CreateEnrollmentAsync()
        {
            // Snippet: CreateEnrollmentAsync(string, Enrollment, string, CallSettings)
            // Additional: CreateEnrollmentAsync(string, Enrollment, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Enrollment enrollment = new Enrollment();
            string enrollmentId = "";
            // Make the request
            Operation<Enrollment, OperationMetadata> response = await eventarcClient.CreateEnrollmentAsync(parent, enrollment, enrollmentId);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateEnrollmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnrollment</summary>
        public void CreateEnrollmentResourceNames()
        {
            // Snippet: CreateEnrollment(LocationName, Enrollment, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Enrollment enrollment = new Enrollment();
            string enrollmentId = "";
            // Make the request
            Operation<Enrollment, OperationMetadata> response = eventarcClient.CreateEnrollment(parent, enrollment, enrollmentId);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateEnrollment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnrollmentAsync</summary>
        public async Task CreateEnrollmentResourceNamesAsync()
        {
            // Snippet: CreateEnrollmentAsync(LocationName, Enrollment, string, CallSettings)
            // Additional: CreateEnrollmentAsync(LocationName, Enrollment, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Enrollment enrollment = new Enrollment();
            string enrollmentId = "";
            // Make the request
            Operation<Enrollment, OperationMetadata> response = await eventarcClient.CreateEnrollmentAsync(parent, enrollment, enrollmentId);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateEnrollmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnrollment</summary>
        public void UpdateEnrollmentRequestObject()
        {
            // Snippet: UpdateEnrollment(UpdateEnrollmentRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            UpdateEnrollmentRequest request = new UpdateEnrollmentRequest
            {
                Enrollment = new Enrollment(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Enrollment, OperationMetadata> response = eventarcClient.UpdateEnrollment(request);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = eventarcClient.PollOnceUpdateEnrollment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnrollmentAsync</summary>
        public async Task UpdateEnrollmentRequestObjectAsync()
        {
            // Snippet: UpdateEnrollmentAsync(UpdateEnrollmentRequest, CallSettings)
            // Additional: UpdateEnrollmentAsync(UpdateEnrollmentRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEnrollmentRequest request = new UpdateEnrollmentRequest
            {
                Enrollment = new Enrollment(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Enrollment, OperationMetadata> response = await eventarcClient.UpdateEnrollmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceUpdateEnrollmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnrollment</summary>
        public void UpdateEnrollment()
        {
            // Snippet: UpdateEnrollment(Enrollment, FieldMask, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            Enrollment enrollment = new Enrollment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Enrollment, OperationMetadata> response = eventarcClient.UpdateEnrollment(enrollment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = eventarcClient.PollOnceUpdateEnrollment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnrollmentAsync</summary>
        public async Task UpdateEnrollmentAsync()
        {
            // Snippet: UpdateEnrollmentAsync(Enrollment, FieldMask, CallSettings)
            // Additional: UpdateEnrollmentAsync(Enrollment, FieldMask, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            Enrollment enrollment = new Enrollment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Enrollment, OperationMetadata> response = await eventarcClient.UpdateEnrollmentAsync(enrollment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceUpdateEnrollmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnrollment</summary>
        public void DeleteEnrollmentRequestObject()
        {
            // Snippet: DeleteEnrollment(DeleteEnrollmentRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            DeleteEnrollmentRequest request = new DeleteEnrollmentRequest
            {
                EnrollmentName = EnrollmentName.FromProjectLocationEnrollment("[PROJECT]", "[LOCATION]", "[ENROLLMENT]"),
                Etag = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Enrollment, OperationMetadata> response = eventarcClient.DeleteEnrollment(request);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteEnrollment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnrollmentAsync</summary>
        public async Task DeleteEnrollmentRequestObjectAsync()
        {
            // Snippet: DeleteEnrollmentAsync(DeleteEnrollmentRequest, CallSettings)
            // Additional: DeleteEnrollmentAsync(DeleteEnrollmentRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEnrollmentRequest request = new DeleteEnrollmentRequest
            {
                EnrollmentName = EnrollmentName.FromProjectLocationEnrollment("[PROJECT]", "[LOCATION]", "[ENROLLMENT]"),
                Etag = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Enrollment, OperationMetadata> response = await eventarcClient.DeleteEnrollmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteEnrollmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnrollment</summary>
        public void DeleteEnrollment()
        {
            // Snippet: DeleteEnrollment(string, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/enrollments/[ENROLLMENT]";
            string etag = "";
            // Make the request
            Operation<Enrollment, OperationMetadata> response = eventarcClient.DeleteEnrollment(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteEnrollment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnrollmentAsync</summary>
        public async Task DeleteEnrollmentAsync()
        {
            // Snippet: DeleteEnrollmentAsync(string, string, CallSettings)
            // Additional: DeleteEnrollmentAsync(string, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/enrollments/[ENROLLMENT]";
            string etag = "";
            // Make the request
            Operation<Enrollment, OperationMetadata> response = await eventarcClient.DeleteEnrollmentAsync(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteEnrollmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnrollment</summary>
        public void DeleteEnrollmentResourceNames()
        {
            // Snippet: DeleteEnrollment(EnrollmentName, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            EnrollmentName name = EnrollmentName.FromProjectLocationEnrollment("[PROJECT]", "[LOCATION]", "[ENROLLMENT]");
            string etag = "";
            // Make the request
            Operation<Enrollment, OperationMetadata> response = eventarcClient.DeleteEnrollment(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteEnrollment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnrollmentAsync</summary>
        public async Task DeleteEnrollmentResourceNamesAsync()
        {
            // Snippet: DeleteEnrollmentAsync(EnrollmentName, string, CallSettings)
            // Additional: DeleteEnrollmentAsync(EnrollmentName, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            EnrollmentName name = EnrollmentName.FromProjectLocationEnrollment("[PROJECT]", "[LOCATION]", "[ENROLLMENT]");
            string etag = "";
            // Make the request
            Operation<Enrollment, OperationMetadata> response = await eventarcClient.DeleteEnrollmentAsync(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<Enrollment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Enrollment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Enrollment, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteEnrollmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Enrollment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetPipeline</summary>
        public void GetPipelineRequestObject()
        {
            // Snippet: GetPipeline(GetPipelineRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            GetPipelineRequest request = new GetPipelineRequest
            {
                PipelineName = PipelineName.FromProjectLocationPipeline("[PROJECT]", "[LOCATION]", "[PIPELINE]"),
            };
            // Make the request
            Pipeline response = eventarcClient.GetPipeline(request);
            // End snippet
        }

        /// <summary>Snippet for GetPipelineAsync</summary>
        public async Task GetPipelineRequestObjectAsync()
        {
            // Snippet: GetPipelineAsync(GetPipelineRequest, CallSettings)
            // Additional: GetPipelineAsync(GetPipelineRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            GetPipelineRequest request = new GetPipelineRequest
            {
                PipelineName = PipelineName.FromProjectLocationPipeline("[PROJECT]", "[LOCATION]", "[PIPELINE]"),
            };
            // Make the request
            Pipeline response = await eventarcClient.GetPipelineAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPipeline</summary>
        public void GetPipeline()
        {
            // Snippet: GetPipeline(string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/pipelines/[PIPELINE]";
            // Make the request
            Pipeline response = eventarcClient.GetPipeline(name);
            // End snippet
        }

        /// <summary>Snippet for GetPipelineAsync</summary>
        public async Task GetPipelineAsync()
        {
            // Snippet: GetPipelineAsync(string, CallSettings)
            // Additional: GetPipelineAsync(string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/pipelines/[PIPELINE]";
            // Make the request
            Pipeline response = await eventarcClient.GetPipelineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPipeline</summary>
        public void GetPipelineResourceNames()
        {
            // Snippet: GetPipeline(PipelineName, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            PipelineName name = PipelineName.FromProjectLocationPipeline("[PROJECT]", "[LOCATION]", "[PIPELINE]");
            // Make the request
            Pipeline response = eventarcClient.GetPipeline(name);
            // End snippet
        }

        /// <summary>Snippet for GetPipelineAsync</summary>
        public async Task GetPipelineResourceNamesAsync()
        {
            // Snippet: GetPipelineAsync(PipelineName, CallSettings)
            // Additional: GetPipelineAsync(PipelineName, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            PipelineName name = PipelineName.FromProjectLocationPipeline("[PROJECT]", "[LOCATION]", "[PIPELINE]");
            // Make the request
            Pipeline response = await eventarcClient.GetPipelineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPipelines</summary>
        public void ListPipelinesRequestObject()
        {
            // Snippet: ListPipelines(ListPipelinesRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            ListPipelinesRequest request = new ListPipelinesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListPipelinesResponse, Pipeline> response = eventarcClient.ListPipelines(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Pipeline item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPipelinesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Pipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Pipeline> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Pipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPipelinesAsync</summary>
        public async Task ListPipelinesRequestObjectAsync()
        {
            // Snippet: ListPipelinesAsync(ListPipelinesRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            ListPipelinesRequest request = new ListPipelinesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPipelinesResponse, Pipeline> response = eventarcClient.ListPipelinesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Pipeline item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPipelinesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Pipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Pipeline> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Pipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPipelines</summary>
        public void ListPipelines()
        {
            // Snippet: ListPipelines(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPipelinesResponse, Pipeline> response = eventarcClient.ListPipelines(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Pipeline item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPipelinesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Pipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Pipeline> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Pipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPipelinesAsync</summary>
        public async Task ListPipelinesAsync()
        {
            // Snippet: ListPipelinesAsync(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPipelinesResponse, Pipeline> response = eventarcClient.ListPipelinesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Pipeline item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPipelinesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Pipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Pipeline> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Pipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPipelines</summary>
        public void ListPipelinesResourceNames()
        {
            // Snippet: ListPipelines(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPipelinesResponse, Pipeline> response = eventarcClient.ListPipelines(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Pipeline item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPipelinesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Pipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Pipeline> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Pipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPipelinesAsync</summary>
        public async Task ListPipelinesResourceNamesAsync()
        {
            // Snippet: ListPipelinesAsync(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPipelinesResponse, Pipeline> response = eventarcClient.ListPipelinesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Pipeline item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPipelinesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Pipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Pipeline> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Pipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreatePipeline</summary>
        public void CreatePipelineRequestObject()
        {
            // Snippet: CreatePipeline(CreatePipelineRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            CreatePipelineRequest request = new CreatePipelineRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Pipeline = new Pipeline(),
                PipelineId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Pipeline, OperationMetadata> response = eventarcClient.CreatePipeline(request);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreatePipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePipelineAsync</summary>
        public async Task CreatePipelineRequestObjectAsync()
        {
            // Snippet: CreatePipelineAsync(CreatePipelineRequest, CallSettings)
            // Additional: CreatePipelineAsync(CreatePipelineRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            CreatePipelineRequest request = new CreatePipelineRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Pipeline = new Pipeline(),
                PipelineId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Pipeline, OperationMetadata> response = await eventarcClient.CreatePipelineAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreatePipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePipeline</summary>
        public void CreatePipeline()
        {
            // Snippet: CreatePipeline(string, Pipeline, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Pipeline pipeline = new Pipeline();
            string pipelineId = "";
            // Make the request
            Operation<Pipeline, OperationMetadata> response = eventarcClient.CreatePipeline(parent, pipeline, pipelineId);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreatePipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePipelineAsync</summary>
        public async Task CreatePipelineAsync()
        {
            // Snippet: CreatePipelineAsync(string, Pipeline, string, CallSettings)
            // Additional: CreatePipelineAsync(string, Pipeline, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Pipeline pipeline = new Pipeline();
            string pipelineId = "";
            // Make the request
            Operation<Pipeline, OperationMetadata> response = await eventarcClient.CreatePipelineAsync(parent, pipeline, pipelineId);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreatePipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePipeline</summary>
        public void CreatePipelineResourceNames()
        {
            // Snippet: CreatePipeline(LocationName, Pipeline, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Pipeline pipeline = new Pipeline();
            string pipelineId = "";
            // Make the request
            Operation<Pipeline, OperationMetadata> response = eventarcClient.CreatePipeline(parent, pipeline, pipelineId);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreatePipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePipelineAsync</summary>
        public async Task CreatePipelineResourceNamesAsync()
        {
            // Snippet: CreatePipelineAsync(LocationName, Pipeline, string, CallSettings)
            // Additional: CreatePipelineAsync(LocationName, Pipeline, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Pipeline pipeline = new Pipeline();
            string pipelineId = "";
            // Make the request
            Operation<Pipeline, OperationMetadata> response = await eventarcClient.CreatePipelineAsync(parent, pipeline, pipelineId);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreatePipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePipeline</summary>
        public void UpdatePipelineRequestObject()
        {
            // Snippet: UpdatePipeline(UpdatePipelineRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            UpdatePipelineRequest request = new UpdatePipelineRequest
            {
                Pipeline = new Pipeline(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Pipeline, OperationMetadata> response = eventarcClient.UpdatePipeline(request);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = eventarcClient.PollOnceUpdatePipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePipelineAsync</summary>
        public async Task UpdatePipelineRequestObjectAsync()
        {
            // Snippet: UpdatePipelineAsync(UpdatePipelineRequest, CallSettings)
            // Additional: UpdatePipelineAsync(UpdatePipelineRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePipelineRequest request = new UpdatePipelineRequest
            {
                Pipeline = new Pipeline(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Pipeline, OperationMetadata> response = await eventarcClient.UpdatePipelineAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceUpdatePipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePipeline</summary>
        public void UpdatePipeline()
        {
            // Snippet: UpdatePipeline(Pipeline, FieldMask, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            Pipeline pipeline = new Pipeline();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Pipeline, OperationMetadata> response = eventarcClient.UpdatePipeline(pipeline, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = eventarcClient.PollOnceUpdatePipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePipelineAsync</summary>
        public async Task UpdatePipelineAsync()
        {
            // Snippet: UpdatePipelineAsync(Pipeline, FieldMask, CallSettings)
            // Additional: UpdatePipelineAsync(Pipeline, FieldMask, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            Pipeline pipeline = new Pipeline();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Pipeline, OperationMetadata> response = await eventarcClient.UpdatePipelineAsync(pipeline, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceUpdatePipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePipeline</summary>
        public void DeletePipelineRequestObject()
        {
            // Snippet: DeletePipeline(DeletePipelineRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            DeletePipelineRequest request = new DeletePipelineRequest
            {
                PipelineName = PipelineName.FromProjectLocationPipeline("[PROJECT]", "[LOCATION]", "[PIPELINE]"),
                Etag = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Pipeline, OperationMetadata> response = eventarcClient.DeletePipeline(request);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeletePipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePipelineAsync</summary>
        public async Task DeletePipelineRequestObjectAsync()
        {
            // Snippet: DeletePipelineAsync(DeletePipelineRequest, CallSettings)
            // Additional: DeletePipelineAsync(DeletePipelineRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            DeletePipelineRequest request = new DeletePipelineRequest
            {
                PipelineName = PipelineName.FromProjectLocationPipeline("[PROJECT]", "[LOCATION]", "[PIPELINE]"),
                Etag = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Pipeline, OperationMetadata> response = await eventarcClient.DeletePipelineAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeletePipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePipeline</summary>
        public void DeletePipeline()
        {
            // Snippet: DeletePipeline(string, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/pipelines/[PIPELINE]";
            string etag = "";
            // Make the request
            Operation<Pipeline, OperationMetadata> response = eventarcClient.DeletePipeline(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeletePipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePipelineAsync</summary>
        public async Task DeletePipelineAsync()
        {
            // Snippet: DeletePipelineAsync(string, string, CallSettings)
            // Additional: DeletePipelineAsync(string, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/pipelines/[PIPELINE]";
            string etag = "";
            // Make the request
            Operation<Pipeline, OperationMetadata> response = await eventarcClient.DeletePipelineAsync(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeletePipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePipeline</summary>
        public void DeletePipelineResourceNames()
        {
            // Snippet: DeletePipeline(PipelineName, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            PipelineName name = PipelineName.FromProjectLocationPipeline("[PROJECT]", "[LOCATION]", "[PIPELINE]");
            string etag = "";
            // Make the request
            Operation<Pipeline, OperationMetadata> response = eventarcClient.DeletePipeline(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeletePipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePipelineAsync</summary>
        public async Task DeletePipelineResourceNamesAsync()
        {
            // Snippet: DeletePipelineAsync(PipelineName, string, CallSettings)
            // Additional: DeletePipelineAsync(PipelineName, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            PipelineName name = PipelineName.FromProjectLocationPipeline("[PROJECT]", "[LOCATION]", "[PIPELINE]");
            string etag = "";
            // Make the request
            Operation<Pipeline, OperationMetadata> response = await eventarcClient.DeletePipelineAsync(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<Pipeline, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Pipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Pipeline, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeletePipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Pipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetGoogleApiSource</summary>
        public void GetGoogleApiSourceRequestObject()
        {
            // Snippet: GetGoogleApiSource(GetGoogleApiSourceRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            GetGoogleApiSourceRequest request = new GetGoogleApiSourceRequest
            {
                GoogleApiSourceName = GoogleApiSourceName.FromProjectLocationGoogleApiSource("[PROJECT]", "[LOCATION]", "[GOOGLE_API_SOURCE]"),
            };
            // Make the request
            GoogleApiSource response = eventarcClient.GetGoogleApiSource(request);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleApiSourceAsync</summary>
        public async Task GetGoogleApiSourceRequestObjectAsync()
        {
            // Snippet: GetGoogleApiSourceAsync(GetGoogleApiSourceRequest, CallSettings)
            // Additional: GetGoogleApiSourceAsync(GetGoogleApiSourceRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            GetGoogleApiSourceRequest request = new GetGoogleApiSourceRequest
            {
                GoogleApiSourceName = GoogleApiSourceName.FromProjectLocationGoogleApiSource("[PROJECT]", "[LOCATION]", "[GOOGLE_API_SOURCE]"),
            };
            // Make the request
            GoogleApiSource response = await eventarcClient.GetGoogleApiSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleApiSource</summary>
        public void GetGoogleApiSource()
        {
            // Snippet: GetGoogleApiSource(string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/googleApiSources/[GOOGLE_API_SOURCE]";
            // Make the request
            GoogleApiSource response = eventarcClient.GetGoogleApiSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleApiSourceAsync</summary>
        public async Task GetGoogleApiSourceAsync()
        {
            // Snippet: GetGoogleApiSourceAsync(string, CallSettings)
            // Additional: GetGoogleApiSourceAsync(string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/googleApiSources/[GOOGLE_API_SOURCE]";
            // Make the request
            GoogleApiSource response = await eventarcClient.GetGoogleApiSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleApiSource</summary>
        public void GetGoogleApiSourceResourceNames()
        {
            // Snippet: GetGoogleApiSource(GoogleApiSourceName, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            GoogleApiSourceName name = GoogleApiSourceName.FromProjectLocationGoogleApiSource("[PROJECT]", "[LOCATION]", "[GOOGLE_API_SOURCE]");
            // Make the request
            GoogleApiSource response = eventarcClient.GetGoogleApiSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleApiSourceAsync</summary>
        public async Task GetGoogleApiSourceResourceNamesAsync()
        {
            // Snippet: GetGoogleApiSourceAsync(GoogleApiSourceName, CallSettings)
            // Additional: GetGoogleApiSourceAsync(GoogleApiSourceName, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            GoogleApiSourceName name = GoogleApiSourceName.FromProjectLocationGoogleApiSource("[PROJECT]", "[LOCATION]", "[GOOGLE_API_SOURCE]");
            // Make the request
            GoogleApiSource response = await eventarcClient.GetGoogleApiSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGoogleApiSources</summary>
        public void ListGoogleApiSourcesRequestObject()
        {
            // Snippet: ListGoogleApiSources(ListGoogleApiSourcesRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            ListGoogleApiSourcesRequest request = new ListGoogleApiSourcesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListGoogleApiSourcesResponse, GoogleApiSource> response = eventarcClient.ListGoogleApiSources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GoogleApiSource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGoogleApiSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleApiSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleApiSource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleApiSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGoogleApiSourcesAsync</summary>
        public async Task ListGoogleApiSourcesRequestObjectAsync()
        {
            // Snippet: ListGoogleApiSourcesAsync(ListGoogleApiSourcesRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            ListGoogleApiSourcesRequest request = new ListGoogleApiSourcesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListGoogleApiSourcesResponse, GoogleApiSource> response = eventarcClient.ListGoogleApiSourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GoogleApiSource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGoogleApiSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleApiSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleApiSource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleApiSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGoogleApiSources</summary>
        public void ListGoogleApiSources()
        {
            // Snippet: ListGoogleApiSources(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListGoogleApiSourcesResponse, GoogleApiSource> response = eventarcClient.ListGoogleApiSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GoogleApiSource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGoogleApiSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleApiSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleApiSource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleApiSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGoogleApiSourcesAsync</summary>
        public async Task ListGoogleApiSourcesAsync()
        {
            // Snippet: ListGoogleApiSourcesAsync(string, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListGoogleApiSourcesResponse, GoogleApiSource> response = eventarcClient.ListGoogleApiSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GoogleApiSource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGoogleApiSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleApiSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleApiSource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleApiSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGoogleApiSources</summary>
        public void ListGoogleApiSourcesResourceNames()
        {
            // Snippet: ListGoogleApiSources(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListGoogleApiSourcesResponse, GoogleApiSource> response = eventarcClient.ListGoogleApiSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GoogleApiSource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGoogleApiSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleApiSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleApiSource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleApiSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGoogleApiSourcesAsync</summary>
        public async Task ListGoogleApiSourcesResourceNamesAsync()
        {
            // Snippet: ListGoogleApiSourcesAsync(LocationName, string, int?, CallSettings)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListGoogleApiSourcesResponse, GoogleApiSource> response = eventarcClient.ListGoogleApiSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GoogleApiSource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGoogleApiSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleApiSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleApiSource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleApiSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateGoogleApiSource</summary>
        public void CreateGoogleApiSourceRequestObject()
        {
            // Snippet: CreateGoogleApiSource(CreateGoogleApiSourceRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            CreateGoogleApiSourceRequest request = new CreateGoogleApiSourceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GoogleApiSource = new GoogleApiSource(),
                GoogleApiSourceId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = eventarcClient.CreateGoogleApiSource(request);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateGoogleApiSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGoogleApiSourceAsync</summary>
        public async Task CreateGoogleApiSourceRequestObjectAsync()
        {
            // Snippet: CreateGoogleApiSourceAsync(CreateGoogleApiSourceRequest, CallSettings)
            // Additional: CreateGoogleApiSourceAsync(CreateGoogleApiSourceRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            CreateGoogleApiSourceRequest request = new CreateGoogleApiSourceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GoogleApiSource = new GoogleApiSource(),
                GoogleApiSourceId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = await eventarcClient.CreateGoogleApiSourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateGoogleApiSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGoogleApiSource</summary>
        public void CreateGoogleApiSource()
        {
            // Snippet: CreateGoogleApiSource(string, GoogleApiSource, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            GoogleApiSource googleApiSource = new GoogleApiSource();
            string googleApiSourceId = "";
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = eventarcClient.CreateGoogleApiSource(parent, googleApiSource, googleApiSourceId);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateGoogleApiSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGoogleApiSourceAsync</summary>
        public async Task CreateGoogleApiSourceAsync()
        {
            // Snippet: CreateGoogleApiSourceAsync(string, GoogleApiSource, string, CallSettings)
            // Additional: CreateGoogleApiSourceAsync(string, GoogleApiSource, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            GoogleApiSource googleApiSource = new GoogleApiSource();
            string googleApiSourceId = "";
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = await eventarcClient.CreateGoogleApiSourceAsync(parent, googleApiSource, googleApiSourceId);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateGoogleApiSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGoogleApiSource</summary>
        public void CreateGoogleApiSourceResourceNames()
        {
            // Snippet: CreateGoogleApiSource(LocationName, GoogleApiSource, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            GoogleApiSource googleApiSource = new GoogleApiSource();
            string googleApiSourceId = "";
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = eventarcClient.CreateGoogleApiSource(parent, googleApiSource, googleApiSourceId);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateGoogleApiSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGoogleApiSourceAsync</summary>
        public async Task CreateGoogleApiSourceResourceNamesAsync()
        {
            // Snippet: CreateGoogleApiSourceAsync(LocationName, GoogleApiSource, string, CallSettings)
            // Additional: CreateGoogleApiSourceAsync(LocationName, GoogleApiSource, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            GoogleApiSource googleApiSource = new GoogleApiSource();
            string googleApiSourceId = "";
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = await eventarcClient.CreateGoogleApiSourceAsync(parent, googleApiSource, googleApiSourceId);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceCreateGoogleApiSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleApiSource</summary>
        public void UpdateGoogleApiSourceRequestObject()
        {
            // Snippet: UpdateGoogleApiSource(UpdateGoogleApiSourceRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            UpdateGoogleApiSourceRequest request = new UpdateGoogleApiSourceRequest
            {
                GoogleApiSource = new GoogleApiSource(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = eventarcClient.UpdateGoogleApiSource(request);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = eventarcClient.PollOnceUpdateGoogleApiSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleApiSourceAsync</summary>
        public async Task UpdateGoogleApiSourceRequestObjectAsync()
        {
            // Snippet: UpdateGoogleApiSourceAsync(UpdateGoogleApiSourceRequest, CallSettings)
            // Additional: UpdateGoogleApiSourceAsync(UpdateGoogleApiSourceRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGoogleApiSourceRequest request = new UpdateGoogleApiSourceRequest
            {
                GoogleApiSource = new GoogleApiSource(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = await eventarcClient.UpdateGoogleApiSourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceUpdateGoogleApiSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleApiSource</summary>
        public void UpdateGoogleApiSource()
        {
            // Snippet: UpdateGoogleApiSource(GoogleApiSource, FieldMask, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            GoogleApiSource googleApiSource = new GoogleApiSource();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = eventarcClient.UpdateGoogleApiSource(googleApiSource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = eventarcClient.PollOnceUpdateGoogleApiSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleApiSourceAsync</summary>
        public async Task UpdateGoogleApiSourceAsync()
        {
            // Snippet: UpdateGoogleApiSourceAsync(GoogleApiSource, FieldMask, CallSettings)
            // Additional: UpdateGoogleApiSourceAsync(GoogleApiSource, FieldMask, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            GoogleApiSource googleApiSource = new GoogleApiSource();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = await eventarcClient.UpdateGoogleApiSourceAsync(googleApiSource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceUpdateGoogleApiSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGoogleApiSource</summary>
        public void DeleteGoogleApiSourceRequestObject()
        {
            // Snippet: DeleteGoogleApiSource(DeleteGoogleApiSourceRequest, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            DeleteGoogleApiSourceRequest request = new DeleteGoogleApiSourceRequest
            {
                GoogleApiSourceName = GoogleApiSourceName.FromProjectLocationGoogleApiSource("[PROJECT]", "[LOCATION]", "[GOOGLE_API_SOURCE]"),
                Etag = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = eventarcClient.DeleteGoogleApiSource(request);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteGoogleApiSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGoogleApiSourceAsync</summary>
        public async Task DeleteGoogleApiSourceRequestObjectAsync()
        {
            // Snippet: DeleteGoogleApiSourceAsync(DeleteGoogleApiSourceRequest, CallSettings)
            // Additional: DeleteGoogleApiSourceAsync(DeleteGoogleApiSourceRequest, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGoogleApiSourceRequest request = new DeleteGoogleApiSourceRequest
            {
                GoogleApiSourceName = GoogleApiSourceName.FromProjectLocationGoogleApiSource("[PROJECT]", "[LOCATION]", "[GOOGLE_API_SOURCE]"),
                Etag = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = await eventarcClient.DeleteGoogleApiSourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteGoogleApiSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGoogleApiSource</summary>
        public void DeleteGoogleApiSource()
        {
            // Snippet: DeleteGoogleApiSource(string, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/googleApiSources/[GOOGLE_API_SOURCE]";
            string etag = "";
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = eventarcClient.DeleteGoogleApiSource(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteGoogleApiSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGoogleApiSourceAsync</summary>
        public async Task DeleteGoogleApiSourceAsync()
        {
            // Snippet: DeleteGoogleApiSourceAsync(string, string, CallSettings)
            // Additional: DeleteGoogleApiSourceAsync(string, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/googleApiSources/[GOOGLE_API_SOURCE]";
            string etag = "";
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = await eventarcClient.DeleteGoogleApiSourceAsync(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteGoogleApiSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGoogleApiSource</summary>
        public void DeleteGoogleApiSourceResourceNames()
        {
            // Snippet: DeleteGoogleApiSource(GoogleApiSourceName, string, CallSettings)
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            GoogleApiSourceName name = GoogleApiSourceName.FromProjectLocationGoogleApiSource("[PROJECT]", "[LOCATION]", "[GOOGLE_API_SOURCE]");
            string etag = "";
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = eventarcClient.DeleteGoogleApiSource(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = eventarcClient.PollOnceDeleteGoogleApiSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGoogleApiSourceAsync</summary>
        public async Task DeleteGoogleApiSourceResourceNamesAsync()
        {
            // Snippet: DeleteGoogleApiSourceAsync(GoogleApiSourceName, string, CallSettings)
            // Additional: DeleteGoogleApiSourceAsync(GoogleApiSourceName, string, CancellationToken)
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            GoogleApiSourceName name = GoogleApiSourceName.FromProjectLocationGoogleApiSource("[PROJECT]", "[LOCATION]", "[GOOGLE_API_SOURCE]");
            string etag = "";
            // Make the request
            Operation<GoogleApiSource, OperationMetadata> response = await eventarcClient.DeleteGoogleApiSourceAsync(name, etag);

            // Poll until the returned long-running operation is complete
            Operation<GoogleApiSource, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GoogleApiSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GoogleApiSource, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceDeleteGoogleApiSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GoogleApiSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
