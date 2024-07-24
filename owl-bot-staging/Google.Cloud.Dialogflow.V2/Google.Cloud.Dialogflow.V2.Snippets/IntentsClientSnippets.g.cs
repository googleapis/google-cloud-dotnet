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
    using Google.Cloud.Dialogflow.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedIntentsClientSnippets
    {
        /// <summary>Snippet for ListIntents</summary>
        public void ListIntentsRequestObject()
        {
            // Snippet: ListIntents(ListIntentsRequest, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            ListIntentsRequest request = new ListIntentsRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                LanguageCode = "",
                IntentView = IntentView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListIntentsResponse, Intent> response = intentsClient.ListIntents(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIntentsAsync</summary>
        public async Task ListIntentsRequestObjectAsync()
        {
            // Snippet: ListIntentsAsync(ListIntentsRequest, CallSettings)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            ListIntentsRequest request = new ListIntentsRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                LanguageCode = "",
                IntentView = IntentView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListIntentsResponse, Intent> response = intentsClient.ListIntentsAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIntents</summary>
        public void ListIntents1()
        {
            // Snippet: ListIntents(string, string, int?, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            // Make the request
            PagedEnumerable<ListIntentsResponse, Intent> response = intentsClient.ListIntents(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIntentsAsync</summary>
        public async Task ListIntents1Async()
        {
            // Snippet: ListIntentsAsync(string, string, int?, CallSettings)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            // Make the request
            PagedAsyncEnumerable<ListIntentsResponse, Intent> response = intentsClient.ListIntentsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIntents</summary>
        public void ListIntents1ResourceNames()
        {
            // Snippet: ListIntents(AgentName, string, int?, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListIntentsResponse, Intent> response = intentsClient.ListIntents(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIntentsAsync</summary>
        public async Task ListIntents1ResourceNamesAsync()
        {
            // Snippet: ListIntentsAsync(AgentName, string, int?, CallSettings)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListIntentsResponse, Intent> response = intentsClient.ListIntentsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIntents</summary>
        public void ListIntents2()
        {
            // Snippet: ListIntents(string, string, string, int?, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            string languageCode = "";
            // Make the request
            PagedEnumerable<ListIntentsResponse, Intent> response = intentsClient.ListIntents(parent, languageCode: languageCode);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIntentsAsync</summary>
        public async Task ListIntents2Async()
        {
            // Snippet: ListIntentsAsync(string, string, string, int?, CallSettings)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            string languageCode = "";
            // Make the request
            PagedAsyncEnumerable<ListIntentsResponse, Intent> response = intentsClient.ListIntentsAsync(parent, languageCode: languageCode);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIntents</summary>
        public void ListIntents2ResourceNames()
        {
            // Snippet: ListIntents(AgentName, string, string, int?, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            string languageCode = "";
            // Make the request
            PagedEnumerable<ListIntentsResponse, Intent> response = intentsClient.ListIntents(parent, languageCode: languageCode);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIntentsAsync</summary>
        public async Task ListIntents2ResourceNamesAsync()
        {
            // Snippet: ListIntentsAsync(AgentName, string, string, int?, CallSettings)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            string languageCode = "";
            // Make the request
            PagedAsyncEnumerable<ListIntentsResponse, Intent> response = intentsClient.ListIntentsAsync(parent, languageCode: languageCode);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetIntent</summary>
        public void GetIntentRequestObject()
        {
            // Snippet: GetIntent(GetIntentRequest, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                LanguageCode = "",
                IntentView = IntentView.Unspecified,
            };
            // Make the request
            Intent response = intentsClient.GetIntent(request);
            // End snippet
        }

        /// <summary>Snippet for GetIntentAsync</summary>
        public async Task GetIntentRequestObjectAsync()
        {
            // Snippet: GetIntentAsync(GetIntentRequest, CallSettings)
            // Additional: GetIntentAsync(GetIntentRequest, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                LanguageCode = "",
                IntentView = IntentView.Unspecified,
            };
            // Make the request
            Intent response = await intentsClient.GetIntentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIntent</summary>
        public void GetIntent1()
        {
            // Snippet: GetIntent(string, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/intents/[INTENT]";
            // Make the request
            Intent response = intentsClient.GetIntent(name);
            // End snippet
        }

        /// <summary>Snippet for GetIntentAsync</summary>
        public async Task GetIntent1Async()
        {
            // Snippet: GetIntentAsync(string, CallSettings)
            // Additional: GetIntentAsync(string, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/intents/[INTENT]";
            // Make the request
            Intent response = await intentsClient.GetIntentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIntent</summary>
        public void GetIntent1ResourceNames()
        {
            // Snippet: GetIntent(IntentName, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            IntentName name = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]");
            // Make the request
            Intent response = intentsClient.GetIntent(name);
            // End snippet
        }

        /// <summary>Snippet for GetIntentAsync</summary>
        public async Task GetIntent1ResourceNamesAsync()
        {
            // Snippet: GetIntentAsync(IntentName, CallSettings)
            // Additional: GetIntentAsync(IntentName, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            IntentName name = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]");
            // Make the request
            Intent response = await intentsClient.GetIntentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIntent</summary>
        public void GetIntent2()
        {
            // Snippet: GetIntent(string, string, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/intents/[INTENT]";
            string languageCode = "";
            // Make the request
            Intent response = intentsClient.GetIntent(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for GetIntentAsync</summary>
        public async Task GetIntent2Async()
        {
            // Snippet: GetIntentAsync(string, string, CallSettings)
            // Additional: GetIntentAsync(string, string, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/intents/[INTENT]";
            string languageCode = "";
            // Make the request
            Intent response = await intentsClient.GetIntentAsync(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for GetIntent</summary>
        public void GetIntent2ResourceNames()
        {
            // Snippet: GetIntent(IntentName, string, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            IntentName name = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]");
            string languageCode = "";
            // Make the request
            Intent response = intentsClient.GetIntent(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for GetIntentAsync</summary>
        public async Task GetIntent2ResourceNamesAsync()
        {
            // Snippet: GetIntentAsync(IntentName, string, CallSettings)
            // Additional: GetIntentAsync(IntentName, string, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            IntentName name = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]");
            string languageCode = "";
            // Make the request
            Intent response = await intentsClient.GetIntentAsync(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for CreateIntent</summary>
        public void CreateIntentRequestObject()
        {
            // Snippet: CreateIntent(CreateIntentRequest, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Intent = new Intent(),
                LanguageCode = "",
                IntentView = IntentView.Unspecified,
            };
            // Make the request
            Intent response = intentsClient.CreateIntent(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIntentAsync</summary>
        public async Task CreateIntentRequestObjectAsync()
        {
            // Snippet: CreateIntentAsync(CreateIntentRequest, CallSettings)
            // Additional: CreateIntentAsync(CreateIntentRequest, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Intent = new Intent(),
                LanguageCode = "",
                IntentView = IntentView.Unspecified,
            };
            // Make the request
            Intent response = await intentsClient.CreateIntentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIntent</summary>
        public void CreateIntent1()
        {
            // Snippet: CreateIntent(string, Intent, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            Intent intent = new Intent();
            // Make the request
            Intent response = intentsClient.CreateIntent(parent, intent);
            // End snippet
        }

        /// <summary>Snippet for CreateIntentAsync</summary>
        public async Task CreateIntent1Async()
        {
            // Snippet: CreateIntentAsync(string, Intent, CallSettings)
            // Additional: CreateIntentAsync(string, Intent, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            Intent intent = new Intent();
            // Make the request
            Intent response = await intentsClient.CreateIntentAsync(parent, intent);
            // End snippet
        }

        /// <summary>Snippet for CreateIntent</summary>
        public void CreateIntent1ResourceNames()
        {
            // Snippet: CreateIntent(AgentName, Intent, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            Intent intent = new Intent();
            // Make the request
            Intent response = intentsClient.CreateIntent(parent, intent);
            // End snippet
        }

        /// <summary>Snippet for CreateIntentAsync</summary>
        public async Task CreateIntent1ResourceNamesAsync()
        {
            // Snippet: CreateIntentAsync(AgentName, Intent, CallSettings)
            // Additional: CreateIntentAsync(AgentName, Intent, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            Intent intent = new Intent();
            // Make the request
            Intent response = await intentsClient.CreateIntentAsync(parent, intent);
            // End snippet
        }

        /// <summary>Snippet for CreateIntent</summary>
        public void CreateIntent2()
        {
            // Snippet: CreateIntent(string, Intent, string, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            Intent intent = new Intent();
            string languageCode = "";
            // Make the request
            Intent response = intentsClient.CreateIntent(parent, intent, languageCode);
            // End snippet
        }

        /// <summary>Snippet for CreateIntentAsync</summary>
        public async Task CreateIntent2Async()
        {
            // Snippet: CreateIntentAsync(string, Intent, string, CallSettings)
            // Additional: CreateIntentAsync(string, Intent, string, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            Intent intent = new Intent();
            string languageCode = "";
            // Make the request
            Intent response = await intentsClient.CreateIntentAsync(parent, intent, languageCode);
            // End snippet
        }

        /// <summary>Snippet for CreateIntent</summary>
        public void CreateIntent2ResourceNames()
        {
            // Snippet: CreateIntent(AgentName, Intent, string, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            Intent intent = new Intent();
            string languageCode = "";
            // Make the request
            Intent response = intentsClient.CreateIntent(parent, intent, languageCode);
            // End snippet
        }

        /// <summary>Snippet for CreateIntentAsync</summary>
        public async Task CreateIntent2ResourceNamesAsync()
        {
            // Snippet: CreateIntentAsync(AgentName, Intent, string, CallSettings)
            // Additional: CreateIntentAsync(AgentName, Intent, string, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            Intent intent = new Intent();
            string languageCode = "";
            // Make the request
            Intent response = await intentsClient.CreateIntentAsync(parent, intent, languageCode);
            // End snippet
        }

        /// <summary>Snippet for UpdateIntent</summary>
        public void UpdateIntentRequestObject()
        {
            // Snippet: UpdateIntent(UpdateIntentRequest, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "",
                UpdateMask = new FieldMask(),
                IntentView = IntentView.Unspecified,
            };
            // Make the request
            Intent response = intentsClient.UpdateIntent(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIntentAsync</summary>
        public async Task UpdateIntentRequestObjectAsync()
        {
            // Snippet: UpdateIntentAsync(UpdateIntentRequest, CallSettings)
            // Additional: UpdateIntentAsync(UpdateIntentRequest, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "",
                UpdateMask = new FieldMask(),
                IntentView = IntentView.Unspecified,
            };
            // Make the request
            Intent response = await intentsClient.UpdateIntentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIntent</summary>
        public void UpdateIntent1()
        {
            // Snippet: UpdateIntent(Intent, string, CallSettings)
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
        public async Task UpdateIntent1Async()
        {
            // Snippet: UpdateIntentAsync(Intent, string, CallSettings)
            // Additional: UpdateIntentAsync(Intent, string, CancellationToken)
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
        public void UpdateIntent2()
        {
            // Snippet: UpdateIntent(Intent, string, FieldMask, CallSettings)
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
        public async Task UpdateIntent2Async()
        {
            // Snippet: UpdateIntentAsync(Intent, string, FieldMask, CallSettings)
            // Additional: UpdateIntentAsync(Intent, string, FieldMask, CancellationToken)
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

        /// <summary>Snippet for DeleteIntent</summary>
        public void DeleteIntentRequestObject()
        {
            // Snippet: DeleteIntent(DeleteIntentRequest, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
            };
            // Make the request
            intentsClient.DeleteIntent(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIntentAsync</summary>
        public async Task DeleteIntentRequestObjectAsync()
        {
            // Snippet: DeleteIntentAsync(DeleteIntentRequest, CallSettings)
            // Additional: DeleteIntentAsync(DeleteIntentRequest, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
            };
            // Make the request
            await intentsClient.DeleteIntentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIntent</summary>
        public void DeleteIntent()
        {
            // Snippet: DeleteIntent(string, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/intents/[INTENT]";
            // Make the request
            intentsClient.DeleteIntent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIntentAsync</summary>
        public async Task DeleteIntentAsync()
        {
            // Snippet: DeleteIntentAsync(string, CallSettings)
            // Additional: DeleteIntentAsync(string, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/intents/[INTENT]";
            // Make the request
            await intentsClient.DeleteIntentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIntent</summary>
        public void DeleteIntentResourceNames()
        {
            // Snippet: DeleteIntent(IntentName, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            IntentName name = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]");
            // Make the request
            intentsClient.DeleteIntent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIntentAsync</summary>
        public async Task DeleteIntentResourceNamesAsync()
        {
            // Snippet: DeleteIntentAsync(IntentName, CallSettings)
            // Additional: DeleteIntentAsync(IntentName, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            IntentName name = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]");
            // Make the request
            await intentsClient.DeleteIntentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateIntents</summary>
        public void BatchUpdateIntentsRequestObject()
        {
            // Snippet: BatchUpdateIntents(BatchUpdateIntentsRequest, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            BatchUpdateIntentsRequest request = new BatchUpdateIntentsRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                IntentBatchUri = "",
                LanguageCode = "",
                UpdateMask = new FieldMask(),
                IntentView = IntentView.Unspecified,
            };
            // Make the request
            Operation<BatchUpdateIntentsResponse, Struct> response = intentsClient.BatchUpdateIntents(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateIntentsResponse, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchUpdateIntentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateIntentsResponse, Struct> retrievedResponse = intentsClient.PollOnceBatchUpdateIntents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateIntentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateIntentsAsync</summary>
        public async Task BatchUpdateIntentsRequestObjectAsync()
        {
            // Snippet: BatchUpdateIntentsAsync(BatchUpdateIntentsRequest, CallSettings)
            // Additional: BatchUpdateIntentsAsync(BatchUpdateIntentsRequest, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateIntentsRequest request = new BatchUpdateIntentsRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                IntentBatchUri = "",
                LanguageCode = "",
                UpdateMask = new FieldMask(),
                IntentView = IntentView.Unspecified,
            };
            // Make the request
            Operation<BatchUpdateIntentsResponse, Struct> response = await intentsClient.BatchUpdateIntentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateIntentsResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchUpdateIntentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateIntentsResponse, Struct> retrievedResponse = await intentsClient.PollOnceBatchUpdateIntentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateIntentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateIntents</summary>
        public void BatchUpdateIntents1()
        {
            // Snippet: BatchUpdateIntents(string, string, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            string intentBatchUri = "";
            // Make the request
            Operation<BatchUpdateIntentsResponse, Struct> response = intentsClient.BatchUpdateIntents(parent, intentBatchUri);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateIntentsResponse, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchUpdateIntentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateIntentsResponse, Struct> retrievedResponse = intentsClient.PollOnceBatchUpdateIntents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateIntentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateIntentsAsync</summary>
        public async Task BatchUpdateIntents1Async()
        {
            // Snippet: BatchUpdateIntentsAsync(string, string, CallSettings)
            // Additional: BatchUpdateIntentsAsync(string, string, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            string intentBatchUri = "";
            // Make the request
            Operation<BatchUpdateIntentsResponse, Struct> response = await intentsClient.BatchUpdateIntentsAsync(parent, intentBatchUri);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateIntentsResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchUpdateIntentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateIntentsResponse, Struct> retrievedResponse = await intentsClient.PollOnceBatchUpdateIntentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateIntentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateIntents</summary>
        public void BatchUpdateIntents1ResourceNames()
        {
            // Snippet: BatchUpdateIntents(AgentName, string, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            string intentBatchUri = "";
            // Make the request
            Operation<BatchUpdateIntentsResponse, Struct> response = intentsClient.BatchUpdateIntents(parent, intentBatchUri);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateIntentsResponse, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchUpdateIntentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateIntentsResponse, Struct> retrievedResponse = intentsClient.PollOnceBatchUpdateIntents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateIntentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateIntentsAsync</summary>
        public async Task BatchUpdateIntents1ResourceNamesAsync()
        {
            // Snippet: BatchUpdateIntentsAsync(AgentName, string, CallSettings)
            // Additional: BatchUpdateIntentsAsync(AgentName, string, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            string intentBatchUri = "";
            // Make the request
            Operation<BatchUpdateIntentsResponse, Struct> response = await intentsClient.BatchUpdateIntentsAsync(parent, intentBatchUri);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateIntentsResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchUpdateIntentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateIntentsResponse, Struct> retrievedResponse = await intentsClient.PollOnceBatchUpdateIntentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateIntentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateIntents</summary>
        public void BatchUpdateIntents2()
        {
            // Snippet: BatchUpdateIntents(string, IntentBatch, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            IntentBatch intentBatchInline = new IntentBatch();
            // Make the request
            Operation<BatchUpdateIntentsResponse, Struct> response = intentsClient.BatchUpdateIntents(parent, intentBatchInline);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateIntentsResponse, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchUpdateIntentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateIntentsResponse, Struct> retrievedResponse = intentsClient.PollOnceBatchUpdateIntents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateIntentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateIntentsAsync</summary>
        public async Task BatchUpdateIntents2Async()
        {
            // Snippet: BatchUpdateIntentsAsync(string, IntentBatch, CallSettings)
            // Additional: BatchUpdateIntentsAsync(string, IntentBatch, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            IntentBatch intentBatchInline = new IntentBatch();
            // Make the request
            Operation<BatchUpdateIntentsResponse, Struct> response = await intentsClient.BatchUpdateIntentsAsync(parent, intentBatchInline);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateIntentsResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchUpdateIntentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateIntentsResponse, Struct> retrievedResponse = await intentsClient.PollOnceBatchUpdateIntentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateIntentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateIntents</summary>
        public void BatchUpdateIntents2ResourceNames()
        {
            // Snippet: BatchUpdateIntents(AgentName, IntentBatch, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            IntentBatch intentBatchInline = new IntentBatch();
            // Make the request
            Operation<BatchUpdateIntentsResponse, Struct> response = intentsClient.BatchUpdateIntents(parent, intentBatchInline);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateIntentsResponse, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchUpdateIntentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateIntentsResponse, Struct> retrievedResponse = intentsClient.PollOnceBatchUpdateIntents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateIntentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateIntentsAsync</summary>
        public async Task BatchUpdateIntents2ResourceNamesAsync()
        {
            // Snippet: BatchUpdateIntentsAsync(AgentName, IntentBatch, CallSettings)
            // Additional: BatchUpdateIntentsAsync(AgentName, IntentBatch, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            IntentBatch intentBatchInline = new IntentBatch();
            // Make the request
            Operation<BatchUpdateIntentsResponse, Struct> response = await intentsClient.BatchUpdateIntentsAsync(parent, intentBatchInline);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateIntentsResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchUpdateIntentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateIntentsResponse, Struct> retrievedResponse = await intentsClient.PollOnceBatchUpdateIntentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateIntentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteIntents</summary>
        public void BatchDeleteIntentsRequestObject()
        {
            // Snippet: BatchDeleteIntents(BatchDeleteIntentsRequest, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            BatchDeleteIntentsRequest request = new BatchDeleteIntentsRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Intents = { new Intent(), },
            };
            // Make the request
            Operation<Empty, Struct> response = intentsClient.BatchDeleteIntents(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = intentsClient.PollOnceBatchDeleteIntents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteIntentsAsync</summary>
        public async Task BatchDeleteIntentsRequestObjectAsync()
        {
            // Snippet: BatchDeleteIntentsAsync(BatchDeleteIntentsRequest, CallSettings)
            // Additional: BatchDeleteIntentsAsync(BatchDeleteIntentsRequest, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteIntentsRequest request = new BatchDeleteIntentsRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Intents = { new Intent(), },
            };
            // Make the request
            Operation<Empty, Struct> response = await intentsClient.BatchDeleteIntentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await intentsClient.PollOnceBatchDeleteIntentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteIntents</summary>
        public void BatchDeleteIntents()
        {
            // Snippet: BatchDeleteIntents(string, IEnumerable<Intent>, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            IEnumerable<Intent> intents = new Intent[] { new Intent(), };
            // Make the request
            Operation<Empty, Struct> response = intentsClient.BatchDeleteIntents(parent, intents);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = intentsClient.PollOnceBatchDeleteIntents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteIntentsAsync</summary>
        public async Task BatchDeleteIntentsAsync()
        {
            // Snippet: BatchDeleteIntentsAsync(string, IEnumerable<Intent>, CallSettings)
            // Additional: BatchDeleteIntentsAsync(string, IEnumerable<Intent>, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            IEnumerable<Intent> intents = new Intent[] { new Intent(), };
            // Make the request
            Operation<Empty, Struct> response = await intentsClient.BatchDeleteIntentsAsync(parent, intents);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await intentsClient.PollOnceBatchDeleteIntentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteIntents</summary>
        public void BatchDeleteIntentsResourceNames()
        {
            // Snippet: BatchDeleteIntents(AgentName, IEnumerable<Intent>, CallSettings)
            // Create client
            IntentsClient intentsClient = IntentsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            IEnumerable<Intent> intents = new Intent[] { new Intent(), };
            // Make the request
            Operation<Empty, Struct> response = intentsClient.BatchDeleteIntents(parent, intents);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = intentsClient.PollOnceBatchDeleteIntents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteIntentsAsync</summary>
        public async Task BatchDeleteIntentsResourceNamesAsync()
        {
            // Snippet: BatchDeleteIntentsAsync(AgentName, IEnumerable<Intent>, CallSettings)
            // Additional: BatchDeleteIntentsAsync(AgentName, IEnumerable<Intent>, CancellationToken)
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            IEnumerable<Intent> intents = new Intent[] { new Intent(), };
            // Make the request
            Operation<Empty, Struct> response = await intentsClient.BatchDeleteIntentsAsync(parent, intents);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await intentsClient.PollOnceBatchDeleteIntentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
