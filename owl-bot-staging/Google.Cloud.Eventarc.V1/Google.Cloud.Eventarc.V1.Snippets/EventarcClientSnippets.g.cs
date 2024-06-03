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
    }
}
