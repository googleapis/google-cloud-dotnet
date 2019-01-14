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

namespace Google.Cloud.Dialogflow.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Dialogflow.V2;
    using Google.LongRunning;
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
    public class GeneratedIntentsClientSnippets
    {
        /// <summary>Snippet for ListIntentsAsync</summary>
        public async Task ListIntentsAsync1()
        {
            // Snippet: ListIntentsAsync(ProjectAgentName,string,int?,CallSettings)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListIntentsResponse, Intent> response =
                intentsClient.ListIntentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Intent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIntentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Intent item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Intent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Intent item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIntents</summary>
        public void ListIntents1()
        {
            // Snippet: ListIntents(ProjectAgentName,string,int?,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListIntentsResponse, Intent> response =
                intentsClient.ListIntents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Intent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIntentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Intent item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Intent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Intent item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIntentsAsync</summary>
        public async Task ListIntentsAsync2()
        {
            // Snippet: ListIntentsAsync(ProjectAgentName,string,string,int?,CallSettings)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            string languageCode = "";
            // Make the request
            PagedAsyncEnumerable<ListIntentsResponse, Intent> response =
                intentsClient.ListIntentsAsync(parent: parent, languageCode: languageCode);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Intent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIntentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Intent item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Intent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Intent item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIntents</summary>
        public void ListIntents2()
        {
            // Snippet: ListIntents(ProjectAgentName,string,string,int?,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            string languageCode = "";
            // Make the request
            PagedEnumerable<ListIntentsResponse, Intent> response =
                intentsClient.ListIntents(parent: parent, languageCode: languageCode);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Intent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIntentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Intent item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Intent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Intent item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIntentsAsync</summary>
        public async Task ListIntentsAsync_RequestObject()
        {
            // Snippet: ListIntentsAsync(ListIntentsRequest,CallSettings)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            ListIntentsRequest request = new ListIntentsRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListIntentsResponse, Intent> response =
                intentsClient.ListIntentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Intent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIntentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Intent item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Intent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Intent item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIntents</summary>
        public void ListIntents_RequestObject()
        {
            // Snippet: ListIntents(ListIntentsRequest,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            ListIntentsRequest request = new ListIntentsRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListIntentsResponse, Intent> response =
                intentsClient.ListIntents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Intent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIntentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Intent item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Intent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Intent item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetIntentAsync</summary>
        public async Task GetIntentAsync1()
        {
            // Snippet: GetIntentAsync(IntentName,CallSettings)
            // Additional: GetIntentAsync(IntentName,CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            IntentName name = new IntentName("[PROJECT]", "[INTENT]");
            // Make the request
            Intent response = await intentsClient.GetIntentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIntent</summary>
        public void GetIntent1()
        {
            // Snippet: GetIntent(IntentName,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            IntentName name = new IntentName("[PROJECT]", "[INTENT]");
            // Make the request
            Intent response = intentsClient.GetIntent(name);
            // End snippet
        }

        /// <summary>Snippet for GetIntentAsync</summary>
        public async Task GetIntentAsync2()
        {
            // Snippet: GetIntentAsync(IntentName,string,CallSettings)
            // Additional: GetIntentAsync(IntentName,string,CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            IntentName name = new IntentName("[PROJECT]", "[INTENT]");
            string languageCode = "";
            // Make the request
            Intent response = await intentsClient.GetIntentAsync(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for GetIntent</summary>
        public void GetIntent2()
        {
            // Snippet: GetIntent(IntentName,string,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            IntentName name = new IntentName("[PROJECT]", "[INTENT]");
            string languageCode = "";
            // Make the request
            Intent response = intentsClient.GetIntent(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for GetIntentAsync</summary>
        public async Task GetIntentAsync_RequestObject()
        {
            // Snippet: GetIntentAsync(GetIntentRequest,CallSettings)
            // Additional: GetIntentAsync(GetIntentRequest,CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
            };
            // Make the request
            Intent response = await intentsClient.GetIntentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIntent</summary>
        public void GetIntent_RequestObject()
        {
            // Snippet: GetIntent(GetIntentRequest,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
            };
            // Make the request
            Intent response = intentsClient.GetIntent(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIntentAsync</summary>
        public async Task CreateIntentAsync1()
        {
            // Snippet: CreateIntentAsync(ProjectAgentName,Intent,CallSettings)
            // Additional: CreateIntentAsync(ProjectAgentName,Intent,CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            Intent intent = new Intent();
            // Make the request
            Intent response = await intentsClient.CreateIntentAsync(parent, intent);
            // End snippet
        }

        /// <summary>Snippet for CreateIntent</summary>
        public void CreateIntent1()
        {
            // Snippet: CreateIntent(ProjectAgentName,Intent,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            Intent intent = new Intent();
            // Make the request
            Intent response = intentsClient.CreateIntent(parent, intent);
            // End snippet
        }

        /// <summary>Snippet for CreateIntentAsync</summary>
        public async Task CreateIntentAsync2()
        {
            // Snippet: CreateIntentAsync(ProjectAgentName,Intent,string,CallSettings)
            // Additional: CreateIntentAsync(ProjectAgentName,Intent,string,CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            Intent intent = new Intent();
            string languageCode = "";
            // Make the request
            Intent response = await intentsClient.CreateIntentAsync(parent, intent, languageCode);
            // End snippet
        }

        /// <summary>Snippet for CreateIntent</summary>
        public void CreateIntent2()
        {
            // Snippet: CreateIntent(ProjectAgentName,Intent,string,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            Intent intent = new Intent();
            string languageCode = "";
            // Make the request
            Intent response = intentsClient.CreateIntent(parent, intent, languageCode);
            // End snippet
        }

        /// <summary>Snippet for CreateIntentAsync</summary>
        public async Task CreateIntentAsync_RequestObject()
        {
            // Snippet: CreateIntentAsync(CreateIntentRequest,CallSettings)
            // Additional: CreateIntentAsync(CreateIntentRequest,CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                Intent = new Intent(),
            };
            // Make the request
            Intent response = await intentsClient.CreateIntentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIntent</summary>
        public void CreateIntent_RequestObject()
        {
            // Snippet: CreateIntent(CreateIntentRequest,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                Intent = new Intent(),
            };
            // Make the request
            Intent response = intentsClient.CreateIntent(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIntentAsync</summary>
        public async Task UpdateIntentAsync1()
        {
            // Snippet: UpdateIntentAsync(Intent,string,CallSettings)
            // Additional: UpdateIntentAsync(Intent,string,CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            Intent intent = new Intent();
            string languageCode = "";
            // Make the request
            Intent response = await intentsClient.UpdateIntentAsync(intent, languageCode);
            // End snippet
        }

        /// <summary>Snippet for UpdateIntent</summary>
        public void UpdateIntent1()
        {
            // Snippet: UpdateIntent(Intent,string,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            Intent intent = new Intent();
            string languageCode = "";
            // Make the request
            Intent response = intentsClient.UpdateIntent(intent, languageCode);
            // End snippet
        }

        /// <summary>Snippet for UpdateIntentAsync</summary>
        public async Task UpdateIntentAsync2()
        {
            // Snippet: UpdateIntentAsync(Intent,string,FieldMask,CallSettings)
            // Additional: UpdateIntentAsync(Intent,string,FieldMask,CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            Intent intent = new Intent();
            string languageCode = "";
            FieldMask updateMask = new FieldMask();
            // Make the request
            Intent response = await intentsClient.UpdateIntentAsync(intent, languageCode, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateIntent</summary>
        public void UpdateIntent2()
        {
            // Snippet: UpdateIntent(Intent,string,FieldMask,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            Intent intent = new Intent();
            string languageCode = "";
            FieldMask updateMask = new FieldMask();
            // Make the request
            Intent response = intentsClient.UpdateIntent(intent, languageCode, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateIntentAsync</summary>
        public async Task UpdateIntentAsync_RequestObject()
        {
            // Snippet: UpdateIntentAsync(UpdateIntentRequest,CallSettings)
            // Additional: UpdateIntentAsync(UpdateIntentRequest,CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "",
            };
            // Make the request
            Intent response = await intentsClient.UpdateIntentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIntent</summary>
        public void UpdateIntent_RequestObject()
        {
            // Snippet: UpdateIntent(UpdateIntentRequest,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "",
            };
            // Make the request
            Intent response = intentsClient.UpdateIntent(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIntentAsync</summary>
        public async Task DeleteIntentAsync()
        {
            // Snippet: DeleteIntentAsync(IntentName,CallSettings)
            // Additional: DeleteIntentAsync(IntentName,CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            IntentName name = new IntentName("[PROJECT]", "[INTENT]");
            // Make the request
            await intentsClient.DeleteIntentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIntent</summary>
        public void DeleteIntent()
        {
            // Snippet: DeleteIntent(IntentName,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            IntentName name = new IntentName("[PROJECT]", "[INTENT]");
            // Make the request
            intentsClient.DeleteIntent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIntentAsync</summary>
        public async Task DeleteIntentAsync_RequestObject()
        {
            // Snippet: DeleteIntentAsync(DeleteIntentRequest,CallSettings)
            // Additional: DeleteIntentAsync(DeleteIntentRequest,CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
            };
            // Make the request
            await intentsClient.DeleteIntentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIntent</summary>
        public void DeleteIntent_RequestObject()
        {
            // Snippet: DeleteIntent(DeleteIntentRequest,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
            };
            // Make the request
            intentsClient.DeleteIntent(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateIntentsAsync</summary>
        public async Task BatchUpdateIntentsAsync_RequestObject()
        {
            // Snippet: BatchUpdateIntentsAsync(BatchUpdateIntentsRequest,CallSettings)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateIntentsRequest request = new BatchUpdateIntentsRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                LanguageCode = "",
            };
            // Make the request
            Operation<BatchUpdateIntentsResponse, Struct> response =
                await intentsClient.BatchUpdateIntentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateIntentsResponse, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchUpdateIntentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateIntentsResponse, Struct> retrievedResponse =
                await intentsClient.PollOnceBatchUpdateIntentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateIntentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateIntents</summary>
        public void BatchUpdateIntents_RequestObject()
        {
            // Snippet: BatchUpdateIntents(BatchUpdateIntentsRequest,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            BatchUpdateIntentsRequest request = new BatchUpdateIntentsRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                LanguageCode = "",
            };
            // Make the request
            Operation<BatchUpdateIntentsResponse, Struct> response =
                intentsClient.BatchUpdateIntents(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateIntentsResponse, Struct> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            BatchUpdateIntentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateIntentsResponse, Struct> retrievedResponse =
                intentsClient.PollOnceBatchUpdateIntents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateIntentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteIntentsAsync</summary>
        public async Task BatchDeleteIntentsAsync()
        {
            // Snippet: BatchDeleteIntentsAsync(ProjectAgentName,IEnumerable<Intent>,CallSettings)
            // Additional: BatchDeleteIntentsAsync(ProjectAgentName,IEnumerable<Intent>,CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            IEnumerable<Intent> intents = new List<Intent>();
            // Make the request
            Operation<Empty, Struct> response =
                await intentsClient.BatchDeleteIntentsAsync(parent, intents);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                await intentsClient.PollOnceBatchDeleteIntentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteIntents</summary>
        public void BatchDeleteIntents()
        {
            // Snippet: BatchDeleteIntents(ProjectAgentName,IEnumerable<Intent>,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            IEnumerable<Intent> intents = new List<Intent>();
            // Make the request
            Operation<Empty, Struct> response =
                intentsClient.BatchDeleteIntents(parent, intents);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                intentsClient.PollOnceBatchDeleteIntents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteIntentsAsync</summary>
        public async Task BatchDeleteIntentsAsync_RequestObject()
        {
            // Snippet: BatchDeleteIntentsAsync(BatchDeleteIntentsRequest,CallSettings)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteIntentsRequest request = new BatchDeleteIntentsRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                Intents = { },
            };
            // Make the request
            Operation<Empty, Struct> response =
                await intentsClient.BatchDeleteIntentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                await intentsClient.PollOnceBatchDeleteIntentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteIntents</summary>
        public void BatchDeleteIntents_RequestObject()
        {
            // Snippet: BatchDeleteIntents(BatchDeleteIntentsRequest,CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            BatchDeleteIntentsRequest request = new BatchDeleteIntentsRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                Intents = { },
            };
            // Make the request
            Operation<Empty, Struct> response =
                intentsClient.BatchDeleteIntents(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                intentsClient.PollOnceBatchDeleteIntents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

    }
}
