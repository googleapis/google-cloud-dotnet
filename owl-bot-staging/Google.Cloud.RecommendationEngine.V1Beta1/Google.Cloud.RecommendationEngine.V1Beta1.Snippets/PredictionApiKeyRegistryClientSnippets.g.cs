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
    using Google.Cloud.RecommendationEngine.V1Beta1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPredictionApiKeyRegistryClientSnippets
    {
        /// <summary>Snippet for CreatePredictionApiKeyRegistration</summary>
        public void CreatePredictionApiKeyRegistrationRequestObject()
        {
            // Snippet: CreatePredictionApiKeyRegistration(CreatePredictionApiKeyRegistrationRequest, CallSettings)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = PredictionApiKeyRegistryClient.Create();
            // Initialize request argument(s)
            CreatePredictionApiKeyRegistrationRequest request = new CreatePredictionApiKeyRegistrationRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                PredictionApiKeyRegistration = new PredictionApiKeyRegistration(),
            };
            // Make the request
            PredictionApiKeyRegistration response = predictionApiKeyRegistryClient.CreatePredictionApiKeyRegistration(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePredictionApiKeyRegistrationAsync</summary>
        public async Task CreatePredictionApiKeyRegistrationRequestObjectAsync()
        {
            // Snippet: CreatePredictionApiKeyRegistrationAsync(CreatePredictionApiKeyRegistrationRequest, CallSettings)
            // Additional: CreatePredictionApiKeyRegistrationAsync(CreatePredictionApiKeyRegistrationRequest, CancellationToken)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = await PredictionApiKeyRegistryClient.CreateAsync();
            // Initialize request argument(s)
            CreatePredictionApiKeyRegistrationRequest request = new CreatePredictionApiKeyRegistrationRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                PredictionApiKeyRegistration = new PredictionApiKeyRegistration(),
            };
            // Make the request
            PredictionApiKeyRegistration response = await predictionApiKeyRegistryClient.CreatePredictionApiKeyRegistrationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePredictionApiKeyRegistration</summary>
        public void CreatePredictionApiKeyRegistration()
        {
            // Snippet: CreatePredictionApiKeyRegistration(string, PredictionApiKeyRegistration, CallSettings)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = PredictionApiKeyRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            PredictionApiKeyRegistration predictionApiKeyRegistration = new PredictionApiKeyRegistration();
            // Make the request
            PredictionApiKeyRegistration response = predictionApiKeyRegistryClient.CreatePredictionApiKeyRegistration(parent, predictionApiKeyRegistration);
            // End snippet
        }

        /// <summary>Snippet for CreatePredictionApiKeyRegistrationAsync</summary>
        public async Task CreatePredictionApiKeyRegistrationAsync()
        {
            // Snippet: CreatePredictionApiKeyRegistrationAsync(string, PredictionApiKeyRegistration, CallSettings)
            // Additional: CreatePredictionApiKeyRegistrationAsync(string, PredictionApiKeyRegistration, CancellationToken)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = await PredictionApiKeyRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            PredictionApiKeyRegistration predictionApiKeyRegistration = new PredictionApiKeyRegistration();
            // Make the request
            PredictionApiKeyRegistration response = await predictionApiKeyRegistryClient.CreatePredictionApiKeyRegistrationAsync(parent, predictionApiKeyRegistration);
            // End snippet
        }

        /// <summary>Snippet for CreatePredictionApiKeyRegistration</summary>
        public void CreatePredictionApiKeyRegistrationResourceNames()
        {
            // Snippet: CreatePredictionApiKeyRegistration(EventStoreName, PredictionApiKeyRegistration, CallSettings)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = PredictionApiKeyRegistryClient.Create();
            // Initialize request argument(s)
            EventStoreName parent = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]");
            PredictionApiKeyRegistration predictionApiKeyRegistration = new PredictionApiKeyRegistration();
            // Make the request
            PredictionApiKeyRegistration response = predictionApiKeyRegistryClient.CreatePredictionApiKeyRegistration(parent, predictionApiKeyRegistration);
            // End snippet
        }

        /// <summary>Snippet for CreatePredictionApiKeyRegistrationAsync</summary>
        public async Task CreatePredictionApiKeyRegistrationResourceNamesAsync()
        {
            // Snippet: CreatePredictionApiKeyRegistrationAsync(EventStoreName, PredictionApiKeyRegistration, CallSettings)
            // Additional: CreatePredictionApiKeyRegistrationAsync(EventStoreName, PredictionApiKeyRegistration, CancellationToken)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = await PredictionApiKeyRegistryClient.CreateAsync();
            // Initialize request argument(s)
            EventStoreName parent = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]");
            PredictionApiKeyRegistration predictionApiKeyRegistration = new PredictionApiKeyRegistration();
            // Make the request
            PredictionApiKeyRegistration response = await predictionApiKeyRegistryClient.CreatePredictionApiKeyRegistrationAsync(parent, predictionApiKeyRegistration);
            // End snippet
        }

        /// <summary>Snippet for ListPredictionApiKeyRegistrations</summary>
        public void ListPredictionApiKeyRegistrationsRequestObject()
        {
            // Snippet: ListPredictionApiKeyRegistrations(ListPredictionApiKeyRegistrationsRequest, CallSettings)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = PredictionApiKeyRegistryClient.Create();
            // Initialize request argument(s)
            ListPredictionApiKeyRegistrationsRequest request = new ListPredictionApiKeyRegistrationsRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
            };
            // Make the request
            PagedEnumerable<ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration> response = predictionApiKeyRegistryClient.ListPredictionApiKeyRegistrations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PredictionApiKeyRegistration item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPredictionApiKeyRegistrationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PredictionApiKeyRegistration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PredictionApiKeyRegistration> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PredictionApiKeyRegistration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPredictionApiKeyRegistrationsAsync</summary>
        public async Task ListPredictionApiKeyRegistrationsRequestObjectAsync()
        {
            // Snippet: ListPredictionApiKeyRegistrationsAsync(ListPredictionApiKeyRegistrationsRequest, CallSettings)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = await PredictionApiKeyRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListPredictionApiKeyRegistrationsRequest request = new ListPredictionApiKeyRegistrationsRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration> response = predictionApiKeyRegistryClient.ListPredictionApiKeyRegistrationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PredictionApiKeyRegistration item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPredictionApiKeyRegistrationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PredictionApiKeyRegistration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PredictionApiKeyRegistration> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PredictionApiKeyRegistration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPredictionApiKeyRegistrations</summary>
        public void ListPredictionApiKeyRegistrations()
        {
            // Snippet: ListPredictionApiKeyRegistrations(string, string, int?, CallSettings)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = PredictionApiKeyRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            // Make the request
            PagedEnumerable<ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration> response = predictionApiKeyRegistryClient.ListPredictionApiKeyRegistrations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PredictionApiKeyRegistration item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPredictionApiKeyRegistrationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PredictionApiKeyRegistration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PredictionApiKeyRegistration> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PredictionApiKeyRegistration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPredictionApiKeyRegistrationsAsync</summary>
        public async Task ListPredictionApiKeyRegistrationsAsync()
        {
            // Snippet: ListPredictionApiKeyRegistrationsAsync(string, string, int?, CallSettings)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = await PredictionApiKeyRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            // Make the request
            PagedAsyncEnumerable<ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration> response = predictionApiKeyRegistryClient.ListPredictionApiKeyRegistrationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PredictionApiKeyRegistration item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPredictionApiKeyRegistrationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PredictionApiKeyRegistration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PredictionApiKeyRegistration> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PredictionApiKeyRegistration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPredictionApiKeyRegistrations</summary>
        public void ListPredictionApiKeyRegistrationsResourceNames()
        {
            // Snippet: ListPredictionApiKeyRegistrations(EventStoreName, string, int?, CallSettings)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = PredictionApiKeyRegistryClient.Create();
            // Initialize request argument(s)
            EventStoreName parent = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]");
            // Make the request
            PagedEnumerable<ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration> response = predictionApiKeyRegistryClient.ListPredictionApiKeyRegistrations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PredictionApiKeyRegistration item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPredictionApiKeyRegistrationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PredictionApiKeyRegistration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PredictionApiKeyRegistration> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PredictionApiKeyRegistration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPredictionApiKeyRegistrationsAsync</summary>
        public async Task ListPredictionApiKeyRegistrationsResourceNamesAsync()
        {
            // Snippet: ListPredictionApiKeyRegistrationsAsync(EventStoreName, string, int?, CallSettings)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = await PredictionApiKeyRegistryClient.CreateAsync();
            // Initialize request argument(s)
            EventStoreName parent = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]");
            // Make the request
            PagedAsyncEnumerable<ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration> response = predictionApiKeyRegistryClient.ListPredictionApiKeyRegistrationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PredictionApiKeyRegistration item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPredictionApiKeyRegistrationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PredictionApiKeyRegistration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PredictionApiKeyRegistration> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PredictionApiKeyRegistration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeletePredictionApiKeyRegistration</summary>
        public void DeletePredictionApiKeyRegistrationRequestObject()
        {
            // Snippet: DeletePredictionApiKeyRegistration(DeletePredictionApiKeyRegistrationRequest, CallSettings)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = PredictionApiKeyRegistryClient.Create();
            // Initialize request argument(s)
            DeletePredictionApiKeyRegistrationRequest request = new DeletePredictionApiKeyRegistrationRequest
            {
                PredictionApiKeyRegistrationName = PredictionApiKeyRegistrationName.FromProjectLocationCatalogEventStorePredictionApiKeyRegistration("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]", "[PREDICTION_API_KEY_REGISTRATION]"),
            };
            // Make the request
            predictionApiKeyRegistryClient.DeletePredictionApiKeyRegistration(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePredictionApiKeyRegistrationAsync</summary>
        public async Task DeletePredictionApiKeyRegistrationRequestObjectAsync()
        {
            // Snippet: DeletePredictionApiKeyRegistrationAsync(DeletePredictionApiKeyRegistrationRequest, CallSettings)
            // Additional: DeletePredictionApiKeyRegistrationAsync(DeletePredictionApiKeyRegistrationRequest, CancellationToken)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = await PredictionApiKeyRegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeletePredictionApiKeyRegistrationRequest request = new DeletePredictionApiKeyRegistrationRequest
            {
                PredictionApiKeyRegistrationName = PredictionApiKeyRegistrationName.FromProjectLocationCatalogEventStorePredictionApiKeyRegistration("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]", "[PREDICTION_API_KEY_REGISTRATION]"),
            };
            // Make the request
            await predictionApiKeyRegistryClient.DeletePredictionApiKeyRegistrationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePredictionApiKeyRegistration</summary>
        public void DeletePredictionApiKeyRegistration()
        {
            // Snippet: DeletePredictionApiKeyRegistration(string, CallSettings)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = PredictionApiKeyRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]/predictionApiKeyRegistrations/[PREDICTION_API_KEY_REGISTRATION]";
            // Make the request
            predictionApiKeyRegistryClient.DeletePredictionApiKeyRegistration(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePredictionApiKeyRegistrationAsync</summary>
        public async Task DeletePredictionApiKeyRegistrationAsync()
        {
            // Snippet: DeletePredictionApiKeyRegistrationAsync(string, CallSettings)
            // Additional: DeletePredictionApiKeyRegistrationAsync(string, CancellationToken)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = await PredictionApiKeyRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]/predictionApiKeyRegistrations/[PREDICTION_API_KEY_REGISTRATION]";
            // Make the request
            await predictionApiKeyRegistryClient.DeletePredictionApiKeyRegistrationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePredictionApiKeyRegistration</summary>
        public void DeletePredictionApiKeyRegistrationResourceNames()
        {
            // Snippet: DeletePredictionApiKeyRegistration(PredictionApiKeyRegistrationName, CallSettings)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = PredictionApiKeyRegistryClient.Create();
            // Initialize request argument(s)
            PredictionApiKeyRegistrationName name = PredictionApiKeyRegistrationName.FromProjectLocationCatalogEventStorePredictionApiKeyRegistration("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]", "[PREDICTION_API_KEY_REGISTRATION]");
            // Make the request
            predictionApiKeyRegistryClient.DeletePredictionApiKeyRegistration(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePredictionApiKeyRegistrationAsync</summary>
        public async Task DeletePredictionApiKeyRegistrationResourceNamesAsync()
        {
            // Snippet: DeletePredictionApiKeyRegistrationAsync(PredictionApiKeyRegistrationName, CallSettings)
            // Additional: DeletePredictionApiKeyRegistrationAsync(PredictionApiKeyRegistrationName, CancellationToken)
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = await PredictionApiKeyRegistryClient.CreateAsync();
            // Initialize request argument(s)
            PredictionApiKeyRegistrationName name = PredictionApiKeyRegistrationName.FromProjectLocationCatalogEventStorePredictionApiKeyRegistration("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]", "[PREDICTION_API_KEY_REGISTRATION]");
            // Make the request
            await predictionApiKeyRegistryClient.DeletePredictionApiKeyRegistrationAsync(name);
            // End snippet
        }
    }
}
