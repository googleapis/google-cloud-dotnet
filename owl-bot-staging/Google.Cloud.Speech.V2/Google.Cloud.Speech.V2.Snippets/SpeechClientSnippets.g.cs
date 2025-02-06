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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Speech.V2;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSpeechClientSnippets
    {
        /// <summary>Snippet for CreateRecognizer</summary>
        public void CreateRecognizerRequestObject()
        {
            // Snippet: CreateRecognizer(CreateRecognizerRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            CreateRecognizerRequest request = new CreateRecognizerRequest
            {
                Recognizer = new Recognizer(),
                ValidateOnly = false,
                RecognizerId = "",
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Operation<Recognizer, OperationMetadata> response = speechClient.CreateRecognizer(request);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = speechClient.PollOnceCreateRecognizer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRecognizerAsync</summary>
        public async Task CreateRecognizerRequestObjectAsync()
        {
            // Snippet: CreateRecognizerAsync(CreateRecognizerRequest, CallSettings)
            // Additional: CreateRecognizerAsync(CreateRecognizerRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            CreateRecognizerRequest request = new CreateRecognizerRequest
            {
                Recognizer = new Recognizer(),
                ValidateOnly = false,
                RecognizerId = "",
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Operation<Recognizer, OperationMetadata> response = await speechClient.CreateRecognizerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = await speechClient.PollOnceCreateRecognizerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRecognizer</summary>
        public void CreateRecognizer()
        {
            // Snippet: CreateRecognizer(string, Recognizer, string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Recognizer recognizer = new Recognizer();
            string recognizerId = "";
            // Make the request
            Operation<Recognizer, OperationMetadata> response = speechClient.CreateRecognizer(parent, recognizer, recognizerId);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = speechClient.PollOnceCreateRecognizer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRecognizerAsync</summary>
        public async Task CreateRecognizerAsync()
        {
            // Snippet: CreateRecognizerAsync(string, Recognizer, string, CallSettings)
            // Additional: CreateRecognizerAsync(string, Recognizer, string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Recognizer recognizer = new Recognizer();
            string recognizerId = "";
            // Make the request
            Operation<Recognizer, OperationMetadata> response = await speechClient.CreateRecognizerAsync(parent, recognizer, recognizerId);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = await speechClient.PollOnceCreateRecognizerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRecognizer</summary>
        public void CreateRecognizerResourceNames()
        {
            // Snippet: CreateRecognizer(LocationName, Recognizer, string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Recognizer recognizer = new Recognizer();
            string recognizerId = "";
            // Make the request
            Operation<Recognizer, OperationMetadata> response = speechClient.CreateRecognizer(parent, recognizer, recognizerId);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = speechClient.PollOnceCreateRecognizer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRecognizerAsync</summary>
        public async Task CreateRecognizerResourceNamesAsync()
        {
            // Snippet: CreateRecognizerAsync(LocationName, Recognizer, string, CallSettings)
            // Additional: CreateRecognizerAsync(LocationName, Recognizer, string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Recognizer recognizer = new Recognizer();
            string recognizerId = "";
            // Make the request
            Operation<Recognizer, OperationMetadata> response = await speechClient.CreateRecognizerAsync(parent, recognizer, recognizerId);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = await speechClient.PollOnceCreateRecognizerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListRecognizers</summary>
        public void ListRecognizersRequestObject()
        {
            // Snippet: ListRecognizers(ListRecognizersRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            ListRecognizersRequest request = new ListRecognizersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListRecognizersResponse, Recognizer> response = speechClient.ListRecognizers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Recognizer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRecognizersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recognizer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recognizer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recognizer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecognizersAsync</summary>
        public async Task ListRecognizersRequestObjectAsync()
        {
            // Snippet: ListRecognizersAsync(ListRecognizersRequest, CallSettings)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            ListRecognizersRequest request = new ListRecognizersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListRecognizersResponse, Recognizer> response = speechClient.ListRecognizersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Recognizer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRecognizersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recognizer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recognizer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recognizer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecognizers</summary>
        public void ListRecognizers()
        {
            // Snippet: ListRecognizers(string, string, int?, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListRecognizersResponse, Recognizer> response = speechClient.ListRecognizers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Recognizer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRecognizersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recognizer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recognizer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recognizer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecognizersAsync</summary>
        public async Task ListRecognizersAsync()
        {
            // Snippet: ListRecognizersAsync(string, string, int?, CallSettings)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListRecognizersResponse, Recognizer> response = speechClient.ListRecognizersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Recognizer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRecognizersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recognizer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recognizer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recognizer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecognizers</summary>
        public void ListRecognizersResourceNames()
        {
            // Snippet: ListRecognizers(LocationName, string, int?, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListRecognizersResponse, Recognizer> response = speechClient.ListRecognizers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Recognizer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRecognizersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recognizer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recognizer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recognizer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecognizersAsync</summary>
        public async Task ListRecognizersResourceNamesAsync()
        {
            // Snippet: ListRecognizersAsync(LocationName, string, int?, CallSettings)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListRecognizersResponse, Recognizer> response = speechClient.ListRecognizersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Recognizer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRecognizersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recognizer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recognizer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recognizer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRecognizer</summary>
        public void GetRecognizerRequestObject()
        {
            // Snippet: GetRecognizer(GetRecognizerRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            GetRecognizerRequest request = new GetRecognizerRequest
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
            };
            // Make the request
            Recognizer response = speechClient.GetRecognizer(request);
            // End snippet
        }

        /// <summary>Snippet for GetRecognizerAsync</summary>
        public async Task GetRecognizerRequestObjectAsync()
        {
            // Snippet: GetRecognizerAsync(GetRecognizerRequest, CallSettings)
            // Additional: GetRecognizerAsync(GetRecognizerRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            GetRecognizerRequest request = new GetRecognizerRequest
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
            };
            // Make the request
            Recognizer response = await speechClient.GetRecognizerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRecognizer</summary>
        public void GetRecognizer()
        {
            // Snippet: GetRecognizer(string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/recognizers/[RECOGNIZER]";
            // Make the request
            Recognizer response = speechClient.GetRecognizer(name);
            // End snippet
        }

        /// <summary>Snippet for GetRecognizerAsync</summary>
        public async Task GetRecognizerAsync()
        {
            // Snippet: GetRecognizerAsync(string, CallSettings)
            // Additional: GetRecognizerAsync(string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/recognizers/[RECOGNIZER]";
            // Make the request
            Recognizer response = await speechClient.GetRecognizerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRecognizer</summary>
        public void GetRecognizerResourceNames()
        {
            // Snippet: GetRecognizer(RecognizerName, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognizerName name = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]");
            // Make the request
            Recognizer response = speechClient.GetRecognizer(name);
            // End snippet
        }

        /// <summary>Snippet for GetRecognizerAsync</summary>
        public async Task GetRecognizerResourceNamesAsync()
        {
            // Snippet: GetRecognizerAsync(RecognizerName, CallSettings)
            // Additional: GetRecognizerAsync(RecognizerName, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            RecognizerName name = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]");
            // Make the request
            Recognizer response = await speechClient.GetRecognizerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateRecognizer</summary>
        public void UpdateRecognizerRequestObject()
        {
            // Snippet: UpdateRecognizer(UpdateRecognizerRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            UpdateRecognizerRequest request = new UpdateRecognizerRequest
            {
                Recognizer = new Recognizer(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Recognizer, OperationMetadata> response = speechClient.UpdateRecognizer(request);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = speechClient.PollOnceUpdateRecognizer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRecognizerAsync</summary>
        public async Task UpdateRecognizerRequestObjectAsync()
        {
            // Snippet: UpdateRecognizerAsync(UpdateRecognizerRequest, CallSettings)
            // Additional: UpdateRecognizerAsync(UpdateRecognizerRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRecognizerRequest request = new UpdateRecognizerRequest
            {
                Recognizer = new Recognizer(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Recognizer, OperationMetadata> response = await speechClient.UpdateRecognizerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = await speechClient.PollOnceUpdateRecognizerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRecognizer</summary>
        public void UpdateRecognizer()
        {
            // Snippet: UpdateRecognizer(Recognizer, FieldMask, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            Recognizer recognizer = new Recognizer();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Recognizer, OperationMetadata> response = speechClient.UpdateRecognizer(recognizer, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = speechClient.PollOnceUpdateRecognizer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRecognizerAsync</summary>
        public async Task UpdateRecognizerAsync()
        {
            // Snippet: UpdateRecognizerAsync(Recognizer, FieldMask, CallSettings)
            // Additional: UpdateRecognizerAsync(Recognizer, FieldMask, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            Recognizer recognizer = new Recognizer();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Recognizer, OperationMetadata> response = await speechClient.UpdateRecognizerAsync(recognizer, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = await speechClient.PollOnceUpdateRecognizerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRecognizer</summary>
        public void DeleteRecognizerRequestObject()
        {
            // Snippet: DeleteRecognizer(DeleteRecognizerRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            DeleteRecognizerRequest request = new DeleteRecognizerRequest
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                ValidateOnly = false,
                Etag = "",
                AllowMissing = false,
            };
            // Make the request
            Operation<Recognizer, OperationMetadata> response = speechClient.DeleteRecognizer(request);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = speechClient.PollOnceDeleteRecognizer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRecognizerAsync</summary>
        public async Task DeleteRecognizerRequestObjectAsync()
        {
            // Snippet: DeleteRecognizerAsync(DeleteRecognizerRequest, CallSettings)
            // Additional: DeleteRecognizerAsync(DeleteRecognizerRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRecognizerRequest request = new DeleteRecognizerRequest
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                ValidateOnly = false,
                Etag = "",
                AllowMissing = false,
            };
            // Make the request
            Operation<Recognizer, OperationMetadata> response = await speechClient.DeleteRecognizerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = await speechClient.PollOnceDeleteRecognizerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRecognizer</summary>
        public void DeleteRecognizer()
        {
            // Snippet: DeleteRecognizer(string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/recognizers/[RECOGNIZER]";
            // Make the request
            Operation<Recognizer, OperationMetadata> response = speechClient.DeleteRecognizer(name);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = speechClient.PollOnceDeleteRecognizer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRecognizerAsync</summary>
        public async Task DeleteRecognizerAsync()
        {
            // Snippet: DeleteRecognizerAsync(string, CallSettings)
            // Additional: DeleteRecognizerAsync(string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/recognizers/[RECOGNIZER]";
            // Make the request
            Operation<Recognizer, OperationMetadata> response = await speechClient.DeleteRecognizerAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = await speechClient.PollOnceDeleteRecognizerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRecognizer</summary>
        public void DeleteRecognizerResourceNames()
        {
            // Snippet: DeleteRecognizer(RecognizerName, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognizerName name = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]");
            // Make the request
            Operation<Recognizer, OperationMetadata> response = speechClient.DeleteRecognizer(name);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = speechClient.PollOnceDeleteRecognizer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRecognizerAsync</summary>
        public async Task DeleteRecognizerResourceNamesAsync()
        {
            // Snippet: DeleteRecognizerAsync(RecognizerName, CallSettings)
            // Additional: DeleteRecognizerAsync(RecognizerName, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            RecognizerName name = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]");
            // Make the request
            Operation<Recognizer, OperationMetadata> response = await speechClient.DeleteRecognizerAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = await speechClient.PollOnceDeleteRecognizerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteRecognizer</summary>
        public void UndeleteRecognizerRequestObject()
        {
            // Snippet: UndeleteRecognizer(UndeleteRecognizerRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            UndeleteRecognizerRequest request = new UndeleteRecognizerRequest
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Recognizer, OperationMetadata> response = speechClient.UndeleteRecognizer(request);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = speechClient.PollOnceUndeleteRecognizer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteRecognizerAsync</summary>
        public async Task UndeleteRecognizerRequestObjectAsync()
        {
            // Snippet: UndeleteRecognizerAsync(UndeleteRecognizerRequest, CallSettings)
            // Additional: UndeleteRecognizerAsync(UndeleteRecognizerRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteRecognizerRequest request = new UndeleteRecognizerRequest
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Recognizer, OperationMetadata> response = await speechClient.UndeleteRecognizerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = await speechClient.PollOnceUndeleteRecognizerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteRecognizer</summary>
        public void UndeleteRecognizer()
        {
            // Snippet: UndeleteRecognizer(string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/recognizers/[RECOGNIZER]";
            // Make the request
            Operation<Recognizer, OperationMetadata> response = speechClient.UndeleteRecognizer(name);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = speechClient.PollOnceUndeleteRecognizer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteRecognizerAsync</summary>
        public async Task UndeleteRecognizerAsync()
        {
            // Snippet: UndeleteRecognizerAsync(string, CallSettings)
            // Additional: UndeleteRecognizerAsync(string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/recognizers/[RECOGNIZER]";
            // Make the request
            Operation<Recognizer, OperationMetadata> response = await speechClient.UndeleteRecognizerAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = await speechClient.PollOnceUndeleteRecognizerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteRecognizer</summary>
        public void UndeleteRecognizerResourceNames()
        {
            // Snippet: UndeleteRecognizer(RecognizerName, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognizerName name = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]");
            // Make the request
            Operation<Recognizer, OperationMetadata> response = speechClient.UndeleteRecognizer(name);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = speechClient.PollOnceUndeleteRecognizer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteRecognizerAsync</summary>
        public async Task UndeleteRecognizerResourceNamesAsync()
        {
            // Snippet: UndeleteRecognizerAsync(RecognizerName, CallSettings)
            // Additional: UndeleteRecognizerAsync(RecognizerName, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            RecognizerName name = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]");
            // Make the request
            Operation<Recognizer, OperationMetadata> response = await speechClient.UndeleteRecognizerAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = await speechClient.PollOnceUndeleteRecognizerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Recognize</summary>
        public void RecognizeRequestObject()
        {
            // Snippet: Recognize(RecognizeRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Content = ByteString.Empty,
                ConfigMask = new FieldMask(),
            };
            // Make the request
            RecognizeResponse response = speechClient.Recognize(request);
            // End snippet
        }

        /// <summary>Snippet for RecognizeAsync</summary>
        public async Task RecognizeRequestObjectAsync()
        {
            // Snippet: RecognizeAsync(RecognizeRequest, CallSettings)
            // Additional: RecognizeAsync(RecognizeRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Content = ByteString.Empty,
                ConfigMask = new FieldMask(),
            };
            // Make the request
            RecognizeResponse response = await speechClient.RecognizeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Recognize</summary>
        public void Recognize1()
        {
            // Snippet: Recognize(string, RecognitionConfig, FieldMask, ByteString, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string recognizer = "projects/[PROJECT]/locations/[LOCATION]/recognizers/[RECOGNIZER]";
            RecognitionConfig config = new RecognitionConfig();
            FieldMask configMask = new FieldMask();
            ByteString content = ByteString.Empty;
            // Make the request
            RecognizeResponse response = speechClient.Recognize(recognizer, config, configMask, content);
            // End snippet
        }

        /// <summary>Snippet for RecognizeAsync</summary>
        public async Task Recognize1Async()
        {
            // Snippet: RecognizeAsync(string, RecognitionConfig, FieldMask, ByteString, CallSettings)
            // Additional: RecognizeAsync(string, RecognitionConfig, FieldMask, ByteString, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string recognizer = "projects/[PROJECT]/locations/[LOCATION]/recognizers/[RECOGNIZER]";
            RecognitionConfig config = new RecognitionConfig();
            FieldMask configMask = new FieldMask();
            ByteString content = ByteString.Empty;
            // Make the request
            RecognizeResponse response = await speechClient.RecognizeAsync(recognizer, config, configMask, content);
            // End snippet
        }

        /// <summary>Snippet for Recognize</summary>
        public void Recognize1ResourceNames()
        {
            // Snippet: Recognize(RecognizerName, RecognitionConfig, FieldMask, ByteString, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognizerName recognizer = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]");
            RecognitionConfig config = new RecognitionConfig();
            FieldMask configMask = new FieldMask();
            ByteString content = ByteString.Empty;
            // Make the request
            RecognizeResponse response = speechClient.Recognize(recognizer, config, configMask, content);
            // End snippet
        }

        /// <summary>Snippet for RecognizeAsync</summary>
        public async Task Recognize1ResourceNamesAsync()
        {
            // Snippet: RecognizeAsync(RecognizerName, RecognitionConfig, FieldMask, ByteString, CallSettings)
            // Additional: RecognizeAsync(RecognizerName, RecognitionConfig, FieldMask, ByteString, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            RecognizerName recognizer = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]");
            RecognitionConfig config = new RecognitionConfig();
            FieldMask configMask = new FieldMask();
            ByteString content = ByteString.Empty;
            // Make the request
            RecognizeResponse response = await speechClient.RecognizeAsync(recognizer, config, configMask, content);
            // End snippet
        }

        /// <summary>Snippet for Recognize</summary>
        public void Recognize2()
        {
            // Snippet: Recognize(string, RecognitionConfig, FieldMask, string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string recognizer = "projects/[PROJECT]/locations/[LOCATION]/recognizers/[RECOGNIZER]";
            RecognitionConfig config = new RecognitionConfig();
            FieldMask configMask = new FieldMask();
            string uri = "";
            // Make the request
            RecognizeResponse response = speechClient.Recognize(recognizer, config, configMask, uri);
            // End snippet
        }

        /// <summary>Snippet for RecognizeAsync</summary>
        public async Task Recognize2Async()
        {
            // Snippet: RecognizeAsync(string, RecognitionConfig, FieldMask, string, CallSettings)
            // Additional: RecognizeAsync(string, RecognitionConfig, FieldMask, string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string recognizer = "projects/[PROJECT]/locations/[LOCATION]/recognizers/[RECOGNIZER]";
            RecognitionConfig config = new RecognitionConfig();
            FieldMask configMask = new FieldMask();
            string uri = "";
            // Make the request
            RecognizeResponse response = await speechClient.RecognizeAsync(recognizer, config, configMask, uri);
            // End snippet
        }

        /// <summary>Snippet for Recognize</summary>
        public void Recognize2ResourceNames()
        {
            // Snippet: Recognize(RecognizerName, RecognitionConfig, FieldMask, string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognizerName recognizer = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]");
            RecognitionConfig config = new RecognitionConfig();
            FieldMask configMask = new FieldMask();
            string uri = "";
            // Make the request
            RecognizeResponse response = speechClient.Recognize(recognizer, config, configMask, uri);
            // End snippet
        }

        /// <summary>Snippet for RecognizeAsync</summary>
        public async Task Recognize2ResourceNamesAsync()
        {
            // Snippet: RecognizeAsync(RecognizerName, RecognitionConfig, FieldMask, string, CallSettings)
            // Additional: RecognizeAsync(RecognizerName, RecognitionConfig, FieldMask, string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            RecognizerName recognizer = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]");
            RecognitionConfig config = new RecognitionConfig();
            FieldMask configMask = new FieldMask();
            string uri = "";
            // Make the request
            RecognizeResponse response = await speechClient.RecognizeAsync(recognizer, config, configMask, uri);
            // End snippet
        }

        /// <summary>Snippet for StreamingRecognize</summary>
        public async Task StreamingRecognize()
        {
            // Snippet: StreamingRecognize(CallSettings, BidirectionalStreamingSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize streaming call, retrieving the stream object
            using SpeechClient.StreamingRecognizeStream response = speechClient.StreamingRecognize();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<StreamingRecognizeResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    StreamingRecognizeResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                StreamingRecognizeRequest request = new StreamingRecognizeRequest
                {
                    RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                    StreamingConfig = new StreamingRecognitionConfig(),
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for BatchRecognize</summary>
        public void BatchRecognizeRequestObject()
        {
            // Snippet: BatchRecognize(BatchRecognizeRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            BatchRecognizeRequest request = new BatchRecognizeRequest
            {
                RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Files =
                {
                    new BatchRecognizeFileMetadata(),
                },
                Config = new RecognitionConfig(),
                ConfigMask = new FieldMask(),
                RecognitionOutputConfig = new RecognitionOutputConfig(),
                ProcessingStrategy = BatchRecognizeRequest.Types.ProcessingStrategy.Unspecified,
            };
            // Make the request
            Operation<BatchRecognizeResponse, OperationMetadata> response = speechClient.BatchRecognize(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchRecognizeResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchRecognizeResponse, OperationMetadata> retrievedResponse = speechClient.PollOnceBatchRecognize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchRecognizeAsync</summary>
        public async Task BatchRecognizeRequestObjectAsync()
        {
            // Snippet: BatchRecognizeAsync(BatchRecognizeRequest, CallSettings)
            // Additional: BatchRecognizeAsync(BatchRecognizeRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            BatchRecognizeRequest request = new BatchRecognizeRequest
            {
                RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Files =
                {
                    new BatchRecognizeFileMetadata(),
                },
                Config = new RecognitionConfig(),
                ConfigMask = new FieldMask(),
                RecognitionOutputConfig = new RecognitionOutputConfig(),
                ProcessingStrategy = BatchRecognizeRequest.Types.ProcessingStrategy.Unspecified,
            };
            // Make the request
            Operation<BatchRecognizeResponse, OperationMetadata> response = await speechClient.BatchRecognizeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchRecognizeResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchRecognizeResponse, OperationMetadata> retrievedResponse = await speechClient.PollOnceBatchRecognizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchRecognize</summary>
        public void BatchRecognize()
        {
            // Snippet: BatchRecognize(string, RecognitionConfig, FieldMask, IEnumerable<BatchRecognizeFileMetadata>, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string recognizer = "projects/[PROJECT]/locations/[LOCATION]/recognizers/[RECOGNIZER]";
            RecognitionConfig config = new RecognitionConfig();
            FieldMask configMask = new FieldMask();
            IEnumerable<BatchRecognizeFileMetadata> files = new BatchRecognizeFileMetadata[]
            {
                new BatchRecognizeFileMetadata(),
            };
            // Make the request
            Operation<BatchRecognizeResponse, OperationMetadata> response = speechClient.BatchRecognize(recognizer, config, configMask, files);

            // Poll until the returned long-running operation is complete
            Operation<BatchRecognizeResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchRecognizeResponse, OperationMetadata> retrievedResponse = speechClient.PollOnceBatchRecognize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchRecognizeAsync</summary>
        public async Task BatchRecognizeAsync()
        {
            // Snippet: BatchRecognizeAsync(string, RecognitionConfig, FieldMask, IEnumerable<BatchRecognizeFileMetadata>, CallSettings)
            // Additional: BatchRecognizeAsync(string, RecognitionConfig, FieldMask, IEnumerable<BatchRecognizeFileMetadata>, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string recognizer = "projects/[PROJECT]/locations/[LOCATION]/recognizers/[RECOGNIZER]";
            RecognitionConfig config = new RecognitionConfig();
            FieldMask configMask = new FieldMask();
            IEnumerable<BatchRecognizeFileMetadata> files = new BatchRecognizeFileMetadata[]
            {
                new BatchRecognizeFileMetadata(),
            };
            // Make the request
            Operation<BatchRecognizeResponse, OperationMetadata> response = await speechClient.BatchRecognizeAsync(recognizer, config, configMask, files);

            // Poll until the returned long-running operation is complete
            Operation<BatchRecognizeResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchRecognizeResponse, OperationMetadata> retrievedResponse = await speechClient.PollOnceBatchRecognizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchRecognize</summary>
        public void BatchRecognizeResourceNames()
        {
            // Snippet: BatchRecognize(RecognizerName, RecognitionConfig, FieldMask, IEnumerable<BatchRecognizeFileMetadata>, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognizerName recognizer = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]");
            RecognitionConfig config = new RecognitionConfig();
            FieldMask configMask = new FieldMask();
            IEnumerable<BatchRecognizeFileMetadata> files = new BatchRecognizeFileMetadata[]
            {
                new BatchRecognizeFileMetadata(),
            };
            // Make the request
            Operation<BatchRecognizeResponse, OperationMetadata> response = speechClient.BatchRecognize(recognizer, config, configMask, files);

            // Poll until the returned long-running operation is complete
            Operation<BatchRecognizeResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchRecognizeResponse, OperationMetadata> retrievedResponse = speechClient.PollOnceBatchRecognize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchRecognizeAsync</summary>
        public async Task BatchRecognizeResourceNamesAsync()
        {
            // Snippet: BatchRecognizeAsync(RecognizerName, RecognitionConfig, FieldMask, IEnumerable<BatchRecognizeFileMetadata>, CallSettings)
            // Additional: BatchRecognizeAsync(RecognizerName, RecognitionConfig, FieldMask, IEnumerable<BatchRecognizeFileMetadata>, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            RecognizerName recognizer = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]");
            RecognitionConfig config = new RecognitionConfig();
            FieldMask configMask = new FieldMask();
            IEnumerable<BatchRecognizeFileMetadata> files = new BatchRecognizeFileMetadata[]
            {
                new BatchRecognizeFileMetadata(),
            };
            // Make the request
            Operation<BatchRecognizeResponse, OperationMetadata> response = await speechClient.BatchRecognizeAsync(recognizer, config, configMask, files);

            // Poll until the returned long-running operation is complete
            Operation<BatchRecognizeResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchRecognizeResponse, OperationMetadata> retrievedResponse = await speechClient.PollOnceBatchRecognizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetConfig</summary>
        public void GetConfigRequestObject()
        {
            // Snippet: GetConfig(GetConfigRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Config response = speechClient.GetConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetConfigAsync</summary>
        public async Task GetConfigRequestObjectAsync()
        {
            // Snippet: GetConfigAsync(GetConfigRequest, CallSettings)
            // Additional: GetConfigAsync(GetConfigRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Config response = await speechClient.GetConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConfig</summary>
        public void GetConfig()
        {
            // Snippet: GetConfig(string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/config";
            // Make the request
            Config response = speechClient.GetConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfigAsync</summary>
        public async Task GetConfigAsync()
        {
            // Snippet: GetConfigAsync(string, CallSettings)
            // Additional: GetConfigAsync(string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/config";
            // Make the request
            Config response = await speechClient.GetConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfig</summary>
        public void GetConfigResourceNames()
        {
            // Snippet: GetConfig(ConfigName, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            ConfigName name = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Config response = speechClient.GetConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfigAsync</summary>
        public async Task GetConfigResourceNamesAsync()
        {
            // Snippet: GetConfigAsync(ConfigName, CallSettings)
            // Additional: GetConfigAsync(ConfigName, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            ConfigName name = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Config response = await speechClient.GetConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateConfig</summary>
        public void UpdateConfigRequestObject()
        {
            // Snippet: UpdateConfig(UpdateConfigRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            UpdateConfigRequest request = new UpdateConfigRequest
            {
                Config = new Config(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Config response = speechClient.UpdateConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConfigAsync</summary>
        public async Task UpdateConfigRequestObjectAsync()
        {
            // Snippet: UpdateConfigAsync(UpdateConfigRequest, CallSettings)
            // Additional: UpdateConfigAsync(UpdateConfigRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConfigRequest request = new UpdateConfigRequest
            {
                Config = new Config(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Config response = await speechClient.UpdateConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConfig</summary>
        public void UpdateConfig()
        {
            // Snippet: UpdateConfig(Config, FieldMask, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            Config config = new Config();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Config response = speechClient.UpdateConfig(config, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateConfigAsync</summary>
        public async Task UpdateConfigAsync()
        {
            // Snippet: UpdateConfigAsync(Config, FieldMask, CallSettings)
            // Additional: UpdateConfigAsync(Config, FieldMask, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            Config config = new Config();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Config response = await speechClient.UpdateConfigAsync(config, updateMask);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomClass</summary>
        public void CreateCustomClassRequestObject()
        {
            // Snippet: CreateCustomClass(CreateCustomClassRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            CreateCustomClassRequest request = new CreateCustomClassRequest
            {
                CustomClass = new CustomClass(),
                ValidateOnly = false,
                CustomClassId = "",
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Operation<CustomClass, OperationMetadata> response = speechClient.CreateCustomClass(request);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = speechClient.PollOnceCreateCustomClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCustomClassAsync</summary>
        public async Task CreateCustomClassRequestObjectAsync()
        {
            // Snippet: CreateCustomClassAsync(CreateCustomClassRequest, CallSettings)
            // Additional: CreateCustomClassAsync(CreateCustomClassRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            CreateCustomClassRequest request = new CreateCustomClassRequest
            {
                CustomClass = new CustomClass(),
                ValidateOnly = false,
                CustomClassId = "",
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Operation<CustomClass, OperationMetadata> response = await speechClient.CreateCustomClassAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = await speechClient.PollOnceCreateCustomClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCustomClass</summary>
        public void CreateCustomClass()
        {
            // Snippet: CreateCustomClass(string, CustomClass, string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CustomClass customClass = new CustomClass();
            string customClassId = "";
            // Make the request
            Operation<CustomClass, OperationMetadata> response = speechClient.CreateCustomClass(parent, customClass, customClassId);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = speechClient.PollOnceCreateCustomClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCustomClassAsync</summary>
        public async Task CreateCustomClassAsync()
        {
            // Snippet: CreateCustomClassAsync(string, CustomClass, string, CallSettings)
            // Additional: CreateCustomClassAsync(string, CustomClass, string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CustomClass customClass = new CustomClass();
            string customClassId = "";
            // Make the request
            Operation<CustomClass, OperationMetadata> response = await speechClient.CreateCustomClassAsync(parent, customClass, customClassId);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = await speechClient.PollOnceCreateCustomClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCustomClass</summary>
        public void CreateCustomClassResourceNames()
        {
            // Snippet: CreateCustomClass(LocationName, CustomClass, string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CustomClass customClass = new CustomClass();
            string customClassId = "";
            // Make the request
            Operation<CustomClass, OperationMetadata> response = speechClient.CreateCustomClass(parent, customClass, customClassId);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = speechClient.PollOnceCreateCustomClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCustomClassAsync</summary>
        public async Task CreateCustomClassResourceNamesAsync()
        {
            // Snippet: CreateCustomClassAsync(LocationName, CustomClass, string, CallSettings)
            // Additional: CreateCustomClassAsync(LocationName, CustomClass, string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CustomClass customClass = new CustomClass();
            string customClassId = "";
            // Make the request
            Operation<CustomClass, OperationMetadata> response = await speechClient.CreateCustomClassAsync(parent, customClass, customClassId);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = await speechClient.PollOnceCreateCustomClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListCustomClasses</summary>
        public void ListCustomClassesRequestObject()
        {
            // Snippet: ListCustomClasses(ListCustomClassesRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            ListCustomClassesRequest request = new ListCustomClassesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListCustomClassesResponse, CustomClass> response = speechClient.ListCustomClasses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomClass item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomClassesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomClass item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomClass> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomClass item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomClassesAsync</summary>
        public async Task ListCustomClassesRequestObjectAsync()
        {
            // Snippet: ListCustomClassesAsync(ListCustomClassesRequest, CallSettings)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            ListCustomClassesRequest request = new ListCustomClassesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListCustomClassesResponse, CustomClass> response = speechClient.ListCustomClassesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomClass item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomClassesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomClass item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomClass> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomClass item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomClasses</summary>
        public void ListCustomClasses()
        {
            // Snippet: ListCustomClasses(string, string, int?, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCustomClassesResponse, CustomClass> response = speechClient.ListCustomClasses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomClass item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomClassesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomClass item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomClass> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomClass item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomClassesAsync</summary>
        public async Task ListCustomClassesAsync()
        {
            // Snippet: ListCustomClassesAsync(string, string, int?, CallSettings)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCustomClassesResponse, CustomClass> response = speechClient.ListCustomClassesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomClass item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomClassesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomClass item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomClass> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomClass item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomClasses</summary>
        public void ListCustomClassesResourceNames()
        {
            // Snippet: ListCustomClasses(LocationName, string, int?, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCustomClassesResponse, CustomClass> response = speechClient.ListCustomClasses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomClass item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomClassesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomClass item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomClass> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomClass item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomClassesAsync</summary>
        public async Task ListCustomClassesResourceNamesAsync()
        {
            // Snippet: ListCustomClassesAsync(LocationName, string, int?, CallSettings)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCustomClassesResponse, CustomClass> response = speechClient.ListCustomClassesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomClass item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomClassesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomClass item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomClass> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomClass item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCustomClass</summary>
        public void GetCustomClassRequestObject()
        {
            // Snippet: GetCustomClass(GetCustomClassRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            // Make the request
            CustomClass response = speechClient.GetCustomClass(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomClassAsync</summary>
        public async Task GetCustomClassRequestObjectAsync()
        {
            // Snippet: GetCustomClassAsync(GetCustomClassRequest, CallSettings)
            // Additional: GetCustomClassAsync(GetCustomClassRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            // Make the request
            CustomClass response = await speechClient.GetCustomClassAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomClass</summary>
        public void GetCustomClass()
        {
            // Snippet: GetCustomClass(string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customClasses/[CUSTOM_CLASS]";
            // Make the request
            CustomClass response = speechClient.GetCustomClass(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomClassAsync</summary>
        public async Task GetCustomClassAsync()
        {
            // Snippet: GetCustomClassAsync(string, CallSettings)
            // Additional: GetCustomClassAsync(string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customClasses/[CUSTOM_CLASS]";
            // Make the request
            CustomClass response = await speechClient.GetCustomClassAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomClass</summary>
        public void GetCustomClassResourceNames()
        {
            // Snippet: GetCustomClass(CustomClassName, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            CustomClassName name = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]");
            // Make the request
            CustomClass response = speechClient.GetCustomClass(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomClassAsync</summary>
        public async Task GetCustomClassResourceNamesAsync()
        {
            // Snippet: GetCustomClassAsync(CustomClassName, CallSettings)
            // Additional: GetCustomClassAsync(CustomClassName, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            CustomClassName name = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]");
            // Make the request
            CustomClass response = await speechClient.GetCustomClassAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomClass</summary>
        public void UpdateCustomClassRequestObject()
        {
            // Snippet: UpdateCustomClass(UpdateCustomClassRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            UpdateCustomClassRequest request = new UpdateCustomClassRequest
            {
                CustomClass = new CustomClass(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<CustomClass, OperationMetadata> response = speechClient.UpdateCustomClass(request);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = speechClient.PollOnceUpdateCustomClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomClassAsync</summary>
        public async Task UpdateCustomClassRequestObjectAsync()
        {
            // Snippet: UpdateCustomClassAsync(UpdateCustomClassRequest, CallSettings)
            // Additional: UpdateCustomClassAsync(UpdateCustomClassRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCustomClassRequest request = new UpdateCustomClassRequest
            {
                CustomClass = new CustomClass(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<CustomClass, OperationMetadata> response = await speechClient.UpdateCustomClassAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = await speechClient.PollOnceUpdateCustomClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomClass</summary>
        public void UpdateCustomClass()
        {
            // Snippet: UpdateCustomClass(CustomClass, FieldMask, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            CustomClass customClass = new CustomClass();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CustomClass, OperationMetadata> response = speechClient.UpdateCustomClass(customClass, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = speechClient.PollOnceUpdateCustomClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomClassAsync</summary>
        public async Task UpdateCustomClassAsync()
        {
            // Snippet: UpdateCustomClassAsync(CustomClass, FieldMask, CallSettings)
            // Additional: UpdateCustomClassAsync(CustomClass, FieldMask, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            CustomClass customClass = new CustomClass();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CustomClass, OperationMetadata> response = await speechClient.UpdateCustomClassAsync(customClass, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = await speechClient.PollOnceUpdateCustomClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomClass</summary>
        public void DeleteCustomClassRequestObject()
        {
            // Snippet: DeleteCustomClass(DeleteCustomClassRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            DeleteCustomClassRequest request = new DeleteCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                ValidateOnly = false,
                Etag = "",
                AllowMissing = false,
            };
            // Make the request
            Operation<CustomClass, OperationMetadata> response = speechClient.DeleteCustomClass(request);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = speechClient.PollOnceDeleteCustomClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomClassAsync</summary>
        public async Task DeleteCustomClassRequestObjectAsync()
        {
            // Snippet: DeleteCustomClassAsync(DeleteCustomClassRequest, CallSettings)
            // Additional: DeleteCustomClassAsync(DeleteCustomClassRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCustomClassRequest request = new DeleteCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                ValidateOnly = false,
                Etag = "",
                AllowMissing = false,
            };
            // Make the request
            Operation<CustomClass, OperationMetadata> response = await speechClient.DeleteCustomClassAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = await speechClient.PollOnceDeleteCustomClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomClass</summary>
        public void DeleteCustomClass()
        {
            // Snippet: DeleteCustomClass(string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customClasses/[CUSTOM_CLASS]";
            // Make the request
            Operation<CustomClass, OperationMetadata> response = speechClient.DeleteCustomClass(name);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = speechClient.PollOnceDeleteCustomClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomClassAsync</summary>
        public async Task DeleteCustomClassAsync()
        {
            // Snippet: DeleteCustomClassAsync(string, CallSettings)
            // Additional: DeleteCustomClassAsync(string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customClasses/[CUSTOM_CLASS]";
            // Make the request
            Operation<CustomClass, OperationMetadata> response = await speechClient.DeleteCustomClassAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = await speechClient.PollOnceDeleteCustomClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomClass</summary>
        public void DeleteCustomClassResourceNames()
        {
            // Snippet: DeleteCustomClass(CustomClassName, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            CustomClassName name = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]");
            // Make the request
            Operation<CustomClass, OperationMetadata> response = speechClient.DeleteCustomClass(name);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = speechClient.PollOnceDeleteCustomClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomClassAsync</summary>
        public async Task DeleteCustomClassResourceNamesAsync()
        {
            // Snippet: DeleteCustomClassAsync(CustomClassName, CallSettings)
            // Additional: DeleteCustomClassAsync(CustomClassName, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            CustomClassName name = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]");
            // Make the request
            Operation<CustomClass, OperationMetadata> response = await speechClient.DeleteCustomClassAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = await speechClient.PollOnceDeleteCustomClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteCustomClass</summary>
        public void UndeleteCustomClassRequestObject()
        {
            // Snippet: UndeleteCustomClass(UndeleteCustomClassRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            UndeleteCustomClassRequest request = new UndeleteCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<CustomClass, OperationMetadata> response = speechClient.UndeleteCustomClass(request);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = speechClient.PollOnceUndeleteCustomClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteCustomClassAsync</summary>
        public async Task UndeleteCustomClassRequestObjectAsync()
        {
            // Snippet: UndeleteCustomClassAsync(UndeleteCustomClassRequest, CallSettings)
            // Additional: UndeleteCustomClassAsync(UndeleteCustomClassRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteCustomClassRequest request = new UndeleteCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<CustomClass, OperationMetadata> response = await speechClient.UndeleteCustomClassAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = await speechClient.PollOnceUndeleteCustomClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteCustomClass</summary>
        public void UndeleteCustomClass()
        {
            // Snippet: UndeleteCustomClass(string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customClasses/[CUSTOM_CLASS]";
            // Make the request
            Operation<CustomClass, OperationMetadata> response = speechClient.UndeleteCustomClass(name);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = speechClient.PollOnceUndeleteCustomClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteCustomClassAsync</summary>
        public async Task UndeleteCustomClassAsync()
        {
            // Snippet: UndeleteCustomClassAsync(string, CallSettings)
            // Additional: UndeleteCustomClassAsync(string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customClasses/[CUSTOM_CLASS]";
            // Make the request
            Operation<CustomClass, OperationMetadata> response = await speechClient.UndeleteCustomClassAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = await speechClient.PollOnceUndeleteCustomClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteCustomClass</summary>
        public void UndeleteCustomClassResourceNames()
        {
            // Snippet: UndeleteCustomClass(CustomClassName, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            CustomClassName name = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]");
            // Make the request
            Operation<CustomClass, OperationMetadata> response = speechClient.UndeleteCustomClass(name);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = speechClient.PollOnceUndeleteCustomClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteCustomClassAsync</summary>
        public async Task UndeleteCustomClassResourceNamesAsync()
        {
            // Snippet: UndeleteCustomClassAsync(CustomClassName, CallSettings)
            // Additional: UndeleteCustomClassAsync(CustomClassName, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            CustomClassName name = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]");
            // Make the request
            Operation<CustomClass, OperationMetadata> response = await speechClient.UndeleteCustomClassAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CustomClass, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomClass, OperationMetadata> retrievedResponse = await speechClient.PollOnceUndeleteCustomClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseSet</summary>
        public void CreatePhraseSetRequestObject()
        {
            // Snippet: CreatePhraseSet(CreatePhraseSetRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            CreatePhraseSetRequest request = new CreatePhraseSetRequest
            {
                PhraseSet = new PhraseSet(),
                ValidateOnly = false,
                PhraseSetId = "",
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = speechClient.CreatePhraseSet(request);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = speechClient.PollOnceCreatePhraseSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseSetAsync</summary>
        public async Task CreatePhraseSetRequestObjectAsync()
        {
            // Snippet: CreatePhraseSetAsync(CreatePhraseSetRequest, CallSettings)
            // Additional: CreatePhraseSetAsync(CreatePhraseSetRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            CreatePhraseSetRequest request = new CreatePhraseSetRequest
            {
                PhraseSet = new PhraseSet(),
                ValidateOnly = false,
                PhraseSetId = "",
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = await speechClient.CreatePhraseSetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = await speechClient.PollOnceCreatePhraseSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseSet</summary>
        public void CreatePhraseSet()
        {
            // Snippet: CreatePhraseSet(string, PhraseSet, string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PhraseSet phraseSet = new PhraseSet();
            string phraseSetId = "";
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = speechClient.CreatePhraseSet(parent, phraseSet, phraseSetId);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = speechClient.PollOnceCreatePhraseSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseSetAsync</summary>
        public async Task CreatePhraseSetAsync()
        {
            // Snippet: CreatePhraseSetAsync(string, PhraseSet, string, CallSettings)
            // Additional: CreatePhraseSetAsync(string, PhraseSet, string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PhraseSet phraseSet = new PhraseSet();
            string phraseSetId = "";
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = await speechClient.CreatePhraseSetAsync(parent, phraseSet, phraseSetId);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = await speechClient.PollOnceCreatePhraseSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseSet</summary>
        public void CreatePhraseSetResourceNames()
        {
            // Snippet: CreatePhraseSet(LocationName, PhraseSet, string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PhraseSet phraseSet = new PhraseSet();
            string phraseSetId = "";
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = speechClient.CreatePhraseSet(parent, phraseSet, phraseSetId);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = speechClient.PollOnceCreatePhraseSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseSetAsync</summary>
        public async Task CreatePhraseSetResourceNamesAsync()
        {
            // Snippet: CreatePhraseSetAsync(LocationName, PhraseSet, string, CallSettings)
            // Additional: CreatePhraseSetAsync(LocationName, PhraseSet, string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PhraseSet phraseSet = new PhraseSet();
            string phraseSetId = "";
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = await speechClient.CreatePhraseSetAsync(parent, phraseSet, phraseSetId);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = await speechClient.PollOnceCreatePhraseSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListPhraseSets</summary>
        public void ListPhraseSetsRequestObject()
        {
            // Snippet: ListPhraseSets(ListPhraseSetsRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            ListPhraseSetsRequest request = new ListPhraseSetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListPhraseSetsResponse, PhraseSet> response = speechClient.ListPhraseSets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhraseSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhraseSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhraseSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhraseSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhraseSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhraseSetsAsync</summary>
        public async Task ListPhraseSetsRequestObjectAsync()
        {
            // Snippet: ListPhraseSetsAsync(ListPhraseSetsRequest, CallSettings)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            ListPhraseSetsRequest request = new ListPhraseSetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListPhraseSetsResponse, PhraseSet> response = speechClient.ListPhraseSetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhraseSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhraseSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhraseSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhraseSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhraseSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhraseSets</summary>
        public void ListPhraseSets()
        {
            // Snippet: ListPhraseSets(string, string, int?, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPhraseSetsResponse, PhraseSet> response = speechClient.ListPhraseSets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhraseSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhraseSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhraseSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhraseSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhraseSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhraseSetsAsync</summary>
        public async Task ListPhraseSetsAsync()
        {
            // Snippet: ListPhraseSetsAsync(string, string, int?, CallSettings)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPhraseSetsResponse, PhraseSet> response = speechClient.ListPhraseSetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhraseSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhraseSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhraseSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhraseSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhraseSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhraseSets</summary>
        public void ListPhraseSetsResourceNames()
        {
            // Snippet: ListPhraseSets(LocationName, string, int?, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPhraseSetsResponse, PhraseSet> response = speechClient.ListPhraseSets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhraseSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhraseSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhraseSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhraseSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhraseSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhraseSetsAsync</summary>
        public async Task ListPhraseSetsResourceNamesAsync()
        {
            // Snippet: ListPhraseSetsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPhraseSetsResponse, PhraseSet> response = speechClient.ListPhraseSetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhraseSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhraseSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhraseSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhraseSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhraseSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPhraseSet</summary>
        public void GetPhraseSetRequestObject()
        {
            // Snippet: GetPhraseSet(GetPhraseSetRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            // Make the request
            PhraseSet response = speechClient.GetPhraseSet(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseSetAsync</summary>
        public async Task GetPhraseSetRequestObjectAsync()
        {
            // Snippet: GetPhraseSetAsync(GetPhraseSetRequest, CallSettings)
            // Additional: GetPhraseSetAsync(GetPhraseSetRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            // Make the request
            PhraseSet response = await speechClient.GetPhraseSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseSet</summary>
        public void GetPhraseSet()
        {
            // Snippet: GetPhraseSet(string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/phraseSets/[PHRASE_SET]";
            // Make the request
            PhraseSet response = speechClient.GetPhraseSet(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseSetAsync</summary>
        public async Task GetPhraseSetAsync()
        {
            // Snippet: GetPhraseSetAsync(string, CallSettings)
            // Additional: GetPhraseSetAsync(string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/phraseSets/[PHRASE_SET]";
            // Make the request
            PhraseSet response = await speechClient.GetPhraseSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseSet</summary>
        public void GetPhraseSetResourceNames()
        {
            // Snippet: GetPhraseSet(PhraseSetName, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            PhraseSetName name = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]");
            // Make the request
            PhraseSet response = speechClient.GetPhraseSet(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseSetAsync</summary>
        public async Task GetPhraseSetResourceNamesAsync()
        {
            // Snippet: GetPhraseSetAsync(PhraseSetName, CallSettings)
            // Additional: GetPhraseSetAsync(PhraseSetName, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            PhraseSetName name = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]");
            // Make the request
            PhraseSet response = await speechClient.GetPhraseSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhraseSet</summary>
        public void UpdatePhraseSetRequestObject()
        {
            // Snippet: UpdatePhraseSet(UpdatePhraseSetRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            UpdatePhraseSetRequest request = new UpdatePhraseSetRequest
            {
                PhraseSet = new PhraseSet(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = speechClient.UpdatePhraseSet(request);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = speechClient.PollOnceUpdatePhraseSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePhraseSetAsync</summary>
        public async Task UpdatePhraseSetRequestObjectAsync()
        {
            // Snippet: UpdatePhraseSetAsync(UpdatePhraseSetRequest, CallSettings)
            // Additional: UpdatePhraseSetAsync(UpdatePhraseSetRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePhraseSetRequest request = new UpdatePhraseSetRequest
            {
                PhraseSet = new PhraseSet(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = await speechClient.UpdatePhraseSetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = await speechClient.PollOnceUpdatePhraseSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePhraseSet</summary>
        public void UpdatePhraseSet()
        {
            // Snippet: UpdatePhraseSet(PhraseSet, FieldMask, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            PhraseSet phraseSet = new PhraseSet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = speechClient.UpdatePhraseSet(phraseSet, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = speechClient.PollOnceUpdatePhraseSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePhraseSetAsync</summary>
        public async Task UpdatePhraseSetAsync()
        {
            // Snippet: UpdatePhraseSetAsync(PhraseSet, FieldMask, CallSettings)
            // Additional: UpdatePhraseSetAsync(PhraseSet, FieldMask, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            PhraseSet phraseSet = new PhraseSet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = await speechClient.UpdatePhraseSetAsync(phraseSet, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = await speechClient.PollOnceUpdatePhraseSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseSet</summary>
        public void DeletePhraseSetRequestObject()
        {
            // Snippet: DeletePhraseSet(DeletePhraseSetRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            DeletePhraseSetRequest request = new DeletePhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                ValidateOnly = false,
                Etag = "",
                AllowMissing = false,
            };
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = speechClient.DeletePhraseSet(request);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = speechClient.PollOnceDeletePhraseSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseSetAsync</summary>
        public async Task DeletePhraseSetRequestObjectAsync()
        {
            // Snippet: DeletePhraseSetAsync(DeletePhraseSetRequest, CallSettings)
            // Additional: DeletePhraseSetAsync(DeletePhraseSetRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            DeletePhraseSetRequest request = new DeletePhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                ValidateOnly = false,
                Etag = "",
                AllowMissing = false,
            };
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = await speechClient.DeletePhraseSetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = await speechClient.PollOnceDeletePhraseSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseSet</summary>
        public void DeletePhraseSet()
        {
            // Snippet: DeletePhraseSet(string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/phraseSets/[PHRASE_SET]";
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = speechClient.DeletePhraseSet(name);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = speechClient.PollOnceDeletePhraseSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseSetAsync</summary>
        public async Task DeletePhraseSetAsync()
        {
            // Snippet: DeletePhraseSetAsync(string, CallSettings)
            // Additional: DeletePhraseSetAsync(string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/phraseSets/[PHRASE_SET]";
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = await speechClient.DeletePhraseSetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = await speechClient.PollOnceDeletePhraseSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseSet</summary>
        public void DeletePhraseSetResourceNames()
        {
            // Snippet: DeletePhraseSet(PhraseSetName, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            PhraseSetName name = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]");
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = speechClient.DeletePhraseSet(name);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = speechClient.PollOnceDeletePhraseSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseSetAsync</summary>
        public async Task DeletePhraseSetResourceNamesAsync()
        {
            // Snippet: DeletePhraseSetAsync(PhraseSetName, CallSettings)
            // Additional: DeletePhraseSetAsync(PhraseSetName, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            PhraseSetName name = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]");
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = await speechClient.DeletePhraseSetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = await speechClient.PollOnceDeletePhraseSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeletePhraseSet</summary>
        public void UndeletePhraseSetRequestObject()
        {
            // Snippet: UndeletePhraseSet(UndeletePhraseSetRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            UndeletePhraseSetRequest request = new UndeletePhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = speechClient.UndeletePhraseSet(request);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = speechClient.PollOnceUndeletePhraseSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeletePhraseSetAsync</summary>
        public async Task UndeletePhraseSetRequestObjectAsync()
        {
            // Snippet: UndeletePhraseSetAsync(UndeletePhraseSetRequest, CallSettings)
            // Additional: UndeletePhraseSetAsync(UndeletePhraseSetRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            UndeletePhraseSetRequest request = new UndeletePhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = await speechClient.UndeletePhraseSetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = await speechClient.PollOnceUndeletePhraseSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeletePhraseSet</summary>
        public void UndeletePhraseSet()
        {
            // Snippet: UndeletePhraseSet(string, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/phraseSets/[PHRASE_SET]";
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = speechClient.UndeletePhraseSet(name);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = speechClient.PollOnceUndeletePhraseSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeletePhraseSetAsync</summary>
        public async Task UndeletePhraseSetAsync()
        {
            // Snippet: UndeletePhraseSetAsync(string, CallSettings)
            // Additional: UndeletePhraseSetAsync(string, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/phraseSets/[PHRASE_SET]";
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = await speechClient.UndeletePhraseSetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = await speechClient.PollOnceUndeletePhraseSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeletePhraseSet</summary>
        public void UndeletePhraseSetResourceNames()
        {
            // Snippet: UndeletePhraseSet(PhraseSetName, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            PhraseSetName name = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]");
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = speechClient.UndeletePhraseSet(name);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = speechClient.PollOnceUndeletePhraseSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeletePhraseSetAsync</summary>
        public async Task UndeletePhraseSetResourceNamesAsync()
        {
            // Snippet: UndeletePhraseSetAsync(PhraseSetName, CallSettings)
            // Additional: UndeletePhraseSetAsync(PhraseSetName, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            PhraseSetName name = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]");
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = await speechClient.UndeletePhraseSetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = await speechClient.PollOnceUndeletePhraseSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
